namespace solution1
{
    partial class MAJClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MAJClient));
            this.groupBoxMAJClient = new System.Windows.Forms.GroupBox();
            this.rBRaisonSociale = new System.Windows.Forms.RadioButton();
            this.rBIdentifiant = new System.Windows.Forms.RadioButton();
            this.rBTous = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dGVClients = new System.Windows.Forms.DataGridView();
            this.tBRaisonSociale = new System.Windows.Forms.TextBox();
            this.tBIdentifiant = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.ColumnModifier = new System.Windows.Forms.DataGridViewImageColumn();
            this.ColumnSupprimer = new System.Windows.Forms.DataGridViewImageColumn();
            this.ColumnIdClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSpécialité = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAdresse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnVille = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnWilaya = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPays = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnRegistreDeCommerce = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NIF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTéléphone1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTéléphone2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxMAJClient.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVClients)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxMAJClient
            // 
            this.groupBoxMAJClient.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxMAJClient.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBoxMAJClient.Controls.Add(this.rBRaisonSociale);
            this.groupBoxMAJClient.Controls.Add(this.rBIdentifiant);
            this.groupBoxMAJClient.Controls.Add(this.rBTous);
            this.groupBoxMAJClient.Controls.Add(this.groupBox2);
            this.groupBoxMAJClient.Controls.Add(this.tBRaisonSociale);
            this.groupBoxMAJClient.Controls.Add(this.tBIdentifiant);
            this.groupBoxMAJClient.Location = new System.Drawing.Point(4, 5);
            this.groupBoxMAJClient.Name = "groupBoxMAJClient";
            this.groupBoxMAJClient.Size = new System.Drawing.Size(757, 397);
            this.groupBoxMAJClient.TabIndex = 0;
            this.groupBoxMAJClient.TabStop = false;
            this.groupBoxMAJClient.Text = "Rechercher un client";
            // 
            // rBRaisonSociale
            // 
            this.rBRaisonSociale.AutoSize = true;
            this.rBRaisonSociale.Location = new System.Drawing.Point(14, 65);
            this.rBRaisonSociale.Name = "rBRaisonSociale";
            this.rBRaisonSociale.Size = new System.Drawing.Size(94, 17);
            this.rBRaisonSociale.TabIndex = 28;
            this.rBRaisonSociale.TabStop = true;
            this.rBRaisonSociale.Text = "Raison sociale";
            this.rBRaisonSociale.UseVisualStyleBackColor = true;
            this.rBRaisonSociale.CheckedChanged += new System.EventHandler(this.rBRaisonSociale_CheckedChanged);
            // 
            // rBIdentifiant
            // 
            this.rBIdentifiant.AutoSize = true;
            this.rBIdentifiant.Location = new System.Drawing.Point(14, 42);
            this.rBIdentifiant.Name = "rBIdentifiant";
            this.rBIdentifiant.Size = new System.Drawing.Size(71, 17);
            this.rBIdentifiant.TabIndex = 27;
            this.rBIdentifiant.TabStop = true;
            this.rBIdentifiant.Text = "Identifiant";
            this.rBIdentifiant.UseVisualStyleBackColor = true;
            this.rBIdentifiant.CheckedChanged += new System.EventHandler(this.rBIdentifiant_CheckedChanged);
            // 
            // rBTous
            // 
            this.rBTous.AutoSize = true;
            this.rBTous.Checked = true;
            this.rBTous.Location = new System.Drawing.Point(14, 19);
            this.rBTous.Name = "rBTous";
            this.rBTous.Size = new System.Drawing.Size(49, 17);
            this.rBTous.TabIndex = 26;
            this.rBTous.TabStop = true;
            this.rBTous.Text = "Tous";
            this.rBTous.UseVisualStyleBackColor = true;
            this.rBTous.CheckedChanged += new System.EventHandler(this.rBTous_CheckedChanged);
            this.rBTous.ChangeUICues += new System.Windows.Forms.UICuesEventHandler(this.rBTous_ChangeUICues);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.dGVClients);
            this.groupBox2.Location = new System.Drawing.Point(6, 88);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(745, 303);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Liste des clients";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // dGVClients
            // 
            this.dGVClients.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dGVClients.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dGVClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVClients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnModifier,
            this.ColumnSupprimer,
            this.ColumnIdClient,
            this.ColumnNom,
            this.ColumnSpécialité,
            this.ColumnAdresse,
            this.ColumnVille,
            this.ColumnWilaya,
            this.ColumnPays,
            this.ColumnRegistreDeCommerce,
            this.NIF,
            this.ColumnTéléphone1,
            this.ColumnTéléphone2,
            this.ColumnFax,
            this.ColumnEmail});
            this.dGVClients.Location = new System.Drawing.Point(8, 19);
            this.dGVClients.Name = "dGVClients";
            this.dGVClients.Size = new System.Drawing.Size(731, 278);
            this.dGVClients.TabIndex = 0;
            this.dGVClients.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVClients_CellClick);
            this.dGVClients.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVClients_CellContentClick);
            // 
            // tBRaisonSociale
            // 
            this.tBRaisonSociale.Location = new System.Drawing.Point(141, 62);
            this.tBRaisonSociale.Name = "tBRaisonSociale";
            this.tBRaisonSociale.Size = new System.Drawing.Size(198, 20);
            this.tBRaisonSociale.TabIndex = 24;
            this.tBRaisonSociale.TextChanged += new System.EventHandler(this.tBRaisonSociale_TextChanged);
            this.tBRaisonSociale.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tBRaisonSociale_MouseDown);
            // 
            // tBIdentifiant
            // 
            this.tBIdentifiant.Location = new System.Drawing.Point(141, 39);
            this.tBIdentifiant.Name = "tBIdentifiant";
            this.tBIdentifiant.Size = new System.Drawing.Size(198, 20);
            this.tBIdentifiant.TabIndex = 22;
            this.tBIdentifiant.TextChanged += new System.EventHandler(this.tBIdentifiant_TextChanged);
            this.tBIdentifiant.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tBIdentifiant_MouseDown);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.Gainsboro;
            this.statusStrip1.Location = new System.Drawing.Point(0, 405);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(765, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // ColumnModifier
            // 
            this.ColumnModifier.HeaderText = "";
            this.ColumnModifier.Image = ((System.Drawing.Image)(resources.GetObject("ColumnModifier.Image")));
            this.ColumnModifier.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.ColumnModifier.Name = "ColumnModifier";
            this.ColumnModifier.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnModifier.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ColumnModifier.Width = 25;
            // 
            // ColumnSupprimer
            // 
            this.ColumnSupprimer.HeaderText = "";
            this.ColumnSupprimer.Image = ((System.Drawing.Image)(resources.GetObject("ColumnSupprimer.Image")));
            this.ColumnSupprimer.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.ColumnSupprimer.Name = "ColumnSupprimer";
            this.ColumnSupprimer.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnSupprimer.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ColumnSupprimer.Width = 25;
            // 
            // ColumnIdClient
            // 
            this.ColumnIdClient.HeaderText = "Id";
            this.ColumnIdClient.Name = "ColumnIdClient";
            // 
            // ColumnNom
            // 
            this.ColumnNom.HeaderText = "Nom";
            this.ColumnNom.Name = "ColumnNom";
            // 
            // ColumnSpécialité
            // 
            this.ColumnSpécialité.HeaderText = "Spécialité";
            this.ColumnSpécialité.Name = "ColumnSpécialité";
            // 
            // ColumnAdresse
            // 
            this.ColumnAdresse.HeaderText = "Adresse";
            this.ColumnAdresse.Name = "ColumnAdresse";
            // 
            // ColumnVille
            // 
            this.ColumnVille.HeaderText = "Ville";
            this.ColumnVille.Name = "ColumnVille";
            // 
            // ColumnWilaya
            // 
            this.ColumnWilaya.HeaderText = "Wilaya";
            this.ColumnWilaya.Name = "ColumnWilaya";
            // 
            // ColumnPays
            // 
            this.ColumnPays.HeaderText = "Pays";
            this.ColumnPays.Name = "ColumnPays";
            // 
            // ColumnRegistreDeCommerce
            // 
            this.ColumnRegistreDeCommerce.HeaderText = "Registre de commerce";
            this.ColumnRegistreDeCommerce.Name = "ColumnRegistreDeCommerce";
            // 
            // NIF
            // 
            this.NIF.HeaderText = "ColumnNIF";
            this.NIF.Name = "NIF";
            // 
            // ColumnTéléphone1
            // 
            this.ColumnTéléphone1.HeaderText = "Téléphone1";
            this.ColumnTéléphone1.Name = "ColumnTéléphone1";
            // 
            // ColumnTéléphone2
            // 
            this.ColumnTéléphone2.HeaderText = "Téléphone2";
            this.ColumnTéléphone2.Name = "ColumnTéléphone2";
            // 
            // ColumnFax
            // 
            this.ColumnFax.HeaderText = "Fax";
            this.ColumnFax.Name = "ColumnFax";
            // 
            // ColumnEmail
            // 
            this.ColumnEmail.HeaderText = "Email";
            this.ColumnEmail.Name = "ColumnEmail";
            // 
            // MAJClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 427);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBoxMAJClient);
            this.MaximizeBox = false;
            this.Name = "MAJClient";
            this.Text = "MAJ du fichier client";
            this.Load += new System.EventHandler(this.MAJClient_Load);
            this.groupBoxMAJClient.ResumeLayout(false);
            this.groupBoxMAJClient.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGVClients)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxMAJClient;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dGVClients;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.RadioButton rBRaisonSociale;
        private System.Windows.Forms.RadioButton rBIdentifiant;
        private System.Windows.Forms.RadioButton rBTous;
        private System.Windows.Forms.TextBox tBRaisonSociale;
        private System.Windows.Forms.TextBox tBIdentifiant;
        private System.Windows.Forms.DataGridViewImageColumn ColumnModifier;
        private System.Windows.Forms.DataGridViewImageColumn ColumnSupprimer;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnIdClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNom;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSpécialité;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAdresse;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnVille;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnWilaya;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPays;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnRegistreDeCommerce;
        private System.Windows.Forms.DataGridViewTextBoxColumn NIF;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTéléphone1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTéléphone2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFax;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEmail;
    }
}