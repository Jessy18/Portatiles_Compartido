Imports System.Data.SqlClient

Module ModVariables
    Public Comando As SqlCommand
    Public ExisteRegistro As Boolean
    Public GenericSql As String
    Public GenericRow As DataRow
    Public ResultMsg As Integer

    'Variables de Sesión de usuario
    Public CodUsuario As String
    Public Usuario As String
    Public CodSucursal As String
    Public Administrador As Boolean

    'Variables de configuración de empresa
    Public Empresa As String
    Public RazonSocial As String
    Public RUCEmpresa As String
    Public DirEmpresa As String
    Public TelEmpresa As String
    Public ChequeA As String
    Public IVA As Double = 0
    'Variables comunes
    Public ClaveBusqueda As String = ""
    Public MovimientoListado As String = ""
    Public CodigoGenerico As String = ""
    Public DtSeleccion As DataTable

    'Variables de documentos a editar
    Public NumAjuste As String = ""
    Public NumRemision As String = ""
    Public NumCompra As String = ""
    Public NumVenta As String = ""

    'Variable de Historial Acciones
    Public HADatosOLD As String = ""
    Public HADatosNEW As String = ""

End Module
