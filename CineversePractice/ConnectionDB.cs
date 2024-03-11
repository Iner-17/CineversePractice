using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace CineversePractice
{
    internal class ConnectionDB
    {
        private static readonly String connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=cinedb;";

        public static MySqlConnection getConnection() 
        { 
            MySqlConnection conn = new MySqlConnection(connectionString);
            return conn;
        }
    }
}
