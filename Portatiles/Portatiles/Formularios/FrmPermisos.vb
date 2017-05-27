Imports System.IO
Imports DevExpress.XtraEditors

Public Class FrmPermisos

    'Por cada pestaña creada en el MDI, crear un datatable y agregar los formularios
    Dim DtMovimientos As DataTable
    Dim DtListados As DataTable
    Dim DtCatalogos As DataTable
    Dim DtHerramientas As DataTable

    ''' <summary>
    ''' Este método inicializa todos los Datatables existentes
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub CrearDataTables()
        'MOVIMIENTOS
        DtMovimientos = New DataTable()
        DtMovimientos.Columns.Add("Formulario", GetType(String))
        DtMovimientos.Columns.Add("Acceso", GetType(Boolean))
        DtMovimientos.Columns(0).Caption = "Módulo"
        gcMov.DataSource = DtMovimientos
        FormatoGridControl(gvMov)

        'LISTADOS
        DtListados = New DataTable()
        DtListados.Columns.Add("Formulario", GetType(String))
        DtListados.Columns.Add("Acceso", GetType(Boolean))
        DtListados.Columns(0).Caption = "Módulo"
        gcListados.DataSource = DtListados
        FormatoGridControl(gvListados)

        'CATALOGOS
        DtCatalogos = New DataTable()
        DtCatalogos.Columns.Add("Formulario", GetType(String))
        DtCatalogos.Columns.Add("Acceso", GetType(Boolean))
        DtCatalogos.Columns(0).Caption = "Módulo"
        gcCatalogos.DataSource = DtCatalogos
        FormatoGridControl(gvCatalogos)

        'HERRAMIENTAS
        DtHerramientas = New DataTable()
        DtHerramientas.Columns.Add("Formulario", GetType(String))
        DtHerramientas.Columns.Add("Acceso", GetType(Boolean))
        DtHerramientas.Columns(0).Caption = "Módulo"
        gcHerram.DataSource = DtHerramientas
        FormatoGridControl(gvHerram)
    End Sub

    Private Sub FormatoGridControl(ByVal Grid As DevExpress.XtraGrid.Views.Grid.GridView)
        Grid.Columns(0).Width = 450
        Grid.Columns(1).Width = 75

        Grid.Columns(0).OptionsColumn.AllowEdit = False
        Grid.Columns(1).OptionsColumn.AllowEdit = True
    End Sub

    ''' <summary>
    ''' Este método crea los formularios que pertenecen a cada módulo
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub LlenarDataTables()
        'Movimientos
        DtMovimientos.Rows.Add({"Facturación", False})
        DtMovimientos.Rows.Add({"Compras", False})
        DtMovimientos.Rows.Add({"Remisiones", False})
        DtMovimientos.Rows.Add({"Ajustes de Inventario", False})
        DtMovimientos.AcceptChanges()

        'Listados
        DtListados.Rows.Add({"Listado de Facturas", False})
        DtListados.Rows.Add({"Listado de Remisiones", False})
        DtListados.Rows.Add({"Listado de Compras", False})
        DtListados.Rows.Add({"Listado de Ajustes de Inventario", False})
        DtListados.AcceptChanges()

        'Catálogos
        DtCatalogos.Rows.Add({"Catálogos", False})
        DtCatalogos.AcceptChanges()

        'Herramientas
        DtHerramientas.Rows.Add({"Configuración", False})
        DtHerramientas.Rows.Add({"Importador", False})
        DtHerramientas.AcceptChanges()

    End Sub

    Private Sub Permisos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        On Error GoTo Exception

        CrearDataTables()
        LlenarDataTables()

        LueUsuario.Properties.DataSource = BusquedaSeleccion("Select IDUsuario, Nombre from Usuarios Where Activo = 1")
        LueUsuario.Properties.ValueMember = "IDUsuario"
        LueUsuario.Properties.DisplayMember = "Nombre"
        LueUsuario.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup


        Exit Sub
