Imports DevExpress.XtraEditors
Imports DevExpress.XtraTreeList.Nodes
Imports Microsoft.Office.Interop


Public Class FrmImportador

    Dim DtExcel As DataTable

    Private Sub FrmCatalogos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarArbolObjetos()
    End Sub


    Private Sub CargarArbolObjetos()
        'Agrego las columnas al treelist de devexpress
        TreeCatalogos.BeginUpdate()

        TreeCatalogos.OptionsSelection.MultiSelect = False
        TreeCatalogos.OptionsBehavior.Editable = False
        'estas dos propiedades de abajo son las que permiten el autofiltrado
        TreeCatalogos.OptionsFilter.AllowFilterEditor = True
        TreeCatalogos.OptionsBehavior.EnableFiltering = True

        TreeCatalogos.Columns.Add()
        TreeCatalogos.Columns(0).Caption = "Listado de Catálogos"
        TreeCatalogos.Columns(0).VisibleIndex = 0

        'TreeCatalogos.Columns(0).OptionsColumn.ReadOnly = True
        TreeCatalogos.EndUpdate()

        'Agrego los items que pertenecen al árbol
        TreeCatalogos.BeginUnboundLoad()

        Dim ParentNodo As TreeListNode = Nothing

        Dim RootNodo As TreeListNode = TreeCatalogos.AppendNode(New Object() {"Sucursales"}, ParentNodo)
        Dim RootNodo1 As TreeListNode = TreeCatalogos.AppendNode(New Object() {"Usuarios"}, ParentNodo)
        Dim RootNodo2 As TreeListNode = TreeCatalogos.AppendNode(New Object() {"Vendedores"}, ParentNodo)
        Dim RootNodo3 As TreeListNode = TreeCatalogos.AppendNode(New Object() {"Proveedores"}, ParentNodo)
        Dim RootNodo4 As TreeListNode = TreeCatalogos.AppendNode(New Object() {"Clientes"}, ParentNodo)
        Dim RootNodo5 As TreeListNode = TreeCatalogos.AppendNode(New Object() {"Marcas"}, ParentNodo)
        Dim RootNodo6 As TreeListNode = TreeCatalogos.AppendNode(New Object() {"Categorías de Productos"}, ParentNodo)
        Dim RootNodo7 As TreeListNode = TreeCatalogos.AppendNode(New Object() {"Tipo de Ajuste"}, ParentNodo)
        Dim RootNodo8 As TreeListNode = TreeCatalogos.AppendNode(New Object() {"Productos"}, ParentNodo)


        TreeCatalogos.EndUnboundLoad()
        TreeCatalogos.ExpandAll()

    End Sub


    Private Sub TreeCatalogos_FocusedNodeChanged(sender As Object, e As DevExpress.XtraTreeList.FocusedNodeChangedEventArgs) Handles TreeCatalogos.FocusedNodeChanged
        If Not IsNothing(TreeCatalogos.FocusedNode.GetValue(0)) Then

        Else
            For Each page As DevExpress.XtraTab.XtraTabPage In XTPCatalogos.TabPages
                page.PageVisible = False
            Next
            LblTitulo.Text = "Importador"
            XTPCatalogos.Visible = False
        End If

    End Sub



    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If IsNothing(TreeCatalogos.FocusedNode.GetValue(0)) Then Exit Sub

        Select Case TreeCatalogos.FocusedNode.GetValue(0).ToString
            Case "Usuarios"
                'GuardarUsuario()
            Case "Marcas"
                GuardarMarca()
  
            Case Else
        End Select
    End Sub


    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Dispose()
        Me.Close()
    End Sub


    ' PROGRAMACION DEL CATALOGO DE MARCAS 
