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
    class C_Categoria_Productos : Conexion
    {
        int codigo_categoria;
        string descripcion_categoria;
        int estado;
        int codigo_producto;
        int precio_de_venta;
        int precio_de_compra;
        int total_bodega;
        int total_tienda;

        public int Var_Codigo_categoria
        {
            get
            {
                return codigo_categoria;
            }

            set
            {
                codigo_categoria = value;
            }
        }

        public string Var_Descripcion_categoria
        {
            get
            {
                return descripcion_categoria;
            }

            set
            {
                descripcion_categoria = value;
            }
        }

        public int Var_Precio_de_venta
        {
            get
            {
                return precio_de_venta;
            }

            set
            {
                precio_de_venta = value;
            }
        }

        public int Var_Precio_de_compra
        {
            get
            {
                return precio_de_compra;
            }

            set
            {
                precio_de_compra = value;
            }
        }

        public int Var_Total_bodega
        {
            get
            {
                return total_bodega;
            }

            set
            {
                total_bodega = value;
            }
        }

        public int Var_Total_tienda
        {
            get
            {
                return total_tienda;
            }

            set
            {
                total_tienda = value;
            }
        }

        public int Var_Codigo_producto
        {
            get
            {
                return codigo_producto;
            }

            set
            {
                codigo_producto = value;
            }
        }

        public int Var_Estado
        {
            get
            {
                return estado;
            }

            set
            {
                estado = value;
            }
        }

        public void Fun_ModificarDatos()
        {

            sql = string.Format(@"update Categoria_Producto set Descripcion = '{0}' where Codigo_Categoria = '{1}'", Var_Descripcion_categoria, Var_Codigo_categoria);

            cmd = new SqlCommand(sql, cnx);

            cnx.Open();
            SqlDataReader Reg = null;
            Reg = cmd.ExecuteReader();
            cnx.Close();


        }

        public void Fun_Agregar()
        {



            //cnx.Open();
            sql = string.Format(@"insert into Categoria_Producto values ('{0}')", this.Var_Descripcion_categoria);

            cmd = new SqlCommand(sql, cnx);

            cnx.Open();
            SqlDataReader Reg = null;
            Reg = this.cmd.ExecuteReader();
            cnx.Close();


        }

        
        public void Fun_Modificar(ComboBox comb, int a)
        {


            this.Var_Estado = Convert.ToInt16(comb.SelectedValue);
            //cnx.Open();
            sql = string.Format(@"update Producto set  Cod_Estado={0}, PrecioVenta= {1}, PrecioCompra = {2}, 
                                   Cod_Proveedor={3}  where Cod_Producto = {4}",
               this.Var_Estado, this.Var_Precio_de_venta, this.Var_Precio_de_compra, a,this.Var_Codigo_producto);

            cmd = new SqlCommand(sql, cnx);

            cnx.Open();
            SqlDataReader Reg = null;
            Reg = this.cmd.ExecuteReader();
            cnx.Close();


        }

        public void Fun_CargarPrimerDataGriew(DataGridView dgv)
        {
            Conexion con = new Conexion();
            con.cnx.Open();
            try
            {
                con.DataAdapter = new SqlDataAdapter("Select * from Categoria_Producto", con.ccnx);
                con.dt = new DataTable();
                con.DataAdapter.Fill(con.dt);
                dgv.DataSource = con.dt;

            }
            catch
            {

            }
        }

    }

}
