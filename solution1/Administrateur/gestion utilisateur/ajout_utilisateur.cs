using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Configuration;
using System.Linq;
using System.Data.SqlClient;

namespace solution1.gestion_utilisateur
{
    public partial class ajout_utilisateur : DevExpress.XtraEditors.XtraUserControl
    {
        int i = 0;
        DataSet droi = new DataSet();
        int verif = 0;
        solution1.Prenom.gestion_utilisateur.message msg = new solution1.Prenom.gestion_utilisateur.message();
        string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["connectString1"].ConnectionString;
        public ajout_utilisateur()
        {
            InitializeComponent();
            Bitmap b= new Bitmap(40, 40);
            Graphics g = Graphics.FromImage((Image)b);
            g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            g.DrawImage(valider_enregistrement.Image, 0, 0, 40, 40);
            g.Dispose(); Image myResizedImg = (Image)b;
            //put the resized image back to the button and change toolstrip's 
            valider_enregistrement.Image = myResizedImg;
        }
        private void selectnod(object sender, TreeViewEventArgs e)
                {

            TreeNode nod = treeDroits.SelectedNode.Parent;
            if (nod != null)
            {
                dgvDroits.Rows.Add(1);
                dgvDroits.Rows[i].Cells[1].Value = nod.Text;
                dgvDroits.Rows[i].Cells[0].Value = treeDroits.SelectedNode.Text;
                i++;

            }

        }

        private void deletrow(object sender, DataGridViewRowEventArgs e)
        {

            i = i - 1;

        }

        private void butvalidDroit_Click(object sender, EventArgs e)
        {
            int nbrow = dgvDroits.Rows.Count;

            string login = Login.Text;
            for (int j = 0; j < nbrow - 1; j++)
            {
                string descdroi = dgvDroits.Rows[j].Cells[0].Value.ToString();
                // MessageBox.Show(descdroi);
                DataSet droi = MaConnexion.ExecuteSelect(connectionString, "select idDroit from DoitsAcces where descrition ='" + descdroi + "'");
                string val = droi.Tables[0].Rows[0][0].ToString();
                string privilege = dgvDroits.Rows[j].Cells[1].Value.ToString();
                int result = MaConnexion.ExecuteUpdate(connectionString, "insert into avoir values('" + login + "','" + val + "','" + privilege + "')");

                if (result == 1)
                {
                    verif++;

                }
            }
            if (verif == nbrow - 1)
            {
                Prenom.Text = "";
                Nom.Text = "";
                Login.Text = "";
                Password.Text = "";
                check_admin.Checked = false;
                dgvDroits.Rows.Clear();
            }
        }

        private void butvalidUser_Click(object sender, EventArgs e)
        {
            if (check_admin.Checked == true)
            {
                int nb = MaConnexion.ExecuteUpdate(connectionString, "insert into Utilisateur	(pseudo,motDePasse,Administrateur,etat) values ('" + Login.Text + "','" + Password.Text + "','true','valide')");
                if (nb == 1)
                {
                    treeDroits.Enabled = true;
                    dgvDroits.Enabled = true;
                    enregistrer_droit.Enabled = true;
                }
            }
            else
            {
                int nb = MaConnexion.ExecuteUpdate(connectionString, "insert into Utilisateur	(pseudo,motDePasse,Administrateur,etat) values ('" + Login.Text + "','" + Password.Text + "','false','valide')");
                if (nb == 1)
                {
                    treeDroits.Enabled = true;
                    dgvDroits.Enabled = true;
                    enregistrer_droit.Enabled = true;
                }
            }

        }


        private void valider_enregistrement_Click(object sender, EventArgs e)
        {
            
            if (Login.Text != "" && Password.Text != "" && Nom.Text != "" && Prenom.Text != "")
            {
                if (check_admin.Checked == true)
                {
                    string requete = "insert into Utilisateur (pseudo,motDePasse,Administrateur,etat) values ('" + Login.Text + "','" + Password.Text + "','true','valide')";

                    int nb = MaConnexion.ExecuteUpdate(connectionString, requete);

                    msg.ajout_admin(Nom.Text,Prenom.Text,Login.Text,Password.Text);
                    msg.Show();

                    Nom.Text = "";
                    Prenom.Text = "";
                    Login.Text = "";
                    Password.Text = "";

                    
                }

                else
                {
                        string req = "insert into Utilisateur (pseudo,motDePasse,Administrateur,etat) values ('" + Login.Text + "','" + Password.Text + "','false','valide')";
                        int nb = MaConnexion.ExecuteUpdate(connectionString, req);
                        panelControl3.Enabled = true;
                } 
                
            }
            else
            {
                MessageBox.Show("verifier que les champs sont bien remplis");
            }
        }


        private void enregistrer_droit_Click(object sender, EventArgs e)
        {
            int nbrow = dgvDroits.Rows.Count;
           
            for (int i = 0; i < nbrow - 1; i++)
            {
                string privilege = dgvDroits.Rows[i].Cells[0].Value.ToString();
                string droit = dgvDroits.Rows[i].Cells[1].Value.ToString();
                string requete = "insert into attribuer (id_droit,id_priv,id_utilisateur) values ((select id_droit from droit where droit='" + droit.ToString() + "'),(select id_priv from privilege where priv='" + privilege.ToString() + "'),(select idUtilisateur from Utilisateur where pseudo='" + Login.Text.ToString() + "' and motDePasse='" + Password.Text.ToString() + "'))";
                int attribution = MaConnexion.ExecuteUpdate(connectionString, requete);
                if (attribution == 1)
                {
                    //MessageBox.Show(" Ajout droit réussi ");
                }

               
            }
            msg.ajout_util(Nom.Text, Prenom.Text, Login.Text, Password.Text, dgvDroits);
            
            Nom.Text = "";
            Prenom.Text = "";
            Login.Text = "";
            Password.Text = "";
            dgvDroits.Rows.Clear();
           
            panelControl3.Enabled = false;
            msg.Show();

           
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

            TreeNode nod = treeDroits.SelectedNode.Parent;
            if (nod != null)
            {
                dgvDroits.Rows.Add(1);
                dgvDroits.Rows[i].Cells[1].Value = nod.Text;
                dgvDroits.Rows[i].Cells[0].Value = treeDroits.SelectedNode.Text;
                i++;

            }
        }

        private void dataGrid_utilisateur_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           // if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            //click sur le bouton de suppression
          
           // if (e.RowIndex != dgvDroits.RowCount - 1) //bouton de suppression
           // {
            MessageBox.Show("tes"+e.RowIndex.ToString());
                dgvDroits.Rows.RemoveAt(e.RowIndex);
                
            //}
        }

        private void ajout_utilisateur_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }


        public FormWindowState WindowState { get; set; }

    }
}
