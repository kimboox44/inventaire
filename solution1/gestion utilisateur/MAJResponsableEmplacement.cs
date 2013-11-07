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
    public partial class MAJResponsableEmplacement : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["connectString1"].ConnectionString;
        DataSet dataSet = null;
        DataSet dS = null;
        string query = null;
        string requete = null;
        string idSite = null;
        string idEmpla = null;

        public MAJResponsableEmplacement(string idSite, string idEmpla)
        {
            this.idSite = idSite;
            this.idEmpla = idEmpla;
            InitializeComponent();
        }

        public MAJResponsableEmplacement()
        {
            InitializeComponent();
        }

        struct structSite
        {
            string idSite;
            string nomSite;
            public structSite(String idSite, string nomSite) { this.idSite = idSite; this.nomSite = nomSite; }
            public string Idsite
            {
                get { return idSite; }
            }
            public string NomSite
            {
                get { return nomSite; }
            }
        }

        private void MAJResponsableEmplacement_Load(object sender, EventArgs e)
        {
            chargerResponsable();
            chargerSites();            
        }

        private void chargerSites()
        {
            //chargement des sites
            DataSet dsite = MaConnexion.ExecuteSelect(connectionString, "select * from site where etatSite = 'Non supprimé'");
            foreach (DataRow row in dsite.Tables[0].Rows)
            {
                structSite str = new structSite(row[0].ToString(), row[1].ToString());
                cBSite.Items.Add(str);
            }

            sélectionnerSite(idSite);
            sélectionnerEmplacement(idEmpla);
        }

        private void sélectionnerSite(string idSite) 
        {
            //Sélection du site adéquat
            if (idSite == null)
            {
                try //selection du premier site
                {
                    cBSite.SelectedIndex = 0;
                }
                catch (Exception) { } //pas de site dans la base de donnée
            }
            else
            {
                bool trouve = false;
                for (int i = 0; i < cBSite.Items.Count && !trouve; i++)
                {
                    if (((structSite)cBSite.Items[i]).Idsite.Equals(idSite))
                    {
                        trouve = true;
                        cBSite.SelectedIndex = i;
                    }
                }
            }
        }

        private void sélectionnerEmplacement(string idEmpla)
        {
            //Sélection de l'emplacemen du bien à modifier dans l'inventaire courant
            if (idEmpla != null)
                comparerEmplacement(tVEmplacements.Nodes[0], idEmpla);
        }

        void comparerEmplacement(TreeNode tn, String id)
        {
            string[] tab = tn.Name.Split(new char[] { '_' });
            if (tab[1] == id)
            {
                tn.TreeView.SelectedNode = tn;
            }
            else
            {
                if (tn.FirstNode != null)
                    comparerEmplacement(tn.FirstNode, id);
                if (tn.NextNode != null)
                    comparerEmplacement(tn.NextNode, id);
            }
        }

        private void chargerResponsable() 
        {
            requete = "SELECT idResp,nomResp,prenomResp,fonctionResp FROM Responsable where etatResp = 'Non supprimé'";            
            DataSet dataTable = MaConnexion.ExecuteSelect(connectionString, requete);
            if (dataTable != null)
            {
                dGVResponsables.Rows.Clear();
                foreach (DataRow dR in dataTable.Tables[0].Rows)
                {
                    dGVResponsables.Rows.Add(new object[] {false, dR[1].ToString(), dR[2].ToString(), dR[3].ToString()});
                    dGVResponsables.Rows[dGVResponsables.Rows.Count-2].Tag = dR[0].ToString(); //sauvegarde de l'identifiant du responsable
                    
                }
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

        private void comboBoxSite_SelectedIndexChanged(object sender, EventArgs e)
        {
            idSite = ((structSite)cBSite.SelectedItem).Idsite;
            tVEmplacements.Nodes.Clear();
            try
            {
                query = "select * from emplacement where idSitePere is null and idEmplaPere is null and idsite=" + ((structSite)cBSite.SelectedItem).Idsite;
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
                            + dRRacine[1].ToString() + ";";

                        DataSet sousDataTable = MaConnexion.ExecuteSelect(connectionString, requete);
                        foreach (DataRow dRCourant in sousDataTable.Tables[0].Rows)
                        {
                            TreeNode tNCourant = new TreeNode(dRCourant[4].ToString(), 0, 1);

                            //on stocke l'identifant de l'emplacement (idSite_idEmpla)
                            tNCourant.Name = dRCourant[0].ToString() + "_" + dRCourant[1].ToString();
                            racine.Nodes.Add(approfondir(tNCourant, dRCourant[0].ToString(), dRCourant[1].ToString()));
                        }
                        tVEmplacements.Nodes.Add(racine);
                    }
                    tVEmplacements.SelectedNode = tVEmplacements.Nodes[0];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Echec du chargement des emplacements", "Erreur de chargement des valeurs", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void tVEmplacements_AfterSelect(object sender, TreeViewEventArgs e)
        {
            rechercherResponsableCorrespondant(e.Node);
        }

        private void rechercherResponsableCorrespondant(TreeNode node) 
        {
            try
            {
                string[] tab = node.Name.Split(new char[] { '_' });
                requete = "select idResp from Emplacement where idEmpla = " + tab[1];
                Console.WriteLine(requete);

                dS = MaConnexion.ExecuteSelect(connectionString, requete);                
                for (int i=0; i < dGVResponsables.Rows.Count-1; i++) 
                {
                    if (dGVResponsables.Rows[i].Tag.ToString().Equals(dS.Tables[0].Rows[0][0].ToString()))
                        ((DataGridViewCheckBoxCell)dGVResponsables.Rows[i].Cells[0]).Value = true;
                    else
                        ((DataGridViewCheckBoxCell)dGVResponsables.Rows[i].Cells[0]).Value = false;
                }
            } catch (Exception ex ){} //si un emplacement ne possede pas de responsable
        }

        private void dGVResponsables_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            
            
        }

        private void dGVResponsables_CellValuePushed(object sender, DataGridViewCellValueEventArgs e)
        {

        }

        private void dGVResponsables_CellValueNeeded(object sender, DataGridViewCellValueEventArgs e)
        {
            MessageBox.Show("Modif");
        }

        private void dGVResponsables_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex == -1 || e.RowIndex == -1)
                return;

            if (dGVResponsables.Columns[e.ColumnIndex].Name == "ColumnSupprimer")
            {
                if (e.RowIndex != dGVResponsables.RowCount - 1)
                {
                    e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                    int intTop = (e.CellBounds.Height - 16) / 2 + e.CellBounds.Top;
                    int intLeft = (e.CellBounds.Width - 16) / 2 + e.CellBounds.Left;
                    try
                    {
                        e.Graphics.DrawImage(System.Drawing.Image.FromFile("delete.gif"), intLeft, intTop);
                    }
                    catch (Exception)
                    { }
                    e.Handled = true;
                }
                else
                {
                    e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                    int intTop = (e.CellBounds.Height - 16) / 2 + e.CellBounds.Top;
                    int intLeft = (e.CellBounds.Width - 16) / 2 + e.CellBounds.Left;
                    try
                    {
                        e.Graphics.DrawImage(System.Drawing.Image.FromFile("images.jpeg"), intLeft, intTop);
                    }
                    catch (Exception)
                    { }
                    e.Handled = true;
                }
            }
        }

        private void dGVResponsables_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            //click sur le bouton de suppression d'inventaire
            if (dGVResponsables.Columns[e.ColumnIndex].Name == "ColumnSupprimer")
            {
                if (e.RowIndex != dGVResponsables.RowCount - 1) //bouton de suppression
                {
                    if (MessageBox.Show("Voulez vous vraiment supprimer ce responsable ?", "Supprimer un respondsable", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                    {
                        requete = "update Responsable set etatResp = 'Supprimé' where idResp = " + dGVResponsables.Rows[e.RowIndex].Tag.ToString();
                        if (MaConnexion.ExecuteUpdate(connectionString, requete) == 1)
                            dGVResponsables.Rows.Remove(dGVResponsables.Rows[e.RowIndex]);
                        else
                            MessageBox.Show("La suppression a échoué", "Erreur de suppression", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else //bouton d'ajout
                {
                    DateTime date = DateTime.Now;
                    requete = "INSERT INTO Responsable (nomResp ,prenomResp ,fonctionResp ,etatResp) VALUES ('Nom','Prenom','Fonction','Non supprimé')";
                    if (MaConnexion.ExecuteUpdate(connectionString, requete) == 1)
                    {
                        DataSet dS = MaConnexion.ExecuteSelect(connectionString, "select idResp,nomResp ,prenomResp ,fonctionResp from responsable where idResp in (select max(idResp) from responsable)");
                        object[] newRow = new object[] { false, dS.Tables[0].Rows[0][1].ToString(), dS.Tables[0].Rows[0][2].ToString(), dS.Tables[0].Rows[0][3].ToString() };
                        dGVResponsables.Rows.Add(newRow);
                        dGVResponsables.Rows[dGVResponsables.Rows.Count - 2].Tag = dS.Tables[0].Rows[0][0].ToString(); //sauvegarde de l'identifiant du responsable
                    }
                    else
                    {
                        MessageBox.Show("Echec d'insertion du responsable", "Saisie incomplète", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void dGVResponsables_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (dGVResponsables.Columns[e.ColumnIndex].Name == "ColumnNom")
            {
                try
                {
                    requete = "update Responsable set nomResp = '" + dGVResponsables.Rows[e.RowIndex].Cells["ColumnNom"].Value + "' where idResp = " + dGVResponsables.Rows[e.RowIndex].Tag.ToString();
                    if (MaConnexion.ExecuteUpdate(connectionString, requete) != 1)
                    {
                        MessageBox.Show("La modification n'a pas été prise en charge", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                catch (Exception) { }
            }
            else if (dGVResponsables.Columns[e.ColumnIndex].Name == "ColumnPrenom")
            {
                try
                {
                    requete = "update Responsable set prenomResp = '" + dGVResponsables.Rows[e.RowIndex].Cells["ColumnPrenom"].Value + "' where idResp = " + dGVResponsables.Rows[e.RowIndex].Tag.ToString();
                    if (MaConnexion.ExecuteUpdate(connectionString, requete) != 1)
                    {
                        MessageBox.Show("La modification n'a pas été prise en charge", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                catch (Exception) { }
            }
            else if (dGVResponsables.Columns[e.ColumnIndex].Name == "ColumnFonction")
            {
                try
                {
                    requete = "update Responsable set fonctionResp = '" + dGVResponsables.Rows[e.RowIndex].Cells["ColumnFonction"].Value + "' where idResp = " + dGVResponsables.Rows[e.RowIndex].Tag.ToString();
                    if (MaConnexion.ExecuteUpdate(connectionString, requete) != 1)
                    {
                        MessageBox.Show("La modification n'a pas été prise en charge", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                catch (Exception) { }
            }
        }

        private void bSites_Click(object sender, EventArgs e)
        {
           // (new MAJSites()).ShowDialog();
        }

        private void dGVResponsables_CellStateChanged(object sender, DataGridViewCellStateChangedEventArgs e)
        {
            if (dGVResponsables.Columns[e.Cell.ColumnIndex].Name == "ColumnResponsable")
            {
                try
                {
                    string msg = String.Format("Row {0}, Column {1}, {2}", e.Cell.RowIndex, e.Cell.ColumnIndex, e.StateChanged);
                    MessageBox.Show(msg, "Cell State Changed");

                    for (int i = 0; i < dGVResponsables.Rows.Count; i++)
                    {
                        ((DataGridViewCell)dGVResponsables.Rows[i].Cells["ColumnResponsable"]).Value = false;
                    }

                    string idEmpla = tVEmplacements.SelectedNode.Name.Split(new char[] { '_' })[1];
                    string idResp = null;

                    //MessageBox.Show( ((bool)((DataGridViewCell)dGVResponsables.Rows[e.Cell.RowIndex].Cells["ColumnResponsable"]).Value).ToString() );
                    idResp = dGVResponsables.Rows[e.Cell.RowIndex].Tag.ToString();
                    requete = "update Emplacement set idResp = " + idResp + " where idEmpla = " + idEmpla;
                    if (MaConnexion.ExecuteUpdate(connectionString, requete) != 1)
                    {
                        MessageBox.Show("La modification n'a pas été prise en charge", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                catch (Exception) { }

            }
        }

    }
}
