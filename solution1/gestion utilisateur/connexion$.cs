using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Configuration;

namespace solution1.gestion_utilisateur
{
    public partial class connexion_ : DevExpress.XtraEditors.XtraForm
    {
        public DataSet recupe_privilege = null;
        MDIParent parent = null;
        string connectionString = ConfigurationManager.ConnectionStrings["connectString1"].ConnectionString;
        public connexion_(MDIParent parent)
        {
            InitializeComponent();
            this.Owner = parent;
            this.parent = parent;
         
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            connexion();
        }
        public void connexion()
        {
            try
            {
                string requete = "select * from utilisateur where pseudo='" + login.Text.Trim() + "' and motDePasse='" + mot_pass.Text.Trim()+"'";
                DataSet conn = MaConnexion.ExecuteSelect(connectionString, requete);
                if (conn.Tables[0].Rows.Count == 0)
                {
                    MessageBox.Show("Pseudo et mot de passe erroné");
                }
                else
                {  
                    this.Close();
                    string requete_privilege = "select attribuer.*,droit.doit from attribuer join droit on attribuer.id_droit=droit.id_droit and  id_utilisateur=" + conn.Tables[0].Rows[0][0].ToString().ToLower();
                    parent.priv= MaConnexion.ExecuteSelect(connectionString, requete_privilege);
                    recupe_privilege = MaConnexion.ExecuteSelect(connectionString, requete_privilege);
                    
                    parent.menuStrip.Enabled = true;
                    parent.toolStrip.Enabled = true;
                    parent.toolStripLabel_utilisateur.Text = login.Text.Trim();

                    parent.Administrateur = conn.Tables[0].Rows[0][2].ToString().ToLower();
                    parent.idUtilisateur = conn.Tables[0].Rows[0][0].ToString().ToLower();
                    parent.toolStripStatusLabel.Text = "Utilisateur : " + login.Text.Trim();

                    OuvrirInventaire ouvre = new OuvrirInventaire(parent);
                    ouvre.MdiParent = parent;
                    ouvre.Show();

                    /*
                        if (parent.priv != null)
                        {
                            foreach (DataRow row in parent.priv.Tables[0].Rows)
                            {
                                MessageBox.Show("privilege " + row[3].ToString().Trim() + " \\ " + row[2]);
                                if ((row[3].ToString().Trim()=="Inventaire") && (row[2].ToString().Trim()=="consultation"))
                                {
                                    parent.tSBNouvelInventaire.Visible = false;
                                    parent.toolStripSeparator2.Visible = false;
                                    
            
                                }
                            }
                        }*/
                    privilege privi = new privilege();
                    privi.ouvrirInventaire(parent.priv, parent);

                    
                }
            }
            catch (Exception ex) //La base de données existe déja
            {
                MessageBox.Show("L'installation de la base à échoué" + "\n" + ex.ToString(), "Erruer", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
       
    }
}



