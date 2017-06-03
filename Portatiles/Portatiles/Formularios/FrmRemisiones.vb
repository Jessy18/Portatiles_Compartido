imports DevExpress.XtraEditors.Controls
imports DevExpress.XtraGrid
imports DevExpress.XtraGrid.Views.Grid
imports DevExpress.XtraEditors
imports System.Globalization
imports DevExpress.XtraGrid.Views.Grid.ViewInfo
imports DevExpress.XtraBars
imports DevExpress.XtraGrid.Columns

Public Class FrmRemisiones

    Dim DrEmpresa As DataRow
    Dim DtDetalle As DataTable

    Private Sub FrmRemisiones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        On Error GoTo ErrException

        DrEmpresa = BusquedaSeleccionFila("Select * From Empresa")

        Me.LimpiarFormulario(0)

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

        gLueUserAutoriza.Properties.DataSource = BusquedaSeleccion("Select IdUsuario, Nombre AS Usuario FROM Usuarios Where Activo = 1 ")
        gLueUserAutoriza.Properties.DisplayMember = "Usuario"
        gLueUserAutoriza.Properties.ValueMember = "IdUsuario"
        gLueUserAutoriza.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        gLueUserAutoriza.ForceInitialize()

        CrearTabla()
        txtNumRemision.Text = IIf(String.IsNullOrEmpty(DrEmpresa!Remisiones.ToString), "1", DrEmpresa!Remisiones.ToString)
        txtNumSucRemision.Text = BuscarRegistroSql("Sucursales", "NumRemisionSuc", "IdSucursal", CodSucursal)
        DteFecha.DateTime = Now

        Exit Sub
ErrException:
        XtraMessageBox.Show(Err.Description, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

    ''' <summary>
    ''' Función que limpia los campos del formulario
    ''' </summary>
    ''' <param name="QueLimpia">0: Limpia Todo, 1: Limpia la Sección de Productos
    ''' Otro número: Limpia Todo</param>
    ''' <param name="LimpiaCodProducto">En caso de que limpiea la sección de productos,
    ''' especificar si limpia también el Código de Producto</param>
    ''' <remarks></remarks>
    Private Sub LimpiarFormulario(ByVal QueLimpia As Integer, Optional ByVal LimpiaCodProducto As Boolean = True)
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

        For Each DCDetalle As GridColumn In gvRemisiones.Columns
            gvRemisiones.Columns(DCDetalle.FieldName).OptionsColumn.AllowEdit = False
            If DCDetalle.FieldName = "Cantidad" Then
                gvRemisiones.Columns(DCDetalle.FieldName).OptionsColumn.AllowEdit = True
            Else
                gvRemisiones.Columns(DCDetalle.FieldName).OptionsColumn.AllowEdit = False
            End If
        Next

        DtDetalle.Rows.Add({"1", "Ariel", 2, 5})

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
        On Error GoTo ErrException
        If Guardar() Then
            Me.FrmRemisiones_Load(sender, e)
        End If
        Exit Sub
ErrException:
        XtraMessageBox.Show("Error Nº" & Err.Number & ": " & Environment.NewLine & Err.Description, "Ha ocurrido un error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

    Private Function Guardar() As Boolean
        If IsNothing(LueSucEntrada.EditValue) Then
            XtraMessageBox.Show("Olvidó seleccionar la Sucursal de Entrada de Productos", "Faltan llenar datos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        If IsNothing(LueSucSalida.EditValue) Then
            XtraMessageBox.Show("Olvidó seleccionar la Sucursal de Salida de Productos", "Faltan llenar datos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        If gvRemisiones.RowCount <= 0 Then
            XtraMessageBox.Show("No ha agregado productos a la tabla!" & vbNewLine & "Por favor proceda a agregar productos para efetuar la Remisión", "Faltan agregar productos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        'Obtenemos el último número de Remision, y una vez que lo obtenemos,  lo actualizamos 
        DrEmpresa = BusquedaSeleccionFila("Select * From Empresa")
        txtNumRemision.Text = DrEmpresa!Remisiones.ToString()
        EjecutarConsulta("UPDATE Empresa SET [Remisiones] = [Remisiones] + 1")

        Dim DrSucursal As DataRow = BusquedaSeleccionFila("Select * From Sucursales Where IdSucursal = '" & LueSucSalida.EditValue.ToString & "'")
        If Not IsDBNull(DrSucursal!NumRemisionSuc) Then
            txtNumSucRemision.Text = DrSucursal!NumRemisionSuc.ToString
        Else
            txtNumSucRemision.Text = "1"
        End If

        GenericSql = "INSERT INTO Remisiones (NumRemision, IdSucursalSalida, IdSucursalEntrada, IdUsuRemite, IdUsuAutoriza, IdUsuRecibe, NumRemisionSuc, Fecha, Observaciones, Total, Editar, Anulada) VALUES        (@NumRemision,@IdSucursalSalida,@IdSucursalEntrada,@IdUsuRemite,@IdUsuAutoriza,@IdUsuRecibe,@NumDocRemision,@Fecha,@Observaciones,@Total,@Editar,@Anulada)"
        CrearComando(GenericSql)
        With Comando.Parameters
            .AddWithValue("NumRemision", Val(txtNumRemision.Text))
            .AddWithValue("IdSucursalSalida", LueSucSalida.EditValue.ToString)
            .AddWithValue("IdSucursalEntrada", LueSucEntrada.EditValue.ToString)
            .AddWithValue("IdUsuRemite", CodUsuario)
            .AddWithValue("IdUsuAutoriza", gLueUserAutoriza.EditValue)
            .AddWithValue("IdUsuRecibe", gLueUserRecibe.EditValue)
            .AddWithValue("NumRemisionSuc", Val(txtNumSucRemision.Text))
            .AddWithValue("Fecha", Now)
            .AddWithValue("Observaciones", TxtObservaciones.Text.Trim)
            .AddWithValue("Total", txtNumRemision.Text)
            .AddWithValue("Editar", 0)
            .AddWithValue("Anulada", 0)
        End With

    End Function

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Dispose()
        Me.Close()
    End Sub

    Private Sub LueSucEntrada_EditValueChanged(sender As Object, e As EventArgs) Handles LueSucEntrada.EditValueChanged
        gLueUserRecibe.EditValue = Nothing
        If Not String.IsNullOrEmpty(LueSucEntrada.EditValue) Then
            gLueUserRecibe.Properties.DataSource = BusquedaSeleccion("Select IdUsuario, Nombre AS Usuario FROM Usuarios Where Activo = 1 AND IdSucursal='" & LueSucEntrada.EditValue.ToString & "'")
            gLueUserRecibe.Properties.ValueMember = "IdUsuario"
            gLueUserRecibe.Properties.DisplayMember = "Usuario"
            gLueUserRecibe.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
            gLueUserRecibe.ForceInitialize()
            gvLueUserRecibe.Columns(0).Visible = False
        End If
    End Sub

    Private Sub gvRemisiones_CellValueChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs)
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
End Class