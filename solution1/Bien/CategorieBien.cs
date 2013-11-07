using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace solution1
{
    class CategorieBien
    {
        //un chngement
        // sofiane

        // TODO : qddssd 
        // encore
        // un deuxieme changement
        string connectionString = ConfigurationManager.ConnectionStrings["connectString1"].ConnectionString;    
        public void ajouterCategorieBien0(string a,string b)//!a&&b
        {
                DataSet d = new DataSet();
                d = MaConnexion.ExecuteSelect(connectionString, "select * from CategorieBien where DesigCategorieBien='" + b + "'");
                MaConnexion.ExecuteUpdate(connectionString, "insert into CategorieBien values(22,'" + d.Tables[0].Rows[0][0] + "',1,'" + a + "')");
        }

        public void ajouterCategorieBien1(string a)
        {
            MaConnexion.ExecuteUpdate(connectionString, "insert into CategorieBien values(3,null,1,'" + a + "')");
        }
        public void ajouterCategorieBien1(string a, string b)//a&&!b
        {
            MaConnexion.ExecuteUpdate(connectionString, "insert into CategorieBien values(12,null,1,'" + b + "')");
            DataSet d = new DataSet();
            d = MaConnexion.ExecuteSelect(connectionString, "select * from CategorieBien where DesigCategorieBien='" + b + "'");
            MaConnexion.ExecuteUpdate(connectionString, "update CategorieBien set IdCategorieBienPere='" + d.Tables[0].Rows[0][0] + "' where DesigCategorieBien='" + a + "' ");
        }
        public void ajouterCategorieBien2(string a, string b)//!a&&!b
        {
            MaConnexion.ExecuteUpdate(connectionString, "insert into CategorieBien values(13,null,1,'" + b + "')");
            
            DataSet d = new DataSet();
            d = MaConnexion.ExecuteSelect(connectionString, "select * from CategorieBien where DesigCategorieBien='" + b + "'");
            MaConnexion.ExecuteUpdate(connectionString, "insert into CategorieBien values(14,'" + d.Tables[0].Rows[0][0] + "',1,'" + a + "')");
        }
    }
}
