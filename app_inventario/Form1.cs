using app_inventario.Clases;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app_inventario
{
    public partial class Form1 : Form
    {
        


        
        
        public Form1()
        {
            InitializeComponent();
            //LOGEO CODIGO ****
            //F_Log frm = new F_Log();  frm.StartPosition = FormStartPosition.CenterParent;  frm.ShowDialog();

            MySqlConnection conexionbd = Clases.conexion.establecerConexion();
            conexionbd.Open();

            MySqlCommand comando = new MySqlCommand();
            comando.Connection = conexionbd;

            comando.CommandText = ("Select * from compras_precio INNER JOIN valor_venta ON valor_venta.id_venta = compras_precio.id_compras_precio;");

            MySqlDataAdapter adapter = new MySqlDataAdapter(comando);
            DataTable tabla = new DataTable();
            adapter.Fill(tabla);
            dataGridView1.DataSource = tabla;
            conexionbd.Close();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string textoBusqueda = textBox1.Text.Trim();

            using (MySqlConnection conexionbd = Clases.conexion.establecerConexion())
            {
                conexionbd.Open();
                string consulta = "SELECT * FROM compras_precio WHERE nom_compra LIKE @busqueda";
                using (MySqlCommand comando = new MySqlCommand(consulta, conexionbd))
                {
                    comando.Parameters.AddWithValue("@busqueda", "%" + textoBusqueda + "%");
                    MySqlDataAdapter adapter = new MySqlDataAdapter(comando);
                    DataTable tabla = new DataTable();
                    adapter.Fill(tabla);
                    dataGridView1.DataSource = tabla;
                }
            }
        }
    }
}
