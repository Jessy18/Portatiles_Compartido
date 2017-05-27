<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmInicioSesion
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
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.TxtUsuario = New DevExpress.XtraEditors.TextEdit()
        Me.TxtPass = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.SBtnCancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.SBtnIngresar = New DevExpress.XtraEditors.SimpleButton()
        Me.chkRecordarUsuario = New DevExpress.XtraEditors.CheckEdit()
        CType(Me.TxtUsuario.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtPass.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkRecordarUsuario.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.LabelControl1.Location = New System.Drawing.Point(26, 65)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(62, 23)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "Usuario"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.LabelControl2.Location = New System.Drawing.Point(26, 103)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(94, 23)
        Me.LabelControl2.TabIndex = 1
        Me.LabelControl2.Text = "Contraseña"
        '
        'TxtUsuario
        '
        Me.TxtUsuario.Location = New System.Drawing.Point(150, 66)
        Me.TxtUsuario.Name = "TxtUsuario"
        Me.TxtUsuario.Properties.Appearance.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtUsuario.Properties.Appearance.Options.UseFont = True
        Me.TxtUsuario.Size = New System.Drawing.Size(130, 22)
        Me.TxtUsuario.TabIndex = 2
        '
        'TxtPass
        '
        Me.TxtPass.Location = New System.Drawing.Point(150, 104)
        Me.TxtPass.Name = "TxtPass"
        Me.TxtPass.Properties.Appearance.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPass.Properties.Appearance.Options.UseFont = True
        Me.TxtPass.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtPass.Size = New System.Drawing.Size(130, 22)
        Me.TxtPass.TabIndex = 3
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.LabelControl3.Location = New System.Drawing.Point(38, 12)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(187, 23)
        Me.LabelControl3.TabIndex = 4
        Me.LabelControl3.Text = "Ingresando a SCI-Port"
        '
        'SBtnCancelar
        '
        Me.SBtnCancelar.Appearance.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SBtnCancelar.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.SBtnCancelar.Appearance.Options.UseFont = True
        Me.SBtnCancelar.Appearance.Options.UseForeColor = True
        Me.SBtnCancelar.Image = Global.Portatiles.My.Resources.Resources.Cancel1
        Me.SBtnCancelar.Location = New System.Drawing.Point(162, 161)
        Me.SBtnCancelar.Name = "SBtnCancelar"
        Me.SBtnCancelar.Size = New System.Drawing.Size(118, 41)
        Me.SBtnCancelar.TabIndex = 6
        Me.SBtnCancelar.Text = "Cancelar"
        '
        'SBtnIngresar
        '
        Me.SBtnIngresar.Appearance.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SBtnIngresar.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.SBtnIngresar.Appearance.Options.UseFont = True
        Me.SBtnIngresar.Appearance.Options.UseForeColor = True
        Me.SBtnIngresar.Image = Global.Portatiles.My.Resources.Resources.Ok1
        Me.SBtnIngresar.Location = New System.Drawing.Point(38, 161)
        Me.SBtnIngresar.Name = "SBtnIngresar"
        Me.SBtnIngresar.Size = New System.Drawing.Size(118, 41)
        Me.SBtnIngresar.TabIndex = 5
        Me.SBtnIngresar.Text = "Aceptar"
        '
        'chkRecordarUsuario
        '
        Me.chkRecordarUsuario.Location = New System.Drawing.Point(128, 132)
        Me.chkRecordarUsuario.Name = "chkRecordarUsuario"
        Me.chkRecordarUsuario.Properties.Appearance.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkRecordarUsuario.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.chkRecordarUsuario.Properties.Appearance.Options.UseFont = True
        Me.chkRecordarUsuario.Properties.Appearance.Options.UseForeColor = True
        Me.chkRecordarUsuario.Properties.Caption = "Recordar Usuario"
        Me.chkRecordarUsuario.Size = New System.Drawing.Size(152, 23)
        Me.chkRecordarUsuario.TabIndex = 8
        '
        'FrmInicioSesion
        '
        Me.Appearance.BackColor = System.Drawing.Color.White
        Me.Appearance.Options.UseBackColor = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(305, 219)
        Me.Controls.Add(Me.chkRecordarUsuario)
        Me.Controls.Add(Me.SBtnCancelar)
        Me.Controls.Add(Me.SBtnIngresar)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.TxtPass)
        Me.Controls.Add(Me.TxtUsuario)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.LabelControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmInicioSesion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inicio"
        CType(Me.TxtUsuario.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtPass.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkRecordarUsuario.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TxtUsuario As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TxtPass As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SBtnIngresar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SBtnCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents chkRecordarUsuario As DevExpress.XtraEditors.CheckEdit
End Class
