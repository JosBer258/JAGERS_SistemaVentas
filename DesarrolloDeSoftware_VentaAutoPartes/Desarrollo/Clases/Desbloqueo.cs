using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Desarrollo.Clases
{
    class Desbloqueo:Conexion
    {
        private string id_empleado;
        private string contrasena;
        private string codigo_estado;
        private string codigo_rol;

        public string Var_Id_empleado
        {
            get { return id_empleado; }
            set { id_empleado = value; }
        }

        public string Var_Codigo_Rol
        {
            get { return codigo_rol; }
            set { codigo_rol = value; }
        }


        public string Var_Contrasena
        {
            get { return contrasena; }
            set { contrasena = value; }
        }

        public string Var_Codigo_estado
        {
            get { return codigo_estado; }
            set { codigo_estado = value; }
        }

        public bool Fun_Comprobacion(string ID, string Password)
        {

            bool resultado = false;
            this.sql = string.Format(@"select ID, Nombre, Contraseña, Codigo_Rol, Codigo_Estado from Empleados where ID = '{0}' and Contraseña ='{1}' and Codigo_Rol= '{2}'", ID, Password, 1);
            this.cmd = new SqlCommand(this.sql, this.cnx);
            this.cnx.Open();
            SqlDataReader Reg = null;
            Reg = this.cmd.ExecuteReader();

            if (Reg.Read())
            {
                Var_Codigo_estado = Reg["Codigo_Estado"].ToString();
                if (Convert.ToInt16(Var_Codigo_estado) == 1)
                {
                    this.cnx.Close();

                    resultado = true;
                }
                else
                {
                    this.cnx.Close();
                    resultado = false;
                }
            }
            else
            {
                resultado = false;
            }
            this.cnx.Close();
            return resultado;
        }


        public void Fun_Restauracion(string ID)
        {
            this.sql = string.Format(@"update Empleados set Codigo_Estado = 1 where ID = '{0}'", ID);
            this.cmd = new SqlCommand(this.sql, this.cnx);
            this.cnx.Open();
            SqlDataReader Reg = null;
            Reg = this.cmd.ExecuteReader();

            this.cnx.Close();
        }

        public void Fun_NuevaContraseña(string ID, string Contraseña)
        {
            this.sql = string.Format(@"update Empleados set Contraseña = '{0}' where ID = '{1}'",Contraseña, ID);
            this.cmd = new SqlCommand(this.sql, this.cnx);
            this.cnx.Open();
            SqlDataReader Reg = null;
            Reg = this.cmd.ExecuteReader();

            this.cnx.Close();
        }
    }
}
