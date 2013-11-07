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
    class vider_bdd
    {
        string connectionString = ConfigurationManager.ConnectionStrings["connectString1"].ConnectionString;


        public void parcour_fichier (TextBox parcour)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.DefaultExt = "csv";
            openFile.Filter = "Fichier CSV (*.csv)|*.csv";
            openFile.ShowDialog();
            if (openFile.FileNames.Length > 0)
            {
                foreach (string filename in openFile.FileNames)
                {
                    parcour.Text = filename;
                    //listBoxAdd.Items.Add(filename);
                }
            }
        }

        public void vider_bdd_tapbe(ComboBox comboBox_table, TextBox textBox_journal_bdd) 
        {
            if (comboBox_table.Text.ToString().Substring(7).Trim() == "Catégorie Bien")
            {
                string requete_sup = "delete from CategorieBien";
                if (MaConnexion.ExecuteUpdate(connectionString, requete_sup) != -1)
                {
                    textBox_journal_bdd.Text = "la table Catégorie bien est vidé ";
                }
                else
                {
                    textBox_journal_bdd.Text = "la table Catégorie bien n'a pas put etre vidé !! ";
                }
            }

            if (comboBox_table.Text.ToString().Substring(7).Trim() == "Bien")
            {
                string requete_sup = "delete from Bien";
                if (MaConnexion.ExecuteUpdate(connectionString, requete_sup) != -1)
                {
                    textBox_journal_bdd.Text = "la table bien est vidé ";
                }
                else
                {
                    textBox_journal_bdd.Text = "la table bien n'a pas put etre vidé !! ";
                }
            }

            if (comboBox_table.Text.ToString().Substring(7).Trim() == "Site")
            {
                string requete_sup = "delete from Site";
                if (MaConnexion.ExecuteUpdate(connectionString, requete_sup) != -1)
                {
                    textBox_journal_bdd.Text = "la table Site est vidé ";
                }
                else
                {
                    textBox_journal_bdd.Text = "la table Site n'a pas put etre vidé !! ";
                }
            }
            if (comboBox_table.Text.ToString().Substring(7).Trim() == "Emplacement")
            {
                string requete_sup = "delete from Emplacement";
                if (MaConnexion.ExecuteUpdate(connectionString, requete_sup) != -1)
                {
                    textBox_journal_bdd.Text = "la table Catégorie bien est vidé ";
                }
                else
                {
                    textBox_journal_bdd.Text = "la table Catégorie bien n'a pas put etre vidé !! ";
                }
            }
            if (comboBox_table.Text.ToString().Substring(7).Trim() == "Se Trouve Bien")
            {
                string requete_sup = "delete from SeTrouveB";
                if (MaConnexion.ExecuteUpdate(connectionString, requete_sup) != -1)
                {
                    textBox_journal_bdd.Text = "la table se trouve bien est vidé ";
                }
                else
                {
                    textBox_journal_bdd.Text = "la table Se Trouve Bien n'a pas put etre vidé !! ";
                }
            }
        }


        public void vider_toute_bdd(TextBox textBox_journal_bdd)
        {
            string requate_sup_total = "delete from Bien delete from CategorieBien delete from Emplacement delete from Site delete from SeTrouveB";
            if (MaConnexion.ExecuteUpdate(connectionString, requate_sup_total) != 1)
            {
                textBox_journal_bdd.Text = "la base de donnée est vidé complaintement ";
            }
            else
            {
                textBox_journal_bdd.Text = "interoption de l'instruction la base n'a pas put etre vidé ";
            }
        }
    }
}
