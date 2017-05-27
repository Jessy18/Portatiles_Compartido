Public Class RFMDI 

   
  
    Private Sub RFMDI_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarConfiguracion()

        'FrmTile.TopLevel = False
        'FrmTile.Parent = Me.PanelTile
        'FrmTile.Show()

        'If btsVerPanelLatIzq.Checked Then
        '    Me.PanelTile.Visible = True
        'Else
        '    Me.PanelTile.Visible = False
        'End If

    End Sub

    Private Sub BBICatalogos_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BBICatalogos.ItemClick
        If Not Administrador Then
            If Not PuedeAcceder("Catálogos", "Catálogos") Then Exit Sub
        End If

        FrmCatalogos.MdiParent = Me
        FrmCatalogos.Show()
    End Sub

    Private Sub BBIConfiguracion_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BBIConfiguracion.ItemClick
        If Not Administrador Then
            If Not PuedeAcceder("Herramientas", "Configuración") Then Exit Sub
        End If

        FrmConfiguracion.MdiParent = Me
        FrmConfiguracion.Show()
    End Sub

    Private Sub BBIAjustes_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BBIAjustes.ItemClick
        If Not Administrador Then
            If Not PuedeAcceder("Movimientos", "Ajustes de Inventario") Then Exit Sub
        End If

        FrmAjustes.MdiParent = Me
        FrmAjustes.Show()
    End Sub

    Private Sub BBICompras_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BBICompras.ItemClick
        If Not Administrador Then
            If Not PuedeAcceder("Movimientos", "Compras") Then Exit Sub
        End If

        FrmCompras.MdiParent = Me
        FrmCompras.Show()
    End Sub

    Private Sub BBIListadoAjustes_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BBIListadoAjustes.ItemClick
        If Not Administrador Then
            If Not PuedeAcceder("Listados", "Listado de Ajustes de Inventario") Then Exit Sub
        End If

        MovimientoListado = "Ajustes"
        FrmListado.MdiParent = Me
        FrmListado.Show()
    End Sub

    Private Sub BBIListaFacturas_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BBIListaFacturas.ItemClick
        If Not Administrador Then
            If Not PuedeAcceder("Listados", "Listado de Facturas") Then Exit Sub
        End If

        MovimientoListado = "Ventas"
        FrmListado.MdiParent = Me
        FrmListado.Show()
    End Sub

    Private Sub BBIListaRemisiones_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BBIListaRemisiones.ItemClick
        If Not Administrador Then
            If Not PuedeAcceder("Listados", "Listado de Remisiones") Then Exit Sub
        End If

        MovimientoListado = "Remisiones"
        FrmListado.MdiParent = Me
        FrmListado.Show()
    End Sub

    Private Sub BBIListadoCompras_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BBIListadoCompras.ItemClick
        If Not Administrador Then
            If Not PuedeAcceder("Listados", "Listado de Compras") Then Exit Sub
        End If

        MovimientoListado = "Compras"
        FrmListado.MdiParent = Me
        FrmListado.Show()
    End Sub

    Private Sub BBIImportador_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BBIImportador.ItemClick
        If Not Administrador Then
            If Not PuedeAcceder("Herramientas", "Importador") Then Exit Sub
        End If

        FrmImportador.MdiParent = Me
        FrmImportador.Show()
    End Sub

    Private Sub bbiPermisos_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiPermisos.ItemClick
        If Not Administrador Then
            DevExpress.XtraEditors.XtraMessageBox.Show("No tiene permiso para acceder a este módulo", "Acceso Denegado", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        FrmPermisos.MdiParent = Me
        FrmPermisos.Show()
    End Sub

   
    Private Sub bbiVerTile_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiVerTile.ItemClick
        FrmTile.MdiParent = Me
        FrmTile.Show()
    End Sub

    Private Sub btsVerPanelLatIzq_CheckedChanged(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btsVerPanelLatIzq.CheckedChanged
        If btsVerPanelLatIzq.Checked Then
            PanelIzq.Visible = True
        Else
            PanelIzq.Visible = False
            ToggleAgenda.IsOn = False
        End If

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        TxtReloj.Text = Now.ToLongTimeString()
    End Sub

    Private Sub ToggleAgenda_Toggled(sender As Object, e As EventArgs) Handles ToggleAgenda.Toggled
        If ToggleAgenda.IsOn Then
            PanelAgenda.Visible = True
        Else
            PanelAgenda.Visible = False
        End If

    End Sub

    Private Sub BBIRemision_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BBIRemision.ItemClick
        If Not Administrador Then
            If Not PuedeAcceder("Movimientos", "Remisiones") Then Exit Sub
        End If

        FrmRemisiones.MdiParent = Me
        FrmRemisiones.Show()
    End Sub
End Class