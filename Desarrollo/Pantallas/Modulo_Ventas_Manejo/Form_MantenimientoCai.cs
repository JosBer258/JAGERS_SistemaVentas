using Desarrollo.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desarrollo.Pantallas.Modulo_Ventas_Manejo
{
    public partial class Form_MantenimientoCai : System.Windows.Forms.Form
    {
        Cai cai = new Cai();
        Validaciones val = new Validaciones();
        
         public Form_MantenimientoCai()
        {
            InitializeComponent();
        }

        private void dataGrid_VentasCai_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txt_Codigo_TextChanged(object sender, EventArgs e)
        {

        }
        private void validacionMenu()
        {
            var blankContextMenu = new ContextMenuStrip();
            var boxes = gb_ModificarCai.Controls.OfType<TextBox>();
            foreach (var box in boxes)
            {
                box.ContextMenuStrip = blankContextMenu;

            }


            var boxex = gb_ModificarCai.Controls.OfType<DateTimePicker>();
            foreach (var box in boxex)
            {
                box.ContextMenuStrip = blankContextMenu;

            }


            var boxe1 = groupBox1.Controls.OfType<TextBox>();
            foreach (var box in boxe1)
            {
                box.ContextMenuStrip = blankContextMenu;

            }


            



        }
        private void Form_MantenimientoCai_Load(object sender, EventArgs e)
        {
            CargarPrimerDataGriew(dataGrid_VentasCai);
            txt_buscar.MaxLength = cai.longitudMaximaBusqueda();
            dataGrid_VentasCai.ReadOnly = true;
            validacionMenu();
            date_FechaLimite.MinDate = DateTime.Now;

            if (cai.RevisionDeExistencia() == false)
            {
                rb_BuscarDatosCod.Checked = true;
                rb_AgregarCodigoCai.Enabled = false;
                MessageBox.Show("Existe ya un Cai activo." + " " +"Solo se puede agregar Cai una vez que ha expirado el anterior.", "Existencia Activa", MessageBoxButtons.OK);
                return;
                
            }
            else
            {
                txt_Codigo.Text = Convert.ToString(cai.ObtenerUltimoCodigoCai());


                rb_AgregarCodigoCai.Enabled = true;
                rb_AgregarCodigoCai.Checked = true;
            }
            
           
            
        }
        public void CargarPrimerDataGriew(DataGridView dgv)
        {
            Conexion con = new Conexion();
            con.cnx.Open();
            try
            {
                con.DataAdapter = new SqlDataAdapter("select A.Codigo_Cai as Codigo, A.CodigoProporcionado as Clave,A.FechaLimite as Fecha_Limite, A.RangoInicial as RangoInicial, A.RangoFinal as Rango_final,A.Correlativo, B.Descripcion_Estado as Descripcion_de_Estado from Cai as A inner join Estados as B on A.Codigo_Estado = b.Codigo_Estado where Codigo_Tipo_Estado = 7 order by Codigo_Cai", con.ccnx);
                con.dt = new DataTable();
                con.DataAdapter.Fill(con.dt);
                dgv.DataSource = con.dt;

            }
            catch
            {

            }
        }
        private bool Vacios(object sender, EventArgs e)
        {
            //int v = 0;
            int s = 0;
           
           

                    var boxes = gb_ModificarCai.Controls.OfType<TextBox>();
                    foreach (var box in boxes)
                    {
                        if (string.IsNullOrWhiteSpace(box.Text))
                        {
                            errorProvider1.SetError(box, "Please fill the required field");
                            s++;
                        }
                        else
                        {
                            errorProvider1.SetError(box, "");
                        }

                    }
                    if (s > 0)
                        return false;
                    else
                    {

                        return true;
                    }


                 
               

        }
        public void IngresoDatos()
        {
            

            DateTime dt = cai.FechaLimite1;
            string strDate = dt.ToString("yyyy-MM-dd");

         
            Conexion cs = new Conexion();
            cs.sql = string.Format(@"insert into Cai values(
            '{0}',  '{1}',  '{2}',  '{3}', '{4}', '{5}') ",cai.CodigoProporcionado, strDate,
            cai.RangoInicial1, cai.Rangofinal1,0,1 );
            cs.cmd = new SqlCommand(cs.sql, cs.cnx);
            cs.cnx.Open();
            SqlDataReader Reg = null;
            Reg = cs.cmd.ExecuteReader();
            cs.cnx.Close();

            MessageBox.Show("Ingresado Correctamente");
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            
            cai.CodigoProporcionado = Convert.ToString(txt_ClaveCai.Text);
            cai.FechaLimite1 = Convert.ToDateTime(date_FechaLimite.Text);
            cai.RangoInicial1 = Convert.ToString(txt_RangoInicial.Text);
            cai.Rangofinal1 = Convert.ToString(txt_RangoFinal.Text);
            
            if(Vacios(sender,e)==true)
            {
                
                if(cai.RevisionDeDatos()==false)
                {
                    MessageBox.Show("Existe una duplicación de datos ya sea por la Clave Cai" +" "+
              "o por los Rangos, por favor revise nuevamente los datos del Nuevo Cai.", "Duplicacion de Datos", MessageBoxButtons.OK);
                    return;
                }
                else
                {
                    if(cai.RevisionRangos()==true)
                    {
                        errorProvider1.SetError(txt_RangoInicial, "Valor Incorrecto");
                        errorProvider1.SetError(txt_RangoFinal, "Valor Incorrecto");
                    }
                    else
                    {
                        errorProvider1.SetError(txt_RangoInicial, "");
                        errorProvider1.SetError(txt_RangoFinal, "");
                        if (cai.RevisionRangosSql() == false)
                        {
                            errorProvider1.SetError(txt_RangoInicial, "Valor Menor Al Ultimo Rango Final");
                            errorProvider1.SetError(txt_RangoFinal, "Valor Menor Relacional Al Ultimo Rango Final ");
                        }
                        else
                        {
                            errorProvider1.SetError(txt_RangoInicial, "");
                            errorProvider1.SetError(txt_RangoFinal, "");
                            IngresoDatos();
                        }
                    }
                }


            }
            //this.caiTableAdapter.Fill(this.ventasAutoPartesDataSet.Cai);
            txt_buscar.MaxLength = cai.longitudMaximaBusqueda();
           
            date_FechaLimite.MinDate = DateTime.Now;
            if (cai.RevisionDeExistencia() == false)
            {
                rb_BuscarDatosCod.Checked = true;
                rb_AgregarCodigoCai.Enabled = false;

            }

            CargarPrimerDataGriew(dataGrid_VentasCai);
        }

        private void date_FechaLimite_ValueChanged(object sender, EventArgs e)
        {
         
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (txt_buscar.Text == string.Empty)
            {
                //this.caiTableAdapter.Fill(this.ventasAutoPartesDataSet.Cai);
                CargarPrimerDataGriew(dataGrid_VentasCai);
            }
            else
            {
                cai.CargarPorCodigo(dataGrid_VentasCai, Convert.ToInt32(Convert.ToInt64(txt_buscar.Text)));
            }
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            var boxes = gb_ModificarCai.Controls.OfType<TextBox>();
            foreach (var box in boxes)
            {
                box.Text = string.Empty;

            }


            


            var boxe1 = groupBox1.Controls.OfType<TextBox>();
            foreach (var box in boxe1)
            {
                box.Text = string.Empty;

            }
            if(rb_AgregarCodigoCai.Checked==true)
            {
                txt_Codigo.Text = Convert.ToString(cai.ObtenerUltimoCodigoCai());
            }
        }

        private void txt_ClaveCai_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.ValidarNombres_LetrasYNumeros(sender, e);
        }

        private void txt_RangoInicial_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.ValidarID(sender, e);
        }

        private void txt_RangoFinal_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.ValidarID(sender, e);
        }

        private void txt_buscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.ValidarID(sender, e);
        }

        private void rb_AgregarCodigoCai_CheckedChanged(object sender, EventArgs e)
        {
            if(rb_AgregarCodigoCai.Checked==true)
            {
                txt_Codigo.Text = Convert.ToString(cai.ObtenerUltimoCodigoCai());
                groupBox1.Enabled = false;
                var boxes = groupBox1.Controls.OfType<TextBox>();
                foreach (var box in boxes)
                {
                    box.Text = string.Empty;
                    errorProvider1.SetError(box, "");
                }
            }
            else
            {
                groupBox1.Enabled = true;
                var boxes = gb_ModificarCai.Controls.OfType<TextBox>();
                foreach (var box in boxes)
                {
                    box.Text = string.Empty;
                    errorProvider1.SetError(box, "");
                }
            }
        }

        private void rb_BuscarDatosCod_CheckedChanged(object sender, EventArgs e)
        {
            if(rb_BuscarDatosCod.Checked==true)
            {
                gb_ModificarCai.Enabled = false;
                var boxes = gb_ModificarCai.Controls.OfType<TextBox>();
                foreach (var box in boxes)
                {
                    box.Text = string.Empty;
                    errorProvider1.SetError(box, "");
                }
            }
            else
            {
                txt_Codigo.Text = Convert.ToString(cai.ObtenerUltimoCodigoCai());
                gb_ModificarCai.Enabled = true;
                var boxes = groupBox1.Controls.OfType<TextBox>();
                foreach (var box in boxes)
                {
                    box.Text = string.Empty;
                    errorProvider1.SetError(box, "");
                }
            }
        }

        private void dataGrid_VentasCai_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
