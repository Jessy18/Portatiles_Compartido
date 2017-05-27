Public Class FrmBusqueda 
    Dim SqlRegistros As String
    Dim DtRegistros As DataTable
    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Dispose()
        Me.Close()
    End Sub

    Private Sub FrmBusqueda_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CodigoGenerico = ""
        BuscarRegistros()
    End Sub

    Private Sub btnSeleccionar_Click(sender As Object, e As EventArgs) Handles btnSeleccionar.Click
        SeleccionarRegistro()
        Me.Dispose()
        Me.Close()
    End Sub
    Private Sub BuscarRegistros()
        Select Case ClaveBusqueda
            Case "Productos"
                SqlRegistros = "Select P.IdProducto, P.Producto, Convert(bit,0)  as Seleccionado, C.Categoria, M.Marca,P.Moneda, P.Precio1 from Productos as P INNER JOIN CategoriaProducto AS C ON P.IdCategoria=C.IdCategoria INNER JOIN Marcas as M ON M.IdMarca=P.IdMarca Where P.Activo=1 "
            Case "Clientes"
                SqlRegistros = "Select Clientes.IdCliente, DatosEntidad.Nombres+' '+DatosEntidad.Apellidos as Cliente, DatosEntidad.Empresa, DatosEntidad.Telefono, DatosEntidad.Direccion from Clientes INNER JOIN DatosEntidad ON Clientes.IdDatos=DatosEntidad.IdDatos "
            Case "Vendedores"
                SqlRegistros = "Select Vendedores.IdVendedor, DatosEntidad.Nombres+' '+DatosEntidad.Apellidos as Vendedor, DatosEntidad.Telefono, DatosEntidad.Direccion from Vendedores INNER JOIN DatosEntidad ON Vendedores.IdDatos=DatosEntidad.IdDatos "
            Case "Compras"
                SqlRegistros = "Select Compras.NumCompra, Compras.Fecha, Compras.IdProveedor, Proveedores.Proveedor, Compras.Subtotal+Compras.IVA as Total from Compras INNER JOIN Proveedores on Compras.IdProveedor=Proveedores.IdProveedor Where Compras.Editar=1 "
	   Case "Usuarios"
                SqlRegistros = "Select IDUsuario, Nombre From Usuarios Where Activo = 1"

            Case Else
                SqlRegistros = String.Format("Select * From {0}", ClaveBusqueda)
		
        End Select

        DtRegistros = BusquedaSeleccion(SqlRegistros)
        gcRegistros.DataSource = DtRegistros

        For Each DCDetalle As DevExpress.XtraGrid.Columns.GridColumn In gvRegistros.Columns
            gvRegistros.Columns(DCDetalle.FieldName).OptionsColumn.AllowEdit = False
            If DCDetalle.FieldName = "Seleccionado" Then
                gvRegistros.Columns(DCDetalle.FieldName).OptionsColumn.AllowEdit = True
            End If
        Next
    End Sub
    Private Sub SeleccionarRegistro()
        Try
            Dim DrNuevo As DataRow
            If gvRegistros.RowCount = 0 Then Exit Sub

            CodigoGenerico = gvRegistros.GetFocusedDataRow.Item(0).ToString
            If ClaveBusqueda = "Productos" Then
                InicializarTablaSeleccionados()
                For Each DrFila As DataRow In DtRegistros.Rows

                    If CBool(DrFila!Seleccionado) = True Then
                        DrNuevo = DtSeleccion.NewRow
                        DrNuevo!Codigo = DrFila(0).ToString.Trim
                        DtSeleccion.Rows.Add(DrNuevo)
                    End If
                Next
            End If
            If DtSeleccion Is Nothing Then Exit Sub
            If DtSeleccion.Rows.Count > 1 Then CodigoGenerico = ""
        Catch ex As Exception

        End Try

    End Sub
End Class