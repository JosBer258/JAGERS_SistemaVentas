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
    class C_Compras:Conexion
    {
        public DataTable DataSource { get; private set; }

        public int CodigoNuevoCompra()
        {
            int NuevoCodigo = 0;

            this.sql = string.Format(@"select Top 1 [Codigo_Compras] as CodigoFinal from Compras order by [Codigo_Compras] desc");
            this.cmd = new SqlCommand(this.sql, this.cnx);
            this.cnx.Open();

            SqlDataReader Reg = null;
            Reg = this.cmd.ExecuteReader();

            if (Reg.Read())
            {
                NuevoCodigo = Convert.ToInt32((Reg["CodigoFinal"].ToString()));

            }
            else
            {

            }

            this.cnx.Close();

            return (NuevoCodigo + 1);
        }

        public void FiltroBusquedaProveedor(ComboBox Combo_Box, string Filtro)
        {
            if(Filtro == string.Empty)
            {
                Filtro = "a";
            }

            this.cnx.Open();
            this.sql = string.Format(@"select Codigo_Proveedor, Nombre from Proveedor where Nombre like '%{0}%' and Codigo_Estado=1", Filtro);
            this.cmd = new SqlCommand(this.sql, this.cnx);
            this.DataAdapter = new SqlDataAdapter(this.cmd);
            this.dt = new DataTable();
            this.DataAdapter.Fill(this.dt);
            this.cnx.Close();

            Combo_Box.ValueMember = "Codigo_Proveedor";
            Combo_Box.DisplayMember = "Nombre";
            Combo_Box.DataSource = this.dt;

        }

        public void FiltroBusquedaProductos(ComboBox Combo_Box, string Filtro)
        {
            if (Filtro == string.Empty)
            {
                Filtro = "a";
            }

            this.cnx.Open();
            this.sql = string.Format(@"select Cod_Producto, NombreProducto from Producto where NombreProducto like '%{0}%' and Cod_Estado=1", Filtro);
            this.cmd = new SqlCommand(this.sql, this.cnx);
            this.DataAdapter = new SqlDataAdapter(this.cmd);
            this.dt = new DataTable();
            this.DataAdapter.Fill(this.dt);
            this.cnx.Close();

            Combo_Box.ValueMember = "Cod_Producto";
            Combo_Box.DisplayMember = "NombreProducto";
            Combo_Box.DataSource = this.dt;
        }

        public void ExtraccionIformacionProductos(ComboBox Combo_Box, string Cod_Filtro)
        {
            int Filtro = 0;
            if (Cod_Filtro == string.Empty)
            {
                Cod_Filtro = "0";
            }

            Filtro = Convert.ToInt32(Cod_Filtro);

            this.cnx.Open();
            this.sql = string.Format(@"select L.Cod_Localidad as 'Local', L.Nombre as 'Name'  from Localidad as L inner join [Producto|Localidad] as Pl
                                       on L.Cod_Localidad=Pl.Cod_Localidad inner join Producto as P
                                       on P.Cod_Producto=Pl.Cod_Producto where P.Cod_Producto='{0}'", Filtro);

            this.cmd = new SqlCommand(this.sql, this.cnx);
            this.DataAdapter = new SqlDataAdapter(this.cmd);
            this.dt = new DataTable();
            this.DataAdapter.Fill(this.dt);
            this.cnx.Close();

            Combo_Box.ValueMember = "Local";
            Combo_Box.DisplayMember = "Name";
            Combo_Box.DataSource = this.dt;
        }

        ///Ingreso Y Modificacion
        
        public void AgregarCompra(int Cod, string Fecha_Entrega, string Fecha_Realizacion, string Empleado, int Cod_Proveedor)
        {
            

            this.sql = string.Format(@"insert into Compras 
                                        values('{0}','{1}','{2}',
                                        '{3}','{4}')",
                                        Cod, Fecha_Entrega, Fecha_Realizacion, Empleado, Cod_Proveedor);
            this.cmd = new SqlCommand(this.sql, this.cnx);

            this.cnx.Open();
            SqlDataReader Reg = null;
            Reg = this.cmd.ExecuteReader();
            this.cnx.Close();
        }


        public void AgregarDetallesCompra(string NombreProducto,string Localidad, int CantidadIngresada, float Precio)
        {
            this.sql = string.Format(@"insert into [Detalles|Compras]
                                        values ( (select Top 1 Codigo_Compras from Compras order by Codigo_Compras desc), 
                                        (select Cod_Producto from Producto where NombreProducto='{0}'), 
                                        (select Cod_Localidad from Localidad where Nombre='{1}'),'{2}','{3}')",
                                        NombreProducto,Localidad ,CantidadIngresada, Precio);
            this.cmd = new SqlCommand(this.sql, this.cnx);

            this.cnx.Open();
            SqlDataReader Reg = null;
            Reg = this.cmd.ExecuteReader();
            this.cnx.Close();
        }


        public void ModificarProducto(string NombreProducto, float PrecioCompra)
        {
            this.sql = string.Format(@"update Producto
                                       set PrecioCompra='{0}'
                                       where NombreProducto='{1}'", PrecioCompra, NombreProducto);
           this.cmd = new SqlCommand(this.sql, this.cnx);

            this.cnx.Open();
            SqlDataReader Reg = null;
            Reg = this.cmd.ExecuteReader();
            this.cnx.Close();
        }


        public void ModificarProductos_Localidad(string NombreProducto, string Localidad, int Cantidad)
        {
            this.sql = string.Format(@"update [Producto|Localidad] set Cantidad=CAST( (CAST(Cantidad as float)+ {0}) as nvarchar)
                                    where Cod_Localidad=(select Cod_Localidad from Localidad where Nombre='{1}') 
                                    and Cod_Producto=(select Cod_Producto from Producto where NombreProducto='{2}')",
                                    Cantidad, Localidad, NombreProducto);
            this.cmd = new SqlCommand(this.sql, this.cnx);

            this.cnx.Open();
            SqlDataReader Reg = null;
            Reg = this.cmd.ExecuteReader();
            this.cnx.Close();
        }

        //Funcion de Busqueda de Compras
        public void Llenar_DataGriewIncial(DataGridView DataGriew)
        {
           
            this.cnx.Open();
           

                this.sql = string.Format
                (@"select C.Codigo_Compras as 'Codigo de la Compra', C.Fecha_Entrega as 
                    'Fecha de la Entrega', C.Fecha_Pedido as 'Fecha del Pedido', (E.Nombre + ' ' + E.Apellido) as 'Empleado Receptor',
                     P.Nombre as 'Nombre del Proveedor'
                    from Compras as C inner join Empleados as E on C.Cod_Empleado= E.Codigo_Empleado inner join
                    Proveedor as P on C.Cod_Proveedor=P.Codigo_Proveedor");
                this.cmd = new SqlCommand(this.sql, this.cnx);
                this.DataAdapter = new SqlDataAdapter(this.cmd);
                this.dt = new DataTable();
                this.DataAdapter.Fill(this.dt);
            DataGriew.DataSource = this.dt;
            this.cnx.Close();
           
           
        }



        public void Llenar_DataGriewCodigo(DataGridView DataGriew, double Cod)
        {

            this.cnx.Open();
            int Codigo = (int)Cod;

            this.sql = string.Format
            (@"select C.Codigo_Compras as 'Codigo de la Compra', C.Fecha_Entrega as 
                    'Fecha de la Entrega', C.Fecha_Pedido as 'Fecha del Pedido', (E.Nombre + ' ' + E.Apellido) as 'Empleado Receptor',
                     P.Nombre as 'Nombre del Proveedor'
                    from Compras as C inner join Empleados as E on C.Cod_Empleado= E.Codigo_Empleado inner join
                    Proveedor as P on C.Cod_Proveedor=P.Codigo_Proveedor
                    where Codigo_Compras like '%{0}%'", Codigo);

            this.cmd = new SqlCommand(this.sql, this.cnx);
            this.DataAdapter = new SqlDataAdapter(this.cmd);
            this.dt = new DataTable();
            this.DataAdapter.Fill(this.dt);
            DataGriew.DataSource = this.dt;
            this.cnx.Close();


        }



        public void Llenar_DataGriewProveedor(DataGridView DataGriew, string Nom)
        {


            this.sql = string.Format
            (@"select C.Codigo_Compras as 'Codigo de la Compra', C.Fecha_Entrega as 
                    'Fecha de la Entrega', C.Fecha_Pedido as 'Fecha del Pedido', (E.Nombre + ' ' + E.Apellido) as 'Empleado Receptor',
                     P.Nombre as 'Nombre del Proveedor'
                    from Compras as C inner join Empleados as E on C.Cod_Empleado= E.Codigo_Empleado inner join
                    Proveedor as P on C.Cod_Proveedor=P.Codigo_Proveedor
                    where p.Nombre like '%{0}%'", Nom);

            this.cmd = new SqlCommand(this.sql, this.cnx);
            this.DataAdapter = new SqlDataAdapter(this.cmd);
            this.dt = new DataTable();
            this.DataAdapter.Fill(this.dt);
            DataGriew.DataSource = this.dt;
            this.cnx.Close();


        }


        public void Llenar_DataGriewDetalles(DataGridView DataGriew, float Codigo_Factura)
        {
            int Cod = (int)Codigo_Factura;

            this.sql = string.Format
            (@" select 
                B.NombreProducto as 'Nombre del Producto',
                D.Descripcion as 'Modelo',
                E.Descripcion as 'Marca',
                C.Nombre as 'Localidad'
                from [Detalles|Compras] As A inner join Producto as B on A.Codigo_Producto=B.Cod_Producto
                inner join Localidad as C on C.Cod_Localidad=A.Cod_Localidad inner join Modelo as D on D.Cod_Modelo=B.Cod_Modelo
                inner join Marca as E on E.Cod_Marca=D.Cod_Marca
                where A.Codigo_Compra= '{0}'", Cod);

            this.cmd = new SqlCommand(this.sql, this.cnx);
            this.DataAdapter = new SqlDataAdapter(this.cmd);
            this.dt = new DataTable();
            this.DataAdapter.Fill(this.dt);
            DataGriew.DataSource = this.dt;
            this.cnx.Close();

        }

        //*************************************************************************************************************************************************


        public void Llenar_DataGriewFechaEntrega(DataGridView DataGriew, string Date)
        {

            this.cnx.Open();


            this.sql = string.Format
            (@"select C.Codigo_Compras as 'Codigo de la Compra', C.Fecha_Entrega as 
                    'Fecha de la Entrega', C.Fecha_Pedido as 'Fecha del Pedido', (E.Nombre + ' ' + E.Apellido) as 'Empleado Receptor',
                     P.Nombre as 'Nombre del Proveedor'
                    from Compras as C inner join Empleados as E on C.Cod_Empleado= E.Codigo_Empleado inner join
                    Proveedor as P on C.Cod_Proveedor=P.Codigo_Proveedor
                    where Fecha_Entrega='{0}'", Date);
            this.cmd = new SqlCommand(this.sql, this.cnx);
            this.DataAdapter = new SqlDataAdapter(this.cmd);
            this.dt = new DataTable();
            this.DataAdapter.Fill(this.dt);
            DataGriew.DataSource = this.dt;
            this.cnx.Close();


        }


        public void Llenar_DataGriewFechaPedido(DataGridView DataGriew, string Date)
        {

            this.cnx.Open();


            this.sql = string.Format
            (@"select C.Codigo_Compras as 'Codigo de la Compra', C.Fecha_Entrega as 
                    'Fecha de la Entrega', C.Fecha_Pedido as 'Fecha del Pedido', (E.Nombre + ' ' + E.Apellido) as 'Empleado Receptor',
                     P.Nombre as 'Nombre del Proveedor'
                    from Compras as C inner join Empleados as E on C.Cod_Empleado= E.Codigo_Empleado inner join
                    Proveedor as P on C.Cod_Proveedor=P.Codigo_Proveedor where Fecha_Pedido='{0}'", Date);
            this.cmd = new SqlCommand(this.sql, this.cnx);
            this.DataAdapter = new SqlDataAdapter(this.cmd);
            this.dt = new DataTable();
            this.DataAdapter.Fill(this.dt);
            DataGriew.DataSource = this.dt;
            this.cnx.Close();


        }
    }

}
