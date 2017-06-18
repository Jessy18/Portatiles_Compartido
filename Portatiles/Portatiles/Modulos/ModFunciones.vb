Imports System.Windows.Forms
Imports DevExpress.XtraEditors

Module ModFunciones
    Public Function CodigoNuevo(ByVal Tabla As String, ByVal IdTabla As String, ByVal CantidadNumeros As Integer) As String
        On Error GoTo tipoerr

        Dim NuevoCod As String = ""
        Dim Formato As String = ""
        Dim DrFila As DataRow = BusquedaSeleccionFila("select MAX(" + IdTabla + ") as Id from " + Tabla)

        If CantidadNumeros = 0 Then
            Formato = "#####"
        Else
            For i = 1 To CantidadNumeros
                Formato += "0"
            Next
        End If

        If Not String.IsNullOrEmpty(DrFila("Id").ToString()) Then
            NuevoCod = Format(CDbl(DrFila("Id")) + 1, Formato)
        Else
            NuevoCod = Format(1, Formato)
        End If

        CodigoNuevo = NuevoCod
        Exit Function
tipoerr:
        MsgBox(Err.Description, MsgBoxStyle.Critical)
    End Function

    Public Function BuscarRegistroSql(ByVal NombreTabla As String, ByVal NombreCampoBuscar As String, ByVal IdTabla As String, ByVal ValorId As String) As String

        Dim DrFila As DataRow = BusquedaSeleccionFila("Select " & NombreCampoBuscar & " as CampoBuscado From " & NombreTabla & " Where " & IdTabla & " = '" & ValorId & "'")

        If Not IsNothing(DrFila) Then
            If Not IsDBNull(DrFila!CampoBuscado) Then
                BuscarRegistroSql = DrFila!CampoBuscado.ToString()
            Else
                BuscarRegistroSql = ""
            End If
        Else
            BuscarRegistroSql = ""
        End If
    End Function

    Public Function HayRegistrosAnidados(ByVal NombreTabla As String, ByVal IdRelacion As String, ByVal ValorId As String) As Boolean
        HayRegistrosAnidados = False
        If BusquedaSeleccion(String.Format("Select * from {0} Where {1}= '{2}'", NombreTabla, IdRelacion, ValorId)).Rows.Count > 0 Then
            HayRegistrosAnidados = True
        End If
        Return HayRegistrosAnidados
    End Function

    Public Sub ValidarNumeroEntero(ByVal Texto As String, ByVal Evento As System.Windows.Forms.KeyPressEventArgs)

        '/// Valida que solo se ingrese valores numéricos
        Select Case Asc(Evento.KeyChar)
            Case 8 'tecla BACK
            Case 13 'Tecla ENTER
            Case 48 To 57 ' del 1 al 9
            Case 127 ' Tecla DELETE
            Case Else
                Evento.Handled = True
        End Select
    End Sub

    Public Sub ValidarNumeroDecimal(ByVal Texto As String, ByVal Evento As System.Windows.Forms.KeyPressEventArgs)

        '/// Valida que solo se ingrese valores numéricos y un punto
        Select Case Asc(Evento.KeyChar)
            Case 8 'tecla BACK
            Case 13 'Tecla ENTER
            Case 46 'PUNTO
                If Texto.Contains(".") Then
                    Evento.Handled = True
                End If
            Case 48 To 57 ' del 1 al 9
            Case 127 ' Tecla DELETE
            Case Else
                Evento.Handled = True
        End Select
    End Sub

    Public Sub ValidarLetras(ByVal Texto As String, ByVal Evento As System.Windows.Forms.KeyPressEventArgs)

        '/// Valida que solo se ingrese letras
        Select Case Asc(Evento.KeyChar)
            Case 8 'tecla BACK
            Case 13 'Tecla ENTER
            Case 37 'Tecla ESPACIO            
            Case 127 ' Tecla DELETE
            Case Else
                If Not Char.IsLetter(Evento.KeyChar) Then
                    Evento.Handled = True
                End If

        End Select
    End Sub

    Public Sub CargarConfiguracion()
        On Error GoTo tipoerr

        Dim DRConfig As DataRow = BusquedaSeleccionFila("Select * from Empresa ")
        If Not DRConfig Is Nothing Then
            IdEmpresa = DRConfig!IdEmpresa
            Empresa = DRConfig!NombreEmpresa.ToString
            RazonSocial = DRConfig!RazonSocial.ToString
            RUCEmpresa = DRConfig!RUC.ToString
            DirEmpresa = DRConfig!Direccion.ToString
            TelEmpresa = DRConfig!Telefonos.ToString
            ChequeA = DRConfig!ChequeANombre.ToString
            IVA = CDbl(DRConfig!PorcIVA)
        End If
        Exit Sub
