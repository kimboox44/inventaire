namespace solution1
{
    partial class FormBonsDeTransfert
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBonsDeTransfert));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dTPFin = new System.Windows.Forms.DateTimePicker();
            this.dTPDebut = new System.Windows.Forms.DateTimePicker();
            this.rBDate = new System.Windows.Forms.RadioButton();
            this.rBNumBonTransfert = new System.Windows.Forms.RadioButton();
            this.rBTous = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dGVBonDeTransfert = new System.Windows.Forms.DataGridView();
            this.ColumnIdBonTransfert = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnMotif = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSiteSource = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSiteDest = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnModifier = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ColumnImprimer = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ColumnSupprimer = new System.Windows.Forms.DataGridViewImageColumn();
            this.tBIdBonTransfert = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dGVBiens = new System.Windows.Forms.DataGridView();
            this.buttonQuitter = new System.Windows.Forms.Button();
            this.ColumnIdBien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnProvenance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDestination = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAncienCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDésignation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCatégorie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDateAcquisition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColyumnEtat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPrix = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnParticularité = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVBonDeTransfert)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVBiens)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dTPFin);
            this.groupBox1.Controls.Add(this.dTPDebut);
            this.groupBox1.Controls.Add(this.rBDate);
            this.groupBox1.Controls.Add(this.rBNumBonTransfert);
            this.groupBox1.Controls.Add(this.rBTous);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.tBIdBonTransfert);
            this.groupBox1.Location = new System.Drawing.Point(9, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1349, 411);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rechercher un bon de transfert";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(91, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "de";
            this.label2.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "à";
            this.label1.Visible = false;
            // 
            // dTPFin
            // 
            this.dTPFin.Location = new System.Drawing.Point(134, 86);
            this.dTPFin.Name = "dTPFin";
            this.dTPFin.Size = new System.Drawing.Size(230, 20);
            this.dTPFin.TabIndex = 30;
            this.dTPFin.Visible = false;
            this.dTPFin.ValueChanged += new System.EventHandler(this.dTPFin_ValueChanged);
            // 
            // dTPDebut
            // 
            this.dTPDebut.Location = new System.Drawing.Point(134, 62);
            this.dTPDebut.Name = "dTPDebut";
            this.dTPDebut.Size = new System.Drawing.Size(230, 20);
            this.dTPDebut.TabIndex = 29;
            this.dTPDebut.Visible = false;
            this.dTPDebut.ValueChanged += new System.EventHandler(this.dTPDebut_ValueChanged);
            // 
            // rBDate
            // 
            this.rBDate.AutoSize = true;
            this.rBDate.Location = new System.Drawing.Point(16, 65);
            this.rBDate.Name = "rBDate";
            this.rBDate.Size = new System.Drawing.Size(54, 17);
            this.rBDate.TabIndex = 28;
            this.rBDate.Text = "Date :";
            this.rBDate.UseVisualStyleBackColor = true;
            this.rBDate.Visible = false;
            this.rBDate.CheckedChanged += new System.EventHandler(this.rBDate_CheckedChanged);
            // 
            // rBNumBonTransfert
            // 
            this.rBNumBonTransfert.AutoSize = true;
            this.rBNumBonTransfert.Location = new System.Drawing.Point(16, 42);
            this.rBNumBonTransfert.Name = "rBNumBonTransfert";
            this.rBNumBonTransfert.Size = new System.Drawing.Size(58, 17);
            this.rBNumBonTransfert.TabIndex = 27;
            this.rBNumBonTransfert.Text = "N° bon";
            this.rBNumBonTransfert.UseVisualStyleBackColor = true;
            this.rBNumBonTransfert.CheckedChanged += new System.EventHandler(this.rBNumBonTransfert_CheckedChanged);
            // 
            // rBTous
            // 
            this.rBTous.AutoSize = true;
            this.rBTous.Checked = true;
            this.rBTous.Location = new System.Drawing.Point(16, 19);
            this.rBTous.Name = "rBTous";
            this.rBTous.Size = new System.Drawing.Size(49, 17);
            this.rBTous.TabIndex = 26;
            this.rBTous.TabStop = true;
            this.rBTous.Text = "Tous";
            this.rBTous.UseVisualStyleBackColor = true;
            this.rBTous.CheckedChanged += new System.EventHandler(this.rBTous_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.dGVBonDeTransfert);
            this.groupBox2.Location = new System.Drawing.Point(7, 112);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1336, 292);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Listes des bons de transfert";
            // 
            // dGVBonDeTransfert
            // 
            this.dGVBonDeTransfert.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dGVBonDeTransfert.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dGVBonDeTransfert.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVBonDeTransfert.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnIdBonTransfert,
            this.Date,
            this.ColumnMotif,
            this.ColumnSiteSource,
            this.ColumnSiteDest,
            this.ColumnModifier,
            this.ColumnImprimer,
            this.ColumnSupprimer});
            this.dGVBonDeTransfert.GridColor = System.Drawing.Color.Gainsboro;
            this.dGVBonDeTransfert.Location = new System.Drawing.Point(9, 19);
            this.dGVBonDeTransfert.MultiSelect = false;
            this.dGVBonDeTransfert.Name = "dGVBonDeTransfert";
            this.dGVBonDeTransfert.Size = new System.Drawing.Size(1319, 267);
            this.dGVBonDeTransfert.TabIndex = 0;
            this.dGVBonDeTransfert.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVBonDeTransfert_CellClick);
            this.dGVBonDeTransfert.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dGVBonDeTransfert_CellPainting);
            this.dGVBonDeTransfert.SelectionChanged += new System.EventHandler(this.dGVBonDeTransfert_SelectionChanged);
            // 
            // ColumnIdBonTransfert
            // 
            this.ColumnIdBonTransfert.HeaderText = "N° Bon";
            this.ColumnIdBonTransfert.Name = "ColumnIdBonTransfert";
            this.ColumnIdBonTransfert.ReadOnly = true;
            this.ColumnIdBonTransfert.Width = 107;
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            // 
            // ColumnMotif
            // 
            this.ColumnMotif.HeaderText = "Motif";
            this.ColumnMotif.Name = "ColumnMotif";
            this.ColumnMotif.Width = 580;
            // 
            // ColumnSiteSource
            // 
            this.ColumnSiteSource.HeaderText = "Site Source";
            this.ColumnSiteSource.Name = "ColumnSiteSource";
            this.ColumnSiteSource.Width = 190;
            // 
            // ColumnSiteDest
            // 
            this.ColumnSiteDest.HeaderText = "Site destination";
            this.ColumnSiteDest.Name = "ColumnSiteDest";
            this.ColumnSiteDest.Width = 190;
            // 
            // ColumnModifier
            // 
            this.ColumnModifier.HeaderText = "";
            this.ColumnModifier.Name = "ColumnModifier";
            this.ColumnModifier.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnModifier.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ColumnModifier.Visible = false;
            this.ColumnModifier.Width = 25;
            // 
            // ColumnImprimer
            // 
            this.ColumnImprimer.HeaderText = "";
            this.ColumnImprimer.Name = "ColumnImprimer";
            this.ColumnImprimer.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnImprimer.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ColumnImprimer.Width = 25;
            // 
            // ColumnSupprimer
            // 
            this.ColumnSupprimer.HeaderText = "";
            this.ColumnSupprimer.Image = ((System.Drawing.Image)(resources.GetObject("ColumnSupprimer.Image")));
            this.ColumnSupprimer.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.ColumnSupprimer.Name = "ColumnSupprimer";
            this.ColumnSupprimer.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnSupprimer.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ColumnSupprimer.Width = 25;
            // 
            // tBIdBonTransfert
            // 
            this.tBIdBonTransfert.Location = new System.Drawing.Point(134, 39);
            this.tBIdBonTransfert.Name = "tBIdBonTransfert";
            this.tBIdBonTransfert.Size = new System.Drawing.Size(230, 20);
            this.tBIdBonTransfert.TabIndex = 22;
            this.tBIdBonTransfert.TextChanged += new System.EventHandler(this.tBIdBonTransfert_TextChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel5,
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3,
            this.toolStripStatusLabel4});
            this.statusStrip1.Location = new System.Drawing.Point(0, 688);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1366, 24);
            this.statusStrip1.TabIndex = 3;
            // 
            // toolStripStatusLabel5
            // 
            this.toolStripStatusLabel5.Name = "toolStripStatusLabel5";
            this.toolStripStatusLabel5.Size = new System.Drawing.Size(13, 19);
            this.toolStripStatusLabel5.Text = "  ";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.BackColor = System.Drawing.Color.Green;
            this.toolStripStatusLabel1.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(20, 19);
            this.toolStripStatusLabel1.Text = "   ";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(68, 19);
            this.toolStripStatusLabel2.Text = " Bien reçu   ";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.BackColor = System.Drawing.Color.Red;
            this.toolStripStatusLabel3.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(20, 19);
            this.toolStripStatusLabel3.Text = "   ";
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(96, 19);
            this.toolStripStatusLabel4.Text = " Bien en transfert";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.dGVBiens);
            this.groupBox3.Location = new System.Drawing.Point(14, 432);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1344, 226);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Les biens transférés";
            // 
            // dGVBiens
            // 
            this.dGVBiens.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dGVBiens.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dGVBiens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVBiens.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnIdBien,
            this.ColumnProvenance,
            this.ColumnDestination,
            this.ColumnAncienCode,
            this.ColumnDésignation,
            this.ColumnCatégorie,
            this.ColumnDateAcquisition,
            this.ColyumnEtat,
            this.ColumnPrix,
            this.ColumnParticularité});
            this.dGVBiens.GridColor = System.Drawing.Color.Gainsboro;
            this.dGVBiens.Location = new System.Drawing.Point(11, 19);
            this.dGVBiens.Name = "dGVBiens";
            this.dGVBiens.Size = new System.Drawing.Size(1325, 201);
            this.dGVBiens.TabIndex = 33;
            // 
            // buttonQuitter
            // 
            this.buttonQuitter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonQuitter.Location = new System.Drawing.Point(1271, 663);
            this.buttonQuitter.Name = "buttonQuitter";
            this.buttonQuitter.Size = new System.Drawing.Size(87, 23);
            this.buttonQuitter.TabIndex = 30;
            this.buttonQuitter.Text = "Quitter";
            this.buttonQuitter.UseVisualStyleBackColor = true;
            this.buttonQuitter.Click += new System.EventHandler(this.buttonQuitter_Click);
            // 
            // ColumnIdBien
            // 
            this.ColumnIdBien.HeaderText = "Identifiant";
            this.ColumnIdBien.Name = "ColumnIdBien";
            // 
            // ColumnProvenance
            // 
            this.ColumnProvenance.HeaderText = "Provenance";
            this.ColumnProvenance.Name = "ColumnProvenance";
            // 
            // ColumnDestination
            // 
            this.ColumnDestination.HeaderText = "Destination";
            this.ColumnDestination.Name = "ColumnDestination";
            // 
            // ColumnAncienCode
            // 
            this.ColumnAncienCode.HeaderText = "Ancien code";
            this.ColumnAncienCode.Name = "ColumnAncienCode";
            // 
            // ColumnDésignation
            // 
            this.ColumnDésignation.HeaderText = "Désignation";
            this.ColumnDésignation.Name = "ColumnDésignation";
            // 
            // ColumnCatégorie
            // 
            this.ColumnCatégorie.HeaderText = "Catégorie";
            this.ColumnCatégorie.Name = "ColumnCatégorie";
            // 
            // ColumnDateAcquisition
            // 
            this.ColumnDateAcquisition.HeaderText = "Acquisition";
            this.ColumnDateAcquisition.Name = "ColumnDateAcquisition";
            this.ColumnDateAcquisition.Width = 80;
            // 
            // ColyumnEtat
            // 
            this.ColyumnEtat.HeaderText = "Etat";
            this.ColyumnEtat.Name = "ColyumnEtat";
            // 
            // ColumnPrix
            // 
            this.ColumnPrix.HeaderText = "Prix";
            this.ColumnPrix.Name = "ColumnPrix";
            // 
            // ColumnParticularité
            // 
            this.ColumnParticularité.HeaderText = "Particularité";
            this.ColumnParticularité.Name = "ColumnParticularité";
            this.ColumnParticularité.Width = 370;
            // 
            // FormBonsDeTransfert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1366, 712);
            this.Controls.Add(this.buttonQuitter);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FormBonsDeTransfert";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bon de transfert";
            this.Load += new System.EventHandler(this.FormBonsDeTransfert_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGVBonDeTransfert)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGVBiens)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dTPFin;
        private System.Windows.Forms.DateTimePicker dTPDebut;
        private System.Windows.Forms.RadioButton rBDate;
        private System.Windows.Forms.RadioButton rBNumBonTransfert;
        private System.Windows.Forms.RadioButton rBTous;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dGVBonDeTransfert;
        private System.Windows.Forms.TextBox tBIdBonTransfert;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dGVBiens;
        private System.Windows.Forms.Button buttonQuitter;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel5;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnIdBonTransfert;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnMotif;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSiteSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSiteDest;
        private System.Windows.Forms.DataGridViewButtonColumn ColumnModifier;
        private System.Windows.Forms.DataGridViewButtonColumn ColumnImprimer;
        private System.Windows.Forms.DataGridViewImageColumn ColumnSupprimer;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnIdBien;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnProvenance;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDestination;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAncienCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDésignation;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCatégorie;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDateAcquisition;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColyumnEtat;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPrix;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnParticularité;
    }
}