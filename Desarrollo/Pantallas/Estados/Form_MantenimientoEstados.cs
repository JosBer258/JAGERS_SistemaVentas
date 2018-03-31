using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Desarrollo.Clases;
using System.Data.SqlClient;


namespace Desarrollo.Pantallas.Estados
{
    public partial class Form_MantenimientoEstados : System.Windows.Forms.Form
    {

        Validaciones validar = new Validaciones();
        Conexion Con = new Conexion();


        public Form_MantenimientoEstados()
        {
            InitializeComponent();
        }

        private void Form_MantenimientoEstados_Load(object sender, EventArgs e)
        {
            //this.estadosTableAdapter.Fill(this.ventasAutoPartesDataSet.Estados);
            ExtraerEstado(DATA_Griew_Estados);
        }

        private void Bttn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Bttn_Aceptar_Click(object sender, EventArgs e)
        {
            if (Txt_CodigoTipo.Text == string.Empty ||
                Txt_CodigoEstado.Text == string.Empty ||
                Txt_CodigoDescripcion.Text == string.Empty)
            {
                MessageBox.Show("No puede dejar campos vacíos", "ERROR");
            }
            else if (Radio_Agregar.Checked == true)
            {
                //string nuevasLlaves = Txt_CodigoTipo.Text + Txt_CodigoEstado.Text;
                //compararLlaves(DATA_Griew_Estados, nuevasLlaves);
                //validarDescripcion(DATA_Griew_Estados, Txt_CodigoDescripcion.Text);
                agregarEstado();

            }
            else if (Radio_Manejo.Checked == true)
            {
                actualizarEstados();
            }


            limpiar();
            ExtraerEstado(DATA_Griew_Estados);
        }

