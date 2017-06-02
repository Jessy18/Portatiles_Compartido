<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Kardex
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
        Me.btnSalir = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.btnBuscar = New DevExpress.XtraEditors.SimpleButton()
        Me.LblExistencia = New DevExpress.XtraEditors.LabelControl()
        Me.ChkFiltroFechas = New DevExpress.XtraEditors.CheckEdit()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.DteFechaFin = New DevExpress.XtraEditors.DateEdit()
        Me.lueProducto = New DevExpress.XtraEditors.LookUpEdit()
        Me.LblProducto = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.DteFechaIni = New DevExpress.XtraEditors.DateEdit()
        Me.txtExistencia = New DevExpress.XtraEditors.TextEdit()
        Me.gcAjustes = New DevExpress.XtraGrid.GridControl()
        Me.gvAjustes = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.btnImprimir = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.ChkFiltroFechas.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DteFechaFin.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DteFechaFin.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueProducto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DteFechaIni.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DteFechaIni.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtExistencia.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gcAjustes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvAjustes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSalir
        '
        Me.btnSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSalir.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Appearance.Options.UseFont = True
        Me.btnSalir.Appearance.Options.UseTextOptions = True
        Me.btnSalir.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSalir.Image = Global.Portatiles.My.Resources.Resources.Shutdown
        Me.btnSalir.Location = New System.Drawing.Point(644, 360)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(98, 48)
        Me.btnSalir.TabIndex = 6
        Me.btnSalir.Text = "Salir"
        '
        'GroupControl1
        '
        Me.GroupControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupControl1.Controls.Add(Me.btnBuscar)
        Me.GroupControl1.Controls.Add(Me.LblExistencia)
        Me.GroupControl1.Controls.Add(Me.ChkFiltroFechas)
        Me.GroupControl1.Controls.Add(Me.LabelControl5)
        Me.GroupControl1.Controls.Add(Me.DteFechaFin)
        Me.GroupControl1.Controls.Add(Me.lueProducto)
        Me.GroupControl1.Controls.Add(Me.LblProducto)
        Me.GroupControl1.Controls.Add(Me.LabelControl3)
        Me.GroupControl1.Controls.Add(Me.DteFechaIni)
        Me.GroupControl1.Controls.Add(Me.txtExistencia)
        Me.GroupControl1.Location = New System.Drawing.Point(2, 2)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(740, 109)
        Me.GroupControl1.TabIndex = 7
        Me.GroupControl1.Text = "Filtros"
        '
        'btnBuscar
        '
        Me.btnBuscar.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.Appearance.Options.UseFont = True
        Me.btnBuscar.Appearance.Options.UseTextOptions = True
        Me.btnBuscar.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBuscar.Image = Global.Portatiles.My.Resources.Resources.Search1
        Me.btnBuscar.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.btnBuscar.Location = New System.Drawing.Point(558, 21)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(46, 74)
        Me.btnBuscar.TabIndex = 14
        Me.btnBuscar.Text = "Buscar"
        '
        'LblExistencia
        '
        Me.LblExistencia.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblExistencia.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.LblExistencia.Location = New System.Drawing.Point(7, 58)
        Me.LblExistencia.Name = "LblExistencia"
        Me.LblExistencia.Size = New System.Drawing.Size(53, 14)
        Me.LblExistencia.TabIndex = 13
        Me.LblExistencia.Text = "Existencia"
        '
        'ChkFiltroFechas
        '
        Me.ChkFiltroFechas.Location = New System.Drawing.Point(432, 24)
        Me.ChkFiltroFechas.Name = "ChkFiltroFechas"
        Me.ChkFiltroFechas.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkFiltroFechas.Properties.Appearance.Options.UseFont = True
        Me.ChkFiltroFechas.Properties.Caption = "Filtrar por Fechas"
        Me.ChkFiltroFechas.Size = New System.Drawing.Size(122, 20)
        Me.ChkFiltroFechas.TabIndex = 12
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl5.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.LabelControl5.Location = New System.Drawing.Point(434, 77)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(15, 14)
        Me.LabelControl5.TabIndex = 11
        Me.LabelControl5.Text = "Fin"
        '
        'DteFechaFin
        '
        Me.DteFechaFin.EditValue = Nothing
        Me.DteFechaFin.Location = New System.Drawing.Point(464, 74)
        Me.DteFechaFin.Name = "DteFechaFin"
        Me.DteFechaFin.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DteFechaFin.Properties.Appearance.Options.UseFont = True
        Me.DteFechaFin.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DteFechaFin.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DteFechaFin.Size = New System.Drawing.Size(90, 20)
        Me.DteFechaFin.TabIndex = 10
        '
        'lueProducto
        '
        Me.lueProducto.EditValue = ""
        Me.lueProducto.Location = New System.Drawing.Point(79, 24)
        Me.lueProducto.Name = "lueProducto"
        Me.lueProducto.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lueProducto.Properties.Appearance.Options.UseFont = True
        Me.lueProducto.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.lueProducto.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueProducto.Properties.NullText = ""
        Me.lueProducto.Size = New System.Drawing.Size(217, 22)
        Me.lueProducto.TabIndex = 4
        '
        'LblProducto
        '
        Me.LblProducto.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblProducto.Location = New System.Drawing.Point(10, 26)
        Me.LblProducto.Name = "LblProducto"
        Me.LblProducto.Size = New System.Drawing.Size(50, 14)
        Me.LblProducto.TabIndex = 9
        Me.LblProducto.Text = "Producto"
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.LabelControl3.Location = New System.Drawing.Point(434, 52)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(28, 14)
        Me.LabelControl3.TabIndex = 7
        Me.LabelControl3.Text = "Inicio"
        '
        'DteFechaIni
        '
        Me.DteFechaIni.EditValue = Nothing
        Me.DteFechaIni.Location = New System.Drawing.Point(464, 47)
        Me.DteFechaIni.Name = "DteFechaIni"
        Me.DteFechaIni.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DteFechaIni.Properties.Appearance.Options.UseFont = True
        Me.DteFechaIni.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DteFechaIni.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DteFechaIni.Size = New System.Drawing.Size(90, 20)
        Me.DteFechaIni.TabIndex = 2
        '
        'txtExistencia
        '
        Me.txtExistencia.Location = New System.Drawing.Point(79, 52)
        Me.txtExistencia.Name = "txtExistencia"
        Me.txtExistencia.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtExistencia.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtExistencia.Properties.Appearance.Options.UseBackColor = True
        Me.txtExistencia.Properties.Appearance.Options.UseFont = True
        Me.txtExistencia.Size = New System.Drawing.Size(74, 22)
        Me.txtExistencia.TabIndex = 0
        '
        'gcAjustes
        '
        Me.gcAjustes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gcAjustes.Location = New System.Drawing.Point(2, 107)
        Me.gcAjustes.MainView = Me.gvAjustes
        Me.gcAjustes.Name = "gcAjustes"
        Me.gcAjustes.Size = New System.Drawing.Size(740, 249)
        Me.gcAjustes.TabIndex = 8
        Me.gcAjustes.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvAjustes})
        '
        'gvAjustes
        '
        Me.gvAjustes.Appearance.Row.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.gvAjustes.Appearance.Row.Options.UseFont = True
        Me.gvAjustes.Appearance.ViewCaption.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gvAjustes.Appearance.ViewCaption.Options.UseFont = True
        Me.gvAjustes.GridControl = Me.gcAjustes
        Me.gvAjustes.Name = "gvAjustes"
        Me.gvAjustes.OptionsBehavior.Editable = False
        Me.gvAjustes.OptionsView.ShowAutoFilterRow = True
        Me.gvAjustes.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.gvAjustes.OptionsView.ShowGroupPanel = False
        '
        'btnImprimir
        '
        Me.btnImprimir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnImprimir.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImprimir.Appearance.Options.UseFont = True
        Me.btnImprimir.Appearance.Options.UseTextOptions = True
        Me.btnImprimir.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.btnImprimir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnImprimir.Image = Global.Portatiles.My.Resources.Resources.Calc1
        Me.btnImprimir.Location = New System.Drawing.Point(540, 360)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(98, 48)
        Me.btnImprimir.TabIndex = 9
        Me.btnImprimir.Text = "Imprimir"
        '
        'Kardex
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(745, 411)
        Me.Controls.Add(Me.btnImprimir)
        Me.Controls.Add(Me.gcAjustes)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.btnSalir)
        Me.MinimumSize = New System.Drawing.Size(630, 450)
        Me.Name = "Kardex"
        Me.Text = "Kardex"
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.ChkFiltroFechas.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DteFechaFin.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DteFechaFin.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueProducto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DteFechaIni.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DteFechaIni.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtExistencia.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gcAjustes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvAjustes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents btnBuscar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LblExistencia As DevExpress.XtraEditors.LabelControl
    Friend WithEvents ChkFiltroFechas As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents DteFechaFin As DevExpress.XtraEditors.DateEdit
    Friend WithEvents lueProducto As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LblProducto As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents DteFechaIni As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txtExistencia As DevExpress.XtraEditors.TextEdit
    Friend WithEvents gcAjustes As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvAjustes As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents btnImprimir As DevExpress.XtraEditors.SimpleButton
End Class
