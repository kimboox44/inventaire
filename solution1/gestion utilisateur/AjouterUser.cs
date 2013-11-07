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

namespace solution1
{
    public partial class AjouterUser : DevExpress.XtraEditors.XtraUserControl
    {
        string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["connectString2"].ConnectionString;
        //string connection = ConfigurationManager.ConnectionStrings["ProjectPFE.Properties.Settings.ProjectPFEConnectionString"].ConnectionString;
        int i = 0;
        DataSet droi = new DataSet();
        int verif = 0;
    
        public AjouterUser()
        {
            InitializeComponent();
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
            
            string login = txtLogin.Text;
            for (int j = 0; j < nbrow-1; j++)
            {
                string descdroi = dgvDroits.Rows[j].Cells[0].Value.ToString();
               // MessageBox.Show(descdroi);
                DataSet droi = MaConnexion.ExecuteSelect(connectionString, "select idDroit from DoitsAcces where descrition ='"+descdroi+"'");
                string val = droi.Tables[0].Rows[0][0].ToString();
                string privilege = dgvDroits.Rows[j].Cells[1].Value.ToString();
                int result = MaConnexion.ExecuteUpdate(connectionString,"insert into avoir values('"+login+"','"+val+"','"+privilege+"')");
                
                if (result == 1)
                {
                    verif++;
                   
                }
            }
            if (verif == nbrow - 1) {
                txtPrenom.Text = "";
                txtNom.Text = "";
                txtLogin.Text = "";
                txtMotPasse.Text = "";
                chekAdmin.Checked = false;
                dgvDroits.Rows.Clear();
            }
           


        }

        private void butvalidUser_Click(object sender, EventArgs e)
        {
            if (chekAdmin.Checked == true)
            {
                int nb = MaConnexion.ExecuteUpdate(connectionString, "insert into utilisateur	(pseudo,motDePasse,administrateur,nom,prenom,etat) values ('"+txtLogin.Text+"','"+txtMotPasse.Text+"','true','"+txtNom.Text+"','"+txtPrenom.Text+"','valide')");
                if (nb == 1) {
                    treeDroits.Enabled = true;
                    dgvDroits.Enabled = true;
                    butvalidDroit.Enabled = true;
                }
            }
            else {
                int nb = MaConnexion.ExecuteUpdate(connectionString, "insert into utilisateur	(pseudo,motDePasse,administrateur,nom,prenom,etat) values ('" + txtLogin.Text + "','" + txtMotPasse.Text + "','false','" + txtNom.Text + "','" + txtPrenom.Text + "','valide')");
                if (nb == 1)
                {
                    treeDroits.Enabled = true;
                    dgvDroits.Enabled = true;
                    butvalidDroit.Enabled = true;
                }
            }
            
        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        

        

       
    }
}
