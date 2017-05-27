<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmImportador
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
        Dim SuperToolTip1 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem1 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim ToolTipItem1 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Me.PanelTree = New DevExpress.XtraEditors.PanelControl()
        Me.TreeCatalogos = New DevExpress.XtraTreeList.TreeList()
        Me.SplitterControl1 = New DevExpress.XtraEditors.SplitterControl()
        Me.PanelPrincipal = New DevExpress.XtraEditors.PanelControl()
        Me.btnAgregar = New DevExpress.XtraEditors.SimpleButton()
        Me.PanelBotones = New DevExpress.XtraEditors.PanelControl()
        Me.btnExportar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnValidar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnGuardar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnSalir = New DevExpress.XtraEditors.SimpleButton()
        Me.btnBuscar = New DevExpress.XtraEditors.SimpleButton()
        Me.XTPCatalogos = New DevExpress.XtraTab.XtraTabControl()
        Me.xtpImportador = New DevExpress.XtraTab.XtraTabPage()
        Me.gcRegistros = New DevExpress.XtraGrid.GridControl()
        Me.gvRegistros = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.XTPErrores = New DevExpress.XtraTab.XtraTabPage()
        Me.ListErrores = New DevExpress.XtraEditors.ListBoxControl()
        Me.PanelTitulo = New DevExpress.XtraEditors.PanelControl()
        Me.LblTitulo = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.Splitter1 = New System.Windows.Forms.Splitter()
        Me.txthoja = New DevExpress.XtraEditors.TextEdit()
        Me.txtRuta = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        CType(Me.PanelTree, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelTree.SuspendLayout()
        CType(Me.TreeCatalogos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelPrincipal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelPrincipal.SuspendLayout()
        CType(Me.PanelBotones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelBotones.SuspendLayout()
        CType(Me.XTPCatalogos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XTPCatalogos.SuspendLayout()
        Me.xtpImportador.SuspendLayout()
        CType(Me.gcRegistros, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvRegistros, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XTPErrores.SuspendLayout()
        CType(Me.ListErrores, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelTitulo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelTitulo.SuspendLayout()
        CType(Me.txthoja.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRuta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelTree
        '
        Me.PanelTree.Controls.Add(Me.TreeCatalogos)
        Me.PanelTree.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelTree.Location = New System.Drawing.Point(0, 0)
        Me.PanelTree.Name = "PanelTree"
        Me.PanelTree.Size = New System.Drawing.Size(237, 471)
        Me.PanelTree.TabIndex = 1
        '
        'TreeCatalogos
        '
        Me.TreeCatalogos.Appearance.BandPanel.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TreeCatalogos.Appearance.BandPanel.Options.UseFont = True
        Me.TreeCatalogos.Appearance.FilterPanel.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TreeCatalogos.Appearance.FilterPanel.Options.UseFont = True
        Me.TreeCatalogos.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TreeCatalogos.Appearance.FocusedCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TreeCatalogos.Appearance.FocusedCell.Options.UseBackColor = True
        Me.TreeCatalogos.Appearance.FocusedCell.Options.UseFont = True
        Me.TreeCatalogos.Appearance.SelectedRow.BackColor = System.Drawing.Color.LightSteelBlue
        Me.TreeCatalogos.Appearance.SelectedRow.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TreeCatalogos.Appearance.SelectedRow.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TreeCatalogos.Appearance.SelectedRow.Options.UseBackColor = True
        Me.TreeCatalogos.Appearance.SelectedRow.Options.UseFont = True
        Me.TreeCatalogos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TreeCatalogos.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TreeCatalogos.Location = New System.Drawing.Point(2, 2)
        Me.TreeCatalogos.Name = "TreeCatalogos"
        Me.TreeCatalogos.OptionsView.ShowAutoFilterRow = True
        Me.TreeCatalogos.Size = New System.Drawing.Size(233, 467)
        Me.TreeCatalogos.TabIndex = 1
        Me.TreeCatalogos.TreeLineStyle = DevExpress.XtraTreeList.LineStyle.Solid
        '
        'SplitterControl1
        '
        Me.SplitterControl1.Location = New System.Drawing.Point(237, 0)
        Me.SplitterControl1.Name = "SplitterControl1"
        Me.SplitterControl1.Size = New System.Drawing.Size(6, 471)
        Me.SplitterControl1.TabIndex = 2
        Me.SplitterControl1.TabStop = False
        '
        'PanelPrincipal
        '
        Me.PanelPrincipal.Controls.Add(Me.btnAgregar)
        Me.PanelPrincipal.Controls.Add(Me.PanelBotones)
        Me.PanelPrincipal.Controls.Add(Me.btnBuscar)
        Me.PanelPrincipal.Controls.Add(Me.XTPCatalogos)
        Me.PanelPrincipal.Controls.Add(Me.PanelTitulo)
        Me.PanelPrincipal.Controls.Add(Me.LabelControl3)
        Me.PanelPrincipal.Controls.Add(Me.Splitter1)
        Me.PanelPrincipal.Controls.Add(Me.txthoja)
        Me.PanelPrincipal.Controls.Add(Me.txtRuta)
        Me.PanelPrincipal.Controls.Add(Me.LabelControl4)
        Me.PanelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelPrincipal.Location = New System.Drawing.Point(243, 0)
        Me.PanelPrincipal.Name = "PanelPrincipal"
        Me.PanelPrincipal.Size = New System.Drawing.Size(461, 471)
        Me.PanelPrincipal.TabIndex = 3
        '
        'btnAgregar
        '
        Me.btnAgregar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAgregar.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregar.Appearance.Options.UseFont = True
        Me.btnAgregar.Appearance.Options.UseTextOptions = True
        Me.btnAgregar.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAgregar.Image = Global.Portatiles.My.Resources.Resources.Download
        Me.btnAgregar.Location = New System.Drawing.Point(367, 47)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(84, 52)
        Me.btnAgregar.TabIndex = 11
        Me.btnAgregar.Text = "Cargar"
        '
        'PanelBotones
        '
        Me.PanelBotones.Controls.Add(Me.btnExportar)
        Me.PanelBotones.Controls.Add(Me.btnValidar)
        Me.PanelBotones.Controls.Add(Me.btnGuardar)
        Me.PanelBotones.Controls.Add(Me.btnSalir)
        Me.PanelBotones.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelBotones.Location = New System.Drawing.Point(5, 404)
        Me.PanelBotones.Name = "PanelBotones"
        Me.PanelBotones.Size = New System.Drawing.Size(454, 65)
        Me.PanelBotones.TabIndex = 4
        '
        'btnExportar
        '
        Me.btnExportar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExportar.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExportar.Appearance.Options.UseFont = True
        Me.btnExportar.Appearance.Options.UseTextOptions = True
        Me.btnExportar.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.btnExportar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExportar.Image = Global.Portatiles.My.Resources.Resources.Document_Spreadsheet
        Me.btnExportar.Location = New System.Drawing.Point(5, 9)
        Me.btnExportar.Name = "btnExportar"
        Me.btnExportar.Size = New System.Drawing.Size(98, 48)
        Me.btnExportar.TabIndex = 4
        Me.btnExportar.Text = "Exportar formato"
        '
        'btnValidar
        '
        Me.btnValidar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnValidar.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnValidar.Appearance.Options.UseFont = True
        Me.btnValidar.Appearance.Options.UseTextOptions = True
        Me.btnValidar.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.btnValidar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnValidar.Image = Global.Portatiles.My.Resources.Resources.Ok3
        Me.btnValidar.Location = New System.Drawing.Point(141, 9)
        Me.btnValidar.Name = "btnValidar"
        Me.btnValidar.Size = New System.Drawing.Size(98, 48)
        Me.btnValidar.TabIndex = 3
        Me.btnValidar.Text = "Validar Datos"
        '
        'btnGuardar
        '
        Me.btnGuardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGuardar.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.Appearance.Options.UseFont = True
        Me.btnGuardar.Appearance.Options.UseTextOptions = True
        Me.btnGuardar.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGuardar.Image = Global.Portatiles.My.Resources.Resources.Save_32x32
        Me.btnGuardar.Location = New System.Drawing.Point(245, 9)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(98, 48)
        Me.btnGuardar.TabIndex = 2
        Me.btnGuardar.Text = "Guardar"
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
        Me.btnSalir.Location = New System.Drawing.Point(348, 9)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(98, 48)
        Me.btnSalir.TabIndex = 0
        Me.btnSalir.Text = "Salir"
        '
        'btnBuscar
        '
        Me.btnBuscar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBuscar.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.Appearance.Options.UseFont = True
        Me.btnBuscar.Appearance.Options.UseTextOptions = True
        Me.btnBuscar.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBuscar.Image = Global.Portatiles.My.Resources.Resources.Find_32x32
        Me.btnBuscar.Location = New System.Drawing.Point(316, 50)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(40, 24)
        ToolTipTitleItem1.Text = "Buscar Producto"
        ToolTipItem1.LeftIndent = 6
        ToolTipItem1.Text = "Abre una cuadro de diálogo auxiliar con la lista de productos activos"
        SuperToolTip1.Items.Add(ToolTipTitleItem1)
        SuperToolTip1.Items.Add(ToolTipItem1)
        Me.btnBuscar.SuperTip = SuperToolTip1
        Me.btnBuscar.TabIndex = 10
        '
        'XTPCatalogos
        '
        Me.XTPCatalogos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.XTPCatalogos.AppearancePage.Header.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XTPCatalogos.AppearancePage.Header.Options.UseFont = True
        Me.XTPCatalogos.AppearancePage.HeaderActive.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XTPCatalogos.AppearancePage.HeaderActive.Options.UseFont = True
        Me.XTPCatalogos.Location = New System.Drawing.Point(8, 108)
        Me.XTPCatalogos.Name = "XTPCatalogos"
        Me.XTPCatalogos.SelectedTabPage = Me.xtpImportador
        Me.XTPCatalogos.Size = New System.Drawing.Size(452, 294)
        Me.XTPCatalogos.TabIndex = 3
        Me.XTPCatalogos.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.xtpImportador, Me.XTPErrores})
        '
        'xtpImportador
        '
        Me.xtpImportador.Controls.Add(Me.gcRegistros)
        Me.xtpImportador.Name = "xtpImportador"
        Me.xtpImportador.Size = New System.Drawing.Size(446, 263)
        Me.xtpImportador.Text = "Datos a importar"
        '
        'gcRegistros
        '
        Me.gcRegistros.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcRegistros.Location = New System.Drawing.Point(0, 0)
        Me.gcRegistros.MainView = Me.gvRegistros
        Me.gcRegistros.Name = "gcRegistros"
        Me.gcRegistros.Size = New System.Drawing.Size(446, 263)
        Me.gcRegistros.TabIndex = 9
        Me.gcRegistros.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvRegistros})
        '
        'gvRegistros
        '
        Me.gvRegistros.GridControl = Me.gcRegistros
        Me.gvRegistros.Name = "gvRegistros"
        Me.gvRegistros.OptionsBehavior.Editable = False
        Me.gvRegistros.OptionsView.ShowAutoFilterRow = True
        Me.gvRegistros.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.gvRegistros.OptionsView.ShowGroupPanel = False
        '
        'XTPErrores
        '
        Me.XTPErrores.Controls.Add(Me.ListErrores)
        Me.XTPErrores.Name = "XTPErrores"
        Me.XTPErrores.Size = New System.Drawing.Size(446, 263)
        Me.XTPErrores.Text = "Listado de errores"
        '
        'ListErrores
        '
        Me.ListErrores.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListErrores.Location = New System.Drawing.Point(0, 0)
        Me.ListErrores.Name = "ListErrores"
        Me.ListErrores.Size = New System.Drawing.Size(446, 263)
        Me.ListErrores.TabIndex = 0
        '
        'PanelTitulo
        '
        Me.PanelTitulo.Controls.Add(Me.LblTitulo)
        Me.PanelTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelTitulo.Location = New System.Drawing.Point(5, 2)
        Me.PanelTitulo.Name = "PanelTitulo"
        Me.PanelTitulo.Size = New System.Drawing.Size(454, 39)
        Me.PanelTitulo.TabIndex = 2
        '
        'LblTitulo
        '
        Me.LblTitulo.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LblTitulo.Appearance.Font = New System.Drawing.Font("Monotype Corsiva", 20.25!, System.Drawing.FontStyle.Italic)
        Me.LblTitulo.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.LblTitulo.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LblTitulo.Location = New System.Drawing.Point(40, 3)
        Me.LblTitulo.Name = "LblTitulo"
        Me.LblTitulo.Size = New System.Drawing.Size(375, 33)
        Me.LblTitulo.TabIndex = 1
        Me.LblTitulo.Text = "Importador de"
        '
        'LabelControl3
        '
        Me.LabelControl3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Location = New System.Drawing.Point(207, 86)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(26, 16)
        Me.LabelControl3.TabIndex = 8
        Me.LabelControl3.Text = "Hoja"
        '
        'Splitter1
        '
        Me.Splitter1.Location = New System.Drawing.Point(2, 2)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(3, 467)
        Me.Splitter1.TabIndex = 5
        Me.Splitter1.TabStop = False
        '
        'txthoja
        '
        Me.txthoja.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txthoja.Location = New System.Drawing.Point(239, 80)
        Me.txthoja.Name = "txthoja"
        Me.txthoja.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txthoja.Properties.Appearance.Options.UseFont = True
        Me.txthoja.Size = New System.Drawing.Size(73, 22)
        Me.txthoja.TabIndex = 7
        '
        'txtRuta
        '
        Me.txtRuta.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtRuta.Location = New System.Drawing.Point(70, 52)
        Me.txtRuta.Name = "txtRuta"
        Me.txtRuta.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRuta.Properties.Appearance.Options.UseFont = True
        Me.txtRuta.Size = New System.Drawing.Size(242, 22)
        Me.txtRuta.TabIndex = 5
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Location = New System.Drawing.Point(17, 55)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(42, 16)
        Me.LabelControl4.TabIndex = 6
        Me.LabelControl4.Text = "Archivo"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'FrmImportador
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(704, 471)
        Me.Controls.Add(Me.PanelPrincipal)
        Me.Controls.Add(Me.SplitterControl1)
        Me.Controls.Add(Me.PanelTree)
        Me.Name = "FrmImportador"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Importación de datos al sistema"
        CType(Me.PanelTree, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelTree.ResumeLayout(False)
        CType(Me.TreeCatalogos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelPrincipal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelPrincipal.ResumeLayout(False)
        Me.PanelPrincipal.PerformLayout()
        CType(Me.PanelBotones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelBotones.ResumeLayout(False)
        CType(Me.XTPCatalogos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XTPCatalogos.ResumeLayout(False)
        Me.xtpImportador.ResumeLayout(False)
        CType(Me.gcRegistros, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvRegistros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XTPErrores.ResumeLayout(False)
        CType(Me.ListErrores, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelTitulo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelTitulo.ResumeLayout(False)
        CType(Me.txthoja.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRuta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelTree As DevExpress.XtraEditors.PanelControl
    Friend WithEvents TreeCatalogos As DevExpress.XtraTreeList.TreeList
    Friend WithEvents SplitterControl1 As DevExpress.XtraEditors.SplitterControl
    Friend WithEvents PanelPrincipal As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelBotones As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnValidar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnGuardar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents XTPCatalogos As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents xtpImportador As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents gcRegistros As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvRegistros As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txthoja As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtRuta As DevExpress.XtraEditors.TextEdit
    Friend WithEvents PanelTitulo As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LblTitulo As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Splitter1 As System.Windows.Forms.Splitter
    Friend WithEvents btnAgregar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnBuscar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnExportar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents XTPErrores As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents ListErrores As DevExpress.XtraEditors.ListBoxControl
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
End Class
