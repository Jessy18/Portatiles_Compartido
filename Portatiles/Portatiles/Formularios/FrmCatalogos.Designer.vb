<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCatalogos
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
        Me.PanelTree = New DevExpress.XtraEditors.PanelControl()
        Me.TreeCatalogos = New DevExpress.XtraTreeList.TreeList()
        Me.SplitterControl1 = New DevExpress.XtraEditors.SplitterControl()
        Me.PanelPrincipal = New DevExpress.XtraEditors.PanelControl()
        Me.PanelBotones = New DevExpress.XtraEditors.PanelControl()
        Me.btnNuevo = New DevExpress.XtraEditors.SimpleButton()
        Me.btnGuardar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnEliminar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnSalir = New DevExpress.XtraEditors.SimpleButton()
        Me.XTPCatalogos = New DevExpress.XtraTab.XtraTabControl()
        Me.xtpUsuarios = New DevExpress.XtraTab.XtraTabPage()
        Me.ChkUsuarioAdministrador = New DevExpress.XtraEditors.CheckEdit()
        Me.ChkUsuarioActivo = New DevExpress.XtraEditors.CheckEdit()
        Me.lueSucursalUsuario = New DevExpress.XtraEditors.LookUpEdit()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.txtClave = New DevExpress.XtraEditors.TextEdit()
        Me.gcUsuarios = New DevExpress.XtraGrid.GridControl()
        Me.gvUsuarios = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.txtUsuario = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.TxtIdIUsuario = New DevExpress.XtraEditors.TextEdit()
        Me.xtpMarcas = New DevExpress.XtraTab.XtraTabPage()
        Me.ChkMarcaActiva = New DevExpress.XtraEditors.CheckEdit()
        Me.gcMarcas = New DevExpress.XtraGrid.GridControl()
        Me.gvMarcas = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.txtMarca = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.txtIdMarca = New DevExpress.XtraEditors.TextEdit()
        Me.xtpCategorias = New DevExpress.XtraTab.XtraTabPage()
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.txtPUtilidad2 = New DevExpress.XtraEditors.TextEdit()
        Me.txtPUtilidad3 = New DevExpress.XtraEditors.TextEdit()
        Me.txtComision = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.txtPUtilidad1 = New DevExpress.XtraEditors.TextEdit()
        Me.ChkCategoriaActiva = New DevExpress.XtraEditors.CheckEdit()
        Me.gcCategorias = New DevExpress.XtraGrid.GridControl()
        Me.gvCategorias = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.txtCategoria = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.TxtIdCategoria = New DevExpress.XtraEditors.TextEdit()
        Me.XTPTipoAjuste = New DevExpress.XtraTab.XtraTabPage()
        Me.RDGValorAjuste = New DevExpress.XtraEditors.RadioGroup()
        Me.LabelControl14 = New DevExpress.XtraEditors.LabelControl()
        Me.gcTipoAjuste = New DevExpress.XtraGrid.GridControl()
        Me.gvTipoAjuste = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl()
        Me.txtTipoAjuste = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl13 = New DevExpress.XtraEditors.LabelControl()
        Me.txtIdTipoAjuste = New DevExpress.XtraEditors.TextEdit()
        Me.XtcSucursal = New DevExpress.XtraTab.XtraTabPage()
        Me.GCNumeraciones = New DevExpress.XtraEditors.GroupControl()
        Me.LabelControl21 = New DevExpress.XtraEditors.LabelControl()
        Me.SpeNumAjuste = New DevExpress.XtraEditors.SpinEdit()
        Me.LabelControl20 = New DevExpress.XtraEditors.LabelControl()
        Me.SpeNumFactura = New DevExpress.XtraEditors.SpinEdit()
        Me.LabelControl19 = New DevExpress.XtraEditors.LabelControl()
        Me.SpeNumRemision = New DevExpress.XtraEditors.SpinEdit()
        Me.LabelControl18 = New DevExpress.XtraEditors.LabelControl()
        Me.SpeNumCompra = New DevExpress.XtraEditors.SpinEdit()
        Me.txtDirSucursal = New DevExpress.XtraEditors.TextEdit()
        Me.ChkSucursalActiva = New DevExpress.XtraEditors.CheckEdit()
        Me.LabelControl15 = New DevExpress.XtraEditors.LabelControl()
        Me.GCSucursal = New DevExpress.XtraGrid.GridControl()
        Me.GvSucursal = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.LabelControl16 = New DevExpress.XtraEditors.LabelControl()
        Me.txtSucursal = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl17 = New DevExpress.XtraEditors.LabelControl()
        Me.txtIdSucursal = New DevExpress.XtraEditors.TextEdit()
        Me.XTPProveedor = New DevExpress.XtraTab.XtraTabPage()
        Me.txtCorreoProveedor = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl24 = New DevExpress.XtraEditors.LabelControl()
        Me.txtRUCProveedor = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl23 = New DevExpress.XtraEditors.LabelControl()
        Me.txtTelProveedor = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl22 = New DevExpress.XtraEditors.LabelControl()
        Me.txtDirProveedor = New DevExpress.XtraEditors.TextEdit()
        Me.ChkProveedorActivo = New DevExpress.XtraEditors.CheckEdit()
        Me.LabelControl26 = New DevExpress.XtraEditors.LabelControl()
        Me.GCProveedores = New DevExpress.XtraGrid.GridControl()
        Me.GVProveedores = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.LabelControl27 = New DevExpress.XtraEditors.LabelControl()
        Me.txtProveedor = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl28 = New DevExpress.XtraEditors.LabelControl()
        Me.txtIdProveedor = New DevExpress.XtraEditors.TextEdit()
        Me.XTPVendedores = New DevExpress.XtraTab.XtraTabPage()
        Me.txtCorreoVendedor = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl25 = New DevExpress.XtraEditors.LabelControl()
        Me.txtApellidosVendedor = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl29 = New DevExpress.XtraEditors.LabelControl()
        Me.txtTelVendedor = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl30 = New DevExpress.XtraEditors.LabelControl()
        Me.txtDirVendedor = New DevExpress.XtraEditors.TextEdit()
        Me.ChkVendedorActivo = New DevExpress.XtraEditors.CheckEdit()
        Me.LabelControl31 = New DevExpress.XtraEditors.LabelControl()
        Me.GCVendedores = New DevExpress.XtraGrid.GridControl()
        Me.GVVendedores = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.LabelControl32 = New DevExpress.XtraEditors.LabelControl()
        Me.txtNombresVendedor = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl33 = New DevExpress.XtraEditors.LabelControl()
        Me.txtIdVendedor = New DevExpress.XtraEditors.TextEdit()
        Me.XTPClientes = New DevExpress.XtraTab.XtraTabPage()
        Me.XTCClientes = New DevExpress.XtraTab.XtraTabControl()
        Me.XTPListaCliente = New DevExpress.XtraTab.XtraTabPage()
        Me.GCClientes = New DevExpress.XtraGrid.GridControl()
        Me.GVClientes = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.XTPDatosCliente = New DevExpress.XtraTab.XtraTabPage()
        Me.ChkClienteExonerado = New DevExpress.XtraEditors.CheckEdit()
        Me.txtRUCCliente = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl39 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl41 = New DevExpress.XtraEditors.LabelControl()
        Me.txtIdCliente = New DevExpress.XtraEditors.TextEdit()
        Me.txtApellidosCliente = New DevExpress.XtraEditors.TextEdit()
        Me.txtEmpresaCliente = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl40 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl38 = New DevExpress.XtraEditors.LabelControl()
        Me.txtCorreoCliente = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl37 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl34 = New DevExpress.XtraEditors.LabelControl()
        Me.ChkClienteActivo = New DevExpress.XtraEditors.CheckEdit()
        Me.txtNombresCliente = New DevExpress.XtraEditors.TextEdit()
        Me.txtDirCliente = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl35 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl36 = New DevExpress.XtraEditors.LabelControl()
        Me.txtTelCliente = New DevExpress.XtraEditors.TextEdit()
        Me.XTPProductos = New DevExpress.XtraTab.XtraTabPage()
        Me.XTCProductos = New DevExpress.XtraTab.XtraTabControl()
        Me.XTPListaProductos = New DevExpress.XtraTab.XtraTabPage()
        Me.GCProductos = New DevExpress.XtraGrid.GridControl()
        Me.GVProductos = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.XTPDatosProducto = New DevExpress.XtraTab.XtraTabPage()
        Me.ChkEsServicio = New DevExpress.XtraEditors.CheckEdit()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.RDGMonedaProducto = New DevExpress.XtraEditors.RadioGroup()
        Me.txtCosto = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl45 = New DevExpress.XtraEditors.LabelControl()
        Me.ChkProductoExonerado = New DevExpress.XtraEditors.CheckEdit()
        Me.LueMarcas = New DevExpress.XtraEditors.LookUpEdit()
        Me.LueCategorias = New DevExpress.XtraEditors.LookUpEdit()
        Me.txtExistencia = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl42 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl43 = New DevExpress.XtraEditors.LabelControl()
        Me.txtIdProducto = New DevExpress.XtraEditors.TextEdit()
        Me.txtProducto = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl44 = New DevExpress.XtraEditors.LabelControl()
        Me.LblCleanCategoria = New DevExpress.XtraEditors.LabelControl()
        Me.txtPrecio3 = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl46 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl47 = New DevExpress.XtraEditors.LabelControl()
        Me.ChkProductoActivo = New DevExpress.XtraEditors.CheckEdit()
        Me.txtPrecio1 = New DevExpress.XtraEditors.TextEdit()
        Me.LblCleanMarca = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl49 = New DevExpress.XtraEditors.LabelControl()
        Me.txtPrecio2 = New DevExpress.XtraEditors.TextEdit()
        Me.PanelTitulo = New DevExpress.XtraEditors.PanelControl()
        Me.LblTitulo = New DevExpress.XtraEditors.LabelControl()
        Me.Splitter1 = New System.Windows.Forms.Splitter()
        CType(Me.PanelTree, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelTree.SuspendLayout()
        CType(Me.TreeCatalogos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelPrincipal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelPrincipal.SuspendLayout()
        CType(Me.PanelBotones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelBotones.SuspendLayout()
        CType(Me.XTPCatalogos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XTPCatalogos.SuspendLayout()
        Me.xtpUsuarios.SuspendLayout()
        CType(Me.ChkUsuarioAdministrador.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChkUsuarioActivo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lueSucursalUsuario.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtClave.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gcUsuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvUsuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtUsuario.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtIdIUsuario.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.xtpMarcas.SuspendLayout()
        CType(Me.ChkMarcaActiva.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gcMarcas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvMarcas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMarca.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtIdMarca.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.xtpCategorias.SuspendLayout()
        CType(Me.txtPUtilidad2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPUtilidad3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtComision.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPUtilidad1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChkCategoriaActiva.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gcCategorias, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvCategorias, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCategoria.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtIdCategoria.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XTPTipoAjuste.SuspendLayout()
        CType(Me.RDGValorAjuste.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gcTipoAjuste, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvTipoAjuste, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTipoAjuste.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtIdTipoAjuste.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtcSucursal.SuspendLayout()
        CType(Me.GCNumeraciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GCNumeraciones.SuspendLayout()
        CType(Me.SpeNumAjuste.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpeNumFactura.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpeNumRemision.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpeNumCompra.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDirSucursal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChkSucursalActiva.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GCSucursal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GvSucursal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSucursal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtIdSucursal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XTPProveedor.SuspendLayout()
        CType(Me.txtCorreoProveedor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRUCProveedor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTelProveedor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDirProveedor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChkProveedorActivo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GCProveedores, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVProveedores, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtProveedor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtIdProveedor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XTPVendedores.SuspendLayout()
        CType(Me.txtCorreoVendedor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtApellidosVendedor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTelVendedor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDirVendedor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChkVendedorActivo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GCVendedores, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVVendedores, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNombresVendedor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtIdVendedor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XTPClientes.SuspendLayout()
        CType(Me.XTCClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XTCClientes.SuspendLayout()
        Me.XTPListaCliente.SuspendLayout()
        CType(Me.GCClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XTPDatosCliente.SuspendLayout()
        CType(Me.ChkClienteExonerado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRUCCliente.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtIdCliente.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtApellidosCliente.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEmpresaCliente.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCorreoCliente.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChkClienteActivo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNombresCliente.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDirCliente.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTelCliente.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XTPProductos.SuspendLayout()
        CType(Me.XTCProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XTCProductos.SuspendLayout()
        Me.XTPListaProductos.SuspendLayout()
        CType(Me.GCProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XTPDatosProducto.SuspendLayout()
        CType(Me.ChkEsServicio.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.RDGMonedaProducto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCosto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChkProductoExonerado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LueMarcas.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LueCategorias.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtExistencia.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtIdProducto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtProducto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPrecio3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChkProductoActivo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPrecio1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPrecio2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelTitulo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelTitulo.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelTree
        '
        Me.PanelTree.Controls.Add(Me.TreeCatalogos)
        Me.PanelTree.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelTree.Location = New System.Drawing.Point(0, 0)
        Me.PanelTree.Name = "PanelTree"
        Me.PanelTree.Size = New System.Drawing.Size(237, 471)
        Me.PanelTree.TabIndex = 1
        '
        'TreeCatalogos
        '
        Me.TreeCatalogos.Appearance.BandPanel.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TreeCatalogos.Appearance.BandPanel.Options.UseFont = True
        Me.TreeCatalogos.Appearance.FilterPanel.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TreeCatalogos.Appearance.FilterPanel.Options.UseFont = True
        Me.TreeCatalogos.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TreeCatalogos.Appearance.FocusedCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TreeCatalogos.Appearance.FocusedCell.Options.UseBackColor = True
        Me.TreeCatalogos.Appearance.FocusedCell.Options.UseFont = True
        Me.TreeCatalogos.Appearance.SelectedRow.BackColor = System.Drawing.Color.LightSteelBlue
        Me.TreeCatalogos.Appearance.SelectedRow.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TreeCatalogos.Appearance.SelectedRow.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TreeCatalogos.Appearance.SelectedRow.Options.UseBackColor = True
        Me.TreeCatalogos.Appearance.SelectedRow.Options.UseFont = True
        Me.TreeCatalogos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TreeCatalogos.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TreeCatalogos.Location = New System.Drawing.Point(2, 2)
        Me.TreeCatalogos.Name = "TreeCatalogos"
        Me.TreeCatalogos.OptionsView.ShowAutoFilterRow = True
        Me.TreeCatalogos.Size = New System.Drawing.Size(233, 467)
        Me.TreeCatalogos.TabIndex = 1
        Me.TreeCatalogos.TreeLineStyle = DevExpress.XtraTreeList.LineStyle.Solid
        '
        'SplitterControl1
        '
        Me.SplitterControl1.Location = New System.Drawing.Point(237, 0)
        Me.SplitterControl1.Name = "SplitterControl1"
        Me.SplitterControl1.Size = New System.Drawing.Size(5, 471)
        Me.SplitterControl1.TabIndex = 2
        Me.SplitterControl1.TabStop = False
        '
        'PanelPrincipal
        '
        Me.PanelPrincipal.Controls.Add(Me.PanelBotones)
        Me.PanelPrincipal.Controls.Add(Me.XTPCatalogos)
        Me.PanelPrincipal.Controls.Add(Me.PanelTitulo)
        Me.PanelPrincipal.Controls.Add(Me.Splitter1)
        Me.PanelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelPrincipal.Location = New System.Drawing.Point(242, 0)
        Me.PanelPrincipal.Name = "PanelPrincipal"
        Me.PanelPrincipal.Size = New System.Drawing.Size(481, 471)
        Me.PanelPrincipal.TabIndex = 3
        '
        'PanelBotones
        '
        Me.PanelBotones.Controls.Add(Me.btnNuevo)
        Me.PanelBotones.Controls.Add(Me.btnGuardar)
        Me.PanelBotones.Controls.Add(Me.btnEliminar)
        Me.PanelBotones.Controls.Add(Me.btnSalir)
        Me.PanelBotones.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelBotones.Location = New System.Drawing.Point(5, 404)
        Me.PanelBotones.Name = "PanelBotones"
        Me.PanelBotones.Size = New System.Drawing.Size(474, 65)
        Me.PanelBotones.TabIndex = 4
        '
        'btnNuevo
        '
        Me.btnNuevo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNuevo.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevo.Appearance.Options.UseFont = True
        Me.btnNuevo.Appearance.Options.UseTextOptions = True
        Me.btnNuevo.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.btnNuevo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNuevo.Image = Global.Portatiles.My.Resources.Resources.add1
        Me.btnNuevo.Location = New System.Drawing.Point(56, 9)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(98, 48)
        Me.btnNuevo.TabIndex = 3
        Me.btnNuevo.Text = "Nuevo"
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
        Me.btnGuardar.Location = New System.Drawing.Point(160, 9)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(98, 48)
        Me.btnGuardar.TabIndex = 2
        Me.btnGuardar.Text = "Guardar"
        '
        'btnEliminar
        '
        Me.btnEliminar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEliminar.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.Appearance.Options.UseFont = True
        Me.btnEliminar.Appearance.Options.UseTextOptions = True
        Me.btnEliminar.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEliminar.Image = Global.Portatiles.My.Resources.Resources.Delete_32x32
        Me.btnEliminar.Location = New System.Drawing.Point(264, 9)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(98, 48)
        Me.btnEliminar.TabIndex = 1
        Me.btnEliminar.Text = "Eliminar"
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
        Me.btnSalir.Location = New System.Drawing.Point(368, 9)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(98, 48)
        Me.btnSalir.TabIndex = 0
        Me.btnSalir.Text = "Salir"
        '
        'XTPCatalogos
        '
        Me.XTPCatalogos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.XTPCatalogos.AppearancePage.Header.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XTPCatalogos.AppearancePage.Header.Options.UseFont = True
        Me.XTPCatalogos.AppearancePage.HeaderActive.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XTPCatalogos.AppearancePage.HeaderActive.Options.UseFont = True
        Me.XTPCatalogos.Location = New System.Drawing.Point(8, 47)
        Me.XTPCatalogos.Name = "XTPCatalogos"
        Me.XTPCatalogos.SelectedTabPage = Me.xtpUsuarios
        Me.XTPCatalogos.Size = New System.Drawing.Size(472, 355)
        Me.XTPCatalogos.TabIndex = 3
        Me.XTPCatalogos.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.xtpUsuarios, Me.xtpMarcas, Me.xtpCategorias, Me.XTPTipoAjuste, Me.XtcSucursal, Me.XTPProveedor, Me.XTPVendedores, Me.XTPClientes, Me.XTPProductos})
        '
        'xtpUsuarios
        '
        Me.xtpUsuarios.Controls.Add(Me.ChkUsuarioAdministrador)
        Me.xtpUsuarios.Controls.Add(Me.ChkUsuarioActivo)
        Me.xtpUsuarios.Controls.Add(Me.lueSucursalUsuario)
        Me.xtpUsuarios.Controls.Add(Me.LabelControl8)
        Me.xtpUsuarios.Controls.Add(Me.LabelControl7)
        Me.xtpUsuarios.Controls.Add(Me.txtClave)
        Me.xtpUsuarios.Controls.Add(Me.gcUsuarios)
        Me.xtpUsuarios.Controls.Add(Me.LabelControl2)
        Me.xtpUsuarios.Controls.Add(Me.txtUsuario)
        Me.xtpUsuarios.Controls.Add(Me.LabelControl1)
        Me.xtpUsuarios.Controls.Add(Me.TxtIdIUsuario)
        Me.xtpUsuarios.Name = "xtpUsuarios"
        Me.xtpUsuarios.Size = New System.Drawing.Size(466, 324)
        Me.xtpUsuarios.Text = "Usuarios"
        '
        'ChkUsuarioAdministrador
        '
        Me.ChkUsuarioAdministrador.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkUsuarioAdministrador.Location = New System.Drawing.Point(288, 13)
        Me.ChkUsuarioAdministrador.Name = "ChkUsuarioAdministrador"
        Me.ChkUsuarioAdministrador.Properties.Appearance.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkUsuarioAdministrador.Properties.Appearance.Options.UseFont = True
        Me.ChkUsuarioAdministrador.Properties.Caption = "Administrador"
        Me.ChkUsuarioAdministrador.Size = New System.Drawing.Size(110, 19)
        Me.ChkUsuarioAdministrador.TabIndex = 10
        '
        'ChkUsuarioActivo
        '
        Me.ChkUsuarioActivo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkUsuarioActivo.Location = New System.Drawing.Point(404, 13)
        Me.ChkUsuarioActivo.Name = "ChkUsuarioActivo"
        Me.ChkUsuarioActivo.Properties.Appearance.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkUsuarioActivo.Properties.Appearance.Options.UseFont = True
        Me.ChkUsuarioActivo.Properties.Caption = "Activo"
        Me.ChkUsuarioActivo.Size = New System.Drawing.Size(58, 19)
        Me.ChkUsuarioActivo.TabIndex = 9
        '
        'lueSucursalUsuario
        '
        Me.lueSucursalUsuario.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lueSucursalUsuario.EditValue = ""
        Me.lueSucursalUsuario.Location = New System.Drawing.Point(98, 97)
        Me.lueSucursalUsuario.Name = "lueSucursalUsuario"
        Me.lueSucursalUsuario.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.lueSucursalUsuario.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueSucursalUsuario.Properties.NullText = ""
        Me.lueSucursalUsuario.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.OnlyInPopup
        Me.lueSucursalUsuario.Size = New System.Drawing.Size(364, 20)
        Me.lueSucursalUsuario.TabIndex = 8
        '
        'LabelControl8
        '
        Me.LabelControl8.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl8.Location = New System.Drawing.Point(10, 98)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(49, 16)
        Me.LabelControl8.TabIndex = 7
        Me.LabelControl8.Text = "Sucursal"
        '
        'LabelControl7
        '
        Me.LabelControl7.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl7.Location = New System.Drawing.Point(10, 71)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(65, 16)
        Me.LabelControl7.TabIndex = 6
        Me.LabelControl7.Text = "Contraseña"
        '
        'txtClave
        '
        Me.txtClave.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtClave.Location = New System.Drawing.Point(98, 68)
        Me.txtClave.Name = "txtClave"
        Me.txtClave.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtClave.Properties.Appearance.Options.UseFont = True
        Me.txtClave.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtClave.Size = New System.Drawing.Size(364, 22)
        Me.txtClave.TabIndex = 5
        '
        'gcUsuarios
        '
        Me.gcUsuarios.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gcUsuarios.Location = New System.Drawing.Point(10, 131)
        Me.gcUsuarios.MainView = Me.gvUsuarios
        Me.gcUsuarios.Name = "gcUsuarios"
        Me.gcUsuarios.Size = New System.Drawing.Size(452, 189)
        Me.gcUsuarios.TabIndex = 4
        Me.gcUsuarios.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvUsuarios})
        '
        'gvUsuarios
        '
        Me.gvUsuarios.Appearance.Row.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.gvUsuarios.Appearance.Row.Options.UseFont = True
        Me.gvUsuarios.Appearance.ViewCaption.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gvUsuarios.Appearance.ViewCaption.Options.UseFont = True
        Me.gvUsuarios.GridControl = Me.gcUsuarios
        Me.gvUsuarios.Name = "gvUsuarios"
        Me.gvUsuarios.OptionsBehavior.Editable = False
        Me.gvUsuarios.OptionsView.ShowAutoFilterRow = True
        Me.gvUsuarios.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.gvUsuarios.OptionsView.ShowGroupPanel = False
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Location = New System.Drawing.Point(10, 43)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(43, 16)
        Me.LabelControl2.TabIndex = 3
        Me.LabelControl2.Text = "Usuario"
        '
        'txtUsuario
        '
        Me.txtUsuario.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtUsuario.Location = New System.Drawing.Point(98, 40)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsuario.Properties.Appearance.Options.UseFont = True
        Me.txtUsuario.Size = New System.Drawing.Size(364, 22)
        Me.txtUsuario.TabIndex = 2
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Location = New System.Drawing.Point(10, 15)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(39, 16)
        Me.LabelControl1.TabIndex = 1
        Me.LabelControl1.Text = "Código"
        '
        'TxtIdIUsuario
        '
        Me.TxtIdIUsuario.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtIdIUsuario.Location = New System.Drawing.Point(98, 12)
        Me.TxtIdIUsuario.Name = "TxtIdIUsuario"
        Me.TxtIdIUsuario.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtIdIUsuario.Properties.Appearance.Options.UseFont = True
        Me.TxtIdIUsuario.Size = New System.Drawing.Size(184, 22)
        Me.TxtIdIUsuario.TabIndex = 0
        '
        'xtpMarcas
        '
        Me.xtpMarcas.Controls.Add(Me.ChkMarcaActiva)
        Me.xtpMarcas.Controls.Add(Me.gcMarcas)
        Me.xtpMarcas.Controls.Add(Me.LabelControl3)
        Me.xtpMarcas.Controls.Add(Me.txtMarca)
        Me.xtpMarcas.Controls.Add(Me.LabelControl4)
        Me.xtpMarcas.Controls.Add(Me.txtIdMarca)
        Me.xtpMarcas.Name = "xtpMarcas"
        Me.xtpMarcas.Size = New System.Drawing.Size(466, 324)
        Me.xtpMarcas.Text = "Marcas"
        '
        'ChkMarcaActiva
        '
        Me.ChkMarcaActiva.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkMarcaActiva.Location = New System.Drawing.Point(384, 12)
        Me.ChkMarcaActiva.Name = "ChkMarcaActiva"
        Me.ChkMarcaActiva.Properties.Appearance.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkMarcaActiva.Properties.Appearance.Options.UseFont = True
        Me.ChkMarcaActiva.Properties.Caption = "Activo"
        Me.ChkMarcaActiva.Size = New System.Drawing.Size(60, 19)
        Me.ChkMarcaActiva.TabIndex = 10
        '
        'gcMarcas
        '
        Me.gcMarcas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gcMarcas.Location = New System.Drawing.Point(9, 68)
        Me.gcMarcas.MainView = Me.gvMarcas
        Me.gcMarcas.Name = "gcMarcas"
        Me.gcMarcas.Size = New System.Drawing.Size(432, 253)
        Me.gcMarcas.TabIndex = 9
        Me.gcMarcas.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvMarcas})
        '
        'gvMarcas
        '
        Me.gvMarcas.GridControl = Me.gcMarcas
        Me.gvMarcas.Name = "gvMarcas"
        Me.gvMarcas.OptionsBehavior.Editable = False
        Me.gvMarcas.OptionsView.ShowAutoFilterRow = True
        Me.gvMarcas.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.gvMarcas.OptionsView.ShowGroupPanel = False
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Location = New System.Drawing.Point(9, 43)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(35, 16)
        Me.LabelControl3.TabIndex = 8
        Me.LabelControl3.Text = "Marca"
        '
        'txtMarca
        '
        Me.txtMarca.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtMarca.Location = New System.Drawing.Point(98, 40)
        Me.txtMarca.Name = "txtMarca"
        Me.txtMarca.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMarca.Properties.Appearance.Options.UseFont = True
        Me.txtMarca.Size = New System.Drawing.Size(344, 22)
        Me.txtMarca.TabIndex = 7
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Location = New System.Drawing.Point(9, 15)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(39, 16)
        Me.LabelControl4.TabIndex = 6
        Me.LabelControl4.Text = "Código"
        '
        'txtIdMarca
        '
        Me.txtIdMarca.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtIdMarca.Location = New System.Drawing.Point(98, 12)
        Me.txtIdMarca.Name = "txtIdMarca"
        Me.txtIdMarca.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdMarca.Properties.Appearance.Options.UseFont = True
        Me.txtIdMarca.Size = New System.Drawing.Size(276, 22)
        Me.txtIdMarca.TabIndex = 5
        '
        'xtpCategorias
        '
        Me.xtpCategorias.Controls.Add(Me.LabelControl11)
        Me.xtpCategorias.Controls.Add(Me.LabelControl10)
        Me.xtpCategorias.Controls.Add(Me.txtPUtilidad2)
        Me.xtpCategorias.Controls.Add(Me.txtPUtilidad3)
        Me.xtpCategorias.Controls.Add(Me.txtComision)
        Me.xtpCategorias.Controls.Add(Me.LabelControl9)
        Me.xtpCategorias.Controls.Add(Me.txtPUtilidad1)
        Me.xtpCategorias.Controls.Add(Me.ChkCategoriaActiva)
        Me.xtpCategorias.Controls.Add(Me.gcCategorias)
        Me.xtpCategorias.Controls.Add(Me.LabelControl5)
        Me.xtpCategorias.Controls.Add(Me.txtCategoria)
        Me.xtpCategorias.Controls.Add(Me.LabelControl6)
        Me.xtpCategorias.Controls.Add(Me.TxtIdCategoria)
        Me.xtpCategorias.Name = "xtpCategorias"
        Me.xtpCategorias.Size = New System.Drawing.Size(466, 324)
        Me.xtpCategorias.Text = "Categorías de Productos"
        '
        'LabelControl11
        '
        Me.LabelControl11.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl11.Location = New System.Drawing.Point(98, 71)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(42, 16)
        Me.LabelControl11.TabIndex = 22
        Me.LabelControl11.Text = "Utilidad"
        '
        'LabelControl10
        '
        Me.LabelControl10.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl10.Location = New System.Drawing.Point(332, 71)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(52, 16)
        Me.LabelControl10.TabIndex = 21
        Me.LabelControl10.Text = "Comisión"
        '
        'txtPUtilidad2
        '
        Me.txtPUtilidad2.Location = New System.Drawing.Point(209, 68)
        Me.txtPUtilidad2.Name = "txtPUtilidad2"
        Me.txtPUtilidad2.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPUtilidad2.Properties.Appearance.Options.UseFont = True
        Me.txtPUtilidad2.Size = New System.Drawing.Size(52, 22)
        Me.txtPUtilidad2.TabIndex = 20
        '
        'txtPUtilidad3
        '
        Me.txtPUtilidad3.Location = New System.Drawing.Point(267, 68)
        Me.txtPUtilidad3.Name = "txtPUtilidad3"
        Me.txtPUtilidad3.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPUtilidad3.Properties.Appearance.Options.UseFont = True
        Me.txtPUtilidad3.Size = New System.Drawing.Size(52, 22)
        Me.txtPUtilidad3.TabIndex = 19
        '
        'txtComision
        '
        Me.txtComision.Location = New System.Drawing.Point(390, 68)
        Me.txtComision.Name = "txtComision"
        Me.txtComision.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtComision.Properties.Appearance.Options.UseFont = True
        Me.txtComision.Size = New System.Drawing.Size(52, 22)
        Me.txtComision.TabIndex = 18
        '
        'LabelControl9
        '
        Me.LabelControl9.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl9.Location = New System.Drawing.Point(10, 71)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(67, 16)
        Me.LabelControl9.TabIndex = 17
        Me.LabelControl9.Text = "Porcentajes"
        '
        'txtPUtilidad1
        '
        Me.txtPUtilidad1.Location = New System.Drawing.Point(151, 68)
        Me.txtPUtilidad1.Name = "txtPUtilidad1"
        Me.txtPUtilidad1.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPUtilidad1.Properties.Appearance.Options.UseFont = True
        Me.txtPUtilidad1.Size = New System.Drawing.Size(52, 22)
        Me.txtPUtilidad1.TabIndex = 16
        '
        'ChkCategoriaActiva
        '
        Me.ChkCategoriaActiva.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkCategoriaActiva.Location = New System.Drawing.Point(384, 13)
        Me.ChkCategoriaActiva.Name = "ChkCategoriaActiva"
        Me.ChkCategoriaActiva.Properties.Appearance.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkCategoriaActiva.Properties.Appearance.Options.UseFont = True
        Me.ChkCategoriaActiva.Properties.Caption = "Activo"
        Me.ChkCategoriaActiva.Size = New System.Drawing.Size(60, 19)
        Me.ChkCategoriaActiva.TabIndex = 15
        '
        'gcCategorias
        '
        Me.gcCategorias.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gcCategorias.Location = New System.Drawing.Point(10, 96)
        Me.gcCategorias.MainView = Me.gvCategorias
        Me.gcCategorias.Name = "gcCategorias"
        Me.gcCategorias.Size = New System.Drawing.Size(432, 225)
        Me.gcCategorias.TabIndex = 14
        Me.gcCategorias.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvCategorias})
        '
        'gvCategorias
        '
        Me.gvCategorias.GridControl = Me.gcCategorias
        Me.gvCategorias.Name = "gvCategorias"
        Me.gvCategorias.OptionsBehavior.Editable = False
        Me.gvCategorias.OptionsView.ShowAutoFilterRow = True
        Me.gvCategorias.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.gvCategorias.OptionsView.ShowGroupPanel = False
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl5.Location = New System.Drawing.Point(10, 43)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(55, 16)
        Me.LabelControl5.TabIndex = 13
        Me.LabelControl5.Text = "Categoría"
        '
        'txtCategoria
        '
        Me.txtCategoria.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCategoria.Location = New System.Drawing.Point(98, 40)
        Me.txtCategoria.Name = "txtCategoria"
        Me.txtCategoria.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCategoria.Properties.Appearance.Options.UseFont = True
        Me.txtCategoria.Size = New System.Drawing.Size(344, 22)
        Me.txtCategoria.TabIndex = 12
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl6.Location = New System.Drawing.Point(10, 15)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(39, 16)
        Me.LabelControl6.TabIndex = 11
        Me.LabelControl6.Text = "Código"
        '
        'TxtIdCategoria
        '
        Me.TxtIdCategoria.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtIdCategoria.Location = New System.Drawing.Point(98, 12)
        Me.TxtIdCategoria.Name = "TxtIdCategoria"
        Me.TxtIdCategoria.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtIdCategoria.Properties.Appearance.Options.UseFont = True
        Me.TxtIdCategoria.Size = New System.Drawing.Size(276, 22)
        Me.TxtIdCategoria.TabIndex = 10
        '
        'XTPTipoAjuste
        '
        Me.XTPTipoAjuste.Controls.Add(Me.RDGValorAjuste)
        Me.XTPTipoAjuste.Controls.Add(Me.LabelControl14)
        Me.XTPTipoAjuste.Controls.Add(Me.gcTipoAjuste)
        Me.XTPTipoAjuste.Controls.Add(Me.LabelControl12)
        Me.XTPTipoAjuste.Controls.Add(Me.txtTipoAjuste)
        Me.XTPTipoAjuste.Controls.Add(Me.LabelControl13)
        Me.XTPTipoAjuste.Controls.Add(Me.txtIdTipoAjuste)
        Me.XTPTipoAjuste.Name = "XTPTipoAjuste"
        Me.XTPTipoAjuste.Size = New System.Drawing.Size(466, 324)
        Me.XTPTipoAjuste.Text = "Tipo de Ajuste"
        '
        'RDGValorAjuste
        '
        Me.RDGValorAjuste.Location = New System.Drawing.Point(140, 69)
        Me.RDGValorAjuste.Name = "RDGValorAjuste"
        Me.RDGValorAjuste.Properties.Appearance.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RDGValorAjuste.Properties.Appearance.Options.UseFont = True
        Me.RDGValorAjuste.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.RDGValorAjuste.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(Nothing, "Aumento"), New DevExpress.XtraEditors.Controls.RadioGroupItem(Nothing, "Disminución")})
        Me.RDGValorAjuste.Size = New System.Drawing.Size(226, 20)
        Me.RDGValorAjuste.TabIndex = 17
        '
        'LabelControl14
        '
        Me.LabelControl14.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl14.Location = New System.Drawing.Point(9, 71)
        Me.LabelControl14.Name = "LabelControl14"
        Me.LabelControl14.Size = New System.Drawing.Size(99, 16)
        Me.LabelControl14.TabIndex = 16
        Me.LabelControl14.Text = "Valor por defecto"
        '
        'gcTipoAjuste
        '
        Me.gcTipoAjuste.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gcTipoAjuste.Location = New System.Drawing.Point(9, 95)
        Me.gcTipoAjuste.MainView = Me.gvTipoAjuste
        Me.gcTipoAjuste.Name = "gcTipoAjuste"
        Me.gcTipoAjuste.Size = New System.Drawing.Size(417, 226)
        Me.gcTipoAjuste.TabIndex = 15
        Me.gcTipoAjuste.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvTipoAjuste})
        '
        'gvTipoAjuste
        '
        Me.gvTipoAjuste.GridControl = Me.gcTipoAjuste
        Me.gvTipoAjuste.Name = "gvTipoAjuste"
        Me.gvTipoAjuste.OptionsBehavior.Editable = False
        Me.gvTipoAjuste.OptionsView.ShowAutoFilterRow = True
        Me.gvTipoAjuste.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.gvTipoAjuste.OptionsView.ShowGroupPanel = False
        '
        'LabelControl12
        '
        Me.LabelControl12.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl12.Location = New System.Drawing.Point(9, 44)
        Me.LabelControl12.Name = "LabelControl12"
        Me.LabelControl12.Size = New System.Drawing.Size(65, 16)
        Me.LabelControl12.TabIndex = 14
        Me.LabelControl12.Text = "Tipo Ajuste"
        '
        'txtTipoAjuste
        '
        Me.txtTipoAjuste.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTipoAjuste.Location = New System.Drawing.Point(97, 41)
        Me.txtTipoAjuste.Name = "txtTipoAjuste"
        Me.txtTipoAjuste.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTipoAjuste.Properties.Appearance.Options.UseFont = True
        Me.txtTipoAjuste.Size = New System.Drawing.Size(329, 22)
        Me.txtTipoAjuste.TabIndex = 13
        '
        'LabelControl13
        '
        Me.LabelControl13.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl13.Location = New System.Drawing.Point(9, 16)
        Me.LabelControl13.Name = "LabelControl13"
        Me.LabelControl13.Size = New System.Drawing.Size(39, 16)
        Me.LabelControl13.TabIndex = 12
        Me.LabelControl13.Text = "Código"
        '
        'txtIdTipoAjuste
        '
        Me.txtIdTipoAjuste.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtIdTipoAjuste.Location = New System.Drawing.Point(97, 13)
        Me.txtIdTipoAjuste.Name = "txtIdTipoAjuste"
        Me.txtIdTipoAjuste.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdTipoAjuste.Properties.Appearance.Options.UseFont = True
        Me.txtIdTipoAjuste.Size = New System.Drawing.Size(329, 22)
        Me.txtIdTipoAjuste.TabIndex = 11
        '
        'XtcSucursal
        '
        Me.XtcSucursal.Controls.Add(Me.GCNumeraciones)
        Me.XtcSucursal.Controls.Add(Me.txtDirSucursal)
        Me.XtcSucursal.Controls.Add(Me.ChkSucursalActiva)
        Me.XtcSucursal.Controls.Add(Me.LabelControl15)
        Me.XtcSucursal.Controls.Add(Me.GCSucursal)
        Me.XtcSucursal.Controls.Add(Me.LabelControl16)
        Me.XtcSucursal.Controls.Add(Me.txtSucursal)
        Me.XtcSucursal.Controls.Add(Me.LabelControl17)
        Me.XtcSucursal.Controls.Add(Me.txtIdSucursal)
        Me.XtcSucursal.Name = "XtcSucursal"
        Me.XtcSucursal.Size = New System.Drawing.Size(466, 324)
        Me.XtcSucursal.Text = "Sucursales"
        '
        'GCNumeraciones
        '
        Me.GCNumeraciones.Controls.Add(Me.LabelControl21)
        Me.GCNumeraciones.Controls.Add(Me.SpeNumAjuste)
        Me.GCNumeraciones.Controls.Add(Me.LabelControl20)
        Me.GCNumeraciones.Controls.Add(Me.SpeNumFactura)
        Me.GCNumeraciones.Controls.Add(Me.LabelControl19)
        Me.GCNumeraciones.Controls.Add(Me.SpeNumRemision)
        Me.GCNumeraciones.Controls.Add(Me.LabelControl18)
        Me.GCNumeraciones.Controls.Add(Me.SpeNumCompra)
        Me.GCNumeraciones.Location = New System.Drawing.Point(9, 96)
        Me.GCNumeraciones.Name = "GCNumeraciones"
        Me.GCNumeraciones.Size = New System.Drawing.Size(432, 46)
        Me.GCNumeraciones.TabIndex = 28
        Me.GCNumeraciones.Text = "Numeración de Documentos"
        '
        'LabelControl21
        '
        Me.LabelControl21.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl21.Location = New System.Drawing.Point(323, 22)
        Me.LabelControl21.Name = "LabelControl21"
        Me.LabelControl21.Size = New System.Drawing.Size(36, 16)
        Me.LabelControl21.TabIndex = 34
        Me.LabelControl21.Text = "Ajuste"
        '
        'SpeNumAjuste
        '
        Me.SpeNumAjuste.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.SpeNumAjuste.Location = New System.Drawing.Point(372, 21)
        Me.SpeNumAjuste.Name = "SpeNumAjuste"
        Me.SpeNumAjuste.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SpeNumAjuste.Size = New System.Drawing.Size(53, 20)
        Me.SpeNumAjuste.TabIndex = 33
        '
        'LabelControl20
        '
        Me.LabelControl20.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl20.Location = New System.Drawing.Point(224, 22)
        Me.LabelControl20.Name = "LabelControl20"
        Me.LabelControl20.Size = New System.Drawing.Size(43, 16)
        Me.LabelControl20.TabIndex = 32
        Me.LabelControl20.Text = "Factura"
        '
        'SpeNumFactura
        '
        Me.SpeNumFactura.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.SpeNumFactura.Location = New System.Drawing.Point(269, 21)
        Me.SpeNumFactura.Name = "SpeNumFactura"
        Me.SpeNumFactura.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SpeNumFactura.Size = New System.Drawing.Size(53, 20)
        Me.SpeNumFactura.TabIndex = 31
        '
        'LabelControl19
        '
        Me.LabelControl19.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl19.Location = New System.Drawing.Point(111, 22)
        Me.LabelControl19.Name = "LabelControl19"
        Me.LabelControl19.Size = New System.Drawing.Size(52, 16)
        Me.LabelControl19.TabIndex = 30
        Me.LabelControl19.Text = "Remisión"
        '
        'SpeNumRemision
        '
        Me.SpeNumRemision.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.SpeNumRemision.Location = New System.Drawing.Point(166, 21)
        Me.SpeNumRemision.Name = "SpeNumRemision"
        Me.SpeNumRemision.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SpeNumRemision.Size = New System.Drawing.Size(53, 20)
        Me.SpeNumRemision.TabIndex = 29
        '
        'LabelControl18
        '
        Me.LabelControl18.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl18.Location = New System.Drawing.Point(6, 22)
        Me.LabelControl18.Name = "LabelControl18"
        Me.LabelControl18.Size = New System.Drawing.Size(45, 16)
        Me.LabelControl18.TabIndex = 28
        Me.LabelControl18.Text = "Compra"
        '
        'SpeNumCompra
        '
        Me.SpeNumCompra.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.SpeNumCompra.Location = New System.Drawing.Point(55, 21)
        Me.SpeNumCompra.Name = "SpeNumCompra"
        Me.SpeNumCompra.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SpeNumCompra.Size = New System.Drawing.Size(53, 20)
        Me.SpeNumCompra.TabIndex = 27
        '
        'txtDirSucursal
        '
        Me.txtDirSucursal.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDirSucursal.Location = New System.Drawing.Point(97, 69)
        Me.txtDirSucursal.Name = "txtDirSucursal"
        Me.txtDirSucursal.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDirSucursal.Properties.Appearance.Options.UseFont = True
        Me.txtDirSucursal.Size = New System.Drawing.Size(329, 22)
        Me.txtDirSucursal.TabIndex = 26
        '
        'ChkSucursalActiva
        '
        Me.ChkSucursalActiva.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkSucursalActiva.Location = New System.Drawing.Point(366, 14)
        Me.ChkSucursalActiva.Name = "ChkSucursalActiva"
        Me.ChkSucursalActiva.Properties.Appearance.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkSucursalActiva.Properties.Appearance.Options.UseFont = True
        Me.ChkSucursalActiva.Properties.Caption = "Activa"
        Me.ChkSucursalActiva.Size = New System.Drawing.Size(60, 19)
        Me.ChkSucursalActiva.TabIndex = 25
        '
        'LabelControl15
        '
        Me.LabelControl15.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl15.Location = New System.Drawing.Point(9, 71)
        Me.LabelControl15.Name = "LabelControl15"
        Me.LabelControl15.Size = New System.Drawing.Size(52, 16)
        Me.LabelControl15.TabIndex = 23
        Me.LabelControl15.Text = "Dirección"
        '
        'GCSucursal
        '
        Me.GCSucursal.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GCSucursal.Location = New System.Drawing.Point(9, 142)
        Me.GCSucursal.MainView = Me.GvSucursal
        Me.GCSucursal.Name = "GCSucursal"
        Me.GCSucursal.Size = New System.Drawing.Size(417, 179)
        Me.GCSucursal.TabIndex = 22
        Me.GCSucursal.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GvSucursal})
        '
        'GvSucursal
        '
        Me.GvSucursal.GridControl = Me.GCSucursal
        Me.GvSucursal.Name = "GvSucursal"
        Me.GvSucursal.OptionsBehavior.Editable = False
        Me.GvSucursal.OptionsView.ShowAutoFilterRow = True
        Me.GvSucursal.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.GvSucursal.OptionsView.ShowGroupPanel = False
        '
        'LabelControl16
        '
        Me.LabelControl16.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl16.Location = New System.Drawing.Point(9, 44)
        Me.LabelControl16.Name = "LabelControl16"
        Me.LabelControl16.Size = New System.Drawing.Size(49, 16)
        Me.LabelControl16.TabIndex = 21
        Me.LabelControl16.Text = "Sucursal"
        '
        'txtSucursal
        '
        Me.txtSucursal.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSucursal.Location = New System.Drawing.Point(97, 41)
        Me.txtSucursal.Name = "txtSucursal"
        Me.txtSucursal.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSucursal.Properties.Appearance.Options.UseFont = True
        Me.txtSucursal.Size = New System.Drawing.Size(329, 22)
        Me.txtSucursal.TabIndex = 20
        '
        'LabelControl17
        '
        Me.LabelControl17.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl17.Location = New System.Drawing.Point(9, 16)
        Me.LabelControl17.Name = "LabelControl17"
        Me.LabelControl17.Size = New System.Drawing.Size(39, 16)
        Me.LabelControl17.TabIndex = 19
        Me.LabelControl17.Text = "Código"
        '
        'txtIdSucursal
        '
        Me.txtIdSucursal.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtIdSucursal.Location = New System.Drawing.Point(97, 13)
        Me.txtIdSucursal.Name = "txtIdSucursal"
        Me.txtIdSucursal.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdSucursal.Properties.Appearance.Options.UseFont = True
        Me.txtIdSucursal.Size = New System.Drawing.Size(254, 22)
        Me.txtIdSucursal.TabIndex = 18
        '
        'XTPProveedor
        '
        Me.XTPProveedor.Controls.Add(Me.txtCorreoProveedor)
        Me.XTPProveedor.Controls.Add(Me.LabelControl24)
        Me.XTPProveedor.Controls.Add(Me.txtRUCProveedor)
        Me.XTPProveedor.Controls.Add(Me.LabelControl23)
        Me.XTPProveedor.Controls.Add(Me.txtTelProveedor)
        Me.XTPProveedor.Controls.Add(Me.LabelControl22)
        Me.XTPProveedor.Controls.Add(Me.txtDirProveedor)
        Me.XTPProveedor.Controls.Add(Me.ChkProveedorActivo)
        Me.XTPProveedor.Controls.Add(Me.LabelControl26)
        Me.XTPProveedor.Controls.Add(Me.GCProveedores)
        Me.XTPProveedor.Controls.Add(Me.LabelControl27)
        Me.XTPProveedor.Controls.Add(Me.txtProveedor)
        Me.XTPProveedor.Controls.Add(Me.LabelControl28)
        Me.XTPProveedor.Controls.Add(Me.txtIdProveedor)
        Me.XTPProveedor.Name = "XTPProveedor"
        Me.XTPProveedor.Size = New System.Drawing.Size(466, 324)
        Me.XTPProveedor.Text = "Proveedores"
        '
        'txtCorreoProveedor
        '
        Me.txtCorreoProveedor.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCorreoProveedor.Location = New System.Drawing.Point(97, 152)
        Me.txtCorreoProveedor.Name = "txtCorreoProveedor"
        Me.txtCorreoProveedor.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCorreoProveedor.Properties.Appearance.Options.UseFont = True
        Me.txtCorreoProveedor.Size = New System.Drawing.Size(329, 22)
        Me.txtCorreoProveedor.TabIndex = 42
        '
        'LabelControl24
        '
        Me.LabelControl24.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl24.Location = New System.Drawing.Point(9, 155)
        Me.LabelControl24.Name = "LabelControl24"
        Me.LabelControl24.Size = New System.Drawing.Size(39, 16)
        Me.LabelControl24.TabIndex = 41
        Me.LabelControl24.Text = "Correo"
        '
        'txtRUCProveedor
        '
        Me.txtRUCProveedor.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtRUCProveedor.Location = New System.Drawing.Point(97, 68)
        Me.txtRUCProveedor.Name = "txtRUCProveedor"
        Me.txtRUCProveedor.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRUCProveedor.Properties.Appearance.Options.UseFont = True
        Me.txtRUCProveedor.Size = New System.Drawing.Size(329, 22)
        Me.txtRUCProveedor.TabIndex = 40
        '
        'LabelControl23
        '
        Me.LabelControl23.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl23.Location = New System.Drawing.Point(9, 71)
        Me.LabelControl23.Name = "LabelControl23"
        Me.LabelControl23.Size = New System.Drawing.Size(24, 16)
        Me.LabelControl23.TabIndex = 39
        Me.LabelControl23.Text = "RUC"
        '
        'txtTelProveedor
        '
        Me.txtTelProveedor.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTelProveedor.Location = New System.Drawing.Point(97, 124)
        Me.txtTelProveedor.Name = "txtTelProveedor"
        Me.txtTelProveedor.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelProveedor.Properties.Appearance.Options.UseFont = True
        Me.txtTelProveedor.Size = New System.Drawing.Size(329, 22)
        Me.txtTelProveedor.TabIndex = 38
        '
        'LabelControl22
        '
        Me.LabelControl22.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl22.Location = New System.Drawing.Point(9, 127)
        Me.LabelControl22.Name = "LabelControl22"
        Me.LabelControl22.Size = New System.Drawing.Size(50, 16)
        Me.LabelControl22.TabIndex = 37
        Me.LabelControl22.Text = "Teléfono"
        '
        'txtDirProveedor
        '
        Me.txtDirProveedor.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDirProveedor.Location = New System.Drawing.Point(97, 96)
        Me.txtDirProveedor.Name = "txtDirProveedor"
        Me.txtDirProveedor.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDirProveedor.Properties.Appearance.Options.UseFont = True
        Me.txtDirProveedor.Size = New System.Drawing.Size(329, 22)
        Me.txtDirProveedor.TabIndex = 36
        '
        'ChkProveedorActivo
        '
        Me.ChkProveedorActivo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkProveedorActivo.Location = New System.Drawing.Point(366, 13)
        Me.ChkProveedorActivo.Name = "ChkProveedorActivo"
        Me.ChkProveedorActivo.Properties.Appearance.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkProveedorActivo.Properties.Appearance.Options.UseFont = True
        Me.ChkProveedorActivo.Properties.Caption = "Activo"
        Me.ChkProveedorActivo.Size = New System.Drawing.Size(60, 19)
        Me.ChkProveedorActivo.TabIndex = 35
        '
        'LabelControl26
        '
        Me.LabelControl26.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl26.Location = New System.Drawing.Point(9, 99)
        Me.LabelControl26.Name = "LabelControl26"
        Me.LabelControl26.Size = New System.Drawing.Size(52, 16)
        Me.LabelControl26.TabIndex = 34
        Me.LabelControl26.Text = "Dirección"
        '
        'GCProveedores
        '
        Me.GCProveedores.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GCProveedores.Location = New System.Drawing.Point(9, 180)
        Me.GCProveedores.MainView = Me.GVProveedores
        Me.GCProveedores.Name = "GCProveedores"
        Me.GCProveedores.Size = New System.Drawing.Size(417, 140)
        Me.GCProveedores.TabIndex = 33
        Me.GCProveedores.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVProveedores})
        '
        'GVProveedores
        '
        Me.GVProveedores.GridControl = Me.GCProveedores
        Me.GVProveedores.Name = "GVProveedores"
        Me.GVProveedores.OptionsBehavior.Editable = False
        Me.GVProveedores.OptionsView.ShowAutoFilterRow = True
        Me.GVProveedores.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.GVProveedores.OptionsView.ShowGroupPanel = False
        '
        'LabelControl27
        '
        Me.LabelControl27.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl27.Location = New System.Drawing.Point(9, 43)
        Me.LabelControl27.Name = "LabelControl27"
        Me.LabelControl27.Size = New System.Drawing.Size(58, 16)
        Me.LabelControl27.TabIndex = 32
        Me.LabelControl27.Text = "Proveedor"
        '
        'txtProveedor
        '
        Me.txtProveedor.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtProveedor.Location = New System.Drawing.Point(97, 40)
        Me.txtProveedor.Name = "txtProveedor"
        Me.txtProveedor.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProveedor.Properties.Appearance.Options.UseFont = True
        Me.txtProveedor.Size = New System.Drawing.Size(329, 22)
        Me.txtProveedor.TabIndex = 31
        '
        'LabelControl28
        '
        Me.LabelControl28.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl28.Location = New System.Drawing.Point(9, 15)
        Me.LabelControl28.Name = "LabelControl28"
        Me.LabelControl28.Size = New System.Drawing.Size(39, 16)
        Me.LabelControl28.TabIndex = 30
        Me.LabelControl28.Text = "Código"
        '
        'txtIdProveedor
        '
        Me.txtIdProveedor.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtIdProveedor.Location = New System.Drawing.Point(97, 12)
        Me.txtIdProveedor.Name = "txtIdProveedor"
        Me.txtIdProveedor.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdProveedor.Properties.Appearance.Options.UseFont = True
        Me.txtIdProveedor.Size = New System.Drawing.Size(254, 22)
        Me.txtIdProveedor.TabIndex = 29
        '
        'XTPVendedores
        '
        Me.XTPVendedores.Controls.Add(Me.txtCorreoVendedor)
        Me.XTPVendedores.Controls.Add(Me.LabelControl25)
        Me.XTPVendedores.Controls.Add(Me.txtApellidosVendedor)
        Me.XTPVendedores.Controls.Add(Me.LabelControl29)
        Me.XTPVendedores.Controls.Add(Me.txtTelVendedor)
        Me.XTPVendedores.Controls.Add(Me.LabelControl30)
        Me.XTPVendedores.Controls.Add(Me.txtDirVendedor)
        Me.XTPVendedores.Controls.Add(Me.ChkVendedorActivo)
        Me.XTPVendedores.Controls.Add(Me.LabelControl31)
        Me.XTPVendedores.Controls.Add(Me.GCVendedores)
        Me.XTPVendedores.Controls.Add(Me.LabelControl32)
        Me.XTPVendedores.Controls.Add(Me.txtNombresVendedor)
        Me.XTPVendedores.Controls.Add(Me.LabelControl33)
        Me.XTPVendedores.Controls.Add(Me.txtIdVendedor)
        Me.XTPVendedores.Name = "XTPVendedores"
        Me.XTPVendedores.Size = New System.Drawing.Size(466, 324)
        Me.XTPVendedores.Text = "Vendedores"
        '
        'txtCorreoVendedor
        '
        Me.txtCorreoVendedor.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCorreoVendedor.Location = New System.Drawing.Point(97, 152)
        Me.txtCorreoVendedor.Name = "txtCorreoVendedor"
        Me.txtCorreoVendedor.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCorreoVendedor.Properties.Appearance.Options.UseFont = True
        Me.txtCorreoVendedor.Size = New System.Drawing.Size(329, 22)
        Me.txtCorreoVendedor.TabIndex = 56
        '
        'LabelControl25
        '
        Me.LabelControl25.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl25.Location = New System.Drawing.Point(9, 155)
        Me.LabelControl25.Name = "LabelControl25"
        Me.LabelControl25.Size = New System.Drawing.Size(39, 16)
        Me.LabelControl25.TabIndex = 55
        Me.LabelControl25.Text = "Correo"
        '
        'txtApellidosVendedor
        '
        Me.txtApellidosVendedor.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtApellidosVendedor.Location = New System.Drawing.Point(97, 68)
        Me.txtApellidosVendedor.Name = "txtApellidosVendedor"
        Me.txtApellidosVendedor.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtApellidosVendedor.Properties.Appearance.Options.UseFont = True
        Me.txtApellidosVendedor.Size = New System.Drawing.Size(329, 22)
        Me.txtApellidosVendedor.TabIndex = 54
        '
        'LabelControl29
        '
        Me.LabelControl29.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl29.Location = New System.Drawing.Point(9, 72)
        Me.LabelControl29.Name = "LabelControl29"
        Me.LabelControl29.Size = New System.Drawing.Size(51, 16)
        Me.LabelControl29.TabIndex = 53
        Me.LabelControl29.Text = "Apellidos"
        '
        'txtTelVendedor
        '
        Me.txtTelVendedor.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTelVendedor.Location = New System.Drawing.Point(97, 124)
        Me.txtTelVendedor.Name = "txtTelVendedor"
        Me.txtTelVendedor.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelVendedor.Properties.Appearance.Options.UseFont = True
        Me.txtTelVendedor.Size = New System.Drawing.Size(329, 22)
        Me.txtTelVendedor.TabIndex = 52
        '
        'LabelControl30
        '
        Me.LabelControl30.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl30.Location = New System.Drawing.Point(9, 127)
        Me.LabelControl30.Name = "LabelControl30"
        Me.LabelControl30.Size = New System.Drawing.Size(50, 16)
        Me.LabelControl30.TabIndex = 51
        Me.LabelControl30.Text = "Teléfono"
        '
        'txtDirVendedor
        '
        Me.txtDirVendedor.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDirVendedor.Location = New System.Drawing.Point(97, 96)
        Me.txtDirVendedor.Name = "txtDirVendedor"
        Me.txtDirVendedor.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDirVendedor.Properties.Appearance.Options.UseFont = True
        Me.txtDirVendedor.Size = New System.Drawing.Size(329, 22)
        Me.txtDirVendedor.TabIndex = 50
        '
        'ChkVendedorActivo
        '
        Me.ChkVendedorActivo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkVendedorActivo.Location = New System.Drawing.Point(366, 13)
        Me.ChkVendedorActivo.Name = "ChkVendedorActivo"
        Me.ChkVendedorActivo.Properties.Appearance.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkVendedorActivo.Properties.Appearance.Options.UseFont = True
        Me.ChkVendedorActivo.Properties.Caption = "Activo"
        Me.ChkVendedorActivo.Size = New System.Drawing.Size(60, 19)
        Me.ChkVendedorActivo.TabIndex = 49
        '
        'LabelControl31
        '
        Me.LabelControl31.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl31.Location = New System.Drawing.Point(9, 99)
        Me.LabelControl31.Name = "LabelControl31"
        Me.LabelControl31.Size = New System.Drawing.Size(52, 16)
        Me.LabelControl31.TabIndex = 48
        Me.LabelControl31.Text = "Dirección"
        '
        'GCVendedores
        '
        Me.GCVendedores.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GCVendedores.Location = New System.Drawing.Point(9, 180)
        Me.GCVendedores.MainView = Me.GVVendedores
        Me.GCVendedores.Name = "GCVendedores"
        Me.GCVendedores.Size = New System.Drawing.Size(417, 140)
        Me.GCVendedores.TabIndex = 47
        Me.GCVendedores.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVVendedores})
        '
        'GVVendedores
        '
        Me.GVVendedores.GridControl = Me.GCVendedores
        Me.GVVendedores.Name = "GVVendedores"
        Me.GVVendedores.OptionsBehavior.Editable = False
        Me.GVVendedores.OptionsView.ShowAutoFilterRow = True
        Me.GVVendedores.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.GVVendedores.OptionsView.ShowGroupPanel = False
        '
        'LabelControl32
        '
        Me.LabelControl32.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl32.Location = New System.Drawing.Point(9, 43)
        Me.LabelControl32.Name = "LabelControl32"
        Me.LabelControl32.Size = New System.Drawing.Size(51, 16)
        Me.LabelControl32.TabIndex = 46
        Me.LabelControl32.Text = "Nombres"
        '
        'txtNombresVendedor
        '
        Me.txtNombresVendedor.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNombresVendedor.Location = New System.Drawing.Point(97, 40)
        Me.txtNombresVendedor.Name = "txtNombresVendedor"
        Me.txtNombresVendedor.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombresVendedor.Properties.Appearance.Options.UseFont = True
        Me.txtNombresVendedor.Size = New System.Drawing.Size(329, 22)
        Me.txtNombresVendedor.TabIndex = 45
        '
        'LabelControl33
        '
        Me.LabelControl33.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl33.Location = New System.Drawing.Point(9, 15)
        Me.LabelControl33.Name = "LabelControl33"
        Me.LabelControl33.Size = New System.Drawing.Size(39, 16)
        Me.LabelControl33.TabIndex = 44
        Me.LabelControl33.Text = "Código"
        '
        'txtIdVendedor
        '
        Me.txtIdVendedor.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtIdVendedor.Location = New System.Drawing.Point(97, 12)
        Me.txtIdVendedor.Name = "txtIdVendedor"
        Me.txtIdVendedor.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdVendedor.Properties.Appearance.Options.UseFont = True
        Me.txtIdVendedor.Size = New System.Drawing.Size(254, 22)
        Me.txtIdVendedor.TabIndex = 43
        '
        'XTPClientes
        '
        Me.XTPClientes.Controls.Add(Me.XTCClientes)
        Me.XTPClientes.Name = "XTPClientes"
        Me.XTPClientes.Size = New System.Drawing.Size(466, 324)
        Me.XTPClientes.Text = "Clientes"
        '
        'XTCClientes
        '
        Me.XTCClientes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XTCClientes.Location = New System.Drawing.Point(0, 0)
        Me.XTCClientes.Name = "XTCClientes"
        Me.XTCClientes.SelectedTabPage = Me.XTPListaCliente
        Me.XTCClientes.Size = New System.Drawing.Size(466, 324)
        Me.XTCClientes.TabIndex = 61
        Me.XTCClientes.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XTPListaCliente, Me.XTPDatosCliente})
        '
        'XTPListaCliente
        '
        Me.XTPListaCliente.Controls.Add(Me.GCClientes)
        Me.XTPListaCliente.Name = "XTPListaCliente"
        Me.XTPListaCliente.Size = New System.Drawing.Size(460, 296)
        Me.XTPListaCliente.Text = "Listado"
        '
        'GCClientes
        '
        Me.GCClientes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GCClientes.Location = New System.Drawing.Point(0, 0)
        Me.GCClientes.MainView = Me.GVClientes
        Me.GCClientes.Name = "GCClientes"
        Me.GCClientes.Size = New System.Drawing.Size(460, 296)
        Me.GCClientes.TabIndex = 47
        Me.GCClientes.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVClientes})
        '
        'GVClientes
        '
        Me.GVClientes.GridControl = Me.GCClientes
        Me.GVClientes.Name = "GVClientes"
        Me.GVClientes.OptionsBehavior.Editable = False
        Me.GVClientes.OptionsView.ShowAutoFilterRow = True
        Me.GVClientes.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.GVClientes.OptionsView.ShowGroupPanel = False
        '
        'XTPDatosCliente
        '
        Me.XTPDatosCliente.Controls.Add(Me.ChkClienteExonerado)
        Me.XTPDatosCliente.Controls.Add(Me.txtRUCCliente)
        Me.XTPDatosCliente.Controls.Add(Me.LabelControl39)
        Me.XTPDatosCliente.Controls.Add(Me.LabelControl41)
        Me.XTPDatosCliente.Controls.Add(Me.txtIdCliente)
        Me.XTPDatosCliente.Controls.Add(Me.txtApellidosCliente)
        Me.XTPDatosCliente.Controls.Add(Me.txtEmpresaCliente)
        Me.XTPDatosCliente.Controls.Add(Me.LabelControl40)
        Me.XTPDatosCliente.Controls.Add(Me.LabelControl38)
        Me.XTPDatosCliente.Controls.Add(Me.txtCorreoCliente)
        Me.XTPDatosCliente.Controls.Add(Me.LabelControl37)
        Me.XTPDatosCliente.Controls.Add(Me.LabelControl34)
        Me.XTPDatosCliente.Controls.Add(Me.ChkClienteActivo)
        Me.XTPDatosCliente.Controls.Add(Me.txtNombresCliente)
        Me.XTPDatosCliente.Controls.Add(Me.txtDirCliente)
        Me.XTPDatosCliente.Controls.Add(Me.LabelControl35)
        Me.XTPDatosCliente.Controls.Add(Me.LabelControl36)
        Me.XTPDatosCliente.Controls.Add(Me.txtTelCliente)
        Me.XTPDatosCliente.Name = "XTPDatosCliente"
        Me.XTPDatosCliente.Size = New System.Drawing.Size(460, 296)
        Me.XTPDatosCliente.Text = "Datos"
        '
        'ChkClienteExonerado
        '
        Me.ChkClienteExonerado.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkClienteExonerado.Location = New System.Drawing.Point(261, 19)
        Me.ChkClienteExonerado.Name = "ChkClienteExonerado"
        Me.ChkClienteExonerado.Properties.Appearance.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkClienteExonerado.Properties.Appearance.Options.UseFont = True
        Me.ChkClienteExonerado.Properties.Caption = "Exonerado"
        Me.ChkClienteExonerado.Size = New System.Drawing.Size(96, 19)
        Me.ChkClienteExonerado.TabIndex = 10
        '
        'txtRUCCliente
        '
        Me.txtRUCCliente.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtRUCCliente.Location = New System.Drawing.Point(79, 131)
        Me.txtRUCCliente.Name = "txtRUCCliente"
        Me.txtRUCCliente.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRUCCliente.Properties.Appearance.Options.UseFont = True
        Me.txtRUCCliente.Size = New System.Drawing.Size(343, 22)
        Me.txtRUCCliente.TabIndex = 60
        '
        'LabelControl39
        '
        Me.LabelControl39.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl39.Location = New System.Drawing.Point(16, 22)
        Me.LabelControl39.Name = "LabelControl39"
        Me.LabelControl39.Size = New System.Drawing.Size(39, 16)
        Me.LabelControl39.TabIndex = 44
        Me.LabelControl39.Text = "Código"
        '
        'LabelControl41
        '
        Me.LabelControl41.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl41.Location = New System.Drawing.Point(16, 131)
        Me.LabelControl41.Name = "LabelControl41"
        Me.LabelControl41.Size = New System.Drawing.Size(24, 16)
        Me.LabelControl41.TabIndex = 59
        Me.LabelControl41.Text = "RUC"
        '
        'txtIdCliente
        '
        Me.txtIdCliente.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtIdCliente.Location = New System.Drawing.Point(79, 19)
        Me.txtIdCliente.Name = "txtIdCliente"
        Me.txtIdCliente.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdCliente.Properties.Appearance.Options.UseFont = True
        Me.txtIdCliente.Size = New System.Drawing.Size(174, 22)
        Me.txtIdCliente.TabIndex = 43
        '
        'txtApellidosCliente
        '
        Me.txtApellidosCliente.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtApellidosCliente.Location = New System.Drawing.Point(79, 103)
        Me.txtApellidosCliente.Name = "txtApellidosCliente"
        Me.txtApellidosCliente.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtApellidosCliente.Properties.Appearance.Options.UseFont = True
        Me.txtApellidosCliente.Size = New System.Drawing.Size(343, 22)
        Me.txtApellidosCliente.TabIndex = 58
        '
        'txtEmpresaCliente
        '
        Me.txtEmpresaCliente.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtEmpresaCliente.Location = New System.Drawing.Point(79, 47)
        Me.txtEmpresaCliente.Name = "txtEmpresaCliente"
        Me.txtEmpresaCliente.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmpresaCliente.Properties.Appearance.Options.UseFont = True
        Me.txtEmpresaCliente.Size = New System.Drawing.Size(343, 22)
        Me.txtEmpresaCliente.TabIndex = 45
        '
        'LabelControl40
        '
        Me.LabelControl40.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl40.Location = New System.Drawing.Point(16, 103)
        Me.LabelControl40.Name = "LabelControl40"
        Me.LabelControl40.Size = New System.Drawing.Size(51, 16)
        Me.LabelControl40.TabIndex = 57
        Me.LabelControl40.Text = "Apellidos"
        '
        'LabelControl38
        '
        Me.LabelControl38.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl38.Location = New System.Drawing.Point(16, 50)
        Me.LabelControl38.Name = "LabelControl38"
        Me.LabelControl38.Size = New System.Drawing.Size(50, 16)
        Me.LabelControl38.TabIndex = 46
        Me.LabelControl38.Text = "Empresa"
        '
        'txtCorreoCliente
        '
        Me.txtCorreoCliente.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCorreoCliente.Location = New System.Drawing.Point(79, 215)
        Me.txtCorreoCliente.Name = "txtCorreoCliente"
        Me.txtCorreoCliente.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCorreoCliente.Properties.Appearance.Options.UseFont = True
        Me.txtCorreoCliente.Size = New System.Drawing.Size(343, 22)
        Me.txtCorreoCliente.TabIndex = 56
        '
        'LabelControl37
        '
        Me.LabelControl37.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl37.Location = New System.Drawing.Point(16, 162)
        Me.LabelControl37.Name = "LabelControl37"
        Me.LabelControl37.Size = New System.Drawing.Size(52, 16)
        Me.LabelControl37.TabIndex = 48
        Me.LabelControl37.Text = "Dirección"
        '
        'LabelControl34
        '
        Me.LabelControl34.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl34.Location = New System.Drawing.Point(16, 218)
        Me.LabelControl34.Name = "LabelControl34"
        Me.LabelControl34.Size = New System.Drawing.Size(39, 16)
        Me.LabelControl34.TabIndex = 55
        Me.LabelControl34.Text = "Correo"
        '
        'ChkClienteActivo
        '
        Me.ChkClienteActivo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkClienteActivo.Location = New System.Drawing.Point(362, 20)
        Me.ChkClienteActivo.Name = "ChkClienteActivo"
        Me.ChkClienteActivo.Properties.Appearance.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkClienteActivo.Properties.Appearance.Options.UseFont = True
        Me.ChkClienteActivo.Properties.Caption = "Activo"
        Me.ChkClienteActivo.Size = New System.Drawing.Size(60, 19)
        Me.ChkClienteActivo.TabIndex = 49
        '
        'txtNombresCliente
        '
        Me.txtNombresCliente.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNombresCliente.Location = New System.Drawing.Point(79, 75)
        Me.txtNombresCliente.Name = "txtNombresCliente"
        Me.txtNombresCliente.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombresCliente.Properties.Appearance.Options.UseFont = True
        Me.txtNombresCliente.Size = New System.Drawing.Size(343, 22)
        Me.txtNombresCliente.TabIndex = 54
        '
        'txtDirCliente
        '
        Me.txtDirCliente.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDirCliente.Location = New System.Drawing.Point(79, 159)
        Me.txtDirCliente.Name = "txtDirCliente"
        Me.txtDirCliente.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDirCliente.Properties.Appearance.Options.UseFont = True
        Me.txtDirCliente.Size = New System.Drawing.Size(343, 22)
        Me.txtDirCliente.TabIndex = 50
        '
        'LabelControl35
        '
        Me.LabelControl35.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl35.Location = New System.Drawing.Point(16, 75)
        Me.LabelControl35.Name = "LabelControl35"
        Me.LabelControl35.Size = New System.Drawing.Size(51, 16)
        Me.LabelControl35.TabIndex = 53
        Me.LabelControl35.Text = "Nombres"
        '
        'LabelControl36
        '
        Me.LabelControl36.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl36.Location = New System.Drawing.Point(16, 190)
        Me.LabelControl36.Name = "LabelControl36"
        Me.LabelControl36.Size = New System.Drawing.Size(50, 16)
        Me.LabelControl36.TabIndex = 51
        Me.LabelControl36.Text = "Teléfono"
        '
        'txtTelCliente
        '
        Me.txtTelCliente.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTelCliente.Location = New System.Drawing.Point(79, 187)
        Me.txtTelCliente.Name = "txtTelCliente"
        Me.txtTelCliente.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelCliente.Properties.Appearance.Options.UseFont = True
        Me.txtTelCliente.Size = New System.Drawing.Size(343, 22)
        Me.txtTelCliente.TabIndex = 52
        '
        'XTPProductos
        '
        Me.XTPProductos.Controls.Add(Me.XTCProductos)
        Me.XTPProductos.Name = "XTPProductos"
        Me.XTPProductos.Size = New System.Drawing.Size(466, 324)
        Me.XTPProductos.Text = "Productos"
        '
        'XTCProductos
        '
        Me.XTCProductos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XTCProductos.Location = New System.Drawing.Point(0, 0)
        Me.XTCProductos.Name = "XTCProductos"
        Me.XTCProductos.SelectedTabPage = Me.XTPListaProductos
        Me.XTCProductos.Size = New System.Drawing.Size(466, 324)
        Me.XTCProductos.TabIndex = 0
        Me.XTCProductos.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XTPListaProductos, Me.XTPDatosProducto})
        '
        'XTPListaProductos
        '
        Me.XTPListaProductos.Controls.Add(Me.GCProductos)
        Me.XTPListaProductos.Name = "XTPListaProductos"
        Me.XTPListaProductos.Size = New System.Drawing.Size(460, 296)
        Me.XTPListaProductos.Text = "Listado"
        '
        'GCProductos
        '
        Me.GCProductos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GCProductos.Location = New System.Drawing.Point(0, 0)
        Me.GCProductos.MainView = Me.GVProductos
        Me.GCProductos.Name = "GCProductos"
        Me.GCProductos.Size = New System.Drawing.Size(460, 296)
        Me.GCProductos.TabIndex = 48
        Me.GCProductos.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVProductos})
        '
        'GVProductos
        '
        Me.GVProductos.GridControl = Me.GCProductos
        Me.GVProductos.Name = "GVProductos"
        Me.GVProductos.OptionsBehavior.Editable = False
        Me.GVProductos.OptionsView.ShowAutoFilterRow = True
        Me.GVProductos.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.GVProductos.OptionsView.ShowGroupPanel = False
        '
        'XTPDatosProducto
        '
        Me.XTPDatosProducto.Controls.Add(Me.ChkEsServicio)
        Me.XTPDatosProducto.Controls.Add(Me.GroupControl1)
        Me.XTPDatosProducto.Controls.Add(Me.txtCosto)
        Me.XTPDatosProducto.Controls.Add(Me.LabelControl45)
        Me.XTPDatosProducto.Controls.Add(Me.ChkProductoExonerado)
        Me.XTPDatosProducto.Controls.Add(Me.LueMarcas)
        Me.XTPDatosProducto.Controls.Add(Me.LueCategorias)
        Me.XTPDatosProducto.Controls.Add(Me.txtExistencia)
        Me.XTPDatosProducto.Controls.Add(Me.LabelControl42)
        Me.XTPDatosProducto.Controls.Add(Me.LabelControl43)
        Me.XTPDatosProducto.Controls.Add(Me.txtIdProducto)
        Me.XTPDatosProducto.Controls.Add(Me.txtProducto)
        Me.XTPDatosProducto.Controls.Add(Me.LabelControl44)
        Me.XTPDatosProducto.Controls.Add(Me.LblCleanCategoria)
        Me.XTPDatosProducto.Controls.Add(Me.txtPrecio3)
        Me.XTPDatosProducto.Controls.Add(Me.LabelControl46)
        Me.XTPDatosProducto.Controls.Add(Me.LabelControl47)
        Me.XTPDatosProducto.Controls.Add(Me.ChkProductoActivo)
        Me.XTPDatosProducto.Controls.Add(Me.txtPrecio1)
        Me.XTPDatosProducto.Controls.Add(Me.LblCleanMarca)
        Me.XTPDatosProducto.Controls.Add(Me.LabelControl49)
        Me.XTPDatosProducto.Controls.Add(Me.txtPrecio2)
        Me.XTPDatosProducto.Name = "XTPDatosProducto"
        Me.XTPDatosProducto.Size = New System.Drawing.Size(460, 296)
        Me.XTPDatosProducto.Text = "Datos"
        '
        'ChkEsServicio
        '
        Me.ChkEsServicio.Location = New System.Drawing.Point(181, 212)
        Me.ChkEsServicio.Name = "ChkEsServicio"
        Me.ChkEsServicio.Properties.Appearance.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkEsServicio.Properties.Appearance.Options.UseFont = True
        Me.ChkEsServicio.Properties.Caption = "Servicio"
        Me.ChkEsServicio.Size = New System.Drawing.Size(96, 19)
        Me.ChkEsServicio.TabIndex = 84
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.RDGMonedaProducto)
        Me.GroupControl1.Location = New System.Drawing.Point(282, 134)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(120, 77)
        Me.GroupControl1.TabIndex = 83
        Me.GroupControl1.Text = "Moneda"
        '
        'RDGMonedaProducto
        '
        Me.RDGMonedaProducto.Location = New System.Drawing.Point(10, 24)
        Me.RDGMonedaProducto.Name = "RDGMonedaProducto"
        Me.RDGMonedaProducto.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.RDGMonedaProducto.Properties.Appearance.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RDGMonedaProducto.Properties.Appearance.Options.UseBackColor = True
        Me.RDGMonedaProducto.Properties.Appearance.Options.UseFont = True
        Me.RDGMonedaProducto.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.RDGMonedaProducto.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(Nothing, "US$"), New DevExpress.XtraEditors.Controls.RadioGroupItem(Nothing, "CS$")})
        Me.RDGMonedaProducto.Size = New System.Drawing.Size(67, 48)
        Me.RDGMonedaProducto.TabIndex = 18
        '
        'txtCosto
        '
        Me.txtCosto.Location = New System.Drawing.Point(79, 160)
        Me.txtCosto.Name = "txtCosto"
        Me.txtCosto.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCosto.Properties.Appearance.Options.UseFont = True
        Me.txtCosto.Size = New System.Drawing.Size(67, 22)
        Me.txtCosto.TabIndex = 82
        '
        'LabelControl45
        '
        Me.LabelControl45.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl45.Location = New System.Drawing.Point(16, 163)
        Me.LabelControl45.Name = "LabelControl45"
        Me.LabelControl45.Size = New System.Drawing.Size(32, 16)
        Me.LabelControl45.TabIndex = 81
        Me.LabelControl45.Text = "Costo"
        '
        'ChkProductoExonerado
        '
        Me.ChkProductoExonerado.Location = New System.Drawing.Point(79, 212)
        Me.ChkProductoExonerado.Name = "ChkProductoExonerado"
        Me.ChkProductoExonerado.Properties.Appearance.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkProductoExonerado.Properties.Appearance.Options.UseFont = True
        Me.ChkProductoExonerado.Properties.Caption = "Exonerado"
        Me.ChkProductoExonerado.Size = New System.Drawing.Size(96, 19)
        Me.ChkProductoExonerado.TabIndex = 80
        '
        'LueMarcas
        '
        Me.LueMarcas.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LueMarcas.EditValue = ""
        Me.LueMarcas.Location = New System.Drawing.Point(79, 103)
        Me.LueMarcas.Name = "LueMarcas"
        Me.LueMarcas.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.LueMarcas.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LueMarcas.Properties.NullText = ""
        Me.LueMarcas.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.OnlyInPopup
        Me.LueMarcas.Size = New System.Drawing.Size(343, 20)
        Me.LueMarcas.TabIndex = 79
        '
        'LueCategorias
        '
        Me.LueCategorias.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LueCategorias.EditValue = ""
        Me.LueCategorias.Location = New System.Drawing.Point(79, 76)
        Me.LueCategorias.Name = "LueCategorias"
        Me.LueCategorias.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.LueCategorias.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LueCategorias.Properties.NullText = ""
        Me.LueCategorias.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.OnlyInPopup
        Me.LueCategorias.Size = New System.Drawing.Size(343, 20)
        Me.LueCategorias.TabIndex = 78
        '
        'txtExistencia
        '
        Me.txtExistencia.Location = New System.Drawing.Point(79, 131)
        Me.txtExistencia.Name = "txtExistencia"
        Me.txtExistencia.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtExistencia.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtExistencia.Properties.Appearance.Options.UseBackColor = True
        Me.txtExistencia.Properties.Appearance.Options.UseFont = True
        Me.txtExistencia.Properties.ReadOnly = True
        Me.txtExistencia.Size = New System.Drawing.Size(67, 22)
        Me.txtExistencia.TabIndex = 77
        '
        'LabelControl42
        '
        Me.LabelControl42.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl42.Location = New System.Drawing.Point(16, 22)
        Me.LabelControl42.Name = "LabelControl42"
        Me.LabelControl42.Size = New System.Drawing.Size(39, 16)
        Me.LabelControl42.TabIndex = 62
        Me.LabelControl42.Text = "Código"
        '
        'LabelControl43
        '
        Me.LabelControl43.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl43.Location = New System.Drawing.Point(16, 134)
        Me.LabelControl43.Name = "LabelControl43"
        Me.LabelControl43.Size = New System.Drawing.Size(56, 16)
        Me.LabelControl43.TabIndex = 76
        Me.LabelControl43.Text = "Existencia"
        '
        'txtIdProducto
        '
        Me.txtIdProducto.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtIdProducto.Location = New System.Drawing.Point(79, 19)
        Me.txtIdProducto.Name = "txtIdProducto"
        Me.txtIdProducto.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdProducto.Properties.Appearance.Options.UseFont = True
        Me.txtIdProducto.Size = New System.Drawing.Size(277, 22)
        Me.txtIdProducto.TabIndex = 61
        '
        'txtProducto
        '
        Me.txtProducto.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtProducto.Location = New System.Drawing.Point(79, 48)
        Me.txtProducto.Name = "txtProducto"
        Me.txtProducto.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProducto.Properties.Appearance.Options.UseFont = True
        Me.txtProducto.Size = New System.Drawing.Size(343, 22)
        Me.txtProducto.TabIndex = 75
        '
        'LabelControl44
        '
        Me.LabelControl44.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl44.Location = New System.Drawing.Point(16, 48)
        Me.LabelControl44.Name = "LabelControl44"
        Me.LabelControl44.Size = New System.Drawing.Size(50, 16)
        Me.LabelControl44.TabIndex = 74
        Me.LabelControl44.Text = "Producto"
        '
        'LblCleanCategoria
        '
        Me.LblCleanCategoria.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCleanCategoria.Location = New System.Drawing.Point(16, 77)
        Me.LblCleanCategoria.Name = "LblCleanCategoria"
        Me.LblCleanCategoria.Size = New System.Drawing.Size(55, 16)
        Me.LblCleanCategoria.TabIndex = 64
        Me.LblCleanCategoria.Text = "Categoría"
        '
        'txtPrecio3
        '
        Me.txtPrecio3.Location = New System.Drawing.Point(209, 187)
        Me.txtPrecio3.Name = "txtPrecio3"
        Me.txtPrecio3.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrecio3.Properties.Appearance.Options.UseFont = True
        Me.txtPrecio3.Size = New System.Drawing.Size(67, 22)
        Me.txtPrecio3.TabIndex = 73
        '
        'LabelControl46
        '
        Me.LabelControl46.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl46.Location = New System.Drawing.Point(155, 134)
        Me.LabelControl46.Name = "LabelControl46"
        Me.LabelControl46.Size = New System.Drawing.Size(46, 16)
        Me.LabelControl46.TabIndex = 65
        Me.LabelControl46.Text = "Precio 1"
        '
        'LabelControl47
        '
        Me.LabelControl47.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl47.Location = New System.Drawing.Point(155, 190)
        Me.LabelControl47.Name = "LabelControl47"
        Me.LabelControl47.Size = New System.Drawing.Size(46, 16)
        Me.LabelControl47.TabIndex = 72
        Me.LabelControl47.Text = "Precio 3"
        '
        'ChkProductoActivo
        '
        Me.ChkProductoActivo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkProductoActivo.Location = New System.Drawing.Point(362, 20)
        Me.ChkProductoActivo.Name = "ChkProductoActivo"
        Me.ChkProductoActivo.Properties.Appearance.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkProductoActivo.Properties.Appearance.Options.UseFont = True
        Me.ChkProductoActivo.Properties.Caption = "Activo"
        Me.ChkProductoActivo.Size = New System.Drawing.Size(60, 19)
        Me.ChkProductoActivo.TabIndex = 66
        '
        'txtPrecio1
        '
        Me.txtPrecio1.Location = New System.Drawing.Point(209, 131)
        Me.txtPrecio1.Name = "txtPrecio1"
        Me.txtPrecio1.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrecio1.Properties.Appearance.Options.UseFont = True
        Me.txtPrecio1.Size = New System.Drawing.Size(67, 22)
        Me.txtPrecio1.TabIndex = 67
        '
        'LblCleanMarca
        '
        Me.LblCleanMarca.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCleanMarca.Location = New System.Drawing.Point(16, 104)
        Me.LblCleanMarca.Name = "LblCleanMarca"
        Me.LblCleanMarca.Size = New System.Drawing.Size(35, 16)
        Me.LblCleanMarca.TabIndex = 70
        Me.LblCleanMarca.Text = "Marca"
        '
        'LabelControl49
        '
        Me.LabelControl49.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl49.Location = New System.Drawing.Point(155, 162)
        Me.LabelControl49.Name = "LabelControl49"
        Me.LabelControl49.Size = New System.Drawing.Size(46, 16)
        Me.LabelControl49.TabIndex = 68
        Me.LabelControl49.Text = "Precio 2"
        '
        'txtPrecio2
        '
        Me.txtPrecio2.EditValue = ""
        Me.txtPrecio2.Location = New System.Drawing.Point(209, 159)
        Me.txtPrecio2.Name = "txtPrecio2"
        Me.txtPrecio2.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrecio2.Properties.Appearance.Options.UseFont = True
        Me.txtPrecio2.Size = New System.Drawing.Size(67, 22)
        Me.txtPrecio2.TabIndex = 69
        '
        'PanelTitulo
        '
        Me.PanelTitulo.Controls.Add(Me.LblTitulo)
        Me.PanelTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelTitulo.Location = New System.Drawing.Point(5, 2)
        Me.PanelTitulo.Name = "PanelTitulo"
        Me.PanelTitulo.Size = New System.Drawing.Size(474, 39)
        Me.PanelTitulo.TabIndex = 2
        '
        'LblTitulo
        '
        Me.LblTitulo.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LblTitulo.Appearance.Font = New System.Drawing.Font("Monotype Corsiva", 20.25!, System.Drawing.FontStyle.Italic)
        Me.LblTitulo.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.LblTitulo.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LblTitulo.Location = New System.Drawing.Point(50, 3)
        Me.LblTitulo.Name = "LblTitulo"
        Me.LblTitulo.Size = New System.Drawing.Size(375, 33)
        Me.LblTitulo.TabIndex = 1
        Me.LblTitulo.Text = "Catálogo de"
        '
        'Splitter1
        '
        Me.Splitter1.Location = New System.Drawing.Point(2, 2)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(3, 467)
        Me.Splitter1.TabIndex = 5
        Me.Splitter1.TabStop = False
        '
        'FrmCatalogos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(723, 471)
        Me.Controls.Add(Me.PanelPrincipal)
        Me.Controls.Add(Me.SplitterControl1)
        Me.Controls.Add(Me.PanelTree)
        Me.Name = "FrmCatalogos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Catálogos del Sistema"
        CType(Me.PanelTree, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelTree.ResumeLayout(False)
        CType(Me.TreeCatalogos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelPrincipal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelPrincipal.ResumeLayout(False)
        CType(Me.PanelBotones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelBotones.ResumeLayout(False)
        CType(Me.XTPCatalogos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XTPCatalogos.ResumeLayout(False)
        Me.xtpUsuarios.ResumeLayout(False)
        Me.xtpUsuarios.PerformLayout()
        CType(Me.ChkUsuarioAdministrador.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChkUsuarioActivo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lueSucursalUsuario.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtClave.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gcUsuarios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvUsuarios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtUsuario.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtIdIUsuario.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.xtpMarcas.ResumeLayout(False)
        Me.xtpMarcas.PerformLayout()
        CType(Me.ChkMarcaActiva.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gcMarcas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvMarcas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMarca.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtIdMarca.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.xtpCategorias.ResumeLayout(False)
        Me.xtpCategorias.PerformLayout()
        CType(Me.txtPUtilidad2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPUtilidad3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtComision.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPUtilidad1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChkCategoriaActiva.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gcCategorias, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvCategorias, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCategoria.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtIdCategoria.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XTPTipoAjuste.ResumeLayout(False)
        Me.XTPTipoAjuste.PerformLayout()
        CType(Me.RDGValorAjuste.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gcTipoAjuste, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvTipoAjuste, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTipoAjuste.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtIdTipoAjuste.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtcSucursal.ResumeLayout(False)
        Me.XtcSucursal.PerformLayout()
        CType(Me.GCNumeraciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GCNumeraciones.ResumeLayout(False)
        Me.GCNumeraciones.PerformLayout()
        CType(Me.SpeNumAjuste.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpeNumFactura.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpeNumRemision.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpeNumCompra.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDirSucursal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChkSucursalActiva.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GCSucursal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GvSucursal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSucursal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtIdSucursal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XTPProveedor.ResumeLayout(False)
        Me.XTPProveedor.PerformLayout()
        CType(Me.txtCorreoProveedor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRUCProveedor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTelProveedor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDirProveedor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChkProveedorActivo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GCProveedores, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVProveedores, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtProveedor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtIdProveedor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XTPVendedores.ResumeLayout(False)
        Me.XTPVendedores.PerformLayout()
        CType(Me.txtCorreoVendedor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtApellidosVendedor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTelVendedor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDirVendedor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChkVendedorActivo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GCVendedores, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVVendedores, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNombresVendedor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtIdVendedor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XTPClientes.ResumeLayout(False)
        CType(Me.XTCClientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XTCClientes.ResumeLayout(False)
        Me.XTPListaCliente.ResumeLayout(False)
        CType(Me.GCClientes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVClientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XTPDatosCliente.ResumeLayout(False)
        Me.XTPDatosCliente.PerformLayout()
        CType(Me.ChkClienteExonerado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRUCCliente.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtIdCliente.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtApellidosCliente.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEmpresaCliente.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCorreoCliente.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChkClienteActivo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNombresCliente.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDirCliente.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTelCliente.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XTPProductos.ResumeLayout(False)
        CType(Me.XTCProductos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XTCProductos.ResumeLayout(False)
        Me.XTPListaProductos.ResumeLayout(False)
        CType(Me.GCProductos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVProductos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XTPDatosProducto.ResumeLayout(False)
        Me.XTPDatosProducto.PerformLayout()
        CType(Me.ChkEsServicio.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.RDGMonedaProducto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCosto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChkProductoExonerado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LueMarcas.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LueCategorias.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtExistencia.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtIdProducto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtProducto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPrecio3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChkProductoActivo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPrecio1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPrecio2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelTitulo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelTitulo.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelTree As DevExpress.XtraEditors.PanelControl
    Friend WithEvents TreeCatalogos As DevExpress.XtraTreeList.TreeList
    Friend WithEvents SplitterControl1 As DevExpress.XtraEditors.SplitterControl
    Friend WithEvents PanelPrincipal As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelBotones As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnNuevo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnGuardar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnEliminar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents XTPCatalogos As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents xtpUsuarios As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents gcUsuarios As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvUsuarios As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtUsuario As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TxtIdIUsuario As DevExpress.XtraEditors.TextEdit
    Friend WithEvents xtpMarcas As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents gcMarcas As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvMarcas As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtMarca As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtIdMarca As DevExpress.XtraEditors.TextEdit
    Friend WithEvents xtpCategorias As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents gcCategorias As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvCategorias As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCategoria As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TxtIdCategoria As DevExpress.XtraEditors.TextEdit
    Friend WithEvents PanelTitulo As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LblTitulo As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Splitter1 As System.Windows.Forms.Splitter
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtClave As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lueSucursalUsuario As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents ChkUsuarioActivo As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents ChkMarcaActiva As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtPUtilidad2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtPUtilidad3 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtComision As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtPUtilidad1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ChkCategoriaActiva As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents XTPTipoAjuste As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents RDGValorAjuste As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents LabelControl14 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents gcTipoAjuste As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvTipoAjuste As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LabelControl12 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtTipoAjuste As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl13 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtIdTipoAjuste As DevExpress.XtraEditors.TextEdit
    Friend WithEvents XtcSucursal As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents LabelControl15 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GCSucursal As DevExpress.XtraGrid.GridControl
    Friend WithEvents GvSucursal As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LabelControl16 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtSucursal As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl17 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtIdSucursal As DevExpress.XtraEditors.TextEdit
    Friend WithEvents XTPProveedor As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XTPVendedores As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents txtDirSucursal As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ChkSucursalActiva As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents GCNumeraciones As DevExpress.XtraEditors.GroupControl
    Friend WithEvents SpeNumCompra As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents LabelControl21 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SpeNumAjuste As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents LabelControl20 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SpeNumFactura As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents LabelControl19 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SpeNumRemision As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents LabelControl18 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtDirProveedor As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ChkProveedorActivo As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LabelControl26 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GCProveedores As DevExpress.XtraGrid.GridControl
    Friend WithEvents GVProveedores As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LabelControl27 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtProveedor As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl28 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtIdProveedor As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtTelProveedor As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl22 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtRUCProveedor As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl23 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCorreoProveedor As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl24 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents XTPClientes As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XTPProductos As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents txtCorreoVendedor As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl25 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtApellidosVendedor As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl29 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtTelVendedor As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl30 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtDirVendedor As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ChkVendedorActivo As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LabelControl31 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GCVendedores As DevExpress.XtraGrid.GridControl
    Friend WithEvents GVVendedores As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LabelControl32 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtNombresVendedor As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl33 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtIdVendedor As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtRUCCliente As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl41 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtApellidosCliente As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl40 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCorreoCliente As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl34 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtNombresCliente As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl35 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtTelCliente As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl36 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtDirCliente As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ChkClienteActivo As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LabelControl37 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GCClientes As DevExpress.XtraGrid.GridControl
    Friend WithEvents GVClientes As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LabelControl38 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl39 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtIdCliente As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ChkClienteExonerado As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents XTCProductos As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XTPListaProductos As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XTPDatosProducto As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XTCClientes As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XTPListaCliente As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XTPDatosCliente As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents txtEmpresaCliente As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GCProductos As DevExpress.XtraGrid.GridControl
    Friend WithEvents GVProductos As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RDGMonedaProducto As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents txtCosto As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl45 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents ChkProductoExonerado As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LueMarcas As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LueCategorias As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents txtExistencia As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl42 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl43 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtIdProducto As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtProducto As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl44 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LblCleanCategoria As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtPrecio3 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl46 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl47 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents ChkProductoActivo As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents txtPrecio1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LblCleanMarca As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl49 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtPrecio2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ChkEsServicio As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents ChkUsuarioAdministrador As DevExpress.XtraEditors.CheckEdit
End Class
