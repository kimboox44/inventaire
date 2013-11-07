namespace solution1.gestion_utilisateur
{
    partial class modifier_utilisateur
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
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("Bien-Categorie");
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("Site-Emplacement");
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("Client-Fournisseur");
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("Transfert-Cession");
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("Rapports");
            System.Windows.Forms.TreeNode treeNode23 = new System.Windows.Forms.TreeNode("Inventaire");
            System.Windows.Forms.TreeNode treeNode24 = new System.Windows.Forms.TreeNode("Mise a jour", new System.Windows.Forms.TreeNode[] {
            treeNode18,
            treeNode19,
            treeNode20,
            treeNode21,
            treeNode22,
            treeNode23});
            System.Windows.Forms.TreeNode treeNode25 = new System.Windows.Forms.TreeNode("Bien-Categorie");
            System.Windows.Forms.TreeNode treeNode26 = new System.Windows.Forms.TreeNode("Site-Emplacement");
            System.Windows.Forms.TreeNode treeNode27 = new System.Windows.Forms.TreeNode("Client-Fournisseur");
            System.Windows.Forms.TreeNode treeNode28 = new System.Windows.Forms.TreeNode("Transfert-Cession");
            System.Windows.Forms.TreeNode treeNode29 = new System.Windows.Forms.TreeNode("Rapports");
            System.Windows.Forms.TreeNode treeNode30 = new System.Windows.Forms.TreeNode("Inventaire");
            System.Windows.Forms.TreeNode treeNode31 = new System.Windows.Forms.TreeNode("Consultation", new System.Windows.Forms.TreeNode[] {
            treeNode25,
            treeNode26,
            treeNode27,
            treeNode28,
            treeNode29,
            treeNode30});
            System.Windows.Forms.TreeNode treeNode32 = new System.Windows.Forms.TreeNode("Client-Fournisseur");
            System.Windows.Forms.TreeNode treeNode33 = new System.Windows.Forms.TreeNode("Transfert-Cession");
            System.Windows.Forms.TreeNode treeNode34 = new System.Windows.Forms.TreeNode("Aucun accée", new System.Windows.Forms.TreeNode[] {
            treeNode32,
            treeNode33});
            this.ajout_util = new DevExpress.XtraEditors.PanelControl();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.label3 = new System.Windows.Forms.Label();
            this.treeDroits = new System.Windows.Forms.TreeView();
            this.enregistrer_droit = new DevExpress.XtraEditors.SimpleButton();
            this.dgvDroits = new System.Windows.Forms.DataGridView();
            this.splitterControl1 = new DevExpress.XtraEditors.SplitterControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.label2 = new System.Windows.Forms.Label();
            this.check_admin = new DevExpress.XtraEditors.CheckEdit();
            this.Password = new DevExpress.XtraEditors.TextEdit();
            this.Login = new DevExpress.XtraEditors.TextEdit();
            this.Prenom = new DevExpress.XtraEditors.TextEdit();
            this.NOM = new DevExpress.XtraEditors.TextEdit();
            this.panalpassword = new DevExpress.XtraEditors.LabelControl();
            this.panalLogin = new DevExpress.XtraEditors.LabelControl();
            this.panalPrenom = new DevExpress.XtraEditors.LabelControl();
            this.panalNom = new DevExpress.XtraEditors.LabelControl();
            this.Modifier_enregistrement = new DevExpress.XtraEditors.SimpleButton();
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
            ((System.ComponentModel.ISupportInitialize)(this.NOM.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // ajout_util
            // 
            this.ajout_util.Controls.Add(this.panelControl3);
            this.ajout_util.Controls.Add(this.panelControl2);
            this.ajout_util.Location = new System.Drawing.Point(28, 55);
            this.ajout_util.LookAndFeel.SkinName = "Office 2007 Black";
            this.ajout_util.Name = "ajout_util";
            this.ajout_util.Size = new System.Drawing.Size(989, 468);
            this.ajout_util.TabIndex = 2;
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.label3);
            this.panelControl3.Controls.Add(this.treeDroits);
            this.panelControl3.Controls.Add(this.enregistrer_droit);
            this.panelControl3.Controls.Add(this.dgvDroits);
            this.panelControl3.Controls.Add(this.splitterControl1);
            this.panelControl3.Location = new System.Drawing.Point(355, 5);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(627, 456);
            this.panelControl3.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.label3.Location = new System.Drawing.Point(196, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 21);
            this.label3.TabIndex = 12;
            this.label3.Text = "Privileges utilisateur";
            // 
            // treeDroits
            // 
            this.treeDroits.Location = new System.Drawing.Point(21, 100);
            this.treeDroits.Name = "treeDroits";
            treeNode18.Name = "Bien-Categorie";
            treeNode18.Text = "Bien-Categorie";
            treeNode19.Name = "Site-Emplacement";
            treeNode19.Text = "Site-Emplacement";
            treeNode20.Name = "Client-Fournisseur";
            treeNode20.Text = "Client-Fournisseur";
            treeNode21.Name = "Transfert-Cession";
            treeNode21.Text = "Transfert-Cession";
            treeNode22.Name = "Rapports";
            treeNode22.Text = "Rapports";
            treeNode23.Name = "Inventaire";
            treeNode23.Text = "Inventaire";
            treeNode24.Name = "Mise a jour";
            treeNode24.Text = "Mise a jour";
            treeNode25.Name = "Bien-Categorie";
            treeNode25.Text = "Bien-Categorie";
            treeNode26.Name = "Site-Emplacement";
            treeNode26.Text = "Site-Emplacement";
            treeNode27.Name = "Client-Fournisseur";
            treeNode27.Text = "Client-Fournisseur";
            treeNode28.Name = "Transfert-Cession";
            treeNode28.Text = "Transfert-Cession";
            treeNode29.Name = "Rapports";
            treeNode29.Text = "Rapports";
            treeNode30.Name = "Inventaire";
            treeNode30.Text = "Inventaire";
            treeNode31.Name = "Consultation";
            treeNode31.Text = "Consultation";
            treeNode32.Name = "Client-Fournisseur";
            treeNode32.Text = "Client-Fournisseur";
            treeNode33.Name = "Transfert-Cession";
            treeNode33.Text = "Transfert-Cession";
            treeNode34.Name = "Aucun accée";
            treeNode34.Text = "Aucun accée";
            this.treeDroits.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode24,
            treeNode31,
            treeNode34});
            this.treeDroits.Size = new System.Drawing.Size(208, 307);
            this.treeDroits.TabIndex = 3;
            // 
            // enregistrer_droit
            // 
            this.enregistrer_droit.Location = new System.Drawing.Point(412, 375);
            this.enregistrer_droit.Name = "enregistrer_droit";
            this.enregistrer_droit.Size = new System.Drawing.Size(105, 25);
            this.enregistrer_droit.TabIndex = 2;
            this.enregistrer_droit.Text = "Modifier privilége";
            // 
            // dgvDroits
            // 
            this.dgvDroits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDroits.Location = new System.Drawing.Point(257, 100);
            this.dgvDroits.Name = "dgvDroits";
            this.dgvDroits.Size = new System.Drawing.Size(365, 211);
            this.dgvDroits.TabIndex = 1;
            this.dgvDroits.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDroits_CellContentClick);
            this.dgvDroits.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDroits_CellContentClick);
            // 
            // splitterControl1
            // 
            this.splitterControl1.Location = new System.Drawing.Point(2, 2);
            this.splitterControl1.Name = "splitterControl1";
            this.splitterControl1.Size = new System.Drawing.Size(5, 452);
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
            this.panelControl2.Controls.Add(this.NOM);
            this.panelControl2.Controls.Add(this.panalpassword);
            this.panelControl2.Controls.Add(this.panalLogin);
            this.panelControl2.Controls.Add(this.panalPrenom);
            this.panelControl2.Controls.Add(this.panalNom);
            this.panelControl2.Controls.Add(this.Modifier_enregistrement);
            this.panelControl2.Controls.Add(this.splitterControl2);
            this.panelControl2.Location = new System.Drawing.Point(7, 5);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(344, 456);
            this.panelControl2.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.label2.Location = new System.Drawing.Point(90, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Informations utilisateur";
            // 
            // check_admin
            // 
            this.check_admin.Location = new System.Drawing.Point(37, 281);
            this.check_admin.Name = "check_admin";
            this.check_admin.Properties.Caption = "Administrateur";
            this.check_admin.Size = new System.Drawing.Size(106, 19);
            this.check_admin.TabIndex = 11;
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(99, 213);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(191, 20);
            this.Password.TabIndex = 10;
            // 
            // Login
            // 
            this.Login.Location = new System.Drawing.Point(99, 178);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(191, 20);
            this.Login.TabIndex = 9;
            // 
            // Prenom
            // 
            this.Prenom.Location = new System.Drawing.Point(99, 144);
            this.Prenom.Name = "Prenom";
            this.Prenom.Size = new System.Drawing.Size(191, 20);
            this.Prenom.TabIndex = 8;
            // 
            // NOM
            // 
            this.NOM.Location = new System.Drawing.Point(99, 104);
            this.NOM.Name = "NOM";
            this.NOM.Size = new System.Drawing.Size(191, 20);
            this.NOM.TabIndex = 7;
            // 
            // panalpassword
            // 
            this.panalpassword.Location = new System.Drawing.Point(37, 213);
            this.panalpassword.Name = "panalpassword";
            this.panalpassword.Size = new System.Drawing.Size(46, 13);
            this.panalpassword.TabIndex = 5;
            this.panalpassword.Text = "Password";
            // 
            // panalLogin
            // 
            this.panalLogin.Location = new System.Drawing.Point(37, 178);
            this.panalLogin.Name = "panalLogin";
            this.panalLogin.Size = new System.Drawing.Size(25, 13);
            this.panalLogin.TabIndex = 4;
            this.panalLogin.Text = "Login";
            // 
            // panalPrenom
            // 
            this.panalPrenom.Location = new System.Drawing.Point(37, 144);
            this.panalPrenom.Name = "panalPrenom";
            this.panalPrenom.Size = new System.Drawing.Size(36, 13);
            this.panalPrenom.TabIndex = 3;
            this.panalPrenom.Text = "Prenom";
            // 
            // panalNom
            // 
            this.panalNom.Location = new System.Drawing.Point(37, 104);
            this.panalNom.Name = "panalNom";
            this.panalNom.Size = new System.Drawing.Size(21, 13);
            this.panalNom.TabIndex = 2;
            this.panalNom.Text = "Nom";
            // 
            // Modifier_enregistrement
            // 
            this.Modifier_enregistrement.Location = new System.Drawing.Point(205, 341);
            this.Modifier_enregistrement.Name = "Modifier_enregistrement";
            this.Modifier_enregistrement.Size = new System.Drawing.Size(78, 25);
            this.Modifier_enregistrement.TabIndex = 1;
            this.Modifier_enregistrement.Text = "Modifier";
            this.Modifier_enregistrement.Click += new System.EventHandler(this.Modifier_enregistrement_Click);
            // 
            // splitterControl2
            // 
            this.splitterControl2.Location = new System.Drawing.Point(2, 2);
            this.splitterControl2.Name = "splitterControl2";
            this.splitterControl2.Size = new System.Drawing.Size(5, 452);
            this.splitterControl2.TabIndex = 0;
            this.splitterControl2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F);
            this.label1.Location = new System.Drawing.Point(317, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 27);
            this.label1.TabIndex = 3;
            this.label1.Text = "Modifier utilisateur";
            // 
            // modifier_utilisateur
            // 
            this.Appearance.Font = new System.Drawing.Font("Times New Roman", 8.25F);
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ajout_util);
            this.Name = "modifier_utilisateur";
            this.Size = new System.Drawing.Size(1038, 533);
            this.Load += new System.EventHandler(this.modifier_utilisateur_Load);
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
            ((System.ComponentModel.ISupportInitialize)(this.NOM.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public DevExpress.XtraEditors.PanelControl ajout_util;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private System.Windows.Forms.TreeView treeDroits;
        private DevExpress.XtraEditors.SimpleButton enregistrer_droit;
        private System.Windows.Forms.DataGridView dgvDroits;
        private DevExpress.XtraEditors.SplitterControl splitterControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.CheckEdit check_admin;
        private DevExpress.XtraEditors.TextEdit Password;
        private DevExpress.XtraEditors.TextEdit Login;
        private DevExpress.XtraEditors.TextEdit Prenom;
        private DevExpress.XtraEditors.TextEdit NOM;
        private DevExpress.XtraEditors.LabelControl panalpassword;
        private DevExpress.XtraEditors.LabelControl panalLogin;
        private DevExpress.XtraEditors.LabelControl panalPrenom;
        private DevExpress.XtraEditors.LabelControl panalNom;
        private DevExpress.XtraEditors.SimpleButton Modifier_enregistrement;
        private DevExpress.XtraEditors.SplitterControl splitterControl2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}
