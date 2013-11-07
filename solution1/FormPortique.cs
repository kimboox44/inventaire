using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;

namespace solution1
{
    public partial class FormPortique : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["connectString1"].ConnectionString;
        public string idSite = "1";
        String requete;
        DataSet dataSet = null;        

        public FormPortique()
        {
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

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void FormPortique_Load(object sender, EventArgs e)
        {
            chargementSites();
            chargerPortique();
        }

        private void chargementSites() 
        {   
            DataSet dsite = MaConnexion.ExecuteSelect(connectionString, "select * from site");
            foreach (DataRow row in dsite.Tables[0].Rows)
            {
                structSite str = new structSite(row[0].ToString(), row[1].ToString());
                comboBoxSite.Items.Add(str);
            }

            try //selection du premier site
            {
                comboBoxSite.Text = dsite.Tables[0].Rows[0][1].ToString();
                tVEmplacement.SelectedNode = tVEmplacement.Nodes[0];
            }
            catch (Exception) { } //pas de site dans la base de donnée
        }

        private void comboBoxSite_SelectedIndexChanged(object sender, EventArgs e)
        {
            chargementEmplacements();
        }

        private void chargementEmplacements() 
        {
            idSite = ((structSite)comboBoxSite.SelectedItem).idsite;
            tVEmplacement.Nodes.Clear();
            try
            {
                requete = "select * from emplacement where idSitePere is null and idEmplaPere is null and idsite=" + ((structSite)comboBoxSite.SelectedItem).idsite;
                dataSet = MaConnexion.ExecuteSelect(connectionString, requete);

                if (dataSet.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow dRRacine in dataSet.Tables[0].Rows)
                    {
                        TreeNode racine = new TreeNode(dRRacine[4].ToString(), 0, 1);

                        //on stocke l'identifant de l'emplacement (idSite_idEmpla)
                        racine.Name = dRRacine[0].ToString() + "_" + dRRacine[1].ToString();
                        requete = "select * from emplacement where idSitePere = "
                            + dRRacine[0].ToString()
                            + " and idEmplaPere = "
                            + dRRacine[1].ToString() + ";";

                        DataSet sousDataTable = MaConnexion.ExecuteSelect(connectionString, requete);
                        foreach (DataRow dRCourant in sousDataTable.Tables[0].Rows)
                        {
                            TreeNode tNCourant = new TreeNode(dRCourant[4].ToString(), 0, 1);

                            //on stocke l'identifant de l'emplacement (idSite_idEmpla)
                            tNCourant.Name = dRCourant[0].ToString() + "_" + dRCourant[1].ToString();
                            racine.Nodes.Add(approfondir(tNCourant, dRCourant[0].ToString(), dRCourant[1].ToString()));
                        }
                        tVEmplacement.Nodes.Add(racine);
                    }
                    tVEmplacement.SelectedNode = tVEmplacement.Nodes[0];
                }
            }
            catch (Exception ex)
            {
                this.BackColor = Color.Red;
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

        private void chargerPortique() 
        {
            tVPortiques.Nodes.Clear();
            requete = "select * from portique";
            dataSet = MaConnexion.ExecuteSelect(connectionString, requete);
            foreach (DataRow row in dataSet.Tables[0].Rows) 
            {
                TreeNode node = new TreeNode(row[1].ToString(), 2, 3);
                tVPortiques.Nodes.Add(node);
                node.Name = row[0].ToString();

                //ajout des noeuds emplacement associé a ce portique
                requete = "select idSite,emplacement.idEmpla, emplacement.desigEmpla from emplacement, associer where emplacement.idEmpla = associer.idEmpla "
                        + "and idPortique = " + row[0].ToString();                
                DataSet dS = MaConnexion.ExecuteSelect(connectionString, requete);
                if (dS != null) 
                {
                    foreach (DataRow ligne in dS.Tables[0].Rows)
                    {
                        TreeNode subNode = new TreeNode(ligne[2].ToString(), 0, 1);
                        subNode.Name = ligne[0].ToString() + "_" + ligne[1].ToString();
                        node.Nodes.Add(subNode);
                    }
                }

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tVEmplacement.SelectedNode != null && tVPortiques.SelectedNode != null)
            {
                if (tVPortiques.SelectedNode.Parent != null)
                    tVPortiques.SelectedNode = tVPortiques.SelectedNode.Parent;

                string[] tabId = tVEmplacement.SelectedNode.Name.Split(new char[] { '_' });
                string idEmpla = tabId[1];
                string idPortique = tVPortiques.SelectedNode.Name;
                if (tVPortiques.SelectedNode.Nodes.Count < 2) 
                {
                    requete = "select * from associer where idPortique = " + idPortique + " and idEmpla = " + idEmpla;                    
                    if (MaConnexion.ExecuteSelect(connectionString, requete).Tables[0].Rows.Count == 0) 
                    {
                        requete = "insert into associer(idPortique, idEmpla) values (" + idPortique + ", " + idEmpla + ");";                        
                        if (MaConnexion.ExecuteUpdate(connectionString, requete) == 1)
                        {
                            TreeNode node = new TreeNode(tVEmplacement.SelectedNode.Text, 0, 1);
                            node.Name = tVEmplacement.SelectedNode.Name;
                            tVPortiques.SelectedNode.Nodes.Add(node);
                            tVPortiques.SelectedNode = node;
                        }
                        else
                        {
                            MessageBox.Show("Echec lors de l'association de l'emplacement '" + tVEmplacement.SelectedNode.Text
                            + "' au portique '" + tVPortiques.SelectedNode.Text + "'", "Erreur d'insertion", MessageBoxButtons.OK
                            , MessageBoxIcon.Exclamation);
                        }
                    } else 
                    {
                        MessageBox.Show("L'emplacement '" + tVEmplacement.SelectedNode.Text + "' est déja associé au portique '" 
                                     + tVPortiques.SelectedNode.Text + "'", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }else 
                {
                    MessageBox.Show("Un portique ne peut être partagé que par 2 emplacement au plus", "Plus de 2 emplacements", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else 
            {
                MessageBox.Show("Sélectionnez d'abord un emplacement et un portique RFID", "Sélection", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void bNouveauPortique_Click(object sender, EventArgs e)
        {
            requete = "insert into portique values ('Nouveau portique')";
            if (MaConnexion.ExecuteUpdate(connectionString, requete) == 1)
            {
                TreeNode node = new TreeNode("Nouveau Portique", 2, 3);
                tVPortiques.Nodes.Add(node);

                try //recupération de l'identifiant du portique inséré
                {
                    requete = "select max(idPortique) from portique";
                    dataSet = MaConnexion.ExecuteSelect(connectionString, requete);
                    node.Name = dataSet.Tables[0].Rows[0][0].ToString();
                }
                catch (Exception)
                {
                    chargerPortique();
                }
                node.BeginEdit();
            }
            else 
            {
                MessageBox.Show("Renommer d'abord le portique 'Nouveau portique' ", "Nom du portique", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void tVPortiques_AfterLabelEdit(object sender, NodeLabelEditEventArgs e)
        {
            if (e.Node.Parent == null) //la modification ne concerne que les portiques (et non leurs fils qui sont des emplacements)
            {                
                TreeNode node = e.Node;                
                string newName = null;
                if (e.Label != null)
                    newName = e.Label;
                else
                    newName = node.Text;
                requete = "update portique set libelléPortique = '" + newName + "' where idPortique = " + node.Name;                
                if (MaConnexion.ExecuteUpdate(connectionString, requete) != 1)
                {
                    MessageBox.Show("Le portique '" + e.Label + "' existe dajà, choisissez un autre nom", "Nom du portique", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    chargerPortique();
                }                
            }
        }

        private void bSupprimer_Click(object sender, EventArgs e)
        {
            if (tVPortiques.SelectedNode != null) 
            {                
                if (tVPortiques.SelectedNode.Parent != null) //c'est un emplacement qui est sélectionné et non un portique
                    tVPortiques.SelectedNode = tVPortiques.SelectedNode.Parent;
                if (MessageBox.Show("Voulez vous vraiment supprimer le portique '" + tVPortiques.SelectedNode.Text + "' ?", "Supprimer un portique", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    requete = "delete from portique where idPortique = " + tVPortiques.SelectedNode.Name ;
                    if (MaConnexion.ExecuteUpdate(connectionString, requete) == 1) 
                    {
                        tVPortiques.Nodes.Remove(tVPortiques.SelectedNode);
                    } else 
                    {
                        MessageBox.Show("Echec de la suppression du portique '" + tVPortiques.SelectedNode.Text + "'", "Erreur de Suppression", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                        
                }
            } 
            else 
            {
                MessageBox.Show("Sélectionnez d'abord le portique à supprimer", "Portque non sélectionné", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (tVPortiques.SelectedNode != null) 
            {
                if (tVPortiques.SelectedNode.Parent != null) 
                {
                    string[] tabId = tVPortiques.SelectedNode.Name.Split(new char[] { '_' });
                    string idEmpla = tabId[1];
                    requete = "delete from associer where idPortique = " + tVPortiques.SelectedNode.Parent.Name + " and idEmpla = "
                            + idEmpla;                    
                    if (MaConnexion.ExecuteUpdate(connectionString, requete) != 1)
                    {
                        MessageBox.Show("Echec de la suppression de l'emplacement '" + tVPortiques.SelectedNode.Text + "' pour le portique '"
                        + tVPortiques.SelectedNode.Parent.Text + "'", "Erreur de suppression", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else 
                    {
                        tVPortiques.SelectedNode.Remove();
                    }
                }
                else
                    MessageBox.Show("Vous devez sélectionner un emplacement et non un portique", "Sélection", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else
                MessageBox.Show("Sélectionnez d'abord un emplacement", "Sélection", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void tVPortiques_BeforeLabelEdit(object sender, NodeLabelEditEventArgs e)
        {
            
        }

       // }
    }
}
