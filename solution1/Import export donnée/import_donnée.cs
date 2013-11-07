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


namespace solution1
{
    class import_donnée
    {
        string connectionString = ConfigurationManager.ConnectionStrings["connectString1"].ConnectionString;

        public void import_par_table(TextBox textBoximpor_table,TextBox textBoxjournal2,ComboBox comboBox1) 
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
                    if (comboBox1.Text.ToString().Substring(7).Trim() == "Se Trouve Bien")
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

                        textBoxjournal2.Text += "nombre total de ligne dans le fichier est " + (i + j) + "\r\n inertion dans la base de " + i + " lignes dans la table setrouveb \r\net " + j + " lignes echecd'insertion \r\n";
                        string datefin = DateTime.Now.ToString("dd/MM/yyyy H:m:s");
                        textBoxjournal2.Text += datefin;



                    }
                    else
                    {
                        textBoxjournal2.Clear();
                        textBoxjournal2.Text = "ERREUR :\r\nle fichier ne correspond pas a la table !!";
                    }


                    // ****** catégorie bien
                    if (comboBox1.Text.ToString().Substring(7).Trim() == "Catégorie Bien")
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

                        textBoxjournal2.Text += "nombre total de ligne dans le fichier est " + (i + j) + "\r\n inertion dans la base de " + i + " lignes dans la table setrouveb \r\net " + j + " lignes echecd'insertion \r\n";
                        string datefin = DateTime.Now.ToString("dd/MM/yyyy H:m:s");
                        textBoxjournal2.Text += datefin;



                    }
                    else
                    {
                        textBoxjournal2.Clear();
                        textBoxjournal2.Text = "ERREUR :\r\nle fichier ne correspond pas a la table !!";
                    }


                    // *************** bien
                    if (comboBox1.Text.ToString().Substring(7).Trim() == "Bien")
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

                        textBoxjournal2.Text += "nombre total de ligne dans le fichier est " + (i + j) + "\r\n inertion dans la base de " + i + " lignes dans la table setrouveb \r\net " + j + " lignes echecd'insertion \r\n";
                        string datefin = DateTime.Now.ToString("dd/MM/yyyy H:m:s");
                        textBoxjournal2.Text += datefin;



                    }
                    else
                    {
                        textBoxjournal2.Clear();
                        textBoxjournal2.Text = "ERREUR :\r\nle fichier ne correspond pas a la table !!";
                    }


                    //  ********* emplacement

                    if (comboBox1.Text.ToString().Substring(7).Trim() == "Emplacement")
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

                        textBoxjournal2.Text += "nombre total de ligne dans le fichier est " + (i + j) + "\r\n inertion dans la base de " + i + " lignes dans la table setrouveb \r\net " + j + " lignes echecd'insertion \r\n";
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
        }




        public void import_bdd_bloc(ComboBox comboBox_table, TextBox textBox_categorie_bien, TextBox textBoxjournal, TextBox textBox_bien, TextBox textBox_site, TextBox textBox_emplacement,TextBox textBox_setoruve_bien)
        {
            //textBoxjournal.ScrollToCaret();
            if (textBox_categorie_bien.Text != "")
            {
                string requete_insertion_bolc_categoriebien = "DBCC CHECKIDENT ('CategorieBien',RESEED,0) BULK INSERT CategorieBien FROM '" +
                                                    textBox_categorie_bien.Text + "'  WITH (FIELDTERMINATOR=';', ROWTERMINATOR='\n' ) update CategorieBien set IdCategorieBienPere=null where IdCategorieBienPere=0";
                if (MaConnexion.ExecuteUpdate(connectionString, requete_insertion_bolc_categoriebien) != -1)
                {
                    textBoxjournal.Text += "Insertion du fichier catégorie bien avec succé dan sla base de donnée \r\n\r\n";
                }
                else
                {
                    textBoxjournal.Text += "Le fichier " + textBox_categorie_bien.Text + " n'est pas put atre importer à la base de donnée \r\n\r\n";
                }
            }
            else
            {
                textBoxjournal.Text += "Le chemin du fichier catégorie bien est vide !! \r\n\r\n";
            }


            //       ***************************************
            if (textBox_bien.Text != "")
            {
                string requete_insertion_bloc_bien = "DBCC CHECKIDENT ('Bien',RESEED,0) BULK INSERT Bien FROM '" +
                    textBox_bien.Text + "' WITH (FIELDTERMINATOR=';', ROWTERMINATOR='\n' ) update Bien set etat='Non Supprimé'";

                if (MaConnexion.ExecuteUpdate(connectionString, requete_insertion_bloc_bien) != -1)
                {
                    textBoxjournal.Text += "Insertion du fichier bien avec succé dan sla base de donnée \r\n\r\n";
                }
                else
                {
                    textBoxjournal.Text += "Le fichier " + textBox_bien.Text + " n'est pas put atre importer à la base de donnée \r\n\r\n";
                }
            }
            else
            {
                textBoxjournal.Text += "Le chemin du fichier bien est vide !! \r\n\r\n";
            }

            //*********************************
            if (textBox_site.Text != "")
            {
                string requete_insertion_bloc_emplacement = "DBCC CHECKIDENT ('Site',RESEED,0) BULK INSERT Site FROM '" +
                                        textBox_site.Text + "' WITH (FIELDTERMINATOR=';', ROWTERMINATOR='\n' ) update Site set etatSite='Supprimé' where etatSite like 'SupprimÚ%' update Site set etatSite='Non Supprimé' where etatSite like 'Non supprimÚ%'";

                if (MaConnexion.ExecuteUpdate(connectionString, requete_insertion_bloc_emplacement) != -1)
                {
                    textBoxjournal.Text += "Insertion du fichier emplacement avec succé dan sla base de donnée \r\n\r\n";
                }
                else
                {
                    textBoxjournal.Text += "Le fichier " + textBox_site.Text + " n'est pas put atre importer à la base de donnée \r\n\r\n";
                }
            }
            else
            {
                textBoxjournal.Text += "Le chemin du fichier emplacment est vide !!\r\n\r\n";
            }


            //   **************************
            if (textBox_emplacement.Text != "")
            {
                string requete_insertion_bloc_emplacement = "DBCC CHECKIDENT ('Emplacement',RESEED,0) BULK INSERT Emplacement FROM '" + textBox_emplacement.Text + "' WITH (FIELDTERMINATOR=';', ROWTERMINATOR='\n' ) update Emplacement set etatEmpla='Non Supprimé'";

                if (MaConnexion.ExecuteUpdate(connectionString, requete_insertion_bloc_emplacement) != -1)
                {
                    textBoxjournal.Text += "Insertion du fichier emplacement avec succé dan sla base de donnée \r\n\r\n";
                }
                else
                {
                    textBoxjournal.Text += "Le fichier " + textBox_emplacement.Text + " n'est pas put atre importer à la base de donnée \r\n\r\n";
                }
            }
            else
            {
                textBoxjournal.Text += "Le chemin du fichier emplacment est vide !!\r\n\r\n";
            }

            //   **************************
            if (textBox_setoruve_bien.Text != "")
            {
                string requete_insertion_bloc_setrouvebien = "DBCC CHECKIDENT ('SeTrouveB',RESEED,0) BULK INSERT SeTrouveB FROM '" + textBox_setoruve_bien.Text + "' WITH (FIELDTERMINATOR=';', ROWTERMINATOR='\n' ) ";

                if (MaConnexion.ExecuteUpdate(connectionString, requete_insertion_bloc_setrouvebien) != -1)
                {
                    textBoxjournal.Text += "Insertion du fichier se touve bien avec succé dan sla base de donnée \r\n\r\n";
                }
                else
                {
                    textBoxjournal.Text += "Le fichier " + textBox_setoruve_bien.Text + " n'a pas put etre importer à la base de donnée \r\n\r\n";
                }
            }
            else
            {
                textBoxjournal.Text += "Le chemin du fichier setrouve bien est vide !! \r\n\r\n";
            }

        }
        
    }
}
