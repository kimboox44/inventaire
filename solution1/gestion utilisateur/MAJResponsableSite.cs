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
    public partial class MAJResponsableSite : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["connectString1"].ConnectionString;
        DataSet dS = null;
        string requete = null;
        string idSite = null;

        public MAJResponsableSite(string idSite)
        {
            this.idSite = idSite;
            InitializeComponent();
        }

        public MAJResponsableSite()
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

        private void MAJResponsableSite_Load(object sender, EventArgs e)
        {
            chargerResponsable();
            chargerSites();
        }

        private void chargerSites()
        {
            try
            {
                requete = "select IdSite, NomSite from Site where etatSite = 'Non supprimé'";
                dS = MaConnexion.ExecuteSelect(connectionString, requete);
                lBSites.Items.Clear();
                foreach (DataRow row in dS.Tables[0].Rows)
                {
                    structSite str = new structSite(row[0].ToString(), row[1].ToString());
                    lBSites.Items.Add(str);
                }
                sélectionnerSite(idSite);
            }
            catch (Exception ex) { }
        }

        private void sélectionnerSite(string idSite)
        {
            //Sélection du site adéquat
            if (idSite == null)
            {
                try //selection du premier site
                {
                    lBSites.SelectedIndex = 0;
                }
                catch (Exception) { } //pas de site dans la base de donnée
            }
            else
            {
                bool trouve = false;
                for (int i = 0; i < lBSites.Items.Count && !trouve; i++)
                {
                    if (((structSite)lBSites.Items[i]).Idsite.Equals(idSite))
                    {
                        trouve = true;
                        lBSites.SelectedIndex = i;
                    }
                }
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
                    dGVResponsables.Rows.Add(new object[] { false, dR[1].ToString(), dR[2].ToString(), dR[3].ToString() });
                    dGVResponsables.Rows[dGVResponsables.Rows.Count - 2].Tag = dR[0].ToString(); //sauvegarde de l'identifiant du responsable

                }
            }
        }

        private void lBSites_SelectedIndexChanged(object sender, EventArgs e)
        {
            rechercherResponsableCorrespondant( ((structSite)lBSites.SelectedItem).Idsite );
        }

        private void rechercherResponsableCorrespondant(string idSite)
        {
            try
            {
                requete = "select idResp from Site where idSite = " + idSite;

                dS = MaConnexion.ExecuteSelect(connectionString, requete);
                for (int i = 0; i < dGVResponsables.Rows.Count - 1; i++)
                {
                    if (dGVResponsables.Rows[i].Tag.ToString().Equals(dS.Tables[0].Rows[0][0].ToString()))
                        ((DataGridViewCheckBoxCell)dGVResponsables.Rows[i].Cells[0]).Value = true;
                    else
                        ((DataGridViewCheckBoxCell)dGVResponsables.Rows[i].Cells[0]).Value = false;
                }
            }
            catch (Exception ex) { } //si un emplacement ne possede pas de responsable
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

        private void dGVResponsables_CellStateChanged(object sender, DataGridViewCellStateChangedEventArgs e)
        {
            if (dGVResponsables.Columns[e.Cell.ColumnIndex].Name == "ColumnResponsable")
            {
                try
                {
                    for (int i = 0; i < dGVResponsables.Rows.Count; i++)
                    {
                        ((DataGridViewCell)dGVResponsables.Rows[i].Cells["ColumnResponsable"]).Value = false;
                    }

                    requete = "update Site set idResp = " + dGVResponsables.Rows[e.Cell.RowIndex].Tag.ToString() + " where idSite = " + ((structSite)lBSites.SelectedItem).Idsite;
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
