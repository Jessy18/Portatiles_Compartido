Imports System.Data
Imports DevExpress.XtraEditors
Public Class FrmCompras

    Dim DtDetalle As DataTable
    Private Sub FrmMovimientos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.DteFecha.DateTime = Now
        CrearTabla()
        CargarDatosLUE()
        If ChkEditando.Checked Then
            CargarDatosCompra()
        Else
            PonerNumeracion()
        End If
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        ClaveBusqueda = "Productos"
        FrmBusqueda.ShowDialog()
        If Not CodigoGenerico.Trim = "" Then
            txtCodProducto.Text = CodigoGenerico
            Exit Sub
        End If
        If DtSeleccion Is Nothing Then Exit Sub
        If DtSeleccion.Rows.Count > 0 Then
            AgregarListadoSeleccion()
            CalcularResultados()
        End If

    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        On Error GoTo tipoerr
        If Not PuedeAgregar() Then Exit Sub
        AgregarProducto()
        CalcularResultados()
        Exit Sub
tipoerr:
        MsgBox(Err.Description, MsgBoxStyle.Critical)
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        On Error GoTo tipoerr
        'Pasamos los datos por una serie de validaciones simples
        If Not ValidarDatosCompra() Then Exit Sub

        'Procedemos a guardar el maestro de compr
        If ChkEditando.Checked Then
            GenericSql = "UPDATE Compras SET  IdSucursal = @IdSucursal, IdUsuario = @IdUsuario, IdProveedor = @IdProveedor, NumDocCompra = @NumDocCompra, Fecha = @Fecha, Tipo = @Tipo, DocReferencia = @DocReferencia, Subtotal = @Subtotal, IVA = @IVA, Observaciones = @Observaciones, Editar = @Editar,  Anulada = @Anulada WHERE     NumCompra = @NumCompra  "
        Else
            GenericSql = "INSERT INTO Compras (NumCompra, IdSucursal, IdUsuario, IdProveedor, NumDocCompra, Fecha, Tipo, DocReferencia, Subtotal, IVA, Observaciones, Editar, Anulada) VALUES (@NumCompra, @IdSucursal, @IdUsuario, @IdProveedor, @NumDocCompra, @Fecha, @Tipo, @DocReferencia, @Subtotal, @IVA, @Observaciones, @Editar, @Anulada) "
        End If
        CrearComando(GenericSql)

        With Comando.Parameters
            .AddWithValue("NumCompra", txtNumCompra.Text)
            .AddWithValue("IdSucursal", lueSucursal.EditValue.ToString)
            .AddWithValue("IdUsuario", CodUsuario)
            .AddWithValue("IdProveedor", LueProveedor.EditValue.ToString)
            .AddWithValue("DocReferencia", txtFacturaReferencia.Text.ToString)
            .AddWithValue("NumDocCompra", txtDocSucursal.Text)
            .AddWithValue("Fecha", DteFecha.DateTime)
            .AddWithValue("Subtotal", txtTotalCosto.Text)
            .AddWithValue("Tipo", "Contado")
            .AddWithValue("IVA", txtIVA.Text)
            .AddWithValue("Observaciones", MeObservaciones.Text)
            .AddWithValue("Editar", True)
            .AddWithValue("Anulada", False)

        End With
        EjecutarComando()

        EjecutarConsulta(String.Format("Delete from DetalleCompra Where NumCompra={0}", txtNumCompra.Text))
        For Each DrFila As DataRow In DtDetalle.Rows
            'Procedemos a guardar el detalle de compra
            GenericSql = "INSERT INTO DetalleCompra(NumCompra, IdProducto, Cantidad, Costo, Exonerado) VALUES (@NumCompra, @IdProducto, @Cantidad, @Costo, @Exonerado) "
            CrearComando(GenericSql)

            With Comando.Parameters
                .AddWithValue("NumCompra", txtNumCompra.Text)
                .AddWithValue("IdProducto", DrFila!IdProducto.ToString)
                .AddWithValue("Cantidad", DrFila!Cantidad.ToString)
                .AddWithValue("Costo", DrFila!Costo.ToString)
                .AddWithValue("Exonerado", CBool(DrFila!Exonerado))
            End With
            EjecutarComando()
        Next
        XtraMessageBox.Show("La compra se ha guardado correctamente", "Datos Almacenados", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Dispose()
        Me.Close()
        Exit Sub
tipoerr:
        MsgBox(Err.Description, MsgBoxStyle.Critical)
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Dispose()
        Me.Close()
    End Sub

    Private Sub PonerNumeracion()
        Dim Drconfig As DataRow = BusquedaSeleccionFila("Select * from Empresa")
        If Not Drconfig Is Nothing Then
            txtNumCompra.Text = Drconfig!Compras.ToString
        End If
        If Not lueSucursal.EditValue Is Nothing Then
            Dim DrSucursal As DataRow = BusquedaSeleccionFila(String.Format("Select * from Sucursales Where IdSucursal={0}", lueSucursal.EditValue.ToString))
            If Not DrSucursal Is Nothing Then
                txtDocSucursal.Text = DrSucursal!NumDocCompra.ToString
            End If
        End If
    End Sub

    Private Sub CargarDatosLUE()
        lueSucursal.Properties.DataSource = BusquedaSeleccion("Select IdSucursal, Sucursal from Sucursales Where Activa=1 ")
        lueSucursal.Properties.ValueMember = "IdSucursal"
        lueSucursal.Properties.DisplayMember = "Sucursal"

        If Not Administrador Then
            lueSucursal.Properties.ReadOnly = True
            lueSucursal.EditValue = CodSucursal
        End If
        LueProveedor.Properties.DataSource = BusquedaSeleccion("Select IdProveedor, Proveedor from Proveedores Where Activo=1 ")
        LueProveedor.Properties.ValueMember = "IdProveedor"
        LueProveedor.Properties.DisplayMember = "Proveedor"
      
    End Sub
    Private Sub CrearTabla()
        On Error GoTo tipoerr
        DtDetalle = New DataTable
        With DtDetalle
            .Columns.Add("IdProducto", GetType(String))
            .Columns.Add("Producto", GetType(String))
            .Columns.Add("Cantidad", GetType(Double))
            .Columns.Add("Costo", GetType(Double))
            .Columns.Add("Subtotal", GetType(Double))
            .Columns.Add("Iva", GetType(Double))
            .Columns.Add("Exonerado", GetType(Boolean))
        End With
        gcMovimientos.DataSource = DtDetalle

        For Each DCDetalle As DevExpress.XtraGrid.Columns.GridColumn In gvMovimientos.Columns
            gvMovimientos.Columns(DCDetalle.FieldName).OptionsColumn.AllowEdit = False
            If DCDetalle.FieldName = "Cantidad" Or DCDetalle.FieldName = "Costo" Then
                gvMovimientos.Columns(DCDetalle.FieldName).OptionsColumn.AllowEdit = True
            End If
        Next
        Exit Sub
tipoerr:
        MsgBox(Err.Description, MsgBoxStyle.Critical)
    End Sub

    Private Sub txtCodProducto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCodProducto.KeyPress
        If Asc(e.KeyChar) = 13 Then
            CargarDatosProducto()
        End If
    End Sub

    Private Sub CargarDatosProducto()
        On Error GoTo tipoerr

        If txtCodProducto.Text.Trim = "" Then Exit Sub
        Dim DrProducto As DataRow = BusquedaSeleccionFila(String.Format("Select * from Productos Where IdProducto={0}", txtCodProducto.Text.Trim))
        If Not DrProducto Is Nothing Then
            txtProducto.Text = DrProducto!Producto.ToString
            txtCosto.Text = DrProducto!Costo.ToString
            txtCosto.Tag = DrProducto!Moneda.ToString
        End If
        Exit Sub
tipoerr:
        MsgBox(Err.Description, MsgBoxStyle.Critical)
    End Sub

    Private Sub txtCantidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCantidad.KeyPress
        ValidarNumeroDecimal(txtCantidad.Text, e)
    End Sub

    Private Function PuedeAgregar() As Boolean
        'Esta función valida si los datos son correctos para agregar un item al detalle
        PuedeAgregar = True
        'Inicia en verdadero indicando que se va agregar siempre y cuando no entre en las siguientes condiciones

        If txtCodProducto.Text.Trim = "" Then
            XtraMessageBox.Show("Seleccione un producto válido.", "Validar Datos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            PuedeAgregar = False
            Exit Function
        End If
        If txtCantidad.Text.Trim = "" Then
            XtraMessageBox.Show("La cantidad de compra no puede ser vacía.", "Validar Datos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            PuedeAgregar = False
            Exit Function
        End If
        If CDbl(txtCantidad.Text.Trim) <= 0 Then
            XtraMessageBox.Show("La cantidad de compra no puede ser cero.", "Validar Datos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            PuedeAgregar = False
            Exit Function
        End If
        'Al cumplir alguna de éstas condiciones el valor se vuelve falso y sale de la función de inmediato
    End Function

    Private Sub AgregarProducto()
        'Este método agrega un producto al detalle
        Dim DrDato As DataRow
        'Se recorre el detalle de productos agregados para validar si el producto a agregar 
        'ya existe en el detalle del ajuste
        'Si ya existe solo se actualizan las cantidades y el subtotal
        For Each DrFila As DataRow In DtDetalle.Rows
            If DrFila!IdProducto.ToString = txtCodProducto.Text.Trim Then
                DrFila.BeginEdit()
                DrFila!Cantidad = CDbl(DrFila!Cantidad) + CDbl(txtCantidad.Text)
                DrFila!Subtotal = CDbl(DrFila!Cantidad) * CDbl(DrFila!Costo)
                DrFila.EndEdit()
                DrFila.AcceptChanges()
                Exit Sub
            End If
        Next

        'Aquí se agrega un elemento nuevo al detalle del ajuste
        DrDato = DtDetalle.NewRow
        DrDato!IdProducto = txtCodProducto.Text.Trim
        DrDato!Producto = txtProducto.Text.Trim
        DrDato!Cantidad = CDbl(txtCantidad.Text)
        DrDato!Costo = CDbl(txtCosto.Text)
        DrDato!Subtotal = CDbl(txtCantidad.Text) * CDbl(txtCosto.Text)
        DtDetalle.Rows.Add(DrDato)
        Exit Sub
    End Sub
    Private Sub AgregarListadoSeleccion()
        Dim Agregar As Boolean
        'Dtseleccion contiene un listado de codigos de productos seleccionados
        For Each DrFila As DataRow In DtSeleccion.Rows
            Agregar = True
            'Primero se valida si el producto ya está agregado en el detalle de ajuste
            For Each DrDetalleAjuste As DataRow In DtDetalle.Rows
                If DrFila!Codigo.ToString = DrDetalleAjuste!IdProducto.ToString Then
                    Agregar = False
                End If
            Next
            'Si el codigo aún no está agregado al detalle se agrega el producto con cantidad 1
            If Agregar Then
                'Aquí se agrega un elemento nuevo al detalle del ajuste
                Dim DrDato As DataRow = DtDetalle.NewRow
                Dim DrProducto As DataRow = BusquedaSeleccionFila(String.Format("Select * from Productos Where IdProducto={0}", DrFila!Codigo.ToString))
                DrDato!IdProducto = DrFila!Codigo
                DrDato!Producto = DrProducto!Producto
                DrDato!Cantidad = 1
                DrDato!Costo = CDbl(DrProducto!Costo)
                DrDato!Subtotal = DrProducto!Costo
                DtDetalle.Rows.Add(DrDato)
            End If
        Next
        gcMovimientos.DataSource = DtDetalle
    End Sub
    Private Sub CalcularResultados()

        For Each DrFila As DataRow In DtDetalle.Rows

            DrFila.BeginEdit()
            'DrFila!Cantidad = CDbl(DrFila!Cantidad) + CDbl(txtCantidad.Text)
            DrFila!Subtotal = CDbl(DrFila!Cantidad) * CDbl(DrFila!Costo)
            DrFila!Exonerado = CBool(BuscarRegistroSql("Productos", "Exonerado", "IdProducto", DrFila!IdProducto.ToString))
            DrFila!Iva = 0
            If CBool(DrFila!Exonerado) = False Then
                DrFila!Iva = CDbl(DrFila!Subtotal) * (IVA / 100)
            End If
            DrFila.EndEdit()
            DrFila.AcceptChanges()


        Next

        'Calculamos los totales

        Dim TotalProducto As Double = DtDetalle.Rows.Count
        Dim TotalCantidad As Double = CDbl(DtDetalle.Compute("SUM(Cantidad)", ""))
        Dim TotalCosto As Double = CDbl(DtDetalle.Compute("SUM(Subtotal)", ""))
        Dim TotalIVA As Double = CDbl(DtDetalle.Compute("SUM(Iva)", ""))
        Dim TotalCompra As Double = TotalCosto + TotalIVA
        'Se presentan los resultados al usuario
        txtTotalProductos.Text = TotalProducto.ToString
        txtTotalCant.Text = TotalCantidad.ToString
        txtTotalCosto.Text = TotalCosto.ToString
        txtIVA.Text = TotalIVA.ToString
        txtTotalCompra.Text = TotalCompra.ToString

    End Sub


    Private Sub gvMovimientos_CellValueChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles gvMovimientos.CellValueChanged
        CalcularResultados()
    End Sub

    Private Sub txtCodProducto_TextChanged(sender As Object, e As EventArgs) Handles txtCodProducto.TextChanged
        CargarDatosProducto()
    End Sub

    Private Sub lueSucursal_EditValueChanged(sender As Object, e As EventArgs) Handles lueSucursal.EditValueChanged
        PonerNumeracion()
    End Sub
    Private Function ValidarDatosCompra() As Boolean
        ValidarDatosCompra = True

        If txtNumCompra.Text.Trim = "" Then
            XtraMessageBox.Show("El número de compra no puede estar vacío.", "Validar Datos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ValidarDatosCompra = False
            Exit Function
        End If

        If lueSucursal.EditValue.ToString.Trim = "" Then
            XtraMessageBox.Show("Por favor seleccione la sucursal.", "Validar Datos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ValidarDatosCompra = False
            Exit Function
        End If
        If LueProveedor.EditValue.ToString.Trim = "" Then
            XtraMessageBox.Show("Por favor seleccione el proveedor.", "Validar Datos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ValidarDatosCompra = False
            Exit Function
        End If
        If gvMovimientos.RowCount = 0 Then
            XtraMessageBox.Show("Debe agregar al menos un producto al detalle.", "Validar Datos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ValidarDatosCompra = False
            Exit Function
        End If

        If Not ChkEditando.Checked Then
            PonerNumeracion()

            'Validando la numeración de la sucursal
            If txtDocSucursal.Text.Trim <> "" Then
                Dim DrCompraDoc As DataRow = BusquedaSeleccionFila(String.Format("Select * from Compras Where NumDocCompra='{0}' AND IdSucursal='{1}'", txtDocSucursal.Text.Trim, lueSucursal.EditValue))
                If Not DrCompraDoc Is Nothing Then
                    XtraMessageBox.Show("Ya existe una compra guardado con ese número de documento en la sucursal.", "Validar Datos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    ValidarDatosCompra = False
                    Exit Function
                End If
            End If

            'Validando la numeración del ajuste en sí.
            If txtNumCompra.Text.Trim <> "" Then
                If BuscarRegistroSql("Compras", "NumCompra", "NumCompra", txtNumCompra.Text.Trim) = "" Then
                    ExisteRegistro = False
                Else
                    ExisteRegistro = True
                End If
                If ExisteRegistro Then
                    Dim NuevaCompra As String = CodigoNuevo("Compras", "NumCompra", 1)
                    EjecutarConsulta(String.Format("Update Empresa Set Compras={0}", NuevaCompra))
                    XtraMessageBox.Show("El sistema actualizó la numeración de compras. Proceda a verificar si es correcto.", "Validar Datos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    ValidarDatosCompra = False
                End If
            End If
        End If
        Return ValidarDatosCompra
    End Function

    Private Sub CargarDatosCompra()
        If NumCompra.Trim = "" Then Exit Sub
        Dim DrCompra As DataRow = BusquedaSeleccionFila(String.Format("Select * from Compras Where NumCompra={0}", NumCompra))
        DtDetalle = BusquedaSeleccion(String.Format("Select DC.IdProducto, P.Producto, DC.Cantidad, DC.Costo, DC.Cantidad*DC.Costo as Subtotal, DC.Exonerado, Convert(numeric(10,0),0) as Iva from DetalleCompra as DC INNER JOIN Productos as P ON DC.IdProducto=P.IdProducto Where DC.NumCompra={0}", NumCompra))
        If Not DrCompra Is Nothing Then
            txtNumCompra.Text = NumCompra
            lueSucursal.EditValue = DrCompra!IdSucursal.ToString
            LueProveedor.EditValue = DrCompra!IdProveedor.ToString
            txtFacturaReferencia.Text = DrCompra!DocReferencia.ToString
            txtDocSucursal.Text = DrCompra!NumDocCompra.ToString
            DteFecha.DateTime = CDate(DrCompra!Fecha)
            MeObservaciones.Text = DrCompra!Observaciones.ToString
        End If
        gcMovimientos.DataSource = DtDetalle
        CalcularResultados()
    End Sub

End Class