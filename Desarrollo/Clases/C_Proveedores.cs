using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desarrollo.Clases
{
    class C_Proveedores:Conexion
    {
        int codigoProveedor;
        string nombreProveedor;
        string correoProveedor;
        int codigoPostalProveedor;
        string direccionProveedor;
        int estadoProveedor;
        int nacionalidadProveedor;

        public int Var_CodigoProveedor
        {
            get
            {
                return codigoProveedor;
            }

            set
            {
                codigoProveedor = value;
            }
        }

        public string Var_NombreProveedor
        {
            get
            {
                return nombreProveedor;
            }

            set
            {
                nombreProveedor = value;
            }
        }

        public string Var_CorreoProveedor
        {
            get
            {
                return correoProveedor;
            }

            set
            {
                correoProveedor = value;
            }
        }

        public int Var_CodigoPostalProveedor
        {
            get
            {
                return codigoPostalProveedor;
            }

            set
            {
                codigoPostalProveedor = value;
            }
        }

        public string Var_DireccionProveedor
        {
            get
            {
                return direccionProveedor;
            }

            set
            {
                direccionProveedor = value;
            }
        }

        public int Var_EstadoProveedor
        {
            get
            {
                return estadoProveedor;
            }

            set
            {
                estadoProveedor = value;
            }
        }

        public int Var_NacionalidadProveedor
        {
            get
            {
                return nacionalidadProveedor;
            }

            set
            {
                nacionalidadProveedor = value;
            }
        }


        public void Fun_Agregar_Proveedor()
        {


            this.sql = string.Format(
                @"insert into Proveedor 
                  (Nombre, Correo, CodigoPostal, Direccion, Codigo_Estado, Codigo_Nacionalidad ) 
                    values ('{0}','{1}','{2}','{3}','{4}','{5}')",
            this.Var_NombreProveedor, this.Var_CorreoProveedor,
            this.Var_CodigoPostalProveedor, this.Var_DireccionProveedor,
            this.Var_EstadoProveedor, this.Var_NacionalidadProveedor);



            this.cmd = new SqlCommand(this.sql, this.cnx);
            this.cnx.Open();
            SqlDataReader Reg = null;
            Reg = this.cmd.ExecuteReader();
            this.cnx.Close();

        }

        //Fun_Modificar_Proveedor
       
        public void Fun_Modificar_Proveedor(int Codigo, string Correo, string Direccion, int CodigoEstado)
        {
            this.sql = string.Format(@"update Proveedor set Correo = '{0}', Direccion = '{1}', Codigo_Estado = '{2}' where Codigo_Proveedor = '{3}'", Correo, Direccion, CodigoEstado, Codigo);
            this.cmd = new SqlCommand(this.sql, this.cnx);
            this.cnx.Open();
            SqlDataReader Reg = null;
            Reg = this.cmd.ExecuteReader();

            this.cnx.Close();
        }
        public bool RevisionDeDatos()
        {
            this.sql = string.Format(@"select Nombre from Proveedor where Nombre='{0}'", Var_NombreProveedor);
            this.cmd = new SqlCommand(this.sql, this.cnx);
            this.cnx.Open();
            SqlDataReader Reg = null;
            Reg = this.cmd.ExecuteReader();

            if (Reg.Read())
            {

                this.cnx.Close();
                return false;

            }
            else
            {
                this.cnx.Close();

                return true;
            }

        }
    }
}
