Imports DevExpress.XtraEditors

Public Class FrmRemisiones

    Dim DrEmpresa As DataRow
    Dim DtDetalle As DataTable

    Private Sub FrmRemisiones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        On Error GoTo ErrException

        DrEmpresa = BusquedaSeleccionFila("Select * From Empresa")

        LueSucEntrada.Properties.DataSource = BusquedaSeleccion("Select IdSucursal, Sucursal FROM Sucursales Where Activa = 1")
        LueSucEntrada.Properties.ValueMember = "IdSucursal"
        LueSucEntrada.Properties.DisplayMember = "Sucursal"
        LueSucEntrada.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        LueSucEntrada.Properties.ForceInitialize()


        LueSucSalida.Properties.DataSource = BusquedaSeleccion("Select IdSucursal, Sucursal FROM Sucursales Where Activa = 1")
        LueSucSalida.Properties.ValueMember = "IdSucursal"
        LueSucSalida.Properties.DisplayMember = "Sucursal"
        LueSucSalida.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        LueSucEntrada.Properties.ForceInitialize()

        txtNumRemision.Text = IIf(String.IsNullOrEmpty(DrEmpresa!Remisiones.ToString), "1", DrEmpresa!Remisiones.ToString)
        txtNumSucRemision.Text = BuscarRegistroSql("Sucursales", "NumDocRemision", "IdSucursal", CodSucursal)
        DteFecha.DateTime = Now

        Exit Sub
ErrException:
        XtraMessageBox.Show(Err.Description, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
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

        For Each DCDetalle As DevExpress.XtraGrid.Columns.GridColumn In gvRemisiones.Columns
            gvRemisiones.Columns(DCDetalle.FieldName).OptionsColumn.AllowEdit = False
            If DCDetalle.FieldName = "Cantidad" Then
                gvRemisiones.Columns(DCDetalle.FieldName).OptionsColumn.AllowEdit = True
            End If
        Next
        Exit Sub
tipoerr:
        MsgBox(Err.Description, MsgBoxStyle.Critical)
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

    Private Sub txtCantidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCantidad.KeyPress
        ValidarNumeroDecimal(txtCantidad.Text, e)
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Dispose()
        Me.Close()
    End Sub
End Class