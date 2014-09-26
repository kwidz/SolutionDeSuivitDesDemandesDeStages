<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.NomENTDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VilleENTDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StatutDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateCreationDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SelectionEntrepriseBindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        Me.SSDSDataSet = New SSDS.SSDSDataSet()
        Me.BoutonSupprimer = New System.Windows.Forms.Button()
        Me.BoutonModifier = New System.Windows.Forms.Button()
        Me.BoutonAjouter = New System.Windows.Forms.Button()
        Me.SelectionEntrepriseBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.SelectionEntrepriseBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BoutonDetailContacts = New System.Windows.Forms.Button()
        Me.BoutonDetailAnnuler = New System.Windows.Forms.Button()
        Me.BoutonDetailSauvegarder = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ComboBoxDetailStatut = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxDetailDescription = New System.Windows.Forms.RichTextBox()
        Me.TextBoxDetailCouriel = New System.Windows.Forms.TextBox()
        Me.TextBoxDetailTelephone = New System.Windows.Forms.TextBox()
        Me.TextBoxDetailAdresse = New System.Windows.Forms.TextBox()
        Me.TextBoxDetailVille = New System.Windows.Forms.TextBox()
        Me.TextBoxDetailCodeP = New System.Windows.Forms.TextBox()
        Me.TextBoxDetailNom = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.SelectionEntreprisesBindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        Me.SelectionEntrepriseBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SelectionEntrepriseTableAdapter = New SSDS.SSDSDataSetTableAdapters.SelectionEntrepriseTableAdapter()
        Me.SelectionEntrepriseBindingSource4 = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBoxEntreprises.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SelectionEntrepriseBindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SSDSDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SelectionEntrepriseBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SelectionEntrepriseBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.SelectionEntreprisesBindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SelectionEntrepriseBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SelectionEntrepriseBindingSource4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBoxEntreprises
        '
        Me.GroupBoxEntreprises.Controls.Add(Me.DataGridView2)
        Me.GroupBoxEntreprises.Controls.Add(Me.BoutonSupprimer)
        Me.GroupBoxEntreprises.Controls.Add(Me.BoutonModifier)
        Me.GroupBoxEntreprises.Controls.Add(Me.BoutonAjouter)
        Me.GroupBoxEntreprises.Location = New System.Drawing.Point(12, 12)
        Me.GroupBoxEntreprises.Name = "GroupBoxEntreprises"
        Me.GroupBoxEntreprises.Size = New System.Drawing.Size(675, 111)
        Me.GroupBoxEntreprises.TabIndex = 0
        Me.GroupBoxEntreprises.TabStop = False
        Me.GroupBoxEntreprises.Text = "Entreprises"
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.AutoGenerateColumns = False
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NomENTDataGridViewTextBoxColumn, Me.VilleENTDataGridViewTextBoxColumn, Me.StatutDataGridViewTextBoxColumn, Me.DateCreationDataGridViewTextBoxColumn})
        Me.DataGridView2.DataSource = Me.SelectionEntrepriseBindingSource4
        Me.DataGridView2.Location = New System.Drawing.Point(6, 19)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        Me.DataGridView2.Size = New System.Drawing.Size(532, 81)
        Me.DataGridView2.TabIndex = 4
        '
        'NomENTDataGridViewTextBoxColumn
        '
        Me.NomENTDataGridViewTextBoxColumn.DataPropertyName = "nomENT"
        Me.NomENTDataGridViewTextBoxColumn.HeaderText = "nomENT"
        Me.NomENTDataGridViewTextBoxColumn.Name = "NomENTDataGridViewTextBoxColumn"
        Me.NomENTDataGridViewTextBoxColumn.ReadOnly = True
        '
        'VilleENTDataGridViewTextBoxColumn
        '
        Me.VilleENTDataGridViewTextBoxColumn.DataPropertyName = "villeENT"
        Me.VilleENTDataGridViewTextBoxColumn.HeaderText = "villeENT"
        Me.VilleENTDataGridViewTextBoxColumn.Name = "VilleENTDataGridViewTextBoxColumn"
        Me.VilleENTDataGridViewTextBoxColumn.ReadOnly = True
        '
        'StatutDataGridViewTextBoxColumn
        '
        Me.StatutDataGridViewTextBoxColumn.DataPropertyName = "Statut"
        Me.StatutDataGridViewTextBoxColumn.HeaderText = "Statut"
        Me.StatutDataGridViewTextBoxColumn.Name = "StatutDataGridViewTextBoxColumn"
        Me.StatutDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DateCreationDataGridViewTextBoxColumn
        '
        Me.DateCreationDataGridViewTextBoxColumn.DataPropertyName = "dateCreation"
        Me.DateCreationDataGridViewTextBoxColumn.HeaderText = "dateCreation"
        Me.DateCreationDataGridViewTextBoxColumn.Name = "DateCreationDataGridViewTextBoxColumn"
        Me.DateCreationDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SelectionEntrepriseBindingSource3
        '
        Me.SelectionEntrepriseBindingSource3.DataMember = "SelectionEntreprise"
        Me.SelectionEntrepriseBindingSource3.DataSource = Me.SSDSDataSet
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
        Me.GroupBox1.Controls.Add(Me.BoutonDetailContacts)
        Me.GroupBox1.Controls.Add(Me.BoutonDetailAnnuler)
        Me.GroupBox1.Controls.Add(Me.BoutonDetailSauvegarder)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.ComboBoxDetailStatut)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TextBoxDetailDescription)
        Me.GroupBox1.Controls.Add(Me.TextBoxDetailCouriel)
        Me.GroupBox1.Controls.Add(Me.TextBoxDetailTelephone)
        Me.GroupBox1.Controls.Add(Me.TextBoxDetailAdresse)
        Me.GroupBox1.Controls.Add(Me.TextBoxDetailVille)
        Me.GroupBox1.Controls.Add(Me.TextBoxDetailCodeP)
        Me.GroupBox1.Controls.Add(Me.TextBoxDetailNom)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 129)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(675, 255)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Détail de l'entreprise"
        '
        'BoutonDetailContacts
        '
        Me.BoutonDetailContacts.Location = New System.Drawing.Point(568, 165)
        Me.BoutonDetailContacts.Name = "BoutonDetailContacts"
        Me.BoutonDetailContacts.Size = New System.Drawing.Size(85, 23)
        Me.BoutonDetailContacts.TabIndex = 21
        Me.BoutonDetailContacts.Text = "Contacts"
        Me.BoutonDetailContacts.UseVisualStyleBackColor = True
        '
        'BoutonDetailAnnuler
        '
        Me.BoutonDetailAnnuler.Location = New System.Drawing.Point(568, 69)
        Me.BoutonDetailAnnuler.Name = "BoutonDetailAnnuler"
        Me.BoutonDetailAnnuler.Size = New System.Drawing.Size(85, 23)
        Me.BoutonDetailAnnuler.TabIndex = 20
        Me.BoutonDetailAnnuler.Text = "Annuler"
        Me.BoutonDetailAnnuler.UseVisualStyleBackColor = True
        '
        'BoutonDetailSauvegarder
        '
        Me.BoutonDetailSauvegarder.Location = New System.Drawing.Point(568, 40)
        Me.BoutonDetailSauvegarder.Name = "BoutonDetailSauvegarder"
        Me.BoutonDetailSauvegarder.Size = New System.Drawing.Size(85, 23)
        Me.BoutonDetailSauvegarder.TabIndex = 19
        Me.BoutonDetailSauvegarder.Text = "Sauvegarder"
        Me.BoutonDetailSauvegarder.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(88, 229)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(89, 13)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "Date de creation:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(431, 229)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(110, 13)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Dernière Modification:"
        '
        'ComboBoxDetailStatut
        '
        Me.ComboBoxDetailStatut.FormattingEnabled = True
        Me.ComboBoxDetailStatut.Location = New System.Drawing.Point(419, 42)
        Me.ComboBoxDetailStatut.Name = "ComboBoxDetailStatut"
        Me.ComboBoxDetailStatut.Size = New System.Drawing.Size(121, 21)
        Me.ComboBoxDetailStatut.TabIndex = 16
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(40, 71)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(48, 13)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "Adresse:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(59, 101)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(29, 13)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Ville:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(21, 123)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(67, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Code Postal:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(352, 71)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Telephone:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(371, 97)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Couriel:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(25, 149)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Description:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(375, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Statut:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(56, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Nom:"
        '
        'TextBoxDetailDescription
        '
        Me.TextBoxDetailDescription.Location = New System.Drawing.Point(90, 146)
        Me.TextBoxDetailDescription.Name = "TextBoxDetailDescription"
        Me.TextBoxDetailDescription.Size = New System.Drawing.Size(448, 42)
        Me.TextBoxDetailDescription.TabIndex = 2
        Me.TextBoxDetailDescription.Text = ""
        '
        'TextBoxDetailCouriel
        '
        Me.TextBoxDetailCouriel.Location = New System.Drawing.Point(419, 94)
        Me.TextBoxDetailCouriel.Name = "TextBoxDetailCouriel"
        Me.TextBoxDetailCouriel.Size = New System.Drawing.Size(119, 20)
        Me.TextBoxDetailCouriel.TabIndex = 6
        '
        'TextBoxDetailTelephone
        '
        Me.TextBoxDetailTelephone.Location = New System.Drawing.Point(419, 68)
        Me.TextBoxDetailTelephone.Name = "TextBoxDetailTelephone"
        Me.TextBoxDetailTelephone.Size = New System.Drawing.Size(119, 20)
        Me.TextBoxDetailTelephone.TabIndex = 5
        '
        'TextBoxDetailAdresse
        '
        Me.TextBoxDetailAdresse.Location = New System.Drawing.Point(91, 68)
        Me.TextBoxDetailAdresse.Name = "TextBoxDetailAdresse"
        Me.TextBoxDetailAdresse.Size = New System.Drawing.Size(255, 20)
        Me.TextBoxDetailAdresse.TabIndex = 4
        '
        'TextBoxDetailVille
        '
        Me.TextBoxDetailVille.Location = New System.Drawing.Point(91, 94)
        Me.TextBoxDetailVille.Name = "TextBoxDetailVille"
        Me.TextBoxDetailVille.Size = New System.Drawing.Size(255, 20)
        Me.TextBoxDetailVille.TabIndex = 3
        '
        'TextBoxDetailCodeP
        '
        Me.TextBoxDetailCodeP.Location = New System.Drawing.Point(91, 120)
        Me.TextBoxDetailCodeP.Name = "TextBoxDetailCodeP"
        Me.TextBoxDetailCodeP.Size = New System.Drawing.Size(255, 20)
        Me.TextBoxDetailCodeP.TabIndex = 2
        '
        'TextBoxDetailNom
        '
        Me.TextBoxDetailNom.Location = New System.Drawing.Point(91, 42)
        Me.TextBoxDetailNom.Name = "TextBoxDetailNom"
        Me.TextBoxDetailNom.Size = New System.Drawing.Size(255, 20)
        Me.TextBoxDetailNom.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Controls.Add(Me.Button3)
        Me.GroupBox2.Controls.Add(Me.DataGridView1)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 390)
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
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(6, 27)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(535, 80)
        Me.DataGridView1.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Controls.Add(Me.Label16)
        Me.GroupBox3.Controls.Add(Me.RichTextBox1)
        Me.GroupBox3.Controls.Add(Me.Button4)
        Me.GroupBox3.Controls.Add(Me.Button5)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.ComboBox2)
        Me.GroupBox3.Controls.Add(Me.ComboBox1)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 528)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(675, 149)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Détail de la demarche"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(3, 130)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(89, 13)
        Me.Label14.TabIndex = 26
        Me.Label14.Text = "Date de creation:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(428, 130)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(110, 13)
        Me.Label15.TabIndex = 25
        Me.Label15.Text = "Dernière Modification:"
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
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(6, 85)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(534, 42)
        Me.RichTextBox1.TabIndex = 23
        Me.RichTextBox1.Text = ""
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
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(343, 49)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox2.TabIndex = 4
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(343, 22)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 3
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
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(43, 22)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 1
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
        Me.Button6.Location = New System.Drawing.Point(612, 683)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(75, 23)
        Me.Button6.TabIndex = 4
        Me.Button6.Text = "Fermer"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'SelectionEntreprisesBindingSource3
        '
        Me.SelectionEntreprisesBindingSource3.DataMember = "SelectionEntreprises"
        '
        'SelectionEntrepriseTableAdapter
        '
        Me.SelectionEntrepriseTableAdapter.ClearBeforeFill = True
        '
        'SelectionEntrepriseBindingSource4
        '
        Me.SelectionEntrepriseBindingSource4.DataMember = "SelectionEntreprise"
        Me.SelectionEntrepriseBindingSource4.DataSource = Me.SSDSDataSet
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(699, 710)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBoxEntreprises)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBoxEntreprises.ResumeLayout(False)
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SelectionEntrepriseBindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SSDSDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SelectionEntrepriseBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SelectionEntrepriseBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.SelectionEntreprisesBindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SelectionEntrepriseBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SelectionEntrepriseBindingSource4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBoxEntreprises As System.Windows.Forms.GroupBox
    Friend WithEvents BoutonAjouter As System.Windows.Forms.Button
    Friend WithEvents BoutonSupprimer As System.Windows.Forms.Button
    Friend WithEvents BoutonModifier As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ComboBoxDetailStatut As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBoxDetailDescription As System.Windows.Forms.RichTextBox
    Friend WithEvents TextBoxDetailCouriel As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxDetailTelephone As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxDetailAdresse As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxDetailVille As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxDetailCodeP As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxDetailNom As System.Windows.Forms.TextBox
    Friend WithEvents BoutonDetailContacts As System.Windows.Forms.Button
    Friend WithEvents BoutonDetailAnnuler As System.Windows.Forms.Button
    Friend WithEvents BoutonDetailSauvegarder As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents SelectionEntreprisesBindingSource3 As System.Windows.Forms.BindingSource
    Friend WithEvents SelectionEntrepriseBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SelectionEntrepriseTableAdapter As SSDS.SSDSDataSetTableAdapters.SelectionEntrepriseTableAdapter
    Friend WithEvents SelectionEntrepriseBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents SelectionEntrepriseBindingSource2 As System.Windows.Forms.BindingSource
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents NomENTDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VilleENTDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StatutDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DateCreationDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SelectionEntrepriseBindingSource3 As System.Windows.Forms.BindingSource
    Friend WithEvents SSDSDataSet As SSDS.SSDSDataSet
    Friend WithEvents SelectionEntrepriseBindingSource4 As System.Windows.Forms.BindingSource

End Class
