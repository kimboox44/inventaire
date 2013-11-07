namespace ProjectPFE
{
    partial class import
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
            this.wizardControl1 = new DevExpress.XtraWizard.WizardControl();
            this.welcomeWizardPage1 = new DevExpress.XtraWizard.WelcomeWizardPage();
            this.wizardPage1 = new DevExpress.XtraWizard.WizardPage();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.butparcourir = new System.Windows.Forms.Button();
            this.txtChemin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.radbutXml = new System.Windows.Forms.RadioButton();
            this.radbutExcel = new System.Windows.Forms.RadioButton();
            this.completionWizardPage1 = new DevExpress.XtraWizard.CompletionWizardPage();
            this.wizardPage2 = new DevExpress.XtraWizard.WizardPage();
            this.butImporter = new System.Windows.Forms.Button();
            this.butVlidSchema = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.comboTableBD = new System.Windows.Forms.ComboBox();
            this.dsDest1 = new ProjectPFE.dsDest();
            this.dgvcorrespondance = new System.Windows.Forms.DataGridView();
            this.coldest = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colonne = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colsource = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.wizardPage3 = new DevExpress.XtraWizard.WizardPage();
            this.txtLigneimporté = new System.Windows.Forms.TextBox();
            this.txtLigneFichier = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvLignenonimporté = new System.Windows.Forms.DataGridView();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.daDest = new System.Data.SqlClient.SqlDataAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.wizardControl1)).BeginInit();
            this.wizardControl1.SuspendLayout();
            this.wizardPage1.SuspendLayout();
            this.wizardPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsDest1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcorrespondance)).BeginInit();
            this.wizardPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLignenonimporté)).BeginInit();
            this.SuspendLayout();
            // 
            // wizardControl1
            // 
            this.wizardControl1.Controls.Add(this.welcomeWizardPage1);
            this.wizardControl1.Controls.Add(this.wizardPage1);
            this.wizardControl1.Controls.Add(this.completionWizardPage1);
            this.wizardControl1.Controls.Add(this.wizardPage2);
            this.wizardControl1.Controls.Add(this.wizardPage3);
            this.wizardControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wizardControl1.Location = new System.Drawing.Point(0, 0);
            this.wizardControl1.Name = "wizardControl1";
            this.wizardControl1.Pages.AddRange(new DevExpress.XtraWizard.BaseWizardPage[] {
            this.welcomeWizardPage1,
            this.wizardPage1,
            this.wizardPage2,
            this.wizardPage3,
            this.completionWizardPage1});
            this.wizardControl1.Size = new System.Drawing.Size(509, 423);
            this.wizardControl1.Text = "";
            // 
            // welcomeWizardPage1
            // 
            this.welcomeWizardPage1.IntroductionText = "Cet Assistant vous permettra d\'importer des données de fichiers Excel ou XMLvers " +
                "votre base de données. Veuillez suivre les étapes qui suivent.\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n" +
                "";
            this.welcomeWizardPage1.Name = "welcomeWizardPage1";
            this.welcomeWizardPage1.ProceedText = "Pour continuer, cliquez sur Next";
            this.welcomeWizardPage1.Size = new System.Drawing.Size(292, 267);
            this.welcomeWizardPage1.Text = "Bienvenue à l\'assistant d\'import de données";
            // 
            // wizardPage1
            // 
            this.wizardPage1.Controls.Add(this.label3);
            this.wizardPage1.Controls.Add(this.label2);
            this.wizardPage1.Controls.Add(this.butparcourir);
            this.wizardPage1.Controls.Add(this.txtChemin);
            this.wizardPage1.Controls.Add(this.label1);
            this.wizardPage1.Controls.Add(this.radbutXml);
            this.wizardPage1.Controls.Add(this.radbutExcel);
            this.wizardPage1.DescriptionText = "";
            this.wizardPage1.Name = "wizardPage1";
            this.wizardPage1.Size = new System.Drawing.Size(477, 278);
            this.wizardPage1.Text = "Selectionnez quel type de fichier et le fichier à importer";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Choisissez le fichier\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "le type du fichier";
            // 
            // butparcourir
            // 
            this.butparcourir.Location = new System.Drawing.Point(396, 190);
            this.butparcourir.Name = "butparcourir";
            this.butparcourir.Size = new System.Drawing.Size(35, 22);
            this.butparcourir.TabIndex = 4;
            this.butparcourir.Text = "....";
            this.butparcourir.UseVisualStyleBackColor = true;
            this.butparcourir.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtChemin
            // 
            this.txtChemin.Location = new System.Drawing.Point(152, 190);
            this.txtChemin.Name = "txtChemin";
            this.txtChemin.Size = new System.Drawing.Size(238, 21);
            this.txtChemin.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Chemin d\'accés au fichier";
            // 
            // radbutXml
            // 
            this.radbutXml.AutoSize = true;
            this.radbutXml.Location = new System.Drawing.Point(22, 85);
            this.radbutXml.Name = "radbutXml";
            this.radbutXml.Size = new System.Drawing.Size(78, 17);
            this.radbutXml.TabIndex = 1;
            this.radbutXml.TabStop = true;
            this.radbutXml.Text = "Fichier XML";
            this.radbutXml.UseVisualStyleBackColor = true;
            // 
            // radbutExcel
            // 
            this.radbutExcel.AutoSize = true;
            this.radbutExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.radbutExcel.Location = new System.Drawing.Point(22, 48);
            this.radbutExcel.Name = "radbutExcel";
            this.radbutExcel.Size = new System.Drawing.Size(84, 17);
            this.radbutExcel.TabIndex = 0;
            this.radbutExcel.TabStop = true;
            this.radbutExcel.Text = "Fichier Excel";
            this.radbutExcel.UseVisualStyleBackColor = true;
            // 
            // completionWizardPage1
            // 
            this.completionWizardPage1.Name = "completionWizardPage1";
            this.completionWizardPage1.Size = new System.Drawing.Size(292, 290);
            // 
            // wizardPage2
            // 
            this.wizardPage2.Controls.Add(this.butImporter);
            this.wizardPage2.Controls.Add(this.butVlidSchema);
            this.wizardPage2.Controls.Add(this.label4);
            this.wizardPage2.Controls.Add(this.comboTableBD);
            this.wizardPage2.Controls.Add(this.dgvcorrespondance);
            this.wizardPage2.DescriptionText = "";
            this.wizardPage2.Name = "wizardPage2";
            this.wizardPage2.Size = new System.Drawing.Size(477, 278);
            this.wizardPage2.Text = "Selectionnez la liste des colonnes à importer du fichier";
            // 
            // butImporter
            // 
            this.butImporter.Enabled = false;
            this.butImporter.Location = new System.Drawing.Point(315, 234);
            this.butImporter.Name = "butImporter";
            this.butImporter.Size = new System.Drawing.Size(127, 25);
            this.butImporter.TabIndex = 4;
            this.butImporter.Text = "Importer les données";
            this.butImporter.UseVisualStyleBackColor = true;
            this.butImporter.Click += new System.EventHandler(this.butImporter_Click);
            // 
            // butVlidSchema
            // 
            this.butVlidSchema.Location = new System.Drawing.Point(315, 203);
            this.butVlidSchema.Name = "butVlidSchema";
            this.butVlidSchema.Size = new System.Drawing.Size(127, 25);
            this.butVlidSchema.TabIndex = 3;
            this.butVlidSchema.Text = "Valider le schema";
            this.butVlidSchema.UseVisualStyleBackColor = true;
            this.butVlidSchema.Click += new System.EventHandler(this.butVlidSchema_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Table Destination";
            // 
            // comboTableBD
            // 
            this.comboTableBD.DataSource = this.dsDest1;
            this.comboTableBD.DisplayMember = "TABLES.TABLE_NAME";
            this.comboTableBD.FormattingEnabled = true;
            this.comboTableBD.Location = new System.Drawing.Point(175, 17);
            this.comboTableBD.Name = "comboTableBD";
            this.comboTableBD.Size = new System.Drawing.Size(244, 21);
            this.comboTableBD.TabIndex = 1;
            this.comboTableBD.ValueMember = "TABLES.TABLE_NAME";
            this.comboTableBD.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dsDest1
            // 
            this.dsDest1.DataSetName = "dsDest";
            this.dsDest1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dgvcorrespondance
            // 
            this.dgvcorrespondance.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvcorrespondance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvcorrespondance.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.coldest,
            this.colonne,
            this.colsource});
            this.dgvcorrespondance.Location = new System.Drawing.Point(15, 73);
            this.dgvcorrespondance.Name = "dgvcorrespondance";
            this.dgvcorrespondance.Size = new System.Drawing.Size(427, 112);
            this.dgvcorrespondance.TabIndex = 0;
            // 
            // coldest
            // 
            this.coldest.HeaderText = "column destination";
            this.coldest.Name = "coldest";
            // 
            // colonne
            // 
            this.colonne.HeaderText = "colonne";
            this.colonne.Name = "colonne";
            // 
            // colsource
            // 
            this.colsource.HeaderText = "colonne source";
            this.colsource.Name = "colsource";
            // 
            // wizardPage3
            // 
            this.wizardPage3.Controls.Add(this.txtLigneimporté);
            this.wizardPage3.Controls.Add(this.txtLigneFichier);
            this.wizardPage3.Controls.Add(this.label7);
            this.wizardPage3.Controls.Add(this.label6);
            this.wizardPage3.Controls.Add(this.label5);
            this.wizardPage3.Controls.Add(this.dgvLignenonimporté);
            this.wizardPage3.DescriptionText = "";
            this.wizardPage3.Name = "wizardPage3";
            this.wizardPage3.Size = new System.Drawing.Size(477, 278);
            this.wizardPage3.Text = "Compte rendu de l\'import";
            // 
            // txtLigneimporté
            // 
            this.txtLigneimporté.Location = new System.Drawing.Point(165, 36);
            this.txtLigneimporté.Name = "txtLigneimporté";
            this.txtLigneimporté.Size = new System.Drawing.Size(148, 21);
            this.txtLigneimporté.TabIndex = 5;
            // 
            // txtLigneFichier
            // 
            this.txtLigneFichier.Location = new System.Drawing.Point(165, 9);
            this.txtLigneFichier.Name = "txtLigneFichier";
            this.txtLigneFichier.Size = new System.Drawing.Size(148, 21);
            this.txtLigneFichier.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(162, 83);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Les lignes non importées";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Nombre de lignes importées";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Nombre de lignes à importer";
            // 
            // dgvLignenonimporté
            // 
            this.dgvLignenonimporté.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLignenonimporté.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLignenonimporté.Location = new System.Drawing.Point(15, 110);
            this.dgvLignenonimporté.Name = "dgvLignenonimporté";
            this.dgvLignenonimporté.Size = new System.Drawing.Size(438, 139);
            this.dgvLignenonimporté.TabIndex = 0;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // sqlSelectCommand1
            // 
            this.sqlSelectCommand1.CommandText = "SELECT        TABLE_NAME\r\nFROM            INFORMATION_SCHEMA.TABLES\r\nWHERE       " +
                " (TABLE_TYPE = \'BASE TABLE\')";
            this.sqlSelectCommand1.Connection = this.sqlConnection1;
            // 
            // sqlConnection1
            // 
            this.sqlConnection1.ConnectionString = "Data Source=SOUAD;Initial Catalog=ProjectPFE;Integrated Security=True";
            this.sqlConnection1.FireInfoMessageEventOnUserErrors = false;
            // 
            // daDest
            // 
            this.daDest.SelectCommand = this.sqlSelectCommand1;
            this.daDest.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "TABLES", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("TABLE_NAME", "TABLE_NAME")})});
            // 
            // import
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 423);
            this.Controls.Add(this.wizardControl1);
            this.Name = "import";
            this.Text = "import";
            this.Load += new System.EventHandler(this.import_Load);
            ((System.ComponentModel.ISupportInitialize)(this.wizardControl1)).EndInit();
            this.wizardControl1.ResumeLayout(false);
            this.wizardPage1.ResumeLayout(false);
            this.wizardPage1.PerformLayout();
            this.wizardPage2.ResumeLayout(false);
            this.wizardPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsDest1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcorrespondance)).EndInit();
            this.wizardPage3.ResumeLayout(false);
            this.wizardPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLignenonimporté)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraWizard.WizardControl wizardControl1;
        private DevExpress.XtraWizard.WelcomeWizardPage welcomeWizardPage1;
        private DevExpress.XtraWizard.WizardPage wizardPage1;
        private DevExpress.XtraWizard.CompletionWizardPage completionWizardPage1;
        private DevExpress.XtraWizard.WizardPage wizardPage2;
        private System.Windows.Forms.Button butparcourir;
        private System.Windows.Forms.TextBox txtChemin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radbutXml;
        private System.Windows.Forms.RadioButton radbutExcel;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private dsDest dsDest1;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
        private System.Data.SqlClient.SqlConnection sqlConnection1;
        private System.Data.SqlClient.SqlDataAdapter daDest;
        private System.Windows.Forms.ComboBox comboTableBD;
        private System.Windows.Forms.DataGridView dgvcorrespondance;
        private DevExpress.XtraWizard.WizardPage wizardPage3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn coldest;
        private System.Windows.Forms.DataGridViewTextBoxColumn colonne;
        private System.Windows.Forms.DataGridViewComboBoxColumn colsource;
        private System.Windows.Forms.Button butVlidSchema;
        private System.Windows.Forms.DataGridView dgvLignenonimporté;
        private System.Windows.Forms.Button butImporter;
        private System.Windows.Forms.TextBox txtLigneimporté;
        private System.Windows.Forms.TextBox txtLigneFichier;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}