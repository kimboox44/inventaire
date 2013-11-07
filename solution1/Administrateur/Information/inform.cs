using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Printing;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;
using System.Collections.ObjectModel;

namespace solution1.Prenom.Information
{
    public partial class inform : UserControl
    {
        string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["connectString1"].ConnectionString;
        public inform()
        {
            InitializeComponent();
            info_actuel();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            modification(textBox_reg.Text, textBox_ident.Text, textBox_fisc.Text, textBox_logo.Text);

            info_actuel();
        }



        private void modification(string reg, string ident, string fisc, string logo)
        {
            int erreur = 0;
            int succé = 0;

            if (logo != "")
            {

                string req = "update information set logo = (SELECT BulkColumn FROM Openrowset( Bulk '" + logo + "', Single_Blob) as logo)";

                if (MaConnexion.ExecuteUpdate(connectionString, req) == 1)
                {
                    succé = 1;
                }
                else
                {
                    erreur = 1;
                }

            }

            if (reg != "")
            {

                string req = "update information set num_reg = " + reg;

                if (MaConnexion.ExecuteUpdate(connectionString, req) == 1)
                {
                    succé = 1;
                }
                else
                {
                    erreur = 1;
                }

            }

            if (fisc != "")
            {

                string req = "update information set num_fiscal = " + fisc;

                if (MaConnexion.ExecuteUpdate(connectionString, req) == 1)
                {
                    succé = 1;
                }
                else
                {
                    erreur = 1;
                }

            }


            if (ident != "")
            {

                string req = "update information set num_ind = " + ident;

                if (MaConnexion.ExecuteUpdate(connectionString, req) == 1)
                {
                    succé = 1;
                }
                else
                {
                    erreur = 1;
                }

            }

            /*

            if (succé == 1 && erreur == 0)
            {
                MessageBox.Show("Les informations sont modifiées avec succès");
            }
            if (succé == 0 && erreur == 0)
            {
                MessageBox.Show("Echec des modifications !!");
            }
            */
        }



        private void info_actuel()
        {
            string requete = "select * from information";

            DataSet data = MaConnexion.ExecuteSelect(connectionString, requete);
            foreach (DataRow row in data.Tables[0].Rows)
            {
                //mage img=GetImageById();
                //string reg3=row[2].ToString();
                //string fisc=row[3].ToString();
                //string ident=row[4].ToString();
                image_logo.Image = GetImageById();
                reg.Text = row[2].ToString();
                fisc.Text = row[3].ToString();
                ident.Text = row[4].ToString();
                //return(img,reg3,fisc,ident);
            }
        }

        public Image GetImageById()
        {
            Image result = null;
            SqlDataReader imageReader;

            SqlConnection conn = new SqlConnection(connectionString);// your connection string I place mine for illustration.. DON'T HARDLY WRITE IT, pass it as argument or add it in application configuration 
            string selectString = "[dbo].[GetImageByID]";
            SqlCommand selectCommand = new SqlCommand(selectString, conn);
            selectCommand.CommandType = CommandType.StoredProcedure;
            selectCommand.Parameters.AddWithValue("@id", 1);

            conn.Open();
            imageReader = selectCommand.ExecuteReader(CommandBehavior.CloseConnection);
            while (imageReader.Read())
            {
                result = Image.FromStream(new MemoryStream((byte[])imageReader.GetValue(0)));
            }
            return result;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.DefaultExt = "mif";
            openFile.Filter = "Fichier jpg, png (*.jpg, *.png)|*.jpg; *.png";
            openFile.ShowDialog();
            if (openFile.FileNames.Length > 0)
            {
                foreach (string filename in openFile.FileNames)
                {
                    textBox_logo.Text = filename;
                    //listBoxAdd.Items.Add(filename);
                }
            }
        }


    }
}
