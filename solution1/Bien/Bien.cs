using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.Configuration;

namespace solution1
{
    public class Bien
    {
        private String idBien = null;
        private String idcategorieBien = null;
        private String idEtat = null;
        private String IdBienSeq = null;
        private String desigBien = null;
        private String dateAquisition = null;
        private String particularite = null;
        private float prix = default(float);
        private String photo = null;
        private String ancienCode = null;
        private int idFournisseur =-1;
        private String etatBien = null;
        private String numFacture = null;
        private String numSerie = null;
        private String marque = null;

        //private String emplacement = null; 
        string connectionString = ConfigurationManager.ConnectionStrings["connectString1"].ConnectionString;    

        //Constructeurs
        public Bien(String idBien) 
        {
            this.idBien = idBien;
        }
        public String getDesignation()
        {
            return this.desigBien;
        }
        public void setDesignation(String desigBien)
        {
            this.desigBien = desigBien;
        }
        public String getIdentifiant()
        {
            return this.idBien;
        }
        public void setIdentifiant(String idBien)
        {
            this.idBien = idBien;
        }
        public String getDate()
        {
            return this.dateAquisition;
        }
        public String getAncien()
        {
            return this.ancienCode;
        }
        public void SetAncien(String anciencode)
        {
            this.ancienCode = anciencode;
        }

        public void setDate(String dateAquisition)
        {
            this.dateAquisition = dateAquisition;
        }

        public Bien(String idcategorieBien, String idEtat, String desigBien, String dateAquisition, String particularite, float prix, String photo, String ancienCode, int idFournisseur, String numFacture, String numSerie, String marque,String etatBien)
        {          
            this.idcategorieBien = idcategorieBien;
            this.idEtat = idEtat;            
            this.desigBien = desigBien;
            this.dateAquisition = dateAquisition;
            this.particularite = particularite;            
            this.prix = prix;
            this.photo = photo;  
            this.ancienCode = ancienCode;
            this.idFournisseur = idFournisseur;
            this.etatBien = etatBien;     
            this.numFacture = numFacture;
            this.numSerie = numSerie;
            this.marque = marque;
        }

