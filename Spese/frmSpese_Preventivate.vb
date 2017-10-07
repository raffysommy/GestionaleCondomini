
Imports System.ComponentModel
Imports MySql.Data.MySqlClient
Imports Autenticazione

Namespace Gestionale_Condomini

    Public Class frmSpese_Preventivate
        Dim str As StringaConnessione = New StringaConnessione
        Private ad As MySqlDataAdapter

        Private Sub frmSpese_Preventivate_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
            Dim strConn As String = str.conn
            ad = New MySqlDataAdapter("select * from `Spese_Preventivate`", strConn)
            Dim builder As MySqlCommandBuilder = New MySqlCommandBuilder(ad)
            ad.Fill(Me.newDataSet.Spese_Preventivate)
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
            Dim colCausale As System.Windows.Forms.DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
            colCausale.DataPropertyName = "Causale"
            colCausale.HeaderText = "Causale"
            colCausale.Name = "colCausale"
            colCausale.MaxInputLength = 255
            dataGridView1.Columns.Add(colCausale)
            Dim colImporto As System.Windows.Forms.DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
            colImporto.DataPropertyName = "Importo"
            colImporto.HeaderText = "Importo"
            colImporto.Name = "colImporto"
            dataGridView1.Columns.Add(colImporto)
            Dim colTabellaFK As System.Windows.Forms.DataGridViewComboBoxColumn = New System.Windows.Forms.DataGridViewComboBoxColumn()
            If Not (ad2 Is Nothing) Then
                ad2.Dispose()
            End If
            ad2 = New MySql.Data.MySqlClient.MySqlDataAdapter("select distinct Tabella from `Tabella_Millesimale`", strConn2)
            ad2.Fill(Me.newDataSet.Tabella_Millesimale2)
            colTabellaFK.DataSource = Me.newDataSet.Tabella_Millesimale2
            colTabellaFK.DataPropertyName = "TabellaFK"
            colTabellaFK.DisplayMember = "Tabella"
            colTabellaFK.ValueMember = "Tabella"
            colTabellaFK.HeaderText = "TabellaFK"
            colTabellaFK.Name = "colTabellaFK"
            colTabellaFK.ToolTipText = "Seleziona il valore tra quelli proposti"
            dataGridView1.Columns.Add(colTabellaFK)
            Me.dataGridView1.DataSource = Me.Spese_PreventivateBindingSource
        End Sub

        Private Sub ToolStripButton1_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton1.Click
            If Not Me.Validate() Then
                Return
            End If
            Spese_PreventivateBindingSource.EndEdit()
            ad.Update(Me.newDataSet.Spese_Preventivate)
        End Sub

        Private Sub frmSpese_Preventivate_FormClosing(sender As System.Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
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

                Dim v As Integer
                If (TypeOf value Is DBNull) OrElse String.IsNullOrEmpty(value.ToString()) Then
                    e.Cancel = True
                    row.ErrorText = "Il campo Anno e' richiesto"
                    Return
                End If
                s = value.ToString()
                If Not Integer.TryParse(s, v) Then
                    e.Cancel = True
                    row.ErrorText = "Il campo Anno deve essere un numero."
                    Return
                End If
            End If
            If e.ColumnIndex = 1 Then

                If (TypeOf value Is DBNull) OrElse String.IsNullOrEmpty(value.ToString()) Then
                    e.Cancel = True
                    row.ErrorText = "Il campo Causale e' richiesto"
                    Return
                End If
            End If
            If e.ColumnIndex = 2 Then

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
        End Sub
        Private Sub dataGridView1_DataError(ByVal sender As Object, ByVal e As DataGridViewDataErrorEventArgs) Handles dataGridView1.DataError
            dataGridView1.Rows(e.RowIndex).ErrorText = e.Exception.Message
            e.Cancel = True
        End Sub

        Private Sub bindingNavigatorAddNewItem_Click(sender As System.Object, e As System.EventArgs) Handles BindingNavigatorAddNewItem.Click
            Spese_PreventivateBindingSource.AddNew()
        End Sub

    End Class

End Namespace
