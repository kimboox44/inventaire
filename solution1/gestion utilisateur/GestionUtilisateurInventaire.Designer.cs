namespace solution1
{
    partial class GestionUtilisateurInventaire
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionUtilisateurInventaire));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.dGVUtilisateur = new System.Windows.Forms.DataGridView();
            this.ColumnIdUtilisateur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPseudo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnMotDePasse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAdministrateur = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ColumnSupprimerUtilisateur = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dGVInventaire = new System.Windows.Forms.DataGridView();
            this.ColumnAvoirAcces = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ColumnIdentifiant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSupprimerInventaire = new System.Windows.Forms.DataGridViewButtonColumn();
            this.gBUtilisateurs = new System.Windows.Forms.GroupBox();
            this.gBInventaires = new System.Windows.Forms.GroupBox();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVUtilisateur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVInventaire)).BeginInit();
            this.gBUtilisateurs.SuspendLayout();
            this.gBInventaires.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 476);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(960, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(434, 17);
            this.toolStripStatusLabel1.Text = "Pour modifier le pseudo ou le mot de passe, sélectionnez une cellule, puis appuye" +
                "z sur F2";
            // 
            // dGVUtilisateur
            // 
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dGVUtilisateur.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dGVUtilisateur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVUtilisateur.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnIdUtilisateur,
            this.ColumnPseudo,
            this.ColumnMotDePasse,
            this.ColumnAdministrateur,
            this.ColumnSupprimerUtilisateur});
            this.dGVUtilisateur.Location = new System.Drawing.Point(6, 19);
            this.dGVUtilisateur.MultiSelect = false;
            this.dGVUtilisateur.Name = "dGVUtilisateur";
            this.dGVUtilisateur.RowHeadersVisible = false;
            this.dGVUtilisateur.Size = new System.Drawing.Size(372, 425);
            this.dGVUtilisateur.TabIndex = 1;
            this.dGVUtilisateur.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVUtilisateur_CellClick);
            this.dGVUtilisateur.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVUtilisateur_CellContentClick_1);
            this.dGVUtilisateur.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVUtilisateur_CellDoubleClick);
            this.dGVUtilisateur.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dGVUtilisateur_CellMouseClick);
            this.dGVUtilisateur.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dGVUtilisateur_CellMouseUp);
            this.dGVUtilisateur.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dGVUtilisateur_CellPainting);
            this.dGVUtilisateur.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVUtilisateur_CellValueChanged);
            this.dGVUtilisateur.CellValuePushed += new System.Windows.Forms.DataGridViewCellValueEventHandler(this.dGVUtilisateur_CellValuePushed);
            this.dGVUtilisateur.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVUtilisateur_RowEnter);
            this.dGVUtilisateur.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dGVUtilisateur_RowsAdded);
            this.dGVUtilisateur.SelectionChanged += new System.EventHandler(this.dGVUtilisateur_SelectionChanged);
            // 
            // ColumnIdUtilisateur
            // 
            this.ColumnIdUtilisateur.HeaderText = "Identifiant";
            this.ColumnIdUtilisateur.Name = "ColumnIdUtilisateur";
            this.ColumnIdUtilisateur.Visible = false;
            // 
            // ColumnPseudo
            // 
            this.ColumnPseudo.HeaderText = "Pseudo";
            this.ColumnPseudo.Name = "ColumnPseudo";
            this.ColumnPseudo.Width = 122;
            // 
            // ColumnMotDePasse
            // 
            this.ColumnMotDePasse.HeaderText = "Mot de passe";
            this.ColumnMotDePasse.Name = "ColumnMotDePasse";
            this.ColumnMotDePasse.Width = 122;
            // 
            // ColumnAdministrateur
            // 
            this.ColumnAdministrateur.HeaderText = "Administrateur";
            this.ColumnAdministrateur.Name = "ColumnAdministrateur";
            this.ColumnAdministrateur.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnAdministrateur.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // ColumnSupprimerUtilisateur
            // 
            this.ColumnSupprimerUtilisateur.HeaderText = "";
            this.ColumnSupprimerUtilisateur.Name = "ColumnSupprimerUtilisateur";
            this.ColumnSupprimerUtilisateur.Width = 25;
            // 
            // dGVInventaire
            // 
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.dGVInventaire.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dGVInventaire.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVInventaire.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnAvoirAcces,
            this.ColumnIdentifiant,
            this.ColumnNom,
            this.ColumnDate,
            this.ColumnSupprimerInventaire});
            this.dGVInventaire.Location = new System.Drawing.Point(6, 19);
            this.dGVInventaire.MultiSelect = false;
            this.dGVInventaire.Name = "dGVInventaire";
            this.dGVInventaire.RowHeadersVisible = false;
            this.dGVInventaire.Size = new System.Drawing.Size(530, 425);
            this.dGVInventaire.TabIndex = 2;
            this.dGVInventaire.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVInventaire_CellClick);
            this.dGVInventaire.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dGVInventaire_CellPainting);
            this.dGVInventaire.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVInventaire_CellValueChanged);
            this.dGVInventaire.SelectionChanged += new System.EventHandler(this.dGVInventaire_SelectionChanged);
            // 
            // ColumnAvoirAcces
            // 
            this.ColumnAvoirAcces.HeaderText = "";
            this.ColumnAvoirAcces.Name = "ColumnAvoirAcces";
            this.ColumnAvoirAcces.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnAvoirAcces.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ColumnAvoirAcces.Width = 25;
            // 
            // ColumnIdentifiant
            // 
            this.ColumnIdentifiant.HeaderText = "Identifiant";
            this.ColumnIdentifiant.Name = "ColumnIdentifiant";
            this.ColumnIdentifiant.ReadOnly = true;
            this.ColumnIdentifiant.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnIdentifiant.Width = 230;
            // 
            // ColumnNom
            // 
            this.ColumnNom.HeaderText = "Nom";
            this.ColumnNom.Name = "ColumnNom";
            this.ColumnNom.Width = 130;
            // 
            // ColumnDate
            // 
            this.ColumnDate.HeaderText = "Date";
            this.ColumnDate.Name = "ColumnDate";
            this.ColumnDate.ReadOnly = true;
            this.ColumnDate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnDate.Width = 116;
            // 
            // ColumnSupprimerInventaire
            // 
            this.ColumnSupprimerInventaire.HeaderText = "";
            this.ColumnSupprimerInventaire.Name = "ColumnSupprimerInventaire";
            this.ColumnSupprimerInventaire.Width = 25;
            // 
            // gBUtilisateurs
            // 
            this.gBUtilisateurs.Controls.Add(this.dGVUtilisateur);
            this.gBUtilisateurs.Location = new System.Drawing.Point(13, 12);
            this.gBUtilisateurs.Name = "gBUtilisateurs";
            this.gBUtilisateurs.Size = new System.Drawing.Size(384, 450);
            this.gBUtilisateurs.TabIndex = 5;
            this.gBUtilisateurs.TabStop = false;
            this.gBUtilisateurs.Text = "Utilisateurs";
            // 
            // gBInventaires
            // 
            this.gBInventaires.Controls.Add(this.dGVInventaire);
            this.gBInventaires.Location = new System.Drawing.Point(403, 12);
            this.gBInventaires.Name = "gBInventaires";
            this.gBInventaires.Size = new System.Drawing.Size(542, 450);
            this.gBInventaires.TabIndex = 6;
            this.gBInventaires.TabStop = false;
            this.gBInventaires.Text = "Inventaires";
            // 
            // GestionUtilisateurInventaire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 498);
            this.Controls.Add(this.gBInventaires);
            this.Controls.Add(this.gBUtilisateurs);
            this.Controls.Add(this.statusStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "GestionUtilisateurInventaire";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion des utilisateurs";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVUtilisateur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVInventaire)).EndInit();
            this.gBUtilisateurs.ResumeLayout(false);
            this.gBInventaires.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.DataGridView dGVUtilisateur;
        private System.Windows.Forms.DataGridView dGVInventaire;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnIdUtilisateur;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPseudo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnMotDePasse;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColumnAdministrateur;
        private System.Windows.Forms.DataGridViewButtonColumn ColumnSupprimerUtilisateur;
        private System.Windows.Forms.GroupBox gBUtilisateurs;
        private System.Windows.Forms.GroupBox gBInventaires;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColumnAvoirAcces;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnIdentifiant;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNom;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDate;
        private System.Windows.Forms.DataGridViewButtonColumn ColumnSupprimerInventaire;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}