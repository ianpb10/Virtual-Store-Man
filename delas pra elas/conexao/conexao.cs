using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delas_pra_elas.conexao
{
    public class MySqlConnectionManager
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;

        public string lasterror { get; private set; }

        public MySqlConnectionManager()
        {
            Initialize();
        }

        private void Initialize()
        {
            server = "localhost";
            database = "homens";
            uid = "root";
            password = "";

            string connectionstring = $"SERVER={server};DATABASE={database};UID={uid};PASSWORD={password};";
            connection = new MySqlConnection(connectionstring);
        }

        public bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                lasterror = ex.Message;
                return false;
            }

        }
        public bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                lasterror = ex.Message;
                return false;
            }
        }

        public MySqlConnection GetConnection()
        {
            return connection;
        }
    }
}
