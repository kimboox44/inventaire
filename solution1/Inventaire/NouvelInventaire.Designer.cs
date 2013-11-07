namespace solution1
{
    partial class NouvelInventaire
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
            this.tBDesigInventaire = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxImporter = new System.Windows.Forms.TextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.rBATous = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.rBAUtilisateurEnCours = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.importer = new System.Windows.Forms.Button();
            this.bOK = new System.Windows.Forms.Button();
            this.bAnnuler = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.type = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tBDesigInventaire
            // 
            this.tBDesigInventaire.Location = new System.Drawing.Point(15, 51);
            this.tBDesigInventaire.Multiline = true;
            this.tBDesigInventaire.Name = "tBDesigInventaire";
            this.tBDesigInventaire.Size = new System.Drawing.Size(421, 30);
            this.tBDesigInventaire.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Entrez le nom de l\'inventaire :";
            // 
            // textBoxImporter
            // 
            this.textBoxImporter.Location = new System.Drawing.Point(15, 87);
            this.textBoxImporter.Multiline = true;
            this.textBoxImporter.Name = "textBoxImporter";
            this.textBoxImporter.Size = new System.Drawing.Size(320, 30);
            this.textBoxImporter.TabIndex = 32;
            this.textBoxImporter.TextChanged += new System.EventHandler(this.textBoxImporter_TextChanged);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(15, 276);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(421, 18);
            this.progressBar1.TabIndex = 33;
            this.progressBar1.Click += new System.EventHandler(this.bOK_Click);
            // 
            // rBATous
            // 
            this.rBATous.AutoSize = true;
            this.rBATous.Checked = true;
            this.rBATous.Location = new System.Drawing.Point(174, 19);
            this.rBATous.Name = "rBATous";
            this.rBATous.Size = new System.Drawing.Size(54, 17);
            this.rBATous.TabIndex = 0;
            this.rBATous.TabStop = true;
            this.rBATous.Text = "à tous";
            this.rBATous.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Inventaire accessible";
            // 
            // rBAUtilisateurEnCours
            // 
            this.rBAUtilisateurEnCours.AutoSize = true;
            this.rBAUtilisateurEnCours.Location = new System.Drawing.Point(273, 19);
            this.rBAUtilisateurEnCours.Name = "rBAUtilisateurEnCours";
            this.rBAUtilisateurEnCours.Size = new System.Drawing.Size(127, 17);
            this.rBAUtilisateurEnCours.TabIndex = 1;
            this.rBAUtilisateurEnCours.TabStop = true;
            this.rBAUtilisateurEnCours.Text = "A l\'utilisateur en cours";
            this.rBAUtilisateurEnCours.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.rBAUtilisateurEnCours);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.rBATous);
            this.groupBox1.Location = new System.Drawing.Point(15, 164);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(421, 46);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // importer
            // 
            this.importer.Image = global::solution1.Properties.Resources.folder_tar;
            this.importer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.importer.Location = new System.Drawing.Point(341, 87);
            this.importer.Name = "importer";
            this.importer.Size = new System.Drawing.Size(95, 30);
            this.importer.TabIndex = 31;
            this.importer.Text = "Importer";
            this.importer.UseVisualStyleBackColor = true;
            this.importer.Click += new System.EventHandler(this.button1_Click);
            // 
            // bOK
            // 
            this.bOK.BackgroundImage = global::solution1.Properties.Resources.save3;
            this.bOK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bOK.Location = new System.Drawing.Point(106, 229);
            this.bOK.Name = "bOK";
            this.bOK.Size = new System.Drawing.Size(90, 35);
            this.bOK.TabIndex = 30;
            this.bOK.Text = "Ok";
            this.bOK.UseVisualStyleBackColor = true;
            this.bOK.Click += new System.EventHandler(this.bOK_Click);
            // 
            // bAnnuler
            // 
            this.bAnnuler.Image = global::solution1.Properties.Resources._104;
            this.bAnnuler.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bAnnuler.Location = new System.Drawing.Point(202, 229);
            this.bAnnuler.Name = "bAnnuler";
            this.bAnnuler.Size = new System.Drawing.Size(90, 35);
            this.bAnnuler.TabIndex = 29;
            this.bAnnuler.Text = "Annuler";
            this.bAnnuler.UseVisualStyleBackColor = true;
            this.bAnnuler.Click += new System.EventHandler(this.bAnnuler_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // type
            // 
            this.type.FormattingEnabled = true;
            this.type.Items.AddRange(new object[] {
            "Physique",
            "Comptable"});
            this.type.Location = new System.Drawing.Point(12, 124);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(424, 21);
            this.type.TabIndex = 34;
            // 
            // NouvelInventaire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(448, 318);
            this.Controls.Add(this.type);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.textBoxImporter);
            this.Controls.Add(this.importer);
            this.Controls.Add(this.bOK);
            this.Controls.Add(this.bAnnuler);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tBDesigInventaire);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NouvelInventaire";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nouvel inventaire";
            this.Load += new System.EventHandler(this.NouvelInventaire_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tBDesigInventaire;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bAnnuler;
        private System.Windows.Forms.Button bOK;
        private System.Windows.Forms.Button importer;
        private System.Windows.Forms.TextBox textBoxImporter;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.RadioButton rBATous;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rBAUtilisateurEnCours;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.ComboBox type;
    }
}