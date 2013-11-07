using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using System.Collections;
using System.Drawing.Printing;
using System.Threading;

using System.ComponentModel;

using System.IO;


namespace solution1
{

    public partial class Comparer2Inventaires : Form
    {
        public string uidInventaireReference = null;
        public string uidInventaireAcomparer = null;
        public string DesigInventaire = "Inventaire général";
        public string chemin="";
        DataSet inventairegeneralBien = null;
        Dataset.DataSet1 dsComparerBien = new Dataset.DataSet1();
       
        string connectionString = ConfigurationManager.ConnectionStrings["connectString1"].ConnectionString;
        String query = null;        
        DataSet dataSet = null;
        string idUtilisateur = null;
        ArrayList aLEmplacementsCochés = new ArrayList();
        bool MinVersMax = true;

        private class SiteEmpla 
        {
            string idSite = null;
            string idEmpla = null;

            public SiteEmpla(string idSite, string idEmpla) 
            {
                this.idSite = idSite;
                this.idEmpla = idEmpla;
            }

            public string IdSite
            {
                get { return idSite; }
            }
            public string IdEmpla
            {
                get { return idEmpla; }
            }
        }
        
        public Comparer2Inventaires(string idUtilisateur)
        {
            this.idUtilisateur = idUtilisateur;
            InitializeComponent();             
        }
                
        struct structSite
        {
            string idSite;
            string Site;
            public structSite(String idSite, string Site) { this.idSite = idSite; this.Site = Site; }
            public string idsite
            {
                get { return idSite; }
            }
            public string site
            {
                get { return Site; }
            }
        }

        struct structInventaire
        {
            string uidInventaire;
            string desigInventaire;
            public structInventaire(String uidInventaire, string desigInventaire) { this.uidInventaire = uidInventaire; this.desigInventaire = desigInventaire; }
            public string UidInventaire
            {
                get { return uidInventaire; }
            }
            public string DesigInventaire
            {
                get { return desigInventaire; }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            chargerSites();
            chagerInventaire();
            //Cocher tous les emplacements du site courant
            cBSelectTousNoeuds.Checked = true;
        }

        private void chargerSites() 
        {
            DataSet dsite = MaConnexion.ExecuteSelect(connectionString, "select * from site");
            foreach (DataRow row in dsite.Tables[0].Rows)
            {
                structSite str = new structSite(row[0].ToString(), row[1].ToString());
                comboBoxSite.Items.Add(str);
            }
            try
            {
                comboBoxSite.Text = dsite.Tables[0].Rows[0][1].ToString();
            }
            catch (Exception) { }
        }

        private void chagerInventaire() 
        {
            DataSet dsite1 = MaConnexion.ExecuteSelect(connectionString, "select inventaire.uidInventaire, desigInventaire from inventaire where etat = 'Valide' order by DateInventaire");
            foreach (DataRow row in dsite1.Tables[0].Rows)
            {
                structInventaire str = new structInventaire(row[0].ToString(), row[1].ToString());
                comboBoxReference.Items.Add(str);
                comboBoxAcomparer.Items.Add(str);

            }
        }

