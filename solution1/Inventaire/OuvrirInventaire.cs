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
    public partial class OuvrirInventaire : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["connectString1"].ConnectionString;
        MDIParent mDIParent = null;
        string requete = null;

        struct structInventaire
        {
            string uidInventaire;
            string desigInventaire;
            string dateInventaire;
            public structInventaire(string uidInventaire, string desigInventaire, string dateInventaire) { this.uidInventaire = uidInventaire; this.desigInventaire = desigInventaire; this.dateInventaire = dateInventaire; }
            public string UidInventaire
            {
                get { return uidInventaire; }
            }
            public string DesigInventaire
            {
                get { return desigInventaire; }
            }
            public string DateInventaire
            {
                get { return dateInventaire; }
            }
        }
        
        public OuvrirInventaire(MDIParent parent)
        {
            InitializeComponent();
            this.mDIParent = parent;

            Bitmap b = new Bitmap(40, 40);
            Graphics g = Graphics.FromImage((Image)b);
            //Graphics g2 = Graphics.FromImage((Image)b);

                       g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;

                        g.DrawImage(bOuvrir.Image, 0, 0, 40, 40);
                        g.Dispose(); Image myResizedImg = (Image)b;
                        //put the resized image back to the button and change toolstrip's 
                       bOuvrir.Image = myResizedImg;

        }

        private void lBinventaire_SelectedIndexChanged(object sender, EventArgs e)
        {   
            dateTimePicker1.Text = ((structInventaire)lBinventaire.SelectedItem).DateInventaire;            
            tSSLDateInventaire.Text = "Date création d'inventaire : "+dateTimePicker1.Text;
        }

        private void OuvrirInventaire_Load(object sender, EventArgs e)
        {
            ouvrir_inventaire(requete = "Select * from inventaire where etat = 'Valide' order by DateInventaire");
        }
        private void type_SelectedIndexChanged(object sender, EventArgs e)
        {
            charger_inventaire();
        }
        private void caract_SelectedIndexChanged(object sender, EventArgs e)
        {
            charger_inventaire();
        }


        private void lBinventaire_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            bOuvrir.PerformClick();               
        }

        private void bGénérer_Click(object sender, EventArgs e)
        {
            string uidInventaire = ((structInventaire)lBinventaire.SelectedItem).UidInventaire;
            FormInventaire formInventaire = new FormInventaire(mDIParent, uidInventaire);
            formInventaire.MdiParent = this.MdiParent;
            formInventaire.Text = ((structInventaire)lBinventaire.SelectedItem).DesigInventaire;            
            formInventaire.Show();            
            this.Close();
        }



        private void ouvrir_inventaire(string req)
        {
            requete = "select Administrateur from Utilisateur where idUtilisateur = " + mDIParent.idUtilisateur;
            DataSet dSUtilisateur = MaConnexion.ExecuteSelect(connectionString, requete);

            DataSet dSInventaires = null;

            
            dSInventaires = MaConnexion.ExecuteSelect(connectionString, req);


            lBinventaire.Items.Clear();

            if (dSInventaires != null)
            {
                foreach (DataRow row in dSInventaires.Tables[0].Rows)
                {
                    structInventaire str = new structInventaire(row[0].ToString(), row[1].ToString(), row[2].ToString());
                    
                    lBinventaire.Items.Add(str);
                }
            }
            else
            { MessageBox.Show("Aucun inventaire créé", "Inventaire", MessageBoxButtons.OK, MessageBoxIcon.Information); }

            try
            {
                lBinventaire.SelectedIndex = 0;
            }
            catch (Exception) { }
        }

        private void charger_inventaire()
        {
            if (caract.Text.ToString() == "" && type.Text.ToString() == "")
            {
                ouvrir_inventaire(requete = "Select * from inventaire where etat = 'Valide'  order by DateInventaire");
            }
            else
            {
                if (caract.Text.ToString() == "")
                {
                    ouvrir_inventaire(requete = "Select * from inventaire where etat = 'Valide' and type='" + type.Text.ToString() + "' order by DateInventaire");
                }
                else
                {
                    if (type.Text.ToString() == "")
                    {
                        ouvrir_inventaire(requete = "Select * from inventaire where etat = 'Valide' and caract='" + caract.Text.ToString() + "' order by DateInventaire");
                    }
                    else
                    {
                        ouvrir_inventaire(requete = "Select * from inventaire where etat = 'Valide' and type='" + type.Text.ToString() + "' and caract='" + caract.Text.ToString() + "' order by DateInventaire");
                    }


                }
            }
        }

 
    }
}
