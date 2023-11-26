using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ems_app
{
    class Configuration
    {
        //String ConnectionStr = "Data Source=rsmsftp.database.windows.net;Initial Catalog=RSMS;User ID=waa;Password=uetftp@123;";
        String ConnectionStr = @"Data Source=(local);Initial Catalog=EMS2;Integrated Security=True";
        SqlConnection con;
        private static Configuration _instance;
        public static Configuration getInstance()
        {
            if (_instance == null)
                _instance = new Configuration();
            return _instance;
        }
        private Configuration()
        {
            con = new SqlConnection(ConnectionStr);
            con.Open();
        }
        public SqlConnection getConnection()
        {
            return con;
        }
    }
}
