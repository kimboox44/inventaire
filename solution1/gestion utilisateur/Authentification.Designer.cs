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
            this.tBMotDePasse = new System.Windows.Forms.TextBox();
            this.tBPseudo = new System.Windows.Forms.TextBox();
            this.bAnnuler = new System.Windows.Forms.Button();
            this.bvalider = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pseudo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 1;
            this.label2.Tag = "se";
            this.label2.Text = "Mot de passe";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tBMotDePasse);
            this.groupBox1.Controls.Add(this.tBPseudo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(11, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(382, 87);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // tBMotDePasse
            // 
            this.tBMotDePasse.Location = new System.Drawing.Point(97, 50);
            this.tBMotDePasse.Name = "tBMotDePasse";
            this.tBMotDePasse.PasswordChar = '*';
            this.tBMotDePasse.Size = new System.Drawing.Size(274, 20);
            this.tBMotDePasse.TabIndex = 3;
            this.tBMotDePasse.TextChanged += new System.EventHandler(this.tBMotDePasse_TextChanged);
            this.tBMotDePasse.KeyDown += new System.Windows.Forms.KeyEventHandler(this.bvalider_Click);
            // 
            // tBPseudo
            // 
            this.tBPseudo.Location = new System.Drawing.Point(97, 18);
            this.tBPseudo.Name = "tBPseudo";
            this.tBPseudo.Size = new System.Drawing.Size(274, 20);
            this.tBPseudo.TabIndex = 2;
            this.tBPseudo.Text = "Utilisateur1";
            this.tBPseudo.TextChanged += new System.EventHandler(this.tBPseudo_TextChanged);
            // 
            // bAnnuler
            // 
            this.bAnnuler.Location = new System.Drawing.Point(204, 148);
            this.bAnnuler.Name = "bAnnuler";
            this.bAnnuler.Size = new System.Drawing.Size(75, 23);
            this.bAnnuler.TabIndex = 27;
            this.bAnnuler.Text = "Annuler";
            this.bAnnuler.UseVisualStyleBackColor = true;
            this.bAnnuler.Click += new System.EventHandler(this.button2_Click);
            // 
            // bvalider
            // 
            this.bvalider.FlatAppearance.BorderSize = 0;
            this.bvalider.Location = new System.Drawing.Point(123, 148);
            this.bvalider.Name = "bvalider";
            this.bvalider.Size = new System.Drawing.Size(75, 23);
            this.bvalider.TabIndex = 28;
            this.bvalider.Text = "Valider";
            this.bvalider.UseVisualStyleBackColor = true;
            this.bvalider.Click += new System.EventHandler(this.bvalider_Click);
            // 
            // Authentification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 183);
            this.Controls.Add(this.bvalider);
            this.Controls.Add(this.bAnnuler);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Authentification";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Authentification";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Authentification_FormClosed);
            this.Load += new System.EventHandler(this.Authentification_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
    }
}