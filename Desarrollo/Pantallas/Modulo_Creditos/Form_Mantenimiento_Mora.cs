using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Desarrollo.Clases;

namespace Desarrollo.Pantallas.Modulo_Creditos
{
    public partial class Form_Mantenimiento_Mora : System.Windows.Forms.Form
    {
        C_Mora m = new C_Mora();
        Conexion con = new Conexion();
        public Form_Mantenimiento_Mora()
        {
            InitializeComponent();
        }

        public void Fun_ExtraerEstados(ComboBox Com)
        {
            Conexion Con = new Conexion();

            Con.cnx.Open();
            Con.sql = string.Format(@"select Codigo_Estado, Descripcion_Estado from Estados where Codigo_Tipo_Estado = 25");
            Con.cmd = new SqlCommand(Con.sql, Con.cnx);
            Con.DataAdapter = new SqlDataAdapter(Con.cmd);
            Con.dt = new DataTable();
            Con.DataAdapter.Fill(Con.dt);
            Con.cnx.Close();

            Com.ValueMember = "Codigo_Estado";
            Com.DisplayMember = "Descripcion_Estado";
            Com.DataSource = Con.dt;

        } 

        private void Form_Mantenimiento_Mora_Load(object sender, EventArgs e)
        {
            Txt_CodigoNuevaMora.Text = Convert.ToString(m.NuevocodigoMora());
            Fun_ExtraerEstados(ComboBox_Estados);
            Fun_P_CargarMora();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Bttn_Salir_Click(object sender, EventArgs e)
        {
            if (VerificarEstados() == 0)
            {
                MessageBox.Show("Debe existir almenos un porcentaje de mora Activo", "Error de Registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            this.Close();
        }

        private void Bttn_Agregar_Click(object sender, EventArgs e)
        {
            actualizar();
            if (Txt_NuevaMora.Text == string.Empty || Convert.ToDouble(Txt_NuevaMora.Text)<=0)
            {
                MessageBox.Show("Error: No se permiten campos vacios", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            C_Mora mo = new C_Mora();
            ComboBox_Estados.SelectedValue = 1;

            double PorcentajeMora = Convert.ToDouble(Txt_NuevaMora.Text) / 100;
            DeshabilitarOtrosMora();

            mo.Fun_Agregar_Mora(PorcentajeMora, 1);
            Fun_P_CargarMora();


        }

        private void DataGriw_Moras_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow fila = DataGriw_Moras.Rows[e.RowIndex];
            Txt_CodigoMora.Text = Convert.ToString(fila.Cells[0].Value);
            Txt_PorcentajeMora.Text = Convert.ToString(fila.Cells[1].Value);
            ComboBox_Estados.SelectedValue = Convert.ToString(fila.Cells[2].Value);
        }

        private void Txt_NuevaMora_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones val = new Validaciones();
            val.NumerosDecimales(sender, e, Txt_NuevaMora);
            //acordate de cambiarlo a validar impuesto
        }
        public void actualizar()
        {
            Conexion conn = new Conexion();
            conn.cnx.Open();
            SqlCommand cmdd = new SqlCommand("select * from Mora", conn.cnx);
            SqlDataAdapter daa = new SqlDataAdapter(cmdd);
            DataTable dtt = new DataTable();
            daa.Fill(dtt);
            DataGriw_Moras.DataSource = dtt;
            conn.cnx.Close();
        }

        private void Bttn_Aceptar_Click(object sender, EventArgs e)
        {
            if (Txt_CodigoMora.Text == string.Empty)
            {
                MessageBox.Show("Error: No se permiten campos vacios", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
                if (Txt_PorcentajeMora.Text == string.Empty)
            {
                MessageBox.Show("Error: No se permiten campos vacios", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
                if (ComboBox_Estados.Text == string.Empty)
            {
                MessageBox.Show("Error: No se permiten campos vacios", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

                C_Mora mor = new C_Mora();

            if (Convert.ToInt32(ComboBox_Estados.SelectedValue) == 1 && SumaMora(Convert.ToInt32(Txt_CodigoMora.Text)) >= 1)
            {
                MessageBox.Show("Ya existe una Mora Activa", "Error de Registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            mor.Modificar_Mora(Convert.ToInt32(ComboBox_Estados.SelectedValue), Convert.ToInt32(Txt_CodigoMora.Text));
           
            MessageBox.Show("Se ha modificado con exito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Fun_P_CargarMora();
        }

        private void Txt_CodigoMora_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones val = new Validaciones();
            val.ValidarID(sender, e );
        }

        private void Txt_PorcentajeMora_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones val = new Validaciones();
            val.NumerosDecimales(sender, e, Txt_PorcentajeMora);
        }

        private void Bttn_Limpiar_Click(object sender, EventArgs e)
        {
            Txt_CodigoMora.Clear();
            Txt_NuevaMora.Clear();
            Txt_PorcentajeMora.Clear();
            ComboBox_Estados.SelectedValue = 1;
        }

        private void ComboBox_Estados_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Txt_NuevaMora_TextChanged(object sender, EventArgs e)
        {

        }


        public void Fun_P_CargarMora()
        {
            Conexion con = new Conexion();
            con.cnx.Open();
            try
            {

                con.sql = string.Format
                (@"select Codigo_Mora as 'Codigo', 
				('%' + CAST(( Porcentaje_Mora* 100) as nvarchar)) as 'Porcentaje de Mora',
                CodEstado_Mora as 'Codigo de Estado', 
                (select B.Descripcion_Estado from Estados as B where B.Codigo_Estado=H.CodEstado_Mora
                and B.Codigo_Tipo_Estado=25) as 'Estado'from Mora as H");
                con.cmd = new SqlCommand(con.sql, con.cnx);
                con.DataAdapter = new SqlDataAdapter(con.cmd);
                con.dt = new DataTable();
                con.DataAdapter.Fill(con.dt);
                DataGriw_Moras.DataSource = con.dt;

            }
            catch
            {

            }
            con.cnx.Close();
        }


        private void DeshabilitarOtrosMora()
        {
            con.sql = string.Format(@"update Mora set CodEstado_Mora=2 where CodEstado_Mora=1");

            con.cmd = new SqlCommand(con.sql, con.cnx);
            con.cnx.Open();
            SqlDataReader Reg = null;
            Reg = con.cmd.ExecuteReader();
            con.cnx.Close();
        }


        private int SumaMora(int Cod)
        {
            int Codigo = 0;
            con.sql = string.Format(@"select count(CodEstado_Mora) as 'Sumatoria' from Mora where CodEstado_Mora=1 and Codigo_Mora!='{0}' ", Cod);
            con.cmd = new SqlCommand(con.sql, con.cnx);
            con.cnx.Open();

            SqlDataReader Reg = null;
            Reg = con.cmd.ExecuteReader();

            if (Reg.Read())
            {
                Codigo = Convert.ToInt16((Reg["Sumatoria"].ToString()));

            }
            else
            {

            }

            con.cnx.Close();
            return (Codigo);
        }


        private int VerificarEstados()
        {
            int Codigo = 0;
            con.sql = string.Format(@"select count(CodEstado_Mora) as 'Sumatoria' from Mora where CodEstado_Mora=1");
            con.cmd = new SqlCommand(con.sql, con.cnx);
            con.cnx.Open();

            SqlDataReader Reg = null;
            Reg = con.cmd.ExecuteReader();

            if (Reg.Read())
            {
                Codigo = Convert.ToInt16((Reg["Sumatoria"].ToString()));

            }
            else
            {

            }

            con.cnx.Close();
            return (Codigo);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }

}
