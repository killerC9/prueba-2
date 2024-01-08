using app_inventario.Clases;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Reflection;
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

        private void tb_buscar_KeyPress(object sender, KeyPressEventArgs e)
        {

            MySqlConnection conexionbd = Clases.conexion.establecerConexion();
            conexionbd.Open();

            MySqlCommand comando = new MySqlCommand();
            comando.Connection = conexionbd;
            MySqlDataAdapter adapter = new MySqlDataAdapter(comando);


            comando.CommandText = ("Select * from compras_precio INNER JOIN valor_venta ON valor_venta.id_venta = compras_precio.id_compras_precio where nom_compra LIKE  '%" + tb_buscar.Text + "%'");
            DataTable tabla = new DataTable();

            adapter.Fill(tabla);
            dataGridView1.DataSource = tabla;
            conexionbd.Close();




        }
        
      


        private void tb_buscar_MouseHover(object sender, EventArgs e)
        {




        }

        private void button1_Click(object sender, EventArgs e)
        {

            MySqlConnection conexionbd = Clases.conexion.establecerConexion();
            conexionbd.Open();

            MySqlCommand comando = new MySqlCommand();
            comando.Connection = conexionbd;
            MySqlDataAdapter adapter = new MySqlDataAdapter(comando);


            comando.CommandText = ("Select * from compras_precio INNER JOIN valor_venta ON valor_venta.id_venta = compras_precio.id_compras_precio where nom_compra LIKE  '%" + tb_buscar.Text + "%'");
            DataTable tabla = new DataTable();

            adapter.Fill(tabla);
            dataGridView1.DataSource = tabla;
            conexionbd.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pn_ing_proveedor.Visible = true;
            pn_ing_precio_compra.Visible = false;
            pn_ing_val_venta.Visible = false;

            MySqlConnection conexionbd = Clases.conexion.establecerConexion();
            conexionbd.Open();

            MySqlCommand comando = new MySqlCommand();
            comando.Connection = conexionbd;
            MySqlDataAdapter adapter = new MySqlDataAdapter(comando);


            comando.CommandText = ("Select MAX(id_proveedor) from proveedores;");
            DataTable tabla = new DataTable();
            adapter.Fill(tabla);

               
            conexionbd.Close();


            if (tabla.Rows.Count > 0)
            {

                string aaaaa = tabla.Rows[0][0].ToString();
                int resultado = Convert.ToInt32(aaaaa);
                int i = 1;
                resultado =resultado+i;

                tb_id_proveedor.Text = resultado.ToString();


            }
           

        }

        
        private void btn_ing_compra_Click(object sender, EventArgs e)
        {
            pn_ing_proveedor.Visible = false;
            pn_ing_precio_compra.Visible = true;
            pn_ing_val_venta.Visible = false;

            MySqlConnection conexionbd = Clases.conexion.establecerConexion();
            conexionbd.Open();

            MySqlCommand comando = new MySqlCommand();
            comando.Connection = conexionbd;
            MySqlDataAdapter adapter = new MySqlDataAdapter(comando);


            comando.CommandText = ("Select nom_proveedor from proveedores;");
            DataTable tabla = new DataTable();
            adapter.Fill(tabla);

            cb_prov_compra.DataSource = tabla;
            cb_prov_compra.DisplayMember = "nom_proveedor";
            cb_prov_compra.ValueMember = "nom_proveedor";
            ////////////////////////////////////////////
            ///




            
            MySqlCommand comando2 = new MySqlCommand();
            comando2.Connection = conexionbd;
            MySqlDataAdapter adapte2 = new MySqlDataAdapter(comando2);


            comando2.CommandText = ("Select MAX(id_compras_precio) from compras_precio;");
            DataTable tabla2 = new DataTable();
            adapte2.Fill(tabla2);


            conexionbd.Close();

            
            if (tabla2.Rows.Count == 0)
            {
               
                string aaaaa = tabla2.Rows[0][0].ToString();
                MessageBox.Show(aaaaa);
                int resultado = Convert.ToInt32(aaaaa);
                int i = 1;
                resultado = resultado + i;

                tb_id_com_precio.Text = resultado.ToString();


            }




            if (tabla2.Rows.Count > 0)
            {
                


                string aaaaa = tabla2.Rows[0][0].ToString();
                int resultado = Convert.ToInt32(aaaaa);
                int i = 1;
                resultado =resultado+i;

                tb_id_com_precio.Text = resultado.ToString();


            }



        }

        private void tb_id_proveedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            //VALIDAR SOLO NUMEROS EN EL TB
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btn_add_proveedor_Click(object sender, EventArgs e)
        {
            MySqlConnection conexionbd = Clases.conexion.establecerConexion();
            conexionbd.Open();

            MySqlCommand comando = new MySqlCommand();
            comando.Connection = conexionbd;
            MySqlDataAdapter adapter = new MySqlDataAdapter(comando);

            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = ("INSERT INTO proveedores (id_proveedor, nom_proveedor, des_proveedor, ubi_proveedor ) VALUES ('" + tb_id_proveedor.Text + "', '" + tb_nom_proveedor.Text + "', '" + tb_des_proveedor.Text + "', '" + tb_ubi_proveedor.Text + "');");
            cmd.Connection = conexionbd;

            cmd.ExecuteNonQuery();
            conexionbd.Close();

            MessageBox.Show("PROVEEDOR AGREGADO CORRECTAMENTE :D");


            conexionbd.Open();

            comando.Connection = conexionbd;
            MySqlDataAdapter adapter2 = new MySqlDataAdapter(comando);


            comando.CommandText = ("Select MAX(id_proveedor) from proveedores;");
            DataTable tabla = new DataTable();
            adapter2.Fill(tabla);



            conexionbd.Close();



            if (tabla.Rows.Count > 0)
            {

                string aaaaa = tabla.Rows[0][0].ToString();
                int resultado = Convert.ToInt32(aaaaa);
                int i = 1;
                resultado = resultado + i;


                tb_id_proveedor.Text = resultado.ToString();


            }

            tb_nom_proveedor.Clear();
            tb_des_proveedor.Clear();
            tb_ubi_proveedor.Clear();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void pn_ing_proveedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_add_valor_venta_Click(object sender, EventArgs e)
        {
            MySqlConnection conexionbd = Clases.conexion.establecerConexion();
            conexionbd.Open();

            MySqlCommand comando = new MySqlCommand();
            comando.Connection = conexionbd;
            MySqlDataAdapter adapter = new MySqlDataAdapter(comando);



            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = ("INSERT INTO valor_venta (id_venta, nom_item_venta, precio_venta) VALUES ('" + tb_id_venta.Text + "', '" + cb_item_venta.Text + "', '" + tb_precio_venta.Text + "');");
            cmd.Connection = conexionbd;

            cmd.ExecuteNonQuery();
            conexionbd.Close();

            MessageBox.Show("VALOR DE VENTA AGREGADO CORRECTAMENTE :D");


            conexionbd.Open();

            comando.Connection = conexionbd;
            MySqlDataAdapter adapter2 = new MySqlDataAdapter(comando);


            comando.CommandText = ("Select MAX(id_venta) from valor_venta;");
            DataTable tabla = new DataTable();
            adapter2.Fill(tabla);



            conexionbd.Close();



            if (tabla.Rows.Count > 0)
            {

                string aaaaa = tabla.Rows[0][0].ToString();
                int resultado = Convert.ToInt32(aaaaa);
                int i = 1;
                resultado = resultado + i;


                tb_id_venta.Text = resultado.ToString();

            }

            conexionbd.Close();
            tb_precio_venta.Clear();
           
        }

        private void btn_ing_val_venta_Click(object sender, EventArgs e)
        {
            pn_ing_proveedor.Visible = false;
            pn_ing_precio_compra.Visible = false;
            pn_ing_val_venta.Visible = true;

            MySqlConnection conexionbd = Clases.conexion.establecerConexion();
            conexionbd.Open();

            MySqlCommand comando = new MySqlCommand();
            comando.Connection = conexionbd;
            MySqlDataAdapter adapter = new MySqlDataAdapter(comando);

            comando.CommandText = ("Select id_compras_precio, nom_compra from compras_precio;");
            DataTable tabla = new DataTable();
            adapter.Fill(tabla);

            cb_item_venta.DataSource = tabla;
            cb_item_venta.DisplayMember = "nom_compra";
            cb_item_venta.ValueMember = "nom_compra";

        }

        private void tb_id_venta_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void tb_precio_venta_KeyPress(object sender, KeyPressEventArgs e)
        {
            //VALIDAR SOLO NUMEROS EN EL TB
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MySqlConnection conexionbd = Clases.conexion.establecerConexion();
            conexionbd.Open();

            MySqlCommand comando = new MySqlCommand();
            comando.Connection = conexionbd;
            MySqlDataAdapter adapter = new MySqlDataAdapter(comando);



            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = ("INSERT INTO compras_precio (id_compras_precio, nom_compra, precio_compra, prov_compra) VALUES ('" + tb_id_com_precio.Text + "', '" + tb_nom_compra.Text + "', '" + tb_precio_compra.Text + "', '" + cb_prov_compra.Text + "');");
            cmd.Connection = conexionbd;

            cmd.ExecuteNonQuery();
            conexionbd.Close();

            MessageBox.Show("VALOR DE COMPRA AGREGADO CORRECTAMENTE :D");


            conexionbd.Open();

            comando.Connection = conexionbd;
            MySqlDataAdapter adapter2 = new MySqlDataAdapter(comando);


            comando.CommandText = ("Select MAX(id_compras_precio) from compras_precio;");
            DataTable tabla = new DataTable();
            adapter2.Fill(tabla);



            conexionbd.Close();



            if (tabla.Rows.Count > 0)
            {

                string aaaaa = tabla.Rows[0][0].ToString();
                int resultado = Convert.ToInt32(aaaaa);
                int i = 1;
                resultado = resultado + i;


                tb_id_com_precio.Text = resultado.ToString();

            }

           conexionbd.Close();
           tb_nom_compra.Clear();
           tb_precio_compra.Clear(); tb_precio_compra.Clear();

        }

        private void cb_item_venta_SelectedIndexChanged(object sender, EventArgs e)
        {
                              
            MySqlConnection conexionbd = Clases.conexion.establecerConexion();
            conexionbd.Open();

            MySqlCommand comando = new MySqlCommand();
            comando.Connection = conexionbd;
            MySqlDataAdapter adapter = new MySqlDataAdapter(comando);

            comando.CommandText = ("Select id_compras_precio from compras_precio WHERE nom_compra = '" + cb_item_venta.Text + "';");
            DataTable tabla = new DataTable();
            adapter.Fill(tabla);

            if( tabla.Rows.Count > 0){

                string aaaaa = tabla.Rows[0][0].ToString();

                tb_id_venta.Text = aaaaa;
            }

            

        }

        private void cb_item_venta_SelectedValueChanged(object sender, EventArgs e)
        {

           
        }

        private void cb_item_venta_SelectionChangeCommitted(object sender, EventArgs e)
        {
            

        }

        private void tb_precio_compra_KeyPress(object sender, KeyPressEventArgs e)
        {
            //VALIDAR SOLO NUMEROS EN EL TB
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void cb_item_venta_TextUpdate(object sender, EventArgs e)
        {
           
        }

        private void cb_item_venta_TabIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cb_item_venta_DisplayMemberChanged(object sender, EventArgs e)
        {
           
        }

        private void tb_main_Selected(object sender, TabControlEventArgs e)
        {
            pn_ing_val_venta.Visible = false;
            pn_ing_precio_compra.Visible = false;
            pn_ing_proveedor.Visible = false;
        }

        private void tb_id_com_precio_KeyPress(object sender, KeyPressEventArgs e)
        {
            //VALIDAR SOLO NUMEROS EN EL TB
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void tb_id_com_precio_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
