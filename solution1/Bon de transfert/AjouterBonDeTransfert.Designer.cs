namespace solution1
{
    partial class AjouterBonDeTransfert
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AjouterBonDeTransfert));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tBMotif = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dTPDateTransfert = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tBIdBonDeTransfert = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rBEmplacementSélectionné = new System.Windows.Forms.RadioButton();
            this.rBTousLesEmplacements = new System.Windows.Forms.RadioButton();
            this.dGVBiensDestination = new System.Windows.Forms.DataGridView();
            this.ColumnAnnulerTransfert = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ColumnIdBienTransféré = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAncienCodeTransféré = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDesigBienTransféré = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDesigCategorieBienTransféré = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDateAcquisitionTransféré = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEtatTransféré = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPrixTransféré = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnParticularitéTransféré = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEmplacementSource = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.cBSiteDestination = new System.Windows.Forms.ComboBox();
            this.tVEmplacementDestination = new System.Windows.Forms.TreeView();
            this.listeIcones = new System.Windows.Forms.ImageList(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dGVBiensSource = new System.Windows.Forms.DataGridView();
            this.ColumnTransferer = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ColumnIdBien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAncienCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDésignation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCatégorie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDateAcquisition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColyumnEtat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPrix = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnParticularité = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.cBSiteSource = new System.Windows.Forms.ComboBox();
            this.tVEmplacements = new System.Windows.Forms.TreeView();
            this.bAnnuler = new System.Windows.Forms.Button();
            this.bAjouter = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVBiensDestination)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVBiensSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1342, 659);
            this.tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(1334, 633);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Nouveau bon de transfert";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.tBMotif);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.dTPDateTransfert);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.tBIdBonDeTransfert);
            this.groupBox3.Location = new System.Drawing.Point(6, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1325, 68);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Information sur le bon de transfert";
            // 
            // tBMotif
            // 
            this.tBMotif.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tBMotif.Location = new System.Drawing.Point(417, 16);
            this.tBMotif.Name = "tBMotif";
            this.tBMotif.Size = new System.Drawing.Size(902, 20);
            this.tBMotif.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(375, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Motif :";
            // 
            // dTPDateTransfert
            // 
            this.dTPDateTransfert.Location = new System.Drawing.Point(134, 42);
            this.dTPDateTransfert.Name = "dTPDateTransfert";
            this.dTPDateTransfert.Size = new System.Drawing.Size(203, 20);
            this.dTPDateTransfert.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Date :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "N° de bon de transfert :";
            // 
            // tBIdBonDeTransfert
            // 
            this.tBIdBonDeTransfert.Enabled = false;
            this.tBIdBonDeTransfert.Location = new System.Drawing.Point(134, 16);
            this.tBIdBonDeTransfert.Name = "tBIdBonDeTransfert";
            this.tBIdBonDeTransfert.Size = new System.Drawing.Size(203, 20);
            this.tBIdBonDeTransfert.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.rBEmplacementSélectionné);
            this.groupBox2.Controls.Add(this.rBTousLesEmplacements);
            this.groupBox2.Controls.Add(this.dGVBiensDestination);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.cBSiteDestination);
            this.groupBox2.Controls.Add(this.tVEmplacementDestination);
            this.groupBox2.Location = new System.Drawing.Point(6, 356);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1325, 274);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Destination";
            // 
            // rBEmplacementSélectionné
            // 
            this.rBEmplacementSélectionné.AutoSize = true;
            this.rBEmplacementSélectionné.Checked = true;
            this.rBEmplacementSélectionné.Location = new System.Drawing.Point(343, 247);
            this.rBEmplacementSélectionné.Name = "rBEmplacementSélectionné";
            this.rBEmplacementSélectionné.Size = new System.Drawing.Size(146, 17);
            this.rBEmplacementSélectionné.TabIndex = 37;
            this.rBEmplacementSélectionné.TabStop = true;
            this.rBEmplacementSélectionné.Text = "Emplacement sélectionné";
            this.rBEmplacementSélectionné.UseVisualStyleBackColor = true;
            this.rBEmplacementSélectionné.CheckedChanged += new System.EventHandler(this.rBEmplacementSélectionné_CheckedChanged);
            // 
            // rBTousLesEmplacements
            // 
            this.rBTousLesEmplacements.AutoSize = true;
            this.rBTousLesEmplacements.Location = new System.Drawing.Point(495, 247);
            this.rBTousLesEmplacements.Name = "rBTousLesEmplacements";
            this.rBTousLesEmplacements.Size = new System.Drawing.Size(136, 17);
            this.rBTousLesEmplacements.TabIndex = 36;
            this.rBTousLesEmplacements.Text = "Tous les emplacements";
            this.rBTousLesEmplacements.UseVisualStyleBackColor = true;
            this.rBTousLesEmplacements.CheckedChanged += new System.EventHandler(this.rBTousLesEmplacements_CheckedChanged);
            // 
            // dGVBiensDestination
            // 
            this.dGVBiensDestination.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dGVBiensDestination.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dGVBiensDestination.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVBiensDestination.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnAnnulerTransfert,
            this.ColumnIdBienTransféré,
            this.ColumnAncienCodeTransféré,
            this.ColumnDesigBienTransféré,
            this.ColumnDesigCategorieBienTransféré,
            this.ColumnDateAcquisitionTransféré,
            this.ColumnEtatTransféré,
            this.ColumnPrixTransféré,
            this.ColumnParticularitéTransféré,
            this.ColumnEmplacementSource});
            this.dGVBiensDestination.GridColor = System.Drawing.Color.Gainsboro;
            this.dGVBiensDestination.Location = new System.Drawing.Point(343, 19);
            this.dGVBiensDestination.Name = "dGVBiensDestination";
            this.dGVBiensDestination.Size = new System.Drawing.Size(976, 222);
            this.dGVBiensDestination.TabIndex = 33;
            this.dGVBiensDestination.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVBiensDestination_CellClick);
            this.dGVBiensDestination.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dGVBiensDestination_CellPainting);
            // 
            // ColumnAnnulerTransfert
            // 
            this.ColumnAnnulerTransfert.HeaderText = "";
            this.ColumnAnnulerTransfert.Name = "ColumnAnnulerTransfert";
            this.ColumnAnnulerTransfert.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnAnnulerTransfert.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ColumnAnnulerTransfert.Width = 25;
            // 
            // ColumnIdBienTransféré
            // 
            this.ColumnIdBienTransféré.HeaderText = "Identifiant";
            this.ColumnIdBienTransféré.Name = "ColumnIdBienTransféré";
            // 
            // ColumnAncienCodeTransféré
            // 
            this.ColumnAncienCodeTransféré.HeaderText = "Ancien code";
            this.ColumnAncienCodeTransféré.Name = "ColumnAncienCodeTransféré";
            // 
            // ColumnDesigBienTransféré
            // 
            this.ColumnDesigBienTransféré.HeaderText = "Désignation";
            this.ColumnDesigBienTransféré.Name = "ColumnDesigBienTransféré";
            // 
            // ColumnDesigCategorieBienTransféré
            // 
            this.ColumnDesigCategorieBienTransféré.HeaderText = "Catégorie";
            this.ColumnDesigCategorieBienTransféré.Name = "ColumnDesigCategorieBienTransféré";
            // 
            // ColumnDateAcquisitionTransféré
            // 
            this.ColumnDateAcquisitionTransféré.HeaderText = "Acquisition";
            this.ColumnDateAcquisitionTransféré.Name = "ColumnDateAcquisitionTransféré";
            this.ColumnDateAcquisitionTransféré.Width = 85;
            // 
            // ColumnEtatTransféré
            // 
            this.ColumnEtatTransféré.HeaderText = "Etat";
            this.ColumnEtatTransféré.Name = "ColumnEtatTransféré";
            // 
            // ColumnPrixTransféré
            // 
            this.ColumnPrixTransféré.HeaderText = "Prix";
            this.ColumnPrixTransféré.Name = "ColumnPrixTransféré";
            // 
            // ColumnParticularitéTransféré
            // 
            this.ColumnParticularitéTransféré.HeaderText = "Particularité";
            this.ColumnParticularitéTransféré.Name = "ColumnParticularitéTransféré";
            // 
            // ColumnEmplacementSource
            // 
            this.ColumnEmplacementSource.HeaderText = "Source";
            this.ColumnEmplacementSource.Name = "ColumnEmplacementSource";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Site :";
            // 
            // cBSiteDestination
            // 
            this.cBSiteDestination.DisplayMember = "Site";
            this.cBSiteDestination.FormattingEnabled = true;
            this.cBSiteDestination.Location = new System.Drawing.Point(42, 19);
            this.cBSiteDestination.Name = "cBSiteDestination";
            this.cBSiteDestination.Size = new System.Drawing.Size(295, 21);
            this.cBSiteDestination.TabIndex = 3;
            this.cBSiteDestination.SelectedIndexChanged += new System.EventHandler(this.tBSiteDestination_SelectedIndexChanged);
            // 
            // tVEmplacementDestination
            // 
            this.tVEmplacementDestination.HideSelection = false;
            this.tVEmplacementDestination.ImageIndex = 0;
            this.tVEmplacementDestination.ImageList = this.listeIcones;
            this.tVEmplacementDestination.Location = new System.Drawing.Point(6, 44);
            this.tVEmplacementDestination.Name = "tVEmplacementDestination";
            this.tVEmplacementDestination.SelectedImageIndex = 0;
            this.tVEmplacementDestination.Size = new System.Drawing.Size(331, 220);
            this.tVEmplacementDestination.TabIndex = 1;
            this.tVEmplacementDestination.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tVEmplacementDestination_AfterSelect);
            // 
            // listeIcones
            // 
            this.listeIcones.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("listeIcones.ImageStream")));
            this.listeIcones.TransparentColor = System.Drawing.Color.Transparent;
            this.listeIcones.Images.SetKeyName(0, "grouptree_toggle.gif");
            this.listeIcones.Images.SetKeyName(1, "emplacementSelect1.ico");
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.dGVBiensSource);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cBSiteSource);
            this.groupBox1.Controls.Add(this.tVEmplacements);
            this.groupBox1.Location = new System.Drawing.Point(6, 77);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1325, 273);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Source";
            // 
            // dGVBiensSource
            // 
            this.dGVBiensSource.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dGVBiensSource.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dGVBiensSource.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVBiensSource.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnTransferer,
            this.ColumnIdBien,
            this.ColumnAncienCode,
            this.ColumnDésignation,
            this.ColumnCatégorie,
            this.ColumnDateAcquisition,
            this.ColyumnEtat,
            this.ColumnPrix,
            this.ColumnParticularité});
            this.dGVBiensSource.GridColor = System.Drawing.Color.Gainsboro;
            this.dGVBiensSource.Location = new System.Drawing.Point(343, 19);
            this.dGVBiensSource.Name = "dGVBiensSource";
            this.dGVBiensSource.Size = new System.Drawing.Size(976, 247);
            this.dGVBiensSource.TabIndex = 33;
            this.dGVBiensSource.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVBiensSource_CellClick);
            this.dGVBiensSource.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dGVBiensSource_CellPainting);
            // 
            // ColumnTransferer
            // 
            this.ColumnTransferer.HeaderText = "";
            this.ColumnTransferer.Name = "ColumnTransferer";
            this.ColumnTransferer.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnTransferer.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ColumnTransferer.Width = 25;
            // 
            // ColumnIdBien
            // 
            this.ColumnIdBien.HeaderText = "Identifiant";
            this.ColumnIdBien.Name = "ColumnIdBien";
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
            this.ColumnDateAcquisition.Width = 187;
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
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Site :";
            // 
            // cBSiteSource
            // 
            this.cBSiteSource.DisplayMember = "Site";
            this.cBSiteSource.FormattingEnabled = true;
            this.cBSiteSource.Location = new System.Drawing.Point(42, 19);
            this.cBSiteSource.Name = "cBSiteSource";
            this.cBSiteSource.Size = new System.Drawing.Size(295, 21);
            this.cBSiteSource.TabIndex = 1;
            this.cBSiteSource.SelectedIndexChanged += new System.EventHandler(this.tBSiteSource_SelectedIndexChanged);
            // 
            // tVEmplacements
            // 
            this.tVEmplacements.HideSelection = false;
            this.tVEmplacements.ImageIndex = 0;
            this.tVEmplacements.ImageList = this.listeIcones;
            this.tVEmplacements.Location = new System.Drawing.Point(6, 46);
            this.tVEmplacements.Name = "tVEmplacements";
            this.tVEmplacements.SelectedImageIndex = 0;
            this.tVEmplacements.Size = new System.Drawing.Size(331, 220);
            this.tVEmplacements.TabIndex = 0;
            this.tVEmplacements.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tVEmplacements_AfterSelect);
            // 
            // bAnnuler
            // 
            this.bAnnuler.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bAnnuler.Location = new System.Drawing.Point(1201, 677);
            this.bAnnuler.Name = "bAnnuler";
            this.bAnnuler.Size = new System.Drawing.Size(75, 23);
            this.bAnnuler.TabIndex = 28;
            this.bAnnuler.Text = "Annuler";
            this.bAnnuler.UseVisualStyleBackColor = true;
            this.bAnnuler.Click += new System.EventHandler(this.bAnnuler_Click);
            // 
            // bAjouter
            // 
            this.bAjouter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bAjouter.Location = new System.Drawing.Point(1279, 677);
            this.bAjouter.Name = "bAjouter";
            this.bAjouter.Size = new System.Drawing.Size(75, 23);
            this.bAjouter.TabIndex = 27;
            this.bAjouter.Text = "Enregistrer";
            this.bAjouter.UseVisualStyleBackColor = true;
            this.bAjouter.Click += new System.EventHandler(this.bAjouter_Click);
            // 
            // AjouterBonDeTransfert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1366, 712);
            this.Controls.Add(this.bAnnuler);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.bAjouter);
            this.Name = "AjouterBonDeTransfert";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bon de Transfert";
            this.Load += new System.EventHandler(this.BonDeTransfert_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVBiensDestination)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVBiensSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DateTimePicker dTPDateTransfert;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tBIdBonDeTransfert;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cBSiteDestination;
        private System.Windows.Forms.TreeView tVEmplacementDestination;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cBSiteSource;
        private System.Windows.Forms.TreeView tVEmplacements;
        private System.Windows.Forms.Button bAnnuler;
        public System.Windows.Forms.Button bAjouter;
        private System.Windows.Forms.DataGridView dGVBiensDestination;
        private System.Windows.Forms.DataGridView dGVBiensSource;
        private System.Windows.Forms.ImageList listeIcones;
        private System.Windows.Forms.TextBox tBMotif;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rBEmplacementSélectionné;
        private System.Windows.Forms.RadioButton rBTousLesEmplacements;
        private System.Windows.Forms.DataGridViewButtonColumn ColumnAnnulerTransfert;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnIdBienTransféré;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAncienCodeTransféré;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDesigBienTransféré;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDesigCategorieBienTransféré;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDateAcquisitionTransféré;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEtatTransféré;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPrixTransféré;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnParticularitéTransféré;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEmplacementSource;
        private System.Windows.Forms.DataGridViewButtonColumn ColumnTransferer;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnIdBien;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAncienCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDésignation;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCatégorie;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDateAcquisition;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColyumnEtat;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPrix;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnParticularité;

    }
}