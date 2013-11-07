using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;


namespace solution1.Prenom.import_export
{
  
    public partial class import_tab : UserControl
    {
        string connectionString = ConfigurationManager.ConnectionStrings["connectString1"].ConnectionString;
        public import_tab()
        {
            InitializeComponent();

            string requete = "select name as NomTable from	[Inventaire BDD].sys.tables ";
            DataSet dataTable = MaConnexion.ExecuteSelect(connectionString, requete);

            //int count =DataTable.rows.cout-1;
            for (int i = 0; i < dataTable.Tables[0].Rows.Count; i++)
            {
                comboBox1.Items.Add(dataTable.Tables[0].Rows[i][0]);

            }
        }

        private void import_tab_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button_importation_Click(object sender, EventArgs e)
        {


            if (textBoximpor_table.Text != "")
            {

                string[] Tligne = new string[100]; // tableau qui va contenir les sous-chaines extraites d'une ligne.
                char[] splitter = { ';' }; // délimiteur du fichier texte
                string fic_serveur = null; // chaine qui contient le nom du fichier csv à ouvrir

                int i = 0;
                int j = 0;
                int lg = 0;
                int erreur = 0;

                fic_serveur = textBoximpor_table.Text.ToString(); ;

                if (System.IO.File.Exists(fic_serveur))
                {
                    // On vérifie si le fichier existe avant de l'ouvrir
                    System.IO.StreamReader line = new System.IO.StreamReader(fic_serveur);
                    string ligne = null;
                    // on parcours les lignes jusqu'à la fin du fichier


                    //******** se trouve bien 
                    if (comboBox1.Text.ToString().Trim() == "Se Trouve Bien")
                    {

                        string datedebut = DateTime.Now.ToString("dd/MM/yyyy H:m:s");
                        textBoxjournal2.Text = datedebut + "\r\n";

                        while ((ligne = line.ReadLine()) != null)
                        {
                            Tligne = ligne.Split(splitter); // récupération de la premiere ligne du fichier

                            lg++;
                            string requete_insrt_setouvbien = "INSERT INTO SeTrouveB (UIdInventaire ,IdSite ,IdEmpla ,IdBien, IdEtat) VALUES ('" +
                            Tligne[0].ToString() + "', " + Tligne[1] + ", " + Tligne[2] + ", '" + Tligne[3].ToString() + "'," + Tligne[4] + ");";

                            if (MaConnexion.ExecuteUpdate(connectionString, requete_insrt_setouvbien) == 1)
                            {
                                i++;
                            }
                            else
                            {
                                j++;

                            }
                        } // Fin while (ligne!=null)
                        line.Close(); // Fermeture du fichier CSV

                        textBoxjournal2.Text += "nombre total de ligne dans le fichier est " + (i + j) + "\r\ninertion dans la base de " + i + " lignes dans la table Se trouve b \r\net " + j + " lignes echecd'insertion \r\n";
                        string datefin = DateTime.Now.ToString("dd/MM/yyyy H:m:s");
                        textBoxjournal2.Text += datefin;



                    }
                    else
                    {
                        textBoxjournal2.Clear();
                        textBoxjournal2.Text = "ERREUR :\r\nle fichier ne correspond pas a la table !!";
                    }


                    // ****** catégorie bien
                    if (comboBox1.Text.ToString().Trim() == "Catégorie Bien")
                    {

                        string datedebut = DateTime.Now.ToString("dd/MM/yyyy H:m:s");
                        textBoxjournal2.Text = datedebut + "\r\n";
                        while ((ligne = line.ReadLine()) != null)
                        {
                            Tligne = ligne.Split(splitter); // récupération de la premiere ligne du fichier

                            lg++;
                            string requete_insrt_setouvbien = "INSERT INTO CategorieBien (IdCategorieBienPere,IdAmort,DesigCategorieBien) VALUES (" +
                             Tligne[1] + ", " + Tligne[2].ToString() + ", '" + Tligne[3].ToString() + "');";

                            if (MaConnexion.ExecuteUpdate(connectionString, requete_insrt_setouvbien) == 1)
                            {
                                i++;
                            }
                            else
                            {
                                j++;

                            }
                        } // Fin while (ligne!=null)
                        line.Close(); // Fermeture du fichier CSV

                        textBoxjournal2.Text += "nombre total de ligne dans le fichier est " + (i + j) + "\r\n inertion dans la base de " + i + " lignes dans la table Catégorie bien \r\net " + j + " lignes echecd'insertion \r\n";
                        string datefin = DateTime.Now.ToString("dd/MM/yyyy H:m:s");
                        textBoxjournal2.Text += datefin;



                    }
                    else
                    {
                        textBoxjournal2.Clear();
                        textBoxjournal2.Text = "ERREUR :\r\nle fichier ne correspond pas a la table !!";
                    }


                    // *************** bien
                    if (comboBox1.Text.ToString().Trim() == "Bien")
                    {

                        string datedebut = DateTime.Now.ToString("dd/MM/yyyy H:m:s");
                        textBoxjournal2.Text = datedebut + "\r\n";
                        while ((ligne = line.ReadLine()) != null)
                        {
                            Tligne = ligne.Split(splitter); // récupération de la premiere ligne du fichier

                            lg++;
                            string requete_insrt_setouvbien = "INSERT INTO Bien (IdBien,IdCategorieBien,DesigBien,DateAcquisitionBien,Particularite,Prix,Photo,ancienCode,idFournisseur,numFacture,numSerie,marque,etat) VALUES ('" +
                            Tligne[0].ToString() + "', " + Tligne[1] + ", " + Tligne[2].ToString() + ", '" + Tligne[3].ToString() + "'," + Tligne[4].ToString() + "," + Tligne[5] + ",'" + Tligne[6].ToString() + "','" + Tligne[7].ToString() + "'," + Tligne[8] + "," + Tligne[9] + "," + Tligne[10] + "," + Tligne[11].ToString() + "," + Tligne[12].ToString() + ");";

                            if (MaConnexion.ExecuteUpdate(connectionString, requete_insrt_setouvbien) == 1)
                            {
                                i++;
                            }
                            else
                            {
                                j++;

                            }
                        } // Fin while (ligne!=null)
                        line.Close(); // Fermeture du fichier CSV

                        textBoxjournal2.Text += "nombre total de ligne dans le fichier est " + (i + j) + "\r\n inertion dans la base de " + i + " lignes dans la table Bien \r\net " + j + " lignes echecd'insertion \r\n";
                        string datefin = DateTime.Now.ToString("dd/MM/yyyy H:m:s");
                        textBoxjournal2.Text += datefin;



                    }
                    else
                    {
                        textBoxjournal2.Clear();
                        textBoxjournal2.Text = "ERREUR :\r\nle fichier ne correspond pas a la table !!";
                    }


                    //  ********* emplacement

                    if (comboBox1.Text.ToString().Trim() == "Emplacement")
                    {

                        string datedebut = DateTime.Now.ToString("dd/MM/yyyy H:m:s");
                        textBoxjournal2.Text = datedebut + "\r\n";
                        while ((ligne = line.ReadLine()) != null)
                        {
                            Tligne = ligne.Split(splitter); // récupération de la premiere ligne du fichier

                            lg++;
                            if (Tligne[6].ToString() == "")
                            {
                                Tligne[6] = "null";

                            }

                            if (Tligne[3].ToString() == "")
                            {
                                Tligne[3] = "null";

                            }



                            string requete_insrt_setouvbien = "INSERT INTO Emplacement (IdSite,IdSitePere ,IdEmplaPere ,DesigEmpla ,idEmplaComplet ,idResp ,abrevEmpla ,etatEmpla) VALUES (" +
                             Tligne[0] + ", " + Tligne[1] + ", " + Tligne[3] + ",'" + Tligne[4].ToString() + "','" + Tligne[5].ToString() + "'," + Tligne[6] + ",'" + Tligne[7].ToString() + "','" + Tligne[8].ToString() + "');";


                            if (MaConnexion.ExecuteUpdate(connectionString, requete_insrt_setouvbien) == 1)
                            {
                                i++;
                            }
                            else
                            {
                                j++;

                            }
                        } // Fin while (ligne!=null)
                        line.Close(); // Fermeture du fichier CSV

                        textBoxjournal2.Text += "nombre total de ligne dans le fichier est " + (i + j) + "\r\n inertion dans la base de " + i + " lignes dans la table Emplacement \r\net " + j + " lignes echecd'insertion \r\n";
                        string datefin = DateTime.Now.ToString("dd/MM/yyyy H:m:s");
                        textBoxjournal2.Text += datefin;



                    }
                    else
                    {
                        textBoxjournal2.Clear();
                        textBoxjournal2.Text = "ERREUR :\r\nle fichier ne correspond pas a la table !!";
                    }


                    // ***** site 


                    if (comboBox1.Text.ToString().Trim() == "Site")
                    {

                        string datedebut = DateTime.Now.ToString("dd/MM/yyyy H:m:s");
                        textBoxjournal2.Text = datedebut + "\r\n";
                        while ((ligne = line.ReadLine()) != null)
                        {
                            Tligne = ligne.Split(splitter); // récupération de la premiere ligne du fichier

                            lg++;
                          



                            string requete_insrt_setouvbien = "INSERT INTO Site  VALUES ('" +
                             Tligne[0].ToString() + "', " + Tligne[1] + ", '" + Tligne[2].ToString() + "');";


                            if (MaConnexion.ExecuteUpdate(connectionString, requete_insrt_setouvbien) == 1)
                            {
                                i++;
                            }
                            else
                            {
                                j++;

                            }
                        } // Fin while (ligne!=null)
                        line.Close(); // Fermeture du fichier CSV

                        textBoxjournal2.Text += "nombre total de ligne dans le fichier est " + (i + j) + "\r\n inertion dans la base de " + i + " lignes dans la table Site \r\net " + j + " lignes echecd'insertion \r\n";
                        string datefin = DateTime.Now.ToString("dd/MM/yyyy H:m:s");
                        textBoxjournal2.Text += datefin;



                    }
                    else
                    {
                        textBoxjournal2.Clear();
                        textBoxjournal2.Text = "ERREUR :\r\nle fichier ne correspond pas a la table !!";
                    }
                }
                else
                {
                    textBoxjournal2.Clear();
                    textBoxjournal2.Text = "ERREUR :\r\nLe fichier n'existe pas verfier le chemin !!";
                }
            }
            else
            {
                textBoxjournal2.Clear();
                textBoxjournal2.Text = "ERREUR :\r\nLe chemin du fichier a importer est vide !!";
            }






            /*
          //string requete = "insert into "+comboBox1.Text.ToString().Trim()+" values ('site general4',null,'Non Supprimé') ";
            //MessageBox.Show(requete);
        

            
            string[] Tligne = new string[100]; // tableau qui va contenir les sous-chaines extraites d'une ligne.
            char[] splitter = { ';' }; // délimiteur du fichier texte
            //string fic_serveur = null; // chaine qui contient le nom du fichier csv à ouvrir


            string fic_serveur = textBoximpor_table.Text.ToString();

            if (System.IO.File.Exists(fic_serveur))
            {
                // On vérifie si le fichier existe avant de l'ouvrir
                System.IO.StreamReader line = new System.IO.StreamReader(fic_serveur);
                string ligne = null;
                string req = null;
                // on parcours les lignes jusqu'à la fin du fichier
                while ((ligne = line.ReadLine()) != null)
                {

                    req = "insert into " + comboBox1.Text.ToString().Trim() + " values (";

                    Tligne = ligne.Split(splitter);
                    int i = 0;
                    int nb = Tligne.Length;
                    string requete = "exec sp_columns @table_name = 'site'";
                    DataSet table = MaConnexion.ExecuteSelect(connectionString, requete);
                   
                    
                    while (i<(Tligne.Length-1))
                    {
                        // récupération de la premiere ligne du fichier
                        //MessageBox.Show(Tligne[i]);

                        int type = int.Parse(table.Tables[0].Rows[i][4].ToString());
                        if (type == 4 || type==3)
                        {
                            req = req + Tligne[i] + ",";
                        }
                        if (type == 12)
                        {
                            req = req +"'"+ Tligne[i] + "',";
                        }
                        i++;
                    }
                    int typef = int.Parse(table.Tables[0].Rows[Tligne.Length - 1][4].ToString());
                    if (typef == 4 || typef == 3)
                    {
                        req = req + Tligne[Tligne.Length - 1] + ")";
                    }
                    if (typef == 12)
                    {
                        req = req + "'" + Tligne[Tligne.Length - 1] + "')";
                    }

                    
                    MessageBox.Show(req);
                    int result = MaConnexion.ExecuteUpdate(connectionString, req);
                    MessageBox.Show(result.ToString());
                }


            }


            //le type du champs 
           /* string requete = "exec sp_columns @table_name = 'site'";
            DataSet table = MaConnexion.ExecuteSelect(connectionString, requete);
              string type =  table.Tables[0].Rows[0][5].ToString();
            MessageBox.Show(type);*/
        }

        private void parcourir_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.DefaultExt = "csv";
            openFile.Filter = "Fichier CSV (*.csv)|*.csv";
            openFile.ShowDialog();
            if (openFile.FileNames.Length > 0)
            {
                foreach (string filename in openFile.FileNames)
                {
                    textBoximpor_table.Text = filename;
                    //listBoxAdd.Items.Add(filename);
                }
            }
        }
    }
}
