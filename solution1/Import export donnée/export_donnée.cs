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
    class exporte_donnée
    {
        string connectionString = ConfigurationManager.ConnectionStrings["connectString1"].ConnectionString;


        //*** exporter les données vers un fichier CSV par table 
        public void export_table(TextBox textBox_export, ComboBox comboBox_export)
        {
            string mydocpath =
                 Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            StringBuilder sb = new StringBuilder();

            foreach (string txtName in Directory.EnumerateFiles(mydocpath, "*.csv"))
            {
                using (StreamReader sr = new StreamReader(txtName))
                {
                 sb.Append(sr.ReadToEnd());
                 
                }
            }


            //*********** export categorie bien 
            if (comboBox_export.Text.ToString().Substring(7).Trim() == "Catégorie Bien")
            {
                using (StreamWriter outfile =
                    new StreamWriter(mydocpath + @"\categorie bien.csv"))
                {
                    outfile.Write(sb.ToString());
                }

                string requete = "select * from CategorieBien ";
                DataSet dataTable = MaConnexion.ExecuteSelect(connectionString, requete);
                if (dataTable != null)
                {
                    int lg = 0;
                    using (StreamWriter StreamWriter = new StreamWriter(mydocpath + @"\categorie bien.csv"))
                    {
                        foreach (DataRow categorie_bien in dataTable.Tables[0].Rows)
                        {
                            
                            StreamWriter.WriteLine(categorie_bien[0].ToString().Trim() + ";" + categorie_bien[1].ToString().Trim() + ";" + categorie_bien[2].ToString().Trim() + ";" + categorie_bien[3].ToString().Trim());
                            lg++;
                        }
                    }
                    if(lg!=0)
                    {
                        textBox_export.Text = "RAPPORT: \r\nL'exportation des donnéees de la table Catégorie bien est efféctue avec succé \r\nle nombre de ligne de donée est de " + lg;
                    }else{
                        textBox_export.Text = "Rapport:\r\nLa table catégorie bien est vide ";
                    }
                }
                else
                {
                    textBox_export.Text = "ERREUR:\r\nLa catégorie bien n'existe pas dans la base de donnée ";
                }
            }


            //******** export bien 
            if (comboBox_export.Text.ToString().Substring(7).Trim() == "Bien")
            {
                using (StreamWriter outfile =
                    new StreamWriter(mydocpath + @"\bien.csv"))
                {
                    outfile.Write(sb.ToString());
                }

                string requete = "select * from Bien ";
                DataSet dataTable = MaConnexion.ExecuteSelect(connectionString, requete);
                if (dataTable != null)
                {
                    int lg = 0;
                    using (StreamWriter StreamWriter = new StreamWriter(mydocpath + @"\bien.csv"))
                    {
                        foreach (DataRow bien in dataTable.Tables[0].Rows)
                        {
                            StreamWriter.WriteLine(bien[0].ToString().Trim() + ";" + bien[1].ToString().Trim() + ";" + bien[2].ToString().Trim() + ";" + bien[3].ToString().Trim() + ";" + bien[4].ToString().Trim() + ";" + bien[5].ToString().Trim() + ";" + bien[6].ToString().Trim() + ";" + bien[7].ToString().Trim() + ";" + bien[8].ToString().Trim() + ";" + bien[9].ToString().Trim() + ";" + bien[10].ToString().Trim() + ";" + bien[11].ToString().Trim() + ";" + bien[12].ToString().Trim() + ";" + bien[13].ToString().Trim());
                            lg++;
                        }
                    }
                    if (lg != 0)
                    {
                        textBox_export.Text = "RAPPORT: \r\nL'exportation des donnéees de la table bien est efféctue avec succé \r\nle nombre de ligne de donée est de " + lg;
                    }
                    else
                    {
                        textBox_export.Text = "Rapport:\r\nLa table bien est vide ";
                    }
                }
                else
                {
                    textBox_export.Text = "ERREUR:\r\nLa table bien n'existe pas dans la base de donnée";
                }
            }


            // ********* export Site
            if (comboBox_export.Text.ToString().Substring(7).Trim() == "Site")
            {
                using (StreamWriter outfile =
                    new StreamWriter(mydocpath + @"\site.csv"))
                {
                    outfile.Write(sb.ToString());
                }

                string requete = "select * from site ";
                DataSet dataTable = MaConnexion.ExecuteSelect(connectionString, requete);
                if (dataTable != null)
                {
                    int lg = 0;
                    using (StreamWriter StreamWriter = new StreamWriter(mydocpath + @"\site.csv"))
                    {
                        foreach (DataRow site in dataTable.Tables[0].Rows)
                        {
                            StreamWriter.WriteLine(site[0].ToString().Trim() + ";" + site[1].ToString().Trim() + ";" + site[2].ToString().Trim() + ";" + site[3].ToString().Trim());
                            lg++;
                        }
                    }
                    if (lg != 0)
                    {
                        textBox_export.Text = "RAPPORT: \r\nL'exportation des donnéees de la table Site est efféctue avec succé \r\nle nombre de ligne de donée est de " + lg;
                    }
                    else
                    {
                        textBox_export.Text = "Rapport:\r\nLa table Site est vide ";
                    }
                }
                else
                {
                    textBox_export.Text = "ERREUR:\r\nLa table site n'existe pas dans la base de donnée ";
                }
            }



            // ***************** emplacement
            if (comboBox_export.Text.ToString().Substring(7).Trim() == "Emplacement")
            {
                using (StreamWriter outfile =
                    new StreamWriter(mydocpath + @"\emplacement.csv"))
                {
                    outfile.Write(sb.ToString());
                }

                string requete = "select * from Emplacement ";
                DataSet dataTable = MaConnexion.ExecuteSelect(connectionString, requete);
                if (dataTable != null)
                {
                    int lg = 0;
                    using (StreamWriter StreamWriter = new StreamWriter(mydocpath + @"\emplacement.csv"))
                    {
                        foreach (DataRow emplacement in dataTable.Tables[0].Rows)
                        {
                            StreamWriter.WriteLine(emplacement[0].ToString().Trim() + ";" + emplacement[1].ToString().Trim() + ";" + emplacement[2].ToString().Trim() + ";" + emplacement[3].ToString().Trim() + ";" + emplacement[4].ToString().Trim() + ";" + emplacement[5].ToString().Trim() + ";" + emplacement[6].ToString().Trim() + ";" + emplacement[7].ToString().Trim() + ";" + emplacement[8].ToString().Trim());
                            lg++;
                        }
                    }
                    if (lg != 0)
                    {
                        textBox_export.Text = "RAPPORT: \r\nL'exportation des donnéees de la table Emplacement est efféctue avec succé \r\nle nombre de ligne de donée est de " + lg;
                    }
                    else
                    {
                        textBox_export.Text = "Rapport:\r\nLa table Emplacement est vide ";
                    }
                }
                else
                {
                    textBox_export.Text = "ERREUR:\r\nLa table emplacement n'existe pas dans la base de donnée";
                }
            }



            if (comboBox_export.Text.ToString().Substring(7).Trim() == "Se Trouve Bien")
            {
                using (StreamWriter outfile =
                    new StreamWriter(mydocpath + @"\trouve_bien.csv"))
                {
                    outfile.Write(sb.ToString());
                }

                string requete = "select * from SeTrouveB ";
                DataSet dataTable = MaConnexion.ExecuteSelect(connectionString, requete);
                if (dataTable != null)
                {
                    int lg = 0;
                    using (StreamWriter StreamWriter = new StreamWriter(mydocpath + @"\trouve_bien.csv"))
                    {
                        foreach (DataRow strouve in dataTable.Tables[0].Rows)
                        {
                            StreamWriter.WriteLine(strouve[0].ToString().Trim() + ";" + strouve[1].ToString().Trim() + ";" + strouve[2].ToString().Trim() + ";" + strouve[3].ToString().Trim() + ";" + strouve[4].ToString().Trim());
                            lg++;
                        }
                    }
                    if (lg != 0)
                    {
                        textBox_export.Text = "RAPPORT: \r\nL'exportation des donnéees de la table Se Trouve Bien est efféctue avec succé \r\nle nombre de ligne de donée est de " + lg;
                    }
                    else
                    {
                        textBox_export.Text = "Rapport:\r\nLa table Se Trouve Bien est vide ";
                    }
                }
                else
                {
                    textBox_export.Text = "ERREUR:\r\nLa table se trouve bien n'existe pas dans la base de donnée ";
                }
            }
        }



        //**** exportation de toute la bnase de donnée
        public void export_base(TextBox textBox_export)
        {
            string mydocpath =
                         Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            StringBuilder sb = new StringBuilder();

            foreach (string txtName in Directory.EnumerateFiles(mydocpath, "*.csv"))
            {
                using (StreamReader sr = new StreamReader(txtName))
                {
                   sb.Append(sr.ReadToEnd());
          
                }

            }


            using (StreamWriter outfile =
                new StreamWriter(mydocpath + @"\categorie bien.csv"))
            {
                outfile.Write(sb.ToString());
            }

            string requete = "select * from CategorieBien ";
            DataSet dataTable = MaConnexion.ExecuteSelect(connectionString, requete);
            if (dataTable != null)
            {
                int lg = 0;
                using (StreamWriter StreamWriter = new StreamWriter(mydocpath + @"\categorie bien.csv"))
                {
                    foreach (DataRow categorie_bien in dataTable.Tables[0].Rows)
                    {
                        StreamWriter.WriteLine(categorie_bien[0].ToString().Trim() + ";" + categorie_bien[1].ToString().Trim() + ";" + categorie_bien[2].ToString().Trim() + ";" + categorie_bien[3].ToString().Trim());
                        lg++;
                    }
                }
                textBox_export.Text += "RAPPORT: \r\nl'exportation des donnéees de la table Catégorie bien est efféctue avec succé \r\nle nombre de ligne de donée est de " + lg;
            }
            else
            {
                textBox_export.Text += "ERREUR:\r\nla table Catégorie bien est vide ";
            }


            string mydocpath2 =
                 Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            StringBuilder sb2 = new StringBuilder();

            foreach (string txtName in Directory.EnumerateFiles(mydocpath2, "*.csv"))
            {
                using (StreamReader sr2 = new StreamReader(txtName))
                {
                    sb2.Append(sr2.ReadToEnd());
                }

            }
            using (StreamWriter outfile =
                new StreamWriter(mydocpath2 + @"\bien.csv"))
            {
                outfile.Write(sb2.ToString());
            }

            string requete2 = "select * from Bien ";
            DataSet dataTable2 = MaConnexion.ExecuteSelect(connectionString, requete2);
            if (dataTable2 != null)
            {
                int lg = 0;
                using (StreamWriter StreamWriter = new StreamWriter(mydocpath2 + @"\bien.csv"))
                {
                    foreach (DataRow bien in dataTable2.Tables[0].Rows)
                    {
                        StreamWriter.WriteLine(bien[0].ToString().Trim() + ";" + bien[1].ToString().Trim() + ";" + bien[2].ToString().Trim() + ";" + bien[3].ToString().Trim() + ";" + bien[4].ToString().Trim() + ";" + bien[5].ToString().Trim() + ";" + bien[6].ToString().Trim() + ";" + bien[7].ToString().Trim() + ";" + bien[8].ToString().Trim() + ";" + bien[9].ToString().Trim() + ";" + bien[10].ToString().Trim() + ";" + bien[11].ToString().Trim() + ";" + bien[12].ToString().Trim() + ";" + bien[13].ToString().Trim());
                        lg++;
                    }
                }
                textBox_export.Text += "RAPPORT: \r\nl'exportation des donnéees de la table bien est efféctue avec succé \r\nle nombre de ligne de donée est de " + lg;
            }
            else
            {
                textBox_export.Text += "ERREUR:\r\nla table bien est vide ";
            }




            string mydocpath3 =
             Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            StringBuilder sb3 = new StringBuilder();

            foreach (string txtName in Directory.EnumerateFiles(mydocpath3, "*.csv"))
            {
                using (StreamReader sr3 = new StreamReader(txtName))
                {
                    sb3.Append(sr3.ReadToEnd());
                }

            }
            using (StreamWriter outfile =
                new StreamWriter(mydocpath3 + @"\site.csv"))
            {
                outfile.Write(sb3.ToString());
            }

            string requete3 = "select * from site ";
            DataSet dataTable3 = MaConnexion.ExecuteSelect(connectionString, requete3);
            if (dataTable3 != null)
            {
                int lg = 0;
                using (StreamWriter StreamWriter = new StreamWriter(mydocpath3 + @"\site.csv"))
                {
                    foreach (DataRow site in dataTable3.Tables[0].Rows)
                    {
                        StreamWriter.WriteLine(site[0].ToString().Trim() + ";" + site[1].ToString().Trim() + ";" + site[2].ToString().Trim() + ";" + site[3].ToString().Trim());
                        lg++;
                    }
                }
                textBox_export.Text += "RAPPORT: \r\nl'exportation des donnéees de la table site est efféctue avec succé \r\nle nombre de ligne de donée est de " + lg;
            }
            else
            {
                textBox_export.Text += "ERREUR:\r\nla table site est vide ";
            }



            string mydocpath4 =
             Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            StringBuilder sb4 = new StringBuilder();

            foreach (string txtName in Directory.EnumerateFiles(mydocpath4, "*.csv"))
            {
                using (StreamReader sr4 = new StreamReader(txtName))
                {
                    //sb.AppendLine(txtName.ToString());
                    //sb.AppendLine("= = = = = =");
                    sb4.Append(sr4.ReadToEnd());
                    //  sb.AppendLine();
                    //sb.AppendLine();
                }

            }
            using (StreamWriter outfile =
                new StreamWriter(mydocpath4 + @"\emplacement.csv"))
            {
                outfile.Write(sb4.ToString());
            }

            string requete4 = "select * from Emplacement ";
            DataSet dataTable4 = MaConnexion.ExecuteSelect(connectionString, requete4);
            if (dataTable4 != null)
            {
                int lg = 0;
                using (StreamWriter StreamWriter = new StreamWriter(mydocpath4 + @"\emplacement.csv"))
                {
                    foreach (DataRow emplacement in dataTable4.Tables[0].Rows)
                    {
                        StreamWriter.WriteLine(emplacement[0].ToString().Trim() + ";" + emplacement[1].ToString().Trim() + ";" + emplacement[2].ToString().Trim() + ";" + emplacement[3].ToString().Trim() + ";" + emplacement[4].ToString().Trim() + ";" + emplacement[5].ToString().Trim() + ";" + emplacement[6].ToString().Trim() + ";" + emplacement[7].ToString().Trim() + ";" + emplacement[8].ToString().Trim());
                        lg++;
                    }
                }
                textBox_export.Text += "RAPPORT: \r\nl'exportation des donnéees de la table emplacement est efféctue avec succé \r\nle nombre de ligne de donée est de " + lg;
            }
            else
            {
                textBox_export.Text += "ERREUR:\r\nla table emplacement est vide ";
            }


            string mydocpath5 =
         Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            StringBuilder sb5 = new StringBuilder();

            foreach (string txtName in Directory.EnumerateFiles(mydocpath, "*.csv"))
            {
                using (StreamReader sr5 = new StreamReader(txtName))
                {
                    sb5.Append(sr5.ReadToEnd());
                }

            }
            using (StreamWriter outfile =
                new StreamWriter(mydocpath5 + @"\trouve_bien.csv"))
            {
                outfile.Write(sb5.ToString());
            }

            string requete5 = "select * from SeTrouveB ";
            DataSet dataTable5 = MaConnexion.ExecuteSelect(connectionString, requete5);
            if (dataTable5 != null)
            {
                int lg = 0;
                using (StreamWriter StreamWriter = new StreamWriter(mydocpath5 + @"\trouve_bien.csv"))
                {
                    foreach (DataRow strouve in dataTable5.Tables[0].Rows)
                    {
                        StreamWriter.WriteLine(strouve[0].ToString().Trim() + ";" + strouve[1].ToString().Trim() + ";" + strouve[2].ToString().Trim() + ";" + strouve[3].ToString().Trim() + ";" + strouve[4].ToString().Trim());
                        lg++;
                    }
                }
                textBox_export.Text += "RAPPORT: \r\nl'exportation des donnéees de la table se toruve bien est efféctue avec succé \r\nle nombre de ligne de donée est de " + lg;
            }
            else
            {
                textBox_export.Text += "ERREUR:\r\nla table se trouve bien est vide ";
            }
        }

    }
}
