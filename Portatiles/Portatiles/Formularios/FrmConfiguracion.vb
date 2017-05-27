Public Class FrmConfiguracion 

    Private Sub FrmConfiguracion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Cargamos los parámetros de la empresa en las variables públicas
        CargarConfiguracion()
        'Cargamos los datos de la empresa en el formulario
        CargarDatosConfiguracion()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        On Error GoTo tipoerr

        If Not ValidarDatosEmpresa() Then Exit Sub

        CrearComando("UPDATE    Empresa SET NombreEmpresa = @NombreEmpresa, RazonSocial = @RazonSocial, RUC = @RUC, Direccion = @Direccion, Telefonos = @Telefonos, ChequeANombre = @ChequeANombre, PorcIVA = @PorcIVA, Moneda = @Moneda, Historial = @Historial, DigitoIdProducto = @DigitoIdProducto,  DigitoIdCliente = @DigitoIdCliente, DigitoIdProveedor = @DigitoIdProveedor, DigitoIdVendedor = @DigitoIdVendedor, Compras = @Compras, Remisiones = @Remisiones, Ventas = @Ventas, Ajustes = @Ajustes ")
        'CrearComando(GenericSql)

        With Comando.Parameters
            .AddWithValue("NombreEmpresa", txtNombreEmpresa.Text.Trim)
            .AddWithValue("RazonSocial", txtRazonSocial.Text.Trim)
            .AddWithValue("RUC", txtRUC.Text.Trim)
            .AddWithValue("Direccion", txtDireccion.Text.Trim)
            .AddWithValue("Telefonos", txtTelefonos.Text.Trim)
            .AddWithValue("ChequeANombre", txtChequeNombre.Text.Trim)
            .AddWithValue("PorcIVA", CDbl(txtPorcIVA.Text))
            .AddWithValue("Moneda", IIf(RDGMoneda.SelectedIndex = 0, "US", "CS"))
            .AddWithValue("Historial", CBool(ChkHistorial.Checked))
            .AddWithValue("DigitoIdProducto", SpeDigitoProducto.Text)
            .AddWithValue("DigitoIdCliente", SpeDigitoCliente.Text)
            .AddWithValue("DigitoIdProveedor", SpeDigitoProveedor.Text)
            .AddWithValue("DigitoIdVendedor", SpeDigitoVendedor.Text)
            .AddWithValue("Compras", SpeNumCompra.Text)
            .AddWithValue("Remisiones", SpeNumRemision.Text)
            .AddWithValue("Ventas", SpeNumFactura.Text)
            .AddWithValue("Ajustes", SpeNumAjuste.Text)
        End With
        If EjecutarComando() Then
            DevExpress.XtraEditors.XtraMessageBox.Show("El Registro se ha guardado correctamente", "Datos Almacenados", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        FrmConfiguracion_Load(sender, e)

        Exit Sub
tipoerr:
        DevExpress.XtraEditors.XtraMessageBox.Show(Err.Description, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Dispose()
        Me.Close()
    End Sub

    Private Sub CargarDatosConfiguracion()
        On Error GoTo tipoerr

        Dim DrEmpresa As DataRow = BusquedaSeleccionFila("Select * from Empresa")
        If Not DrEmpresa Is Nothing Then
            txtNombreEmpresa.Text = DrEmpresa!NombreEmpresa.ToString
            txtRazonSocial.Text = DrEmpresa!RazonSocial.ToString
            txtRUC.Text = DrEmpresa!RUC.ToString
            txtDireccion.Text = DrEmpresa!Direccion.ToString
            txtTelefonos.Text = DrEmpresa!Telefonos.ToString
            txtChequeNombre.Text = DrEmpresa!ChequeANombre.ToString
            txtPorcIVA.Text = DrEmpresa!PorcIVA.ToString
            If Not IsDBNull(DrEmpresa!Moneda) Then
                RDGMoneda.SelectedIndex = CInt(IIf(DrEmpresa!Moneda.ToString = "US", 1, 0))
            End If
            If Not IsDBNull(DrEmpresa!Historial) Then
                ChkHistorial.Checked = CBool(DrEmpresa!Historial)
            End If
            If Not IsDBNull(DrEmpresa!DigitoIdProducto) Then
                SpeDigitoProducto.Text = DrEmpresa!DigitoIdProducto.ToString
            End If
            If Not IsDBNull(DrEmpresa!DigitoIdProducto) Then
                SpeDigitoCliente.Text = DrEmpresa!DigitoIdCliente.ToString
            End If
            If Not IsDBNull(DrEmpresa!DigitoIdProveedor) Then
                SpeDigitoProveedor.Text = DrEmpresa!DigitoIdProveedor.ToString
            End If
            If Not IsDBNull(DrEmpresa!DigitoIdVendedor) Then
                SpeDigitoVendedor.Text = DrEmpresa!DigitoIdVendedor.ToString
            End If
            If Not IsDBNull(DrEmpresa!Compras) Then
                SpeNumCompra.Text = DrEmpresa!Compras.ToString
            End If
            If Not IsDBNull(DrEmpresa!Ventas) Then
                SpeNumFactura.Text = DrEmpresa!Ventas.ToString
            End If
            If Not IsDBNull(DrEmpresa!Remisiones) Then
                SpeNumRemision.Text = DrEmpresa!Remisiones.ToString
            End If
            If Not IsDBNull(DrEmpresa!Ajustes) Then
                SpeNumAjuste.Text = DrEmpresa!Ajustes.ToString
            End If
        End If
        Exit Sub
tipoerr:
        MsgBox(Err.Description, MsgBoxStyle.Critical)
    End Sub

    Private Sub txtPorcIVA_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPorcIVA.KeyPress
        ValidarNumeroDecimal(txtPorcIVA.Text, e)
    End Sub

    Private Function ValidarDatosEmpresa() As Boolean
        ValidarDatosEmpresa = True

        If txtNombreEmpresa.Text.Trim = "" Then
            DevExpress.XtraEditors.XtraMessageBox.Show("El nombre de la empresa no puede quedar vacío", "Validar Datos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ValidarDatosEmpresa = False
            Exit Function
        End If

        If txtRazonSocial.Text.Trim = "" Then
            DevExpress.XtraEditors.XtraMessageBox.Show("La razón social de la empresa no puede quedar vacío", "Validar Datos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ValidarDatosEmpresa = False
            Exit Function
        End If

    End Function
End Class