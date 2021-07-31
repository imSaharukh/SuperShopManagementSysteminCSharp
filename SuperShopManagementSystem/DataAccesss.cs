using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace SuperShopManagementSystem
{
  public static class DataAccess
    {
        private static SqlConnection sqlcon = new SqlConnection(@"Server=tcp:supershop.database.windows.net,1433;Database=supershoplow;User ID=supershop;Password=Saharukh123##;Trusted_Connection=False;Encrypt=True;");

        public static SqlConnection Sqlcon
        {
            get { return sqlcon; }
            set { sqlcon = value; }
        }

        private static SqlCommand sqlcom;

        public static SqlCommand Sqlcom
        {
            get { return sqlcom; }
            set { sqlcom = value; }
        }

        private static SqlDataAdapter sda;

        public static SqlDataAdapter Sda
        {
            get { return sda; }
            set { sda = value; }
        }

        private static DataSet ds;

        public static DataSet Ds
        {
            get { return ds; }
            set { ds = value; }
        }


        private static void QueryText(string query)
        {
           Sqlcom = new SqlCommand(query,Sqlcon);
        }

        public static DataSet ExecuteQuery(string sql)
        {
            QueryText(sql);
            Sda = new SqlDataAdapter(Sqlcom);
            Ds = new DataSet();
            Sda.Fill(Ds);
            return Ds;
        }

        public static int ExecuteUpdateQuery(string sql)
        {
          QueryText(sql);
            int u =Sqlcom.ExecuteNonQuery();
            return u;
        }
    }
}
