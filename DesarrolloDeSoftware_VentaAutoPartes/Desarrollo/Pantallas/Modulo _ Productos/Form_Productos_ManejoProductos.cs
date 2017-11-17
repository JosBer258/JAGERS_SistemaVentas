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

namespace Desarrollo.Pantallas.Modulo___Productos
{
    public partial class Form_Productos_ManejoProductos : Form
    {
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

        private void Form_Productos_ManejoProductos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'ventasAutoPartesDataSet.Categoria_Producto' Puede moverla o quitarla según sea necesario.
            this.categoria_ProductoTableAdapter.Fill(this.ventasAutoPartesDataSet.Categoria_Producto);
            // TODO: esta línea de código carga datos en la tabla 'ventasAutoPartesDataSet._Productos_Historicos' Puede moverla o quitarla según sea necesario.
            this.productos_HistoricosTableAdapter.Fill(this.ventasAutoPartesDataSet._Productos_Historicos);
            // TODO: esta línea de código carga datos en la tabla 'ventasAutoPartesDataSet.Producto' Puede moverla o quitarla según sea necesario.
            this.productoTableAdapter.Fill(this.ventasAutoPartesDataSet.Producto);
            // TODO: esta línea de código carga datos en la tabla 'ventasAutoPartesDataSet.Modelo' Puede moverla o quitarla según sea necesario.
            this.modeloTableAdapter.Fill(this.ventasAutoPartesDataSet.Modelo);
            // TODO: esta línea de código carga datos en la tabla 'ventasAutoPartesDataSet.Marca' Puede moverla o quitarla según sea necesario.
            this.marcaTableAdapter.Fill(this.ventasAutoPartesDataSet.Marca);

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
            Fun_AgregarProducto();

        }




        private void Pest1_Txt_Filtro_NombreProveedor_TextChanged(object sender, EventArgs e)
        {
            Fun_Llenarproveedor();
        }

        public void Fun_Llenarproveedor()
        {
            int a = Convert.ToInt16(Pest1_Txt_Filtro_NombreProveedor.Text);
            Conexion Con = new Conexion();

            Con.cnx.Open();
            Con.sql = string.Format(@"select Codigo_Proveedor, Nombre from [dbo].[Proveedor] where Codigo_Proveedor like '{0}'", a);
            Con.cmd = new SqlCommand(Con.sql, Con.cnx);
            Con.DataAdapter = new SqlDataAdapter(Con.cmd);
            Con.dt = new DataTable();
            Con.DataAdapter.Fill(Con.dt);
            Con.cnx.Close();


            Con.Dr = Con.dt.NewRow();
            Con.dt.Rows.InsertAt(Con.Dr, 0);

            Pest1_ComBox_Filtro_NombreProveedor.ValueMember = "Codigo_Proveedor";
            Pest1_ComBox_Filtro_NombreProveedor.DisplayMember = "Nombre";
            Pest1_ComBox_Filtro_NombreProveedor.DataSource = Con.dt;
        }

        public void Fun_LlenarMarca()
        {
            int a = Convert.ToInt16(Pest1_Txt_Filtro_NombreMarca.Text);
            Conexion Con = new Conexion();

            Con.cnx.Open();
            Con.sql = string.Format(@"select [Cod_Marca], Descripcion from [dbo].[Marca] where [Cod_Marca] like '{0}'", a);
            Con.cmd = new SqlCommand(Con.sql, Con.cnx);
            Con.DataAdapter = new SqlDataAdapter(Con.cmd);
            Con.dt = new DataTable();
            Con.DataAdapter.Fill(Con.dt);
            Con.cnx.Close();


            Con.Dr = Con.dt.NewRow();
            Con.dt.Rows.InsertAt(Con.Dr, 0);

            Pest1_ComBox_Filtro_NombreMarca.ValueMember = "Cod_Marca";
            Pest1_ComBox_Filtro_NombreMarca.DisplayMember = "Descripcion";
            Pest1_ComBox_Filtro_NombreMarca.DataSource = Con.dt;
        }


