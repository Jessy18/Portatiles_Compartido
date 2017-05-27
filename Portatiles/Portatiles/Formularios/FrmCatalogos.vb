Imports DevExpress.XtraEditors
Imports DevExpress.XtraTreeList.Nodes


Public Class FrmCatalogos

    Private Sub FrmCatalogos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarArbolReportes()

        For Each page As DevExpress.XtraTab.XtraTabPage In XTPCatalogos.TabPages
            page.PageVisible = False
        Next

        XTPCatalogos.TabPages(0).PageVisible = True

        'Cargamos todos los LOAD de los catalogos
        LoadUsuarios()
        LoadMarcas()
        LoadCategorias()
        LoadTipoAjustes()
        LoadSucursales()
        LoadProveedores()
        LoadVendedores()
        LoadClientes()
        LoadProductos()
    End Sub


    Private Sub CargarArbolReportes()
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
        Dim RootNodo As TreeListNode = TreeCatalogos.AppendNode(New Object() {"Usuarios"}, ParentNodo)
        Dim RootNodo2 As TreeListNode = TreeCatalogos.AppendNode(New Object() {"Marcas"}, ParentNodo)
        Dim RootNodo3 As TreeListNode = TreeCatalogos.AppendNode(New Object() {"Categorías de Productos"}, ParentNodo)
        Dim RootNodo4 As TreeListNode = TreeCatalogos.AppendNode(New Object() {"Tipo de Ajuste"}, ParentNodo)
        Dim RootNodo5 As TreeListNode = TreeCatalogos.AppendNode(New Object() {"Sucursales"}, ParentNodo)
        Dim RootNodo6 As TreeListNode = TreeCatalogos.AppendNode(New Object() {"Proveedores"}, ParentNodo)
        Dim RootNodo7 As TreeListNode = TreeCatalogos.AppendNode(New Object() {"Vendedores"}, ParentNodo)
        Dim RootNodo8 As TreeListNode = TreeCatalogos.AppendNode(New Object() {"Clientes"}, ParentNodo)
        Dim RootNodo9 As TreeListNode = TreeCatalogos.AppendNode(New Object() {"Productos"}, ParentNodo)


        TreeCatalogos.EndUnboundLoad()
        TreeCatalogos.ExpandAll()

    End Sub

    Private Sub MuestraPestanaSeleccionada(ByVal NombrePestana As String)

        For Each Page As DevExpress.XtraTab.XtraTabPage In XTPCatalogos.TabPages
            'If Page.Text = NombrePestana Then
            If String.Compare(Page.Text, NombrePestana) = 0 Then

                Page.PageVisible = True
                LblTitulo.Text = "Catálogo de " & NombrePestana
            Else
                Page.PageVisible = False
            End If

        Next
    End Sub

    Private Sub TreeCatalogos_FocusedNodeChanged(sender As Object, e As DevExpress.XtraTreeList.FocusedNodeChangedEventArgs) Handles TreeCatalogos.FocusedNodeChanged
        If Not IsNothing(TreeCatalogos.FocusedNode.GetValue(0)) Then
            XTPCatalogos.Visible = True
            MuestraPestanaSeleccionada(TreeCatalogos.FocusedNode.GetValue(0).ToString())
        Else
            For Each page As DevExpress.XtraTab.XtraTabPage In XTPCatalogos.TabPages
                page.PageVisible = False
            Next
            LblTitulo.Text = "Catálogos"
            XTPCatalogos.Visible = False
        End If

    End Sub


    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        If IsNothing(TreeCatalogos.FocusedNode.GetValue(0)) Then Exit Sub

        Select Case TreeCatalogos.FocusedNode.GetValue(0).ToString
            Case "Usuarios"
                NuevoCodigoUsuario()
            Case "Marcas"
                NuevoCodigoMarcas()
            Case "Categorías de Productos"
                NuevoCodigoCategoria()
            Case "Tipo de Ajuste"
                NuevoCodigoTipoAjuste()
            Case "Sucursales"
                NuevoCodigoSucursal()
            Case "Proveedores"
                NuevoCodigoProveedor()
            Case "Vendedores"
                NuevoCodigoVendedor()
            Case "Clientes"
                NuevoCodigoCliente()
            Case "Productos"
                NuevoCodigoProducto()
            Case Else
        End Select
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If IsNothing(TreeCatalogos.FocusedNode.GetValue(0)) Then Exit Sub

        Select Case TreeCatalogos.FocusedNode.GetValue(0).ToString
            Case "Usuarios"
                GuardarUsuario()
            Case "Marcas"
                GuardarMarca()
            Case "Categorías de Productos"
                GuardarCategoria()
            Case "Tipo de Ajuste"
                GuardarTipoAjuste()
            Case "Sucursales"
                GuardarSucursal()
            Case "Proveedores"
                GuardarProveedor()
            Case "Vendedores"
                GuardarVendedor()
            Case "Clientes"
                GuardarCliente()
            Case "Productos"
                GuardarProducto()
            Case Else
        End Select
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If IsNothing(TreeCatalogos.FocusedNode.GetValue(0)) Then Exit Sub

        Select Case TreeCatalogos.FocusedNode.GetValue(0).ToString
            Case "Usuarios"
                EliminarUsuario()
            Case "Idiomas"
                EliminarMarca()
            Case "Categorías de Productos"
                EliminarCategoria()
            Case "Tipo de Ajuste"
                EliminarTipoAjuste()
            Case "Sucursales"
                EliminarSucursal()
            Case "Proveedores"
                EliminarProveedor()
            Case "Vendedores"
                EliminarVendedor()
            Case "Clientes"
                EliminarCliente()
            Case "Productos"
                EliminarProducto()
            Case Else
        End Select
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Dispose()
        Me.Close()
    End Sub


    ' PROGRAMACION DEL CATALOGO DE USUARIOS  
#Region "PROGRAMACION DEL CATALOGO DE USUARIOS"

    Private Sub LoadUsuarios()
        On Error GoTo tipoerr
        gcUsuarios.DataSource = BusquedaSeleccion("Select IdUsuario, Nombre From Usuarios order by IdUsuario")
        lueSucursalUsuario.Properties.DataSource = BusquedaSeleccion("Select IdSucursal, Sucursal from Sucursales")
        lueSucursalUsuario.Properties.ValueMember = "IdSucursal"
        lueSucursalUsuario.Properties.DisplayMember = "Sucursal"

        LimpiarCamposUsuarios(True)
        Application.DoEvents()

        Exit Sub
