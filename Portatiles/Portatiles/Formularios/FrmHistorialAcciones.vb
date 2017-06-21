Imports DevExpress.XtraEditors
Imports DevExpress.XtraReports.UI

Public Class FrmHistorialAcciones

    Private Sub FrmHistorialAccion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dteFechaINI.DateTime = Now
        dteFechaFIN.DateTime = Now

        glueSucursal.Properties.DataSource = BusquedaSeleccion("Sucursales_GLUE '" & Str(IdEmpresa) & "'")
        glueSucursal.Properties.ValueMember = "IdSucursal"
        glueSucursal.Properties.DisplayMember = "Sucursal"
        glueSucursal.Properties.PopulateViewColumns()
        gvlueSucursal.Columns(0).Visible = False

        glueUsuario.Properties.DataSource = BusquedaSeleccion("Usuarios_GLUE")
        glueUsuario.Properties.ValueMember = "IdUsuario"
        glueUsuario.Properties.DisplayMember = "Usuario"
        glueUsuario.Properties.PopulateViewColumns()
        gvlueUsuario.Columns(0).Visible = False

        btnFiltrar.PerformClick()
    End Sub

    Private Sub btnFiltrar_Click(sender As Object, e As EventArgs) Handles btnFiltrar.Click
        On Error GoTo ErrException

        GenericSql = "SELECT Fecha, IdUsuario, Usuario, Modulo, Accion, NumDoc, IdSucursal, DatosOLD, DatosNEW from HistorialAcciones"
        GenericSql += " WHERE IdEmpresa = '" & IdEmpresa.ToString & "' AND Convert(Date, Fecha) BETWEEN '" & dteFechaINI.DateTime.ToString("yyyy/MM/dd") & "' AND '" & dteFechaFIN.DateTime.ToString("yyyy/MM/dd") & "'"

        If glueUsuario.Text <> "" Then
            GenericSql += " AND IdUsuario = '" & glueUsuario.EditValue.ToString & "'"
        End If

        If glueSucursal.Text <> "" Then
            GenericSql += " AND IdSucursal = '" & glueSucursal.EditValue.ToString & "'"
        End If

        gcHistorial.DataSource = BusquedaSeleccion(GenericSql)
        gvHistorial.PopulateColumns()
        gvHistorial.Columns("DatosOLD").Visible = False
        gvHistorial.Columns("DatosNEW").Visible = False
        gvHistorial.ViewCaption = "Registros encontrados: " & gvHistorial.RowCount

        Exit Sub
ErrException:
        XtraMessageBox.Show(Err.Description, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Dispose()
        Me.Close()
    End Sub

    Private Sub LabelControl1_Click(sender As Object, e As EventArgs) Handles LabelControl1.Click
        glueUsuario.EditValue = Nothing
    End Sub

    Private Sub LabelControl4_Click(sender As Object, e As EventArgs) Handles LabelControl4.Click
        glueSucursal.EditValue = Nothing
    End Sub

    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        Dim Report As xrHistorialAcciones = New xrHistorialAcciones
        Dim Tool As ReportPrintTool = New ReportPrintTool(Report)
        Tool.ShowPreview()
    End Sub
End Class