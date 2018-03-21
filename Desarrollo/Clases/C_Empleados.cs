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
    class C_Empleados : Conexion
    {

        private int var_codigo_empleado;
        private string var_id_empleado;
        private string var_nombre_empleado;
        private string var_apellido_empleado;
        private string var_correo_empleado;
        private string var_telefono_fijo;
        private string var_telefono_celular;
        private string var_fecha_nacimiento;
        private string var_genero;
        private string var_contrasena;
        private string var_estado_civil;
        private string var_codigo_rol;
        private string var_empleado_estado;
        private string var_direccion;
        private int var_localidad;

        public string Var_Direccion
        {
            get
            {
                return var_direccion;
            }

            set
            {
                var_direccion = value;
            }
        }

        public int Var_Codigo_empleado
        {
            get
            {
                return var_codigo_empleado;
            }

            set
            {
                var_codigo_empleado = value;
            }
        }

        public string Var_Id_empleado
        {
            get
            {
                return var_id_empleado;
            }

            set
            {
                var_id_empleado = value;
            }
        }

        public string Var_Nombre_empleado
        {
            get
            {
                return var_nombre_empleado;
            }

            set
            {
                var_nombre_empleado = value;
            }
        }

        public string Var_Apellido_empleado
        {
            get
            {
                return var_apellido_empleado;
            }

            set
            {
                var_apellido_empleado = value;
            }
        }

        public string Var_Correo_empleado
        {
            get
            {
                return var_correo_empleado;
            }

            set
            {
                var_correo_empleado = value;
            }
        }

        public string Var_Telefono_fijo
        {
            get
            {
                return var_telefono_fijo;
            }

            set
            {
                var_telefono_fijo = value;
            }
        }

        public string Var_Telefono_celular
        {
            get
            {
                return var_telefono_celular;
            }

            set
            {
                var_telefono_celular = value;
            }
        }

        public string Var_Fecha_nacimiento
        {
            get
            {
                return var_fecha_nacimiento;
            }

            set
            {
                var_fecha_nacimiento = value;
            }
        }

        public string Var_Genero
        {
            get
            {
                return var_genero;
            }

            set
            {
                var_genero = value;
            }
        }

        public string Var_Contrasena
        {
            get
            {
                return var_contrasena;
            }

            set
            {
                var_contrasena = value;
            }
        }

        public string Var_Estado_civil
        { get { return var_estado_civil; }
            set { var_estado_civil = value; }
        }

        public string Var_Rol
        { get { return var_codigo_rol; }
            set { var_codigo_rol = value; }
        }

        public string Var_Codigo_estado
        { get { return var_empleado_estado; }
            set { var_empleado_estado = value; }
        }

        public int Localidad
        {
            get
            {
                return var_localidad;
            }

            set
            {
                var_localidad = value;
            }
        }

     
        public int Fun_OptenerUltimoID()
        {
            int Codigo = 0;
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

        public bool Fun_RevisionDeDatos()
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

        public void Fun_IngresoDatos()
        {
            this.sql = string.Format(@"insert into Empleados values(
            '{0}',  '{1}',  '{2}',  '{3}', '{4}', '{5}', '{6}', '{7}','{8}','{9}', 
            '{10}', '{11}', '{12}','{13}')",
            Var_Id_empleado, Var_Nombre_empleado, Var_Apellido_empleado, Var_Correo_empleado, Var_Telefono_fijo,
            Var_Telefono_celular, Var_Fecha_nacimiento, Var_Genero, Var_Contrasena, Var_Estado_civil,
            Var_Rol, Var_Codigo_estado, Var_Direccion, Localidad);

            this.cmd = new SqlCommand(this.sql, this.cnx);
            this.cnx.Open();
            SqlDataReader Reg = null;
            Reg = this.cmd.ExecuteReader();
            this.cnx.Close();


        }

        public void Fun_IngresoHistoricos(string FV_Estado, string FV_Rol, string FV_Empleado)
        {
            C_DatoHistoricos H = new C_DatoHistoricos();
            string Name = Var_Nombre_empleado + " " + Var_Apellido_empleado;

            H.Fun_IngresoHistoricos(Var_Id_empleado, Name, Var_Correo_empleado, Var_Telefono_fijo
            , FV_Estado, FV_Rol, FV_Empleado, "Agregar");
        }

        public void Fun_UpdateHistoricos(string FV_Estado, string FV_Rol, string FV_Empleado)
        {
            C_DatoHistoricos H = new C_DatoHistoricos();
            string Name = Var_Nombre_empleado + " " + Var_Apellido_empleado;

            H.Fun_UpdateHistoricos(Var_Codigo_empleado, Var_Id_empleado, Name, Var_Correo_empleado, Var_Telefono_fijo
            , FV_Estado, FV_Rol, FV_Empleado, "Actualizar");
        }

        public void Fun_MoodificarDatos(string FV_Telefono, int FV_Estado, string FV_Civil, int FV_CodigoRol, string FV_Direccion, string FV_Correo, string FV_Contraseña, string FV_NFijo ,int FV_Codigo_Emp, int FV_Loc)
        {
            this.sql = string.Format(@"update Empleados
                                       set TelefonoCelular='{0}', Codigo_Estado='{1}', EstadoCivil='{2}', Codigo_Rol='{3}', 
                                         Direccion='{4}', Correo='{5}', Contraseña='{6}', TelefonoFijo='{7}', Cod_Localidad='{8}' where Codigo_Empleado = '{9}'",
                                         FV_Telefono, FV_Estado, FV_Civil, FV_CodigoRol, FV_Direccion, FV_Correo, FV_Contraseña, FV_NFijo, FV_Loc, FV_Codigo_Emp);

            cmd = new SqlCommand(sql, cnx);
            cnx.Open();
            int Reg = cmd.ExecuteNonQuery();
            if (Reg > 0)
            {
                MessageBox.Show("Se ha realizado los cambios", "Mensaje de confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            cnx.Close();

        }
       
        public void Fun_ExtraerRoles( ComboBox Com_Roles)
        {
            cnx.Open();
            sql = string.Format(@"select Codigo_Rol, Descripcion from Rol");
            cmd = new SqlCommand(sql, cnx);
            DataAdapter = new SqlDataAdapter(cmd);
            dt = new DataTable();
            DataAdapter.Fill(dt);
            cnx.Close();

            Com_Roles.ValueMember = "Codigo_Rol";
            Com_Roles.DisplayMember = "Descripcion";
            Com_Roles.DataSource = dt;
        }

        public void Fun_ExtraerLocalidades(ComboBox Com_Local)
        {
            cnx.Open();
            sql = string.Format(@"select Cod_Localidad, Nombre from Localidad");
            cmd = new SqlCommand(sql, cnx);
            DataAdapter = new SqlDataAdapter(cmd);
            dt = new DataTable();
            DataAdapter.Fill(dt);
            cnx.Close();

            Com_Local.ValueMember = "Cod_Localidad";
            Com_Local.DisplayMember = "Nombre";
            Com_Local.DataSource = dt;
        }

        public void Fun_CargarPrimerDataGriew(DataGridView FDGV_Inicial)
        {
            cnx.Open();
            try
            {
                DataAdapter = new SqlDataAdapter("select A.Codigo_Empleado as Codigo,  A.ID as Id, Nombre, A.Apellido, A.Correo, A.TelefonoCelular as Telefono, A.TelefonoFijo as Celular, A.Contraseña, A.Direccion, b.Descripcion, (select Descripcion_Estado from Estados where Codigo_Tipo_Estado = 1 and Codigo_Estado = A.Codigo_Estado) as Estado from Empleados as A inner join Rol as b on A.Codigo_Rol = B.Codigo_Rol", ccnx);
                dt = new DataTable();
                DataAdapter.Fill(dt);
                FDGV_Inicial.DataSource = dt;

            }
            catch
            {

            }
            cnx.Close();
        }

        public void Fun_CargarPorCodigo(DataGridView FDGV_Inicial, int FV_Codigo)
        {
            cnx.Open();
            try
            {
               
                int L_Busqueda;
                L_Busqueda = FV_Codigo;


                sql = string.Format
                (@"select A.Codigo_Empleado as Codigo, A.ID as Id, Nombre, A.Apellido, A.Correo, 
                  A.TelefonoCelular as Telefono, A.TelefonoFijo as Celular, A.Contraseña, A.Direccion, 
                  b.Descripcion, (select Descripcion_Estado from Estados where Codigo_Tipo_Estado = 1 
                  and Codigo_Estado = A.Codigo_Estado) as Estado from Empleados as A inner join Rol as b on 
                  A.Codigo_Rol = B.Codigo_Rol where A.Codigo_Empleado like '%{0}%'", L_Busqueda);
                cmd = new SqlCommand(sql, cnx);
                DataAdapter = new SqlDataAdapter(cmd);
                dt = new DataTable();
                DataAdapter.Fill(dt);
                FDGV_Inicial.DataSource = dt;

            }
            catch
            {

            }
            cnx.Close();
        }

        public void Fun_CargarPorNombre(DataGridView FDGV_Inicial, string FV_Codigo)
        {
            cnx.Open();
            try
            {
                string L_Busq;
                L_Busq = FV_Codigo;


                sql = string.Format
                (@"select A.Codigo_Empleado as Codigo, A.ID as Id, Nombre, A.Apellido, A.Correo, 
                  A.TelefonoCelular as Telefono, A.TelefonoFijo as Celular, A.Contraseña, A.Direccion, 
                  b.Descripcion, (select Descripcion_Estado from Estados where Codigo_Tipo_Estado = 1 
                  and Codigo_Estado = A.Codigo_Estado) as Estado from Empleados as A inner join Rol as b on 
                  A.Codigo_Rol = B.Codigo_Rol where  A.Nombre like '%{0}%'", L_Busq);
                cmd = new SqlCommand(sql, cnx);
                DataAdapter = new SqlDataAdapter(cmd);
                dt = new DataTable();
                DataAdapter.Fill(dt);
                FDGV_Inicial.DataSource = dt;

            }
            catch
            {

            }
            cnx.Close();
        }

        public void Fun_CargarPorID(DataGridView FDGV_Inicial, string FV_Codigo)
        {
            cnx.Open();
            try
            {
                string l_Busq;
                l_Busq = FV_Codigo;


                sql = string.Format
                (@"select A.Codigo_Empleado as Codigo, A.ID as Id, Nombre, A.Apellido, A.Correo, 
                  A.TelefonoCelular as Telefono, A.TelefonoFijo as Celular, A.Contraseña, A.Direccion, 
                  b.Descripcion, (select Descripcion_Estado from Estados where Codigo_Tipo_Estado = 1 
                  and Codigo_Estado = A.Codigo_Estado) as Estado from Empleados as A inner join Rol as b on 
                  A.Codigo_Rol = B.Codigo_Rol  where A.ID like '%{0}%'", l_Busq);
                cmd = new SqlCommand(sql, cnx);
                DataAdapter = new SqlDataAdapter(cmd);
                dt = new DataTable();
                DataAdapter.Fill(dt);
                FDGV_Inicial.DataSource = dt;

            }
            catch
            {

            }
            cnx.Close();
        }

        public void Fun_ExtraerEstados(ComboBox Com_Estados)
        {
            cnx.Open();
            sql = string.Format(@"select Codigo_Estado, Descripcion_Estado from Estados where Codigo_Tipo_Estado = 1");
            cmd = new SqlCommand(sql, cnx);
            DataAdapter = new SqlDataAdapter(cmd);
            dt = new DataTable();
            DataAdapter.Fill(dt);
            cnx.Close();

            Com_Estados.ValueMember = "Codigo_Estado";
            Com_Estados.DisplayMember = "Descripcion_Estado";
            Com_Estados.DataSource = dt;
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
