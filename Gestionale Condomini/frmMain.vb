Imports System.Windows.Forms
Imports Spese.Gestionale_Condomini
Imports Opzioni
Imports Opzioni.Gestionale_Condomini
Imports Quote
Imports Quote.Gestionale_Condomini
Imports Anagrafica
Imports Anagrafica.Gestionale_Condomini
Public Class frmMain




    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles EsciToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub CutToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CutToolStripMenuItem.Click

        ' Utilizzare My.Computer.Clipboard per inserire negli Appunti le immagini o il testo selezionato
    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CopyToolStripMenuItem.Click
        ' Utilizzare My.Computer.Clipboard per inserire negli Appunti le immagini o il testo selezionato
    End Sub

    Private Sub PasteToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles PasteToolStripMenuItem.Click
        'Utilizzare My.Computer.Clipboard.GetText() o My.Computer.Clipboard.GetData per recuperare informazioni dagli Appunti.
    End Sub

    Private Sub ToolBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ToolBarToolStripMenuItem.Click
        Me.ToolStrip.Visible = Me.ToolBarToolStripMenuItem.Checked
    End Sub

    Private Sub StatusBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles StatusBarToolStripMenuItem.Click
        Me.StatusStrip.Visible = Me.StatusBarToolStripMenuItem.Checked
    End Sub

    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CascadeToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub TileVerticalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles TileVerticalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles TileHorizontalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ArrangeIconsToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CloseAllToolStripMenuItem.Click
        ' Chiude tutti i form figlio del form padre.
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub

    Private m_ChildFormNumber As Integer

    Private Sub MDIParent2_Close(sender As Object, e As EventArgs) Handles MyBase.FormClosed
        Application.Exit()
    End Sub


    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        Dim f As AboutBox1 = New AboutBox1
        f.MdiParent = Me
        m_ChildFormNumber += 1
        f.Show()
    End Sub
    Private Sub SpeseEffettiveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SpeseEffettiveToolStripMenuItem.Click
        Dim f As frmSpese_Effettive = New frmSpese_Effettive
        f.MdiParent = Me
        m_ChildFormNumber += 1
        f.Show()
    End Sub

    Private Sub SpesePreventiveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SpesePreventiveToolStripMenuItem.Click
        Dim f As frmSpese_Preventivate = New frmSpese_Preventivate()
        f.MdiParent = Me
        m_ChildFormNumber += 1
        f.Show()
    End Sub

    Private Sub InserisciCondominoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InserisciCondominoToolStripMenuItem.Click
        Dim f As insCondomini = New insCondomini()
        f.MdiParent = Me
        m_ChildFormNumber += 1
        f.Show()
    End Sub

    Private Sub ModificaCondominiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModificaCondominiToolStripMenuItem.Click
        Dim f As frmCondomini = New frmCondomini()
        f.MdiParent = Me
        m_ChildFormNumber += 1
        f.Show()
    End Sub

    Private Sub TabelleMillesimaliToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TabelleMillesimaliToolStripMenuItem.Click
        Dim f As frmTabella_Millesimale = New frmTabella_Millesimale()
        f.MdiParent = Me
        m_ChildFormNumber += 1
        f.Show()
    End Sub

    Private Sub PrintToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintToolStripMenuItem.Click
        Dim f As GrtQuote = New GrtQuote
        f.MdiParent = Me
        m_ChildFormNumber += 1
        f.Show()
    End Sub

    Private Sub GestisciQuote_Click(sender As Object, e As EventArgs) Handles GestisciQuote.Click
        Dim f As frmQuote = New frmQuote()
        f.MdiParent = Me
        m_ChildFormNumber += 1
        f.Show()
    End Sub

    Private Sub ModalitàPagamentoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModalitàPagamentoToolStripMenuItem.Click
        Dim f As frmModoPagamento = New frmModoPagamento
        f.MdiParent = Me
        m_ChildFormNumber += 1
        f.Show()
    End Sub

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        Dim f As frmAnno = New frmAnno
        f.MdiParent = Me
        m_ChildFormNumber += 1
        f.Show()
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        Dim f As insAnno = New insAnno
        f.MdiParent = Me
        m_ChildFormNumber += 1
        f.Show()
    End Sub



    Private Sub CheckTabelleMillesimaliToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CheckTabelleMillesimaliToolStripMenuItem.Click
        Dim f As ChkMillesimi = New ChkMillesimi
        f.MdiParent = Me
        m_ChildFormNumber += 1
        f.Show()
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ToolStripStatusLabel.Text = LoginForm1.conn.State.ToString + " connection to server: " + My.Settings.Server.ToString + " Port:" + My.Settings.Port.ToString
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Not LoginForm1.conn.Ping() Then
            ToolStripStatusLabel.Text = "Connessione interrotta al Server " + My.Settings.Server.ToString + " Port:" + My.Settings.Port.ToString
        End If
    End Sub

End Class
