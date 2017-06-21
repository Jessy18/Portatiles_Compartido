Imports System.Data
Imports DevExpress.XtraEditors
Public Class FrmFacturacion

    Dim DtDetalle As DataTable
    Dim Exonerado As Boolean
    Dim DrNumeros As DataRow

    Private Sub FrmFacturacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.DteFecha.DateTime = Now
        CrearTabla()
        CargarDatosLUE()
        CargarEstadoCombo()
        PonerNumeracion()


    End Sub
    Private Sub CargarEstadoCombo()
        With CmbTipoPrecio.Properties.Items
            .Add("Precio 1")
            .Add("Precio 2")
            .Add("Precio 3")
        End With

    End Sub
    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscarProducto.Click
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
        If Not ValidarDatosFactura() Then Exit Sub

        'Procedemos a guardar el maestro de compr

        If Guardar() Then
            XtraMessageBox.Show("La compra se ha guardado correctamente", "Datos Almacenados", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If
        Me.Dispose()
        Me.Close()
        Exit Sub
tipoerr:
        MsgBox(Err.Description, MsgBoxStyle.Critical)
    End Sub


    Private Function Guardar() As Boolean

        'la fecha del control  mas la hora actual
        FechaGuardar = CDate(DteFecha.DateTime.ToString("dd/MM/yyyy") & " " & Now.ToString("hh:mm:ss"))
        Try

            AbrirTransaccion()

            'se obtiene las numeraciones Actuales
            DrNumeros = BusquedaSeleccionFila("select * From Ventas_ObtieneNum('" & lueSucursal.EditValue.ToString & "')")

            'Se actualiza las numeraciones (+1)
            Comando.Parameters.Clear()
            Comando.CommandText = "Ventas_ActualizaNum"
            Comando.CommandType = CommandType.StoredProcedure
            Comando.Parameters.AddWithValue("IdSucursal", lueSucursal.EditValue)
            Comando.ExecuteNonQuery()

            'Guardo el Maestro
            Comando.Parameters.Clear()
            Comando.CommandText = "Remisiones_Agregar"
            Comando.CommandType = CommandType.StoredProcedure
            With Comando.Parameters
                .AddWithValue("NumRemision", DrNumeros!NumRemision)
                .AddWithValue("IdSucursalSalida", lueSucursal.EditValue.ToString)
                .AddWithValue("IdUsuRemite", CodUsuario)
                .AddWithValue("NumRemisionSuc", DrNumeros!NumRemisionSuc)
                .AddWithValue("Fecha", FechaGuardar)
                .AddWithValue("Observaciones", MeObservaciones.Text.Trim)
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
            Comando.Parameters.AddWithValue("idSucursal", lueSucursal.EditValue)
            EjecutarComando()

            'Sucursal de Salida
            CrearComando("Productos_ActualizarExist")
            Comando.Parameters.AddWithValue("idProducto", item!IdProducto)
            Comando.Parameters.AddWithValue("idSucursal", lueSucursal.EditValue)
            EjecutarComando()
        Next

        HADatosNEW = "NumRemision: " & txtNumVenta.Text & " | " & _
                    "NumRemisionSucursal: " & txtDocSucursal.Text & " | " & _
                    "SucursalSalida: " & lueSucursal.EditValue.ToString & _
                    "Fecha: " & FechaGuardar.ToLongDateString & " | " & _
                    "Observaciones: " & MeObservaciones.Text & " | "

        GuardarHistorialAccion("Insertar", "Sucursales", txtNumVenta.Text, "", HADatosNEW)

        Return True
    End Function


    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Dispose()
        Me.Close()
    End Sub

    Private Sub PonerNumeracion()
        Dim Drconfig As DataRow = BusquedaSeleccionFila("Select * from Empresa")
        If Not Drconfig Is Nothing Then
            txtNumVenta.Text = Drconfig!Ventas.ToString
        End If
        If lueSucursal.EditValue Is Nothing Then Exit Sub
        If lueSucursal.EditValue.ToString.Trim = "" Then Exit Sub

        Dim DrSucursal As DataRow = BusquedaSeleccionFila(String.Format("Select * from Sucursales Where IdSucursal={0}", lueSucursal.EditValue.ToString))
        If Not DrSucursal Is Nothing Then
            txtDocSucursal.Text = DrSucursal!NumCompraSuc.ToString
        End If

    End Sub

    Private Sub CargarDatosLUE()
        lueSucursal.Properties.DataSource = BusquedaSeleccion("Select IdSucursal, Sucursal from Sucursales Where Activa=1 ")
        lueSucursal.Properties.ValueMember = "IdSucursal"
        lueSucursal.Properties.DisplayMember = "Sucursal"

        lueSucursal.EditValue = Nothing

        If Not Administrador Then
            lueSucursal.Properties.ReadOnly = True
            lueSucursal.EditValue = CodSucursal
        End If
        LueVendedor.Properties.DataSource = BusquedaSeleccion("Select Vendedores.IdVendedor, DatosEntidad.Nombres+' '+DatosEntidad.Apellidos as Vendedor, DatosEntidad.Telefono, DatosEntidad.Direccion from Vendedores INNER JOIN DatosEntidad ON Vendedores.IdDatos=DatosEntidad.IdDatos Where Vendedores.Activo=1 ")
        LueVendedor.Properties.ValueMember = "IdVendedor"
        LueVendedor.Properties.DisplayMember = "Vendedor"

    End Sub
    Private Sub CrearTabla()
        On Error GoTo tipoerr
        DtDetalle = New DataTable
        With DtDetalle
            .Columns.Add("IdProducto", GetType(String))
            .Columns.Add("Producto", GetType(String))
            .Columns.Add("Cantidad", GetType(Double))
            .Columns.Add("Precio", GetType(Double))
            .Columns.Add("TipoPrecio", GetType(String))
            .Columns.Add("Subtotal", GetType(Double))
            .Columns.Add("Iva", GetType(Double))
            .Columns.Add("IncluyeIVA", GetType(Boolean))
            .Columns.Add("Exonerado", GetType(Boolean))
            .Columns.Add("Cortesia", GetType(Boolean))
        End With
        gcMovimientos.DataSource = DtDetalle

        For Each DCDetalle As DevExpress.XtraGrid.Columns.GridColumn In gvMovimientos.Columns
            gvMovimientos.Columns(DCDetalle.FieldName).OptionsColumn.AllowEdit = False
            'sujeto a revisi{on
            'If DCDetalle.FieldName = "Cantidad" Or DCDetalle.FieldName = "Precio" Then
            '    gvMovimientos.Columns(DCDetalle.FieldName).OptionsColumn.AllowEdit = True
            'End If
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
            txtPrecio.Text = DrProducto!Precio1.ToString
            txtPrecio.Tag = DrProducto!Moneda.ToString
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
            XtraMessageBox.Show("La cantidad de venta no puede ser vacía.", "Validar Datos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            PuedeAgregar = False
            Exit Function
        End If
        If CDbl(txtCantidad.Text.Trim) <= 0 Then
            XtraMessageBox.Show("La cantidad de venta no puede ser cero.", "Validar Datos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
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
                DrFila!Subtotal = CDbl(DrFila!Cantidad) * CDbl(DrFila!Precio)
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

        DrDato!TipoPrecio = CmbTipoPrecio.Text
        Dim Precio As Double
        If ChkIncluyeIVa.Checked Then
            Precio = Format(CDbl(txtPrecio.Text) / (1 + IVA / 100), "##0.000000")
        Else
            Precio = CDbl(txtPrecio.Text)
        End If
        DrDato!Precio = CDbl(Precio)
        DrDato!Subtotal = CDbl(txtCantidad.Text) * CDbl(Precio)
        DrDato!IncluyeIVA = CBool(ChkIncluyeIVa.Checked)
        DrDato!Cortesia = CBool(ChkEsCortesia.Checked)
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
                Select Case CmbTipoPrecio.Text
                    Case "Precio 1"
                        DrDato!Precio = CDbl(DrProducto!Precio1)
                    Case "Precio 2"
                        DrDato!Precio = CDbl(DrProducto!Precio2)
                    Case "Precio 3"
                        DrDato!Precio = CDbl(DrProducto!Precio3)
                    Case Else
                        DrDato!Precio = CDbl(DrProducto!Precio1)
                End Select
                DrDato!Subtotal = DrProducto!Precio1
                DrDato!TipoPrecio = CmbTipoPrecio.Text
                DrDato!IncluyeIVA = CBool(ChkIncluyeIVa.Checked)
                DrDato!Cortesia = CBool(ChkEsCortesia.Checked)
                DtDetalle.Rows.Add(DrDato)
            End If
        Next
        gcMovimientos.DataSource = DtDetalle
    End Sub
    Private Sub CalcularResultados()

        For Each DrFila As DataRow In DtDetalle.Rows

            DrFila.BeginEdit()
            'DrFila!Cantidad = CDbl(DrFila!Cantidad) + CDbl(txtCantidad.Text)
            DrFila!Subtotal = CDbl(DrFila!Cantidad) * CDbl(DrFila!Precio)
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
        Dim TotalCosto As Double = CDbl(DtDetalle.Compute("SUM(Subtotal)", "Cortesia=0"))
        Dim TotalIVA As Double = CDbl(DtDetalle.Compute("SUM(Iva)", "Cortesia=0"))
        Dim TotalCompra As Double = TotalCosto + TotalIVA
        'Se presentan los resultados al usuario
        txtTotalProductos.Text = TotalProducto.ToString
        txtTotalCant.Text = TotalCantidad.ToString
        txtSubTotal.Text = TotalCosto.ToString
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
    Private Function ValidarDatosFactura() As Boolean
        ValidarDatosFactura = True

        If txtNumVenta.Text.Trim = "" Then
            XtraMessageBox.Show("El número de factura no puede estar vacío.", "Validar Datos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ValidarDatosFactura = False
            Exit Function
        End If

        If lueSucursal.EditValue.ToString.Trim = "" Then
            XtraMessageBox.Show("Por favor seleccione la sucursal.", "Validar Datos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ValidarDatosFactura = False
            Exit Function
        End If
        If LueVendedor.EditValue.ToString.Trim = "" Then
            XtraMessageBox.Show("Por favor seleccione el vendedor.", "Validar Datos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ValidarDatosFactura = False
            Exit Function
        End If
        If gvMovimientos.RowCount = 0 Then
            XtraMessageBox.Show("Debe agregar al menos un producto al detalle.", "Validar Datos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ValidarDatosFactura = False
            Exit Function
        End If



        'Validando la numeración de la sucursal
        If txtDocSucursal.Text.Trim <> "" Then
            Dim DrCompraDoc As DataRow = BusquedaSeleccionFila(String.Format("Select * from Ventas Where NumDocFactura='{0}' AND IdSucursal='{1}'", txtDocSucursal.Text.Trim, lueSucursal.EditValue))
            If Not DrCompraDoc Is Nothing Then
                XtraMessageBox.Show("Ya existe una factura guardada con ese número de documento en la sucursal.", "Validar Datos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                ValidarDatosFactura = False
                Exit Function
            End If
        End If

        'Validando la numeración del ajuste en sí.
        If txtNumVenta.Text.Trim <> "" Then
            If BuscarRegistroSql("Ventas", "NumVenta", "NumVenta", txtNumVenta.Text.Trim) = "" Then
                ExisteRegistro = False
            Else
                ExisteRegistro = True
            End If
            If ExisteRegistro Then
                Dim NuevaVenta As String = CodigoNuevo("Ventas", "NumVenta", 1)
                EjecutarConsulta(String.Format("Update Empresa Set Ventas={0}", NuevaVenta))
                XtraMessageBox.Show("El sistema actualizó la numeración de compras. Proceda a verificar si es correcto.", "Validar Datos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                ValidarDatosFactura = False
            End If
        End If

        Return ValidarDatosFactura
    End Function

    Private Sub CargarDatosCompra()
        If NumCompra.Trim = "" Then Exit Sub
        Dim DrCompra As DataRow = BusquedaSeleccionFila(String.Format("Select * from Compras Where NumCompra={0}", NumCompra))
        DtDetalle = BusquedaSeleccion(String.Format("Select DC.IdProducto, P.Producto, DC.Cantidad, DC.Costo, DC.Cantidad*DC.Costo as Subtotal, DC.Exonerado, Convert(numeric(10,0),0) as Iva from DetalleCompra as DC INNER JOIN Productos as P ON DC.IdProducto=P.IdProducto Where DC.NumCompra={0}", NumCompra))
        If Not DrCompra Is Nothing Then
            txtNumVenta.Text = NumCompra
            lueSucursal.EditValue = DrCompra!IdSucursal.ToString
            LueVendedor.EditValue = DrCompra!IdProveedor.ToString
            txtCodCliente.Text = DrCompra!DocReferencia.ToString
            txtDocSucursal.Text = DrCompra!NumDocCompra.ToString
            DteFecha.DateTime = CDate(DrCompra!Fecha)
            MeObservaciones.Text = DrCompra!Observaciones.ToString
        End If
        gcMovimientos.DataSource = DtDetalle
        CalcularResultados()
    End Sub

    Private Sub BtnBuscarCliente_Click(sender As Object, e As EventArgs) Handles BtnBuscarCliente.Click
        ClaveBusqueda = "Clientes"
        FrmBusqueda.ShowDialog()
        If Not CodigoGenerico.Trim = "" Then
            txtCodCliente.Text = CodigoGenerico
            CargarDatosCliente()
            Exit Sub
        End If
    End Sub

    Private Sub BtnBuscarVendedor_Click(sender As Object, e As EventArgs) Handles BtnBuscarVendedor.Click
        ClaveBusqueda = "Vendedores"
        FrmBusqueda.ShowDialog()
        If Not CodigoGenerico.Trim = "" Then
            txtCodVendedor.Text = CodigoGenerico
            CargarDatosVendedor()
            Exit Sub
        End If
    End Sub

    Private Sub txtCodCliente_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCodCliente.KeyPress
        If Asc(e.KeyChar) = 13 Then
            CargarDatosCliente()
        End If
    End Sub
    Private Sub CargarDatosCliente()
        On Error GoTo tipoerr

        If txtCodCliente.Text.Trim = "" Then Exit Sub
        Dim DrCliente As DataRow = BusquedaSeleccionFila(String.Format("Select Clientes.IdCliente, DatosEntidad.Nombres+' '+DatosEntidad.Apellidos as Cliente, DatosEntidad.Empresa, DatosEntidad.Telefono, DatosEntidad.Direccion, Clientes.Exonerado from Clientes INNER JOIN DatosEntidad ON Clientes.IdDatos=DatosEntidad.IdDatos Where Clientes.IdCliente={0}", txtCodCliente.Text.Trim))
        If Not DrCliente Is Nothing Then
            txtCliente.Text = DrCliente!Cliente.ToString
            Exonerado = CBool(DrCliente!Exonerado)
        End If
        Exit Sub
tipoerr:
        MsgBox(Err.Description, MsgBoxStyle.Critical)
    End Sub

    Private Sub txtCodVendedor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCodVendedor.KeyPress
        If Asc(e.KeyChar) = 13 Then
            CargarDatosCliente()
        End If
    End Sub
    Private Sub CargarDatosVendedor()
        On Error GoTo tipoerr

        If txtCodVendedor.Text.Trim = "" Then Exit Sub
        Dim DrVendededor As DataRow = BusquedaSeleccionFila(String.Format("Select Vendedores.IdVendedor, DatosEntidad.Nombres+' '+DatosEntidad.Apellidos as Vendedor, DatosEntidad.Telefono, DatosEntidad.Direccion from Vendedores INNER JOIN DatosEntidad ON Vendedores.IdDatos=DatosEntidad.IdDatos  Where Vendedores.IdVendedor={0}", txtCodVendedor.Text.Trim))
        If Not DrVendededor Is Nothing Then
            LueVendedor.EditValue = DrVendededor!IdVendedor.ToString

        End If
        Exit Sub
tipoerr:
        MsgBox(Err.Description, MsgBoxStyle.Critical)
    End Sub

    Private Sub LueVendedor_EditValueChanged(sender As Object, e As EventArgs) Handles LueVendedor.EditValueChanged
        If LueVendedor.EditValue.ToString = "" Then Exit Sub
        txtCodVendedor.Text = LueVendedor.EditValue.ToString
    End Sub

    Private Sub txtCodVendedor_TextChanged(sender As Object, e As EventArgs) Handles txtCodVendedor.TextChanged
        'If txtCodVendedor.Text.Trim = "" Then Exit Sub
        'If txtCodVendedor.Text.Trim = LueVendedor.EditValue.ToString Then Exit Sub
        'If BuscarRegistroSql("Vendedores", "CodVendedor", "CodVendedor", txtCodVendedor.Text) <> "" Then
        '    LueVendedor.EditValue = txtCodVendedor.Text
        'End If
    End Sub
End Class