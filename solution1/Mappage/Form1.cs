using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;
using System.Collections.ObjectModel;
using System.Threading;

namespace solution1.Mappage
{
    public partial class Form1 : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["connectString1"].ConnectionString;
        public Form1()
        {
            InitializeComponent();

            string query = "SELECT table_name FROM information_schema.tables WHERE table_type='BASE TABLE'";
            DataSet dataTable = MaConnexion.ExecuteSelect(connectionString, query);
            if (dataTable != null)
            {
                foreach (DataRow dR in dataTable.Tables[0].Rows)
                {
                    
                    comboBox1.Items.Add(dR[0]);

                }
            }






        }


        struct structcolone
        {
            string colone;
            int idcolone;
            public structcolone(String Colone, int IdCol) { this.colone = Colone; this.idcolone = IdCol; }
            public string col
            {
                get { return colone; }
            }
            public int idcol
            {
                get { return idcolone; }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {


            OpenFileDialog openFile = new OpenFileDialog();
            openFile.DefaultExt = "csv";
            openFile.Filter = "Fichier CSV (*.csv)|*.csv";
            openFile.ShowDialog();
            if (openFile.FileNames.Length > 0)
            {
                foreach (string filename in openFile.FileNames)
                {
                    textBox_parcour.Text = filename;
                    //listBoxAdd.Items.Add(filename);
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataSet dSUtilisateur = MaConnexion.ExecuteSelect(connectionString, "SELECT   COLUMN_NAME, ORDINAL_POSITION FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME='"+comboBox1.Text.ToString()+"'");
            if (dSUtilisateur != null)
            {
                dataGridView1.Rows.Clear();
                foreach (DataRow row in dSUtilisateur.Tables[0].Rows)
                {

                    object[] newRow = new object[] { row[0].ToString()};
                    dataGridView1.Rows.Add(newRow);
                
                }


                string[] Tligne = new string[100]; // tableau qui va contenir les sous-chaines extraites d'une ligne.
                char[] splitter = { ';' }; // délimiteur du fichier texte
                string fic_serveur = null; // chaine qui contient le nom du fichier csv à ouvrir
                DataSet combox = new DataSet();

                int i = 0;
                int j = 0;
                int lg = 0;
                int erreur = 0;

                fic_serveur = textBox_parcour.Text.ToString();

                if (System.IO.File.Exists(fic_serveur))
                {
                    // On vérifie si le fichier existe avant de l'ouvrir
                    System.IO.StreamReader line = new System.IO.StreamReader(fic_serveur);
                    string ligne = null;

                    ligne = line.ReadLine();
                    Tligne = ligne.Split(splitter); // récupération de la premiere ligne du fichier

                    for (int n = 0; n < Tligne.Length; n++)
                    {
                         structcolone col = new structcolone("Colonne"+n, n);

                         Column3.Items.Add("Colonne"+n);
                        Column3.ValueMember = "colonne"+n;
                        //Column3.Items.(n);
                    }
                    line.Close(); // Fermeture du fichier CSV

                }
            }
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Importer_Click(object sender, EventArgs e)
        {
            string champ = "";
            string valeur ="";
            int[] nbcol = new int[dataGridView1.Rows.Count];
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                try
                {
                    string ch = dataGridView1.Rows[i].Cells[0].Value.ToString();
                    if (champ == "")
                    {
                        champ = champ + ch;
                    }
                    else
                    {
                        champ = champ +","+ ch;
                    }

                    string vl = dataGridView1.Rows[i].Cells[1].Value.ToString();
                    if (valeur == "")
                    {
                        valeur = valeur + "+Tligne[" + int.Parse(vl.Substring(7).ToString()) + "]+";
                    }else{
                        valeur = valeur + ",+Tligne[" + int.Parse(vl.Substring(7).ToString()) + "]+";
                    }

                    nbcol[i]=int.Parse(vl.Substring(7).ToString());
                    
                   
                }
                catch { }
            }

  
            //string requete_insrt = "INSERT INTO " + comboBox1.Text + " (" + champ + ") values ( "+valeur+")";
            //MessageBox.Show("la requete " + requete_insrt);

             string[] Tligne = new string[100]; // tableau qui va contenir les sous-chaines extraites d'une ligne.
                char[] splitter = { ';' }; // délimiteur du fichier texte
                string fic_serveur = null; // chaine qui contient le nom du fichier csv à ouvrir

                int succ = 0;
                int j = 0;
                int lg = 0;
                int erreur = 0;

                fic_serveur = textBox_parcour.Text.ToString(); ;
            
                if (System.IO.File.Exists(fic_serveur))
                {
                    // On vérifie si le fichier existe avant de l'ouvrir
                    System.IO.StreamReader line = new System.IO.StreamReader(fic_serveur);
                    string ligne = null;
                    // on parcours les lignes jusqu'à la fin du fichier

                        
                        while ((ligne = line.ReadLine()) != null)
                        {
                            Tligne = ligne.Split(splitter); // récupération de la premiere ligne du fichier
                            
                            lg++;


                            string str="";

                            for (int k = 0; k < nbcol.Length-1; k++)
                            {
                                if (str == "")
                                {
                                    str = str + Tligne[nbcol[k]];
                                }
                                else
                                {
                                    str = str + "," + Tligne[nbcol[k]];
                                }
                                
                            }

                            string requete_insrt = "INSERT INTO " + comboBox1.Text +" ("+champ + ") values ("+ str+")";
                            requete.Text = requete_insrt;
                            
                             if (MaConnexion.ExecuteUpdate(connectionString, requete_insrt) == 1)
                            {
                                succ++;
                            }
                            else
                            {
                                j++;

                            }
                        } // Fin while (ligne!=null)
                        line.Close(); // Fermeture du fichier CSV
                        MessageBox.Show("le nombre inset est de " + succ + "le nombre nn insert est de " + j);
                      
                    }
            
        }
    }
}
