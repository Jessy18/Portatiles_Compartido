﻿Imports DevExpress.XtraEditors

Public Class Kardex
    Dim Dtgeneral As DataTable
    Private Sub FrmListado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DteFechaIni.DateTime = Now
        DteFechaFin.DateTime = Now
        CargarDatosLue()
        BuscarSaldoInicial()
        'BuscarRegistros()
        CrearDatatable()
        gcAjustes.DataSource = Dtgeneral
    End Sub
    Private Sub CrearDatatable()
        Dtgeneral = New DataTable

        Dtgeneral.Columns.Add("Movimiento", GetType(String))
        Dtgeneral.Columns.Add("NoDocumento", GetType(String))
        Dtgeneral.Columns.Add("Cantidad", GetType(Double))
        Dtgeneral.Columns.Add("Fecha", GetType(Date))
        Dtgeneral.Columns.Add("Costo", GetType(Double))

    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        BuscarRegistros()
        BuscarSaldoInicial()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Dispose()
        Me.Close()
    End Sub
    Private Sub CargarDatosLue()

        lueProducto.Properties.DataSource = BusquedaSeleccion("Select IdProducto, Producto from Productos Where Activo=1 ")
        lueProducto.Properties.ValueMember = "IdProducto"
        lueProducto.Properties.DisplayMember = "Producto"

        If Not Administrador Then
            lueProducto.Properties.ReadOnly = True
            lueProducto.EditValue = CodSucursal
        End If
    End Sub

    Private Sub BuscarRegistros()
        On Error GoTo tipoerr
        Dim NombreCampo As String = ""
        'Aqui se establece la consulta maestra
        Select Case MovimientoListado
            Case "Ajustes"
                GenericSql = "Select Ajustes.NumAjuste, Ajustes.Fecha, Sucursales.Sucursal, TipoAjuste.TipoAjuste, Ajustes.Subtotal, Ajustes.Observaciones, Ajustes.Anulado from Ajustes INNER JOIN Sucursales on Sucursales.IdSucursal=Ajustes.IdSucursal INNER JOIN TipoAjuste ON TipoAjuste.IdTipo=Ajustes.IdTipo Where Ajustes.NumAjuste > 0 "
            Case "Compras"
                GenericSql = "Select Compras.NumCompra, Compras.Fecha, Sucursales.Sucursal, Proveedores.Proveedor, Compras.NumDocCompra, Compras.Subtotal+Compras.IVA as Total, Compras.Observaciones, Compras.Anulada from Compras INNER JOIN Sucursales ON Compras.IdSucursal=Sucursales.IdSucursal INNER JOIN Proveedores ON Proveedores.IdProveedor=Compras.IdProveedor Where Compras.NumCompra>0 "
            Case "Ventas"
                GenericSql = "Select Ventas.NumVenta, Ventas.Fecha, Sucursales.Sucursal, DatosEntidad.Nombres+ ' ' + DatosEntidad.Apellidos as Cliente, Ventas.NumDocFactura, Ventas.Subtotal-Ventas.Descuento + Ventas.IVA as Total, Ventas.Observaciones, Ventas.Anulada from Ventas INNER JOIN Sucursales on Ventas.IdSucursal=Sucursales.IdSucursal INNER JOIN Clientes ON Ventas.IdCliente=Clientes.IdCliente INNER JOIN DatosEntidad on Clientes.IdDatos=DatosEntidad.IdDatos Where Ventas.NumVenta>0 "
            Case "Remisiones"
                GenericSql = "Select Remisiones.NumRemision, Remisiones.Fecha, S1.Sucursal as SucursalSalida, S2.Sucursal as SucursalEntrada, U1.Nombre as Remite, U2.Nombre as Autoriza, U3.Nombre as Recibe, Remisiones.NumDocRemision, Remisiones.Observaciones, Remisiones.Anulada From Remisiones INNER JOIN Sucursales AS S1 ON Remisiones.IdSucursalSalida=S1.IdSucursal INNER JOIN Sucursales AS S2 ON Remisiones.IdSucursalEntrada=S2.IdSucursal INNER JOIN Usuarios AS U1 ON Remisiones.IdUsuRemite=U1.IDUsuario INNER JOIN Usuarios AS U2 ON Remisiones.IdUsuAutoriza=U2.IDUsuario INNER JOIN Usuarios AS U3 ON Remisiones.IdUsuRecibe=U3.IDUsuario Where Remisiones.NumRemision > 0 "
        End Select

        'Luego se van agregando las condiciones de filtro
        If ChkFiltroFechas.Checked Then
            GenericSql += String.Format(" AND {0}.Fecha between CONVERT(DATETIME, '{1}',102) AND CONVERT(DATETIME,'{2} 23:59:59',102)", MovimientoListado, Format(DteFechaIni.DateTime, "yyyy/MM/dd"), Format(DteFechaFin.DateTime, "yyyy/MM/dd"))
        End If

        If lueProducto.EditValue.ToString.Trim <> "" Then
            If MovimientoListado = "Remisiones" Then
                GenericSql += String.Format(" AND {0}.IdSucursalSalida='{1}' ", MovimientoListado, lueProducto.EditValue.ToString)
            Else
                GenericSql += String.Format(" AND {0}.IdSucursal='{1}' ", MovimientoListado, lueProducto.EditValue.ToString)
            End If
        End If

        If txtExistencia.Text.Trim <> "" Then
            Select Case MovimientoListado
                Case "Ajustes"
                    NombreCampo = MovimientoListado & ".NumAjuste"
                Case "Remisiones"
                    NombreCampo = MovimientoListado & ".NumRemision"
                Case "Ventas"
                    NombreCampo = MovimientoListado & ".NumVenta"
                Case "Compras"
                    NombreCampo = MovimientoListado & ".NumCompra"
            End Select
            GenericSql += String.Format(" AND {0}={1}", NombreCampo, txtExistencia.Text)
            NombreCampo = ""
        End If
        'If txtDocSucursal.Text.Trim <> "" Then
        Select Case MovimientoListado
            Case "Ajustes"
                NombreCampo = MovimientoListado & ".NumDocAjuste"
            Case " Remisiones"
                NombreCampo = MovimientoListado & ".NumDocRemision"
            Case "Ventas"
                NombreCampo = MovimientoListado & ".NumDocFactura"
            Case "Compras"
                NombreCampo = MovimientoListado & ".NumDocCompra"
        End Select

        NombreCampo = ""
 
        gcAjustes.DataSource = BusquedaSeleccion(GenericSql)
        Exit Sub
