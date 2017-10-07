Imports Autenticazione
Imports MySql.Data.MySqlClient

Public Class ChkMillesimi
    Private ad2 As MySqlDataAdapter = Nothing
    Private Sub ChkMillesimi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim str As StringaConnessione = New StringaConnessione
        Dim strConn2 As String = str.conn
        ad2 = New MySql.Data.MySqlClient.MySqlDataAdapter("SELECT Distinct `Tabella`,`Check`(`Tabella`) AS `Check` FROM `Tabella_Millesimale`", strConn2)
        ad2.Fill(Me.NewDataSet.Tabella_Millesimale1)
    End Sub
End Class