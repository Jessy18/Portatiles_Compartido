<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class xrUsuariosAct
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
        Me.formattingRule1 = New DevExpress.XtraReports.UI.FormattingRule()
        Me.xrTableRow2 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.TableHeaderStyle = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.xrTableCell5 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.LavenderStyle = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.White = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.xrTableCell4 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand()
        Me.xrTableCell2 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.xrTableCell12 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.xrTableCell8 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.xrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.xrTable1 = New DevExpress.XtraReports.UI.XRTable()
        Me.xrTable2 = New DevExpress.XtraReports.UI.XRTable()
        Me.xrTableCell1 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.GroupHeader1 = New DevExpress.XtraReports.UI.GroupHeaderBand()
        Me.xrTableRow1 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.LightBlue = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.xrTableCell3 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.xrTableCell7 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.TableStyle = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.PageFooter = New DevExpress.XtraReports.UI.PageFooterBand()
        Me.xrTableCell9 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.xrTableCell6 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.DsUsuarios1 = New Portatiles.dsUsuarios()
        Me.QueriesTableAdapter1 = New Portatiles.dsUsuariosTableAdapters.QueriesTableAdapter()
        Me.QueriesTableAdapter2 = New Portatiles.dsUsuariosTableAdapters.QueriesTableAdapter()
        CType(Me.xrTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.xrTable2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsUsuarios1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'formattingRule1
        '
        Me.formattingRule1.Name = "formattingRule1"
        '
        'xrTableRow2
        '
        Me.xrTableRow2.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.xrTableCell4, Me.xrTableCell3, Me.xrTableCell7, Me.xrTableCell8, Me.xrTableCell12})
        Me.xrTableRow2.Name = "xrTableRow2"
        Me.xrTableRow2.Weight = 1.0R
        '
        'TableHeaderStyle
        '
        Me.TableHeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.TableHeaderStyle.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold)
        Me.TableHeaderStyle.ForeColor = System.Drawing.Color.White
        Me.TableHeaderStyle.Name = "TableHeaderStyle"
        Me.TableHeaderStyle.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 0, 0, 0, 100.0!)
        '
        'xrTableCell5
        '
        Me.xrTableCell5.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Employees.BirthDate", "{0:MM/dd}")})
        Me.xrTableCell5.Name = "xrTableCell5"
        Me.xrTableCell5.Text = "xrTableCell12"
        Me.xrTableCell5.Weight = 1.1767994929282322R
        '
        'LavenderStyle
        '
        Me.LavenderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.LavenderStyle.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.LavenderStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(79, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.LavenderStyle.Name = "LavenderStyle"
        Me.LavenderStyle.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 0, 0, 0, 100.0!)
        '
        'White
        '
        Me.White.BackColor = System.Drawing.Color.White
        Me.White.BorderWidth = 0.0!
        Me.White.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.White.ForeColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(79, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.White.Name = "White"
        Me.White.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 0, 0, 0, 100.0!)
        '
        'Detail
        '
        Me.Detail.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Detail.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrTable1})
        Me.Detail.HeightF = 25.0!
        Me.Detail.Name = "Detail"
        Me.Detail.OddStyleName = "LightBlue"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'xrTableCell4
        '
        Me.xrTableCell4.Name = "xrTableCell4"
        Me.xrTableCell4.Text = "First"
        Me.xrTableCell4.Weight = 1.4853570466572541R
        '
        'PageHeader
        '
        Me.PageHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PageHeader.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrLabel1})
        Me.PageHeader.HeightF = 80.20834!
        Me.PageHeader.Name = "PageHeader"
        Me.PageHeader.StylePriority.UseBackColor = False
        Me.PageHeader.StylePriority.UseBorderColor = False
        '
        'xrTableCell2
        '
        Me.xrTableCell2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Employees.Extension")})
        Me.xrTableCell2.Name = "xrTableCell2"
        Me.xrTableCell2.Text = "xrTableCell8"
        Me.xrTableCell2.Weight = 0.92473156617760743R
        '
        'xrTableCell12
        '
        Me.xrTableCell12.Name = "xrTableCell12"
        Me.xrTableCell12.Text = "Birthday"
        Me.xrTableCell12.Weight = 1.4757684712560988R
        '
        'xrTableCell8
        '
        Me.xrTableCell8.Name = "xrTableCell8"
        Me.xrTableCell8.Text = "Ext."
        Me.xrTableCell8.Weight = 1.1565207043104846R
        '
        'xrLabel1
        '
        Me.xrLabel1.BorderWidth = 0.0!
        Me.xrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 10.00001!)
        Me.xrLabel1.Name = "xrLabel1"
        Me.xrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.xrLabel1.SizeF = New System.Drawing.SizeF(650.0!, 60.20834!)
        Me.xrLabel1.StyleName = "TableStyle"
        Me.xrLabel1.Text = "Employees"
        '
        'xrTable1
        '
        Me.xrTable1.EvenStyleName = "LavenderStyle"
        Me.xrTable1.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 0.0!)
        Me.xrTable1.Name = "xrTable1"
        Me.xrTable1.OddStyleName = "White"
        Me.xrTable1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.xrTableRow1})
        Me.xrTable1.SizeF = New System.Drawing.SizeF(649.6747!, 25.0!)
        '
        'xrTable2
        '
        Me.xrTable2.BackColor = System.Drawing.Color.White
        Me.xrTable2.ForeColor = System.Drawing.Color.Black
        Me.xrTable2.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 0.0!)
        Me.xrTable2.Name = "xrTable2"
        Me.xrTable2.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.xrTableRow2})
        Me.xrTable2.SizeF = New System.Drawing.SizeF(650.0!, 25.0!)
        Me.xrTable2.StyleName = "TableHeaderStyle"
        '
        'xrTableCell1
        '
        Me.xrTableCell1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Employees.Title")})
        Me.xrTableCell1.Name = "xrTableCell1"
        Me.xrTableCell1.Text = "text"
        Me.xrTableCell1.Weight = 1.812015190512982R
        '
        'GroupHeader1
        '
        Me.GroupHeader1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GroupHeader1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GroupHeader1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrTable2})
        Me.GroupHeader1.GroupFields.AddRange(New DevExpress.XtraReports.UI.GroupField() {New DevExpress.XtraReports.UI.GroupField("ProductName", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
        Me.GroupHeader1.HeightF = 25.0!
        Me.GroupHeader1.Name = "GroupHeader1"
        Me.GroupHeader1.RepeatEveryPage = True
        '
        'xrTableRow1
        '
        Me.xrTableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.xrTableCell6, Me.xrTableCell9, Me.xrTableCell1, Me.xrTableCell2, Me.xrTableCell5})
        Me.xrTableRow1.Name = "xrTableRow1"
        Me.xrTableRow1.Weight = 1.0R
        '
        'LightBlue
        '
        Me.LightBlue.BackColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.LightBlue.Name = "LightBlue"
        '
        'xrTableCell3
        '
        Me.xrTableCell3.Name = "xrTableCell3"
        Me.xrTableCell3.Text = "Last"
        Me.xrTableCell3.Weight = 1.6065655694919694R
        '
        'TopMargin
        '
        Me.TopMargin.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TopMargin.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TopMargin.HeightF = 72.91666!
        Me.TopMargin.Name = "TopMargin"
        Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.TopMargin.StylePriority.UseBackColor = False
        Me.TopMargin.StylePriority.UseBorderColor = False
        Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'xrTableCell7
        '
        Me.xrTableCell7.Name = "xrTableCell7"
        Me.xrTableCell7.StyleName = "TableHeaderStyle"
        Me.xrTableCell7.Text = "Title"
        Me.xrTableCell7.Weight = 2.2662051928422979R
        '
        'TableStyle
        '
        Me.TableStyle.BackColor = System.Drawing.Color.White
        Me.TableStyle.BorderColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.TableStyle.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid
        Me.TableStyle.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.TableStyle.Font = New System.Drawing.Font("Calibri", 36.0!)
        Me.TableStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.TableStyle.Name = "TableStyle"
        Me.TableStyle.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 0, 0, 0, 100.0!)
        '
        'PageFooter
        '
        Me.PageFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PageFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PageFooter.Borders = CType((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.PageFooter.HeightF = 100.0!
        Me.PageFooter.Name = "PageFooter"
        '
        'xrTableCell9
        '
        Me.xrTableCell9.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Employees.LastName")})
        Me.xrTableCell9.Name = "xrTableCell9"
        Me.xrTableCell9.Text = "xrTableCell9"
        Me.xrTableCell9.Weight = 1.2845793504698684R
        '
        'xrTableCell6
        '
        Me.xrTableCell6.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Employees.FirstName")})
        Me.xrTableCell6.Name = "xrTableCell6"
        Me.xrTableCell6.Text = "xrTableCell6"
        Me.xrTableCell6.Weight = 1.187663299618577R
        '
        'BottomMargin
        '
        Me.BottomMargin.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BottomMargin.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BottomMargin.HeightF = 272.9167!
        Me.BottomMargin.Name = "BottomMargin"
        Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'DsUsuarios1
        '
        Me.DsUsuarios1.DataSetName = "dsUsuarios"
        Me.DsUsuarios1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'xrUsuariosAct
        '
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.GroupHeader1, Me.PageHeader, Me.PageFooter})
        Me.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.DataAdapter = Me.QueriesTableAdapter2
        Me.DataSource = Me.DsUsuarios1
        Me.Font = New System.Drawing.Font("Arial Narrow", 9.75!)
        Me.FormattingRules.Add(Me.formattingRule1)
        Me.FormattingRuleSheet.AddRange(New DevExpress.XtraReports.UI.FormattingRule() {Me.formattingRule1})
        Me.Margins = New System.Drawing.Printing.Margins(100, 100, 73, 273)
        Me.StyleSheet.AddRange(New DevExpress.XtraReports.UI.XRControlStyle() {Me.LightBlue, Me.TableHeaderStyle, Me.TableStyle, Me.White, Me.LavenderStyle})
        Me.Version = "14.2"
        CType(Me.xrTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.xrTable2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsUsuarios1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents formattingRule1 As DevExpress.XtraReports.UI.FormattingRule
    Friend WithEvents xrTableRow2 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents xrTableCell4 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents xrTableCell3 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents xrTableCell7 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents xrTableCell8 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents xrTableCell12 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents TableHeaderStyle As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents xrTableCell5 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents LavenderStyle As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents White As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents xrTable1 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents xrTableRow1 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents xrTableCell6 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents xrTableCell9 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents xrTableCell1 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents xrTableCell2 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents PageHeader As DevExpress.XtraReports.UI.PageHeaderBand
    Friend WithEvents xrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents xrTable2 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents GroupHeader1 As DevExpress.XtraReports.UI.GroupHeaderBand
    Friend WithEvents LightBlue As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents TableStyle As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents PageFooter As DevExpress.XtraReports.UI.PageFooterBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents DsUsuarios1 As Portatiles.dsUsuarios
    Friend WithEvents QueriesTableAdapter1 As Portatiles.dsUsuariosTableAdapters.QueriesTableAdapter
    Friend WithEvents QueriesTableAdapter2 As Portatiles.dsUsuariosTableAdapters.QueriesTableAdapter
End Class
