namespace solution1
{
    partial class MAJCession
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
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.id_client = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nom_client = new System.Windows.Forms.TextBox();
            this.dTPDateCession = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tBNumFacture = new System.Windows.Forms.TextBox();
            this.tBIdPVCession = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rBTousClient = new System.Windows.Forms.RadioButton();
            this.rBRaisonSociale = new System.Windows.Forms.RadioButton();
            this.dGVClients = new System.Windows.Forms.DataGridView();
            this.ColumnIdClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSpécialité = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnModifier = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ColumnSupprimer = new System.Windows.Forms.DataGridViewButtonColumn();
            this.rBIdentifiant = new System.Windows.Forms.RadioButton();
            this.tBIdentifiantClient = new System.Windows.Forms.TextBox();
            this.tBRaisonSociale = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dGVBienCédé = new System.Windows.Forms.DataGridView();
            this.ColumnIdBienCédé = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAncienCodeCédé = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDésignationCédé = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCatégorieCédé = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDateAcquisitionCédé = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEtatCédé = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPrixCédé = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPrixCession = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnParticularitéCédé = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rBDésignation = new System.Windows.Forms.RadioButton();
            this.rBAncienCode = new System.Windows.Forms.RadioButton();
            this.rBIdBien = new System.Windows.Forms.RadioButton();
            this.rBTousBien = new System.Windows.Forms.RadioButton();
            this.dGVBiens = new System.Windows.Forms.DataGridView();
            this.ColumnCeder = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ColumnIdBien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAncienCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDésignation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCatégorie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDateAcquisition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColyumnEtat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPrix = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnParticularité = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tBDésignation = new System.Windows.Forms.TextBox();
            this.tBAncienCode = new System.Windows.Forms.TextBox();
            this.tBIdBien = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tabPage1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVClients)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVBienCédé)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVBiens)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Gainsboro;
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1336, 636);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "PV de cession";
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.id_client);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.nom_client);
            this.groupBox4.Controls.Add(this.dTPDateCession);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.tBNumFacture);
            this.groupBox4.Controls.Add(this.tBIdPVCession);
            this.groupBox4.Location = new System.Drawing.Point(6, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1324, 83);
            this.groupBox4.TabIndex = 43;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Information sur le PV";
            // 
            // id_client
            // 
            this.id_client.Location = new System.Drawing.Point(579, 55);
            this.id_client.Name = "id_client";
            this.id_client.Size = new System.Drawing.Size(198, 20);
            this.id_client.TabIndex = 44;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(333, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 43;
            this.label3.Text = "Client :";
            // 
            // nom_client
            // 
            this.nom_client.Location = new System.Drawing.Point(375, 56);
            this.nom_client.Name = "nom_client";
            this.nom_client.Size = new System.Drawing.Size(198, 20);
            this.nom_client.TabIndex = 42;
            // 
            // dTPDateCession
            // 
            this.dTPDateCession.Enabled = false;
            this.dTPDateCession.Location = new System.Drawing.Point(378, 26);
            this.dTPDateCession.Name = "dTPDateCession";
            this.dTPDateCession.Size = new System.Drawing.Size(175, 20);
            this.dTPDateCession.TabIndex = 41;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(336, 29);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(36, 13);
            this.label14.TabIndex = 40;
            this.label14.Text = "Date :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 39;
            this.label2.Text = "Num facture :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 38;
            this.label1.Text = "N° PV de cession :";
            // 
            // tBNumFacture
            // 
            this.tBNumFacture.Location = new System.Drawing.Point(129, 52);
            this.tBNumFacture.Name = "tBNumFacture";
            this.tBNumFacture.Size = new System.Drawing.Size(198, 20);
            this.tBNumFacture.TabIndex = 37;
            // 
            // tBIdPVCession
            // 
            this.tBIdPVCession.BackColor = System.Drawing.Color.Gainsboro;
            this.tBIdPVCession.Location = new System.Drawing.Point(129, 26);
            this.tBIdPVCession.Name = "tBIdPVCession";
            this.tBIdPVCession.ReadOnly = true;
            this.tBIdPVCession.Size = new System.Drawing.Size(198, 20);
            this.tBIdPVCession.TabIndex = 36;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.rBTousClient);
            this.groupBox3.Controls.Add(this.rBRaisonSociale);
            this.groupBox3.Controls.Add(this.dGVClients);
            this.groupBox3.Controls.Add(this.rBIdentifiant);
            this.groupBox3.Controls.Add(this.tBIdentifiantClient);
            this.groupBox3.Controls.Add(this.tBRaisonSociale);
            this.groupBox3.Location = new System.Drawing.Point(6, 95);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1324, 142);
            this.groupBox3.TabIndex = 42;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Selection du client auquel vont être cédés les biens";
            // 
            // rBTousClient
            // 
            this.rBTousClient.AutoSize = true;
            this.rBTousClient.Checked = true;
            this.rBTousClient.Location = new System.Drawing.Point(11, 34);
            this.rBTousClient.Name = "rBTousClient";
            this.rBTousClient.Size = new System.Drawing.Size(49, 17);
            this.rBTousClient.TabIndex = 39;
            this.rBTousClient.TabStop = true;
            this.rBTousClient.Text = "Tous";
            this.rBTousClient.UseVisualStyleBackColor = true;
            this.rBTousClient.CheckedChanged += new System.EventHandler(this.rBTous_CheckedChanged);
            // 
            // rBRaisonSociale
            // 
            this.rBRaisonSociale.AutoSize = true;
            this.rBRaisonSociale.Location = new System.Drawing.Point(11, 80);
            this.rBRaisonSociale.Name = "rBRaisonSociale";
            this.rBRaisonSociale.Size = new System.Drawing.Size(94, 17);
            this.rBRaisonSociale.TabIndex = 41;
            this.rBRaisonSociale.TabStop = true;
            this.rBRaisonSociale.Text = "Raison sociale";
            this.rBRaisonSociale.UseVisualStyleBackColor = true;
            this.rBRaisonSociale.CheckedChanged += new System.EventHandler(this.rBRaisonSociale_CheckedChanged);
            // 
            // dGVClients
            // 
            this.dGVClients.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dGVClients.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dGVClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVClients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnIdClient,
            this.ColumnNom,
            this.ColumnSpécialité,
            this.ColumnModifier,
            this.ColumnSupprimer});
            this.dGVClients.Location = new System.Drawing.Point(339, 22);
            this.dGVClients.MultiSelect = false;
            this.dGVClients.Name = "dGVClients";
            this.dGVClients.Size = new System.Drawing.Size(979, 114);
            this.dGVClients.TabIndex = 36;
            this.dGVClients.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVClients_CellClick);
            this.dGVClients.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dGVClients_CellPainting);
            this.dGVClients.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dGVClients_RowHeaderMouseClick);
            // 
            // ColumnIdClient
            // 
            this.ColumnIdClient.HeaderText = "Identifiant";
            this.ColumnIdClient.Name = "ColumnIdClient";
            // 
            // ColumnNom
            // 
            this.ColumnNom.HeaderText = "Nom";
            this.ColumnNom.Name = "ColumnNom";
            this.ColumnNom.Width = 240;
            // 
            // ColumnSpécialité
            // 
            this.ColumnSpécialité.HeaderText = "Spécialité";
            this.ColumnSpécialité.Name = "ColumnSpécialité";
            this.ColumnSpécialité.Width = 525;
            // 
            // ColumnModifier
            // 
            this.ColumnModifier.HeaderText = "";
            this.ColumnModifier.Name = "ColumnModifier";
            this.ColumnModifier.Width = 25;
            // 
            // ColumnSupprimer
            // 
            this.ColumnSupprimer.HeaderText = "";
            this.ColumnSupprimer.Name = "ColumnSupprimer";
            this.ColumnSupprimer.Width = 25;
            // 
            // rBIdentifiant
            // 
            this.rBIdentifiant.AutoSize = true;
            this.rBIdentifiant.Location = new System.Drawing.Point(11, 57);
            this.rBIdentifiant.Name = "rBIdentifiant";
            this.rBIdentifiant.Size = new System.Drawing.Size(71, 17);
            this.rBIdentifiant.TabIndex = 40;
            this.rBIdentifiant.TabStop = true;
            this.rBIdentifiant.Text = "Identifiant";
            this.rBIdentifiant.UseVisualStyleBackColor = true;
            this.rBIdentifiant.CheckedChanged += new System.EventHandler(this.rBIdentifiant_CheckedChanged);
            // 
            // tBIdentifiantClient
            // 
            this.tBIdentifiantClient.Location = new System.Drawing.Point(126, 56);
            this.tBIdentifiantClient.Name = "tBIdentifiantClient";
            this.tBIdentifiantClient.Size = new System.Drawing.Size(198, 20);
            this.tBIdentifiantClient.TabIndex = 37;
            this.tBIdentifiantClient.TextChanged += new System.EventHandler(this.tBIdentifiant_TextChanged);
            // 
            // tBRaisonSociale
            // 
            this.tBRaisonSociale.Location = new System.Drawing.Point(126, 79);
            this.tBRaisonSociale.Name = "tBRaisonSociale";
            this.tBRaisonSociale.Size = new System.Drawing.Size(198, 20);
            this.tBRaisonSociale.TabIndex = 38;
            this.tBRaisonSociale.TextChanged += new System.EventHandler(this.tBRaisonSociale_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.dGVBienCédé);
            this.groupBox2.Location = new System.Drawing.Point(6, 446);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1324, 184);
            this.groupBox2.TabIndex = 31;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Les biens cédés";
            // 
            // dGVBienCédé
            // 
            this.dGVBienCédé.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dGVBienCédé.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dGVBienCédé.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVBienCédé.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnIdBienCédé,
            this.ColumnAncienCodeCédé,
            this.ColumnDésignationCédé,
            this.ColumnCatégorieCédé,
            this.ColumnDateAcquisitionCédé,
            this.ColumnEtatCédé,
            this.ColumnPrixCédé,
            this.ColumnPrixCession,
            this.ColumnParticularitéCédé});
            this.dGVBienCédé.Location = new System.Drawing.Point(11, 16);
            this.dGVBienCédé.Name = "dGVBienCédé";
            this.dGVBienCédé.Size = new System.Drawing.Size(1307, 162);
            this.dGVBienCédé.TabIndex = 33;
            this.dGVBienCédé.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVBienCédé_CellEndEdit);
            // 
            // ColumnIdBienCédé
            // 
            this.ColumnIdBienCédé.HeaderText = "Identifiant";
            this.ColumnIdBienCédé.Name = "ColumnIdBienCédé";
            this.ColumnIdBienCédé.ReadOnly = true;
            // 
            // ColumnAncienCodeCédé
            // 
            this.ColumnAncienCodeCédé.HeaderText = "Ancien code";
            this.ColumnAncienCodeCédé.Name = "ColumnAncienCodeCédé";
            this.ColumnAncienCodeCédé.ReadOnly = true;
            // 
            // ColumnDésignationCédé
            // 
            this.ColumnDésignationCédé.HeaderText = "Désignation";
            this.ColumnDésignationCédé.Name = "ColumnDésignationCédé";
            this.ColumnDésignationCédé.ReadOnly = true;
            // 
            // ColumnCatégorieCédé
            // 
            this.ColumnCatégorieCédé.HeaderText = "Catégorie";
            this.ColumnCatégorieCédé.Name = "ColumnCatégorieCédé";
            this.ColumnCatégorieCédé.ReadOnly = true;
            // 
            // ColumnDateAcquisitionCédé
            // 
            this.ColumnDateAcquisitionCédé.HeaderText = "Acquisition";
            this.ColumnDateAcquisitionCédé.Name = "ColumnDateAcquisitionCédé";
            this.ColumnDateAcquisitionCédé.ReadOnly = true;
            // 
            // ColumnEtatCédé
            // 
            this.ColumnEtatCédé.HeaderText = "Etat";
            this.ColumnEtatCédé.Name = "ColumnEtatCédé";
            this.ColumnEtatCédé.ReadOnly = true;
            // 
            // ColumnPrixCédé
            // 
            this.ColumnPrixCédé.HeaderText = "Prix d\'acquisition";
            this.ColumnPrixCédé.Name = "ColumnPrixCédé";
            this.ColumnPrixCédé.ReadOnly = true;
            this.ColumnPrixCédé.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnPrixCédé.Width = 130;
            // 
            // ColumnPrixCession
            // 
            this.ColumnPrixCession.HeaderText = "Prix de cession";
            this.ColumnPrixCession.Name = "ColumnPrixCession";
            this.ColumnPrixCession.Width = 130;
            // 
            // ColumnParticularitéCédé
            // 
            this.ColumnParticularitéCédé.HeaderText = "Particularité";
            this.ColumnParticularitéCédé.Name = "ColumnParticularitéCédé";
            this.ColumnParticularitéCédé.ReadOnly = true;
            this.ColumnParticularitéCédé.Width = 383;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.rBDésignation);
            this.groupBox1.Controls.Add(this.rBAncienCode);
            this.groupBox1.Controls.Add(this.rBIdBien);
            this.groupBox1.Controls.Add(this.rBTousBien);
            this.groupBox1.Controls.Add(this.dGVBiens);
            this.groupBox1.Controls.Add(this.tBDésignation);
            this.groupBox1.Controls.Add(this.tBAncienCode);
            this.groupBox1.Controls.Add(this.tBIdBien);
            this.groupBox1.Location = new System.Drawing.Point(6, 243);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1324, 197);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rechercher un bien";
            // 
            // rBDésignation
            // 
            this.rBDésignation.AutoSize = true;
            this.rBDésignation.Location = new System.Drawing.Point(11, 99);
            this.rBDésignation.Name = "rBDésignation";
            this.rBDésignation.Size = new System.Drawing.Size(87, 17);
            this.rBDésignation.TabIndex = 36;
            this.rBDésignation.Text = "Désignation :";
            this.rBDésignation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rBDésignation.UseVisualStyleBackColor = true;
            this.rBDésignation.CheckedChanged += new System.EventHandler(this.rBDésignation_CheckedChanged);
            // 
            // rBAncienCode
            // 
            this.rBAncienCode.AutoSize = true;
            this.rBAncienCode.Location = new System.Drawing.Point(11, 76);
            this.rBAncienCode.Name = "rBAncienCode";
            this.rBAncienCode.Size = new System.Drawing.Size(85, 17);
            this.rBAncienCode.TabIndex = 35;
            this.rBAncienCode.Text = "Ancien code";
            this.rBAncienCode.UseVisualStyleBackColor = true;
            this.rBAncienCode.CheckedChanged += new System.EventHandler(this.rBAncienCode_CheckedChanged);
            // 
            // rBIdBien
            // 
            this.rBIdBien.AutoSize = true;
            this.rBIdBien.Location = new System.Drawing.Point(11, 53);
            this.rBIdBien.Name = "rBIdBien";
            this.rBIdBien.Size = new System.Drawing.Size(115, 17);
            this.rBIdBien.TabIndex = 34;
            this.rBIdBien.Text = "Identifiant du bien :";
            this.rBIdBien.UseVisualStyleBackColor = true;
            this.rBIdBien.CheckedChanged += new System.EventHandler(this.rBIdBien_CheckedChanged);
            // 
            // rBTousBien
            // 
            this.rBTousBien.AutoSize = true;
            this.rBTousBien.Checked = true;
            this.rBTousBien.Location = new System.Drawing.Point(11, 30);
            this.rBTousBien.Name = "rBTousBien";
            this.rBTousBien.Size = new System.Drawing.Size(49, 17);
            this.rBTousBien.TabIndex = 33;
            this.rBTousBien.TabStop = true;
            this.rBTousBien.Text = "Tous";
            this.rBTousBien.UseVisualStyleBackColor = true;
            this.rBTousBien.CheckedChanged += new System.EventHandler(this.rBTousBien_CheckedChanged);
            // 
            // dGVBiens
            // 
            this.dGVBiens.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dGVBiens.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dGVBiens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVBiens.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnCeder,
            this.ColumnIdBien,
            this.ColumnAncienCode,
            this.ColumnDésignation,
            this.ColumnCatégorie,
            this.ColumnDateAcquisition,
            this.ColyumnEtat,
            this.ColumnPrix,
            this.ColumnParticularité});
            this.dGVBiens.Location = new System.Drawing.Point(339, 19);
            this.dGVBiens.Name = "dGVBiens";
            this.dGVBiens.Size = new System.Drawing.Size(979, 172);
            this.dGVBiens.TabIndex = 32;
            this.dGVBiens.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVBiens_CellClick);
            this.dGVBiens.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dGVBiens_CellPainting);
            // 
            // ColumnCeder
            // 
            this.ColumnCeder.HeaderText = "";
            this.ColumnCeder.Name = "ColumnCeder";
            this.ColumnCeder.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnCeder.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ColumnCeder.Width = 25;
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
            this.ColumnParticularité.Width = 190;
            // 
            // tBDésignation
            // 
            this.tBDésignation.Location = new System.Drawing.Point(126, 98);
            this.tBDésignation.Name = "tBDésignation";
            this.tBDésignation.Size = new System.Drawing.Size(198, 20);
            this.tBDésignation.TabIndex = 3;
            this.tBDésignation.TextChanged += new System.EventHandler(this.tBDésignation_TextChanged);
            // 
            // tBAncienCode
            // 
            this.tBAncienCode.Location = new System.Drawing.Point(126, 75);
            this.tBAncienCode.Name = "tBAncienCode";
            this.tBAncienCode.Size = new System.Drawing.Size(198, 20);
            this.tBAncienCode.TabIndex = 2;
            this.tBAncienCode.TextChanged += new System.EventHandler(this.tBAncienCode_TextChanged);
            // 
            // tBIdBien
            // 
            this.tBIdBien.Location = new System.Drawing.Point(126, 52);
            this.tBIdBien.Name = "tBIdBien";
            this.tBIdBien.Size = new System.Drawing.Size(198, 20);
            this.tBIdBien.TabIndex = 1;
            this.tBIdBien.TextChanged += new System.EventHandler(this.tBIdBien_TextChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(10, 9);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1344, 662);
            this.tabControl1.TabIndex = 32;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1198, 677);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 34;
            this.button2.Text = "Annuler";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1279, 677);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 33;
            this.button1.Text = "Valider";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MAJCession
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1366, 712);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tabControl1);
            this.Name = "MAJCession";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PV de cession du ";
            this.Load += new System.EventHandler(this.MAJCession_Load);
            this.tabPage1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVClients)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGVBienCédé)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVBiens)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dGVClients;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dGVBiens;
        private System.Windows.Forms.TextBox tBDésignation;
        private System.Windows.Forms.TextBox tBAncienCode;
        private System.Windows.Forms.TextBox tBIdBien;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DateTimePicker dTPDateCession;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tBNumFacture;
        private System.Windows.Forms.TextBox tBIdPVCession;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rBTousClient;
        private System.Windows.Forms.RadioButton rBRaisonSociale;
        private System.Windows.Forms.RadioButton rBIdentifiant;
        private System.Windows.Forms.TextBox tBIdentifiantClient;
        private System.Windows.Forms.TextBox tBRaisonSociale;
        private System.Windows.Forms.RadioButton rBDésignation;
        private System.Windows.Forms.RadioButton rBAncienCode;
        private System.Windows.Forms.RadioButton rBIdBien;
        private System.Windows.Forms.RadioButton rBTousBien;
        private System.Windows.Forms.DataGridView dGVBienCédé;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnIdClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNom;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSpécialité;
        private System.Windows.Forms.DataGridViewButtonColumn ColumnModifier;
        private System.Windows.Forms.DataGridViewButtonColumn ColumnSupprimer;
        private System.Windows.Forms.DataGridViewButtonColumn ColumnCeder;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnIdBien;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAncienCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDésignation;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCatégorie;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDateAcquisition;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColyumnEtat;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPrix;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnParticularité;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnIdBienCédé;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAncienCodeCédé;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDésignationCédé;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCatégorieCédé;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDateAcquisitionCédé;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEtatCédé;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPrixCédé;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPrixCession;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnParticularitéCédé;
        private System.Windows.Forms.TextBox id_client;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nom_client;

    }
}