        //fin constructeurs
        public int ajouterBien(string idBien)
        {
            var price = (float)this.prix;
            string pric = price.ToString(".##");

            var connection = new SqlConnection(connectionString);
            var SqlCommand = new SqlCommand("InsertBien", connection)
            {
                CommandType = CommandType.StoredProcedure
            };

            SqlCommand.Parameters.Add("@idBien", SqlDbType.VarChar, 254).Value = idBien.ToString();
            SqlCommand.Parameters.Add("@idcategorieBien", SqlDbType.Int).Value = Convert.ToInt32(this.idcategorieBien);
            SqlCommand.Parameters.Add("@DesigBien", SqlDbType.VarChar, 254).Value = this.desigBien;
            SqlCommand.Parameters.Add("@DateAcquisitionBien", SqlDbType.Date).Value = this.dateAquisition;
            SqlCommand.Parameters.Add("@Particularite", SqlDbType.VarChar, 254).Value = this.particularite;
            SqlCommand.Parameters.Add("@photo", SqlDbType.NVarChar).Value = this.photo;
            SqlCommand.Parameters.Add("@prix", SqlDbType.Float).Value = pric;
            SqlCommand.Parameters.Add("@ancienCode", SqlDbType.VarChar, 30).Value = this.ancienCode;

            if(idFournisseur!=-1)
            SqlCommand.Parameters.Add("@idFournisseur", SqlDbType.Int).Value = DBNull.Value;
            else
                SqlCommand.Parameters.Add("@idFournisseur", SqlDbType.Int).Value = idFournisseur;


            SqlCommand.Parameters.Add("@numFacture", SqlDbType.VarChar, 20).Value = this.numFacture;
            SqlCommand.Parameters.Add("@numSerie", SqlDbType.VarChar, 30).Value = this.numSerie;
            SqlCommand.Parameters.Add("@marque", SqlDbType.VarChar, 20).Value = this.marque;
            SqlCommand.Parameters.Add("@etat", SqlDbType.VarChar, 20).Value = this.etatBien;

            connection.Open();
            int number = SqlCommand.ExecuteNonQuery();
            connection.Close();
            return number;



            /*string requete = "insert into Bien (idBien,idcategorieBien,DesigBien,DateAcquisitionBien,Particularite,prix, photo, ancienCode, idFournisseur, numFacture, numSerie, marque, etat) values ('" + idBien + "'," + this.idcategorieBien + ",'" + this.desigBien + "','" + this.dateAquisition + "','" + this.particularite + "'," + this.prix + ",'" + this.photo + "', '" + this.ancienCode + "', " + this.idFournisseur + ", '" + numFacture + "','" + numSerie + "','" + marque + "','" + this.etatBien + "');";
            Console.WriteLine(requete);
            return  MaConnexion.ExecuteUpdate(connectionString, requete);*/
        }
        public int modifierBien(string idBien)
        {
            var temp = (float)this.prix;
            string price2 = temp.ToString(".##");

            var connection = new SqlConnection(connectionString);
            var SqlCommand = new SqlCommand("UpdateBien", connection)
            {
                CommandType = CommandType.StoredProcedure
            };
            SqlCommand.Parameters.Add("@idBien", SqlDbType.VarChar, 254).Value = idBien.ToString();
            SqlCommand.Parameters.Add("@idcategorieBien", SqlDbType.Int).Value = this.idcategorieBien;
            SqlCommand.Parameters.Add("@DesigBien", SqlDbType.VarChar, 254).Value = this.desigBien;
            SqlCommand.Parameters.Add("@DateAcquisitionBien", SqlDbType.Date).Value = this.dateAquisition;
            SqlCommand.Parameters.Add("@Particularite", SqlDbType.VarChar, 254).Value = this.particularite;
            SqlCommand.Parameters.Add("@photo", SqlDbType.NVarChar).Value = this.photo;
            SqlCommand.Parameters.Add("@prix", SqlDbType.Float).Value = price2;
            SqlCommand.Parameters.Add("@ancienCode", SqlDbType.VarChar, 30).Value = this.ancienCode;
            SqlCommand.Parameters.Add("@idFournisseur", SqlDbType.Int).Value = DBNull.Value;
            SqlCommand.Parameters.Add("@numFacture", SqlDbType.VarChar, 20).Value = this.numFacture;
            SqlCommand.Parameters.Add("@numSerie", SqlDbType.VarChar, 30).Value = this.numSerie;
            SqlCommand.Parameters.Add("@marque", SqlDbType.VarChar, 20).Value = this.marque;
            SqlCommand.Parameters.Add("@etat", SqlDbType.VarChar, 20).Value = this.etatBien;

            connection.Open();
            int number = SqlCommand.ExecuteNonQuery();
            connection.Close();
            return number;
            
            
            /*  string requete = "UPDATE Bien SET IdCategorieBien = " 
                + this.idcategorieBien + " ,DesigBien = '"
                + this.desigBien + "' , DateAcquisitionBien = '"
                + this.dateAquisition + "', Particularite = '"
                + this.particularite + "', prix = "                 
                + this.prix + ", photo = '" 
                + this.photo + "', ancienCode = '"
                + this.ancienCode + "', idFournisseur = "
                + this.idFournisseur + ", numFacture = '"
                + this.numFacture + "', numSerie = '"
                + this.numSerie + "', marque = '"
                + this.marque + "', etat = 'Non supprimé' WHERE IdBien = '" + idBien +"'";
           
                
            return MaConnexion.ExecuteUpdate(connectionString, requete);*/
        }

        public int supprimerBien(string uidInventaire, string idEmpla)
        {
           // String requete = "delete from seTrouveB where idBien = '" + this.idBien + "' and uidInventaire = '" + uidInventaire + "' and idEmpla = " + idEmpla ;            
            String requete = "update Bien set etat='suprimer' where  IdBien='" + this.idBien + "'";
            return MaConnexion.ExecuteUpdate(connectionString, requete);



        }


    }
}
