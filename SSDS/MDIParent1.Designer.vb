<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MDIParent1
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
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.FileMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestionDesDémarchesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultationDesDémarchesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestionDesUtilisateursToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChangerDeMotDePasseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RapportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListeDesEntreprisesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListeDesDémarchesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WindowsMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.MenuStrip.SuspendLayout()
        Me.StatusStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileMenu, Me.EditMenu, Me.ChangerDeMotDePasseToolStripMenuItem, Me.RapportsToolStripMenuItem, Me.WindowsMenu, Me.HelpMenu})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.MdiWindowListItem = Me.WindowsMenu
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(632, 24)
        Me.MenuStrip.TabIndex = 5
        Me.MenuStrip.Text = "MenuStrip"
        '
        'FileMenu
        '
        Me.FileMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.FileMenu.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder
        Me.FileMenu.Name = "FileMenu"
        Me.FileMenu.Size = New System.Drawing.Size(54, 20)
        Me.FileMenu.Text = "&Fichier"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(111, 22)
        Me.ExitToolStripMenuItem.Text = "&Quitter"
        '
        'EditMenu
        '
        Me.EditMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GestionDesDémarchesToolStripMenuItem, Me.ConsultationDesDémarchesToolStripMenuItem, Me.GestionDesUtilisateursToolStripMenuItem})
        Me.EditMenu.Name = "EditMenu"
        Me.EditMenu.Size = New System.Drawing.Size(81, 20)
        Me.EditMenu.Text = "&Formulaires"
        '
        'GestionDesDémarchesToolStripMenuItem
        '
        Me.GestionDesDémarchesToolStripMenuItem.Name = "GestionDesDémarchesToolStripMenuItem"
        Me.GestionDesDémarchesToolStripMenuItem.Size = New System.Drawing.Size(227, 22)
        Me.GestionDesDémarchesToolStripMenuItem.Text = "Gestion des démarches"
        '
        'ConsultationDesDémarchesToolStripMenuItem
        '
        Me.ConsultationDesDémarchesToolStripMenuItem.Name = "ConsultationDesDémarchesToolStripMenuItem"
        Me.ConsultationDesDémarchesToolStripMenuItem.Size = New System.Drawing.Size(227, 22)
        Me.ConsultationDesDémarchesToolStripMenuItem.Text = "Consultation des démarches "
        '
        'GestionDesUtilisateursToolStripMenuItem
        '
        Me.GestionDesUtilisateursToolStripMenuItem.Name = "GestionDesUtilisateursToolStripMenuItem"
        Me.GestionDesUtilisateursToolStripMenuItem.Size = New System.Drawing.Size(227, 22)
        Me.GestionDesUtilisateursToolStripMenuItem.Text = "Gestion des Utilisateurs"
        '
        'ChangerDeMotDePasseToolStripMenuItem
        '
        Me.ChangerDeMotDePasseToolStripMenuItem.Name = "ChangerDeMotDePasseToolStripMenuItem"
        Me.ChangerDeMotDePasseToolStripMenuItem.Size = New System.Drawing.Size(153, 20)
        Me.ChangerDeMotDePasseToolStripMenuItem.Text = "Changer de mot de passe"
        '
        'RapportsToolStripMenuItem
        '
        Me.RapportsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ListeDesEntreprisesToolStripMenuItem, Me.ListeDesDémarchesToolStripMenuItem})
        Me.RapportsToolStripMenuItem.Name = "RapportsToolStripMenuItem"
        Me.RapportsToolStripMenuItem.Size = New System.Drawing.Size(66, 20)
        Me.RapportsToolStripMenuItem.Text = "Rapports"
        '
        'ListeDesEntreprisesToolStripMenuItem
        '
        Me.ListeDesEntreprisesToolStripMenuItem.Name = "ListeDesEntreprisesToolStripMenuItem"
        Me.ListeDesEntreprisesToolStripMenuItem.Size = New System.Drawing.Size(262, 22)
        Me.ListeDesEntreprisesToolStripMenuItem.Text = "Nombre de contacts par entreprises"
        '
        'ListeDesDémarchesToolStripMenuItem
        '
        Me.ListeDesDémarchesToolStripMenuItem.Name = "ListeDesDémarchesToolStripMenuItem"
        Me.ListeDesDémarchesToolStripMenuItem.Size = New System.Drawing.Size(262, 22)
        Me.ListeDesDémarchesToolStripMenuItem.Text = "Liste des contacts par entreprises"
        '
        'WindowsMenu
        '
        Me.WindowsMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CloseAllToolStripMenuItem})
        Me.WindowsMenu.Name = "WindowsMenu"
        Me.WindowsMenu.Size = New System.Drawing.Size(63, 20)
        Me.WindowsMenu.Text = "F&enêtres"
        '
        'CloseAllToolStripMenuItem
        '
        Me.CloseAllToolStripMenuItem.Name = "CloseAllToolStripMenuItem"
        Me.CloseAllToolStripMenuItem.Size = New System.Drawing.Size(136, 22)
        Me.CloseAllToolStripMenuItem.Text = "&Fermer tout"
        '
        'HelpMenu
        '
        Me.HelpMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpMenu.Name = "HelpMenu"
        Me.HelpMenu.Size = New System.Drawing.Size(24, 20)
        Me.HelpMenu.Text = "&?"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(147, 22)
        Me.AboutToolStripMenuItem.Text = "À pr&opos de..."
        '
        'StatusStrip
        '
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 431)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(632, 22)
        Me.StatusStrip.TabIndex = 7
        Me.StatusStrip.Text = "StatusStrip"
        '
        'ToolStripStatusLabel
        '
        Me.ToolStripStatusLabel.Name = "ToolStripStatusLabel"
        Me.ToolStripStatusLabel.Size = New System.Drawing.Size(27, 17)
        Me.ToolStripStatusLabel.Text = "État"
        '
        'MDIParent1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(632, 453)
        Me.Controls.Add(Me.MenuStrip)
        Me.Controls.Add(Me.StatusStrip)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "MDIParent1"
        Me.Text = "SSDS"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents HelpMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CloseAllToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WindowsMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents ToolStripStatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FileMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents EditMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GestionDesDémarchesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GestionDesUtilisateursToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConsultationDesDémarchesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ChangerDeMotDePasseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RapportsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ListeDesEntreprisesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ListeDesDémarchesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
