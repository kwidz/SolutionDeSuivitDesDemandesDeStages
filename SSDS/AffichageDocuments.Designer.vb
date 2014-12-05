<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AffichageDocuments
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AffichageDocuments))
        Me.AxAcroPDF1 = New AxAcroPDFLib.AxAcroPDF()
        Me.AjouterFichier = New System.Windows.Forms.Button()
        Me.SupprimerLeFichier = New System.Windows.Forms.Button()
        Me.SelectionerFichier = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.AxAcroPDF1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AxAcroPDF1
        '
        Me.AxAcroPDF1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AxAcroPDF1.Enabled = True
        Me.AxAcroPDF1.Location = New System.Drawing.Point(12, 100)
        Me.AxAcroPDF1.Name = "AxAcroPDF1"
        Me.AxAcroPDF1.OcxState = CType(resources.GetObject("AxAcroPDF1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxAcroPDF1.Size = New System.Drawing.Size(599, 313)
        Me.AxAcroPDF1.TabIndex = 0
        '
        'AjouterFichier
        '
        Me.AjouterFichier.Location = New System.Drawing.Point(12, 13)
        Me.AjouterFichier.Name = "AjouterFichier"
        Me.AjouterFichier.Size = New System.Drawing.Size(269, 23)
        Me.AjouterFichier.TabIndex = 1
        Me.AjouterFichier.Text = "Ajouter un fichier"
        Me.AjouterFichier.UseVisualStyleBackColor = True
        '
        'SupprimerLeFichier
        '
        Me.SupprimerLeFichier.Location = New System.Drawing.Point(12, 71)
        Me.SupprimerLeFichier.Name = "SupprimerLeFichier"
        Me.SupprimerLeFichier.Size = New System.Drawing.Size(269, 23)
        Me.SupprimerLeFichier.TabIndex = 2
        Me.SupprimerLeFichier.Text = "Supprimer le fichier"
        Me.SupprimerLeFichier.UseVisualStyleBackColor = True
        '
        'SelectionerFichier
        '
        Me.SelectionerFichier.Location = New System.Drawing.Point(12, 42)
        Me.SelectionerFichier.Name = "SelectionerFichier"
        Me.SelectionerFichier.Size = New System.Drawing.Size(269, 23)
        Me.SelectionerFichier.TabIndex = 3
        Me.SelectionerFichier.Text = "Afficher le fichier"
        Me.SelectionerFichier.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Location = New System.Drawing.Point(536, 420)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Fermer"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'AffichageDocuments
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(623, 455)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.SelectionerFichier)
        Me.Controls.Add(Me.SupprimerLeFichier)
        Me.Controls.Add(Me.AjouterFichier)
        Me.Controls.Add(Me.AxAcroPDF1)
        Me.Name = "AffichageDocuments"
        Me.Text = "Afficher un document"
        CType(Me.AxAcroPDF1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents AxAcroPDF1 As AxAcroPDFLib.AxAcroPDF
    Friend WithEvents AjouterFichier As System.Windows.Forms.Button
    Friend WithEvents SupprimerLeFichier As System.Windows.Forms.Button
    Friend WithEvents SelectionerFichier As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
