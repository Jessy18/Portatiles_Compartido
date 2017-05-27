<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAsistenteConfiguracion
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
        Me.XTCInicio = New DevExpress.XtraTab.XtraTabControl()
        Me.XTPEmpresa = New DevExpress.XtraTab.XtraTabPage()
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl()
        Me.BtnEmpresa = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.txtChequeNombre = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.txtTelefonos = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.txtDireccion = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.txtRUC = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.txtRazonSocial = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.txtNombreEmpresa = New DevExpress.XtraEditors.TextEdit()
        Me.XTPSucursal = New DevExpress.XtraTab.XtraTabPage()
        Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl()
        Me.BtnSucursal = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.txtDirSucursal = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.txtSucursal = New DevExpress.XtraEditors.TextEdit()
        Me.XTPUsuarios = New DevExpress.XtraTab.XtraTabPage()
        Me.LabelControl13 = New DevExpress.XtraEditors.LabelControl()
        Me.BtnFin = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.txtClave = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.txtUsuario = New DevExpress.XtraEditors.TextEdit()
        Me.PE3 = New DevExpress.XtraEditors.PictureEdit()
        Me.PE1 = New DevExpress.XtraEditors.PictureEdit()
        Me.PE2 = New DevExpress.XtraEditors.PictureEdit()
        Me.BtnCancelar = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.XTCInicio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XTCInicio.SuspendLayout()
        Me.XTPEmpresa.SuspendLayout()
        CType(Me.txtChequeNombre.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTelefonos.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDireccion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRUC.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRazonSocial.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNombreEmpresa.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XTPSucursal.SuspendLayout()
        CType(Me.txtDirSucursal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSucursal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XTPUsuarios.SuspendLayout()
        CType(Me.txtClave.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtUsuario.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PE3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PE1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PE2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'XTCInicio
        '
        Me.XTCInicio.Location = New System.Drawing.Point(0, -4)
        Me.XTCInicio.Name = "XTCInicio"
        Me.XTCInicio.SelectedTabPage = Me.XTPEmpresa
        Me.XTCInicio.Size = New System.Drawing.Size(439, 283)
        Me.XTCInicio.TabIndex = 0
        Me.XTCInicio.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XTPEmpresa, Me.XTPSucursal, Me.XTPUsuarios})
        '
        'XTPEmpresa
        '
        Me.XTPEmpresa.Controls.Add(Me.LabelControl11)
        Me.XTPEmpresa.Controls.Add(Me.BtnEmpresa)
        Me.XTPEmpresa.Controls.Add(Me.LabelControl5)
        Me.XTPEmpresa.Controls.Add(Me.txtChequeNombre)
        Me.XTPEmpresa.Controls.Add(Me.LabelControl6)
        Me.XTPEmpresa.Controls.Add(Me.txtTelefonos)
        Me.XTPEmpresa.Controls.Add(Me.LabelControl3)
        Me.XTPEmpresa.Controls.Add(Me.txtDireccion)
        Me.XTPEmpresa.Controls.Add(Me.LabelControl4)
        Me.XTPEmpresa.Controls.Add(Me.txtRUC)
        Me.XTPEmpresa.Controls.Add(Me.LabelControl2)
        Me.XTPEmpresa.Controls.Add(Me.txtRazonSocial)
        Me.XTPEmpresa.Controls.Add(Me.LabelControl1)
        Me.XTPEmpresa.Controls.Add(Me.txtNombreEmpresa)
        Me.XTPEmpresa.Name = "XTPEmpresa"
        Me.XTPEmpresa.Size = New System.Drawing.Size(433, 255)
        Me.XTPEmpresa.Text = "Empresa"
        '
        'LabelControl11
        '
        Me.LabelControl11.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.LabelControl11.Appearance.Font = New System.Drawing.Font("Berlin Sans FB Demi", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl11.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.LabelControl11.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.LabelControl11.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl11.Location = New System.Drawing.Point(67, 0)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(366, 30)
        Me.LabelControl11.TabIndex = 31
        Me.LabelControl11.Text = "Ingrese los datos generales de su negocio"
        '
        'BtnEmpresa
        '
        Me.BtnEmpresa.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnEmpresa.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEmpresa.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.BtnEmpresa.Appearance.Options.UseFont = True
        Me.BtnEmpresa.Appearance.Options.UseForeColor = True
        Me.BtnEmpresa.Image = Global.Portatiles.My.Resources.Resources.Arrow2_Right2
        Me.BtnEmpresa.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleRight
        Me.BtnEmpresa.Location = New System.Drawing.Point(329, 225)
        Me.BtnEmpresa.Name = "BtnEmpresa"
        Me.BtnEmpresa.Size = New System.Drawing.Size(100, 30)
        Me.BtnEmpresa.TabIndex = 17
        Me.BtnEmpresa.Text = "Siguiente"
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl5.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.LabelControl5.Location = New System.Drawing.Point(6, 191)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(102, 16)
        Me.LabelControl5.TabIndex = 29
        Me.LabelControl5.Text = "Cheque a nombre"
        '
        'txtChequeNombre
        '
        Me.txtChequeNombre.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtChequeNombre.Location = New System.Drawing.Point(114, 188)
        Me.txtChequeNombre.Name = "txtChequeNombre"
        Me.txtChequeNombre.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtChequeNombre.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.txtChequeNombre.Properties.Appearance.Options.UseFont = True
        Me.txtChequeNombre.Properties.Appearance.Options.UseForeColor = True
        Me.txtChequeNombre.Size = New System.Drawing.Size(300, 22)
        Me.txtChequeNombre.TabIndex = 28
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl6.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.LabelControl6.Location = New System.Drawing.Point(6, 163)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(56, 16)
        Me.LabelControl6.TabIndex = 27
        Me.LabelControl6.Text = "Teléfonos"
        '
        'txtTelefonos
        '
        Me.txtTelefonos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTelefonos.Location = New System.Drawing.Point(114, 160)
        Me.txtTelefonos.Name = "txtTelefonos"
        Me.txtTelefonos.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelefonos.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.txtTelefonos.Properties.Appearance.Options.UseFont = True
        Me.txtTelefonos.Properties.Appearance.Options.UseForeColor = True
        Me.txtTelefonos.Size = New System.Drawing.Size(300, 22)
        Me.txtTelefonos.TabIndex = 26
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.LabelControl3.Location = New System.Drawing.Point(6, 135)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(52, 16)
        Me.LabelControl3.TabIndex = 25
        Me.LabelControl3.Text = "Dirección"
        '
        'txtDireccion
        '
        Me.txtDireccion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDireccion.Location = New System.Drawing.Point(114, 132)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDireccion.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.txtDireccion.Properties.Appearance.Options.UseFont = True
        Me.txtDireccion.Properties.Appearance.Options.UseForeColor = True
        Me.txtDireccion.Size = New System.Drawing.Size(300, 22)
        Me.txtDireccion.TabIndex = 24
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.LabelControl4.Location = New System.Drawing.Point(6, 107)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(24, 16)
        Me.LabelControl4.TabIndex = 23
        Me.LabelControl4.Text = "RUC"
        '
        'txtRUC
        '
        Me.txtRUC.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtRUC.Location = New System.Drawing.Point(114, 104)
        Me.txtRUC.Name = "txtRUC"
        Me.txtRUC.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRUC.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.txtRUC.Properties.Appearance.Options.UseFont = True
        Me.txtRUC.Properties.Appearance.Options.UseForeColor = True
        Me.txtRUC.Size = New System.Drawing.Size(300, 22)
        Me.txtRUC.TabIndex = 22
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.LabelControl2.Location = New System.Drawing.Point(6, 79)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(71, 16)
        Me.LabelControl2.TabIndex = 21
        Me.LabelControl2.Text = "Razón social"
        '
        'txtRazonSocial
        '
        Me.txtRazonSocial.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtRazonSocial.Location = New System.Drawing.Point(114, 76)
        Me.txtRazonSocial.Name = "txtRazonSocial"
        Me.txtRazonSocial.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRazonSocial.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.txtRazonSocial.Properties.Appearance.Options.UseFont = True
        Me.txtRazonSocial.Properties.Appearance.Options.UseForeColor = True
        Me.txtRazonSocial.Size = New System.Drawing.Size(300, 22)
        Me.txtRazonSocial.TabIndex = 20
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.LabelControl1.Location = New System.Drawing.Point(6, 51)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(99, 16)
        Me.LabelControl1.TabIndex = 19
        Me.LabelControl1.Text = "Nombre empresa"
        '
        'txtNombreEmpresa
        '
        Me.txtNombreEmpresa.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNombreEmpresa.Location = New System.Drawing.Point(114, 48)
        Me.txtNombreEmpresa.Name = "txtNombreEmpresa"
        Me.txtNombreEmpresa.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombreEmpresa.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.txtNombreEmpresa.Properties.Appearance.Options.UseFont = True
        Me.txtNombreEmpresa.Properties.Appearance.Options.UseForeColor = True
        Me.txtNombreEmpresa.Size = New System.Drawing.Size(300, 22)
        Me.txtNombreEmpresa.TabIndex = 18
        '
        'XTPSucursal
        '
        Me.XTPSucursal.Controls.Add(Me.LabelControl12)
        Me.XTPSucursal.Controls.Add(Me.BtnSucursal)
        Me.XTPSucursal.Controls.Add(Me.LabelControl7)
        Me.XTPSucursal.Controls.Add(Me.txtDirSucursal)
        Me.XTPSucursal.Controls.Add(Me.LabelControl8)
        Me.XTPSucursal.Controls.Add(Me.txtSucursal)
        Me.XTPSucursal.Name = "XTPSucursal"
        Me.XTPSucursal.Size = New System.Drawing.Size(433, 255)
        Me.XTPSucursal.Text = "Sucursal"
        '
        'LabelControl12
        '
        Me.LabelControl12.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.LabelControl12.Appearance.Font = New System.Drawing.Font("Berlin Sans FB Demi", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl12.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.LabelControl12.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.LabelControl12.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl12.Location = New System.Drawing.Point(67, 5)
        Me.LabelControl12.Name = "LabelControl12"
        Me.LabelControl12.Size = New System.Drawing.Size(366, 30)
        Me.LabelControl12.TabIndex = 32
        Me.LabelControl12.Text = "Ingrese una sucursal de su negocio"
        '
        'BtnSucursal
        '
        Me.BtnSucursal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnSucursal.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSucursal.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.BtnSucursal.Appearance.Options.UseFont = True
        Me.BtnSucursal.Appearance.Options.UseForeColor = True
        Me.BtnSucursal.Image = Global.Portatiles.My.Resources.Resources.Arrow2_Right2
        Me.BtnSucursal.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleRight
        Me.BtnSucursal.Location = New System.Drawing.Point(329, 225)
        Me.BtnSucursal.Name = "BtnSucursal"
        Me.BtnSucursal.Size = New System.Drawing.Size(100, 30)
        Me.BtnSucursal.TabIndex = 26
        Me.BtnSucursal.Text = "Siguiente"
        '
        'LabelControl7
        '
        Me.LabelControl7.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl7.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.LabelControl7.Location = New System.Drawing.Point(6, 89)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(52, 16)
        Me.LabelControl7.TabIndex = 25
        Me.LabelControl7.Text = "Dirección"
        '
        'txtDirSucursal
        '
        Me.txtDirSucursal.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDirSucursal.Location = New System.Drawing.Point(11, 111)
        Me.txtDirSucursal.Name = "txtDirSucursal"
        Me.txtDirSucursal.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDirSucursal.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.txtDirSucursal.Properties.Appearance.Options.UseFont = True
        Me.txtDirSucursal.Properties.Appearance.Options.UseForeColor = True
        Me.txtDirSucursal.Size = New System.Drawing.Size(315, 22)
        Me.txtDirSucursal.TabIndex = 24
        '
        'LabelControl8
        '
        Me.LabelControl8.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl8.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.LabelControl8.Location = New System.Drawing.Point(6, 34)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(96, 16)
        Me.LabelControl8.TabIndex = 23
        Me.LabelControl8.Text = "Nombre sucursal"
        '
        'txtSucursal
        '
        Me.txtSucursal.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSucursal.Location = New System.Drawing.Point(11, 56)
        Me.txtSucursal.Name = "txtSucursal"
        Me.txtSucursal.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSucursal.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.txtSucursal.Properties.Appearance.Options.UseFont = True
        Me.txtSucursal.Properties.Appearance.Options.UseForeColor = True
        Me.txtSucursal.Size = New System.Drawing.Size(315, 22)
        Me.txtSucursal.TabIndex = 22
        '
        'XTPUsuarios
        '
        Me.XTPUsuarios.Controls.Add(Me.LabelControl13)
        Me.XTPUsuarios.Controls.Add(Me.BtnFin)
        Me.XTPUsuarios.Controls.Add(Me.LabelControl9)
        Me.XTPUsuarios.Controls.Add(Me.txtClave)
        Me.XTPUsuarios.Controls.Add(Me.LabelControl10)
        Me.XTPUsuarios.Controls.Add(Me.txtUsuario)
        Me.XTPUsuarios.Name = "XTPUsuarios"
        Me.XTPUsuarios.Size = New System.Drawing.Size(433, 255)
        Me.XTPUsuarios.Text = "Usuario"
        '
        'LabelControl13
        '
        Me.LabelControl13.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.LabelControl13.Appearance.Font = New System.Drawing.Font("Berlin Sans FB Demi", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl13.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.LabelControl13.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.LabelControl13.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl13.Location = New System.Drawing.Point(68, 5)
        Me.LabelControl13.Name = "LabelControl13"
        Me.LabelControl13.Size = New System.Drawing.Size(284, 30)
        Me.LabelControl13.TabIndex = 33
        Me.LabelControl13.Text = "Registre sus datos de usuario"
        '
        'BtnFin
        '
        Me.BtnFin.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnFin.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnFin.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.BtnFin.Appearance.Options.UseFont = True
        Me.BtnFin.Appearance.Options.UseForeColor = True
        Me.BtnFin.Image = Global.Portatiles.My.Resources.Resources.Arrow2_Right2
        Me.BtnFin.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleRight
        Me.BtnFin.Location = New System.Drawing.Point(329, 225)
        Me.BtnFin.Name = "BtnFin"
        Me.BtnFin.Size = New System.Drawing.Size(100, 30)
        Me.BtnFin.TabIndex = 27
        Me.BtnFin.Text = "Finalizar"
        '
        'LabelControl9
        '
        Me.LabelControl9.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl9.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.LabelControl9.Location = New System.Drawing.Point(7, 86)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(65, 16)
        Me.LabelControl9.TabIndex = 10
        Me.LabelControl9.Text = "Contraseña"
        '
        'txtClave
        '
        Me.txtClave.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtClave.Location = New System.Drawing.Point(11, 108)
        Me.txtClave.Name = "txtClave"
        Me.txtClave.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtClave.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.txtClave.Properties.Appearance.Options.UseFont = True
        Me.txtClave.Properties.Appearance.Options.UseForeColor = True
        Me.txtClave.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtClave.Size = New System.Drawing.Size(336, 22)
        Me.txtClave.TabIndex = 9
        '
        'LabelControl10
        '
        Me.LabelControl10.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl10.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.LabelControl10.Location = New System.Drawing.Point(7, 36)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(43, 16)
        Me.LabelControl10.TabIndex = 8
        Me.LabelControl10.Text = "Usuario"
        '
        'txtUsuario
        '
        Me.txtUsuario.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtUsuario.Location = New System.Drawing.Point(11, 58)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsuario.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.txtUsuario.Properties.Appearance.Options.UseFont = True
        Me.txtUsuario.Properties.Appearance.Options.UseForeColor = True
        Me.txtUsuario.Size = New System.Drawing.Size(336, 22)
        Me.txtUsuario.TabIndex = 7
        '
        'PE3
        '
        Me.PE3.EditValue = Global.Portatiles.My.Resources.Resources._31
        Me.PE3.Location = New System.Drawing.Point(0, -3)
        Me.PE3.Name = "PE3"
        Me.PE3.Size = New System.Drawing.Size(62, 58)
        Me.PE3.TabIndex = 35
        '
        'PE1
        '
        Me.PE1.EditValue = Global.Portatiles.My.Resources.Resources._11
        Me.PE1.Location = New System.Drawing.Point(1, -3)
        Me.PE1.Name = "PE1"
        Me.PE1.Size = New System.Drawing.Size(62, 58)
        Me.PE1.TabIndex = 36
        '
        'PE2
        '
        Me.PE2.EditValue = Global.Portatiles.My.Resources.Resources._21
        Me.PE2.Location = New System.Drawing.Point(0, -3)
        Me.PE2.Name = "PE2"
        Me.PE2.Size = New System.Drawing.Size(62, 58)
        Me.PE2.TabIndex = 37
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnCancelar.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancelar.Appearance.Options.UseFont = True
        Me.BtnCancelar.Image = Global.Portatiles.My.Resources.Resources.Cancel
        Me.BtnCancelar.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleRight
        Me.BtnCancelar.Location = New System.Drawing.Point(222, 241)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(102, 30)
        Me.BtnCancelar.TabIndex = 38
        Me.BtnCancelar.Text = "Cancelar"
        '
        'FrmAsistenteConfiguracion
        '
        Me.Appearance.Options.UseFont = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(434, 282)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.PE2)
        Me.Controls.Add(Me.PE1)
        Me.Controls.Add(Me.PE3)
        Me.Controls.Add(Me.XTCInicio)
        Me.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmAsistenteConfiguracion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Asistente de Configuración"
        CType(Me.XTCInicio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XTCInicio.ResumeLayout(False)
        Me.XTPEmpresa.ResumeLayout(False)
        Me.XTPEmpresa.PerformLayout()
        CType(Me.txtChequeNombre.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTelefonos.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDireccion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRUC.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRazonSocial.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNombreEmpresa.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XTPSucursal.ResumeLayout(False)
        Me.XTPSucursal.PerformLayout()
        CType(Me.txtDirSucursal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSucursal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XTPUsuarios.ResumeLayout(False)
        Me.XTPUsuarios.PerformLayout()
        CType(Me.txtClave.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtUsuario.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PE3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PE1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PE2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents XTCInicio As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XTPEmpresa As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents BtnEmpresa As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtChequeNombre As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtTelefonos As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtDireccion As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtRUC As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtRazonSocial As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtNombreEmpresa As DevExpress.XtraEditors.TextEdit
    Friend WithEvents XTPSucursal As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XTPUsuarios As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents BtnSucursal As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtDirSucursal As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtSucursal As DevExpress.XtraEditors.TextEdit
    Friend WithEvents BtnFin As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtClave As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtUsuario As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl12 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl13 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PE3 As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents PE1 As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents PE2 As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents BtnCancelar As DevExpress.XtraEditors.SimpleButton
End Class
