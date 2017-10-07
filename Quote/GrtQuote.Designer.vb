<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GrtQuote
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GrtQuote))
        Me.Quietanze = New System.Windows.Forms.Button()
        Me.Pdf = New System.Windows.Forms.Button()
        Me.DescrizioneMeseComboBox = New System.Windows.Forms.ComboBox()
        Me.MesiBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NewDataSet = New Quote.NewDataSet()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.OrdinarieAnnoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ordinarie = New System.Windows.Forms.RadioButton()
        Me.Straordinarie = New System.Windows.Forms.RadioButton()
        Me.StraordinarieAnnoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.MesiBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NewDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrdinarieAnnoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StraordinarieAnnoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Quietanze
        '
        Me.Quietanze.Location = New System.Drawing.Point(223, 61)
        Me.Quietanze.Name = "Quietanze"
        Me.Quietanze.Size = New System.Drawing.Size(153, 23)
        Me.Quietanze.TabIndex = 0
        Me.Quietanze.Text = "Genera Quietanze"
        Me.Quietanze.UseVisualStyleBackColor = True
        '
        'Pdf
        '
        Me.Pdf.Enabled = False
        Me.Pdf.Location = New System.Drawing.Point(223, 162)
        Me.Pdf.Name = "Pdf"
        Me.Pdf.Size = New System.Drawing.Size(153, 23)
        Me.Pdf.TabIndex = 1
        Me.Pdf.Text = "Esporta PDF"
        Me.Pdf.UseVisualStyleBackColor = True
        '
        'DescrizioneMeseComboBox
        '
        Me.DescrizioneMeseComboBox.DataSource = Me.MesiBindingSource
        Me.DescrizioneMeseComboBox.DisplayMember = "DescrizioneMese"
        Me.DescrizioneMeseComboBox.FormattingEnabled = True
        Me.DescrizioneMeseComboBox.Location = New System.Drawing.Point(70, 60)
        Me.DescrizioneMeseComboBox.Name = "DescrizioneMeseComboBox"
        Me.DescrizioneMeseComboBox.Size = New System.Drawing.Size(121, 21)
        Me.DescrizioneMeseComboBox.TabIndex = 2
        '
        'MesiBindingSource
        '
        Me.MesiBindingSource.DataMember = "Mesi"
        Me.MesiBindingSource.DataSource = Me.NewDataSet
        '
        'NewDataSet
        '
        Me.NewDataSet.DataSetName = "NewDataSet"
        Me.NewDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Mese:"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(223, 90)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(153, 23)
        Me.ProgressBar1.TabIndex = 4
        '
        'OrdinarieAnnoBindingSource
        '
        Me.OrdinarieAnnoBindingSource.DataMember = "OrdinarieAnno"
        Me.OrdinarieAnnoBindingSource.DataSource = Me.NewDataSet
        '
        'Ordinarie
        '
        Me.Ordinarie.AutoSize = True
        Me.Ordinarie.Checked = True
        Me.Ordinarie.Location = New System.Drawing.Point(31, 125)
        Me.Ordinarie.Name = "Ordinarie"
        Me.Ordinarie.Size = New System.Drawing.Size(67, 17)
        Me.Ordinarie.TabIndex = 5
        Me.Ordinarie.TabStop = True
        Me.Ordinarie.Text = "Ordinarie"
        Me.Ordinarie.UseVisualStyleBackColor = True
        '
        'Straordinarie
        '
        Me.Straordinarie.AutoSize = True
        Me.Straordinarie.Location = New System.Drawing.Point(31, 149)
        Me.Straordinarie.Name = "Straordinarie"
        Me.Straordinarie.Size = New System.Drawing.Size(84, 17)
        Me.Straordinarie.TabIndex = 6
        Me.Straordinarie.Text = "Straordinarie"
        Me.Straordinarie.UseVisualStyleBackColor = True
        '
        'StraordinarieAnnoBindingSource
        '
        Me.StraordinarieAnnoBindingSource.DataMember = "StraordinarieAnno"
        Me.StraordinarieAnnoBindingSource.DataSource = Me.NewDataSet
        '
        'GrtQuote
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(434, 211)
        Me.Controls.Add(Me.Straordinarie)
        Me.Controls.Add(Me.Ordinarie)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DescrizioneMeseComboBox)
        Me.Controls.Add(Me.Pdf)
        Me.Controls.Add(Me.Quietanze)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "GrtQuote"
        Me.Text = "Stampa Quote"
        CType(Me.MesiBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NewDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrdinarieAnnoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StraordinarieAnnoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Quietanze As System.Windows.Forms.Button
    Friend WithEvents Pdf As System.Windows.Forms.Button
    Friend WithEvents DescrizioneMeseComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents NewDataSet As Quote.NewDataSet
    Friend WithEvents MesiBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents OrdinarieAnnoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Ordinarie As System.Windows.Forms.RadioButton
    Friend WithEvents Straordinarie As System.Windows.Forms.RadioButton
    Friend WithEvents StraordinarieAnnoBindingSource As System.Windows.Forms.BindingSource
End Class
