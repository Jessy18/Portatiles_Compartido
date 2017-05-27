Module ModArranqueSistema
    Sub Main()
        Dim Present As New FrmPresentacion
        Present.Show()
        System.Threading.Thread.Sleep(2000)
        Present.Dispose()
        Present.Close()
        Application.DoEvents()

        If VerificarInicio() = False Then
            Application.Run(SplashAsistenteInicio)

            Application.Run(FrmAsistenteConfiguracion)
        End If

        Application.Run(FrmInicioSesion)
        If Not CodUsuario Is Nothing Then
            RFMDI.ShowDialog()
        End If
    End Sub
End Module
