<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GestionDesDemarches
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
        Me.GroupBoxEntreprises = New System.Windows.Forms.GroupBox()
        Me.dgvEntreprises = New System.Windows.Forms.DataGridView()
        Me.NoENTDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NomENTDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VilleENTDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StatutDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateCreationDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SelectionEntrepriseBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SSDSDataSet = New SSDS.SSDSDataSet()
        Me.BoutonSupprimer = New System.Windows.Forms.Button()
        Me.BoutonModifier = New System.Windows.Forms.Button()
        Me.BoutonAjouter = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.BoutonDetailContacts = New System.Windows.Forms.Button()
        Me.BoutonDetailAnnuler = New System.Windows.Forms.Button()
        Me.BoutonDetailSauvegarder = New System.Windows.Forms.Button()
        Me.txtDateCreationEntreprise = New System.Windows.Forms.Label()
        Me.txtDateModificationEntreprise = New System.Windows.Forms.Label()
        Me.ComboBoxDetailStatutEntreprise = New System.Windows.Forms.ComboBox()
        Me.SelectionStatutENTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxDetailDescriptionEntreprise = New System.Windows.Forms.RichTextBox()
        Me.TextBoxDetailCourielEntreprise = New System.Windows.Forms.TextBox()
        Me.TextBoxDetailTelephoneEntreprise = New System.Windows.Forms.TextBox()
        Me.TextBoxDetailAdresseEntreprise = New System.Windows.Forms.TextBox()
        Me.TextBoxDetailVilleEntreprise = New System.Windows.Forms.TextBox()
        Me.TextBoxDetailCodePEntreprise = New System.Windows.Forms.TextBox()
        Me.TextBoxDetailNomEntreprise = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.dgvDemarches = New System.Windows.Forms.DataGridView()
        Me.NoDEMDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateDEMDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NomTYPDEMDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NomCONDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NoteDEMDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SelectionDemarchesByIdBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.DateCreationDem = New System.Windows.Forms.Label()
        Me.DerniereModificationDem = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.DescriptionDem = New System.Windows.Forms.RichTextBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TypeDem = New System.Windows.Forms.ComboBox()
        Me.SelectionTypeDEMBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SSDSDataSet1 = New SSDS.SSDSDataSet()
        Me.ContactDem = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.DateDem = New System.Windows.Forms.DateTimePicker()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.SelectionEntrepriseTableAdapter = New SSDS.SSDSDataSetTableAdapters.SelectionEntrepriseTableAdapter()
        Me.SelectionDemarchesByIdTableAdapter = New SSDS.SSDSDataSetTableAdapters.SelectionDemarchesByIdTableAdapter()
        Me.SelectionStatutENTTableAdapter = New SSDS.SSDSDataSetTableAdapters.SelectionStatutENTTableAdapter()
        Me.SelectionTypeDEMTableAdapter = New SSDS.SSDSDataSetTableAdapters.SelectionTypeDEMTableAdapter()
        Me.SelectionContactBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SelectionContactTableAdapter = New SSDS.SSDSDataSetTableAdapters.SelectionContactTableAdapter()
        Me.GroupBoxEntreprises.SuspendLayout()
        CType(Me.dgvEntreprises, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SelectionEntrepriseBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SSDSDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SelectionStatutENTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvDemarches, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SelectionDemarchesByIdBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.SelectionTypeDEMBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SSDSDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SelectionContactBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBoxEntreprises
        '
        Me.GroupBoxEntreprises.Controls.Add(Me.dgvEntreprises)
        Me.GroupBoxEntreprises.Controls.Add(Me.BoutonSupprimer)
        Me.GroupBoxEntreprises.Controls.Add(Me.BoutonModifier)
        Me.GroupBoxEntreprises.Controls.Add(Me.BoutonAjouter)
        Me.GroupBoxEntreprises.Location = New System.Drawing.Point(12, 12)
        Me.GroupBoxEntreprises.Name = "GroupBoxEntreprises"
        Me.GroupBoxEntreprises.Size = New System.Drawing.Size(675, 120)
        Me.GroupBoxEntreprises.TabIndex = 0
        Me.GroupBoxEntreprises.TabStop = False
        Me.GroupBoxEntreprises.Text = "Entreprises"
        '
        'dgvEntreprises
        '
        Me.dgvEntreprises.AllowUserToAddRows = False
        Me.dgvEntreprises.AllowUserToDeleteRows = False
        Me.dgvEntreprises.AllowUserToResizeColumns = False
        Me.dgvEntreprises.AllowUserToResizeRows = False
        Me.dgvEntreprises.AutoGenerateColumns = False
        Me.dgvEntreprises.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEntreprises.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NoENTDataGridViewTextBoxColumn, Me.NomENTDataGridViewTextBoxColumn, Me.VilleENTDataGridViewTextBoxColumn, Me.StatutDataGridViewTextBoxColumn, Me.DateCreationDataGridViewTextBoxColumn})
        Me.dgvEntreprises.DataSource = Me.SelectionEntrepriseBindingSource
        Me.dgvEntreprises.Location = New System.Drawing.Point(6, 19)
        Me.dgvEntreprises.MultiSelect = False
        Me.dgvEntreprises.Name = "dgvEntreprises"
        Me.dgvEntreprises.ReadOnly = True
        Me.dgvEntreprises.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvEntreprises.ShowCellErrors = False
        Me.dgvEntreprises.Size = New System.Drawing.Size(535, 95)
        Me.dgvEntreprises.TabIndex = 4
        '
        'NoENTDataGridViewTextBoxColumn
        '
        Me.NoENTDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.NoENTDataGridViewTextBoxColumn.DataPropertyName = "noENT"
        Me.NoENTDataGridViewTextBoxColumn.HeaderText = "noENT"
        Me.NoENTDataGridViewTextBoxColumn.Name = "NoENTDataGridViewTextBoxColumn"
        Me.NoENTDataGridViewTextBoxColumn.ReadOnly = True
        Me.NoENTDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.NoENTDataGridViewTextBoxColumn.Visible = False
        '
        'NomENTDataGridViewTextBoxColumn
        '
        Me.NomENTDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NomENTDataGridViewTextBoxColumn.DataPropertyName = "nomENT"
        Me.NomENTDataGridViewTextBoxColumn.HeaderText = "Nom"
        Me.NomENTDataGridViewTextBoxColumn.Name = "NomENTDataGridViewTextBoxColumn"
        Me.NomENTDataGridViewTextBoxColumn.ReadOnly = True
        Me.NomENTDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.NomENTDataGridViewTextBoxColumn.Width = 54
        '
        'VilleENTDataGridViewTextBoxColumn
        '
        Me.VilleENTDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.VilleENTDataGridViewTextBoxColumn.DataPropertyName = "villeENT"
        Me.VilleENTDataGridViewTextBoxColumn.HeaderText = "Ville"
        Me.VilleENTDataGridViewTextBoxColumn.Name = "VilleENTDataGridViewTextBoxColumn"
        Me.VilleENTDataGridViewTextBoxColumn.ReadOnly = True
        Me.VilleENTDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.VilleENTDataGridViewTextBoxColumn.Width = 51
        '
        'StatutDataGridViewTextBoxColumn
        '
        Me.StatutDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.StatutDataGridViewTextBoxColumn.DataPropertyName = "Statut"
        Me.StatutDataGridViewTextBoxColumn.HeaderText = "Statut"
        Me.StatutDataGridViewTextBoxColumn.Name = "StatutDataGridViewTextBoxColumn"
        Me.StatutDataGridViewTextBoxColumn.ReadOnly = True
        Me.StatutDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.StatutDataGridViewTextBoxColumn.Width = 60
        '
        'DateCreationDataGridViewTextBoxColumn
        '
        Me.DateCreationDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DateCreationDataGridViewTextBoxColumn.DataPropertyName = "dateCreation"
        Me.DateCreationDataGridViewTextBoxColumn.HeaderText = "dateCreation"
        Me.DateCreationDataGridViewTextBoxColumn.Name = "DateCreationDataGridViewTextBoxColumn"
        Me.DateCreationDataGridViewTextBoxColumn.ReadOnly = True
        Me.DateCreationDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DateCreationDataGridViewTextBoxColumn.Width = 92
        '
        'SelectionEntrepriseBindingSource
        '
        Me.SelectionEntrepriseBindingSource.DataMember = "SelectionEntreprise"
        Me.SelectionEntrepriseBindingSource.DataSource = Me.SSDSDataSet
        '
        'SSDSDataSet
        '
        Me.SSDSDataSet.DataSetName = "SSDSDataSet"
        Me.SSDSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BoutonSupprimer
        '
        Me.BoutonSupprimer.Location = New System.Drawing.Point(568, 77)
        Me.BoutonSupprimer.Name = "BoutonSupprimer"
        Me.BoutonSupprimer.Size = New System.Drawing.Size(85, 23)
        Me.BoutonSupprimer.TabIndex = 3
        Me.BoutonSupprimer.Text = "Supprimer"
        Me.BoutonSupprimer.UseVisualStyleBackColor = True
        '
        'BoutonModifier
        '
        Me.BoutonModifier.Location = New System.Drawing.Point(568, 48)
        Me.BoutonModifier.Name = "BoutonModifier"
        Me.BoutonModifier.Size = New System.Drawing.Size(85, 23)
        Me.BoutonModifier.TabIndex = 2
        Me.BoutonModifier.Text = "Modifier"
        Me.BoutonModifier.UseVisualStyleBackColor = True
        '
        'BoutonAjouter
        '
        Me.BoutonAjouter.Location = New System.Drawing.Point(568, 19)
        Me.BoutonAjouter.Name = "BoutonAjouter"
        Me.BoutonAjouter.Size = New System.Drawing.Size(85, 23)
        Me.BoutonAjouter.TabIndex = 1
        Me.BoutonAjouter.Text = "Ajouter"
        Me.BoutonAjouter.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DataGridView2)
        Me.GroupBox1.Controls.Add(Me.BoutonDetailContacts)
        Me.GroupBox1.Controls.Add(Me.BoutonDetailAnnuler)
        Me.GroupBox1.Controls.Add(Me.BoutonDetailSauvegarder)
        Me.GroupBox1.Controls.Add(Me.txtDateCreationEntreprise)
        Me.GroupBox1.Controls.Add(Me.txtDateModificationEntreprise)
        Me.GroupBox1.Controls.Add(Me.ComboBoxDetailStatutEntreprise)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TextBoxDetailDescriptionEntreprise)
        Me.GroupBox1.Controls.Add(Me.TextBoxDetailCourielEntreprise)
        Me.GroupBox1.Controls.Add(Me.TextBoxDetailTelephoneEntreprise)
        Me.GroupBox1.Controls.Add(Me.TextBoxDetailAdresseEntreprise)
        Me.GroupBox1.Controls.Add(Me.TextBoxDetailVilleEntreprise)
        Me.GroupBox1.Controls.Add(Me.TextBoxDetailCodePEntreprise)
        Me.GroupBox1.Controls.Add(Me.TextBoxDetailNomEntreprise)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 138)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(675, 202)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Détail de l'entreprise"
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(9, -98)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        Me.DataGridView2.Size = New System.Drawing.Size(529, 92)
        Me.DataGridView2.TabIndex = 4
        '
        'BoutonDetailContacts
        '
        Me.BoutonDetailContacts.Location = New System.Drawing.Point(568, 142)
        Me.BoutonDetailContacts.Name = "BoutonDetailContacts"
        Me.BoutonDetailContacts.Size = New System.Drawing.Size(85, 23)
        Me.BoutonDetailContacts.TabIndex = 21
        Me.BoutonDetailContacts.Text = "Contacts"
        Me.BoutonDetailContacts.UseVisualStyleBackColor = True
        '
        'BoutonDetailAnnuler
        '
        Me.BoutonDetailAnnuler.Location = New System.Drawing.Point(568, 46)
        Me.BoutonDetailAnnuler.Name = "BoutonDetailAnnuler"
        Me.BoutonDetailAnnuler.Size = New System.Drawing.Size(85, 23)
        Me.BoutonDetailAnnuler.TabIndex = 20
        Me.BoutonDetailAnnuler.Text = "Annuler"
        Me.BoutonDetailAnnuler.UseVisualStyleBackColor = True
        '
        'BoutonDetailSauvegarder
        '
        Me.BoutonDetailSauvegarder.Location = New System.Drawing.Point(568, 17)
        Me.BoutonDetailSauvegarder.Name = "BoutonDetailSauvegarder"
        Me.BoutonDetailSauvegarder.Size = New System.Drawing.Size(85, 23)
        Me.BoutonDetailSauvegarder.TabIndex = 19
        Me.BoutonDetailSauvegarder.Text = "Sauvegarder"
        Me.BoutonDetailSauvegarder.UseVisualStyleBackColor = True
        '
        'txtDateCreationEntreprise
        '
        Me.txtDateCreationEntreprise.AutoSize = True
        Me.txtDateCreationEntreprise.Location = New System.Drawing.Point(88, 180)
        Me.txtDateCreationEntreprise.Name = "txtDateCreationEntreprise"
        Me.txtDateCreationEntreprise.Size = New System.Drawing.Size(89, 13)
        Me.txtDateCreationEntreprise.TabIndex = 18
        Me.txtDateCreationEntreprise.Text = "Date de creation:"
        '
        'txtDateModificationEntreprise
        '
        Me.txtDateModificationEntreprise.AutoSize = True
        Me.txtDateModificationEntreprise.Location = New System.Drawing.Point(428, 180)
        Me.txtDateModificationEntreprise.Name = "txtDateModificationEntreprise"
        Me.txtDateModificationEntreprise.Size = New System.Drawing.Size(110, 13)
        Me.txtDateModificationEntreprise.TabIndex = 17
        Me.txtDateModificationEntreprise.Text = "Dernière Modification:"
        '
        'ComboBoxDetailStatutEntreprise
        '
        Me.ComboBoxDetailStatutEntreprise.DataSource = Me.SelectionStatutENTBindingSource
        Me.ComboBoxDetailStatutEntreprise.DisplayMember = "nomSTAENT"
        Me.ComboBoxDetailStatutEntreprise.FormattingEnabled = True
        Me.ComboBoxDetailStatutEntreprise.Location = New System.Drawing.Point(419, 19)
        Me.ComboBoxDetailStatutEntreprise.Name = "ComboBoxDetailStatutEntreprise"
        Me.ComboBoxDetailStatutEntreprise.Size = New System.Drawing.Size(121, 21)
        Me.ComboBoxDetailStatutEntreprise.TabIndex = 16
        Me.ComboBoxDetailStatutEntreprise.ValueMember = "noSTAENT"
        '
        'SelectionStatutENTBindingSource
        '
        Me.SelectionStatutENTBindingSource.DataMember = "SelectionStatutENT"
        Me.SelectionStatutENTBindingSource.DataSource = Me.SSDSDataSet
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(40, 48)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(48, 13)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "Adresse:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(59, 78)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(29, 13)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Ville:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(21, 100)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(67, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Code Postal:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(352, 48)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Telephone:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(371, 74)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Couriel:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(25, 126)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Description:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(375, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Statut:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(56, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Nom:"
        '
        'TextBoxDetailDescriptionEntreprise
        '
        Me.TextBoxDetailDescriptionEntreprise.Location = New System.Drawing.Point(90, 123)
        Me.TextBoxDetailDescriptionEntreprise.Name = "TextBoxDetailDescriptionEntreprise"
        Me.TextBoxDetailDescriptionEntreprise.Size = New System.Drawing.Size(448, 42)
        Me.TextBoxDetailDescriptionEntreprise.TabIndex = 2
        Me.TextBoxDetailDescriptionEntreprise.Text = ""
        '
        'TextBoxDetailCourielEntreprise
        '
        Me.TextBoxDetailCourielEntreprise.Location = New System.Drawing.Point(419, 71)
        Me.TextBoxDetailCourielEntreprise.Name = "TextBoxDetailCourielEntreprise"
        Me.TextBoxDetailCourielEntreprise.Size = New System.Drawing.Size(119, 20)
        Me.TextBoxDetailCourielEntreprise.TabIndex = 6
        '
        'TextBoxDetailTelephoneEntreprise
        '
        Me.TextBoxDetailTelephoneEntreprise.Location = New System.Drawing.Point(419, 45)
        Me.TextBoxDetailTelephoneEntreprise.Name = "TextBoxDetailTelephoneEntreprise"
        Me.TextBoxDetailTelephoneEntreprise.Size = New System.Drawing.Size(119, 20)
        Me.TextBoxDetailTelephoneEntreprise.TabIndex = 5
        '
        'TextBoxDetailAdresseEntreprise
        '
        Me.TextBoxDetailAdresseEntreprise.Location = New System.Drawing.Point(91, 45)
        Me.TextBoxDetailAdresseEntreprise.Name = "TextBoxDetailAdresseEntreprise"
        Me.TextBoxDetailAdresseEntreprise.Size = New System.Drawing.Size(255, 20)
        Me.TextBoxDetailAdresseEntreprise.TabIndex = 4
        '
        'TextBoxDetailVilleEntreprise
        '
        Me.TextBoxDetailVilleEntreprise.Location = New System.Drawing.Point(91, 71)
        Me.TextBoxDetailVilleEntreprise.Name = "TextBoxDetailVilleEntreprise"
        Me.TextBoxDetailVilleEntreprise.Size = New System.Drawing.Size(255, 20)
        Me.TextBoxDetailVilleEntreprise.TabIndex = 3
        '
        'TextBoxDetailCodePEntreprise
        '
        Me.TextBoxDetailCodePEntreprise.Location = New System.Drawing.Point(91, 97)
        Me.TextBoxDetailCodePEntreprise.Name = "TextBoxDetailCodePEntreprise"
        Me.TextBoxDetailCodePEntreprise.Size = New System.Drawing.Size(255, 20)
        Me.TextBoxDetailCodePEntreprise.TabIndex = 2
        '
        'TextBoxDetailNomEntreprise
        '
        Me.TextBoxDetailNomEntreprise.Location = New System.Drawing.Point(91, 19)
        Me.TextBoxDetailNomEntreprise.Name = "TextBoxDetailNomEntreprise"
        Me.TextBoxDetailNomEntreprise.Size = New System.Drawing.Size(255, 20)
        Me.TextBoxDetailNomEntreprise.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Controls.Add(Me.Button3)
        Me.GroupBox2.Controls.Add(Me.dgvDemarches)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 346)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(675, 132)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Démarches"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(568, 84)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(85, 23)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Supprimer"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(568, 55)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(85, 23)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Modifier"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(568, 26)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(85, 23)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "Ajouter"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'dgvDemarches
        '
        Me.dgvDemarches.AllowUserToAddRows = False
        Me.dgvDemarches.AllowUserToDeleteRows = False
        Me.dgvDemarches.AutoGenerateColumns = False
        Me.dgvDemarches.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDemarches.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NoDEMDataGridViewTextBoxColumn, Me.DateDEMDataGridViewTextBoxColumn, Me.NomTYPDEMDataGridViewTextBoxColumn, Me.NomCONDataGridViewTextBoxColumn, Me.NoteDEMDataGridViewTextBoxColumn})
        Me.dgvDemarches.DataSource = Me.SelectionDemarchesByIdBindingSource
        Me.dgvDemarches.Location = New System.Drawing.Point(6, 27)
        Me.dgvDemarches.Name = "dgvDemarches"
        Me.dgvDemarches.ReadOnly = True
        Me.dgvDemarches.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDemarches.Size = New System.Drawing.Size(535, 80)
        Me.dgvDemarches.TabIndex = 0
        '
        'NoDEMDataGridViewTextBoxColumn
        '
        Me.NoDEMDataGridViewTextBoxColumn.DataPropertyName = "noDEM"
        Me.NoDEMDataGridViewTextBoxColumn.HeaderText = "noDEM"
        Me.NoDEMDataGridViewTextBoxColumn.Name = "NoDEMDataGridViewTextBoxColumn"
        Me.NoDEMDataGridViewTextBoxColumn.ReadOnly = True
        Me.NoDEMDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.NoDEMDataGridViewTextBoxColumn.Visible = False
        '
        'DateDEMDataGridViewTextBoxColumn
        '
        Me.DateDEMDataGridViewTextBoxColumn.DataPropertyName = "dateDEM"
        Me.DateDEMDataGridViewTextBoxColumn.HeaderText = "dateDEM"
        Me.DateDEMDataGridViewTextBoxColumn.Name = "DateDEMDataGridViewTextBoxColumn"
        Me.DateDEMDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NomTYPDEMDataGridViewTextBoxColumn
        '
        Me.NomTYPDEMDataGridViewTextBoxColumn.DataPropertyName = "nomTYPDEM"
        Me.NomTYPDEMDataGridViewTextBoxColumn.HeaderText = "nomTYPDEM"
        Me.NomTYPDEMDataGridViewTextBoxColumn.Name = "NomTYPDEMDataGridViewTextBoxColumn"
        Me.NomTYPDEMDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NomCONDataGridViewTextBoxColumn
        '
        Me.NomCONDataGridViewTextBoxColumn.DataPropertyName = "nomCON"
        Me.NomCONDataGridViewTextBoxColumn.HeaderText = "nomCON"
        Me.NomCONDataGridViewTextBoxColumn.Name = "NomCONDataGridViewTextBoxColumn"
        Me.NomCONDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NoteDEMDataGridViewTextBoxColumn
        '
        Me.NoteDEMDataGridViewTextBoxColumn.DataPropertyName = "noteDEM"
        Me.NoteDEMDataGridViewTextBoxColumn.HeaderText = "noteDEM"
        Me.NoteDEMDataGridViewTextBoxColumn.Name = "NoteDEMDataGridViewTextBoxColumn"
        Me.NoteDEMDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SelectionDemarchesByIdBindingSource
        '
        Me.SelectionDemarchesByIdBindingSource.DataMember = "SelectionDemarchesById"
        Me.SelectionDemarchesByIdBindingSource.DataSource = Me.SSDSDataSet
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.DateCreationDem)
        Me.GroupBox3.Controls.Add(Me.DerniereModificationDem)
        Me.GroupBox3.Controls.Add(Me.Label16)
        Me.GroupBox3.Controls.Add(Me.DescriptionDem)
        Me.GroupBox3.Controls.Add(Me.Button4)
        Me.GroupBox3.Controls.Add(Me.Button5)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.TypeDem)
        Me.GroupBox3.Controls.Add(Me.ContactDem)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.DateDem)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 484)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(675, 149)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Détail de la demarche"
        '
        'DateCreationDem
        '
        Me.DateCreationDem.AutoSize = True
        Me.DateCreationDem.Location = New System.Drawing.Point(3, 130)
        Me.DateCreationDem.Name = "DateCreationDem"
        Me.DateCreationDem.Size = New System.Drawing.Size(89, 13)
        Me.DateCreationDem.TabIndex = 26
        Me.DateCreationDem.Text = "Date de creation:"
        '
        'DerniereModificationDem
        '
        Me.DerniereModificationDem.AutoSize = True
        Me.DerniereModificationDem.Location = New System.Drawing.Point(428, 130)
        Me.DerniereModificationDem.Name = "DerniereModificationDem"
        Me.DerniereModificationDem.Size = New System.Drawing.Size(110, 13)
        Me.DerniereModificationDem.TabIndex = 25
        Me.DerniereModificationDem.Text = "Dernière Modification:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(6, 69)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(63, 13)
        Me.Label16.TabIndex = 24
        Me.Label16.Text = "Description:"
        '
        'DescriptionDem
        '
        Me.DescriptionDem.Location = New System.Drawing.Point(6, 85)
        Me.DescriptionDem.Name = "DescriptionDem"
        Me.DescriptionDem.Size = New System.Drawing.Size(534, 42)
        Me.DescriptionDem.TabIndex = 23
        Me.DescriptionDem.Text = ""
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(568, 47)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(85, 23)
        Me.Button4.TabIndex = 22
        Me.Button4.Text = "Annuler"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(568, 18)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(85, 23)
        Me.Button5.TabIndex = 21
        Me.Button5.Text = "Sauvegarder"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(292, 52)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(34, 13)
        Me.Label13.TabIndex = 5
        Me.Label13.Text = "Type:"
        '
        'TypeDem
        '
        Me.TypeDem.DataSource = Me.SelectionTypeDEMBindingSource
        Me.TypeDem.DisplayMember = "nomTYPDEM"
        Me.TypeDem.FormattingEnabled = True
        Me.TypeDem.Location = New System.Drawing.Point(343, 49)
        Me.TypeDem.Name = "TypeDem"
        Me.TypeDem.Size = New System.Drawing.Size(121, 21)
        Me.TypeDem.TabIndex = 4
        Me.TypeDem.ValueMember = "noTYPDEM"
        '
        'SelectionTypeDEMBindingSource
        '
        Me.SelectionTypeDEMBindingSource.DataMember = "SelectionTypeDEM"
        Me.SelectionTypeDEMBindingSource.DataSource = Me.SSDSDataSet1
        '
        'SSDSDataSet1
        '
        Me.SSDSDataSet1.DataSetName = "SSDSDataSet"
        Me.SSDSDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ContactDem
        '
        Me.ContactDem.DataSource = Me.SelectionContactBindingSource
        Me.ContactDem.DisplayMember = "nomCON"
        Me.ContactDem.FormattingEnabled = True
        Me.ContactDem.Location = New System.Drawing.Point(343, 22)
        Me.ContactDem.Name = "ContactDem"
        Me.ContactDem.Size = New System.Drawing.Size(121, 21)
        Me.ContactDem.TabIndex = 3
        Me.ContactDem.ValueMember = "noCON"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(290, 28)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(47, 13)
        Me.Label12.TabIndex = 2
        Me.Label12.Text = "Contact:"
        '
        'DateDem
        '
        Me.DateDem.Location = New System.Drawing.Point(43, 22)
        Me.DateDem.Name = "DateDem"
        Me.DateDem.Size = New System.Drawing.Size(200, 20)
        Me.DateDem.TabIndex = 1
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(4, 28)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(33, 13)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Date:"
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(612, 639)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(75, 23)
        Me.Button6.TabIndex = 4
        Me.Button6.Text = "Fermer"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'SelectionEntrepriseTableAdapter
        '
        Me.SelectionEntrepriseTableAdapter.ClearBeforeFill = True
        '
        'SelectionDemarchesByIdTableAdapter
        '
        Me.SelectionDemarchesByIdTableAdapter.ClearBeforeFill = True
        '
        'SelectionStatutENTTableAdapter
        '
        Me.SelectionStatutENTTableAdapter.ClearBeforeFill = True
        '
        'SelectionTypeDEMTableAdapter
        '
        Me.SelectionTypeDEMTableAdapter.ClearBeforeFill = True
        '
        'SelectionContactBindingSource
        '
        Me.SelectionContactBindingSource.DataMember = "SelectionContact"
        Me.SelectionContactBindingSource.DataSource = Me.SSDSDataSet
        '
        'SelectionContactTableAdapter
        '
        Me.SelectionContactTableAdapter.ClearBeforeFill = True
        '
        'GestionDesDemarches
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(699, 668)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBoxEntreprises)
        Me.Name = "GestionDesDemarches"
        Me.Text = "Gestion des démarches"
        Me.GroupBoxEntreprises.ResumeLayout(False)
        CType(Me.dgvEntreprises, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SelectionEntrepriseBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SSDSDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SelectionStatutENTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgvDemarches, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SelectionDemarchesByIdBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.SelectionTypeDEMBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SSDSDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SelectionContactBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBoxEntreprises As System.Windows.Forms.GroupBox
    Friend WithEvents BoutonAjouter As System.Windows.Forms.Button
    Friend WithEvents BoutonSupprimer As System.Windows.Forms.Button
    Friend WithEvents BoutonModifier As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ComboBoxDetailStatutEntreprise As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBoxDetailDescriptionEntreprise As System.Windows.Forms.RichTextBox
    Friend WithEvents TextBoxDetailCourielEntreprise As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxDetailTelephoneEntreprise As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxDetailAdresseEntreprise As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxDetailVilleEntreprise As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxDetailCodePEntreprise As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxDetailNomEntreprise As System.Windows.Forms.TextBox
    Friend WithEvents BoutonDetailContacts As System.Windows.Forms.Button
    Friend WithEvents BoutonDetailAnnuler As System.Windows.Forms.Button
    Friend WithEvents BoutonDetailSauvegarder As System.Windows.Forms.Button
    Friend WithEvents txtDateCreationEntreprise As System.Windows.Forms.Label
    Friend WithEvents txtDateModificationEntreprise As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents dgvDemarches As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents DateCreationDem As System.Windows.Forms.Label
    Friend WithEvents DerniereModificationDem As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents DescriptionDem As System.Windows.Forms.RichTextBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents TypeDem As System.Windows.Forms.ComboBox
    Friend WithEvents ContactDem As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents DateDem As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents dgvEntreprises As System.Windows.Forms.DataGridView
    Friend WithEvents SSDSDataSet As SSDS.SSDSDataSet
    Friend WithEvents SelectionEntrepriseBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SelectionEntrepriseTableAdapter As SSDS.SSDSDataSetTableAdapters.SelectionEntrepriseTableAdapter
    Friend WithEvents NoENTDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NomENTDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VilleENTDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StatutDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DateCreationDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NoDEMDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DateDEMDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NomTYPDEMDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NomCONDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NoteDEMDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SelectionDemarchesByIdBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SelectionDemarchesByIdTableAdapter As SSDS.SSDSDataSetTableAdapters.SelectionDemarchesByIdTableAdapter
    Friend WithEvents SelectionStatutENTBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SelectionStatutENTTableAdapter As SSDS.SSDSDataSetTableAdapters.SelectionStatutENTTableAdapter
    Friend WithEvents SSDSDataSet1 As SSDS.SSDSDataSet
    Friend WithEvents SelectionTypeDEMBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SelectionTypeDEMTableAdapter As SSDS.SSDSDataSetTableAdapters.SelectionTypeDEMTableAdapter
    Friend WithEvents SelectionContactBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SelectionContactTableAdapter As SSDS.SSDSDataSetTableAdapters.SelectionContactTableAdapter

End Class
