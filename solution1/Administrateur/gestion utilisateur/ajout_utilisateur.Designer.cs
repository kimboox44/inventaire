namespace solution1.gestion_utilisateur
{
    partial class ajout_utilisateur
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Bien-Categorie");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Site-Emplacement");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Client-Fournisseur");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Transfert-Cession");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Rapports");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Inventaire");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Mise a jour", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5,
            treeNode6});
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Bien-Categorie");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Site-Emplacement");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Client-Fournisseur");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Transfert-Cession");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Rapports");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Inventaire");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Consultation", new System.Windows.Forms.TreeNode[] {
            treeNode8,
            treeNode9,
            treeNode10,
            treeNode11,
            treeNode12,
            treeNode13});
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Client-Fournisseur");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("Transfert-Cession");
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("Aucun accée", new System.Windows.Forms.TreeNode[] {
            treeNode15,
            treeNode16});
            this.ajout_util = new DevExpress.XtraEditors.PanelControl();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.label3 = new System.Windows.Forms.Label();
            this.treeDroits = new System.Windows.Forms.TreeView();
            this.enregistrer_droit = new DevExpress.XtraEditors.SimpleButton();
            this.dgvDroits = new System.Windows.Forms.DataGridView();
            this.Privilége = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.droit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Supprimer = new System.Windows.Forms.DataGridViewButtonColumn();
            this.splitterControl1 = new DevExpress.XtraEditors.SplitterControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.label2 = new System.Windows.Forms.Label();
            this.check_admin = new DevExpress.XtraEditors.CheckEdit();
            this.Password = new DevExpress.XtraEditors.TextEdit();
            this.Login = new DevExpress.XtraEditors.TextEdit();
            this.Prenom = new DevExpress.XtraEditors.TextEdit();
            this.Nom = new DevExpress.XtraEditors.TextEdit();
            this.panalpassword = new DevExpress.XtraEditors.LabelControl();
            this.panalLogin = new DevExpress.XtraEditors.LabelControl();
            this.panalPrenom = new DevExpress.XtraEditors.LabelControl();
            this.panalNom = new DevExpress.XtraEditors.LabelControl();
            this.valider_enregistrement = new DevExpress.XtraEditors.SimpleButton();
            this.splitterControl2 = new DevExpress.XtraEditors.SplitterControl();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ajout_util)).BeginInit();
            this.ajout_util.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDroits)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.check_admin.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Password.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Login.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Prenom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nom.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // ajout_util
            // 
            this.ajout_util.Controls.Add(this.panelControl3);
            this.ajout_util.Controls.Add(this.panelControl2);
            this.ajout_util.Location = new System.Drawing.Point(19, 75);
            this.ajout_util.LookAndFeel.SkinName = "Office 2007 Black";
            this.ajout_util.Name = "ajout_util";
            this.ajout_util.Size = new System.Drawing.Size(959, 419);
            this.ajout_util.TabIndex = 1;
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.label3);
            this.panelControl3.Controls.Add(this.treeDroits);
            this.panelControl3.Controls.Add(this.enregistrer_droit);
            this.panelControl3.Controls.Add(this.dgvDroits);
            this.panelControl3.Controls.Add(this.splitterControl1);
            this.panelControl3.Enabled = false;
            this.panelControl3.Location = new System.Drawing.Point(327, 9);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(627, 403);
            this.panelControl3.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.label3.Location = new System.Drawing.Point(196, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 21);
            this.label3.TabIndex = 12;
            this.label3.Text = "Privileges utilisateur";
            // 
            // treeDroits
            // 
            this.treeDroits.Location = new System.Drawing.Point(13, 87);
            this.treeDroits.Name = "treeDroits";
            treeNode1.Name = "Bien-Categorie";
            treeNode1.Text = "Bien-Categorie";
            treeNode2.Name = "Site-Emplacement";
            treeNode2.Text = "Site-Emplacement";
            treeNode3.Name = "Client-Fournisseur";
            treeNode3.Text = "Client-Fournisseur";
            treeNode4.Name = "Transfert-Cession";
            treeNode4.Text = "Transfert-Cession";
            treeNode5.Name = "Rapports";
            treeNode5.Text = "Rapports";
            treeNode6.Name = "Inventaire";
            treeNode6.Text = "Inventaire";
            treeNode7.Name = "Mise a jour";
            treeNode7.Text = "Mise a jour";
            treeNode8.Name = "Bien-Categorie";
            treeNode8.Text = "Bien-Categorie";
            treeNode9.Name = "Site-Emplacement";
            treeNode9.Text = "Site-Emplacement";
            treeNode10.Name = "Client-Fournisseur";
            treeNode10.Text = "Client-Fournisseur";
            treeNode11.Name = "Transfert-Cession";
            treeNode11.Text = "Transfert-Cession";
            treeNode12.Name = "Rapports";
            treeNode12.Text = "Rapports";
            treeNode13.Name = "Inventaire";
            treeNode13.Text = "Inventaire";
            treeNode14.Name = "Consultation";
            treeNode14.Text = "Consultation";
            treeNode15.Name = "Client-Fournisseur";
            treeNode15.Text = "Client-Fournisseur";
            treeNode16.Name = "Transfert-Cession";
            treeNode16.Text = "Transfert-Cession";
            treeNode17.Name = "Aucun accée";
            treeNode17.Text = "Aucun accée";
            this.treeDroits.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode7,
            treeNode14,
            treeNode17});
            this.treeDroits.Size = new System.Drawing.Size(208, 285);
            this.treeDroits.TabIndex = 3;
            this.treeDroits.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.selectnod);
            // 
            // enregistrer_droit
            // 
            this.enregistrer_droit.Image = global::solution1.Properties.Resources.save3;
            this.enregistrer_droit.Location = new System.Drawing.Point(439, 332);
            this.enregistrer_droit.Name = "enregistrer_droit";
            this.enregistrer_droit.Size = new System.Drawing.Size(95, 35);
            this.enregistrer_droit.TabIndex = 2;
            this.enregistrer_droit.Text = "Privilége";
            this.enregistrer_droit.Click += new System.EventHandler(this.enregistrer_droit_Click);
            // 
            // dgvDroits
            // 
            this.dgvDroits.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvDroits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDroits.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Privilége,
            this.droit,
            this.Supprimer});
            this.dgvDroits.Location = new System.Drawing.Point(243, 89);
            this.dgvDroits.Name = "dgvDroits";
            this.dgvDroits.Size = new System.Drawing.Size(379, 196);
            this.dgvDroits.TabIndex = 1;
            this.dgvDroits.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_utilisateur_CellContentClick);
            // 
            // Privilége
            // 
            this.Privilége.HeaderText = "Privilége";
            this.Privilége.MaxInputLength = 3276;
            this.Privilége.Name = "Privilége";
            this.Privilége.Width = 145;
            // 
            // droit
            // 
            this.droit.HeaderText = "Droit";
            this.droit.Name = "droit";
            this.droit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.droit.Width = 145;
            // 
            // Supprimer
            // 
            this.Supprimer.HeaderText = "Sup";
            this.Supprimer.Name = "Supprimer";
            this.Supprimer.Width = 30;
            // 
            // splitterControl1
            // 
            this.splitterControl1.Location = new System.Drawing.Point(2, 2);
            this.splitterControl1.Name = "splitterControl1";
            this.splitterControl1.Size = new System.Drawing.Size(5, 399);
            this.splitterControl1.TabIndex = 0;
            this.splitterControl1.TabStop = false;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.label2);
            this.panelControl2.Controls.Add(this.check_admin);
            this.panelControl2.Controls.Add(this.Password);
            this.panelControl2.Controls.Add(this.Login);
            this.panelControl2.Controls.Add(this.Prenom);
            this.panelControl2.Controls.Add(this.Nom);
            this.panelControl2.Controls.Add(this.panalpassword);
            this.panelControl2.Controls.Add(this.panalLogin);
            this.panelControl2.Controls.Add(this.panalPrenom);
            this.panelControl2.Controls.Add(this.panalNom);
            this.panelControl2.Controls.Add(this.valider_enregistrement);
            this.panelControl2.Controls.Add(this.splitterControl2);
            this.panelControl2.Location = new System.Drawing.Point(7, 9);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(315, 405);
            this.panelControl2.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.label2.Location = new System.Drawing.Point(96, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Information utilisateur";
            // 
            // check_admin
            // 
            this.check_admin.Location = new System.Drawing.Point(44, 251);
            this.check_admin.Name = "check_admin";
            this.check_admin.Properties.Caption = "Administrateur";
            this.check_admin.Size = new System.Drawing.Size(106, 19);
            this.check_admin.TabIndex = 11;
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(106, 188);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(191, 20);
            this.Password.TabIndex = 10;
            // 
            // Login
            // 
            this.Login.Location = new System.Drawing.Point(106, 155);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(191, 20);
            this.Login.TabIndex = 9;
            // 
            // Prenom
            // 
            this.Prenom.Location = new System.Drawing.Point(106, 124);
            this.Prenom.Name = "Prenom";
            this.Prenom.Size = new System.Drawing.Size(191, 20);
            this.Prenom.TabIndex = 8;
            // 
            // Nom
            // 
            this.Nom.Location = new System.Drawing.Point(106, 87);
            this.Nom.Name = "Nom";
            this.Nom.Size = new System.Drawing.Size(191, 20);
            this.Nom.TabIndex = 7;
            // 
            // panalpassword
            // 
            this.panalpassword.Location = new System.Drawing.Point(44, 188);
            this.panalpassword.Name = "panalpassword";
            this.panalpassword.Size = new System.Drawing.Size(46, 13);
            this.panalpassword.TabIndex = 5;
            this.panalpassword.Text = "Password";
            // 
            // panalLogin
            // 
            this.panalLogin.Location = new System.Drawing.Point(44, 155);
            this.panalLogin.Name = "panalLogin";
            this.panalLogin.Size = new System.Drawing.Size(25, 13);
            this.panalLogin.TabIndex = 4;
            this.panalLogin.Text = "Login";
            // 
            // panalPrenom
            // 
            this.panalPrenom.Location = new System.Drawing.Point(44, 124);
            this.panalPrenom.Name = "panalPrenom";
            this.panalPrenom.Size = new System.Drawing.Size(36, 13);
            this.panalPrenom.TabIndex = 3;
            this.panalPrenom.Text = "Prenom";
            // 
            // panalNom
            // 
            this.panalNom.Location = new System.Drawing.Point(44, 87);
            this.panalNom.Name = "panalNom";
            this.panalNom.Size = new System.Drawing.Size(21, 13);
            this.panalNom.TabIndex = 2;
            this.panalNom.Text = "Nom";
            // 
            // valider_enregistrement
            // 
            this.valider_enregistrement.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.valider_enregistrement.Image = global::solution1.Properties.Resources.db_add;
            this.valider_enregistrement.ImeMode = System.Windows.Forms.ImeMode.On;
            this.valider_enregistrement.Location = new System.Drawing.Point(191, 307);
            this.valider_enregistrement.Name = "valider_enregistrement";
            this.valider_enregistrement.Size = new System.Drawing.Size(95, 35);
            this.valider_enregistrement.TabIndex = 1;
            this.valider_enregistrement.Text = "Valider";
            this.valider_enregistrement.Click += new System.EventHandler(this.valider_enregistrement_Click);
            // 
            // splitterControl2
            // 
            this.splitterControl2.Location = new System.Drawing.Point(2, 2);
            this.splitterControl2.Name = "splitterControl2";
            this.splitterControl2.Size = new System.Drawing.Size(5, 401);
            this.splitterControl2.TabIndex = 0;
            this.splitterControl2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F);
            this.label1.Location = new System.Drawing.Point(311, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ajouter utilisateur";
            // 
            // ajout_utilisateur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ajout_util);
            this.Name = "ajout_utilisateur";
            this.Size = new System.Drawing.Size(1001, 510);
            this.Load += new System.EventHandler(this.ajout_utilisateur_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ajout_util)).EndInit();
            this.ajout_util.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            this.panelControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDroits)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.check_admin.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Password.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Login.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Prenom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nom.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl3;
        private System.Windows.Forms.TreeView treeDroits;
        private DevExpress.XtraEditors.SimpleButton enregistrer_droit;
        private DevExpress.XtraEditors.SplitterControl splitterControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.CheckEdit check_admin;
        private DevExpress.XtraEditors.LabelControl panalpassword;
        private DevExpress.XtraEditors.LabelControl panalLogin;
        private DevExpress.XtraEditors.LabelControl panalPrenom;
        private DevExpress.XtraEditors.LabelControl panalNom;
        private DevExpress.XtraEditors.SimpleButton valider_enregistrement;
        private DevExpress.XtraEditors.SplitterControl splitterControl2;
        public DevExpress.XtraEditors.PanelControl ajout_util;
        private System.Windows.Forms.DataGridViewTextBoxColumn Privilége;
        private System.Windows.Forms.DataGridViewTextBoxColumn droit;
        private System.Windows.Forms.DataGridViewButtonColumn Supprimer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        public DevExpress.XtraEditors.TextEdit Password;
        public DevExpress.XtraEditors.TextEdit Login;
        public DevExpress.XtraEditors.TextEdit Prenom;
        public DevExpress.XtraEditors.TextEdit Nom;
        public System.Windows.Forms.DataGridView dgvDroits;
    }
}
