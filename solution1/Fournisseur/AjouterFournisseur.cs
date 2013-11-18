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
    public partial class AjouterFournisseur : Form
    {
        string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["connectString1"].ConnectionString;
        string requete = null;

        public AjouterFournisseur()
        {
            InitializeComponent();
        }

        private void bAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bAjouter_Click(object sender, EventArgs e)
        {
            ajouterFournisseur();
        }

        private void ajouterFournisseur()
        {
            string messageErreur = controlSaisie();
            if (messageErreur == null) //pas d'erreur de saisie
            {
                requete = "INSERT INTO Fournisseur (nom,spécialité,adresse,ville,wilaya,pays,registreDeCommerce,NIF,Téléphone1,Téléphone2,fax,email,etat) VALUES ( '"
                          + tBRaisonSociale.Text + "', '"
                          + tBSpécialité.Text + "', '"
                          + tBAdresse.Text.Replace("'", "''") + "', '"
                          + tBVille.Text + "', '"
                          + tBPays.Text + "', '"
                          + tBWilaya.Text + "', '"
                          + tBRegistreDeCommerce.Text + "', '"
                          + tBNIF.Text + "', '"
                          + tBTél1.Text + "', '"
                          + tBTél2.Text + "', '"
                          + tBFax.Text + "', '"
                          + tBEmail.Text + "', 'Non supprimé');";
                if (MaConnexion.ExecuteUpdate(connectionString, requete) == 1)
                {
                    MessageBox.Show("Le Fournisseur est ajouté avec succès", "Opération réussie", MessageBoxButtons.OK, MessageBoxIcon.None);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("L'insertion a échoué", "Erreur d'insertion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
            else
            {
                MessageBox.Show(messageErreur, "Saisie incomplète ou erronée", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        string controlSaisie()
        {
            string messageErreur = null;
            if (tBRaisonSociale.Text != "") 

                if (tBEmail.Text != "") 
                     
                    if (tBRegistreDeCommerce.Text != "")

                        if (tBAdresse.Text != "")
                    
                             if(tBTél1.Text !="")
                        
            {

            }
            else
            {
                messageErreur = "Veuillez entrer tous les champs obligatoires";
            }
            return messageErreur;
        }




    }
}
