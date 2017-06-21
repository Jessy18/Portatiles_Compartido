Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo


Public Class FrmRemision

    Dim DrEmpresa As DataRow
    Dim DrNumeros As DataRow
    Dim DtDetalle As DataTable

#Region "LOAD, LIMPIADOR Y CARGA DE DATOS DE LA TABLA"

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Dispose()
        Me.Close()
    End Sub

    Private Sub FrmRemision_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        On Error GoTo ErrException

        DrEmpresa = BusquedaSeleccionFila("Select * From Empresa")

        Me.LimpiarFormulario(0)

        LueSucEntrada.Properties.DataSource = BusquedaSeleccion("Sucursales_GLUE '" & Str(IdEmpresa) & "'")
        LueSucEntrada.Properties.ValueMember = "IdSucursal"
        LueSucEntrada.Properties.DisplayMember = "Sucursal"
        LueSucEntrada.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        LueSucEntrada.Properties.PopulateColumns()
        LueSucEntrada.Properties.Columns(0).Visible = False

        LueSucSalida.Properties.DataSource = BusquedaSeleccion("Sucursales_GLUE '" & Str(IdEmpresa) & "'")
        LueSucSalida.Properties.ValueMember = "IdSucursal"
        LueSucSalida.Properties.DisplayMember = "Sucursal"
        LueSucSalida.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        LueSucSalida.Properties.PopulateColumns()
        LueSucSalida.EditValue = CodSucursal
        LueSucSalida.Properties.Columns(0).Visible = False

        gLueUserAutoriza.Properties.DataSource = BusquedaSeleccion("Usuarios_GLUE")
        gLueUserAutoriza.Properties.DisplayMember = "Usuario"
        gLueUserAutoriza.Properties.ValueMember = "IdUsuario"
        gLueUserAutoriza.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        gLueUserAutoriza.Properties.PopulateViewColumns()
        gvLueUserAutoriza.Columns(0).Visible = False

        CrearTabla()
        DrNumeros = BusquedaSeleccionFila("select * From Remisiones_ObtieneNum('" & LueSucSalida.EditValue.ToString & "')")
        txtNumRemision.Text = DrNumeros!NumRemision.ToString
        txtNumSucRemision.Text = DrNumeros!NumRemisionSuc.ToString
        DteFecha.DateTime = Now

        Exit Sub