tipoerr:
        XtraMessageBox.Show(Err.Description, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

    Private Sub LimpiarCamposUsuarios(ByVal limpiarcodigo As Boolean)
        If limpiarcodigo Then TxtIdIUsuario.Text = ""
        txtUsuario.Text = ""
        txtClave.Text = ""
        lueSucursalUsuario.EditValue = ""
    End Sub

    Private Sub NuevoCodigoUsuario()
        On Error GoTo tipoerr
        LimpiarCamposUsuarios(True)
        TxtIdIUsuario.Text = CodigoNuevo("Usuarios", "IdUsuario", 3)
        txtUsuario.Focus()
        Exit Sub
tipoerr:
        XtraMessageBox.Show(Err.Description, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

    Private Function ValidarDatosUsuario() As Boolean
        ValidarDatosUsuario = True
        If TxtIdIUsuario.Text.Trim = "" Then
            XtraMessageBox.Show("El código de usuario no puede quedar vacío", "Validar Datos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ValidarDatosUsuario = False
            Exit Function
        End If

        If txtUsuario.Text.Trim = "" Then
            XtraMessageBox.Show("El nombre de usuario no puede quedar vacío", "Validar Datos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ValidarDatosUsuario = False
            Exit Function
        End If

        If txtClave.Text.Trim = "" Then
            XtraMessageBox.Show("El contraseña no puede quedar vacía", "Validar Datos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ValidarDatosUsuario = False
            Exit Function
        End If

    End Function

    Private Sub GuardarUsuario()
        On Error GoTo tipoerr

        If Not ValidarDatosUsuario() Then Exit Sub

        If BuscarRegistroSql("Usuarios", "IdUsuario", "IdUsuario", TxtIdIUsuario.Text) = "" Then
            ExisteRegistro = False
        Else
            ExisteRegistro = True
        End If

        If ExisteRegistro Then
            CrearComando("UPDATE Usuarios SET IdSucursal = @IdSucursal, Nombre=@Nombre, Clave=@Clave, Activo=@Activo, Administrador=@Administrador WHERE IDUsuario = @IDUsuario")
        Else
            GenericSql = "INSERT INTO Usuarios (IDUsuario, IdSucursal, Nombre, Clave, Activo, Administrador ) VALUES  (@IDUsuario, @IdSucursal, @Nombre, @Clave, @Activo, @Administrador )"
            CrearComando(GenericSql)
        End If

        With Comando.Parameters
            .AddWithValue("IDUsuario", TxtIdIUsuario.Text)
            .AddWithValue("IdSucursal", lueSucursalUsuario.EditValue.ToString)
            .AddWithValue("Nombre", txtUsuario.Text.Trim)
            .AddWithValue("Clave", txtClave.Text)
            .AddWithValue("Activo", ChkUsuarioActivo.Checked)
            .AddWithValue("Administrador", ChkUsuarioAdministrador.Checked)

        End With
        If EjecutarComando() Then
            XtraMessageBox.Show("El Registro se ha guardado correctamente", "Datos Almacenados", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        HADatosNEW = "IDUsuario: " & TxtIdIUsuario.Text & " | " & _
                      "IdSucursal: " & lueSucursalUsuario.EditValue.ToString & " | " & _
                      "Nombre: " & txtUsuario.Text & " | " & _
                      "Clave: " & txtClave.Text.ToString & " | " & _
                      "Activo: " & ChkUsuarioActivo.Checked.ToString & " | " & _
                      "Administrador: " & ChkUsuarioAdministrador.Checked.ToString


        If ExisteRegistro Then
            GuardarHistorialAccion("Actualizar", "Usuarios", TxtIdIUsuario.Text, HADatosOLD, HADatosNEW)
        Else
            GuardarHistorialAccion("Insertar", "Usuarios", TxtIdIUsuario.Text, "", HADatosNEW)
        End If

        LoadUsuarios()
        TxtIdIUsuario.Focus()
        Exit Sub
tipoerr:
        XtraMessageBox.Show(Err.Description, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

    Private Sub EliminarUsuario()
        On Error GoTo tipoerr

        If BuscarRegistroSql("Usuarios", "IDUsuario", "IDUsuario", TxtIdIUsuario.Text) = "" Then
            XtraMessageBox.Show("El Registro que desea eliminar no existe!", "Registro inexistente", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        ResultMsg = XtraMessageBox.Show("¿Desea eliminar el registro: " & txtUsuario.Text.Trim & "?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If ResultMsg <> vbYes Then Exit Sub

        GenericSql = "DELETE FROM Usuarios WHERE IDUsuario= '" & TxtIdIUsuario.Text.Trim & "'"
        If EjecutarConsulta(GenericSql) Then
            XtraMessageBox.Show("El Registro se ha eliminado correctamente", "Datos Eliminados", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If 'xrs
        LoadUsuarios()
        TxtIdIUsuario.Focus()
        Exit Sub
tipoerr:
        XtraMessageBox.Show(Err.Description, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

    Private Sub CargarDatosUsuario()
        On Error GoTo tipoerr

        LimpiarCamposUsuarios(False) 'limpiamos los campos menos el código
        GenericRow = BusquedaSeleccionFila("Select * From Usuarios WHERE IDUsuario = '" & TxtIdIUsuario.Text & "'")
        If Not IsNothing(GenericRow) Then
            txtUsuario.Text = Trim(GenericRow!Nombre.ToString)
            txtClave.Text = GenericRow!Clave.ToString
            lueSucursalUsuario.EditValue = GenericRow!IdSucursal
            ChkUsuarioActivo.Checked = CBool(GenericRow!Activo)
            ChkUsuarioAdministrador.Checked = CBool(GenericRow!Administrador)
            HADatosOLD = CrearHADatosOLD(GenericRow)
        End If

        Exit Sub
tipoerr:
        XtraMessageBox.Show(Err.Description, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

    Private Sub TxtIdIUsuario_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtIdIUsuario.KeyPress
        If Asc(e.KeyChar) = 13 Then
            CargarDatosUsuario()
            txtUsuario.Focus()
        Else
            ValidarNumeroEntero(TxtIdIUsuario.Text, e)
        End If
    End Sub

    Private Sub TxtIdIUsuario_TextChanged(sender As Object, e As EventArgs) Handles TxtIdIUsuario.TextChanged
        CargarDatosUsuario()
    End Sub

    Private Sub txtUsuario_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUsuario.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtClave.Focus()
        End If
    End Sub

    Private Sub gvUsuarios_DoubleClick(sender As Object, e As EventArgs) Handles gvUsuarios.DoubleClick
        If gvUsuarios.RowCount = 0 Then Exit Sub
        TxtIdIUsuario.Text = gvUsuarios.GetFocusedDataRow.Item("IdUsuario").ToString
    End Sub

    Private Sub gvUsuarios_KeyUp(sender As Object, e As KeyEventArgs) Handles gvUsuarios.KeyUp
        If gvUsuarios.RowCount = 0 Then Exit Sub
        TxtIdIUsuario.Text = gvUsuarios.GetFocusedDataRow.Item("IdUsuario").ToString
    End Sub
    Private Sub txtClave_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtClave.KeyPress
        If Asc(e.KeyChar) = 13 Then
            ChkUsuarioActivo.Focus()
        End If
    End Sub

#End Region

    ' PROGRAMACION DEL CATALOGO DE MARCAS 
#Region "PROGRAMACION DEL CATALOGO DE MARCAS"

    Private Sub LoadMarcas()
        On Error GoTo tipoerr
        gcMarcas.DataSource = BusquedaSeleccion("Select * From Marcas order by IdMarca ")
        LimpiarCamposMarcas(True)
        Application.DoEvents()

        Exit Sub
tipoerr:
        XtraMessageBox.Show(Err.Description, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

    Private Sub LimpiarCamposMarcas(ByVal limpiarcodigo As Boolean)
        If limpiarcodigo Then txtIdMarca.Text = ""
        txtMarca.Text = ""
        ChkMarcaActiva.Checked = False
    End Sub

    Private Sub NuevoCodigoMarcas()
        On Error GoTo tipoerr
        LimpiarCamposMarcas(True)
        txtIdMarca.Text = CodigoNuevo("Marcas", "IdMarca", 3)
        txtMarca.Focus()
        Exit Sub
tipoerr:
        XtraMessageBox.Show(Err.Description, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

    Private Function ValidarDatosMarcas() As Boolean
        ValidarDatosMarcas = True
        If txtIdMarca.Text.Trim = "" Then
            XtraMessageBox.Show("El código de la marca no puede quedar vacío", "Validar Datos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ValidarDatosMarcas = False
            Exit Function
        End If

        If txtMarca.Text.Trim = "" Then
            XtraMessageBox.Show("El nombre de la marca no puede quedar vacío", "Validar Datos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ValidarDatosMarcas = False
            Exit Function
        End If
    End Function

    Private Sub GuardarMarca()
        On Error GoTo tipoerr

        If Not ValidarDatosMarcas() Then Exit Sub

        If BuscarRegistroSql("Marcas", "IdMarca", "IdMarca", txtIdMarca.Text) = "" Then
            ExisteRegistro = False
        Else
            ExisteRegistro = True
        End If

        If ExisteRegistro Then
            CrearComando("UPDATE Marcas SET Marca= @Marca, Activo=@Activo WHERE IdMarca = @IdMarca ")
        Else
            GenericSql = "INSERT INTO Marcas VALUES (@IdMarca, @Marca, @Activo )"
            CrearComando(GenericSql)
        End If

        With Comando.Parameters
            .AddWithValue("IdMarca", txtIdMarca.Text)
            .AddWithValue("Marca", txtMarca.Text.Trim)
            .AddWithValue("Activo", Me.ChkMarcaActiva.Checked)
        End With
        If EjecutarComando() Then
            XtraMessageBox.Show("El Registro se ha guardado correctamente", "Datos Almacenados", MessageBoxButtons.OK, MessageBoxIcon.Information)
            HADatosNEW = "IdMarca: " & txtIdMarca.Text & " | " & _
                     "Marca: " & txtMarca.Text.Trim & " | " & _
                     "Activo: " & Me.ChkMarcaActiva.Checked.ToString

            If ExisteRegistro Then
                GuardarHistorialAccion("Actualizar", "Marcas", txtIdMarca.Text, HADatosOLD, HADatosNEW)
            Else
                GuardarHistorialAccion("Insertar", "Marcas", txtIdMarca.Text, "", HADatosNEW)
            End If
        End If

        LoadMarcas()
        txtIdMarca.Focus()
        Exit Sub
tipoerr:
        XtraMessageBox.Show(Err.Description, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

    Private Sub EliminarMarca()
        On Error GoTo tipoerr

        If BuscarRegistroSql("Marcas", "IdMarca", "IdMarca", txtIdMarca.Text) = "" Then
            XtraMessageBox.Show("El Registro que desea eliminar no existe!", "Registro inexistente", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        ResultMsg = XtraMessageBox.Show("¿Desea eliminar el registro: " & txtMarca.Text.Trim & "?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If ResultMsg <> vbYes Then Exit Sub

        GenericSql = "DELETE FROM Marcas WHERE IdMarca= '" & txtIdMarca.Text.Trim & "'"
        If EjecutarConsulta(GenericSql) Then
            XtraMessageBox.Show("El Registro se ha eliminado correctamente", "Datos Eliminados", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        LoadMarcas()
        txtIdMarca.Focus()
        Exit Sub
tipoerr:
        XtraMessageBox.Show(Err.Description, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

    Private Sub CargarDatosMarca()
        On Error GoTo tipoerr

        LimpiarCamposMarcas(False) 'limpiamos los campos menos el código
        GenericRow = BusquedaSeleccionFila("Select * From Marcas WHERE IdMarca= '" & txtIdMarca.Text & "'")
        If Not IsNothing(GenericRow) Then
            txtMarca.Text = Trim(GenericRow!Marca.ToString)
            ChkMarcaActiva.Checked = CBool(GenericRow!Activo)
            HADatosOLD = CrearHADatosOLD(GenericRow)
        End If

        Exit Sub
tipoerr:
        XtraMessageBox.Show(Err.Description, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

    Private Sub TxtCodIdioma_TextChanged(sender As Object, e As EventArgs) Handles txtIdMarca.TextChanged
        CargarDatosMarca()
    End Sub
    Private Sub txtMarca_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMarca.KeyPress
        If Asc(e.KeyChar) = 13 Then
            btnGuardar.PerformClick()
        End If
    End Sub

    Private Sub gvIdiomas_DoubleClick(sender As Object, e As EventArgs) Handles gvMarcas.DoubleClick
        If gvMarcas.RowCount = 0 Then Exit Sub
        txtIdMarca.Text = gvMarcas.GetFocusedDataRow.Item("IdMarca").ToString
    End Sub

    Private Sub gvIdiomas_KeyUp(sender As Object, e As KeyEventArgs) Handles gvMarcas.KeyUp
        If gvMarcas.RowCount = 0 Then Exit Sub
        txtIdMarca.Text = gvMarcas.GetFocusedDataRow.Item("IdMarca").ToString
    End Sub

    Private Sub txtIdMarca_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtIdMarca.KeyPress
        If Asc(e.KeyChar) = 13 Then
            CargarDatosMarca()
            ChkMarcaActiva.Focus()
        Else
            ValidarNumeroEntero(txtIdMarca.Text, e)
        End If
    End Sub

    Private Sub ChkMarcaActiva_CheckedChanged(sender As Object, e As EventArgs) Handles ChkMarcaActiva.CheckedChanged
        txtMarca.Focus()
    End Sub

#End Region

    ' PROGRAMACION DEL CATALOGO DE CATEGORIA DE PRODUCTOS 
#Region "PROGRAMACION DEL CATALOGO DE CATEGORIA"

    Private Sub LoadCategorias()
        On Error GoTo tipoerr
        gcCategorias.DataSource = BusquedaSeleccion("Select IdCategoria, Categoria From CategoriaProducto order by IdCategoria ")
        LimpiarCamposCategoria(True)
        Application.DoEvents()

        Exit Sub
tipoerr:
        XtraMessageBox.Show(Err.Description, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

    Private Sub LimpiarCamposCategoria(ByVal limpiarcodigo As Boolean)
        If limpiarcodigo Then TxtIdCategoria.Text = ""
        txtCategoria.Text = ""
        txtPUtilidad1.Text = "0.0"
        txtPUtilidad2.Text = "0.0"
        txtPUtilidad3.Text = "0.0"
        txtComision.Text = "0.0"
        ChkCategoriaActiva.Checked = False
    End Sub

    Private Sub NuevoCodigoCategoria()
        On Error GoTo tipoerr
        LimpiarCamposCategoria(True)
        TxtIdCategoria.Text = CodigoNuevo("CategoriaProducto", "IdCategoria", 3)
        txtCategoria.Focus()
        Exit Sub
tipoerr:
        XtraMessageBox.Show(Err.Description, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

    Private Function ValidarDatosCategoria() As Boolean
        ValidarDatosCategoria = True
        If TxtIdCategoria.Text.Trim = "" Then
            XtraMessageBox.Show("El código de la categoría no puede quedar vacío", "Validar Datos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ValidarDatosCategoria = False
            Exit Function
        End If

        If txtCategoria.Text.Trim = "" Then
            XtraMessageBox.Show("El nombre de la categoria no puede quedar vacío", "Validar Datos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ValidarDatosCategoria = False
            Exit Function
        End If

        If txtPUtilidad1.Text.Trim = "" Then
            XtraMessageBox.Show("El porcentaje no puede quedar vacío", "Validar Datos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ValidarDatosCategoria = False
            Exit Function
        End If

        If txtPUtilidad2.Text.Trim = "" Then
            XtraMessageBox.Show("El porcentaje no puede quedar vacío", "Validar Datos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ValidarDatosCategoria = False
            Exit Function
        End If

        If txtPUtilidad3.Text.Trim = "" Then
            XtraMessageBox.Show("El porcentaje no puede quedar vacío", "Validar Datos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ValidarDatosCategoria = False
            Exit Function
        End If
        If txtComision.Text.Trim = "" Then
            XtraMessageBox.Show("El porcentaje de comisión no puede quedar vacío", "Validar Datos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ValidarDatosCategoria = False
            Exit Function
        End If

    End Function

    Private Sub GuardarCategoria()
        On Error GoTo tipoerr

        If Not ValidarDatosCategoria() Then Exit Sub

        If BuscarRegistroSql("CategoriaProducto", "IdCategoria", "IdCategoria", TxtIdCategoria.Text) = "" Then
            ExisteRegistro = False
        Else
            ExisteRegistro = True
        End If

        If ExisteRegistro Then
            CrearComando("UPDATE CategoriaProducto SET Categoria = @Categoria, PorcUtilidad1 = @PorcUtilidad1, PorcUtilidad2 = @PorcUtilidad2, PorcUtilidad3 = @PorcUtilidad3, PorcComision = @PorcComision, Activo = @Activo  WHERE IdCategoria = @IdCategoria ")
        Else
            GenericSql = "INSERT INTO CategoriaProducto (IdCategoria, Categoria, PorcUtilidad1, PorcUtilidad2, PorcUtilidad3, PorcComision, Activo) VALUES (@IdCategoria, @Categoria, @PorcUtilidad1, @PorcUtilidad2, @PorcUtilidad3, @PorcComision, @Activo) "
            CrearComando(GenericSql)
        End If

        With Comando.Parameters
            .AddWithValue("IdCategoria", TxtIdCategoria.Text)
            .AddWithValue("Categoria", txtCategoria.Text.Trim)
            .AddWithValue("PorcUtilidad1", CDbl(txtPUtilidad1.Text))
            .AddWithValue("PorcUtilidad2", CDbl(txtPUtilidad2.Text))
            .AddWithValue("PorcUtilidad3", CDbl(txtPUtilidad3.Text))
            .AddWithValue("PorcComision", CDbl(txtComision.Text))
            .AddWithValue("Activo", Me.ChkCategoriaActiva.Checked)
        End With
        If EjecutarComando() Then
            XtraMessageBox.Show("El Registro se ha guardado correctamente", "Datos Almacenados", MessageBoxButtons.OK, MessageBoxIcon.Information)

            HADatosNEW = "IdCategoria: " & TxtIdCategoria.Text & " | " & _
                         "Categoria: " & txtCategoria.Text.Trim & " | " & _
                         "PorcUtilidad1: " & CDbl(txtPUtilidad3.Text) & " | " & _
                         "PorcUtilidad2: " & CDbl(txtPUtilidad3.Text) & " | " & _
                         "PorcUtilidad3: " & CDbl(txtPUtilidad3.Text) & " | " & _
                         "PorcComision: " & CDbl(txtComision.Text) & " | " & _
                         "Activo: " & ChkCategoriaActiva.Checked.ToString

            If ExisteRegistro Then
                GuardarHistorialAccion("Actualizar", "Categorias de Producto", TxtIdCategoria.Text, HADatosOLD, HADatosNEW)
            Else
                GuardarHistorialAccion("Insertar", "Categorias de Producto", TxtIdCategoria.Text, "", HADatosNEW)
            End If
        End If

        LoadCategorias()
        txtIdMarca.Focus()
        Exit Sub
tipoerr:
        XtraMessageBox.Show(Err.Description, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

    Private Sub EliminarCategoria()
        On Error GoTo tipoerr

        If BuscarRegistroSql("CategoriaProducto", "IdCategoria", "IdCategoria", TxtIdCategoria.Text) = "" Then
            XtraMessageBox.Show("El Registro que desea eliminar no existe!", "Registro inexistente", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        If HayRegistrosAnidados("Productos", "IdCategoria", TxtIdCategoria.Text) Then
            XtraMessageBox.Show("El Registro que desea eliminar no existe!", "Registro inexistente", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        ResultMsg = XtraMessageBox.Show("¿Desea eliminar el registro: " & txtCategoria.Text.Trim & "?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If ResultMsg <> vbYes Then Exit Sub

        GenericSql = "DELETE FROM CategoriaProducto WHERE IdCategoria= '" & TxtIdCategoria.Text.Trim & "'"
        If EjecutarConsulta(GenericSql) Then
            XtraMessageBox.Show("El Registro se ha eliminado correctamente", "Datos Eliminados", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        LoadCategorias()
        TxtIdCategoria.Focus()
        Exit Sub
tipoerr:
        XtraMessageBox.Show(Err.Description, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

    Private Sub CargarDatosCategoria()
        On Error GoTo tipoerr

        LimpiarCamposCategoria(False) 'limpiamos los campos menos el código
        GenericRow = BusquedaSeleccionFila(String.Format("Select * From CategoriaProducto WHERE IdCategoria= '{0}'", TxtIdCategoria.Text))
        If Not IsNothing(GenericRow) Then
            txtCategoria.Text = Trim(GenericRow!Categoria.ToString)
            ChkCategoriaActiva.Checked = CBool(GenericRow!Activo)
            txtPUtilidad1.Text = GenericRow!PorcUtilidad1.ToString
            txtPUtilidad2.Text = GenericRow!PorcUtilidad2.ToString
            txtPUtilidad3.Text = GenericRow!PorcUtilidad2.ToString
            txtComision.Text = GenericRow!PorcComision.ToString
            HADatosOLD = CrearHADatosOLD(GenericRow)
        End If

        Exit Sub
tipoerr:
        XtraMessageBox.Show(Err.Description, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

    Private Sub TxtIdCategoria_TextChanged(sender As Object, e As EventArgs) Handles TxtIdCategoria.TextChanged
        CargarDatosCategoria()
    End Sub
    Private Sub TxtIdCategoria_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtIdCategoria.KeyPress
        If Asc(e.KeyChar) = 13 Then
            CargarDatosCategoria()
            ChkCategoriaActiva.Focus()
        Else
            ValidarNumeroEntero(TxtIdCategoria.Text, e)
        End If
    End Sub

    Private Sub txtCategoria_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCategoria.KeyPress
        If Asc(e.KeyChar) = 13 Then
            btnGuardar.PerformClick()
        End If
    End Sub
    Private Sub gvCategorias_DoubleClick(sender As Object, e As EventArgs) Handles gvCategorias.DoubleClick
        If gvCategorias.RowCount = 0 Then Exit Sub
        TxtIdCategoria.Text = gvCategorias.GetFocusedDataRow.Item("IdCategoria").ToString

    End Sub

    Private Sub gvCategorias_KeyUp(sender As Object, e As KeyEventArgs) Handles gvCategorias.KeyUp
        If gvCategorias.RowCount = 0 Then Exit Sub
        TxtIdCategoria.Text = gvCategorias.GetFocusedDataRow.Item("IdCategoria").ToString

    End Sub

    Private Sub txtPUtilidad1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPUtilidad1.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtPUtilidad2.Focus()
        End If
    End Sub
    Private Sub txtPUtilidad2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPUtilidad2.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtPUtilidad3.Focus()
        End If
    End Sub

    Private Sub txtPUtilidad3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPUtilidad3.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtComision.Focus()
        End If
    End Sub

    Private Sub txtComision_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtComision.KeyPress
        If Asc(e.KeyChar) = 13 Then
            btnGuardar.PerformClick()
        End If
    End Sub

#End Region

    ' PROGRAMACION DEL CATALOGO DE TIPO DE AJUSTES 
#Region "PROGRAMACION DEL CATALOGO DE TIPO DE AJUSTES"
    Private Sub LoadTipoAjustes()
        On Error GoTo tipoerr
        gcTipoAjuste.DataSource = BusquedaSeleccion("Select IdTipo, TipoAjuste From TipoAjuste order by IdTipo ")
        LimpiarCamposTipoAjuste(True)
        Application.DoEvents()

        Exit Sub
tipoerr:
        XtraMessageBox.Show(Err.Description, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

    Private Sub LimpiarCamposTipoAjuste(ByVal limpiarcodigo As Boolean)
        If limpiarcodigo Then txtIdTipoAjuste.Text = ""
        txtTipoAjuste.Text = ""
        RDGValorAjuste.SelectedIndex = 0
    End Sub

    Private Sub NuevoCodigoTipoAjuste()
        On Error GoTo tipoerr
        LimpiarCamposTipoAjuste(True)
        txtIdTipoAjuste.Text = CodigoNuevo("TipoAjuste", "IdTipo", 3)
        txtTipoAjuste.Focus()
        Exit Sub
tipoerr:
        XtraMessageBox.Show(Err.Description, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub
    Private Function ValidarDatosTipoAjuste() As Boolean
        ValidarDatosTipoAjuste = True
        If txtIdTipoAjuste.Text.Trim = "" Then
            XtraMessageBox.Show("El código del tipo de ajuste no puede quedar vacío", "Validar Datos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ValidarDatosTipoAjuste = False
            Exit Function
        End If

        If txtTipoAjuste.Text.Trim = "" Then
            XtraMessageBox.Show("El nombre del tipo de ajuste no puede quedar vacío", "Validar Datos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ValidarDatosTipoAjuste = False
            Exit Function
        End If


    End Function

    Private Sub GuardarTipoAjuste()
        On Error GoTo tipoerr

        If Not ValidarDatosTipoAjuste() Then Exit Sub

        If BuscarRegistroSql("TipoAjuste", "IdTipo", "IdTipo", txtIdTipoAjuste.Text) = "" Then
            ExisteRegistro = False
        Else
            ExisteRegistro = True
        End If

        If ExisteRegistro Then
            CrearComando("UPDATE TipoAjuste SET  TipoAjuste = @TipoAjuste, Valor = @Valor WHERE IdTipo = '" & txtIdTipoAjuste.Text.Trim & "' ")
        Else
            GenericSql = "INSERT INTO TipoAjuste ( TipoAjuste, Valor) VALUES ( @TipoAjuste, @Valor) "
            CrearComando(GenericSql)
        End If

        With Comando.Parameters
            .AddWithValue("TipoAjuste", txtTipoAjuste.Text.Trim)
            .AddWithValue("Valor", IIf(RDGValorAjuste.SelectedIndex = 0, 1, -1))
        End With
        If EjecutarComando() Then
            XtraMessageBox.Show("El Registro se ha guardado correctamente", "Datos Almacenados", MessageBoxButtons.OK, MessageBoxIcon.Information)
            HADatosNEW = "IdTipo: " & txtIdTipoAjuste.Text & " | " & _
                      "TipoAjuste: " & txtTipoAjuste.Text.Trim & " | "
            If RDGValorAjuste.SelectedIndex = 0 Then
                HADatosNEW += "Valor: 1"
            Else
                HADatosNEW += "Valor: -1"
            End If

            If ExisteRegistro Then
                GuardarHistorialAccion("Actualizar", "Tipos de Ajuste de Inventario", txtIdTipoAjuste.Text, HADatosOLD, HADatosNEW)
            Else
                GuardarHistorialAccion("Insertar", "Tipos de Ajuste de Inventario", txtIdTipoAjuste.Text, "", HADatosNEW)
            End If
        End If

        LoadTipoAjustes()
        txtidTipoAjuste.Focus()
        Exit Sub
tipoerr:
        XtraMessageBox.Show(Err.Description, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

    Private Sub EliminarTipoAjuste()
        On Error GoTo tipoerr

        If BuscarRegistroSql("TipoAjuste", "IdTipo", "IdTipo", txtIdTipoAjuste.Text) = "" Then
            XtraMessageBox.Show("El Registro que desea eliminar no existe!", "Registro inexistente", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        If HayRegistrosAnidados("Ajustes", "IdTipo", txtIdTipoAjuste.Text) Then
            XtraMessageBox.Show("No se puede eliminar el registro, está relacionado con otros registros.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        ResultMsg = XtraMessageBox.Show("¿Desea eliminar el registro: " & txtTipoAjuste.Text.Trim & "?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If ResultMsg <> vbYes Then Exit Sub

        GenericSql = "DELETE FROM TipoAjuste WHERE IdTipo= '" & txtIdTipoAjuste.Text.Trim & "'"
        If EjecutarConsulta(GenericSql) Then
            XtraMessageBox.Show("El Registro se ha eliminado correctamente", "Datos Eliminados", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        LoadCategorias()
        txtIdMarca.Focus()
        Exit Sub
tipoerr:
        XtraMessageBox.Show(Err.Description, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

    Private Sub CargarDatosTipoAjuste()
        On Error GoTo tipoerr

        LimpiarCamposTipoAjuste(False) 'limpiamos los campos menos el código
        GenericRow = BusquedaSeleccionFila(String.Format("Select * From TipoAjuste WHERE IdTipoAjuste= '{0}'", TxtIdTipoAjuste.Text))
        If Not IsNothing(GenericRow) Then
            txtTipoAjuste.Text = Trim(GenericRow!TipoAjuste.ToString)
            RDGValorAjuste.SelectedIndex = IIf(GenericRow!Valor = 1, 0, 1)
            HADatosOLD = CrearHADatosOLD(GenericRow)
        End If

        Exit Sub
tipoerr:
        XtraMessageBox.Show(Err.Description, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub
    Private Sub txtIdTipoAjuste_TextChanged(sender As Object, e As EventArgs) Handles txtIdTipoAjuste.TextChanged
        CargarDatosTipoAjuste()
    End Sub

    Private Sub txtIdTipoAjuste_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtIdTipoAjuste.KeyPress
        If Asc(e.KeyChar) = 13 Then
            CargarDatosTipoAjuste()
            txtTipoAjuste.Focus()
        Else
            ValidarNumeroEntero(txtIdTipoAjuste.Text, e)
        End If
    End Sub

    Private Sub txtTipoAjuste_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTipoAjuste.KeyPress
        If Asc(e.KeyChar) = 13 Then
            RDGValorAjuste.Focus()
        End If
    End Sub

    Private Sub RDGValorAjuste_KeyPress(sender As Object, e As KeyPressEventArgs) Handles RDGValorAjuste.KeyPress
        If Asc(e.KeyChar) = 13 Then
            btnGuardar.PerformClick()
        End If
    End Sub

    Private Sub gvTipoAjuste_DoubleClick(sender As Object, e As EventArgs) Handles gvTipoAjuste.DoubleClick
        If gvTipoAjuste.RowCount = 0 Then Exit Sub
        txtIdTipoAjuste.Text = gvTipoAjuste.GetFocusedDataRow.Item("IdTipo").ToString

    End Sub

    Private Sub gvTipoAjuste_KeyUp(sender As Object, e As KeyEventArgs) Handles gvTipoAjuste.KeyUp
        If gvTipoAjuste.RowCount = 0 Then Exit Sub
        txtIdTipoAjuste.Text = gvTipoAjuste.GetFocusedDataRow.Item("IdTipo").ToString

    End Sub
#End Region

    ' PROGRAMACION DEL CATALOGO DE SUCURSALES
#Region "PROGRAMACION DEL CATALOGO DE SUCURSALES"

    Private Sub LoadSucursales()
        On Error GoTo tipoerr
        GCSucursal.DataSource = BusquedaSeleccion("Select IdSucursal, Sucursal From Sucursales order by IdSucursal")
        LimpiarCamposSucursal(True)
        Application.DoEvents()

        Exit Sub
tipoerr:
        XtraMessageBox.Show(Err.Description, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

    Private Sub LimpiarCamposSucursal(ByVal limpiarcodigo As Boolean)
        If limpiarcodigo Then txtIdSucursal.Text = ""
        txtSucursal.Text = ""
        txtDirSucursal.Text = ""
        SpeNumAjuste.Text = "1"
        SpeNumCompra.Text = "1"
        SpeNumFactura.Text = "1"
        SpeNumRemision.Text = "1"
    End Sub

    Private Sub NuevoCodigoSucursal()
        On Error GoTo tipoerr
        LimpiarCamposSucursal(True)
        txtIdSucursal.Text = CodigoNuevo("Sucursales", "IdSucursal", 3)
        ChkSucursalActiva.Focus()
        Exit Sub
tipoerr:
        XtraMessageBox.Show(Err.Description, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

    Private Function ValidarDatosSucursal() As Boolean
        ValidarDatosSucursal = True
        If txtIdSucursal.Text.Trim = "" Then
            XtraMessageBox.Show("El código de sucursal no puede quedar vacío", "Validar Datos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ValidarDatosSucursal = False
            Exit Function
        End If

        If txtSucursal.Text.Trim = "" Then
            XtraMessageBox.Show("El nombre de sucursal no puede quedar vacío", "Validar Datos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ValidarDatosSucursal = False
            Exit Function
        End If
        If txtDirSucursal.Text.Trim = "" Then
            XtraMessageBox.Show("La dirección de la sucursal no puede quedar vacío", "Validar Datos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ValidarDatosSucursal = False
            Exit Function
        End If

    End Function

    Private Sub GuardarSucursal()
        On Error GoTo tipoerr

        If Not ValidarDatosSucursal() Then Exit Sub

        If BuscarRegistroSql("Sucursales", "IdSucursal", "IdSucursal", txtIdSucursal.Text) = "" Then
            ExisteRegistro = False
        Else
            ExisteRegistro = True
        End If

        If ExisteRegistro Then
            CrearComando("UPDATE Sucursales SET IdEmpresa = @IdEmpresa, Sucursal = @Sucursal, DirSucursal = @DirSucursal, Activa = @Activa, NumDocCompra = @NumDocCompra,  NumDocRemision = @NumDocRemision, NumDocFactura = @NumDocFactura, NumDocAjuste = @NumDocAjuste WHERE  IdSucursal = @IdSucursal ")
        Else
            GenericSql = "INSERT INTO Sucursales (IdSucursal, IdEmpresa, Sucursal, DirSucursal, Activa, NumDocCompra, NumDocRemision, NumDocFactura, NumDocAjuste) VALUES (@IdSucursal, @IdEmpresa, @Sucursal, @DirSucursal, @Activa, @NumDocCompra, @NumDocRemision, @NumDocFactura, @NumDocAjuste) "
            CrearComando(GenericSql)
        End If

        With Comando.Parameters
            .AddWithValue("IdSucursal", txtIdSucursal.Text)
            .AddWithValue("IdEmpresa", BuscarRegistroSql("Empresa", "IdEmpresa", "1", "1"))
            .AddWithValue("Sucursal", txtSucursal.Text.Trim)
            .AddWithValue("DirSucursal", txtDirSucursal.Text.Trim)
            .AddWithValue("NumDocCompra", SpeNumCompra.Text)
            .AddWithValue("NumDocRemision", SpeNumRemision.Text)
            .AddWithValue("NumDocFactura", SpeNumFactura.Text)
            .AddWithValue("NumDocAjuste", SpeNumAjuste.Text)
            .AddWithValue("Activa", CBool(ChkSucursalActiva.Checked))

        End With
        If EjecutarComando() Then
            XtraMessageBox.Show("El Registro se ha guardado correctamente", "Datos Almacenados", MessageBoxButtons.OK, MessageBoxIcon.Information)
            HADatosNEW = "IdSucursal: " & txtIdSucursal.Text & " | " & _
                    "IdEmpresa: " & BuscarRegistroSql("Empresa", "IdEmpresa", "1", "1") & " | " & _
                    "Sucursal: " & txtSucursal.Text.Trim & " | " & _
                    "DirSucursal: " & txtDirSucursal.Text.Trim & " | " & _
                    "NumSucCompra: " & SpeNumCompra.Text & " | " & _
                    "NumSucRemision: " & SpeNumRemision.Text & " | " & _
                    "NumSucFactura: " & SpeNumFactura.Text & " | " & _
                    "NumSucAjuste: " & SpeNumAjuste.Text & " | " & _
                    "Activa: " & ChkSucursalActiva.Checked.ToString

            If ExisteRegistro Then
                GuardarHistorialAccion("Actualizar", "Sucursales", txtIdSucursal.Text, HADatosOLD, HADatosNEW)
            Else
                GuardarHistorialAccion("Insertar", "Sucursales", txtIdSucursal.Text, "", HADatosNEW)
            End If
        End If

        LoadSucursales()
        txtIdSucursal.Focus()
        Exit Sub
tipoerr:
        XtraMessageBox.Show(Err.Description, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

    Private Sub EliminarSucursal()
        On Error GoTo tipoerr

        If BuscarRegistroSql("Sucursales", "IdSucursal", "IdSucursal", txtIdSucursal.Text) = "" Then
            XtraMessageBox.Show("El Registro que desea eliminar no existe!", "Registro inexistente", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        If HayRegistrosAnidados("Usuarios", "IdSucursal", txtIdSucursal.Text) Then
            XtraMessageBox.Show("No se puede eliminar el registro, está relacionado con otros registros.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        ResultMsg = XtraMessageBox.Show("¿Desea eliminar el registro: " & txtSucursal.Text.Trim & "?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If ResultMsg <> vbYes Then Exit Sub

        GenericSql = "DELETE FROM Sucursales WHERE IdSucursal= '" & txtIdSucursal.Text.Trim & "'"
        If EjecutarConsulta(GenericSql) Then
            XtraMessageBox.Show("El Registro se ha eliminado correctamente", "Datos Eliminados", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        LoadSucursales()
        txtIdSucursal.Focus()
        Exit Sub
tipoerr:
        XtraMessageBox.Show(Err.Description, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

    Private Sub CargarDatosSucursal()
        On Error GoTo tipoerr

        LimpiarCamposSucursal(False) 'limpiamos los campos menos el código
        GenericRow = BusquedaSeleccionFila(String.Format("Select * From Sucursales WHERE IdSucursal= '{0}'", txtIdSucursal.Text))
        If Not IsNothing(GenericRow) Then
            txtSucursal.Text = Trim(GenericRow!Sucursal.ToString)
            txtDirSucursal.Text = Trim(GenericRow!DirSucursal.ToString)
            ChkSucursalActiva.Checked = CBool(GenericRow!Activa)
            SpeNumCompra.Text = IIf(IsDBNull(GenericRow!NumDocCompra), "1", GenericRow!NumDocCompra.ToString)
            SpeNumRemision.Text = IIf(IsDBNull(GenericRow!NumDocRemision), "1", GenericRow!NumDocRemision.ToString)
            SpeNumFactura.Text = IIf(IsDBNull(GenericRow!NumDocFactura), "1", GenericRow!NumDocFactura.ToString)
            SpeNumAjuste.Text = IIf(IsDBNull(GenericRow!NumDocAjuste), "1", GenericRow!NumDocAjuste.ToString)
            HADatosOLD = CrearHADatosOLD(GenericRow)
        End If

        Exit Sub
tipoerr:
        XtraMessageBox.Show(Err.Description, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

    Private Sub txtIdSucursal_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtIdSucursal.KeyPress
        If Asc(e.KeyChar) = 13 Then
            CargarDatosSucursal()
            ChkSucursalActiva.Focus()
        Else
            ValidarNumeroEntero(txtIdSucursal.Text, e)
        End If
    End Sub

    Private Sub txtIdSucursal_TextChanged(sender As Object, e As EventArgs) Handles txtIdSucursal.TextChanged
        CargarDatosSucursal()
    End Sub

    Private Sub txtSucursal_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSucursal.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtDirSucursal.Focus()
        End If
    End Sub

    Private Sub ChkSucursalActiva_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ChkSucursalActiva.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtSucursal.Focus()
        End If
    End Sub

    Private Sub txtDirSucursal_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDirSucursal.KeyPress
        If Asc(e.KeyChar) = 13 Then
            SpeNumCompra.Focus()
        End If
    End Sub

    Private Sub SpeNumRemision_KeyPress(sender As Object, e As KeyPressEventArgs) Handles SpeNumRemision.KeyPress
        If Asc(e.KeyChar) = 13 Then
            SpeNumFactura.Focus()
        End If
    End Sub

    Private Sub SpeNumFactura_KeyPress(sender As Object, e As KeyPressEventArgs) Handles SpeNumFactura.KeyPress
        If Asc(e.KeyChar) = 13 Then
            SpeNumAjuste.Focus()
        End If
    End Sub

    Private Sub SpeNumAjuste_KeyPress(sender As Object, e As KeyPressEventArgs) Handles SpeNumAjuste.KeyPress
        If Asc(e.KeyChar) = 13 Then
            btnGuardar.PerformClick()
        End If
    End Sub
    Private Sub GvSucursal_DoubleClick(sender As Object, e As EventArgs) Handles GvSucursal.DoubleClick
        If GvSucursal.RowCount = 0 Then Exit Sub
        txtIdSucursal.Text = GvSucursal.GetFocusedDataRow.Item("IdSucursal").ToString

    End Sub

    Private Sub GvSucursal_KeyUp(sender As Object, e As KeyEventArgs) Handles GvSucursal.KeyUp
        If GvSucursal.RowCount = 0 Then Exit Sub
        txtIdSucursal.Text = GvSucursal.GetFocusedDataRow.Item("IdSucursal").ToString

    End Sub
#End Region

    ' PROGRAMACION DEL CATALOGO DE PROVEEDORES
#Region "PROGRAMACION DEL CATALOGO DE PROVEEDORES"

    Private Sub LoadProveedores()
        On Error GoTo tipoerr
        GCProveedores.DataSource = BusquedaSeleccion("Select IdProveedor, Proveedor From Proveedores order by IdProveedor ")
        LimpiarCamposProveedor(True)
        Application.DoEvents()

        Exit Sub
tipoerr:
        XtraMessageBox.Show(Err.Description, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

    Private Sub LimpiarCamposProveedor(ByVal limpiarcodigo As Boolean)
        If limpiarcodigo Then txtIdProveedor.Text = ""
        txtProveedor.Text = ""
        txtTelProveedor.Text = ""
        txtDirProveedor.Text = ""
        txtRUCProveedor.Text = ""
        txtCorreoProveedor.Text = ""
        ChkProveedorActivo.Checked = False
    End Sub

    Private Sub NuevoCodigoProveedor()
        On Error GoTo tipoerr
        LimpiarCamposProveedor(True)
        Dim NoDigito As Integer = CInt(BuscarRegistroSql("Empresa", "DigitoIdProveedor", "1", "1"))
        txtIdProveedor.Text = CodigoNuevo("Proveedores", "IdProveedor", NoDigito)
        ChkProveedorActivo.Focus()
        Exit Sub
tipoerr:
        XtraMessageBox.Show(Err.Description, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

    Private Function ValidarDatosProveedor() As Boolean
        ValidarDatosProveedor = True
        If txtIdProveedor.Text.Trim = "" Then
            XtraMessageBox.Show("El código de proveedor no puede quedar vacío", "Validar Datos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ValidarDatosProveedor = False
            Exit Function
        End If

        If txtProveedor.Text.Trim = "" Then
            XtraMessageBox.Show("El nombre de proveedor no puede quedar vacío", "Validar Datos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ValidarDatosProveedor = False
            Exit Function
        End If
        If txtDirProveedor.Text.Trim = "" Then
            XtraMessageBox.Show("La dirección del proveedor no puede quedar vacía", "Validar Datos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ValidarDatosProveedor = False
            Exit Function
        End If
        If txtTelProveedor.Text.Trim = "" Then
            XtraMessageBox.Show("El telefono del proveedor no puede quedar vacío", "Validar Datos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ValidarDatosProveedor = False
            Exit Function
        End If
        If txtRUCProveedor.Text.Trim = "" Then
            XtraMessageBox.Show("El RUC del proveedor no puede quedar vacío", "Validar Datos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ValidarDatosProveedor = False
            Exit Function
        End If

    End Function

    Private Sub GuardarProveedor()
        On Error GoTo tipoerr
        Dim IdDatos As String

        If Not ValidarDatosProveedor() Then Exit Sub

        If BuscarRegistroSql("Proveedores", "IdProveedor", "IdProveedor", txtIdProveedor.Text) = "" Then
            ExisteRegistro = False
        Else
            ExisteRegistro = True
        End If
        'Primero guardamos los datos de la entidad
        If ExisteRegistro Then
            IdDatos = BuscarRegistroSql("Proveedores", "IdDatos", "IdProveedor", txtIdProveedor.Text)
            CrearComando("UPDATE    DatosEntidad SET Nombres = @Nombres, Apellidos = @Apellidos, Empresa = @Empresa, Telefono = @Telefono, Direccion = @Direccion, CedulaRUC = @CedulaRUC, Correo = @Correo, Tipo = @Tipo WHERE IdDatos = @IdDatos ")
        Else
            IdDatos = CodigoNuevo("DatosEntidad", "IdDatos", 3)
            GenericSql = "INSERT INTO DatosEntidad (IdDatos, Nombres, Apellidos, Empresa, Telefono, Direccion, CedulaRUC, Correo, Tipo) VALUES (@IdDatos, @Nombres, @Apellidos, @Empresa, @Telefono, @Direccion, @CedulaRUC, @Correo, @Tipo) "
            CrearComando(GenericSql)
        End If
        With Comando.Parameters
            .AddWithValue("IdDatos", IdDatos)
            .AddWithValue("Nombres", "")
            .AddWithValue("Apellidos", "")
            .AddWithValue("Empresa", txtProveedor.Text)
            .AddWithValue("Telefono", txtTelProveedor.Text)
            .AddWithValue("Direccion", txtDirProveedor.Text)
            .AddWithValue("CedulaRUC", txtRUCProveedor.Text.Trim)
            .AddWithValue("Correo", txtCorreoProveedor.Text.Trim)
            .AddWithValue("Tipo", "P")

        End With
        EjecutarComando()
        'Luego guardamos los datos del proveedor
        If ExisteRegistro Then
            CrearComando("UPDATE    Proveedores SET  IdDatos = @IdDatos, Proveedor = @Proveedor, Activo = @Activo WHERE IdProveedor = @IdProveedor ")
        Else
            GenericSql = "INSERT INTO Proveedores (IdProveedor, IdDatos, Proveedor, Activo) VALUES      (@IdProveedor, @IdDatos, @Proveedor, @Activo) "
            CrearComando(GenericSql)
        End If

        With Comando.Parameters
            .AddWithValue("IdProveedor", txtIdProveedor.Text)
            .AddWithValue("IdDatos", IdDatos)
            .AddWithValue("Proveedor", txtProveedor.Text.Trim)
            .AddWithValue("Activo", ChkProveedorActivo.Checked)

        End With
        If EjecutarComando() Then
            XtraMessageBox.Show("El Registro se ha guardado correctamente", "Datos Almacenados", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        LoadProveedores()
        txtIdProveedor.Focus()
        Exit Sub
tipoerr:
        XtraMessageBox.Show(Err.Description, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

    Private Sub EliminarProveedor()
        On Error GoTo tipoerr
        Dim IdDatos As String
        If BuscarRegistroSql("Proveedores", "IdProveedor", "IdProveedor", txtIdProveedor.Text) = "" Then
            XtraMessageBox.Show("El Registro que desea eliminar no existe!", "Registro inexistente", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        If HayRegistrosAnidados("Compras", "IdProveedor", txtIdProveedor.Text) Then
            XtraMessageBox.Show("No se puede eliminar el registro, está relacionado con otros registros.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        ResultMsg = XtraMessageBox.Show("¿Desea eliminar el registro: " & txtProveedor.Text.Trim & "?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If ResultMsg <> vbYes Then Exit Sub
        IdDatos = BuscarRegistroSql("Proveedores", "IdDatos", "IdProveedor", txtIdProveedor.Text)
        'Para eliminar correctamente el proveedor, debemos eliminar luego sus datos de entidad
        GenericSql = "DELETE FROM Proveedores WHERE IdProveedor= '" & txtIdProveedor.Text.Trim & "'"
        If EjecutarConsulta(GenericSql) Then
            GenericSql = String.Format("DELETE FROM DatosEntidad WHERE IdDatos= '{0}'", IdDatos)
            EjecutarConsulta(GenericSql)
            XtraMessageBox.Show("El Registro se ha eliminado correctamente", "Datos Eliminados", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If
        LoadProveedores()
        txtIdProveedor.Focus()
        Exit Sub
tipoerr:
        XtraMessageBox.Show(Err.Description, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

    Private Sub CargarDatosProveedor()
        On Error GoTo tipoerr

        LimpiarCamposProveedor(False) 'limpiamos los campos menos el código
        GenericRow = BusquedaSeleccionFila(String.Format("Select Proveedores.IdProveedor, Proveedores.Proveedor, DatosEntidad.Telefono, DatosEntidad.Direccion, DatosEntidad.CedulaRUC, DatosEntidad.Correo, Proveedores.Activo from Proveedores INNER JOIN DatosEntidad on Proveedores.IdDatos= DatosEntidad.IdDatos WHERE Proveedores.IdProveedor= '{0}'", txtIdProveedor.Text))
        If Not IsNothing(GenericRow) Then
            txtProveedor.Text = Trim(GenericRow!Proveedor.ToString)
            txtTelProveedor.Text = Trim(GenericRow!Telefono.ToString)
            txtDirProveedor.Text = Trim(GenericRow!Direccion.ToString)
            txtRUCProveedor.Text = Trim(GenericRow!CedulaRUC.ToString)
            txtCorreoProveedor.Text = Trim(GenericRow!Correo.ToString)
            ChkProveedorActivo.Checked = CBool(GenericRow!Activo)
            HADatosOLD = CrearHADatosOLD(GenericRow)
        End If

        Exit Sub
tipoerr:
        XtraMessageBox.Show(Err.Description, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub
    Private Sub txtIdProveedor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtIdProveedor.KeyPress
        If Asc(e.KeyChar) = 13 Then
            CargarDatosProveedor()
            ChkProveedorActivo.Focus()
        Else
            ValidarNumeroEntero(txtIdProveedor.Text, e)
        End If
    End Sub

    Private Sub txtIdProveedor_TextChanged(sender As Object, e As EventArgs) Handles txtIdProveedor.TextChanged
        CargarDatosProveedor()
    End Sub

    Private Sub ChkProveedorActivo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ChkProveedorActivo.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtProveedor.Focus()
        End If
    End Sub

    Private Sub txtProveedor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtProveedor.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtRUCProveedor.Focus()
        End If
    End Sub

    Private Sub txtRUCProveedor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtRUCProveedor.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtDirProveedor.Focus()
        End If
    End Sub

    Private Sub txtDirProveedor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDirProveedor.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtTelProveedor.Focus()
        End If
    End Sub

    Private Sub txtTelProveedor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTelProveedor.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtCorreoProveedor.Focus()
        End If
    End Sub

    Private Sub txtCorreoProveedor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCorreoProveedor.KeyPress
        If Asc(e.KeyChar) = 13 Then
            btnGuardar.PerformClick()
        End If
    End Sub
    Private Sub GVProveedores_DoubleClick(sender As Object, e As EventArgs) Handles GVProveedores.DoubleClick
        If GVProveedores.RowCount = 0 Then Exit Sub
        txtIdProveedor.Text = GVProveedores.GetFocusedDataRow.Item("IdProveedor").ToString

    End Sub

    Private Sub GVProveedores_KeyUp(sender As Object, e As KeyEventArgs) Handles GVProveedores.KeyUp
        If GVProveedores.RowCount = 0 Then Exit Sub
        txtIdProveedor.Text = GVProveedores.GetFocusedDataRow.Item("IdProveedor").ToString

    End Sub
#End Region

    ' PROGRAMACION DEL CATALOGO DE VENDEDORES
#Region "PROGRAMACION DEL CATALOGO DE VENDEDORES"

    Private Sub LoadVendedores()
        On Error GoTo tipoerr
        GCVendedores.DataSource = BusquedaSeleccion("Select Vendedores.IdVendedor, DatosEntidad.Nombres, DatosEntidad.Apellidos From Vendedores INNER JOIN DatosEntidad ON Vendedores.IdDatos=DatosEntidad.IdDatos ")
        LimpiarCamposVendedor(True)
        Application.DoEvents()

        Exit Sub
tipoerr:
        XtraMessageBox.Show(Err.Description, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

    Private Sub LimpiarCamposVendedor(ByVal limpiarcodigo As Boolean)
        If limpiarcodigo Then txtIdVendedor.Text = ""
        txtNombresVendedor.Text = ""
        txtApellidosVendedor.Text = ""
        txtTelVendedor.Text = ""
        txtDirVendedor.Text = ""
        txtCorreoVendedor.Text = ""
        ChkVendedorActivo.Checked = False
    End Sub

    Private Sub NuevoCodigoVendedor()
        On Error GoTo tipoerr
        LimpiarCamposProveedor(True)
        Dim NoDigito As Integer = CInt(BuscarRegistroSql("Empresa", "DigitoIdVendedor", "1", "1"))

        txtIdVendedor.Text = CodigoNuevo("Vendedores", "IdVendedor", NoDigito)
        ChkVendedorActivo.Focus()
        Exit Sub
tipoerr:
        XtraMessageBox.Show(Err.Description, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

    Private Function ValidarDatosVendedor() As Boolean
        ValidarDatosVendedor = True
        If txtIdVendedor.Text.Trim = "" Then
            XtraMessageBox.Show("El código de vendedor no puede quedar vacío", "Validar Datos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ValidarDatosVendedor = False
            Exit Function
        End If

        If txtNombresVendedor.Text.Trim = "" Then
            XtraMessageBox.Show("El nombre de vendedor no puede quedar vacío", "Validar Datos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ValidarDatosVendedor = False
            Exit Function
        End If
        If txtApellidosVendedor.Text.Trim = "" Then
            XtraMessageBox.Show("El apellido de vendedor no puede quedar vacío", "Validar Datos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ValidarDatosVendedor = False
            Exit Function
        End If
        If txtDirVendedor.Text.Trim = "" Then
            XtraMessageBox.Show("La dirección del vendedor no puede quedar vacío", "Validar Datos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ValidarDatosVendedor = False
            Exit Function
        End If
        If txtTelVendedor.Text.Trim = "" Then
            XtraMessageBox.Show("El telefono del vendedor no puede quedar vacío", "Validar Datos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ValidarDatosVendedor = False
            Exit Function
        End If

    End Function

    Private Sub GuardarVendedor()
        On Error GoTo tipoerr
        Dim IdDatos As String

        If Not ValidarDatosVendedor() Then Exit Sub

        If BuscarRegistroSql("Vendedores", "IdVendedor", "IdVendedor", txtIdVendedor.Text) = "" Then
            ExisteRegistro = False
        Else
            ExisteRegistro = True
        End If
        'Primero guardamos los datos de la entidad
        If ExisteRegistro Then
            IdDatos = BuscarRegistroSql("Vendedores", "IdDatos", "IdVendedor", txtIdVendedor.Text)
            CrearComando("UPDATE    DatosEntidad SET Nombres = @Nombres, Apellidos = @Apellidos, Empresa = @Empresa, Telefono = @Telefono, Direccion = @Direccion, CedulaRUC = @CedulaRUC, Correo = @Correo, Tipo = @Tipo WHERE IdDatos = @IdDatos ")
        Else
            IdDatos = CodigoNuevo("DatosEntidad", "IdDatos", 3)
            GenericSql = "INSERT INTO DatosEntidad (IdDatos, Nombres, Apellidos, Empresa, Telefono, Direccion, CedulaRUC, Correo, Tipo) VALUES (@IdDatos, @Nombres, @Apellidos, @Empresa, @Telefono, @Direccion, @CedulaRUC, @Correo, @Tipo) "
            CrearComando(GenericSql)
        End If
        With Comando.Parameters
            .AddWithValue("IdDatos", IdDatos)
            .AddWithValue("Nombres", txtNombresVendedor.Text.Trim)
            .AddWithValue("Apellidos", txtApellidosVendedor.Text.Trim)
            .AddWithValue("Empresa", IIf(Empresa Is Nothing, "", Empresa))
            .AddWithValue("Telefono", txtTelVendedor.Text.Trim)
            .AddWithValue("Direccion", txtDirVendedor.Text.Trim)
            .AddWithValue("CedulaRUC", "")
            .AddWithValue("Correo", txtCorreoVendedor.Text.Trim)
            .AddWithValue("Tipo", "V")

        End With
        EjecutarComando()
        'Luego guardamos los datos del vendedor
        If ExisteRegistro Then
            CrearComando("UPDATE Vendedores SET  IdDatos = @IdDatos, Activo = @Activo WHERE IdVendedor = @IdVendedor ")
        Else
            GenericSql = "INSERT INTO Vendedores (IdVendedor, IdDatos, Activo) VALUES (@IdVendedor, @IdDatos, @Activo) "
            CrearComando(GenericSql)
        End If

        With Comando.Parameters
            .AddWithValue("IdVendedor", txtIdVendedor.Text)
            .AddWithValue("IdDatos", IdDatos)
            .AddWithValue("Activo", ChkVendedorActivo.Checked)

        End With
        If EjecutarComando() Then
            XtraMessageBox.Show("El Registro se ha guardado correctamente", "Datos Almacenados", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        LoadVendedores()
        txtIdVendedor.Focus()
        Exit Sub
tipoerr:
        XtraMessageBox.Show(Err.Description, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

    Private Sub EliminarVendedor()
        On Error GoTo tipoerr
        Dim IdDatos As String
        If BuscarRegistroSql("Vendedores", "IdVendedor", "IdVendedor", txtIdVendedor.Text) = "" Then
            XtraMessageBox.Show("El Registro que desea eliminar no existe!", "Registro inexistente", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        If HayRegistrosAnidados("Ventas", "IdVendedor", txtIdVendedor.Text) Then
            XtraMessageBox.Show("No se puede eliminar el registro, está relacionado con otros registros.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        ResultMsg = XtraMessageBox.Show("¿Desea eliminar el registro: " & txtProveedor.Text.Trim & "?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If ResultMsg <> vbYes Then Exit Sub
        IdDatos = BuscarRegistroSql("Vendedores", "IdDatos", "IdVendedor", txtIdVendedor.Text)
        'Para eliminar correctamente el proveedor, debemos eliminar luego sus datos de entidad
        GenericSql = "DELETE FROM Vendedores WHERE IdVendedor= '" & txtIdVendedor.Text.Trim & "'"
        If EjecutarConsulta(GenericSql) Then
            GenericSql = String.Format("DELETE FROM DatosEntidad WHERE IdDatos= '{0}'", IdDatos)
            EjecutarConsulta(GenericSql)
            XtraMessageBox.Show("El Registro se ha eliminado correctamente", "Datos Eliminados", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If
        LoadVendedores()
        txtIdVendedor.Focus()
        Exit Sub
tipoerr:
        XtraMessageBox.Show(Err.Description, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

    Private Sub CargarDatosVendedor()
        On Error GoTo tipoerr

        LimpiarCamposVendedor(False) 'limpiamos los campos menos el código
        GenericRow = BusquedaSeleccionFila(String.Format("Select Vendedores.IdVendedor, DatosEntidad.Nombres, DatosEntidad.Apellidos, DatosEntidad.Telefono, DatosEntidad.Correo, DatosEntidad.Direccion, Vendedores.Activo From Vendedores INNER JOIN DatosEntidad ON Vendedores.IdDatos=DatosEntidad.IdDatos WHERE Vendedores.IdVendedor= '{0}'", txtIdVendedor.Text))
        If Not IsNothing(GenericRow) Then
            txtNombresVendedor.Text = Trim(GenericRow!Nombres.ToString)
            txtApellidosVendedor.Text = Trim(GenericRow!Apellidos.ToString)
            txtDirVendedor.Text = Trim(GenericRow!Direccion.ToString)
            txtTelVendedor.Text = Trim(GenericRow!Telefono.ToString)
            txtCorreoVendedor.Text = Trim(GenericRow!Correo.ToString)
            ChkVendedorActivo.Checked = CBool(GenericRow!Activo)
            HADatosOLD = CrearHADatosOLD(GenericRow)
        End If

        Exit Sub
tipoerr:
        XtraMessageBox.Show(Err.Description, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub
    Private Sub txtIdVendedor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtIdVendedor.KeyPress
        If Asc(e.KeyChar) = 13 Then
            CargarDatosVendedor()
            ChkVendedorActivo.Focus()
        Else
            ValidarNumeroEntero(txtIdVendedor.Text, e)
        End If
    End Sub

    Private Sub txtIdVendedor_TextChanged(sender As Object, e As EventArgs) Handles txtIdVendedor.TextChanged
        CargarDatosVendedor()
    End Sub

    Private Sub ChkVendedorActivo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ChkVendedorActivo.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtNombresVendedor.Focus()
        End If
    End Sub

    Private Sub txtNombresVendedor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNombresVendedor.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtApellidosVendedor.Focus()
        End If
    End Sub

    Private Sub txtApellidosVendedor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtApellidosVendedor.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtDirVendedor.Focus()
        End If
    End Sub

    Private Sub txtDirVendedor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDirVendedor.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtTelVendedor.Focus()
        End If
    End Sub

    Private Sub txtTelVendedor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTelVendedor.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtCorreoVendedor.Focus()
        End If
    End Sub

    Private Sub txtCorreoVendedor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCorreoVendedor.KeyPress
        If Asc(e.KeyChar) = 13 Then
            btnGuardar.PerformClick()
        End If
    End Sub
    Private Sub GVVendedores_DoubleClick(sender As Object, e As EventArgs) Handles GVVendedores.DoubleClick
        If GVVendedores.RowCount = 0 Then Exit Sub
        txtIdVendedor.Text = GVVendedores.GetFocusedDataRow.Item("IdVendedor").ToString

    End Sub

    Private Sub GVVendedores_KeyUp(sender As Object, e As KeyEventArgs) Handles GVVendedores.KeyUp
        If GVVendedores.RowCount = 0 Then Exit Sub
        txtIdVendedor.Text = GVVendedores.GetFocusedDataRow.Item("IdVendedor").ToString
    End Sub
#End Region

    ' PROGRAMACION DEL CATALOGO DE CLIENTES
#Region "PROGRAMACION DEL CATALOGO DE CLIENTES"

    Private Sub LoadClientes()
        On Error GoTo tipoerr
        GCClientes.DataSource = BusquedaSeleccion("Select Clientes.IdCliente, DatosEntidad.Nombres + ' ' + DatosEntidad.Apellidos as Cliente, DatosEntidad.Empresa FROM Clientes INNER JOIN DatosEntidad ON Clientes.IdDatos=DatosEntidad.IdDatos ")
        LimpiarCamposCliente(True)
        Application.DoEvents()

        Exit Sub
tipoerr:
        XtraMessageBox.Show(Err.Description, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

    Private Sub LimpiarCamposCliente(ByVal limpiarcodigo As Boolean)
        If limpiarcodigo Then txtIdCliente.Text = ""
        txtNombresCliente.Text = ""
        txtApellidosCliente.Text = ""
        txtEmpresaCliente.Text = ""
        txtTelCliente.Text = ""
        txtDirCliente.Text = ""
        txtRUCCliente.Text = ""
        txtCorreoCliente.Text = ""
        ChkClienteActivo.Checked = False
    End Sub

    Private Sub NuevoCodigoCliente()
        On Error GoTo tipoerr
        LimpiarCamposCliente(True)
        Dim NoDigito As Integer = CInt(BuscarRegistroSql("Empresa", "DigitoIdCliente", "1", "1"))

        txtIdCliente.Text = CodigoNuevo("Clientes", "IdCliente", NoDigito)
        ChkClienteActivo.Focus()
        Exit Sub
tipoerr:
        XtraMessageBox.Show(Err.Description, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

    Private Function ValidarDatosCliente() As Boolean
        ValidarDatosCliente = True
        If txtIdCliente.Text.Trim = "" Then
            XtraMessageBox.Show("El código de cliente no puede quedar vacío", "Validar Datos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ValidarDatosCliente = False
            Exit Function
        End If

        If txtNombresCliente.Text.Trim = "" Then
            XtraMessageBox.Show("El nombre de cliente no puede quedar vacío", "Validar Datos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ValidarDatosCliente = False
            Exit Function
        End If
        If txtApellidosCliente.Text.Trim = "" Then
            XtraMessageBox.Show("El apellido del cliente no puede quedar vacío", "Validar Datos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ValidarDatosCliente = False
            Exit Function
        End If
        If txtDirCliente.Text.Trim = "" Then
            XtraMessageBox.Show("La dirección del cliente no puede quedar vacía", "Validar Datos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ValidarDatosCliente = False
            Exit Function
        End If
        If txtEmpresaCliente.Text.Trim = "" Then
            XtraMessageBox.Show("La empresa del cliente no puede quedar vacío", "Validar Datos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ValidarDatosCliente = False
            Exit Function
        End If
        If txtTelCliente.Text.Trim = "" Then
            XtraMessageBox.Show("El telefono del cliente no puede quedar vacío", "Validar Datos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ValidarDatosCliente = False
            Exit Function
        End If
        If txtRUCCliente.Text.Trim = "" Then
            XtraMessageBox.Show("El RUC del cliente no puede quedar vacío", "Validar Datos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ValidarDatosCliente = False
            Exit Function
        End If

    End Function

    Private Sub GuardarCliente()
        On Error GoTo tipoerr
        Dim IdDatos As String

        If Not ValidarDatosCliente() Then Exit Sub

        If BuscarRegistroSql("Clientes", "IdCliente", "IdCliente", txtIdCliente.Text) = "" Then
            ExisteRegistro = False
        Else
            ExisteRegistro = True
        End If
        'Primero guardamos los datos de la entidad
        If ExisteRegistro Then
            IdDatos = BuscarRegistroSql("Clientes", "IdDatos", "IdCliente", txtIdCliente.Text)
            CrearComando("UPDATE    DatosEntidad SET Nombres = @Nombres, Apellidos = @Apellidos, Empresa = @Empresa, Telefono = @Telefono, Direccion = @Direccion, CedulaRUC = @CedulaRUC, Correo = @Correo, Tipo = @Tipo WHERE IdDatos = @IdDatos ")
        Else
            IdDatos = CodigoNuevo("DatosEntidad", "IdDatos", 3)
            GenericSql = "INSERT INTO DatosEntidad (IdDatos, Nombres, Apellidos, Empresa, Telefono, Direccion, CedulaRUC, Correo, Tipo) VALUES (@IdDatos, @Nombres, @Apellidos, @Empresa, @Telefono, @Direccion, @CedulaRUC, @Correo, @Tipo) "
            CrearComando(GenericSql)
        End If
        With Comando.Parameters
            .AddWithValue("IdDatos", IdDatos)
            .AddWithValue("Nombres", txtNombresCliente.Text.Trim)
            .AddWithValue("Apellidos", txtApellidosCliente.Text.Trim)
            .AddWithValue("Empresa", txtEmpresaCliente.Text.Trim)
            .AddWithValue("Telefono", txtTelCliente.Text)
            .AddWithValue("Direccion", txtDirCliente.Text)
            .AddWithValue("CedulaRUC", txtRUCCliente.Text.Trim)
            .AddWithValue("Correo", txtCorreoCliente.Text.Trim)
            .AddWithValue("Tipo", "C")

        End With
        EjecutarComando()
        'Luego guardamos los datos del Cliente
        If ExisteRegistro Then
            CrearComando("UPDATE    Clientes SET IdDatos = @IdDatos, Exonerado = @Exonerado, Activo = @Activo WHERE  IdCliente = @IdCliente ")
        Else
            GenericSql = "INSERT INTO Clientes (IdCliente, IdDatos, Exonerado, Activo) VALUES (@IdCliente, @IdDatos, @Exonerado, @Activo) "
            CrearComando(GenericSql)
        End If

        With Comando.Parameters
            .AddWithValue("IdCliente", txtIdCliente.Text)
            .AddWithValue("IdDatos", IdDatos)
            .AddWithValue("Exonerado", ChkClienteExonerado.Checked)
            .AddWithValue("Activo", ChkClienteActivo.Checked)

        End With
        If EjecutarComando() Then
            XtraMessageBox.Show("El Registro se ha guardado correctamente", "Datos Almacenados", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        LoadClientes()
        txtIdCliente.Focus()
        Exit Sub
tipoerr:
        XtraMessageBox.Show(Err.Description, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

    Private Sub EliminarCliente()
        On Error GoTo tipoerr
        Dim IdDatos As String
        If BuscarRegistroSql("Clientes", "IdCliente", "IdCliente", txtIdCliente.Text) = "" Then
            XtraMessageBox.Show("El Registro que desea eliminar no existe!", "Registro inexistente", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        If HayRegistrosAnidados("Ventas", "IdCliente", txtIdCliente.Text) Then
            XtraMessageBox.Show("No se puede eliminar el registro, está relacionado con otros registros.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        ResultMsg = XtraMessageBox.Show("¿Desea eliminar el registro: " & txtEmpresaCliente.Text.Trim & "?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If ResultMsg <> vbYes Then Exit Sub
        IdDatos = BuscarRegistroSql("Clientes", "IdDatos", "IdCliente", txtIdCliente.Text)
        'Para eliminar correctamente el proveedor, debemos eliminar luego sus datos de entidad
        GenericSql = "DELETE FROM Clientes WHERE IdCliente= '" & txtIdCliente.Text.Trim & "'"
        If EjecutarConsulta(GenericSql) Then
            GenericSql = String.Format("DELETE FROM DatosEntidad WHERE IdDatos= '{0}'", IdDatos)
            EjecutarConsulta(GenericSql)
            XtraMessageBox.Show("El Registro se ha eliminado correctamente", "Datos Eliminados", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If
        LoadClientes()
        txtIdCliente.Focus()
        Exit Sub
tipoerr:
        XtraMessageBox.Show(Err.Description, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

    Private Sub CargarDatosCliente()
        On Error GoTo tipoerr

        LimpiarCamposCliente(False) 'limpiamos los campos menos el código
        GenericRow = BusquedaSeleccionFila(String.Format("Select Clientes.IdCliente, DatosEntidad.Nombres, DatosEntidad.Apellidos , DatosEntidad.Empresa, DatosEntidad.CedulaRUC, DatosEntidad.Correo, DatosEntidad.Telefono, DatosEntidad.Direccion, DatosEntidad.Correo, Clientes.Exonerado, Clientes.Activo FROM Clientes INNER JOIN DatosEntidad ON Clientes.IdDatos=DatosEntidad.IdDatos WHERE Clientes.IdCliente= '{0}'", txtIdCliente.Text))
        If Not IsNothing(GenericRow) Then
            txtEmpresaCliente.Text = Trim(GenericRow!Empresa.ToString)
            txtNombresCliente.Text = Trim(GenericRow!Nombres.ToString)
            txtApellidosCliente.Text = Trim(GenericRow!Apellidos.ToString)
            txtTelCliente.Text = Trim(GenericRow!Telefono.ToString)
            txtDirCliente.Text = Trim(GenericRow!Direccion.ToString)
            txtRUCCliente.Text = Trim(GenericRow!CedulaRUC.ToString)
            txtCorreoCliente.Text = Trim(GenericRow!Correo.ToString)
            ChkClienteActivo.Checked = CBool(GenericRow!Activo)
            ChkClienteExonerado.Checked = CBool(GenericRow!Exonerado)
            HADatosOLD = CrearHADatosOLD(GenericRow)
        End If

        Exit Sub
tipoerr:
        XtraMessageBox.Show(Err.Description, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

    Private Sub GVClientes_DoubleClick(sender As Object, e As EventArgs) Handles GVClientes.DoubleClick
        If GVClientes.RowCount = 0 Then Exit Sub
        txtIdCliente.Text = GVClientes.GetFocusedDataRow.Item("IdCliente").ToString
        XTCClientes.SelectedTabPage = XTPDatosCliente
    End Sub

    Private Sub GVClientes_KeyUp(sender As Object, e As KeyEventArgs) Handles GVClientes.KeyUp
        If GVClientes.RowCount = 0 Then Exit Sub
        txtIdCliente.Text = GVClientes.GetFocusedDataRow.Item("IdCliente").ToString
    End Sub
    Private Sub txtIdCliente_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtIdCliente.KeyPress
        If Asc(e.KeyChar) = 13 Then
            CargarDatosCliente()
            ChkClienteActivo.Focus()
        End If
    End Sub

    Private Sub txtIdCliente_TextChanged(sender As Object, e As EventArgs) Handles txtIdCliente.TextChanged
        CargarDatosCliente()
    End Sub

    Private Sub ChkClienteActivo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ChkClienteActivo.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtEmpresaCliente.Focus()
        End If
    End Sub

    Private Sub txtEmpresaCliente_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtEmpresaCliente.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtNombresCliente.Focus()
        End If
    End Sub

    Private Sub txtNombresCliente_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNombresCliente.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtApellidosCliente.Focus()
        End If
    End Sub

    Private Sub txtApellidosCliente_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtApellidosCliente.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtRUCCliente.Focus()
        End If
    End Sub

    Private Sub txtRUCCliente_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtRUCCliente.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtDirCliente.Focus()
        End If
    End Sub

    Private Sub txtDirCliente_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDirCliente.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtTelCliente.Focus()
        End If
    End Sub

    Private Sub txtTelCliente_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTelCliente.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtCorreoCliente.Focus()
        End If
    End Sub

    Private Sub txtCorreoCliente_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCorreoCliente.KeyPress
        If Asc(e.KeyChar) = 13 Then
            btnGuardar.PerformClick()
        End If
    End Sub
#End Region

    ' PROGRAMACION DEL CATALOGO DE PRODUCTOS
#Region "PROGRAMACION DEL CATALOGO DE PRODUCTOS"

    Private Sub LoadProductos()
        On Error GoTo tipoerr
        GCProductos.DataSource = BusquedaSeleccion("Select Productos.IdProducto, Productos.Producto, CategoriaProducto.Categoria, Marcas.Marca, Productos.Existencia, Productos.Precio1 as Precio from Productos INNER JOIN CategoriaProducto ON Productos.IdCategoria=CategoriaProducto.IdCategoria INNER JOIN Marcas ON Productos.IdMarca=Marcas.IdMarca ")

        LueCategorias.Properties.DataSource = BusquedaSeleccion("Select IdCategoria, Categoria from CategoriaProducto")
        LueCategorias.Properties.ValueMember = "IdCategoria"
        LueCategorias.Properties.DisplayMember = "Categoria"
        LueMarcas.Properties.DataSource = BusquedaSeleccion("Select IdMarca, Marca from Marcas")
        LueMarcas.Properties.ValueMember = "IdMarca"
        LueMarcas.Properties.DisplayMember = "Marca"

        LimpiarCamposProducto(True)
        Application.DoEvents()

        Exit Sub
tipoerr:
        XtraMessageBox.Show(Err.Description, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

    Private Sub LimpiarCamposProducto(ByVal limpiarcodigo As Boolean)
        If limpiarcodigo Then txtIdProducto.Text = ""
        txtProducto.Text = ""
        LueCategorias.EditValue = ""
        LueMarcas.EditValue = ""
        txtCosto.Text = ""
        txtPrecio1.Text = ""
        txtPrecio2.Text = ""
        txtPrecio3.Text = ""
        ChkProductoActivo.Checked = False
        ChkProductoExonerado.Checked = False
        ChkEsServicio.Checked = False
    End Sub

    Private Sub NuevoCodigoProducto()
        On Error GoTo tipoerr
        LimpiarCamposCliente(True)
        Dim NoDigito As Integer = CInt(BuscarRegistroSql("Empresa", "DigitoIdProducto", "1", "1"))
        txtIdProducto.Text = CodigoNuevo("Productos", "IdProducto", NoDigito)
        ChkProductoExonerado.Focus()
        Exit Sub
tipoerr:
        XtraMessageBox.Show(Err.Description, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

    Private Function ValidarDatosProducto() As Boolean
        ValidarDatosProducto = True
        If txtIdProducto.Text.Trim = "" Then
            XtraMessageBox.Show("El código de producto no puede quedar vacío", "Validar Datos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ValidarDatosProducto = False
            Exit Function
        End If

        If txtProducto.Text.Trim = "" Then
            XtraMessageBox.Show("El nombre de producto no puede quedar vacío", "Validar Datos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ValidarDatosProducto = False
            Exit Function
        End If

        If LueCategorias.EditValue.ToString = "" Then
            XtraMessageBox.Show("La categoría del producto no puede quedar vacía", "Validar Datos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ValidarDatosProducto = False
            Exit Function
        End If
        If LueMarcas.EditValue.ToString = "" Then
            XtraMessageBox.Show("La marca del producto no puede quedar vacío", "Validar Datos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ValidarDatosProducto = False
            Exit Function
        End If
        If txtCosto.Text.Trim = "" Then
            XtraMessageBox.Show("El costo del producto no puede quedar vacío", "Validar Datos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ValidarDatosProducto = False
            Exit Function
        End If
        If txtPrecio1.Text.Trim = "" Then
            XtraMessageBox.Show("El precio del producto no puede quedar vacío", "Validar Datos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ValidarDatosProducto = False
            Exit Function
        End If

    End Function

    Private Sub GuardarProducto()
        On Error GoTo tipoerr
        Dim IdDatos As String

        If Not ValidarDatosProducto() Then Exit Sub

        If BuscarRegistroSql("Productos", "IdProducto", "IdProducto", txtIdProducto.Text) = "" Then
            ExisteRegistro = False
        Else
            ExisteRegistro = True
        End If

        'Guardamos los datos del producto
        If ExisteRegistro Then
            CrearComando("UPDATE    Productos SET  IdCategoria = @IdCategoria, IdMarca = @IdMarca, Moneda = @Moneda, Producto = @Producto, Costo = @Costo, Precio1 = @Precio1, Precio2 = @Precio2, Precio3 = @Precio3, Exonerado = @Exonerado, Activo = @Activo, Servicio= @Servicio Where IdProducto = @IdProducto ")
        Else
            GenericSql = "INSERT INTO Productos (IdProducto, IdCategoria, IdMarca, Moneda, Producto, Costo, Precio1, Precio2, Precio3,  Exonerado, Activo, Servicio ) VALUES (@IdProducto, @IdCategoria, @IdMarca, @Moneda, @Producto, @Costo, @Precio1, @Precio2, @Precio3,  @Exonerado, @Activo, @Servicio ) "
            CrearComando(GenericSql)
        End If

        With Comando.Parameters
            .AddWithValue("IdProducto", txtIdProducto.Text)
            .AddWithValue("IdCategoria", LueCategorias.EditValue)
            .AddWithValue("IdMarca", LueMarcas.EditValue)
            .AddWithValue("Moneda", IIf(RDGMonedaProducto.SelectedIndex = 0, "US", "CS"))
            .AddWithValue("Producto", txtProducto.Text)
            .AddWithValue("Costo", txtCosto.Text)
            .AddWithValue("Precio1", txtPrecio1.Text)
            .AddWithValue("Precio2", txtPrecio2.Text)
            .AddWithValue("Precio3", txtPrecio3.Text)

            .AddWithValue("Exonerado", ChkProductoExonerado.Checked)
            .AddWithValue("Activo", ChkProductoActivo.Checked)
            .AddWithValue("Servicio", ChkEsServicio.Checked)

        End With
        If EjecutarComando() Then
            XtraMessageBox.Show("El Registro se ha guardado correctamente", "Datos Almacenados", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        LoadProductos()
        txtIdProducto.Focus()
        Exit Sub
tipoerr:
        XtraMessageBox.Show(Err.Description, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

    Private Sub EliminarProducto()
        On Error GoTo tipoerr
        Dim IdDatos As String
        If BuscarRegistroSql("Productos", "IdProducto", "IdProducto", txtIdProducto.Text) = "" Then
            XtraMessageBox.Show("El Registro que desea eliminar no existe!", "Registro inexistente", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        If HayRegistrosAnidados("DetalleVenta", "IdProducto", txtIdProducto.Text) Then
            XtraMessageBox.Show("No se puede eliminar el registro, está relacionado con otros registros.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        If HayRegistrosAnidados("DetalleAjuste", "IdProducto", txtIdProducto.Text) Then
            XtraMessageBox.Show("No se puede eliminar el registro, está relacionado con otros registros.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        If HayRegistrosAnidados("DetalleCompra", "IdProducto", txtIdProducto.Text) Then
            XtraMessageBox.Show("No se puede eliminar el registro, está relacionado con otros registros.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        If HayRegistrosAnidados("DetalleRemision", "IdProducto", txtIdProducto.Text) Then
            XtraMessageBox.Show("No se puede eliminar el registro, está relacionado con otros registros.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If


        ResultMsg = XtraMessageBox.Show(String.Format("¿Desea eliminar el registro: {0}?", txtProducto.Text.Trim), "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If ResultMsg <> vbYes Then Exit Sub
        GenericSql = String.Format("DELETE FROM Productos WHERE idProducto= '{0}'", txtIdProducto.Text.Trim)
        If EjecutarConsulta(GenericSql) Then
            XtraMessageBox.Show("El Registro se ha eliminado correctamente", "Datos Eliminados", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        LoadProductos()
        txtIdProducto.Focus()
        Exit Sub
tipoerr:
        XtraMessageBox.Show(Err.Description, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

    Private Sub CargarDatosProducto()
        On Error GoTo tipoerr

        LimpiarCamposProducto(False) 'limpiamos los campos menos el código
        GenericRow = BusquedaSeleccionFila(String.Format("Select * from Productos WHERE Productos.IdProducto= '{0}'", txtIdProducto.Text))
        If Not IsNothing(GenericRow) Then
            txtProducto.Text = Trim(GenericRow!Producto.ToString)
            LueCategorias.EditValue = Trim(GenericRow!IdCategoria.ToString)
            LueMarcas.EditValue = Trim(GenericRow!IdMarca.ToString)
            txtCosto.Text = Trim(GenericRow!Costo.ToString)
            txtPrecio1.Text = Trim(GenericRow!Precio1.ToString)
            txtPrecio2.Text = Trim(GenericRow!Precio2.ToString)
            txtPrecio3.Text = Trim(GenericRow!Precio3.ToString)
            RDGMonedaProducto.SelectedIndex = CInt(IIf(GenericRow!Moneda = "US", 0, 1))
            ChkProductoActivo.Checked = CBool(GenericRow!Activo)
            ChkProductoExonerado.Checked = CBool(GenericRow!Exonerado)
            ChkEsServicio.Checked = CBool(GenericRow!Servicio)
            HADatosOLD = CrearHADatosOLD(GenericRow)
        End If

        Exit Sub
tipoerr:
        XtraMessageBox.Show(Err.Description, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub
    Private Sub txtIdProducto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtIdProducto.KeyPress
        If Asc(e.KeyChar) = 13 Then
            CargarDatosProducto()
            ChkProveedorActivo.Focus()
        End If
    End Sub

    Private Sub txtIdProducto_TextChanged(sender As Object, e As EventArgs) Handles txtIdProducto.TextChanged
        CargarDatosProducto()
    End Sub

    Private Sub ChkProductoActivo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ChkProductoActivo.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtProducto.Focus()
        End If
    End Sub

    Private Sub txtProducto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtProducto.KeyPress
        If Asc(e.KeyChar) = 13 Then
            LueCategorias.Focus()
        End If
    End Sub

    Private Sub LueCategorias_KeyPress(sender As Object, e As KeyPressEventArgs) Handles LueCategorias.KeyPress
        If Asc(e.KeyChar) = 13 Then
            LueMarcas.Focus()
        End If
    End Sub

    Private Sub LueMarcas_KeyPress(sender As Object, e As KeyPressEventArgs) Handles LueMarcas.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtCosto.Focus()
        End If
    End Sub

    Private Sub txtCosto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCosto.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtPrecio1.Focus()
        Else
            ValidarNumeroDecimal(txtCosto.Text, e)
        End If
    End Sub

    Private Sub txtPrecio1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPrecio1.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtPrecio2.Focus()
        Else
            ValidarNumeroDecimal(txtPrecio1.Text, e)
        End If
    End Sub

    Private Sub txtPrecio2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPrecio2.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtPrecio3.Focus()
        Else
            ValidarNumeroDecimal(txtPrecio2.Text, e)
        End If
    End Sub

    Private Sub txtPrecio3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPrecio3.KeyPress
        If Asc(e.KeyChar) = 13 Then
            RDGMonedaProducto.Focus()
        Else
            ValidarNumeroDecimal(txtPrecio3.Text, e)
        End If
    End Sub
    Private Sub GVProductos_DoubleClick(sender As Object, e As EventArgs) Handles GVProductos.DoubleClick
        If GVProductos.RowCount = 0 Then Exit Sub
        txtIdProducto.Text = GVProductos.GetFocusedDataRow.Item("IdProducto").ToString
        XTCProductos.SelectedTabPage = XTPDatosProducto
    End Sub
#End Region



















End Class