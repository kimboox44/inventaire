namespace solution1.Inventaire
{
    partial class choix_cpt
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
            this.invent = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Importation = new System.Windows.Forms.Button();
            this.cree_inv = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_nom_inv = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // invent
            // 
            this.invent.DisplayMember = "Invent";
            this.invent.FormattingEnabled = true;
            this.invent.Location = new System.Drawing.Point(34, 103);
            this.invent.Name = "invent";
            this.invent.Size = new System.Drawing.Size(217, 21);
            this.invent.TabIndex = 0;
            this.invent.ValueMember = "idInvent";
            this.invent.SelectedIndexChanged += new System.EventHandler(this.invent_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tb_nom_inv);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cree_inv);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.invent);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 170);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Information Inventaire";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // Importation
            // 
            this.Importation.Location = new System.Drawing.Point(68, 43);
            this.Importation.Name = "Importation";
            this.Importation.Size = new System.Drawing.Size(123, 23);
            this.Importation.TabIndex = 3;
            this.Importation.Text = "Importation";
            this.Importation.UseVisualStyleBackColor = true;
            this.Importation.Click += new System.EventHandler(this.Importation_Click);
            // 
            // cree_inv
            // 
            this.cree_inv.Location = new System.Drawing.Point(69, 134);
            this.cree_inv.Name = "cree_inv";
            this.cree_inv.Size = new System.Drawing.Size(123, 23);
            this.cree_inv.TabIndex = 2;
            this.cree_inv.Text = "Créer inventaire";
            this.cree_inv.UseVisualStyleBackColor = true;
            this.cree_inv.Click += new System.EventHandler(this.cree_inv_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(18, 199);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(251, 1);
            this.panel1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Choix d\'inventaire";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nom de l\'inventaire";
            // 
            // tb_nom_inv
            // 
            this.tb_nom_inv.Location = new System.Drawing.Point(34, 48);
            this.tb_nom_inv.Name = "tb_nom_inv";
            this.tb_nom_inv.Size = new System.Drawing.Size(217, 20);
            this.tb_nom_inv.TabIndex = 7;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Importation);
            this.groupBox2.Location = new System.Drawing.Point(12, 210);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(260, 92);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Importation Inventaire";
            // 
            // choix_cpt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 314);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "choix_cpt";
            this.Text = "Création Inventaire";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox invent;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Importation;
        private System.Windows.Forms.Button cree_inv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tb_nom_inv;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;

    }
}