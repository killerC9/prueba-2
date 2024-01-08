namespace app_inventario
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tb_main = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_buscar = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_ing_compra = new System.Windows.Forms.Button();
            this.btn_ing_val_venta = new System.Windows.Forms.Button();
            this.btn_ing_proveedor = new System.Windows.Forms.Button();
            this.pn_ing_proveedor = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_add_proveedor = new System.Windows.Forms.Button();
            this.tb_id_proveedor = new System.Windows.Forms.TextBox();
            this.tb_nom_proveedor = new System.Windows.Forms.TextBox();
            this.tb_des_proveedor = new System.Windows.Forms.TextBox();
            this.tb_ubi_proveedor = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pn_ing_val_venta = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_id_venta = new System.Windows.Forms.TextBox();
            this.btn_add_valor_venta = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tb_precio_venta = new System.Windows.Forms.TextBox();
            this.pn_ing_precio_compra = new System.Windows.Forms.Panel();
            this.tb_precio_compra = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tb_nom_compra = new System.Windows.Forms.TextBox();
            this.tb_id_com_precio = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.cb_prov_compra = new System.Windows.Forms.ComboBox();
            this.cb_item_venta = new System.Windows.Forms.ComboBox();
            this.tb_main.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.pn_ing_proveedor.SuspendLayout();
            this.pn_ing_val_venta.SuspendLayout();
            this.pn_ing_precio_compra.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_main
            // 
            this.tb_main.Controls.Add(this.tabPage1);
            this.tb_main.Controls.Add(this.tabPage2);
            this.tb_main.Controls.Add(this.tabPage3);
            this.tb_main.Controls.Add(this.tabPage4);
            this.tb_main.ItemSize = new System.Drawing.Size(50, 30);
            this.tb_main.Location = new System.Drawing.Point(22, 86);
            this.tb_main.Name = "tb_main";
            this.tb_main.SelectedIndex = 0;
            this.tb_main.Size = new System.Drawing.Size(1226, 553);
            this.tb_main.TabIndex = 0;
            this.tb_main.Selected += new System.Windows.Forms.TabControlEventHandler(this.tb_main_Selected);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.tb_buscar);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1218, 515);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "CONSULTAR";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(795, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(115, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "BUSCAR :";
            // 
            // tb_buscar
            // 
            this.tb_buscar.AccessibleDescription = "";
            this.tb_buscar.Location = new System.Drawing.Point(206, 18);
            this.tb_buscar.Name = "tb_buscar";
            this.tb_buscar.Size = new System.Drawing.Size(341, 20);
            this.tb_buscar.TabIndex = 1;
            this.tb_buscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_buscar_KeyPress);
            this.tb_buscar.MouseHover += new System.EventHandler(this.tb_buscar_MouseHover);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(101, 52);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(977, 404);
            this.dataGridView1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btn_ing_proveedor);
            this.tabPage2.Controls.Add(this.btn_ing_val_venta);
            this.tabPage2.Controls.Add(this.btn_ing_compra);
            this.tabPage2.Controls.Add(this.pn_ing_val_venta);
            this.tabPage2.Controls.Add(this.pn_ing_proveedor);
            this.tabPage2.Controls.Add(this.pn_ing_precio_compra);
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1218, 515);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "INGRESAR";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 34);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1218, 515);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "MODIFICAR";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 34);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1218, 515);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "ELIMINAR";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "INVENTARIO";
            // 
            // btn_ing_compra
            // 
            this.btn_ing_compra.Location = new System.Drawing.Point(77, 23);
            this.btn_ing_compra.Name = "btn_ing_compra";
            this.btn_ing_compra.Size = new System.Drawing.Size(187, 47);
            this.btn_ing_compra.TabIndex = 0;
            this.btn_ing_compra.Text = "INGRESAR COMPRAS";
            this.btn_ing_compra.UseVisualStyleBackColor = true;
            this.btn_ing_compra.Click += new System.EventHandler(this.btn_ing_compra_Click);
            // 
            // btn_ing_val_venta
            // 
            this.btn_ing_val_venta.Location = new System.Drawing.Point(372, 23);
            this.btn_ing_val_venta.Name = "btn_ing_val_venta";
            this.btn_ing_val_venta.Size = new System.Drawing.Size(187, 47);
            this.btn_ing_val_venta.TabIndex = 1;
            this.btn_ing_val_venta.Text = "INGRESAR VALOR VENTA";
            this.btn_ing_val_venta.UseVisualStyleBackColor = true;
            this.btn_ing_val_venta.Click += new System.EventHandler(this.btn_ing_val_venta_Click);
            // 
            // btn_ing_proveedor
            // 
            this.btn_ing_proveedor.Location = new System.Drawing.Point(629, 23);
            this.btn_ing_proveedor.Name = "btn_ing_proveedor";
            this.btn_ing_proveedor.Size = new System.Drawing.Size(187, 47);
            this.btn_ing_proveedor.TabIndex = 2;
            this.btn_ing_proveedor.Text = "INGRESAR PROVEEDOR";
            this.btn_ing_proveedor.UseVisualStyleBackColor = true;
            this.btn_ing_proveedor.Click += new System.EventHandler(this.button3_Click);
            // 
            // pn_ing_proveedor
            // 
            this.pn_ing_proveedor.Controls.Add(this.label7);
            this.pn_ing_proveedor.Controls.Add(this.tb_ubi_proveedor);
            this.pn_ing_proveedor.Controls.Add(this.tb_des_proveedor);
            this.pn_ing_proveedor.Controls.Add(this.tb_nom_proveedor);
            this.pn_ing_proveedor.Controls.Add(this.tb_id_proveedor);
            this.pn_ing_proveedor.Controls.Add(this.btn_add_proveedor);
            this.pn_ing_proveedor.Controls.Add(this.label6);
            this.pn_ing_proveedor.Controls.Add(this.label5);
            this.pn_ing_proveedor.Controls.Add(this.label4);
            this.pn_ing_proveedor.Controls.Add(this.label3);
            this.pn_ing_proveedor.Location = new System.Drawing.Point(76, 122);
            this.pn_ing_proveedor.Name = "pn_ing_proveedor";
            this.pn_ing_proveedor.Size = new System.Drawing.Size(759, 337);
            this.pn_ing_proveedor.TabIndex = 3;
            this.pn_ing_proveedor.Paint += new System.Windows.Forms.PaintEventHandler(this.pn_ing_proveedor_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "ID_PROVEEDOR :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "NOMBRE :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "DESCRIPCION :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(43, 189);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "UBICACION :";
            // 
            // btn_add_proveedor
            // 
            this.btn_add_proveedor.Location = new System.Drawing.Point(155, 238);
            this.btn_add_proveedor.Name = "btn_add_proveedor";
            this.btn_add_proveedor.Size = new System.Drawing.Size(205, 40);
            this.btn_add_proveedor.TabIndex = 4;
            this.btn_add_proveedor.Text = "AGREGAR NUEVO PROVEEDOR";
            this.btn_add_proveedor.UseVisualStyleBackColor = true;
            this.btn_add_proveedor.Click += new System.EventHandler(this.btn_add_proveedor_Click);
            // 
            // tb_id_proveedor
            // 
            this.tb_id_proveedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tb_id_proveedor.Enabled = false;
            this.tb_id_proveedor.Location = new System.Drawing.Point(120, 70);
            this.tb_id_proveedor.MaxLength = 7;
            this.tb_id_proveedor.Name = "tb_id_proveedor";
            this.tb_id_proveedor.Size = new System.Drawing.Size(72, 20);
            this.tb_id_proveedor.TabIndex = 5;
            this.tb_id_proveedor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_id_proveedor_KeyPress);
            // 
            // tb_nom_proveedor
            // 
            this.tb_nom_proveedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tb_nom_proveedor.Location = new System.Drawing.Point(120, 106);
            this.tb_nom_proveedor.MaxLength = 60;
            this.tb_nom_proveedor.Name = "tb_nom_proveedor";
            this.tb_nom_proveedor.Size = new System.Drawing.Size(168, 20);
            this.tb_nom_proveedor.TabIndex = 6;
            // 
            // tb_des_proveedor
            // 
            this.tb_des_proveedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tb_des_proveedor.Location = new System.Drawing.Point(120, 145);
            this.tb_des_proveedor.MaxLength = 60;
            this.tb_des_proveedor.Name = "tb_des_proveedor";
            this.tb_des_proveedor.Size = new System.Drawing.Size(296, 20);
            this.tb_des_proveedor.TabIndex = 7;
            // 
            // tb_ubi_proveedor
            // 
            this.tb_ubi_proveedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tb_ubi_proveedor.Location = new System.Drawing.Point(120, 186);
            this.tb_ubi_proveedor.MaxLength = 50;
            this.tb_ubi_proveedor.Name = "tb_ubi_proveedor";
            this.tb_ubi_proveedor.Size = new System.Drawing.Size(296, 20);
            this.tb_ubi_proveedor.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(27, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(247, 24);
            this.label7.TabIndex = 9;
            this.label7.Text = "INSERTAR PROVEEDOR";
            // 
            // pn_ing_val_venta
            // 
            this.pn_ing_val_venta.Controls.Add(this.cb_item_venta);
            this.pn_ing_val_venta.Controls.Add(this.tb_precio_venta);
            this.pn_ing_val_venta.Controls.Add(this.label8);
            this.pn_ing_val_venta.Controls.Add(this.tb_id_venta);
            this.pn_ing_val_venta.Controls.Add(this.btn_add_valor_venta);
            this.pn_ing_val_venta.Controls.Add(this.label10);
            this.pn_ing_val_venta.Controls.Add(this.label11);
            this.pn_ing_val_venta.Controls.Add(this.label12);
            this.pn_ing_val_venta.Location = new System.Drawing.Point(79, 119);
            this.pn_ing_val_venta.Name = "pn_ing_val_venta";
            this.pn_ing_val_venta.Size = new System.Drawing.Size(759, 337);
            this.pn_ing_val_venta.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(34, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(297, 24);
            this.label8.TabIndex = 9;
            this.label8.Text = "INSERTAR VALOR DE VENTA";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // tb_id_venta
            // 
            this.tb_id_venta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tb_id_venta.Enabled = false;
            this.tb_id_venta.Location = new System.Drawing.Point(151, 70);
            this.tb_id_venta.MaxLength = 7;
            this.tb_id_venta.Name = "tb_id_venta";
            this.tb_id_venta.Size = new System.Drawing.Size(72, 20);
            this.tb_id_venta.TabIndex = 5;
            this.tb_id_venta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_id_venta_KeyPress);
            // 
            // btn_add_valor_venta
            // 
            this.btn_add_valor_venta.Location = new System.Drawing.Point(155, 238);
            this.btn_add_valor_venta.Name = "btn_add_valor_venta";
            this.btn_add_valor_venta.Size = new System.Drawing.Size(205, 40);
            this.btn_add_valor_venta.TabIndex = 4;
            this.btn_add_valor_venta.Text = "AGREGAR VALOR DE VENTA";
            this.btn_add_valor_venta.UseVisualStyleBackColor = true;
            this.btn_add_valor_venta.Click += new System.EventHandler(this.btn_add_valor_venta_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(35, 148);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(110, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "PRECIO DE VENTA :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(17, 109);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(128, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "NOMBRE ITEM VENTA :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(79, 73);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(66, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "ID_VENTA :";
            // 
            // tb_precio_venta
            // 
            this.tb_precio_venta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tb_precio_venta.Location = new System.Drawing.Point(151, 145);
            this.tb_precio_venta.MaxLength = 10;
            this.tb_precio_venta.Name = "tb_precio_venta";
            this.tb_precio_venta.Size = new System.Drawing.Size(104, 20);
            this.tb_precio_venta.TabIndex = 10;
            this.tb_precio_venta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_precio_venta_KeyPress);
            // 
            // pn_ing_precio_compra
            // 
            this.pn_ing_precio_compra.Controls.Add(this.cb_prov_compra);
            this.pn_ing_precio_compra.Controls.Add(this.label16);
            this.pn_ing_precio_compra.Controls.Add(this.tb_precio_compra);
            this.pn_ing_precio_compra.Controls.Add(this.label9);
            this.pn_ing_precio_compra.Controls.Add(this.tb_nom_compra);
            this.pn_ing_precio_compra.Controls.Add(this.tb_id_com_precio);
            this.pn_ing_precio_compra.Controls.Add(this.button2);
            this.pn_ing_precio_compra.Controls.Add(this.label13);
            this.pn_ing_precio_compra.Controls.Add(this.label14);
            this.pn_ing_precio_compra.Controls.Add(this.label15);
            this.pn_ing_precio_compra.Location = new System.Drawing.Point(76, 122);
            this.pn_ing_precio_compra.Name = "pn_ing_precio_compra";
            this.pn_ing_precio_compra.Size = new System.Drawing.Size(713, 337);
            this.pn_ing_precio_compra.TabIndex = 11;
            // 
            // tb_precio_compra
            // 
            this.tb_precio_compra.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tb_precio_compra.Location = new System.Drawing.Point(189, 142);
            this.tb_precio_compra.MaxLength = 10;
            this.tb_precio_compra.Name = "tb_precio_compra";
            this.tb_precio_compra.Size = new System.Drawing.Size(104, 20);
            this.tb_precio_compra.TabIndex = 10;
            this.tb_precio_compra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_precio_compra_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(38, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(322, 24);
            this.label9.TabIndex = 9;
            this.label9.Text = "INSERTAR PRECIO DE COMPRA";
            // 
            // tb_nom_compra
            // 
            this.tb_nom_compra.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tb_nom_compra.Location = new System.Drawing.Point(189, 106);
            this.tb_nom_compra.MaxLength = 50;
            this.tb_nom_compra.Name = "tb_nom_compra";
            this.tb_nom_compra.Size = new System.Drawing.Size(168, 20);
            this.tb_nom_compra.TabIndex = 6;
            // 
            // tb_id_com_precio
            // 
            this.tb_id_com_precio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tb_id_com_precio.Enabled = false;
            this.tb_id_com_precio.Location = new System.Drawing.Point(189, 70);
            this.tb_id_com_precio.MaxLength = 7;
            this.tb_id_com_precio.Name = "tb_id_com_precio";
            this.tb_id_com_precio.Size = new System.Drawing.Size(72, 20);
            this.tb_id_com_precio.TabIndex = 5;
            this.tb_id_com_precio.TextChanged += new System.EventHandler(this.tb_id_com_precio_TextChanged);
            this.tb_id_com_precio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_id_com_precio_KeyPress);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(155, 238);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(205, 40);
            this.button2.TabIndex = 4;
            this.button2.Text = "AGREGAR COMPRA";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(50, 145);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(133, 13);
            this.label13.TabIndex = 2;
            this.label13.Text = "PRECIO DE LA COMPRA:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(77, 110);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(106, 13);
            this.label14.TabIndex = 1;
            this.label14.Text = "NOMBRE COMPRA:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(107, 77);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(76, 13);
            this.label15.TabIndex = 0;
            this.label15.Text = "ID_COMPRA :";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(22, 183);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(161, 13);
            this.label16.TabIndex = 11;
            this.label16.Text = "PROVEEDOR DE LA COMPRA:";
            // 
            // cb_prov_compra
            // 
            this.cb_prov_compra.FormattingEnabled = true;
            this.cb_prov_compra.Location = new System.Drawing.Point(189, 180);
            this.cb_prov_compra.Name = "cb_prov_compra";
            this.cb_prov_compra.Size = new System.Drawing.Size(199, 21);
            this.cb_prov_compra.TabIndex = 12;
            // 
            // cb_item_venta
            // 
            this.cb_item_venta.FormattingEnabled = true;
            this.cb_item_venta.Location = new System.Drawing.Point(151, 102);
            this.cb_item_venta.Name = "cb_item_venta";
            this.cb_item_venta.Size = new System.Drawing.Size(233, 21);
            this.cb_item_venta.TabIndex = 11;
            this.cb_item_venta.SelectedIndexChanged += new System.EventHandler(this.cb_item_venta_SelectedIndexChanged);
            this.cb_item_venta.SelectionChangeCommitted += new System.EventHandler(this.cb_item_venta_SelectionChangeCommitted);
            this.cb_item_venta.TextUpdate += new System.EventHandler(this.cb_item_venta_TextUpdate);
            this.cb_item_venta.DisplayMemberChanged += new System.EventHandler(this.cb_item_venta_DisplayMemberChanged);
            this.cb_item_venta.SelectedValueChanged += new System.EventHandler(this.cb_item_venta_SelectedValueChanged);
            this.cb_item_venta.TabIndexChanged += new System.EventHandler(this.cb_item_venta_TabIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_main);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tb_main.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.pn_ing_proveedor.ResumeLayout(false);
            this.pn_ing_proveedor.PerformLayout();
            this.pn_ing_val_venta.ResumeLayout(false);
            this.pn_ing_val_venta.PerformLayout();
            this.pn_ing_precio_compra.ResumeLayout(false);
            this.pn_ing_precio_compra.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tb_main;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_buscar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_ing_proveedor;
        private System.Windows.Forms.Button btn_ing_val_venta;
        private System.Windows.Forms.Button btn_ing_compra;
        private System.Windows.Forms.Panel pn_ing_proveedor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_id_proveedor;
        private System.Windows.Forms.Button btn_add_proveedor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_ubi_proveedor;
        private System.Windows.Forms.TextBox tb_des_proveedor;
        private System.Windows.Forms.TextBox tb_nom_proveedor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel pn_ing_val_venta;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_id_venta;
        private System.Windows.Forms.Button btn_add_valor_venta;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tb_precio_venta;
        private System.Windows.Forms.Panel pn_ing_precio_compra;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox tb_precio_compra;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tb_nom_compra;
        private System.Windows.Forms.TextBox tb_id_com_precio;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cb_prov_compra;
        private System.Windows.Forms.ComboBox cb_item_venta;
    }
}

