Imports System.IO
Imports DevExpress.XtraEditors
Public Class FrmInicioSesion
    Dim RutaRecordarUsuario As String = System.Environment.CurrentDirectory & "\RecordarUsuario.txt"
    Dim reader As StreamReader
    Dim writer As StreamWriter

    Private Sub SBtnCancelar_Click(sender As Object, e As EventArgs) Handles SBtnCancelar.Click
        Me.Dispose()
        Me.Close()

    End Sub

    Private Sub FrmInicioSesion_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub FrmInicioSesion_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        On Error GoTo ErrorException

        If Not File.Exists(RutaRecordarUsuario) Then
            File.Create(RutaRecordarUsuario)
        Else
            reader = New StreamReader(RutaRecordarUsuario)
            TxtUsuario.Text = reader.ReadLine
            reader.Close()
            reader.Dispose()
            If Not TxtUsuario.Text = "" Then
                chkRecordarUsuario.Checked = True
                TxtPass.Focus()
            End If

        End If
        Exit Sub
ErrorException:
        XtraMessageBox.Show(Err.Description, "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub
    Private Sub SBtnIngresar_Click(sender As Object, e As EventArgs) Handles SBtnIngresar.Click

        Dim Consulta As String
        Dim DRUsuario As DataRow

        Try
            If PuedeProceder() Then
                Consulta = String.Format("Select * from Usuarios Where Nombre ='{0}' AND Clave ='{1}'", TxtUsuario.Text, TxtPass.Text)
                DRUsuario = BusquedaSeleccionFila(Consulta)

                If Not DRUsuario Is Nothing Then
                    If CBool(DRUsuario!Activo) Then
                        CodUsuario = DRUsuario!IdUsuario.ToString
                        CodSucursal = DRUsuario!IdSucursal.ToString
                        Administrador = CBool(DRUsuario!Administrador)

                        If chkRecordarUsuario.Checked Then
                            writer = New StreamWriter(RutaRecordarUsuario, False, System.Text.ASCIIEncoding.ASCII)
                            writer.WriteLine(TxtUsuario.Text.Trim)
                            writer.Close()
                        Else
                            writer = New StreamWriter(RutaRecordarUsuario, False, System.Text.ASCIIEncoding.ASCII)
                            writer.WriteLine("")
                            writer.Close()
                        End If

                    Else
                        DevExpress.XtraEditors.XtraMessageBox.Show("El usuario está inactivo", "Cierre del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        CodUsuario = Nothing
                    End If
                    Me.Close()
                End If
                DevExpress.XtraEditors.XtraMessageBox.Show("Usuario y/o clave incorrecta", "Datos inválidos", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.TxtUsuario.Text = ""
                Me.TxtPass.Text = ""
            End If

        Catch ex As Exception

        End Try


    End Sub

    Private Function PuedeProceder() As Boolean
        PuedeProceder = True
        'Valido que ingrese el usuario
        If TxtUsuario.Text = "" Then
            DevExpress.XtraEditors.XtraMessageBox.Show("Ingrese el usuario.")
            PuedeProceder = False
            Exit Function
        End If
        'Valido que ingrese la contraseña
        If TxtPass.Text = "" Then
            DevExpress.XtraEditors.XtraMessageBox.Show("Ingrese la clave para acceder.")
            PuedeProceder = False
            Exit Function
        End If
        'Valido que exista el registro de usuario
        If TxtUsuario.Text <> "" Then
            If BuscarRegistroSql("Usuarios", "Nombre", "Nombre", TxtUsuario.Text) = "" Then
                PuedeProceder = False
                Exit Function
            End If

        End If

    End Function

    Private Sub TxtUsuario_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtUsuario.KeyPress
        If Asc(e.KeyChar) = 13 Then
            TxtPass.Focus()
        End If
    End Sub

    Private Sub TxtPass_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtPass.KeyPress
        If Asc(e.KeyChar) = 13 Then
            SBtnIngresar.PerformClick()
        End If
    End Sub
End Class