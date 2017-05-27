<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class XtraForm1
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
        Dim TileItemElement1 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemElement2 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemElement3 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Me.TileBar1 = New DevExpress.XtraBars.Navigation.TileBar()
        Me.TileBarGroup2 = New DevExpress.XtraBars.Navigation.TileBarGroup()
        Me.TileBarGroup3 = New DevExpress.XtraBars.Navigation.TileBarGroup()
        Me.TileBarGroup4 = New DevExpress.XtraBars.Navigation.TileBarGroup()
        Me.TileBarItem1 = New DevExpress.XtraBars.Navigation.TileBarItem()
        Me.TileBarGroup5 = New DevExpress.XtraBars.Navigation.TileBarGroup()
        Me.TileBarGroup6 = New DevExpress.XtraBars.Navigation.TileBarGroup()
        Me.TileBarGroup7 = New DevExpress.XtraBars.Navigation.TileBarGroup()
        Me.TileBarItem2 = New DevExpress.XtraBars.Navigation.TileBarItem()
        Me.TileBarItem3 = New DevExpress.XtraBars.Navigation.TileBarItem()
        Me.SuspendLayout()
        '
        'TileBar1
        '
        Me.TileBar1.AllowDrag = False
        Me.TileBar1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TileBar1.DropDownOptions.BeakColor = System.Drawing.Color.Empty
        Me.TileBar1.Groups.Add(Me.TileBarGroup2)
        Me.TileBar1.Groups.Add(Me.TileBarGroup3)
        Me.TileBar1.Groups.Add(Me.TileBarGroup4)
        Me.TileBar1.Groups.Add(Me.TileBarGroup5)
        Me.TileBar1.Groups.Add(Me.TileBarGroup6)
        Me.TileBar1.Groups.Add(Me.TileBarGroup7)
        Me.TileBar1.Location = New System.Drawing.Point(0, 0)
        Me.TileBar1.MaxId = 4
        Me.TileBar1.Name = "TileBar1"
        Me.TileBar1.ScrollMode = DevExpress.XtraEditors.TileControlScrollMode.ScrollButtons
        Me.TileBar1.Size = New System.Drawing.Size(460, 107)
        Me.TileBar1.TabIndex = 0
        Me.TileBar1.Text = "TileBar1"
        '
        'TileBarGroup2
        '
        Me.TileBarGroup2.Items.Add(Me.TileBarItem1)
        Me.TileBarGroup2.Name = "TileBarGroup2"
        '
        'TileBarGroup3
        '
        Me.TileBarGroup3.Items.Add(Me.TileBarItem2)
        Me.TileBarGroup3.Name = "TileBarGroup3"
        '
        'TileBarGroup4
        '
        Me.TileBarGroup4.Items.Add(Me.TileBarItem3)
        Me.TileBarGroup4.Name = "TileBarGroup4"
        '
        'TileBarItem1
        '
        Me.TileBarItem1.DropDownOptions.BeakColor = System.Drawing.Color.Empty
        TileItemElement1.Image = Global.Portatiles.My.Resources.Resources.shopping_cart
        TileItemElement1.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Left
        TileItemElement1.Text = "Catálogos"
        Me.TileBarItem1.Elements.Add(TileItemElement1)
        Me.TileBarItem1.Id = 0
        Me.TileBarItem1.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide
        Me.TileBarItem1.Name = "TileBarItem1"
        '
        'TileBarGroup5
        '
        Me.TileBarGroup5.Name = "TileBarGroup5"
        '
        'TileBarGroup6
        '
        Me.TileBarGroup6.Name = "TileBarGroup6"
        '
        'TileBarGroup7
        '
        Me.TileBarGroup7.Name = "TileBarGroup7"
        '
        'TileBarItem2
        '
        Me.TileBarItem2.DropDownOptions.BeakColor = System.Drawing.Color.Empty
        TileItemElement2.Image = Global.Portatiles.My.Resources.Resources.Arrow2_Right
        TileItemElement2.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Left
        TileItemElement2.Text = "TileBarItem2"
        Me.TileBarItem2.Elements.Add(TileItemElement2)
        Me.TileBarItem2.Id = 2
        Me.TileBarItem2.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide
        Me.TileBarItem2.Name = "TileBarItem2"
        '
        'TileBarItem3
        '
        Me.TileBarItem3.DropDownOptions.BeakColor = System.Drawing.Color.Empty
        TileItemElement3.Text = "TileBarItem3"
        Me.TileBarItem3.Elements.Add(TileItemElement3)
        Me.TileBarItem3.Id = 3
        Me.TileBarItem3.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide
        Me.TileBarItem3.Name = "TileBarItem3"
        '
        'XtraForm1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(460, 255)
        Me.Controls.Add(Me.TileBar1)
        Me.Name = "XtraForm1"
        Me.Text = "XtraForm1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TileBar1 As DevExpress.XtraBars.Navigation.TileBar
    Friend WithEvents TileBarGroup2 As DevExpress.XtraBars.Navigation.TileBarGroup
    Friend WithEvents TileBarItem1 As DevExpress.XtraBars.Navigation.TileBarItem
    Friend WithEvents TileBarGroup3 As DevExpress.XtraBars.Navigation.TileBarGroup
    Friend WithEvents TileBarGroup4 As DevExpress.XtraBars.Navigation.TileBarGroup
    Friend WithEvents TileBarGroup5 As DevExpress.XtraBars.Navigation.TileBarGroup
    Friend WithEvents TileBarGroup6 As DevExpress.XtraBars.Navigation.TileBarGroup
    Friend WithEvents TileBarGroup7 As DevExpress.XtraBars.Navigation.TileBarGroup
    Friend WithEvents TileBarItem2 As DevExpress.XtraBars.Navigation.TileBarItem
    Friend WithEvents TileBarItem3 As DevExpress.XtraBars.Navigation.TileBarItem
End Class
