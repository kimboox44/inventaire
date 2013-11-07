namespace solution1
{
    partial class UserControlListeBiens
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonAfficher = new System.Windows.Forms.Button();
            this.DGVBien = new System.Windows.Forms.DataGridView();
            this.ColumnIdentifiant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAncienCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDesignation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCategorie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAcquisition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEtat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPrix = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnParticularite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rBTousBien = new System.Windows.Forms.RadioButton();
            this.rBIdBien = new System.Windows.Forms.RadioButton();
            this.rBancienCode = new System.Windows.Forms.RadioButton();
            this.tBidentBien = new System.Windows.Forms.TextBox();
            this.tBAncienCode = new System.Windows.Forms.TextBox();
            this.rBDesignation = new System.Windows.Forms.RadioButton();
            this.tBDesignation = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGVBien)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAfficher
            // 
            this.buttonAfficher.Location = new System.Drawing.Point(797, 3);
            this.buttonAfficher.Name = "buttonAfficher";
            this.buttonAfficher.Size = new System.Drawing.Size(97, 31);
            this.buttonAfficher.TabIndex = 0;
            this.buttonAfficher.Text = "Afficher";
            this.buttonAfficher.UseVisualStyleBackColor = true;
            this.buttonAfficher.Click += new System.EventHandler(this.buttonAfficher_Click);
            // 
            // DGVBien
            // 
            this.DGVBien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnIdentifiant,
            this.ColumnAncienCode,
            this.ColumnDesignation,
            this.ColumnCategorie,
            this.ColumnAcquisition,
            this.ColumnEtat,
            this.ColumnPrix,
            this.ColumnParticularite});
            this.DGVBien.Location = new System.Drawing.Point(147, 384);
            this.DGVBien.Name = "DGVBien";
            this.DGVBien.Size = new System.Drawing.Size(607, 132);
            this.DGVBien.TabIndex = 0;
            this.DGVBien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVBien_CellContentClick);
            // 
            // ColumnIdentifiant
            // 
            this.ColumnIdentifiant.HeaderText = "Identifiant";
            this.ColumnIdentifiant.Name = "ColumnIdentifiant";
            // 
            // ColumnAncienCode
            // 
            this.ColumnAncienCode.HeaderText = "Ancien Code";
            this.ColumnAncienCode.Name = "ColumnAncienCode";
            // 
            // ColumnDesignation
            // 
            this.ColumnDesignation.HeaderText = "Désignation";
            this.ColumnDesignation.Name = "ColumnDesignation";
            // 
            // ColumnCategorie
            // 
            this.ColumnCategorie.HeaderText = "Catégorie";
            this.ColumnCategorie.Name = "ColumnCategorie";
            // 
            // ColumnAcquisition
            // 
            this.ColumnAcquisition.HeaderText = "Acquisition";
            this.ColumnAcquisition.Name = "ColumnAcquisition";
            // 
            // ColumnEtat
            // 
            this.ColumnEtat.HeaderText = "Etat";
            this.ColumnEtat.Name = "ColumnEtat";
            // 
            // ColumnPrix
            // 
            this.ColumnPrix.HeaderText = "Prix";
            this.ColumnPrix.Name = "ColumnPrix";
            // 
            // ColumnParticularite
            // 
            this.ColumnParticularite.HeaderText = "Particularité";
            this.ColumnParticularite.Name = "ColumnParticularite";
            // 
            // rBTousBien
            // 
            this.rBTousBien.AutoSize = true;
            this.rBTousBien.Location = new System.Drawing.Point(22, 15);
            this.rBTousBien.Name = "rBTousBien";
            this.rBTousBien.Size = new System.Drawing.Size(49, 17);
            this.rBTousBien.TabIndex = 1;
            this.rBTousBien.TabStop = true;
            this.rBTousBien.Text = "Tous";
            this.rBTousBien.UseVisualStyleBackColor = true;
            // 
            // rBIdBien
            // 
            this.rBIdBien.AutoSize = true;
            this.rBIdBien.Location = new System.Drawing.Point(22, 49);
            this.rBIdBien.Name = "rBIdBien";
            this.rBIdBien.Size = new System.Drawing.Size(95, 17);
            this.rBIdBien.TabIndex = 2;
            this.rBIdBien.TabStop = true;
            this.rBIdBien.Text = "Identifiant Bien";
            this.rBIdBien.UseVisualStyleBackColor = true;
            // 
            // rBancienCode
            // 
            this.rBancienCode.AutoSize = true;
            this.rBancienCode.Location = new System.Drawing.Point(458, 10);
            this.rBancienCode.Name = "rBancienCode";
            this.rBancienCode.Size = new System.Drawing.Size(86, 17);
            this.rBancienCode.TabIndex = 3;
            this.rBancienCode.TabStop = true;
            this.rBancienCode.Text = "Ancien Code";
            this.rBancienCode.UseVisualStyleBackColor = true;
            // 
            // tBidentBien
            // 
            this.tBidentBien.Location = new System.Drawing.Point(128, 49);
            this.tBidentBien.Name = "tBidentBien";
            this.tBidentBien.Size = new System.Drawing.Size(125, 20);
            this.tBidentBien.TabIndex = 5;
            // 
            // tBAncienCode
            // 
            this.tBAncienCode.Location = new System.Drawing.Point(564, 10);
            this.tBAncienCode.Name = "tBAncienCode";
            this.tBAncienCode.Size = new System.Drawing.Size(125, 20);
            this.tBAncienCode.TabIndex = 6;
            // 
            // rBDesignation
            // 
            this.rBDesignation.AutoSize = true;
            this.rBDesignation.Location = new System.Drawing.Point(458, 52);
            this.rBDesignation.Name = "rBDesignation";
            this.rBDesignation.Size = new System.Drawing.Size(81, 17);
            this.rBDesignation.TabIndex = 7;
            this.rBDesignation.TabStop = true;
            this.rBDesignation.Text = "Désignation";
            this.rBDesignation.UseVisualStyleBackColor = true;
            // 
            // tBDesignation
            // 
            this.tBDesignation.Location = new System.Drawing.Point(564, 49);
            this.tBDesignation.Name = "tBDesignation";
            this.tBDesignation.Size = new System.Drawing.Size(125, 20);
            this.tBDesignation.TabIndex = 8;
            // 
            // UserControlListeBiens
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tBDesignation);
            this.Controls.Add(this.rBDesignation);
            this.Controls.Add(this.tBAncienCode);
            this.Controls.Add(this.tBidentBien);
            this.Controls.Add(this.rBancienCode);
            this.Controls.Add(this.rBIdBien);
            this.Controls.Add(this.rBTousBien);
            this.Controls.Add(this.DGVBien);
            this.Controls.Add(this.buttonAfficher);
            this.Name = "UserControlListeBiens";
            this.Size = new System.Drawing.Size(953, 519);
            ((System.ComponentModel.ISupportInitialize)(this.DGVBien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAfficher;
        private System.Windows.Forms.DataGridView DGVBien;
        private System.Windows.Forms.RadioButton rBTousBien;
        private System.Windows.Forms.RadioButton rBIdBien;
        private System.Windows.Forms.RadioButton rBancienCode;
        private System.Windows.Forms.TextBox tBidentBien;
        private System.Windows.Forms.TextBox tBAncienCode;
        private System.Windows.Forms.RadioButton rBDesignation;
        private System.Windows.Forms.TextBox tBDesignation;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnIdentifiant;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAncienCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDesignation;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCategorie;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAcquisition;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEtat;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPrix;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnParticularite;
    }
}
