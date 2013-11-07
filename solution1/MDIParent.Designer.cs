namespace solution1
{
    partial class MDIParent
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();

            }
            base.Dispose(disposing);

        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MDIParent));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolBarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusBarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.newWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cascadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tileVerticalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tileHorizontalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arrangeIconsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rapportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuAdmin = new System.Windows.Forms.ToolStripMenuItem();
            this.importationDonnéeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportationDeDonnéeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viderLaBaseDeDonéeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionUtilisateursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.ouvrirInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nvInvTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.gestInventTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tBSUtilisateur = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton_rapport = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.helpToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel_utilisateur = new System.Windows.Forms.ToolStripLabel();
            this.utilisateur = new System.Windows.Forms.Label();
            this.BienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.toolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BienBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.AutoSize = false;
            this.menuStrip.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("menuStrip.BackgroundImage")));
            this.menuStrip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu,
            this.viewMenu,
            this.windowsMenu,
            this.rapportToolStripMenuItem,
            this.toolStripMenuAdmin});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.MdiWindowListItem = this.windowsMenu;
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.menuStrip.Size = new System.Drawing.Size(1094, 27);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // fileMenu
            // 
            this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.toolStripSeparator3,
            this.toolStripSeparator5,
            this.exitToolStripMenuItem});
            this.fileMenu.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileMenu.ForeColor = System.Drawing.Color.Gainsboro;
            this.fileMenu.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder;
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Size = new System.Drawing.Size(64, 23);
            this.fileMenu.Text = "&Fichier";
            this.fileMenu.Click += new System.EventHandler(this.fileMenu_Click);
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripMenuItem.Image")));
            this.newToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(266, 24);
            this.newToolStripMenuItem.Text = "&Nouvel inventaire";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.ShowNewForm);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
            this.openToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(266, 24);
            this.openToolStripMenuItem.Text = "&Ouvrire un inventaire";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.OpenFile);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(263, 6);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(263, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(266, 24);
            this.exitToolStripMenuItem.Text = "E&xit";
            // 
            // viewMenu
            // 
            this.viewMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolBarToolStripMenuItem,
            this.statusBarToolStripMenuItem});
            this.viewMenu.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewMenu.ForeColor = System.Drawing.Color.Gainsboro;
            this.viewMenu.Name = "viewMenu";
            this.viewMenu.Size = new System.Drawing.Size(82, 23);
            this.viewMenu.Text = "&Affichage";
            // 
            // toolBarToolStripMenuItem
            // 
            this.toolBarToolStripMenuItem.Checked = true;
            this.toolBarToolStripMenuItem.CheckOnClick = true;
            this.toolBarToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolBarToolStripMenuItem.Name = "toolBarToolStripMenuItem";
            this.toolBarToolStripMenuItem.Size = new System.Drawing.Size(144, 24);
            this.toolBarToolStripMenuItem.Text = "&Toolbar";
            this.toolBarToolStripMenuItem.Click += new System.EventHandler(this.ToolBarToolStripMenuItem_Click);
            // 
            // statusBarToolStripMenuItem
            // 
            this.statusBarToolStripMenuItem.Checked = true;
            this.statusBarToolStripMenuItem.CheckOnClick = true;
            this.statusBarToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.statusBarToolStripMenuItem.Name = "statusBarToolStripMenuItem";
            this.statusBarToolStripMenuItem.Size = new System.Drawing.Size(144, 24);
            this.statusBarToolStripMenuItem.Text = "&Status Bar";
            this.statusBarToolStripMenuItem.Click += new System.EventHandler(this.StatusBarToolStripMenuItem_Click);
            // 
            // windowsMenu
            // 
            this.windowsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newWindowToolStripMenuItem,
            this.cascadeToolStripMenuItem,
            this.tileVerticalToolStripMenuItem,
            this.tileHorizontalToolStripMenuItem,
            this.closeAllToolStripMenuItem,
            this.arrangeIconsToolStripMenuItem});
            this.windowsMenu.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.windowsMenu.ForeColor = System.Drawing.Color.Gainsboro;
            this.windowsMenu.Name = "windowsMenu";
            this.windowsMenu.Size = new System.Drawing.Size(70, 23);
            this.windowsMenu.Text = "&Fenêtre";
            // 
            // newWindowToolStripMenuItem
            // 
            this.newWindowToolStripMenuItem.Name = "newWindowToolStripMenuItem";
            this.newWindowToolStripMenuItem.Size = new System.Drawing.Size(249, 24);
            this.newWindowToolStripMenuItem.Text = "&Nouvelle Fenêtre";
            this.newWindowToolStripMenuItem.Click += new System.EventHandler(this.ShowNewForm);
            // 
            // cascadeToolStripMenuItem
            // 
            this.cascadeToolStripMenuItem.Name = "cascadeToolStripMenuItem";
            this.cascadeToolStripMenuItem.Size = new System.Drawing.Size(249, 24);
            this.cascadeToolStripMenuItem.Text = "En cascade";
            this.cascadeToolStripMenuItem.Click += new System.EventHandler(this.CascadeToolStripMenuItem_Click);
            // 
            // tileVerticalToolStripMenuItem
            // 
            this.tileVerticalToolStripMenuItem.Name = "tileVerticalToolStripMenuItem";
            this.tileVerticalToolStripMenuItem.Size = new System.Drawing.Size(249, 24);
            this.tileVerticalToolStripMenuItem.Text = "En bandes verticales";
            this.tileVerticalToolStripMenuItem.Click += new System.EventHandler(this.TileVerticalToolStripMenuItem_Click);
            // 
            // tileHorizontalToolStripMenuItem
            // 
            this.tileHorizontalToolStripMenuItem.Name = "tileHorizontalToolStripMenuItem";
            this.tileHorizontalToolStripMenuItem.Size = new System.Drawing.Size(249, 24);
            this.tileHorizontalToolStripMenuItem.Text = "En bandes horizontales";
            this.tileHorizontalToolStripMenuItem.Click += new System.EventHandler(this.TileHorizontalToolStripMenuItem_Click);
            // 
            // closeAllToolStripMenuItem
            // 
            this.closeAllToolStripMenuItem.Name = "closeAllToolStripMenuItem";
            this.closeAllToolStripMenuItem.Size = new System.Drawing.Size(249, 24);
            this.closeAllToolStripMenuItem.Text = "Fermer toutes les fenêtres";
            this.closeAllToolStripMenuItem.Click += new System.EventHandler(this.CloseAllToolStripMenuItem_Click);
            // 
            // arrangeIconsToolStripMenuItem
            // 
            this.arrangeIconsToolStripMenuItem.Name = "arrangeIconsToolStripMenuItem";
            this.arrangeIconsToolStripMenuItem.Size = new System.Drawing.Size(249, 24);
            this.arrangeIconsToolStripMenuItem.Text = "Arrangeer les icones";
            this.arrangeIconsToolStripMenuItem.Click += new System.EventHandler(this.ArrangeIconsToolStripMenuItem_Click);
            // 
            // rapportToolStripMenuItem
            // 
            this.rapportToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rapportToolStripMenuItem.ForeColor = System.Drawing.Color.Gainsboro;
            this.rapportToolStripMenuItem.Name = "rapportToolStripMenuItem";
            this.rapportToolStripMenuItem.Size = new System.Drawing.Size(79, 23);
            this.rapportToolStripMenuItem.Text = "Rapports";
            this.rapportToolStripMenuItem.Click += new System.EventHandler(this.rapportToolStripMenuItem_Click);
            // 
            // toolStripMenuAdmin
            // 
            this.toolStripMenuAdmin.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importationDonnéeToolStripMenuItem,
            this.exportationDeDonnéeToolStripMenuItem,
            this.viderLaBaseDeDonéeToolStripMenuItem,
            this.gestionUtilisateursToolStripMenuItem});
            this.toolStripMenuAdmin.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuAdmin.ForeColor = System.Drawing.Color.Gainsboro;
            this.toolStripMenuAdmin.Name = "toolStripMenuAdmin";
            this.toolStripMenuAdmin.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolStripMenuAdmin.Size = new System.Drawing.Size(117, 23);
            this.toolStripMenuAdmin.Text = "Administrateur";
            this.toolStripMenuAdmin.Visible = false;
            // 
            // importationDonnéeToolStripMenuItem
            // 
            this.importationDonnéeToolStripMenuItem.Name = "importationDonnéeToolStripMenuItem";
            this.importationDonnéeToolStripMenuItem.Size = new System.Drawing.Size(225, 24);
            this.importationDonnéeToolStripMenuItem.Text = "Importation donnée";
            this.importationDonnéeToolStripMenuItem.Click += new System.EventHandler(this.importationDonnéeToolStripMenuItem_Click);
            // 
            // exportationDeDonnéeToolStripMenuItem
            // 
            this.exportationDeDonnéeToolStripMenuItem.Name = "exportationDeDonnéeToolStripMenuItem";
            this.exportationDeDonnéeToolStripMenuItem.Size = new System.Drawing.Size(225, 24);
            this.exportationDeDonnéeToolStripMenuItem.Text = "Exportation de donnée";
            this.exportationDeDonnéeToolStripMenuItem.Click += new System.EventHandler(this.exportationDeDonnéeToolStripMenuItem_Click);
            // 
            // viderLaBaseDeDonéeToolStripMenuItem
            // 
            this.viderLaBaseDeDonéeToolStripMenuItem.Name = "viderLaBaseDeDonéeToolStripMenuItem";
            this.viderLaBaseDeDonéeToolStripMenuItem.Size = new System.Drawing.Size(225, 24);
            this.viderLaBaseDeDonéeToolStripMenuItem.Text = "vider la base de donée";
            this.viderLaBaseDeDonéeToolStripMenuItem.Click += new System.EventHandler(this.viderLaBaseDeDonéeToolStripMenuItem_Click);
            // 
            // gestionUtilisateursToolStripMenuItem
            // 
            this.gestionUtilisateursToolStripMenuItem.Name = "gestionUtilisateursToolStripMenuItem";
            this.gestionUtilisateursToolStripMenuItem.Size = new System.Drawing.Size(225, 24);
            this.gestionUtilisateursToolStripMenuItem.Text = "Gestion utilisateurs";
            this.gestionUtilisateursToolStripMenuItem.Click += new System.EventHandler(this.gestionUtilisateursToolStripMenuItem_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 442);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1094, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStrip
            // 
            this.toolStrip.AutoSize = false;
            this.toolStrip.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("toolStrip.BackgroundImage")));
            this.toolStrip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tBSUtilisateur,
            this.toolStripSeparator2,
            this.toolStripSplitButton1,
            this.toolStripSeparator8,
            this.toolStripButton_rapport,
            this.toolStripSeparator6,
            this.helpToolStripButton,
            this.toolStripSeparator4,
            this.toolStripButton1,
            this.toolStripSeparator7,
            this.toolStripLabel_utilisateur});
            this.toolStrip.Location = new System.Drawing.Point(0, 27);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(1094, 45);
            this.toolStrip.TabIndex = 1;
            this.toolStrip.Text = "ToolStrip";
            this.toolStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip_ItemClicked);
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSplitButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ouvrirInToolStripMenuItem,
            this.nvInvTSMI,
            this.gestInventTSMI});
            this.toolStripSplitButton1.Image = global::solution1.Properties.Resources.doc;
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(32, 42);
            this.toolStripSplitButton1.Text = "toolStripSplitButton1";
            // 
            // ouvrirInToolStripMenuItem
            // 
            this.ouvrirInToolStripMenuItem.Name = "ouvrirInToolStripMenuItem";
            this.ouvrirInToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.ouvrirInToolStripMenuItem.Text = "Ouvrir Inventaire";
            this.ouvrirInToolStripMenuItem.Click += new System.EventHandler(this.ouvrirInToolStripMenuItem_Click);
            // 
            // nvInvTSMI
            // 
            this.nvInvTSMI.Name = "nvInvTSMI";
            this.nvInvTSMI.Size = new System.Drawing.Size(169, 22);
            this.nvInvTSMI.Text = "Nouvel Inventaire";
            this.nvInvTSMI.Click += new System.EventHandler(this.nouveauInventaireToolStripMenuItem_Click);
            // 
            // gestInventTSMI
            // 
            this.gestInventTSMI.Name = "gestInventTSMI";
            this.gestInventTSMI.Size = new System.Drawing.Size(169, 22);
            this.gestInventTSMI.Text = "Gestion Inventaire";
            this.gestInventTSMI.Click += new System.EventHandler(this.gestionInventaireToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 45);
            // 
            // tBSUtilisateur
            // 
            this.tBSUtilisateur.AutoSize = false;
            this.tBSUtilisateur.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tBSUtilisateur.Image = ((System.Drawing.Image)(resources.GetObject("tBSUtilisateur.Image")));
            this.tBSUtilisateur.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tBSUtilisateur.Name = "tBSUtilisateur";
            this.tBSUtilisateur.Size = new System.Drawing.Size(45, 42);
            this.tBSUtilisateur.Text = "toolStripButton1";
            this.tBSUtilisateur.ToolTipText = "Gestion des utilisateurs/inventaires";
            this.tBSUtilisateur.Click += new System.EventHandler(this.tBSUtilisateur_Click);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(6, 45);
            // 
            // toolStripButton_rapport
            // 
            this.toolStripButton_rapport.AutoSize = false;
            this.toolStripButton_rapport.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_rapport.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_rapport.Image")));
            this.toolStripButton_rapport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_rapport.Name = "toolStripButton_rapport";
            this.toolStripButton_rapport.Size = new System.Drawing.Size(45, 42);
            this.toolStripButton_rapport.Text = "toolStripButton1";
            this.toolStripButton_rapport.ToolTipText = "Gestion des utilisateurs/inventaires";
            this.toolStripButton_rapport.Click += new System.EventHandler(this.toolStripButton_rapport_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 45);
            // 
            // helpToolStripButton
            // 
            this.helpToolStripButton.AutoSize = false;
            this.helpToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.helpToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("helpToolStripButton.Image")));
            this.helpToolStripButton.ImageTransparentColor = System.Drawing.Color.Black;
            this.helpToolStripButton.Name = "helpToolStripButton";
            this.helpToolStripButton.Size = new System.Drawing.Size(45, 42);
            this.helpToolStripButton.Text = "Help";
            this.helpToolStripButton.Click += new System.EventHandler(this.helpToolStripButton_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 45);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.AutoSize = false;
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolStripButton1.RightToLeftAutoMirrorImage = true;
            this.toolStripButton1.Size = new System.Drawing.Size(45, 42);
            this.toolStripButton1.Text = "Déconnexion";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click_2);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 45);
            // 
            // toolStripLabel_utilisateur
            // 
            this.toolStripLabel_utilisateur.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel_utilisateur.Name = "toolStripLabel_utilisateur";
            this.toolStripLabel_utilisateur.Size = new System.Drawing.Size(65, 42);
            this.toolStripLabel_utilisateur.Text = "Utilisateur";
            // 
            // utilisateur
            // 
            this.utilisateur.AutoSize = true;
            this.utilisateur.Location = new System.Drawing.Point(590, 8);
            this.utilisateur.Name = "utilisateur";
            this.utilisateur.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.utilisateur.Size = new System.Drawing.Size(0, 13);
            this.utilisateur.TabIndex = 6;
            // 
            // BienBindingSource
            // 
            this.BienBindingSource.DataMember = "Bien";
            // 
            // MDIParent
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1094, 464);
            this.Controls.Add(this.utilisateur);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MDIParent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventaire";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MDIParent1_Load);
            this.Validated += new System.EventHandler(this.MDIParent_Validated);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BienBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem tileHorizontalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileMenu;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewMenu;
        private System.Windows.Forms.ToolStripMenuItem toolBarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statusBarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem windowsMenu;
        private System.Windows.Forms.ToolStripMenuItem newWindowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cascadeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tileVerticalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arrangeIconsToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton helpToolStripButton;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        public System.Windows.Forms.MenuStrip menuStrip;
        public System.Windows.Forms.ToolStrip toolStrip;
        public System.Windows.Forms.ToolStripButton tBSUtilisateur;
        public System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        public System.Windows.Forms.ToolStripMenuItem toolStripMenuAdmin;
        private System.Windows.Forms.ToolStripMenuItem importationDonnéeToolStripMenuItem;
        public System.Windows.Forms.Label utilisateur;
        private System.Windows.Forms.ToolStripMenuItem exportationDeDonnéeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viderLaBaseDeDonéeToolStripMenuItem;
        public System.Windows.Forms.ToolStripLabel toolStripLabel_utilisateur;
        public System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.BindingSource BienBindingSource;
        private System.Windows.Forms.ToolStripMenuItem rapportToolStripMenuItem;
        public System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        public System.Windows.Forms.ToolStripButton toolStripButton_rapport;
        private System.Windows.Forms.ToolStripMenuItem gestionUtilisateursToolStripMenuItem;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripMenuItem ouvrirInToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem gestInventTSMI;
        public System.Windows.Forms.ToolStripMenuItem nvInvTSMI;
    

    }
}



