using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.Collections;

namespace solution1
{
    public partial class AjouterBonDeTransfert : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["connectString1"].ConnectionString;
        string idSiteSource = "";
        string idSiteDestination = "";
        string idEmplaSource = "";
        String idEmplaCmpletsource = "";
        string idEmplaDestination = "";
        string desigEmplaSource = "";
        string desigEmplaDestination= "";
        string idEmplaCmpletdestination = "";
        string requete = null;
        string query = null;
        string idinventaire;
        DataSet dataSet = null;
        string idBonTransfert = null;
        DataSet dS = null;
        ArrayList aLBiensTransférés = new ArrayList();
        string[] ligneBienTransféré = null; //idBien, ancienCode, desigBien, desigCategorieBien, dateAcquisition, desigEtat, prix, particularite, idEmplaSource, idEmplaDestination, desigEmplaSource

        public AjouterBonDeTransfert(String uidInventaire)
        {
            this.idinventaire = uidInventaire;
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

        private void BonDeTransfert_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized; 
            chargementSites();            
        }

        private void chargementSites() 
        {
            DataSet dsite = MaConnexion.ExecuteSelect(connectionString, "select * from site where etatsite='Non Supprimé'");
            foreach (DataRow row in dsite.Tables[0].Rows)
            {
                structSite str = new structSite(row[0].ToString(), row[1].ToString());
                cBSiteSource.Items.Add(str);
                cBSiteDestination.Items.Add(str);
            }

            //selection des premiers sites
            try
            {
                cBSiteSource.SelectedIndex = 0;
                cBSiteDestination.SelectedIndex = 0;
                tVEmplacements.SelectedNode = tVEmplacements.Nodes[0];
                tVEmplacementDestination.SelectedNode = tVEmplacementDestination.Nodes[0];
            }
            catch (Exception) 
            {
                MessageBox.Show("Vous devez créer au moins un site en ouvrant la fenêtre 'Gestion des sites'", "Aucun site créé", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            
        }

        private void tBSiteSource_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (aLBiensTransférés.Count != 0) // c'est l'utilisateur qui choisit un autre site 
            {
                MessageBox.Show("Tous les transferts de biens de ce bon de transfert seront perdues", "Changement de site", MessageBoxButtons.OK, MessageBoxIcon.Information);
                aLBiensTransférés.Clear();
                réinitialiserAfichageBien();
            }

            try { idSiteSource = ((structSite)cBSiteSource.SelectedItem).idsite; } catch (Exception) { }
            chargerTVEmplacementsSource();
        }

        private void chargerTVEmplacementsSource() 
        {            
            tVEmplacements.Nodes.Clear();
            try
            {                
                query = "select * from emplacement where idSitePere is null and idEmplaPere is null and idsite=" + idSiteSource;
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
                            + " and idEmplaPere = '"
                            + dRRacine[1].ToString() + "';";

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
            catch (Exception)
            {
                MessageBox.Show("Echec du chargements de l'arbre des emplacement", "Erreur de chargement des valeurs", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public TreeNode approfondir(TreeNode node, String idSite, String idEmpla)
        {
            String requete = "select * from emplacement where idSitePere = "
                        + idSite
                        + " and idEmplaPere = '"
                        + idEmpla + "';";

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

        private void tBSiteDestination_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (aLBiensTransférés.Count != 0) // c'est l'utilisateur qui choisit un autre site 
            {
                MessageBox.Show("Tous les transferts de biens de ce bon de transfert seront perdues", "Changement de site", MessageBoxButtons.OK, MessageBoxIcon.Information);
                aLBiensTransférés.Clear();
                réinitialiserAfichageBien();
            }
            
            try { idSiteDestination = ((structSite)cBSiteDestination.SelectedItem).idsite; } catch (Exception) { }
            chargerTVEmplacementsDestination();
        }

        private void chargerTVEmplacementsDestination()
        {
            tVEmplacementDestination.Nodes.Clear();
            try
            {                
                query = "select * from emplacement where idSitePere is null and idEmplaPere is null and idsite=" + idSiteDestination;
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
                            + " and idEmplaPere = '"
                            + dRRacine[1].ToString() + "';";

                        DataSet sousDataTable = MaConnexion.ExecuteSelect(connectionString, requete);
                        foreach (DataRow dRCourant in sousDataTable.Tables[0].Rows)
                        {
                            TreeNode tNCourant = new TreeNode(dRCourant[4].ToString(), 0, 1);

                            //on stocke l'identifant de l'emplacement (idSite_idEmpla)
                            tNCourant.Name = dRCourant[0].ToString() + "_" + dRCourant[1].ToString();
                            racine.Nodes.Add(approfondir(tNCourant, dRCourant[0].ToString(), dRCourant[1].ToString()));
                        }
                        tVEmplacementDestination.Nodes.Add(racine);
                    }
                    tVEmplacementDestination.SelectedNode = tVEmplacementDestination.Nodes[0];
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Echec du chargements de l'arbre des emplacement", "Erreur de chargement des valeurs", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void bAjouter_Click(object sender, EventArgs e)
        {
            enregistrerBonTransfert();
        }

        private void enregistrerBonTransfert()
        {
            string date = this.dTPDateTransfert.Value.ToString("dd-MM-yyyy");

            requete = "INSERT INTO BonTransfert (dateTransfert,motifTransfert,idSiteSource,idSiteDestination,etatBonTransfert) VALUES ('"
                    + date + "', '" + tBMotif.Text + "', " + idSiteSource + ", " + idSiteDestination + ", 'Non supprimé');";
            if (MaConnexion.ExecuteUpdate(connectionString, requete) != 1)
            {
                MessageBox.Show("Echec de l'enregistrement du bon de transfert", "Erreur d'enregistrement", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else 
            {
                //recupération de l'identifiant du bon de transfert courant :
                DataSet dS = MaConnexion.ExecuteSelect(connectionString, "select max(idBonTransfert) from BonTransfert");
                idBonTransfert = dS.Tables[0].Rows[0][0].ToString();

                //enregistrement des biens transférés dans ce bon de transfert
                bool erreur = false;
                for (int i = 0; i < aLBiensTransférés.Count; i++) 
                {
                    
                    requete = "INSERT INTO Transferer (idBien,idBonTransfert,idSiteSource,idEmplaSource,idSiteDest,idEmplaDest, reçu) VALUES ('"
                            + ((String[])aLBiensTransférés[i])[0] + "', "
                            + idBonTransfert + ","
                            + idSiteSource + ",'"
                            + (((String[])aLBiensTransférés[i])[8]).Trim() + "',"
                            + idSiteDestination + ",'" +
                            (((String[])aLBiensTransférés[i])[9]).Trim() + "', 'False');";
                    if (MaConnexion.ExecuteUpdate(connectionString, requete) != 1)
                    {
                        erreur = true;
                    }                    
                    else 
                    {
                        
                        //deplacement du bien dans l'inventaire général
                        requete = "update seTrouveB set idSite = " + idSiteDestination + ", idEmpla = '" + ((String[])aLBiensTransférés[i])[9]
                                + "' where idSite = " + idSiteSource + " and idEmpla = '" + ((String[])aLBiensTransférés[i])[8]
                                + "' and idBien = '" + ((String[])aLBiensTransférés[i])[0] + "' and uidInventaire = '"+idinventaire+"'";
                        
                        if (MaConnexion.ExecuteUpdate(connectionString, requete) != 1)
                        {
                            erreur = true;
                        }

                        //Modification de l'état du bien transféré ("Non supprimé" => "Transfréré")
                        /*requete = "update Bien set Bien.etat = 'En transfert' where Bien.idBien = '" + ((String[])aLBiensTransférés[i])[0] + "'";
                        if (MaConnexion.ExecuteUpdate(connectionString, requete) != 1)
                        {
                            erreur = true;
                        }
                        */
                    }  
                }

                if (erreur)
                {
                    MessageBox.Show("Echec de l'enregistrement des biens transférés", "Erreur d'enregistrement", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else 
                {
                    MessageBox.Show("Enregistrement efféctuée", "Opération réussie", MessageBoxButtons.OK, MessageBoxIcon.None);
                    this.Close();
                }                    
            }
        }

        private string getListIdBienTransférés() 
        {
            string listIdBienTransférés = "(";
            for (int i = 0; i < aLBiensTransférés.Count; i++) 
            {
                listIdBienTransférés += ((String[])aLBiensTransférés[i])[0] + ",";
            }
            listIdBienTransférés = listIdBienTransférés.Substring(0, listIdBienTransférés.Length - 2) + ");";
            return listIdBienTransférés;
        }

        private void tVEmplacements_AfterSelect(object sender, TreeViewEventArgs e)
        {            
            AfficherBienSource((TreeNode)e.Node);
        }

        private void AfficherBienSource(TreeNode NoeudSélectionné) 
        {
            dGVBiensSource.Rows.Clear();
            try
            {
                desigEmplaSource = NoeudSélectionné.Text;
                String id = NoeudSélectionné.Name;
                String[] tabId = id.Split(new char[] { '_' });                
                idEmplaSource = tabId[1];

                string requete_empl="select idEmplaComplet from Emplacement where IdEmpla="+idEmplaSource;
                DataSet dataTableidEmplaCmplet = MaConnexion.ExecuteSelect(connectionString, requete_empl);
                DataRow dRidEmplaCmplet = dataTableidEmplaCmplet.Tables[0].Rows[0];
                idEmplaCmpletsource = dRidEmplaCmplet[0].ToString();

                requete = "select Bien.idBien, ancienCode, Bien.DesigBien, CategorieBien.DesigCategorieBien,Bien.DateAcquisitionBien,Etat.DesigEtat, Bien.Prix, Bien.Particularite from seTrouveB, Bien, Etat,CategorieBien where CategorieBien.IdCategorieBien=Bien.IdCategorieBien and Etat.IdEtat=seTrouveB.IdEtat and seTrouveB.idBien=Bien.idBien  and uidInventaire = '"+idinventaire+"' and etat = 'Non supprimé' and seTrouveB.IdEmpla = '" + idEmplaCmpletsource + "' and idSite = " + idSiteSource;
                
                dS = MaConnexion.ExecuteSelect(connectionString, requete);
                foreach (DataRow row in dS.Tables[0].Rows)
                {                    
                    object[] ligneBienSource = new object[] { null, row[0].ToString(), row[1].ToString(), row[2].ToString(), row[3].ToString(), row[4].ToString(), row[5].ToString(), row[6].ToString(), row[7].ToString() };
                    dGVBiensSource.Rows.Add(ligneBienSource);
                }
            }
            catch (Exception ex) 
            {                
                MessageBox.Show("huhuhuh"+ex.ToString());
            }
        }

        private void dGVBiensSource_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex == -1 || e.RowIndex == -1)
                return;

            if (dGVBiensSource.Columns[e.ColumnIndex].Name == "ColumnTransferer")
            {
                if (e.RowIndex != dGVBiensSource.RowCount - 1)
                {
                    e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                    int intTop = (e.CellBounds.Height - 18) / 2 + e.CellBounds.Top;
                    int intLeft = (e.CellBounds.Width - 18) / 2 + e.CellBounds.Left;
                    try
                    {
                        e.Graphics.DrawImage(System.Drawing.Image.FromFile("ceder.JPG"), intLeft, intTop);
                    }
                    catch (Exception)
                    { }
                    e.Handled = true;
                }
            }
        }

        private void dGVBiensSource_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            if (dGVBiensSource.Columns[e.ColumnIndex].Name == "ColumnTransferer") //click sur le bouton de modification ou d'ajout
            {
                if (e.RowIndex != dGVBiensSource.RowCount - 1) 
                {
                    if (!bienDéjàTransféré(dGVBiensSource.Rows[e.RowIndex].Cells["ColumnIdBien"].Value.ToString()))
                    {
                        if (!idEmplaSource.Equals(idEmplaCmpletdestination))
                        {
                            if (MessageBox.Show("Voulez vous vraiment transférer '" + dGVBiensSource.Rows[e.RowIndex].Cells["ColumnDésignation"].Value + "' de '" + desigEmplaSource + "' vers '" + desigEmplaDestination + "'", "transfert d'un bien", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                            {
                                ligneBienTransféré = new string[] { dGVBiensSource.Rows[e.RowIndex].Cells[1].Value.ToString(), 
                                                        dGVBiensSource.Rows[e.RowIndex].Cells[2].Value.ToString(), 
                                                        dGVBiensSource.Rows[e.RowIndex].Cells[3].Value.ToString(), 
                                                        dGVBiensSource.Rows[e.RowIndex].Cells[4].Value.ToString(), 
                                                        dGVBiensSource.Rows[e.RowIndex].Cells[5].Value.ToString(), 
                                                        dGVBiensSource.Rows[e.RowIndex].Cells[6].Value.ToString(), 
                                                        dGVBiensSource.Rows[e.RowIndex].Cells[7].Value.ToString(), 
                                                        dGVBiensSource.Rows[e.RowIndex].Cells[8].Value.ToString(), 
                                                        idEmplaCmpletsource, idEmplaCmpletdestination, desigEmplaSource};
                                aLBiensTransférés.Add(ligneBienTransféré);
                                rafraichirBiensTransférés();
                            }
                        }
                        else 
                        {
                            MessageBox.Show("Vous ne pouvez pas transferer un bien d'un emplacement vers lui même. Sélectionnez un autre emplacement destination ", "Transfert impossible", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                    }
                }
            }
            
        }

        private void tVEmplacementDestination_AfterSelect(object sender, TreeViewEventArgs e)
        {
            AfficherBienDestination((TreeNode)e.Node);
        }

        private void AfficherBienDestination(TreeNode NoeudSélectionné) 
        {
            dGVBiensDestination.Rows.Clear(); desigEmplaDestination = NoeudSélectionné.Text;
            String id = NoeudSélectionné.Name;
            String[] tabId = id.Split(new char[] { '_' });
            idEmplaDestination = tabId[1];


            string requete_empl = "select idEmplaComplet from Emplacement where IdEmpla=" + idEmplaDestination;
            DataSet dataTableidEmplaCmplet = MaConnexion.ExecuteSelect(connectionString, requete_empl);
            DataRow dRidEmplaCmplet = dataTableidEmplaCmplet.Tables[0].Rows[0];
            idEmplaCmpletdestination = dRidEmplaCmplet[0].ToString();


            if (rBEmplacementSélectionné.Checked)
            {
                try
                {                    
                    for (int i = 0; i < aLBiensTransférés.Count; i++)
                    {
                        if (((String[])aLBiensTransférés[i])[9].Equals(idEmplaCmpletdestination))
                        {
                            object[] ligneBienDestination = new object[] { null, ((String[])aLBiensTransférés[i])[0], 
                                                                             ((String[])aLBiensTransférés[i])[1],
                                                                             ((String[])aLBiensTransférés[i])[2],
                                                                             ((String[])aLBiensTransférés[i])[3],
                                                                             ((String[])aLBiensTransférés[i])[4],
                                                                             ((String[])aLBiensTransférés[i])[5],
                                                                             ((String[])aLBiensTransférés[i])[6],
                                                                             ((String[])aLBiensTransférés[i])[7],
                                                                             ((String[])aLBiensTransférés[i])[10]};
                            dGVBiensDestination.Rows.Add(ligneBienDestination);
                        }
                    }

                }
                catch (Exception) { }
            }
            else
                if (rBTousLesEmplacements.Checked)
                {
                    for (int i = 0; i < aLBiensTransférés.Count; i++)
                    {
                        object[] ligneBienDestination = new object[] { null, ((String[])aLBiensTransférés[i])[0], 
                                                                                 ((String[])aLBiensTransférés[i])[1],
                                                                                 ((String[])aLBiensTransférés[i])[2],
                                                                                 ((String[])aLBiensTransférés[i])[3],
                                                                                 ((String[])aLBiensTransférés[i])[4],
                                                                                 ((String[])aLBiensTransférés[i])[5],
                                                                                 ((String[])aLBiensTransférés[i])[6],
                                                                                 ((String[])aLBiensTransférés[i])[7],
                                                                                 ((String[])aLBiensTransférés[i])[10]};
                        dGVBiensDestination.Rows.Add(ligneBienDestination);
                    }

                }
        }

        private bool bienDéjàTransféré(string idBien) 
        {
            for (int i = 0; i < aLBiensTransférés.Count; i++) 
            {
                if (((String[])aLBiensTransférés[i])[0].Equals(idBien)) 
                {
                    MessageBox.Show("Vous avez déjà transféré ce bien", "Bien transféré", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
            }
            return false;
        }

        private void dGVBiensDestination_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex == -1 || e.RowIndex == -1)
                return;

            if (dGVBiensDestination.Columns[e.ColumnIndex].Name == "ColumnAnnulerTransfert")
            {
                if (e.RowIndex != dGVBiensDestination.RowCount - 1)
                {
                    e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                    int intTop = (e.CellBounds.Height - 18) / 2 + e.CellBounds.Top;
                    int intLeft = (e.CellBounds.Width - 18) / 2 + e.CellBounds.Left;
                    try
                    {
                        e.Graphics.DrawImage(System.Drawing.Image.FromFile("annuler céder.JPG"), intLeft, intTop);
                    }
                    catch (Exception)
                    { }
                    e.Handled = true;
                }
            }
        }

        private void dGVBiensDestination_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            //click sur le bouton de suppression
            if (dGVBiensDestination.Columns[e.ColumnIndex].Name == "ColumnAnnulerTransfert")
            {
                if (e.RowIndex != dGVBiensDestination.RowCount - 1) //bouton de suppression
                {
                    if (MessageBox.Show("Voulez vous vraiment annuler le transfert du bien '" + dGVBiensDestination.Rows[e.RowIndex].Cells["ColumnDesigBienTransféré"].Value + "' de '" + dGVBiensDestination.Rows[e.RowIndex].Cells["ColumnEmplacementSource"].Value + "' vers '" + desigEmplaDestination + "'", "Annulation de transfert d'un bien", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                    {
                        bool trouve = false;
                        for (int i = 0; i < aLBiensTransférés.Count && !trouve; i++) 
                        {
                            if (((String[])aLBiensTransférés[i])[0].Equals(dGVBiensDestination.Rows[e.RowIndex].Cells["ColumnIdBienTransféré"].Value)) 
                            {
                                aLBiensTransférés.RemoveAt(i);
                                rafraichirBiensTransférés();
                            }
                        }
                    }

                }
            }
        }

        private void rafraichirBiensTransférés() 
        {
            //resélectionner le noeud sélectionné pour réafficher les biens transférés de ce noeud
            TreeNode sauvNoeudSélectionné = tVEmplacementDestination.SelectedNode;
            tVEmplacementDestination.SelectedNode = null;
            tVEmplacementDestination.SelectedNode = sauvNoeudSélectionné;
        }

        private void rBEmplacementSélectionné_CheckedChanged(object sender, EventArgs e)
        {
            AfficherBienDestination(tVEmplacementDestination.SelectedNode);
        }

        private void rBTousLesEmplacements_CheckedChanged(object sender, EventArgs e)
        {
            AfficherBienDestination(tVEmplacementDestination.SelectedNode);
        }

        private void réinitialiserAfichageBien() 
        {
            try
            {
                TreeNode sauvNoeudSource = tVEmplacements.SelectedNode;
                tVEmplacements.SelectedNode = null;
                tVEmplacements.SelectedNode = sauvNoeudSource;

                TreeNode sauvNoeudDestination = tVEmplacementDestination.SelectedNode;
                tVEmplacementDestination.SelectedNode = null;
                tVEmplacementDestination.SelectedNode = sauvNoeudDestination;
            }
            catch (Exception) { }

        }

        private void bAnnuler_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez vous enregistrer le bon de transfert ? ", "Transfert d'un bien", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                enregistrerBonTransfert();
            this.Close();
        }

    }
}
