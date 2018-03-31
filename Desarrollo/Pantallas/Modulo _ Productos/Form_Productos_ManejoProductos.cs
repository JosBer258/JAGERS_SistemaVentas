using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Desarrollo.Clases;
using Desarrollo.Pantallas.Manueales;
using System.IO;
using System.Reflection;
using iTextSharp.text;
using iTextSharp.text.pdf;



namespace Desarrollo.Pantallas.Modulo___Productos
{
    public partial class Form_Productos_ManejoProductos : System.Windows.Forms.Form
    {
        Conexion Conn = new Conexion();
        C_DatoHistoricos HisDatos = new C_DatoHistoricos();
        Validaciones Valid = new Validaciones();
        C_Productos Products = new C_Productos();
        C_Categoria_Productos Categ = new C_Categoria_Productos();

        public string comparar;
        public string Localidad;
        public string EmpNombr;



        public Form_Productos_ManejoProductos()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void Cargar()
        {
            Products.ExtrearTodo(Pest2_DataGriew_Productos);
            Fun_llenarCategoria();
        }

        private void Form_Productos_ManejoProductos_Load(object sender, EventArgs e)
        {
            Pest3_ComboBox_Localidad.Enabled = false;
            if (Localidad == "1" || Localidad == "2")
            {   label2.Visible = true;
                Pest1_Txt_TotalBodega.Visible = true;
            }
            else{ label2.Visible = false;
                  Pest1_Txt_TotalBodega.Visible = false;
            }


            //BUSCAR PRODUCTOS
            Products.ExtrearTodo(Pest2_DataGriew_Productos);           
            OptenerUltimoCodigoProducto();
            Fun_llenarPRO();
            Cargar();
            Products.ExtraerEstadosMarcas(Pest5_Radio_Manejo_Estados);
            Products.Fun_ExtraerEstados(Pest3_ComBox_Estado);

            Pest2_Txt_NombreFiltro.Enabled = false;
            Pest2_Txt_CodigoFiltro.Enabled = false;
            Pest2_Radio_Nombre.Checked = true;
            Pest4_Txt_Manejo_CodCategoria.Enabled = false;
            Pest4_Txt_Manejo_Categoria.Enabled = false;
            Pest4_Txt_Busqueda_CodCategoria.Enabled = false;
            Pest4_Txt_Busqueda_Categoria.Enabled = false;
            Pest4_Radio_Agregar.Checked = true;
            Pest5_Radio_Buscar.Checked = true;
            radioButton1.Checked = true;
            Pest3_Txt_Codigo.Enabled = false;
            Pest3_Txt_Nombre.Enabled = false;
            Pest3_Txt_Categorias.Enabled = false;
            Pest3_Txt_Modelo.Enabled = false;
            Pest6_Txt_Manejo_CodigoModulo.Enabled = false;
            Pest6_Txt_Manejo_Descripcion.Enabled = false;
            Pest6_Txt_Manejo_FiltroMarca.Enabled = false;
            Pest6_ComboBox_Manejo_ResultadoMarca.Enabled = false;
            Pest6_Txt_Busqueda_CodigoModelo.Enabled = false;
            Pest6_Txt_Busqueda_Descripcion.Enabled = false;
            Pest6_Txt_Busqueda_CodigoMarca.Enabled = false;
            Pest6_ComBox_Busqueda_Estados.Enabled = false;
            Pest6_Bttn_Busqueda_Aceptar.Enabled = false;


            Categ.Fun_CargarPrimerDataGriew(Pest4_DataGrid_Categoria);
            this.modeloTableAdapter.Fill(this.ventasAutoPartesDataSet.Modelo);
            this.marcaTableAdapter.Fill(this.ventasAutoPartesDataSet.Marca);
            Pest6_Bttn_Manejo_Aceptar.Enabled = false;
            Products.Pest6_Fun_llenarEstadoModelo(Pest6_ComBox_Busqueda_Estados); 


            Pest6_Radio_Agregar.Checked = true;


            validacionMenu();
            validacionMenu2_GrupoManejo();
            Fun_ExtraerCodigo();
            validacionMenu_GrupoBuscar();
            actualizar(Pest5_DataGriewMarcas);


            var blankContextMenu = new ContextMenuStrip();
            Pest5_Txt_Manejo_Descripcion.ContextMenuStrip = blankContextMenu;
            Pest5_TxtDescipcionBuscar.ContextMenuStrip = blankContextMenu;
            Pest2_Txt_NombreFiltro.ContextMenuStrip = blankContextMenu;
            Pest2_Txt_CodigoFiltro.ContextMenuStrip = blankContextMenu;
            Pest1_Txt_Nombre.ContextMenuStrip = blankContextMenu;
            Pest1_Txt_PrecioVentas.ContextMenuStrip = blankContextMenu;
            Pest1_Txt_PrecioCompras.ContextMenuStrip = blankContextMenu;
            Pest1_Txt_TotalEnTienda.ContextMenuStrip = blankContextMenu;
            Pest1_Txt_TotalBodega.ContextMenuStrip = blankContextMenu;
            Pest1_CuadroTexto_Descripcion.ContextMenuStrip = blankContextMenu;
            Pest6_Txt_Manejo_Descripcion.ContextMenuStrip = blankContextMenu;
            Pest6_Txt_Busqueda_Descripcion.ContextMenuStrip = blankContextMenu;
            Pest6_Txt_Busqueda_CodigoModelo.ContextMenuStrip = blankContextMenu;
            Pest3_Cant_PorLocalidad.ContextMenuStrip = blankContextMenu;
            Pest3_Txt_PrecioVenta.ContextMenuStrip = blankContextMenu;
            Pest3_Txt_Compras.ContextMenuStrip = blankContextMenu;
            Pest1_Txt_Filtro_NombreMarca.ContextMenuStrip = blankContextMenu;
            Pest1_Txt_Filtro_NombreProveedor.ContextMenuStrip = blankContextMenu;

            

            
            
        }

        private void validacionMenu()
        {
            var blankContextMenu = new ContextMenuStrip();

            var boxes = tabPage3.Controls.OfType<TextBox>();
            foreach (var box in boxes)
            {
                box.ContextMenuStrip = blankContextMenu;

            }


            var boxe = tabPage3.Controls.OfType<TextBox>();
            foreach (var box in boxe)
            {
                box.ContextMenuStrip = blankContextMenu;

            }

            var boxex = tabPage3.Controls.OfType<ComboBox>();
            foreach (var box in boxex)
            {
                box.ContextMenuStrip = blankContextMenu;

            }


        }


        private void validacionMenu2_GrupoManejo()
        {
            var blankContextMenu = new ContextMenuStrip();

            var boxes = Pest4_Grupo_Manejo.Controls.OfType<TextBox>();
            foreach (var box in boxes)
            {
                box.ContextMenuStrip = blankContextMenu;

            }


            var boxe = Pest4_Grupo_Manejo.Controls.OfType<TextBox>();
            foreach (var box in boxe)
            {
                box.ContextMenuStrip = blankContextMenu;

            }
        }

