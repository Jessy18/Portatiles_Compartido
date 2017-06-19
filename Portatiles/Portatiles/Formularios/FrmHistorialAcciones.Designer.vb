<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmHistorialAcciones
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
        Me.gcHistorial = New DevExpress.XtraGrid.GridControl()
        Me.gvHistorial = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GroupControl3 = New DevExpress.XtraEditors.GroupControl()
        Me.btnFiltrar = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.dteFechaFIN = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.dteFechaINI = New DevExpress.XtraEditors.DateEdit()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.glueSucursal = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.gvlueSucursal = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.glueUsuario = New DevExpress.XtraEditors.GridLookUpEdit()
        Me.gvlueUsuario = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.btnSalir = New DevExpress.XtraEditors.SimpleButton()
        Me.btnImprimir = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.gcHistorial, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvHistorial, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl3.SuspendLayout()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.dteFechaFIN.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dteFechaFIN.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dteFechaINI.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dteFechaINI.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.glueSucursal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvlueSucursal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.glueUsuario.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvlueUsuario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gcHistorial
        '
        Me.gcHistorial.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gcHistorial.Location = New System.Drawing.Point(12, 99)
        Me.gcHistorial.MainView = Me.gvHistorial
        Me.gcHistorial.Name = "gcHistorial"
        Me.gcHistorial.Size = New System.Drawing.Size(861, 294)
        Me.gcHistorial.TabIndex = 0
        Me.gcHistorial.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvHistorial})
        '
        'gvHistorial
        '
        Me.gvHistorial.GridControl = Me.gcHistorial
        Me.gvHistorial.Name = "gvHistorial"
        Me.gvHistorial.OptionsBehavior.Editable = False
        Me.gvHistorial.OptionsView.ShowGroupPanel = False
        Me.gvHistorial.OptionsView.ShowViewCaption = True
        '
        'GroupControl3
        '
        Me.GroupControl3.Controls.Add(Me.btnFiltrar)
        Me.GroupControl3.Location = New System.Drawing.Point(723, 13)
        Me.GroupControl3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupControl3.Name = "GroupControl3"
        Me.GroupControl3.Size = New System.Drawing.Size(150, 79)
        Me.GroupControl3.TabIndex = 28
        Me.GroupControl3.Text = "Filtros"
        '
        'btnFiltrar
        '
        Me.btnFiltrar.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFiltrar.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFiltrar.Appearance.Options.UseFont = True
        Me.btnFiltrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFiltrar.Image = Global.Portatiles.My.Resources.Resources.Ok3
        Me.btnFiltrar.Location = New System.Drawing.Point(20, 28)
        Me.btnFiltrar.Name = "btnFiltrar"
        Me.btnFiltrar.Size = New System.Drawing.Size(109, 41)
        Me.btnFiltrar.TabIndex = 23
        Me.btnFiltrar.Text = "Filtrar"
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.LabelControl2)
        Me.GroupControl2.Controls.Add(Me.dteFechaFIN)
        Me.GroupControl2.Controls.Add(Me.LabelControl3)
        Me.GroupControl2.Controls.Add(Me.dteFechaINI)
        Me.GroupControl2.Location = New System.Drawing.Point(455, 13)
        Me.GroupControl2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(262, 79)
        Me.GroupControl2.TabIndex = 27
        Me.GroupControl2.Text = "Rango de Fechas"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Location = New System.Drawing.Point(16, 28)
        Me.LabelControl2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(71, 16)
        Me.LabelControl2.TabIndex = 19
        Me.LabelControl2.Text = "Fecha Inicial"
        '
        'dteFechaFIN
        '
        Me.dteFechaFIN.EditValue = New Date(2017, 6, 18, 22, 9, 11, 458)
        Me.dteFechaFIN.Location = New System.Drawing.Point(142, 47)
        Me.dteFechaFIN.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dteFechaFIN.Name = "dteFechaFIN"
        Me.dteFechaFIN.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.dteFechaFIN.Properties.Appearance.Options.UseFont = True
        Me.dteFechaFIN.Properties.Appearance.Options.UseTextOptions = True
        Me.dteFechaFIN.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.dteFechaFIN.Properties.AppearanceDropDown.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.dteFechaFIN.Properties.AppearanceDropDown.Options.UseFont = True
        Me.dteFechaFIN.Properties.AppearanceDropDownHeader.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.dteFechaFIN.Properties.AppearanceDropDownHeader.Options.UseFont = True
        Me.dteFechaFIN.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dteFechaFIN.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dteFechaFIN.Size = New System.Drawing.Size(95, 22)
        Me.dteFechaFIN.TabIndex = 22
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Location = New System.Drawing.Point(142, 28)
        Me.LabelControl3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(65, 16)
        Me.LabelControl3.TabIndex = 20
        Me.LabelControl3.Text = "Fecha Final"
        '
        'dteFechaINI
        '
        Me.dteFechaINI.EditValue = New Date(2017, 6, 18, 22, 9, 11, 458)
        Me.dteFechaINI.Location = New System.Drawing.Point(16, 47)
        Me.dteFechaINI.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dteFechaINI.Name = "dteFechaINI"
        Me.dteFechaINI.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.dteFechaINI.Properties.Appearance.Options.UseFont = True
        Me.dteFechaINI.Properties.Appearance.Options.UseTextOptions = True
        Me.dteFechaINI.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.dteFechaINI.Properties.AppearanceDropDown.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.dteFechaINI.Properties.AppearanceDropDown.Options.UseFont = True
        Me.dteFechaINI.Properties.AppearanceDropDownHeader.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.dteFechaINI.Properties.AppearanceDropDownHeader.Options.UseFont = True
        Me.dteFechaINI.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dteFechaINI.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dteFechaINI.Size = New System.Drawing.Size(95, 22)
        Me.dteFechaINI.TabIndex = 21
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.glueSucursal)
        Me.GroupControl1.Controls.Add(Me.LabelControl4)
        Me.GroupControl1.Controls.Add(Me.glueUsuario)
        Me.GroupControl1.Controls.Add(Me.LabelControl1)
        Me.GroupControl1.Location = New System.Drawing.Point(12, 13)
        Me.GroupControl1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(437, 79)
        Me.GroupControl1.TabIndex = 26
        Me.GroupControl1.Text = "Filtros"
        '
        'glueSucursal
        '
        Me.glueSucursal.EditValue = ""
        Me.glueSucursal.Location = New System.Drawing.Point(222, 47)
        Me.glueSucursal.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.glueSucursal.Name = "glueSucursal"
        Me.glueSucursal.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.glueSucursal.Properties.Appearance.Options.UseFont = True
        Me.glueSucursal.Properties.AppearanceDropDown.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.glueSucursal.Properties.AppearanceDropDown.Options.UseFont = True
        Me.glueSucursal.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.glueSucursal.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.glueSucursal.Properties.NullText = ""
        Me.glueSucursal.Properties.View = Me.gvlueSucursal
        Me.glueSucursal.Size = New System.Drawing.Size(206, 22)
        Me.glueSucursal.TabIndex = 20
        '
        'gvlueSucursal
        '
        Me.gvlueSucursal.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.gvlueSucursal.Name = "gvlueSucursal"
        Me.gvlueSucursal.OptionsBehavior.Editable = False
        Me.gvlueSucursal.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gvlueSucursal.OptionsView.ShowAutoFilterRow = True
        Me.gvlueSucursal.OptionsView.ShowGroupPanel = False
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Cursor = System.Windows.Forms.Cursors.Cross
        Me.LabelControl4.Location = New System.Drawing.Point(222, 28)
        Me.LabelControl4.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(49, 16)
        Me.LabelControl4.TabIndex = 19
        Me.LabelControl4.Text = "Sucursal"
        '
        'glueUsuario
        '
        Me.glueUsuario.EditValue = ""
        Me.glueUsuario.Location = New System.Drawing.Point(5, 47)
        Me.glueUsuario.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.glueUsuario.Name = "glueUsuario"
        Me.glueUsuario.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.glueUsuario.Properties.Appearance.Options.UseFont = True
        Me.glueUsuario.Properties.AppearanceDropDown.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.glueUsuario.Properties.AppearanceDropDown.Options.UseFont = True
        Me.glueUsuario.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.glueUsuario.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.glueUsuario.Properties.NullText = ""
        Me.glueUsuario.Properties.View = Me.gvlueUsuario
        Me.glueUsuario.Size = New System.Drawing.Size(206, 22)
        Me.glueUsuario.TabIndex = 18
        '
        'gvlueUsuario
        '
        Me.gvlueUsuario.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.gvlueUsuario.Name = "gvlueUsuario"
        Me.gvlueUsuario.OptionsBehavior.Editable = False
        Me.gvlueUsuario.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gvlueUsuario.OptionsView.ShowAutoFilterRow = True
        Me.gvlueUsuario.OptionsView.ShowGroupPanel = False
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Cursor = System.Windows.Forms.Cursors.Cross
        Me.LabelControl1.Location = New System.Drawing.Point(5, 28)
        Me.LabelControl1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(43, 16)
        Me.LabelControl1.TabIndex = 17
        Me.LabelControl1.Text = "Usuario"
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
        Me.btnSalir.Location = New System.Drawing.Point(775, 400)
        Me.btnSalir.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(98, 48)
        Me.btnSalir.TabIndex = 29
        Me.btnSalir.Text = "Salir"
        '
        'btnImprimir
        '
        Me.btnImprimir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnImprimir.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImprimir.Appearance.Options.UseFont = True
        Me.btnImprimir.Appearance.Options.UseTextOptions = True
        Me.btnImprimir.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.btnImprimir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnImprimir.Image = Global.Portatiles.My.Resources.Resources.Print_32x32
        Me.btnImprimir.Location = New System.Drawing.Point(671, 400)
        Me.btnImprimir.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(98, 48)
        Me.btnImprimir.TabIndex = 30
        Me.btnImprimir.Text = "Imprimir"
        '
        'FrmHistorialAcciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(881, 457)
        Me.Controls.Add(Me.btnImprimir)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.GroupControl3)
        Me.Controls.Add(Me.GroupControl2)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.gcHistorial)
        Me.Name = "FrmHistorialAcciones"
        Me.Text = "Historial de Acciones"
        CType(Me.gcHistorial, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvHistorial, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl3.ResumeLayout(False)
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        Me.GroupControl2.PerformLayout()
        CType(Me.dteFechaFIN.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dteFechaFIN.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dteFechaINI.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dteFechaINI.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.glueSucursal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvlueSucursal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.glueUsuario.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvlueUsuario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gcHistorial As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvHistorial As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GroupControl3 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents btnFiltrar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents dteFechaFIN As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents dteFechaINI As DevExpress.XtraEditors.DateEdit
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents glueSucursal As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents gvlueSucursal As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents glueUsuario As DevExpress.XtraEditors.GridLookUpEdit
    Friend WithEvents gvlueUsuario As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnImprimir As DevExpress.XtraEditors.SimpleButton
End Class
