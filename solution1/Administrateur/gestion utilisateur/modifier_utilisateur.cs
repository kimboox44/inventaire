using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace solution1.gestion_utilisateur
{
    public partial class modifier_utilisateur : DevExpress.XtraEditors.XtraUserControl
    {
        string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["connectString1"].ConnectionString;
        string requete,login,mot_pass;
        public int id_utilisateur;
        int i=0;

        public modifier_utilisateur(string mot_passe,string login)
        {
            InitializeComponent();
            this.mot_pass = mot_passe;
            this.login = login;
            
        }

        private void modifier_utilisateur_Load(object sender, EventArgs e)
        {
            charger_utilisateur();

        }
        private void charger_utilisateur()
        {
            requete = "select * from Utilisateur where pseudo='"+login.ToString()+"' and motDePasse='"+mot_pass.ToString()+"'";
   
            DataSet utilisateur = MaConnexion.ExecuteSelect(connectionString, requete);
            if (utilisateur != null)
            {
                foreach (DataRow row in utilisateur.Tables[0].Rows)
                {
                    Login.Text = row[1].ToString();
                    Password.Text = row[2].ToString();
                    NOM.Text = row[3].ToString();
                    Prenom.Text = row[4].ToString();
                    id_utilisateur = int.Parse(row[0].ToString());


                }
            }

            requete = "select priv,droit from attribuer join privilege  on attribuer.id_priv= privilege.id_priv join droit on droit.id_droit=attribuer.id_droit and  id_utilisateur=" + id_utilisateur;
      
           DataSet privilege = MaConnexion.ExecuteSelect(connectionString, requete);
           dgvDroits.DataSource = privilege.Tables[0];
           DataGridViewButtonColumn col = new DataGridViewButtonColumn();
           dgvDroits.Columns.Add(col);


           
        }



        private void Modifier_enregistrement_Click(object sender, EventArgs e)
        {
            requete = "update utilisateur  set pseudo='"+Login.Text+"',motDePasse='"+Password.Text+"',Administrateur='"+NOM.Text+"',etat='"+Prenom.Text+"' where idUtilisateur="+id_utilisateur;
            int modif = MaConnexion.ExecuteUpdate(connectionString, requete);
            if (modif != -1)
            {
                MessageBox.Show("modification réussite!!");
            }else{MessageBox.Show("modification non effectuer");}
        }

        private void dgvDroits_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            //click sur le bouton de suppression
            
            
                if (e.RowIndex != dgvDroits.RowCount - 1) //bouton de suppression
                {
                    dgvDroits.Rows.RemoveAt(e.RowIndex); 
                }
            
        }

       

       

    }
}
