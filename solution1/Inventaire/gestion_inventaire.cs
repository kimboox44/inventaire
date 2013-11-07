using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace solution1.Inventaire
{
    public partial class gestion_inventaire : Form
    {
        string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["connectString1"].ConnectionString;

        public gestion_inventaire()
        {
            InitializeComponent();
            charger_gestion_inventaire();
        }

        private void gestion_inventaire_Load(object sender, EventArgs e)
        {

        }

        private void charger_gestion_inventaire()
        {
            string requete = "select * from inventaire where etat ='Valide'";
            dgv_inventaire.Rows.Clear();

            DataSet dS = MaConnexion.ExecuteSelect(connectionString, requete);
            try
            {
                foreach (DataRow row in dS.Tables[0].Rows)
                {
                    object[] ligneBien = new object[] { row[1].ToString(), row[4].ToString(), row[5].ToString(), row[2].ToString() };
                    dgv_inventaire.Rows.Add(ligneBien);

                }
            }
            catch (Exception)
            { }
        }

        private void dgv_inventaire_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            //click sur le bouton de suppression
            if (dgv_inventaire.Columns[e.ColumnIndex].Name == "Column3")
            {
               
                if (e.RowIndex != dgv_inventaire.RowCount - 1) //bouton de suppression
                {
                    if (MessageBox.Show("Voulez vous vraiment supprimer cet inventaire ?", "Supprimer un inventaire", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                    {
                        string requete = "update inventaire set etat='Non Valide' where DesigInventaire='" + dgv_inventaire.Rows[e.RowIndex].Cells["Column1"].Value + "'";
                        
                        if (MaConnexion.ExecuteUpdate(connectionString, requete) == 1)
                        {
                            charger_gestion_inventaire();
                        }
                        else
                            MessageBox.Show("La suppression a échoué", "Erreur de suppression", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
                   
        }

        private void dgv_inventaire_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
