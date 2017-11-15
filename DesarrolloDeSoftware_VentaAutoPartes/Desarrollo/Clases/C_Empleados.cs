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
        private int telefono_fijo;
        private int telefono_celular;
        private DateTime fecha_nacimiento;
        private string genero;
        private string contrasena;
        private string estado_civil;
        private int codigo_rol;
        private int codigo_estado;

        public int Codigo_empleado
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

        public string Id_empleado
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

        public string Nombre_empleado
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

        public string Apellido_empleado
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

        public string Correo_empleado
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

        public int Telefono_fijo
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

        public int Telefono_celular
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

        public DateTime Fecha_nacimiento
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

        public string Genero
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

        public string Contrasena
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

        public int Var_Codigo_rol
        {   get { return codigo_rol; }
            set {codigo_rol = value;}
        }

        public int Var_Codigo_estado
        {  get { return codigo_estado; }
           set { codigo_estado = value;}
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


        ///CAS0: Agregar empleado
        ///
        public int OptenerUltimoID()
        {
            int Codigo=0;
            this.sql = string.Format(@"select Top 1 Codigo_Empleado as CodigoFinal from Empleados");
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
         //////////////////////////////
    }
}
