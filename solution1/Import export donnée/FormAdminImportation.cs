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

namespace solution1
{
    public partial class FormAdminImportation : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["connectString1"].ConnectionString;


        public FormAdminImportation()
        {
            InitializeComponent();
            textBoxexplicimportglob.Text = "importation par bloc : \r\n dans cette partie en importe par bloc";
        }


        
// **************************       bouton parcoure des fichier 
        //***** parcourire import par table 
        private void parcourir_Click(object sender, EventArgs e)
        {
            vider_bdd vide = new vider_bdd();
            vide.parcour_fichier(textBoximpor_table);
        }

        //***** parcoure categorie bien 
        private void button10_Click(object sender, EventArgs e)
        {
            vider_bdd vide = new vider_bdd();
            vide.parcour_fichier(textBox_categorie_bien);
        }

        //***** parcourire bien
        private void button_bien_Click(object sender, EventArgs e)
        {
            vider_bdd vide = new vider_bdd();
            vide.parcour_fichier(textBox_bien);
        }

        //**** parcourire site
        private void button_site_Click(object sender, EventArgs e)
        {
             vider_bdd vide = new vider_bdd();
             vide.parcour_fichier(textBox_site);
        }

        //**** parcourire emplacement
        private void button_emplacement_Click(object sender, EventArgs e)
        {
            vider_bdd vide = new vider_bdd();
            vide.parcour_fichier(textBox_emplacement);
        }
        
        //***** parcourire se trouve bien
        private void button_setrouve_bien_Click(object sender, EventArgs e)
        {
            vider_bdd vide = new vider_bdd();
            vide.parcour_fichier(textBox_setoruve_bien);
        }
//  ************* fin des bouton parcoure des fichier 


//**** importation des données dans la base de donnée 
        //******* importer des données sur la base de donnée par table 
        private void button1_Click(object sender, EventArgs e)
        {
            import_donnée import_tab = new import_donnée();
            import_tab.import_par_table(textBoximpor_table, textBoxjournal2, comboBox1);
        }

        //**** remplire la base de donnée en bloc
        private void demarrage_Click(object sender, EventArgs e)
        {
            import_donnée import_bdd = new import_donnée();
            import_bdd.import_bdd_bloc(comboBox_table, textBox_categorie_bien, textBoxjournal, textBox_bien, textBox_site, textBox_emplacement, textBox_setoruve_bien);
        }
//***** fin d'importation


//*** vider la base de données 
        // ****** vider la base de donnée par table 
        private void button_vide_tab_Click(object sender, EventArgs e)
        {
            vider_bdd vider = new vider_bdd();
            vider.vider_bdd_tapbe(comboBox_table, textBox_journal_bdd);
        }

        // ***** vider la base de donnée entierement 
        private void button_vider_Click(object sender, EventArgs e)
        {
            vider_bdd vider_tt = new vider_bdd();
            vider_tt.vider_toute_bdd(textBox_journal_bdd);
        }
//  *************** fin de vider la base de donnée 





// ******************** exportation des données de la BDD vers un ficier csv
        // exportation de données par table 
        private void button1_Click_1(object sender, EventArgs e)
        {
            exporte_donnée export = new exporte_donnée();
            export.export_table(textBox_export,comboBox_export);
            
        }

        //exportation de toute la base de données 
        private void button_export_tt_Click(object sender, EventArgs e)
        {
            exporte_donnée export_dbb = new exporte_donnée();
            export_dbb.export_base(textBox_export);
            
        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }
//****-- fin d'exportation 
 
    }
}
