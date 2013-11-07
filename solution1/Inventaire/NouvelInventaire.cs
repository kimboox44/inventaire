using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.IO;

namespace solution1
{
    public partial class NouvelInventaire : Form
    {
        Timer time;
        string connectionString = ConfigurationManager.ConnectionStrings["connectString1"].ConnectionString;
        MDIParent parent = null;
        int a;

   
        public NouvelInventaire(MDIParent parent)
        {
            InitializeComponent();
            this.parent = parent;


            Bitmap b = new Bitmap(40, 40);
           // Bitmap b2 = new Bitmap(40, 40);
            Graphics g = Graphics.FromImage((Image)b);
          //Graphics g2 = Graphics.FromImage((Image)b);

                       g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;

                        g.DrawImage(importer.Image, 0, 0, 30, 30);
                        g.Dispose(); 
            Image myResizedImg = (Image)b;
                        //put the resized image back to the button and change toolstrip's 
                       importer.Image = myResizedImg;
                       //bAnnuler.Image = myResizedImg;
            
                      /* g2.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                       g2.DrawImage(bAnnuler.Image, 0, 0, 40, 40);
                       g2.Dispose(); Image size1 = (Image)b;
                       bAnnuler.Image = size1;*/
        }

        private void bAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }
       
        
            public int nbligne = 0;
         

