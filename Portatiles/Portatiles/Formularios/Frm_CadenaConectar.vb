Imports DevExpress.XtraEditors

Public Class Frm_CadenaConectar

    Private Sub Frm_CadenaConectar_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        cmbDevelopers.Focus()
    End Sub

    Private Sub Conectar()
        On Error GoTo ErrExcepcion
        Select Case cmbDevelopers.Text
            Case "Jessenia Collado"
                CadenaConexion = My.Settings.ConexionJCC
            Case "Esdrey Gómez"
                CadenaConexion = My.Settings.ConexionEAGM
            Case "Ariel Dávila"
                CadenaConexion = My.Settings.ConexionAADG
        End Select

        Me.Close()
        Me.Dispose()

        Exit Sub
ErrExcepcion:
        XtraMessageBox.Show("Error Nº" & Err.Number & ": " & Environment.NewLine & Err.Description, "Ha ocurrido un error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

    Private Sub btnConectar_Click(sender As Object, e As EventArgs) Handles btnConectar.Click
        Conectar()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub cmbDevelopers_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmbDevelopers.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Conectar()
        End If
    End Sub

    Private Sub Frm_CadenaConectar_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class