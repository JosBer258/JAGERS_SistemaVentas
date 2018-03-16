using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

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
        private int localidad;

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

        public int Localidad
        {
            get
            {
                return localidad;
            }

            set
            {
                localidad = value;
            }
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
            '{10}', '{11}', '{12}','{13}')",
            Var_Id_empleado, Var_Nombre_empleado, Var_Apellido_empleado,Var_Correo_empleado, Var_Telefono_fijo,
            Var_Telefono_celular,Var_Fecha_nacimiento, Var_Genero, Var_Contrasena, Var_Estado_civil,
            Var_Rol, Var_Codigo_estado, Var_Direccion, Localidad);

            this.cmd = new SqlCommand(this.sql, this.cnx);
            this.cnx.Open();
            SqlDataReader Reg = null;
            Reg = this.cmd.ExecuteReader();    
            this.cnx.Close();
        }




        public void Fun_MoodificarDatos(string Telefono, int Estado, string Civil, int CodigoRol, string Direccion, string correo, string contra, string fijo ,int Codigo_e, int lo)
        {
            this.sql = string.Format(@"update Empleados
                                       set TelefonoCelular='{0}', Codigo_Estado='{1}', EstadoCivil='{2}', Codigo_Rol='{3}', 
                                         Direccion='{4}', Correo='{5}', Contraseña='{6}', TelefonoFijo='{7}', Cod_Localidad='{8}' where Codigo_Empleado = '{9}'",
                                         Telefono, Estado, Civil, CodigoRol, Direccion, correo, contra, fijo, lo, Codigo_e);

            this.cmd = new SqlCommand(this.sql, this.cnx);

            this.cnx.Open();
            SqlDataReader Reg = null;
            Reg = this.cmd.ExecuteReader();
            this.cnx.Close();

        }
        ///////////////////////////////////////////////////////////////////////////////////////////////


        public void Fun_ExtraerRoles( ComboBox RolBox)
        {
            Conexion Con = new Conexion();

            Con.cnx.Open();
            Con.sql = string.Format(@"select Codigo_Rol, Descripcion from Rol");
            Con.cmd = new SqlCommand(Con.sql, Con.cnx);
            Con.DataAdapter = new SqlDataAdapter(Con.cmd);
            Con.dt = new DataTable();
            Con.DataAdapter.Fill(Con.dt);
            Con.cnx.Close();

            RolBox.ValueMember = "Codigo_Rol";
            RolBox.DisplayMember = "Descripcion";
            RolBox.DataSource = Con.dt;
        }


        public void Fun_ExtraerLocalidades(ComboBox RolBox)
        {
            Conexion Con = new Conexion();

            Con.cnx.Open();
            Con.sql = string.Format(@"select Cod_Localidad, Nombre from Localidad");
            Con.cmd = new SqlCommand(Con.sql, Con.cnx);
            Con.DataAdapter = new SqlDataAdapter(Con.cmd);
            Con.dt = new DataTable();
            Con.DataAdapter.Fill(Con.dt);
            Con.cnx.Close();

            RolBox.ValueMember = "Cod_Localidad";
            RolBox.DisplayMember = "Nombre";
            RolBox.DataSource = Con.dt;
        }



        public void Fun_CargarPrimerDataGriew(DataGridView dgv)
        {
            Conexion con = new Conexion();
            con.cnx.Open();
            try
            {
                con.DataAdapter = new SqlDataAdapter("select A.Codigo_Empleado as Codigo,  A.ID as Id, Nombre, A.Apellido, A.Correo, A.TelefonoCelular as Telefono, A.TelefonoFijo as Celular, A.Contraseña, A.Direccion, b.Descripcion, (select Descripcion_Estado from Estados where Codigo_Tipo_Estado = 1 and Codigo_Estado = A.Codigo_Estado) as Estado from Empleados as A inner join Rol as b on A.Codigo_Rol = B.Codigo_Rol", con.ccnx);
                con.dt = new DataTable();
                con.DataAdapter.Fill(con.dt);
                dgv.DataSource = con.dt;

            }
            catch
            {

            }
            con.cnx.Close();
        }



        public void Fun_CargarPorCodigo(DataGridView dgv, int a)
        {
            Conexion con = new Conexion();
            con.cnx.Open();
            try
            {
                double conv = Convert.ToDouble(Convert.ToInt32(a));

                int busq;
                busq = a;


                con.sql = string.Format
                (@"select A.Codigo_Empleado as Codigo, A.ID as Id, Nombre, A.Apellido, A.Correo, 
                  A.TelefonoCelular as Telefono, A.TelefonoFijo as Celular, A.Contraseña, A.Direccion, 
                  b.Descripcion, (select Descripcion_Estado from Estados where Codigo_Tipo_Estado = 1 
                  and Codigo_Estado = A.Codigo_Estado) as Estado from Empleados as A inner join Rol as b on 
                  A.Codigo_Rol = B.Codigo_Rol where A.Codigo_Empleado like '%{0}%'", busq);
                con.cmd = new SqlCommand(con.sql, con.cnx);
                con.DataAdapter = new SqlDataAdapter(con.cmd);
                con.dt = new DataTable();
                con.DataAdapter.Fill(con.dt);
                dgv.DataSource = con.dt;

            }
            catch
            {

            }
            con.cnx.Close();
        }

        public void Fun_CargarPorNombre(DataGridView dgv, string a)
        {
            Conexion con = new Conexion();
            con.cnx.Open();
            try
            {
                string busq;
                busq = a;


                con.sql = string.Format
                (@"select A.Codigo_Empleado as Codigo, A.ID as Id, Nombre, A.Apellido, A.Correo, 
                  A.TelefonoCelular as Telefono, A.TelefonoFijo as Celular, A.Contraseña, A.Direccion, 
                  b.Descripcion, (select Descripcion_Estado from Estados where Codigo_Tipo_Estado = 1 
                  and Codigo_Estado = A.Codigo_Estado) as Estado from Empleados as A inner join Rol as b on 
                  A.Codigo_Rol = B.Codigo_Rol where  A.Nombre like '%{0}%'", busq);
                con.cmd = new SqlCommand(con.sql, con.cnx);
                con.DataAdapter = new SqlDataAdapter(con.cmd);
                con.dt = new DataTable();
                con.DataAdapter.Fill(con.dt);
                dgv.DataSource = con.dt;

            }
            catch
            {

            }
            con.cnx.Close();
        }

        public void Fun_CargarPorID(DataGridView dgv, string a)
        {
            Conexion con = new Conexion();
            con.cnx.Open();
            try
            {
                string busq;
                busq = a;


                con.sql = string.Format
                (@"select A.Codigo_Empleado as Codigo, A.ID as Id, Nombre, A.Apellido, A.Correo, 
                  A.TelefonoCelular as Telefono, A.TelefonoFijo as Celular, A.Contraseña, A.Direccion, 
                  b.Descripcion, (select Descripcion_Estado from Estados where Codigo_Tipo_Estado = 1 
                  and Codigo_Estado = A.Codigo_Estado) as Estado from Empleados as A inner join Rol as b on 
                  A.Codigo_Rol = B.Codigo_Rol  where A.ID like '%{0}%'", busq);
                con.cmd = new SqlCommand(con.sql, con.cnx);
                con.DataAdapter = new SqlDataAdapter(con.cmd);
                con.dt = new DataTable();
                con.DataAdapter.Fill(con.dt);
                dgv.DataSource = con.dt;

            }
            catch
            {

            }
            con.cnx.Close();
        }




        public void Fun_ExtraerEstados(ComboBox Com)
        {
            Conexion Con = new Conexion();

            Con.cnx.Open();
            Con.sql = string.Format(@"select Codigo_Estado, Descripcion_Estado from Estados where Codigo_Tipo_Estado = 1");
            Con.cmd = new SqlCommand(Con.sql, Con.cnx);
            Con.DataAdapter = new SqlDataAdapter(Con.cmd);
            Con.dt = new DataTable();
            Con.DataAdapter.Fill(Con.dt);
            Con.cnx.Close();

            Com.ValueMember = "Codigo_Estado";
            Com.DisplayMember = "Descripcion_Estado";
            Com.DataSource = Con.dt;

            //Pest1_ComBox_Estado
        }


        public void IngresoLogin()
        {

            this.sql = string.Format(@"insert into Login values (6,(select top 1 Codigo_Empleado from Empleados order by Codigo_Empleado desc))");
            this.cmd = new SqlCommand(this.sql, this.cnx);
            this.cnx.Open();
            SqlDataReader Reg = null;
            Reg = this.cmd.ExecuteReader();
            this.cnx.Close();
        }


    }
}
