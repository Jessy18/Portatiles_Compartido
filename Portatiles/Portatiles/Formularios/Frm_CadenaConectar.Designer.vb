<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_CadenaConectar
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
        Me.cmbDevelopers = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.btnConectar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnSalir = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.cmbDevelopers.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(12, 12)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(258, 13)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "De los desarrolladores, Quién desea iniciar el sistema?"
        '
        'cmbDevelopers
        '
        Me.cmbDevelopers.EditValue = "Jessenia Collado"
        Me.cmbDevelopers.Location = New System.Drawing.Point(12, 36)
        Me.cmbDevelopers.Name = "cmbDevelopers"
        Me.cmbDevelopers.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbDevelopers.Properties.Appearance.Options.UseFont = True
        Me.cmbDevelopers.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbDevelopers.Properties.Items.AddRange(New Object() {"Jessenia Collado", "Esdrey Gómez", "Ariel Dávila"})
        Me.cmbDevelopers.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cmbDevelopers.Size = New System.Drawing.Size(258, 26)
        Me.cmbDevelopers.TabIndex = 1
        '
        'btnConectar
        '
        Me.btnConectar.Appearance.Image = Global.Portatiles.My.Resources.Resources.Arrow2_Right1
        Me.btnConectar.Appearance.Options.UseImage = True
        Me.btnConectar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnConectar.Image = Global.Portatiles.My.Resources.Resources.Ok2
        Me.btnConectar.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnConectar.Location = New System.Drawing.Point(158, 68)
        Me.btnConectar.Name = "btnConectar"
        Me.btnConectar.Size = New System.Drawing.Size(53, 44)
        Me.btnConectar.TabIndex = 2
        Me.btnConectar.ToolTip = "Conectar"
        '
        'btnSalir
        '
        Me.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSalir.Image = Global.Portatiles.My.Resources.Resources.Shutdown
        Me.btnSalir.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnSalir.Location = New System.Drawing.Point(217, 68)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(53, 44)
        Me.btnSalir.TabIndex = 3
        Me.btnSalir.ToolTip = "Salir"
        '
        'Frm_CadenaConectar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(278, 120)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnConectar)
        Me.Controls.Add(Me.cmbDevelopers)
        Me.Controls.Add(Me.LabelControl1)
        Me.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.None
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Frm_CadenaConectar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Proyecto"
        CType(Me.cmbDevelopers.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmbDevelopers As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents btnConectar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnSalir As DevExpress.XtraEditors.SimpleButton
End Class
