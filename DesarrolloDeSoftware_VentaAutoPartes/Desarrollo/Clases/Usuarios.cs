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
        private string contrasena;
        private string codigo_estado;
        private string codigo_rol;
        private string oportunidades_numero;

        public string Var_Oportunidades_Numero
        {
            get { return oportunidades_numero; }
            set { oportunidades_numero = value; }
        }

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


        public bool Fun_PruebaComprobarEstado( string ID, string  Password)
        {
           
            bool resultado = false;
            this.sql = string.Format(@"select ID, Nombre, Codigo_Estado, Contraseña, Codigo_Rol from Empleados where [ID]='{0}' AND [Contraseña]='{1}'", ID, Password);
            this.cmd = new SqlCommand(this.sql, this.cnx);
            this.cnx.Open();
            SqlDataReader Reg = null;
            Reg = this.cmd.ExecuteReader();

            if (Reg.Read())
            {
                
                Var_Codigo_estado = Reg["Codigo_Estado"].ToString();
                Var_Codigo_Rol = Reg["Codigo_Rol"].ToString();
                

                if(Convert.ToInt16(Var_Codigo_estado) == 1)
                {
                    this.cnx.Close();
                    
                    resultado = true;
                }else
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




        ///////////////////////////////////////////////////////////////////////
        
    }
    }
