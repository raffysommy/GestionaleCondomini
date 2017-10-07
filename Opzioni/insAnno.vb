Imports MySql.Data.MySqlClient
Imports Autenticazione

Namespace Gestionale_Condomini

    Public Class insAnno
        Dim str As StringaConnessione = New StringaConnessione
        Private ad As MySqlDataAdapter
        Dim ad2 As MySql.Data.MySqlClient.MySqlDataAdapter = Nothing
        Private Sub Aggiungi_Click(sender As Object, e As EventArgs) Handles Aggiungi.Click
            Dim strConn As String = str.conn
            Dim conn1 As MySqlConnection = New MySqlConnection(strConn)
            Try
                conn1.Open()
            Catch ex As Exception
                MsgBox("Errore di Connessione al database", MsgBoxStyle.Critical)
                Exit Sub
            End Try
            Dim sql1 As String
            If newanno.Text.Length = 0 Then
                sql1 = ("INSERT INTO `Anni`(`InCorso`) VALUES (0)")
            Else
                sql1 = ("INSERT INTO `Anni`(`InCorso`) VALUES (@anno)")
            End If
            If MsgBox("Inserire il nuovo anno?", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
                Dim cmd As MySqlCommand = New MySqlCommand(sql1, conn1)
                cmd.Parameters.AddWithValue("@anno", frmAnno.AnniComboBox.Text)
                Dim dataupdate As MySqlDataReader = cmd.ExecuteReader
                dataupdate.Close()
                ad2.Fill(Me.NewDataSet.Anni)
                MsgBox("Anno Inserito")
            End If

        End Sub

        Private Sub insAnno_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            Dim strConn2 As String = str.conn
            ad2 = New MySql.Data.MySqlClient.MySqlDataAdapter("SELECT * FROM `Anni` ORDER BY `Anni`.`InCorso`,`Anni`.`Anno` DESC", strConn2)
            ad2.Fill(Me.NewDataSet.Anni)
        End Sub
    End Class


End Namespace
