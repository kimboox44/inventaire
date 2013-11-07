namespace solution1.Mappage
{
    partial class Form1
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Parcour = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox_parcour = new System.Windows.Forms.TextBox();
            this.Importer = new System.Windows.Forms.Button();
            this.champ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.requete = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(340, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Parcour
            // 
            this.Parcour.Location = new System.Drawing.Point(386, 55);
            this.Parcour.Name = "Parcour";
            this.Parcour.Size = new System.Drawing.Size(75, 23);
            this.Parcour.TabIndex = 1;
            this.Parcour.Text = "button1";
            this.Parcour.UseVisualStyleBackColor = true;
            this.Parcour.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.champ,
            this.Column3});
            this.dataGridView1.Location = new System.Drawing.Point(12, 128);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(405, 334);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // textBox_parcour
            // 
            this.textBox_parcour.Location = new System.Drawing.Point(153, 57);
            this.textBox_parcour.Name = "textBox_parcour";
            this.textBox_parcour.Size = new System.Drawing.Size(227, 20);
            this.textBox_parcour.TabIndex = 3;
            // 
            // Importer
            // 
            this.Importer.Location = new System.Drawing.Point(448, 439);
            this.Importer.Name = "Importer";
            this.Importer.Size = new System.Drawing.Size(75, 23);
            this.Importer.TabIndex = 4;
            this.Importer.Text = "importer";
            this.Importer.UseVisualStyleBackColor = true;
            this.Importer.Click += new System.EventHandler(this.Importer_Click);
            // 
            // champ
            // 
            this.champ.HeaderText = "Champ";
            this.champ.Name = "champ";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Column3";
            this.Column3.Name = "Column3";
            // 
            // requete
            // 
            this.requete.Location = new System.Drawing.Point(39, 493);
            this.requete.Name = "requete";
            this.requete.Size = new System.Drawing.Size(573, 20);
            this.requete.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 525);
            this.Controls.Add(this.requete);
            this.Controls.Add(this.Importer);
            this.Controls.Add(this.textBox_parcour);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Parcour);
            this.Controls.Add(this.comboBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button Parcour;
        private System.Windows.Forms.TextBox textBox_parcour;
        public System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.Button Importer;
        private System.Windows.Forms.DataGridViewTextBoxColumn champ;
        private System.Windows.Forms.DataGridViewComboBoxColumn Column3;
        private System.Windows.Forms.TextBox requete;



    }
}