        private void comboBoxSite_SelectedIndexChanged(object sender, EventArgs e)
        {
            treeViewEmplacement.Nodes.Clear();
            try
            {
                query = "select * from emplacement where idSitePere is null and idEmplaPere is null and idsite=" + ((structSite)comboBoxSite.SelectedItem).idsite;
                dataSet = MaConnexion.ExecuteSelect(connectionString, query);

                if (dataSet.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow dRRacine in dataSet.Tables[0].Rows)
                    {
                        TreeNode racine = new TreeNode(dRRacine[4].ToString());

                        //on stocke l'identifant de l'emplacement (idSite_idEmpla)
                        racine.Name = dRRacine[0].ToString() + "_" + dRRacine[1].ToString();
                        cocherDécocherNoeud(racine);
                        String requete = "select * from emplacement where idSitePere = "
                            + dRRacine[0].ToString()
                            + " and idEmplaPere = "
                            + dRRacine[1].ToString() + ";";

                        DataSet sousDataTable = MaConnexion.ExecuteSelect(connectionString, requete);

                        foreach (DataRow dRCourant in sousDataTable.Tables[0].Rows)
                        {
                            TreeNode tNCourant = new TreeNode(dRCourant[4].ToString());

                            //on stocke l'identifant de l'emplacement (idSite_idEmpla)
                            tNCourant.Name = dRCourant[0].ToString() + "_" + dRCourant[1].ToString();
                            cocherDécocherNoeud(tNCourant);
                            racine.Nodes.Add(approfondir(tNCourant, dRCourant[0].ToString(), dRCourant[1].ToString()));
                        }
                        treeViewEmplacement.Nodes.Add(racine);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur de chargement de l'arbre des emplacements ", "Echec de chargement des valeurs", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            finally 
            {
                //développer tous les noeuds de l'arbre
                treeViewEmplacement.ExpandAll();
            }

        }

        public TreeNode approfondir(TreeNode node, String idSite, String idEmpla)
        {
            String requete = "select * from emplacement where idSitePere = "
                        + idSite
                        + " and idEmplaPere = "
                        + idEmpla + ";";

            DataSet dataTable = MaConnexion.ExecuteSelect(connectionString, requete);

            if (dataTable.Tables[0].Rows.Count == 0)
            {
                return node;
            }
            else
            {

                foreach (DataRow dRCourant in dataTable.Tables[0].Rows)
                {
                    TreeNode subNode = new TreeNode(dRCourant[4].ToString());

                    //on stocke l'identifant de l'emplacement (idSite_idEmpla)
                    subNode.Name = dRCourant[0].ToString() + "_" + dRCourant[1].ToString();
                    cocherDécocherNoeud(subNode);
                    String sousRequete = "select * from emplacement where idSitePere = "
                        + dRCourant[0].ToString()
                        + " and idEmplaPere = "
                        + dRCourant[1].ToString() + ";";

                    DataSet sousDataTable = MaConnexion.ExecuteSelect(connectionString, sousRequete);
                    if (sousDataTable.Tables[0].Rows.Count != 0)
                    {
                        node.Nodes.Add(approfondir(subNode, dRCourant[0].ToString(), dRCourant[1].ToString()));
                    }
                    else
                    {
                        node.Nodes.Add(subNode);
                    }

                }
                return node;
            }
        }        

        private void treeViewEmplacement_AfterSelect(object sender, TreeViewEventArgs e)
        {
            listViewBien.Items.Clear();            
            if (treeViewEmplacement.SelectedNode.Checked) 
            {
                TreeNode tN = (TreeNode)e.Node;
                String id = tN.Name;
                String[] tabId = id.Split(new char[] { '_' });
                String idSite = tabId[0];
                String idEmpla = tabId[1];                
                ListViewItem lVI = null;

                try
                {
                    foreach (DataRow dR in inventairegeneralBien.Tables[0].Rows)
                    {
                        if ((idEmpla == dR[9].ToString()) || (dR[9].ToString() == "" && dR[20].ToString() == idEmpla))
                        {
                            if (dR[9].ToString() == dR[20].ToString())  //le bien est sur place
                            {
                                lVI = new ListViewItem(new string[] { dR[0].ToString(), dR[1].ToString(), dR[2].ToString(), dR[3].ToString(), dR[4].ToString(), dR[15].ToString(), dR[5].ToString(), dR[6].ToString(), dR[10].ToString() + "\\" + dR[7].ToString(), dR[21].ToString() + "\\" + dR[18].ToString() }, 3);
                                listViewBien.Items.Add(lVI);
                            }
                            else
                            {
                                if (dR[20].ToString() == "") //bien perdu
                                {
                                    lVI = new ListViewItem(new string[] { dR[0].ToString(), dR[1].ToString(), dR[2].ToString(), dR[3].ToString(), dR[4].ToString(), "", dR[5].ToString(), dR[6].ToString(), dR[10].ToString() + "\\" + dR[7].ToString(), dR[18].ToString() }, 0);
                                    listViewBien.Items.Add(lVI);
                                }
                                else
                                {
                                    if (dR[9].ToString() == "") // nouveau bien 
                                    {
                                        lVI = new ListViewItem(new string[] { dR[11].ToString(), dR[12].ToString(), dR[13].ToString(), dR[14].ToString(), "", dR[15].ToString(), dR[16].ToString(), dR[17].ToString(), dR[7].ToString(), dR[21].ToString() + "\\" + dR[18].ToString() }, 2);
                                        listViewBien.Items.Add(lVI);
                                    }
                                    else // le bien est déplacé
                                    {
                                        lVI = new ListViewItem(new string[] { dR[0].ToString(), dR[1].ToString(), dR[2].ToString(), dR[3].ToString(), dR[4].ToString(), dR[15].ToString(), dR[5].ToString(), dR[6].ToString(), dR[10].ToString() + "\\" + dR[7].ToString(), dR[21].ToString() + "\\" + dR[18].ToString() }, 1);
                                        listViewBien.Items.Add(lVI);
                                    }
                                }
                            }
                        }
                    }
                }
                catch (Exception)
                { }
            }
        }

        private void buttoncomparer_Click(object sender, EventArgs e)
        {
            string messageErreur = controlSaisie();
            if (messageErreur == null) //pas d'erreur de saisie
            {
                comparer2Inventaires("");
            }
            else
            {
                MessageBox.Show(messageErreur, "Les inventaires à comparer", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
         }

        private void comparer2Inventaires(string option) 
        {
            uidInventaireReference = ((structInventaire)comboBoxReference.SelectedItem).UidInventaire;
            uidInventaireAcomparer = ((structInventaire)comboBoxAcomparer.SelectedItem).UidInventaire;
            listViewBien.Items.Clear();

            //Activer les boutons et les contextMenus de mise à jour de l'inventaire référence s'il s'agit de l'inventaire général
            RéférenceInventaireGénéral();
            ////////////activer le button vcomparer
            buttonRapport.Enabled = true;

            MaConnexion.ExecuteUpdate(connectionString, "create view vue1 as select Bien.IdBien, Bien.DesigBien, CategorieBien.DesigCategorieBien, Bien.DateAcquisitionBien, Etat.DesigEtat, Bien.Prix, Bien.Particularite, Emplacement.DesigEmpla, seTrouveB.idSite, Emplacement.IdEmpla, Site.NomSite from setrouveB, Emplacement,Bien,Etat,CategorieBien,Site where Etat.IdEtat=seTrouveB.IdEtat and Emplacement.IdEmplaComplet = SeTrouveB.IdEmpla and Bien.IdBien = SeTrouveB.IdBien and CategorieBien.IdCategorieBien=Bien.IdCategorieBien and seTrouveB.idSite = Site.idSite and seTrouveB.uidInventaire = '" + uidInventaireReference + "'");
            MaConnexion.ExecuteUpdate(connectionString, "create view vue2 as select Bien.IdBien, Bien.DesigBien, CategorieBien.DesigCategorieBien, Bien.DateAcquisitionBien, Etat.DesigEtat, Bien.Prix, Bien.Particularite, Emplacement.DesigEmpla, seTrouveB.idSite, Emplacement.IdEmpla, Site.NomSite from setrouveB, Emplacement,Bien,Etat,CategorieBien,Site where Etat.IdEtat=seTrouveB.IdEtat and Emplacement.IdEmplaComplet = SeTrouveB.IdEmpla and Bien.IdBien = SeTrouveB.IdBien and CategorieBien.IdCategorieBien=Bien.IdCategorieBien and seTrouveB.idSite = Site.idSite and seTrouveB.uidInventaire = '" + uidInventaireAcomparer + "'");
            inventairegeneralBien = MaConnexion.ExecuteSelect(connectionString, "select * from vue1 full outer join vue2 on vue1.idBien=vue2.idBien" + option);

            ListViewItem lVI = null;
            try
            {
                for (int j = 0; j < inventairegeneralBien.Tables[0].Rows.Count; j++)
                {
                    DataRow dR = inventairegeneralBien.Tables[0].Rows[j];

                    if (inclureDansComparaison(dR))
                    {
                        if (dR[9].ToString() == dR[20].ToString())  //le bien est sur place
                        {
                            lVI = new ListViewItem(new string[] { dR[0].ToString(), dR[1].ToString(), dR[2].ToString(), dR[3].ToString(), dR[4].ToString(), dR[15].ToString(), dR[5].ToString(), dR[6].ToString(), dR[10].ToString() + "\\" + dR[7].ToString(), dR[21].ToString() + "\\" + dR[18].ToString() }, 3);
                            listViewBien.Items.Add(lVI);
                        }
                        else
                        {
                            if (dR[20].ToString() == "") //bien perdu
                            {
                                lVI = new ListViewItem(new string[] { dR[0].ToString(), dR[1].ToString(), dR[2].ToString(), dR[3].ToString(), dR[4].ToString(), "", dR[5].ToString(), dR[6].ToString(), dR[10].ToString() + "\\" + dR[7].ToString(), dR[18].ToString() }, 0);
                                listViewBien.Items.Add(lVI);
                            }
                            else
                            {
                                if (dR[9].ToString() == "") // nouveau bien 
                                {
                                    lVI = new ListViewItem(new string[] { dR[11].ToString(), dR[12].ToString(), dR[13].ToString(), dR[14].ToString(), "", dR[15].ToString(), dR[16].ToString(), dR[17].ToString(), dR[7].ToString(), dR[21].ToString() + "\\" + dR[18].ToString() }, 2);
                                    listViewBien.Items.Add(lVI);
                                }
                                else // le bien est déplacé
                                {
                                    lVI = new ListViewItem(new string[] { dR[0].ToString(), dR[1].ToString(), dR[2].ToString(), dR[3].ToString(), dR[4].ToString(), dR[15].ToString(), dR[5].ToString(), dR[6].ToString(), dR[10].ToString() + "\\" + dR[7].ToString(), dR[21].ToString() + "\\" + dR[18].ToString() }, 1);
                                    listViewBien.Items.Add(lVI);
                                }
                            }
                        }
                        //on sauvegarde dans la propriété "Name" du ListViewItem "lVI" ce qui suit : idSiteAvant_idEmplaAvant*idSiteAprès_idEmplaAprès
                        lVI.Name = dR[8].ToString() + "_" + dR[9].ToString() + "*" + dR[19].ToString() + "_" + dR[20].ToString();
                    }
                }
                string requete1 = "drop view vue1";
                MaConnexion.ExecuteUpdate(connectionString, requete1);

                string requete2 = "drop view vue2";
                MaConnexion.ExecuteUpdate(connectionString, requete2);
            }
            catch (Exception) { }

        }               

        private string controlSaisie() 
        {
            string messageErreur = null;
            if (comboBoxAcomparer.SelectedItem == null || comboBoxReference.SelectedItem == null)
            {
                messageErreur = "sélectionnez d'abord l'inventaire référence et l'inventaire à comparer";
            }
            else 
            {
                if (buttoncomparer.Text == "")
                {
                    messageErreur = "Veuillez entrer l'inventaire reference";
                }
            }
            return messageErreur;
        }












        private void buttonRapport_Click(object sender,EventArgs e)
        {
            //new FormCRComparereBien(uidInventaireReference, uidInventaireAcomparer, extractListEmpla()).Show();
            //new FormCRComparereExemplaire(uidInventaireReference, uidInventaireAcomparer, Convert.ToInt32(((structSite)comboBoxSite.SelectedItem).idsite)).Show();



            //Inventaire.compar_rap_imp cp = new Inventaire.compar_rap_imp();
            //cp.ShowDialog();

/*            PrintDocument printDocument = new PrintDocument();
            Int32 id = listViewBien.Items[0].Index;
            MessageBox.Show("le di est : " + listViewBien.Items[id].SubItems[1].Text);
            PrintDialog pdd = new PrintDialog();
            pdd.ShowDialog();
            int i = 1;

            printDocument.PrintPage += new PrintPageEventHandler(this.printDocument1_PrintPage);
            pdd.Document = printDocument;
            printDocument.Print();

            */
            FolderBrowserDialog dialogue = new FolderBrowserDialog();
            if (dialogue.ShowDialog() == DialogResult.OK)
            {
                chemin = dialogue.SelectedPath;
                MessageBox.Show("le chemin est " + chemin);
                if (chemin.ToString() != "")
                {
                    export_excel();
                }
            }



            /*OpenFileDialog openFile = new OpenFileDialog();
            
            openFile.DefaultExt = "mif";
            openFile.Filter = "Fichier CSV (*.csv)|*.csv";
            openFile.ShowDialog();
            if (openFile.FileNames.Length > 0)
            {
                foreach (string filename in openFile.FileNames)
                {
                    FileInfo.Name
                    string chemin = Path.GetFullPath(filename);
                    MessageBox.Show("le chemin est"+chemin);
                    //listBoxAdd.Items.Add(filename);
                }
            }*/



     

        
        }
        private void export_excel()
        {
            try
            {
                string[] st = new string[listViewBien.Columns.Count];
                DirectoryInfo di = new DirectoryInfo(@""+ chemin.ToString() );
                if (di.Exists == false)
                    di.Create();
                StreamWriter sw = new StreamWriter(chemin.ToString()+@"\Rapport_comparaison.xlt", false);
                sw.WriteLine("\t \t \t Comparaison entre deux inventaires \n \t Reference: \t"+comboBoxReference.Text.ToString()+"\t compare à: \t"+comboBoxAcomparer.Text.ToString()+"\n");
                sw.AutoFlush = true;
                for (int col = 0; col < listViewBien.Columns.Count; col++)
                {
                    
                    sw.Write("\t" + listViewBien.Columns[col].Text.ToString());
                }
                int rowIndex = 0;
                int row = 0;
                string st1 = "";
                
                for (row = 0; row < listViewBien.Items.Count; row++)
                {
                    st1 = "\n";
                    if (rowIndex <= listViewBien.Items.Count)
                    {
                        rowIndex++;
                        for (int col = 0; col < listViewBien.Columns.Count; col++)
                        {
                            st1 = st1 + "\t" + listViewBien.Items[row].SubItems[col].Text.ToString();

                        }
                        sw.WriteLine(st1);
                    }

                }
                sw.Close();
                FileInfo fil = new FileInfo(chemin.ToString() + @"\Rapport_comparaison.xlt");
                if (fil.Exists == true)
                {
                    MessageBox.Show("Exportation Réalisée Avec Succès Vers Excel", "Exportation En Excel", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                    MessageBox.Show("Echec D'Exportation Vers Excel", "Exportation En Excel", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            catch (Exception ex)
            {
            }
        
        }
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Point posBacode = new Point(5, 45);
            Point posLogo = new Point(5, 2);
            Brush textBrush = new System.Drawing.SolidBrush(Color.Black);
            StringFormat stringFlags = new StringFormat();
            Rectangle tabBounds = new Rectangle(new Point(0, 80), new Size(800, 900));

           
            Rectangle tabBoundDate = new Rectangle(new Point(50, 10), new Size(150, 10));
            stringFlags.Alignment = StringAlignment.Center;
            stringFlags.LineAlignment = StringAlignment.Center;
            Font font = new Font("Lucida Fax", (float)12.0, FontStyle.Regular, GraphicsUnit.Pixel);

            // DataSet ds = MaConnexion.ExecuteSelect(connectionString, "select * from information");

            //Image i = Image.FromStream(E:\Mobility\Projects\asset\solution1\solution1\bin\Debug\logo\logo.jpg);


            //Image i = GetImageById(1);

           // Bitmap m_Bitmap = new Bitmap((Bitmap)GetImageById(1), 40, 40);


            // Bitmap m_Bitmap = new Bitmap(global::solution1.Properties.Resources.Sogral, 30, 30);
           
           // e.Graphics.DrawImage(m_Bitmap, posLogo);
          //  e.Graphics.DrawImage((Image)dGVCodeBarres.Rows[numCodeBarres].Cells[0].Value, posBacode);
           // Pen black = new Pen(Color.FromArgb(255, 0, 0, 0), 5);
            //e.Graphics.DrawRectangle(black, 10, 10, 100, 50);
            int i = 0;
            while (i < listViewBien.Items.Count - 1)
            {



                e.Graphics.DrawString(listViewBien.Items[i].ToString()+"/n", font, textBrush, tabBounds, stringFlags);
                
                // e.Graphics.DrawString(listeBien[numCodeBarres].getDate(), font, textBrush, tabBoundDate, stringFlags);
                i++;
            }
        }

       
        private void cBSelectTousNoeuds_CheckedChanged(object sender, EventArgs e)
        {
            for(int i=0; i<treeViewEmplacement.Nodes.Count; i++)
            {
                selectAllNodes(treeViewEmplacement.Nodes[i], cBSelectTousNoeuds.Checked);
            }
        }

        void selectAllNodes(TreeNode node, bool coché)
        {
            node.Checked = coché;
            if (node.FirstNode != null)
                selectAllNodes(node.FirstNode, coché);
            if (node.NextNode != null)
                selectAllNodes(node.NextNode, coché);
        }

     


        void RéférenceInventaireGénéral() //Active les boutons et les contextMenusde de mise à jour de l'inventaire référence s'il s'agit de l'inventaire général
        {
            try
            {
                bool égal = (((structInventaire)comboBoxReference.SelectedItem).UidInventaire.Equals("00000000-0000-0000-0000-000000000000"));
                bMAJBiens.Enabled = égal;
                bMAJBiensDéplacés.Enabled = égal;
                bMAJBiensPerdus.Enabled = égal;
                bMAJBiensRetrouvés.Enabled = égal;                
            }
            catch (Exception) { } //l'inventaire reference n'est pas encore séléctionné
        }

      



        private void listViewBien_MouseDown(object sender, MouseEventArgs e)
        {
            // Il s'agit du boutton droit
            if (e.Button == MouseButtons.Right)
            {
                // Récupère le menuItem situé sous la souris
                ListViewItem lVI = listViewBien.GetItemAt(e.X, e.Y);

                // La souris est bien au-dessus d'un menuItem
                if (lVI != null)
                {
                    string[] tab = lVI.Name.Split(new char[] { '*' });
                    string SiteEmplaAvant = tab[0];
                    string SiteEmplaAprès = tab[1];

                    tab = SiteEmplaAvant.Split(new char[] { '_' });
                    string SiteAvant = tab[0];
                    string EmplaAvant = tab[1];

                    tab = SiteEmplaAprès.Split(new char[] { '_' });
                    string SiteAprès = tab[0];
                    string EmplaAprès = tab[1];
                    
                    //tSSL1.Text = SiteAvant + "_" + EmplaAvant + "*" + SiteAprès + "_" + EmplaAprès;

                    if (EmplaAprès == "") //bien perdu
                    {
                        cMSMAJBienPerdu.Show(listViewBien, new Point(e.X, e.Y));
                    }
                    else //nouveau bien
                    {
                        if (EmplaAvant == "")
                        {
                            cMSMAJBienRetrouvé.Show(listViewBien, new Point(e.X, e.Y));
                        }
                        else //bien déplacé
                        {
                            if (EmplaAvant != EmplaAprès)
                                cMSMAJBienDéplacé.Show(listViewBien, new Point(e.X, e.Y));
                        }
                    }                  
                }
            }
        }





        //vérifie si le bien doit être affiché ou non selon les emplacements cochés dans l'arbre des emplacements 
        private bool inclureDansComparaison(DataRow dR) 
        {
            for (int i = 0; i < aLEmplacementsCochés.Count; i++)
            {

                if (((SiteEmpla)aLEmplacementsCochés[i]).IdEmpla.Equals(dR[9].ToString()) || (dR[9].ToString() == "" && ((SiteEmpla)aLEmplacementsCochés[i]).IdEmpla.Equals(dR[20].ToString())))                
                {
                    return true;
                }
            }
            return false;
        }

        bool filtrerBien(DataRow dR) 
        {
            bool séléctionné = false; 
            int i = 0;

            while (!séléctionné && i < treeViewEmplacement.Nodes.Count)
            {
                séléctionné = filtrerBienRécursif(treeViewEmplacement.Nodes[i], dR);
                i++;
            }
            return séléctionné;
        }

        bool filtrerBienRécursif(TreeNode node, DataRow dR)
        {
            String[] tabId = node.Name.Split(new char[] { '_' });
            String idSite = tabId[0];
            String idEmpla = tabId[1];
            if (idEmpla == dR[9].ToString() || (dR[9].ToString() == "" && idEmpla == dR[19].ToString()))
                if (node.Checked) 
                {
                    return true;
                }                
                else
                    return false;
            else
            {
                bool séléctionné = false;
                int i = 0;
                while (!séléctionné && i < node.Nodes.Count)
                {
                    séléctionné = filtrerBienRécursif(node.Nodes[i], dR);
                    i++;
                }
                return séléctionné;
            }                
        }
                
        private void bMAJBiensRetrouvés_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listViewBien.Items.Count; i++)
            {
                ListViewItem lVI = listViewBien.Items[i];
                string idBien = lVI.SubItems[0].Text;

                string[] tab = lVI.Name.Split(new char[] { '*' });
                string idSiteIdEmplaAvant = tab[0];
                string idSiteIdEmplaAprès = tab[1];

                tab = idSiteIdEmplaAvant.Split(new char[] { '_' });
                string idSiteAvant = tab[0];
                string idEmplaAvant = tab[1];

                tab = idSiteIdEmplaAprès.Split(new char[] { '_' });
                string idSiteAprès = tab[0];
                string idEmplaAprès = tab[1];

                if (idEmplaAvant == "")
                {
                    MAJBiensRetrouvés(idBien, idSiteAprès, idEmplaAprès);
                }
            }
            buttoncomparer.PerformClick();
        }

        void MAJBiensRetrouvés(string idBien, string idSiteAprès, string idEmplaAprès) 
        {
            string requete = "INSERT INTO SeTrouveB (uidInventaire, IdSite, IdEmpla, IdBien, rowguid) VALUES ('" +
                             uidInventaireReference + "'," + idSiteAprès + "," + idEmplaAprès + ",'" + idBien + "', NEWID())";
            if (MaConnexion.ExecuteUpdate(connectionString, requete) != 1)
                MessageBox.Show("Echec de la mise à jour du bien numéro '" + idBien + "'", "Erreur de modification", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void bMAJBiensPerdus_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listViewBien.Items.Count; i++) 
            {
                ListViewItem lVI = listViewBien.Items[i];
                string idBien = lVI.SubItems[0].Text;

                string[] tab = lVI.Name.Split(new char[] { '*' });
                string idSiteIdEmplaAvant = tab[0];
                string idSiteIdEmplaAprès = tab[1];

                tab = idSiteIdEmplaAvant.Split(new char[] { '_' });
                string idSiteAvant = tab[0];
                string idEmplaAvant = tab[1];

                tab = idSiteIdEmplaAprès.Split(new char[] { '_' });
                string idSiteAprès = tab[0];
                string idEmplaAprès = tab[1];

                if (idEmplaAprès == "") 
                {
                    MAJBiensPerdus(idBien, idSiteAvant, idEmplaAvant);
                }                
            }
            buttoncomparer.PerformClick();
        }

        void MAJBiensPerdus(string idBien, string idSiteAvant, string idEmplaAvant)
        {
            string requete = "delete from seTrouveB where idBien = '" + idBien + "' and idSite = " + idSiteAvant + " and idEmpla = " + idEmplaAvant + " and uidInventaire = '" + uidInventaireReference + "'";
            if (MaConnexion.ExecuteUpdate(connectionString, requete) != 1)
                MessageBox.Show("Echec de la mise à jour du bien numéro '" + idBien + "'", "Erreur de modification", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);            
        }

        private void bMAJBiensDéplacés_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listViewBien.Items.Count; i++)
            {
                ListViewItem lVI = listViewBien.Items[i];
                string idBien = lVI.SubItems[0].Text;

                string[] tab = lVI.Name.Split(new char[] { '*' });
                string idSiteIdEmplaAvant = tab[0];
                string idSiteIdEmplaAprès = tab[1];

                tab = idSiteIdEmplaAvant.Split(new char[] { '_' });
                string idSiteAvant = tab[0];
                string idEmplaAvant = tab[1];

                tab = idSiteIdEmplaAprès.Split(new char[] { '_' });
                string idSiteAprès = tab[0];
                string idEmplaAprès = tab[1];

                if (idEmplaAvant != "" && idEmplaAprès != "" && idEmplaAvant != idEmplaAprès)
                {
                    MAJBiensDéplacés(idBien, idSiteAvant, idEmplaAvant, idSiteAprès, idEmplaAprès);
                }
            }
            buttoncomparer.PerformClick();
        }

        void MAJBiensDéplacés(string idBien, string idSiteAvant, string idEmplaAvant, string idSiteAprès, string idEmplaAprès) 
        {
            string requete = "update seTrouveB set idSite = " + idSiteAprès + ", idEmpla = " + idEmplaAprès + "  where idBien = '" + idBien + "' and idSite = " + idSiteAvant + " and idEmpla = " + idEmplaAvant + " and uidInventaire = '" + uidInventaireReference + "'";            
            if (MaConnexion.ExecuteUpdate(connectionString, requete) != 1)
                MessageBox.Show("Echec de la mise à jour du bien numéro '" + idBien + "'", "Erreur de modification", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void bMAJBiens_Click(object sender, EventArgs e)
        {
            bMAJBiensRetrouvés.PerformClick();
            bMAJBiensDéplacés.PerformClick();
            bMAJBiensPerdus.PerformClick();
        }

        private void bMAJExemplairesPerdus_Click(object sender, EventArgs e)
        {
            
        }

        void MAJExemplairesPerdus(string idouvrage, string cote, string idSiteAvant, string idEmplaAvant)
        {
            string requete = "delete from seTrouveE where cote = '" + cote + "' and idOuvrage = " + idouvrage + " and idSite = " + idSiteAvant + " and idEmpla = " + idEmplaAvant + " and uidInventaire = '" + uidInventaireReference + "'";
            if (MaConnexion.ExecuteUpdate(connectionString, requete) != 1)
                MessageBox.Show("Echec de la mise à jour de l'exemplaire dont la cote est '" + cote + "'", "Erreur de modification", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void bMAJExemplairesDéplacés_Click(object sender, EventArgs e)
        {
            
        }

        void MAJExemplairesDéplacés(string idOuvrage, string cote, string idSiteAvant, string idEmplaAvant, string idSiteAprès, string idEmplaAprès)
        {
            string requete = "update seTrouveE set idSite = " + idSiteAprès + ", idEmpla = " + idEmplaAprès + "  where idOuvrage = " + idOuvrage + " and cote = '" + cote + "' and idSite = " + idSiteAvant + " and idEmpla = " + idEmplaAvant + " and uidInventaire = '" + uidInventaireReference + "'";            
            if (MaConnexion.ExecuteUpdate(connectionString, requete) != 1)
                MessageBox.Show("Echec de la mise à jour de l'exemplaire dont la cote est '" + cote + "'", "Erreur de modification", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void bMAJExemplairesRetrouvés_Click(object sender, EventArgs e)
        {
            
        }

        void MAJExemplairesRetrouvés(string idOuvrage,string cote, string idSiteAprès, string idEmplaAprès)
        {
            string requete = "INSERT INTO SeTrouveE(uidInventaire, IdSite, IdEmpla, IdOuvrage, Cote, rowguid) VALUES ('" +
                             uidInventaireReference + "'," + idSiteAprès + "," + idEmplaAprès + "," + idOuvrage + ",'" + cote + "', NEWID())";
            if (MaConnexion.ExecuteUpdate(connectionString, requete) != 1)
                MessageBox.Show("Echec de la mise à jour du bien numéro '" + cote + "'", "Erreur de modification", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void bMAJExemplaires_Click(object sender, EventArgs e)
        {
            
        }

        private void mAJTousLesBiensDéplacésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bMAJBiensDéplacés.PerformClick();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            bMAJBiensPerdus.PerformClick();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            bMAJBiensRetrouvés.PerformClick();
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            
        }

        private void toolStripMenuItem10_Click(object sender, EventArgs e)
        {
            
        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            
        }

        private void cMSMAJBienDéplacé_Opening(object sender, CancelEventArgs e)
        {

        }

        private void mAJBiensDéplacésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listViewBien.SelectedItems.Count; i++)
            {
                ListViewItem lVI = listViewBien.SelectedItems[i];
                string idBien = lVI.SubItems[0].Text;

                string[] tab = lVI.Name.Split(new char[] { '*' });
                string idSiteIdEmplaAvant = tab[0];
                string idSiteIdEmplaAprès = tab[1];

                tab = idSiteIdEmplaAvant.Split(new char[] { '_' });
                string idSiteAvant = tab[0];
                string idEmplaAvant = tab[1];

                tab = idSiteIdEmplaAprès.Split(new char[] { '_' });
                string idSiteAprès = tab[0];
                string idEmplaAprès = tab[1];

                if (idEmplaAvant != "" && idEmplaAprès != "" && idEmplaAvant != idEmplaAprès)
                {
                    MAJBiensDéplacés(idBien, idSiteAvant, idEmplaAvant, idSiteAprès, idEmplaAprès);
                }
            }
            buttoncomparer.PerformClick();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listViewBien.SelectedItems.Count; i++)
            {
                ListViewItem lVI = listViewBien.SelectedItems[i];
                string idBien = lVI.SubItems[0].Text;

                string[] tab = lVI.Name.Split(new char[] { '*' });
                string idSiteIdEmplaAvant = tab[0];
                string idSiteIdEmplaAprès = tab[1];

                tab = idSiteIdEmplaAvant.Split(new char[] { '_' });
                string idSiteAvant = tab[0];
                string idEmplaAvant = tab[1];

                tab = idSiteIdEmplaAprès.Split(new char[] { '_' });
                string idSiteAprès = tab[0];
                string idEmplaAprès = tab[1];

                if (idEmplaAprès == "")
                {
                    MAJBiensPerdus(idBien, idSiteAvant, idEmplaAvant);
                }
            }
            buttoncomparer.PerformClick();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listViewBien.SelectedItems.Count; i++)
            {
                ListViewItem lVI = listViewBien.SelectedItems[i];
                string idBien = lVI.SubItems[0].Text;

                string[] tab = lVI.Name.Split(new char[] { '*' });
                string idSiteIdEmplaAvant = tab[0];
                string idSiteIdEmplaAprès = tab[1];

                tab = idSiteIdEmplaAvant.Split(new char[] { '_' });
                string idSiteAvant = tab[0];
                string idEmplaAvant = tab[1];

                tab = idSiteIdEmplaAprès.Split(new char[] { '_' });
                string idSiteAprès = tab[0];
                string idEmplaAprès = tab[1];

                if (idEmplaAvant == "")
                {
                    MAJBiensRetrouvés(idBien, idSiteAprès, idEmplaAprès);
                }
            }
            buttoncomparer.PerformClick();
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            
        }

        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {
            
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            
        }

        private void treeViewEmplacement_AfterCheck(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Checked)
                ajouterSiteEmpla(e.Node);
            else
                supprimerSiteEmpla(e.Node);
        }

        private void ajouterSiteEmpla(TreeNode node) 
        {
            String[] tabId = node.Name.Split(new char[] { '_' });
            String idSite = tabId[0];
            String idEmpla = tabId[1];
            aLEmplacementsCochés.Add(new SiteEmpla(idSite, idEmpla));
        }

        private void supprimerSiteEmpla(TreeNode node)
        {
            String[] tabId = node.Name.Split(new char[] { '_' });
            String idSite = tabId[0];
            String idEmpla = tabId[1];
            bool trouve = false;
            for (int i = 0; i < aLEmplacementsCochés.Count && !trouve; i++) 
            {
                if (((SiteEmpla)aLEmplacementsCochés[i]).IdSite.Equals(idSite) && ((SiteEmpla)aLEmplacementsCochés[i]).IdEmpla.Equals(idEmpla))
                    aLEmplacementsCochés.RemoveAt(i);
            }
        }

        private bool cocherDécocherNoeud(TreeNode node) 
        {
            if (node != null)
            {
                String[] tabId = node.Name.Split(new char[] { '_' });
                String idSite = tabId[0];
                String idEmpla = tabId[1];
                for (int i = 0; i < aLEmplacementsCochés.Count; i++)
                {
                    if (((SiteEmpla)aLEmplacementsCochés[i]).IdSite.Equals(idSite) && ((SiteEmpla)aLEmplacementsCochés[i]).IdEmpla.Equals(idEmpla))
                    {
                        node.Checked = true;
                        return true;
                    }

                }
            }
            return false;
        }

        private void afficherListe() 
        {
            for (int i = 0; i < aLEmplacementsCochés.Count; i++)
            {
                Console.WriteLine(((SiteEmpla)aLEmplacementsCochés[i]).IdSite + "_" + ((SiteEmpla)aLEmplacementsCochés[i]).IdEmpla);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
                
        private void listViewBien_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            TrierListeBien(e.Column);

            /*
            switch (listViewBien.Columns[e.Column].Name) 
            {
                case "columnIdentifiant":           comparer2Inventaires(" order by Bien.idBien"); break;
                case "columnDesignation":           comparer2Inventaires(" order by Bien.desigBien"); break;
                case "columnCatégorie":             comparer2Inventaires(" order by CategorieBien.DesigCategorieBien"); break;
                case "columnDateAcquisitionBien":   comparer2Inventaires(" order by Bien.DateAcquisitionBien"); break;
                case "columnEtatInit":              comparer2Inventaires(" order by Etat.DesigEtat"); break;
                case "columnEtatFin":               comparer2Inventaires(" order by "); break;
                case "columnPrix":                  comparer2Inventaires(" order by "); break;
                case "columnParticularité":         comparer2Inventaires(" order by "); break;
                case "columnEmplacementAvant":      comparer2Inventaires(" order by "); break;
                case "columnEmplacementAprès":      comparer2Inventaires(" order by "); break;

            }*/
        }

        private void TrierListeBien(int indexColumn) 
        {
            if (listViewBien.Items.Count > 0) 
            {
                bool continuer = true;
                if (MinVersMax) //un tri min vers max a déja été fait sur cette colonne => tentative de tri Max vers min 
                {
                    while (continuer)
                    {
                        continuer = false;
                        for (int i = 0; i < listViewBien.Items.Count - 1; i++)
                        {

                            if (listViewBien.Items[i + 1].SubItems[indexColumn].Text.CompareTo(listViewBien.Items[i].SubItems[indexColumn].Text) < 0)
                            {
                                ListViewItem lV = listViewBien.Items[i + 1];
                                listViewBien.Items.RemoveAt(i + 1);
                                listViewBien.Items.Insert(i, lV);
                                continuer = true;
                            }
                        }
                    }
                }
                else 
                {
                    while (continuer)
                    {
                        continuer = false;

                        for (int i = 0; i < listViewBien.Items.Count - 1; i++)
                        {

                            if (listViewBien.Items[i + 1].SubItems[indexColumn].Text.CompareTo(listViewBien.Items[i].SubItems[indexColumn].Text) > 0)
                            {
                                ListViewItem lV = listViewBien.Items[i + 1];
                                listViewBien.Items.RemoveAt(i + 1);
                                listViewBien.Items.Insert(i, lV);
                                continuer = true;
                            }
                        }
                    }
                }

                MinVersMax = !MinVersMax;
            }
            
        }

        private string extractListEmpla() 
        {
            string str = "(";
            for (int i = 0; i < aLEmplacementsCochés.Count; i++) 
            {
                str = str + ((SiteEmpla)aLEmplacementsCochés[i]).IdEmpla + ",";
            }
            str = str.Substring(0, str.Length - 1) + ")";
            return str;
        }


    }    
}
