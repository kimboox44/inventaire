namespace solution1.Rapport.Traçabilité
{
    partial class taraçabilité
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
            this.designe_bien = new System.Windows.Forms.TextBox();
            this.radioBt_desgbien = new System.Windows.Forms.RadioButton();
            this.idbien = new System.Windows.Forms.TextBox();
            this.radioBt_idbien = new System.Windows.Forms.RadioButton();
            this.ancien_code = new System.Windows.Forms.TextBox();
            this.radioBt_anciencode = new System.Windows.Forms.RadioButton();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // designe_bien
            // 
            this.designe_bien.Location = new System.Drawing.Point(376, 19);
            this.designe_bien.Name = "designe_bien";
            this.designe_bien.Size = new System.Drawing.Size(157, 20);
            this.designe_bien.TabIndex = 12;
            // 
            // radioBt_desgbien
            // 
            this.radioBt_desgbien.AutoSize = true;
            this.radioBt_desgbien.Location = new System.Drawing.Point(265, 20);
            this.radioBt_desgbien.Name = "radioBt_desgbien";
            this.radioBt_desgbien.Size = new System.Drawing.Size(105, 17);
            this.radioBt_desgbien.TabIndex = 11;
            this.radioBt_desgbien.TabStop = true;
            this.radioBt_desgbien.Text = "Designation Bien";
            this.radioBt_desgbien.UseVisualStyleBackColor = true;
            // 
            // idbien
            // 
            this.idbien.Location = new System.Drawing.Point(674, 19);
            this.idbien.Name = "idbien";
            this.idbien.Size = new System.Drawing.Size(157, 20);
            this.idbien.TabIndex = 10;
            // 
            // radioBt_idbien
            // 
            this.radioBt_idbien.AutoSize = true;
            this.radioBt_idbien.Location = new System.Drawing.Point(563, 19);
            this.radioBt_idbien.Name = "radioBt_idbien";
            this.radioBt_idbien.Size = new System.Drawing.Size(95, 17);
            this.radioBt_idbien.TabIndex = 9;
            this.radioBt_idbien.TabStop = true;
            this.radioBt_idbien.Text = "Identifient Bien";
            this.radioBt_idbien.UseVisualStyleBackColor = true;
            // 
            // ancien_code
            // 
            this.ancien_code.Location = new System.Drawing.Point(103, 20);
            this.ancien_code.Name = "ancien_code";
            this.ancien_code.Size = new System.Drawing.Size(126, 20);
            this.ancien_code.TabIndex = 8;
            // 
            // radioBt_anciencode
            // 
            this.radioBt_anciencode.AutoSize = true;
            this.radioBt_anciencode.Location = new System.Drawing.Point(12, 20);
            this.radioBt_anciencode.Name = "radioBt_anciencode";
            this.radioBt_anciencode.Size = new System.Drawing.Size(85, 17);
            this.radioBt_anciencode.TabIndex = 7;
            this.radioBt_anciencode.TabStop = true;
            this.radioBt_anciencode.Text = "Ancien code";
            this.radioBt_anciencode.UseVisualStyleBackColor = true;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Location = new System.Drawing.Point(12, 55);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(858, 479);
            this.reportViewer1.TabIndex = 13;
            // 
            // taraçabilité
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.designe_bien);
            this.Controls.Add(this.radioBt_desgbien);
            this.Controls.Add(this.idbien);
            this.Controls.Add(this.radioBt_idbien);
            this.Controls.Add(this.ancien_code);
            this.Controls.Add(this.radioBt_anciencode);
            this.Name = "taraçabilité";
            this.Size = new System.Drawing.Size(881, 553);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox designe_bien;
        private System.Windows.Forms.RadioButton radioBt_desgbien;
        private System.Windows.Forms.TextBox idbien;
        private System.Windows.Forms.RadioButton radioBt_idbien;
        private System.Windows.Forms.TextBox ancien_code;
        private System.Windows.Forms.RadioButton radioBt_anciencode;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}
