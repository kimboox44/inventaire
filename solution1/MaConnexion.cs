using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using System.Text.RegularExpressions;
using System.Configuration;
using System.Data;
using System.Windows.Forms;

namespace solution1
{
    public class MaConnexion
    {
        internal static int ExecuteUpdate(string connectionString, string requête)
        {
            // on gère les éventuelles exceptions
            try
            {
                using (SqlConnection connexion = new SqlConnection(connectionString))
                {
                    // ouverture connexion
                    connexion.Open();
                    // exécute sqlCommand avec requête de mise à jour
                    SqlCommand sqlCommand = new SqlCommand(requête, connexion);
                    int nbLignes = sqlCommand.ExecuteNonQuery();
                    return nbLignes;                    
                }
            }
            catch (Exception)
            {                              
                return -1;
            }           
        } //ExecuteUppdate

        // exécution d'une requête Select
        internal static DataSet ExecuteSelect(string connectionString, string requête)
        {
            // on gère les éventuelles exceptions
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {                    
                    con.Open();                  
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandText = requête;
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds);                 
                    return ds;
                }
            }
            catch (Exception)
            {                
                return null;
            }
        }
    }
}
