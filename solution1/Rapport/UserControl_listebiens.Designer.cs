namespace solution1.Rapport
{
    partial class UserControl_listebiens
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.dataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet_bien = new solution1.Rapport.DataSet_bien();
            this.getImageByIDBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.getImageByIDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataTable2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox_inventaire = new System.Windows.Forms.ComboBox();
            this.bt_afficher = new System.Windows.Forms.Button();
            this.categorie_bien = new System.Windows.Forms.TextBox();
            this.radioBt_categorie = new System.Windows.Forms.RadioButton();
            this.etat_bien = new System.Windows.Forms.TextBox();
            this.radioBt_etat = new System.Windows.Forms.RadioButton();
            this.designe_bien = new System.Windows.Forms.TextBox();
            this.radioBt_desgbien = new System.Windows.Forms.RadioButton();
            this.idbien = new System.Windows.Forms.TextBox();
            this.radioBt_idbien = new System.Windows.Forms.RadioButton();
            this.ancien_code = new System.Windows.Forms.TextBox();
            this.radioBt_anciencode = new System.Windows.Forms.RadioButton();
            this.radioBt_ttbiens = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dataTable1TableAdapter = new solution1.Rapport.DataSet_bienTableAdapters.DataTable1TableAdapter();
            this.dataTable2TableAdapter = new solution1.Rapport.DataSet_bienTableAdapters.DataTable2TableAdapter();
            this.getImageByIDTableAdapter = new solution1.Rapport.DataSet_bienTableAdapters.GetImageByIDTableAdapter();
            this.DataSet_bienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_bien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getImageByIDBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getImageByIDBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable2BindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet_bienBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataTable1BindingSource
            // 
            this.dataTable1BindingSource.DataMember = "DataTable1";
            this.dataTable1BindingSource.DataSource = this.dataSet_bien;
            this.dataTable1BindingSource.CurrentChanged += new System.EventHandler(this.dataTable1BindingSource_CurrentChanged);
            // 
            // dataSet_bien
            // 
            this.dataSet_bien.DataSetName = "DataSet_bien";
            this.dataSet_bien.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // getImageByIDBindingSource1
            // 
            this.getImageByIDBindingSource1.DataMember = "GetImageByID";
            this.getImageByIDBindingSource1.DataSource = this.dataSet_bien;
            // 
            // getImageByIDBindingSource
            // 
            this.getImageByIDBindingSource.DataMember = "GetImageByID";
            this.getImageByIDBindingSource.DataSource = this.dataSet_bien;
            // 
            // dataTable2BindingSource
            // 
            this.dataTable2BindingSource.DataMember = "DataTable2";
            this.dataTable2BindingSource.DataSource = this.dataSet_bien;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboBox_inventaire);
            this.panel1.Controls.Add(this.bt_afficher);
            this.panel1.Controls.Add(this.categorie_bien);
            this.panel1.Controls.Add(this.radioBt_categorie);
            this.panel1.Controls.Add(this.etat_bien);
            this.panel1.Controls.Add(this.radioBt_etat);
            this.panel1.Controls.Add(this.designe_bien);
            this.panel1.Controls.Add(this.radioBt_desgbien);
            this.panel1.Controls.Add(this.idbien);
            this.panel1.Controls.Add(this.radioBt_idbien);
            this.panel1.Controls.Add(this.ancien_code);
            this.panel1.Controls.Add(this.radioBt_anciencode);
            this.panel1.Controls.Add(this.radioBt_ttbiens);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1019, 80);
            this.panel1.TabIndex = 0;
            // 
            // comboBox_inventaire
            // 
            this.comboBox_inventaire.DisplayMember = "Site";
            this.comboBox_inventaire.FormattingEnabled = true;
            this.comboBox_inventaire.Location = new System.Drawing.Point(85, 11);
            this.comboBox_inventaire.Name = "comboBox_inventaire";
            this.comboBox_inventaire.Size = new System.Drawing.Size(147, 21);
            this.comboBox_inventaire.TabIndex = 12;
            this.comboBox_inventaire.ValueMember = "idSite";
            this.comboBox_inventaire.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // bt_afficher
            // 
            this.bt_afficher.Location = new System.Drawing.Point(926, 15);
            this.bt_afficher.Name = "bt_afficher";
            this.bt_afficher.Size = new System.Drawing.Size(75, 48);
            this.bt_afficher.TabIndex = 11;
            this.bt_afficher.Text = "Afficher ";
            this.bt_afficher.UseVisualStyleBackColor = true;
            this.bt_afficher.Click += new System.EventHandler(this.bt_afficher_Click);
            // 
            // categorie_bien
            // 
            this.categorie_bien.Location = new System.Drawing.Point(666, 46);
            this.categorie_bien.Name = "categorie_bien";
            this.categorie_bien.Size = new System.Drawing.Size(145, 20);
            this.categorie_bien.TabIndex = 10;
            // 
            // radioBt_categorie
            // 
            this.radioBt_categorie.AutoSize = true;
            this.radioBt_categorie.Location = new System.Drawing.Point(575, 46);
            this.radioBt_categorie.Name = "radioBt_categorie";
            this.radioBt_categorie.Size = new System.Drawing.Size(70, 17);
            this.radioBt_categorie.TabIndex = 9;
            this.radioBt_categorie.TabStop = true;
            this.radioBt_categorie.Text = "Categorie";
            this.radioBt_categorie.UseVisualStyleBackColor = true;
            // 
            // etat_bien
            // 
            this.etat_bien.Location = new System.Drawing.Point(666, 15);
            this.etat_bien.Name = "etat_bien";
            this.etat_bien.Size = new System.Drawing.Size(145, 20);
            this.etat_bien.TabIndex = 8;
            // 
            // radioBt_etat
            // 
            this.radioBt_etat.AutoSize = true;
            this.radioBt_etat.Location = new System.Drawing.Point(575, 15);
            this.radioBt_etat.Name = "radioBt_etat";
            this.radioBt_etat.Size = new System.Drawing.Size(68, 17);
            this.radioBt_etat.TabIndex = 7;
            this.radioBt_etat.TabStop = true;
            this.radioBt_etat.Text = "Etat Bien";
            this.radioBt_etat.UseVisualStyleBackColor = true;
            // 
            // designe_bien
            // 
            this.designe_bien.Location = new System.Drawing.Point(379, 46);
            this.designe_bien.Name = "designe_bien";
            this.designe_bien.Size = new System.Drawing.Size(157, 20);
            this.designe_bien.TabIndex = 6;
            // 
            // radioBt_desgbien
            // 
            this.radioBt_desgbien.AutoSize = true;
            this.radioBt_desgbien.Location = new System.Drawing.Point(268, 47);
            this.radioBt_desgbien.Name = "radioBt_desgbien";
            this.radioBt_desgbien.Size = new System.Drawing.Size(105, 17);
            this.radioBt_desgbien.TabIndex = 5;
            this.radioBt_desgbien.TabStop = true;
            this.radioBt_desgbien.Text = "Designation Bien";
            this.radioBt_desgbien.UseVisualStyleBackColor = true;
            this.radioBt_desgbien.CheckedChanged += new System.EventHandler(this.radioBt_desgbien_CheckedChanged);
            // 
            // idbien
            // 
            this.idbien.Location = new System.Drawing.Point(379, 15);
            this.idbien.Name = "idbien";
            this.idbien.Size = new System.Drawing.Size(157, 20);
            this.idbien.TabIndex = 4;
            // 
            // radioBt_idbien
            // 
            this.radioBt_idbien.AutoSize = true;
            this.radioBt_idbien.Location = new System.Drawing.Point(268, 15);
            this.radioBt_idbien.Name = "radioBt_idbien";
            this.radioBt_idbien.Size = new System.Drawing.Size(95, 17);
            this.radioBt_idbien.TabIndex = 3;
            this.radioBt_idbien.TabStop = true;
            this.radioBt_idbien.Text = "Identifient Bien";
            this.radioBt_idbien.UseVisualStyleBackColor = true;
            this.radioBt_idbien.CheckedChanged += new System.EventHandler(this.radioBt_idbien_CheckedChanged);
            // 
            // ancien_code
            // 
            this.ancien_code.Location = new System.Drawing.Point(106, 47);
            this.ancien_code.Name = "ancien_code";
            this.ancien_code.Size = new System.Drawing.Size(126, 20);
            this.ancien_code.TabIndex = 2;
            // 
            // radioBt_anciencode
            // 
            this.radioBt_anciencode.AutoSize = true;
            this.radioBt_anciencode.Location = new System.Drawing.Point(15, 47);
            this.radioBt_anciencode.Name = "radioBt_anciencode";
            this.radioBt_anciencode.Size = new System.Drawing.Size(85, 17);
            this.radioBt_anciencode.TabIndex = 1;
            this.radioBt_anciencode.TabStop = true;
            this.radioBt_anciencode.Text = "Ancien code";
            this.radioBt_anciencode.UseVisualStyleBackColor = true;
            // 
            // radioBt_ttbiens
            // 
            this.radioBt_ttbiens.AutoSize = true;
            this.radioBt_ttbiens.Location = new System.Drawing.Point(817, 49);
            this.radioBt_ttbiens.Name = "radioBt_ttbiens";
            this.radioBt_ttbiens.Size = new System.Drawing.Size(80, 17);
            this.radioBt_ttbiens.TabIndex = 0;
            this.radioBt_ttbiens.TabStop = true;
            this.radioBt_ttbiens.Text = "Tous biens ";
            this.radioBt_ttbiens.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.reportViewer2);
            this.panel2.Controls.Add(this.reportViewer1);
            this.panel2.Location = new System.Drawing.Point(3, 89);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1022, 598);
            this.panel2.TabIndex = 1;
            // 
            // reportViewer2
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.dataTable2BindingSource;
            this.reportViewer2.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "solution1.Rapport.Report1.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(3, 6);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.Size = new System.Drawing.Size(1016, 592);
            this.reportViewer2.TabIndex = 1;
            this.reportViewer2.Load += new System.EventHandler(this.reportViewer2_Load);
            // 
            // reportViewer1
            // 
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.dataTable1BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "solution1.Rapport.Rapport_listebien.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(3, 3);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1016, 592);
            this.reportViewer1.TabIndex = 0;
            // 
            // dataTable1TableAdapter
            // 
            this.dataTable1TableAdapter.ClearBeforeFill = true;
            // 
            // dataTable2TableAdapter
            // 
            this.dataTable2TableAdapter.ClearBeforeFill = true;
            // 
            // getImageByIDTableAdapter
            // 
            this.getImageByIDTableAdapter.ClearBeforeFill = true;
            // 
            // DataSet_bienBindingSource
            // 
            this.DataSet_bienBindingSource.DataMember = "DataTable2";
            this.DataSet_bienBindingSource.DataSource = typeof(solution1.Rapport.DataSet_bien);
            // 
            // UserControl_listebiens
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "UserControl_listebiens";
            this.Size = new System.Drawing.Size(1034, 690);
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_bien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getImageByIDBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getImageByIDBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable2BindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataSet_bienBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioBt_ttbiens;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox ancien_code;
        private System.Windows.Forms.RadioButton radioBt_anciencode;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.TextBox categorie_bien;
        private System.Windows.Forms.RadioButton radioBt_categorie;
        private System.Windows.Forms.TextBox etat_bien;
        private System.Windows.Forms.RadioButton radioBt_etat;
        private System.Windows.Forms.TextBox designe_bien;
        private System.Windows.Forms.RadioButton radioBt_desgbien;
        private System.Windows.Forms.TextBox idbien;
        private System.Windows.Forms.RadioButton radioBt_idbien;
        private System.Windows.Forms.Button bt_afficher;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private System.Windows.Forms.ComboBox comboBox_inventaire;
        private System.Windows.Forms.BindingSource dataTable2BindingSource;
        private DataSet_bien dataSet_bien;
        private System.Windows.Forms.BindingSource dataTable1BindingSource;
        private DataSet_bienTableAdapters.DataTable1TableAdapter dataTable1TableAdapter;
        private DataSet_bienTableAdapters.DataTable2TableAdapter dataTable2TableAdapter;
        private System.Windows.Forms.BindingSource getImageByIDBindingSource;
        private DataSet_bienTableAdapters.GetImageByIDTableAdapter getImageByIDTableAdapter;
        private System.Windows.Forms.BindingSource getImageByIDBindingSource1;
        private System.Windows.Forms.BindingSource DataSet_bienBindingSource;
    }
}
