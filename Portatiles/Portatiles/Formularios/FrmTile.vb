Public Class FrmTile 

    Private Sub titCatalogos_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles titCatalogos.ItemClick
        RFMDI.BBICatalogos.PerformClick()
    End Sub

    Private Sub titPermisos_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles titPermisos.ItemClick
        RFMDI.bbiPermisos.PerformClick()
    End Sub

    Private Sub titConfig_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles titConfig.ItemClick
        RFMDI.BBIConfiguracion.PerformClick()
    End Sub

    Private Sub titFacturacion_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles titFacturacion.ItemClick
        RFMDI.BBIFacturacion.PerformClick()
    End Sub

    Private Sub titCompras_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles titCompras.ItemClick
        RFMDI.BBICompras.PerformClick()
    End Sub

    Private Sub titSalir_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles titSalir.ItemClick
        Me.Dispose()
        Me.Close()
    End Sub
End Class