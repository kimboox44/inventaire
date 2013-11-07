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
    public partial class ModierFournisseur : Form
    {
        string idFournisseur = "";
        string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["connectString1"].ConnectionString;
        string requete = null;
        DataSet dS = null;

        public ModierFournisseur(string idFournisseur)
        {
            this.idFournisseur = idFournisseur;
            InitializeComponent();
        }

        private void bAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bModifier_Click(object sender, EventArgs e)
        {
            modifierClient();
        }

        private void modifierClient()
        {
            requete = "UPDATE Fournisseur SET "
                      + "nom = '" + tBRaisonSociale.Text
                      + "',spécialité = '" + tBSpécialité.Text
                      + "',adresse = '" + tBAdresse.Text.Replace("'", "''")
                      + "',ville = '" + tBVille.Text
                      + "',wilaya = '" + tBPays.Text
                      + "',pays = '" + tBWilaya.Text
                      + "',registreDeCommerce = '" + tBRegistreDeCommerce.Text
                      + "',NIF = '" + tBNIF.Text
                      + "',Téléphone1 = '" + tBTél1.Text
                      + "',Téléphone2 = '" + tBTél2.Text
                      + "',fax = '" + tBFax.Text
                      + "',email = '" + tBEmail.Text
                      + "' WHERE idFournisseur = " + idFournisseur;
            Console.WriteLine(requete);

            if (MaConnexion.ExecuteUpdate(connectionString, requete) == 1)
            {
                MessageBox.Show("Modification effectuée ", "Opération réussie", MessageBoxButtons.OK, MessageBoxIcon.None);
                this.Close();
            }
            else
            {
                MessageBox.Show("La modification a échoué", "Erreur de modification", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void ModifierFournisseur_Load(object sender, EventArgs e)
        {
            requete = "select * from fournisseur where idFournisseur = " + idFournisseur;
            dS = MaConnexion.ExecuteSelect(connectionString, requete);
            afficherClient();
        }

        private void afficherClient()
        {
            tBIdentifiant.Text = dS.Tables[0].Rows[0][0].ToString();
            tBRaisonSociale.Text = dS.Tables[0].Rows[0][1].ToString();
            tBSpécialité.Text = dS.Tables[0].Rows[0][2].ToString();
            tBAdresse.Text = dS.Tables[0].Rows[0][3].ToString();
            tBVille.Text = dS.Tables[0].Rows[0][4].ToString();
            tBWilaya.Text = dS.Tables[0].Rows[0][5].ToString();
            tBPays.Text = dS.Tables[0].Rows[0][6].ToString();
            tBRegistreDeCommerce.Text = dS.Tables[0].Rows[0][7].ToString();
            tBNIF.Text = dS.Tables[0].Rows[0][8].ToString();
            tBTél1.Text = dS.Tables[0].Rows[0][9].ToString();
            tBTél2.Text = dS.Tables[0].Rows[0][10].ToString();
            tBFax.Text = dS.Tables[0].Rows[0][11].ToString();
            tBEmail.Text = dS.Tables[0].Rows[0][12].ToString();
        }

    }
}
