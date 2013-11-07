namespace solution1
{
    partial class MAJResponsableEmplacement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MAJResponsableEmplacement));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bSites = new System.Windows.Forms.Button();
            this.mesIcones = new System.Windows.Forms.ImageList(this.components);
            this.cBSite = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tVEmplacements = new System.Windows.Forms.TreeView();
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
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVResponsables)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 392);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(835, 22);
            this.statusStrip1.TabIndex = 0;
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
            this.splitContainer1.Panel1.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dGVResponsables);
            this.splitContainer1.Size = new System.Drawing.Size(835, 392);
            this.splitContainer1.SplitterDistance = 265;
            this.splitContainer1.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.bSites);
            this.groupBox2.Controls.Add(this.cBSite);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(6, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(256, 42);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            // 
            // bSites
            // 
            this.bSites.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bSites.ImageIndex = 2;
            this.bSites.ImageList = this.mesIcones;
            this.bSites.Location = new System.Drawing.Point(226, 13);
            this.bSites.Name = "bSites";
            this.bSites.Size = new System.Drawing.Size(23, 23);
            this.bSites.TabIndex = 3;
            this.bSites.UseVisualStyleBackColor = true;
            this.bSites.Click += new System.EventHandler(this.bSites_Click);
            // 
            // mesIcones
            // 
            this.mesIcones.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("mesIcones.ImageStream")));
            this.mesIcones.TransparentColor = System.Drawing.Color.Transparent;
            this.mesIcones.Images.SetKeyName(0, "grouptree_toggle.gif");
            this.mesIcones.Images.SetKeyName(1, "emplacementSelect1.ico");
            this.mesIcones.Images.SetKeyName(2, "site.jpeg");
            // 
            // cBSite
            // 
            this.cBSite.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cBSite.DisplayMember = "NomSite";
            this.cBSite.FormattingEnabled = true;
            this.cBSite.Location = new System.Drawing.Point(47, 14);
            this.cBSite.Name = "cBSite";
            this.cBSite.Size = new System.Drawing.Size(175, 21);
            this.cBSite.TabIndex = 1;
            this.cBSite.ValueMember = "idSite";
            this.cBSite.SelectedIndexChanged += new System.EventHandler(this.comboBoxSite_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Site :";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.tVEmplacements);
            this.groupBox1.Location = new System.Drawing.Point(6, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(256, 338);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // tVEmplacements
            // 
            this.tVEmplacements.AllowDrop = true;
            this.tVEmplacements.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tVEmplacements.HideSelection = false;
            this.tVEmplacements.ImageIndex = 0;
            this.tVEmplacements.ImageList = this.mesIcones;
            this.tVEmplacements.LabelEdit = true;
            this.tVEmplacements.Location = new System.Drawing.Point(7, 13);
            this.tVEmplacements.Name = "tVEmplacements";
            this.tVEmplacements.SelectedImageIndex = 0;
            this.tVEmplacements.Size = new System.Drawing.Size(243, 319);
            this.tVEmplacements.TabIndex = 0;
            this.tVEmplacements.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tVEmplacements_AfterSelect);
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
            this.dGVResponsables.Size = new System.Drawing.Size(566, 392);
            this.dGVResponsables.TabIndex = 0;
            this.dGVResponsables.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVResponsables_CellClick);
            this.dGVResponsables.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVResponsables_CellEndEdit);
            this.dGVResponsables.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dGVResponsables_CellPainting);
            this.dGVResponsables.CellStateChanged += new System.Windows.Forms.DataGridViewCellStateChangedEventHandler(this.dGVResponsables_CellStateChanged);
            this.dGVResponsables.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVResponsables_CellValueChanged);
            this.dGVResponsables.CellValueNeeded += new System.Windows.Forms.DataGridViewCellValueEventHandler(this.dGVResponsables_CellValueNeeded);
            this.dGVResponsables.CellValuePushed += new System.Windows.Forms.DataGridViewCellValueEventHandler(this.dGVResponsables_CellValuePushed);
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
            // MAJResponsableEmplacement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 414);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.statusStrip1);
            this.Name = "MAJResponsableEmplacement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Les responsables des emplacements";
            this.Load += new System.EventHandler(this.MAJResponsableEmplacement_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGVResponsables)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dGVResponsables;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button bSites;
        private System.Windows.Forms.ComboBox cBSite;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.TreeView tVEmplacements;
        private System.Windows.Forms.ImageList mesIcones;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColumnResponsable;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNom;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPrenom;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFonction;
        private System.Windows.Forms.DataGridViewButtonColumn ColumnSupprimer;
    }
}