Public Class LoginSetup

    Private Sub LoginSetup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoginForm1.Enabled = False
        Reset_Click(sender, e)
    End Sub
    Private Sub LoginSetup_Close() Handles MyBase.FormClosed
        LoginForm1.Enabled = True
    End Sub

    Private Sub Reset_Click(sender As Object, e As EventArgs) Handles Reset.Click
        Host.Text = My.Settings.Server
        Port.Text = My.Settings.Port
        database.Text = My.Settings.Database
    End Sub

    Private Sub Imposta_Click(sender As Object, e As EventArgs) Handles Imposta.Click
        If Checkport(Port.Text) Then
            My.Settings.Port = Port.Text
        Else

            MsgBox("Attenzione: Inserire un numero di porta valido", MsgBoxStyle.Critical)
            Exit Sub
        End If
        If Checkserver(Host.Text) Then
            My.Settings.Server = Host.Text.ToString
        Else

            MsgBox("Attenzione: Inserire un hostname o ip valido", MsgBoxStyle.Critical)
            Exit Sub
        End If
        My.Settings.Database = database.Text.ToString
        My.Settings.Save()
        MsgBox("Server Impostato", MsgBoxStyle.Exclamation)
        Me.Close()
    End Sub
    Private Function Checkport(ByVal port As Integer) As Boolean
        Return (port < 65535 And port > 0)
    End Function
    Private Function Checkserver(ByVal server As String) As Boolean
        Dim ValidIpAddressRegex As String = "^(([0-9]|[1-9][0-9]|1[0-9]{2}|2[0-4][0-9]|25[0-5])\.){3}([0-9]|[1-9][0-9]|1[0-9]{2}|2[0-4][0-9]|25[0-5])$"
        Dim ValidHostnameRegex As String = "^(([a-zA-Z0-9]|[a-zA-Z0-9][a-zA-Z0-9\-]*[a-zA-Z0-9])\.)*([A-Za-z0-9]|[A-Za-z0-9][A-Za-z0-9\-]*[A-Za-z0-9])$"
        Return System.Text.RegularExpressions.Regex.Match(server, ValidIpAddressRegex).Success Or System.Text.RegularExpressions.Regex.Match(server, ValidHostnameRegex).Success
    End Function

    Private Sub Databaselbl_Click(sender As Object, e As EventArgs) Handles Databaselbl.Click

    End Sub
End Class