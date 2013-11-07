namespace solution1.Prenom
{
    partial class Admin
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
            this.ribboncontrol = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.Ajout_util = new DevExpress.XtraBars.BarButtonItem();
            this.mod_sup_util = new DevExpress.XtraBars.BarButtonItem();
            this.import_bloc = new DevExpress.XtraBars.BarButtonItem();
            this.import_tab = new DevExpress.XtraBars.BarButtonItem();
            this.expoter_bdd = new DevExpress.XtraBars.BarButtonItem();
            this.vider_bdd = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonMiniToolbar1 = new DevExpress.XtraBars.Ribbon.RibbonMiniToolbar(this.components);
            this.ribbonPageCategory1 = new DevExpress.XtraBars.Ribbon.RibbonPageCategory();
            this.import = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.export = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup6 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.gest_util = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.info = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup7 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.panel = new System.Windows.Forms.Panel();
            this.ribbonPageGroup8 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup9 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ((System.ComponentModel.ISupportInitialize)(this.ribboncontrol)).BeginInit();
            this.SuspendLayout();
            // 
            // ribboncontrol
            // 
            this.ribboncontrol.ApplicationButtonText = null;
            // 
            // 
            // 
            this.ribboncontrol.ExpandCollapseItem.Id = 0;
            this.ribboncontrol.ExpandCollapseItem.Name = "";
            this.ribboncontrol.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribboncontrol.ExpandCollapseItem,
            this.Ajout_util,
            this.mod_sup_util,
            this.import_bloc,
            this.import_tab,
            this.expoter_bdd,
            this.vider_bdd,
            this.barButtonItem1});
            this.ribboncontrol.Location = new System.Drawing.Point(0, 0);
            this.ribboncontrol.MaxItemId = 9;
            this.ribboncontrol.MiniToolbars.Add(this.ribbonMiniToolbar1);
            this.ribboncontrol.Name = "ribboncontrol";
            this.ribboncontrol.PageCategories.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageCategory[] {
            this.ribbonPageCategory1});
            this.ribboncontrol.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.gest_util,
            this.info});
            this.ribboncontrol.SelectedPage = this.export;
            this.ribboncontrol.Size = new System.Drawing.Size(984, 145);
            // 
            // Ajout_util
            // 
            this.Ajout_util.Caption = "Ajouter";
            this.Ajout_util.Id = 1;
            this.Ajout_util.LargeGlyph = global::solution1.Properties.Resources.edit_add;
            this.Ajout_util.LargeGlyphDisabled = global::solution1.Properties.Resources.edit_add;
            this.Ajout_util.Name = "Ajout_util";
            this.Ajout_util.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.Ajout_util.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Ajout_util_ItemClick);
            // 
            // mod_sup_util
            // 
            this.mod_sup_util.Caption = "Modifier Supprimer";
            this.mod_sup_util.Id = 2;
            this.mod_sup_util.LargeGlyph = global::solution1.Properties.Resources.logo_2;
            this.mod_sup_util.Name = "mod_sup_util";
            this.mod_sup_util.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.mod_sup_util.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mod_sup_util_ItemClick);
            // 
            // import_bloc
            // 
            this.import_bloc.Caption = "Importation Bloc";
            this.import_bloc.Id = 4;
            this.import_bloc.LargeGlyph = global::solution1.Properties.Resources.reminders;
            this.import_bloc.Name = "import_bloc";
            this.import_bloc.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.import_bloc.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.import_bloc_ItemClick);
            // 
            // import_tab
            // 
            this.import_tab.Caption = "Importation Table";
            this.import_tab.Id = 5;
            this.import_tab.LargeGlyph = global::solution1.Properties.Resources.Download_File213213;
            this.import_tab.Name = "import_tab";
            this.import_tab.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.import_tab.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.import_tab_ItemClick);
            // 
            // expoter_bdd
            // 
            this.expoter_bdd.Caption = "Exporter BDD";
            this.expoter_bdd.Id = 6;
            this.expoter_bdd.LargeGlyph = global::solution1.Properties.Resources.export_bdd1;
            this.expoter_bdd.Name = "expoter_bdd";
            this.expoter_bdd.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.expoter_bdd.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.expoter_bdd_ItemClick);
            // 
            // vider_bdd
            // 
            this.vider_bdd.Caption = "Vider BDD";
            this.vider_bdd.Id = 7;
            this.vider_bdd.LargeGlyph = global::solution1.Properties.Resources.vider_bdd1;
            this.vider_bdd.Name = "vider_bdd";
            this.vider_bdd.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.vider_bdd.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.vider_bdd_ItemClick);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Actuel / Modification";
            this.barButtonItem1.Id = 8;
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // ribbonPageCategory1
            // 
            this.ribbonPageCategory1.Name = "ribbonPageCategory1";
            this.ribbonPageCategory1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.import,
            this.export});
            this.ribbonPageCategory1.Text = "Imporot export des données";
            // 
            // import
            // 
            this.import.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup3,
            this.ribbonPageGroup4});
            this.import.Name = "import";
            this.import.Text = "  Importation  ";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.import_bloc);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "                                               ";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.import_tab);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "                                               ";
            // 
            // export
            // 
            this.export.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup5,
            this.ribbonPageGroup6});
            this.export.Name = "export";
            this.export.Text = "  Exportation  ";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.ItemLinks.Add(this.expoter_bdd);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            this.ribbonPageGroup5.Text = "                                               ";
            // 
            // ribbonPageGroup6
            // 
            this.ribbonPageGroup6.ItemLinks.Add(this.vider_bdd);
            this.ribbonPageGroup6.Name = "ribbonPageGroup6";
            this.ribbonPageGroup6.Text = "                                               ";
            // 
            // gest_util
            // 
            this.gest_util.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2});
            this.gest_util.Name = "gest_util";
            this.gest_util.Text = "Gestion Utilisateur";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.Ajout_util);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "                                               ";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.mod_sup_util);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "                                               ";
            // 
            // info
            // 
            this.info.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup7});
            this.info.Name = "info";
            this.info.Text = "Information";
            // 
            // ribbonPageGroup7
            // 
            this.ribbonPageGroup7.ItemLinks.Add(this.barButtonItem1);
            this.ribbonPageGroup7.Name = "ribbonPageGroup7";
            this.ribbonPageGroup7.Text = "                                               ";
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.Gainsboro;
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.Location = new System.Drawing.Point(0, 145);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(984, 577);
            this.panel.TabIndex = 1;
            // 
            // ribbonPageGroup8
            // 
            this.ribbonPageGroup8.ItemLinks.Add(this.Ajout_util);
            this.ribbonPageGroup8.Name = "ribbonPageGroup8";
            this.ribbonPageGroup8.Text = "ribbonPageGroup1";
            // 
            // ribbonPageGroup9
            // 
            this.ribbonPageGroup9.ItemLinks.Add(this.Ajout_util);
            this.ribbonPageGroup9.Name = "ribbonPageGroup9";
            this.ribbonPageGroup9.Text = "ribbonPageGroup1";
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 722);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.ribboncontrol);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1000, 760);
            this.MinimumSize = new System.Drawing.Size(1000, 760);
            this.Name = "Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            ((System.ComponentModel.ISupportInitialize)(this.ribboncontrol)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.BarButtonItem Ajout_util;
        private DevExpress.XtraBars.BarButtonItem mod_sup_util;
        private DevExpress.XtraBars.Ribbon.RibbonPage gest_util;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private System.Windows.Forms.Panel panel;
        private DevExpress.XtraBars.Ribbon.RibbonPageCategory ribbonPageCategory1;
        private DevExpress.XtraBars.BarButtonItem import_bloc;
        private DevExpress.XtraBars.BarButtonItem import_tab;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.BarButtonItem expoter_bdd;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup6;
        public DevExpress.XtraBars.Ribbon.RibbonControl ribboncontrol;
        public DevExpress.XtraBars.Ribbon.RibbonPage import;
        public DevExpress.XtraBars.Ribbon.RibbonPage export;
        public DevExpress.XtraBars.BarButtonItem vider_bdd;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.Ribbon.RibbonMiniToolbar ribbonMiniToolbar1;
        private DevExpress.XtraBars.Ribbon.RibbonPage info;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup7;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup8;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup9;
    }
}