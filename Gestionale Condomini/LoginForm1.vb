Imports MySql.Data.MySqlClient

Public Class LoginForm1
    Dim newDataSet As Object
    Protected Friend conn As MySqlConnection
    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        'CustomPrincipal.NomeUtente = UsernameTextBox.Text
        'CustomPrincipal.Password = PasswordTextBox.Text
        Dim str As Autenticazione.StringaConnessione = New Autenticazione.StringaConnessione
        str.Sett(UsernameTextBox.Text, PasswordTextBox.Text, My.Settings.Server.ToString, My.Settings.Port, My.Settings.Database.ToString)
        Dim strConn As String = str.conn
        Try
            conn = New MySqlConnection(strConn)
            conn.Open()
            frmMain.Show()
            str.SetLock()
            Me.Hide()
        Catch ex As Exception
            If ex.ToString.Contains("denied") Then
                Label1.Visible() = True
            Else
                MsgBox(ex.ToString)
            End If
            Exit Try
        Finally
        End Try

    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub LoginForm1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Opzioni_Click(sender As Object, e As EventArgs) Handles Opzioni.Click
        Dim f As LoginSetup = New LoginSetup
        f.Show()
    End Sub
End Class




