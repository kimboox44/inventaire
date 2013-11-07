namespace solution1.Inventaire
{
    partial class gestion_inventaire
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
            this.dgv_inventaire = new System.Windows.Forms.DataGridView();
            this.column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_inventaire)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_inventaire
            // 
            this.dgv_inventaire.BackgroundColor = System.Drawing.Color.LightGray;
            this.dgv_inventaire.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_inventaire.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.column1,
            this.Column2,
            this.Column4,
            this.date,
            this.Column3});
            this.dgv_inventaire.Location = new System.Drawing.Point(6, 9);
            this.dgv_inventaire.Name = "dgv_inventaire";
            this.dgv_inventaire.Size = new System.Drawing.Size(556, 465);
            this.dgv_inventaire.TabIndex = 0;
            this.dgv_inventaire.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_inventaire_CellClick);
            this.dgv_inventaire.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_inventaire_CellContentClick);
            // 
            // column1
            // 
            this.column1.HeaderText = "Désignation Inventaire";
            this.column1.Name = "column1";
            this.column1.Width = 180;
            // 
            // Column2
            // 
            this.Column2.FillWeight = 80F;
            this.Column2.HeaderText = "Type";
            this.Column2.Name = "Column2";
            // 
            // Column4
            // 
            this.Column4.FillWeight = 80F;
            this.Column4.HeaderText = "Caractéristique";
            this.Column4.Name = "Column4";
            this.Column4.Width = 80;
            // 
            // date
            // 
            this.date.HeaderText = "Date";
            this.date.Name = "date";
            this.date.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.date.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "suprimé";
            this.Column3.Name = "Column3";
            this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column3.Width = 30;
            // 
            // gestion_inventaire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(564, 482);
            this.Controls.Add(this.dgv_inventaire);
            this.MaximumSize = new System.Drawing.Size(580, 520);
            this.MinimumSize = new System.Drawing.Size(500, 520);
            this.Name = "gestion_inventaire";
            this.Text = "Gestion Inventaire";
            this.Load += new System.EventHandler(this.gestion_inventaire_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_inventaire)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_inventaire;
        private System.Windows.Forms.DataGridViewTextBoxColumn column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewButtonColumn Column3;
    }
}