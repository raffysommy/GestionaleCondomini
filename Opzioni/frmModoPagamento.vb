
Imports System.ComponentModel
Imports MySql.Data.MySqlClient
Imports Autenticazione

Namespace Gestionale_Condomini

    Public Class frmModoPagamento
        Dim str As StringaConnessione = New StringaConnessione
        Private ad As MySqlDataAdapter

        Private Sub frmModoPagamento_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
            Dim strConn As String = str.conn
            ad = New MySqlDataAdapter("select * from `ModoPagamento`", strConn)
            Dim builder As MySqlCommandBuilder = New MySqlCommandBuilder(ad)
            ad.Fill(Me.newDataSet.ModoPagamento)
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
            DataGridView1.AutoGenerateColumns = True
            Dim strConn2 As String = str.conn
            Dim ad2 As MySql.Data.MySqlClient.MySqlDataAdapter = Nothing

            Me.DataGridView1.DataSource = Me.ModoPagamentoBindingSource
        End Sub



        Private Sub frmModoPagamento_FormClosing(sender As System.Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
            e.Cancel = False
        End Sub

        Private Sub dataGridView1_CellValidating(sender As Object, e As DataGridViewCellValidatingEventArgs)


            Dim row As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
            Dim value As Object = e.FormattedValue
            e.Cancel = False
            row.ErrorText = ""
            If row.IsNewRow Then
                Return
            End If
            If e.ColumnIndex = 0 Then

                If (TypeOf value Is DBNull) OrElse String.IsNullOrEmpty(value.ToString()) Then
                    e.Cancel = True
                    row.ErrorText = "Il campo CodPagamento e' richiesto"
                    Return
                End If
            End If
            If e.ColumnIndex = 1 Then

                If (TypeOf value Is DBNull) OrElse String.IsNullOrEmpty(value.ToString()) Then
                    e.Cancel = True
                    row.ErrorText = "Il campo DescrPagamento e' richiesto"
                    Return
                End If
            End If
        End Sub
        Private Sub dataGridView1_DataError(ByVal sender As Object, ByVal e As DataGridViewDataErrorEventArgs)
            DataGridView1.Rows(e.RowIndex).ErrorText = e.Exception.Message
            e.Cancel = True
        End Sub

        Private Sub bindingNavigatorAddNewItem_Click(sender As System.Object, e As System.EventArgs)
            ModoPagamentoBindingSource.AddNew()
        End Sub

        Private Sub ToolStripButton1_Click_1(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
            If Not Me.Validate() Then
                Return
            End If
            ModoPagamentoBindingSource.EndEdit()
            ad.Update(Me.newDataSet.ModoPagamento)
        End Sub
    End Class

End Namespace
