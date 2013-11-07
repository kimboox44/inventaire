using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace solution1
{
    public partial class MAJCession : Form
    {
        string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["connectString1"].ConnectionString;
        string requete = null;
        DataSet dS = null;
        int idPVCession ;
        string idClient = "";
        string inventaire = "";

        public MAJCession(string idinventaire)
        {
            inventaire = idinventaire;

            requete = "select max(idpvcession) from PVCession";
            dS = MaConnexion.ExecuteSelect(connectionString, requete);
            string idce = dS.Tables[0].Rows[0][0].ToString();
            
            if (idce.Trim() == "")
            {
                idPVCession = 0;
            }
            else {
                idPVCession = int.Parse(idce.ToString());
            }
 



            //this.idPVCession = idPVCession;
            InitializeComponent();

        }

        private void MAJCession_Load(object sender, EventArgs e)
        {
            int id_pvcession=idPVCession;

            /*requete = "select max(idpvcession) from PVCession";
            dS = MaConnexion.ExecuteSelect(connectionString, requete);
            string id_pvcession_str = dS.Tables[0].Rows[0][0].ToString();
      
            id_pvcession = int.Parse(id_pvcession_str.ToString());*/
            


            id_pvcession++;
            tBIdPVCession.Text = id_pvcession.ToString();

            //chargerPV();
            chargerClients();
            chargerBiens();
            //chargerBiensCédés();
            sélectionnerClient();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chargerBiens() 
        {           
            if (rBTousBien.Checked)
            {
                requete = "select Bien.idBien, ancienCode, Bien.DesigBien, CategorieBien.DesigCategorieBien,Bien.DateAcquisitionBien,Etat.DesigEtat, Bien.Prix, Bien.Particularite from seTrouveB, Bien, Etat,CategorieBien where CategorieBien.IdCategorieBien=Bien.IdCategorieBien and Etat.IdEtat=seTrouveB.IdEtat and seTrouveB.idBien=Bien.idBien  and uidInventaire = '"+inventaire+"' and etat = 'Non supprimé';";
            }
            else
            {
                if (rBIdBien.Checked)
                {
                    requete = "select Bien.idBien, ancienCode, Bien.DesigBien, CategorieBien.DesigCategorieBien,Bien.DateAcquisitionBien,Etat.DesigEtat, Bien.Prix, Bien.Particularite from seTrouveB, Bien, Etat,CategorieBien where CategorieBien.IdCategorieBien=Bien.IdCategorieBien and Etat.IdEtat=seTrouveB.IdEtat and seTrouveB.idBien=Bien.idBien  and uidInventaire = '"+inventaire+"' and etat = 'Non supprimé' and Bien.idBien LIKE '" + tBIdBien.Text + "%'";                    
                }
                else
                {
                    if (rBAncienCode.Checked)
                    {
                        requete = "select Bien.idBien, ancienCode, Bien.DesigBien, CategorieBien.DesigCategorieBien,Bien.DateAcquisitionBien,Etat.DesigEtat, Bien.Prix, Bien.Particularite from seTrouveB, Bien, Etat,CategorieBien where CategorieBien.IdCategorieBien=Bien.IdCategorieBien and Etat.IdEtat=seTrouveB.IdEtat and seTrouveB.idBien=Bien.idBien  and uidInventaire = '"+inventaire+"' and etat = 'Non supprimé' and ancienCode LIKE '" + tBAncienCode.Text + "%'";
                        
                    }
                    else 
                    {
                        if (rBDésignation.Checked) 
                        {
                            requete = "select Bien.idBien, ancienCode, Bien.DesigBien, CategorieBien.DesigCategorieBien,Bien.DateAcquisitionBien,Etat.DesigEtat, Bien.Prix, Bien.Particularite from seTrouveB, Bien, Etat,CategorieBien where CategorieBien.IdCategorieBien=Bien.IdCategorieBien and Etat.IdEtat=seTrouveB.IdEtat and seTrouveB.idBien=Bien.idBien  and uidInventaire = '"+inventaire+"' and etat = 'Non supprimé' and DesigBien LIKE '" + tBDésignation.Text + "%'";
                            
                        }
                    }
                }
            }

            dGVBiens.Rows.Clear();
            dS = MaConnexion.ExecuteSelect(connectionString, requete);
            try
            {
                foreach (DataRow row in dS.Tables[0].Rows)
                {
                    object[] ligneBien = new object[] { null, row[0].ToString(), row[1].ToString(), row[2].ToString(), row[3].ToString(), row[4].ToString(), row[5].ToString(), row[6].ToString(), row[7].ToString() };
                    dGVBiens.Rows.Add(ligneBien);

                }
            }
            catch (Exception) 
            {}

        }

        private void chargerPV()
        {
            try
            {
                requete = "select * from PVCession where idPVCession = " + idPVCession;
                dS = MaConnexion.ExecuteSelect(connectionString, requete);
                tBIdPVCession.Text = dS.Tables[0].Rows[0][0].ToString();
                int jour = Int32.Parse(dS.Tables[0].Rows[0][1].ToString().Substring(0, 2));
                int mois = Int32.Parse(dS.Tables[0].Rows[0][1].ToString().Substring(3, 2));
                int année = Int32.Parse(dS.Tables[0].Rows[0][1].ToString().Substring(6, 4));
                DateTime date = new DateTime(année, mois, jour);
                dTPDateCession.Text = date.ToString();
                this.Text += dS.Tables[0].Rows[0][1].ToString().Substring(0,8);
                tBNumFacture.Text = dS.Tables[0].Rows[0][3].ToString();
                idClient = dS.Tables[0].Rows[0][4].ToString();
            }
            catch (Exception) 
            {
                {
                    MessageBox.Show("Erreur de chargement des information du PV ", "Echec de chargement des valeurs", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void chargerClients()
        {
            if (rBTousClient.Checked)
            {
                requete = "select * from client where etat = 'Non supprimé'";
            }
            else
            {
                if (rBIdentifiant.Checked)
                {
                    requete = "select * from client where etat = 'Non supprimé' and idClient = " + tBIdentifiantClient.Text;                    
                }
                else
                {
                    if (rBRaisonSociale.Checked)
                    {
                        requete = "select * from client where etat = 'Non supprimé' and nom like '" + tBRaisonSociale.Text + "%';";                        
                    }
                }
            }

            dGVClients.Rows.Clear();
            dS = MaConnexion.ExecuteSelect(connectionString, requete);
            try
            {
                foreach (DataRow row in dS.Tables[0].Rows)
                {
                    object[] ligneClient = new object[] { row[0].ToString(), row[1].ToString(), row[2].ToString() };
                    dGVClients.Rows.Add(ligneClient);

                }
            }
            catch (Exception) 
            {}

        }

        private void chargerBiensCédés() 
        {            
            try
            {
                requete = "select Bien.idBien, ancienCode, Bien.DesigBien, CategorieBien.DesigCategorieBien,Bien.DateAcquisitionBien,Etat.DesigEtat, Bien.Prix, prixCession,Bien.Particularite from seTrouveB, Bien, Etat,CategorieBien,Ceder where CategorieBien.IdCategorieBien=Bien.IdCategorieBien and Etat.IdEtat=seTrouveB.IdEtat and seTrouveB.idBien=Bien.idBien  and Bien.IdBien = ceder.IdBien  and uidInventaire = '00000000-0000-0000-0000-000000000000' and etat = 'Cédé' and idPVCession = " + idPVCession;                                
                dS = MaConnexion.ExecuteSelect(connectionString, requete);
                foreach (DataRow row in dS.Tables[0].Rows)
                {
                    object[] ligneBienCédé = new object[] { row[0].ToString(), row[1].ToString(), row[2].ToString(), row[3].ToString(), row[4].ToString().Substring(0,8), row[5].ToString(), row[6].ToString(), row[7].ToString(), row[8].ToString() };                    
                    dGVBienCédé.Rows.Add(ligneBienCédé);
                }
            }
            catch (Exception) 
            {
                MessageBox.Show("Erreur de chargement des biens cédés", "Erreur de chargement des valeurs", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            
        }

        private void rBTous_CheckedChanged(object sender, EventArgs e)
        {
            if (rBTousClient.Checked)
                chargerClients();
        }

        private void rBIdentifiant_CheckedChanged(object sender, EventArgs e)
        {
            if (rBIdentifiant.Checked)
                chargerClients();
        }

        private void rBRaisonSociale_CheckedChanged(object sender, EventArgs e)
        {
            if (rBRaisonSociale.Checked)
                chargerClients();
        }

        private void tBIdentifiant_TextChanged(object sender, EventArgs e)
        {
            rBIdentifiant.Checked = true;
            chargerClients();
        }

        private void tBRaisonSociale_TextChanged(object sender, EventArgs e)
        {
            rBRaisonSociale.Checked = true;
            chargerClients();
        }

        private void rBTousBien_CheckedChanged(object sender, EventArgs e)
        {
            if (rBTousBien.Checked)
                chargerBiens();
        }

        private void rBIdBien_CheckedChanged(object sender, EventArgs e)
        {
            if (rBIdBien.Checked)
                chargerBiens();
        }

        private void rBAncienCode_CheckedChanged(object sender, EventArgs e)
        {
            if (rBAncienCode.Checked)
                chargerBiens();
        }

        private void rBDésignation_CheckedChanged(object sender, EventArgs e)
        {
            if (rBDésignation.Checked)
                chargerBiens();
        }

        private void tBIdBien_TextChanged(object sender, EventArgs e)
        {
            rBIdBien.Checked = true;
            chargerBiens();
        }

        private void tBAncienCode_TextChanged(object sender, EventArgs e)
        {
            rBAncienCode.Checked = true;
            chargerBiens();
        }

        private void tBDésignation_TextChanged(object sender, EventArgs e)
        {
            rBDésignation.Checked = true;
            chargerBiens();
        }

        private void dGVBiens_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex == -1 || e.RowIndex == -1)
                return;

            if (dGVBiens.Columns[e.ColumnIndex].Name == "ColumnCeder")
            {
                if (e.RowIndex != dGVBiens.RowCount - 1)
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

        private void dGVBiens_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            //click sur le bouton de cession
            if (dGVBiens.Columns[e.ColumnIndex].Name == "ColumnCeder")
            {
                if (e.RowIndex != dGVBiens.RowCount - 1) //bouton de cession
                {
                    if (dGVClients.SelectedRows.Count == 1)
                    {
                        if (MessageBox.Show("Voulez vous vraiment Ceder le bien '" + dGVBiens.Rows[e.RowIndex].Cells["ColumnDésignation"].Value + "' à " + dGVClients.SelectedRows[0].Cells["ColumnNom"].Value + " ?", "Ceder un bien", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            object[] ligneBienCédé = new object[] {   dGVBiens.Rows[e.RowIndex].Cells[1].Value, 
                                                                      dGVBiens.Rows[e.RowIndex].Cells[2].Value, 
                                                                      dGVBiens.Rows[e.RowIndex].Cells[3].Value, 
                                                                      dGVBiens.Rows[e.RowIndex].Cells[4].Value, 
                                                                      dGVBiens.Rows[e.RowIndex].Cells[5].Value, 
                                                                      dGVBiens.Rows[e.RowIndex].Cells[6].Value, 
                                                                      dGVBiens.Rows[e.RowIndex].Cells[7].Value, 
                                                                      "0",
                                                                      dGVBiens.Rows[e.RowIndex].Cells[8].Value };

                            dGVBienCédé.Rows.Add(ligneBienCédé);

                        }
                    }
                    else 
                    {
                        MessageBox.Show("Sélectionnez d'abord un client auquel seront cédés les biens", "Sélection d'un client obligatoire", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void dGVClients_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex == -1 || e.RowIndex == -1)
                return;

            if (dGVClients.Columns[e.ColumnIndex].Name == "ColumnSupprimer")
            {
                if (e.RowIndex != dGVClients.RowCount - 1)
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
            } 
            else
                if (dGVClients.Columns[e.ColumnIndex].Name == "ColumnModifier") 
                {
                    if (e.RowIndex != dGVClients.RowCount - 1)
                    {
                        e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                        int intTop = (e.CellBounds.Height - 16) / 2 + e.CellBounds.Top;
                        int intLeft = (e.CellBounds.Width - 10) / 2 + e.CellBounds.Left;
                        try
                        {
                            e.Graphics.DrawImage(System.Drawing.Image.FromFile("modifier.gif"), intLeft, intTop);
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

        private void dGVClients_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            //click sur le bouton de suppression
            if (dGVClients.Columns[e.ColumnIndex].Name == "ColumnSupprimer")
            {
                if (e.RowIndex != dGVClients.RowCount - 1) //bouton de suppression
                {
                    if (MessageBox.Show("Voulez vous vraiment supprimer ce client ?", "Supprimer un client", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                    {
                        requete = "update client set etat = 'Supprimé' where idClient =" + dGVClients.Rows[e.RowIndex].Cells["ColumnIdClient"].Value;                        

                        if (MaConnexion.ExecuteUpdate(connectionString, requete) == 1)
                        {
                            chargerClients();
                        }
                        else
                            MessageBox.Show("La suppression a échoué", "Erreur de suppression", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
            else
                if (dGVClients.Columns[e.ColumnIndex].Name == "ColumnModifier") //click sur le bouton de modification ou d'ajout
                {
                    if (e.RowIndex != dGVClients.RowCount - 1) //click sur le bouton de modification
                    {
                        (new ModifierClient(dGVClients.Rows[e.RowIndex].Cells["ColumnIdClient"].Value.ToString())).ShowDialog();
                    }
                    else //click sur le bouton d'ajout
                    {
                        (new AjouterClient()).ShowDialog();
                    }
                    chargerClients();
                }        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //enregistrer le numéro de facture du PV de cession en cours 
            if (tBNumFacture.Text != "") 
            {
                if(id_client.Text!="")
                {
                    requete = "INSERT INTO PVCession (numfacture,idClient,DateCession,etat) VALUES ( '" + tBNumFacture.Text + "'," + int.Parse(id_client.Text.ToString())+",'"+ DateTime.Now.ToString("dd-MM-yyyy")+"','Non supprimé')";
                    
                    if (MaConnexion.ExecuteUpdate(connectionString, requete) != 1)
                    {
                        MessageBox.Show("Echec d'enregistrement du numéro de facture du PV", "Erreur d'enregistrement", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                 /*   else 
                    {
                        this.Close();
                    }
                    */




                    int nbrow = dGVBienCédé.Rows.Count;
                    //MessageBox.Show("le nombre de ligen est de : " + nbrow);

                    nbrow = nbrow - 1;
                    for (int i = 0; i < nbrow ; i++)
                    {
                        string id_bien = dGVBienCédé.Rows[i].Cells[0].Value.ToString();
                        requete = "INSERT INTO Ceder (IdBien,idPVCession) VALUES ('" +id_bien + "' , " + int.Parse(tBIdPVCession.Text.ToString()) + ")";
                        //MessageBox.Show("la requete :" + requete);
                        int attribution = MaConnexion.ExecuteUpdate(connectionString, requete);
                       
                        if (attribution == 1)
                        {
                            string req_mod= "update bien set etat='Supprimé' where IdBien='"+id_bien.ToString()+"'";
                            int modif = MaConnexion.ExecuteUpdate(connectionString, req_mod);
                           // MessageBox.Show(" Ajout droit réussi ");
                        }

                    }




                }else
                {
                    MessageBox.Show("Veuillez choisir un client SVP");
                }
            }
            else
            {
                // ajouter le id client dans pvcession 
                MessageBox.Show("Le champ facture doit etre rempli");
            }           
        }

        private void sélectionnerClient()
        {
            try
            {
                for (int i = 0; i < dGVClients.Rows.Count - 1; i++)
                {
                    if (dGVClients.Rows[i].Cells[0].Value.ToString().Equals(idClient))
                    {
                        dGVClients.Rows[i].Selected = true;
                    }
                }
            }
            catch (Exception) 
            {}
        }

        private void dGVBienCédé_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try 
            {
                decimal prixCession = long.Parse(dGVBienCédé.Rows[e.RowIndex].Cells["ColumnPrixCession"].Value.ToString());
                requete = "update ceder set prixCession = " + prixCession + "where idPVCession = " + idPVCession + " and idBien = '" + dGVBienCédé.Rows[e.RowIndex].Cells["ColumnIdBienCédé"].Value + "';";
                
                if (MaConnexion.ExecuteUpdate(connectionString, requete) != 1) 
                {
                    MessageBox.Show("Echec de mise à jour du prix de cession", "Erreur de mise à jour", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            } catch (Exception) 
            {
                MessageBox.Show("Le prix de cession du bien doit être un decimal.", "Erreur de saisie", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            
        }

        private void dGVClients_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            id_client.Text = dGVClients.SelectedRows[0].Cells["ColumnIdClient"].Value.ToString();
            nom_client.Text = dGVClients.SelectedRows[0].Cells["Columnnom"].Value.ToString();
        }



    }
}
