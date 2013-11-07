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
using System.IO;
using System.Collections.ObjectModel;


namespace solution1
{
    public partial class FormInventaire : Form
    {
        MDIParent mDIParent = null;
        public string uidInventaire = null;
        public string DesigInventaire = "Inventaire général";
        string connectionString = ConfigurationManager.ConnectionStrings["connectString1"].ConnectionString;
        string defaultPath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
        String query = null;
        //IDataReader reader = null;
        DataSet dataSet = null;
        public ListViewItem lVI = null;
        private TreeNode hoverNode;
        public string idSite = "1";
        private List<Bien> listBien = new List<Bien>();

        public FormInventaire(MDIParent mDIParent, String uidInventaire)
        {
            this.mDIParent = mDIParent;
            this.uidInventaire = uidInventaire;
            InitializeComponent();
            //change the dimensions of button itself 
            toolStrip1.AutoSize = false;
            toolStrip1.Height = 50;
            toolStripButton1.AutoSize = false;
            toolStripButton1.Width = 50;
            //resize the image of the button to the 
            int sourceWidth = toolStripButton1.Image.Width;
            int sourceHeight = toolStripButton1.Image.Height;
            Bitmap b = new Bitmap(40, 40);
            Graphics g = Graphics.FromImage((Image)b);
            g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            g.DrawImage(toolStripButton1.Image, 0, 0, 40, 40);
            g.Dispose(); Image myResizedImg = (Image)b;
            //put the resized image back to the button and change toolstrip's 
            toolStripButton1.Image = myResizedImg;
            toolStrip1.ImageScalingSize = new Size(35, 35);
            gestion_utilisateur.privilege privi = new gestion_utilisateur.privilege();
            privi.forminventaire(mDIParent.priv, this);
            //privi.forminventaire(mDIParent.priv, this);
        }

        struct structEtat
        {
            string idEtat;
            string etat;
            public structEtat(String idEtat, string etat) { this.idEtat = idEtat; this.etat = etat; }
            public string IdEtat
            {
                get { return idEtat; }
            }
            public string Etat
            {
                get { return etat; }
            }
        }

        public struct structSite
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

        struct structIdOuvrageCote
        {
            string idOuvrage;
            string cote;
            public structIdOuvrageCote(string idOuvrage, string cote) { this.idOuvrage = idOuvrage; this.cote = cote; }
            public string IdOuvrage
            {
                get { return idOuvrage; }
            }
            public string Cote
            {
                get { return cote; }
            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            string requete_id_inventaire = "select type,caract from Inventaire where uidInventaire='" + uidInventaire + "'";
            DataSet ds_car = MaConnexion.ExecuteSelect(connectionString, requete_id_inventaire);
            string type = ds_car.Tables[0].Rows[0][0].ToString();
            string caract = ds_car.Tables[0].Rows[0][1].ToString();

            lab_inf.Text = "Inventaire " + type.ToString() + " " + caract.ToString();

            if (type != "Comptable" || caract != "En cours")
            {

                toolStripButton1.Visible = false;
                tSSBEmplacement.Visible = false;
                tSSBBien.Visible = false;
                tSSBClient.Visible = false;
                tSSBFournisseur.Visible = false;
                tSBCatégorie.Visible = false;
                toolStripSplitButton1.Visible = false;
                toolStripSplitButton2.Visible = false;

                toolStripSeparator1.Visible = false;
                toolStripSeparator10.Visible = false;
                toolStripSeparator7.Visible = false;
                cloture.Visible = false;

            }


            this.WindowState = FormWindowState.Maximized;
            chargerSites();
        }

