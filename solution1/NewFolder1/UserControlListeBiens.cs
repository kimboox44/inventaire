using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace solution1
{
    public partial class UserControlListeBiens : UserControl
    {
        public UserControlListeBiens()
        {
            InitializeComponent();
        }
        string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["connectString1"].ConnectionString;
        string requete ;
        private DataSet dataSet;


        private void chargerBiensTransfertsBien()
        {
            if (rBTousBien.Checked)
            {
                requete = "select Bien.idBien, ancienCode, Bien.DesigBien, CategorieBien.DesigCategorieBien,Bien.DateAcquisitionBien,Etat.DesigEtat, Bien.Prix, Bien.Particularite from seTrouveB, Bien, Etat,CategorieBien where CategorieBien.IdCategorieBien=Bien.IdCategorieBien and Etat.IdEtat=seTrouveB.IdEtat and seTrouveB.idBien=Bien.idBien ";
            }
            else
            {
                if (this.rBIdBien.Checked)
                {
                    requete = "select Bien.idBien, ancienCode, Bien.DesigBien, CategorieBien.DesigCategorieBien,Bien.DateAcquisitionBien,Etat.DesigEtat, Bien.Prix, Bien.Particularite from seTrouveB, Bien, Etat,CategorieBien where CategorieBien.IdCategorieBien=Bien.IdCategorieBien and Etat.IdEtat=seTrouveB.IdEtat and seTrouveB.idBien=Bien.idBien and Bien.idBien LIKE '" + this.tBidentBien.Text + "%'";
                }
                else
                {
                    if (this.rBancienCode.Checked)
                    {
                        requete = "select Bien.idBien, ancienCode, Bien.DesigBien, CategorieBien.DesigCategorieBien,Bien.DateAcquisitionBien,Etat.DesigEtat, Bien.Prix, Bien.Particularite from seTrouveB, Bien, Etat,CategorieBien where CategorieBien.IdCategorieBien=Bien.IdCategorieBien and Etat.IdEtat=seTrouveB.IdEtat and seTrouveB.idBien=Bien.idBien and ancienCode LIKE '" + this.tBAncienCode.Text + "%'";

                    }
                    else
                    {
                        if (this.rBDesignation.Checked)
                        {
                            requete = "select Bien.idBien, ancienCode, Bien.DesigBien, CategorieBien.DesigCategorieBien,Bien.DateAcquisitionBien,Etat.DesigEtat, Bien.Prix, Bien.Particularite from seTrouveB, Bien, Etat,CategorieBien where CategorieBien.IdCategorieBien=Bien.IdCategorieBien and Etat.IdEtat=seTrouveB.IdEtat and seTrouveB.idBien=Bien.idBien and DesigBien LIKE '" + this.tBDesignation.Text + "%'";

                        }
                    }
                }
            }

            this.DGVBien.Rows.Clear();
            dataSet = MaConnexion.ExecuteSelect(connectionString, requete);
            try
            {
                foreach (DataRow row in dataSet.Tables[0].Rows)
                {
                    object[] ligneBien = new object[] { row[0].ToString(), row[1].ToString(), row[2].ToString(), row[3].ToString(), row[4].ToString().Substring(0, 8), row[5].ToString(), row[6].ToString(), row[7].ToString() };
                    DGVBien.Rows.Add(ligneBien);
                }
            }
            catch (Exception)
            { }
        }

        private void buttonAfficher_Click(object sender, EventArgs e)
        {
            chargerBiensTransfertsBien();
        }

        private void DGVBien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
