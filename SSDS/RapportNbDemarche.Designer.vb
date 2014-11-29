<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RaportNbDemarches
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.rapportNombreContactParEntrepriseBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SSDSDataSet = New SSDS.SSDSDataSet()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.SelectionUsersWithTousBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SelectionUsersWithTousTableAdapter = New SSDS.SSDSDataSetTableAdapters.selectionUsersWithTousTableAdapter()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.rapportNombreContactParEntrepriseTableAdapter = New SSDS.SSDSDataSetTableAdapters.rapportNombreContactParEntrepriseTableAdapter()
        CType(Me.rapportNombreContactParEntrepriseBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SSDSDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SelectionUsersWithTousBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rapportNombreContactParEntrepriseBindingSource
        '
        Me.rapportNombreContactParEntrepriseBindingSource.DataMember = "rapportNombreContactParEntreprise"
        Me.rapportNombreContactParEntrepriseBindingSource.DataSource = Me.SSDSDataSet
        '
        'SSDSDataSet
        '
        Me.SSDSDataSet.DataSetName = "SSDSDataSet"
        Me.SSDSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.SelectionUsersWithTousBindingSource
        Me.ComboBox1.DisplayMember = "nomPrenom"
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(74, 11)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 0
        Me.ComboBox1.ValueMember = "noUTIL"
        '
        'SelectionUsersWithTousBindingSource
        '
        Me.SelectionUsersWithTousBindingSource.DataMember = "selectionUsersWithTous"
        Me.SelectionUsersWithTousBindingSource.DataSource = Me.SSDSDataSet
        '
        'SelectionUsersWithTousTableAdapter
        '
        Me.SelectionUsersWithTousTableAdapter.ClearBeforeFill = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Étudiant : "
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(220, 9)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Générer"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.rapportNombreContactParEntrepriseBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "SSDS.NombreDemarches.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(12, 38)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(678, 343)
        Me.ReportViewer1.TabIndex = 3
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(615, 387)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Fermer"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'rapportNombreContactParEntrepriseTableAdapter
        '
        Me.rapportNombreContactParEntrepriseTableAdapter.ClearBeforeFill = True
        '
        'RaportNbDemarches
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(702, 419)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Name = "RaportNbDemarches"
        Me.Text = "Rapport nombre démarches par entreprises"
        CType(Me.rapportNombreContactParEntrepriseBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SSDSDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SelectionUsersWithTousBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents SSDSDataSet As SSDS.SSDSDataSet
    Friend WithEvents SelectionUsersWithTousBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SelectionUsersWithTousTableAdapter As SSDS.SSDSDataSetTableAdapters.selectionUsersWithTousTableAdapter
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents rapportNombreContactParEntrepriseBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents rapportNombreContactParEntrepriseTableAdapter As SSDS.SSDSDataSetTableAdapters.rapportNombreContactParEntrepriseTableAdapter
End Class
