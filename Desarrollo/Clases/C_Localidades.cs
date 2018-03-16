using Desarrollo.Pantallas.Estados;
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
    class C_Localidades:Conexion
    {
        private int codigoLocalidad;
        private string nombreLocalidad;
        private string direccionLocalidad;
        private int estadoLocalidad;

        public int CodigoLocalidad
        {
            get
            {
                return codigoLocalidad;
            }

            set
            {
                codigoLocalidad = value;
            }
        }

        public string NombreLocalidad
        {
            get
            {
                return nombreLocalidad;
            }

            set
            {
                nombreLocalidad = value;
            }
        }

        public string DireccionLocalidad
        {
            get
            {
                return direccionLocalidad;
            }

            set
            {
                direccionLocalidad = value;
            }
        }

        public int EstadoLocalidad
        {
            get
            {
                return estadoLocalidad;
            }

            set
            {
                estadoLocalidad = value;
            }
        }


        //Funciones
        public void Fun_LlenarDataGriew(DataGridView DataGriew_Localidades)
        {
            cnx.Open();

            sql = string.Format
            (@"select Cod_Localidad as 'Codigo', Nombre as 'Nombre', [Direccion] as 'Direccion',[Cod_Estado] as 'Codigo del Estado',
                (select E.Descripcion_Estado from Estados as E where E.Codigo_Estado=Cod_Estado and E.Codigo_Tipo_Estado=14) as Estado  from Localidad");
            cmd = new SqlCommand(sql, cnx);
            DataAdapter = new SqlDataAdapter(cmd);
            dt = new DataTable();
            DataAdapter.Fill(dt);
            DataGriew_Localidades.DataSource = dt;
            cnx.Close();
        }

        public void Fun_ExtraerEstados(ComboBox ComboBoz_Estados)
        {
            

            cnx.Open();
            sql = string.Format(@"select Codigo_Estado, Descripcion_Estado from Estados where Codigo_Tipo_Estado=14");
            cmd = new SqlCommand(sql, cnx);
            DataAdapter = new SqlDataAdapter(cmd);
            dt = new DataTable();
            DataAdapter.Fill(dt);
            

            ComboBoz_Estados.ValueMember = "Codigo_Estado";
            ComboBoz_Estados.DisplayMember = "Descripcion_Estado";
            ComboBoz_Estados.DataSource = dt;

            cnx.Close();
        }

        public int Fun_GenerarNuevoCodigo()
        {
            int cod = 0;

            sql = string.Format(@"select Top 1 Cod_Localidad as Loc from Localidad order by Cod_Localidad desc");
            cmd = new SqlCommand(sql, cnx);
            cnx.Open();

            SqlDataReader Reg = null;
            Reg = cmd.ExecuteReader();

            if (Reg.Read())
            {
                cod = Convert.ToInt16(Convert.ToInt16(Reg["Loc"].ToString()) + 1);

            }
            else
            {

            }

            cnx.Close();
            return (cod);
        }

        public void ValidarRepeticion()
        {
            sql = string.Format(@"select * from Localidad where Nombre='{0}'", NombreLocalidad);
            cmd = new SqlCommand(sql, cnx);
            cnx.Open();
            SqlDataReader Reg = null;
            Reg = cmd.ExecuteReader();

            if (Reg.Read())
            {
                cnx.Close();
                MessageBox.Show("Existe una Duplicacion de Datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                cnx.Close();
                IngresoDeNuevaLocalidad();
                MessageBox.Show("Localidad registrada exitosamente","Mensaje de Confirmación",MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            cnx.Close();

        }

        public void IngresoDeNuevaLocalidad()
        {
            sql = string.Format(@"insert into Localidad values ('{0}','{1}','{2}')", NombreLocalidad, DireccionLocalidad, EstadoLocalidad);
            cmd = new SqlCommand(sql, cnx);
            cnx.Open();
            SqlDataReader Reg = null;
            Reg = cmd.ExecuteReader();
            cnx.Close();
            
        }


        public void ValidarActualizarLocalidad()
        {
            sql = string.Format(@"select * from Localidad where Nombre='{0}' and Direccion='{1}' and Cod_Localidad !='{2}' ", NombreLocalidad, DireccionLocalidad, CodigoLocalidad);
            cmd = new SqlCommand(sql, cnx);
            cnx.Open();
            SqlDataReader Reg = null;
            Reg = cmd.ExecuteReader();

            if (Reg.Read())
            {
                cnx.Close();
                MessageBox.Show("Existe una Duplicacion de Datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                cnx.Close();
                UpdateLocalidad();
                MessageBox.Show("Localidad actualizada exitosamente", "Mensaje de Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }

            cnx.Close();
        }

        private void UpdateLocalidad()
        {
            sql = string.Format(@"update Localidad set Direccion='{0}', [Cod_Estado]='{1}' where [Cod_Localidad]='{2}'",
                DireccionLocalidad, EstadoLocalidad, CodigoLocalidad);

            cmd = new SqlCommand(sql, cnx);
            cnx.Open();
            SqlDataReader Reg = null;
            Reg = cmd.ExecuteReader();
            cnx.Close();
            
        }
    }
}
