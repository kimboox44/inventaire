namespace solution1
{
    partial class Comparer2Inventaires
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Comparer2Inventaires));
            this.mesIcones = new System.Windows.Forms.ImageList(this.components);
            this.treeViewEmplacement = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBoxSite = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cBSelectTousNoeuds = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonRapport = new System.Windows.Forms.Button();
            this.buttoncomparer = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxAcomparer = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxReference = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.bMAJBiens = new System.Windows.Forms.Button();
            this.bMAJBiensRetrouvés = new System.Windows.Forms.Button();
            this.bMAJBiensDéplacés = new System.Windows.Forms.Button();
            this.bMAJBiensPerdus = new System.Windows.Forms.Button();
            this.listViewBien = new System.Windows.Forms.ListView();
            this.columnIdentifiant = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnDesignation = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnCatégorie = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnDateAcquisitionBien = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnEtatInit = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnEtatFin = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnPrix = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnParticularité = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnEmplacementAvant = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnEmplacementAprès = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tSSL = new System.Windows.Forms.ToolStripStatusLabel();
            this.cMSMAJBienDéplacé = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mAJBiensDéplacésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mAJTousLesBiensDéplacésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cMSMAJBienPerdu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.cMSMAJBienRetrouvé = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.cMSMAJExemplaireDéplacé = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.cMSMAJExemplaireRetrouvé = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
            this.cMSMAJExemplairePerdu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem9 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem10 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.cMSMAJBienDéplacé.SuspendLayout();
            this.cMSMAJBienPerdu.SuspendLayout();
            this.cMSMAJBienRetrouvé.SuspendLayout();
            this.cMSMAJExemplaireDéplacé.SuspendLayout();
            this.cMSMAJExemplaireRetrouvé.SuspendLayout();
            this.cMSMAJExemplairePerdu.SuspendLayout();
            this.SuspendLayout();
            // 
            // mesIcones
            // 
            this.mesIcones.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("mesIcones.ImageStream")));
            this.mesIcones.TransparentColor = System.Drawing.Color.Transparent;
            this.mesIcones.Images.SetKeyName(0, "perdu.ico");
            this.mesIcones.Images.SetKeyName(1, "deplacé.ico");
            this.mesIcones.Images.SetKeyName(2, "nouveau.ico");
            this.mesIcones.Images.SetKeyName(3, "surPlace.ico");
            this.mesIcones.Images.SetKeyName(4, "ProgressError.ico");
            this.mesIcones.Images.SetKeyName(5, "deplacé.png");
            this.mesIcones.Images.SetKeyName(6, "agrsmdel.ico");
            this.mesIcones.Images.SetKeyName(7, "ProgressSkip.ico");
            // 
            // treeViewEmplacement
            // 
            this.treeViewEmplacement.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treeViewEmplacement.CheckBoxes = true;
            this.treeViewEmplacement.ForeColor = System.Drawing.SystemColors.WindowText;
            this.treeViewEmplacement.HideSelection = false;
            this.treeViewEmplacement.ImageIndex = 0;
            this.treeViewEmplacement.ImageList = this.imageList1;
            this.treeViewEmplacement.Location = new System.Drawing.Point(6, 14);
            this.treeViewEmplacement.Name = "treeViewEmplacement";
            this.treeViewEmplacement.SelectedImageIndex = 1;
            this.treeViewEmplacement.Size = new System.Drawing.Size(229, 296);
            this.treeViewEmplacement.TabIndex = 0;
            this.treeViewEmplacement.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.treeViewEmplacement_AfterCheck);
            this.treeViewEmplacement.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewEmplacement_AfterSelect);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "grouptree_toggle.gif");
            this.imageList1.Images.SetKeyName(1, "emplacementSelect1.ico");
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
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
            this.splitContainer1.Panel2.Controls.Add(this.groupBox3);
            this.splitContainer1.Panel2.Controls.Add(this.groupBox4);
            this.splitContainer1.Size = new System.Drawing.Size(984, 420);
            this.splitContainer1.SplitterDistance = 253;
            this.splitContainer1.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.comboBoxSite);
            this.groupBox2.Location = new System.Drawing.Point(5, 1);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(241, 48);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sites";
            // 
            // comboBoxSite
            // 
            this.comboBoxSite.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxSite.DisplayMember = "Site";
            this.comboBoxSite.FormattingEnabled = true;
            this.comboBoxSite.Location = new System.Drawing.Point(6, 15);
            this.comboBoxSite.Name = "comboBoxSite";
            this.comboBoxSite.Size = new System.Drawing.Size(229, 21);
            this.comboBoxSite.TabIndex = 1;
            this.comboBoxSite.ValueMember = "idSite";
            this.comboBoxSite.SelectedIndexChanged += new System.EventHandler(this.comboBoxSite_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.cBSelectTousNoeuds);
            this.groupBox1.Controls.Add(this.treeViewEmplacement);
            this.groupBox1.Location = new System.Drawing.Point(5, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(241, 337);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Tag = "S";
            this.groupBox1.Text = "Arbre des emplacements";
            // 
            // cBSelectTousNoeuds
            // 
            this.cBSelectTousNoeuds.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cBSelectTousNoeuds.AutoSize = true;
            this.cBSelectTousNoeuds.Location = new System.Drawing.Point(6, 316);
            this.cBSelectTousNoeuds.Name = "cBSelectTousNoeuds";
            this.cBSelectTousNoeuds.Size = new System.Drawing.Size(162, 17);
            this.cBSelectTousNoeuds.TabIndex = 1;
            this.cBSelectTousNoeuds.Text = "Sélectionner tous les noeuds";
            this.cBSelectTousNoeuds.UseVisualStyleBackColor = true;
            this.cBSelectTousNoeuds.CheckedChanged += new System.EventHandler(this.cBSelectTousNoeuds_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.buttonRapport);
            this.groupBox3.Controls.Add(this.buttoncomparer);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.comboBoxAcomparer);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.comboBoxReference);
            this.groupBox3.Location = new System.Drawing.Point(3, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(717, 48);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Inventaire";
            // 
            // buttonRapport
            // 
            this.buttonRapport.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonRapport.Enabled = false;
            this.buttonRapport.Location = new System.Drawing.Point(636, 15);
            this.buttonRapport.Name = "buttonRapport";
            this.buttonRapport.Size = new System.Drawing.Size(75, 23);
            this.buttonRapport.TabIndex = 6;
            this.buttonRapport.Text = "Rapport";
            this.buttonRapport.UseVisualStyleBackColor = true;
            this.buttonRapport.Click += new System.EventHandler(this.buttonRapport_Click);
            // 
            // buttoncomparer
            // 
            this.buttoncomparer.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttoncomparer.Location = new System.Drawing.Point(555, 15);
            this.buttoncomparer.Name = "buttoncomparer";
            this.buttoncomparer.Size = new System.Drawing.Size(75, 23);
            this.buttoncomparer.TabIndex = 3;
            this.buttoncomparer.Text = "Comparer";
            this.buttoncomparer.UseVisualStyleBackColor = true;
            this.buttoncomparer.Click += new System.EventHandler(this.buttoncomparer_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(267, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "A comparer";
            // 
            // comboBoxAcomparer
            // 
            this.comboBoxAcomparer.DisplayMember = "DesigInventaire";
            this.comboBoxAcomparer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAcomparer.FormattingEnabled = true;
            this.comboBoxAcomparer.Location = new System.Drawing.Point(334, 15);
            this.comboBoxAcomparer.Name = "comboBoxAcomparer";
            this.comboBoxAcomparer.Size = new System.Drawing.Size(173, 21);
            this.comboBoxAcomparer.TabIndex = 1;
            this.comboBoxAcomparer.ValueMember = "uidInventaire";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Reference";
            // 
            // comboBoxReference
            // 
            this.comboBoxReference.DisplayMember = "DesigInventaire";
            this.comboBoxReference.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxReference.FormattingEnabled = true;
            this.comboBoxReference.Location = new System.Drawing.Point(79, 17);
            this.comboBoxReference.Name = "comboBoxReference";
            this.comboBoxReference.Size = new System.Drawing.Size(173, 21);
            this.comboBoxReference.TabIndex = 2;
            this.comboBoxReference.ValueMember = "uidInventaire";
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.bMAJBiens);
            this.groupBox4.Controls.Add(this.bMAJBiensRetrouvés);
            this.groupBox4.Controls.Add(this.bMAJBiensDéplacés);
            this.groupBox4.Controls.Add(this.bMAJBiensPerdus);
            this.groupBox4.Controls.Add(this.listViewBien);
            this.groupBox4.Location = new System.Drawing.Point(3, 57);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(717, 334);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Biens";
            // 
            // bMAJBiens
            // 
            this.bMAJBiens.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bMAJBiens.BackColor = System.Drawing.Color.LightBlue;
            this.bMAJBiens.Enabled = false;
            this.bMAJBiens.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bMAJBiens.Image = global::solution1.Properties.Resources.TousBiens16x16;
            this.bMAJBiens.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bMAJBiens.Location = new System.Drawing.Point(15, 302);
            this.bMAJBiens.Name = "bMAJBiens";
            this.bMAJBiens.Size = new System.Drawing.Size(171, 26);
            this.bMAJBiens.TabIndex = 4;
            this.bMAJBiens.Text = "MAJ biens";
            this.bMAJBiens.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bMAJBiens.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bMAJBiens.UseVisualStyleBackColor = false;
            this.bMAJBiens.Click += new System.EventHandler(this.bMAJBiens_Click);
            // 
            // bMAJBiensRetrouvés
            // 
            this.bMAJBiensRetrouvés.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bMAJBiensRetrouvés.BackColor = System.Drawing.Color.LightBlue;
            this.bMAJBiensRetrouvés.Enabled = false;
            this.bMAJBiensRetrouvés.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bMAJBiensRetrouvés.Image = global::solution1.Properties.Resources.nouveau16x16;
            this.bMAJBiensRetrouvés.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bMAJBiensRetrouvés.Location = new System.Drawing.Point(190, 302);
            this.bMAJBiensRetrouvés.Name = "bMAJBiensRetrouvés";
            this.bMAJBiensRetrouvés.Size = new System.Drawing.Size(171, 26);
            this.bMAJBiensRetrouvés.TabIndex = 3;
            this.bMAJBiensRetrouvés.Text = "MAJ biens retrouvés";
            this.bMAJBiensRetrouvés.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bMAJBiensRetrouvés.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bMAJBiensRetrouvés.UseCompatibleTextRendering = true;
            this.bMAJBiensRetrouvés.UseVisualStyleBackColor = false;
            this.bMAJBiensRetrouvés.Click += new System.EventHandler(this.bMAJBiensRetrouvés_Click);
            // 
            // bMAJBiensDéplacés
            // 
            this.bMAJBiensDéplacés.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bMAJBiensDéplacés.BackColor = System.Drawing.Color.LightBlue;
            this.bMAJBiensDéplacés.Enabled = false;
            this.bMAJBiensDéplacés.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bMAJBiensDéplacés.Image = global::solution1.Properties.Resources.deplacé16x16;
            this.bMAJBiensDéplacés.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bMAJBiensDéplacés.Location = new System.Drawing.Point(365, 302);
            this.bMAJBiensDéplacés.Name = "bMAJBiensDéplacés";
            this.bMAJBiensDéplacés.Size = new System.Drawing.Size(171, 26);
            this.bMAJBiensDéplacés.TabIndex = 2;
            this.bMAJBiensDéplacés.Text = "MAJ biens déplacés";
            this.bMAJBiensDéplacés.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bMAJBiensDéplacés.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bMAJBiensDéplacés.UseCompatibleTextRendering = true;
            this.bMAJBiensDéplacés.UseVisualStyleBackColor = false;
            this.bMAJBiensDéplacés.Click += new System.EventHandler(this.bMAJBiensDéplacés_Click);
            // 
            // bMAJBiensPerdus
            // 
            this.bMAJBiensPerdus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bMAJBiensPerdus.BackColor = System.Drawing.Color.LightBlue;
            this.bMAJBiensPerdus.Enabled = false;
            this.bMAJBiensPerdus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bMAJBiensPerdus.Image = global::solution1.Properties.Resources.perdu16x16;
            this.bMAJBiensPerdus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bMAJBiensPerdus.Location = new System.Drawing.Point(540, 302);
            this.bMAJBiensPerdus.Name = "bMAJBiensPerdus";
            this.bMAJBiensPerdus.Size = new System.Drawing.Size(171, 26);
            this.bMAJBiensPerdus.TabIndex = 1;
            this.bMAJBiensPerdus.Text = "MAJ biens Perdus";
            this.bMAJBiensPerdus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bMAJBiensPerdus.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bMAJBiensPerdus.UseCompatibleTextRendering = true;
            this.bMAJBiensPerdus.UseVisualStyleBackColor = false;
            this.bMAJBiensPerdus.Click += new System.EventHandler(this.bMAJBiensPerdus_Click);
            // 
            // listViewBien
            // 
            this.listViewBien.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewBien.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnIdentifiant,
            this.columnDesignation,
            this.columnCatégorie,
            this.columnDateAcquisitionBien,
            this.columnEtatInit,
            this.columnEtatFin,
            this.columnPrix,
            this.columnParticularité,
            this.columnEmplacementAvant,
            this.columnEmplacementAprès});
            this.listViewBien.FullRowSelect = true;
            this.listViewBien.GridLines = true;
            this.listViewBien.Location = new System.Drawing.Point(6, 19);
            this.listViewBien.Name = "listViewBien";
            this.listViewBien.Size = new System.Drawing.Size(705, 277);
            this.listViewBien.SmallImageList = this.mesIcones;
            this.listViewBien.TabIndex = 0;
            this.listViewBien.UseCompatibleStateImageBehavior = false;
            this.listViewBien.View = System.Windows.Forms.View.Details;
            this.listViewBien.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listViewBien_ColumnClick);
        
            this.listViewBien.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listViewBien_MouseDown);
            // 
            // columnIdentifiant
            // 
            this.columnIdentifiant.Text = "Identifiant";
            this.columnIdentifiant.Width = 121;
            // 
            // columnDesignation
            // 
            this.columnDesignation.Text = "Designation";
            this.columnDesignation.Width = 162;
            // 
            // columnCatégorie
            // 
            this.columnCatégorie.Text = "Catégorie";
            this.columnCatégorie.Width = 135;
            // 
            // columnDateAcquisitionBien
            // 
            this.columnDateAcquisitionBien.Text = "Date d\'acquisition";
            this.columnDateAcquisitionBien.Width = 150;
            // 
            // columnEtatInit
            // 
            this.columnEtatInit.Text = "Etat init";
            this.columnEtatInit.Width = 91;
            // 
            // columnEtatFin
            // 
            this.columnEtatFin.Text = "Etat fin";
            this.columnEtatFin.Width = 91;
            // 
            // columnPrix
            // 
            this.columnPrix.Text = "Prix";
            this.columnPrix.Width = 74;
            // 
            // columnParticularité
            // 
            this.columnParticularité.Text = "Particularité";
            this.columnParticularité.Width = 238;
            // 
            // columnEmplacementAvant
            // 
            this.columnEmplacementAvant.Text = "Emplacement d\'avant";
            this.columnEmplacementAvant.Width = 300;
            // 
            // columnEmplacementAprès
            // 
            this.columnEmplacementAprès.Text = "Emplacement d\'après";
            this.columnEmplacementAprès.Width = 300;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tSSL});
            this.statusStrip1.Location = new System.Drawing.Point(0, 398);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(984, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tSSL
            // 
            this.tSSL.Name = "tSSL";
            this.tSSL.Size = new System.Drawing.Size(0, 17);
            // 
            // cMSMAJBienDéplacé
            // 
            this.cMSMAJBienDéplacé.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mAJBiensDéplacésToolStripMenuItem,
            this.mAJTousLesBiensDéplacésToolStripMenuItem});
            this.cMSMAJBienDéplacé.Name = "cMSMAJBienDéplacé";
            this.cMSMAJBienDéplacé.Size = new System.Drawing.Size(219, 48);
            this.cMSMAJBienDéplacé.Opening += new System.ComponentModel.CancelEventHandler(this.cMSMAJBienDéplacé_Opening);
            // 
            // mAJBiensDéplacésToolStripMenuItem
            // 
            this.mAJBiensDéplacésToolStripMenuItem.Name = "mAJBiensDéplacésToolStripMenuItem";
            this.mAJBiensDéplacésToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.mAJBiensDéplacésToolStripMenuItem.Text = "MAJ bien(s) déplacé(s)";
            this.mAJBiensDéplacésToolStripMenuItem.Click += new System.EventHandler(this.mAJBiensDéplacésToolStripMenuItem_Click);
            // 
            // mAJTousLesBiensDéplacésToolStripMenuItem
            // 
            this.mAJTousLesBiensDéplacésToolStripMenuItem.Name = "mAJTousLesBiensDéplacésToolStripMenuItem";
            this.mAJTousLesBiensDéplacésToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.mAJTousLesBiensDéplacésToolStripMenuItem.Text = "MAJ tous les biens déplacés";
            this.mAJTousLesBiensDéplacésToolStripMenuItem.Click += new System.EventHandler(this.mAJTousLesBiensDéplacésToolStripMenuItem_Click);
            // 
            // cMSMAJBienPerdu
            // 
            this.cMSMAJBienPerdu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2});
            this.cMSMAJBienPerdu.Name = "cMSMAJBienDéplacé";
            this.cMSMAJBienPerdu.Size = new System.Drawing.Size(210, 48);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(209, 22);
            this.toolStripMenuItem1.Text = "MAJ bien(s) perdu(s)";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(209, 22);
            this.toolStripMenuItem2.Text = "MAJ tous les biens perdus";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // cMSMAJBienRetrouvé
            // 
            this.cMSMAJBienRetrouvé.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem3,
            this.toolStripMenuItem4});
            this.cMSMAJBienRetrouvé.Name = "cMSMAJBienDéplacé";
            this.cMSMAJBienRetrouvé.Size = new System.Drawing.Size(224, 48);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(223, 22);
            this.toolStripMenuItem3.Text = "MAJ bien(s) retrouvé(s)";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(223, 22);
            this.toolStripMenuItem4.Text = "MAJ tous les biens retrouvés";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // cMSMAJExemplaireDéplacé
            // 
            this.cMSMAJExemplaireDéplacé.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem5,
            this.toolStripMenuItem6});
            this.cMSMAJExemplaireDéplacé.Name = "cMSMAJBienDéplacé";
            this.cMSMAJExemplaireDéplacé.Size = new System.Drawing.Size(251, 48);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(250, 22);
            this.toolStripMenuItem5.Text = "MAJ exemplaire(s) déplacé(s)";
            this.toolStripMenuItem5.Click += new System.EventHandler(this.toolStripMenuItem5_Click);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(250, 22);
            this.toolStripMenuItem6.Text = "MAJ tous les exemplaires déplacés";
            this.toolStripMenuItem6.Click += new System.EventHandler(this.toolStripMenuItem6_Click);
            // 
            // cMSMAJExemplaireRetrouvé
            // 
            this.cMSMAJExemplaireRetrouvé.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem7,
            this.toolStripMenuItem8});
            this.cMSMAJExemplaireRetrouvé.Name = "cMSMAJBienDéplacé";
            this.cMSMAJExemplaireRetrouvé.Size = new System.Drawing.Size(256, 48);
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(255, 22);
            this.toolStripMenuItem7.Text = "MAJ exemplaire(s) retrouvé(s)";
            this.toolStripMenuItem7.Click += new System.EventHandler(this.toolStripMenuItem7_Click);
            // 
            // toolStripMenuItem8
            // 
            this.toolStripMenuItem8.Name = "toolStripMenuItem8";
            this.toolStripMenuItem8.Size = new System.Drawing.Size(255, 22);
            this.toolStripMenuItem8.Text = "MAJ tous les exemplaires retrouvés";
            this.toolStripMenuItem8.Click += new System.EventHandler(this.toolStripMenuItem8_Click);
            // 
            // cMSMAJExemplairePerdu
            // 
            this.cMSMAJExemplairePerdu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem9,
            this.toolStripMenuItem10});
            this.cMSMAJExemplairePerdu.Name = "cMSMAJBienDéplacé";
            this.cMSMAJExemplairePerdu.Size = new System.Drawing.Size(242, 48);
            // 
            // toolStripMenuItem9
            // 
            this.toolStripMenuItem9.Name = "toolStripMenuItem9";
            this.toolStripMenuItem9.Size = new System.Drawing.Size(241, 22);
            this.toolStripMenuItem9.Text = "MAJ exemplaire(s) perdu(s)";
            this.toolStripMenuItem9.Click += new System.EventHandler(this.toolStripMenuItem9_Click);
            // 
            // toolStripMenuItem10
            // 
            this.toolStripMenuItem10.Name = "toolStripMenuItem10";
            this.toolStripMenuItem10.Size = new System.Drawing.Size(241, 22);
            this.toolStripMenuItem10.Text = "MAJ tous les exemplaires perdus";
            this.toolStripMenuItem10.Click += new System.EventHandler(this.toolStripMenuItem10_Click);
            // 
            // Comparer2Inventaires
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 420);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(982, 454);
            this.Name = "Comparer2Inventaires";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Comparer deux inventaires";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.cMSMAJBienDéplacé.ResumeLayout(false);
            this.cMSMAJBienPerdu.ResumeLayout(false);
            this.cMSMAJBienRetrouvé.ResumeLayout(false);
            this.cMSMAJExemplaireDéplacé.ResumeLayout(false);
            this.cMSMAJExemplaireRetrouvé.ResumeLayout(false);
            this.cMSMAJExemplairePerdu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList mesIcones;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListView listViewBien;
        public System.Windows.Forms.TreeView treeViewEmplacement;
        private System.Windows.Forms.ComboBox comboBoxSite;
        private System.Windows.Forms.ColumnHeader columnIdentifiant;
        private System.Windows.Forms.ColumnHeader columnDesignation;
        private System.Windows.Forms.ColumnHeader columnCatégorie;
        private System.Windows.Forms.ColumnHeader columnDateAcquisitionBien;
        private System.Windows.Forms.ColumnHeader columnEtatInit;
        private System.Windows.Forms.ColumnHeader columnPrix;
        private System.Windows.Forms.ColumnHeader columnParticularité;
        private System.Windows.Forms.ColumnHeader columnEmplacementAvant;
        private System.Windows.Forms.ColumnHeader columnEmplacementAprès;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttoncomparer;
        private System.Windows.Forms.ComboBox comboBoxReference;
        private System.Windows.Forms.ComboBox comboBoxAcomparer;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button buttonRapport;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.CheckBox cBSelectTousNoeuds;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button bMAJBiensRetrouvés;
        private System.Windows.Forms.Button bMAJBiensDéplacés;
        private System.Windows.Forms.Button bMAJBiensPerdus;
        private System.Windows.Forms.Button bMAJBiens;
        private System.Windows.Forms.ContextMenuStrip cMSMAJBienDéplacé;
        private System.Windows.Forms.ToolStripMenuItem mAJBiensDéplacésToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mAJTousLesBiensDéplacésToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip cMSMAJBienPerdu;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ContextMenuStrip cMSMAJBienRetrouvé;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ContextMenuStrip cMSMAJExemplaireDéplacé;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ContextMenuStrip cMSMAJExemplaireRetrouvé;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem8;
        private System.Windows.Forms.ContextMenuStrip cMSMAJExemplairePerdu;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem9;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem10;
        private System.Windows.Forms.ToolStripStatusLabel tSSL;
        private System.Windows.Forms.ColumnHeader columnEtatFin;
    }
}

