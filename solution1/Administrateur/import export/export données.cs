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
    public partial class export_données : UserControl
    {
        string connectionString = ConfigurationManager.ConnectionStrings["connectString1"].ConnectionString;
        public export_données()
        {
            InitializeComponent();
            string requete = "select name as NomTable from	[Inventaire BDD].sys.tables ";
            DataSet dataTable = MaConnexion.ExecuteSelect(connectionString, requete);

            //int count =DataTable.rows.cout-1;
            for (int i = 0; i < dataTable.Tables[0].Rows.Count; i++)
            {
                comboBox_export.Items.Add(dataTable.Tables[0].Rows[i][0]);

            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button_export_tt_Click(object sender, EventArgs e)
        {
            System.IO.Directory.CreateDirectory("C:\\Documents and Settings\\HOMME\\Mes documents\\Inventaire10");

            string requete = "select name as NomTable from	[Inventaire BDD].sys.tables ";
            DataSet nomTable = MaConnexion.ExecuteSelect(connectionString, requete);


            this.progressBar1.Value = 1;
            //this.timer1.Interval = 5;
            this.timer1.Start();
            this.timer1.Enabled = true;
            int nbligne = nomTable.Tables[0].Rows.Count;


            textBox_export.Text = "RAPPORT : ";

            //int count =DataTable.rows.cout-1;
            for (int i = 0; i < nomTable.Tables[0].Rows.Count; i++)
            {
                //comboBox1.Items.Add(dataTable.Tables[0].Rows[i][0]);

                string table = nomTable.Tables[0].Rows[i][0].ToString();


                this.progressBar1.Value++;
                progressBar1.Maximum = nbligne + 1;
                if (progressBar1.Value == nbligne + 1)
                {

                    timer1.Stop();
                }


                string mydocpath =Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                string dossier = mydocpath + "\\Inventaire10";
                StringBuilder sb = new StringBuilder();

                foreach (string txtName in Directory.EnumerateFiles(dossier, "*.csv"))
                {
                    using (StreamReader sr = new StreamReader(txtName))
                    {
                        sb.Append(sr.ReadToEnd());

                    }

                }


                using (StreamWriter outfile = new StreamWriter(dossier + @"\"+table.Trim() + @".csv"))
              

                {
                    outfile.Write(sb.ToString());
                   // MessageBox.Show(table.Trim() + @".csv  // sb "+ sb);
                }

                string requete2 = "select * from "+table;
               // MessageBox.Show(requete2);

                DataSet dataTable = MaConnexion.ExecuteSelect(connectionString, requete2);
                if (dataTable != null)
                {

                    int lg = 0;
                    using (StreamWriter StreamWriter = new StreamWriter(dossier + @"\"+table+@".csv"))
                    {
                        foreach (DataRow categorie_bien in dataTable.Tables[0].Rows)
                        {
                            string requete1 = "SELECT count(COLUMN_NAME) FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME='" + table + "'";
                            DataSet nbcolonne = MaConnexion.ExecuteSelect(connectionString, requete1);
                            int nbcol = int.Parse(nbcolonne.Tables[0].Rows[0][0].ToString());
                            string ligne = null;

                            for (int m = 0; m < nbcol-1; m++)
                            {
                                ligne = ligne + categorie_bien[m].ToString().Trim() + ";";
                                //MessageBox.Show("ligne " + ligne);
                            }
                            ligne = ligne + categorie_bien[nbcol - 1].ToString().Trim();
                            StreamWriter.WriteLine(ligne);
                            lg++;
                        }
                    }
                    textBox_export.Text += "\r\nl'exportation des donnéees de la table Catégorie bien est efféctue avec succé \r\nle nombre de ligne de donée est de " + lg+"\r\n";
                }
                else
                {
                    textBox_export.Text += "ERREUR:\r\nla table Catégorie bien est vide ";
                }





            }
        }

        private void button1_Click(object sender, EventArgs e)
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
       
                string table = comboBox_export.Text.ToString().Trim();
                using (StreamWriter outfile =new StreamWriter(mydocpath + @"\"+table +@".csv"))
                {
                    outfile.Write(sb.ToString());
                }

                string requete = "select * from "+table;
                DataSet dataTable = MaConnexion.ExecuteSelect(connectionString, requete);



                this.progressBar1.Value = 1;
                //this.timer1.Interval = 5;
                this.timer1.Start();
                this.timer1.Enabled = true;

                int nbligne = dataTable.Tables[0].Rows.Count;
                //MessageBox.Show(nbligne.ToString());
             if (dataTable != null)
                {
                    int lg = 0;
                    using (StreamWriter StreamWriter = new StreamWriter(mydocpath + @"\"+table+@".csv"))
                    {
                        foreach (DataRow categorie_bien in dataTable.Tables[0].Rows)
                        {
                            string requete1 = "SELECT count(COLUMN_NAME) FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME='" + table + "'";
                            DataSet nbcolonne = MaConnexion.ExecuteSelect(connectionString, requete1);
                            int nbcol = int.Parse(nbcolonne.Tables[0].Rows[0][0].ToString());
                            string ligne = null;
                            //MessageBox.Show(nbcol+"//"+table);

                            for (int k = 0; k < nbcol - 1; k++)
                            {
                                ligne = ligne + categorie_bien[k].ToString().Trim() + ";";
                                //MessageBox.Show("ligne " + ligne);
                            }
                            ligne = ligne + categorie_bien[nbcol - 1].ToString().Trim();
                            StreamWriter.WriteLine(ligne);
                            lg++;



                            this.progressBar1.Value++;
                            progressBar1.Maximum = nbligne + 1;
                            if (progressBar1.Value == nbligne + 1)
                            {

                                timer1.Stop();
                            }

                        }
                    }
                    if (lg != 0)
                    {
                        textBox_export.Text = "RAPPORT: \r\nL'exportation des donnéees de la table Catégorie bien est efféctue avec succé \r\nle nombre de ligne de donée est de " + lg;
                    }
                    else
                    {
                        textBox_export.Text = "Rapport:\r\nLa table catégorie bien est vide ";
                    }
                }
                else
                {
                    textBox_export.Text = "ERREUR:\r\nLa catégorie bien n'existe pas dans la base de donnée ";
                }
            



        }
    }
}
