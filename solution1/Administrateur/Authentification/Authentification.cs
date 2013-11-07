using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using solution1.gestion_utilisateur;

namespace solution1
{
    public partial class Authentification : Form
    {
        public DataSet dSUtilisateur = null;
        MDIParent parent = null;
        MDIParent mDIParent = null;
        string connectionString = ConfigurationManager.ConnectionStrings["connectString1"].ConnectionString;        

        public Authentification(MDIParent parent)
        {
            InitializeComponent();
            this.Owner = parent;
            this.parent = parent;
            this.mDIParent = parent;
        }

        //annulation de l'authentification
        private void button2_Click(object sender, EventArgs e)
        {
            Form owner = this.Owner;
            this.Close();
            owner.Close();
        }

        // laa validation apartir du bouton entrer
        private void tBMotDePasse_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                bvalider_Click(sender, e);
                e.Handled = true;
            }
        }

        // validation de l'euthentification
        private void bvalider_Click(object sender, EventArgs e)
        {
            string requete = "select idUtilisateur, motDePasse, Administrateur from Utilisateur where pseudo = '" + tBPseudo.Text.Trim() + "' and motDePasse='" + tBMotDePasse.Text.Trim()+ "' and etat='Valide'";
         
           dSUtilisateur = MaConnexion.ExecuteSelect(connectionString, requete);
            // si l'utilisateur n'existe pas
            if (dSUtilisateur.Tables[0].Rows.Count == 0) 
            {
                panel1.Visible = true;

                DateTime t = DateTime.Now;
                Random r = new Random((int)(t.Ticks));

                while (DateTime.Now.Second < t.Second + 1)
                    
                {
                    this.DesktopLocation = new Point(this.Location.X + r.Next(-2, 3), this.Location.Y + r.Next(-2, 3));

                    this.StartPosition = FormStartPosition.CenterScreen;
                }

            }
            else 
            {
                attribuer_privilaige();
                charger_inv();
                privilege privi = new privilege();
                privi.ouvrirInventaire(parent.priv, parent);
               
            }    
        }

        // attribution des privilege de l'utilisateur
        private void attribuer_privilaige()
        {

            this.Close();
            string requete_privilege = "select attribuer.*,droit.droit,privilege.priv from attribuer join droit on attribuer.id_droit=droit.id_droit join privilege on privilege.id_priv=attribuer.id_priv and  id_utilisateur=" + dSUtilisateur.Tables[0].Rows[0][0].ToString().ToLower();
            parent.priv = MaConnexion.ExecuteSelect(connectionString, requete_privilege);


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
                parent.toolStripMenuAdmin.Visible = true;
            }
            else
            {
                parent.toolStripMenuAdmin.Visible = false;
            }
        }

        // charger inventaire 
        private void charger_inv()
        {
            string req = "select uidInventaire,DesigInventaire from inventaire where type='Comptable' and caract='En cours'";
            DataSet idinvent = MaConnexion.ExecuteSelect(connectionString, req);
            if (idinvent.Tables[0].Rows.Count == 0)
            {
                OuvrirInventaire ouvre = new OuvrirInventaire(parent);
                ouvre.MdiParent = parent;
                ouvre.Show();
            }
            else
            {
                string uidInventaire = idinvent.Tables[0].Rows[0][0].ToString();
                FormInventaire formInventaire = new FormInventaire(mDIParent, uidInventaire);
                formInventaire.MdiParent = parent;
                formInventaire.Text = idinvent.Tables[0].Rows[0][1].ToString();
                formInventaire.Show();

            }

        }

    }
}
