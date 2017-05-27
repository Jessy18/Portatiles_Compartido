<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SplashAsistenteInicio
    Inherits DevExpress.XtraSplashScreen.SplashScreen

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SplashAsistenteInicio))
        Me.LblPasos = New DevExpress.XtraEditors.LabelControl()
        Me.labelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.PBPasos = New DevExpress.XtraEditors.MarqueeProgressBarControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.BtnCancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.BtnEmpresa = New DevExpress.XtraEditors.SimpleButton()
        Me.pictureEdit1 = New DevExpress.XtraEditors.PictureEdit()
        Me.pictureEdit2 = New DevExpress.XtraEditors.PictureEdit()
        CType(Me.PBPasos.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblPasos
        '
        Me.LblPasos.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.LblPasos.Location = New System.Drawing.Point(23, 212)
        Me.LblPasos.Name = "LblPasos"
        Me.LblPasos.Size = New System.Drawing.Size(147, 13)
        Me.LblPasos.TabIndex = 12
        Me.LblPasos.Text = "Cargando asistente de inicio..."
        '
        'labelControl1
        '
        Me.labelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.labelControl1.Location = New System.Drawing.Point(23, 286)
        Me.labelControl1.Name = "labelControl1"
        Me.labelControl1.Size = New System.Drawing.Size(24, 13)
        Me.labelControl1.TabIndex = 11
        Me.labelControl1.Text = "2017"
        '
        'PBPasos
        '
        Me.PBPasos.EditValue = 0
        Me.PBPasos.Location = New System.Drawing.Point(23, 231)
        Me.PBPasos.Name = "PBPasos"
        Me.PBPasos.Size = New System.Drawing.Size(404, 20)
        Me.PBPasos.TabIndex = 10
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Berlin Sans FB Demi", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.LabelControl2.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.LabelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl2.Location = New System.Drawing.Point(12, 133)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(426, 51)
        Me.LabelControl2.TabIndex = 15
        Me.LabelControl2.Text = "¡Bienvenido a su sistema! Ahora deberá configurar algunos datos de su negocio."
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnCancelar.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancelar.Appearance.Options.UseFont = True
        Me.BtnCancelar.Image = Global.Portatiles.My.Resources.Resources.Cancel
        Me.BtnCancelar.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleRight
        Me.BtnCancelar.Location = New System.Drawing.Point(219, 264)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(102, 30)
        Me.BtnCancelar.TabIndex = 32
        Me.BtnCancelar.Text = "Cancelar"
        '
        'BtnEmpresa
        '
        Me.BtnEmpresa.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnEmpresa.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEmpresa.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.BtnEmpresa.Appearance.Options.UseFont = True
        Me.BtnEmpresa.Appearance.Options.UseForeColor = True
        Me.BtnEmpresa.Image = Global.Portatiles.My.Resources.Resources.Ok
        Me.BtnEmpresa.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleRight
        Me.BtnEmpresa.Location = New System.Drawing.Point(327, 264)
        Me.BtnEmpresa.Name = "BtnEmpresa"
        Me.BtnEmpresa.Size = New System.Drawing.Size(100, 30)
        Me.BtnEmpresa.TabIndex = 31
        Me.BtnEmpresa.Text = "Empezar"
        '
        'pictureEdit1
        '
        Me.pictureEdit1.Cursor = System.Windows.Forms.Cursors.Default
        Me.pictureEdit1.EditValue = CType(resources.GetObject("pictureEdit1.EditValue"), Object)
        Me.pictureEdit1.Location = New System.Drawing.Point(78, 260)
        Me.pictureEdit1.Name = "pictureEdit1"
        Me.pictureEdit1.Properties.AllowFocused = False
        Me.pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.pictureEdit1.Properties.Appearance.Options.UseBackColor = True
        Me.pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.pictureEdit1.Properties.ShowMenu = False
        Me.pictureEdit1.Size = New System.Drawing.Size(108, 48)
        Me.pictureEdit1.TabIndex = 13
        Me.pictureEdit1.Visible = False
        '
        'pictureEdit2
        '
        Me.pictureEdit2.Cursor = System.Windows.Forms.Cursors.Default
        Me.pictureEdit2.EditValue = CType(resources.GetObject("pictureEdit2.EditValue"), Object)
        Me.pictureEdit2.Location = New System.Drawing.Point(12, 12)
        Me.pictureEdit2.Name = "pictureEdit2"
        Me.pictureEdit2.Properties.AllowFocused = False
        Me.pictureEdit2.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.pictureEdit2.Properties.Appearance.Options.UseBackColor = True
        Me.pictureEdit2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.pictureEdit2.Properties.ShowMenu = False
        Me.pictureEdit2.Size = New System.Drawing.Size(426, 194)
        Me.pictureEdit2.TabIndex = 14
        '
        'SplashAsistenteInicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(450, 320)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnEmpresa)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.pictureEdit1)
        Me.Controls.Add(Me.LblPasos)
        Me.Controls.Add(Me.labelControl1)
        Me.Controls.Add(Me.PBPasos)
        Me.Controls.Add(Me.pictureEdit2)
        Me.Name = "SplashAsistenteInicio"
        CType(Me.PBPasos.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents pictureEdit2 As DevExpress.XtraEditors.PictureEdit
    Private WithEvents pictureEdit1 As DevExpress.XtraEditors.PictureEdit
    Private WithEvents LblPasos As DevExpress.XtraEditors.LabelControl
    Private WithEvents labelControl1 As DevExpress.XtraEditors.LabelControl
    Private WithEvents PBPasos As DevExpress.XtraEditors.MarqueeProgressBarControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents BtnCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnEmpresa As DevExpress.XtraEditors.SimpleButton
End Class
