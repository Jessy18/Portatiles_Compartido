Imports DevExpress.XtraEditors
Public Class FrmSeriesProducto

    Dim DtDetalle As DataTable
    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        On Error GoTo tipoerr
        ClaveBusqueda = "Compras"

        FrmBusqueda.ShowDialog()
        If Not CodigoGenerico.Trim = "" Then
            txtNumCompra.Text = (CodigoGenerico)
        End If
        Exit Sub
tipoerr:
        MsgBox(Err.Description, MsgBoxStyle.Critical)
    End Sub

    Private Sub txtNumCompra_EditValueChanged(sender As Object, e As EventArgs) Handles txtNumCompra.EditValueChanged
        CargarProductosCompra()
    End Sub


    Private Sub CargarProductosCompra()
        On Error GoTo tipoerr

        If txtNumCompra.Text.Trim = "" Then Exit Sub
        Dim DtProductos As DataTable = BusquedaSeleccion(String.Format("Select DetalleCompra.IdProducto, Productos.Producto, DetalleCompra.Cantidad, Case When (SUM(Series_Prod.Cantidad)) Is NULL THEN 0 else SUM(Series_Prod.Cantidad) END as Registrados From DetalleCompra INNER JOIN Productos on DetalleCompra.IdProducto=Productos.IdProducto LEFT OUTER JOIN Series_Prod on Series_Prod.IdProducto=DetalleCompra.IdProducto AND Series_Prod.NumCompra=DetalleCompra.NumCompra Where DetalleCompra.NumCompra={0} Group by DetalleCompra.IdProducto, Productos.Producto, DetalleCompra.Cantidad ", txtNumCompra.Text))

        If DtProductos.Rows.Count = 0 Then Exit Sub
        LueProductos.Properties.DataSource = DtProductos
        LueProductos.Properties.ValueMember = "IdProducto"
        LueProductos.Properties.DisplayMember = "Producto"

        Exit Sub
tipoerr:
        MsgBox(Err.Description, MsgBoxStyle.Critical)
    End Sub

    Private Sub LueProductos_EditValueChanged(sender As Object, e As EventArgs) Handles LueProductos.EditValueChanged
        CargarProductoSeleccionado()
    End Sub
    Private Sub CargarProductoSeleccionado()
        On Error GoTo tipoerr

        If LueProductos.EditValue.ToString.Trim = "" Then Exit Sub
        txtCantDisponible.Text = (CDbl(LueProductos.GetColumnValue("Cantidad")) - CDbl(LueProductos.GetColumnValue("Registrados"))).ToString

        Exit Sub
tipoerr:
        MsgBox(Err.Description, MsgBoxStyle.Critical)
    End Sub

    Private Sub FrmSeriesProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CrearTabla()
    End Sub

    Private Sub CrearTabla()
        On Error GoTo tipoerr
        DtDetalle = New DataTable
        With DtDetalle
            .Columns.Add("IdProducto", GetType(String))
            .Columns.Add("Producto", GetType(String))
            .Columns.Add("Cantidad", GetType(Double))
            .Columns.Add("Serie", GetType(String))
        End With
        gcMovimientos.DataSource = DtDetalle

        For Each DCDetalle As DevExpress.XtraGrid.Columns.GridColumn In gvMovimientos.Columns
            gvMovimientos.Columns(DCDetalle.FieldName).OptionsColumn.AllowEdit = False
            If DCDetalle.FieldName = "Cantidad" Or DCDetalle.FieldName = "Serie" Then
                gvMovimientos.Columns(DCDetalle.FieldName).OptionsColumn.AllowEdit = True
            End If
        Next
        Exit Sub
tipoerr:
        MsgBox(Err.Description, MsgBoxStyle.Critical)
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        On Error GoTo tipoerr
        If Not PuedeAgregar() Then Exit Sub
        AgregarProducto()
        Exit Sub
tipoerr:
        MsgBox(Err.Description, MsgBoxStyle.Critical)
    End Sub

    Private Function PuedeAgregar() As Boolean
        'Esta función valida si los datos son correctos para agregar un item al detalle
        PuedeAgregar = True
        'Inicia en verdadero indicando que se va agregar siempre y cuando no entre en las siguientes condiciones

        If LueProductos.EditValue.ToString.Trim = "" Then
            XtraMessageBox.Show("Seleccione un producto válido.", "Validar Datos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            PuedeAgregar = False
            Exit Function
        End If
        If SpeCantidad.Text.Trim = "" Then
            XtraMessageBox.Show("La cantidad a registrar no puede ser vacía.", "Validar Datos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            PuedeAgregar = False
            Exit Function
        End If

        If CDbl(SpeCantidad.Text.Trim) <= 0 Then
            XtraMessageBox.Show("La cantidad a registrar no puede ser cero.", "Validar Datos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            PuedeAgregar = False
            Exit Function
        End If
        If CDbl(SpeCantidad.Text.Trim) > CDbl(txtCantDisponible.Text) Then
            XtraMessageBox.Show("La cantidad a registrar no puede mayor que la cantidad disponible para guardar.", "Validar Datos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            PuedeAgregar = False
            Exit Function
        End If
        'Al cumplir alguna de éstas condiciones el valor se vuelve falso y sale de la función de inmediato
    End Function

    Private Sub AgregarProducto()
        'Este método agrega un producto al detalle
        Dim DrDato As DataRow = DtDetalle.NewRow
    
        'Aquí se agrega un elemento nuevo al detalle del ajuste
        DrDato!IdProducto = LueProductos.EditValue.ToString.Trim
        DrDato!Producto = LueProductos.Text
        DrDato!Cantidad = CDbl(SpeCantidad.Text)
        DrDato!Serie = txtSerie.Text
        DtDetalle.Rows.Add(DrDato)
        Exit Sub
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Dispose()
        Me.Close()
    End Sub

    Private Function ValidarSeriesCompra() As Boolean
        ValidarSeriesCompra = True

        If txtNumCompra.Text.Trim = "" Then
            XtraMessageBox.Show("El número de compra no puede estar vacío.", "Validar Datos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ValidarSeriesCompra = False
            Exit Function
        End If
        If gvMovimientos.RowCount = 0 Then
            XtraMessageBox.Show("Debe agregar al menos un producto al detalle.", "Validar Datos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ValidarSeriesCompra = False
            Exit Function
        End If
    End Function

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        On Error GoTo tipoerr
        'Pasamos los datos por una serie de validaciones simples
        If Not ValidarSeriesCompra() Then Exit Sub

        For Each DrFila As DataRow In DtDetalle.Rows
            'Procedemos a guardar el detalle de compra
            GenericSql = "INSERT INTO Series_Prod(IdProducto, NumCompra, Cantidad, Serie, Vendidos) VALUES (@IdProducto, @NumCompra, @Cantidad, @Serie, @Vendidos) "

            CrearComando(GenericSql)

            With Comando.Parameters
                .AddWithValue("NumCompra", txtNumCompra.Text)
                .AddWithValue("IdProducto", DrFila!IdProducto.ToString)
                .AddWithValue("Cantidad", DrFila!Cantidad.ToString)
                .AddWithValue("Serie", DrFila!Serie.ToString)
                .AddWithValue("Vendidos", 0)
            End With
            EjecutarComando()
        Next
        XtraMessageBox.Show("Los números de series de la compra se ha guardadon correctamente", "Datos Almacenados", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Dispose()
        Me.Close()
        Exit Sub
tipoerr:
        MsgBox(Err.Description, MsgBoxStyle.Critical)
    End Sub
End Class