Public Class FrmReportes 

    Private Sub TreeList1_FocusedNodeChanged(sender As Object, e As DevExpress.XtraTreeList.FocusedNodeChangedEventArgs)

    End Sub

    Private Sub FrmReportes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.DtpFechaFin.DateTime = Now
        Me.DtpFechaIni.DateTime = Now
    End Sub

    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles BtnCerrar.Click
        Me.Close()
        Me.Dispose()

    End Sub

    Private Sub BtnImprimir_Click(sender As Object, e As EventArgs) Handles BtnImprimir.Click
        Dim Node As Integer
        Node = CInt(Me.TreeList1.FocusedNode.ToString)
        If Node = 0 Then

        End If
    End Sub
End Class