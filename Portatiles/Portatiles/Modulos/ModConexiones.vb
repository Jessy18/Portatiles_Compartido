Imports System.Data.SqlClient
Imports System.Data
Imports System.Windows.Forms

Module ModConexiones
    Dim CadenaConexion As String = My.Settings.ConexionBD
    Dim Conexion As SqlConnection
    Dim DtRetorno As DataTable

    Public Function BusquedaSeleccion(ByVal Cadena As String) As DataTable
        DtRetorno = New DataTable
        Try
            'aperturamos la conexion
            Conexion = New SqlConnection(CadenaConexion)
            Dim Adapter As New SqlDataAdapter(Cadena, Conexion)
            Adapter.Fill(DtRetorno)

        Catch ex As Exception

        Finally
            Conexion.Dispose()
            Conexion.Close()
        End Try
        Return DtRetorno

    End Function

    Public Function BusquedaSeleccionFila(ByVal Cadena As String) As DataRow
        DtRetorno = New DataTable
        Try
            'aperturamos la conexion
            Conexion = New SqlConnection(CadenaConexion)
            Dim Adapter As New SqlDataAdapter(Cadena, Conexion)
            Adapter.Fill(DtRetorno)

        Catch ex As Exception

        Finally
            Conexion.Dispose()
            Conexion.Close()
        End Try
        If DtRetorno.Rows.Count > 0 Then
            Return DtRetorno.Rows(0)
        Else
            Return Nothing
        End If


    End Function

    Public Function EjecutarConsulta(ByVal Consulta As String) As Boolean
        Dim ComandoEjecutar As New SqlCommand
        Dim Devolver As Boolean = False
        Try
            'aperturamos la conexion
            Conexion = New SqlConnection(CadenaConexion)
            ComandoEjecutar = New SqlCommand(Consulta, Conexion)
            'aperturamos la conexion del comando
            ComandoEjecutar.Connection.Open()
            If ComandoEjecutar.ExecuteNonQuery() > 0 Then
                Devolver = True
            Else
                Devolver = False
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ComandoEjecutar.Connection.Dispose()
            ComandoEjecutar.Connection.Close()
            Conexion.Dispose()
            Conexion.Close()
        End Try
        Return Devolver
    End Function

    Public Function EjecutarComando() As Boolean
        Dim Devolver As Boolean = False
        Try
            'aperturamos la conexion del comando
            Comando.Connection.Open()
            Comando.CommandType = CommandType.Text
            If Comando.ExecuteNonQuery() > 0 Then
                Devolver = True
            Else
                Devolver = False
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            'Comando.Connection.Dispose()
            Comando.Connection.Close()
        End Try
        Return Devolver
    End Function

    Public Sub CrearComando(ByVal Cadena As String)
        Try
            'aperturamos la conexion
            Conexion = New SqlConnection(CadenaConexion)
            Comando = New SqlCommand(Cadena, Conexion)
        Catch ex As Exception
            Conexion.Dispose()
            Conexion.Close()
        End Try
    End Sub
End Module
