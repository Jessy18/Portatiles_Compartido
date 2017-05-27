<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRemisiones
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
        Dim SuperToolTip3 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem3 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim ToolTipItem3 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.ChkEditando = New DevExpress.XtraEditors.CheckEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.txtNumSucRemision = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.DteFecha = New DevExpress.XtraEditors.DateEdit()
        Me.txtNumRemision = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.LueSucSalida = New DevExpress.XtraEditors.LookUpEdit()
        Me.MeObservaciones = New DevExpress.XtraEditors.MemoEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.LueSucEntrada = New DevExpress.XtraEditors.LookUpEdit()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtTotalProductos = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl13 = New DevExpress.XtraEditors.LabelControl()
        Me.txtTotalCant = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl()
        Me.btnGuardar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnSalir = New DevExpress.XtraEditors.SimpleButton()
        Me.gcRemisiones = New DevExpress.XtraGrid.GridControl()
        Me.gvRemisiones = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GroupControl3 = New DevExpress.XtraEditors.GroupControl()
        Me.TxtExistencias = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl()
        Me.btnAgregar = New DevExpress.XtraEditors.SimpleButton()
        Me.txtCantidad = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.btnBuscar = New DevExpress.XtraEditors.SimpleButton()
        Me.txtProducto = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.txtCodProducto = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.TxtObservaciones = New DevExpress.XtraEditors.MemoEdit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.ChkEditando.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNumSucRemision.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DteFecha.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DteFecha.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNumRemision.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.LueSucSalida.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MeObservaciones.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LueSucEntrada.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.txtTotalProductos.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotalCant.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gcRemisiones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvRemisiones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl3.SuspendLayout()
        CType(Me.TxtExistencias.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCantidad.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtProducto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodProducto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtObservaciones.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupControl1
        '
        Me.GroupControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupControl1.Controls.Add(Me.ChkEditando)
        Me.GroupControl1.Controls.Add(Me.LabelControl3)
        Me.GroupControl1.Controls.Add(Me.txtNumSucRemision)
        Me.GroupControl1.Controls.Add(Me.LabelControl2)
        Me.GroupControl1.Controls.Add(Me.DteFecha)
        Me.GroupControl1.Controls.Add(Me.txtNumRemision)
        Me.GroupControl1.Controls.Add(Me.LabelControl1)
        Me.GroupControl1.Location = New System.Drawing.Point(12, 12)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(563, 54)
        Me.GroupControl1.TabIndex = 1
        Me.GroupControl1.Text = "Datos de la Remisión"
        '
        'ChkEditando
        '
        Me.ChkEditando.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkEditando.Location = New System.Drawing.Point(475, 1)
        Me.ChkEditando.Name = "ChkEditando"
        Me.ChkEditando.Properties.Appearance.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkEditando.Properties.Appearance.Options.UseFont = True
        Me.ChkEditando.Properties.Caption = "Editando"
        Me.ChkEditando.Properties.ReadOnly = True
        Me.ChkEditando.Size = New System.Drawing.Size(78, 19)
        Me.ChkEditando.TabIndex = 10
        '
        'LabelControl3
        '
        Me.LabelControl3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.LabelControl3.Location = New System.Drawing.Point(398, 26)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(39, 18)
        Me.LabelControl3.TabIndex = 7
        Me.LabelControl3.Text = "Fecha"
        '
        'txtNumSucRemision
        '
        Me.txtNumSucRemision.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNumSucRemision.Location = New System.Drawing.Point(318, 24)
        Me.txtNumSucRemision.Name = "txtNumSucRemision"
        Me.txtNumSucRemision.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtNumSucRemision.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumSucRemision.Properties.Appearance.Options.UseBackColor = True
        Me.txtNumSucRemision.Properties.Appearance.Options.UseFont = True
        Me.txtNumSucRemision.Properties.ReadOnly = True
        Me.txtNumSucRemision.Size = New System.Drawing.Size(72, 22)
        Me.txtNumSucRemision.TabIndex = 1
        '
        'LabelControl2
        '
        Me.LabelControl2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.LabelControl2.Location = New System.Drawing.Point(224, 25)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(88, 18)
        Me.LabelControl2.TabIndex = 6
        Me.LabelControl2.Text = "Doc. Sucursal"
        '
        'DteFecha
        '
        Me.DteFecha.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DteFecha.EditValue = New Date(2017, 5, 15, 23, 23, 20, 824)
        Me.DteFecha.Location = New System.Drawing.Point(439, 24)
        Me.DteFecha.Name = "DteFecha"
        Me.DteFecha.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DteFecha.Properties.Appearance.Options.UseFont = True
        Me.DteFecha.Properties.Appearance.Options.UseTextOptions = True
        Me.DteFecha.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.DteFecha.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DteFecha.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DteFecha.Properties.EditFormat.FormatString = "d"
        Me.DteFecha.Size = New System.Drawing.Size(113, 22)
        Me.DteFecha.TabIndex = 2
        '
        'txtNumRemision
        '
        Me.txtNumRemision.Location = New System.Drawing.Point(115, 24)
        Me.txtNumRemision.Name = "txtNumRemision"
        Me.txtNumRemision.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtNumRemision.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumRemision.Properties.Appearance.Options.UseBackColor = True
        Me.txtNumRemision.Properties.Appearance.Options.UseFont = True
        Me.txtNumRemision.Properties.ReadOnly = True
        Me.txtNumRemision.Size = New System.Drawing.Size(89, 22)
        Me.txtNumRemision.TabIndex = 0
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.LabelControl1.Location = New System.Drawing.Point(4, 24)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(102, 19)
        Me.LabelControl1.TabIndex = 5
        Me.LabelControl1.Text = "No Remisión"
        '
        'GroupControl2
        '
        Me.GroupControl2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupControl2.Controls.Add(Me.LueSucSalida)
        Me.GroupControl2.Controls.Add(Me.MeObservaciones)
        Me.GroupControl2.Controls.Add(Me.LabelControl4)
        Me.GroupControl2.Controls.Add(Me.LabelControl7)
        Me.GroupControl2.Controls.Add(Me.LueSucEntrada)
        Me.GroupControl2.Controls.Add(Me.LabelControl10)
        Me.GroupControl2.Location = New System.Drawing.Point(12, 72)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(563, 86)
        Me.GroupControl2.TabIndex = 13
        Me.GroupControl2.Text = "Sucursales"
        '
        'LueSucSalida
        '
        Me.LueSucSalida.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LueSucSalida.EditValue = ""
        Me.LueSucSalida.Location = New System.Drawing.Point(171, 28)
        Me.LueSucSalida.Name = "LueSucSalida"
        Me.LueSucSalida.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LueSucSalida.Properties.Appearance.Options.UseFont = True
        Me.LueSucSalida.Properties.AppearanceDropDown.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.LueSucSalida.Properties.AppearanceDropDown.Options.UseFont = True
        Me.LueSucSalida.Properties.AppearanceDropDownHeader.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.LueSucSalida.Properties.AppearanceDropDownHeader.Options.UseFont = True
        Me.LueSucSalida.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.LueSucSalida.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LueSucSalida.Properties.NullText = ""
        Me.LueSucSalida.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.OnlyInPopup
        Me.LueSucSalida.Size = New System.Drawing.Size(386, 22)
        Me.LueSucSalida.TabIndex = 6
        '
        'MeObservaciones
        '
        Me.MeObservaciones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MeObservaciones.Location = New System.Drawing.Point(4, 459)
        Me.MeObservaciones.Name = "MeObservaciones"
        Me.MeObservaciones.Size = New System.Drawing.Size(339, 48)
        Me.MeObservaciones.TabIndex = 16
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.LabelControl4.Location = New System.Drawing.Point(4, 56)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(149, 19)
        Me.LabelControl4.TabIndex = 7
        Me.LabelControl4.Text = "Sucursal - Entrada"
        '
        'LabelControl7
        '
        Me.LabelControl7.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LabelControl7.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl7.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.LabelControl7.Location = New System.Drawing.Point(4, 441)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(83, 16)
        Me.LabelControl7.TabIndex = 19
        Me.LabelControl7.Text = "Observaciones"
        '
        'LueSucEntrada
        '
        Me.LueSucEntrada.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LueSucEntrada.EditValue = ""
        Me.LueSucEntrada.Location = New System.Drawing.Point(171, 56)
        Me.LueSucEntrada.Name = "LueSucEntrada"
        Me.LueSucEntrada.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LueSucEntrada.Properties.Appearance.Options.UseFont = True
        Me.LueSucEntrada.Properties.AppearanceDropDown.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.LueSucEntrada.Properties.AppearanceDropDown.Options.UseFont = True
        Me.LueSucEntrada.Properties.AppearanceDropDownHeader.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.LueSucEntrada.Properties.AppearanceDropDownHeader.Options.UseFont = True
        Me.LueSucEntrada.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.LueSucEntrada.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LueSucEntrada.Properties.NullText = ""
        Me.LueSucEntrada.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.OnlyInPopup
        Me.LueSucEntrada.Size = New System.Drawing.Size(386, 22)
        Me.LueSucEntrada.TabIndex = 4
        '
        'LabelControl10
        '
        Me.LabelControl10.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl10.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.LabelControl10.Location = New System.Drawing.Point(5, 28)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(135, 19)
        Me.LabelControl10.TabIndex = 5
        Me.LabelControl10.Text = "Sucursal - Salida"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.txtTotalProductos)
        Me.GroupBox1.Controls.Add(Me.LabelControl13)
        Me.GroupBox1.Controls.Add(Me.txtTotalCant)
        Me.GroupBox1.Controls.Add(Me.LabelControl12)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 413)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(564, 39)
        Me.GroupBox1.TabIndex = 20
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Totales"
        '
        'txtTotalProductos
        '
        Me.txtTotalProductos.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTotalProductos.EditValue = "0"
        Me.txtTotalProductos.Location = New System.Drawing.Point(382, 13)
        Me.txtTotalProductos.Name = "txtTotalProductos"
        Me.txtTotalProductos.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtTotalProductos.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalProductos.Properties.Appearance.Options.UseBackColor = True
        Me.txtTotalProductos.Properties.Appearance.Options.UseFont = True
        Me.txtTotalProductos.Properties.Appearance.Options.UseTextOptions = True
        Me.txtTotalProductos.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtTotalProductos.Properties.ReadOnly = True
        Me.txtTotalProductos.Size = New System.Drawing.Size(50, 22)
        Me.txtTotalProductos.TabIndex = 1
        '
        'LabelControl13
        '
        Me.LabelControl13.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl13.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl13.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.LabelControl13.Location = New System.Drawing.Point(443, 16)
        Me.LabelControl13.Name = "LabelControl13"
        Me.LabelControl13.Size = New System.Drawing.Size(50, 16)
        Me.LabelControl13.TabIndex = 2
        Me.LabelControl13.Text = "Cantidad"
        '
        'txtTotalCant
        '
        Me.txtTotalCant.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTotalCant.EditValue = "0"
        Me.txtTotalCant.Location = New System.Drawing.Point(502, 13)
        Me.txtTotalCant.Name = "txtTotalCant"
        Me.txtTotalCant.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtTotalCant.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalCant.Properties.Appearance.Options.UseBackColor = True
        Me.txtTotalCant.Properties.Appearance.Options.UseFont = True
        Me.txtTotalCant.Properties.Appearance.Options.UseTextOptions = True
        Me.txtTotalCant.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtTotalCant.Properties.ReadOnly = True
        Me.txtTotalCant.Size = New System.Drawing.Size(50, 22)
        Me.txtTotalCant.TabIndex = 3
        '
        'LabelControl12
        '
        Me.LabelControl12.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl12.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl12.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.LabelControl12.Location = New System.Drawing.Point(320, 16)
        Me.LabelControl12.Name = "LabelControl12"
        Me.LabelControl12.Size = New System.Drawing.Size(56, 16)
        Me.LabelControl12.TabIndex = 0
        Me.LabelControl12.Text = "Productos"
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
        Me.btnGuardar.Location = New System.Drawing.Point(373, 474)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(98, 48)
        Me.btnGuardar.TabIndex = 17
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
        Me.btnSalir.Location = New System.Drawing.Point(477, 474)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(98, 48)
        Me.btnSalir.TabIndex = 18
        Me.btnSalir.Text = "Salir"
        '
        'gcRemisiones
        '
        Me.gcRemisiones.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gcRemisiones.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gcRemisiones.Location = New System.Drawing.Point(12, 241)
        Me.gcRemisiones.MainView = Me.gvRemisiones
        Me.gcRemisiones.Name = "gcRemisiones"
        Me.gcRemisiones.Size = New System.Drawing.Size(563, 174)
        Me.gcRemisiones.TabIndex = 16
        Me.gcRemisiones.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvRemisiones})
        '
        'gvRemisiones
        '
        Me.gvRemisiones.Appearance.Row.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.gvRemisiones.Appearance.Row.Options.UseFont = True
        Me.gvRemisiones.Appearance.ViewCaption.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gvRemisiones.Appearance.ViewCaption.Options.UseFont = True
        Me.gvRemisiones.GridControl = Me.gcRemisiones
        Me.gvRemisiones.Name = "gvRemisiones"
        Me.gvRemisiones.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.gvRemisiones.OptionsView.ShowGroupPanel = False
        '
        'GroupControl3
        '
        Me.GroupControl3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupControl3.Controls.Add(Me.TxtExistencias)
        Me.GroupControl3.Controls.Add(Me.LabelControl11)
        Me.GroupControl3.Controls.Add(Me.btnAgregar)
        Me.GroupControl3.Controls.Add(Me.txtCantidad)
        Me.GroupControl3.Controls.Add(Me.LabelControl6)
        Me.GroupControl3.Controls.Add(Me.btnBuscar)
        Me.GroupControl3.Controls.Add(Me.txtProducto)
        Me.GroupControl3.Controls.Add(Me.LabelControl9)
        Me.GroupControl3.Controls.Add(Me.txtCodProducto)
        Me.GroupControl3.Controls.Add(Me.LabelControl8)
        Me.GroupControl3.Location = New System.Drawing.Point(12, 164)
        Me.GroupControl3.Name = "GroupControl3"
        Me.GroupControl3.Size = New System.Drawing.Size(563, 71)
        Me.GroupControl3.TabIndex = 17
        Me.GroupControl3.Text = "Datos de Producto"
        '
        'TxtExistencias
        '
        Me.TxtExistencias.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtExistencias.EditValue = "0"
        Me.TxtExistencias.Location = New System.Drawing.Point(406, 43)
        Me.TxtExistencias.Name = "TxtExistencias"
        Me.TxtExistencias.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.TxtExistencias.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtExistencias.Properties.Appearance.Options.UseBackColor = True
        Me.TxtExistencias.Properties.Appearance.Options.UseFont = True
        Me.TxtExistencias.Properties.Appearance.Options.UseTextOptions = True
        Me.TxtExistencias.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.TxtExistencias.Properties.ReadOnly = True
        Me.TxtExistencias.Size = New System.Drawing.Size(51, 22)
        Me.TxtExistencias.TabIndex = 10
        '
        'LabelControl11
        '
        Me.LabelControl11.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl11.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl11.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.LabelControl11.Location = New System.Drawing.Point(407, 24)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(30, 16)
        Me.LabelControl11.TabIndex = 11
        Me.LabelControl11.Text = "Exist."
        '
        'btnAgregar
        '
        Me.btnAgregar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAgregar.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregar.Appearance.Options.UseFont = True
        Me.btnAgregar.Appearance.Options.UseTextOptions = True
        Me.btnAgregar.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAgregar.Image = Global.Portatiles.My.Resources.Resources.add1
        Me.btnAgregar.Location = New System.Drawing.Point(519, 22)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(39, 43)
        Me.btnAgregar.TabIndex = 4
        '
        'txtCantidad
        '
        Me.txtCantidad.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCantidad.EditValue = "1"
        Me.txtCantidad.Location = New System.Drawing.Point(462, 43)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCantidad.Properties.Appearance.Options.UseFont = True
        Me.txtCantidad.Properties.Appearance.Options.UseTextOptions = True
        Me.txtCantidad.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtCantidad.Size = New System.Drawing.Size(51, 22)
        Me.txtCantidad.TabIndex = 3
        '
        'LabelControl6
        '
        Me.LabelControl6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl6.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.LabelControl6.Location = New System.Drawing.Point(463, 24)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(50, 16)
        Me.LabelControl6.TabIndex = 8
        Me.LabelControl6.Text = "Cantidad"
        '
        'btnBuscar
        '
        Me.btnBuscar.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.Appearance.Options.UseFont = True
        Me.btnBuscar.Appearance.Options.UseTextOptions = True
        Me.btnBuscar.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBuscar.Image = Global.Portatiles.My.Resources.Resources.Find_32x32
        Me.btnBuscar.Location = New System.Drawing.Point(101, 30)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(40, 35)
        ToolTipTitleItem3.Text = "Buscar Producto"
        ToolTipItem3.LeftIndent = 6
        ToolTipItem3.Text = "Abre una cuadro de diálogo auxiliar con la lista de productos activos"
        SuperToolTip3.Items.Add(ToolTipTitleItem3)
        SuperToolTip3.Items.Add(ToolTipItem3)
        Me.btnBuscar.SuperTip = SuperToolTip3
        Me.btnBuscar.TabIndex = 1
        '
        'txtProducto
        '
        Me.txtProducto.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtProducto.Location = New System.Drawing.Point(147, 43)
        Me.txtProducto.Name = "txtProducto"
        Me.txtProducto.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtProducto.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProducto.Properties.Appearance.Options.UseBackColor = True
        Me.txtProducto.Properties.Appearance.Options.UseFont = True
        Me.txtProducto.Properties.ReadOnly = True
        Me.txtProducto.Size = New System.Drawing.Size(256, 22)
        Me.txtProducto.TabIndex = 9
        '
        'LabelControl9
        '
        Me.LabelControl9.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl9.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.LabelControl9.Location = New System.Drawing.Point(146, 25)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(50, 16)
        Me.LabelControl9.TabIndex = 6
        Me.LabelControl9.Text = "Producto"
        '
        'txtCodProducto
        '
        Me.txtCodProducto.Location = New System.Drawing.Point(11, 43)
        Me.txtCodProducto.Name = "txtCodProducto"
        Me.txtCodProducto.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodProducto.Properties.Appearance.Options.UseFont = True
        Me.txtCodProducto.Size = New System.Drawing.Size(84, 22)
        Me.txtCodProducto.TabIndex = 0
        '
        'LabelControl8
        '
        Me.LabelControl8.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl8.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.LabelControl8.Location = New System.Drawing.Point(11, 25)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(43, 16)
        Me.LabelControl8.TabIndex = 5
        Me.LabelControl8.Text = "Código"
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl5.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.LabelControl5.Location = New System.Drawing.Point(12, 456)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(83, 16)
        Me.LabelControl5.TabIndex = 21
        Me.LabelControl5.Text = "Observaciones"
        '
        'TxtObservaciones
        '
        Me.TxtObservaciones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtObservaciones.Location = New System.Drawing.Point(12, 477)
        Me.TxtObservaciones.Name = "TxtObservaciones"
        Me.TxtObservaciones.Size = New System.Drawing.Size(343, 45)
        Me.TxtObservaciones.TabIndex = 22
        '
        'FrmRemisiones
        '
        Me.Appearance.Options.UseFont = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(587, 531)
        Me.Controls.Add(Me.TxtObservaciones)
        Me.Controls.Add(Me.LabelControl5)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupControl3)
        Me.Controls.Add(Me.GroupControl2)
        Me.Controls.Add(Me.gcRemisiones)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.btnSalir)
        Me.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MinimumSize = New System.Drawing.Size(603, 569)
        Me.Name = "FrmRemisiones"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Módulo de Remisiones"
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.ChkEditando.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNumSucRemision.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DteFecha.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DteFecha.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNumRemision.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        Me.GroupControl2.PerformLayout()
        CType(Me.LueSucSalida.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MeObservaciones.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LueSucEntrada.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.txtTotalProductos.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotalCant.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gcRemisiones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvRemisiones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl3.ResumeLayout(False)
        Me.GroupControl3.PerformLayout()
        CType(Me.TxtExistencias.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCantidad.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtProducto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodProducto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtObservaciones.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents ChkEditando As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtNumSucRemision As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents DteFecha As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txtNumRemision As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents LueSucSalida As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LueSucEntrada As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtTotalProductos As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl13 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtTotalCant As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl12 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents MeObservaciones As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnGuardar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents gcRemisiones As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvRemisiones As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GroupControl3 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents btnAgregar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtCantidad As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnBuscar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtProducto As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCodProducto As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TxtObservaciones As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents TxtExistencias As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
End Class
