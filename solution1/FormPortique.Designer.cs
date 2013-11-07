namespace solution1
{
    partial class FormPortique
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPortique));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tVEmplacement = new System.Windows.Forms.TreeView();
            this.mesIcones = new System.Windows.Forms.ImageList(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBoxSite = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.bSupprimer = new System.Windows.Forms.Button();
            this.bNouveauPortique = new System.Windows.Forms.Button();
            this.tVPortiques = new System.Windows.Forms.TreeView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 381);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(596, 22);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tVEmplacement
            // 
            this.tVEmplacement.AllowDrop = true;
            this.tVEmplacement.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tVEmplacement.HideSelection = false;
            this.tVEmplacement.ImageIndex = 0;
            this.tVEmplacement.ImageList = this.mesIcones;
            this.tVEmplacement.LabelEdit = true;
            this.tVEmplacement.Location = new System.Drawing.Point(7, 13);
            this.tVEmplacement.Name = "tVEmplacement";
            this.tVEmplacement.SelectedImageIndex = 0;
            this.tVEmplacement.Size = new System.Drawing.Size(239, 306);
            this.tVEmplacement.TabIndex = 0;
            // 
            // mesIcones
            // 
            this.mesIcones.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("mesIcones.ImageStream")));
            this.mesIcones.TransparentColor = System.Drawing.Color.Transparent;
            this.mesIcones.Images.SetKeyName(0, "grouptree_toggle.gif");
            this.mesIcones.Images.SetKeyName(1, "emplacementSelect1.ico");
            this.mesIcones.Images.SetKeyName(2, "Adhérent.gif");
            this.mesIcones.Images.SetKeyName(3, "Adhérent.gif");
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBoxSite);
            this.groupBox2.Location = new System.Drawing.Point(6, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(252, 42);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sites";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // comboBoxSite
            // 
            this.comboBoxSite.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxSite.DisplayMember = "Site";
            this.comboBoxSite.FormattingEnabled = true;
            this.comboBoxSite.Location = new System.Drawing.Point(6, 14);
            this.comboBoxSite.Name = "comboBoxSite";
            this.comboBoxSite.Size = new System.Drawing.Size(240, 21);
            this.comboBoxSite.TabIndex = 1;
            this.comboBoxSite.ValueMember = "idSite";
            this.comboBoxSite.SelectedIndexChanged += new System.EventHandler(this.comboBoxSite_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.tVEmplacement);
            this.groupBox1.Location = new System.Drawing.Point(6, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(252, 325);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Emplacements";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox3.Controls.Add(this.bSupprimer);
            this.groupBox3.Controls.Add(this.bNouveauPortique);
            this.groupBox3.Controls.Add(this.tVPortiques);
            this.groupBox3.Location = new System.Drawing.Point(309, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(281, 373);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Portiques";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // bSupprimer
            // 
            this.bSupprimer.Location = new System.Drawing.Point(142, 341);
            this.bSupprimer.Name = "bSupprimer";
            this.bSupprimer.Size = new System.Drawing.Size(133, 25);
            this.bSupprimer.TabIndex = 2;
            this.bSupprimer.Text = "Supprimer portique";
            this.bSupprimer.UseVisualStyleBackColor = true;
            this.bSupprimer.Click += new System.EventHandler(this.bSupprimer_Click);
            // 
            // bNouveauPortique
            // 
            this.bNouveauPortique.Location = new System.Drawing.Point(6, 341);
            this.bNouveauPortique.Name = "bNouveauPortique";
            this.bNouveauPortique.Size = new System.Drawing.Size(133, 25);
            this.bNouveauPortique.TabIndex = 1;
            this.bNouveauPortique.Text = "Nouveau portique";
            this.bNouveauPortique.UseVisualStyleBackColor = true;
            this.bNouveauPortique.Click += new System.EventHandler(this.bNouveauPortique_Click);
            // 
            // tVPortiques
            // 
            this.tVPortiques.HideSelection = false;
            this.tVPortiques.ImageIndex = 0;
            this.tVPortiques.ImageList = this.mesIcones;
            this.tVPortiques.LabelEdit = true;
            this.tVPortiques.Location = new System.Drawing.Point(6, 14);
            this.tVPortiques.Name = "tVPortiques";
            this.tVPortiques.SelectedImageIndex = 0;
            this.tVPortiques.Size = new System.Drawing.Size(269, 321);
            this.tVPortiques.TabIndex = 0;
            this.tVPortiques.BeforeLabelEdit += new System.Windows.Forms.NodeLabelEditEventHandler(this.tVPortiques_BeforeLabelEdit);
            this.tVPortiques.AfterLabelEdit += new System.Windows.Forms.NodeLabelEditEventHandler(this.tVPortiques_AfterLabelEdit);
            //this.tVPortiques.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tVPortiques_AfterSelect);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(265, 167);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(38, 28);
            this.button1.TabIndex = 10;
            this.button1.Text = ">";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(265, 201);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(38, 28);
            this.button2.TabIndex = 11;
            this.button2.Text = "<";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FormPortique
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 403);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusStrip1);
            this.MaximizeBox = false;
            this.Name = "FormPortique";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion des portiques";
            this.Load += new System.EventHandler(this.FormPortique_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        public System.Windows.Forms.TreeView tVEmplacement;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBoxSite;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TreeView tVPortiques;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ImageList mesIcones;
        private System.Windows.Forms.Button bSupprimer;
        private System.Windows.Forms.Button bNouveauPortique;
    }
}