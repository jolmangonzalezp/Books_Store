using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataLayer
{
    public class Connection
    {
        private MySqlConnection _connection;

        static String server = "server=localhost;";
        static String db = "database=library_dsam;";
        static String user = "user=root;";
        static String passwd = "password=Ianeph21;";
        static String port = "port=3306;";
        static String conn = server + port + user + passwd + db;

        public Connection()
        {
            _connection = new MySqlConnection(conn);
        }

        public MySqlConnection OpenConection()
        {
            try
            {
                if (_connection.State == ConnectionState.Closed)
                {
                    _connection.Open();
                    Console.WriteLine("Se ha conectado a la base de datos");
                }
            }
            catch (MySqlException e)
            {
                MessageBox.Show("No se pudo conectar a la base de datos");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"General error: {ex.Message}");
            }
            return _connection;
        }
    }
}