        private void validacionMenu_GrupoBuscar()
        {
            var blankContextMenu = new ContextMenuStrip();

            var boxes = Pest4_Grupo_BusquedaModificacion.Controls.OfType<TextBox>();
            foreach (var box in boxes)
            {
                box.ContextMenuStrip = blankContextMenu;

            }


            var boxe = Pest4_Grupo_BusquedaModificacion.Controls.OfType<TextBox>();
            foreach (var box in boxe)
            {
                box.ContextMenuStrip = blankContextMenu;

            }
        }


        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.productoTableAdapter.FillBy(this.ventasAutoPartesDataSet.Producto);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }


        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }


        private void tabPage5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button18_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Pest1_Txt_Nombre.Text) || string.IsNullOrWhiteSpace(Pest1_Txt_PrecioVentas.Text) || string.IsNullOrWhiteSpace(Pest1_Txt_PrecioCompras.Text)
               || string.IsNullOrWhiteSpace(Pest1_Txt_TotalEnTienda.Text) || string.IsNullOrWhiteSpace(Pest1_Txt_TotalBodega.Text) || string.IsNullOrWhiteSpace(Pest1_CuadroTexto_Descripcion.Text)
                | Pest1_ComBox_Categoria.SelectedIndex == -1 || Pest1_ComBox_Filtro_NombreProveedor.SelectedIndex == -1 ||
                   Pest1_ComBox_Filtro_NombreMarca.SelectedIndex == -1 || Pest1_ComBox_Modelo.SelectedIndex == -1)
            {
                MessageBox.Show("No pueden quedar valores Vacios", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            Fun_AgregarProducto();
            OptenerUltimoCodigoProducto();
            Products.ExtrearTodo(Pest2_DataGriew_Productos);

        }

        public void Fun_CargarHistoricosNew()
        {
            HisDatos.Var_IngresarProductosHistoricos(Pest1_Txt_Nombre.Text, (float)Convert.ToDouble(Pest1_Txt_PrecioVentas.Text),
                (float)Convert.ToDouble(Pest1_Txt_PrecioCompras.Text), EmpNombr);
                
        }


        private void Pest1_Txt_Filtro_NombreProveedor_TextChanged(object sender, EventArgs e)
        {
            Products.Fun_Llenarproveedor(Pest1_ComBox_Filtro_NombreProveedor, Pest1_Txt_Filtro_NombreProveedor);
        }

        

        

        public void Fun_LlenarMarca()
        {
            string a;
            if (Pest1_Txt_Filtro_NombreMarca.Text == string.Empty) { return;
            }
            else
            {
                a = Pest1_Txt_Filtro_NombreMarca.Text;
            }
            Conexion Con = new Conexion();

            Con.cnx.Open();
            Con.sql = string.Format(@"select [Cod_Marca], Descripcion from Marca where Descripcion like '%{0}%'", a);
            Con.cmd = new SqlCommand(Con.sql, Con.cnx);
            Con.DataAdapter = new SqlDataAdapter(Con.cmd);
            Con.dt = new DataTable();
            Con.DataAdapter.Fill(Con.dt);
            Con.cnx.Close();

            Pest1_ComBox_Filtro_NombreMarca.ValueMember = "Cod_Marca";
            Pest1_ComBox_Filtro_NombreMarca.DisplayMember = "Descripcion";
            Pest1_ComBox_Filtro_NombreMarca.DataSource = Con.dt;
        }

        public void Limp()
        {
            Pest1_Txt_Nombre.Text = string.Empty;
           Pest1_Txt_PrecioVentas.Text = string.Empty;
            Pest1_Txt_PrecioCompras.Text = string.Empty;
            Pest1_Txt_TotalEnTienda.Text = string.Empty;
            Pest1_Txt_TotalBodega.Text = string.Empty;
            Pest1_CuadroTexto_Descripcion.Text = string.Empty;
            //Pest1_Txt_Filtro_NombreMarca;
            //Pest1_Txt_Filtro_NombreProveedor;

        }
        public void Fun_AgregarProducto()
        {
 
            string nomb = Pest1_Txt_Nombre.Text;
            float preve = Convert.ToSingle(Pest1_Txt_PrecioVentas.Text);
            float precom = Convert.ToSingle(Pest1_Txt_PrecioCompras.Text);
            int totaltie = Convert.ToInt16(Pest1_Txt_TotalEnTienda.Text);
            int totalbo = Convert.ToInt16(Pest1_Txt_TotalBodega.Text);
            string nombcat = Pest1_ComBox_Categoria.Text;
            string nombmod = Pest1_ComBox_Modelo.Text;
            string descrip = Pest1_CuadroTexto_Descripcion.Text;
            int codprov = Convert.ToInt16(Pest1_Txt_Filtro_NombreProveedor.Text);

            int CodCateg;
            int CodModelo;
            int CodEstado;
            Conexion Con = new Conexion();    
            CodCateg = Convert.ToInt16(Pest1_ComBox_Categoria.SelectedValue);
            CodModelo = Convert.ToInt16(Pest1_ComBox_Modelo.SelectedValue);
            CodEstado = Convert.ToInt16(1);
            codprov = Convert.ToInt16(Pest1_ComBox_Filtro_NombreProveedor.SelectedValue);

            Con.sql = string.Format(@"insert into [dbo].[Producto] (NombreProducto, Descripcion, PrecioVenta, 
                                     PrecioCompra,Cod_Modelo, Cod_Proveedor, Cod_Categoria, Cod_Estado) values 
                                    ('{0}', '{1}', {2}, {3}, {4}, {5},{6},{7})", nomb, descrip, preve, precom,  CodModelo, codprov, CodCateg, CodEstado);
            try
            {
                Con.cmd = new SqlCommand(Con.sql, Con.cnx);
                Con.cnx.Open();
                SqlDataReader Reg = null;
                Reg = Con.cmd.ExecuteReader();
                Fun_CargarHistoricosNew();
                Products.ExtrearTodo(Pest2_DataGriew_Productos);
                
            }
            catch (Exception )
            {
                MessageBox.Show("Ocurrio un error en el ingreso del nuevo Producto","Esto es embarasoso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Products.ExtrearTodo(Pest2_DataGriew_Productos);
            }
            Con.cnx.Close();
            //AGREGAR LAS CANTIDADES
            if (Localidad=="1" || Localidad == "2")
            {
                AgregarPorSucursalNormal(Convert.ToInt16(Pest1_Txt_TotalEnTienda.Text), Convert.ToInt16(1));
                AgregarPorDodega(Convert.ToInt32(Pest1_Txt_TotalBodega.Text), Convert.ToInt32(2));
            }
            else
            {
                AgregarPorSucursalNormal(Convert.ToInt32(Pest1_Txt_TotalEnTienda.Text), Convert.ToInt32(Localidad));
            }
            Limp();

        }

        public void AgregarPorSucursalNormal(int Cant, int Local)
        {
            Conn.sql = string.Format(@"insert into [Producto|Localidad] (Cod_Localidad, Cod_Producto, Cantidad) values 
                                      ('{0}',(select top 1 Cod_Producto from Producto order by Cod_Producto desc),'{1}')", Local, Cant);
            
                Conn.cmd = new SqlCommand(Conn.sql, Conn.cnx);
                Conn.cnx.Open();
                SqlDataReader Reg = null;
                Reg = Conn.cmd.ExecuteReader();
                Conn.cnx.Close();
            
        }
        
        public void AgregarPorDodega(int Cant, int Loc)
        { 
            Conn.sql = string.Format(@"insert into [Producto|Localidad] (Cod_Localidad, Cod_Producto, Cantidad) values 
                                    ('{0}',(select top 1 Cod_Producto from Producto order by Cod_Producto desc),'{1}')", Loc, Cant);
            
                Conn.cmd = new SqlCommand(Conn.sql, Conn.cnx);
                Conn.cnx.Open();
                SqlDataReader Reg = null;
                Reg = Conn.cmd.ExecuteReader();
                Conn.cnx.Close();
           
        }

        private void Fun_llenarCategoria()
        {
            Conexion Con = new Conexion();

            string mostrar;

            Con.cnx.Open();
            mostrar = Con.sql = string.Format(@"select Codigo_Categoria, Descripcion from Categoria_Producto");
            Con.cmd = new SqlCommand(Con.sql, Con.cnx);
            Con.DataAdapter = new SqlDataAdapter(Con.cmd);
            Con.dt = new DataTable();
            Con.DataAdapter.Fill(Con.dt);
            Con.cnx.Close();

            Pest1_ComBox_Categoria.ValueMember = "Codigo_Categoria";
            Pest1_ComBox_Categoria.DisplayMember = "Descripcion";
            Pest1_ComBox_Categoria.DataSource = Con.dt;
        }


        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Pest1_Txt_Filtro_NombreMarca_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Pest1_ComBox_Modelo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Pest1_Txt_Nombre_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void Pest1_Txt_PrecioCompras_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Pest1_Txt_Filtro_NombreProveedor_TextChanged_1(object sender, EventArgs e)
        {
            Products.Fun_Llenarproveedor(Pest1_ComBox_Filtro_NombreProveedor, Pest1_Txt_Filtro_NombreProveedor);
        }

        private void Pest1_Txt_Filtro_NombreMarca_TextChanged_1(object sender, EventArgs e)
        {
            Fun_LlenarMarca();
        }

        private void Pest4_Bttn_AceptarManejo_Click(object sender, EventArgs e)
        {         
        }

        private void Pest4_Radio_Agregar_CheckedChanged(object sender, EventArgs e)
        {
            if (Pest4_Radio_Agregar.Checked == true)//CASO: Agregar 
            {
                Fun_ExtraerCodigo();
                Pest4_Txt_Manejo_CodCategoria.Enabled = false;
                Pest4_Txt_Manejo_Categoria.Enabled = true;
                Pest4_Txt_Busqueda_CodCategoria.Enabled = false;


            }
        }


        public void Fun_CargarDataGriew(DataGridView dgv)
        {
            Conexion con = new Conexion();
            con.cnx.Open();
            try
            {
                con.DataAdapter = new SqlDataAdapter("select * from Categoria_Producto where Codigo_Categoria like '{0}'", con.ccnx);
                con.dt = new DataTable();
                con.DataAdapter.Fill(con.dt);
                dgv.DataSource = con.dt;

            }
            catch
            {

            }
        }

      

        public void Fun_CargarPorNombre(DataGridView dgv, string a)
        {
            Conexion con = new Conexion();
            con.cnx.Open();
            try
            {
                string busq;
                busq = a;


                con.sql = string.Format(@"select * from Categoria_Producto where Descripcion like '%{0}%'", busq);
                con.cmd = new SqlCommand(con.sql, con.cnx);
                con.DataAdapter = new SqlDataAdapter(con.cmd);
                con.dt = new DataTable();
                con.DataAdapter.Fill(con.dt);
                dgv.DataSource = con.dt;

            }
            catch
            {

            }
        }

        private void Pest4_Txt_Manejo_CodCategoria_TextChanged(object sender, EventArgs e)
        {

        }

        private void Pest4_Txt_Busqueda_CodCategoria_TextChanged(object sender, EventArgs e)
        {
           

            if (Pest4_Txt_Busqueda_CodCategoria.Text == "")
            {               
                if (Pest4_Txt_Busqueda_CodCategoria.Text == string.Empty)
                    Categ.Fun_CargarPrimerDataGriew(Pest4_DataGrid_Categoria);
            }
            else
            {
                Products.Fun_CargarPorCodigo(Pest4_DataGrid_Categoria, 
                    Convert.ToInt16(Convert.ToInt16(Pest4_Txt_Busqueda_CodCategoria.Text)));
            }
        }

        private void Pest4_Txt_Busqueda_Categoria_TextChanged(object sender, EventArgs e)
        {
            if (Pest4_Txt_Busqueda_Categoria.Text == "")
            {
                C_Categoria_Productos categoria = new C_Categoria_Productos();
                if (Pest4_Txt_Busqueda_Categoria.Text == string.Empty)
                    categoria.Fun_CargarPrimerDataGriew(Pest4_DataGrid_Categoria);

            }
            else
            {
                Fun_CargarPorNombre(Pest4_DataGrid_Categoria, Pest4_Txt_Busqueda_Categoria.Text);
            }
        }

        private void Pest2_DataGriew_Productos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = this.Pest2_DataGriew_Productos.Rows[e.RowIndex];
                Fun_llenarPRO();
                Pest3_Txt_Codigo.Text = row.Cells["Codigo del Producto"].Value.ToString();
                Pest3_Txt_Nombre.Text = row.Cells["Nombre"].Value.ToString();
                Pest3_ComBox_Estado.SelectedValue = row.Cells["Codigo de Estado"].Value.ToString();
                Pest3_Txt_PrecioVenta.Text = row.Cells[" Precio de Venta"].Value.ToString();
                Pest3_Txt_Compras.Text = row.Cells["Precio de Compra"].Value.ToString();
                Pest3_Txt_Categorias.Text = row.Cells["Descripcion de Categoria"].Value.ToString();
                Pest3_Txt_Modelo.Text = row.Cells["Descripcion del Modelo"].Value.ToString();
                Pest3_Txt_NombreMarca.Text = row.Cells["Marca"].Value.ToString();
                comboBox1.SelectedValue = Convert.ToInt32(row.Cells["Codigo del Proveedor"].Value.ToString());
                textBox1.Text = row.Cells["Descripcion"].Value.ToString();
                Products.Fun_LLenarLocalidades(Pest3_ComboBox_Localidad);
                if (Localidad == "1" || Localidad == "2")
                {
                    Products.Fun_CargarLocalidad(dataGridView1, Pest3_Txt_Codigo.Text);
                }
                else
                {
                    Products.Fun_CargarLocalidadIndividual(dataGridView1, Pest3_Txt_Codigo.Text, Localidad);
                }

                ModificarCant_PorLocalidad.Checked = true;


                MessageBox.Show("Listo");
            }
            catch (Exception)
            { }

            }





        public void ExtraerPorCodigo(int Cod)
        {
            Conexion Cn = new Conexion();
            Cn.sql = string.Format(@"select [Codigo_Categoria], [Descripcion] from Categoria_Producto where Codigo_Categoria ='{0}'", Cod);
            Cn.cmd = new SqlCommand(Cn.sql, Cn.cnx);
            Cn.cnx.Open();

            SqlDataReader Reg = null;
            Reg = Cn.cmd.ExecuteReader();

            if (Reg.Read())
            {
                Pest4_Txt_Manejo_CodCategoria.Text = (Reg["Codigo_Categoria"].ToString());
                Pest4_Txt_Manejo_Categoria.Text = (Reg["Descripcion"].ToString());
            }
            else
            {

            }
        }


        public void ExtraerPorDescripcion(string Des)
        {
            Conexion Cn = new Conexion();
            Cn.sql = string.Format(@"select [Codigo_Categoria], [Descripcion] from Categoria_Producto where Descripcion ='{0}'", Des);
            Cn.cmd = new SqlCommand(Cn.sql, Cn.cnx);
            Cn.cnx.Open();

            SqlDataReader Reg = null;
            Reg = Cn.cmd.ExecuteReader();

            if (Reg.Read())
            {
                Pest4_Txt_Manejo_CodCategoria.Text = (Reg["Codigo_Categoria"].ToString());
                Pest4_Txt_Manejo_Categoria.Text = (Reg["Descripcion"].ToString());

            }
            else
            {

            }
        }

        private void Pest4_Bttn_LimpiarDataGriew_Click(object sender, EventArgs e)
        {
            Pest4_Txt_Manejo_CodCategoria.Text = "";
            Pest4_Txt_Manejo_Categoria.Text = "";
            Fun_CargarDataGriew(Pest4_DataGrid_Categoria);
        }

        private void Pest4_Radio_BusqCodigo_CheckedChanged(object sender, EventArgs e)
        {
            if (Pest4_Radio_BusqCodigo.Enabled == true) 
            {
                Pest4_Radio_Manejo.Checked = true;
                Pest4_Txt_Manejo_Categoria.Enabled = true;
                Pest4_Txt_Busqueda_CodCategoria.Enabled = true;
                Pest4_Txt_Busqueda_Categoria.Enabled = false;
                Pest4_Txt_Manejo_CodCategoria.Enabled = false;
                Pest4_Txt_Busqueda_Categoria.Text = "";
            }
        }

        private void Pest4_Radio_busqDescripcion_CheckedChanged(object sender, EventArgs e)
        {
            if (Pest4_Radio_busqDescripcion.Enabled == true) ;
            {
                Pest4_Radio_Manejo.Checked = true;
                Pest4_Txt_Manejo_Categoria.Enabled = true;
                Pest4_Txt_Busqueda_Categoria.Enabled = true;
                Pest4_Txt_Busqueda_CodCategoria.Enabled = false;
                Pest4_Txt_Manejo_CodCategoria.Enabled = false;
                Pest4_Txt_Busqueda_CodCategoria.Text = "";
            }
        }

        public void Fun_ExtraerCodigo()
        {
            Conexion Con = new Conexion();

            Con.cnx.Open();
            Con.sql = string.Format(@"select TOP 1 Codigo_Categoria from Categoria_Producto ORDER BY Codigo_Categoria DESC");
            Con.cmd = new SqlCommand(Con.sql, Con.cnx);
            SqlDataReader Reg2 = null;
            Reg2 = Con.cmd.ExecuteReader();
            if (Reg2.Read())
            {
                comparar = Convert.ToString(Convert.ToInt16((Reg2["Codigo_Categoria"].ToString())) + 1);
                Pest4_Txt_Manejo_CodCategoria.Text = Convert.ToString(Convert.ToInt16((Reg2["Codigo_Categoria"].ToString())) + 1);
                Con.cnx.Close();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Desarrollo.Clases.C_Categoria_Productos catprod = new Clases.C_Categoria_Productos();

            if (Pest3_Txt_PrecioVenta.Text == string.Empty)
            {
                errorProvider1.SetError(Pest3_Txt_PrecioVenta, "Campo requerido");
                return;
            }
            else
            {
                errorProvider1.SetError(Pest3_Txt_PrecioVenta, "");
            }

            if (Pest3_Txt_Compras.Text == string.Empty )
            {
                errorProvider1.SetError(Pest3_Txt_Compras, "Campo requerido");
                return;
            }
            else
            {
                errorProvider1.SetError(Pest3_Txt_Compras, "");
            }


           

            catprod.Var_Codigo_producto = Convert.ToInt16(Pest3_Txt_Codigo.Text);
            catprod.Var_Precio_de_venta = Convert.ToInt16(Pest3_Txt_PrecioVenta.Text);
            catprod.Var_Precio_de_compra = Convert.ToInt16(Pest3_Txt_Compras.Text);
     
            //catprod.Var_Estado = Convert.ToUInt16(Pest3_ComBox_Estado.SelectedValue);

            catprod.Fun_Modificar(Pest3_ComBox_Estado, Convert.ToInt32(comboBox1.SelectedValue));
            HisDatos.Var_ModificarProductosHistoricos
                (Convert.ToInt32(Pest3_Txt_Codigo.Text), Pest3_Txt_Nombre.Text, (float)Convert.ToDouble(Pest3_Txt_PrecioVenta.Text),
                (float)Convert.ToDouble(Pest3_Txt_Compras.Text), EmpNombr, Convert.ToString(Pest3_ComBox_Estado.DisplayMember), "Modificar");
            MessageBox.Show("Se Modifico Correctamente");
            Products.ExtrearTodo(Pest2_DataGriew_Productos);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Pest3_Txt_Codigo.Text = "";
            Pest3_Txt_Nombre.Text = "";
            Pest3_Txt_PrecioVenta.Text = "";
            Pest3_Txt_Compras.Text = "";
            Pest3_Txt_Categorias.Text = "";

            Pest3_Txt_Modelo.Text = "";
            
            //Pest3_Txt_RichText_Descripcion.Text = "";
        }

        private void dataGridView2_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
            string a;
            a = Pest4_DataGrid_Categoria.CurrentCell.ColumnIndex.ToString();

            if (Convert.ToInt16(a) == 1 || Convert.ToInt16(a) == 0)
            {
                if (Convert.ToInt16(a) == 0)
                {
                    Pest4_Txt_Manejo_Categoria.Enabled = true;
                    Pest4_Txt_Manejo_CodCategoria.Text = Pest4_DataGrid_Categoria.CurrentCell.Value.ToString();
                    ExtraerPorCodigo(Convert.ToInt16(Pest4_Txt_Manejo_CodCategoria.Text));

                }
                else
                 if (Convert.ToInt16(a) == 1)
                {
                    Pest4_Radio_Manejo.Checked = true;
                    Pest4_Txt_Manejo_Categoria.Text = Pest4_DataGrid_Categoria.CurrentCell.Value.ToString();
                    ExtraerPorDescripcion(Pest4_Txt_Manejo_Categoria.Text);

                }
                Pest4_Txt_Busqueda_CodCategoria.Clear();
                Pest4_Txt_Busqueda_Categoria.Clear();
                C_Categoria_Productos categoria = new C_Categoria_Productos();
                categoria.Fun_CargarPrimerDataGriew(Pest4_DataGrid_Categoria);
            }
        }

        private void Pest4_Radio_Agregar_CheckedChanged_1(object sender, EventArgs e)
        {
            if (Pest4_Radio_Agregar.Checked == true)//CASO: Agregar 
            {
                Fun_ExtraerCodigo();
                Pest4_Txt_Manejo_CodCategoria.Enabled = false;
                Pest4_Txt_Manejo_Categoria.Enabled = true;
                Pest4_Txt_Busqueda_CodCategoria.Enabled = false;
                Pest4_Radio_BusqCodigo.Enabled = false;
                Pest4_Radio_busqDescripcion.Enabled = false;

            }
        }

        private void Pest4_Radio_Manejo_CheckedChanged(object sender, EventArgs e)
        {
            if (Pest4_Radio_Manejo.Checked == true)
            {
                Pest4_Radio_BusqCodigo.Enabled = true;
                Pest4_Radio_busqDescripcion.Enabled = true;
                Pest4_Radio_BusqCodigo.Checked = true;
                Pest4_Txt_Manejo_CodCategoria.Text = "";
                Pest4_Txt_Manejo_Categoria.Text = "";
                Pest4_Txt_Manejo_CodCategoria.Enabled = false;
                Pest4_Txt_Manejo_Categoria.Enabled = true;
                Pest4_Txt_Busqueda_CodCategoria.Enabled = true;
                Pest4_Txt_Busqueda_CodCategoria.Focus();

            }
        }

        private void Pest4_Bttn_AceptarManejo_Click_1(object sender, EventArgs e)
        {
            if (Pest4_Txt_Manejo_CodCategoria.Text == string.Empty)
            {
                MessageBox.Show("credenciales no validas, favor buscar categoria", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Pest4_Txt_Manejo_CodCategoria.Focus();
                return;
            }
            if (Pest4_Txt_Manejo_Categoria.Text == string.Empty)
            {
                MessageBox.Show("Favor ingresar una descripcion", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Pest4_Txt_Manejo_Categoria.Focus();
                return;
            }

            Desarrollo.Clases.C_Categoria_Productos categoria = new Clases.C_Categoria_Productos();

            categoria.Var_Codigo_categoria = Convert.ToInt16(Pest4_Txt_Manejo_CodCategoria.Text);
            categoria.Var_Descripcion_categoria = Pest4_Txt_Manejo_Categoria.Text;

            if (Pest4_Radio_Agregar.Checked == true)
            {
                categoria.Fun_Agregar();
                MessageBox.Show("Fue agregado correcta mente");
            }



            if (Pest4_Radio_Manejo.Checked == true)
            {
                if (Pest4_Txt_Manejo_CodCategoria.Text == comparar)
                {
                    MessageBox.Show("Codigo de Categoria aun no existe, favor buscar por codigo o por descripcion");
                    Pest4_Radio_BusqCodigo.Checked = true;
                    Pest4_Radio_Manejo.Checked = false;
                    Pest4_Txt_Manejo_CodCategoria.Text = "";
                    Pest4_Txt_Manejo_Categoria.Text = "";

                }
                else
                {

                    Pest4_Radio_Manejo.Checked = true;
                    Pest4_Txt_Manejo_CodCategoria.Focus();
                    Pest4_Txt_Manejo_CodCategoria.Enabled = true;
                    categoria.Fun_ModificarDatos();
                    MessageBox.Show("Se Modifico Correctamente");
                }


            }
            Pest4_Txt_Manejo_CodCategoria.Enabled = false;
            Pest4_Txt_Manejo_Categoria.Enabled = true;
            categoria.Fun_CargarPrimerDataGriew(Pest4_DataGrid_Categoria);

            Pest4_Txt_Manejo_CodCategoria.Clear();
            Pest4_Txt_Manejo_Categoria.Clear();
            Cargar();

        }

        private void Pest4_Txt_Manejo_Categoria_KeyPress(object sender, KeyPressEventArgs e)
        {
            Valid.ValirLetrasYEspacios(sender, e, Pest4_Txt_Manejo_Categoria);
        }

        private void Pest4_Txt_Busqueda_CodCategoria_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            Valid.ValidarID(sender, e); 
        }

        private void Pest4_Txt_Busqueda_Categoria_KeyPress(object sender, KeyPressEventArgs e)
        {
            Valid.ValirLetrasYEspacios(sender, e, Pest4_Txt_Busqueda_Categoria);
        }




        ////////////////////////////FUNCIONES DE DAPHNER

       
        private void Pest5_TxtDescipcionBuscar_TextChanged(object sender, EventArgs e)
        {
            if (Pest5_TxtDescipcionBuscar.Text == "")
            {
                Products.Fun_CargarPorNombreMarcas(Pest5_DataGriewMarcas, "a");

            }
            else
            {
                Products.Fun_CargarPorNombreMarcas(Pest5_DataGriewMarcas, Pest5_TxtDescipcionBuscar.Text);
            }
        }


        public void actualizar(DataGridView dgv)
        {
            Conexion conn = new Conexion();
            conn.cnx.Open();
            SqlCommand cmdd = new SqlCommand("select Cod_Marca as 'Codigo de Marca', Descripcion as 'Descripcion de Marca', Cod_Estado as 'Codigo de Estado', ( select E.Descripcion_Estado from Estados as E where E.Codigo_Tipo_Estado=5 and E.Codigo_Estado = Cod_Estado) as 'Estado de la Marca'  from Marca ", conn.cnx);
            SqlDataAdapter daa = new SqlDataAdapter(cmdd);
            DataTable dtt = new DataTable();
            daa.Fill(dtt);
            dgv.DataSource = dtt;
            conn.cnx.Close();
        }


        private void Pest5_BtnMostrar_Click(object sender, EventArgs e)
        {
            if (Pest5_Radio_Buscar.Checked == true)
            {
                if (Pest5_TxtDescipcionBuscar.Text==string.Empty)
                {
                    MessageBox.Show("Debe seleccionar una Marca para ver sus productos");
                    return;
                }


                if (radioButton1.Checked == true)
                {

                    Conexion con = new Conexion();
                    con.cnx.Open();
                    SqlCommand cmd = new SqlCommand("select A.NombreProducto as 'Nombre de Producto' , A.Descripcion as 'Modelo', C.Cod_Marca as 'Codigo de Marca' from Producto as A inner join Modelo as B on A.Cod_Modelo = B.Cod_Modelo inner join Marca as C on B.Cod_Marca = C.Cod_Marca where C.Descripcion='" + Pest5_TxtDescipcionBuscar.Text + "'", con.cnx);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    Pest5_DataGriewMarcasProductos.DataSource = dt;
                    con.cnx.Close();


                }
            }
        }

        private void Pest5_Bttn_Manejo_Aceptar_Click(object sender, EventArgs e)
        {
            if (Pest5_Txt_Manejo_Descripcion.Text == string.Empty)
            {
                MessageBox.Show("Error: No se permiten campos vacios", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (Pest5_Radio_Manejo_Estados.SelectedIndex == -1)
            {
                MessageBox.Show("Error: Debe seleccionar un Estado", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if (Pest5_Radio_Agregar.Checked == true)
            {
                


                Conexion con = new Conexion();
                con.cnx.Open();
                SqlCommand cmd = new SqlCommand("insert into marca(Descripcion, Cod_Estado) values ('" + Pest5_Txt_Manejo_Descripcion.Text + "', '" + Pest5_Radio_Manejo_Estados.Text + "')  ", con.cnx);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt); ;
                Pest5_DataGriewMarcas.DataSource = dt;
                con.cnx.Close();
                actualizar(Pest5_DataGriewMarcas);

            }
            else
           if (Pest5_Radio_Manejo.Checked == true)
            {
                if (Pest5_Txt_Manejo_Descripcion.Text == string.Empty)
                {
                    MessageBox.Show("Error: No se permiten campos vacios", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }else
                    if(Pest5_Txt_Manejo_Codigo.Text == string.Empty)
                {
                    MessageBox.Show("Error: Debes seleccionar una Marca", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                Conexion con = new Conexion();
                con.cnx.Open();
                SqlCommand cmd = new SqlCommand("update marca set Descripcion = '" + Pest5_Txt_Manejo_Descripcion.Text + "', Cod_Estado='"+ Pest5_Radio_Manejo_Estados.SelectedValue +  "'   where Cod_Marca = '" + Pest5_Txt_Manejo_Codigo.Text + "'", con.cnx);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                Pest5_DataGriewMarcasProductos.DataSource = dt;
                con.cnx.Close();
                actualizar(Pest5_DataGriewMarcas);

            }
            else
            {
                MessageBox.Show("");
            }
        }

        private void Pest5_Bttn_Manejo_Limpiar_Click(object sender, EventArgs e)
        {
            Pest5_Txt_Manejo_Codigo.Clear();
            Pest5_Txt_Manejo_Descripcion.Clear();
            Pest5_Radio_Manejo_Estados.SelectedIndex = -1;
            actualizar(Pest5_DataGriewMarcas);
        }

        private void Pest5_Radio_Manejo_CheckedChanged(object sender, EventArgs e)
        {
            Pest5_Txt_Manejo_Codigo.Clear();
            Pest5_Txt_Manejo_Descripcion.Clear();
            Pest5_Radio_Manejo_Estados.Text = "1";
            radioButton1.Checked = true;
            Pest5_TxtDescipcionBuscar.Enabled = true;           
            Pest5_TxtDescipcionBuscar.Focus();
            Pest5_Txt_Manejo_Descripcion.Enabled = true;
            Pest5_Txt_Manejo_Codigo.Enabled = false;
            Pest5_DataGriewMarcasProductos.Enabled = true;
            Pest5_DataGriewMarcas.Enabled = true;
            Pest5_Radio_Manejo_Estados.Enabled = true;
            actualizar(Pest5_DataGriewMarcas);
        }

        private void Pest5_Radio_Buscar_CheckedChanged(object sender, EventArgs e)
        {
            Pest5_Txt_Manejo_Codigo.Clear();
            Pest5_Txt_Manejo_Descripcion.Clear();
            radioButton1.Enabled = true;
            radioButton1.Checked = true;
            Pest5_TxtDescipcionBuscar.Enabled = true;
            Pest5_Txt_Manejo_Codigo.Enabled = false;
            Pest5_Txt_Manejo_Descripcion.Enabled = false;
            Pest5_Radio_Manejo_Estados.Enabled = false;
            Pest5_DataGriewMarcasProductos.Enabled = true;
            Pest5_DataGriewMarcas.Enabled = true;
            Pest5_TxtDescipcionBuscar.Focus();
            actualizar(Pest5_DataGriewMarcas);
        }

        private void Pest5_Radio_Agregar_CheckedChanged(object sender, EventArgs e)
        {
            Pest5_TxtDescipcionBuscar.Enabled = false;
          
            Pest5_Txt_Manejo_Codigo.Clear();
            Pest5_Txt_Manejo_Descripcion.Clear();
            Pest5_Radio_Manejo_Estados.SelectedValue=1;
            radioButton1.Enabled = false;
            Pest5_Txt_Manejo_Codigo.Enabled = false;
            Pest5_Txt_Manejo_Descripcion.Enabled = true;
            Pest5_DataGriewMarcasProductos.Enabled = false;
            Pest5_DataGriewMarcas.Enabled = true;
            Pest5_Radio_Manejo_Estados.Enabled = false;
            Products.Fun_ExtraerCodigoMarcas(Pest5_Txt_Manejo_Codigo);
            actualizar(Pest5_DataGriewMarcas);
        }

        private void Pest5_DataGriewMarcas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Pest5_DataGriewMarcas_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow fila = Pest5_DataGriewMarcas.Rows[e.RowIndex];
                Pest5_Txt_Manejo_Codigo.Text = Convert.ToString(fila.Cells[0].Value);              
                Pest5_Txt_Manejo_Descripcion.Text = Convert.ToString(fila.Cells[1].Value);
                Pest5_Radio_Manejo_Estados.SelectedValue = Convert.ToInt32(fila.Cells[2].Value);
                Pest5_TxtDescipcionBuscar.Text = Convert.ToString(fila.Cells[1].Value);
            }
            catch (Exception) {
            }


        }
        

      

        private void Pest5_TxtDescipcionBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            Valid.ValirLetrasYEspacios(sender, e, Pest5_TxtDescipcionBuscar);
        }

        private void Pest5_Txt_Manejo_Descripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            Valid.ValirLetrasYEspacios(sender, e, Pest5_Txt_Manejo_Descripcion);
        }

        private void Pest2_Txt_NombreFiltro_TextChanged(object sender, EventArgs e)
        {
           

            if (Pest2_Txt_NombreFiltro.Text == string.Empty)
            {
                Products.ExtrearTodo(Pest2_DataGriew_Productos);
            }
            else
            {
                Products.ExtraerPorNombreroducto(Pest2_DataGriew_Productos, Pest2_Txt_NombreFiltro.Text);
            }
        }

        private void Pest2_Txt_CodigoFiltro_TextChanged(object sender, EventArgs e)
        {
            if (Pest2_Txt_CodigoFiltro.Text==string.Empty) {
                Products.ExtrearTodo(Pest2_DataGriew_Productos);
            } else
            {
                Products.Fun_ExtraerPorCodigoroducto(Pest2_DataGriew_Productos, Convert.ToInt32(Pest2_Txt_CodigoFiltro.Text));
            }
        }

        ///Busqueda de los Productos 
        
        private void Pest2_Radio_Nombre_CheckedChanged(object sender, EventArgs e)
        {
            if (Pest2_Radio_Nombre.Checked == true)
            {
                Pest2_Txt_NombreFiltro.Enabled = true;
            }
            else
            {
                Pest2_Txt_NombreFiltro.Text = string.Empty;
                Pest2_Txt_NombreFiltro.Enabled = false;
            }

          
        }

        private void Pest2_Radio_Codigo_CheckedChanged(object sender, EventArgs e)
        {

            if (Pest2_Radio_Codigo.Checked == true)
            {
                Pest2_Txt_CodigoFiltro.Enabled = true;
            }
            else
            {
                Pest2_Txt_CodigoFiltro.Text = string.Empty;
                Pest2_Txt_CodigoFiltro.Enabled = false;
            }
        }

        private void Pest2_Txt_NombreFiltro_KeyPress(object sender, KeyPressEventArgs e)
        {
            Valid.ValirLetrasYEspacios(sender, e, Pest2_Txt_NombreFiltro);
        }

        private void Pest2_Txt_CodigoFiltro_KeyPress(object sender, KeyPressEventArgs e)
        {
            Valid.ValidarID(sender, e);
        }

        private void Pest1_ComBox_Filtro_NombreMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Pest1_ComBox_Filtro_NombreMarca.SelectedIndex == -1)
            {
                return;
            }
            Fun_llenarModelo(Convert.ToInt32(Pest1_ComBox_Filtro_NombreMarca.SelectedValue));
        }

        private void Fun_llenarModelo(int Co)
        {
            Conexion Con = new Conexion();

            string mostrar;

            Con.cnx.Open();
            mostrar = Con.sql = string.Format(@"select Cod_Modelo, Descripcion from Modelo where Cod_Marca = '{0}'", Co);
            Con.cmd = new SqlCommand(Con.sql, Con.cnx);
            Con.DataAdapter = new SqlDataAdapter(Con.cmd);
            Con.dt = new DataTable();
            Con.DataAdapter.Fill(Con.dt);
            Con.cnx.Close();


            Pest1_ComBox_Modelo.ValueMember = "Cod_Modelo";
            Pest1_ComBox_Modelo.DisplayMember = "Descripcion";
            Pest1_ComBox_Modelo.DataSource = Con.dt;
        }


        public void OptenerUltimoCodigoProducto()
        {
            
           
            Conn.sql = string.Format(@"select Top 1 Cod_Producto as Cod from Producto order by Cod_Producto desc");
            Conn.cmd = new SqlCommand(Conn.sql, Conn.cnx);
            Conn.cnx.Open();

            SqlDataReader Reg = null;
            Reg = Conn.cmd.ExecuteReader();

            if (Reg.Read())
            {
                Pest1_Txt_Codigo.Text = Convert.ToString(Convert.ToInt16((Reg["Cod"].ToString()))+1);

            }
            else
            {

            }

            Conn.cnx.Close();
            
        }

        private void Pest1_Txt_Filtro_NombreProveedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            Valid.ValidarID(sender, e);
        }

        private void Pest1_Txt_TotalEnTienda_KeyPress(object sender, KeyPressEventArgs e)
        {
            Valid.ValidarID(sender, e);
        }

        private void Pest1_Txt_TotalBodega_KeyPress(object sender, KeyPressEventArgs e)
        {
            Valid.ValidarID(sender, e);
        }

        private void Pest1_CuadroTexto_Descripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            Valid.ValirLetrasYEspaciosMayorEspacio(sender, e, Pest1_CuadroTexto_Descripcion);
        }

        private void Pest1_CuadroTexto_Descripcion_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            Valid.ValirLetrasYEspaciosMayorEspacio(sender, e, Pest1_CuadroTexto_Descripcion);
        }

        private void Pest1_Txt_Filtro_NombreMarca_KeyPress(object sender, KeyPressEventArgs e)
        {
            Valid.ValirLetrasYEspacios(sender, e, Pest1_Txt_Filtro_NombreMarca);
        }

        private void Pest1_Txt_PrecioCompras_KeyPress(object sender, KeyPressEventArgs e)
        {
            Valid.NumerosDecimales(sender, e, Pest1_Txt_PrecioCompras);
        }

        private void Pest1_Txt_PrecioVentas_KeyPress(object sender, KeyPressEventArgs e)
        {
            Valid.NumerosDecimales(sender, e, Pest1_Txt_PrecioVentas);
        }

        private void Pest1_Txt_Nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            Valid.ValirLetrasYEspacios(sender, e, Pest1_Txt_Nombre);
        }

        private void Pest6_Txt_Busqueda_CodigoModelo_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Pest6_Txt_Busqueda_CodigoModelo.Text)==true)
            {
                this.modeloTableAdapter.Fill(this.ventasAutoPartesDataSet.Modelo);

                return;
            }
            double CodigoFiltro = Convert.ToDouble(Pest6_Txt_Busqueda_CodigoModelo.Text);
            int CodigoFiltroEntero = (int) CodigoFiltro;
            if (Pest6_Radio_Buscar.Checked == true)
            {
                if (Pest6_Txt_Busqueda_CodigoModelo.Text == string.Empty)
                {
                    Products.Pest6_Fun_CargarPorDescripcion(Pest6_DataGreiw_Busqueda, null);

                }
                else
                {
                    Products.Pest6_Fun_CargarPorCodigo(Pest6_DataGreiw_Busqueda, CodigoFiltroEntero);
                }
            }
        }

        private void Pest6_Txt_Busqueda_Descripcion_TextChanged(object sender, EventArgs e)
        {

            if (Pest6_Txt_Busqueda_Descripcion.Text == "")
            {
                Products.Pest6_Fun_CargarPorDescripcion(Pest6_DataGreiw_Busqueda, null);

            }
            else
            {
                Products.Pest6_Fun_CargarPorDescripcion(Pest6_DataGreiw_Busqueda, Pest6_Txt_Busqueda_Descripcion.Text);
            }
        }

        private void Pest6_Txt_Busqueda_CodigoMarca_TextChanged(object sender, EventArgs e)
        {

        }

        private void Pest6_Txt_Manejo_FiltroMarca_TextChanged(object sender, EventArgs e)
        {
            Products.Pest6_Fun_LlenarMarcaModelo(Pest6_ComboBox_Manejo_ResultadoMarca, Pest6_Txt_Manejo_FiltroMarca.Text);

        }

        private void Pest6_Radio_Agregar_CheckedChanged(object sender, EventArgs e)
        {
            if (Pest6_Radio_Agregar.Checked)
            {
                Pest6_Txt_Manejo_CodigoModulo.Enabled = true;
                Pest6_Txt_Manejo_Descripcion.Enabled = true;
                Pest6_Txt_Manejo_FiltroMarca.Enabled = true;
                Pest6_ComboBox_Manejo_ResultadoMarca.Enabled = true;

                Pest6_Bttn_Manejo_Aceptar.Enabled = true;

                Pest6_Txt_Busqueda_CodigoModelo.Enabled = false;
                Pest6_Txt_Busqueda_Descripcion.Enabled = false;
                Pest6_Txt_Busqueda_CodigoMarca.Enabled = false;
                Pest6_ComBox_Busqueda_Estados.Enabled = false;


                Pest6_Bttn_Busqueda_Aceptar.Enabled = false;
                Products.Fun_ExtraerCodigoModelo(Pest6_Txt_Manejo_CodigoModulo);
            }
        }

        private void Pest6_Radio_Buscar_CheckedChanged(object sender, EventArgs e)
        {
            if (Pest6_Radio_Buscar.Checked)
            {
                Pest6_Txt_Manejo_CodigoModulo.Enabled = false;
                Pest6_Txt_Manejo_Descripcion.Enabled = false;
                Pest6_Txt_Manejo_FiltroMarca.Enabled = false;
                Pest6_ComboBox_Manejo_ResultadoMarca.Enabled = false;

                Pest6_Bttn_Manejo_Aceptar.Enabled = false;


                Pest6_Txt_Busqueda_CodigoModelo.Enabled = true;
                Pest6_Txt_Busqueda_Descripcion.Enabled = false;
                Pest6_Txt_Busqueda_CodigoMarca.Enabled = false;
                Pest6_ComBox_Busqueda_Estados.Enabled = false;


                Pest6_Bttn_Busqueda_Aceptar.Enabled = true;
            }


        }


        public void Pest6_ExtraerPorCodigo(int Cod)
        {
            Conexion Cn = new Conexion();
            Cn.sql = string.Format(@"select [Cod_Modelo], [Descripcion] from [dbo].[Modelo] where [Cod_Modelo] ='{0}'", Cod);
            Cn.cmd = new SqlCommand(Cn.sql, Cn.cnx);
            Cn.cnx.Open();

            SqlDataReader Reg = null;
            Reg = Cn.cmd.ExecuteReader();

            if (Reg.Read())
            {
                Pest6_Txt_Manejo_CodigoModulo.Text = (Reg["Cod_Modelo"].ToString());
                Pest6_Txt_Manejo_Descripcion.Text = (Reg["Descripcion"].ToString());
            }
            else
            {

            }
        }


        public void Pest6_ExtraerPorDescripcion(string Des)
        {
            Conexion Cn = new Conexion();
            Cn.sql = string.Format(@"select [Cod_Modelo], [Descripcion] from [dbo].[Modelo] where [Descripcion] ='{0}'", Des);
            Cn.cmd = new SqlCommand(Cn.sql, Cn.cnx);
            Cn.cnx.Open();

            SqlDataReader Reg = null;
            Reg = Cn.cmd.ExecuteReader();

            if (Reg.Read())
            {
                Pest6_Txt_Manejo_CodigoModulo.Text = (Reg["Cod_Modelo"].ToString());
                Pest6_Txt_Manejo_Descripcion.Text = (Reg["Descripcion"].ToString());

            }
            else
            {

            }
        }

        private void Pest6_Bttn_Busqueda_Aceptar_Click(object sender, EventArgs e)
        {
            if (Pest6_Txt_Busqueda_Descripcion.Text == string.Empty)
            {
                MessageBox.Show("Tiene que agregar una descripcion del modelo");
                return;
            }

            Products.Var_CodModelo = Convert.ToInt16(Pest6_Txt_Busqueda_CodigoModelo.Text);
            Products.Var_DescripcionModelo = Pest6_Txt_Busqueda_Descripcion.Text;
            Products.Var_CodEstado = Convert.ToInt16(Pest6_ComBox_Busqueda_Estados.SelectedValue);

            Products.Pest6_Fun_ModificarModelo();

            Pest6_Txt_Busqueda_CodigoModelo.Clear();
            Pest6_Txt_Busqueda_Descripcion.Clear();
            Pest6_Txt_Busqueda_CodigoMarca.Clear();

            Products.Fun_CargarPrimerDataGriew(Pest6_DataGreiw_Busqueda);
        }

     

        private void Pest6_Bttn_Manejo_Aceptar_Click(object sender, EventArgs e)
        {
            if (Pest6_Txt_Manejo_Descripcion.Text == string.Empty)
            {
                MessageBox.Show("Tiene que agregar una descripcion del modelo");
                return;
            }
            if (Pest6_ComboBox_Manejo_ResultadoMarca.SelectedIndex == -1)
            {
                MessageBox.Show("Debe Elejir una Marca");
                return;
            }
            Products.Var_CodModelo = Convert.ToInt16(Pest6_Txt_Manejo_CodigoModulo.Text);
            Products.Var_DescripcionModelo = Pest6_Txt_Manejo_Descripcion.Text;
            Products.Var_CodMarca = Convert.ToInt16(Pest6_ComboBox_Manejo_ResultadoMarca.SelectedValue);
            Products.Var_CodEstado = 1;

            Products.Pest6_Fun_AgregarModelo();

            Pest6_Txt_Manejo_CodigoModulo.Clear();
            Pest6_Txt_Manejo_Descripcion.Clear();
            Pest6_Txt_Manejo_FiltroMarca.Clear();
            Products.Fun_CargarPrimerDataGriew(Pest6_DataGreiw_Busqueda);
        }

        private void Pest6_Radio_Manejo_CheckedChanged(object sender, EventArgs e)
        {

            if (Pest6_Radio_Manejo.Checked == true)
            {
                Pest6_Txt_Manejo_CodigoModulo.Enabled = false;
                Pest6_Txt_Manejo_CodigoModulo.Clear();
                Pest6_Txt_Manejo_Descripcion.Enabled = false;
                Pest6_Txt_Manejo_Descripcion.Clear();
                Pest6_Txt_Manejo_FiltroMarca.Enabled = false;
                Pest6_ComboBox_Manejo_ResultadoMarca.Enabled = false;

                Pest6_Bttn_Manejo_Aceptar.Enabled = false;


                Pest6_Txt_Busqueda_CodigoModelo.Enabled = false;
                Pest6_Txt_Busqueda_Descripcion.Enabled = true;
                Pest6_Txt_Busqueda_CodigoMarca.Enabled = false;
                Pest6_ComBox_Busqueda_Estados.Enabled = true;


                Pest6_Bttn_Busqueda_Aceptar.Enabled = true;
            }
        }

        private void Pest6_DataGreiw_Busqueda_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Pest6_Txt_Busqueda_CodigoModelo.Text = Pest6_DataGreiw_Busqueda.CurrentRow.Cells[0].Value.ToString();
            Pest6_Txt_Busqueda_Descripcion.Text = Pest6_DataGreiw_Busqueda.CurrentRow.Cells[2].Value.ToString();
            Pest6_Txt_Busqueda_CodigoMarca.Text = Pest6_DataGreiw_Busqueda.CurrentRow.Cells[1].Value.ToString();
            Pest6_ComBox_Busqueda_Estados.SelectedValue = Pest6_DataGreiw_Busqueda.CurrentRow.Cells[3].Value.ToString();

            MessageBox.Show("Listo");
        }

        

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            try
            {
              
            DateTime Hoy = DateTime.Today;
            string fecha_actual = Hoy.ToString("dd-MM-yyyy");
            string Nombre = "Reporte Inventario" + fecha_actual;
            string Ruta = @"C:\Rogers\Reportes\" + Nombre + ".pdf";

            
                reporteInventario(Pest2_DataGriew_Productos);
                ExportDataTableToPdf(Pest2_DataGriew_Productos,Ruta, "Reporte de Inventario");
                System.Diagnostics.Process.Start(Ruta);
                llenarDataGridView(Pest2_DataGriew_Productos);
        }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message");
            }

}

        public void llenarDataGridView(DataGridView dgv)
        {
            Conexion Con = new Conexion();
            try
            {

                Con.DataAdapter = new SqlDataAdapter(@"Select *
		                                                FROM Producto", Con.cnx);
                Con.dt = new DataTable();
                Con.DataAdapter.Fill(Con.dt);
                dgv.DataSource = Con.dt;
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        void ExportDataTableToPdf(DataGridView dgvTable, String strPdfPath, string strHeader)
        {
            System.IO.FileStream fs = new FileStream(strPdfPath, FileMode.Create, FileAccess.Write, FileShare.None);
            Document document = new Document();
            document.SetPageSize(iTextSharp.text.PageSize.A4);
            PdfWriter writer = PdfWriter.GetInstance(document, fs);
            document.Open();

            //Report Header
           BaseFont bfntHead = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
            iTextSharp.text.Font fntHead = new iTextSharp.text.Font(bfntHead, 16, 1, iTextSharp.text.BaseColor.BLACK);
            Paragraph prgHeading = new Paragraph();
            prgHeading.Alignment = Element.ALIGN_CENTER;
            prgHeading.Add(new Chunk(strHeader.ToUpper(), fntHead));
            document.Add(prgHeading);

            //Author
            Paragraph prgAuthor = new Paragraph();
            BaseFont btnAuthor = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
            iTextSharp.text.Font fntAuthor = new iTextSharp.text.Font(btnAuthor, 10, 2, iTextSharp.text.BaseColor.BLACK);
            prgAuthor.Alignment = Element.ALIGN_RIGHT;
            prgAuthor.Add(new Chunk("\nFecha : " + DateTime.Now.ToShortDateString(), fntAuthor));
            document.Add(prgAuthor);

            //Add a line seperation
            Paragraph p = new Paragraph(new Chunk(new iTextSharp.text.pdf.draw.LineSeparator(0.0F, 100.0F, iTextSharp.text.BaseColor.BLACK, Element.ALIGN_LEFT, 1)));
            document.Add(p);

            //Add line break
            document.Add(new Chunk("\n", fntHead));

            //Write the table
            PdfPTable tabl = new PdfPTable(dgvTable.Columns.Count);
            //Table header
            BaseFont btnColumnHeader = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
            iTextSharp.text.Font fntColumnHeader = new iTextSharp.text.Font(btnColumnHeader, 12, 0, iTextSharp.text.BaseColor.WHITE);

            for (int i = 0; i < dgvTable.Columns.Count; i++)
            {
                PdfPCell cell = new PdfPCell();
                cell.BackgroundColor = iTextSharp.text.BaseColor.DARK_GRAY;
                cell.AddElement(new Chunk(dgvTable.Columns[i].HeaderText, fntColumnHeader));
                
                tabl.AddCell(cell);
            }
            //table Data
            for (int i = 0; i < dgvTable.Rows.Count; i++)
            {
                for (int j = 0; j < dgvTable.Columns.Count; j++)
                {
                    tabl.AddCell(Convert.ToString(dgvTable.Rows[i].Cells[j].Value));
                    //Nombre, Codigo, Cantidad, precio compra, precio venta
                }
            }
            try
            {
               document.Add(tabl);
                document.Close();
                writer.Close();
                fs.Close();
            }
            catch(Exception) { }
        }

        private void reporteInventario(DataGridView dgv)
        { Conexion Con = new Conexion();
            try
            {

                Con.DataAdapter = new SqlDataAdapter(@"Select Cod_Producto as [Código de Producto],
		                                                NombreProducto as [Nombre de Producto],
		                                              
		                                                PrecioCompra as [Precio de Compra],
		                                                PrecioVenta as [Precio de Venta]
		                                                FROM Producto", Con.cnx);
                Con.dt = new DataTable();
                Con.DataAdapter.Fill(Con.dt);
                dgv.DataSource = Con.dt;
              
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }



        //***********************************************************************************************
        //***********************************************************************************************
        //***********************************************************************************************
        //***********************************************************************************************

        private void Pest6_Txt_Manejo_Descripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones Va = new Validaciones();
            Va.ValirLetrasYEspacios(sender, e, Pest6_Txt_Manejo_Descripcion);
        }

        private void Pest6_Txt_Manejo_Descripcion_KeyPress_1(object sender, KeyPressEventArgs e)
        {

            Validaciones Va = new Validaciones();
            Va.ValirLetrasYEspacios(sender, e, Pest6_Txt_Manejo_Descripcion);
        }

        private void Pest6_Txt_Busqueda_CodigoModelo_KeyPress(object sender, KeyPressEventArgs e)
        {
            Valid.ValidarID(sender, e);
        }

        private void Pest6_Txt_Busqueda_Descripcion_KeyPress(object sender, KeyPressEventArgs e)
        {

            Validaciones Va = new Validaciones();
            Va.ValirLetrasYEspacios(sender, e, Pest6_Txt_Busqueda_Descripcion);
        }


        private void Fun_llenarPRO()
        {
            Conexion Con = new Conexion();

            string mostrar;

            Con.cnx.Open();
            mostrar = Con.sql = string.Format(@"SELECT Codigo_Proveedor, Nombre FROM Proveedor");
            Con.cmd = new SqlCommand(Con.sql, Con.cnx);
            Con.DataAdapter = new SqlDataAdapter(Con.cmd);
            Con.dt = new DataTable();
            Con.DataAdapter.Fill(Con.dt);
            Con.cnx.Close();


            comboBox1.ValueMember = "Codigo_Proveedor";
            comboBox1.DisplayMember = "Nombre";
            comboBox1.DataSource = Con.dt;
        }

        private void Pest3_Txt_PrecioVenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            Valid.NumerosDecimales(sender, e, Pest3_Txt_PrecioVenta);

        }

        private void Pest3_Txt_Compras_KeyPress(object sender, KeyPressEventArgs e)
        {
            Valid.NumerosDecimales(sender, e, Pest3_Txt_Compras);
        }

        private void Pest3_Txt_TotalTienda_KeyPress(object sender, KeyPressEventArgs e)
        {
            Valid.ValidarID(sender, e);
        }

        private void Pest3_Txt_TotalBodega_KeyPress(object sender, KeyPressEventArgs e)
        {
            Valid.ValidarID(sender, e);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Valid.ValirLetrasYEspacios(sender, e, textBox1);
        }

        private void Pest3_Txt_TotalTienda_TextChanged(object sender, EventArgs e)
        {

        }

        private void Pest3_Txt_TotalBodega_TextChanged(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }


        /////MODIFICACION DE LOCALIDADES
        
        private void ModificarCant_PorLocalidad_CheckedChanged(object sender, EventArgs e)
        {
            if (ModificarCant_PorLocalidad.Checked == true)
            {
                Pest3_ComboBox_Localidad.Enabled = false;
            }
        }

        private void Modificar()
        {
            int conf=0;
            if (string.IsNullOrWhiteSpace(Pest3_Cant_PorLocalidad.Text))
            {
                errorProvider1.SetError(Pest3_Cant_PorLocalidad, "Porfavor, Ingrese la Cantidad"); return;
            }
            else{
                errorProvider1.SetError(Pest3_Cant_PorLocalidad, "");
                
            }


            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {

                if (Convert.ToInt16(Pest3_ComboBox_Localidad.SelectedValue) == Convert.ToInt16(this.dataGridView1.Rows[i].Cells[0].Value))
                {
                    Fun_UpdateCantidad_Localidad(Convert.ToInt32(Pest3_ComboBox_Localidad.SelectedValue), Convert.ToInt32(Pest3_Cant_PorLocalidad.Text),
                    Convert.ToInt32(Pest3_Txt_Codigo.Text));
                    conf = 1;  }
                else
                {
                  
                }

                
            }

            if (conf == 0)
            {
                MessageBox.Show("Debe agregar esta Localizacion si desea actualizarla", "Error de Actaulizacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void Fun_AgregarLocalidades_ModPro()
        {
            int conf = 0;
            if (string.IsNullOrWhiteSpace(Pest3_Cant_PorLocalidad.Text))
            {
                errorProvider1.SetError(Pest3_Cant_PorLocalidad, "Porfavor, Ingrese la Cantidad"); return;
            }
            else
            {
                errorProvider1.SetError(Pest3_Cant_PorLocalidad, "");

            }


            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {

                if (Convert.ToInt16(Pest3_ComboBox_Localidad.SelectedValue) == Convert.ToInt16(this.dataGridView1.Rows[i].Cells[0].Value))
                {
                    conf = 1;
                }
                else
                {}
            }

            if (conf == 1)
            {
                MessageBox.Show("Esta localidad ya existe", "Error de Actaulizacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }else
            {
                Fun_IngresarProductos_Localidad(Convert.ToInt32(Pest3_ComboBox_Localidad.SelectedValue), Convert.ToInt32(Pest3_Cant_PorLocalidad.Text),
                        Convert.ToInt32(Pest3_Txt_Codigo.Text));
            }

            if (Localidad == "1" || Localidad == "2")
            { Products.Fun_CargarLocalidad(dataGridView1, Pest3_Txt_Codigo.Text); }
            else
            {
                Products.Fun_CargarLocalidadIndividual(dataGridView1, Pest3_Txt_Codigo.Text, Localidad);
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(ModificarCant_PorLocalidad.Checked == true)
            {
                Modificar();
            }
            else
            {
                Fun_AgregarLocalidades_ModPro();

            }

            Products.Fun_LLenarLocalidades(Pest3_ComboBox_Localidad);


            if (Localidad == "1" || Localidad == "2")
            { Products.Fun_CargarLocalidad(dataGridView1, Pest3_Txt_Codigo.Text);}
            else {
                Products.Fun_CargarLocalidadIndividual(dataGridView1, Pest3_Txt_Codigo.Text, Localidad);
            }
        }

        private void Nueva_LocalidadProductos_CheckedChanged(object sender, EventArgs e)
        {
            if (Nueva_LocalidadProductos.Checked == true)
            {
                Pest3_ComboBox_Localidad.Enabled = false;
                Pest3_ComboBox_Localidad.SelectedValue = Localidad;
            }
            else
            {
                Pest3_ComboBox_Localidad.Enabled = false;
            }
        }

        public void Fun_UpdateCantidad_Localidad(int CodLocal, int Cantidad, int CodigoPro)
        {
            Conn.sql = string.Format(@"update [Producto|Localidad] set Cantidad='{0}' where Cod_Localidad='{1}' and Cod_Producto='{2}'", Cantidad, CodLocal, CodigoPro);

            Conn.cmd = new SqlCommand(Conn.sql, Conn.cnx);

            Conn.cnx.Open();
            SqlDataReader Reg = null;
            Reg = Conn.cmd.ExecuteReader();
            Conn.cnx.Close();
        }

        public void Fun_IngresarProductos_Localidad(int CodLocal, int Cantidad, int CodigoPro)
        {

            Conn.sql = string.Format(@"insert into [Producto|Localidad] values ('{0}','{1}','{2}')", CodigoPro, CodLocal, Cantidad);

            Conn.cmd = new SqlCommand(Conn.sql, Conn.cnx);

            Conn.cnx.Open();
            SqlDataReader Reg = null;
            Reg = Conn.cmd.ExecuteReader();
            Conn.cnx.Close();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            ModificarCant_PorLocalidad.Checked = true;
            try
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                Pest3_ComboBox_Localidad.SelectedValue = Convert.ToString(row.Cells["Codigo de Localidad"].Value.ToString());
                Pest3_Cant_PorLocalidad.Text = Convert.ToString(row.Cells["Unidades en existencia"].Value.ToString());
            }
            catch (Exception) { }

        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ModificarCant_PorLocalidad.Checked = true;
            try
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                Pest3_ComboBox_Localidad.SelectedValue = Convert.ToString(row.Cells["Codigo de Localidad"].Value.ToString());
                Pest3_Cant_PorLocalidad.Text = Convert.ToString(row.Cells["Unidades en existencia"].Value.ToString());
            }
            catch (Exception) { }

        }

        private void Pest3_Cant_PorLocalidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            Valid.ValidarID(sender, e);
        }

        private void Pest6_Bttn_Manejo_Limpiar_Click(object sender, EventArgs e)
        {
            Pest6_Txt_Busqueda_Descripcion.Clear();
            Pest6_Txt_Busqueda_CodigoMarca.Clear();
            Products.Fun_ExtraerCodigoModelo(Pest6_Txt_Manejo_CodigoModulo);
        }

        private void Bttn_Ayuda_Click(object sender, EventArgs e)
        {
            
            Form_VistaManualPDF Manual = new Form_VistaManualPDF();
            Manual.PDF_Local.src = (Application.StartupPath + @"\ManualesHTML\ManualesPantalla\Manual Pantalla de Productos.pdf");
            Manual.ShowDialog();
        }
    }

}
