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
    public partial class MAJFournisseur : Form
    {
        string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["connectString1"].ConnectionString;
        string requete = null;
        DataSet dS = null;

        public MAJFournisseur()
        {
            InitializeComponent();
        }

        private void MAJFournisseur_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            chargerFournisseurs();
        }

        private void chargerFournisseurs()         
        {            
            if (rBTous.Checked)
            {                
                requete = "select * from Fournisseur where etat = 'Non supprimé'";                
            }
            else 
            {
                if (rBIdentifiant.Checked)
                {
                    requete = "select * from Fournisseur where etat = 'Non supprimé' and idFournisseur = " + tBIdentifiant.Text;
                    Console.WriteLine(requete);
                }
                else 
                {
                    if (rBRaisonSociale.Checked)
                    {                        
                        requete = "select * from Fournisseur where etat = 'Non supprimé' and nom like '" + tBRaisonSociale.Text + "%';";
                        Console.WriteLine(requete);
                    }
                }
            }
            Console.WriteLine(requete);
            dGVFournisseurs.Rows.Clear();
            dS = MaConnexion.ExecuteSelect(connectionString, requete);
            try
            {
                foreach (DataRow row in dS.Tables[0].Rows)
                {
                    object[] ligneClient = new object[] { null, null, row[0].ToString(), row[1].ToString(), row[2].ToString(), row[3].ToString(), row[4].ToString(), row[5].ToString(), row[6].ToString(), row[7].ToString(), row[8].ToString(), row[9].ToString(), row[10].ToString(), row[11].ToString(), row[12].ToString() };
                    dGVFournisseurs.Rows.Add(ligneClient);
                }
            }
            catch (Exception) { }
        }

        private void rBTous_CheckedChanged(object sender, EventArgs e)
        {
            if (rBTous.Checked)
                chargerFournisseurs();
        }

        private void rBIdentifiant_CheckedChanged(object sender, EventArgs e)
        {
            if (rBIdentifiant.Checked)
                chargerFournisseurs();
        }

        private void rBRaisonSociale_CheckedChanged(object sender, EventArgs e)
        {
            if (rBRaisonSociale.Checked)
                chargerFournisseurs();
        }

        private void tBIdentifiant_TextChanged(object sender, EventArgs e)
        {
            rBIdentifiant.Checked = true;
            chargerFournisseurs();
        }

        private void tBRaisonSociale_TextChanged(object sender, EventArgs e)
        {
            rBRaisonSociale.Checked = true;
            chargerFournisseurs();
        }

        private void dGVFournisseurs_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            //click sur le bouton de suppression
            if (dGVFournisseurs.Columns[e.ColumnIndex].Name == "ColumnSupprimer")
            {
                if (e.RowIndex != dGVFournisseurs.RowCount - 1) //bouton de suppression
                {
                    if (MessageBox.Show("Voulez vous vraiment supprimer ce fournisseur ?", "Supprimer un fournisseur", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                    {
                        requete = "update fournisseur set etat = 'Supprimé' where idFournisseur =" + dGVFournisseurs.Rows[e.RowIndex].Cells["ColumnIdFournisseur"].Value;
                        Console.WriteLine(requete);

                        if (MaConnexion.ExecuteUpdate(connectionString, requete) == 1)
                        {
                            chargerFournisseurs();
                        }
                        else
                            MessageBox.Show("La suppression a échoué", "Erreur de suppression", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
            else
                if (dGVFournisseurs.Columns[e.ColumnIndex].Name == "ColumnModifier") //click sur le bouton de modification ou d'ajout
                {
                    if (e.RowIndex != dGVFournisseurs.RowCount - 1) //click sur le bouton de modification
                    {
                        (new ModierFournisseur(dGVFournisseurs.Rows[e.RowIndex].Cells["ColumnIdFournisseur"].Value.ToString())).ShowDialog();                        
                    }
                    else //click sur le bouton d'ajout
                    {
                        (new AjouterFournisseur()).ShowDialog();
                    }
                    chargerFournisseurs();
                }
        }

        private void dGVFournisseurs_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex == -1 || e.RowIndex == -1)
                return;

            if (dGVFournisseurs.Columns[e.ColumnIndex].Name == "ColumnSupprimer")
            {
                if (e.RowIndex != dGVFournisseurs.RowCount - 1)
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
                if (dGVFournisseurs.Columns[e.ColumnIndex].Name == "ColumnModifier")
                {
                    if (e.RowIndex != dGVFournisseurs.RowCount - 1)
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

        private void dGVFournisseurs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }




    }
}
