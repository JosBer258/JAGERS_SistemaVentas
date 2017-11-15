using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desarrollo.Clases
{
    class C_Usuarios : Conexion
    {
        /* 
         * ********************ESTANDARISACION******************
         
         Variables=Normales ex: Numero y con nombre Descriptivos. 
         Llamadas con Var_ Primero y luego el nombre de la variable:  Var_Numero {get, set}
         Funciones con Fun_ Primero: Fun_Buscar, Nombres descriptivos
         Clases con C_ al principio: C_Usuarios excepto la clase Conexion, Nombres descriptivos
         Formas con Form al principio: Form_Ingreso_Al_Sistema, Nombres Descriptivos
         Textos dependiendo si la pantalla tiene pestañas, si las tienen devera ser Pest(Num de pestaña)_Txt_Variable
                 ejemplo: Pest1_Txt_ID, en caso de que no hayan pensatañas sera Txt_ID solamente

        ComboBox

        DataGrews

        
        */
        private string id_empleado;
        private string nombre;
        private string contrasena;
        private int codigo_estado;
        private int codigo_rol;
        private int oportunidades_numero;

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


        public string Var_Nombre
        {
            get
            {
                return nombre;
            }

            set
            {
               nombre = value;
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

        public int Var_Codigo_estado
        {
            get
            {
                return codigo_estado;
            }

            set
            {
                codigo_estado = value;
            }
        }

        public int Var_Codigo_rol
        {
            get
            {
                return codigo_rol;
            }

            set
            {
                codigo_rol = value;
            }
        }

        public int Var_Oportunidades_numero
        {
            get
            {
                return oportunidades_numero;
            }

            set
            {
                oportunidades_numero = value;
            }
        }

        public bool Fun_Buscar_UserAndPass()
        {
           
            bool resultado = false;
            this.sql = string.Format(@"SELECT[ID],[Contraseña], [Nombre], [Codigo_Rol], [Codigo_Estado]
           FROM Empleados where[ID] = '{0}' AND[Contraseña] = '{1}'", this.Var_Id_empleado, this.Var_Contrasena);
            this.cmd = new SqlCommand(this.sql, this.cnx);
            this.cnx.Open();
            SqlDataReader Reg = null;
            Reg = this.cmd.ExecuteReader();

           if (Reg.Read())
           {
                codigo_estado = Convert.ToInt16((Reg["Codigo_Estado"].ToString()));
                codigo_rol = Convert.ToInt16((Reg["Codigo_Rol"].ToString()));
                nombre = Convert.ToString((Reg["Nombre"].ToString()));

                this.cnx.Close();
                resultado = true;
                
            }
            else
           {
               resultado = false;
            }

            this.cnx.Close();
            return resultado;
        }
        public bool Fun_Buscar_User()
        {
            bool resultado = false;
            this.sql = string.Format(@"SELECT A.[Codigo_Empleado], A.[ID], A.[Codigo_Estado], B.[Oportunidades]
           FROM Empleados as A INNER JOIN Login as B ON A.[Codigo_Empleado] = B.[Codigo_Empleado] WHERE A.ID = '{0}'", Var_Id_empleado);
            this.cmd = new SqlCommand(this.sql, this.cnx);
            this.cnx.Open();
            SqlDataReader Reg = null;
            Reg = this.cmd.ExecuteReader();

            if (Reg.Read())
            {
                oportunidades_numero = Convert.ToInt16((Reg["Oportunidades"].ToString()))-1;
                this.cnx.Close();
                Fun_ReducirIntentos();
                resultado = true;
            }
            else
            {
                resultado = false;
            }
            this.cnx.Close();
            return resultado;
        }

        public void Fun_RestablecerIntentos()
        {
            
                this.sql = string.Format(@"UPDATE A Set A.Oportunidades = 6 from Login as A INNER JOIN Empleados as B  ON A.Codigo_Empleado = B.Codigo_Empleado WHERE B.ID = '{0}' AND B.Codigo_Estado = '{1}'", this.Var_Id_empleado,this.Var_Codigo_estado );
                this.cmd = new SqlCommand(this.sql, this.cnx);
                this.cnx.Open();
                SqlDataReader Reg3 = null;
                Reg3 = this.cmd.ExecuteReader();
                this.cnx.Close();
        }

        public void Fun_BloquearUsuario()
        {
            if (oportunidades_numero == 0)
            {
                this.sql = string.Format(@"UPDATE A Set A.Codigo_Estado = 3 from Empleados as A INNER JOIN Login as B  ON A.Codigo_Empleado = B.Codigo_Empleado WHERE A.ID = '{0}'", this.Var_Id_empleado);
                this.cmd = new SqlCommand(this.sql, this.cnx);
                this.cnx.Open();
                SqlDataReader Reg2 = null;
                Reg2 = this.cmd.ExecuteReader();
                if (Reg2.Read())
                {
                    codigo_estado = Convert.ToInt16((Reg2["Codigo_Estado"].ToString()));
                }
                this.cnx.Close();
            } 
        }

        public void Fun_ReducirIntentos()
        {
            
            if (oportunidades_numero >=0)
            {
                this.sql = string.Format(@"UPDATE A Set A.Oportunidades='{0}' from Login as A INNER JOIN Empleados as B  ON A.Codigo_Empleado = B.Codigo_Empleado WHERE B.ID = '{1}'", this.Var_Oportunidades_numero, this.Var_Id_empleado);
                this.cmd = new SqlCommand(this.sql, this.cnx);
                this.cnx.Open();
                SqlDataReader Reg1 = null;
                Reg1 = this.cmd.ExecuteReader();
                this.cnx.Close();
            }
      
            Fun_BloquearUsuario();
        }


        public void Fun_ValidarContraseña()
        {
        }
        public void Fun_NuevaContraseña()
        {
        }
    }
    }