        private void DATA_Griew_Estados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DATA_Griew_Estados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Radio_Manejo.Checked == true)
                selectFila(e);
        }

        private void Radio_Manejo_CheckedChanged(object sender, EventArgs e)
        {
            if (Radio_Manejo.Checked == true)
            {
                Txt_CodigoTipo.Enabled = false;
                Txt_CodigoEstado.Enabled = false;
                Txt_Busqueda.Enabled = true;
            }
            else
            {
                Txt_CodigoTipo.Enabled = true;
                Txt_CodigoEstado.Enabled = true;
                Txt_Busqueda.Enabled = false;
            }
        }

        private void Radio_Agregar_CheckedChanged(object sender, EventArgs e)
        {
            limpiar();
        }

        private void Txt_Busqueda_TextChanged(object sender, EventArgs e)
        {

            if (Txt_Busqueda.Text == "")
            {

                ExtraerEstado(DATA_Griew_Estados);
            }
            else
            {
                filtrarEstado(DATA_Griew_Estados, Txt_Busqueda.Text);
            }
        }

        private void Bttn_Limpiar_Click(object sender, EventArgs e)
        {
            limpiar();
            this.estadosTableAdapter.Fill(this.ventasAutoPartesDataSet.Estados);
        }

        private void Txt_CodigoTipo_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloNumeros(e);
        }

        private void Txt_CodigoDescripcion_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txt_CodigoDescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.ValirLetrasYEspacios(sender, e, Txt_CodigoDescripcion);
        }

        private void Txt_CodigoEstado_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloNumeros(e);
        }

        private void Txt_Busqueda_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.ValirLetrasYEspacios(sender, e, Txt_Busqueda);
        }

        private void Radio_Busqueda_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Txt_CodigoTipo_MouseClick(object sender, MouseEventArgs e)
        {

        }



        ////////////////////////////////FUNCIONES///////////////////////////////
        //////////////////////////////////////////////////////////////////////////////////////////////////


        private void limpiar()
        {
            Txt_CodigoTipo.Text = string.Empty;
            Txt_CodigoEstado.Text = string.Empty;
            Txt_CodigoDescripcion.Text = string.Empty;
            Txt_Busqueda.Text = string.Empty;
        }
        public void selectFila(DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.DATA_Griew_Estados.Rows[e.RowIndex];
                //AS [Codigo Tipo de Estado], Codigo_Estado AS [Codigo de Estado], Descripcion_Estado AS [Descripcion de Estado] FROM Estados WHERE Descripcion_Estado LIKE '%{0}%'", a);//'%{0}%'
                Txt_CodigoTipo.Text = row.Cells["Codigo Tipo de Estado"].Value.ToString();
                Txt_CodigoEstado.Text = row.Cells["Codigo de Estado"].Value.ToString();
                Txt_CodigoDescripcion.Text = row.Cells["Descripcion de Estado"].Value.ToString();

            }
        }

        private void soloNumeros(KeyPressEventArgs e)
        {
            e.Handled = !(Char.IsNumber(e.KeyChar) || e.KeyChar == 8);

        }

        private void actualizarEstados()
        {
            using (SqlConnection sc = new SqlConnection())
            {
                Con.cnx.Open();

                using (SqlCommand com = Con.cnx.CreateCommand())
                {
                    com.CommandText = "UPDATE Estados SET Codigo_Tipo_Estado = @codigoTipoEstado, Codigo_Estado = @codigoEstado, Descripcion_Estado = @descripcionEstado WHERE Codigo_Tipo_Estado =" + Txt_CodigoTipo.Text + " and Codigo_Estado =" + Txt_CodigoEstado.Text;

                    com.Parameters.AddWithValue("@codigoTipoEstado", Txt_CodigoTipo.Text);
                    com.Parameters.AddWithValue("@codigoEstado", Txt_CodigoEstado.Text);
                    com.Parameters.AddWithValue("@descripcionEstado", Txt_CodigoDescripcion.Text);

                    com.ExecuteNonQuery();
                }

                this.estadosTableAdapter.Fill(this.ventasAutoPartesDataSet.Estados);

                Con.cnx.Close();
            }

            MessageBox.Show("Estado Actualizado");

        }

        public void filtrarEstado(DataGridView dgv, string a)
        {

            Conexion con = new Conexion();
            con.cnx.Open();
            try
            {
                con.sql = string.Format
                (@"SELECT Codigo_Tipo_Estado AS [Codigo Tipo de Estado], Codigo_Estado AS [Codigo de Estado], Descripcion_Estado AS [Descripcion de Estado] FROM Estados WHERE Descripcion_Estado LIKE '%{0}%'", a);//'%{0}%'
                con.cmd = new SqlCommand(con.sql, con.cnx);
                con.DataAdapter = new SqlDataAdapter(con.cmd);
                con.dt = new DataTable();
                con.DataAdapter.Fill(con.dt);
                dgv.DataSource = con.dt;

                con.cnx.Close();

            }
            catch
            {

            }

        }


        public void ExtraerEstado(DataGridView dgv)
        {

            Conexion con = new Conexion();
            con.cnx.Open();
            try
            {
                con.sql = string.Format
                (@"SELECT Codigo_Tipo_Estado AS [Codigo Tipo de Estado], Codigo_Estado AS [Codigo de Estado], Descripcion_Estado AS [Descripcion de Estado] FROM Estados");//'%{0}%'
                con.cmd = new SqlCommand(con.sql, con.cnx);
                con.DataAdapter = new SqlDataAdapter(con.cmd);
                con.dt = new DataTable();
                con.DataAdapter.Fill(con.dt);
                dgv.DataSource = con.dt;

                con.cnx.Close();

            }
            catch
            {

            }

        }

        private void agregarEstado()
        {
            try
            {
                using (SqlCommand com = Con.cnx.CreateCommand())
                {
                    Con.cnx.Open();

                    com.CommandText = "INSERT INTO Estados (Codigo_Tipo_Estado, Codigo_Estado, Descripcion_Estado) VALUES (@codigoTipoEstado, @codigoEstado, @descripcionEstado);";
                    com.Parameters.AddWithValue("@codigoTipoEstado", Txt_CodigoTipo.Text);
                    com.Parameters.AddWithValue("@codigoEstado", Txt_CodigoEstado.Text);
                    com.Parameters.AddWithValue("@descripcionEstado", Txt_CodigoDescripcion.Text);

                    com.ExecuteNonQuery();

                    Con.cnx.Close();
                }

                this.estadosTableAdapter.Fill(this.ventasAutoPartesDataSet.Estados);

                MessageBox.Show("Estado Agregado");
            }
            catch
            {
                Con.cnx.Close();
                MessageBox.Show("No se pueden duplicar", "ERROR");
            }
        }

        
        private void validarDescripcion(DataGridView dgv, string txt)
        {
            foreach (DataGridViewRow row in dgv.Rows)
            {
                string value = row.Cells["Descripcion de Estado"].Value.ToString();
                if (value == txt)
                {
                    MessageBox.Show("No puede ingresar la misma descripcion");
                    break;
                }
                
            }
        }

        ////////////////////////////////////////////////////////////////////
        /*private void compararLlaves(DataGridView dgv, string nuevasLlaves)
        {
            foreach (DataGridViewRow row in dgv.Rows)
            {
                string value = row.Cells["codigoTipoEstadoDataGridViewTextBoxColumn"].Value.ToString() + row.Cells["codigoEstadoDataGridViewTextBoxColumn"].Value.ToString();
                if (value == nuevasLlaves)
                {
                    MessageBox.Show("No puede ingresar el mismo codigo");
                    break;
                }
                else
                    agregarEstado();
                    break;
           }
                        
        }*/
       
    }
}
