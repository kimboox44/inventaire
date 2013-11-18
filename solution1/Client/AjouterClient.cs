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
    public partial class AjouterClient : Form
    {
        string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["connectString1"].ConnectionString;
        string requete = null;

        public AjouterClient()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ajouterClient();
        }

        private void ajouterClient() 
        {
            string messageErreur = controlSaisie();
            if (messageErreur == null) //pas d'erreur de saisie
            {
                requete = "INSERT INTO Client (nom,spécialité,adresse,ville,wilaya,pays,registreDeCommerce,NIF,Téléphone1,Téléphone2,fax,email, etat) VALUES ( '"
                          + tBRaisonSociale.Text + "', '"
                          + tBSpécialité.Text + "', '"
                          + tBAdresse.Text.Replace("'", "''") + "', '"
                          + tBVille.Text + "', '"
                          
                          + tBWilaya.Text + "', '"
                          + tBPays.Text + "', '"
                          + tBRegistreDeCommerce.Text + "', '"
                          + tBNIF.Text + "', '"
                          + tBTél1.Text + "', '"
                          + tBTél2.Text + "', '"
                          + tBFax.Text + "', '"
                          + tBEmail.Text + "','Non supprimé');";
                
                Console.WriteLine(requete);
                if (MaConnexion.ExecuteUpdate(connectionString, requete) == 1)
                {
                    MessageBox.Show("Le client est ajouté avec succès", "Opération réussie", MessageBoxButtons.OK, MessageBoxIcon.None);
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

                if (tBAdresse.Text !="")

                    if (tBEmail.Text != "")

                        if (tBRegistreDeCommerce.Text !="")

                            if (tBTél1.Text !="")
            {
                
            }
            else
            {
                messageErreur = "Veuillez entrer tous les chapms obligatoires";
            }
            return messageErreur;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AjouterClient_Load(object sender, EventArgs e)
        {

        }

    }
}
