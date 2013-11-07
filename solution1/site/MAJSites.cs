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
    public partial class MAJSites : Form
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["connectString1"].ConnectionString;
        private string requete;
        private DataSet dS = null;
        public FormInventaire form = null;

        public MAJSites(FormInventaire form)
        {
            this.form = form;
            InitializeComponent();
        }

        struct structSite
        {
            string idSite;
            string nomSite;
            public structSite(String idSite, string nomSite) { this.idSite = idSite; this.nomSite = nomSite; }
            public string IdSite
            {
                get { return idSite; }
            }
            public string NomSite
            {
                get { return nomSite; }
            }
        }

        private void dataGridView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex == -1 || e.RowIndex == -1)
                return;

            if (dGVSites.Columns[e.ColumnIndex].Name == "ColumnSupprimer")
            {
                if (e.RowIndex != dGVSites.RowCount - 1)
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

        private void MAJSites_Load(object sender, EventArgs e)
        {
             Sites();
             
            
        }

        private void Sites()
        {
            try
            {
                requete = "select IdSite, NomSite from Site where etatSite = 'Non supprimé'";
                dS = MaConnexion.ExecuteSelect(connectionString, requete);
                dGVSites.Rows.Clear();
                foreach (DataRow row in dS.Tables[0].Rows)
                {
                    object[] newRow = new object[] { null, row[1].ToString() };                    
                    dGVSites.Rows.Add(newRow);
                    dGVSites.Rows[dGVSites.Rows.Count - 2].Tag = row[0].ToString(); //sauvegarde de l'identifiant du site
                }
                dGVSites.Rows[0].Selected = true;
            }
            catch (Exception ex) { }
        }

        private void dGVSites_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            //click sur le bouton de suppression
            if (dGVSites.Columns[e.ColumnIndex].Name == "ColumnSupprimer")
            {
                if (e.RowIndex != dGVSites.RowCount - 1) //bouton de suppression
                {
                    if (MessageBox.Show("Voulez vous vraiment supprimer le site '" + dGVSites.Rows[e.RowIndex].Cells["ColumnNomSite"].Value + "' ?", "Supprimer un site", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                    {
                        requete = "update site set etatSite = 'Supprimé' where idSite =" + dGVSites.Rows[e.RowIndex].Tag;

                        if (MaConnexion.ExecuteUpdate(connectionString, requete) == 1)
                        {
                            Sites();
                        }
                        else
                            MessageBox.Show("La suppression a échoué", "Erreur de suppression", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else //click sur le bouton d'ajout
                {
                    ajouterSite();
                }
            } 
        }

        private void ajouterSite() 
        {
            try
            {
                requete = "select MAX(idSite)from Site";
                dS = MaConnexion.ExecuteSelect(connectionString, requete);
                String Idsite = dS.Tables[0].Rows[0][0].ToString();

                requete = "INSERT INTO Site (NomSite,etatSite) VALUES ('Nouveau site"+Idsite+1+"', 'Non supprimé');";
                if (MaConnexion.ExecuteUpdate(connectionString, requete) == 1)
                {
                    requete = "select IdSite, NomSite from Site where IdSite in (select MAX(idSite)from Site)";
                    dS = MaConnexion.ExecuteSelect(connectionString, requete);
                    object[] newRow = new object[] { null, dS.Tables[0].Rows[0][1].ToString() };
                    dGVSites.Rows.Add(newRow);
                    dGVSites.Rows[dGVSites.Rows.Count - 2].Tag = dS.Tables[0].Rows[0][0].ToString(); //sauvegarde de l'identifiant du site
                                        
                }
                else
                {
                    MessageBox.Show("Le nom du site doit être unique", "Nouveau site", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Echec de l'ajout d'un nouveau site", "Nouveau site", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dGVSites_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dGVSites_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            if (dGVSites.Columns[e.ColumnIndex].Name == "ColumnNomSite")
            {
                try
                {
                    requete = "update Site set nomSite = '" + dGVSites.Rows[e.RowIndex].Cells["ColumnNomSite"].Value + "' where idSite = " + dGVSites.Rows[e.RowIndex].Tag;
                    Console.WriteLine(requete);
                    if (MaConnexion.ExecuteUpdate(connectionString, requete) != 1)
                    {
                        MessageBox.Show("Echec de la modification du site", "Erreur de modication", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception) { }
            }
        }

        private void dGVSites_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public  void OKsite_Click(object sender, EventArgs e)
        {
            DataSet infosite = MaConnexion.ExecuteSelect(connectionString, "select * from site where etatSite = 'Non supprimé'");
            form.comboBoxSite.Items.Clear();
           
            foreach (DataRow row in infosite.Tables[0].Rows)
            {
                
                FormInventaire.structSite str = new FormInventaire.structSite(row[0].ToString(), row[1].ToString());
                form.comboBoxSite.Items.Add(str);
            }

            
            try //selection du premier site
            { 
                form.comboBoxSite.Text = infosite.Tables[0].Rows[0][1].ToString();
                form.treeViewEmplacement.SelectedNode = form.treeViewEmplacement.Nodes[0];
            }
            catch (Exception) { } //pas de site dans la base de donnée*/
            this.Close();
        }

       
      

   }
}
