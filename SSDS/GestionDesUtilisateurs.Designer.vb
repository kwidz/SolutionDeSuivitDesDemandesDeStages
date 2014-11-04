<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GestionDesUtilisateurs
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Rechercher = New System.Windows.Forms.Button()
        Me.Inactifs = New System.Windows.Forms.RadioButton()
        Me.Tous = New System.Windows.Forms.RadioButton()
        Me.Actifs = New System.Windows.Forms.RadioButton()
        Me.Type = New System.Windows.Forms.ComboBox()
        Me.SelectionRefTypUtilWithTousBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SSDSDataSet1 = New SSDS.SSDSDataSet()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxPrenom = New System.Windows.Forms.TextBox()
        Me.TextBoxNom = New System.Windows.Forms.TextBox()
        Me.SSDSDataSet = New SSDS.SSDSDataSet()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.CheckBoxDetailActif = New System.Windows.Forms.CheckBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DateCreation = New System.Windows.Forms.Label()
        Me.DerniereModification = New System.Windows.Forms.Label()
        Me.ComboBoxDetailType = New System.Windows.Forms.ComboBox()
        Me.REFTypeUtilisateurBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SSDSDataSet2 = New SSDS.SSDSDataSet()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.TextBoxDetailNom = New System.Windows.Forms.TextBox()
        Me.TextBoxDetailPrenom = New System.Windows.Forms.TextBox()
        Me.TextBoxDetailCouriel = New System.Windows.Forms.TextBox()
        Me.REFTypeUtilisateurBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.gbResultats = New System.Windows.Forms.GroupBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.dgvEtudiants = New System.Windows.Forms.DataGridView()
        Me.NoUTILDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NomPrenomDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NomTYPUTILlDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EstActifDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DateCreationDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ListerUserByAllNPAWithTypeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ListerUserByAllNPAWithTypeTableAdapter = New SSDS.SSDSDataSetTableAdapters.ListerUserByAllNPAWithTypeTableAdapter()
        Me.SelectionRefTypUtilWithTousTableAdapter = New SSDS.SSDSDataSetTableAdapters.selectionRefTypUtilWithTousTableAdapter()
        Me.REF_TypeUtilisateurTableAdapter = New SSDS.SSDSDataSetTableAdapters.REF_TypeUtilisateurTableAdapter()
        Me.GroupBox1.SuspendLayout()
        CType(Me.SelectionRefTypUtilWithTousBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SSDSDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SSDSDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.REFTypeUtilisateurBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SSDSDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.REFTypeUtilisateurBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbResultats.SuspendLayout()
        CType(Me.dgvEtudiants, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListerUserByAllNPAWithTypeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Rechercher)
        Me.GroupBox1.Controls.Add(Me.Inactifs)
        Me.GroupBox1.Controls.Add(Me.Tous)
        Me.GroupBox1.Controls.Add(Me.Actifs)
        Me.GroupBox1.Controls.Add(Me.Type)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TextBoxPrenom)
        Me.GroupBox1.Controls.Add(Me.TextBoxNom)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(611, 80)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Recherche"
        '
        'Rechercher
        '
        Me.Rechercher.Location = New System.Drawing.Point(499, 15)
        Me.Rechercher.Name = "Rechercher"
        Me.Rechercher.Size = New System.Drawing.Size(101, 23)
        Me.Rechercher.TabIndex = 7
        Me.Rechercher.Text = "Rechercher"
        Me.Rechercher.UseVisualStyleBackColor = True
        '
        'Inactifs
        '
        Me.Inactifs.AutoSize = True
        Me.Inactifs.Location = New System.Drawing.Point(290, 18)
        Me.Inactifs.Name = "Inactifs"
        Me.Inactifs.Size = New System.Drawing.Size(59, 17)
        Me.Inactifs.TabIndex = 4
        Me.Inactifs.Text = "Inactifs"
        Me.Inactifs.UseVisualStyleBackColor = True
        '
        'Tous
        '
        Me.Tous.AutoSize = True
        Me.Tous.Checked = True
        Me.Tous.Location = New System.Drawing.Point(355, 18)
        Me.Tous.Name = "Tous"
        Me.Tous.Size = New System.Drawing.Size(49, 17)
        Me.Tous.TabIndex = 5
        Me.Tous.TabStop = True
        Me.Tous.Text = "Tous"
        Me.Tous.UseVisualStyleBackColor = True
        '
        'Actifs
        '
        Me.Actifs.AutoSize = True
        Me.Actifs.Location = New System.Drawing.Point(233, 18)
        Me.Actifs.Name = "Actifs"
        Me.Actifs.Size = New System.Drawing.Size(51, 17)
        Me.Actifs.TabIndex = 3
        Me.Actifs.Text = "Actifs"
        Me.Actifs.UseVisualStyleBackColor = True
        '
        'Type
        '
        Me.Type.DataSource = Me.SelectionRefTypUtilWithTousBindingSource
        Me.Type.DisplayMember = "nomTYPUTILl"
        Me.Type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Type.FormattingEnabled = True
        Me.Type.Location = New System.Drawing.Point(270, 45)
        Me.Type.Name = "Type"
        Me.Type.Size = New System.Drawing.Size(121, 21)
        Me.Type.TabIndex = 6
        Me.Type.ValueMember = "noTYPUTIL"
        '
        'SelectionRefTypUtilWithTousBindingSource
        '
        Me.SelectionRefTypUtilWithTousBindingSource.DataMember = "selectionRefTypUtilWithTous"
        Me.SelectionRefTypUtilWithTousBindingSource.DataSource = Me.SSDSDataSet1
        '
        'SSDSDataSet1
        '
        Me.SSDSDataSet1.DataSetName = "SSDSDataSet"
        Me.SSDSDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(34, 23)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Nom:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Prénom: "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(230, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Type:"
        '
        'TextBoxPrenom
        '
        Me.TextBoxPrenom.Location = New System.Drawing.Point(72, 46)
        Me.TextBoxPrenom.Name = "TextBoxPrenom"
        Me.TextBoxPrenom.Size = New System.Drawing.Size(128, 20)
        Me.TextBoxPrenom.TabIndex = 2
        '
        'TextBoxNom
        '
        Me.TextBoxNom.Location = New System.Drawing.Point(72, 20)
        Me.TextBoxNom.Name = "TextBoxNom"
        Me.TextBoxNom.Size = New System.Drawing.Size(128, 20)
        Me.TextBoxNom.TabIndex = 1
        '
        'SSDSDataSet
        '
        Me.SSDSDataSet.DataSetName = "SSDSDataSet"
        Me.SSDSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.CheckBoxDetailActif)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.DateCreation)
        Me.GroupBox2.Controls.Add(Me.DerniereModification)
        Me.GroupBox2.Controls.Add(Me.ComboBoxDetailType)
        Me.GroupBox2.Controls.Add(Me.Button7)
        Me.GroupBox2.Controls.Add(Me.Button6)
        Me.GroupBox2.Controls.Add(Me.TextBoxDetailNom)
        Me.GroupBox2.Controls.Add(Me.TextBoxDetailPrenom)
        Me.GroupBox2.Controls.Add(Me.TextBoxDetailCouriel)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 289)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(611, 133)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Détails"
        '
        'CheckBoxDetailActif
        '
        Me.CheckBoxDetailActif.AutoSize = True
        Me.CheckBoxDetailActif.Location = New System.Drawing.Point(335, 54)
        Me.CheckBoxDetailActif.Name = "CheckBoxDetailActif"
        Me.CheckBoxDetailActif.Size = New System.Drawing.Size(47, 17)
        Me.CheckBoxDetailActif.TabIndex = 24
        Me.CheckBoxDetailActif.Text = "Actif"
        Me.CheckBoxDetailActif.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(34, 24)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(32, 13)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "Nom:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(17, 48)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(49, 13)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "Prénom: "
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(24, 74)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(42, 13)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Couriel:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(332, 21)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(34, 13)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Type:"
        '
        'DateCreation
        '
        Me.DateCreation.AutoSize = True
        Me.DateCreation.Location = New System.Drawing.Point(69, 105)
        Me.DateCreation.Name = "DateCreation"
        Me.DateCreation.Size = New System.Drawing.Size(89, 13)
        Me.DateCreation.TabIndex = 17
        Me.DateCreation.Text = "Date de création:"
        '
        'DerniereModification
        '
        Me.DerniereModification.AutoSize = True
        Me.DerniereModification.Location = New System.Drawing.Point(332, 105)
        Me.DerniereModification.Name = "DerniereModification"
        Me.DerniereModification.Size = New System.Drawing.Size(109, 13)
        Me.DerniereModification.TabIndex = 16
        Me.DerniereModification.Text = "Dernière modification:"
        '
        'ComboBoxDetailType
        '
        Me.ComboBoxDetailType.DataSource = Me.REFTypeUtilisateurBindingSource
        Me.ComboBoxDetailType.DisplayMember = "nomTYPUTILl"
        Me.ComboBoxDetailType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxDetailType.FormattingEnabled = True
        Me.ComboBoxDetailType.Location = New System.Drawing.Point(372, 18)
        Me.ComboBoxDetailType.Name = "ComboBoxDetailType"
        Me.ComboBoxDetailType.Size = New System.Drawing.Size(121, 21)
        Me.ComboBoxDetailType.TabIndex = 23
        Me.ComboBoxDetailType.ValueMember = "noTYPUTIL"
        '
        'REFTypeUtilisateurBindingSource
        '
        Me.REFTypeUtilisateurBindingSource.DataMember = "REF_TypeUtilisateur"
        Me.REFTypeUtilisateurBindingSource.DataSource = Me.SSDSDataSet2
        '
        'SSDSDataSet2
        '
        Me.SSDSDataSet2.DataSetName = "SSDSDataSet"
        Me.SSDSDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(499, 19)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(101, 23)
        Me.Button7.TabIndex = 25
        Me.Button7.Text = "Sauvegarder"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(499, 48)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(101, 23)
        Me.Button6.TabIndex = 26
        Me.Button6.Text = "Annuler"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'TextBoxDetailNom
        '
        Me.TextBoxDetailNom.Location = New System.Drawing.Point(72, 19)
        Me.TextBoxDetailNom.Name = "TextBoxDetailNom"
        Me.TextBoxDetailNom.Size = New System.Drawing.Size(231, 20)
        Me.TextBoxDetailNom.TabIndex = 20
        '
        'TextBoxDetailPrenom
        '
        Me.TextBoxDetailPrenom.Location = New System.Drawing.Point(72, 45)
        Me.TextBoxDetailPrenom.Name = "TextBoxDetailPrenom"
        Me.TextBoxDetailPrenom.Size = New System.Drawing.Size(231, 20)
        Me.TextBoxDetailPrenom.TabIndex = 21
        '
        'TextBoxDetailCouriel
        '
        Me.TextBoxDetailCouriel.Location = New System.Drawing.Point(72, 71)
        Me.TextBoxDetailCouriel.Name = "TextBoxDetailCouriel"
        Me.TextBoxDetailCouriel.Size = New System.Drawing.Size(231, 20)
        Me.TextBoxDetailCouriel.TabIndex = 22
        '
        'REFTypeUtilisateurBindingSource1
        '
        Me.REFTypeUtilisateurBindingSource1.DataMember = "REF_TypeUtilisateur"
        Me.REFTypeUtilisateurBindingSource1.DataSource = Me.SSDSDataSet
        '
        'gbResultats
        '
        Me.gbResultats.Controls.Add(Me.Button5)
        Me.gbResultats.Controls.Add(Me.Button4)
        Me.gbResultats.Controls.Add(Me.Button3)
        Me.gbResultats.Controls.Add(Me.dgvEtudiants)
        Me.gbResultats.Location = New System.Drawing.Point(12, 98)
        Me.gbResultats.Name = "gbResultats"
        Me.gbResultats.Size = New System.Drawing.Size(611, 168)
        Me.gbResultats.TabIndex = 1
        Me.gbResultats.TabStop = False
        Me.gbResultats.Text = "Résultats"
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(499, 19)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(101, 23)
        Me.Button5.TabIndex = 13
        Me.Button5.Text = "Ajouter"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(499, 48)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(101, 23)
        Me.Button4.TabIndex = 12
        Me.Button4.Text = "Modifier"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(499, 77)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(101, 23)
        Me.Button3.TabIndex = 11
        Me.Button3.Text = "Supprimer"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'dgvEtudiants
        '
        Me.dgvEtudiants.AllowUserToAddRows = False
        Me.dgvEtudiants.AllowUserToDeleteRows = False
        Me.dgvEtudiants.AllowUserToOrderColumns = True
        Me.dgvEtudiants.AutoGenerateColumns = False
        Me.dgvEtudiants.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEtudiants.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NoUTILDataGridViewTextBoxColumn, Me.NomPrenomDataGridViewTextBoxColumn, Me.NomTYPUTILlDataGridViewTextBoxColumn, Me.EstActifDataGridViewCheckBoxColumn, Me.DateCreationDataGridViewTextBoxColumn})
        Me.dgvEtudiants.DataSource = Me.ListerUserByAllNPAWithTypeBindingSource
        Me.dgvEtudiants.Location = New System.Drawing.Point(6, 19)
        Me.dgvEtudiants.Name = "dgvEtudiants"
        Me.dgvEtudiants.ReadOnly = True
        Me.dgvEtudiants.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvEtudiants.Size = New System.Drawing.Size(487, 143)
        Me.dgvEtudiants.TabIndex = 0
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
        'NomTYPUTILlDataGridViewTextBoxColumn
        '
        Me.NomTYPUTILlDataGridViewTextBoxColumn.DataPropertyName = "nomTYPUTILl"
        Me.NomTYPUTILlDataGridViewTextBoxColumn.HeaderText = "nomTYPUTILl"
        Me.NomTYPUTILlDataGridViewTextBoxColumn.Name = "NomTYPUTILlDataGridViewTextBoxColumn"
        Me.NomTYPUTILlDataGridViewTextBoxColumn.ReadOnly = True
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
        'ListerUserByAllNPAWithTypeBindingSource
        '
        Me.ListerUserByAllNPAWithTypeBindingSource.DataMember = "ListerUserByAllNPAWithType"
        Me.ListerUserByAllNPAWithTypeBindingSource.DataSource = Me.SSDSDataSet
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(511, 436)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(101, 23)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "Fermer"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'ListerUserByAllNPAWithTypeTableAdapter
        '
        Me.ListerUserByAllNPAWithTypeTableAdapter.ClearBeforeFill = True
        '
        'SelectionRefTypUtilWithTousTableAdapter
        '
        Me.SelectionRefTypUtilWithTousTableAdapter.ClearBeforeFill = True
        '
        'REF_TypeUtilisateurTableAdapter
        '
        Me.REF_TypeUtilisateurTableAdapter.ClearBeforeFill = True
        '
        'GestionDesUtilisateurs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(639, 471)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.gbResultats)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button2)
        Me.Name = "GestionDesUtilisateurs"
        Me.Text = "Gestion des utilisateurs"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.SelectionRefTypUtilWithTousBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SSDSDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SSDSDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.REFTypeUtilisateurBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SSDSDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.REFTypeUtilisateurBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbResultats.ResumeLayout(False)
        CType(Me.dgvEtudiants, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListerUserByAllNPAWithTypeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Rechercher As System.Windows.Forms.Button
    Friend WithEvents Inactifs As System.Windows.Forms.RadioButton
    Friend WithEvents Tous As System.Windows.Forms.RadioButton
    Friend WithEvents Actifs As System.Windows.Forms.RadioButton
    Friend WithEvents Type As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBoxPrenom As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxNom As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents gbResultats As System.Windows.Forms.GroupBox
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents dgvEtudiants As System.Windows.Forms.DataGridView
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents CheckBoxDetailActif As System.Windows.Forms.CheckBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents DateCreation As System.Windows.Forms.Label
    Friend WithEvents DerniereModification As System.Windows.Forms.Label
    Friend WithEvents ComboBoxDetailType As System.Windows.Forms.ComboBox
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents TextBoxDetailNom As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxDetailPrenom As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxDetailCouriel As System.Windows.Forms.TextBox
    Friend WithEvents SSDSDataSet As SSDS.SSDSDataSet
    Friend WithEvents NoUTILDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NomPrenomDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NomTYPUTILlDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EstActifDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DateCreationDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ListerUserByAllNPAWithTypeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ListerUserByAllNPAWithTypeTableAdapter As SSDS.SSDSDataSetTableAdapters.ListerUserByAllNPAWithTypeTableAdapter
    Friend WithEvents REFTypeUtilisateurBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents SSDSDataSet1 As SSDS.SSDSDataSet
    Friend WithEvents SelectionRefTypUtilWithTousBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SelectionRefTypUtilWithTousTableAdapter As SSDS.SSDSDataSetTableAdapters.selectionRefTypUtilWithTousTableAdapter
    Friend WithEvents SSDSDataSet2 As SSDS.SSDSDataSet
    Friend WithEvents REFTypeUtilisateurBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents REF_TypeUtilisateurTableAdapter As SSDS.SSDSDataSetTableAdapters.REF_TypeUtilisateurTableAdapter
End Class
