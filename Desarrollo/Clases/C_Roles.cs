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
    class C_Roles:Conexion
    {
        
        private int var_codigo_Rol;
        private String var_descripcion;

        public int Codigo_Rol
        {
            get
            {
                return var_codigo_Rol;
            }

            set
            {
                var_codigo_Rol = value;
            }
        }

        public string Descripcion
        {
            get
            {
                return var_descripcion;
            }

            set
            {
                var_descripcion = value;
            }
        }


        public void Fun_CargarRoles(DataGridView dvg)
        {
            
            cnx.Open();
            try
            {
                DataAdapter = new SqlDataAdapter(@"select Codigo_Rol as 'Codigo del Rol', Descripcion as 'Descripcion del Rol' from Rol", ccnx);
                dt = new DataTable();
                DataAdapter.Fill(dt);
                dvg.DataSource = dt;

            }
            catch
            {

            }
            cnx.Close();
        }

        public int Fun_ComprobarDescripcion()
        {
            int bandera = 0; 
            sql = string.Format(@"select Descripcion from Rol where Descripcion='{0}'", Descripcion);
            cmd = new SqlCommand(sql, cnx);
            cnx.Open();

            SqlDataReader Reg = null;
            Reg = cmd.ExecuteReader();

            if (Reg.Read())
            {
                bandera = 1;
                MessageBox.Show("Existe una duplicacion de Datos\n Por Favor revise los datos a Ingresar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                bandera = 0;
                cnx.Close();
                Fun_IngresarDescripcion();
                
                
            }

            cnx.Close();
            return (bandera);
        }

        public void Fun_IngresarDescripcion()
        {
            sql = string.Format(@"insert into Rol values('{0}')", Descripcion);
            cmd = new SqlCommand(sql, cnx);
            cnx.Open();
 
            SqlDataReader Regi = null;
            try
            {
                Regi = cmd.ExecuteReader();
                MessageBox.Show("Registro guardado exitosamente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                cnx.Close();
            }
            catch (Exception)
            { }
            cnx.Close();
        }
       
        public int Fun_ComprobarDescripcionModificar()
        {
            int bandera = 0;

            sql = string.Format(@"select  Descripcion from Rol where Descripcion='{0}' and Codigo_Rol != '{1}'", Descripcion, Codigo_Rol);
            cmd = new SqlCommand(sql, cnx);
            cnx.Open();

            SqlDataReader Reg = null;
            Reg = cmd.ExecuteReader();

            if (Reg.Read())
            {
                bandera = 1;
                MessageBox.Show("Existe una duplicacion de Datos\n Por Favor revise los datos a Ingresar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                bandera = 0;
                cnx.Close();
                Fun_UpdateDescripcion();
            }

            cnx.Close();
            return (bandera);
        }

        public void Fun_UpdateDescripcion()
        {
            sql = string.Format(@"update Rol set Descripcion='{0}' where Codigo_Rol='{1}'", Descripcion, Codigo_Rol);
            cmd = new SqlCommand(sql, cnx);
            cnx.Open();

            SqlDataReader Reg = null;
            Reg = cmd.ExecuteReader();

            if (Reg.Read())
            {



            }
            else
            {

            }

            cnx.Close();
        }

        public int Fun_Obtener_Ultimo_ID()
        {
            int Codigo = 0;
            sql = string.Format(@"select top 1 Codigo_Rol from Rol order by Codigo_Rol desc");
            cmd = new SqlCommand(sql, cnx);
            cnx.Open();

            SqlDataReader Reg = null;
            Reg = cmd.ExecuteReader();

            if (Reg.Read())
            {
                Codigo = Convert.ToInt16((Reg["Codigo_Rol"].ToString()));

            }
            else
            {

            }

            cnx.Close();
            return (Codigo + 1);
        }
    }
}
