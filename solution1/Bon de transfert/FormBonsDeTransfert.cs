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
    public partial class FormBonsDeTransfert : Form
    {
        string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["connectString1"].ConnectionString;
        string requete = null;
        DataSet dS = null;
        string dateDebut = null;
        string dateFin = null;
        string idinventaire;

        public FormBonsDeTransfert(string uidInventaire)
        {
            this.idinventaire = uidInventaire;

            InitializeComponent();
        }

        private void FormBonsDeTransfert_Load(object sender, EventArgs e)
        {
            chargerBonsDeTransfert();
            this.WindowState = FormWindowState.Maximized;
        }

        private void chargerBonsDeTransfert() 
        {
            if (rBTous.Checked)
            {
                requete = "create view maVue as select idBonTransfert, dateTransfert, motifTransfert, IdSiteSource, idSiteDestination, NomSite as NomSiteSource, etatBonTransfert  from BonTransfert, Site where BonTransfert.idSiteSource = Site.idSite and etatBonTransfert = 'Non supprimé'";                
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
                        dateDebut = this.dTPDebut.Value.ToString("dd/MM/yyyy");
                        dateFin = this.dTPFin.Value.ToString("dd/MM/yyyy");
                        requete = "create view maVue as select idBonTransfert, dateTransfert, motifTransfert, IdSiteSource, idSiteDestination, NomSite as NomSiteSource, etatBonTransfert  from BonTransfert, Site where BonTransfert.idSiteSource = Site.idSite and etatBonTransfert = 'Non supprimé' and dateTransfert > '" + dateDebut + "' and dateTransfert < '" + dateFin + "'";
                    }
                }
            }
            
            dGVBonDeTransfert.Rows.Clear();
            MaConnexion.ExecuteUpdate(connectionString, requete);
            try
            {
                requete = "select maVue.idBonTransfert, maVue.dateTransfert, maVue.motifTransfert, maVue.NomSiteSource, NomSite as NomSiteDestination from maVue, site where maVue.idSiteDestination = Site.idSite;";
                
                dS = MaConnexion.ExecuteSelect(connectionString, requete);
                foreach (DataRow row in dS.Tables[0].Rows)
                {
                    int jour = Int32.Parse(row[1].ToString().Substring(0, 2));
                    int mois = Int32.Parse(row[1].ToString().Substring(3, 2));
                    int année = Int32.Parse(row[1].ToString().Substring(6, 4));
                    DateTime date = new DateTime(année, mois, jour);
                    object[] lignePVCession = new object[] { row[0].ToString(), date, row[2].ToString(), row[3].ToString(), row[4].ToString(), null, null, null };
                    dGVBonDeTransfert.Rows.Add(lignePVCession);
                }
            }
            catch (Exception) { }
            finally 
            {
                requete = "drop view maVue ";
                dS = MaConnexion.ExecuteSelect(connectionString, requete); //suppression de la vue intermédiaire
            }
        }


        //************************     recherche avancée
        private void tBIdBonTransfert_TextChanged(object sender, EventArgs e)
        {
            rBNumBonTransfert.Checked = true;
            chargerBonsDeTransfert();
        }
        private void dTPDebut_ValueChanged(object sender, EventArgs e)
        {
            rBDate.Checked = true;
            chargerBonsDeTransfert();
        }
        private void dTPFin_ValueChanged(object sender, EventArgs e)
        {
            rBDate.Checked = true;
            chargerBonsDeTransfert();
        }
        private void rBNumBonTransfert_CheckedChanged(object sender, EventArgs e)
        {
            if (rBNumBonTransfert.Checked)
                chargerBonsDeTransfert();
        }
        private void rBTous_CheckedChanged(object sender, EventArgs e)
        {
            if (rBTous.Checked)
                chargerBonsDeTransfert();
        }
        private void rBDate_CheckedChanged(object sender, EventArgs e)
        {
            if (rBDate.Checked)
                chargerBonsDeTransfert();
        }




        // **************************       bonton datagrid
        private void dGVBonDeTransfert_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex == -1 || e.RowIndex == -1)
                return;

            if (dGVBonDeTransfert.Columns[e.ColumnIndex].Name == "ColumnImprimer")
            {
                if (e.RowIndex != dGVBonDeTransfert.RowCount - 1)
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
                if (dGVBonDeTransfert.Columns[e.ColumnIndex].Name == "ColumnSupprimer")
                {
                    if (e.RowIndex != dGVBonDeTransfert.RowCount - 1)
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
                    if (dGVBonDeTransfert.Columns[e.ColumnIndex].Name == "ColumnModifier")
                    {
                        if (e.RowIndex != dGVBonDeTransfert.RowCount - 1)
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
            if (dGVBonDeTransfert.Columns[e.ColumnIndex].Name == "ColumnImprimer")
            {
                if (e.RowIndex != dGVBonDeTransfert.RowCount - 1) //bouton de suppression
                {
                    try
                    {
                      //  (new FormCRBonTransfert(dGVBonDeTransfert.Rows[e.RowIndex].Cells["ColumnIdBonTransfert"].Value.ToString())).ShowDialog();
                    }
                    catch (Exception) { }                    
                }
            }
            else
                if (dGVBonDeTransfert.Columns[e.ColumnIndex].Name == "ColumnModifier") //click sur le bouton de modification ou d'ajout
                {
                    if (e.RowIndex != dGVBonDeTransfert.RowCount - 1) //click sur le bouton de modification
                    {                        
                        (new ModifierBonTransfert(dGVBonDeTransfert.Rows[e.RowIndex].Cells["ColumnIdBonTransfert"].Value.ToString(),idinventaire)).ShowDialog();
                    }
                    else //click sur le bouton d'ajout
                    {  

                        (new AjouterBonDeTransfert(idinventaire)).ShowDialog();                        
                    }

                    //Ce que j'ai fait ici, c'est du bricolage : à réctifier
                    this.Visible = false;
                    (new FormBonsDeTransfert(idinventaire)).Show();
                    
                }
                else
                    if (dGVBonDeTransfert.Columns[e.ColumnIndex].Name == "ColumnSupprimer") //click sur le bouton de suppression
                    {
                        if (MessageBox.Show("Voulez vous vraiment supprimer ce bon de transfert ?", "Supprimer un bon de transfert", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                        {
                            requete = "update BonTransfert set etatBonTransfert = 'Supprimé' where idBonTransfert = " + dGVBonDeTransfert.Rows[e.RowIndex].Cells["ColumnIdBonTransfert"].Value.ToString();
                            if (MaConnexion.ExecuteUpdate(connectionString, requete) != 1)
                            {
                                MessageBox.Show("Echec de suppression du bon de transfert", "Erreur de suppression", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                            else 
                            {
                                //dGVBonDeTransfert.Rows.RemoveAt(e.RowIndex);
                                dGVBonDeTransfert.Rows.Remove(dGVBonDeTransfert.Rows[e.RowIndex]);
                            }
 
                        }
                        //chargerBonsDeTransfert();
                    }
        }



        private void dGVBonDeTransfert_SelectionChanged(object sender, EventArgs e)
        {
            chargerBiensTransférés();
        }
        private void chargerBiensTransférés() 
        {
            dGVBiens.Rows.Clear();
            try
            {
                /*
                requete = "create view vueBonDeTransfert as select Bien.idBien, Bien.ancienCode, Bien.DesigBien, CategorieBien.DesigCategorieBien, Bien.DateAcquisitionBien, Etat.DesigEtat, Bien.Prix, Bien.Particularite,Transferer.idEmplaSource, Transferer.idEmplaDest,  Emplacement.DesigEmpla as DesigEmplaSource, Transferer.reçu from  bien, Transferer, CategorieBien, Emplacement, SeTrouveB, Etat where Emplacement.idEmplaComplet = Transferer.idEmplaSource  and Bien.IdBien = Transferer.idBien and CategorieBien.IdCategorieBien = Bien.IdCategorieBien and seTrouveB.IdBien = Bien.idBien and seTrouveB.IdEtat = Etat.idEtat and SeTrouveB.uidInventaire = '" + idinventaire + "' and Transferer.idBonTransfert = " + dGVBonDeTransfert.Rows[dGVBonDeTransfert.CurrentCell.RowIndex].Cells["ColumnIdBonTransfert"].Value;
                Console.WriteLine(requete);
                MaConnexion.ExecuteUpdate(connectionString, requete);

                requete = "select vueBonDeTransfert.idBien, vueBonDeTransfert.ancienCode, vueBonDeTransfert.DesigBien, vueBonDeTransfert.DesigCategorieBien, vueBonDeTransfert.DateAcquisitionBien, vueBonDeTransfert.DesigEtat,vueBonDeTransfert.Prix, vueBonDeTransfert.Particularite, vueBonDeTransfert.DesigEmplaSource,Emplacement.DesigEmpla as DesigEmplaDestination, vueBonDeTransfert.reçu from vueBonDeTransfert, Emplacement where vueBonDeTransfert.idEmplaDest = Emplacement.idEmplaComplet";
                Console.WriteLine(requete);

                */
              string  requete3 = "select Bien.idbien,Transferer.idEmplaSource,Transferer.idEmplaDest,Bien.ancienCode, Bien.DesigBien, CategorieBien.DesigCategorieBien, Bien.DateAcquisitionBien, Etat.DesigEtat, Bien.Prix ,Bien.Particularite from bien, Transferer, CategorieBien, Emplacement, SeTrouveB, Etat where Emplacement.idEmplaComplet = Transferer.idEmplaSource and  Bien.IdBien = Transferer.idBien and CategorieBien.IdCategorieBien = Bien.IdCategorieBien and seTrouveB.IdBien = Bien.idBien and seTrouveB.IdEtat = Etat.idEtat and SeTrouveB.uidInventaire = '" + idinventaire + "' and Transferer.idBonTransfert = " + dGVBonDeTransfert.Rows[dGVBonDeTransfert.CurrentCell.RowIndex].Cells["ColumnIdBonTransfert"].Value;

                dS = MaConnexion.ExecuteSelect(connectionString, requete3);
                foreach (DataRow row in dS.Tables[0].Rows)
                {
                    object[] ligneBienTransféré = new object[] { row[0].ToString(), row[1].ToString(), row[2].ToString(), row[3].ToString(), row[4].ToString().Substring(0, 8), row[5].ToString(), row[6].ToString(), row[7].ToString(), row[8].ToString(), row[9].ToString() };
                    dGVBiens.Rows.Add(ligneBienTransféré);

                    if (row[10].ToString().Equals("True"))
                        dGVBiens.Rows[dGVBiens.Rows.Count - 2].DefaultCellStyle.BackColor = Color.Green;
                    else
                        dGVBiens.Rows[dGVBiens.Rows.Count - 2].DefaultCellStyle.BackColor = Color.Red;
                }
                requete = "drop view vueBonDeTransfert";
                MaConnexion.ExecuteUpdate(connectionString, requete);                
            }
            catch (Exception) { }
        }

        private void buttonQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

    }
}
