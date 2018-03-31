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
    class C_Impuesto : Conexion
    {
        string fecha_ingreso;
        string Fecha_Inicial;
        int codigo_impuesto;
        float porcentaje_Impuesto;
        int codigo_estado;
        string fecha_modificacion;

        public string Var_Fecha_inicial
        {
            get
            {
                return Fecha_Inicial;
            }

            set
            {
                Fecha_Inicial = value;
            }
        }

        public int Var_Codigo_impuesto
        {
            get
            {
                return codigo_impuesto;
            }

            set
            {
                codigo_impuesto = value;
            }
        }

        public float Var_Porcentaje_Impuesto
        {
            get
            {
                return porcentaje_Impuesto;
            }

            set
            {
                porcentaje_Impuesto = value;
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

        public string Var_Fecha_modificacion
        {
            get
            {
                return fecha_modificacion;
            }

            set
            {
                fecha_modificacion = value;
            }
        }

        public string Var_Fecha_ingreso
        {
            get
            {
                return fecha_ingreso;
            }

            set
            {
                fecha_ingreso = value;
            }
        }

        public string ObtenerFechaDisponible()
        {
            string Fecha = "";
            this.sql = string.Format(@"select dateadd (day, 1, (select top 1 Fecha_Iniciacion from Impuesto where Codigo_Estado != 2 ORDER BY Fecha_Iniciacion DESC)) as FechaDisponible");
            this.cmd = new SqlCommand(this.sql, this.cnx);
            this.cnx.Open();

            SqlDataReader Reg = null;
            Reg = this.cmd.ExecuteReader();

            if (Reg.Read())
            {

                Fecha = Convert.ToString(Reg["FechaDisponible"]);
            }
            else
            {
               
            }

            this.cnx.Close();
            return (Fecha);
        }

        public void VerificarFechaInicio()
        {
            this.sql = string.Format(@"select * from Impuesto where Fecha_Iniciacion >= '{0}' and Codigo_Estado !=2 ", Var_Fecha_inicial);
            this.cmd = new SqlCommand(this.sql, this.cnx);
            this.cnx.Open();

            SqlDataReader Reg = null;
            Reg = this.cmd.ExecuteReader();

            if (Reg.Read())
            {
                MessageBox.Show("No puede existir dos impuestos con la misma fecha de Inicio", "Error de Ingreso", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                this.cnx.Close();
                Fun_Agregar_Impuesto();
                MessageBox.Show("Registro ingresado correctamente.", "Exitosamente", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            this.cnx.Close();
        }

        public void Fun_Agregar_Impuesto()
        {
            string Impuesto =
            sql = string.Format(@"insert into Impuesto([Fecha_Iniciacion],[PorcentajeImpuesto],[Codigo_Estado],[Fecha_Agregado]) values ('{0}','{1}','{2}','{3}')",
            Var_Fecha_inicial, (float)Var_Porcentaje_Impuesto, Var_Codigo_estado, Var_Fecha_ingreso);

            cmd = new SqlCommand(sql, cnx);
            cnx.Open();
            SqlDataReader Reg = null;
            Reg = this.cmd.ExecuteReader();
            cnx.Close();

        }

        public void Fun_Modificar_Impuesto()
        {
            this.sql = string.Format(@"update Impuesto set Codigo_Estado = '{0}', Fecha_Modificacion = '{1}', 
                                        Fecha_Iniciacion='{2}', PorcentajeImpuesto = '{3}' where Codigo_Impuesto = '{4}'", 
                                         Var_Codigo_estado, Var_Fecha_modificacion, Var_Fecha_inicial, Var_Porcentaje_Impuesto ,Var_Codigo_impuesto);
            this.cmd = new SqlCommand(this.sql, this.cnx);
            this.cnx.Open();
            SqlDataReader Reg = null;
            Reg = this.cmd.ExecuteReader();
            this.cnx.Close();
        }

        public void VerificarImpuestosNuevos(string Fecha)
        {
            this.sql = string.Format(@"select * from Impuesto where Fecha_Iniciacion ='{0}' and Codigo_Estado=3", Fecha);
            this.cmd = new SqlCommand(this.sql, this.cnx);
            this.cnx.Open();

            SqlDataReader Reg = null;
            Reg = this.cmd.ExecuteReader();

            if (Reg.Read())
            {
                this.cnx.Close();
                UpdateImpuestos(Fecha);

            }
            this.cnx.Close();
        }

        public void UpdateImpuestos(string Fecha)
        {
            this.sql = string.Format(@"update Impuesto set Codigo_Estado=2 where Codigo_Estado=1 and Fecha_Iniciacion <'{0}';update Impuesto set Codigo_Estado=1 where Codigo_Estado=3 and Fecha_Iniciacion ='{0}';", Fecha);
            this.cmd = new SqlCommand(this.sql, this.cnx);
            this.cnx.Open();
            SqlDataReader Reg = null;
            Reg = this.cmd.ExecuteReader();
            this.cnx.Close();
        }

        public void Fun_CargarPrimerDataGriew(DataGridView dvg)
        {
            cnx.Open();
            try
            {
                DataAdapter = new SqlDataAdapter(@"select Fecha_Agregado as 'Fecha de Ingreso', Fecha_Iniciacion as 'Fecha de Iniciacion',
                Codigo_Impuesto as 'Codigo', PorcentajeImpuesto as 'Porcentaje de Impuesto',Fecha_Modificacion as 'Fecha de Modificacion', A.Codigo_Estado as 'Codigo de Estado',
                (select E.Descripcion_Estado from Estados as E where E.Codigo_Estado = A.Codigo_Estado and Codigo_Tipo_Estado = 10) as 'Descripcion de Estado'  from Impuesto as A", ccnx);
                dt = new DataTable();
                DataAdapter.Fill(dt);
                dvg.DataSource = dt;

            }
            catch
            {

            }
            cnx.Close();
        }

        public void Fun_CargarDataGriewEstado3(DataGridView dvg)
        {
            cnx.Open();
            try
            {
                DataAdapter = new SqlDataAdapter(@"select Fecha_Agregado as 'Fecha de Ingreso', Fecha_Iniciacion as 'Fecha de Iniciacion',
                Codigo_Impuesto as 'Codigo', PorcentajeImpuesto as 'Porcentaje de Impuesto',Fecha_Modificacion as 'Fecha de Modificacion', A.Codigo_Estado as 'Codigo de Estado',
                (select E.Descripcion_Estado from Estados as E where E.Codigo_Estado = A.Codigo_Estado and Codigo_Tipo_Estado = 10) as 'Descripcion de Estado'  from Impuesto as A where A.Codigo_Estado=3", ccnx);
                dt = new DataTable();
                DataAdapter.Fill(dt);
                dvg.DataSource = dt;

            }
            catch
            {

            }
            cnx.Close();
            
         }


        /// MODIFICACION DE DATOS

        public void VerificarFechaInicioModificaciones()
        {
            this.sql = string.Format(@"select * from Impuesto where Fecha_Iniciacion = '{0}'  
                                     and Codigo_Impuesto !='{1}' and Codigo_Estado =3", Var_Fecha_inicial, Var_Codigo_impuesto);
            this.cmd = new SqlCommand(this.sql, this.cnx);
            this.cnx.Open();

            SqlDataReader Reg = null;
            Reg = this.cmd.ExecuteReader();

            if (Reg.Read())
            {
                MessageBox.Show("No puede existir dos impuestos con la misma fecha de Inicio", "Error de Ingreso", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                this.cnx.Close();
                Fun_Modificar_Impuesto();
                MessageBox.Show("Actualizacion realizada correctamente.", "Confirmacion de Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            this.cnx.Close();
        }

        public string Fun_ExtraerCodigoImpuesto()
        {
            string cod = "";
            cnx.Open();
            sql = string.Format(@"select TOP 1 Codigo_Impuesto from Impuesto ORDER BY Codigo_Impuesto DESC");
            cmd = new SqlCommand(sql, cnx);
            SqlDataReader Reg2 = null;
            Reg2 = cmd.ExecuteReader();
            if (Reg2.Read())
            {
                 cod = Convert.ToString(Convert.ToInt16((Reg2["Codigo_Impuesto"].ToString())) + 1);
                cnx.Close();
            }
            return (cod);
        }
        public void Fun_ExtraerEstados(ComboBox comboBoxEstado)
        {
            cnx.Open();
            sql = string.Format(@"select Codigo_Estado, Descripcion_Estado from Estados WHERE Codigo_Tipo_Estado = 10 and Codigo_Estado > 1" );
            cmd = new SqlCommand(sql, cnx);
            DataAdapter = new SqlDataAdapter(cmd);
            dt = new DataTable();
            DataAdapter.Fill(dt);
            cnx.Close();

            comboBoxEstado.ValueMember = "Codigo_Estado";
            comboBoxEstado.DisplayMember = "Descripcion_Estado";
            comboBoxEstado.DataSource = dt;
        }

    }
}
