<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Consultation_des_démarches
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.GBEtudiants = New System.Windows.Forms.GroupBox()
        Me.dgvEtudiants = New System.Windows.Forms.DataGridView()
        Me.NoUTILDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NomPrenomDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EstActifDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DateCreationDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ListerUserByAllNPABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SSDSDataSet = New SSDS.SSDSDataSet()
        Me.Fermer = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBoxNomEtu = New System.Windows.Forms.TextBox()
        Me.TextBoxPrenomEtu = New System.Windows.Forms.TextBox()
        Me.Actif = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Inactif = New System.Windows.Forms.RadioButton()
        Me.Tous = New System.Windows.Forms.RadioButton()
        Me.ListerUserByAllNPATableAdapter = New SSDS.SSDSDataSetTableAdapters.ListerUserByAllNPATableAdapter()
        Me.GBEtudiants.SuspendLayout()
        CType(Me.dgvEtudiants, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListerUserByAllNPABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SSDSDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GBEtudiants
        '
        Me.GBEtudiants.Controls.Add(Me.dgvEtudiants)
        Me.GBEtudiants.Location = New System.Drawing.Point(12, 110)
        Me.GBEtudiants.Name = "GBEtudiants"
        Me.GBEtudiants.Size = New System.Drawing.Size(520, 272)
        Me.GBEtudiants.TabIndex = 1
        Me.GBEtudiants.TabStop = False
        Me.GBEtudiants.Text = "Étudiants"
        '
        'dgvEtudiants
        '
        Me.dgvEtudiants.AllowUserToAddRows = False
        Me.dgvEtudiants.AllowUserToDeleteRows = False
        Me.dgvEtudiants.AutoGenerateColumns = False
        Me.dgvEtudiants.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEtudiants.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NoUTILDataGridViewTextBoxColumn, Me.NomPrenomDataGridViewTextBoxColumn, Me.EstActifDataGridViewCheckBoxColumn, Me.DateCreationDataGridViewTextBoxColumn})
        Me.dgvEtudiants.DataSource = Me.ListerUserByAllNPABindingSource
        Me.dgvEtudiants.Location = New System.Drawing.Point(14, 29)
        Me.dgvEtudiants.MultiSelect = False
        Me.dgvEtudiants.Name = "dgvEtudiants"
        Me.dgvEtudiants.ReadOnly = True
        Me.dgvEtudiants.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvEtudiants.Size = New System.Drawing.Size(490, 228)
        Me.dgvEtudiants.TabIndex = 8
        '
        'NoUTILDataGridViewTextBoxColumn
        '
        Me.NoUTILDataGridViewTextBoxColumn.DataPropertyName = "noUTIL"
        Me.NoUTILDataGridViewTextBoxColumn.HeaderText = "noUTIL"
        Me.NoUTILDataGridViewTextBoxColumn.Name = "NoUTILDataGridViewTextBoxColumn"
        Me.NoUTILDataGridViewTextBoxColumn.ReadOnly = True
        Me.NoUTILDataGridViewTextBoxColumn.Visible = False
        '
        'NomPrenomDataGridViewTextBoxColumn
        '
        Me.NomPrenomDataGridViewTextBoxColumn.DataPropertyName = "nomPrenom"
        Me.NomPrenomDataGridViewTextBoxColumn.HeaderText = "nomPrenom"
        Me.NomPrenomDataGridViewTextBoxColumn.Name = "NomPrenomDataGridViewTextBoxColumn"
        Me.NomPrenomDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EstActifDataGridViewCheckBoxColumn
        '
        Me.EstActifDataGridViewCheckBoxColumn.DataPropertyName = "estActif"
        Me.EstActifDataGridViewCheckBoxColumn.HeaderText = "estActif"
        Me.EstActifDataGridViewCheckBoxColumn.Name = "EstActifDataGridViewCheckBoxColumn"
        Me.EstActifDataGridViewCheckBoxColumn.ReadOnly = True
        '
        'DateCreationDataGridViewTextBoxColumn
        '
        Me.DateCreationDataGridViewTextBoxColumn.DataPropertyName = "dateCreation"
        Me.DateCreationDataGridViewTextBoxColumn.HeaderText = "dateCreation"
        Me.DateCreationDataGridViewTextBoxColumn.Name = "DateCreationDataGridViewTextBoxColumn"
        Me.DateCreationDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ListerUserByAllNPABindingSource
        '
        Me.ListerUserByAllNPABindingSource.DataMember = "ListerUserByAllNPA"
        Me.ListerUserByAllNPABindingSource.DataSource = Me.SSDSDataSet
        '
        'SSDSDataSet
        '
        Me.SSDSDataSet.DataSetName = "SSDSDataSet"
        Me.SSDSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Fermer
        '
        Me.Fermer.Location = New System.Drawing.Point(457, 392)
        Me.Fermer.Name = "Fermer"
        Me.Fermer.Size = New System.Drawing.Size(75, 23)
        Me.Fermer.TabIndex = 9
        Me.Fermer.Text = "Fermer"
        Me.Fermer.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nom:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Prénom:"
        '
        'TextBoxNomEtu
        '
        Me.TextBoxNomEtu.Location = New System.Drawing.Point(63, 22)
        Me.TextBoxNomEtu.Name = "TextBoxNomEtu"
        Me.TextBoxNomEtu.Size = New System.Drawing.Size(136, 20)
        Me.TextBoxNomEtu.TabIndex = 2
        '
        'TextBoxPrenomEtu
        '
        Me.TextBoxPrenomEtu.Location = New System.Drawing.Point(63, 51)
        Me.TextBoxPrenomEtu.Name = "TextBoxPrenomEtu"
        Me.TextBoxPrenomEtu.Size = New System.Drawing.Size(136, 20)
        Me.TextBoxPrenomEtu.TabIndex = 3
        '
        'Actif
        '
        Me.Actif.AutoSize = True
        Me.Actif.Location = New System.Drawing.Point(229, 21)
        Me.Actif.Name = "Actif"
        Me.Actif.Size = New System.Drawing.Size(51, 17)
        Me.Actif.TabIndex = 4
        Me.Actif.Text = "Actifs"
        Me.Actif.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Inactif)
        Me.GroupBox1.Controls.Add(Me.Tous)
        Me.GroupBox1.Controls.Add(Me.Actif)
        Me.GroupBox1.Controls.Add(Me.TextBoxPrenomEtu)
        Me.GroupBox1.Controls.Add(Me.TextBoxNomEtu)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(520, 92)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Recherche"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(415, 18)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(89, 23)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Rechercher"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Inactif
        '
        Me.Inactif.AutoSize = True
        Me.Inactif.Location = New System.Drawing.Point(295, 21)
        Me.Inactif.Name = "Inactif"
        Me.Inactif.Size = New System.Drawing.Size(59, 17)
        Me.Inactif.TabIndex = 5
        Me.Inactif.Text = "Inactifs"
        Me.Inactif.UseVisualStyleBackColor = True
        '
        'Tous
        '
        Me.Tous.AutoSize = True
        Me.Tous.Checked = True
        Me.Tous.Location = New System.Drawing.Point(360, 22)
        Me.Tous.Name = "Tous"
        Me.Tous.Size = New System.Drawing.Size(49, 17)
        Me.Tous.TabIndex = 6
        Me.Tous.TabStop = True
        Me.Tous.Text = "Tous"
        Me.Tous.UseVisualStyleBackColor = True
        '
        'ListerUserByAllNPATableAdapter
        '
        Me.ListerUserByAllNPATableAdapter.ClearBeforeFill = True
        '
        'Consultation_des_démarches
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(543, 427)
        Me.Controls.Add(Me.Fermer)
        Me.Controls.Add(Me.GBEtudiants)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Consultation_des_démarches"
        Me.Text = "Consultation des démarches"
        Me.GBEtudiants.ResumeLayout(False)
        CType(Me.dgvEtudiants, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListerUserByAllNPABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SSDSDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GBEtudiants As System.Windows.Forms.GroupBox
    Friend WithEvents Fermer As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBoxNomEtu As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxPrenomEtu As System.Windows.Forms.TextBox
    Friend WithEvents Actif As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Inactif As System.Windows.Forms.RadioButton
    Friend WithEvents Tous As System.Windows.Forms.RadioButton
    Friend WithEvents dgvEtudiants As System.Windows.Forms.DataGridView
    Friend WithEvents CourielUTILDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NomUTILDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PrenomUTILDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MdpUTILDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DateModifDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DateSuppressionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NoTYPUTILDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SSDSDataSet As SSDS.SSDSDataSet
    Friend WithEvents NoUTILDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NomPrenomDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EstActifDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DateCreationDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ListerUserByAllNPABindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ListerUserByAllNPATableAdapter As SSDS.SSDSDataSetTableAdapters.ListerUserByAllNPATableAdapter
End Class
