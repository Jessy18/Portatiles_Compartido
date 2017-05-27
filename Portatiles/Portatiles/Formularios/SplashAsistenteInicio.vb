Public Class SplashAsistenteInicio


    Sub New()
        InitializeComponent()
    End Sub

    Public Overrides Sub ProcessCommand(ByVal cmd As System.Enum, ByVal arg As Object)
        MyBase.ProcessCommand(cmd, arg)

      
    End Sub

    Public Enum SplashScreenCommand
        SomeCommandId
    End Enum


    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Application.Exit()
    End Sub

    Private Sub BtnEmpresa_Click(sender As Object, e As EventArgs) Handles BtnEmpresa.Click
        Me.Dispose()
        Me.Close()
    End Sub
End Class
