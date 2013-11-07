namespace solution1.Rapport
{
    partial class UserCrt_statistique
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.BienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet_stat = new solution1.Rapport.Stat.DataSet_stat();
            this.CategorieBienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BienTableAdapter = new solution1.Rapport.Stat.DataSet_statTableAdapters.BienTableAdapter();
            this.dataSetstatBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bienTableAdapter1 = new solution1.Rapport.Stat.DataSet_statTableAdapters.BienTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.BienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet_stat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CategorieBienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetstatBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.BienBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "solution1.Rapport.Stat.Report_stat.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(3, 15);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1004, 661);
            this.reportViewer1.TabIndex = 0;
            // 
            // BienBindingSource
            // 
            this.BienBindingSource.DataMember = "Bien";
            this.BienBindingSource.DataSource = this.DataSet_stat;
            // 
            // DataSet_stat
            // 
            this.DataSet_stat.DataSetName = "DataSet_stat";
            this.DataSet_stat.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // CategorieBienBindingSource
            // 
            this.CategorieBienBindingSource.DataMember = "CategorieBien";
            this.CategorieBienBindingSource.DataSource = this.DataSet_stat;
            // 
            // BienTableAdapter
            // 
            this.BienTableAdapter.ClearBeforeFill = true;
            // 
            // dataSetstatBindingSource
            // 
            this.dataSetstatBindingSource.DataSource = this.DataSet_stat;
            this.dataSetstatBindingSource.Position = 0;
            // 
            // bienTableAdapter1
            // 
            this.bienTableAdapter1.ClearBeforeFill = true;
            // 
            // UserCrt_statistique
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.reportViewer1);
            this.Name = "UserCrt_statistique";
            this.Size = new System.Drawing.Size(1020, 690);
            this.Load += new System.EventHandler(this.UserCrt_statistique_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet_stat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CategorieBienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetstatBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource BienBindingSource;
        private Stat.DataSet_stat DataSet_stat;
        private Stat.DataSet_statTableAdapters.BienTableAdapter BienTableAdapter;
        private System.Windows.Forms.BindingSource CategorieBienBindingSource;
        private System.Windows.Forms.BindingSource dataSetstatBindingSource;
        private Stat.DataSet_statTableAdapters.BienTableAdapter bienTableAdapter1;



    }
}