#Region "PROGRAMACION DEL CATALOGO DE MARCAS"



    Private Sub GuardarMarca()
        On Error GoTo tipoerr
        Dim Guardados As Boolean

        For Each DrDato As DataRow In DtExcel.Rows
            GenericSql = "INSERT INTO Marcas VALUES (@IdMarca, @Marca, @Activo )"
            CrearComando(GenericSql)
            'End If

            With Comando.Parameters
                .AddWithValue("IdMarca", DrDato!IdMarca)
                .AddWithValue("Marca", DrDato!Marca)
                .AddWithValue("Activo", True)
            End With
            Guardados = EjecutarComando()


        Next
        If Guardados Then
            XtraMessageBox.Show("Los registros se han importado correctamente", "Datos Importados", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            XtraMessageBox.Show("Los registros no se importaron correctamente. Proceda a verificar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If
        txtRuta.Focus()
        Exit Sub
tipoerr:
        XtraMessageBox.Show(Err.Description, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub



    Private Sub ChkMarcaActiva_CheckedChanged(sender As Object, e As EventArgs)
        txthoja.Focus()
    End Sub

#End Region


    Private Sub btnExportar_Click(sender As Object, e As EventArgs) Handles btnExportar.Click
        If IsNothing(TreeCatalogos.FocusedNode.GetValue(0)) Then Exit Sub
        ExportarFormato()
    End Sub

    Private Sub ExportarFormato()
        On Error GoTo tipoerr
        Dim FDB As New FolderBrowserDialog
        Dim Path As String
        Dim Obj_Excel As Excel.Application
        Dim Obj_Libro As Excel.Workbook
        Dim Obj_Hoja As Excel.Worksheet

        FDB.ShowNewFolderButton = True
        FDB.RootFolder = Environment.SpecialFolder.DesktopDirectory

        If FDB.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Me.Cursor = Cursors.WaitCursor
            Path = FDB.SelectedPath

            If Path = "C:\" Or Path = "D:\" Or Path = "E:\" Or Path = "F:\" Then
                Path += TreeCatalogos.FocusedNode.GetValue(0).ToString + ".xlsx"
            Else
                Path += "\" + TreeCatalogos.FocusedNode.GetValue(0).ToString + ".xlsx"
            End If
        End If

        Obj_Excel = CreateObject("Excel.Application")
        Obj_Libro = Obj_Excel.Workbooks.Add
        Obj_Hoja = Obj_Libro.ActiveSheet

        CrearTablaExcel()

        For i As Integer = 1 To DtExcel.Columns.Count
            Obj_Hoja.Cells(1, i) = DtExcel.Columns(i - 1).Caption
        Next
        With Obj_Hoja
            .Rows.Font.Bold = True
            .Columns.AutoFit()
        End With
        Obj_Libro.SaveAs(Path)
        Obj_Excel.Visible = True
        Obj_Hoja = Nothing
        Obj_Libro = Nothing
        Obj_Excel = Nothing

        Me.Cursor = Cursors.Default
        'Select Case TreeCatalogos.FocusedNode.GetValue(0).ToString
        '    Case "Sucursales"
        '        'EliminarUsuario()
        '    Case "Usuarios"
        '    Case "Proveedores"
        '    Case "Vendedores"
        '    Case "Clientes"
        '    Case "Marcas"
        '    Case "Categorías de Productos"
        '    Case "Tipo de Ajuste"
        '    Case "Productos"

        '    Case Else
        'End Select
        Exit Sub
tipoerr:
        XtraMessageBox.Show(Err.Description, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

    Private Sub CrearTablaExcel()
        DtExcel = New DataTable
        DtExcel.Columns.Add("Linea", GetType(Integer))
        Select Case TreeCatalogos.FocusedNode.GetValue(0).ToString
            Case "Sucursales"
                DtExcel.Columns.Add("IdSucursal", GetType(String))
                DtExcel.Columns.Add("Sucursal", GetType(String))
                DtExcel.Columns.Add("Direccion", GetType(String))
                DtExcel.Columns.Add("NumCompra", GetType(String))
                DtExcel.Columns.Add("NumRemision", GetType(String))
                DtExcel.Columns.Add("NumVenta", GetType(String))
                DtExcel.Columns.Add("NumAjuste", GetType(String))
            Case "Usuarios"
                DtExcel.Columns.Add("IDUsuario", GetType(String))
                DtExcel.Columns.Add("IdSucursal", GetType(String))
                DtExcel.Columns.Add("Nombre", GetType(String))
                DtExcel.Columns.Add("Clave", GetType(String))
            Case "Proveedores"
                DtExcel.Columns.Add("IdProveedor", GetType(String))
                DtExcel.Columns.Add("Proveedor", GetType(String))
                DtExcel.Columns.Add("Telefono", GetType(String))
                DtExcel.Columns.Add("Direccion", GetType(String))
                DtExcel.Columns.Add("CedulaRUC", GetType(String))
                DtExcel.Columns.Add("Correo", GetType(String))

            Case "Vendedores"
                DtExcel.Columns.Add("IdVendedor", GetType(String))
                DtExcel.Columns.Add("Nombres", GetType(String))
                DtExcel.Columns.Add("Apellidos", GetType(String))
                DtExcel.Columns.Add("Telefono", GetType(String))
                DtExcel.Columns.Add("Direccion", GetType(String))
                DtExcel.Columns.Add("Cedula", GetType(String))
                DtExcel.Columns.Add("Correo", GetType(String))
            Case "Clientes"
                DtExcel.Columns.Add("IdCliente", GetType(String))
                DtExcel.Columns.Add("Nombres", GetType(String))
                DtExcel.Columns.Add("Apellidos", GetType(String))
                DtExcel.Columns.Add("Telefono", GetType(String))
                DtExcel.Columns.Add("Direccion", GetType(String))
                DtExcel.Columns.Add("CedulaRUC", GetType(String))
                DtExcel.Columns.Add("Correo", GetType(String))
                DtExcel.Columns.Add("Exonerado", GetType(Boolean))
            Case "Marcas"
                DtExcel.Columns.Add("IdMarca", GetType(String))
                DtExcel.Columns.Add("Marca", GetType(String))
            Case "Categorías de Productos"
                DtExcel.Columns.Add("IdCategoria", GetType(String))
                DtExcel.Columns.Add("Categoria", GetType(String))
                DtExcel.Columns.Add("PorcUtilidad1", GetType(Double))
                DtExcel.Columns.Add("PorcUtilidad2", GetType(Double))
                DtExcel.Columns.Add("PorcUtilidad3", GetType(Double))
                DtExcel.Columns.Add("PorcComision", GetType(Double))
            Case "Tipo de Ajuste"
                DtExcel.Columns.Add("IdTipo", GetType(String))
                DtExcel.Columns.Add("TipoAjuste", GetType(String))
                DtExcel.Columns.Add("Valor", GetType(Integer))
            Case "Productos"
                DtExcel.Columns.Add("IdProducto", GetType(String))
                DtExcel.Columns.Add("Producto", GetType(String))
                DtExcel.Columns.Add("IdCategoria", GetType(String))
                DtExcel.Columns.Add("IdMarca", GetType(String))
                DtExcel.Columns.Add("Servicio", GetType(Boolean))
                DtExcel.Columns.Add("Moneda", GetType(String))
                DtExcel.Columns.Add("Costo", GetType(Double))
                DtExcel.Columns.Add("Precio1", GetType(Double))
                DtExcel.Columns.Add("Precio2", GetType(Double))
                DtExcel.Columns.Add("Precio3", GetType(Double))
            Case Else
        End Select

    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        'On Error GoTo tipoerr
        Dim Ruta As String
        Dim SQL As String
        Dim MiConexion As OleDb.OleDbConnection

        If txtRuta.Text = "" Or txthoja.Text = "" Then
            DevExpress.XtraEditors.XtraMessageBox.Show("Debe rellenar todos los campos", "Campos vacíos")
            Exit Sub
        End If
        CrearTablaExcel()

        ListErrores.Items.Clear()
        btnGuardar.Enabled = False

        Ruta = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" & Me.txtRuta.Text & "; Extended Properties= Excel 8.0"
        SQL = "Select * from [" + txthoja.Text + "$]"
        Try
            MiConexion = New OleDb.OleDbConnection(Ruta)
            MiConexion.Open()
            Dim MiAdapter As New OleDb.OleDbDataAdapter(SQL, MiConexion)
            MiAdapter.Fill(DtExcel)
            MiConexion.Close()
            MiConexion.Dispose()
        Catch ex As Exception

        End Try
        gcRegistros.DataSource = DtExcel
        EnumerarLineas()
        Exit Sub
        'tipoerr:
        '        XtraMessageBox.Show(Err.Description, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

    End Sub
    Private Sub EnumerarLineas()
        Dim i As Integer = 0
        For Each DrFila As DataRow In DtExcel.Rows
            DrFila!Linea = i + 1
            i += 1
        Next

    End Sub
    Private Sub ValidarDatos()
        On Error GoTo tipoerr
        Dim Archivo As String = TreeCatalogos.FocusedNode.GetValue(0).ToString
        If DtExcel.Rows.Count = 0 Then
            XtraMessageBox.Show("La tabla no contiene registros", "Importación de " + Archivo, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        Select Case Archivo
            Case "Sucursales" 'Primero valido que exista la columna del IdSucursal
                If DtExcel.Columns(1).ColumnName.ToString.Trim <> "IdSucursal" Then
                    XtraMessageBox.Show("La tabla no contiene la columna IdSucursal", "Importación de " + Archivo, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
                'Valido los datos
                For Each DrExcel As DataRow In DtExcel.Rows
                    If BuscarRegistroSql(Archivo, "IdSucursal", "IdSucursal", DrExcel!IdSucursal.ToString) <> "" Then
                        AgregarLineaError(DrExcel!Linea.ToString, "El código de Sucursal ya existe en la BD.")
                    End If

                    If BuscarRegistroSql(Archivo, "Sucursal", "Sucursal", DrExcel!Marca.ToString) <> "" Then
                        AgregarLineaError(DrExcel!Linea.ToString, "El registro de Sucursal ya existe en la BD.")
                    End If
                Next
            Case "Usuarios"
                'Primero valido que exista la columna del IdUsuario
                If DtExcel.Columns(1).ColumnName.ToString.Trim <> "IdUsuario" Then
                    XtraMessageBox.Show("La tabla no contiene la columna IdUsuario", "Importación de " + Archivo, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
                'Valido los datos
                For Each DrExcel As DataRow In DtExcel.Rows
                    If BuscarRegistroSql(Archivo, "IdUsuario", "IdUsuario", DrExcel!IdUsuario.ToString) <> "" Then
                        AgregarLineaError(DrExcel!Linea.ToString, "El código de usuario ya existe en la BD.")
                    End If

                    If DrExcel!IdSucursal.ToString.Trim = "" Then
                        AgregarLineaError(DrExcel!Linea.ToString, "La sucursal del usuario debe ser especificada.")

                    End If
                    If BuscarRegistroSql("Sucursales", "IdSucursal", "IdSucursal", DrExcel!IdSucursal.ToString) = "" Then
                        AgregarLineaError(DrExcel!Linea.ToString, "El registro de Sucursal asociada no existe en la BD.")
                    End If
                    If DrExcel!Nombre.ToString.Trim = "" Then
                        AgregarLineaError(DrExcel!Linea.ToString, "El nombre de usuario no puede quedar vacío.")
                    End If
                    If BuscarRegistroSql("Archivo", "IdUsuario", "IdUsuario", DrExcel!IdUsuario.ToString) = "" Then
                        AgregarLineaError(DrExcel!Linea.ToString, "El nombre de usuario ya existe en la BD.")
                    End If

                Next
            Case "Proveedores"
                'Primero valido que exista la columna del IdProveedor
                If DtExcel.Columns(1).ColumnName.ToString.Trim <> "IdProveedor" Then
                    XtraMessageBox.Show("La tabla no contiene la columna IdProveedor", "Importación de " + Archivo, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
                'Valido los datos
                For Each DrExcel As DataRow In DtExcel.Rows
                    If BuscarRegistroSql(Archivo, "IdProveedor", "IdProveedor", DrExcel!IdProveedor.ToString) <> "" Then
                        AgregarLineaError(DrExcel!Linea.ToString, "El código de proveedor ya existe en la BD.")
                    End If

                    If DrExcel!Proveedor.ToString.Trim = "" Then
                        AgregarLineaError(DrExcel!Linea.ToString, "El nombre de proveedor no puede quedar vacío.")
                    End If
                    If DrExcel!CedulaRUC.ToString.Trim = "" Then
                        AgregarLineaError(DrExcel!Linea.ToString, "La cédula RUC del proveedor no puede quedar vacía.")
                    End If
                    If DrExcel!Telefono.ToString.Trim = "" Then
                        AgregarLineaError(DrExcel!Linea.ToString, "El teléfono del proveedor no puede quedar vacío.")
                    End If

                Next
            Case "Vendedores"
                'Primero valido que exista la columna del IdProveedor
                If DtExcel.Columns(1).ColumnName.ToString.Trim <> "IdVendedor" Then
                    XtraMessageBox.Show("La tabla no contiene la columna IdVendedor", "Importación de " + Archivo, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
                'Valido los datos
                For Each DrExcel As DataRow In DtExcel.Rows
                    If BuscarRegistroSql(Archivo, "IdProveedor", "IdProveedor", DrExcel!IdProveedor.ToString) <> "" Then
                        AgregarLineaError(DrExcel!Linea.ToString, "El código de proveedor ya existe en la BD.")
                    End If

                    If DrExcel!Proveedor.ToString.Trim = "" Then
                        AgregarLineaError(DrExcel!Linea.ToString, "El nombre de proveedor no puede quedar vacío.")
                    End If
                    If DrExcel!CedulaRUC.ToString.Trim = "" Then
                        AgregarLineaError(DrExcel!Linea.ToString, "La cédula RUC del proveedor no puede quedar vacía.")
                    End If
                    If DrExcel!Telefono.ToString.Trim = "" Then
                        AgregarLineaError(DrExcel!Linea.ToString, "El teléfono del proveedor no puede quedar vacío.")
                    End If

                Next
            Case "Clientes"
            Case "Marcas"
                'Primero valido que exista la columna del IdMarca
                If DtExcel.Columns(1).ColumnName.ToString.Trim <> "IdMarca" Then
                    XtraMessageBox.Show("La tabla no contiene la columna IdMarca", "Importación de " + Archivo, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
                'Valido los datos
                For Each DrExcel As DataRow In DtExcel.Rows
                    If BuscarRegistroSql(Archivo, "IdMarca", "IdMarca", DrExcel!IdMarca.ToString) <> "" Then
                        ListErrores.Items.Add("Linea " + DrExcel!Linea.ToString + ": El código de marca ya existe en la BD.")
                    End If

                    If BuscarRegistroSql(Archivo, "Marca", "Marca", DrExcel!Marca.ToString) <> "" Then
                        ListErrores.Items.Add("Linea " + DrExcel!Linea.ToString + ": El registro de marca ya existe en la BD.")
                    End If
                Next
            Case "Categorías de Productos"
            Case "Tipo de Ajuste"
            Case "Productos"

            Case Else
        End Select
        If ListErrores.Items.Count = 0 Then
            btnGuardar.Enabled = True
            XtraMessageBox.Show("Los datos han sido validados exitosamente. Puede proceder a guardarlos", "Importación de " + Archivo, MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            XtraMessageBox.Show("Se encontraron inconsistencias en la validación de datos. Proceda a verificarlos en la lista de errores", "Importación de " + Archivo, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            XTPCatalogos.SelectedTabPage = XTPErrores
        End If
        Exit Sub
tipoerr:
        XtraMessageBox.Show(Err.Description, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

    End Sub

    Private Sub AgregarLineaError(ByVal noLinea As String, ByVal mensaje As String)
        ListErrores.Items.Add(String.Format("Linea {0}: {1}", noLinea, mensaje))
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim OFD As New OpenFileDialog()
        'OFD.ShowNewFolderButton = True
        OFD.InitialDirectory = Environment.SpecialFolder.DesktopDirectory.ToString
        'OFD.Filter=""
        If OFD.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Me.Cursor = Cursors.WaitCursor
            If Not OFD.CheckPathExists() Then
                XtraMessageBox.Show("Seleccione otra ruta de acceso.", "Ruta no válida", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            If Not OFD.CheckFileExists() Then
                XtraMessageBox.Show("Seleccione un archivo válido.", "Archivo no válido", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

            txtRuta.Text = OFD.FileName
        End If
    End Sub


    Private Sub btnValidar_Click(sender As Object, e As EventArgs) Handles btnValidar.Click
        ListErrores.Items.Clear()
        ValidarDatos()
    End Sub
End Class