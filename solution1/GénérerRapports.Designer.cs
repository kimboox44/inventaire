namespace solution1
{
    partial class GénérerRapport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GénérerRapport));
            this.lBRapports = new System.Windows.Forms.ListBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bGénérer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lBRapports
            // 
            this.lBRapports.FormattingEnabled = true;
            this.lBRapports.Items.AddRange(new object[] {
            "Liste des biens (inventaire général)",
            "Liste des ouvrages (inventaire général)",
            "Biens par catégorie (inventaire général)",
            "Exemplaires par ouvrage (inventaire général)",
            "Biens par Inventaire/Site/Emplacement ",
            "Exemplaires par Inventaires/Site/Emplacement",
            "Comparaison de deux inventaires (biens/exemplaires perdus, déplacé, sur place, no" +
                "uveaux)"});
            this.lBRapports.Location = new System.Drawing.Point(6, 47);
            this.lBRapports.Name = "lBRapports";
            this.lBRapports.Size = new System.Drawing.Size(460, 173);
            this.lBRapports.TabIndex = 0;
            this.lBRapports.SelectedIndexChanged += new System.EventHandler(this.lBRapports_SelectedIndexChanged);
            this.lBRapports.DoubleClick += new System.EventHandler(this.listBox1_DoubleClick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 263);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(484, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bGénérer);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lBRapports);
            this.groupBox1.Location = new System.Drawing.Point(5, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(472, 256);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // bGénérer
            // 
            this.bGénérer.Location = new System.Drawing.Point(179, 224);
            this.bGénérer.Name = "bGénérer";
            this.bGénérer.Size = new System.Drawing.Size(122, 28);
            this.bGénérer.TabIndex = 2;
            this.bGénérer.Text = "Générer";
            this.bGénérer.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Choisissez un rapport ";
            // 
            // GénérerRapport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 285);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "GénérerRapport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Générer des rapports";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lBRapports;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bGénérer;
    }
}