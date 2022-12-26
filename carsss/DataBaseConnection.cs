using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace carsss
{
    class DataBaseConnection
    {
        MySqlConnection connection = new MySqlConnection(
            "server = localhost;"+
            "port =3306;"+
            "username = root;"+
            //"password = vaspurakanci1915;" +
            "password = Polina2003/;" +
            //"database = automir;"
            "database = pupupu;"
            );

        public void OpenConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
                connection.Open();
        }
        public void CloseConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
                connection.Close();
        }
        public MySqlConnection GetSqlConnection()
        {
            return connection;
        }
    }
}