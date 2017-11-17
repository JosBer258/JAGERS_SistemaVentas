using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Desarrollo.Clases
{
    class C_Empleados:Conexion
    { 

        private int codigo_empleado;
        private string id_empleado;
        private string nombre_empleado;
        private string apellido_empleado;
        private string correo_empleado;
        private string telefono_fijo;
        private string telefono_celular;
        private string fecha_nacimiento;
        private string genero;
        private string contrasena;
        private string estado_civil;
        private string codigo_rol;
        private string empleado_estado;
        private string direccion;

        public string Var_Direccion
        {
            get
            {
                return direccion;
            }

            set
            {
                direccion = value;
            }
        }

        public int Var_Codigo_empleado
        {
            get
            {
                return codigo_empleado;
            }

            set
            {
                codigo_empleado = value;
            }
        }

        public string Var_Id_empleado
        {
            get
            {
                return id_empleado;
            }

            set
            {
                id_empleado = value;
            }
        }

        public string Var_Nombre_empleado
        {
            get
            {
                return nombre_empleado;
            }

            set
            {
                nombre_empleado = value;
            }
        }

        public string Var_Apellido_empleado
        {
            get
            {
                return apellido_empleado;
            }

            set
            {
                apellido_empleado = value;
            }
        }

        public string Var_Correo_empleado
        {
            get
            {
                return correo_empleado;
            }

            set
            {
                correo_empleado = value;
            }
        }

        public string Var_Telefono_fijo
        {
            get
            {
                return telefono_fijo;
            }

            set
            {
                telefono_fijo = value;
            }
        }

        public string Var_Telefono_celular
        {
            get
            {
                return telefono_celular;
            }

            set
            {
                telefono_celular = value;
            }
        }

        public string Var_Fecha_nacimiento
        {
            get
            {
                return fecha_nacimiento;
            }

            set
            {
                fecha_nacimiento = value;
            }
        }

        public string Var_Genero
        {
            get
            {
                return genero;
            }

            set
            {
                genero = value;
            }
        }

        public string Var_Contrasena
        {
            get
            {
                return contrasena;
            }

            set
            {
                contrasena = value;
            }
        }

        public string Var_Estado_civil
        {   get{return estado_civil;}
            set{ estado_civil = value;}
        }

        public string Var_Rol
        {   get { return codigo_rol; }
            set {codigo_rol = value;}
        }

        public string Var_Codigo_estado
        {  get { return empleado_estado; }
           set { empleado_estado = value;}
        }

        public bool Fun_IngresoNuevoEmpleado()
        {
            return false;
        }

        public bool Fun_ModificacionEmpleado()
        {
            return false;
        }

        public bool Fun_BusquedaDeEmpleados()
        {
            return false;
        }

        public bool Fun_BusquedaRoles()
        {
            return false;
        }

        public bool Fun_IngresarRoles()
        {
            return false;
        }

        public bool Fun_ModificarRoles()
        {
            return false;
        }


        //////////////////////////////////////////////////////////////CAS0: Agregar empleado
        ////////////////////////////////////////////////////////////////////////////////////
        public int OptenerUltimoID()
        {
            int Codigo=0;
            this.sql = string.Format(@"select top 1 Codigo_Empleado as CodigoFinal from Empleados order by Codigo_Empleado desc");
            this.cmd = new SqlCommand(this.sql, this.cnx);
            this.cnx.Open();

            SqlDataReader Reg = null;
            Reg = this.cmd.ExecuteReader();

            if (Reg.Read())
            {
                Codigo = Convert.ToInt16((Reg["CodigoFinal"].ToString()));

            }
            else
            {
                
            }

            this.cnx.Close();
            return (Codigo + 1);
        }


        public bool RevisionDeDatos()
        {
            this.sql = string.Format(@"select * from Empleados where ID='{0}' or (Nombre='{1}' and Apellido='{2}')", Var_Id_empleado, Var_Nombre_empleado, Var_Apellido_empleado);
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

        public void IngresoDatos()
        {

            //char Genero;

            //if (Var_Genero.Equals("Masculino")) { Genero = 'M'; } else { Genero = 'F'; }
            
            this.sql = string.Format(@"insert into Empleados values(
            '{0}',  '{1}',  '{2}',  '{3}', '{4}', '{5}', '{6}', '{7}','{8}','{9}', 
            '{10}', '{11}', '{12}')",
            Var_Id_empleado, Var_Nombre_empleado, Var_Apellido_empleado,Var_Correo_empleado, Var_Telefono_fijo,
            Var_Telefono_celular,Var_Fecha_nacimiento, Var_Genero, Var_Contrasena, Var_Estado_civil,
            Var_Rol, Var_Codigo_estado, Var_Direccion);

            this.cmd = new SqlCommand(this.sql, this.cnx);
            this.cnx.Open();
            SqlDataReader Reg = null;
            Reg = this.cmd.ExecuteReader();    
            this.cnx.Close();
        }




        public void Fun_MoodificarDatos(string Telefono, int Estado, string Civil, int CodigoRol, string Direccion, string correo, string contra, string fijo ,int Codigo_e)
        {
            this.sql = string.Format(@"update Empleados
                                       set TelefonoCelular='{0}', Codigo_Estado='{1}', EstadoCivil='{2}', Codigo_Rol='{3}', 
                                         Direccion='{4}', Correo='{5}', Contraseña='{6}', TelefonoFijo='{7}' where Codigo_Empleado = '{8}'",
                                         Telefono, Estado, Civil, CodigoRol, Direccion, correo, contra, fijo, Codigo_e);

            this.cmd = new SqlCommand(this.sql, this.cnx);

            this.cnx.Open();
            SqlDataReader Reg = null;
            Reg = this.cmd.ExecuteReader();
            this.cnx.Close();

        }
        ///////////////////////////////////////////////////////////////////////////////////////////////
    }
}
