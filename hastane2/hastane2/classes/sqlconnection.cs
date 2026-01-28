//sqlconnection.cs

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace hastane2.classes
{
    public class sqlconnection
    {
        public static SqlConnection connection = new SqlConnection("Data Source=RYHN_MATEBOOK\\SQLEXPRESS;Initial Catalog=hastane;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");

        public static void checkconnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
            else
            {

            }
        }

        internal static void closeconnection()
        {
            throw new NotImplementedException();
        }
    }
}