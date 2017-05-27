<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSeriesProducto
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
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.btnAgregar = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.SpeCantidad = New DevExpress.XtraEditors.SpinEdit()
        Me.txtSerie = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.btnBuscar = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl16 = New DevExpress.XtraEditors.LabelControl()
        Me.LueProductos = New DevExpress.XtraEditors.LookUpEdit()
        Me.txtCantDisponible = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.txtNumCompra = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.gcMovimientos = New DevExpress.XtraGrid.GridControl()
        Me.gvMovimientos = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.btnGuardar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnSalir = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.SpeCantidad.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSerie.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LueProductos.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCantDisponible.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNumCompra.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gcMovimientos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvMovimientos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupControl1
        '
        Me.GroupControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupControl1.Controls.Add(Me.btnAgregar)
        Me.GroupControl1.Controls.Add(Me.LabelControl3)
        Me.GroupControl1.Controls.Add(Me.SpeCantidad)
        Me.GroupControl1.Controls.Add(Me.txtSerie)
        Me.GroupControl1.Controls.Add(Me.LabelControl2)
        Me.GroupControl1.Controls.Add(Me.btnBuscar)
        Me.GroupControl1.Controls.Add(Me.LabelControl16)
        Me.GroupControl1.Controls.Add(Me.LueProductos)
        Me.GroupControl1.Controls.Add(Me.txtCantDisponible)
        Me.GroupControl1.Controls.Add(Me.LabelControl4)
        Me.GroupControl1.Controls.Add(Me.txtNumCompra)
        Me.GroupControl1.Controls.Add(Me.LabelControl1)
        Me.GroupControl1.Location = New System.Drawing.Point(3, 3)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(578, 122)
        Me.GroupControl1.TabIndex = 1
        Me.GroupControl1.Text = "Datos de la Compra"
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
        Me.btnAgregar.Location = New System.Drawing.Point(528, 56)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(39, 53)
        Me.btnAgregar.TabIndex = 30
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Location = New System.Drawing.Point(138, 88)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(56, 18)
        Me.LabelControl3.TabIndex = 29
        Me.LabelControl3.Text = "Cantidad"
        '
        'SpeCantidad
        '
        Me.SpeCantidad.EditValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.SpeCantidad.Location = New System.Drawing.Point(200, 89)
        Me.SpeCantidad.Name = "SpeCantidad"
        Me.SpeCantidad.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SpeCantidad.Properties.MaxValue = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.SpeCantidad.Properties.MinValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.SpeCantidad.Size = New System.Drawing.Size(71, 20)
        Me.SpeCantidad.TabIndex = 28
        '
        'txtSerie
        '
        Me.txtSerie.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSerie.Location = New System.Drawing.Point(314, 89)
        Me.txtSerie.Name = "txtSerie"
        Me.txtSerie.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSerie.Properties.Appearance.Options.UseFont = True
        Me.txtSerie.Size = New System.Drawing.Size(208, 22)
        Me.txtSerie.TabIndex = 16
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Location = New System.Drawing.Point(277, 88)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(31, 18)
        Me.LabelControl2.TabIndex = 15
        Me.LabelControl2.Text = "Serie"
        '
        'btnBuscar
        '
        Me.btnBuscar.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.Appearance.Options.UseFont = True
        Me.btnBuscar.Appearance.Options.UseTextOptions = True
        Me.btnBuscar.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBuscar.Image = Global.Portatiles.My.Resources.Resources.Find_32x32
        Me.btnBuscar.Location = New System.Drawing.Point(166, 30)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(40, 24)
        ToolTipTitleItem1.Text = "Buscar Producto"
        ToolTipItem1.LeftIndent = 6
        ToolTipItem1.Text = "Abre una cuadro de diálogo auxiliar con la lista de productos activos"
        SuperToolTip1.Items.Add(ToolTipTitleItem1)
        SuperToolTip1.Items.Add(ToolTipItem1)
        Me.btnBuscar.SuperTip = SuperToolTip1
        Me.btnBuscar.TabIndex = 14
        '
        'LabelControl16
        '
        Me.LabelControl16.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl16.Location = New System.Drawing.Point(6, 56)
        Me.LabelControl16.Name = "LabelControl16"
        Me.LabelControl16.Size = New System.Drawing.Size(64, 18)
        Me.LabelControl16.TabIndex = 13
        Me.LabelControl16.Text = "Productos"
        '
        'LueProductos
        '
        Me.LueProductos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LueProductos.EditValue = ""
        Me.LueProductos.Location = New System.Drawing.Point(72, 60)
        Me.LueProductos.Name = "LueProductos"
        Me.LueProductos.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LueProductos.Properties.Appearance.Options.UseFont = True
        Me.LueProductos.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.LueProductos.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LueProductos.Properties.NullText = ""
        Me.LueProductos.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.OnlyInPopup
        Me.LueProductos.Size = New System.Drawing.Size(450, 22)
        Me.LueProductos.TabIndex = 12
        '
        'txtCantDisponible
        '
        Me.txtCantDisponible.Location = New System.Drawing.Point(72, 89)
        Me.txtCantDisponible.Name = "txtCantDisponible"
        Me.txtCantDisponible.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCantDisponible.Properties.Appearance.Options.UseFont = True
        Me.txtCantDisponible.Size = New System.Drawing.Size(60, 22)
        Me.txtCantDisponible.TabIndex = 11
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Location = New System.Drawing.Point(6, 90)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(63, 18)
        Me.LabelControl4.TabIndex = 8
        Me.LabelControl4.Text = "Disponible"
        '
        'txtNumCompra
        '
        Me.txtNumCompra.Location = New System.Drawing.Point(72, 30)
        Me.txtNumCompra.Name = "txtNumCompra"
        Me.txtNumCompra.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtNumCompra.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumCompra.Properties.Appearance.Options.UseBackColor = True
        Me.txtNumCompra.Properties.Appearance.Options.UseFont = True
        Me.txtNumCompra.Properties.ReadOnly = True
        Me.txtNumCompra.Size = New System.Drawing.Size(89, 22)
        Me.txtNumCompra.TabIndex = 0
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.LabelControl1.Location = New System.Drawing.Point(4, 30)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(63, 19)
        Me.LabelControl1.TabIndex = 5
        Me.LabelControl1.Text = "Compra"
        '
        'gcMovimientos
        '
        Me.gcMovimientos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gcMovimientos.Location = New System.Drawing.Point(3, 131)
        Me.gcMovimientos.MainView = Me.gvMovimientos
        Me.gcMovimientos.Name = "gcMovimientos"
        Me.gcMovimientos.Size = New System.Drawing.Size(578, 302)
        Me.gcMovimientos.TabIndex = 3
        Me.gcMovimientos.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvMovimientos})
        '
        'gvMovimientos
        '
        Me.gvMovimientos.Appearance.Row.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.gvMovimientos.Appearance.Row.Options.UseFont = True
        Me.gvMovimientos.Appearance.ViewCaption.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gvMovimientos.Appearance.ViewCaption.Options.UseFont = True
        Me.gvMovimientos.GridControl = Me.gcMovimientos
        Me.gvMovimientos.Name = "gvMovimientos"
        Me.gvMovimientos.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.gvMovimientos.OptionsView.ShowGroupPanel = False
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
        Me.btnGuardar.Location = New System.Drawing.Point(383, 442)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(98, 48)
        Me.btnGuardar.TabIndex = 6
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
        Me.btnSalir.Location = New System.Drawing.Point(483, 442)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(98, 48)
        Me.btnSalir.TabIndex = 7
        Me.btnSalir.Text = "Salir"
        '
        'FrmSeriesProducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(582, 502)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.gcMovimientos)
        Me.Controls.Add(Me.GroupControl1)
        Me.Name = "FrmSeriesProducto"
        Me.Text = "Series de Producto"
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.SpeCantidad.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSerie.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LueProductos.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCantDisponible.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNumCompra.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gcMovimientos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvMovimientos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents LabelControl16 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LueProductos As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents txtCantDisponible As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtNumCompra As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtSerie As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnBuscar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SpeCantidad As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents btnAgregar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents gcMovimientos As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvMovimientos As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents btnGuardar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnSalir As DevExpress.XtraEditors.SimpleButton
End Class
