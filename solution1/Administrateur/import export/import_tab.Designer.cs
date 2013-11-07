namespace solution1.Prenom.import_export
{
    partial class import_tab
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxjournal2 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.button_importation = new System.Windows.Forms.Button();
            this.parcourir = new System.Windows.Forms.Button();
            this.textBoximpor_table = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.textBoxjournal2);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.button_importation);
            this.panel1.Controls.Add(this.parcourir);
            this.panel1.Controls.Add(this.textBoximpor_table);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(3, 83);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(744, 453);
            this.panel1.TabIndex = 0;
            // 
            // textBoxjournal2
            // 
            this.textBoxjournal2.Location = new System.Drawing.Point(64, 296);
            this.textBoxjournal2.Multiline = true;
            this.textBoxjournal2.Name = "textBoxjournal2";
            this.textBoxjournal2.Size = new System.Drawing.Size(576, 97);
            this.textBoxjournal2.TabIndex = 65;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(183, 139);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(328, 21);
            this.comboBox1.TabIndex = 64;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(88, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 63;
            this.label3.Text = "Choisir la table";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Black;
            this.panel5.Location = new System.Drawing.Point(182, 84);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(283, 1);
            this.panel5.TabIndex = 62;
            // 
            // button_importation
            // 
            this.button_importation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_importation.Font = new System.Drawing.Font("Bell MT", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_importation.Image = global::solution1.Properties.Resources.save;
            this.button_importation.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button_importation.Location = new System.Drawing.Point(407, 171);
            this.button_importation.Name = "button_importation";
            this.button_importation.Size = new System.Drawing.Size(104, 29);
            this.button_importation.TabIndex = 60;
            this.button_importation.Text = "        Importer";
            this.button_importation.UseVisualStyleBackColor = true;
            this.button_importation.Click += new System.EventHandler(this.button_importation_Click);
            // 
            // parcourir
            // 
            this.parcourir.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.parcourir.Location = new System.Drawing.Point(517, 105);
            this.parcourir.Name = "parcourir";
            this.parcourir.Size = new System.Drawing.Size(32, 23);
            this.parcourir.TabIndex = 59;
            this.parcourir.Text = "...";
            this.parcourir.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.parcourir.UseVisualStyleBackColor = true;
            this.parcourir.Click += new System.EventHandler(this.parcourir_Click);
            // 
            // textBoximpor_table
            // 
            this.textBoximpor_table.Location = new System.Drawing.Point(183, 105);
            this.textBoximpor_table.Name = "textBoximpor_table";
            this.textBoximpor_table.Size = new System.Drawing.Size(328, 20);
            this.textBoximpor_table.TabIndex = 58;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 57;
            this.label1.Text = "Chemin de fichier";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(182, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(294, 20);
            this.label2.TabIndex = 66;
            this.label2.Text = "Importation d\'un fichier à une table ";
            // 
            // import_tab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Location = new System.Drawing.Point(120, 0);
            this.Name = "import_tab";
            this.Size = new System.Drawing.Size(750, 540);
            this.Load += new System.EventHandler(this.import_tab_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxjournal2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button button_importation;
        private System.Windows.Forms.Button parcourir;
        private System.Windows.Forms.TextBox textBoximpor_table;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
