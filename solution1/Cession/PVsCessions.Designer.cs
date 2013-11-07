namespace solution1
{
    partial class PVsCessions
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
            this.rBDate = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dTPFin = new System.Windows.Forms.DateTimePicker();
            this.dTPDebut = new System.Windows.Forms.DateTimePicker();
            this.rBNumPV = new System.Windows.Forms.RadioButton();
            this.rBTous = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dGVPVCession = new System.Windows.Forms.DataGridView();
            this.ColumnIdPV = new System.Windows.Forms.DataGridViewTextBoxColumn();
         
            this.ColumnModifier = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ColumnImprimer = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tBIdPVCession = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVPVCession)).BeginInit();
            this.SuspendLayout();
            // 
            // rBDate
            // 
            this.rBDate.AutoSize = true;
            this.rBDate.Location = new System.Drawing.Point(14, 65);
            this.rBDate.Name = "rBDate";
            this.rBDate.Size = new System.Drawing.Size(54, 17);
            this.rBDate.TabIndex = 28;
            this.rBDate.Text = "Date :";
            this.rBDate.UseVisualStyleBackColor = true;
            this.rBDate.CheckedChanged += new System.EventHandler(this.rBDate_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dTPFin);
            this.groupBox1.Controls.Add(this.dTPDebut);
            this.groupBox1.Controls.Add(this.rBDate);
            this.groupBox1.Controls.Add(this.rBNumPV);
            this.groupBox1.Controls.Add(this.rBTous);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.tBIdPVCession);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(356, 427);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rechercher un PV";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(104, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "de";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(104, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "à";
            // 
            // dTPFin
            // 
            this.dTPFin.Location = new System.Drawing.Point(141, 86);
            this.dTPFin.Name = "dTPFin";
            this.dTPFin.Size = new System.Drawing.Size(198, 20);
            this.dTPFin.TabIndex = 30;
            this.dTPFin.ValueChanged += new System.EventHandler(this.dTPFin_ValueChanged);
            // 
            // dTPDebut
            // 
            this.dTPDebut.Location = new System.Drawing.Point(141, 62);
            this.dTPDebut.Name = "dTPDebut";
            this.dTPDebut.Size = new System.Drawing.Size(198, 20);
            this.dTPDebut.TabIndex = 29;
            this.dTPDebut.ValueChanged += new System.EventHandler(this.dTPDebut_ValueChanged);
            // 
            // rBNumPV
            // 
            this.rBNumPV.AutoSize = true;
            this.rBNumPV.Location = new System.Drawing.Point(14, 42);
            this.rBNumPV.Name = "rBNumPV";
            this.rBNumPV.Size = new System.Drawing.Size(54, 17);
            this.rBNumPV.TabIndex = 27;
            this.rBNumPV.Text = "N° PV";
            this.rBNumPV.UseVisualStyleBackColor = true;
            this.rBNumPV.CheckedChanged += new System.EventHandler(this.rBNumPV_CheckedChanged);
            // 
            // rBTous
            // 
            this.rBTous.AutoSize = true;
            this.rBTous.Checked = true;
            this.rBTous.Location = new System.Drawing.Point(14, 19);
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
            this.groupBox2.Controls.Add(this.dGVPVCession);
            this.groupBox2.Location = new System.Drawing.Point(6, 129);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(344, 292);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Liste des PV de cession";
            // 
            // dGVPVCession
            // 
            this.dGVPVCession.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVPVCession.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnIdPV,
   
            this.ColumnModifier,
            this.ColumnImprimer});
            this.dGVPVCession.Location = new System.Drawing.Point(8, 19);
            this.dGVPVCession.Name = "dGVPVCession";
            this.dGVPVCession.Size = new System.Drawing.Size(325, 267);
            this.dGVPVCession.TabIndex = 0;
            this.dGVPVCession.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVPVCession_CellClick);
            this.dGVPVCession.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVPVCession_CellContentClick);
            this.dGVPVCession.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dGVPVCession_CellPainting);
            this.dGVPVCession.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVPVCession_CellValueChanged);
            // 
            // ColumnIdPV
            // 
            this.ColumnIdPV.HeaderText = "PV";
            this.ColumnIdPV.Name = "ColumnIdPV";
            this.ColumnIdPV.ReadOnly = true;
            this.ColumnIdPV.Width = 107;
            // 
            // ColumnDateCession
            // 
       

            this.ColumnModifier.HeaderText = "";
            this.ColumnModifier.Name = "ColumnModifier";
            this.ColumnModifier.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnModifier.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
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
            // tBIdPVCession
            // 
            this.tBIdPVCession.Location = new System.Drawing.Point(141, 39);
            this.tBIdPVCession.Name = "tBIdPVCession";
            this.tBIdPVCession.Size = new System.Drawing.Size(198, 20);
            this.tBIdPVCession.TabIndex = 22;
            this.tBIdPVCession.TextChanged += new System.EventHandler(this.tBIdPVCession_TextChanged);
            // 
            // PVsCessions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 447);
            this.Controls.Add(this.groupBox1);
            this.Name = "PVsCessions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PV de cession";
            this.Load += new System.EventHandler(this.PVs_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGVPVCession)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton rBDate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dTPFin;
        private System.Windows.Forms.DateTimePicker dTPDebut;
        private System.Windows.Forms.RadioButton rBNumPV;
        private System.Windows.Forms.RadioButton rBTous;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dGVPVCession;
        private System.Windows.Forms.TextBox tBIdPVCession;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnIdPV;

        private System.Windows.Forms.DataGridViewButtonColumn ColumnModifier;
        private System.Windows.Forms.DataGridViewButtonColumn ColumnImprimer;
    }
}