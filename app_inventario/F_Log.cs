using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app_inventario
{
    public partial class F_Log : Form
    {
        public F_Log()
        {
            InitializeComponent();
            this.TopMost = true;
        }

        private void btn_entrar_Click(object sender, EventArgs e)
        {
            string usuario = tb_user.Text;
            string contrasena = tb_user.Text;
            if (usuario == "julian" && contrasena == "julian") {

                this.Close();
            }
            else{
                MessageBox.Show("usuario o contraseña incorrecto");
                this.TopMost = true;
            }
        }
    }
}
