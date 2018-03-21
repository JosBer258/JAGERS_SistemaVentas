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


            cnx.Open();
            sql = string.Format(@"select Codigo_Proveedor, Nombre from [dbo].[Proveedor] where Codigo_Proveedor like '%{0}%'", a);
            cmd = new SqlCommand(sql, cnx);
            DataAdapter = new SqlDataAdapter(cmd);
            dt = new DataTable();
            DataAdapter.Fill(dt);
            cnx.Close();

            Comb.ValueMember = "Codigo_Proveedor";
            Comb.DisplayMember = "Nombre";
            Comb.DataSource = dt;
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



        public void Fun_ExtraerCodigoMarcas(TextBox FN_Pest5_ManCod)
        {
            Conexion Con = new Conexion();

            Con.cnx.Open();
            Con.sql = string.Format(@"select TOP 1 Cod_Marca from Marca ORDER BY Cod_Marca DESC");
            Con.cmd = new SqlCommand(Con.sql, Con.cnx);
            SqlDataReader Reg2 = null;
            Reg2 = Con.cmd.ExecuteReader();
            if (Reg2.Read())
            {
                FN_Pest5_ManCod.Text = Convert.ToString(Convert.ToInt16((Reg2["Cod_Marca"].ToString())) + 1);
                Con.cnx.Close();
            }

        }


        public void ExtraerEstadosMarcas(ComboBox Pest5_ManEstados)
        {

            Conexion Con = new Conexion();

            Con.cnx.Open();
            Con.sql = string.Format(@"select Codigo_Estado, Descripcion_Estado from Estados where Codigo_Tipo_Estado = 5");
            Con.cmd = new SqlCommand(Con.sql, Con.cnx);
            Con.DataAdapter = new SqlDataAdapter(Con.cmd);
            Con.dt = new DataTable();
            Con.DataAdapter.Fill(Con.dt);
            Con.cnx.Close();

            Pest5_ManEstados.ValueMember = "Codigo_Estado";
            Pest5_ManEstados.DisplayMember = "Descripcion_Estado";
            Pest5_ManEstados.DataSource = Con.dt;


        }

        public void Fun_Llenarproveedor(ComboBox Pest1_FilNom, TextBox Pest1_FilNomProv)
        {
            int a;

            if (Pest1_FilNomProv.Text == string.Empty) { a = 0; }
            else
            {
                a = Convert.ToInt16(Pest1_FilNomProv.Text);
            }

            Conexion Con = new Conexion();

            Con.cnx.Open();
            Con.sql = string.Format(@"select Codigo_Proveedor, Nombre from [dbo].[Proveedor] where Codigo_Proveedor like '%{0}%'", a);
            Con.cmd = new SqlCommand(Con.sql, Con.cnx);
            Con.DataAdapter = new SqlDataAdapter(Con.cmd);
            Con.dt = new DataTable();
            Con.DataAdapter.Fill(Con.dt);
            Con.cnx.Close();
            Pest1_FilNom.ValueMember = "Codigo_Proveedor";
            Pest1_FilNom.DisplayMember = "Nombre";
            Pest1_FilNom.DataSource = Con.dt;
        }

        public void Fun_CargarPorCodigo(DataGridView dgv, int FN_CodBusq)
        {
            Conexion con = new Conexion();
            con.cnx.Open();
            try
            {
                int busq;
                busq = FN_CodBusq;


                con.sql = string.Format(@"select * from Categoria_Producto where Codigo_Categoria like '%{0}%'", busq);
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



        public void Fun_ExtraerEstados(ComboBox Pest3_Estado)
        {
            Conexion Con = new Conexion();

            Con.cnx.Open();
            Con.sql = string.Format(@"select Codigo_Estado, Descripcion_Estado from Estados WHERE Codigo_Tipo_Estado = 4");
            Con.cmd = new SqlCommand(Con.sql, Con.cnx);
            Con.DataAdapter = new SqlDataAdapter(Con.cmd);
            Con.dt = new DataTable();
            Con.DataAdapter.Fill(Con.dt);
            Con.cnx.Close();


            Pest3_Estado.ValueMember = "Codigo_Estado";
            Pest3_Estado.DisplayMember = "Descripcion_Estado";
            Pest3_Estado.DataSource = Con.dt;
        }



        public void Fun_CargarPorNombreMarcas(DataGridView dgv, string a)
        {
            Conexion con = new Conexion();
            con.cnx.Open();
            try
            {
                string busq;
                busq = a;


                con.sql = string.Format(@"select Cod_Marca as 'Codigo de Marca', Descripcion as 'Descripcion de Marca', Cod_Estado as 'Codigo de Estado', ( select E.Descripcion_Estado from Estados as E where E.Codigo_Tipo_Estado=5 and E.Codigo_Estado = Cod_Estado) as 'Estado de la Marca'  from Marca  where Descripcion like '%{0}%'", busq);
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


        public void ExtrearTodo(DataGridView dgv)
        {
            Conexion con = new Conexion();
            con.cnx.Open();
            try
            {


                con.sql = string.Format
                (@"select A.Cod_Producto as 'Codigo del Producto', A.NombreProducto as 'Nombre', A.Descripcion as 'Descripcion' ,
                A.Cod_Estado as 'Codigo de Estado', (select Est.Descripcion_Estado from Estados as Est where Est.Codigo_Estado=A.Cod_Estado and Est.Codigo_Tipo_Estado=4)
                 as Estado,A.PrecioCompra as 'Precio de Compra', A.PrecioVenta as ' Precio de Venta', A.Cod_Categoria as 'Codigo de la Categoria', C.Descripcion as 'Descripcion de Categoria'
                ,B.Cod_Modelo as 'Codigo de Modelo', B.Descripcion as 'Descripcion del Modelo',
                D.Cod_Marca as 'Codigo de Marca', D.Descripcion as 'Marca', E.Codigo_Proveedor as 'Codigo del Proveedor', E.Nombre as 'Proveedor'
                from Producto as A inner join Categoria_Producto as C on
                A.Cod_Categoria = C.Codigo_Categoria inner join Modelo as B on A.Cod_Modelo=B.Cod_Modelo
                inner join Marca D on D.Cod_Marca=B.Cod_Marca inner join Proveedor as E on E.Codigo_Proveedor=A.Cod_Proveedor");
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

        public void ExtraerPorNombreroducto(DataGridView dgv, string Nom)
        {
            Conexion con = new Conexion();
            con.cnx.Open();
            try
            {


                con.sql = string.Format
                (@"select A.Cod_Producto as 'Codigo del Producto', A.NombreProducto as 'Nombre', A.Descripcion as 'Descripcion' ,
                A.Cod_Estado as 'Codigo de Estado', (select Est.Descripcion_Estado from Estados as Est where Est.Codigo_Estado=A.Cod_Estado and Est.Codigo_Tipo_Estado=4)
                as Estado,A.PrecioCompra as 'Precio de Compra', A.PrecioVenta as ' Precio de Venta', A.Cod_Categoria as 'Codigo de la Categoria', C.Descripcion as 'Descripcion de Categoria'
                , A.CantExistenteTienda as 'Existencia en Tienda', B.Cod_Modelo as 'Codigo de Modelo', B.Descripcion as 'Descripcion del Modelo',
                D.Cod_Marca as 'Codigo de Marca', D.Descripcion as 'Marca', E.Codigo_Proveedor as 'Codigo del Proveedor', E.Nombre as 'Proveedor'
                from Producto as A inner join Categoria_Producto as C on
                A.Cod_Categoria = C.Codigo_Categoria inner join Modelo as B on A.Cod_Modelo=B.Cod_Modelo
                inner join Marca D on D.Cod_Marca=B.Cod_Marca inner join Proveedor 
                as E on E.Codigo_Proveedor=A.Cod_Proveedor
                where  A.NombreProducto like '%{0}%'", Nom);
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

        public void Fun_ExtraerPorCodigoroducto(DataGridView dgv, int VF_Codig)
        {

            cnx.Open();
            try
            {


                sql = string.Format
                (@"select A.Cod_Producto as 'Codigo del Producto', A.NombreProducto as 'Nombre', A.Descripcion as 'Descripcion' ,
                A.Cod_Estado as 'Codigo de Estado', (select Est.Descripcion_Estado from Estados as Est where Est.Codigo_Estado=A.Cod_Estado and Est.Codigo_Tipo_Estado=4)
                as Estado,A.PrecioCompra as 'Precio de Compra', A.PrecioVenta as ' Precio de Venta', A.Cod_Categoria as 'Codigo de la Categoria', C.Descripcion as 'Descripcion de Categoria'
                ,B.Cod_Modelo as 'Codigo de Modelo', B.Descripcion as 'Descripcion del Modelo',
                D.Cod_Marca as 'Codigo de Marca', D.Descripcion as 'Marca', E.Codigo_Proveedor as 'Codigo del Proveedor', E.Nombre as 'Proveedor'
                from Producto as A inner join Categoria_Producto as C on
                A.Cod_Categoria = C.Codigo_Categoria inner join Modelo as B on A.Cod_Modelo=B.Cod_Modelo
                inner join Marca D on D.Cod_Marca=B.Cod_Marca inner join Proveedor 
                as E on E.Codigo_Proveedor=A.Cod_Proveedor
                where A.Cod_Producto like '%{0}%'", VF_Codig);
                cmd = new SqlCommand(sql, cnx);
                DataAdapter = new SqlDataAdapter(cmd);
                dt = new DataTable();
                DataAdapter.Fill(dt);
                dgv.DataSource = dt;

            }
            catch
            {

            }
            cnx.Close();
        }


        public void Fun_CargarPrimerDataGriew(DataGridView dgv)
        {
     
            cnx.Open();
            try
            {
                DataAdapter = new SqlDataAdapter("select * from Modelo where Cod_Estado = 1", ccnx);
                dt = new DataTable();
                DataAdapter.Fill(dt);
                dgv.DataSource = dt;

            }
            catch
            {

            }
            cnx.Close();
        }


        public void Fun_ExtraerCodigoModelo(TextBox VF_CodigoModelo)
        {

            cnx.Open();
            sql = String.Format(@"Select TOP 1 Cod_Modelo from Modelo ORDER BY Cod_Modelo DESC");
            cmd = new SqlCommand(sql, cnx);
            SqlDataReader Reg = null;
            Reg = cmd.ExecuteReader();
            if (Reg.Read())
            {
                VF_CodigoModelo.Text = Convert.ToString(Convert.ToInt16((Reg["Cod_Modelo"].ToString())) + 1);
                cnx.Close();
            }
        }


        public void Fun_CargarLocalidad(DataGridView dgv, string VF_CodBus)
        {

            cnx.Open();
            try
            {
                string busq;
                busq = VF_CodBus;


                sql = string.Format
                (@"select P.Cod_Localidad as 'Codigo de Localidad', L.Nombre as 'Localidad', P.Cantidad as 'Unidades en existencia' 
                from [Producto|Localidad] as P inner join Localidad as L on L.Cod_Localidad=P.Cod_Localidad
                where P.Cod_Producto='{0}' and (P.Cod_Localidad='1' or P.Cod_Localidad='2')", VF_CodBus);
                cmd = new SqlCommand(sql, cnx);
                DataAdapter = new SqlDataAdapter(cmd);
                dt = new DataTable();
                DataAdapter.Fill(dt);
                dgv.DataSource = dt;

            }
            catch
            {

            }
            cnx.Close();
        }


        public void Fun_CargarLocalidadIndividual(DataGridView dgv, string VF_CodPro, string VF_CodLoc)
        {
           
            cnx.Open();
            try
            {
                string busq;
                busq = VF_CodPro;


                sql = string.Format
                (@"select P.Cod_Localidad as 'Codigo de Localidad', L.Nombre as 'Localidad', P.Cantidad as 'Unidades en existencia' 
                from [Producto|Localidad] as P inner join Localidad as L on L.Cod_Localidad=P.Cod_Localidad
                where P.Cod_Producto='{0}' and P.Cod_Localidad='{1}'", VF_CodPro, VF_CodLoc);
                cmd = new SqlCommand(sql, cnx);
                DataAdapter = new SqlDataAdapter(cmd);
                dt = new DataTable();
                DataAdapter.Fill(dt);
                dgv.DataSource = dt;

            }
            catch
            {

            }
            cnx.Close();
        }


        public void Fun_LLenarLocalidades(ComboBox VF_ComLoc)
        {
            cnx.Open();
            sql = string.Format(@"select Cod_Localidad as 'Cod', Nombre as 'Nombre' from Localidad");
            cmd = new SqlCommand(sql, cnx);
            DataAdapter = new SqlDataAdapter(cmd);
            dt = new DataTable();
            DataAdapter.Fill(dt);
            cnx.Close();

            VF_ComLoc.ValueMember = "Cod";
            VF_ComLoc.DisplayMember = "Nombre";
            VF_ComLoc.DataSource = dt;
        }


    }
}
