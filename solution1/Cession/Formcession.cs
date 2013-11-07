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
    public partial class Formcession : Form
    {
        string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["connectString1"].ConnectionString;
        string requete = null;
        DataSet dS = null;
        string dateDebut = null;
        string dateFin = null;
        string idinventaire = "";

        public Formcession(string uidinventaire)
        {
            InitializeComponent();
            this.idinventaire = uidinventaire;
        }

        private void Formcession_Load(object sender, EventArgs e)
        {   
            chargercession();
            this.WindowState = FormWindowState.Maximized;
        }

        private void chargercession() 
        {
            if (rBTous.Checked)
            {
                requete = "create view VueCession as select idPVCession,DateCession,pvcession.etat,numfacture, nom,adresse   from PVCession, Client where pvcession.idClient=Client.idClient and pvcession.etat = 'Non supprimé'";                
            }
            else
            {
                if (rBNumBonTransfert.Checked)
                {
                    requete = "create view maVue as select idBonTransfert, dateTransfert, motifTransfert, IdSiteSource, idSiteDestination, NomSite as NomSiteSource, etatBonTransfert  from BonTransfert, Site where BonTransfert.idSiteSource = Site.idSite and etatBonTransfert = 'Non supprimé' and idBonTransfert = " + tBIdBonTransfert.Text;                    
                }
                else
                {
                    if (rBDate.Checked)
                    {
                        dateDebut = this.dTPDebut.Value.ToString("MM/dd/yyyy");
                        dateFin = this.dTPFin.Value.ToString("MM/dd/yyyy");
                        requete = "create view maVue as select idBonTransfert, dateTransfert, motifTransfert, IdSiteSource, idSiteDestination, NomSite as NomSiteSource, etatBonTransfert  from BonTransfert, Site where BonTransfert.idSiteSource = Site.idSite and etatBonTransfert = 'Non supprimé' and dateTransfert > '" + dateDebut + "' and dateTransfert < '" + dateFin + "'";
                    }
                }
            }
            
            dGVcession.Rows.Clear();
            MaConnexion.ExecuteUpdate(connectionString, requete);
            try
            {
                requete = "select * from Vuecession;";
                
                dS = MaConnexion.ExecuteSelect(connectionString, requete);
                foreach (DataRow row in dS.Tables[0].Rows)
                {

                    object[] lignePVCession = new object[] { row[0].ToString(), row[1].ToString(),  row[3].ToString(), row[4].ToString(), row[5].ToString(),  null,null,null };
                    dGVcession.Rows.Add(lignePVCession);
                }
            }
            catch (Exception) { }
            finally 
            {
                requete = "drop view maVue ";
                dS = MaConnexion.ExecuteSelect(connectionString, requete); //suppression de la vue intermédiaire
            }
        }

        private void tBIdBonTransfert_TextChanged(object sender, EventArgs e)
        {
            rBNumBonTransfert.Checked = true;
            chargercession();
        }

        private void dTPDebut_ValueChanged(object sender, EventArgs e)
        {
            rBDate.Checked = true;
            chargercession();
        }

        private void dTPFin_ValueChanged(object sender, EventArgs e)
        {
            rBDate.Checked = true;
            chargercession();
        }

        private void rBNumBonTransfert_CheckedChanged(object sender, EventArgs e)
        {
            if (rBNumBonTransfert.Checked)
                chargercession();
        }

        private void rBTous_CheckedChanged(object sender, EventArgs e)
        {
            if (rBTous.Checked)
                chargercession();
        }

        private void rBDate_CheckedChanged(object sender, EventArgs e)
        {
            if (rBDate.Checked)
                chargercession();
        }

        private void dGVBonDeTransfert_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex == -1 || e.RowIndex == -1)
                return;

            if (dGVcession.Columns[e.ColumnIndex].Name == "ColumnImprimer")
            {
                if (e.RowIndex != dGVcession.RowCount - 1)
                {
                    e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                    int intTop = (e.CellBounds.Height - 16) / 2 + e.CellBounds.Top;
                    int intLeft = (e.CellBounds.Width - 16) / 2 + e.CellBounds.Left;
                    try
                    {
                        e.Graphics.DrawImage(System.Drawing.Image.FromFile("imprimer.jpeg"), intLeft, intTop);
                    }
                    catch (Exception)
                    { }
                    e.Handled = true;
                }
            }
            else
                if (dGVcession.Columns[e.ColumnIndex].Name == "ColumnSupprimer")
                {
                    if (e.RowIndex != dGVcession.RowCount - 1)
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
                } else
                    if (dGVcession.Columns[e.ColumnIndex].Name == "ColumnModifier")
                    {
                        if (e.RowIndex != dGVcession.RowCount - 1)
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

        private void dGVBonDeTransfert_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            //click sur le bouton de suppression
            if (dGVcession.Columns[e.ColumnIndex].Name == "ColumnImprimer")
            {
                if (e.RowIndex != dGVcession.RowCount - 1) //bouton de suppression
                {
                    try
                    {
                     //   (new FormCRBonTransfert(dGVcession.Rows[e.RowIndex].Cells["ColumnIdBonTransfert"].Value.ToString())).ShowDialog();
                    }
                    catch (Exception) { }                    
                }
            }
            else
                if (dGVcession.Columns[e.ColumnIndex].Name == "ColumnModifier") //click sur le bouton de modification ou d'ajout
                {
                    if (e.RowIndex != dGVcession.RowCount - 1) //click sur le bouton de modification
                    {                        
                        //(new ModifierBonTransfert(dGVcession.Rows[e.RowIndex].Cells["ColumnIdBonTransfert"].Value.ToString())).ShowDialog();
                    }
                    else //click sur le bouton d'ajout
                    {  

                        //(new AjouterBonDeTransfert()).ShowDialog();                        
                    }

                    //Ce que j'ai fait ici, c'est du bricolage : à réctifier
                    this.Visible = false;
                    (new Formcession(idinventaire)).Show();
                    
                }
                else
                    if (dGVcession.Columns[e.ColumnIndex].Name == "ColumnSupprimer") //click sur le bouton de suppression
                    {
                        if (MessageBox.Show("Voulez vous vraiment supprimer ce PVCession  ?", "Supprimer un PVCession", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                        {
                            requete = "update PVCession set etat = 'Supprimé' where idPVCession = " + dGVcession.Rows[e.RowIndex].Cells["ColumnIdBonTransfert"].Value.ToString();
                            if (MaConnexion.ExecuteUpdate(connectionString, requete) != 1)
                            {
                                MessageBox.Show("Echec de suppression du PvCession", "Erreur de suppression", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                            else 
                            {
                                //dGVBonDeTransfert.Rows.RemoveAt(e.RowIndex);
                                dGVcession.Rows.Remove(dGVcession.Rows[e.RowIndex]);
                            }
 
                        }
                        //chargercession();
                    }
        }

        private void dGVBonDeTransfert_SelectionChanged(object sender, EventArgs e)
        {
            chargerBiensVendus();            
        }

        private void chargerBiensVendus() 
        {
            dGVBiens.Rows.Clear();
            try
            {
                requete = "create view vuecedebien as select Bien.idBien, Bien.ancienCode, Bien.DesigBien, CategorieBien.DesigCategorieBien, Bien.DateAcquisitionBien, Bien.Prix, Bien.Particularite,ceder.prixCession from  bien,ceder,CategorieBien,SeTrouveB,Etat where Bien.IdBien = Ceder.idBien and CategorieBien.IdCategorieBien = Bien.IdCategorieBien and seTrouveB.IdBien = Bien.idBien and seTrouveB.IdEtat = Etat.idEtat and SeTrouveB.uidInventaire = '"+idinventaire+"' and ceder.idPVCession=" + dGVcession.Rows[dGVcession.CurrentCell.RowIndex].Cells["ColumnIdBonTransfert"].Value;
                Console.WriteLine(requete);
               int i= MaConnexion.ExecuteUpdate(connectionString, requete);

                requete = "select * from vuecedebien";
                Console.WriteLine(requete);

                dS = MaConnexion.ExecuteSelect(connectionString, requete);
                foreach (DataRow row in dS.Tables[0].Rows)
                {
                    object[] ligneBienTransféré = new object[] { row[0].ToString(), row[1].ToString(), row[2].ToString(), row[3].ToString(), row[4].ToString().Substring(0, 8), row[5].ToString(), row[6].ToString(), row[7].ToString() };
                    dGVBiens.Rows.Add(ligneBienTransféré);

                    /*
                    if (row[10].ToString().Equals("True"))
                        dGVBiens.Rows[dGVBiens.Rows.Count - 2].DefaultCellStyle.BackColor = Color.Green;
                    else
                        dGVBiens.Rows[dGVBiens.Rows.Count - 2].DefaultCellStyle.BackColor = Color.Red;
                     */
                }
                requete = "drop view vuecedebien";
                MaConnexion.ExecuteUpdate(connectionString, requete);                
            }
            catch (Exception) { }
        }

        private void buttonQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dGVcession_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
