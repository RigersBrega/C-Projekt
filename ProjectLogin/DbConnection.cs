using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectLogin
{
    public sealed class DbConnection
    {
        private static SqlConnection conn = null;
        public static SqlConnection getConnection()
        {
            if (conn == null)
            {
                conn = new SqlConnection(Constants.connString);
                return conn;
            }
            else { return conn; }
        }
    }
}