        private void bOK_Click(object sender, EventArgs e)
        {
            if (tBDesigInventaire.Text.Trim() != "")
            {
                string requete = "INSERT INTO Inventaire (UIdInventaire ,DesigInventaire ,DateInventaire ,etat,type,caract) VALUES (NEWID(), '" +
                                  tBDesigInventaire.Text + "', '" + DateTime.Now.ToString("dd/MM/yyyy H:m:s") + "', 'Valide','"+type.Text.ToString()+"','En cours');";



                if (MaConnexion.ExecuteUpdate(connectionString, requete) == 1)
                {
                    string requete_id_inventaire = "select UIdInventaire from Inventaire where DateInventaire=(SELECT MAX(DateInventaire)FROM Inventaire)";
                    DataSet id_inventaire = MaConnexion.ExecuteSelect(connectionString, requete_id_inventaire);
                    string id_invent = id_inventaire.Tables[0].Rows[0][0].ToString();

                    if (textBoxImporter.Text != "")
                    {
                        string[] Tligne = new string[100]; // tableau qui va contenir les sous-chaines extraites d'une ligne.
                        char[] splitter = { ';' }; // délimiteur du fichier texte
                        string fic_serveur = null; // chaine qui contient le nom du fichier csv à ouvrir

                        int i = 0;
                        int j = 0;
                        int lg = 0;
                        int erreur = 0;

                        fic_serveur = textBoxImporter.Text.ToString(); ;

                        if (System.IO.File.Exists(fic_serveur))
                        {
                            // On vérifie si le fichier existe avant de l'ouvrir
                            System.IO.StreamReader line = new System.IO.StreamReader(fic_serveur);
                            string ligne = null;
                            // on parcours les lignes jusqu'à la fin du fichier

                            StreamReader sr = new StreamReader(fic_serveur, Encoding.Default);

                            string buff = "a";
                            while (buff != null)
                            {
                                buff = sr.ReadLine();
                                if (buff == null) { break; }
                                else { nbligne++; }
                            }
                            //MessageBox.Show(nbligne.ToString());

                            this.progressBar1.Value = 1;
                            //this.timer1.Interval = 5;
                            this.timer1.Start();
                            this.timer1.Enabled = true;

                            string datedebut = DateTime.Now.ToString("dd/MM/yyyy H:m:s");
                            while ((ligne = line.ReadLine()) != null)
                            {

                                this.progressBar1.Value++;
                                progressBar1.Maximum = nbligne + 1;
                                if (progressBar1.Value == nbligne + 1)
                                {

                                    timer1.Stop();
                                }




                                Tligne = ligne.Split(splitter); // récupération de la premiere ligne du fichier

                                lg++;

                                DataSet ds = MaConnexion.ExecuteSelect(connectionString, "select IdEtat from Etat where DesigEtat='" + Tligne[3].Trim() + "'");
                                int idetat = int.Parse(ds.Tables[0].Rows[0][0].ToString());


                                string requete_insrt_setouvbien = "INSERT INTO SeTrouveB (UIdInventaire ,IdSite ,IdEmpla ,IdBien, IdEtat) VALUES ('" + id_invent + "', " +
                                Tligne[0] + ", " + Tligne[1].ToString() + ", '" + Tligne[2] + "',  " + idetat + " );";



                                if (MaConnexion.ExecuteUpdate(connectionString, requete_insrt_setouvbien) == 1)
                                {
                                    i++;
                                }
                                else
                                {
                                    j++;

                                }

                                //MessageBox.Show("text : "+Tligne[0]+","+Tligne[1] + ", " + Tligne[2] + ", " + Tligne[3] );




                            } // Fin while (ligne!=null)
                            line.Close();
                            a = 1;// Fermeture du fichier CSV
                            //string datefin = DateTime.Now.ToString("dd/MM/yyyy H:m:s");
                            MessageBox.Show("Inventaire est crée avec succée \n Le nombr de ligne insert dans la base de donnée est : " + i + "\n l'echec d'insertion est : " + j + "\n sur un total de ligne dans le fichier de : " + (i + j));
                        } // Fin If (file.exists)
                        else
                        {
                            MessageBox.Show("Echec de création d'inventaire");
                        }
  
                    }

                    
                    DataSet dSIdInventaire = MaConnexion.ExecuteSelect(connectionString, "select uidInventaire from inventaire where dateInventaire >= ALL (select dateInventaire from inventaire)");
                    if (rBATous.Checked)
                    {
                        DataSet dSidUtilisateur = MaConnexion.ExecuteSelect(connectionString, "select idUtilisateur from Utilisateur");
                        bool erreur = false;
                        foreach (DataRow row in dSidUtilisateur.Tables[0].Rows)
                        {
                            requete = "insert into inventorier values ('" + dSIdInventaire.Tables[0].Rows[0][0] +
                                              "', " + row[0].ToString();

                            if (MaConnexion.ExecuteUpdate(connectionString, requete) != 1)
                                erreur = true;
                        }
                        if (erreur)
                            MessageBox.Show("Echec dans l'attribution des privilèges", "Erreur de privilèges", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        DataSet dSidUtilisateur = MaConnexion.ExecuteSelect(connectionString, "select idUtilisateur from Utilisateur");
                        requete = "insert into inventorier values ('" + dSIdInventaire.Tables[0].Rows[0][0] +
                                              "', " + parent.idUtilisateur;

                        if (MaConnexion.ExecuteUpdate(connectionString, requete) != 1)
                            MessageBox.Show("L'inventaire est créé avec succès", "Opération réussie", MessageBoxButtons.OK, MessageBoxIcon.None);
                    }

                    this.Close();
                    //(new FormInventaire(null, dSIdInventaire.Tables[0].Rows[0][0].ToString())).Show();
                }
            }
            else 
            {
                MessageBox.Show("L'inventaire doit porter un nom", "Saisie incomplète", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
      
        }

        private void NouvelInventaire_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.DefaultExt = "mif";
            openFile.Filter = "Fichier CSV (*.csv)|*.csv";
            openFile.ShowDialog();
            if (openFile.FileNames.Length > 0)
            {
                foreach (string filename in openFile.FileNames)
                {
                    textBoxImporter.Text=filename;
                    //listBoxAdd.Items.Add(filename);
                }
            }
        }

        private void textBoxImporter_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.progressBar1.Value > 0)
            {
                //this.progressBar1.Value--;
              
            }
            else
            {
                this.timer1.Enabled = false;
            } 
        }

        
    }
}
