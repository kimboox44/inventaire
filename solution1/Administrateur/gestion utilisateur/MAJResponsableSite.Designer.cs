namespace solution1
{
    partial class MAJResponsableSite
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lBSites = new System.Windows.Forms.ListBox();
            this.dGVResponsables = new System.Windows.Forms.DataGridView();
            this.ColumnResponsable = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ColumnNom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPrenom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFonction = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSupprimer = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVResponsables)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 401);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(835, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dGVResponsables);
            this.splitContainer1.Size = new System.Drawing.Size(835, 401);
            this.splitContainer1.SplitterDistance = 265;
            this.splitContainer1.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.lBSites);
            this.groupBox1.Location = new System.Drawing.Point(6, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(256, 389);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Emplacements";
            // 
            // lBSites
            // 
            this.lBSites.DisplayMember = "NomSite";
            this.lBSites.FormattingEnabled = true;
            this.lBSites.Location = new System.Drawing.Point(6, 14);
            this.lBSites.Name = "lBSites";
            this.lBSites.Size = new System.Drawing.Size(244, 368);
            this.lBSites.TabIndex = 0;
            this.lBSites.SelectedIndexChanged += new System.EventHandler(this.lBSites_SelectedIndexChanged);
            // 
            // dGVResponsables
            // 
            this.dGVResponsables.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVResponsables.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnResponsable,
            this.ColumnNom,
            this.ColumnPrenom,
            this.ColumnFonction,
            this.ColumnSupprimer});
            this.dGVResponsables.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dGVResponsables.Location = new System.Drawing.Point(0, 0);
            this.dGVResponsables.Name = "dGVResponsables";
            this.dGVResponsables.Size = new System.Drawing.Size(566, 401);
            this.dGVResponsables.TabIndex = 0;
            this.dGVResponsables.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVResponsables_CellClick);
            this.dGVResponsables.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVResponsables_CellEndEdit);
            this.dGVResponsables.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dGVResponsables_CellPainting);
            this.dGVResponsables.CellStateChanged += new System.Windows.Forms.DataGridViewCellStateChangedEventHandler(this.dGVResponsables_CellStateChanged);
            // 
            // ColumnResponsable
            // 
            this.ColumnResponsable.HeaderText = "";
            this.ColumnResponsable.Name = "ColumnResponsable";
            this.ColumnResponsable.Width = 25;
            // 
            // ColumnNom
            // 
            this.ColumnNom.HeaderText = "Nom";
            this.ColumnNom.Name = "ColumnNom";
            this.ColumnNom.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnNom.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColumnNom.Width = 130;
            // 
            // ColumnPrenom
            // 
            this.ColumnPrenom.HeaderText = "Prenom";
            this.ColumnPrenom.Name = "ColumnPrenom";
            this.ColumnPrenom.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnPrenom.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColumnPrenom.Width = 130;
            // 
            // ColumnFonction
            // 
            this.ColumnFonction.HeaderText = "Fonction";
            this.ColumnFonction.Name = "ColumnFonction";
            this.ColumnFonction.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnFonction.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColumnFonction.Width = 212;
            // 
            // ColumnSupprimer
            // 
            this.ColumnSupprimer.HeaderText = "";
            this.ColumnSupprimer.Name = "ColumnSupprimer";
            this.ColumnSupprimer.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnSupprimer.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ColumnSupprimer.Width = 25;
            // 
            // MAJResponsableSite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 423);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.statusStrip1);
            this.Name = "MAJResponsableSite";
            this.Text = "Les responsables des sites";
            this.Load += new System.EventHandler(this.MAJResponsableSite_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGVResponsables)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lBSites;
        private System.Windows.Forms.DataGridView dGVResponsables;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColumnResponsable;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNom;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPrenom;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFonction;
        private System.Windows.Forms.DataGridViewButtonColumn ColumnSupprimer;
    }
}