using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace BestBuy_Proyecto
{
    class MySqlParameters
    {
        public static string connectionString = "datasource=127.0.0.1; port=3306; username=root; password=; database=bestbuy";
        public static MySqlConnection mySqlConnection;
        public static MySqlCommand mySqlCommand;
        public static MySqlDataReader dataReader;

        public static void startMySqlConnection()
        {
            mySqlConnection = new MySqlConnection(connectionString);
            mySqlConnection.Open();
        }
    }
}
