<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class insCondomini
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(insCondomini))
        Me.NewDataSet1 = New NewDataSet()
        Me.Internolb = New System.Windows.Forms.Label()
        Me.Interno = New System.Windows.Forms.TextBox()
        Me.CondominiBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CondominiBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Nome = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Cognome = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Telefono = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Scala = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Aggiungi = New System.Windows.Forms.Button()
        Me.Cancella = New System.Windows.Forms.Button()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.NewDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CondominiBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CondominiBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NewDataSet1
        '
        Me.NewDataSet1.DataSetName = "NewDataSet"
        Me.NewDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Internolb
        '
        Me.Internolb.AutoSize = True
        Me.Internolb.Location = New System.Drawing.Point(60, 86)
        Me.Internolb.Name = "Internolb"
        Me.Internolb.Size = New System.Drawing.Size(40, 13)
        Me.Internolb.TabIndex = 0
        Me.Internolb.Text = "INT/PI"
        '
        'Interno
        '
        Me.Interno.DataBindings.Add(New System.Windows.Forms.Binding("Tag", Me.CondominiBindingSource, "Interno_PI", True))
        Me.Interno.DataBindings.Add(New System.Windows.Forms.Binding("MaxLength", Me.CondominiBindingSource1, "Interno_PI", True))
        Me.Interno.Location = New System.Drawing.Point(105, 83)
        Me.Interno.MaxLength = 5
        Me.Interno.Name = "Interno"
        Me.Interno.Size = New System.Drawing.Size(100, 20)
        Me.Interno.TabIndex = 1
        '
        'CondominiBindingSource
        '
        Me.CondominiBindingSource.DataMember = "Condomini"
        Me.CondominiBindingSource.DataSource = Me.NewDataSet1
        '
        'CondominiBindingSource1
        '
        Me.CondominiBindingSource1.DataMember = "Condomini"
        Me.CondominiBindingSource1.DataSource = Me.NewDataSet1
        '
        'Nome
        '
        Me.Nome.DataBindings.Add(New System.Windows.Forms.Binding("Tag", Me.CondominiBindingSource, "Nome", True))
        Me.Nome.Location = New System.Drawing.Point(105, 138)
        Me.Nome.Name = "Nome"
        Me.Nome.Size = New System.Drawing.Size(100, 20)
        Me.Nome.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(60, 141)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nome"
        '
        'Cognome
        '
        Me.Cognome.DataBindings.Add(New System.Windows.Forms.Binding("Tag", Me.CondominiBindingSource, "Cognome", True))
        Me.Cognome.Location = New System.Drawing.Point(297, 141)
        Me.Cognome.Name = "Cognome"
        Me.Cognome.Size = New System.Drawing.Size(100, 20)
        Me.Cognome.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(237, 141)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Cognome"
        '
        'Telefono
        '
        Me.Telefono.DataBindings.Add(New System.Windows.Forms.Binding("Tag", Me.CondominiBindingSource, "Telefono", True))
        Me.Telefono.Location = New System.Drawing.Point(120, 190)
        Me.Telefono.Name = "Telefono"
        Me.Telefono.Size = New System.Drawing.Size(100, 20)
        Me.Telefono.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(60, 190)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Telefono"
        '
        'Scala
        '
        Me.Scala.DataBindings.Add(New System.Windows.Forms.Binding("Tag", Me.CondominiBindingSource, "Scala", True))
        Me.Scala.Location = New System.Drawing.Point(334, 189)
        Me.Scala.Name = "Scala"
        Me.Scala.Size = New System.Drawing.Size(64, 20)
        Me.Scala.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(294, 193)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(34, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Scala"
        '
        'Aggiungi
        '
        Me.Aggiungi.Location = New System.Drawing.Point(392, 272)
        Me.Aggiungi.Name = "Aggiungi"
        Me.Aggiungi.Size = New System.Drawing.Size(75, 23)
        Me.Aggiungi.TabIndex = 10
        Me.Aggiungi.Text = "Aggiungi"
        Me.Aggiungi.UseVisualStyleBackColor = True
        '
        'Cancella
        '
        Me.Cancella.Location = New System.Drawing.Point(297, 272)
        Me.Cancella.Name = "Cancella"
        Me.Cancella.Size = New System.Drawing.Size(75, 23)
        Me.Cancella.TabIndex = 11
        Me.Cancella.Text = "Cancella"
        Me.Cancella.UseVisualStyleBackColor = True
        '
        'insCondomini
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(499, 320)
        Me.Controls.Add(Me.Cancella)
        Me.Controls.Add(Me.Aggiungi)
        Me.Controls.Add(Me.Scala)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Telefono)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Cognome)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Nome)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Interno)
        Me.Controls.Add(Me.Internolb)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "insCondomini"
        Me.Text = "Inserisci Condomino"
        CType(Me.NewDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CondominiBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CondominiBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents NewDataSet1 As NewDataSet
    Friend WithEvents Internolb As System.Windows.Forms.Label
    Friend WithEvents Interno As System.Windows.Forms.TextBox
    Friend WithEvents Nome As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Cognome As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Telefono As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Scala As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Aggiungi As System.Windows.Forms.Button
    Friend WithEvents Cancella As System.Windows.Forms.Button
    Friend WithEvents CondominiBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CondominiBindingSource1 As System.Windows.Forms.BindingSource
End Class
