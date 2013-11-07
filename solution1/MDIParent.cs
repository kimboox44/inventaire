using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using solution1.Prenom;

namespace solution1
{
    public partial class MDIParent : Form
    {
        public string Administrateur = null;
        public string idUtilisateur = null;
        string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["connectString2"].ConnectionString;
        public int[] privilege;
        public DataSet priv;

        

        public MDIParent()
        {
            InitializeComponent();
            //change the dimensions of button itself 
            toolStrip.AutoSize = false;
            toolStrip.Height = 50;
            toolStripButton1.AutoSize = false;
            toolStripButton1.Width = 50;
            //resize the image of the button to the 
            int sourceWidth = toolStripButton1.Image.Width;
            int sourceHeight = toolStripButton1.Image.Height;
            Bitmap b = new Bitmap(40, 40);
            Graphics g = Graphics.FromImage((Image)b);
            g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            g.DrawImage(toolStripButton1.Image, 0, 0, 40, 40);
            g.Dispose();
            Image myResizedImg = (Image)b;
            //put the resized image back to the button and change toolstrip's 
            toolStripButton1.Image = myResizedImg;
            toolStrip.ImageScalingSize = new Size(40, 40);

        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            (new NouvelInventaire(this)).ShowDialog();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.WindowState = FormWindowState.Minimized;
            }

            Form child = new OuvrirInventaire(this);
            child.MdiParent = this;
            child.Show();
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void MDIParent1_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'Inventaire_BDDDataSet.Bien'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            atacherBDD(); //attachement de la base de données à sql server           
            /*  MdiClient ctlMDI;
                        foreach (Control ctl in this.Controls)
                        {
                            try
                            {               
                                ctlMDI = (MdiClient)ctl;
                                ctlMDI.BackColor = this.BackColor;
                            }
                            catch (InvalidCastException exc)
                            {
                               
                            }
                        }*/
            this.menuStrip.Enabled = false;
            this.toolStrip.Enabled = false;
            (new Authentification(this)).ShowDialog();


            /* //change the dimensions of button itself 
                        toolStrip.AutoSize = false; toolStrip.Height = 50; toolStripButton1.AutoSize = false; toolStripButton1.Width = 50;
                        //resize the image of the button to the 
                        int sourceWidth = toolStripButton1.Image.Width; int sourceHeight = toolStripButton1.Image.Height; Bitmap b = new Bitmap(40, 40); Graphics g = Graphics.FromImage((Image)b); g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic; g.DrawImage(toolStripButton1.Image, 0, 0, 40, 40); g.Dispose(); Image myResizedImg = (Image)b;
                        //put the resized image back to the button and change toolstrip's 
                        toolStripButton1.Image = myResizedImg; toolStrip.ImageScalingSize = new Size(40, 40);*/
        }

        private void fileMenu_Click(object sender, EventArgs e)
        {

        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new FormGestionCategorie(this)).Show();
        }

        private void bienToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }


        private void helpToolStripButton_Click(object sender, EventArgs e)
        {
        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
        }

        private void printPreviewToolStripButton_Click(object sender, EventArgs e)
        {
        }

        private void printToolStripButton_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            (new FormGestionCategorie(this)).Show();
        }

        private void atacherBDD()
        {
            try
            {
                string path = Directory.GetCurrentDirectory();
              
                // Copy the file.
                string location = System.Configuration.ConfigurationManager.ConnectionStrings["server"].ConnectionString;
                System.IO.Directory.CreateDirectory(@location);


                if (!File.Exists(@location + "\\Inventaire BDD.mdf"))
                {
                    File.Copy(path + @"\Inventaire BDD.mdf", @location + "\\Inventaire BDD.mdf");
                    File.Copy(path + @"\Inventaire BDD_log.ldf", @location + "\\Inventaire BDD_log.ldf");
                }

                SqlConnection conn = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand("", conn);
                cmd.CommandText =  @"EXEC sp_attach_db @dbname = N'Inventaire BDD'," +
                "@filename1 = N'" + @location + @"\Inventaire BDD.mdf'," +
                "@filename2 = N'" + @location + @"\Inventaire BDD_log.ldf'";

                conn.Open();
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                conn.Dispose();
                //sqlCreateDBQuery = " CREATE DATABASE 'dodu' ON PRIMARY (NAME = 'tata' FILENAME = 'c:\\tata.mdf',  SIZE = 6144KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB)  LOG ON (NAME = 'tata_LOG', FILENAME = 'c:\\tata_LOG.log' ,  SIZE = 18240KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)";

                MessageBox.Show("L'installation de la base de données est terminée" + path, "Opération réussie", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            catch (Exception ex) //La base de données existe déja
            {

                //MessageBox.Show("L'installation de la base à échoué" + "\n" + ex.ToString(), "Erruer", MessageBoxButtons.OK, MessageBoxIcon.Error);                
            }
        }

        private void MDIParent_Validated(object sender, EventArgs e)
        {
        }

        private void importationDonnéeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //ImportaionDonnée.Visible = true;
            //ImportaionDonnée.tabControl1.SelectedTab = ImportaionDonnée.tabPage2;

            Admin adm = new Prenom.Admin();
            adm.ribboncontrol.SelectedPage = adm.import;
            adm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //this.menuStrip.Enabled = false;
            //this.toolStrip.Enabled = false;
            (new Authentification(this)).ShowDialog();

        }

        private void exportationDeDonnéeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //ImportaionDonnée.Visible = true;
            //ImportaionDonnée.tabControl1.SelectedTab = ImportaionDonnée.tabPage4;

            Admin adm = new Prenom.Admin();
            adm.ribboncontrol.SelectedPage = adm.export;
            adm.ShowDialog();
        }

        private void viderLaBaseDeDonéeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //ImportaionDonnée.Visible = true;
            //ImportaionDonnée.tabControl1.SelectedTab = ImportaionDonnée.tabPage3;

            Admin adm = new Prenom.Admin();
            adm.ribboncontrol.SelectedPage = adm.export;

            adm.ShowDialog();
        }

        private void toolStripButton1_Click_2(object sender, EventArgs e)
        {
            MDIParent parent = new MDIParent();
            parent.Show();
        }

        private void toolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
        }

        private void testToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //solution1.Cession.Form2 fm = new solution1.Cession.Form2();
            //fm.Show();   
        }

        private void rapportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //solution1.Cession.Formrapport fm = new solution1.Cession.Formrapport();
            //XtraForm1 fm = new XtraForm1();
            Rapport.Rapports fm = new Rapport.Rapports();
            fm.Show();
        }

        private void tBSUtilisateur_Click(object sender, EventArgs e)
        {
            Admin adm = new Prenom.Admin();
            adm.ShowDialog();
        }

        private void toolStripButton_rapport_Click(object sender, EventArgs e)
        {
            Rapport.Rapports fm = new Rapport.Rapports();
            fm.Show();
        }

        private void gestionUtilisateursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Admin adm = new Prenom.Admin();
            adm.ShowDialog();
        }

        private void gestionInventaireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Inventaire.gestion_inventaire gst_inv = new Inventaire.gestion_inventaire();
            gst_inv.ShowDialog();
        }

        private void ouvrirInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OuvrirInventaire ouvre = new OuvrirInventaire(this);
            ouvre.MdiParent = this;
            ouvre.Show();
            
        }

        private void nouveauInventaireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NouvelInventaire nouv = new NouvelInventaire(this);
            nouv.ShowDialog();
        }

        private void toolStripButton2_Click_1(object sender, EventArgs e)
        {
            info info = new info();
            info.ShowDialog();
        }


    }
}
