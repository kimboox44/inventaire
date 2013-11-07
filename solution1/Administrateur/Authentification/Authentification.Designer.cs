namespace solution1
{
    partial class Authentification
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tBMotDePasse = new System.Windows.Forms.TextBox();
            this.tBPseudo = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.bvalider = new System.Windows.Forms.Button();
            this.bAnnuler = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pseudo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 1;
            this.label2.Tag = "se";
            this.label2.Text = "Mot de passe";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.tBMotDePasse);
            this.groupBox1.Controls.Add(this.tBPseudo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(11, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(438, 142);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::solution1.Properties.Resources.gpgsm;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Location = new System.Drawing.Point(6, 33);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(76, 72);
            this.panel2.TabIndex = 3;
            // 
            // tBMotDePasse
            // 
            this.tBMotDePasse.Location = new System.Drawing.Point(154, 95);
            this.tBMotDePasse.Name = "tBMotDePasse";
            this.tBMotDePasse.PasswordChar = '*';
            this.tBMotDePasse.Size = new System.Drawing.Size(274, 20);
            this.tBMotDePasse.TabIndex = 0;
            this.tBMotDePasse.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tBMotDePasse_KeyDown);
            // 
            // tBPseudo
            // 
            this.tBPseudo.Location = new System.Drawing.Point(154, 29);
            this.tBPseudo.Name = "tBPseudo";
            this.tBPseudo.Size = new System.Drawing.Size(274, 20);
            this.tBPseudo.TabIndex = 2;
            this.tBPseudo.Text = "Utilisateur1";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Salmon;
            this.panel1.BackgroundImage = global::solution1.Properties.Resources.NetByte_Design_Studio___0007;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(12, 156);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(437, 64);
            this.panel1.TabIndex = 29;
            this.panel1.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "Erreur login ";
            // 
            // bvalider
            // 
            this.bvalider.BackgroundImage = global::solution1.Properties.Resources.button_ok;
            this.bvalider.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bvalider.FlatAppearance.BorderSize = 0;
            this.bvalider.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bvalider.Location = new System.Drawing.Point(93, 226);
            this.bvalider.Name = "bvalider";
            this.bvalider.Size = new System.Drawing.Size(103, 39);
            this.bvalider.TabIndex = 28;
            this.bvalider.Text = "       Valider";
            this.bvalider.UseVisualStyleBackColor = true;
            this.bvalider.Click += new System.EventHandler(this.bvalider_Click);
            // 
            // bAnnuler
            // 
            this.bAnnuler.BackgroundImage = global::solution1.Properties.Resources.stop;
            this.bAnnuler.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bAnnuler.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAnnuler.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bAnnuler.Location = new System.Drawing.Point(250, 226);
            this.bAnnuler.Name = "bAnnuler";
            this.bAnnuler.Size = new System.Drawing.Size(103, 39);
            this.bAnnuler.TabIndex = 27;
            this.bAnnuler.Text = "      Annuler";
            this.bAnnuler.UseVisualStyleBackColor = true;
            this.bAnnuler.Click += new System.EventHandler(this.button2_Click);
            // 
            // Authentification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(461, 273);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bvalider);
            this.Controls.Add(this.bAnnuler);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Authentification";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Authentification";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tBPseudo;
        private System.Windows.Forms.Button bAnnuler;
        private System.Windows.Forms.Button bvalider;
        private System.Windows.Forms.TextBox tBMotDePasse;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
    }
}