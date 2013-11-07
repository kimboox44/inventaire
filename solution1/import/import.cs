using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.OleDb;
using Excel = Microsoft.Office.Interop.Excel;
using System.Configuration;
namespace ProjectPFE
{
    public partial class import : DevExpress.XtraEditors.XtraForm
    {
        string connection = ConfigurationManager.ConnectionStrings["ProjectPFE.Properties.Settings.ProjectPFEConnectionString"].ConnectionString;
        public string fichier;
        public string path;
        OleDbDataReader reader;
        public DataTable table;
        DataRow lineXl = null;
        System.Data.OleDb.OleDbConnection conn;
        System.Data.OleDb.OleDbConnection conn1;
        System.Data.DataSet DtSetcol;
        DataSet dtsetcol= new DataSet();
        System.Data.OleDb.OleDbDataAdapter cmd;
        string connectionstring = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\;Extended Properties='text;HDR=Yes;FMT=Delimited;IMEX=1'";
        System.Data.DataSet DtSetdata;
        string table1;
        int nbrow;
        string valeur = "";
        string colonnes = "";
        public import()
        {
            InitializeComponent();
            daDest.Fill(dsDest1);




        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (radbutExcel.Checked == true)
            {
                openFileDialog1.Filter = "Excel Files (.csv)|*.csv|All Files (*.*)|*.*";
                openFileDialog1.FilterIndex = 1;
            }
            else
            {
                if (radbutXml.Checked == true)
                {

                    openFileDialog1.Filter = "XML Files (.xml)|*.xml|All Files (*.*)|*.*";
                    openFileDialog1.FilterIndex = 1;

                }

            }
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                path = openFileDialog1.FileName.ToString();

                txtChemin.Text = path;
                fichier = System.IO.Path.GetFileName(path);







            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvcorrespondance.Rows.Clear();
            table1 = comboTableBD.SelectedValue.ToString();

           dtsetcol = Connexion.select(connection, "SELECT COLUMN_NAME, ORDINAL_POSITION, DATA_TYPE FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME='" + table1 + "'");
            int nbrow = dtsetcol.Tables[0].Rows.Count;
            int i = 0;
            dgvcorrespondance.Rows.Add(nbrow );
            for (i = 0; i <= nbrow - 1; i++)
            {

                dgvcorrespondance.Rows[i].Cells[0].Value =dtsetcol.Tables[0].Rows[i][0].ToString();


            }
            

            string path = @"C:\Users";
            conn = new System.Data.OleDb.OleDbConnection(connectionstring);
            cmd = new System.Data.OleDb.OleDbDataAdapter("select * from testc.csv ", conn);
            cmd.TableMappings.Add("Table", "TestTable");
            DtSetcol = new System.Data.DataSet();
            cmd.Fill(DtSetcol);
           int nbcol =DtSetcol.Tables[0].Columns.Count;
         
            for (int j = 0; j <nbcol; j++)
            {
                 string col = DtSetcol.Tables[0].Columns[j].ColumnName.ToString();
                 colsource.Items.Add(col);
                
            }
                   
        
        }

        private void butVlidSchema_Click(object sender, EventArgs e)
        {

            int nbligne = dgvcorrespondance.Rows.Count;

            int i = 0;
             colonnes = dgvcorrespondance.Rows[0].Cells[2].Value.ToString();
             DataGridViewTextBoxColumn col = new DataGridViewTextBoxColumn();
             dgvLignenonimporté.Columns.Add(col);
             col.HeaderText = dgvcorrespondance.Rows[0].Cells[2].Value.ToString();

            for (i = 1; i <= nbligne - 2; i++)
            {

                colonnes = colonnes + "," + dgvcorrespondance.Rows[i].Cells[2].Value.ToString();
                DataGridViewTextBoxColumn col1 = new DataGridViewTextBoxColumn();
                dgvLignenonimporté.Columns.Add(col1);
                col1.HeaderText = dgvcorrespondance.Rows[i].Cells[2].Value.ToString();
            }

            conn1 = new System.Data.OleDb.OleDbConnection(connectionstring);
            cmd = new System.Data.OleDb.OleDbDataAdapter("select " + colonnes + " from testc.csv ", conn1);

            DtSetdata = new System.Data.DataSet();
            cmd.Fill(DtSetdata);

            nbrow = DtSetdata.Tables[0].Rows.Count;



            butImporter.Enabled = true;
            butVlidSchema.Enabled = false;
        }




        private void butImporter_Click(object sender, EventArgs e)
        {
            DataTable tablechec = new DataTable();
            int nbrowinser=0;
            DataSet echerc = new DataSet();
            int j = 0;
            dgvLignenonimporté.Rows.Add(1);
            int index = dgvLignenonimporté.CurrentRow.Index;
            foreach (DataRow row in DtSetdata.Tables[0].Rows)
            {
                valeur = "";
                int nbcol = DtSetdata.Tables[0].Columns.Count;
                

                    for (int k = 0; k < nbcol; k++)
                    {

                        string type = dtsetcol.Tables[0].Rows[k][2].ToString();

                        if (type == "varchar")
                        {
                            if (k == 0)
                            {
                                string data = "'" + row[0].ToString() + "'";
                                valeur += data;
                            }
                            else
                            {
                                string data = "'" + row[k].ToString() + "'";
                                valeur += ",";
                                valeur += data;
                            }
                        }
                        else
                        {
                            if (type == "int")
                            {
                                if (k == 0)
                                {

                                    valeur += row[0].ToString();
                                }
                                else
                                {


                                    valeur += ",";
                                    valeur += int.Parse(row[k].ToString());
                                }
                            }
                            else
                            {
                                if (type == "date")
                                {
                                    if (k == 0)
                                    {

                                        valeur += DateTime.Parse(row[0].ToString());
                                    }
                                    else
                                    {

                                        valeur += ",";
                                        valeur += DateTime.Parse(row[k].ToString());
                                    }
                                }


                            }



                        }

                    }

                    string requete = "insert into " + table1 + " values (" + valeur + ")";
                    int nbinsert = Connexion.Updatecmd(connection, requete);
                    // MessageBox.Show(nbinsert.ToString());
                
                if (nbinsert == 1)
                {
                    nbrowinser++;

                }
                else
                {

                   
                    
                        for (int i = 0; i < nbcol; i++)
                        {


                            MessageBox.Show(row[0].ToString());
                           
                            dgvLignenonimporté.Rows[index].Cells[i].Value = row[i].ToString();
                           
                        }
                        index++;

                      
                }



            }
         
            txtLigneFichier.Text = nbrow.ToString();
            txtLigneimporté.Text = nbrowinser.ToString();
      
        }

        private void import_Load(object sender, EventArgs e)
        {

        }

        
        

        

        

        
        

       
       
        

        
        
    }
}