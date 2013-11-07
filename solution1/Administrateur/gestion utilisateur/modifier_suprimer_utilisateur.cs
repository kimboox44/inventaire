using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.Threading;

namespace solution1.gestion_utilisateur
{

    public partial class modifier_suprimer_utilisateur : DevExpress.XtraEditors.XtraUserControl
    {
        //public gestion_utilisateur gestion_utilisateur = new gestion_utilisateur();

        string connectionString = ConfigurationManager.ConnectionStrings["connectString1"].ConnectionString;
        string requete;
        

        public string mot;
        public string log;
        
        public modifier_suprimer_utilisateur()
        {
            InitializeComponent();
            
        }

        private void modifier_suprimer_utilisateur_Load(object sender, EventArgs e)
        {
            charger_utilisateur();
        }

        private void charger_utilisateur() 
        {
            DataSet dSUtilisateur = MaConnexion.ExecuteSelect(connectionString, "select idUtilisateur,Administrateur, pseudo, motDePasse from utilisateur where etat = 'Valide'");
            if (dSUtilisateur != null)
            {
                foreach (DataRow row in dSUtilisateur.Tables[0].Rows)
                {
                    object[] newRow = new object[] { row[0].ToString().Trim(), row[1].ToString().Trim(), row[2].ToString().Trim(), row[3].ToString().Trim(),null,null };
                    dataGrid_utilisateur.Rows.Add(newRow);
                }
              
            }
        }


        private void dataGrid_utilisateur_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            //click sur le bouton de suppression
            if (dataGrid_utilisateur.Columns[e.ColumnIndex].Name == "Supprimer")
            {
                if (e.RowIndex != dataGrid_utilisateur.RowCount - 1) //bouton de suppression
                {
                    if (MessageBox.Show("Voulez vous vraiment supprimer cet utilisateur ?", "Supprimer un client", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        requete = "update Utilisateur set etat = 'Non valide' where pseudo ='" + dataGrid_utilisateur.Rows[e.RowIndex].Cells["Login"].Value + "'and motDePasse='" + dataGrid_utilisateur.Rows[e.RowIndex].Cells["Mot_pass"].Value+"'";
                        

                        if (MaConnexion.ExecuteUpdate(connectionString, requete) == 1)
                        {
                            dataGrid_utilisateur.Rows.Clear();
                            charger_utilisateur();
                        }
                        else
                            MessageBox.Show("La suppression a échoué", "Erreur de suppression", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
           
                if (dataGrid_utilisateur.Columns[e.ColumnIndex].Name == "Modifier") //click sur le bouton de modification ou d'ajout
                {
                    if (e.RowIndex != dataGrid_utilisateur.RowCount - 1) //click sur le bouton de modification
                    {
                        log= dataGrid_utilisateur.Rows[e.RowIndex].Cells["login"].Value.ToString();
                        mot = dataGrid_utilisateur.Rows[e.RowIndex].Cells["mot_pass"].Value.ToString();


                 
                        
                    }
                  
                   
                }

        }

      

  
    }
}
