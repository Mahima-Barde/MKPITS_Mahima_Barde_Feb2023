using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Get_connection
{
    public static class Transaction
    {
        static SqlConnection con = ConnectionDB.GetConnection();
        static string query = null;
        static SqlCommand cmd = null;
        //method to insert record in item table





    }
}
