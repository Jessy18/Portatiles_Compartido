<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTile
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
        Dim TileItemElement7 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemElement8 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemElement9 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemElement10 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemElement11 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemElement12 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Me.TileControl1 = New DevExpress.XtraEditors.TileControl()
        Me.TileGroup2 = New DevExpress.XtraEditors.TileGroup()
        Me.titCatalogos = New DevExpress.XtraEditors.TileItem()
        Me.titPermisos = New DevExpress.XtraEditors.TileItem()
        Me.titConfig = New DevExpress.XtraEditors.TileItem()
        Me.TileGroup3 = New DevExpress.XtraEditors.TileGroup()
        Me.titFacturacion = New DevExpress.XtraEditors.TileItem()
        Me.titCompras = New DevExpress.XtraEditors.TileItem()
        Me.titSalir = New DevExpress.XtraEditors.TileItem()
        Me.SuspendLayout()
        '
        'TileControl1
        '
        Me.TileControl1.AppearanceItem.Normal.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TileControl1.AppearanceItem.Normal.Options.UseFont = True
        Me.TileControl1.BackColor = System.Drawing.Color.SteelBlue
        Me.TileControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TileControl1.DragSize = New System.Drawing.Size(0, 0)
        Me.TileControl1.Groups.Add(Me.TileGroup2)
        Me.TileControl1.Groups.Add(Me.TileGroup3)
        Me.TileControl1.ItemImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopCenter
        Me.TileControl1.ItemSize = 140
        Me.TileControl1.Location = New System.Drawing.Point(0, 0)
        Me.TileControl1.MaxId = 9
        Me.TileControl1.Name = "TileControl1"
        Me.TileControl1.Size = New System.Drawing.Size(693, 421)
        Me.TileControl1.TabIndex = 0
        Me.TileControl1.Text = "TileControl1"
        '
        'TileGroup2
        '
        Me.TileGroup2.Items.Add(Me.titCatalogos)
        Me.TileGroup2.Items.Add(Me.titPermisos)
        Me.TileGroup2.Items.Add(Me.titConfig)
        Me.TileGroup2.Name = "TileGroup2"
        '
        'titCatalogos
        '
        Me.titCatalogos.AppearanceItem.Normal.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(178, Byte), Integer))
        Me.titCatalogos.AppearanceItem.Normal.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.titCatalogos.AppearanceItem.Normal.Options.UseBackColor = True
        Me.titCatalogos.AppearanceItem.Normal.Options.UseBorderColor = True
        TileItemElement7.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Bottom
        TileItemElement7.Text = "Catálogos"
        Me.titCatalogos.Elements.Add(TileItemElement7)
        Me.titCatalogos.Id = 1
        Me.titCatalogos.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium
        Me.titCatalogos.Name = "titCatalogos"
        '
        'titPermisos
        '
        Me.titPermisos.AppearanceItem.Normal.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.titPermisos.AppearanceItem.Normal.BorderColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.titPermisos.AppearanceItem.Normal.Options.UseBackColor = True
        Me.titPermisos.AppearanceItem.Normal.Options.UseBorderColor = True
        TileItemElement8.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Bottom
        TileItemElement8.Text = "Permisos"
        Me.titPermisos.Elements.Add(TileItemElement8)
        Me.titPermisos.Id = 2
        Me.titPermisos.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium
        Me.titPermisos.Name = "titPermisos"
        '
        'titConfig
        '
        Me.titConfig.AppearanceItem.Normal.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.titConfig.AppearanceItem.Normal.BorderColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.titConfig.AppearanceItem.Normal.Options.UseBackColor = True
        Me.titConfig.AppearanceItem.Normal.Options.UseBorderColor = True
        TileItemElement9.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Bottom
        TileItemElement9.Text = "Configuración"
        Me.titConfig.Elements.Add(TileItemElement9)
        Me.titConfig.Id = 3
        Me.titConfig.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide
        Me.titConfig.Name = "titConfig"
        '
        'TileGroup3
        '
        Me.TileGroup3.Items.Add(Me.titFacturacion)
        Me.TileGroup3.Items.Add(Me.titCompras)
        Me.TileGroup3.Items.Add(Me.titSalir)
        Me.TileGroup3.Name = "TileGroup3"
        '
        'titFacturacion
        '
        Me.titFacturacion.AppearanceItem.Normal.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.titFacturacion.AppearanceItem.Normal.BorderColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.titFacturacion.AppearanceItem.Normal.Options.UseBackColor = True
        Me.titFacturacion.AppearanceItem.Normal.Options.UseBorderColor = True
        TileItemElement10.Text = "Facturación"
        Me.titFacturacion.Elements.Add(TileItemElement10)
        Me.titFacturacion.Id = 4
        Me.titFacturacion.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide
        Me.titFacturacion.Name = "titFacturacion"
        '
        'titCompras
        '
        Me.titCompras.AppearanceItem.Normal.BackColor = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(178, Byte), Integer))
        Me.titCompras.AppearanceItem.Normal.BorderColor = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.titCompras.AppearanceItem.Normal.Options.UseBackColor = True
        Me.titCompras.AppearanceItem.Normal.Options.UseBorderColor = True
        TileItemElement11.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Bottom
        TileItemElement11.Text = "Compras"
        Me.titCompras.Elements.Add(TileItemElement11)
        Me.titCompras.Id = 7
        Me.titCompras.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium
        Me.titCompras.Name = "titCompras"
        '
        'titSalir
        '
        Me.titSalir.AppearanceItem.Normal.BackColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.titSalir.AppearanceItem.Normal.BorderColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.titSalir.AppearanceItem.Normal.Options.UseBackColor = True
        Me.titSalir.AppearanceItem.Normal.Options.UseBorderColor = True
        TileItemElement12.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Bottom
        TileItemElement12.Text = "Salir"
        Me.titSalir.Elements.Add(TileItemElement12)
        Me.titSalir.Id = 8
        Me.titSalir.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium
        Me.titSalir.Name = "titSalir"
        '
        'FrmTile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(693, 421)
        Me.Controls.Add(Me.TileControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmTile"
        Me.Text = "FrmTile"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TileControl1 As DevExpress.XtraEditors.TileControl
    Friend WithEvents TileGroup2 As DevExpress.XtraEditors.TileGroup
    Friend WithEvents titCatalogos As DevExpress.XtraEditors.TileItem
    Friend WithEvents titPermisos As DevExpress.XtraEditors.TileItem
    Friend WithEvents titConfig As DevExpress.XtraEditors.TileItem
    Friend WithEvents TileGroup3 As DevExpress.XtraEditors.TileGroup
    Friend WithEvents titFacturacion As DevExpress.XtraEditors.TileItem
    Friend WithEvents titCompras As DevExpress.XtraEditors.TileItem
    Friend WithEvents titSalir As DevExpress.XtraEditors.TileItem
End Class
