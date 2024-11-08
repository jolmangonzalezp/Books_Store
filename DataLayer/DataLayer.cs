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
    public class DataLayer
    {
        Connection con;
        MySqlConnection conex;
        public DataLayer() {
            con = new Connection();
        }

        public void GetAllBook()
        {
            conex = con.OpenConection();
            try
            {
                MySqlCommand cmd = new MySqlCommand("getBooks", conex);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", null);
                cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"MySQL error: {ex.Message}");
            }
            catch (Exception e)
            {
                MessageBox.Show($"General error: {e.Message}");
            }finally
            {
                if (conex != null)
                {
                    conex.Close();
                }
            }
        }

        public string CreateBook(string title,string publishedYear, int idAuthor, string genre,int avalableAmount)
        {
            string message;
            conex = con.OpenConection();
            try
            {
                MySqlCommand cmd = new MySqlCommand("PostBook", conex);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@titulo", title);
                cmd.Parameters.AddWithValue("@anio_publicacion", publishedYear);
                cmd.Parameters.AddWithValue("@genero", genre);
                cmd.Parameters.AddWithValue("@id_autor", idAuthor);
                cmd.Parameters.AddWithValue("@cantidad_disponible", avalableAmount);
                cmd.ExecuteNonQuery();
                message = "Book Created";
            }
            catch (MySqlException ex)
            {
                message = "Book couldn't be created";
            }

            return message;
        }
    }
}
