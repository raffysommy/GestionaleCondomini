
Imports System.ComponentModel
Imports MySql.Data.MySqlClient
Imports Autenticazione

Namespace Gestionale_Condomini

    Public Class frmTabella_Millesimale
        Dim str As StringaConnessione = New StringaConnessione
        Private ad As MySqlDataAdapter

        Private Sub frmTabella_Millesimale_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
            Dim strConn As String = str.conn
            ad = New MySqlDataAdapter("select * from `Tabella_Millesimale`", strConn)
            Dim builder As MySqlCommandBuilder = New MySqlCommandBuilder(ad)
            ad.Fill(Me.newDataSet.Tabella_Millesimale)
            ad.DeleteCommand = builder.GetDeleteCommand()
            ad.UpdateCommand = builder.GetUpdateCommand()
            ad.InsertCommand = builder.GetInsertCommand()
            BindingNavigatorAddNewItem.Enabled = True
            BindingNavigatorCountItem.Enabled = True
            BindingNavigatorDeleteItem.Enabled = True
            BindingNavigatorMoveFirstItem.Enabled = True
            BindingNavigatorMovePreviousItem.Enabled = True
            BindingNavigatorPositionItem.Enabled = True
            BindingNavigatorMoveNextItem.Enabled = True
            BindingNavigatorMoveLastItem.Enabled = True
            ToolStripButton1.Enabled = True
            dataGridView1.AutoGenerateColumns = False
            Dim strConn2 As String = str.conn
            Dim ad2 As MySql.Data.MySqlClient.MySqlDataAdapter = Nothing
            Dim colCondomino As System.Windows.Forms.DataGridViewComboBoxColumn = New System.Windows.Forms.DataGridViewComboBoxColumn()
            If Not (ad2 Is Nothing) Then
                ad2.Dispose()
            End If
            ad2 = New MySql.Data.MySqlClient.MySqlDataAdapter("select * from `Condomini`", strConn2)
            ad2.Fill(Me.newDataSet.Condomini)
            colCondomino.DataSource = Me.newDataSet.Condomini
            colCondomino.DataPropertyName = "Condomino"
            colCondomino.DisplayMember = "Interno_PI"
            colCondomino.ValueMember = "Interno_PI"
            colCondomino.HeaderText = "Interno_PI"
            colCondomino.Name = "colCondomino"
            colCondomino.ToolTipText = "Seleziona il valore tra quelli proposti"
            dataGridView1.Columns.Add(colCondomino)
            Dim colTabella As System.Windows.Forms.DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
            colTabella.DataPropertyName = "Tabella"
            colTabella.HeaderText = "Tabella"
            colTabella.Name = "colTabella"
            colTabella.MaxInputLength = 1
            dataGridView1.Columns.Add(colTabella)
            Dim colMillesimi As System.Windows.Forms.DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
            colMillesimi.DataPropertyName = "Millesimi"
            colMillesimi.HeaderText = "Millesimi"
            colMillesimi.Name = "colMillesimi"
            dataGridView1.Columns.Add(colMillesimi)
            Me.dataGridView1.DataSource = Me.Tabella_MillesimaleBindingSource
        End Sub

        Private Sub ToolStripButton1_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton1.Click
            If Not Me.Validate() Then
                Return
            End If
            Tabella_MillesimaleBindingSource.EndEdit()
            ad.Update(Me.newDataSet.Tabella_Millesimale)
        End Sub

        Private Sub frmTabella_Millesimale_FormClosing(sender As System.Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
            e.Cancel = False
        End Sub

        Private Sub dataGridView1_CellValidating(sender As Object, e As DataGridViewCellValidatingEventArgs) Handles dataGridView1.CellValidating

            Dim s As String
            Dim row As DataGridViewRow = dataGridView1.Rows(e.RowIndex)
            Dim value As Object = e.FormattedValue
            e.Cancel = False
            row.ErrorText = ""
            If row.IsNewRow Then
                Return
            End If
            If e.ColumnIndex = 0 Then

                If (TypeOf value Is DBNull) OrElse String.IsNullOrEmpty(value.ToString()) Then
                    e.Cancel = True
                    row.ErrorText = "Il campo Condomino e' richiesto"
                    Return
                End If
            End If
            If e.ColumnIndex = 1 Then

                If (TypeOf value Is DBNull) OrElse String.IsNullOrEmpty(value.ToString()) Then
                    e.Cancel = True
                    row.ErrorText = "Il campo Tabella e' richiesto"
                    Return
                End If
            End If
            If e.ColumnIndex = 2 Then

                Dim v As Double
                If (TypeOf value Is DBNull) OrElse String.IsNullOrEmpty(value.ToString()) Then
                    e.Cancel = True
                    row.ErrorText = "Il campo Millesimi e' richiesto"
                    Return
                End If
                s = value.ToString()
                If Not Double.TryParse(s, v) Then
                    e.Cancel = True
                    row.ErrorText = "Il campo Millesimi must be Double."
                    Return
                End If
            End If
        End Sub
        Private Sub dataGridView1_DataError(ByVal sender As Object, ByVal e As DataGridViewDataErrorEventArgs) Handles dataGridView1.DataError
            dataGridView1.Rows(e.RowIndex).ErrorText = e.Exception.Message
            e.Cancel = True
        End Sub

        Private Sub bindingNavigatorAddNewItem_Click(sender As System.Object, e As System.EventArgs) Handles BindingNavigatorAddNewItem.Click
            Tabella_MillesimaleBindingSource.AddNew()
        End Sub

    End Class

End Namespace
