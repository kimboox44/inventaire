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
    public partial class PVsCessions : Form
    {
        string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["connectString1"].ConnectionString;
        string requete = null;
        DataSet dS = null;
        string dateDebut = null;
        string dateFin = null;

        public PVsCessions()
        {
            InitializeComponent();
        }

        private void PVs_Load(object sender, EventArgs e)
        {
            chargerPVCession();
        }

        private void chargerPVCession() 
        {
            if (rBTous.Checked)
            {
                requete = "select * from PVCession where etat = 'Non supprimé'";
            }
            else
            {
                if (rBNumPV.Checked)
                {
                    requete = "select * from PVCession where etat = 'Non supprimé' and idPVCession = " + tBIdPVCession.Text;                    
                }
                else
                {
                    if (rBDate.Checked)
                    {                        
                        dateDebut = this.dTPDebut.Value.ToString("MM/dd/yyyy");
                        dateFin = this.dTPFin.Value.ToString("MM/dd/yyyy");


                        requete = "select * from PVCession where etat = 'Non supprimé' and DateCession > '" + dateDebut + "' and DateCession < '" + dateFin + "'";                                                
                    }
                }
            }            

            dGVPVCession.Rows.Clear();
            dS = MaConnexion.ExecuteSelect(connectionString, requete);
            try
            {
                foreach (DataRow row in dS.Tables[0].Rows)
                {
                    int jour = Int32.Parse(row[1].ToString().Substring(0, 2));
                    int mois = Int32.Parse(row[1].ToString().Substring(3, 2));
                    int année = Int32.Parse(row[1].ToString().Substring(6, 4));
                    DateTime date = new DateTime(année, mois, jour);
                    object[] lignePVCession = new object[] { row[0].ToString(), date};
                    dGVPVCession.Rows.Add(lignePVCession);                    
                }
            }
            catch (Exception) { }

        }

        private void rBTous_CheckedChanged(object sender, EventArgs e)
        {
            if (rBTous.Checked)
                chargerPVCession();
        }

        private void rBNumPV_CheckedChanged(object sender, EventArgs e)
        {
            if (rBNumPV.Checked)
                chargerPVCession();
        }

        private void rBDate_CheckedChanged(object sender, EventArgs e)
        {
            if (rBDate.Checked)
                chargerPVCession();
        }

        private void tBIdPVCession_TextChanged(object sender, EventArgs e)
        {
            rBNumPV.Checked = true;
            chargerPVCession();
        }

        private void dTPDebut_ValueChanged(object sender, EventArgs e)
        {
            rBDate.Checked = true;
            chargerPVCession();
        }

        private void dTPFin_ValueChanged(object sender, EventArgs e)
        {
            rBDate.Checked = true;
            chargerPVCession();
        }

        private void dGVPVCession_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex == -1 || e.RowIndex == -1)
                return;

            if (dGVPVCession.Columns[e.ColumnIndex].Name == "ColumnImprimer")
            {
                if (e.RowIndex != dGVPVCession.RowCount - 1)
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
                if (dGVPVCession.Columns[e.ColumnIndex].Name == "ColumnModifier")
                {
                    if (e.RowIndex != dGVPVCession.RowCount - 1)
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

        private void dGVPVCession_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            //click sur le bouton de suppression
            if (dGVPVCession.Columns[e.ColumnIndex].Name == "ColumnImprimer")
            {
                if (e.RowIndex != dGVPVCession.RowCount - 1) //bouton de suppression
                {
                    //dGVPVCession.Rows[e.RowIndex].Cells["ColumnIdClient"].Value
                    //A completer
                   // (new FormCRPVCession(dGVPVCession.Rows[e.RowIndex].Cells["ColumnIdPV"].Value.ToString())).ShowDialog();

                }
            }
            else
                if (dGVPVCession.Columns[e.ColumnIndex].Name == "ColumnModifier") //click sur le bouton de modification ou d'ajout
                {
                    if (e.RowIndex != dGVPVCession.RowCount - 1) //click sur le bouton de modification
                    {
                        //dGVPVCession.Rows[e.RowIndex].Cells["ColumnIdClient"].Value.ToString()
                        //(new MAJCession(dGVPVCession.Rows[e.RowIndex].Cells["ColumnIdPV"].Value.ToString())).ShowDialog(); 
                        //(new Cession.Rapport()).ShowDialog();
                    }
                    else //click sur le bouton d'ajout
                    {
                        requete = "INSERT INTO PVCession (DateCession,etat) VALUES ('" + DateTime.Now.ToString("dd-MM-yyyy") + "', 'Non supprimé')";                        
                        if (MaConnexion.ExecuteUpdate(connectionString, requete) != 1) 
                        {
                            MessageBox.Show("Echec de l'insertion d'un nouveau PV de cession", "Erreur de d'insertion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                    chargerPVCession();
                }
        }

        private void dGVPVCession_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == -1 || e.RowIndex == -1)
                return;

            if (dGVPVCession.Columns[e.ColumnIndex].Name == "ColumnDateCession")
            {
                string date = dGVPVCession.Rows[e.RowIndex].Cells["ColumnDateCession"].Value.ToString();
                date = date.Substring(3, 2) + "/" + date.Substring(0, 2) + "/" + date.Substring(6);
                requete = "update PVCession set dateCession = '" + date + "' where idPVCession = " + dGVPVCession.Rows[e.RowIndex].Cells["ColumnIdPV"].Value.ToString();
                if (MaConnexion.ExecuteUpdate(connectionString, requete) != 1) 
                {
                    MessageBox.Show("Echec de la mise à jour de la date du PV", "Erreur de modification", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }

        }

        private void dGVPVCession_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
               
    }
}
