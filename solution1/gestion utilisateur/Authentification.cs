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
    public partial class Authentification : Form
    {
        MDIParent parent = null;
        string connectionString = ConfigurationManager.ConnectionStrings["connectString1"].ConnectionString;        

        public Authentification(MDIParent parent)
        {
            InitializeComponent();
            this.Owner = parent;
            this.parent = parent;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form owner = this.Owner;
            this.Close();
            owner.Close();
        }

        private void bvalider_Click(object sender, EventArgs e)
        {
            string requete = "select idUtilisateur, motDePasse, Administrateur from Utilisateur where pseudo = '" + tBPseudo.Text.Trim() + "'";
         
            DataSet dSUtilisateur = MaConnexion.ExecuteSelect(connectionString, requete);
            if (dSUtilisateur.Tables[0].Rows.Count == 0) 
            {
                MessageBox.Show("Pseudo et mot de passe erroné", "Echec d'authentification", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else 
            {
                if (dSUtilisateur.Tables[0].Rows[0][1].ToString().Trim() == tBMotDePasse.Text.Trim()) //le mot de passe est juste
                {

                    this.Close();



                    if (dSUtilisateur.Tables[0].Rows[0][2].ToString().ToLower() == "true")
                    {
                        parent.tBSUtilisateur.Enabled = true;
                    }



                    parent.menuStrip.Enabled = true;
                    parent.toolStrip.Enabled = true;
                    parent.toolStripLabel_utilisateur.Text = tBPseudo.Text.Trim();

                    parent.Administrateur = dSUtilisateur.Tables[0].Rows[0][2].ToString().ToLower();
                    parent.idUtilisateur = dSUtilisateur.Tables[0].Rows[0][0].ToString().ToLower();
                    parent.toolStripStatusLabel.Text = "Utilisateur : " + tBPseudo.Text.Trim();
                    if (dSUtilisateur.Tables[0].Rows[0][2].ToString().ToLower() == "true")
                    {
                        parent.toolStripStatusLabel.Text += " (Administrateur)";




                        OuvrirInventaire ouvre = new OuvrirInventaire(parent);
                        ouvre.MdiParent = parent;
                        ouvre.Show();

                        parent.toolStripMenuAdmin.Visible = true;

                    }
                    else
                    {
                        parent.toolStripMenuAdmin.Visible = false;
                    }
                }
               
               

               
            } 
        }

        private void Authentification_FormClosed(object sender, FormClosedEventArgs e)
        {                       
            
        }

        private void Authentification_Load(object sender, EventArgs e)
        {    
        
        }

        private void tBMotDePasse_TextChanged(object sender, EventArgs e)
        {

        }

        private void tBPseudo_TextChanged(object sender, EventArgs e)
        {

        }

       
    
    }
}
