using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Desarrollo.Clases
{
    class C_Desbloqueo:Conexion
    {
        private string var_id_empleado;
        private string var_contrasena;
        private string var_codigo_estado;
        private string var_codigo_rol;

        public string Var_Id_empleado
        {
            get { return var_id_empleado; }
            set { var_id_empleado = value; }
        }

        public string Var_Codigo_Rol
        {
            get { return var_codigo_rol; }
            set { var_codigo_rol = value; }
        }


        public string Var_Contrasena
        {
            get { return var_contrasena; }
            set { var_contrasena = value; }
        }

        public string Var_Codigo_estado
        {
            get { return var_codigo_estado; }
            set { var_codigo_estado = value; }
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

        public void Fun_RestablecerIntentos(string ID)
        {
            this.sql = string.Format(@" UPDATE  A Set A.Oportunidades = 6 from Login as A INNER JOIN Empleados as B  ON A.Codigo_Empleado = B.Codigo_Empleado WHERE B.ID ='{0}'", ID);
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
