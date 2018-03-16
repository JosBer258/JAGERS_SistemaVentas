using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desarrollo.Clases
{
    class C_Productos:Conexion
    {
        private int codProveedor, codMarca, totalTienda, totalBodega, codModelo, codCategoria, codEstado;
        private string nombreProveedor, desMarca, nomProducto, modeloProducto, catProducto, descriProducto;
        private float precioVenta, precioCompra;
        private string descripcionModelo;

        public int var_CodProveedor
        {
            get { return codProveedor; }
            set { codProveedor = value; }
        }

        public int Var_CodMarca
        {
            get { return codMarca; }
            set { codMarca = value; }
        }

        public int Var_TotalTienda
        {
            get { return totalTienda; }
            set { totalTienda = value; }
        }
        public int Var_CodModelo
        {
            get { return codModelo; }
            set { codModelo = value; }
        }

        public int Var_CodCategoria
        {
            get { return codCategoria; }
            set { codCategoria = value; }
        }

        public int Var_CodEstado
        {
            get { return codEstado; }
            set { codEstado = value; }
        }

        public int Var_TotalBodega
        {
            get { return totalBodega; }
            set { totalBodega = value; }
        }

        public string Var_NombreProveedor
        {
            get { return nombreProveedor; }
            set { nombreProveedor = value; }
        }

        public string Var_DesMarca
        {
            get { return desMarca; }
            set { desMarca = value; }
        }

        public string Var_NomProducto
        {
            get
            {
                return nomProducto;
            }

            set
            {
                nomProducto = value;
            }
        }

        public string Var_ModeloProducto
        {
            get
            {
                return modeloProducto;
            }

            set
            {
                modeloProducto = value;
            }
        }

        public string Var_CatProducto
        {
            get
            {
                return catProducto;
            }

            set
            {
                catProducto = value;
            }
        }

        public string Var_DescriProducto
        {
            get
            {
                return descriProducto;
            }

            set
            {
                descriProducto = value;
            }
        }

        public float Var_PrecioVenta
        {
            get
            {
                return precioVenta;
            }

            set
            {
                precioVenta = value;
            }
        }

        public float Var_PrecioCompra
        {
            get
            {
                return precioCompra;
            }

            set
            {
                precioCompra = value;
            }
        }


        public string Var_DescripcionModelo
        {
            get { return descripcionModelo; }
            set { descripcionModelo = value; }
        }




        public void Pest1_Fun_Llenarproveedor(ComboBox Comb, string codi)
        {
            int a;

            if (codi == string.Empty)
            {
                a = 0;
            }
            else
            {
                a = Convert.ToInt32(codi);
            }


            Conexion Con = new Conexion();

            Con.cnx.Open();
            Con.sql = string.Format(@"select Codigo_Proveedor, Nombre from [dbo].[Proveedor] where Codigo_Proveedor like '%{0}%'", a);
            Con.cmd = new SqlCommand(Con.sql, Con.cnx);
            Con.DataAdapter = new SqlDataAdapter(Con.cmd);
            Con.dt = new DataTable();
            Con.DataAdapter.Fill(Con.dt);
            Con.cnx.Close();

            Comb.ValueMember = "Codigo_Proveedor";
            Comb.DisplayMember = "Nombre";
            Comb.DataSource = Con.dt;
        }


        public void Pest1_Fun_LlenarMarca(ComboBox Comb, string codi)
        {
            string a;
            if (codi == "") { return; }
            else
            {
                a = codi;
            }
            Conexion Con = new Conexion();

            Con.cnx.Open();
            Con.sql = string.Format(@"select [Cod_Marca], Descripcion from Marca where Descripcion like '%{0}%'", a);
            Con.cmd = new SqlCommand(Con.sql, Con.cnx);
            Con.DataAdapter = new SqlDataAdapter(Con.cmd);
            Con.dt = new DataTable();
            Con.DataAdapter.Fill(Con.dt);
            Con.cnx.Close();


            Con.Dr = Con.dt.NewRow();
            Con.dt.Rows.InsertAt(Con.Dr, 0);

            Comb.ValueMember = "Cod_Marca";
            Comb.DisplayMember = "Descripcion";
            Comb.DataSource = Con.dt;
        }

        public void Pest1_Fun_AgregarProducto(ComboBox Categoria, ComboBox Modelo, string Proveedor)
        {
            Conexion Con = new Conexion();
            Con.cnx.Open();


            Var_CodCategoria = Convert.ToInt16(Categoria.SelectedValue);
            Var_CodModelo = Convert.ToInt16(Modelo.SelectedValue);
            Var_CodEstado = Convert.ToInt16(1);
            var_CodProveedor = Convert.ToInt16(Proveedor);



            Con.sql = string.Format(@"insert into [dbo].[Producto] (NombreProducto, Descripcion, PrecioVenta, PrecioCompra, CantExistenteTienda,
                                    CantExistenteBodega, Cod_Modelo, Cod_Proveedor, Cod_Categoria, Cod_Estado) values 
                                    ('{0}', '{1}', {2}, {3}, {4}, {5},{6},{7},{8},{9})", Var_NomProducto, Var_DescriProducto,
                                    Var_PrecioVenta, Var_PrecioCompra, Var_TotalTienda, Var_TotalBodega, Var_CodModelo,
                                    var_CodProveedor, Var_CodCategoria, Var_CodEstado);
            Con.cmd = new SqlCommand(Con.sql, Con.cnx);
            Con.DataAdapter = new SqlDataAdapter(Con.cmd);
            Con.dt = new DataTable();
            Con.DataAdapter.Fill(Con.dt);
            Con.cnx.Close();

            MessageBox.Show("Producto Agregado Correctamente");


            Con.Dr = Con.dt.NewRow();
            Con.dt.Rows.InsertAt(Con.Dr, 0);

        }

        public void Pest1_Fun_llenarModelo(ComboBox Comb)
        {
            Conexion Con = new Conexion();

            string mostrar;

            Con.cnx.Open();
            mostrar = Con.sql = string.Format(@"select Cod_Modelo, Descripcion from Modelo");
            Con.cmd = new SqlCommand(Con.sql, Con.cnx);
            Con.DataAdapter = new SqlDataAdapter(Con.cmd);
            Con.dt = new DataTable();
            Con.DataAdapter.Fill(Con.dt);
            Con.cnx.Close();


            Con.Dr = Con.dt.NewRow();
            Con.dt.Rows.InsertAt(Con.Dr, 0);

            Comb.ValueMember = "Cod_Modelo";
            Comb.DisplayMember = "Descripcion";
            Comb.DataSource = Con.dt;
        }

        public void Pest1_Fun_llenarCategoria(ComboBox Comb)
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


            Con.Dr = Con.dt.NewRow();
            Con.dt.Rows.InsertAt(Con.Dr, 0);

            Comb.ValueMember = "Codigo_Categoria";
            Comb.DisplayMember = "Descripcion";
            Comb.DataSource = Con.dt;
        }

        public void Pest2_Fun_CargarDataGriew(DataGridView dgv)
        {
            Conexion con = new Conexion();
            con.cnx.Open();
            try
            {
                con.DataAdapter = new SqlDataAdapter("select * from Producto where Cod_Producto like '{0}'", con.ccnx);
                /* con.sql = string.Format(@"select from Categoria_Producto where Codigo_Categoria like '{0}'", busq);*/
                con.dt = new DataTable();
                con.DataAdapter.Fill(con.dt);
                dgv.DataSource = con.dt;

            }
            catch
            {

            }
        }

        public void Pest2_Fun_CargarPorCodigo(DataGridView dgv, int a)
        {
            Conexion con = new Conexion();
            con.cnx.Open();
            try
            {

                /*con.sql = string.Format(@"Select * from Categoria_Productos", busq);*/
                con.sql = string.Format(@"select * from Producto where Cod_Producto like '{0}'", a);
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

        public void Pest2_Fun_CargarPorNombre(DataGridView dgv, string a)
        {
            Conexion con = new Conexion();
            con.cnx.Open();
            try
            {



                con.sql = string.Format(@"select * from Producto where NombreProducto like '%{0}%'", a);
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




        public void Pest6_Fun_CargarDataGriew(DataGridView dgv)
        {
            Conexion con = new Conexion();
            con.cnx.Open();
            try
            {
                con.DataAdapter = new SqlDataAdapter("select * from Modelo where Cod_Modelo like '{0}'", con.ccnx);
                /* con.sql = string.Format(@"select from Categoria_Producto where Codigo_Categoria like '{0}'", busq);*/
                con.dt = new DataTable();
                con.DataAdapter.Fill(con.dt);
                dgv.DataSource = con.dt;

            }
            catch
            {

            }
        }

        public void Pest6_Fun_CargarPorCodigo(DataGridView dgv, int a)
        {
            Conexion con = new Conexion();
            con.cnx.Open();
            try
            {

                /*con.sql = string.Format(@"Select * from Categoria_Productos", busq);*/
                con.sql = string.Format(@"select * from Modelo where Cod_Modelo like '{0}'", a);
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

        public void Pest6_Fun_CargarPorDescripcion(DataGridView dgv, string a)
        {
            Conexion con = new Conexion();
            con.cnx.Open();
            try
            {
                con.sql = string.Format(@"select * from Modelo where Descripcion like '%{0}%'", a);
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

        public void Pest6_Fun_llenarEstadoModelo(ComboBox Comb)
        {
            Conexion Con = new Conexion();

            string mostrar;

            Con.cnx.Open();
            mostrar = Con.sql = string.Format(@"select Codigo_Estado, Descripcion_Estado from Estados where Codigo_Tipo_Estado = 6");
            Con.cmd = new SqlCommand(Con.sql, Con.cnx);
            Con.DataAdapter = new SqlDataAdapter(Con.cmd);
            Con.dt = new DataTable();
            Con.DataAdapter.Fill(Con.dt);
            Con.cnx.Close();

            Comb.ValueMember = "Codigo_Estado";
            Comb.DisplayMember = "Descripcion_Estado";
            Comb.DataSource = Con.dt;
        }

        public void Pest6_Fun_LlenarMarcaModelo(ComboBox Comb, string codi)
        {
            string a;
            if (codi == "") { return; }
            else
            {
                a = codi;
            }
            Conexion Con = new Conexion();

            Con.cnx.Open();
            Con.sql = string.Format(@"select [Cod_Marca], Descripcion from Marca where Descripcion like '%{0}%'", a);
            Con.cmd = new SqlCommand(Con.sql, Con.cnx);
            Con.DataAdapter = new SqlDataAdapter(Con.cmd);
            Con.dt = new DataTable();
            Con.DataAdapter.Fill(Con.dt);
            Con.cnx.Close();


            Comb.ValueMember = "Cod_Marca";
            Comb.DisplayMember = "Descripcion";
            Comb.DataSource = Con.dt;
        }

        public void Pest6_Fun_AgregarModelo()
        {
            sql = string.Format(@"insert into [dbo].[Modelo] (Cod_Marca, Descripcion, Cod_Estado) values 
                                    ('{0}', '{1}', '{2}')", Var_CodMarca, Var_DescripcionModelo, Var_CodEstado);

            this.cmd = new SqlCommand(this.sql, this.cnx);
            this.cnx.Open();
            SqlDataReader Reg = null;
            Reg = this.cmd.ExecuteReader();
            this.cnx.Close();



            MessageBox.Show("Modelo Agregado Correctamente");

        }
        public void Pest6_Fun_ModificarModelo()
        {
            sql = string.Format(@"update [dbo].[Modelo] set  Descripcion = '{0}', Cod_Estado='{1}' where Cod_Modelo =  '{2}'", Var_DescripcionModelo, Var_CodEstado, Var_CodModelo);

            this.cmd = new SqlCommand(this.sql, this.cnx);
            this.cnx.Open();
            SqlDataReader Reg = null;
            Reg = this.cmd.ExecuteReader();
            this.cnx.Close();



            MessageBox.Show("Registro modificacdo Correctamente");

        }
    }
}
