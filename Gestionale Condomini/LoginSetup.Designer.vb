<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginSetup
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoginSetup))
        Me.Host = New System.Windows.Forms.TextBox()
        Me.Port = New System.Windows.Forms.TextBox()
        Me.Hostlbl = New System.Windows.Forms.Label()
        Me.Portlbl = New System.Windows.Forms.Label()
        Me.Imposta = New System.Windows.Forms.Button()
        Me.Reset = New System.Windows.Forms.Button()
        Me.Databaselbl = New System.Windows.Forms.Label()
        Me.database = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Host
        '
        Me.Host.Location = New System.Drawing.Point(15, 25)
        Me.Host.Name = "Host"
        Me.Host.Size = New System.Drawing.Size(171, 20)
        Me.Host.TabIndex = 0
        '
        'Port
        '
        Me.Port.Location = New System.Drawing.Point(86, 57)
        Me.Port.Name = "Port"
        Me.Port.Size = New System.Drawing.Size(100, 20)
        Me.Port.TabIndex = 1
        '
        'Hostlbl
        '
        Me.Hostlbl.AutoSize = True
        Me.Hostlbl.Location = New System.Drawing.Point(12, 9)
        Me.Hostlbl.Name = "Hostlbl"
        Me.Hostlbl.Size = New System.Drawing.Size(77, 13)
        Me.Hostlbl.TabIndex = 2
        Me.Hostlbl.Text = "Hostname o IP"
        '
        'Portlbl
        '
        Me.Portlbl.AutoSize = True
        Me.Portlbl.Location = New System.Drawing.Point(53, 60)
        Me.Portlbl.Name = "Portlbl"
        Me.Portlbl.Size = New System.Drawing.Size(26, 13)
        Me.Portlbl.TabIndex = 3
        Me.Portlbl.Text = "Port"
        '
        'Imposta
        '
        Me.Imposta.Location = New System.Drawing.Point(111, 142)
        Me.Imposta.Name = "Imposta"
        Me.Imposta.Size = New System.Drawing.Size(75, 23)
        Me.Imposta.TabIndex = 4
        Me.Imposta.Text = "Imposta"
        Me.Imposta.UseVisualStyleBackColor = True
        '
        'Reset
        '
        Me.Reset.Location = New System.Drawing.Point(15, 142)
        Me.Reset.Name = "Reset"
        Me.Reset.Size = New System.Drawing.Size(75, 23)
        Me.Reset.TabIndex = 5
        Me.Reset.Text = "Reset"
        Me.Reset.UseVisualStyleBackColor = True
        '
        'Databaselbl
        '
        Me.Databaselbl.AutoSize = True
        Me.Databaselbl.Location = New System.Drawing.Point(12, 99)
        Me.Databaselbl.Name = "Databaselbl"
        Me.Databaselbl.Size = New System.Drawing.Size(53, 13)
        Me.Databaselbl.TabIndex = 6
        Me.Databaselbl.Text = "Database"
        '
        'database
        '
        Me.database.Location = New System.Drawing.Point(70, 96)
        Me.database.Name = "database"
        Me.database.Size = New System.Drawing.Size(116, 20)
        Me.database.TabIndex = 7
        '
        'LoginSetup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(199, 169)
        Me.Controls.Add(Me.database)
        Me.Controls.Add(Me.Databaselbl)
        Me.Controls.Add(Me.Reset)
        Me.Controls.Add(Me.Imposta)
        Me.Controls.Add(Me.Portlbl)
        Me.Controls.Add(Me.Hostlbl)
        Me.Controls.Add(Me.Port)
        Me.Controls.Add(Me.Host)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "LoginSetup"
        Me.Text = "Opzioni"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Host As System.Windows.Forms.TextBox
    Friend WithEvents Port As System.Windows.Forms.TextBox
    Friend WithEvents Hostlbl As System.Windows.Forms.Label
    Friend WithEvents Portlbl As System.Windows.Forms.Label
    Friend WithEvents Imposta As System.Windows.Forms.Button
    Friend WithEvents Reset As System.Windows.Forms.Button
    Friend WithEvents Databaselbl As System.Windows.Forms.Label
    Friend WithEvents database As System.Windows.Forms.TextBox
End Class