        private void chargerSites()
        {

            //chargement des sites
            DataSet dsite = MaConnexion.ExecuteSelect(connectionString, "select * from site where etatSite = 'Non supprimé'");
            foreach (DataRow row in dsite.Tables[0].Rows)
            {
                structSite str = new structSite(row[0].ToString(), row[1].ToString());
                comboBoxSite.Items.Add(str);
            }

            try //selection du premier site
            {
                comboBoxSite.Text = dsite.Tables[0].Rows[0][1].ToString();
                treeViewEmplacement.SelectedNode = treeViewEmplacement.Nodes[0];
            }
            catch (Exception) { } //pas de site dans la base de donnée
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
                    TreeNode subNode = new TreeNode(dRCourant[4].ToString(), 0, 1);

                    //on stocke l'identifant de l'emplacement (idSite_idEmpla)
                    subNode.Name = dRCourant[0].ToString() + "_" + dRCourant[1].ToString();
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

        public void tV_AfterSelect(object sender, TreeViewEventArgs e)//afficher dans le tableau  *** listviewbien ***
        {
            try
            {
                //Biens dans le listView
                TreeNode tN = (TreeNode)e.Node;
                String id = tN.Name;
                String[] tabId = id.Split(new char[] { '_' });
                String idSite = tabId[0];
                String idEmpla = tabId[1];
                //String idEmplaCmplet = (((MaConnexion.ExecuteSelect(connectionString, "select idEmplaComplet from Emplacement where idEmpla ='" + idEmpla+"';")).Tables[0]).Rows[0]).ToString();
                DataSet dataTableidEmplaCmplet = MaConnexion.ExecuteSelect(connectionString, "select idEmplaComplet from Emplacement where idEmpla ='" + idEmpla + "' and etatEmpla='Non Supprimé';");
                DataRow dRidEmplaCmplet = dataTableidEmplaCmplet.Tables[0].Rows[0];
                String idEmplaCmplet = dRidEmplaCmplet[0].ToString();



                query = "select Bien.idBien, "
                +"Bien.ancienCode,"
                +"Bien.DesigBien,"
                +"CategorieBien.DesigCategorieBien,"
                +"Bien.DateAcquisitionBien,"
                +"Etat.DesigEtat, "
                +"Bien.Prix, "
                +"Bien.Particularite, "
                +"Bien.numFacture, "
                +"Bien.numSerie, "
                +"Bien.marque, "
                +"Bien.idCategorieBien "
                +"from seTrouveB, Bien, Etat,CategorieBien where CategorieBien.IdCategorieBien=Bien.IdCategorieBien and Etat.IdEtat=seTrouveB.IdEtat and seTrouveB.idBien=Bien.idBien and idSite= " + idSite + " and idEmpla = " + idEmplaCmplet + "and uidInventaire = '" + uidInventaire + "' and Bien.etat = 'Non supprimé';";
                DataSet dataTable = MaConnexion.ExecuteSelect(connectionString, query);
                if (dataTable != null)
                {
                    listViewBien.Items.Clear();
                    foreach (DataRow dR in dataTable.Tables[0].Rows)
                    {
                        ListViewItem listViewItem = new ListViewItem(new string[] { dR[0].ToString(), dR[1].ToString(), dR[2].ToString(), dR[3].ToString(), dR[4].ToString(), dR[5].ToString(), dR[6].ToString(), dR[7].ToString(), dR[8].ToString(), dR[9].ToString(), dR[10].ToString() }, 0);
                        listViewItem.Name = dR[11].ToString(); //sauvegarde de la categorie de bien
                        listViewBien.Items.Add(listViewItem);
                    }
                }

            }
            catch (Exception ex) //selection d'un emplacement qui n'a pas encore d'identifiant (node.Name == "")
            {
                //if (this.MdiParent != null)
                //this.mDIParent.toolStripStatusLabel1.Text = "L'emplacement " + ((TreeNode)e.Node).Name + " ne contient pas de bien";
            }
        }


        private void listViewBien_MouseDown(object sender, MouseEventArgs e)
        {
            // Il s'agit du boutton droit
            if (e.Button == MouseButtons.Right)
            {
                // Récupère le menuItem situé sous la souris
                lVI = listViewBien.GetItemAt(e.X, e.Y);
                // La souris est bien au-dessus d'un menuItem
                if (lVI != null)
                {
                    contextMenuBien.Show(listViewBien, new Point(e.X, e.Y));
                }
            }
        }

        private void treeViewEmplacement_MouseDown(object sender, MouseEventArgs e)
        {
            // Récupère le noeud situé sous la souris
            TreeNode node = treeViewEmplacement.GetNodeAt(e.X, e.Y);

            // Il s'agit du boutton droit
            if (e.Button == MouseButtons.Right)
            {
                if (node != null) // La souris est bien au-dessus d'un noeud
                {
                    // Met la sélection sur le noeud
                    treeViewEmplacement.SelectedNode = node;
                    contextMenuEmplacement.Show(treeViewEmplacement, new Point(e.X, e.Y));
                }
                else // La souris n'est pas au-dessus d'un noeud => possibilité d'ajouter de bien seulement
                {
                    treeViewEmplacement.SelectedNode = null;
                    cMAjouterEmplacement.Show(treeViewEmplacement, new Point(e.X, e.Y));
                }
            }
        }

        private void supprimerLeBienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez vous vraiment supprimer ce bien ?", "Suppression d'un bien", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                String[] tabId = treeViewEmplacement.SelectedNode.Name.Split(new char[] { '_' });
                String idEmpla = tabId[1];
                if (new Bien(lVI.SubItems[0].Text).supprimerBien(uidInventaire, idEmpla) != -1)
                {
                    listViewBien.Items.Remove(lVI);
                }
            }
        }

