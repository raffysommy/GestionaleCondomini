Imports MySql.Data.MySqlClient
Imports Autenticazione

Namespace Gestionale_Condomini

    Public Class frmAnno
        Dim str As StringaConnessione = New StringaConnessione
        Private ad As MySqlDataAdapter
        Dim ad2 As MySql.Data.MySqlClient.MySqlDataAdapter = Nothing
        Private Sub frmAnno_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            Dim strConn2 As String = str.conn
            ad2 = New MySql.Data.MySqlClient.MySqlDataAdapter("SELECT * FROM `Anni` ORDER BY `Anni`.`InCorso` DESC", strConn2)
            ad2.Fill(Me.NewDataSet.Anni)

        End Sub

        Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Imposta.Click
            Dim strConn As String = str.conn
            Dim conn As MySqlConnection = New MySqlConnection(strConn)
            Try
                conn.Open()
            Catch ex As Exception
                MsgBox("Errore di Connessione al database", MsgBoxStyle.Critical)
                Exit Try
            End Try
            If MsgBox("Assicurati di chiudere tutte le altre finestre." + Environment.NewLine + "Vuoi impostare l'anno al " + AnniComboBox.Text + "?", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
                Dim sql As String = ("UPDATE `Condominio_test`.`Anni` SET `InCorso`=0; UPDATE `Condominio_test`.`Anni` SET `InCorso` = 1 WHERE `Anno` = @anno")
                Dim cmd As MySqlCommand = New MySqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@anno", AnniComboBox.Text)
                Dim dataupdate As MySqlDataReader = cmd.ExecuteReader
                dataupdate.Close()
                MsgBox("Anno Modificato")
            End If

        End Sub


    End Class

End Namespace
