namespace solution1
{
    partial class OuvrirInventaire
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OuvrirInventaire));
            this.lBinventaire = new System.Windows.Forms.ListBox();
            this.bOuvrir = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.tSSLDateInventaire = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.type = new System.Windows.Forms.ComboBox();
            this.caract = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lBinventaire
            // 
            this.lBinventaire.DisplayMember = "DesigInventaire";
            this.lBinventaire.FormattingEnabled = true;
            this.lBinventaire.Location = new System.Drawing.Point(6, 103);
            this.lBinventaire.Name = "lBinventaire";
            this.lBinventaire.Size = new System.Drawing.Size(313, 199);
            this.lBinventaire.TabIndex = 0;
            this.lBinventaire.SelectedIndexChanged += new System.EventHandler(this.lBinventaire_SelectedIndexChanged);
            this.lBinventaire.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lBinventaire_MouseDoubleClick);
            // 
            // bOuvrir
            // 
            this.bOuvrir.Image = global::solution1.Properties.Resources.NetByte_Design_Studio___0110;
            this.bOuvrir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bOuvrir.Location = new System.Drawing.Point(83, 309);
            this.bOuvrir.Name = "bOuvrir";
            this.bOuvrir.Size = new System.Drawing.Size(122, 41);
            this.bOuvrir.TabIndex = 3;
            this.bOuvrir.Text = "&Ouvrir";
            this.bOuvrir.UseVisualStyleBackColor = true;
            this.bOuvrir.Click += new System.EventHandler(this.bGénérer_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.caract);
            this.groupBox1.Controls.Add(this.type);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lBinventaire);
            this.groupBox1.Controls.Add(this.bOuvrir);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Location = new System.Drawing.Point(7, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(325, 356);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Inventaires";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Choisissez un inventaire";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(111, 110);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(133, 20);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // tSSLDateInventaire
            // 
            this.tSSLDateInventaire.Name = "tSSLDateInventaire";
            this.tSSLDateInventaire.Size = new System.Drawing.Size(0, 17);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tSSLDateInventaire});
            this.statusStrip1.Location = new System.Drawing.Point(0, 364);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(344, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // type
            // 
            this.type.FormattingEnabled = true;
            this.type.Items.AddRange(new object[] {
            "",
            "Physique",
            "Comptable"});
            this.type.Location = new System.Drawing.Point(129, 42);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(164, 21);
            this.type.TabIndex = 6;
            this.type.SelectedIndexChanged += new System.EventHandler(this.type_SelectedIndexChanged);
            // 
            // caract
            // 
            this.caract.FormattingEnabled = true;
            this.caract.Items.AddRange(new object[] {
            "",
            "En cours",
            "Cloturé"});
            this.caract.Location = new System.Drawing.Point(129, 75);
            this.caract.Name = "caract";
            this.caract.Size = new System.Drawing.Size(164, 21);
            this.caract.TabIndex = 7;
            this.caract.SelectedIndexChanged += new System.EventHandler(this.caract_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Type d\'inventaire";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Caractéréstique";
            // 
            // OuvrirInventaire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(344, 386);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(360, 424);
            this.Name = "OuvrirInventaire";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ouvrir un inventaire";
            this.Load += new System.EventHandler(this.OuvrirInventaire_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lBinventaire;
        private System.Windows.Forms.Button bOuvrir;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ToolStripStatusLabel tSSLDateInventaire;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox caract;
        private System.Windows.Forms.ComboBox type;
    }
}