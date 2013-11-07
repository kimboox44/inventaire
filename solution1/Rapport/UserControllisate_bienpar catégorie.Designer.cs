namespace solution1.Rapport
{
    partial class UserControllisate_ibenpar_catégorie
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
            this.bien_categorieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet_bien = new solution1.Rapport.DataSet_bien();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBoxinv = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.treeViewEmplacement = new System.Windows.Forms.TreeView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bSites = new System.Windows.Forms.Button();
            this.comboBoxSite = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.bien_categorieTableAdapter = new solution1.Rapport.DataSet_bienTableAdapters.bien_categorieTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.bien_categorieBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet_bien)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // bien_categorieBindingSource
            // 
            this.bien_categorieBindingSource.DataMember = "bien categorie";
            this.bien_categorieBindingSource.DataSource = this.DataSet_bien;
            // 
            // DataSet_bien
            // 
            this.DataSet_bien.DataSetName = "DataSet_bien";
            this.DataSet_bien.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Location = new System.Drawing.Point(8, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(254, 675);
            this.panel1.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.comboBoxinv);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(10, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(235, 42);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Image = global::solution1.Properties.Resources._3D_Home_641;
            this.button1.Location = new System.Drawing.Point(205, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(23, 23);
            this.button1.TabIndex = 3;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // comboBoxinv
            // 
            this.comboBoxinv.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxinv.DisplayMember = "inv";
            this.comboBoxinv.FormattingEnabled = true;
            this.comboBoxinv.Location = new System.Drawing.Point(74, 14);
            this.comboBoxinv.Name = "comboBoxinv";
            this.comboBoxinv.Size = new System.Drawing.Size(127, 21);
            this.comboBoxinv.TabIndex = 1;
            this.comboBoxinv.ValueMember = "idinv";
            this.comboBoxinv.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Inventaire :";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.treeViewEmplacement);
            this.groupBox1.Location = new System.Drawing.Point(10, 99);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(235, 560);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // treeViewEmplacement
            // 
            this.treeViewEmplacement.AllowDrop = true;
            this.treeViewEmplacement.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.treeViewEmplacement.HideSelection = false;
            this.treeViewEmplacement.LabelEdit = true;
            this.treeViewEmplacement.Location = new System.Drawing.Point(7, 14);
            this.treeViewEmplacement.Name = "treeViewEmplacement";
            this.treeViewEmplacement.Size = new System.Drawing.Size(222, 540);
            this.treeViewEmplacement.TabIndex = 0;
            this.treeViewEmplacement.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tV_AfterSelect);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.bSites);
            this.groupBox2.Controls.Add(this.comboBoxSite);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(10, 51);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(235, 42);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            // 
            // bSites
            // 
            this.bSites.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bSites.Image = global::solution1.Properties.Resources._3D_Home_641;
            this.bSites.Location = new System.Drawing.Point(205, 13);
            this.bSites.Name = "bSites";
            this.bSites.Size = new System.Drawing.Size(23, 23);
            this.bSites.TabIndex = 3;
            this.bSites.UseVisualStyleBackColor = true;
            // 
            // comboBoxSite
            // 
            this.comboBoxSite.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxSite.DisplayMember = "Site";
            this.comboBoxSite.FormattingEnabled = true;
            this.comboBoxSite.Location = new System.Drawing.Point(47, 14);
            this.comboBoxSite.Name = "comboBoxSite";
            this.comboBoxSite.Size = new System.Drawing.Size(154, 21);
            this.comboBoxSite.TabIndex = 1;
            this.comboBoxSite.ValueMember = "idSite";
            this.comboBoxSite.SelectedIndexChanged += new System.EventHandler(this.comboBoxSite_SelectedIndexChanged);
            this.comboBoxSite.SelectedValueChanged += new System.EventHandler(this.comboBoxSite_SelectedIndexChanged);
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
            // panel2
            // 
            this.panel2.Controls.Add(this.reportViewer1);
            this.panel2.Location = new System.Drawing.Point(268, 9);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(749, 678);
            this.panel2.TabIndex = 1;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.bien_categorieBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "solution1.Rapport.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(3, 3);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(743, 672);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // bien_categorieTableAdapter
            // 
            this.bien_categorieTableAdapter.ClearBeforeFill = true;
            // 
            // UserControllisate_ibenpar_catégorie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "UserControllisate_ibenpar_catégorie";
            this.Size = new System.Drawing.Size(1020, 690);
            this.Load += new System.EventHandler(this.UserControllisate_ibenpar_catégorie_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bien_categorieBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet_bien)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button bSites;
        public System.Windows.Forms.ComboBox comboBoxSite;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.TreeView treeViewEmplacement;
        private System.Windows.Forms.Panel panel2;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource bien_categorieBindingSource;
        private DataSet_bien DataSet_bien;
        private DataSet_bienTableAdapters.bien_categorieTableAdapter bien_categorieTableAdapter;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.ComboBox comboBoxinv;
        private System.Windows.Forms.Label label2;
    }
}
