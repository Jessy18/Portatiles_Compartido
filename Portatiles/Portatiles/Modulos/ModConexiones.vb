Imports System.Data.SqlClient
Imports System.Data
Imports System.Windows.Forms
Imports DevExpress.XtraEditors

Module ModConexiones
    'Dim CadenaConexion As String = My.Settings.ConexionBD
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
            XtraMessageBox.Show("Error al conectar a la BD!" & vbNewLine & "Mensaje del Error: " & ex.Message, "Problemas", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
            XtraMessageBox.Show("Error al conectar a la BD!" & vbNewLine & "Mensaje del Error: " & ex.Message, "Problemas", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
            XtraMessageBox.Show("Error al conectar a la BD!" & vbNewLine & "Mensaje del Error: " & ex.Message, "Problemas", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
            XtraMessageBox.Show("Error al conectar a la BD!" & vbNewLine & "Mensaje del Error: " & ex.Message, "Problemas", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
            XtraMessageBox.Show("Error al conectar a la BD!" & vbNewLine & "Mensaje del Error: " & ex.Message, "Problemas", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Conexion.Dispose()
            Conexion.Close()
        End Try
    End Sub

    Public Sub AbrirTransaccion()
        Try
            Conexion = New SqlConnection(CadenaConexion) 'instanciamos la conexion
            Conexion.Open() 'Se apertura la conexion
            Transaccion = Conexion.BeginTransaction() 'Se apertura la transaccion con la conexion ABIERTA
            Comando = New SqlCommand() 'Se instancia el comando
            Comando.Connection = Conexion 'Se le asigna la conexion al comando
            'la conexion del comando permanece abierta
            Comando.Transaction = Transaccion 'y al comando se le asigna la Transaccion
            'es decir, que hay una relacion COMANDO - TRANSACCION, todo lo que se vaya insertando en 
            'el comando, se va a ejecutar cuando se haga COMMIT en la transaccion, bien
        Catch ex As Exception
            XtraMessageBox.Show("Error al conectar a la BD!" & vbNewLine & "Mensaje del Error: " & ex.Message, "Problemas", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Conexion.Dispose()
            Conexion.Close()
        End Try
    End Sub

    Public Sub CommitTransaccion()
        Try
            If Conexion.State = ConnectionState.Open Then 'se supone que todo el tiempo que desde que se abrio la transact, la conex permanecio abierta
                Transaccion.Commit() 'una vez que se hace commit, ya no se podrà revertir las operaciones
                'ACA LOS CAMBIOS YA SE APLICARON, cuando paso por el COMMIT
                Comando.Connection.Close() 'y cuando le dimos commit, procedemos a cerrar todas las conexiones y a liberar memoria, vale?ok totalmene
                Conexion.Close()
                Transaccion.Dispose()
                Conexion.Dispose()
            End If

        Catch ex As Exception
            XtraMessageBox.Show("Error al Guardar los Cambios a la BD!" & vbNewLine & "Mensaje del Error: " & ex.Message, "Problemas", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Conexion.Dispose()
            Conexion.Close()
        End Try
    End Sub

    Public Sub RevertirTransaccion(ByVal ErrorMessage As String)
        Try
            If Conexion.State = ConnectionState.Open Then
                Transaccion.Rollback() 'hay dos cosas que cambian con respecto al commit, primero que aqui se hace un ROLLBACK
                'segundo, si te fijas, recibe un parametro, es el mensaje de error que dice por que se tuvo que revertir la transaccion, y se muestra
                'en un Message BOX

                XtraMessageBox.Show("Han ocurrido errores en las operaciones.!" & vbNewLine & "Mensaje del Error: " & ErrorMessage, "Reversión de Datos exitosa", MessageBoxButtons.OK, MessageBoxIcon.Warning)

                Comando.Connection.Close()
                Conexion.Close()
                Transaccion.Dispose()
                Conexion.Dispose()
            End If

        Catch ex As Exception
            XtraMessageBox.Show("Error al Revertir los Cambios!" & vbNewLine & "Mensaje del Error: " & ex.Message, "Problemas", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Conexion.Dispose()
            Conexion.Close()
        End Try
    End Sub

End Module
