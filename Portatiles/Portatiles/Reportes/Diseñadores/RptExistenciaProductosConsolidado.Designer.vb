<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class RptExistenciaProductosConsolidado
    Inherits DevExpress.XtraReports.UI.XtraReport

    'XtraReport overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Designer
    'It can be modified using the Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.xrPictureBox1 = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.GroupFooter1 = New DevExpress.XtraReports.UI.GroupFooterBand()
        Me.ReportHeading = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.xrTable1 = New DevExpress.XtraReports.UI.XRTable()
        Me.OddStyle = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.GroupHeader = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.xrLine3 = New DevExpress.XtraReports.UI.XRLine()
        Me.xrTable2 = New DevExpress.XtraReports.UI.XRTable()
        Me.xrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrTableCell3 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.xrTableCell1 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.xrTableCell5 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.EvenStyle = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.xrTableCell6 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.Detail1 = New DevExpress.XtraReports.UI.DetailBand()
        Me.xrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.GroupFooter2 = New DevExpress.XtraReports.UI.GroupFooterBand()
        Me.xrTableCell2 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.xrTableRow2 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.TableHeader = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.DetailReport = New DevExpress.XtraReports.UI.DetailReportBand()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.xrLine1 = New DevExpress.XtraReports.UI.XRLine()
        Me.xrTableCell4 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.xrTableRow1 = New DevExpress.XtraReports.UI.XRTableRow()
        CType(Me.xrTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.xrTable2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'xrPictureBox1
        '
        Me.xrPictureBox1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Image", Nothing, "Categories.Picture")})
        Me.xrPictureBox1.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 0.0!)
        Me.xrPictureBox1.Name = "xrPictureBox1"
        Me.xrPictureBox1.SizeF = New System.Drawing.SizeF(102.0!, 64.0!)
        Me.xrPictureBox1.Sizing = DevExpress.XtraPrinting.ImageSizeMode.Squeeze
        '
        'GroupFooter1
        '
        Me.GroupFooter1.HeightF = 100.0!
        Me.GroupFooter1.Name = "GroupFooter1"
        '
        'ReportHeading
        '
        Me.ReportHeading.Font = New System.Drawing.Font("Bernard MT Condensed", 36.0!, System.Drawing.FontStyle.Bold)
        Me.ReportHeading.ForeColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.ReportHeading.Name = "ReportHeading"
        Me.ReportHeading.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'xrTable1
        '
        Me.xrTable1.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 68.58336!)
        Me.xrTable1.Name = "xrTable1"
        Me.xrTable1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.xrTableRow1})
        Me.xrTable1.SizeF = New System.Drawing.SizeF(650.0!, 30.62502!)
        Me.xrTable1.StyleName = "GroupHeader"
        '
        'OddStyle
        '
        Me.OddStyle.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.OddStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(13, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.OddStyle.Name = "OddStyle"
        Me.OddStyle.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        '
        'TopMargin
        '
        Me.TopMargin.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrLabel1})
        Me.TopMargin.HeightF = 71.75002!
        Me.TopMargin.Name = "TopMargin"
        Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'GroupHeader
        '
        Me.GroupHeader.Font = New System.Drawing.Font("Bernard MT Condensed", 15.75!)
        Me.GroupHeader.ForeColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(4, Byte), Integer))
        Me.GroupHeader.Name = "GroupHeader"
        '
        'xrLine3
        '
        Me.xrLine3.LineWidth = 4
        Me.xrLine3.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 0.0!)
        Me.xrLine3.Name = "xrLine3"
        Me.xrLine3.SizeF = New System.Drawing.SizeF(650.0!, 4.0!)
        Me.xrLine3.StyleName = "GroupHeader"
        '
        'xrTable2
        '
        Me.xrTable2.EvenStyleName = "EvenStyle"
        Me.xrTable2.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 0.0!)
        Me.xrTable2.Name = "xrTable2"
        Me.xrTable2.OddStyleName = "OddStyle"
        Me.xrTable2.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.xrTableRow2})
        Me.xrTable2.SizeF = New System.Drawing.SizeF(650.0!, 23.33333!)
        '
        'xrLabel2
        '
        Me.xrLabel2.Font = New System.Drawing.Font("Bernard MT Condensed", 20.25!)
        Me.xrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(102.0!, 0.0!)
        Me.xrLabel2.Name = "xrLabel2"
        Me.xrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel2.SizeF = New System.Drawing.SizeF(548.0!, 64.0!)
        Me.xrLabel2.StyleName = "TableHeader"
        Me.xrLabel2.StylePriority.UseFont = False
        Me.xrLabel2.Text = "  [CategoryName]"
        '
        'xrTableCell3
        '
        Me.xrTableCell3.Name = "xrTableCell3"
        Me.xrTableCell3.Text = "Units in Stock"
        Me.xrTableCell3.Weight = 1.6145834350585937R
        '
        'xrTableCell1
        '
        Me.xrTableCell1.Name = "xrTableCell1"
        Me.xrTableCell1.Text = "ProductName"
        Me.xrTableCell1.Weight = 3.6666665649414063R
        '
        'xrTableCell5
        '
        Me.xrTableCell5.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Categories.CategoriesProducts.UnitPrice")})
        Me.xrTableCell5.Name = "xrTableCell5"
        Me.xrTableCell5.Text = "xrTableCell5"
        Me.xrTableCell5.Weight = 1.2187499999999998R
        '
        'EvenStyle
        '
        Me.EvenStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(194, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.EvenStyle.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.EvenStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(13, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.EvenStyle.Name = "EvenStyle"
        Me.EvenStyle.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        '
        'xrTableCell6
        '
        Me.xrTableCell6.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Categories.CategoriesProducts.UnitsInStock")})
        Me.xrTableCell6.Name = "xrTableCell6"
        Me.xrTableCell6.Text = "xrTableCell6"
        Me.xrTableCell6.Weight = 1.6145834350585939R
        '
        'Detail1
        '
        Me.Detail1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrTable2})
        Me.Detail1.HeightF = 23.33333!
        Me.Detail1.Name = "Detail1"
        '
        'xrLabel1
        '
        Me.xrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 0.0!)
        Me.xrLabel1.Name = "xrLabel1"
        Me.xrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel1.SizeF = New System.Drawing.SizeF(580.2083!, 71.75002!)
        Me.xrLabel1.StyleName = "ReportHeading"
        Me.xrLabel1.Text = "Products by Category"
        '
        'GroupFooter2
        '
        Me.GroupFooter2.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrLine3})
        Me.GroupFooter2.HeightF = 43.75!
        Me.GroupFooter2.Name = "GroupFooter2"
        '
        'xrTableCell2
        '
        Me.xrTableCell2.Name = "xrTableCell2"
        Me.xrTableCell2.Text = "Unit Price"
        Me.xrTableCell2.Weight = 1.21875R
        '
        'xrTableRow2
        '
        Me.xrTableRow2.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.xrTableCell4, Me.xrTableCell5, Me.xrTableCell6})
        Me.xrTableRow2.Name = "xrTableRow2"
        Me.xrTableRow2.Weight = 1.0R
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrTable1, Me.xrLine1, Me.xrLabel2, Me.xrPictureBox1})
        Me.Detail.HeightF = 99.20837!
        Me.Detail.KeepTogetherWithDetailReports = True
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'TableHeader
        '
        Me.TableHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(203, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.TableHeader.Font = New System.Drawing.Font("Bernard MT Condensed", 15.75!)
        Me.TableHeader.ForeColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(13, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.TableHeader.Name = "TableHeader"
        Me.TableHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomLeft
        '
        'DetailReport
        '
        Me.DetailReport.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail1, Me.GroupFooter2})
        Me.DetailReport.DataMember = "Categories.CategoriesProducts"
        Me.DetailReport.Level = 0
        Me.DetailReport.Name = "DetailReport"
        '
        'BottomMargin
        '
        Me.BottomMargin.HeightF = 100.0!
        Me.BottomMargin.Name = "BottomMargin"
        Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'xrLine1
        '
        Me.xrLine1.LineWidth = 4
        Me.xrLine1.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 64.0!)
        Me.xrLine1.Name = "xrLine1"
        Me.xrLine1.SizeF = New System.Drawing.SizeF(650.0!, 4.0!)
        Me.xrLine1.StyleName = "GroupHeader"
        '
        'xrTableCell4
        '
        Me.xrTableCell4.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Categories.CategoriesProducts.ProductName")})
        Me.xrTableCell4.Name = "xrTableCell4"
        Me.xrTableCell4.Text = "xrTableCell4"
        Me.xrTableCell4.Weight = 3.6666665649414063R
        '
        'xrTableRow1
        '
        Me.xrTableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.xrTableCell1, Me.xrTableCell2, Me.xrTableCell3})
        Me.xrTableRow1.Name = "xrTableRow1"
        Me.xrTableRow1.Weight = 1.0R
        '
        'RptExistenciaProductosConsolidado
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.DetailReport, Me.GroupFooter1})
        Me.DataMember = "Categories"
        Me.Margins = New System.Drawing.Printing.Margins(100, 100, 72, 100)
        Me.StyleSheet.AddRange(New DevExpress.XtraReports.UI.XRControlStyle() {Me.GroupHeader, Me.ReportHeading, Me.TableHeader, Me.EvenStyle, Me.OddStyle})
        Me.Version = "14.2"
        CType(Me.xrTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.xrTable2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents xrPictureBox1 As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents GroupFooter1 As DevExpress.XtraReports.UI.GroupFooterBand
    Friend WithEvents ReportHeading As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents xrTable1 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents xrTableRow1 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents xrTableCell1 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents xrTableCell2 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents xrTableCell3 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents OddStyle As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents xrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents GroupHeader As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents xrLine3 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents xrTable2 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents xrTableRow2 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents xrTableCell4 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents xrTableCell5 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents xrTableCell6 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents xrLabel2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents EvenStyle As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents Detail1 As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents GroupFooter2 As DevExpress.XtraReports.UI.GroupFooterBand
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents xrLine1 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents TableHeader As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents DetailReport As DevExpress.XtraReports.UI.DetailReportBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
End Class