tipoerr:
        MsgBox(Err.Description, MsgBoxStyle.Critical)
    End Sub

    Public Function VerificarInicio() As Boolean
        VerificarInicio = True
        Dim DrDatosInicio As DataRow

        DrDatosInicio = BusquedaSeleccionFila("Select Top 1 * from Empresa")

        If DrDatosInicio Is Nothing Then
            VerificarInicio = False
        End If

        DrDatosInicio = BusquedaSeleccionFila("Select Top 1 * from Sucursales")
        If DrDatosInicio Is Nothing Then
            VerificarInicio = False
        End If

        DrDatosInicio = BusquedaSeleccionFila("Select Top 1 * from Usuarios")
        If DrDatosInicio Is Nothing Then
            VerificarInicio = False
        End If

    End Function

    Public Sub InicializarTablaSeleccionados()
        DtSeleccion = New DataTable
        DtSeleccion.Columns.Add("Codigo", GetType(String))
    End Sub

    ''' <summary>
    ''' Crea el historial de las acciones, antes de ser modificadas
    ''' </summary>
    ''' <param name="row"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function CrearHADatosOLD(ByVal row As DataRow) As String
        Dim Devolver As String = ""
        If IsNothing(row) Then Return ""

        For i = 0 To row.Table.Columns.Count - 1
            If Not IsDBNull(row(i)) Then
                Devolver += row.Table.Columns(i).ColumnName & ": " & row(i).ToString()
            Else
                Devolver += row.Table.Columns(i).ColumnName & ": NULL"
            End If

            If i < row.Table.Columns.Count - 1 Then
                Devolver += " | "
            End If

        Next
        Return Devolver
    End Function

    Public Sub GuardarHistorialAccion(ByVal TipoAccion As String, ByVal Modulo As String, ByVal NumDoc As String, ByVal DatosOLD As String, ByVal DatosNEW As String)
        Dim sql As String
        sql = "INSERT INTO HistorialAcciones (Fecha, IdUsuario, Modulo, Accion, NumDoc, DatosOLD, DatosNEW) VALUES (@Fecha,@IdUsuario,@Modulo,@Accion,@NumDoc,@DatosOLD,@DatosNEW)"
        CrearComando(sql)
        With Comando.Parameters
            .AddWithValue("Fecha", Now)
            .AddWithValue("IdUsuario", CodUsuario)
            .AddWithValue("Modulo", Modulo)
            .AddWithValue("Accion", TipoAccion)
            .AddWithValue("NumDoc", NumDoc)
            .AddWithValue("DatosOLD", DatosOLD)
            .AddWithValue("DatosNEW", DatosNEW)
        End With
        EjecutarComando()
    End Sub



    Public Function VerificarExistencias(ByVal IdProducto As String, Optional IdSuc As String = "") As Double
        Dim DrRegistros As DataRow
        Dim Compras As Double = 0
        Dim Remisiones As Double = 0
        Dim Ventas As Double = 0
        Dim Ajustes As Double = 0

        VerificarExistencias = 0

        If CBool(BuscarRegistroSql("Productos", "Servicio", "IdProducto", IdProducto)) = False Then

            ' ''Movimientos de compras
            ''DrRegistros = BusquedaSeleccionFila(String.Format("Select SUM(Cantidad) as Cantidad from DetalleCompra INNER JOIN Compras on DetalleCompra.NumCompra=Compras.NumCompra Where IdProducto='{0}'", IdProducto) & IIf(IdSuc = "", "", String.Format(" AND IdSucursal='{0}'", IdSuc)))
            ''If Not DrRegistros Is Nothing Then Compras = CDbl(DrRegistros!Cantidad)
            ' ''Movimientos de ajustes
            ''DrRegistros = BusquedaSeleccionFila(String.Format("Select SUM(Cantidad) as Cantidad from DetalleAjuste INNER JOIN  Ajustes on DetalleAjuste.NumAjuste=Ajustes.NumAjuste  Where IdProducto='{0}' ", IdProducto) & IIf(IdSuc = "", "", String.Format(" AND IdSucursal='{0}'", IdSuc)))
            ''If Not DrRegistros Is Nothing Then Ajustes = CDbl(DrRegistros!Cantidad)
        End If
        Return VerificarExistencias
    End Function

  Public Function PuedeAcceder(ByVal Modulo As String, ByVal Formulario As String) As Boolean
        Dim dtAcceso As DataTable
        dtAcceso = BusquedaSeleccion("Select * From ModuleUserAccess Where idUsuario = '" & CodUsuario & "' AND Modulo = '" & Modulo & "' AND Formulario = '" & Formulario & "'")
        If dtAcceso.Rows.Count > 0 Then
            If CBool(dtAcceso.Rows(0)("Acceso")) Then
                PuedeAcceder = True
            Else
                PuedeAcceder = False
            End If
        Else
            PuedeAcceder = False
        End If

        If Not PuedeAcceder Then
            DevExpress.XtraEditors.XtraMessageBox.Show("No tiene permiso para acceder a este módulo", "Acceso Denegado", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Function

    Public Sub EliminarFilaActual(ByVal ViewToModify As DevExpress.XtraGrid.Views.Grid.GridView, ByVal DtSourceGridView As DataTable)
        If ViewToModify.RowCount <= 0 Then
            XtraMessageBox.Show("La tabla actual no posee registros para eliminar", "No hay Registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        Dim pos As Integer
        pos = ViewToModify.FocusedRowHandle
        DtSourceGridView.Rows.RemoveAt(pos)
        DtSourceGridView.AcceptChanges()

    End Sub

End Module
