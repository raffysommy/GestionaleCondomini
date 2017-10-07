Imports System.ComponentModel
Imports MySql.Data.MySqlClient
Imports Autenticazione

Namespace Gestionale_Condomini

    Public Class frmCondomini

        Private ad As MySqlDataAdapter

        Private Sub frmCondomini_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
            Dim str As StringaConnessione = New StringaConnessione
            Dim strConn As String = str.conn
            ad = New MySqlDataAdapter("select * from `Condomini`", strConn)
            Dim builder As MySqlCommandBuilder = New MySqlCommandBuilder(ad)
            ad.Fill(Me.newDataSet.Condomini)
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
            Dim colInterno_PI As System.Windows.Forms.DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
            colInterno_PI.DataPropertyName = "Interno_PI"
            colInterno_PI.HeaderText = "Interno_PI"
            colInterno_PI.Name = "colInterno_PI"
            colInterno_PI.MaxInputLength = 5
            dataGridView1.Columns.Add(colInterno_PI)
            Dim colNome As System.Windows.Forms.DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
            colNome.DataPropertyName = "Nome"
            colNome.HeaderText = "Nome"
            colNome.Name = "colNome"
            colNome.MaxInputLength = 45
            dataGridView1.Columns.Add(colNome)
            Dim colCognome As System.Windows.Forms.DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
            colCognome.DataPropertyName = "Cognome"
            colCognome.HeaderText = "Cognome"
            colCognome.Name = "colCognome"
            colCognome.MaxInputLength = 45
            dataGridView1.Columns.Add(colCognome)
            Dim colTelefono As System.Windows.Forms.DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
            colTelefono.DataPropertyName = "Telefono"
            colTelefono.HeaderText = "Telefono"
            colTelefono.Name = "colTelefono"
            dataGridView1.Columns.Add(colTelefono)
            Dim colScala As System.Windows.Forms.DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
            colScala.DataPropertyName = "Scala"
            colScala.HeaderText = "Scala"
            colScala.Name = "colScala"
            colScala.MaxInputLength = 1
            dataGridView1.Columns.Add(colScala)
            Me.dataGridView1.DataSource = Me.CondominiBindingSource
        End Sub

        Private Sub ToolStripButton1_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton1.Click
            If Not Me.Validate() Then
                Return
            End If
            CondominiBindingSource.EndEdit()
            ad.Update(Me.newDataSet.Condomini)
        End Sub

        Private Sub frmCondomini_FormClosing(sender As System.Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
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
                    row.ErrorText = "Il campo Interno e' Richiesto"
                    Return
                End If
            End If
            If e.ColumnIndex = 1 Then

                If (TypeOf value Is DBNull) OrElse String.IsNullOrEmpty(value.ToString()) Then
                    e.Cancel = True
                    row.ErrorText = "Il campo Nome e' richiesto"
                    Return
                End If
            End If
            If e.ColumnIndex = 2 Then

                If (TypeOf value Is DBNull) OrElse String.IsNullOrEmpty(value.ToString()) Then
                    e.Cancel = True
                    row.ErrorText = "Il campo Cognome e' richiesto"
                    Return
                End If
            End If
            If e.ColumnIndex = 3 Then

                Dim v As Integer
                If (TypeOf value Is DBNull) OrElse String.IsNullOrEmpty(value.ToString()) Then
                    'e.Cancel = True
                    'row.ErrorText = "Il campo Telefono e' richiesto"
                    Return
                End If
                s = value.ToString()
                If Not Integer.TryParse(s, v) Then
                    e.Cancel = True
                    row.ErrorText = "Il campo Telefono deve essere un numero."
                    Return
                End If
            End If
            If e.ColumnIndex = 4 Then

                If (TypeOf value Is DBNull) OrElse String.IsNullOrEmpty(value.ToString()) Then
                    e.Cancel = True
                    row.ErrorText = "Il campo Scala e' richiesto"
                    Return
                End If
            End If
        End Sub
        Private Sub dataGridView1_DataError(ByVal sender As Object, ByVal e As DataGridViewDataErrorEventArgs) Handles dataGridView1.DataError
            dataGridView1.Rows(e.RowIndex).ErrorText = e.Exception.Message
            e.Cancel = True
        End Sub

        Private Sub bindingNavigatorAddNewItem_Click(sender As System.Object, e As System.EventArgs) Handles BindingNavigatorAddNewItem.Click
            CondominiBindingSource.AddNew()
        End Sub

    End Class

End Namespace
