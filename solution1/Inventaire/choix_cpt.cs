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
namespace solution1.Inventaire
{
    public partial class choix_cpt : Form
    {
        MDIParent parent = null;
        string connectionString = ConfigurationManager.ConnectionStrings["connectString1"].ConnectionString;

        public struct structinvent
        {
            string idInvent;
            string Invent;
            public structinvent(String idinv, string inv) { this.idInvent = idinv; this.Invent = inv; }
            public string idinvent
            {
                get { return idInvent; }
            }
            public string invent
            {
                get { return Invent; }
            }
        }

        public choix_cpt(MDIParent parent)
        {
            this.parent = parent;
            InitializeComponent();
            charger_inv();
        }

        private void invent_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void charger_inv()
        {
            DataSet dinvent = MaConnexion.ExecuteSelect(connectionString, "select * from inventaire where type='Comptable' and caract='Cloturé'");
            foreach (DataRow row in dinvent.Tables[0].Rows)
            {
                structinvent str = new structinvent(row[0].ToString(), row[1].ToString());
             
                invent.Items.Add(str);
            
            }  
        }

        private void Importation_Click(object sender, EventArgs e)
        {
            NouvelInventaire nv_inv = new NouvelInventaire(parent);
            nv_inv.type.Text = "Comptable";
            nv_inv.Show();

        }

        private void cree_inv_Click(object sender, EventArgs e)
        {
         
            if(invent.Text != "")
            {
                string idinventaire = ((structinvent)invent.SelectedItem).idinvent;
                string desiginvent = ((structinvent)invent.SelectedItem).invent;

                string requete_insert1 = " INSERT INTO Inventaire (UIdInventaire ,DesigInventaire ,DateInventaire ,etat,type,caract) VALUES (NEWID(), '" +
                                  tb_nom_inv.Text.ToString()+"', '" + DateTime.Now.ToString("dd/MM/yyyy H:m:s") + "', 'Valide','Comptable','En cours')";

                if (MaConnexion.ExecuteUpdate(connectionString, requete_insert1) == 1)
                {
                    bool import = false;
                    string requete_id_inventaire = "select UIdInventaire from Inventaire where DateInventaire=(SELECT MAX(DateInventaire)FROM Inventaire)";
                    DataSet id_inventaire = MaConnexion.ExecuteSelect(connectionString, requete_id_inventaire);
                    string id_invent = id_inventaire.Tables[0].Rows[0][0].ToString();

                    string requete_inv = "select * from SeTrouveB where uidInventaire='" + idinventaire.ToString().Trim() + "'";
                    DataSet setrouve = MaConnexion.ExecuteSelect(connectionString, requete_inv);
                    if (setrouve.Tables[0].Rows.Count > 0)
                    {
                        foreach (DataRow ligne in setrouve.Tables[0].Rows)
                        {


                            string req_insert = "INSERT INTO SeTrouveB (uidInventaire,IdSite,IdEmpla,IdBien,IdEtat) VALUES ('" + id_invent.ToString() + "'," + ligne[1] + ",'" + ligne[2] + "','" + ligne[3] + "'," + ligne[4] + ")";
                            MaConnexion.ExecuteUpdate(connectionString, req_insert);
                        }
                        MessageBox.Show("La création d'inventaire est effectuée avec succès");
                    }
                }
                else { MessageBox.Show("Erreur d'importation"); }

            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
