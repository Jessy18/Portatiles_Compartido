﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCompras
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
        Dim SuperToolTip2 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem2 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim ToolTipItem2 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.btnAgregar = New DevExpress.XtraEditors.SimpleButton()
        Me.txtCantidad = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.txtCosto = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.btnBuscar = New DevExpress.XtraEditors.SimpleButton()
        Me.txtProducto = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.txtCodProducto = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.gcMovimientos = New DevExpress.XtraGrid.GridControl()
        Me.gvMovimientos = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.btnGuardar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnSalir = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.MeObservaciones = New DevExpress.XtraEditors.MemoEdit()
        Me.txtTotalCosto = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.LabelControl16 = New DevExpress.XtraEditors.LabelControl()
        Me.LueProveedor = New DevExpress.XtraEditors.LookUpEdit()
        Me.txtFacturaReferencia = New DevExpress.XtraEditors.TextEdit()
        Me.ChkEditando = New DevExpress.XtraEditors.CheckEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.lueSucursal = New DevExpress.XtraEditors.LookUpEdit()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.txtDocSucursal = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.DteFecha = New DevExpress.XtraEditors.DateEdit()
        Me.txtNumCompra = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtTotalCompra = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl15 = New DevExpress.XtraEditors.LabelControl()
        Me.txtIVA = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl14 = New DevExpress.XtraEditors.LabelControl()
        Me.txtTotalProductos = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl13 = New DevExpress.XtraEditors.LabelControl()
        Me.txtTotalCant = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.txtCantidad.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCosto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtProducto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodProducto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gcMovimientos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvMovimientos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MeObservaciones.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotalCosto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.LueProveedor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFacturaReferencia.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChkEditando.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueSucursal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDocSucursal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DteFecha.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DteFecha.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNumCompra.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.txtTotalCompra.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtIVA.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotalProductos.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotalCant.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupControl2
        '
        Me.GroupControl2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupControl2.Controls.Add(Me.btnAgregar)
        Me.GroupControl2.Controls.Add(Me.txtCantidad)
        Me.GroupControl2.Controls.Add(Me.LabelControl6)
        Me.GroupControl2.Controls.Add(Me.txtCosto)
        Me.GroupControl2.Controls.Add(Me.LabelControl5)
        Me.GroupControl2.Controls.Add(Me.btnBuscar)
        Me.GroupControl2.Controls.Add(Me.txtProducto)
        Me.GroupControl2.Controls.Add(Me.LabelControl9)
        Me.GroupControl2.Controls.Add(Me.txtCodProducto)
        Me.GroupControl2.Controls.Add(Me.LabelControl10)
        Me.GroupControl2.Location = New System.Drawing.Point(2, 83)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(560, 71)
        Me.GroupControl2.TabIndex = 1
        Me.GroupControl2.Text = "Datos de Producto"
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
        Me.btnAgregar.Location = New System.Drawing.Point(516, 22)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(39, 43)
        Me.btnAgregar.TabIndex = 4
        '
        'txtCantidad
        '
        Me.txtCantidad.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCantidad.EditValue = "1"
        Me.txtCantidad.Location = New System.Drawing.Point(440, 43)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCantidad.Properties.Appearance.Options.UseFont = True
        Me.txtCantidad.Size = New System.Drawing.Size(72, 22)
        Me.txtCantidad.TabIndex = 3
        '
        'LabelControl6
        '
        Me.LabelControl6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl6.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.LabelControl6.Location = New System.Drawing.Point(441, 24)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(50, 16)
        Me.LabelControl6.TabIndex = 8
        Me.LabelControl6.Text = "Cantidad"
        '
        'txtCosto
        '
        Me.txtCosto.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCosto.Location = New System.Drawing.Point(364, 43)
        Me.txtCosto.Name = "txtCosto"
        Me.txtCosto.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCosto.Properties.Appearance.Options.UseFont = True
        Me.txtCosto.Size = New System.Drawing.Size(72, 22)
        Me.txtCosto.TabIndex = 2
        '
        'LabelControl5
        '
        Me.LabelControl5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl5.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.LabelControl5.Location = New System.Drawing.Point(364, 24)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(32, 16)
        Me.LabelControl5.TabIndex = 7
        Me.LabelControl5.Text = "Costo"
        '
        'btnBuscar
        '
        Me.btnBuscar.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.Appearance.Options.UseFont = True
        Me.btnBuscar.Appearance.Options.UseTextOptions = True
        Me.btnBuscar.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBuscar.Image = Global.Portatiles.My.Resources.Resources.Search4
        Me.btnBuscar.Location = New System.Drawing.Point(81, 33)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(32, 32)
        ToolTipTitleItem2.Text = "Buscar Producto"
        ToolTipItem2.LeftIndent = 6
        ToolTipItem2.Text = "Abre una cuadro de diálogo auxiliar con la lista de productos activos"
        SuperToolTip2.Items.Add(ToolTipTitleItem2)
        SuperToolTip2.Items.Add(ToolTipItem2)
        Me.btnBuscar.SuperTip = SuperToolTip2
        Me.btnBuscar.TabIndex = 1
        '
        'txtProducto
        '
        Me.txtProducto.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtProducto.Location = New System.Drawing.Point(114, 43)
        Me.txtProducto.Name = "txtProducto"
        Me.txtProducto.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtProducto.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProducto.Properties.Appearance.Options.UseBackColor = True
        Me.txtProducto.Properties.Appearance.Options.UseFont = True
        Me.txtProducto.Properties.ReadOnly = True
        Me.txtProducto.Size = New System.Drawing.Size(245, 22)
        Me.txtProducto.TabIndex = 9
        '
        'LabelControl9
        '
        Me.LabelControl9.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl9.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.LabelControl9.Location = New System.Drawing.Point(113, 25)
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
        Me.txtCodProducto.Size = New System.Drawing.Size(69, 22)
        Me.txtCodProducto.TabIndex = 0
        '
        'LabelControl10
        '
        Me.LabelControl10.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl10.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.LabelControl10.Location = New System.Drawing.Point(11, 25)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(43, 16)
        Me.LabelControl10.TabIndex = 5
        Me.LabelControl10.Text = "Código"
        '
        'gcMovimientos
        '
        Me.gcMovimientos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gcMovimientos.Location = New System.Drawing.Point(2, 158)
        Me.gcMovimientos.MainView = Me.gvMovimientos
        Me.gcMovimientos.Name = "gcMovimientos"
        Me.gcMovimientos.Size = New System.Drawing.Size(560, 265)
        Me.gcMovimientos.TabIndex = 2
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
        Me.btnGuardar.Location = New System.Drawing.Point(364, 491)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(98, 48)
        Me.btnGuardar.TabIndex = 4
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
        Me.btnSalir.Location = New System.Drawing.Point(464, 491)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(98, 48)
        Me.btnSalir.TabIndex = 5
        Me.btnSalir.Text = "Salir"
        '
        'LabelControl7
        '
        Me.LabelControl7.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LabelControl7.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl7.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.LabelControl7.Location = New System.Drawing.Point(2, 473)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(83, 16)
        Me.LabelControl7.TabIndex = 6
        Me.LabelControl7.Text = "Observaciones"
        '
        'MeObservaciones
        '
        Me.MeObservaciones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MeObservaciones.Location = New System.Drawing.Point(2, 491)
        Me.MeObservaciones.Name = "MeObservaciones"
        Me.MeObservaciones.Size = New System.Drawing.Size(356, 48)
        Me.MeObservaciones.TabIndex = 3
        '
        'txtTotalCosto
        '
        Me.txtTotalCosto.Location = New System.Drawing.Point(258, 14)
        Me.txtTotalCosto.Name = "txtTotalCosto"
        Me.txtTotalCosto.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtTotalCosto.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalCosto.Properties.Appearance.Options.UseBackColor = True
        Me.txtTotalCosto.Properties.Appearance.Options.UseFont = True
        Me.txtTotalCosto.Properties.ReadOnly = True
        Me.txtTotalCosto.Size = New System.Drawing.Size(72, 22)
        Me.txtTotalCosto.TabIndex = 5
        '
        'LabelControl11
        '
        Me.LabelControl11.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl11.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.LabelControl11.Location = New System.Drawing.Point(205, 17)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(47, 16)
        Me.LabelControl11.TabIndex = 4
        Me.LabelControl11.Text = "Subtotal"
        '
        'GroupControl1
        '
        Me.GroupControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupControl1.Controls.Add(Me.LabelControl16)
        Me.GroupControl1.Controls.Add(Me.LueProveedor)
        Me.GroupControl1.Controls.Add(Me.txtFacturaReferencia)
        Me.GroupControl1.Controls.Add(Me.ChkEditando)
        Me.GroupControl1.Controls.Add(Me.LabelControl4)
        Me.GroupControl1.Controls.Add(Me.lueSucursal)
        Me.GroupControl1.Controls.Add(Me.LabelControl8)
        Me.GroupControl1.Controls.Add(Me.LabelControl3)
        Me.GroupControl1.Controls.Add(Me.txtDocSucursal)
        Me.GroupControl1.Controls.Add(Me.LabelControl2)
        Me.GroupControl1.Controls.Add(Me.DteFecha)
        Me.GroupControl1.Controls.Add(Me.txtNumCompra)
        Me.GroupControl1.Controls.Add(Me.LabelControl1)
        Me.GroupControl1.Location = New System.Drawing.Point(2, 0)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(560, 81)
        Me.GroupControl1.TabIndex = 0
        Me.GroupControl1.Text = "Datos de la Compra"
        '
        'LabelControl16
        '
        Me.LabelControl16.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl16.Location = New System.Drawing.Point(6, 50)
        Me.LabelControl16.Name = "LabelControl16"
        Me.LabelControl16.Size = New System.Drawing.Size(66, 18)
        Me.LabelControl16.TabIndex = 13
        Me.LabelControl16.Text = "Proveedor"
        '
        'LueProveedor
        '
        Me.LueProveedor.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LueProveedor.EditValue = ""
        Me.LueProveedor.Location = New System.Drawing.Point(72, 49)
        Me.LueProveedor.Name = "LueProveedor"
        Me.LueProveedor.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LueProveedor.Properties.Appearance.Options.UseFont = True
        Me.LueProveedor.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.LueProveedor.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LueProveedor.Properties.NullText = ""
        Me.LueProveedor.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.OnlyInPopup
        Me.LueProveedor.Size = New System.Drawing.Size(170, 22)
        Me.LueProveedor.TabIndex = 12
        '
        'txtFacturaReferencia
        '
        Me.txtFacturaReferencia.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtFacturaReferencia.Location = New System.Drawing.Point(322, 49)
        Me.txtFacturaReferencia.Name = "txtFacturaReferencia"
        Me.txtFacturaReferencia.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFacturaReferencia.Properties.Appearance.Options.UseFont = True
        Me.txtFacturaReferencia.Size = New System.Drawing.Size(60, 22)
        Me.txtFacturaReferencia.TabIndex = 11
        '
        'ChkEditando
        '
        Me.ChkEditando.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkEditando.Location = New System.Drawing.Point(472, 1)
        Me.ChkEditando.Name = "ChkEditando"
        Me.ChkEditando.Properties.Appearance.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkEditando.Properties.Appearance.Options.UseFont = True
        Me.ChkEditando.Properties.Caption = "Editando"
        Me.ChkEditando.Properties.ReadOnly = True
        Me.ChkEditando.Size = New System.Drawing.Size(78, 19)
        Me.ChkEditando.TabIndex = 10
        '
        'LabelControl4
        '
        Me.LabelControl4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Location = New System.Drawing.Point(250, 52)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(68, 18)
        Me.LabelControl4.TabIndex = 8
        Me.LabelControl4.Text = "Referencia"
        '
        'lueSucursal
        '
        Me.lueSucursal.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lueSucursal.EditValue = ""
        Me.lueSucursal.Location = New System.Drawing.Point(442, 49)
        Me.lueSucursal.Name = "lueSucursal"
        Me.lueSucursal.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lueSucursal.Properties.Appearance.Options.UseFont = True
        Me.lueSucursal.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.lueSucursal.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueSucursal.Properties.NullText = ""
        Me.lueSucursal.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.OnlyInPopup
        Me.lueSucursal.Size = New System.Drawing.Size(113, 22)
        Me.lueSucursal.TabIndex = 4
        '
        'LabelControl8
        '
        Me.LabelControl8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl8.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl8.Location = New System.Drawing.Point(387, 50)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(53, 18)
        Me.LabelControl8.TabIndex = 9
        Me.LabelControl8.Text = "Sucursal"
        '
        'LabelControl3
        '
        Me.LabelControl3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.LabelControl3.Location = New System.Drawing.Point(401, 26)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(39, 18)
        Me.LabelControl3.TabIndex = 7
        Me.LabelControl3.Text = "Fecha"
        '
        'txtDocSucursal
        '
        Me.txtDocSucursal.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDocSucursal.Location = New System.Drawing.Point(288, 24)
        Me.txtDocSucursal.Name = "txtDocSucursal"
        Me.txtDocSucursal.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtDocSucursal.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDocSucursal.Properties.Appearance.Options.UseBackColor = True
        Me.txtDocSucursal.Properties.Appearance.Options.UseFont = True
        Me.txtDocSucursal.Properties.ReadOnly = True
        Me.txtDocSucursal.Size = New System.Drawing.Size(94, 22)
        Me.txtDocSucursal.TabIndex = 1
        '
        'LabelControl2
        '
        Me.LabelControl2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.LabelControl2.Location = New System.Drawing.Point(194, 25)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(88, 18)
        Me.LabelControl2.TabIndex = 6
        Me.LabelControl2.Text = "Doc. Sucursal"
        '
        'DteFecha
        '
        Me.DteFecha.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DteFecha.EditValue = Nothing
        Me.DteFecha.Location = New System.Drawing.Point(442, 24)
        Me.DteFecha.Name = "DteFecha"
        Me.DteFecha.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DteFecha.Properties.Appearance.Options.UseFont = True
        Me.DteFecha.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DteFecha.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DteFecha.Size = New System.Drawing.Size(113, 22)
        Me.DteFecha.TabIndex = 2
        '
        'txtNumCompra
        '
        Me.txtNumCompra.Location = New System.Drawing.Point(97, 24)
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
        Me.LabelControl1.Location = New System.Drawing.Point(4, 24)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(90, 19)
        Me.LabelControl1.TabIndex = 5
        Me.LabelControl1.Text = "No Compra"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.txtTotalCompra)
        Me.GroupBox1.Controls.Add(Me.LabelControl15)
        Me.GroupBox1.Controls.Add(Me.txtIVA)
        Me.GroupBox1.Controls.Add(Me.LabelControl14)
        Me.GroupBox1.Controls.Add(Me.txtTotalProductos)
        Me.GroupBox1.Controls.Add(Me.LabelControl13)
        Me.GroupBox1.Controls.Add(Me.txtTotalCant)
        Me.GroupBox1.Controls.Add(Me.LabelControl12)
        Me.GroupBox1.Controls.Add(Me.txtTotalCosto)
        Me.GroupBox1.Controls.Add(Me.LabelControl11)
        Me.GroupBox1.Location = New System.Drawing.Point(2, 429)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(560, 40)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Totales"
        '
        'txtTotalCompra
        '
        Me.txtTotalCompra.Location = New System.Drawing.Point(483, 14)
        Me.txtTotalCompra.Name = "txtTotalCompra"
        Me.txtTotalCompra.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtTotalCompra.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalCompra.Properties.Appearance.Options.UseBackColor = True
        Me.txtTotalCompra.Properties.Appearance.Options.UseFont = True
        Me.txtTotalCompra.Properties.ReadOnly = True
        Me.txtTotalCompra.Size = New System.Drawing.Size(72, 22)
        Me.txtTotalCompra.TabIndex = 9
        '
        'LabelControl15
        '
        Me.LabelControl15.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl15.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.LabelControl15.Location = New System.Drawing.Point(449, 17)
        Me.LabelControl15.Name = "LabelControl15"
        Me.LabelControl15.Size = New System.Drawing.Size(29, 16)
        Me.LabelControl15.TabIndex = 8
        Me.LabelControl15.Text = "Total"
        '
        'txtIVA
        '
        Me.txtIVA.Location = New System.Drawing.Point(367, 14)
        Me.txtIVA.Name = "txtIVA"
        Me.txtIVA.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtIVA.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIVA.Properties.Appearance.Options.UseBackColor = True
        Me.txtIVA.Properties.Appearance.Options.UseFont = True
        Me.txtIVA.Properties.ReadOnly = True
        Me.txtIVA.Size = New System.Drawing.Size(72, 22)
        Me.txtIVA.TabIndex = 7
        '
        'LabelControl14
        '
        Me.LabelControl14.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl14.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.LabelControl14.Location = New System.Drawing.Point(343, 17)
        Me.LabelControl14.Name = "LabelControl14"
        Me.LabelControl14.Size = New System.Drawing.Size(20, 16)
        Me.LabelControl14.TabIndex = 6
        Me.LabelControl14.Text = "IVA"
        '
        'txtTotalProductos
        '
        Me.txtTotalProductos.Location = New System.Drawing.Point(65, 14)
        Me.txtTotalProductos.Name = "txtTotalProductos"
        Me.txtTotalProductos.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtTotalProductos.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalProductos.Properties.Appearance.Options.UseBackColor = True
        Me.txtTotalProductos.Properties.Appearance.Options.UseFont = True
        Me.txtTotalProductos.Properties.ReadOnly = True
        Me.txtTotalProductos.Size = New System.Drawing.Size(36, 22)
        Me.txtTotalProductos.TabIndex = 1
        '
        'LabelControl13
        '
        Me.LabelControl13.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl13.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.LabelControl13.Location = New System.Drawing.Point(107, 17)
        Me.LabelControl13.Name = "LabelControl13"
        Me.LabelControl13.Size = New System.Drawing.Size(50, 16)
        Me.LabelControl13.TabIndex = 2
        Me.LabelControl13.Text = "Cantidad"
        '
        'txtTotalCant
        '
        Me.txtTotalCant.Location = New System.Drawing.Point(163, 14)
        Me.txtTotalCant.Name = "txtTotalCant"
        Me.txtTotalCant.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtTotalCant.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalCant.Properties.Appearance.Options.UseBackColor = True
        Me.txtTotalCant.Properties.Appearance.Options.UseFont = True
        Me.txtTotalCant.Properties.ReadOnly = True
        Me.txtTotalCant.Size = New System.Drawing.Size(36, 22)
        Me.txtTotalCant.TabIndex = 3
        '
        'LabelControl12
        '
        Me.LabelControl12.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl12.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.LabelControl12.Location = New System.Drawing.Point(6, 17)
        Me.LabelControl12.Name = "LabelControl12"
        Me.LabelControl12.Size = New System.Drawing.Size(56, 16)
        Me.LabelControl12.TabIndex = 0
        Me.LabelControl12.Text = "Productos"
        '
        'FrmCompras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(564, 542)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.MeObservaciones)
        Me.Controls.Add(Me.LabelControl7)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.gcMovimientos)
        Me.Controls.Add(Me.GroupControl2)
        Me.MinimumSize = New System.Drawing.Size(580, 580)
        Me.Name = "FrmCompras"
        Me.Text = "Compra de productos"
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        Me.GroupControl2.PerformLayout()
        CType(Me.txtCantidad.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCosto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtProducto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodProducto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gcMovimientos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvMovimientos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MeObservaciones.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotalCosto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.LueProveedor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFacturaReferencia.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChkEditando.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueSucursal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDocSucursal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DteFecha.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DteFecha.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNumCompra.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.txtTotalCompra.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtIVA.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotalProductos.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotalCant.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents txtProducto As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCodProducto As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnBuscar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtCosto As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCantidad As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnAgregar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents gcMovimientos As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvMovimientos As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents btnGuardar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents MeObservaciones As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents txtTotalCosto As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lueSucursal As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtDocSucursal As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents DteFecha As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txtNumCompra As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtTotalProductos As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl13 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtTotalCant As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl12 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents ChkEditando As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents txtFacturaReferencia As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtTotalCompra As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl15 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtIVA As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl14 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl16 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LueProveedor As DevExpress.XtraEditors.LookUpEdit
End Class
