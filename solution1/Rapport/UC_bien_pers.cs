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
using solution1.Rapport.DataSet_bienTableAdapters;

namespace solution1.Rapport
{
    public partial class UC_bien_pers : UserControl
    {

        string connectionString = ConfigurationManager.ConnectionStrings["connectString1"].ConnectionString;

        public UC_bien_pers()
        {
            InitializeComponent();
            charger_personne();
        }

        public void charger_personne()
        {
            try
            {
                string query = "select Particularite, COUNT(*) as count from Bien where bien.etat='Non Supprimé' group by (Particularite)";
                DataSet dataSet = MaConnexion.ExecuteSelect(connectionString, query);

                if (dataSet.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow dRRacine in dataSet.Tables[0].Rows)
                    {
                        TreeNode racine = new TreeNode(dRRacine[0].ToString(), 0, 1);

                        //on stocke l'identifant de l'emplacement (idSite_idEmpla)
                        racine.Name = dRRacine[0].ToString() + "_" + dRRacine[1].ToString();

                        TV_personne.Nodes.Add(racine);
                    }
                    
                    TV_personne.SelectedNode = TV_personne.Nodes[0];
                }
            }
            catch { }
        }

        private void TV_personne_AfterSelect(object sender, TreeViewEventArgs e)
        {
            try
            {
                //Biens dans le listView
                TreeNode tN = (TreeNode)e.Node;
                String id = tN.Name;
                String[] tabId = id.Split(new char[] { '_' });
                String personne = tabId[0];
                String idEmpla = tabId[1];
                //String idEmplaCmplet = (((MaConnexion.ExecuteSelect(connectionString, "select idEmplaComplet from Emplacement where idEmpla ='" + idEmpla+"';")).Tables[0]).Rows[0]).ToString();
             /*   DataSet dataTableidEmplaCmplet = MaConnexion.ExecuteSelect(connectionString, "select idEmplaComplet from Emplacement where idEmpla ='" + idEmpla + "' and etatEmpla='Non Supprimé';");
                DataRow dRidEmplaCmplet = dataTableidEmplaCmplet.Tables[0].Rows[0];
                String idEmplaCmplet = dRidEmplaCmplet[0].ToString();
*/
                dataTable3TableAdapter.Fill(dataSet_bien.DataTable3, personne.ToString());
               // DataTable3TableAdapter.Fill(DataSet_bien.DataTable3, personne.ToString());
                reportViewer1.RefreshReport();

            }
            catch (Exception ex) //selection d'un emplacement qui n'a pas encore d'identifiant (node.Name == "")
            {
                //if (this.MdiParent != null)
                //this.mDIParent.toolStripStatusLabel1.Text = "L'emplacement " + ((TreeNode)e.Node).Name + " ne contient pas de bien";
            }
        }

    }
}
