using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desarrollo.Clases
{
    class C_ContactosProveedores:Conexion
    {
        int codigoContacto;
        string nombreContacto;
        string apellidoContacto;
        string correoContacto;
        string telefonoContacto;
        string cargoContacto;
        int estadoContacto;
        int codigoProveedor;

        public int Var_CodigoContacto
        {
            get
            {
                return codigoContacto;
            }

            set
            {
                codigoContacto = value;
            }
        }

        public string Var_NombreContacto
        {
            get
            {
                return nombreContacto;
            }

            set
            {
                nombreContacto = value;
            }
        }

        public string Var_ApellidoContacto
        {
            get
            {
                return apellidoContacto;
            }

            set
            {
                apellidoContacto = value;
            }
        }

        public string Var_CorreoContacto
        {
            get
            {
                return correoContacto;
            }

            set
            {
                correoContacto = value;
            }
        }

        public string Var_TelefonoContacto
        {
            get
            {
                return telefonoContacto;
            }

            set
            {
                telefonoContacto = value;
            }
        }

        public string Var_CargoContacto
        {
            get
            {
                return cargoContacto;
            }

            set
            {
                cargoContacto = value;
            }
        }

        public int Var_EstadoContacto
        {
            get
            {
                return estadoContacto;
            }

            set
            {
                estadoContacto = value;
            }
        }

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

      public void Fun_Verificar_RepeticionContacto()
        {

        }

        public bool Fun_Agregar_Contacto()
        {
            bool resultado = false;
            this.sql = string.Format(
                @"INSERT INTO [Contacto|Proveedor] VALUES ('{0}',  '{1}',  '{2}',  '{3}', '{4}',
            '1',  (select top 1 Codigo_Proveedor from Proveedor order by Codigo_Proveedor desc))", this.Var_NombreContacto, this.Var_ApellidoContacto, this.Var_CorreoContacto, this.Var_TelefonoContacto,
            this.Var_CargoContacto);
            this.cmd = new SqlCommand(this.sql, this.cnx);
            this.cnx.Open();
            SqlDataReader Reg = null;
            Reg = this.cmd.ExecuteReader();
            this.cnx.Close();
            return resultado;

        }


        public bool RevisionDeDatos()
        {
            this.sql = string.Format(@"select Correo from [Contacto|Proveedor] where Correo='{0}'", Var_CorreoContacto);
            this.cmd = new SqlCommand(this.sql, this.cnx);
            this.cnx.Open();
            SqlDataReader Reg1 = null;
            Reg1 = this.cmd.ExecuteReader();

            if (Reg1.Read())
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

        public void Fun_Modificar_Contacto()
        {
            this.sql = string.Format(@"update [Contacto|Proveedor]  set Correo = '{0}', Telefono = '{1}', Cargo = '{2}', Codigo_Estado = '{3}' where Codigo_Contacto = '{4}'", Var_CorreoContacto, Var_TelefonoContacto, Var_CargoContacto, Var_EstadoContacto , Var_CodigoContacto);
            this.cmd = new SqlCommand(this.sql, this.cnx);
            this.cnx.Open();
            SqlDataReader Reg = null;
            Reg = this.cmd.ExecuteReader();
            this.cnx.Close();
        }
    }
}
