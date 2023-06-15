using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Security.Cryptography.X509Certificates;

namespace Get_connection
{
    internal class ConnectionDB
    {
        public static string connectionstring = "server=.\\sqlexpress;integrated security=true;database=FieldTransaction";

        public static SqlConnection GetConnection()
        {
            SqlConnection con = new SqlConnection(connectionstring);
            try
            {
                con.Open();

            }
            catch(Exception ee)
            {
                return null;
            }
            return con;
        }
    }
}
