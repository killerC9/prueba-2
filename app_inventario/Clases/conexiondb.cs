using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace app_inventario.Clases
{
    class conexion
    {

    
        static string server = "localhost";
        static string database = "inventario";
        static string user = "root";
        static string password = "root";
        static string port = "3306";


        
        public static MySqlConnection establecerConexion()
        {

            string conexion = "server=" + server + ";" + "port=" + port + ";" + "user id=" + user + ";" + "password=" + password + ";" + "database=" + database + ";";

            MySqlConnection conexionbd = new MySqlConnection(conexion);
            try
            {
                return conexionbd;
                

            }
            catch (MySqlException e)
            {
                MessageBox.Show("No se pudo establecer la conexion con la bd :" + e.ToString());
                return null;
            }

            
        }
    }
}