        private void ajoiuterBienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AjouterBien ajouterBien = new AjouterBien(this);
            ajouterBien.Show();
        }

        private void modifierLeBienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ModifierBien(this).ShowDialog();
        }

        void comparer(TreeNode tn, String id)
        {
            if (tn.Name == id)
            {
                tn.TreeView.SelectedNode = tn;
            }
            else
            {
                if (tn.FirstNode != null)
                    comparer(tn.FirstNode, id);
                if (tn.NextNode != null)
                    comparer(tn.NextNode, id);
            }
        }


        private void comboBoxSite_SelectedIndexChanged(object sender, EventArgs e)
        {
            idSite = ((structSite)comboBoxSite.SelectedItem).idsite;
            treeViewEmplacement.Nodes.Clear();
            try
            {
                query = "select * from emplacement where idSitePere is null and idEmplaPere is null  and etatEmpla='Non Supprimé' and idsite=" + ((structSite)comboBoxSite.SelectedItem).idsite;
                dataSet = MaConnexion.ExecuteSelect(connectionString, query);

                if (dataSet.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow dRRacine in dataSet.Tables[0].Rows)
                    {
                        TreeNode racine = new TreeNode(dRRacine[4].ToString(), 0, 1);

                        //on stocke l'identifant de l'emplacement (idSite_idEmpla)
                        racine.Name = dRRacine[0].ToString() + "_" + dRRacine[1].ToString();
                        String requete = "select * from emplacement where idSitePere = "
                            + dRRacine[0].ToString()
                            + " and idEmplaPere = "
                            + dRRacine[1].ToString() + " and etatEmpla='Non Supprimé';";

                        DataSet sousDataTable = MaConnexion.ExecuteSelect(connectionString, requete);
                        foreach (DataRow dRCourant in sousDataTable.Tables[0].Rows)
                        {
                            TreeNode tNCourant = new TreeNode(dRCourant[4].ToString(), 0, 1);

                            //on stocke l'identifant de l'emplacement (idSite_idEmpla)
                            tNCourant.Name = dRCourant[0].ToString() + "_" + dRCourant[1].ToString();
                            racine.Nodes.Add(approfondir(tNCourant, dRCourant[0].ToString(), dRCourant[1].ToString()));
                        }
                        treeViewEmplacement.Nodes.Add(racine);
                    }
                    treeViewEmplacement.SelectedNode = treeViewEmplacement.Nodes[0];
                }
            }
            catch (Exception ex)
            {
                this.BackColor = Color.Red;
            }
        }

        public int recupereridentifiantouvrage(string a)
        {
            string[] tab = a.Split(new char[] { '/' });
            string[] tab1 = tab[1].Split(new char[] { '.' });
            string aa = ""; char[] tt = tab1[0].ToCharArray();
            for (int i = 0; i < tab1[0].Length; i++)
            {
                if (!tt[i].Equals("0"))
                    aa += tt[i];
            }
            return Convert.ToInt32(aa);
        }

        private void ajouterEmplacementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ajouterEmplacement();
        }

        private void tSBAjouterEmplacement_Click(object sender, EventArgs e)
        {
            ajouterEmplacement();
        }

        private void ajouterEmplacement()
        {
            string siteid = ((structSite)comboBoxSite.SelectedItem).idsite;
            DataSet emplacementid = MaConnexion.ExecuteSelect(connectionString, "select max(idEmpla) from Emplacement");
            int emplacement = int.Parse(emplacementid.Tables[0].Rows[0][0].ToString());
            emplacement++;

            string idEmplaComplet = "";
            string idEmplaComplet1 = siteid;
            string idEmplaComplet2 = "";
            string idEmplaComplet3 = emplacement.ToString();


            if (idEmplaComplet1.Length == 1)
                idEmplaComplet1 = "0" + idEmplaComplet1;

            idEmplaComplet2 = idEmplaComplet2 + DateTime.Now.Year.ToString().Substring(2, 2);

            while (idEmplaComplet3.Length < 5)
                idEmplaComplet3 = "0" + idEmplaComplet3;

            idEmplaComplet = idEmplaComplet1 + idEmplaComplet2 + idEmplaComplet3;


            if (treeViewEmplacement.SelectedNode != null) //un noeud est selectionné
            {
                TreeNode node = treeViewEmplacement.SelectedNode;
                TreeNode childNode = new TreeNode("Nouvel emplacement", 0, 1);
                node.Nodes.Add(childNode);
                node.Expand();
                treeViewEmplacement.SelectedNode = childNode;

                String id = node.Name; // sous la forme idSite_idEmpla
                String[] tabId = id.Split(new char[] { '_' });
                String idSite = tabId[0];
                String idEmpla = tabId[1];

                String query = "INSERT INTO Emplacement (IdSite,IdSitePere,IdEmplaPere,idEmplaComplet, DesigEmpla,etatEmpla) VALUES (" + idSite + "," + idSite + "," + idEmpla + ", '" + idEmplaComplet + "','Nouvel emplacement','Non Supprimé')";

                MaConnexion.ExecuteUpdate(connectionString, query);
                DataSet ds = MaConnexion.ExecuteSelect(connectionString, "select max(idEmpla) from Emplacement");
                childNode.Name = idSite + "_" + ds.Tables[0].Rows[0][0].ToString();
                childNode.BeginEdit();
            }
            else
            { //aucun noeud n'est selectionné
                TreeNode node = new TreeNode("Nouvel emplacement", 0, 1);
                treeViewEmplacement.Nodes.Add(node);
                treeViewEmplacement.SelectedNode = node;
                String idSite = ((structSite)comboBoxSite.SelectedItem).idsite;



                String query = "INSERT INTO Emplacement (IdSite,IdSitePere,IdEmplaPere,idEmplaComplet ,DesigEmpla,etatEmpla) VALUES (" + idSite + ", NULL, NULL,'" + idEmplaComplet + "','Nouvel emplacement','Non Supprimé')";
                MaConnexion.ExecuteUpdate(connectionString, query);
                DataSet ds = MaConnexion.ExecuteSelect(connectionString, "select max(IdEmpla) from Emplacement");
                node.Name = idSite + "_" + ds.Tables[0].Rows[0][0].ToString();
                node.BeginEdit();
            }

        }

        private void modifierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TreeNode node = treeViewEmplacement.SelectedNode;
            node.BeginEdit();
        }

        private void ajouterUnEmplacementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ajouterEmplacement();
        }

        private void supprimerLemplacementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            supprimerEmplacement();
        }

        private void treeViewEmplacement_AfterLabelEdit(object sender, NodeLabelEditEventArgs e)
        {
            TreeNode node = treeViewEmplacement.SelectedNode;

            String id = node.Name; // sous la forme idSite_idEmpla
            String[] tabId = id.Split(new char[] { '_' });
            String idSite = tabId[0];
            String idEmpla = tabId[1];
            string newName = null;
            if (e.Label != null)
                newName = e.Label;
            else
                newName = node.Text;

            //former idEmplaComplet

            String query = "update Emplacement set desigEmpla = '" + newName + "' where idSite = " + idSite + " and idEmpla = " + idEmpla;
            MaConnexion.ExecuteUpdate(connectionString, query);

        }

        private void associerUnBienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (treeViewEmplacement.SelectedNode == null)
                try
                {
                    treeViewEmplacement.SelectedNode = treeViewEmplacement.Nodes[0];
                }
                catch (Exception)
                {
                    MessageBox.Show("Créez d'abord un emplacement", "Emplacement", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            AjouterBien ajouterBien = new AjouterBien(this);
            ajouterBien.Show();
        }

        private void listViewBien_ItemDrag(object sender, ItemDragEventArgs e)
        {
            List<string> itemIDs = new List<string>((sender as ListView).SelectedItems.Count);
            foreach (ListViewItem item in (sender as ListView).SelectedItems)
            {
                itemIDs.Add(item.SubItems[0].Text);
            }
            (sender as ListView).DoDragDrop(itemIDs.ToArray(), DragDropEffects.Move);
        }


        private void treeViewEmplacement_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void treeViewEmplacement_DragOver(object sender, DragEventArgs e)
        {
            Point mouseLocation = treeViewEmplacement.PointToClient(new Point(e.X, e.Y));
            TreeNode node = treeViewEmplacement.GetNodeAt(mouseLocation);
            if (node != null)
            {
                if (hoverNode == null)
                {
                    node.BackColor = Color.LawnGreen;
                    node.ForeColor = Color.White;
                    hoverNode = node;
                }
                else if (hoverNode != node)
                {
                    hoverNode.BackColor = Color.White;
                    hoverNode.ForeColor = Color.Black;
                    node.BackColor = Color.LawnGreen;
                    node.ForeColor = Color.White;
                    hoverNode = node;
                }
            }
        }

        private void treeViewEmplacement_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(string[])))
            {
                Point dropLocation = (sender as TreeView).PointToClient(new Point(e.X, e.Y));
                TreeNode dropNode = (sender as TreeView).GetNodeAt(dropLocation);
                string[] IDs = (string[])e.Data.GetData(typeof(string[]));

                try
                { //il s'agit d'un deplacement de biens                    
                    long.Parse(IDs[0]);
                    deplacerBien(IDs, dropNode);
                }
                catch (Exception)
                { //il s'agit d'un deplacement d'exemplaires  
                    deplacerExemplaire(IDs, dropNode);
                }
            }
            ResetTreeColors();
        }

        void deplacerBien(string[] IDs, TreeNode node)
        {
            if (node != null)
            {
                String[] tabId = node.Name.Split(new char[] { '_' });
                String idSite = tabId[0];
                String idEmpla = tabId[1];
                Boolean erreur = false;
                for (int i = 0; i < IDs.Length; i++)
                {
                    string requete = "update seTrouveB set idSite = " + idSite + ", idEmpla = " + idEmpla + " where idBien = '" + IDs[i] + "' and uidInventaire = '" + uidInventaire + "'";
                    if (MaConnexion.ExecuteUpdate(connectionString, requete) == 1)
                    {
                        treeViewEmplacement.SelectedNode = null;
                        treeViewEmplacement.SelectedNode = node;
                    }
                    else
                    {
                        erreur = true;
                    }
                }

                if (!erreur)
                    MessageBox.Show("Déplacement efféctuée", "Opération réussie", MessageBoxButtons.OK, MessageBoxIcon.None);
                else
                    MessageBox.Show("Erreur dans le déplacement des biens", "Erreur de déplacement", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        void deplacerExemplaire(string[] IDs, TreeNode node)
        {
            if (node != null)
            {
                String[] tabId = node.Name.Split(new char[] { '_' });
                String idSite = tabId[0];
                String idEmpla = tabId[1];
                string requete_empla = "select idemplacomplet from Emplacement where IdEmpla=" + idEmpla;
                DataSet idemplacp = MaConnexion.ExecuteSelect(connectionString, requete_empla);
                int emplacement_complet = int.Parse(idemplacp.Tables[0].Rows[0][0].ToString());
                MessageBox.Show("le id emplacement " + emplacement_complet);
                Boolean erreur = false;
                for (int i = 0; i < IDs.Length; i++)
                {
                    string requete = "update seTrouveB set idSite = " + idSite + ", idEmpla = " + emplacement_complet + " where IdBien = '" + IDs[i] + "' and uidInventaire = '" + uidInventaire + "'";
                    if (MaConnexion.ExecuteUpdate(connectionString, requete) == 1)
                    {
                        treeViewEmplacement.SelectedNode = null;
                        treeViewEmplacement.SelectedNode = node;
                    }
                    else
                    {
                        erreur = true;
                    }
                }

                if (!erreur)
                    MessageBox.Show("Déplacement efféctuée", "Opération réussie", MessageBoxButtons.OK, MessageBoxIcon.None);
                else
                    MessageBox.Show("Erreur dans le déplacement des exemplaires", "Erreur de déplacement", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void treeViewEmplacement_DragLeave(object sender, EventArgs e)
        {
            ResetTreeColors();
        }

        void ResetTreeColors()
        {
            int i = 0;
            while (i < treeViewEmplacement.Nodes.Count)
            {
                ResetTreeColorsRecursif(treeViewEmplacement.Nodes[i]);
                i++;
            }
        }

        void ResetTreeColorsRecursif(TreeNode node)
        {
            if (node != null)
            {
                node.BackColor = Color.White;
                node.ForeColor = Color.Black;

                if (node.FirstNode != null)
                    ResetTreeColorsRecursif(node.FirstNode);
                if (node.NextNode != null)
                    ResetTreeColorsRecursif(node.NextNode);

            }
        }


        private void ajouterBienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AjouterBien ajouterBien = new AjouterBien(this);
            ajouterBien.Show();
        }

        private void tSBSupprimerEmplacement_Click(object sender, EventArgs e)
        {
            supprimerEmplacement();
        }

        private void supprimerEmplacement()
        {
            try
            {
                TreeNode node = treeViewEmplacement.SelectedNode;

                String id = node.Name;
                String[] tabId = id.Split(new char[] { '_' });
                String idSite = tabId[0];
                String idEmpla = tabId[1];

                //string query = "delete from Emplacement where idSite = " + idSite + " and idEmpla = " + idEmpla;
                string query = "update Emplacement set etatEmpla='Supprimé' where idSite = " + idSite + " and idEmpla = " + idEmpla;

                if (MessageBox.Show("Voulez vous vraiment supprimer l'emplacement " + node.Text + " ?", "Suppression d'un emplacement", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                    if (MaConnexion.ExecuteUpdate(connectionString, query) == 1)
                        node.Remove();
                    else
                        MessageBox.Show("Impossible de supprimer cet emplacement. Commencez d'abord par supprimer ses sous-emplacements", "Suppression impossible", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            }
            catch (Exception) { }
        }

        private void listViewBien_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBien.Clear();
            for (int index = 0; index < ((ListView)sender).SelectedItems.Count; index++)
            {
                String identifiant = ((ListViewItem)((ListView)sender).SelectedItems[index]).SubItems[0].Text;
                String designation = ((ListViewItem)((ListView)sender).SelectedItems[index]).SubItems[2].Text;
                String date = ((ListViewItem)((ListView)sender).SelectedItems[index]).SubItems[3].Text;
                Bien bien = new Bien(identifiant);
                bien.setDesignation(designation);
                bien.setDate(date);
                listBien.Add(bien);
            }

        }

        private void imprimerLeBienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // List<string> list = new List<string>() { lVI.SubItems[0].Text };
            (new Imprimer(listBien, "Code 39")).Show();
        }

        private void imprimerLeCodeBarresDeLaCoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // List<string> list = new List<string>() { lVI.SubItems[0].Text };
            (new Imprimer(listBien, "Code 39")).Show();
        }

        private void imprimerLeCodeBarreDeLemplacementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                String[] tabId = treeViewEmplacement.SelectedNode.Name.Split(new char[] { '_' });
                String idEmpla = tabId[1];
                string requete = "select idEmplaComplet,desigEmpla from emplacement where idEmpla =" + idEmpla;
                DataSet dsIdEmplaComplet = MaConnexion.ExecuteSelect(connectionString, requete);

                //List<Bien> listBien = new List<Bien>(int.Parse( dsIdEmplaComplet.Tables[0].Rows[0][0].ToString())) ;

                String identifiant = dsIdEmplaComplet.Tables[0].Rows[0][0].ToString();
                String designation = dsIdEmplaComplet.Tables[0].Rows[0][1].ToString();
                //String date = ((ListViewItem)((ListView)sender).SelectedItems[index]).SubItems[3].Text;
                Bien bien = new Bien(identifiant);
                bien.setDesignation(designation);
                //bien.setDate(date);
                listBien.Add(bien);


                (new Imprimer(listBien, "Code 39")).Show();
            }
            catch (Exception) { }
        }


        private void tSBCategorie_Click(object sender, EventArgs e)
        {
            (new FormGestionCategorie(mDIParent)).Show();
        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            EditerEmplacement();
        }

        private void EditerEmplacement()
        {
            try
            {
                treeViewEmplacement.SelectedNode.BeginEdit();
            }
            catch (Exception)
            {
                MessageBox.Show("Sélectionnez d'abord un emplacement", "Editer un emplacement", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void tSBImprimer_Click(object sender, EventArgs e)
        {
            /*
            List<string> list = new List<string>();
            for (int i=0; i<listViewBien.SelectedItems.Count; i++)
                list.Add(listViewBien.SelectedItems[i].SubItems[0].Text);
            for (int i=0; i<listViewExemplaire.SelectedItems.Count; i++)
                list.Add(listViewExemplaire.SelectedItems[i].SubItems[0].Text);            
            (new Imprimer(list, "Code 39")).Show();
             */
        }

        /*    private void tSBRapports_Click(object sender, EventArgs e)
            {
                (new FormRapports()).Show();
            }

            private void listeDesBiensinventaireGénéralToolStripMenuItem_Click(object sender, EventArgs e)
            {
                (new FormCRListeBien()).Show();
            }

            private void biensParCatégorieinventaireGénéralToolStripMenuItem_Click(object sender, EventArgs e)
            {
                (new FormCRBienParCategorie()).Show();
            }

            private void biensParInventaireSiteEmplacementToolStripMenuItem_Click(object sender, EventArgs e)
            {
                (new FormCRBienParInventaireSiteEmpla()).Show();
            }*/

        private void comparaisonDeDeuxInventairesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new Comparer2Inventaires(mDIParent.idUtilisateur)).Show();
        }

        private void imprimerEtiquetteBien_Click(object sender, EventArgs e)
        {
            List<Bien> list = new List<Bien>();
            for (int i = 0; i < listViewBien.Items.Count; i++)
                list.Add(new Bien(listViewBien.Items[i].SubItems[0].Text));

            (new Imprimer(list, "Code 39")).Show();
        }



        private void bienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new AjouterBien(this)).Show();
        }



        private void tSBComparer_Click(object sender, EventArgs e)
        {
            (new Comparer2Inventaires(mDIParent.idUtilisateur)).Show();
        }

        private void listViewExemplaire_ItemDrag(object sender, ItemDragEventArgs e)
        {
            List<string> itemIDs = new List<string>((sender as ListView).SelectedItems.Count);
            foreach (ListViewItem item in (sender as ListView).SelectedItems)
            {
                itemIDs.Add(item.SubItems[0].Text);
            }
            (sender as ListView).DoDragDrop(itemIDs.ToArray(), DragDropEffects.Move);
        }

        private void bSites_Click(object sender, EventArgs e)
        {
            (new MAJSites(this)).ShowDialog();
        }

        private void ajouterUnEmplacementToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ajouterEmplacement();
        }

        private void tMSIEditerEplacement_Click(object sender, EventArgs e)
        {
            EditerEmplacement();
        }

        private void tMSISupprimerEmplacement_Click(object sender, EventArgs e)
        {
            supprimerEmplacement();
        }

        private void toolStripButton1_Click_3(object sender, EventArgs e)
        {
            (new MAJSites(this)).ShowDialog();
        }

        private void tSBCatégorie_Click(object sender, EventArgs e)
        {
            (new FormGestionCategorie(mDIParent)).ShowDialog();
        }

        private void tSMIListeFournisseurs_Click(object sender, EventArgs e)
        {
            (new MAJFournisseur()).ShowDialog();
        }

        private void tSMIAjouterFournisseur_Click(object sender, EventArgs e)
        {
            (new AjouterFournisseur()).ShowDialog();
        }

        private void listeDesClientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new MAJClient()).ShowDialog();
        }

        private void ajouterUnClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new AjouterClient()).ShowDialog();
        }

        private void ajouterUnBienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new AjouterBien(this)).ShowDialog();
        }

        private void modifierLeBienSélectionnéToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new ModifierBien(this)).ShowDialog();
        }


        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            String[] tabId = treeViewEmplacement.SelectedNode.Name.Split(new char[] { '_' });
            string idSite = tabId[0];
            string idEmpla = tabId[1];

            (new MAJResponsableEmplacement(idSite, idEmpla)).ShowDialog();
        }


        private void lesBonsDeTransfertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new FormBonsDeTransfert(uidInventaire)).ShowDialog();
        }

        private void listeDesPVDeCessionToolStripMenuItem_Click(object sender, EventArgs e)
        {

            (new Formcession(uidInventaire)).ShowDialog();
        }

        private void voirLesBonsDeTransfertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new AjouterBonDeTransfert(uidInventaire)).ShowDialog();
        }

        private void ajouterUnPVDeCessionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new MAJCession(uidInventaire)).ShowDialog();
        }

        private void cloture_Click(object sender, EventArgs e)
        {
            string reque = "update inventaire set caract='Cloturé' where uidInventaire='" + uidInventaire + "'";
            MaConnexion.ExecuteUpdate(connectionString, reque);
            FormInventaire formInventaire = new FormInventaire(mDIParent, uidInventaire);
            formInventaire.MdiParent = this.MdiParent;
            //formInventaire.Text = ((structInventaire)lBinventaire.SelectedItem).DesigInventaire;
            formInventaire.Show();
            this.Close();

            string req = "select type from inventaire where uidInventaire='" + uidInventaire.ToString() + "'";
            DataSet type = MaConnexion.ExecuteSelect(connectionString, req);
            if (type.Tables[0].Rows[0][0].ToString() == "Comptable")
            {
                MessageBox.Show("il n'existe plus d'inventaire comptable \n vous devriez ajouter un inventaire Comptable !!");
                Inventaire.choix_cpt ch = new Inventaire.choix_cpt(mDIParent);
                ch.Show();
            }

        }

        private void consulterLesBiensToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

    }
}
