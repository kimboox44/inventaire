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
    public partial class MAJClient : Form
    {
        string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["connectString1"].ConnectionString;
        string requete = null;
        DataSet dS = null;

        public MAJClient()
        {
            InitializeComponent();
        }

        private void MAJClient_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            chargerClients();
        }

        private void chargerClients() 
        {            
            if (rBTous.Checked)
            {                
                requete = "select * from client where etat = 'Non supprimé'";                
            }
            else 
            {
                if (rBIdentifiant.Checked)
                {
                    requete = "select * from client where etat = 'Non supprimé' and idClient = " + tBIdentifiant.Text;
                    Console.WriteLine(requete);
                }
                else 
                {
                    if (rBRaisonSociale.Checked)
                    {                        
                        requete = "select * from client where etat = 'Non supprimé' and nom like '" + tBRaisonSociale.Text + "%';";
                        Console.WriteLine(requete);
                    }
                }
            }

            dGVClients.Rows.Clear();
            dS = MaConnexion.ExecuteSelect(connectionString, requete);
            try
            {
                foreach (DataRow row in dS.Tables[0].Rows)
                {
                    object[] ligneClient = new object[] { null, null, row[0].ToString(), row[1].ToString(), row[2].ToString(), row[3].ToString(), row[4].ToString(), row[5].ToString(), row[6].ToString(), row[7].ToString(), row[8].ToString(), row[9].ToString(), row[10].ToString(), row[11].ToString(), row[12].ToString() };
                    dGVClients.Rows.Add(ligneClient);

                }
            }
            catch (Exception) { }
            
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
            } else
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
            } else
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

        private void tBRaisonSociale_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        private void tBIdentifiant_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        private void rBTous_CheckedChanged(object sender, EventArgs e)
        {
            if (rBTous.Checked)
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
        
        private void tBRaisonSociale_TextChanged(object sender, EventArgs e)
        {
            rBRaisonSociale.Checked = true;
            chargerClients();
        }

        private void tBIdentifiant_TextChanged(object sender, EventArgs e)
        {
            rBIdentifiant.Checked = true;
            chargerClients();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void rBTous_ChangeUICues(object sender, UICuesEventArgs e)
        {

        }

        private void dGVClients_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }




    }
}