Exception:
        XtraMessageBox.Show(Err.Description, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

    

    Private Sub btnBuscarUser_Click(sender As Object, e As EventArgs) Handles btnBuscarUser.Click
        ClaveBusqueda = "Usuarios"
        FrmBusqueda.ShowDialog()
        If Not CodigoGenerico.Trim = "" Then
            LueUsuario.EditValue = CodigoGenerico
            Exit Sub
        End If
        
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Dispose()
        Me.Close()
    End Sub

    ''' <summary>
    ''' 1er ForEach: Recorre el datatables del formulario
    ''' 2do ForEach: Recorre el datatable que tiene los datos de la BD
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub LueUsuario_EditValueChanged(sender As Object, e As EventArgs) Handles LueUsuario.EditValueChanged
        On Error GoTo Exception

        CrearDataTables()
        LlenarDataTables()

        Dim DtPermisos As DataTable

        If LueUsuario.Text = "" Then Exit Sub

        DtPermisos = BusquedaSeleccion("Select * From ModuleUserAccess Where IdUsuario = '" & LueUsuario.EditValue.ToString & "'")
        If DtPermisos.Rows.Count > 0 Then

            'Movimientos - 
            For Each frm As DataRow In DtMovimientos.Rows
                For Each BDfrm As DataRow In DtPermisos.Rows
                    If frm!Formulario.ToString = BDfrm!Formulario.ToString Then
                        frm.BeginEdit()
                        frm!Acceso = BDfrm!Acceso
                        frm.EndEdit()
                        frm.AcceptChanges()
                        Exit For
                    End If
                Next
            Next

            'Listados
            For Each frm As DataRow In DtListados.Rows
                For Each BDfrm As DataRow In DtPermisos.Rows
                    If frm!Formulario.ToString = BDfrm!Formulario.ToString Then
                        frm.BeginEdit()
                        frm!Acceso = BDfrm!Acceso
                        frm.EndEdit()
                        frm.AcceptChanges()
                        Exit For
                    End If
                Next
            Next

            'Catálogos
            For Each frm As DataRow In DtCatalogos.Rows
                For Each BDfrm As DataRow In DtPermisos.Rows
                    If frm!Formulario.ToString = BDfrm!Formulario.ToString Then
                        frm.BeginEdit()
                        frm!Acceso = BDfrm!Acceso
                        frm.EndEdit()
                        frm.AcceptChanges()
                        Exit For
                    End If
                Next
            Next

            'Herramientas
            For Each frm As DataRow In DtHerramientas.Rows
                For Each BDfrm As DataRow In DtPermisos.Rows
                    If frm!Formulario.ToString = BDfrm!Formulario.ToString Then
                        frm.BeginEdit()
                        frm!Acceso = BDfrm!Acceso
                        frm.EndEdit()
                        frm.AcceptChanges()
                        Exit For
                    End If
                Next
            Next
        End If


        Exit Sub
Exception:
        XtraMessageBox.Show(Err.Description, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        On Error GoTo Exception

        If LueUsuario.Text = "" Then
            XtraMessageBox.Show("No ha Seleccionado al Usuario", "Seleccione un Usuario", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        'Primero eliminamos sus permisos previos
        EjecutarConsulta("Delete From ModuleUserAccess Where IdUsuario = '" & LueUsuario.EditValue.ToString & "'")

        'Movimientos
        For Each frm As DataRow In DtMovimientos.Rows
            Me.GuardarPermiso("Movimientos", frm!Formulario.ToString(), CBool(frm!Acceso))
        Next

        'Listados
        For Each frm As DataRow In DtListados.Rows
            Me.GuardarPermiso("Listados", frm!Formulario.ToString(), CBool(frm!Acceso))
        Next

        'Catálogos
        For Each frm As DataRow In DtCatalogos.Rows
            Me.GuardarPermiso("Catálogos", frm!Formulario.ToString(), CBool(frm!Acceso))
        Next

        'Herramientas
        For Each frm As DataRow In DtHerramientas.Rows
            Me.GuardarPermiso("Herramientas", frm!Formulario.ToString(), CBool(frm!Acceso))
        Next

        XtraMessageBox.Show("Los Permisos se han actualizado correctamente", "Permisos Actualizados", MessageBoxButtons.OK, MessageBoxIcon.Information)
        LueUsuario.EditValue = Nothing
        chkAccesoTotal.Checked = False
        xtcPermisos.SelectedTabPageIndex = 0

        Exit Sub
Exception:
        XtraMessageBox.Show(Err.Description, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

    Private Sub GuardarPermiso(ByVal Modulo As String, ByVal Formulario As String, ByVal Acceso As Boolean)
        GenericSql = "INSERT INTO ModuleUserAccess (idUsuario, Modulo, Formulario, Acceso) VALUES (@idUsuario,@Modulo,@Formulario,@Acceso)"
        CrearComando(GenericSql)
        Comando.Parameters.AddWithValue("idUsuario", LueUsuario.EditValue)
        Comando.Parameters.AddWithValue("Modulo", Modulo)
        Comando.Parameters.AddWithValue("Formulario", Formulario)
        Comando.Parameters.AddWithValue("Acceso", Acceso)
        EjecutarComando()
    End Sub

#Region "EVENTOS DE CHECK"

    Private Sub chkTodos1_CheckedChanged(sender As Object, e As EventArgs) Handles chkTodos1.CheckedChanged
        For Each frm As DataRow In DtMovimientos.Rows
            frm.BeginEdit()
            If chkTodos1.Checked Then
                frm!Acceso = True
            Else
                frm!Acceso = False
            End If
            frm.EndEdit()
            frm.AcceptChanges()
        Next
    End Sub

    Private Sub chkTodos3_CheckedChanged(sender As Object, e As EventArgs) Handles chkTodos3.CheckedChanged
        For Each frm As DataRow In DtListados.Rows
            frm.BeginEdit()
            If chkTodos3.Checked Then
                frm!Acceso = True
            Else
                frm!Acceso = False
            End If
            frm.EndEdit()
            frm.AcceptChanges()
        Next
    End Sub

    Private Sub chkTodos2_CheckedChanged(sender As Object, e As EventArgs) Handles chkTodos2.CheckedChanged
        For Each frm As DataRow In DtCatalogos.Rows
            frm.BeginEdit()
            If chkTodos2.Checked Then
                frm!Acceso = True
            Else
                frm!Acceso = False
            End If
            frm.EndEdit()
            frm.AcceptChanges()
        Next
    End Sub

    Private Sub chkTodos4_CheckedChanged(sender As Object, e As EventArgs) Handles chkTodos4.CheckedChanged
        For Each frm As DataRow In DtHerramientas.Rows
            frm.BeginEdit()
            If chkTodos4.Checked Then
                frm!Acceso = True
            Else
                frm!Acceso = False
            End If
            frm.EndEdit()
            frm.AcceptChanges()
        Next
    End Sub

    Private Sub chkAccesoTotal_CheckedChanged(sender As Object, e As EventArgs) Handles chkAccesoTotal.CheckedChanged
        If chkAccesoTotal.Checked Then
            chkTodos1.Checked = True
            chkTodos2.Checked = True
            chkTodos3.Checked = True
            chkTodos4.Checked = True
        Else
            chkTodos1.Checked = False
            chkTodos2.Checked = False
            chkTodos3.Checked = False
            chkTodos4.Checked = False
        End If

    End Sub

#End Region


End Class