<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChkMillesimi
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla nell'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.NewDataSet = New Opzioni.NewDataSet()
        Me.Tabella_Millesimale1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tabella_Millesimale1DataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        CType(Me.NewDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tabella_Millesimale1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tabella_Millesimale1DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NewDataSet
        '
        Me.NewDataSet.DataSetName = "NewDataSet"
        Me.NewDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Tabella_Millesimale1BindingSource
        '
        Me.Tabella_Millesimale1BindingSource.DataMember = "Tabella_Millesimale1"
        Me.Tabella_Millesimale1BindingSource.DataSource = Me.NewDataSet
        '
        'Tabella_Millesimale1DataGridView
        '
        Me.Tabella_Millesimale1DataGridView.AllowUserToAddRows = False
        Me.Tabella_Millesimale1DataGridView.AllowUserToDeleteRows = False
        Me.Tabella_Millesimale1DataGridView.AllowUserToResizeColumns = False
        Me.Tabella_Millesimale1DataGridView.AllowUserToResizeRows = False
        Me.Tabella_Millesimale1DataGridView.AutoGenerateColumns = False
        Me.Tabella_Millesimale1DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Tabella_Millesimale1DataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewCheckBoxColumn1})
        Me.Tabella_Millesimale1DataGridView.DataSource = Me.Tabella_Millesimale1BindingSource
        Me.Tabella_Millesimale1DataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Tabella_Millesimale1DataGridView.Location = New System.Drawing.Point(0, 0)
        Me.Tabella_Millesimale1DataGridView.Name = "Tabella_Millesimale1DataGridView"
        Me.Tabella_Millesimale1DataGridView.ReadOnly = True
        Me.Tabella_Millesimale1DataGridView.Size = New System.Drawing.Size(464, 407)
        Me.Tabella_Millesimale1DataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Tabella"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Tabella"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.DataPropertyName = "Check"
        Me.DataGridViewCheckBoxColumn1.HeaderText = "Check"
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        Me.DataGridViewCheckBoxColumn1.ReadOnly = True
        '
        'ChkMillesimi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(464, 407)
        Me.Controls.Add(Me.Tabella_Millesimale1DataGridView)
        Me.Name = "ChkMillesimi"
        Me.Text = "ChkMillesimi"
        CType(Me.NewDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tabella_Millesimale1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tabella_Millesimale1DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents NewDataSet As Opzioni.NewDataSet
    Friend WithEvents Tabella_Millesimale1BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tabella_Millesimale1DataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As System.Windows.Forms.DataGridViewCheckBoxColumn
End Class
