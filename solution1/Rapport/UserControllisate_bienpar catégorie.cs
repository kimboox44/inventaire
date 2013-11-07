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

namespace solution1.Rapport
{
    public partial class UserControllisate_ibenpar_catégorie : UserControl
    {
      
        public UserControllisate_ibenpar_catégorie()
        {
           InitializeComponent();
           //chargerSites();
           charger_inventaire();
           // chargerinventaire();
        }

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

        public struct structinvent
        {
            string idinvent;
            string invent;
            public structinvent(String idinv, string inv) { this.idinvent = idinv; this.invent = inv; }
            public string idinv
            {
                get { return idinvent; }
            }
            public string inv
            {
                get { return invent; }
            }
        }

        private void UserControllisate_ibenpar_catégorie_Load(object sender, EventArgs e)
        {

        }

        public void charger_inventaire()
        {
            DataSet dsite = MaConnexion.ExecuteSelect(connectionString, "select * from inventaire where etat = 'Valide'");
            foreach (DataRow row in dsite.Tables[0].Rows)
            {
                structinvent str = new structinvent(row[0].ToString(), row[1].ToString());
                comboBoxinv.Items.Add(str);
            }

            try //selection du premier site
            {
                comboBoxinv.Text = dsite.Tables[0].Rows[0][1].ToString();
                treeViewEmplacement.SelectedNode = treeViewEmplacement.Nodes[0];
            }
            catch (Exception) { } //pas de site dans la base de donnée

        }

        private void chargerSites()
        {

            //chargement des sites
            DataSet dsite = MaConnexion.ExecuteSelect(connectionString, "select * from site join (select idsite from SeTrouveB group by (IdSite))as id on Site.IdSite=id.IdSite where site.etatSite='Non Supprimé'");
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

                               
                bien_categorieTableAdapter.Fill_bien(DataSet_bien.bien_categorie, idEmplaCmplet.ToString());
                reportViewer1.RefreshReport();
                
            }
            catch (Exception ex) //selection d'un emplacement qui n'a pas encore d'identifiant (node.Name == "")
            {
                //if (this.MdiParent != null)
                //this.mDIParent.toolStripStatusLabel1.Text = "L'emplacement " + ((TreeNode)e.Node).Name + " ne contient pas de bien";
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox_inventaire_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxSite.Items.Clear();
            chargerSites();
        }

    }
}
