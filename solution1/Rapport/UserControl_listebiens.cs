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

namespace solution1.Rapport
{
    public partial class UserControl_listebiens : UserControl
    {
        string connectionString = ConfigurationManager.ConnectionStrings["connectString1"].ConnectionString;
        string dsg_invent = "";

        public UserControl_listebiens()
        {
            InitializeComponent();

            charger_inventaire();
        
        }


        public struct structSite
        {
            string idSite;
            string Site;
            public structSite(String idSite, string Site) { this.idSite = idSite; this.Site = Site; }
            public string idsite
            {
                get { return idSite; }
            }
            public string site
            {
                get { return Site; }
            }
        }


        public struct structinventaire
        {
                    string idSite;
            string Site;
            public structinventaire(string idSite, string Site) { this.idSite = idSite; this.Site = Site; }
            public string idsite
            {
                get { return idSite; }
            }
            public string site
            {
                get { return Site; }
            }
        }

        
        private void charger_inventaire() 
        {


            DataSet dsinventaire = MaConnexion.ExecuteSelect(connectionString, "select uidInventaire,DesigInventaire from Inventaire where etat = 'Valide'");
            foreach (DataRow row in dsinventaire.Tables[0].Rows)
            {
                //structinventaire str = new structinventaire(row[0].ToString(), row[1].ToString());
                structSite str = new structSite(row[0].ToString(), row[1].ToString());
                comboBox_inventaire.Items.Add(str);
            }

            try //selection du premier site
            {
                comboBox_inventaire.Text = dsinventaire.Tables[0].Rows[0][1].ToString();
               
            }
            catch (Exception) { } //pas de site dans la base de donnée
        }


        public void charger_bien()
        {
            dsg_invent = ((structSite)comboBox_inventaire.SelectedItem).site;
          
            if (radioBt_ttbiens.Checked)
            {

                try
                {
                    //dataSet_bien.DataTable1.Clear();
                    dataTable1TableAdapter.Fill1(dataSet_bien.DataTable1, dsg_invent);
                    //getImageByIDTableAdapter.Fill_logo(dataSet_bien.GetImageByID);

                    //dataTable2TableAdapter.Fill(dataSet_bien.DataTable1);
                    reportViewer1.RefreshReport();
                    reportViewer2.Visible = false;
                    reportViewer1.Visible = true;
                }
                catch { }
            }
            else
            {

                if (radioBt_anciencode.Checked==true)
                {
                    int i = 1;
                  // reportViewer1.
                   //DataSet ds=   reportViewer1.LocalReport.DataSources.Add(dataTable2BindingSourcet);
                    dataTable2TableAdapter.Filly(dataSet_bien.DataTable2, "",dsg_invent, ancien_code.Text.ToString(), null, "");
                    reportViewer1.Visible = false;
                    reportViewer2.Visible = true;
                    reportViewer2.RefreshReport();
                }
                else
                {
                    if (radioBt_idbien.Checked==true)
                    {
                        DataSet1 ds = new DataSet1();
                        dataTable2TableAdapter.Filly(dataSet_bien.DataTable2, idbien.Text.ToString(), dsg_invent, "", null, "");
                        reportViewer1.Visible = false;
                        reportViewer2.Visible = true;
                        reportViewer2.RefreshReport();
                    }
                    else 
                    {
                        if (radioBt_desgbien.Checked==true)
                        {
                            dataTable2TableAdapter.Filly(dataSet_bien.DataTable2, "", dsg_invent, "", null, designe_bien.Text.ToString());
                            reportViewer1.Visible = false;
                            reportViewer2.Visible = true;
                            reportViewer2.RefreshReport();
                        }
                        else 
                        {
                            if (radioBt_etat.Checked==true)
                            {
                                dataTable2TableAdapter.Filly(dataSet_bien.DataTable2, "", dsg_invent, "", etat_bien.Text.ToString(), "");
                                reportViewer1.Visible = false;
                                reportViewer2.Visible = true;
                                reportViewer2.RefreshReport();
                            }
                        }
                    }
   
                }
            }      
        }

        private void bt_afficher_Click(object sender, EventArgs e)
        {
            charger_bien();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioBt_desgbien_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioBt_idbien_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void reportViewer2_Load(object sender, EventArgs e)
        {

        }

        private void dataTable1BindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }



     
    }
}
