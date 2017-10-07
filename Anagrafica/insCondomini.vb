Imports MySql.Data.MySqlClient
Imports System.ComponentModel
Imports Autenticazione

Public Class insCondomini
    Dim str As StringaConnessione = New StringaConnessione
    Private ad As MySqlDataAdapter
    Dim newDataSet As Object
    Dim strConn As String = str.conn
    Dim conn As MySqlConnection = New MySqlConnection(strConn)
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.Open()
    End Sub

    Private Sub Cancella_Click(sender As Object, e As EventArgs) Handles Cancella.Click
        Dim ctrl As New Form.ControlCollection(Me)

        ctrl = System.Windows.Forms.Form.ActiveForm.Controls

        For Each c As Control In ctrl

            If TypeOf (c) Is System.Windows.Forms.TextBox Then

                c.Text = ""

            End If

        Next
    End Sub
    Private Sub Controlla_Nullo(textbox As TextBox)
        If String.IsNullOrEmpty(textbox.Text.ToString()) Then
        End If
    End Sub

    Private Sub Aggiungi_Click(sender As Object, e As EventArgs) Handles Aggiungi.Click
        Try
            Dim sql As String = ("INSERT INTO Condomini VALUES (@id,@nome,@cognome,@telefono,@scala)")
            Dim cmd As MySqlCommand = New MySqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@id", Interno.Text)
            cmd.Parameters.AddWithValue("@nome", Nome.Text)
            cmd.Parameters.AddWithValue("@cognome", Cognome.Text)
            cmd.Parameters.AddWithValue("@telefono", Convert.ToInt32(Convert.ToDecimal(Telefono.Text)))
            cmd.Parameters.AddWithValue("@scala", Scala.Text)
            Dim insertdata As MySqlDataReader = cmd.ExecuteReader
            insertdata.Close()
            MsgBox("Condomino Inserito")
        Catch ex As Exception
            If ex.Message.ToString.Contains("PRIMARY") Then
                MsgBox("Errore! Condomino già Presente")
            Else
                MsgBox(ex.ToString,MsgBoxStyle.Critical)
            End If

        End Try


    End Sub

End Class



