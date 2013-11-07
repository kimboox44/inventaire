namespace solution1
{
    partial class MAJSites
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.OKsite = new System.Windows.Forms.Button();
            this.dGVSites = new System.Windows.Forms.DataGridView();
            this.ColumnSupprimer = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ColumnNomSite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVSites)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 319);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(362, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.OKsite);
            this.groupBox1.Controls.Add(this.dGVSites);
            this.groupBox1.Location = new System.Drawing.Point(5, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(352, 310);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sites";
            // 
            // OKsite
            // 
            this.OKsite.Location = new System.Drawing.Point(134, 283);
            this.OKsite.Name = "OKsite";
            this.OKsite.Size = new System.Drawing.Size(75, 23);
            this.OKsite.TabIndex = 1;
            this.OKsite.Text = "Ok";
            this.OKsite.UseVisualStyleBackColor = true;
            this.OKsite.Click += new System.EventHandler(this.OKsite_Click);
            // 
            // dGVSites
            // 
            this.dGVSites.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dGVSites.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVSites.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnSupprimer,
            this.ColumnNomSite});
            this.dGVSites.Location = new System.Drawing.Point(6, 16);
            this.dGVSites.Name = "dGVSites";
            this.dGVSites.Size = new System.Drawing.Size(339, 264);
            this.dGVSites.TabIndex = 0;
            this.dGVSites.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVSites_CellClick);
          //this.dGVSites.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVSites_CellContentClick);
            this.dGVSites.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVSites_CellEndEdit);
            this.dGVSites.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dataGridView1_CellPainting);
            this.dGVSites.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVSites_CellValueChanged);
            // 
            // ColumnSupprimer
            // 
            this.ColumnSupprimer.HeaderText = "";
            this.ColumnSupprimer.Name = "ColumnSupprimer";
            this.ColumnSupprimer.Width = 25;
            // 
            // ColumnNomSite
            // 
            this.ColumnNomSite.HeaderText = "Nom du site";
            this.ColumnNomSite.Name = "ColumnNomSite";
            this.ColumnNomSite.Width = 263;
            // 
            // MAJSites
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(362, 341);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusStrip1);
            this.Name = "MAJSites";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Les sites";
            this.Load += new System.EventHandler(this.MAJSites_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGVSites)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dGVSites;
        private System.Windows.Forms.DataGridViewButtonColumn ColumnSupprimer;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNomSite;
        public System.Windows.Forms.Button OKsite;
    }
}