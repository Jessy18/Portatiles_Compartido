<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmListado
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
        Me.BtnBuscarSucursal = New DevExpress.XtraEditors.SimpleButton()
        Me.BtnBuscarLue2 = New DevExpress.XtraEditors.SimpleButton()
        Me.BtnBuscarLue1 = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.CmbEstado = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LblLue2 = New DevExpress.XtraEditors.LabelControl()
        Me.Lue2 = New DevExpress.XtraEditors.LookUpEdit()
        Me.btnBuscar = New DevExpress.XtraEditors.SimpleButton()
        Me.LblMovimiento = New DevExpress.XtraEditors.LabelControl()
        Me.Lue1 = New DevExpress.XtraEditors.LookUpEdit()
        Me.ChkFiltroFechas = New DevExpress.XtraEditors.CheckEdit()
        Me.LblLue1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.DteFechaFin = New DevExpress.XtraEditors.DateEdit()
        Me.lueSucursal = New DevExpress.XtraEditors.LookUpEdit()
        Me.LblSucursal = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.txtDocSucursal = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.DteFechaIni = New DevExpress.XtraEditors.DateEdit()
        Me.txtNumMovimiento = New DevExpress.XtraEditors.TextEdit()
        Me.gcAjustes = New DevExpress.XtraGrid.GridControl()
        Me.gvAjustes = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.btnEditar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnCerrarEdicion = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.CmbEstado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Lue2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Lue1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChkFiltroFechas.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DteFechaFin.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DteFechaFin.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueSucursal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDocSucursal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DteFechaIni.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DteFechaIni.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNumMovimiento.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.btnSalir.Location = New System.Drawing.Point(513, 364)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(98, 48)
        Me.btnSalir.TabIndex = 6
        Me.btnSalir.Text = "Salir"
        '
        'GroupControl1
        '
        Me.GroupControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupControl1.Controls.Add(Me.BtnBuscarSucursal)
        Me.GroupControl1.Controls.Add(Me.BtnBuscarLue2)
        Me.GroupControl1.Controls.Add(Me.BtnBuscarLue1)
        Me.GroupControl1.Controls.Add(Me.LabelControl1)
        Me.GroupControl1.Controls.Add(Me.CmbEstado)
        Me.GroupControl1.Controls.Add(Me.LblLue2)
        Me.GroupControl1.Controls.Add(Me.Lue2)
        Me.GroupControl1.Controls.Add(Me.btnBuscar)
        Me.GroupControl1.Controls.Add(Me.LblMovimiento)
        Me.GroupControl1.Controls.Add(Me.Lue1)
        Me.GroupControl1.Controls.Add(Me.ChkFiltroFechas)
        Me.GroupControl1.Controls.Add(Me.LblLue1)
        Me.GroupControl1.Controls.Add(Me.LabelControl5)
        Me.GroupControl1.Controls.Add(Me.DteFechaFin)
        Me.GroupControl1.Controls.Add(Me.lueSucursal)
        Me.GroupControl1.Controls.Add(Me.LblSucursal)
        Me.GroupControl1.Controls.Add(Me.LabelControl3)
        Me.GroupControl1.Controls.Add(Me.txtDocSucursal)
        Me.GroupControl1.Controls.Add(Me.LabelControl2)
        Me.GroupControl1.Controls.Add(Me.DteFechaIni)
        Me.GroupControl1.Controls.Add(Me.txtNumMovimiento)
        Me.GroupControl1.Location = New System.Drawing.Point(2, 2)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(609, 109)
        Me.GroupControl1.TabIndex = 7
        Me.GroupControl1.Text = "Filtros"
        '
        'BtnBuscarSucursal
        '
        Me.BtnBuscarSucursal.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBuscarSucursal.Appearance.Options.UseFont = True
        Me.BtnBuscarSucursal.Appearance.Options.UseTextOptions = True
        Me.BtnBuscarSucursal.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.BtnBuscarSucursal.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnBuscarSucursal.Image = Global.Portatiles.My.Resources.Resources.Find_24x24
        Me.BtnBuscarSucursal.Location = New System.Drawing.Point(242, 26)
        Me.BtnBuscarSucursal.Name = "BtnBuscarSucursal"
        Me.BtnBuscarSucursal.Size = New System.Drawing.Size(32, 24)
        Me.BtnBuscarSucursal.TabIndex = 21
        '
        'BtnBuscarLue2
        '
        Me.BtnBuscarLue2.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBuscarLue2.Appearance.Options.UseFont = True
        Me.BtnBuscarLue2.Appearance.Options.UseTextOptions = True
        Me.BtnBuscarLue2.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.BtnBuscarLue2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnBuscarLue2.Image = Global.Portatiles.My.Resources.Resources.Find_24x24
        Me.BtnBuscarLue2.Location = New System.Drawing.Point(242, 75)
        Me.BtnBuscarLue2.Name = "BtnBuscarLue2"
        Me.BtnBuscarLue2.Size = New System.Drawing.Size(32, 24)
        Me.BtnBuscarLue2.TabIndex = 20
        '
        'BtnBuscarLue1
        '
        Me.BtnBuscarLue1.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBuscarLue1.Appearance.Options.UseFont = True
        Me.BtnBuscarLue1.Appearance.Options.UseTextOptions = True
        Me.BtnBuscarLue1.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.BtnBuscarLue1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnBuscarLue1.Image = Global.Portatiles.My.Resources.Resources.Find_24x24
        Me.BtnBuscarLue1.Location = New System.Drawing.Point(242, 49)
        Me.BtnBuscarLue1.Name = "BtnBuscarLue1"
        Me.BtnBuscarLue1.Size = New System.Drawing.Size(32, 24)
        Me.BtnBuscarLue1.TabIndex = 19
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.LabelControl1.Location = New System.Drawing.Point(280, 77)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(37, 14)
        Me.LabelControl1.TabIndex = 18
        Me.LabelControl1.Text = "Estado"
        '
        'CmbEstado
        '
        Me.CmbEstado.Location = New System.Drawing.Point(326, 75)
        Me.CmbEstado.Name = "CmbEstado"
        Me.CmbEstado.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CmbEstado.Size = New System.Drawing.Size(100, 20)
        Me.CmbEstado.TabIndex = 17
        '
        'LblLue2
        '
        Me.LblLue2.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblLue2.Location = New System.Drawing.Point(10, 81)
        Me.LblLue2.Name = "LblLue2"
        Me.LblLue2.Size = New System.Drawing.Size(69, 14)
        Me.LblLue2.TabIndex = 16
        Me.LblLue2.Text = "LueStandar2"
        '
        'Lue2
        '
        Me.Lue2.EditValue = ""
        Me.Lue2.Location = New System.Drawing.Point(79, 77)
        Me.Lue2.Name = "Lue2"
        Me.Lue2.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lue2.Properties.Appearance.Options.UseFont = True
        Me.Lue2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.Lue2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Lue2.Properties.NullText = ""
        Me.Lue2.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.OnlyInPopup
        Me.Lue2.Size = New System.Drawing.Size(155, 22)
        Me.Lue2.TabIndex = 15
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
        'LblMovimiento
        '
        Me.LblMovimiento.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblMovimiento.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.LblMovimiento.Location = New System.Drawing.Point(280, 29)
        Me.LblMovimiento.Name = "LblMovimiento"
        Me.LblMovimiento.Size = New System.Drawing.Size(57, 14)
        Me.LblMovimiento.TabIndex = 13
        Me.LblMovimiento.Text = "No. Movim"
        '
        'Lue1
        '
        Me.Lue1.EditValue = ""
        Me.Lue1.Location = New System.Drawing.Point(79, 50)
        Me.Lue1.Name = "Lue1"
        Me.Lue1.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lue1.Properties.Appearance.Options.UseFont = True
        Me.Lue1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.Lue1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Lue1.Properties.NullText = ""
        Me.Lue1.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.OnlyInPopup
        Me.Lue1.Size = New System.Drawing.Size(155, 22)
        Me.Lue1.TabIndex = 3
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
        'LblLue1
        '
        Me.LblLue1.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblLue1.Location = New System.Drawing.Point(9, 55)
        Me.LblLue1.Name = "LblLue1"
        Me.LblLue1.Size = New System.Drawing.Size(69, 14)
        Me.LblLue1.TabIndex = 8
        Me.LblLue1.Text = "LueStandar1"
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
        'lueSucursal
        '
        Me.lueSucursal.EditValue = ""
        Me.lueSucursal.Location = New System.Drawing.Point(79, 24)
        Me.lueSucursal.Name = "lueSucursal"
        Me.lueSucursal.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lueSucursal.Properties.Appearance.Options.UseFont = True
        Me.lueSucursal.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.lueSucursal.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueSucursal.Properties.NullText = ""
        Me.lueSucursal.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.OnlyInPopup
        Me.lueSucursal.Size = New System.Drawing.Size(155, 22)
        Me.lueSucursal.TabIndex = 4
        '
        'LblSucursal
        '
        Me.LblSucursal.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSucursal.Location = New System.Drawing.Point(10, 26)
        Me.LblSucursal.Name = "LblSucursal"
        Me.LblSucursal.Size = New System.Drawing.Size(44, 14)
        Me.LblSucursal.TabIndex = 9
        Me.LblSucursal.Text = "Sucursal"
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
        'txtDocSucursal
        '
        Me.txtDocSucursal.Location = New System.Drawing.Point(352, 49)
        Me.txtDocSucursal.Name = "txtDocSucursal"
        Me.txtDocSucursal.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtDocSucursal.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDocSucursal.Properties.Appearance.Options.UseBackColor = True
        Me.txtDocSucursal.Properties.Appearance.Options.UseFont = True
        Me.txtDocSucursal.Size = New System.Drawing.Size(73, 22)
        Me.txtDocSucursal.TabIndex = 1
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.LabelControl2.Location = New System.Drawing.Point(280, 51)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(69, 14)
        Me.LabelControl2.TabIndex = 6
        Me.LabelControl2.Text = "Doc Sucursal"
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
        'txtNumMovimiento
        '
        Me.txtNumMovimiento.Location = New System.Drawing.Point(352, 23)
        Me.txtNumMovimiento.Name = "txtNumMovimiento"
        Me.txtNumMovimiento.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtNumMovimiento.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumMovimiento.Properties.Appearance.Options.UseBackColor = True
        Me.txtNumMovimiento.Properties.Appearance.Options.UseFont = True
        Me.txtNumMovimiento.Size = New System.Drawing.Size(74, 22)
        Me.txtNumMovimiento.TabIndex = 0
        '
        'gcAjustes
        '
        Me.gcAjustes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gcAjustes.Location = New System.Drawing.Point(2, 107)
        Me.gcAjustes.MainView = Me.gvAjustes
        Me.gcAjustes.Name = "gcAjustes"
        Me.gcAjustes.Size = New System.Drawing.Size(609, 253)
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
        'btnEditar
        '
        Me.btnEditar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEditar.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditar.Appearance.Options.UseFont = True
        Me.btnEditar.Appearance.Options.UseTextOptions = True
        Me.btnEditar.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEditar.Image = Global.Portatiles.My.Resources.Resources.Write
        Me.btnEditar.Location = New System.Drawing.Point(409, 364)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(98, 48)
        Me.btnEditar.TabIndex = 9
        Me.btnEditar.Text = "Editar"
        '
        'btnCerrarEdicion
        '
        Me.btnCerrarEdicion.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCerrarEdicion.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCerrarEdicion.Appearance.Options.UseFont = True
        Me.btnCerrarEdicion.Appearance.Options.UseTextOptions = True
        Me.btnCerrarEdicion.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.btnCerrarEdicion.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCerrarEdicion.Image = Global.Portatiles.My.Resources.Resources.Lock
        Me.btnCerrarEdicion.Location = New System.Drawing.Point(305, 364)
        Me.btnCerrarEdicion.Name = "btnCerrarEdicion"
        Me.btnCerrarEdicion.Size = New System.Drawing.Size(98, 48)
        Me.btnCerrarEdicion.TabIndex = 10
        Me.btnCerrarEdicion.Text = "Cerrar Edición"
        '
        'FrmListado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(614, 415)
        Me.Controls.Add(Me.btnCerrarEdicion)
        Me.Controls.Add(Me.btnEditar)
        Me.Controls.Add(Me.gcAjustes)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.btnSalir)
        Me.MinimumSize = New System.Drawing.Size(630, 450)
        Me.Name = "FrmListado"
        Me.Text = "Listado de Registros"
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.CmbEstado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Lue2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Lue1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChkFiltroFechas.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DteFechaFin.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DteFechaFin.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueSucursal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDocSucursal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DteFechaIni.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DteFechaIni.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNumMovimiento.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gcAjustes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvAjustes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents LblLue2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Lue2 As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents btnBuscar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LblMovimiento As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Lue1 As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents ChkFiltroFechas As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LblLue1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents DteFechaFin As DevExpress.XtraEditors.DateEdit
    Friend WithEvents lueSucursal As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LblSucursal As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtDocSucursal As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents DteFechaIni As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txtNumMovimiento As DevExpress.XtraEditors.TextEdit
    Friend WithEvents gcAjustes As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvAjustes As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents CmbEstado As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents BtnBuscarLue2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnBuscarLue1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnBuscarSucursal As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnEditar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnCerrarEdicion As DevExpress.XtraEditors.SimpleButton
End Class
