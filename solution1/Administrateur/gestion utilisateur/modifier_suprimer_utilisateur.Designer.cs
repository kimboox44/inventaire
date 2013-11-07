namespace solution1.gestion_utilisateur
{
    partial class modifier_suprimer_utilisateur
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
            this.dataGrid_utilisateur = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Administrateur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Login = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mot_pass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modifier = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Supprimer = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_utilisateur)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGrid_utilisateur
            // 
            this.dataGrid_utilisateur.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataGrid_utilisateur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_utilisateur.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Administrateur,
            this.Login,
            this.Mot_pass,
            this.Modifier,
            this.Supprimer});
            this.dataGrid_utilisateur.GridColor = System.Drawing.Color.Gainsboro;
            this.dataGrid_utilisateur.Location = new System.Drawing.Point(45, 107);
            this.dataGrid_utilisateur.Name = "dataGrid_utilisateur";
            this.dataGrid_utilisateur.Size = new System.Drawing.Size(677, 393);
            this.dataGrid_utilisateur.TabIndex = 0;
            this.dataGrid_utilisateur.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_utilisateur_CellContentClick);
           // this.dataGrid_utilisateur.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_utilisateur_CellContentClick_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(250, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Liste des utilisateurs";
            // 
            // ID
            // 
            this.ID.HeaderText = "Id";
            this.ID.Name = "ID";
            // 
            // Administrateur
            // 
            this.Administrateur.HeaderText = "Administrateur";
            this.Administrateur.Name = "Administrateur";
            // 
            // Login
            // 
            this.Login.HeaderText = "Login";
            this.Login.Name = "Login";
            // 
            // Mot_pass
            // 
            this.Mot_pass.HeaderText = "Mot de pass";
            this.Mot_pass.Name = "Mot_pass";
            // 
            // Modifier
            // 
            this.Modifier.HeaderText = "Modifier";
            this.Modifier.Name = "Modifier";
            this.Modifier.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Modifier.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Modifier.Width = 30;
            // 
            // Supprimer
            // 
            this.Supprimer.HeaderText = "Supprimer";
            this.Supprimer.MinimumWidth = 8;
            this.Supprimer.Name = "Supprimer";
            this.Supprimer.Width = 30;
            // 
            // modifier_suprimer_utilisateur
            // 
            this.Appearance.BackColor = System.Drawing.Color.Gainsboro;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGrid_utilisateur);
            this.Name = "modifier_suprimer_utilisateur";
            this.Size = new System.Drawing.Size(814, 505);
            this.Load += new System.EventHandler(this.modifier_suprimer_utilisateur_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_utilisateur)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGrid_utilisateur;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Administrateur;
        private System.Windows.Forms.DataGridViewTextBoxColumn Login;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mot_pass;
        private System.Windows.Forms.DataGridViewButtonColumn Modifier;
        private System.Windows.Forms.DataGridViewButtonColumn Supprimer;

    }
}
