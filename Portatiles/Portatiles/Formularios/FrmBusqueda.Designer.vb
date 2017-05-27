<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBusqueda
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
        Me.gcRegistros = New DevExpress.XtraGrid.GridControl()
        Me.gvRegistros = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.btnSeleccionar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnSalir = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.gcRegistros, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvRegistros, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gcRegistros
        '
        Me.gcRegistros.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gcRegistros.Location = New System.Drawing.Point(-1, 1)
        Me.gcRegistros.MainView = Me.gvRegistros
        Me.gcRegistros.Name = "gcRegistros"
        Me.gcRegistros.Size = New System.Drawing.Size(521, 219)
        Me.gcRegistros.TabIndex = 5
        Me.gcRegistros.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvRegistros})
        '
        'gvRegistros
        '
        Me.gvRegistros.Appearance.Row.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.gvRegistros.Appearance.Row.Options.UseFont = True
        Me.gvRegistros.Appearance.ViewCaption.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gvRegistros.Appearance.ViewCaption.Options.UseFont = True
        Me.gvRegistros.GridControl = Me.gcRegistros
        Me.gvRegistros.Name = "gvRegistros"
        Me.gvRegistros.OptionsView.ShowAutoFilterRow = True
        Me.gvRegistros.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.gvRegistros.OptionsView.ShowGroupPanel = False
        '
        'btnSeleccionar
        '
        Me.btnSeleccionar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSeleccionar.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSeleccionar.Appearance.Options.UseFont = True
        Me.btnSeleccionar.Appearance.Options.UseTextOptions = True
        Me.btnSeleccionar.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.btnSeleccionar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSeleccionar.Image = Global.Portatiles.My.Resources.Resources.Ok3
        Me.btnSeleccionar.Location = New System.Drawing.Point(303, 226)
        Me.btnSeleccionar.Name = "btnSeleccionar"
        Me.btnSeleccionar.Size = New System.Drawing.Size(113, 37)
        Me.btnSeleccionar.TabIndex = 7
        Me.btnSeleccionar.Text = "Seleccionar"
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
        Me.btnSalir.Location = New System.Drawing.Point(422, 226)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(98, 37)
        Me.btnSalir.TabIndex = 6
        Me.btnSalir.Text = "Salir"
        '
        'FrmBusqueda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(520, 264)
        Me.Controls.Add(Me.btnSeleccionar)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.gcRegistros)
        Me.Name = "FrmBusqueda"
        Me.Text = "Búsqueda de registros"
        CType(Me.gcRegistros, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvRegistros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gcRegistros As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvRegistros As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents btnSeleccionar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnSalir As DevExpress.XtraEditors.SimpleButton
End Class
