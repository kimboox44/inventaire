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
    public partial class vider_BDD : UserControl
    {
        string connectionString = ConfigurationManager.ConnectionStrings["connectString1"].ConnectionString;
        public vider_BDD()
        {
            InitializeComponent();
            string requete = "select name as NomTable from	[Inventaire BDD].sys.tables ";
            DataSet dataTable = MaConnexion.ExecuteSelect(connectionString, requete);

            //int count =DataTable.rows.cout-1;
            for (int i = 0; i < dataTable.Tables[0].Rows.Count; i++)
            {
                comboBox_table.Items.Add(dataTable.Tables[0].Rows[i][0]);

            }
        }

        private void button_vider_Click(object sender, EventArgs e)
        {
            string requete_sup = "delete from toute les table  " ;
            if (MaConnexion.ExecuteUpdate(connectionString, requete_sup) != -1)
            {
                //textBox_journal_bdd.Text = "la table " + table + " est vidé ";
            }
            else
            {
                //textBox_journal_bdd.Text = "la table " + table + " n'a pas put etre vidé !! ";
            }
        }

        private void button_vide_tab_Click(object sender, EventArgs e)
        {
            string table = comboBox_table.Text.ToString().Trim();
            string requete_sup = "delete from "+table;
            if (MaConnexion.ExecuteUpdate(connectionString, requete_sup) != -1)
            {
                textBox_journal_bdd.Text = "la table "+ table +" est vidé ";
            }
            else
            {
                textBox_journal_bdd.Text = "la table "+ table +" n'a pas put etre vidé !! ";
            }
        }
    }
}