        public void Fun_AgregarProducto()
        {
            //   int cod = Convert.ToInt16(Pest1_Txt_Codigo.Text);
            string nomb = Pest1_Txt_Codigo.Text;
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
            Con.cnx.Open();


            CodCateg = Convert.ToInt16(Con.sql = string.Format(@"select Codigo_Categoria from Categoria_Producto where Descripcion = '{0}'", nombcat));
            CodModelo = Convert.ToInt16(Con.sql = string.Format(@"select Cod_Modelo from Modelo where Descripcion = '{0}'", nombmod));
            CodEstado = Convert.ToInt16(Con.sql = string.Format(@"select Cod_Estado from Modelo where Descripcion = '{0}'", nombmod));


            MessageBox.Show("CodCateg");

            Con.sql = string.Format(@"insert into [dbo].[Producto] (NombreProducto, Descripcion, PrecioVenta, PrecioCompra, CantExistenteTienda,
                                    CantExistenteBodega, Cod_Modelo, Cod_Proveedor, Cod_Categoria, Cod_Estado) values 
                                    ('{0}', '{1}', {2}, {3}, {4}, {5},{6},{7},{8},{9})", nomb, descrip, preve, precom, totaltie, totalbo, CodModelo, codprov, CodCateg, CodEstado);
            Con.cmd = new SqlCommand(Con.sql, Con.cnx);
            Con.DataAdapter = new SqlDataAdapter(Con.cmd);
            Con.dt = new DataTable();
            Con.DataAdapter.Fill(Con.dt);
            Con.cnx.Close();


            Con.Dr = Con.dt.NewRow();
            Con.dt.Rows.InsertAt(Con.Dr, 0);

            //Pest1_ComBox_Filtro_NombreProveedor.ValueMember = "Cod_Categoria";
            //Pest1_ComBox_Filtro_NombreProveedor.DisplayMember = "Nombre";
            //Pest1_ComBox_Filtro_NombreProveedor.DataSource = Con.dt;
        }

        private void Fun_llenarModelo()
        {
            Conexion Con = new Conexion();

            string mostrar;

            Con.cnx.Open();
            mostrar = Con.sql = string.Format(@"select Descripcion from Modelo");
            Con.cmd = new SqlCommand(Con.sql, Con.cnx);
            Con.DataAdapter = new SqlDataAdapter(Con.cmd);
            Con.dt = new DataTable();
            Con.DataAdapter.Fill(Con.dt);
            Con.cnx.Close();


            Con.Dr = Con.dt.NewRow();
            Con.dt.Rows.InsertAt(Con.Dr, 0);

            //Pest1_ComBox_Filtro_NombreMarca.ValueMember = "Cod_Marca";
            Pest1_ComBox_Modelo.DisplayMember = "Descripcion";
            Pest1_ComBox_Modelo.DataSource = Con.dt;
        }
        private void Fun_llenarCategoria()
        {
            Conexion Con = new Conexion();

            string mostrar;

            Con.cnx.Open();
            mostrar = Con.sql = string.Format(@"select Descripcion from Categoria_Producto");
            Con.cmd = new SqlCommand(Con.sql, Con.cnx);
            Con.DataAdapter = new SqlDataAdapter(Con.cmd);
            Con.dt = new DataTable();
            Con.DataAdapter.Fill(Con.dt);
            Con.cnx.Close();


            Con.Dr = Con.dt.NewRow();
            Con.dt.Rows.InsertAt(Con.Dr, 0);

            //Pest1_ComBox_Filtro_NombreMarca.ValueMember = "Cod_Marca";
            Pest1_ComBox_Categoria.DisplayMember = "Descripcion";
            Pest1_ComBox_Categoria.DataSource = Con.dt;
        }


        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Pest1_Txt_Filtro_NombreMarca_TextChanged(object sender, EventArgs e)
        {
            Fun_LlenarMarca();
        }

        private void Pest1_ComBox_Modelo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Pest1_Txt_Nombre_TextChanged(object sender, EventArgs e)
        {
            Fun_llenarModelo();
        }

        private void Pest1_Txt_PrecioCompras_TextChanged(object sender, EventArgs e)
        {
            Fun_llenarCategoria();
        }
    }
}