ErrException:
        XtraMessageBox.Show(Err.Description, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

    Private Sub LueSucEntrada_EditValueChanged(sender As Object, e As EventArgs) Handles LueSucEntrada.EditValueChanged
        gLueUserRecibe.EditValue = Nothing
        If Not String.IsNullOrEmpty(LueSucEntrada.EditValue) Then
            gLueUserRecibe.Properties.DataSource = BusquedaSeleccion("Usuarios_GLUE '" & LueSucEntrada.EditValue.ToString & "'")
            gLueUserRecibe.Properties.ValueMember = "IdUsuario"
            gLueUserRecibe.Properties.DisplayMember = "Usuario"
            gLueUserRecibe.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
            gLueUserRecibe.Properties.PopulateViewColumns()
            gvLueUserRecibe.Columns(0).Visible = False
        End If
    End Sub

    ''' <summary>
    ''' Función que limpia los campos del formulario
    ''' </summary>
    ''' <param name="QueLimpia"> 0: Limpia Todo, 1: Limpia la Sección de Productos
    ''' Otro número: Limpia Todo</param>
    ''' <param name="LimpiaCodProducto">En caso de que limpiea la sección de productos,
    ''' especificar si limpia también el Código de Producto</param>
    Private Sub LimpiarFormulario(ByVal QueLimpia As Integer, Optional ByVal LimpiaCodProducto As Boolean = True)
        If QueLimpia = 0 Then 'va a limpiar todo
            Me.txtNumRemision.Text = ""
            Me.txtNumSucRemision.Text = ""
            DteFecha.DateTime = Now
            LueSucEntrada.EditValue = Nothing
            LueSucSalida.EditValue = Nothing
            gLueUserAutoriza.EditValue = Nothing
            gLueUserRecibe.EditValue = Nothing
            txtCodProducto.Text = ""
            txtProducto.Text = ""
            txtCantidad.Text = "1"
            TxtExistencias.Text = "0"
        Else 'Solo la seccion de productos
            If LimpiaCodProducto Then txtCodProducto.Text = ""
            txtProducto.Text = ""
            txtCantidad.Text = "1"
            TxtExistencias.Text = "0"
        End If
    End Sub

    Private Sub CrearTabla()
        On Error GoTo tipoerr
        DtDetalle = New DataTable
        With DtDetalle
            .Columns.Add("IdProducto", GetType(String))
            .Columns.Add("Producto", GetType(String))
            .Columns.Add("Cantidad", GetType(Double))
            .Columns.Add("Existencia", GetType(Double))
        End With
        gcRemisiones.DataSource = DtDetalle

        For Each DCDetalle As GridColumn In gvRemisiones.Columns
            gvRemisiones.Columns(DCDetalle.FieldName).OptionsColumn.AllowEdit = False
            If DCDetalle.FieldName = "Cantidad" Then
                gvRemisiones.Columns(DCDetalle.FieldName).OptionsColumn.AllowEdit = True
            Else
                gvRemisiones.Columns(DCDetalle.FieldName).OptionsColumn.AllowEdit = False
            End If
        Next

        DtDetalle.Rows.Add({"1", "Ariel", 2, 5})
        DtDetalle.Rows.Add({"2", "Davila", 3, 5})

        Exit Sub
tipoerr:
        MsgBox(Err.Description, MsgBoxStyle.Critical)
    End Sub

#End Region

#Region "EVENTOS DE LA SECCION DE PRODUCTOS"

    Private Sub btnBuscarProd_Click(sender As Object, e As EventArgs) Handles btnBuscarProd.Click
        On Error GoTo ErrException
        If LueSucSalida.Text = "" Then
            XtraMessageBox.Show("Primero Seleccione la Sucursal de Salida para validar existencias", "Sucursal de Salida", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ClaveBusqueda = "Productos"
        FrmBusqueda.ShowDialog()
        If Not CodigoGenerico.Trim = "" Then
            txtCodProducto.Text = CodigoGenerico
            CargarDatosProducto()
            Exit Sub
        End If
        Exit Sub
ErrException:
        XtraMessageBox.Show(Err.Description, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

    Private Sub CargarDatosProducto()
        On Error GoTo tipoerr
        txtProducto.Text = ""
        TxtExistencias.Text = "0"

        If LueSucSalida.Text = "" Then
            XtraMessageBox.Show("Primero Seleccione la Sucursal de Salida para validar existencias", "Sucursal de Salida", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If


        If txtCodProducto.Text.Trim = "" Then Exit Sub
        Dim DrProducto As DataRow = BusquedaSeleccionFila(String.Format("Select * from Productos Where IdProducto={0}", txtCodProducto.Text.Trim))
        If Not DrProducto Is Nothing Then
            txtProducto.Text = DrProducto!Producto.ToString
            TxtExistencias.Text = "0"
            txtCantidad.Focus()
        End If
        Exit Sub
tipoerr:
        XtraMessageBox.Show(Err.Description, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

    Private Sub txtCodProducto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCodProducto.KeyPress
        If Asc(e.KeyChar) = 13 Then
            CargarDatosProducto()
        End If
    End Sub

    Private Sub txtCantidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCantidad.KeyPress
        ValidarNumeroEntero(txtCantidad.Text, e)
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        On Error GoTo ErrException

        If txtCodProducto.Text.Trim = "" Then
            XtraMessageBox.Show("Ingrese un Código de Producto!", "Datos Vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If txtProducto.Text.Trim = "" Then
            XtraMessageBox.Show("El código del producto ingresado no existe!", "Producto no existe", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        For Each drFila As DataRow In DtDetalle.Rows
            If txtCodProducto.Text.Trim = drFila!IdProducto.ToString Then
                drFila.BeginEdit()
                drFila!Cantidad += Val(txtCantidad.Text)
                drFila.EndEdit()
                drFila.AcceptChanges()

                SumaTotales()

                txtCodProducto.Text = ""
                txtProducto.Text = ""
                TxtExistencias.Text = "0"
                txtCantidad.Text = "1"
                txtCodProducto.Focus()
                Exit Sub
            End If
        Next

        'Agregamos el producto al Grid
        DtDetalle.Rows.Add({txtCodProducto.Text.Trim, txtProducto.Text, CDbl(txtCantidad.Text), CDbl(TxtExistencias.Text)})
        SumaTotales()

        txtCodProducto.Text = ""
        txtProducto.Text = ""
        TxtExistencias.Text = "0"
        txtCantidad.Text = "1"
        txtCodProducto.Focus()

        Exit Sub
ErrException:
        XtraMessageBox.Show(Err.Description, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

    Private Sub SumaTotales()
        On Error GoTo ErrException
        Dim TotalCant As Double = 0

        For Each drFila As DataRow In DtDetalle.Rows
            TotalCant += CDbl(drFila!Cantidad.ToString())
        Next

        txtTotalCant.Text = Str(TotalCant)
        txtTotalProductos.Text = DtDetalle.Rows.Count.ToString()

        Exit Sub
ErrException:
        XtraMessageBox.Show(Err.Description, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub


    Private Sub gvRemisiones_CellValueChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles gvRemisiones.CellValueChanged
        On Error GoTo ErrException
        If e.Column.FieldName = "Cantidad" Then
            SumaTotales()
        End If
        Exit Sub
ErrException:
        XtraMessageBox.Show("Error Nº" & Err.Number & ": " & Environment.NewLine & Err.Description, "Ha ocurrido un error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

    Private Sub BarManager1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarManager1.ItemClick
        BarManager1.PopupShowMode = DevExpress.XtraBars.PopupShowMode.Classic
        If e.Item.Caption = "Eliminar Fila Seleccionada" Then
            EliminarFilaActual(gvRemisiones, DtDetalle)
            SumaTotales()
        ElseIf e.Item.Caption = "Actualizar Totales" Then
            SumaTotales()
        End If
    End Sub

    Private Sub gvRemisiones_MouseDown(sender As Object, e As MouseEventArgs) Handles gvRemisiones.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Right Then
            Dim view As GridView = sender
            Dim hitInfo As GridHitInfo = view.CalcHitInfo(e.Location)
            If hitInfo.InRowCell Then
                PopupMenu1.ShowPopup(BarManager1, view.GridControl.PointToScreen(e.Location))
            End If
        End If
    End Sub

#End Region

#Region "GUARDADO DE DATOS"

    Private Function ValidarDatos() As Boolean
        Dim CadenaError As String = ""
        DxErrProv.ClearErrors()
        If IsNothing(LueSucEntrada.EditValue) Then
            DxErrProv.SetError(LueSucEntrada, "Seleccione una Sucursal de Entrada", DXErrorProvider.ErrorType.Critical)
            CadenaError += "->  Debe seleccionar la Sucursal de Entrada de Productos" & vbNewLine
        End If

        If IsNothing(LueSucSalida.EditValue) Then
            DxErrProv.SetError(LueSucSalida, "Seleccione una Sucursal de Salida", DXErrorProvider.ErrorType.Critical)
            CadenaError += "->  Debe seleccionar la Sucursal de Salida de Productos" & vbNewLine
        End If

        If gvRemisiones.RowCount <= 0 Then
            CadenaError += "->  No ha agregado productos a la tabla!" & vbNewLine
        End If

        If IsNothing(gLueUserAutoriza.EditValue) Then
            DxErrProv.SetError(gLueUserAutoriza, "Debe seleccionar el Usuario que autoriza", DXErrorProvider.ErrorType.Critical)
            CadenaError += "->  Debe seleccionar el Usuario que autoriza" & vbNewLine
        End If

        If IsNothing(gLueUserRecibe.EditValue) Then
            DxErrProv.SetError(gLueUserRecibe, "Debe seleccionar el Usuario que recibe", DXErrorProvider.ErrorType.Critical)
            CadenaError += "->  Debe seleccionar el Usuario que recibe" & vbNewLine
        End If

        If CadenaError <> "" Then
            Dim MensajeError As String = "No se ha podido guardar debido a que: " & vbNewLine & vbNewLine & CadenaError
            XtraMessageBox.Show(MensajeError, "Validaciones", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        Else
            Return True
        End If
        
    End Function

    Private Function Guardar() As Boolean

        'la fecha del control  mas la hora actual
        FechaGuardar = CDate(DteFecha.DateTime.ToString("dd/MM/yyyy") & " " & Now.ToString("hh:mm:ss"))
        Try

            AbrirTransaccion()

            'se obtiene las numeraciones Actuales
            DrNumeros = BusquedaSeleccionFila("select * From Remisiones_ObtieneNum('" & LueSucSalida.EditValue.ToString & "')")

            'Se actualiza las numeraciones (+1)
            Comando.Parameters.Clear()
            Comando.CommandText = "Remisiones_ActualizaNum"
            Comando.CommandType = CommandType.StoredProcedure
            Comando.Parameters.AddWithValue("IdSucursalSalida", LueSucSalida.EditValue)
            Comando.ExecuteNonQuery()

            'Guardo el Maestro
            Comando.Parameters.Clear()
            Comando.CommandText = "Remisiones_Agregar"
            Comando.CommandType = CommandType.StoredProcedure
            With Comando.Parameters
                .AddWithValue("NumRemision", DrNumeros!NumRemision)
                .AddWithValue("IdSucursalSalida", LueSucSalida.EditValue.ToString)
                .AddWithValue("IdSucursalEntrada", LueSucEntrada.EditValue.ToString)
                .AddWithValue("IdUsuRemite", CodUsuario)
                .AddWithValue("IdUsuAutoriza", gLueUserAutoriza.EditValue)
                .AddWithValue("IdUsuRecibe", gLueUserRecibe.EditValue)
                .AddWithValue("NumRemisionSuc", DrNumeros!NumRemisionSuc)
                .AddWithValue("Fecha", FechaGuardar)
                .AddWithValue("Observaciones", TxtObservaciones.Text.Trim)
                .AddWithValue("Total", Val(txtCantidad.Text))
            End With
            Comando.ExecuteNonQuery()

            'Guardo el Detalle
            For Each item As DataRow In DtDetalle.Rows
                Comando.Parameters.Clear()
                Comando.CommandText = "Remisiones_Det_Agregar"
                Comando.CommandType = CommandType.StoredProcedure
                With Comando.Parameters
                    .AddWithValue("NumRemision", DrNumeros!NumRemision)
                    .AddWithValue("IdProducto", item!CodProducto)
                    .AddWithValue("Cantidad", item!Cantidad)
                    .AddWithValue("Costo", item!Costo)
                End With
                Comando.ExecuteNonQuery()
            Next

            CommitTransaccion()
        Catch ex As Exception
            RevertirTransaccion(ex.Message)
            Return False
        End Try

        'Actualizamos existencias por Sucursal
        For Each item As DataRow In DtDetalle.Rows
            'Sucursal de Entrada
            CrearComando("Productos_ActualizarExist")
            Comando.Parameters.AddWithValue("idProducto", item!IdProducto)
            Comando.Parameters.AddWithValue("idSucursal", LueSucEntrada.EditValue)
            EjecutarComando()

            'Sucursal de Salida
            CrearComando("Productos_ActualizarExist")
            Comando.Parameters.AddWithValue("idProducto", item!IdProducto)
            Comando.Parameters.AddWithValue("idSucursal", LueSucSalida.EditValue)
            EjecutarComando()
        Next

        HADatosNEW = "NumRemision: " & txtNumRemision.Text & " | " & _
                    "NumRemisionSucursal: " & txtNumSucRemision.Text & " | " & _
                    "SucursalSalida: " & LueSucSalida.EditValue.ToString & " " & LueSucSalida.Text & " | " & _
                    "SucursalEntrada: " & LueSucEntrada.EditValue.ToString & " " & LueSucEntrada.Text & " | " & _
                    "Fecha: " & FechaGuardar.ToLongDateString & " | " & _
                    "Observaciones: " & TxtObservaciones.Text & " | "

        GuardarHistorialAccion("Insertar", "Sucursales", txtNumRemision.Text, "", HADatosNEW)

        Return True
    End Function

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        On Error GoTo ErrException

        If Not ValidarDatos() Then Exit Sub

        If XtraMessageBox.Show("¿Desea Guardar la Remisión?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Information) <> Windows.Forms.DialogResult.Yes Then
            Exit Sub
        End If

        If Guardar() Then
            XtraMessageBox.Show("La Remisión se ha generado correctamente", "Operación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.FrmRemision_Load(sender, e)
        End If

        Exit Sub
ErrException:
        XtraMessageBox.Show(Err.Description, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

#End Region

End Class