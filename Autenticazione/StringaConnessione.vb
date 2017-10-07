Imports MySql.Data.MySqlClient

Public Class StringaConnessione
    Shared str As String
    Private Shared setted As Integer = 0
    Public Sub New()

    End Sub

    ReadOnly Property conn() As String
        Get
            Return str
        End Get
    End Property
    Public Sub SetLock()
        setted = 3
    End Sub

    Public Sub Sett(ByVal NomeUtente As String, ByVal Password As String, ByVal Server As String, ByVal Port As Integer, ByVal Database As String)
        If setted < 3 Then
            CustomPrincipal.NomeUtente = NomeUtente
            CustomPrincipal.Password = Password

            str = "port=" + Port.ToString + ";server=" + Server.ToString + ";user id=" + CustomPrincipal.NomeUtente + ";password=" + CustomPrincipal.Password + ";database=" + Database.ToString + ";"
            setted = setted + 1
        End If
    End Sub
End Class
