
Imports Word = Microsoft.Office.Interop.Word
Imports System.ComponentModel
Imports MySql.Data.MySqlClient
Imports Autenticazione

Namespace Gestionale_Condomini

    Public Class frmQuote
        Dim str As StringaConnessione = New StringaConnessione
        Private ad As MySqlDataAdapter

        Private Sub frmQuote_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
            Dim strConn As String = str.conn
            ad = New MySqlDataAdapter("select * from `Quote`", strConn)
            Dim builder As MySqlCommandBuilder = New MySqlCommandBuilder(ad)
            ad.Fill(Me.newDataSet.Quote)
            ad.DeleteCommand = builder.GetDeleteCommand()
            ad.UpdateCommand = builder.GetUpdateCommand()
            ad.InsertCommand = builder.GetInsertCommand()
            BindingNavigatorAddNewItem.Enabled = False
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
            Dim colMese As System.Windows.Forms.DataGridViewComboBoxColumn = New System.Windows.Forms.DataGridViewComboBoxColumn()
            If Not (ad2 Is Nothing) Then
                ad2.Dispose()
            End If
            ad2 = New MySql.Data.MySqlClient.MySqlDataAdapter("select * from `Mesi`", strConn2)
            ad2.Fill(Me.newDataSet.Mesi)
            colMese.DataSource = Me.newDataSet.Mesi
            colMese.DataPropertyName = "Mese"
            colMese.DisplayMember = "CodMese"
            colMese.ValueMember = "CodMese"
            colMese.HeaderText = "Mese"
            colMese.Name = "colMese"
            colMese.ToolTipText = "Seleziona il valore tra quelli proposti"
            dataGridView1.Columns.Add(colMese)
            Dim colAnno As System.Windows.Forms.DataGridViewComboBoxColumn = New System.Windows.Forms.DataGridViewComboBoxColumn()
            If Not (ad2 Is Nothing) Then
                ad2.Dispose()
            End If
            ad2 = New MySql.Data.MySqlClient.MySqlDataAdapter("select * from `Anni`", strConn2)
            ad2.Fill(Me.newDataSet.Anni)
            colAnno.DataSource = Me.newDataSet.Anni
            colAnno.DataPropertyName = "Anno"
            colAnno.DisplayMember = "Anno"
            colAnno.ValueMember = "Anno"
            colAnno.HeaderText = "Anno"
            colAnno.Name = "colAnno"
            colAnno.ToolTipText = "Seleziona il valore tra quelli proposti"
            dataGridView1.Columns.Add(colAnno)
            Dim colPagato As System.Windows.Forms.DataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
            colPagato.DataPropertyName = "Pagato"
            colPagato.HeaderText = "Pagato"
            colPagato.Name = "colPagato"
            dataGridView1.Columns.Add(colPagato)
            Dim colImporto As System.Windows.Forms.DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
            colImporto.DataPropertyName = "Importo"
            colImporto.HeaderText = "Importo"
            colImporto.Name = "colImporto"
            dataGridView1.Columns.Add(colImporto)
            Dim colNote As System.Windows.Forms.DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
            colNote.DataPropertyName = "Note"
            colNote.HeaderText = "Note"
            colNote.Name = "colNote"
            colNote.MaxInputLength = 255
            dataGridView1.Columns.Add(colNote)
            Dim colInterno_PI As System.Windows.Forms.DataGridViewComboBoxColumn = New System.Windows.Forms.DataGridViewComboBoxColumn()
            If Not (ad2 Is Nothing) Then
                ad2.Dispose()
            End If
            ad2 = New MySql.Data.MySqlClient.MySqlDataAdapter("select * from `Condomini`", strConn2)
            ad2.Fill(Me.newDataSet.Condomini)
            colInterno_PI.DataSource = Me.newDataSet.Condomini
            colInterno_PI.DataPropertyName = "Interno_PI"
            colInterno_PI.DisplayMember = "Interno_PI"
            colInterno_PI.ValueMember = "Interno_PI"
            colInterno_PI.HeaderText = "Interno_PI"
            colInterno_PI.Name = "colInterno_PI"
            colInterno_PI.ToolTipText = "Seleziona il valore tra quelli proposti"
            dataGridView1.Columns.Add(colInterno_PI)
            Dim colData_Pagamento As MyDateTimePickerColumn = New MyDateTimePickerColumn()
            colData_Pagamento.DataPropertyName = "Data_Pagamento"
            colData_Pagamento.HeaderText = "Data_Pagamento"
            colData_Pagamento.Name = "colData_Pagamento"
            dataGridView1.Columns.Add(colData_Pagamento)
            Dim colModo_Pagamento As System.Windows.Forms.DataGridViewComboBoxColumn = New System.Windows.Forms.DataGridViewComboBoxColumn()
            If Not (ad2 Is Nothing) Then
                ad2.Dispose()
            End If
            ad2 = New MySql.Data.MySqlClient.MySqlDataAdapter("select * from `ModoPagamento`", strConn2)
            ad2.Fill(Me.newDataSet.ModoPagamento)
            colModo_Pagamento.DataSource = Me.newDataSet.ModoPagamento
            colModo_Pagamento.DataPropertyName = "Modo_Pagamento"
            colModo_Pagamento.DisplayMember = "CodPagamento"
            colModo_Pagamento.ValueMember = "CodPagamento"
            colModo_Pagamento.HeaderText = "Modo_Pagamento"
            colModo_Pagamento.Name = "colModo_Pagamento"
            colModo_Pagamento.ToolTipText = "Seleziona il valore tra quelli proposti"
            dataGridView1.Columns.Add(colModo_Pagamento)
            Dim colOrdStraord As System.Windows.Forms.DataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
            colOrdStraord.DataPropertyName = "OrdStraord"
            colOrdStraord.HeaderText = "OrdStraord"
            colOrdStraord.Name = "colOrdStraord"
            dataGridView1.Columns.Add(colOrdStraord)
            Me.dataGridView1.DataSource = Me.QuoteBindingSource
        End Sub

        Private Sub ToolStripButton1_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton1.Click
            If Not Me.Validate() Then
                Return
            End If
            QuoteBindingSource.EndEdit()
            ad.Update(Me.newDataSet.Quote)
        End Sub

        Private Sub frmQuote_FormClosing(sender As System.Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
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
                    row.ErrorText = "Il campo Mese e' richiesto"
                    Return
                End If
            End If
            If e.ColumnIndex = 1 Then


                If (TypeOf value Is DBNull) OrElse String.IsNullOrEmpty(value.ToString()) Then
                    e.Cancel = True
                    row.ErrorText = "Il campo Anno e' richiesto"
                    Return
                End If
            End If
            If e.ColumnIndex = 2 Then

                If (TypeOf value Is DBNull) OrElse String.IsNullOrEmpty(value.ToString()) Then
                    e.Cancel = True
                    row.ErrorText = "Il campo Pagato e' richiesto"
                    Return
                End If
            End If
            If e.ColumnIndex = 3 Then

                Dim v As Double
                If (TypeOf value Is DBNull) OrElse String.IsNullOrEmpty(value.ToString()) Then
                    e.Cancel = True
                    row.ErrorText = "Il campo Importo e' richiesto"
                    Return
                End If
                s = value.ToString()
                If Not Double.TryParse(s, v) Then
                    e.Cancel = True
                    row.ErrorText = "Il campo Importo deve essere un numero."
                    Return
                End If
            End If
            If e.ColumnIndex = 4 Then

                If (TypeOf value Is DBNull) OrElse String.IsNullOrEmpty(value.ToString()) Then
                    e.Cancel = True
                    row.ErrorText = "Il campo Note e' richiesto"
                    Return
                End If
            End If
            If e.ColumnIndex = 6 Then

                If (TypeOf value Is DBNull) OrElse String.IsNullOrEmpty(value.ToString()) Then
                    e.Cancel = True
                    row.ErrorText = "Il campo Data_Pagamento e' richiesto"
                    Return
                End If
            End If
            If e.ColumnIndex = 7 Then

                If (TypeOf value Is DBNull) OrElse String.IsNullOrEmpty(value.ToString()) Then
                    e.Cancel = True
                    row.ErrorText = "Il campo Modalità_Pagamento e' richiesto"
                    Return
                End If
            End If
        End Sub
        Private Sub dataGridView1_DataError(ByVal sender As Object, ByVal e As DataGridViewDataErrorEventArgs) Handles dataGridView1.DataError
            dataGridView1.Rows(e.RowIndex).ErrorText = e.Exception.Message
            e.Cancel = True
        End Sub

        Private Sub bindingNavigatorAddNewItem_Click(sender As System.Object, e As System.EventArgs) Handles BindingNavigatorAddNewItem.Click
            QuoteBindingSource.AddNew()
        End Sub

    End Class

End Namespace
