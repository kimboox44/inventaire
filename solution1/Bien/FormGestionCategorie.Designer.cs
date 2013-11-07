namespace solution1
{
    partial class FormGestionCategorie
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGestionCategorie));
            this.treeViewCategorieBien = new System.Windows.Forms.TreeView();
            this.imageListTV = new System.Windows.Forms.ImageList(this.components);
            this.buttonSupprimer = new System.Windows.Forms.Button();
            this.buttonAjouterCategorie = new System.Windows.Forms.Button();
            this.gBTypeAmortissement = new System.Windows.Forms.GroupBox();
            this.rBDegressif = new System.Windows.Forms.RadioButton();
            this.rBLineaire = new System.Windows.Forms.RadioButton();
            this.cMSTreeViewCategorieBien = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ajouterUneCatégorieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerLaCatégorieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonFermer = new System.Windows.Forms.Button();
            this.cMSAjouterCatégorie = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.aToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gBTypeAmortissement.SuspendLayout();
            this.cMSTreeViewCategorieBien.SuspendLayout();
            this.cMSAjouterCatégorie.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeViewCategorieBien
            // 
            this.treeViewCategorieBien.BackColor = System.Drawing.Color.White;
            this.treeViewCategorieBien.HideSelection = false;
            this.treeViewCategorieBien.ImageIndex = 0;
            this.treeViewCategorieBien.ImageList = this.imageListTV;
            this.treeViewCategorieBien.LabelEdit = true;
            this.treeViewCategorieBien.Location = new System.Drawing.Point(12, 81);
            this.treeViewCategorieBien.Name = "treeViewCategorieBien";
            this.treeViewCategorieBien.SelectedImageIndex = 0;
            this.treeViewCategorieBien.Size = new System.Drawing.Size(397, 329);
            this.treeViewCategorieBien.TabIndex = 0;
            this.treeViewCategorieBien.AfterLabelEdit += new System.Windows.Forms.NodeLabelEditEventHandler(this.treeViewCategorieBien_AfterLabelEdit);
            this.treeViewCategorieBien.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewCategorieBien_AfterSelect);
            this.treeViewCategorieBien.MouseDown += new System.Windows.Forms.MouseEventHandler(this.treeViewCategorieBien_MouseDown);
            // 
            // imageListTV
            // 
            this.imageListTV.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListTV.ImageStream")));
            this.imageListTV.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListTV.Images.SetKeyName(0, "Categorie.ico");
            this.imageListTV.Images.SetKeyName(1, "CategorieSelect.ico");
            this.imageListTV.Images.SetKeyName(2, "forward.gif");
            this.imageListTV.Images.SetKeyName(3, "next.gif");
            // 
            // buttonSupprimer
            // 
            this.buttonSupprimer.Location = new System.Drawing.Point(149, 416);
            this.buttonSupprimer.Name = "buttonSupprimer";
            this.buttonSupprimer.Size = new System.Drawing.Size(121, 24);
            this.buttonSupprimer.TabIndex = 1;
            this.buttonSupprimer.Text = "Supprimer";
            this.buttonSupprimer.UseVisualStyleBackColor = true;
            this.buttonSupprimer.Click += new System.EventHandler(this.buttonSupprimer_Click);
            // 
            // buttonAjouterCategorie
            // 
            this.buttonAjouterCategorie.Location = new System.Drawing.Point(22, 416);
            this.buttonAjouterCategorie.Name = "buttonAjouterCategorie";
            this.buttonAjouterCategorie.Size = new System.Drawing.Size(121, 24);
            this.buttonAjouterCategorie.TabIndex = 3;
            this.buttonAjouterCategorie.Text = "Ajouter catégorie";
            this.buttonAjouterCategorie.UseVisualStyleBackColor = true;
            this.buttonAjouterCategorie.Click += new System.EventHandler(this.buttonAjouterCategorie_Click);
            // 
            // gBTypeAmortissement
            // 
            this.gBTypeAmortissement.Controls.Add(this.rBDegressif);
            this.gBTypeAmortissement.Controls.Add(this.rBLineaire);
            this.gBTypeAmortissement.Location = new System.Drawing.Point(12, 6);
            this.gBTypeAmortissement.Name = "gBTypeAmortissement";
            this.gBTypeAmortissement.Size = new System.Drawing.Size(397, 69);
            this.gBTypeAmortissement.TabIndex = 4;
            this.gBTypeAmortissement.TabStop = false;
            this.gBTypeAmortissement.Text = "Type d\'amortissement";
            // 
            // rBDegressif
            // 
            this.rBDegressif.AutoSize = true;
            this.rBDegressif.Location = new System.Drawing.Point(22, 44);
            this.rBDegressif.Name = "rBDegressif";
            this.rBDegressif.Size = new System.Drawing.Size(138, 17);
            this.rBDegressif.TabIndex = 1;
            this.rBDegressif.TabStop = true;
            this.rBDegressif.Tag = "";
            this.rBDegressif.Text = "Amortissement dégressif";
            this.rBDegressif.UseVisualStyleBackColor = true;
            this.rBDegressif.CheckedChanged += new System.EventHandler(this.rB_CheckedChanged);
            // 
            // rBLineaire
            // 
            this.rBLineaire.AutoSize = true;
            this.rBLineaire.Location = new System.Drawing.Point(22, 21);
            this.rBLineaire.Name = "rBLineaire";
            this.rBLineaire.Size = new System.Drawing.Size(129, 17);
            this.rBLineaire.TabIndex = 0;
            this.rBLineaire.TabStop = true;
            this.rBLineaire.Tag = "";
            this.rBLineaire.Text = "Amortissement linéaire";
            this.rBLineaire.UseVisualStyleBackColor = true;
            this.rBLineaire.CheckedChanged += new System.EventHandler(this.rB_CheckedChanged);
            // 
            // cMSTreeViewCategorieBien
            // 
            this.cMSTreeViewCategorieBien.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterUneCatégorieToolStripMenuItem,
            this.supprimerLaCatégorieToolStripMenuItem});
            this.cMSTreeViewCategorieBien.Name = "cMSTreeViewCategorieBien";
            this.cMSTreeViewCategorieBien.Size = new System.Drawing.Size(193, 48);
            // 
            // ajouterUneCatégorieToolStripMenuItem
            // 
            this.ajouterUneCatégorieToolStripMenuItem.Name = "ajouterUneCatégorieToolStripMenuItem";
            this.ajouterUneCatégorieToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.ajouterUneCatégorieToolStripMenuItem.Text = "Ajouter une catégorie";
            this.ajouterUneCatégorieToolStripMenuItem.Click += new System.EventHandler(this.ajouterUneCatégorieToolStripMenuItem_Click);
            // 
            // supprimerLaCatégorieToolStripMenuItem
            // 
            this.supprimerLaCatégorieToolStripMenuItem.Name = "supprimerLaCatégorieToolStripMenuItem";
            this.supprimerLaCatégorieToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.supprimerLaCatégorieToolStripMenuItem.Text = "Supprimer la catégorie";
            this.supprimerLaCatégorieToolStripMenuItem.Click += new System.EventHandler(this.supprimerLaCatégorieToolStripMenuItem_Click);
            // 
            // buttonFermer
            // 
            this.buttonFermer.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonFermer.Location = new System.Drawing.Point(276, 416);
            this.buttonFermer.Name = "buttonFermer";
            this.buttonFermer.Size = new System.Drawing.Size(121, 24);
            this.buttonFermer.TabIndex = 6;
            this.buttonFermer.Text = "Fermer";
            this.buttonFermer.UseVisualStyleBackColor = true;
            this.buttonFermer.Click += new System.EventHandler(this.buttonFermer_Click);
            // 
            // cMSAjouterCatégorie
            // 
            this.cMSAjouterCatégorie.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aToolStripMenuItem});
            this.cMSAjouterCatégorie.Name = "cMSAjouterCatégorie";
            this.cMSAjouterCatégorie.Size = new System.Drawing.Size(191, 26);
            // 
            // aToolStripMenuItem
            // 
            this.aToolStripMenuItem.Name = "aToolStripMenuItem";
            this.aToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.aToolStripMenuItem.Text = "Ajouter une catégorie";
            this.aToolStripMenuItem.Click += new System.EventHandler(this.aToolStripMenuItem_Click);
            // 
            // FormGestionCategorie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonFermer;
            this.ClientSize = new System.Drawing.Size(421, 451);
            this.Controls.Add(this.gBTypeAmortissement);
            this.Controls.Add(this.buttonFermer);
            this.Controls.Add(this.buttonAjouterCategorie);
            this.Controls.Add(this.treeViewCategorieBien);
            this.Controls.Add(this.buttonSupprimer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormGestionCategorie";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion des catégories";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormGestionCategorie_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormGestionCategorie_FormClosed);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.gBTypeAmortissement.ResumeLayout(false);
            this.gBTypeAmortissement.PerformLayout();
            this.cMSTreeViewCategorieBien.ResumeLayout(false);
            this.cMSAjouterCatégorie.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeViewCategorieBien;
        private System.Windows.Forms.ImageList imageListTV;
        private System.Windows.Forms.GroupBox gBTypeAmortissement;
        private System.Windows.Forms.RadioButton rBDegressif;
        private System.Windows.Forms.RadioButton rBLineaire;
        private System.Windows.Forms.ContextMenuStrip cMSTreeViewCategorieBien;
        private System.Windows.Forms.Button buttonFermer;
        private System.Windows.Forms.ToolStripMenuItem ajouterUneCatégorieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supprimerLaCatégorieToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip cMSAjouterCatégorie;
        private System.Windows.Forms.ToolStripMenuItem aToolStripMenuItem;
        public System.Windows.Forms.Button buttonSupprimer;
        public System.Windows.Forms.Button buttonAjouterCategorie;
    }
}