Imports Word = Microsoft.Office.Interop.Word
Imports MySql.Data.MySqlClient
Imports Autenticazione

Public Class GrtQuote

    Dim str As StringaConnessione = New StringaConnessione
    Private ad As MySqlDataAdapter
    Dim ad2 As MySql.Data.MySqlClient.MySqlDataAdapter = Nothing
    Public oDoc2 As Word.Document
    Dim mese As String
    Dim gestione As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Quietanze.Click
        ProgressBar1.Value = ProgressBar1.Minimum
        Pdf.Enabled = False
        mese = DescrizioneMeseComboBox.Text
        gestione = OrdStr()
        Dim strConn As String = str.conn
        If Ordinarie.Checked Then
            ad = New MySqlDataAdapter(("select * from `OrdinarieAnno` where mesi='" + mese + "'").ToString, strConn)
        ElseIf Straordinarie.Checked Then
            ad = New MySqlDataAdapter(("select * from `StraordinarieAnno` where mesi='" + mese + "'").ToString, strConn)
        End If

        ad.Fill(Me.NewDataSet.OrdinarieAnno)
        ProgressBar1.ResetText()
        Dim i As Integer
        Dim j As Integer
        Dim nrows As Integer = Me.NewDataSet.OrdinarieAnno.Rows.Count - 1
        If nrows > -1 Then
            ProgressBar1.Step = 100 / nrows
            Dim direct As String = IO.Path.Combine(Application.UserAppDataPath, "bollette")
            Try

                IO.Directory.CreateDirectory(direct)
            Catch ex As Exception
                MsgBox(ex.ToString)
                MsgBox(Application.UserAppDataPath.ToString)
            End Try
            For i = 0 To nrows
                Dim oWord As Word.Application
                Dim oDoc As Word.Document
                'Start Word and open the document template.
                oWord = CreateObject("Word.Application")
                oWord.Visible = False
                Try

                    oDoc = oWord.Documents.Add((IO.Path.Combine(Application.StartupPath + "\bolletta.dotx")).ToString)

                Catch ex As Exception
                    MsgBox("Errore,Impossibile trovare bolletta.dotx in " + IO.Path.Combine(Application.StartupPath + "\bolletta.dotx"), MsgBoxStyle.Critical)
                    Exit Sub
                End Try
                Dim contentControls
                contentControls = oDoc.ContentControls
                j = 0
                While (j < 2)
                    i = i + j
                    If Not i.Equals(nrows + 1) Then
                        'MsgBox(Me.NewDataSet.OrdinarieAnno.Rows.Item(i).Item(4).ToString() + j.ToString + i.ToString)
                        oDoc.ContentControls.Item(10 * j + 1).Range.Text = Me.NewDataSet.OrdinarieAnno.Rows.Item(i).Item(0).ToString()
                        oDoc.ContentControls.Item(10 * j + 2).Range.Text = Me.NewDataSet.OrdinarieAnno.Rows.Item(i).Item(1).ToString() + "  " + Me.NewDataSet.OrdinarieAnno.Rows.Item(i).Item(2).ToString()
                        oDoc.ContentControls.Item(10 * j + 3).Range.Text = Me.NewDataSet.OrdinarieAnno.Rows.Item(i).Item(3).ToString()
                        oDoc.ContentControls.Item(10 * j + 4).Range.Text = Me.NewDataSet.OrdinarieAnno.Rows.Item(i).Item(4).ToString() + "  " + Me.NewDataSet.OrdinarieAnno.Rows.Item(i).Item(5).ToString()
                        oDoc.ContentControls.Item(10 * j + 5).Range.Text = Me.NewDataSet.OrdinarieAnno.Rows.Item(i).Item(6).ToString()
                        'oDoc.ContentControls.Item(10*j+6).Range.Text = Me.NewDataSet.OrdinarieAnno.Rows.Item(i).Item(7).ToString()
                        oDoc.ContentControls.Item(10 * j + 6).Range.Text = gestione + " " + mese
                        oDoc.ContentControls.Item(10 * j + 7).Range.Text = Me.NewDataSet.OrdinarieAnno.Rows.Item(i).Item(8).ToString()
                        oDoc.ContentControls.Item(10 * j + 8).Range.Text = Me.NewDataSet.OrdinarieAnno.Rows.Item(i).Item(8).ToString()
                    Else
                        oDoc.Range(oDoc.Bookmarks("meta").Range.Start, oDoc.Bookmarks("fine").Range.Start).Delete()
                    End If
                    j = j + 1
                End While

                oDoc.SaveAs(IO.Path.Combine(Application.UserAppDataPath, "bollette\" & i.ToString))
                oDoc.Close()
                oWord.Quit()
                ProgressBar1.PerformStep()
            Next
            '== Declare variables
            Dim fileArray As New ArrayList
            Dim intCount As Integer = 0

            Dim dirInfo As IO.DirectoryInfo = New IO.DirectoryInfo(direct)
            '== Create an object of WORD.

            Dim objWord As Word.Application

            objWord = CreateObject("Word.Application") ' 
            oDoc2 = objWord.Documents.Add()
            '== Loop through the collection of documents and add to main word document 

            For Each fi As System.IO.FileInfo In dirInfo.GetFiles("*.docx") '  dirInfo : is the directory where all the separate docs are saved

                If Not fileArray.Contains(fi.FullName) Then ' Check if document is not already added.

                    objWord.Selection.InsertFile(FileName:=fi.FullName, Range:="", ConfirmConversions:=False, Link:=False, Attachment:=False) ' next time onwards use InsertFile method


                    objWord.Selection.InsertBreak()
                End If

            Next
            objWord.Selection.EndKey(Word.WdUnits.wdStory, Nothing)
            objWord.Selection.TypeBackspace()
            objWord.Selection.TypeBackspace()
            ProgressBar1.PerformStep()
            '== Delete all separate documents from folder after merge

            For Each fi As System.IO.FileInfo In dirInfo.GetFiles("*.doc")
                fi.Delete()
            Next
            '== Make the main document visible

            If Not objWord.Visible Then
                objWord.Visible = True
            End If
            ProgressBar1.PerformStep()
            Try
                oDoc2.SaveAs(IO.Path.Combine(Application.UserAppDataPath, "bollette" + mese + gestione + ".docx"))
            Catch ex As Exception
                If ex.ToString.Contains("aperto") Then
                    MsgBox("Attenzione!" + Environment.NewLine + "Il File è gia aperto da un altra istanza", MsgBoxStyle.Critical)
                End If
                Exit Sub

            End Try
            Pdf.Enabled = True

        Else
            MsgBox("Non ci sono quote generate per questo periodo")
        End If



    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim strConn2 As String = str.conn
        ad2 = New MySqlDataAdapter("select * from `Mesi` ORDER BY `Mesi`.`CodMese` ASC", strConn2)
        ad2.Fill(Me.NewDataSet.Mesi)


    End Sub




    Private Sub Pdf_Click(sender As Object, e As EventArgs) Handles Pdf.Click
        Dim Filename As String
        Dim SaveFileDialog As New SaveFileDialog
        IO.Directory.CreateDirectory(My.Computer.FileSystem.SpecialDirectories.MyDocuments + "\bollette")
        SaveFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments + "\bollette"
        SaveFileDialog.FileName = "bollette" + mese + gestione + ".pdf"
        SaveFileDialog.Filter = "File Pdf (*.pdf)|*.pdf|Tutti i file (*.*)|*.*"

        If (SaveFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Filename = SaveFileDialog.FileName
            Try
                oDoc2.SaveAs(Filename, Word.WdSaveFormat.wdFormatPDF)
            Catch ex As Exception
                MsgBox("Errore: Word è stato chiuso!", MsgBoxStyle.Critical)
                Exit Sub
            End Try
        End If
        Try
            Process.Start(Filename)
        Catch ex As Exception
            MsgBox("Errore: Impossibile aprire il File!", MsgBoxStyle.Critical)
            Exit Sub
        End Try
    End Sub
    Private Function OrdStr()
        If Ordinarie.Checked Then
            Return "Ordinarie"
        End If
        If Straordinarie.Checked Then
            Return "Straordinarie"
        End If
        Return vbNullString
    End Function
    Private Sub GrtQuoteClose() Handles Me.FormClosing
        If (MsgBox("Chiudere la finestra di Word?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes) Then
            oDoc2.Close()
        End If
    End Sub

End Class