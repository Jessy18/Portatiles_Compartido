﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class RptExistenciaSucursal
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
        Me.xrTableRow2 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.xrTableCell4 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.xrTableCell5 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.xrTableCell6 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.TableHeader = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.xrTableCell1 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.xrTableCell3 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.xrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.GroupHeader = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.xrTableRow1 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.xrTableCell2 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.xrTable2 = New DevExpress.XtraReports.UI.XRTable()
        Me.EvenStyle = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.xrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.Detail1 = New DevExpress.XtraReports.UI.DetailBand()
        Me.xrLine1 = New DevExpress.XtraReports.UI.XRLine()
        Me.xrPictureBox1 = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.GroupFooter2 = New DevExpress.XtraReports.UI.GroupFooterBand()
        Me.xrLine3 = New DevExpress.XtraReports.UI.XRLine()
        Me.ReportHeading = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.xrTable1 = New DevExpress.XtraReports.UI.XRTable()
        Me.OddStyle = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.GroupFooter1 = New DevExpress.XtraReports.UI.GroupFooterBand()
        Me.DetailReport = New DevExpress.XtraReports.UI.DetailReportBand()
        Me.DataSet11 = New Portatiles.DataSet1()
        Me.SimpleTableAdapter = New Portatiles.DataSet1TableAdapters.simpleTableAdapter()
        Me.SimpleTableAdapter1 = New Portatiles.DataSet1TableAdapters.simpleTableAdapter()
        CType(Me.xrTable2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.xrTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'xrTableRow2
        '
        Me.xrTableRow2.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.xrTableCell4, Me.xrTableCell5, Me.xrTableCell6})
        Me.xrTableRow2.Name = "xrTableRow2"
        Me.xrTableRow2.Weight = 1.0R
        '
        'xrTableCell4
        '
        Me.xrTableCell4.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Categories.CategoriesProducts.ProductName")})
        Me.xrTableCell4.Name = "xrTableCell4"
        Me.xrTableCell4.Text = "xrTableCell4"
        Me.xrTableCell4.Weight = 3.6666665649414063R
        '
        'xrTableCell5
        '
        Me.xrTableCell5.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Categories.CategoriesProducts.UnitPrice")})
        Me.xrTableCell5.Name = "xrTableCell5"
        Me.xrTableCell5.Text = "xrTableCell5"
        Me.xrTableCell5.Weight = 1.2187499999999998R
        '
        'xrTableCell6
        '
        Me.xrTableCell6.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Categories.CategoriesProducts.UnitsInStock")})
        Me.xrTableCell6.Name = "xrTableCell6"
        Me.xrTableCell6.Text = "xrTableCell6"
        Me.xrTableCell6.Weight = 1.6145834350585939R
        '
        'TableHeader
        '
        Me.TableHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.TableHeader.Font = New System.Drawing.Font("Bernard MT Condensed", 20.25!)
        Me.TableHeader.ForeColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.TableHeader.Name = "TableHeader"
        Me.TableHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomLeft
        '
        'xrTableCell1
        '
        Me.xrTableCell1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "simple.Producto")})
        Me.xrTableCell1.Name = "xrTableCell1"
        Me.xrTableCell1.Weight = 3.6666665649414063R
        '
        'xrTableCell3
        '
        Me.xrTableCell3.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "simple.Existencia")})
        Me.xrTableCell3.Name = "xrTableCell3"
        Me.xrTableCell3.Weight = 1.6145834350585937R
        '
        'BottomMargin
        '
        Me.BottomMargin.HeightF = 100.0!
        Me.BottomMargin.Name = "BottomMargin"
        Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
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
        'GroupHeader
        '
        Me.GroupHeader.Font = New System.Drawing.Font("Bernard MT Condensed", 15.75!)
        Me.GroupHeader.ForeColor = System.Drawing.Color.FromArgb(CType(CType(115, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.GroupHeader.Name = "GroupHeader"
        '
        'xrTableRow1
        '
        Me.xrTableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.xrTableCell1, Me.xrTableCell2, Me.xrTableCell3})
        Me.xrTableRow1.Name = "xrTableRow1"
        Me.xrTableRow1.Weight = 1.0R
        '
        'xrTableCell2
        '
        Me.xrTableCell2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "simple.Precio1")})
        Me.xrTableCell2.Name = "xrTableCell2"
        Me.xrTableCell2.Weight = 1.21875R
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
        'EvenStyle
        '
        Me.EvenStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(184, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.EvenStyle.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.EvenStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(115, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.EvenStyle.Name = "EvenStyle"
        Me.EvenStyle.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        '
        'xrLabel2
        '
        Me.xrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(102.0!, 0.0!)
        Me.xrLabel2.Name = "xrLabel2"
        Me.xrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel2.SizeF = New System.Drawing.SizeF(548.0!, 64.0!)
        Me.xrLabel2.StyleName = "TableHeader"
        Me.xrLabel2.Text = "  [CategoryName]"
        '
        'Detail1
        '
        Me.Detail1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrTable2})
        Me.Detail1.HeightF = 23.33333!
        Me.Detail1.Name = "Detail1"
        '
        'xrLine1
        '
        Me.xrLine1.LineWidth = 4
        Me.xrLine1.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 64.0!)
        Me.xrLine1.Name = "xrLine1"
        Me.xrLine1.SizeF = New System.Drawing.SizeF(650.0!, 4.0!)
        Me.xrLine1.StyleName = "GroupHeader"
        '
        'xrPictureBox1
        '
        Me.xrPictureBox1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Image", Nothing, "Categories.Picture")})
        Me.xrPictureBox1.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 0.0!)
        Me.xrPictureBox1.Name = "xrPictureBox1"
        Me.xrPictureBox1.SizeF = New System.Drawing.SizeF(102.0!, 64.0!)
        Me.xrPictureBox1.Sizing = DevExpress.XtraPrinting.ImageSizeMode.Squeeze
        '
        'GroupFooter2
        '
        Me.GroupFooter2.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrLine3})
        Me.GroupFooter2.HeightF = 43.75!
        Me.GroupFooter2.Name = "GroupFooter2"
        '
        'xrLine3
        '
        Me.xrLine3.LineWidth = 4
        Me.xrLine3.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 0.0!)
        Me.xrLine3.Name = "xrLine3"
        Me.xrLine3.SizeF = New System.Drawing.SizeF(650.0!, 4.0!)
        Me.xrLine3.StyleName = "GroupHeader"
        '
        'ReportHeading
        '
        Me.ReportHeading.Font = New System.Drawing.Font("Bernard MT Condensed", 36.0!, System.Drawing.FontStyle.Bold)
        Me.ReportHeading.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.ReportHeading.Name = "ReportHeading"
        Me.ReportHeading.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'TopMargin
        '
        Me.TopMargin.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrLabel1})
        Me.TopMargin.HeightF = 71.75002!
        Me.TopMargin.Name = "TopMargin"
        Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
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
        Me.OddStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(115, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.OddStyle.Name = "OddStyle"
        Me.OddStyle.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
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
        'GroupFooter1
        '
        Me.GroupFooter1.HeightF = 100.0!
        Me.GroupFooter1.Name = "GroupFooter1"
        '
        'DetailReport
        '
        Me.DetailReport.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail1, Me.GroupFooter2})
        Me.DetailReport.DataAdapter = Me.SimpleTableAdapter1
        Me.DetailReport.DataSource = Me.DataSet11
        Me.DetailReport.Level = 0
        Me.DetailReport.Name = "DetailReport"
        '
        'DataSet11
        '
        Me.DataSet11.DataSetName = "DataSet1"
        Me.DataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SimpleTableAdapter
        '
        Me.SimpleTableAdapter.ClearBeforeFill = True
        '
        'SimpleTableAdapter1
        '
        Me.SimpleTableAdapter1.ClearBeforeFill = True
        '
        'RptExistenciaSucursal
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.DetailReport, Me.GroupFooter1})
        Me.DataAdapter = Me.SimpleTableAdapter
        Me.DataMember = "simple"
        Me.DataSource = Me.DataSet11
        Me.Margins = New System.Drawing.Printing.Margins(100, 100, 72, 100)
        Me.StyleSheet.AddRange(New DevExpress.XtraReports.UI.XRControlStyle() {Me.GroupHeader, Me.ReportHeading, Me.TableHeader, Me.EvenStyle, Me.OddStyle})
        Me.Version = "14.2"
        CType(Me.xrTable2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.xrTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents xrTableRow2 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents xrTableCell4 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents xrTableCell5 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents xrTableCell6 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents TableHeader As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents xrTableCell1 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents xrTableCell3 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents xrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents GroupHeader As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents xrTableRow1 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents xrTableCell2 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents xrTable2 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents EvenStyle As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents xrLabel2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Detail1 As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents xrLine1 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents xrPictureBox1 As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents GroupFooter2 As DevExpress.XtraReports.UI.GroupFooterBand
    Friend WithEvents xrLine3 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents ReportHeading As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents xrTable1 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents OddStyle As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents GroupFooter1 As DevExpress.XtraReports.UI.GroupFooterBand
    Friend WithEvents DetailReport As DevExpress.XtraReports.UI.DetailReportBand
    Friend WithEvents DataSet11 As Portatiles.DataSet1
    Friend WithEvents SimpleTableAdapter As Portatiles.DataSet1TableAdapters.simpleTableAdapter
    Friend WithEvents SimpleTableAdapter1 As Portatiles.DataSet1TableAdapters.simpleTableAdapter
End Class
