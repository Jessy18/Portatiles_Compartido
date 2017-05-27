Public Class FrmAsistenteConfiguracion
    Dim Pag1, Pag2, Pag3 As Boolean

    Private Sub FrmAsistenteConfiguracion_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        VerificarConfiguracion()
    End Sub

    Private Sub VerificarConfiguracion()

        Dim DrConfig As DataRow

        DrConfig = BusquedaSeleccionFila("Select Top 1 * from Empresa")

        If DrConfig Is Nothing Then
            Pag1 = True
            Pag2 = False
            Pag3 = False

        Else
            Pag1 = False
            Pag2 = True
            Pag3 = False
        End If
        VerPestanas()
    End Sub

    Private Sub VerPestanas()
        XTPEmpresa.PageVisible = Pag1
        XTPSucursal.PageVisible = Pag2
        XTPUsuarios.PageVisible = Pag3
        PE1.Visible = Pag1
        PE2.Visible = Pag2
        PE3.Visible = Pag3

    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs)
        Me.Dispose()
        Me.Close()
    End Sub

    Private Sub BtnEmpresa_Click(sender As Object, e As EventArgs) Handles BtnEmpresa.Click
        If txtNombreEmpresa.Text.Trim = "" Then
            DevExpress.XtraEditors.XtraMessageBox.Show("Ingrese el nombre de empresa ", "Validar Datos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        If txtRazonSocial.Text.Trim = "" Then
            DevExpress.XtraEditors.XtraMessageBox.Show("Ingrese la razón social ", "Validar Datos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        If txtRUC.Text.Trim = "" Then
            DevExpress.XtraEditors.XtraMessageBox.Show("Ingrese el número ruc de la empresa ", "Validar Datos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        If txtDireccion.Text.Trim = "" Then
            DevExpress.XtraEditors.XtraMessageBox.Show("Ingrese la dirección de la empresa ", "Validar Datos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        If txtTelefonos.Text.Trim = "" Then
            DevExpress.XtraEditors.XtraMessageBox.Show("Ingrese el teléfono de la empresa ", "Validar Datos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        If txtChequeNombre.Text.Trim = "" Then
            DevExpress.XtraEditors.XtraMessageBox.Show("Ingrese beneficiario de cheque de la empresa ", "Validar Datos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        GenericSql = "INSERT INTO Empresa (NombreEmpresa, RazonSocial, RUC, Direccion, Telefonos, ChequeANombre) VALUES (@NombreEmpresa, @RazonSocial, @RUC, @Direccion, @Telefonos, @ChequeANombre) "
        CrearComando(GenericSql)

        With Comando.Parameters
            .AddWithValue("NombreEmpresa", txtNombreEmpresa.Text)
            .AddWithValue("RazonSocial", txtRazonSocial.Text)
            .AddWithValue("RUC", txtRUC.Text.Trim)
            .AddWithValue("Direccion", txtDireccion.Text)
            .AddWithValue("Telefonos", txtTelefonos.Text)
            .AddWithValue("ChequeANombre", txtChequeNombre.Text)

        End With
        If EjecutarComando() Then
            Pag1 = False
            Pag2 = True
            Pag3 = False
            VerPestanas()
        End If
    End Sub

    Private Sub BtnSucursal_Click(sender As Object, e As EventArgs) Handles BtnSucursal.Click
        If txtSucursal.Text.Trim = "" Then
            DevExpress.XtraEditors.XtraMessageBox.Show("Ingrese el nombre de la sucursal ", "Validar Datos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        If txtDirSucursal.Text.Trim = "" Then
            DevExpress.XtraEditors.XtraMessageBox.Show("Ingrese la dirección de la sucursal ", "Validar Datos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        GenericSql = "INSERT INTO Sucursales (IdSucursal,IdEmpresa,Sucursal,DirSucursal,Activa) VALUES (@IdSucursal,@IdEmpresa,@Sucursal,@DirSucursal,@Activa) "
        CrearComando(GenericSql)

        With Comando.Parameters
            .AddWithValue("IdEmpresa", BusquedaSeleccionFila("Select * from Empresa")!IdEmpresa)
            .AddWithValue("IdSucursal", CodigoNuevo("Sucursales", "IdSucursal", 3))
            .AddWithValue("Sucursal", txtSucursal.Text)
            .AddWithValue("DirSucursal", txtDirSucursal.Text.Trim)
            .AddWithValue("Activa", True)

        End With
        If EjecutarComando() Then
            Pag1 = False
            Pag2 = False
            Pag3 = True
            VerPestanas()
        End If
    End Sub


    Private Sub XTPUsuarios_VisibleChanged(sender As Object, e As EventArgs) Handles XTPUsuarios.VisibleChanged
        Dim DtRegistros As DataTable
        DtRegistros = BusquedaSeleccion("Select * from Usuarios")

        If DtRegistros.Rows.Count > 0 Then
            Me.Dispose()
            Me.Close()
        End If
    End Sub


    Private Sub BtnFin_Click(sender As Object, e As EventArgs) Handles BtnFin.Click
        If txtUsuario.Text.Trim = "" Then
            DevExpress.XtraEditors.XtraMessageBox.Show("Ingrese el nombre de usuario ", "Validar Datos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        If txtClave.Text.Trim = "" Then
            DevExpress.XtraEditors.XtraMessageBox.Show("Ingrese la clave de usuario ", "Validar Datos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        GenericSql = "INSERT INTO Usuarios (IDUsuario, IdSucursal, Nombre, Clave, Activo, Administrador) VALUES  (@IDUsuario, @IdSucursal, @Nombre, @Clave, @Activo,  @Administrador) "
        CrearComando(GenericSql)

        With Comando.Parameters
            .AddWithValue("IDUsuario", CodigoNuevo("Usuarios", "IDUsuario", 3))
            .AddWithValue("IdSucursal", BusquedaSeleccion("Select * from Sucursales").Rows(0)!IdSucursal)
            .AddWithValue("Nombre", txtUsuario.Text.Trim)
            .AddWithValue("Clave", txtClave.Text)
            .AddWithValue("Activo", True)
            .AddWithValue("Administrador", True)

        End With
        If EjecutarComando() Then
            'VerPestanas(False, False, True)
            Me.Dispose()
            Me.Close()
        End If
    End Sub

    Private Sub XTPSucursal_VisibleChanged(sender As Object, e As EventArgs) Handles XTPSucursal.VisibleChanged
        Dim DtRegistros As DataTable
        DtRegistros = BusquedaSeleccion("Select * from Sucursales")

        If DtRegistros.Rows.Count > 0 Then
            Pag1 = False
            Pag2 = False
            Pag3 = True
            VerPestanas()
            txtSucursal.Text = DtRegistros.Rows(0)!Sucursal.ToString
            txtDirSucursal.Text = DtRegistros.Rows(0)!DirSucursal.ToString
        End If
    End Sub

    Private Sub BtnCancelar_Click_1(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Me.Dispose()
        Me.Close()
    End Sub
End Class