<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmReportes
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.DtpFechaFin = New DevExpress.XtraEditors.DateEdit()
        Me.DtpFechaIni = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.treeListBand1 = New DevExpress.XtraTreeList.Columns.TreeListBand()
        Me.treeListBand2 = New DevExpress.XtraTreeList.Columns.TreeListBand()
        Me.treeListBand3 = New DevExpress.XtraTreeList.Columns.TreeListBand()
        Me.treeListBand4 = New DevExpress.XtraTreeList.Columns.TreeListBand()
        Me.TreeList1 = New DevExpress.XtraTreeList.TreeList()
        Me.TreeListColumn1 = New DevExpress.XtraTreeList.Columns.TreeListColumn()
        Me.BtnImprimir = New DevExpress.XtraEditors.SimpleButton()
        Me.BtnCerrar = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.DtpFechaFin.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DtpFechaFin.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DtpFechaIni.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DtpFechaIni.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TreeList1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupControl1
        '
        Me.GroupControl1.ContentImageAlignment = System.Drawing.ContentAlignment.TopCenter
        Me.GroupControl1.Controls.Add(Me.GroupControl2)
        Me.GroupControl1.Location = New System.Drawing.Point(0, 1)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(270, 109)
        Me.GroupControl1.TabIndex = 0
        Me.GroupControl1.Text = "Filtros"
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.DtpFechaFin)
        Me.GroupControl2.Controls.Add(Me.DtpFechaIni)
        Me.GroupControl2.Controls.Add(Me.LabelControl2)
        Me.GroupControl2.Controls.Add(Me.LabelControl1)
        Me.GroupControl2.Location = New System.Drawing.Point(5, 24)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(260, 76)
        Me.GroupControl2.TabIndex = 1
        Me.GroupControl2.Text = "Fecha"
        '
        'DtpFechaFin
        '
        Me.DtpFechaFin.EditValue = Nothing
        Me.DtpFechaFin.Location = New System.Drawing.Point(79, 48)
        Me.DtpFechaFin.Name = "DtpFechaFin"
        Me.DtpFechaFin.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DtpFechaFin.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DtpFechaFin.Size = New System.Drawing.Size(176, 20)
        Me.DtpFechaFin.TabIndex = 3
        '
        'DtpFechaIni
        '
        Me.DtpFechaIni.EditValue = Nothing
        Me.DtpFechaIni.Location = New System.Drawing.Point(79, 25)
        Me.DtpFechaIni.Name = "DtpFechaIni"
        Me.DtpFechaIni.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DtpFechaIni.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DtpFechaIni.Size = New System.Drawing.Size(176, 20)
        Me.DtpFechaIni.TabIndex = 2
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(6, 51)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(46, 13)
        Me.LabelControl2.TabIndex = 1
        Me.LabelControl2.Text = "Fecha Fin"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(6, 25)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(57, 13)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "Fecha Inicio"
        '
        'treeListBand1
        '
        Me.treeListBand1.Caption = "treeListBand1"
        Me.treeListBand1.Name = "treeListBand1"
        '
        'treeListBand2
        '
        Me.treeListBand2.Caption = "treeListBand2"
        Me.treeListBand2.Name = "treeListBand2"
        '
        'treeListBand3
        '
        Me.treeListBand3.Caption = "treeListBand3"
        Me.treeListBand3.Name = "treeListBand3"
        '
        'treeListBand4
        '
        Me.treeListBand4.Caption = "Reporte algo"
        Me.treeListBand4.MinWidth = 52
        Me.treeListBand4.Name = "treeListBand4"
        Me.treeListBand4.Visible = False
        '
        'TreeList1
        '
        Me.TreeList1.Columns.AddRange(New DevExpress.XtraTreeList.Columns.TreeListColumn() {Me.TreeListColumn1})
        Me.TreeList1.Location = New System.Drawing.Point(0, 116)
        Me.TreeList1.Name = "TreeList1"
        Me.TreeList1.BeginUnboundLoad()
        Me.TreeList1.AppendNode(New Object() {"Existencias de productos por sucursal"}, -1)
        Me.TreeList1.AppendNode(New Object() {"Existencias de productos consolidado"}, -1)
        Me.TreeList1.AppendNode(New Object() {"Compra con series detallados"}, -1)
        Me.TreeList1.AppendNode(New Object() {"Listado de compras detalladas"}, -1)
        Me.TreeList1.EndUnboundLoad()
        Me.TreeList1.Size = New System.Drawing.Size(270, 183)
        Me.TreeList1.TabIndex = 1
        '
        'TreeListColumn1
        '
        Me.TreeListColumn1.Caption = "Lista de Reportes"
        Me.TreeListColumn1.FieldName = "TreeListColumn1"
        Me.TreeListColumn1.MinWidth = 52
        Me.TreeListColumn1.Name = "TreeListColumn1"
        Me.TreeListColumn1.OptionsColumn.AllowEdit = False
        Me.TreeListColumn1.OptionsColumn.AllowSort = False
        Me.TreeListColumn1.Visible = True
        Me.TreeListColumn1.VisibleIndex = 0
        '
        'BtnImprimir
        '
        Me.BtnImprimir.Image = Global.Portatiles.My.Resources.Resources.Print_32x32
        Me.BtnImprimir.Location = New System.Drawing.Point(96, 305)
        Me.BtnImprimir.Name = "BtnImprimir"
        Me.BtnImprimir.Size = New System.Drawing.Size(84, 33)
        Me.BtnImprimir.TabIndex = 2
        Me.BtnImprimir.Text = "Imprimir"
        '
        'BtnCerrar
        '
        Me.BtnCerrar.Image = Global.Portatiles.My.Resources.Resources.Cancel
        Me.BtnCerrar.Location = New System.Drawing.Point(186, 305)
        Me.BtnCerrar.Name = "BtnCerrar"
        Me.BtnCerrar.Size = New System.Drawing.Size(84, 33)
        Me.BtnCerrar.TabIndex = 3
        Me.BtnCerrar.Text = "Cerrar"
        '
        'FrmReportes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(273, 338)
        Me.Controls.Add(Me.BtnCerrar)
        Me.Controls.Add(Me.BtnImprimir)
        Me.Controls.Add(Me.TreeList1)
        Me.Controls.Add(Me.GroupControl1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmReportes"
        Me.Text = "Formulario de Reportes"
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        Me.GroupControl2.PerformLayout()
        CType(Me.DtpFechaFin.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DtpFechaFin.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DtpFechaIni.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DtpFechaIni.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TreeList1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents DtpFechaFin As DevExpress.XtraEditors.DateEdit
    Friend WithEvents DtpFechaIni As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents treeListBand1 As DevExpress.XtraTreeList.Columns.TreeListBand
    Friend WithEvents treeListBand2 As DevExpress.XtraTreeList.Columns.TreeListBand
    Friend WithEvents treeListBand3 As DevExpress.XtraTreeList.Columns.TreeListBand
    Friend WithEvents treeListBand4 As DevExpress.XtraTreeList.Columns.TreeListBand
    Friend WithEvents TreeList1 As DevExpress.XtraTreeList.TreeList
    Friend WithEvents TreeListColumn1 As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents BtnImprimir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnCerrar As DevExpress.XtraEditors.SimpleButton
End Class
