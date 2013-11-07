namespace solution1
{
    partial class AjouterUser
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Site\\Emplacement");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Bien\\Catégorie");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Client\\Fournisseur");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Transfert\\Cession");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Rapports");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Mises à Jour", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5});
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Site\\Emplacement");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Bien\\Catégorie");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Cleint\\Fournisseur");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Transfert\\Cession");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Rapports");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Consultation", new System.Windows.Forms.TreeNode[] {
            treeNode7,
            treeNode8,
            treeNode9,
            treeNode10,
            treeNode11});
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Cleint\\Fournisseur");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Transfert\\Cession");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Accées refuser", new System.Windows.Forms.TreeNode[] {
            treeNode13,
            treeNode14});
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.chekAdmin = new DevExpress.XtraEditors.CheckEdit();
            this.butvalidUser = new DevExpress.XtraEditors.SimpleButton();
            this.txtMotPasse = new DevExpress.XtraEditors.TextEdit();
            this.txtLogin = new DevExpress.XtraEditors.TextEdit();
            this.txtPrenom = new DevExpress.XtraEditors.TextEdit();
            this.txtNom = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.butvalidDroit = new DevExpress.XtraEditors.SimpleButton();
            this.dgvDroits = new System.Windows.Forms.DataGridView();
            this.DroitSur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Previlege = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.treeDroits = new System.Windows.Forms.TreeView();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chekAdmin.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMotPasse.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLogin.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrenom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDroits)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.splitContainerControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1318, 603);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.groupControl1_Paint);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Georgia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl1.Location = new System.Drawing.Point(17, 26);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(184, 18);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "Ajouter un Utilisateur";
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Location = new System.Drawing.Point(32, 66);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.splitContainerControl1.Panel1.Controls.Add(this.chekAdmin);
            this.splitContainerControl1.Panel1.Controls.Add(this.butvalidUser);
            this.splitContainerControl1.Panel1.Controls.Add(this.txtMotPasse);
            this.splitContainerControl1.Panel1.Controls.Add(this.txtLogin);
            this.splitContainerControl1.Panel1.Controls.Add(this.txtPrenom);
            this.splitContainerControl1.Panel1.Controls.Add(this.txtNom);
            this.splitContainerControl1.Panel1.Controls.Add(this.labelControl6);
            this.splitContainerControl1.Panel1.Controls.Add(this.labelControl5);
            this.splitContainerControl1.Panel1.Controls.Add(this.labelControl4);
            this.splitContainerControl1.Panel1.Controls.Add(this.labelControl3);
            this.splitContainerControl1.Panel1.Controls.Add(this.labelControl2);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.splitContainerControl1.Panel2.Controls.Add(this.butvalidDroit);
            this.splitContainerControl1.Panel2.Controls.Add(this.dgvDroits);
            this.splitContainerControl1.Panel2.Controls.Add(this.treeDroits);
            this.splitContainerControl1.Panel2.Controls.Add(this.labelControl7);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1222, 490);
            this.splitContainerControl1.SplitterPosition = 424;
            this.splitContainerControl1.TabIndex = 0;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // chekAdmin
            // 
            this.chekAdmin.Location = new System.Drawing.Point(20, 285);
            this.chekAdmin.Name = "chekAdmin";
            this.chekAdmin.Properties.Caption = "Definir comme Administrateur";
            this.chekAdmin.Size = new System.Drawing.Size(225, 19);
            this.chekAdmin.TabIndex = 10;
            // 
            // butvalidUser
            // 
            this.butvalidUser.Location = new System.Drawing.Point(266, 395);
            this.butvalidUser.Name = "butvalidUser";
            this.butvalidUser.Size = new System.Drawing.Size(138, 35);
            this.butvalidUser.TabIndex = 9;
            this.butvalidUser.Text = "Valider";
            this.butvalidUser.Click += new System.EventHandler(this.butvalidUser_Click);
            // 
            // txtMotPasse
            // 
            this.txtMotPasse.Location = new System.Drawing.Point(136, 227);
            this.txtMotPasse.Name = "txtMotPasse";
            this.txtMotPasse.Size = new System.Drawing.Size(222, 20);
            this.txtMotPasse.TabIndex = 8;
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(136, 182);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(222, 20);
            this.txtLogin.TabIndex = 7;
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(136, 144);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(222, 20);
            this.txtPrenom.TabIndex = 6;
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(136, 102);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(222, 20);
            this.txtNom.TabIndex = 5;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl6.Location = new System.Drawing.Point(22, 230);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(67, 13);
            this.labelControl6.TabIndex = 4;
            this.labelControl6.Text = "Mot de Passe ";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl5.Location = new System.Drawing.Point(22, 185);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(74, 13);
            this.labelControl5.TabIndex = 3;
            this.labelControl5.Text = "Login Utlisateur";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl4.Location = new System.Drawing.Point(22, 147);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(87, 13);
            this.labelControl4.TabIndex = 2;
            this.labelControl4.Text = "Prenom Utilisateur";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl3.Location = new System.Drawing.Point(32, 105);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(72, 13);
            this.labelControl3.TabIndex = 1;
            this.labelControl3.Text = "Nom Utilisateur";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Location = new System.Drawing.Point(70, 19);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(247, 18);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Informations sur l\'Utilisateur";
            // 
            // butvalidDroit
            // 
            this.butvalidDroit.Enabled = false;
            this.butvalidDroit.Location = new System.Drawing.Point(578, 395);
            this.butvalidDroit.Name = "butvalidDroit";
            this.butvalidDroit.Size = new System.Drawing.Size(142, 34);
            this.butvalidDroit.TabIndex = 4;
            this.butvalidDroit.Text = "Valider Droits";
            this.butvalidDroit.Click += new System.EventHandler(this.butvalidDroit_Click);
            // 
            // dgvDroits
            // 
            this.dgvDroits.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDroits.BackgroundColor = System.Drawing.Color.Gray;
            this.dgvDroits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDroits.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DroitSur,
            this.Previlege});
            this.dgvDroits.Enabled = false;
            this.dgvDroits.Location = new System.Drawing.Point(340, 69);
            this.dgvDroits.Name = "dgvDroits";
            this.dgvDroits.Size = new System.Drawing.Size(372, 296);
            this.dgvDroits.TabIndex = 3;
            this.dgvDroits.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.deletrow);
            // 
            // DroitSur
            // 
            this.DroitSur.HeaderText = "Droit Sur";
            this.DroitSur.Name = "DroitSur";
            // 
            // Previlege
            // 
            this.Previlege.HeaderText = "Previlége";
            this.Previlege.Name = "Previlege";
            // 
            // treeDroits
            // 
            this.treeDroits.Enabled = false;
            this.treeDroits.Location = new System.Drawing.Point(21, 69);
            this.treeDroits.Name = "treeDroits";
            treeNode1.Name = "Nœud1";
            treeNode1.Text = "Site\\Emplacement";
            treeNode2.Name = "Nœud2";
            treeNode2.Text = "Bien\\Catégorie";
            treeNode3.Name = "Nœud3";
            treeNode3.Text = "Client\\Fournisseur";
            treeNode4.Name = "Nœud4";
            treeNode4.Text = "Transfert\\Cession";
            treeNode5.Name = "Nœud5";
            treeNode5.Text = "Rapports";
            treeNode6.Name = "Nœud0";
            treeNode6.Text = "Mises à Jour";
            treeNode7.Name = "Nœud9";
            treeNode7.Text = "Site\\Emplacement";
            treeNode8.Name = "Nœud10";
            treeNode8.Text = "Bien\\Catégorie";
            treeNode9.Name = "Nœud11";
            treeNode9.Text = "Cleint\\Fournisseur";
            treeNode10.Name = "Nœud12";
            treeNode10.Text = "Transfert\\Cession";
            treeNode11.Name = "Nœud13";
            treeNode11.Text = "Rapports";
            treeNode12.Name = "Nœud8";
            treeNode12.Text = "Consultation";
            treeNode13.Name = "Nœud1";
            treeNode13.Text = "Cleint\\Fournisseur";
            treeNode14.Name = "Nœud2";
            treeNode14.Text = "Transfert\\Cession";
            treeNode15.Name = "Nœud0";
            treeNode15.Text = "Accées refuser";
            this.treeDroits.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode6,
            treeNode12,
            treeNode15});
            this.treeDroits.Size = new System.Drawing.Size(261, 296);
            this.treeDroits.TabIndex = 2;
            this.treeDroits.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.selectnod);
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Location = new System.Drawing.Point(289, 14);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(274, 18);
            this.labelControl7.TabIndex = 1;
            this.labelControl7.Text = "Definition des Droits Utilisateurs";
            // 
            // AjouterUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupControl1);
            this.Name = "AjouterUser";
            this.Size = new System.Drawing.Size(1318, 603);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chekAdmin.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMotPasse.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLogin.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrenom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDroits)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton butvalidUser;
        private DevExpress.XtraEditors.TextEdit txtMotPasse;
        private DevExpress.XtraEditors.TextEdit txtLogin;
        private DevExpress.XtraEditors.TextEdit txtPrenom;
        private DevExpress.XtraEditors.TextEdit txtNom;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.CheckEdit chekAdmin;
        private System.Windows.Forms.DataGridView dgvDroits;
        private System.Windows.Forms.TreeView treeDroits;
        private DevExpress.XtraEditors.SimpleButton butvalidDroit;
        private System.Windows.Forms.DataGridViewTextBoxColumn DroitSur;
        private System.Windows.Forms.DataGridViewTextBoxColumn Previlege;
    }
}
