using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace app_inventario
{
    public class DBConnect
    {
        static MySqlConnection connection = new MySqlConnection();
        static string server ="localhost" ;
        static string database = "inventario";
        static string user ="root";
        static string password ="root";
        static string port  = "3306";


        string conexion = "server" + server + ";" + "port" + port + ";" + "user id="+user+";"+"password="+password+";"+"database="+database+";";

        public MySqlConnection establecerConexion()
        {
            try {  
                
                connection.ConnectionString = conexion;
                connection.Open();
                MessageBox.Show("conexion exitosa");

            
            } 
            catch ( MySqlException e)
            {
                MessageBox.Show("No se pudo establecer la conexion con la bd :"+ e.ToString() );
            }

            return connection;
        }

    }
}