tipoerr:
        MsgBox(Err.Description, MsgBoxStyle.Critical)
    End Sub
    Private Sub BuscarSaldoInicial()
        Dim DrAjuste, DrRemisiones, DrVentas, DrCompras As DataTable
        Dim TotalAjustes, TotalRemision, TotalCompra, TotalVenta As Double
        Dim CantAjuste, CantRemision, CantVenta, CantCompra As Double

        DrAjuste = BusquedaSeleccion("SELECT   dbo.TipoAjuste.Valor, dbo.DetalleAjuste.NumAjuste, dbo.DetalleAjuste.Cantidad, dbo.Ajustes.Fecha, dbo.Productos.Producto FROM   dbo.Ajustes INNER JOIN   dbo.DetalleAjuste ON dbo.Ajustes.NumAjuste = dbo.DetalleAjuste.NumAjuste INNER JOIN dbo.TipoAjuste ON dbo.Ajustes.IdTipo = dbo.TipoAjuste.IdTipo INNER JOIN  dbo.Productos ON dbo.DetalleAjuste.IdProducto = dbo.Productos.IdProducto WHere Ajustes.Fecha<(Convert(datetime,'" & Format(DteFechaIni.DateTime) & "')) And Ajustes.Anulado=0 And Productos.IdProducto='" & lueProducto.EditValue & "'")
        For Each Dr As DataRow In DrAjuste.Rows
            CantAjuste = 0
            CantAjuste = CDbl(Dr!Valor) * CDbl(Dr!Cantidad)
            TotalAjustes = TotalAjustes + CantAjuste
        Next

        DrVentas = BusquedaSeleccion("SELECT  dbo.DetalleVenta.NumVenta, dbo.DetalleVenta.Cantidad, dbo.Ventas.Fecha, dbo.Productos.Producto FROM   dbo.Ventas INNER JOIN   dbo.DetalleVenta ON dbo.Ventas.NumVenta = dbo.DetalleVenta.NumVenta  INNER JOIN  dbo.Productos ON dbo.DetalleVenta.IdProducto = dbo.Productos.IdProducto WHere Ventas.Fecha<(Convert(datetime,'" & Format(DteFechaIni.DateTime) & "')) And Ventas.Anulada=0 And Productos.IdProducto='" & lueProducto.EditValue & "'")
        For Each Dr As DataRow In DrVentas.Rows
            CantVenta = 0
            CantVenta = CDbl(Dr!Cantidad)
            TotalVenta = TotalVenta + CantVenta
        Next

        DrCompras = BusquedaSeleccion("SELECT  dbo.DetalleCompra.NumCompra, dbo.DetalleCompra.Cantidad, dbo.Compras.Fecha, dbo.Productos.Producto FROM   dbo.Ventas INNER JOIN   dbo.DetalleVenta ON dbo.Ventas.NumVenta = dbo.DetalleVenta.NumVenta  INNER JOIN  dbo.Productos ON dbo.DetalleVenta.IdProducto = dbo.Productos.IdProducto WHere Ventas.Fecha<(Convert(datetime,'" & Format(DteFechaIni.DateTime) & "')) And Ventas.Anulada=0 And Productos.IdProducto='" & lueProducto.EditValue & "'")
        For Each Dr As DataRow In DrCompras.Rows
            CantVenta = 0
            CantVenta = CDbl(Dr!Cantidad)
            TotalVenta = TotalVenta + CantVenta
        Next

    End Sub
    Private Function PuedeAccionar() As Boolean
        On Error GoTo tipoerr

        Dim Anulado As Boolean = False
        Dim Cerrado As Boolean = False
        Dim Condicion As String = ""
        'si el documento está anulado no puede editarlo ni anularlo
        'Si el documento está cerrado no puede editarlo
        PuedeAccionar = True
        Select Case MovimientoListado
            Case "Ajustes"
                If NumAjuste.Trim = "" Then Return False
                Condicion = String.Format("NumAjuste='{0}'", NumAjuste)
            Case "Compras"
                If NumCompra.Trim = "" Then Return False
                Condicion = String.Format("NumCompra='{0}'", NumCompra)
            Case "Remisiones"
                If NumRemision.Trim = "" Then Return False
                Condicion = String.Format("NumRemision='{0}'", NumRemision)
            Case "Ventas"
                If NumVenta.Trim = "" Then Return False
                Condicion = String.Format("NumVenta='{0}'", NumVenta)
        End Select
        Dim DrMovim As DataRow = BusquedaSeleccionFila(String.Format("Select * from {0} Where {1}", MovimientoListado, Condicion))
        If Not DrMovim Is Nothing Then
            If MovimientoListado = "Ajustes" Then
                Anulado = CBool(DrMovim!Anulado)
            Else
                Anulado = CBool(DrMovim!Anulada)
            End If
            'Anulado = CBool(IIf(MovimientoListado = "Ajustes", DrMovim!Anulado, DrMovim!Anulada))
            If MovimientoListado <> "Ventas" Then
                Cerrado = Not CBool(DrMovim!Editar)
            End If


        End If
        If Anulado Then
            XtraMessageBox.Show("El registro está anulado.", "Validar operación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            PuedeAccionar = False
            Exit Function
        End If
        If Cerrado Then
            XtraMessageBox.Show("La edición del registro ya ha sido cerrada.", "Validar operación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            PuedeAccionar = False
            Exit Function
        End If

        Return PuedeAccionar
        Exit Function
tipoerr:
        MsgBox(Err.Description, MsgBoxStyle.Critical)
    End Function

    Private Sub BtnBuscarLue1_Click(sender As Object, e As EventArgs)
        On Error GoTo tipoerr
        Select Case MovimientoListado
            Case "Ajustes"
                ClaveBusqueda = "TipoAjuste"
            Case "Compras"
                ClaveBusqueda = "Proveedores"
            Case "Remisiones"
                ClaveBusqueda = "Sucursales"
            Case "Ventas"
                ClaveBusqueda = "Clientes"
        End Select

        FrmBusqueda.ShowDialog()
        If Not CodigoGenerico.Trim = "" Then
            'Lue1.EditValue = (CodigoGenerico)
        End If
        Exit Sub
tipoerr:
        MsgBox(Err.Description, MsgBoxStyle.Critical)

    End Sub

    Private Sub BtnBuscarLue2_Click(sender As Object, e As EventArgs)
        On Error GoTo tipoerr
        'Select Case MovimientoListado

        '    Case "Compras"
        '    Case "Remisiones"
        '    Case "Ventas"
        'End Select

        'FrmBusqueda.ShowDialog()
        'If Not CodigoGenerico.Trim = "" Then
        '    Lue1.EditValue = CodigoGenerico
        'End If
        Exit Sub
tipoerr:
        MsgBox(Err.Description, MsgBoxStyle.Critical)
    End Sub

    Private Sub BtnBuscarSucursal_Click(sender As Object, e As EventArgs)
        On Error GoTo tipoerr
        ClaveBusqueda = "Sucursales"

        FrmBusqueda.ShowDialog()
        If Not CodigoGenerico.Trim = "" Then
            lueProducto.EditValue = (CodigoGenerico)
        End If
        Exit Sub
tipoerr:
        MsgBox(Err.Description, MsgBoxStyle.Critical)
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        On Error GoTo tipoerr
        If PuedeAccionar() Then
            Select Case MovimientoListado
                Case "Ajustes"
                    If NumAjuste.Trim = "" Then Exit Select
                    FrmAjustes.ChkEditando.Checked = True
                    FrmAjustes.ShowDialog()
                Case "Compras"
                    If NumCompra.Trim = "" Then Exit Select
                    FrmCompras.ChkEditando.Checked = True
                    FrmCompras.ShowDialog()
                Case "Remisiones"
                    If NumRemision.Trim = "" Then Exit Select

            End Select
        End If

        Exit Sub
tipoerr:
        MsgBox(Err.Description, MsgBoxStyle.Critical)
    End Sub

    Private Sub gvAjustes_DoubleClick(sender As Object, e As EventArgs) Handles gvAjustes.DoubleClick
        On Error GoTo tipoerr

        Select Case MovimientoListado
            Case "Ajustes"
                NumAjuste = gvAjustes.GetFocusedDataRow.Item(0).ToString
            Case "Compras"
                NumCompra = gvAjustes.GetFocusedDataRow.Item(0).ToString
            Case "Remisiones"
                NumRemision = gvAjustes.GetFocusedDataRow.Item(0).ToString
            Case "Ventas"
                NumVenta = gvAjustes.GetFocusedDataRow.Item(0).ToString
        End Select

        Exit Sub
tipoerr:
        MsgBox(Err.Description, MsgBoxStyle.Critical)
    End Sub

    Private Sub LblMovimiento_Click(sender As Object, e As EventArgs) Handles LblExistencia.Click
        txtExistencia.Text = ""
    End Sub

    Private Sub btnCerrarEdicion_Click(sender As Object, e As EventArgs)
        On Error GoTo tipoerr
        Dim Condicion As String
        If PuedeAccionar() Then
            Select Case MovimientoListado
                Case "Ajustes"
                    Condicion = String.Format("NumAjuste='{0}'", NumAjuste)
                Case "Compras"
                    Condicion = String.Format("NumCompra='{0}'", NumCompra)
                Case "Remisiones"
                    Condicion = String.Format("NumRemision='{0}'", NumRemision)
                Case "Ventas"
                    Condicion = String.Format("NumVenta='{0}'", NumVenta)
            End Select

            EjecutarConsulta(String.Format("Update {0} Set Editar=0 Where {1}", MovimientoListado, Condicion))
            XtraMessageBox.Show("La edición del registro ha sido cerrada exitosamente", "Cierre de Edición", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If

        Exit Sub
tipoerr:
        MsgBox(Err.Description, MsgBoxStyle.Critical)
    End Sub

End Class