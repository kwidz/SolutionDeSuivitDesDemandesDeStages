<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Gestion_des_contacts
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
        Me.GbContacts = New System.Windows.Forms.GroupBox()
        Me.ModifierContact = New System.Windows.Forms.Button()
        Me.SupprimerContact = New System.Windows.Forms.Button()
        Me.AjouterContact = New System.Windows.Forms.Button()
        Me.dgvContacts = New System.Windows.Forms.DataGridView()
        Me.SelectionContactPourGestionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SSDSDataSet = New SSDS.SSDSDataSet()
        Me.dateModification = New System.Windows.Forms.GroupBox()
        Me.AnnulerContact = New System.Windows.Forms.Button()
        Me.SauvegarderContact = New System.Windows.Forms.Button()
        Me.dateCreation = New System.Windows.Forms.Label()
        Me.dateModif = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBoxDescription = New System.Windows.Forms.RichTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBoxPrenom = New System.Windows.Forms.TextBox()
        Me.TextTitre = New System.Windows.Forms.TextBox()
        Me.TextBoxTelephone = New System.Windows.Forms.TextBox()
        Me.TextBoxCouriel = New System.Windows.Forms.TextBox()
        Me.TextBoxNom = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BoutonFermer = New System.Windows.Forms.Button()
        Me.SelectionContactPourGestionTableAdapter = New SSDS.SSDSDataSetTableAdapters.SelectionContactPourGestionTableAdapter()
        Me.NoCONDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NomCONDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrenomCONDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TitreCONDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TelephoneCONDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GbContacts.SuspendLayout()
        CType(Me.dgvContacts, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SelectionContactPourGestionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SSDSDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.dateModification.SuspendLayout()
        Me.SuspendLayout()
        '
        'GbContacts
        '
        Me.GbContacts.Controls.Add(Me.ModifierContact)
        Me.GbContacts.Controls.Add(Me.SupprimerContact)
        Me.GbContacts.Controls.Add(Me.AjouterContact)
        Me.GbContacts.Controls.Add(Me.dgvContacts)
        Me.GbContacts.Location = New System.Drawing.Point(12, 12)
        Me.GbContacts.Name = "GbContacts"
        Me.GbContacts.Size = New System.Drawing.Size(681, 151)
        Me.GbContacts.TabIndex = 0
        Me.GbContacts.TabStop = False
        Me.GbContacts.Text = "Contacts"
        '
        'ModifierContact
        '
        Me.ModifierContact.Location = New System.Drawing.Point(558, 46)
        Me.ModifierContact.Name = "ModifierContact"
        Me.ModifierContact.Size = New System.Drawing.Size(87, 23)
        Me.ModifierContact.TabIndex = 3
        Me.ModifierContact.Text = "Modifier"
        Me.ModifierContact.UseVisualStyleBackColor = True
        '
        'SupprimerContact
        '
        Me.SupprimerContact.Location = New System.Drawing.Point(558, 75)
        Me.SupprimerContact.Name = "SupprimerContact"
        Me.SupprimerContact.Size = New System.Drawing.Size(87, 23)
        Me.SupprimerContact.TabIndex = 2
        Me.SupprimerContact.Text = "Supprimer"
        Me.SupprimerContact.UseVisualStyleBackColor = True
        '
        'AjouterContact
        '
        Me.AjouterContact.Location = New System.Drawing.Point(558, 17)
        Me.AjouterContact.Name = "AjouterContact"
        Me.AjouterContact.Size = New System.Drawing.Size(87, 23)
        Me.AjouterContact.TabIndex = 1
        Me.AjouterContact.Text = "Ajouter"
        Me.AjouterContact.UseVisualStyleBackColor = True
        '
        'dgvContacts
        '
        Me.dgvContacts.AllowUserToAddRows = False
        Me.dgvContacts.AllowUserToDeleteRows = False
        Me.dgvContacts.AutoGenerateColumns = False
        Me.dgvContacts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvContacts.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NoCONDataGridViewTextBoxColumn, Me.NomCONDataGridViewTextBoxColumn, Me.PrenomCONDataGridViewTextBoxColumn, Me.TitreCONDataGridViewTextBoxColumn, Me.TelephoneCONDataGridViewTextBoxColumn})
        Me.dgvContacts.DataSource = Me.SelectionContactPourGestionBindingSource
        Me.dgvContacts.Location = New System.Drawing.Point(6, 17)
        Me.dgvContacts.Name = "dgvContacts"
        Me.dgvContacts.ReadOnly = True
        Me.dgvContacts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvContacts.Size = New System.Drawing.Size(524, 128)
        Me.dgvContacts.TabIndex = 0
        '
        'SelectionContactPourGestionBindingSource
        '
        Me.SelectionContactPourGestionBindingSource.DataMember = "SelectionContactPourGestion"
        Me.SelectionContactPourGestionBindingSource.DataSource = Me.SSDSDataSet
        '
        'SSDSDataSet
        '
        Me.SSDSDataSet.DataSetName = "SSDSDataSet"
        Me.SSDSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'dateModification
        '
        Me.dateModification.Controls.Add(Me.AnnulerContact)
        Me.dateModification.Controls.Add(Me.SauvegarderContact)
        Me.dateModification.Controls.Add(Me.dateCreation)
        Me.dateModification.Controls.Add(Me.dateModif)
        Me.dateModification.Controls.Add(Me.Label6)
        Me.dateModification.Controls.Add(Me.TextBoxDescription)
        Me.dateModification.Controls.Add(Me.Label5)
        Me.dateModification.Controls.Add(Me.Label4)
        Me.dateModification.Controls.Add(Me.Label3)
        Me.dateModification.Controls.Add(Me.Label2)
        Me.dateModification.Controls.Add(Me.TextBoxPrenom)
        Me.dateModification.Controls.Add(Me.TextTitre)
        Me.dateModification.Controls.Add(Me.TextBoxTelephone)
        Me.dateModification.Controls.Add(Me.TextBoxCouriel)
        Me.dateModification.Controls.Add(Me.TextBoxNom)
        Me.dateModification.Controls.Add(Me.Label1)
        Me.dateModification.Location = New System.Drawing.Point(12, 169)
        Me.dateModification.Name = "dateModification"
        Me.dateModification.Size = New System.Drawing.Size(681, 216)
        Me.dateModification.TabIndex = 0
        Me.dateModification.TabStop = False
        Me.dateModification.Text = "Détail du contact"
        '
        'AnnulerContact
        '
        Me.AnnulerContact.Location = New System.Drawing.Point(558, 48)
        Me.AnnulerContact.Name = "AnnulerContact"
        Me.AnnulerContact.Size = New System.Drawing.Size(87, 23)
        Me.AnnulerContact.TabIndex = 8
        Me.AnnulerContact.Text = "Annuler"
        Me.AnnulerContact.UseVisualStyleBackColor = True
        '
        'SauvegarderContact
        '
        Me.SauvegarderContact.Location = New System.Drawing.Point(558, 19)
        Me.SauvegarderContact.Name = "SauvegarderContact"
        Me.SauvegarderContact.Size = New System.Drawing.Size(87, 23)
        Me.SauvegarderContact.TabIndex = 7
        Me.SauvegarderContact.Text = "Sauvegarder"
        Me.SauvegarderContact.UseVisualStyleBackColor = True
        '
        'dateCreation
        '
        Me.dateCreation.AutoSize = True
        Me.dateCreation.Location = New System.Drawing.Point(76, 200)
        Me.dateCreation.Name = "dateCreation"
        Me.dateCreation.Size = New System.Drawing.Size(89, 13)
        Me.dateCreation.TabIndex = 13
        Me.dateCreation.Text = "Date de création:"
        '
        'dateModif
        '
        Me.dateModif.AutoSize = True
        Me.dateModif.Location = New System.Drawing.Point(350, 200)
        Me.dateModif.Name = "dateModif"
        Me.dateModif.Size = New System.Drawing.Size(110, 13)
        Me.dateModif.TabIndex = 12
        Me.dateModif.Text = "Dernière Modification:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(7, 122)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Desciption:"
        '
        'TextBoxDescription
        '
        Me.TextBoxDescription.Location = New System.Drawing.Point(6, 141)
        Me.TextBoxDescription.Name = "TextBoxDescription"
        Me.TextBoxDescription.Size = New System.Drawing.Size(524, 33)
        Me.TextBoxDescription.TabIndex = 6
        Me.TextBoxDescription.Text = ""
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(24, 68)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Prénom:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(34, 94)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Titre:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(328, 38)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Téléphone:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(350, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Couriel:"
        '
        'TextBoxPrenom
        '
        Me.TextBoxPrenom.Location = New System.Drawing.Point(79, 65)
        Me.TextBoxPrenom.Name = "TextBoxPrenom"
        Me.TextBoxPrenom.Size = New System.Drawing.Size(186, 20)
        Me.TextBoxPrenom.TabIndex = 2
        '
        'TextTitre
        '
        Me.TextTitre.Location = New System.Drawing.Point(79, 91)
        Me.TextTitre.Name = "TextTitre"
        Me.TextTitre.Size = New System.Drawing.Size(186, 20)
        Me.TextTitre.TabIndex = 3
        '
        'TextBoxTelephone
        '
        Me.TextBoxTelephone.Location = New System.Drawing.Point(395, 35)
        Me.TextBoxTelephone.Name = "TextBoxTelephone"
        Me.TextBoxTelephone.Size = New System.Drawing.Size(135, 20)
        Me.TextBoxTelephone.TabIndex = 4
        '
        'TextBoxCouriel
        '
        Me.TextBoxCouriel.Location = New System.Drawing.Point(395, 65)
        Me.TextBoxCouriel.Name = "TextBoxCouriel"
        Me.TextBoxCouriel.Size = New System.Drawing.Size(135, 20)
        Me.TextBoxCouriel.TabIndex = 5
        '
        'TextBoxNom
        '
        Me.TextBoxNom.Location = New System.Drawing.Point(79, 39)
        Me.TextBoxNom.Name = "TextBoxNom"
        Me.TextBoxNom.Size = New System.Drawing.Size(186, 20)
        Me.TextBoxNom.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(38, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nom:"
        '
        'BoutonFermer
        '
        Me.BoutonFermer.Location = New System.Drawing.Point(582, 391)
        Me.BoutonFermer.Name = "BoutonFermer"
        Me.BoutonFermer.Size = New System.Drawing.Size(75, 23)
        Me.BoutonFermer.TabIndex = 1
        Me.BoutonFermer.Text = "Fermer"
        Me.BoutonFermer.UseVisualStyleBackColor = True
        '
        'SelectionContactPourGestionTableAdapter
        '
        Me.SelectionContactPourGestionTableAdapter.ClearBeforeFill = True
        '
        'NoCONDataGridViewTextBoxColumn
        '
        Me.NoCONDataGridViewTextBoxColumn.DataPropertyName = "noCON"
        Me.NoCONDataGridViewTextBoxColumn.HeaderText = "noCON"
        Me.NoCONDataGridViewTextBoxColumn.Name = "NoCONDataGridViewTextBoxColumn"
        Me.NoCONDataGridViewTextBoxColumn.ReadOnly = True
        Me.NoCONDataGridViewTextBoxColumn.Visible = False
        '
        'NomCONDataGridViewTextBoxColumn
        '
        Me.NomCONDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.NomCONDataGridViewTextBoxColumn.DataPropertyName = "nomCON"
        Me.NomCONDataGridViewTextBoxColumn.HeaderText = "nom"
        Me.NomCONDataGridViewTextBoxColumn.Name = "NomCONDataGridViewTextBoxColumn"
        Me.NomCONDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PrenomCONDataGridViewTextBoxColumn
        '
        Me.PrenomCONDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.PrenomCONDataGridViewTextBoxColumn.DataPropertyName = "prenomCON"
        Me.PrenomCONDataGridViewTextBoxColumn.HeaderText = "prénom"
        Me.PrenomCONDataGridViewTextBoxColumn.Name = "PrenomCONDataGridViewTextBoxColumn"
        Me.PrenomCONDataGridViewTextBoxColumn.ReadOnly = True
        Me.PrenomCONDataGridViewTextBoxColumn.Width = 67
        '
        'TitreCONDataGridViewTextBoxColumn
        '
        Me.TitreCONDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TitreCONDataGridViewTextBoxColumn.DataPropertyName = "titreCON"
        Me.TitreCONDataGridViewTextBoxColumn.HeaderText = "titre"
        Me.TitreCONDataGridViewTextBoxColumn.Name = "TitreCONDataGridViewTextBoxColumn"
        Me.TitreCONDataGridViewTextBoxColumn.ReadOnly = True
        Me.TitreCONDataGridViewTextBoxColumn.Width = 49
        '
        'TelephoneCONDataGridViewTextBoxColumn
        '
        Me.TelephoneCONDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TelephoneCONDataGridViewTextBoxColumn.DataPropertyName = "telephoneCON"
        Me.TelephoneCONDataGridViewTextBoxColumn.HeaderText = "téléphone"
        Me.TelephoneCONDataGridViewTextBoxColumn.Name = "TelephoneCONDataGridViewTextBoxColumn"
        Me.TelephoneCONDataGridViewTextBoxColumn.ReadOnly = True
        Me.TelephoneCONDataGridViewTextBoxColumn.Width = 79
        '
        'Gestion_des_contacts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(705, 426)
        Me.Controls.Add(Me.BoutonFermer)
        Me.Controls.Add(Me.dateModification)
        Me.Controls.Add(Me.GbContacts)
        Me.Name = "Gestion_des_contacts"
        Me.Text = "Gestion_des_contacts"
        Me.GbContacts.ResumeLayout(False)
        CType(Me.dgvContacts, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SelectionContactPourGestionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SSDSDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.dateModification.ResumeLayout(False)
        Me.dateModification.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GbContacts As System.Windows.Forms.GroupBox
    Friend WithEvents dgvContacts As System.Windows.Forms.DataGridView
    Friend WithEvents ModifierContact As System.Windows.Forms.Button
    Friend WithEvents SupprimerContact As System.Windows.Forms.Button
    Friend WithEvents AjouterContact As System.Windows.Forms.Button
    Friend WithEvents dateModification As System.Windows.Forms.GroupBox
    Friend WithEvents BoutonFermer As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBoxPrenom As System.Windows.Forms.TextBox
    Friend WithEvents TextTitre As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxTelephone As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxCouriel As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxNom As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TextBoxDescription As System.Windows.Forms.RichTextBox
    Friend WithEvents dateCreation As System.Windows.Forms.Label
    Friend WithEvents dateModif As System.Windows.Forms.Label
    Friend WithEvents SSDSDataSet As SSDS.SSDSDataSet
    Friend WithEvents SelectionContactPourGestionBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SelectionContactPourGestionTableAdapter As SSDS.SSDSDataSetTableAdapters.SelectionContactPourGestionTableAdapter
    Friend WithEvents AnnulerContact As System.Windows.Forms.Button
    Friend WithEvents SauvegarderContact As System.Windows.Forms.Button
    Friend WithEvents NoCONDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NomCONDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PrenomCONDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TitreCONDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TelephoneCONDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
