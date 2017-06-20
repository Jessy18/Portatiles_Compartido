Imports DevExpress.XtraReports.UI
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
        Node = CInt(Me.TreeList1.FocusedNode.Id)
        If Node = 0 Then
            Dim Rpt As RptExistenciaXSucursal = New RptExistenciaXSucursal
            Dim Tool As ReportPrintTool = New ReportPrintTool(Rpt)
            Tool.ShowPreview()
        ElseIf Node = 1 Then
            Dim Rpt As RptExistenciaXSucursal = New RptExistenciaXSucursal
            Dim Tool As ReportPrintTool = New ReportPrintTool(Rpt)
            Tool.ShowPreview()
        ElseIf Node = 2 Then
            Dim Rpt As RptExistenciaXSucursal = New RptExistenciaXSucursal
            Dim Tool As ReportPrintTool = New ReportPrintTool(Rpt)
            Tool.ShowPreview()
        ElseIf Node = 3 Then
            Dim Rpt As RptExistenciaXSucursal = New RptExistenciaXSucursal
            Dim Tool As ReportPrintTool = New ReportPrintTool(Rpt)
            Tool.ShowPreview()
        End If
    End Sub
End Class