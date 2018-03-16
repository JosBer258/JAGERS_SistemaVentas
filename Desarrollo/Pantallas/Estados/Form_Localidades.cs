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

namespace Desarrollo.Pantallas.Estados
{
    public partial class Form_Localidades : Form
    {
        Conexion Conex = new Conexion();
        C_Localidades localidad = new C_Localidades(); 

        public Form_Localidades()
        {
            InitializeComponent();
        }

        private void Form_Localidades_Load(object sender, EventArgs e)
        {
            localidad.Fun_LlenarDataGriew(DataGriew_Localidades);
            localidad.Fun_ExtraerEstados(ComboBoz_Estados);
            Radio_Nueva.Checked = true;

            var blankContextMenu = new ContextMenuStrip();
           Txt_Direccion.ContextMenuStrip = blankContextMenu;
           Txt_Nombre.ContextMenuStrip = blankContextMenu;


        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void Radio_Nueva_CheckedChanged(object sender, EventArgs e)
        {
            if (Radio_Nueva.Checked == true)
            {
                Txt_Direccion.Clear();
                Txt_Nombre.Clear();
                ComboBoz_Estados.SelectedIndex = 0;
                Txt_Codigo.Text = Convert.ToString(localidad.Fun_GenerarNuevoCodigo());
                Txt_Nombre.Enabled = true;
            }
            else
            {
                Txt_Codigo.Text = string.Empty;
                Txt_Direccion.Clear();
                Txt_Nombre.Clear();
                ComboBoz_Estados.SelectedIndex = 0;
                Txt_Nombre.Enabled = false;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Txt_Codigo.Text))
            {
                errorProvider1.SetError(Txt_Codigo, "Por favor, El codigo es un espacio Requerido");
                Txt_Codigo.Focus();
            }
            else { errorProvider1.SetError(Txt_Codigo, ""); }

            if (string.IsNullOrWhiteSpace(Txt_Nombre.Text))
            {
                errorProvider1.SetError(Txt_Nombre, "Por favor, el nombre es un campo requerido");
                Txt_Nombre.Focus();
            }
            else { errorProvider1.SetError(Txt_Nombre, ""); }


            if (string.IsNullOrWhiteSpace(Txt_Direccion.Text))
            {
                errorProvider1.SetError(Txt_Direccion, "Por favor, la direccion es un espacio requerido");
                Txt_Direccion.Focus();

            }
            else {
                errorProvider1.SetError(Txt_Direccion, "");

                localidad.NombreLocalidad = Txt_Nombre.Text;
                localidad.DireccionLocalidad = Txt_Direccion.Text;
                localidad.CodigoLocalidad = Convert.ToInt16(Txt_Codigo.Text);
                localidad.EstadoLocalidad = Convert.ToInt16(ComboBoz_Estados.SelectedValue);

                if (Radio_Nueva.Checked == true)
                {

                    localidad.ValidarRepeticion();

                }
                else
                if (Radio_Actualizar.Checked == true)
                {
                    localidad.ValidarActualizarLocalidad();
                }

                localidad.Fun_LlenarDataGriew(DataGriew_Localidades);

                if (Radio_Nueva.Checked == true)
                {
                    Fun_Limpiar();
                    Txt_Codigo.Text = Convert.ToString(localidad.Fun_GenerarNuevoCodigo());
                }
                else
                {
                    Fun_Limpiar();
                }
            }
        }
            
        private void Fun_Limpiar()
        {
            Txt_Codigo.Clear();
            Txt_Direccion.Clear();
            Txt_Nombre.Clear();
            ComboBoz_Estados.SelectedIndex = 0;
        }


        private void DataGriew_Localidades_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = this.DataGriew_Localidades.Rows[e.RowIndex];

                Radio_Actualizar.Checked = true;
                Txt_Codigo.Text = Convert.ToString(row.Cells["Codigo"].Value.ToString());
                Txt_Nombre.Text = Convert.ToString(row.Cells["Nombre"].Value.ToString());
                Txt_Direccion.Text = Convert.ToString(row.Cells["Direccion"].Value.ToString());
                ComboBoz_Estados.SelectedValue = Convert.ToInt32(row.Cells["Codigo del Estado"].Value.ToString());
            }
            catch (Exception) { }
        }

        private void Txt_Nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            Desarrollo.Clases.Validaciones Val = new Clases.Validaciones();
            Val.ValirLetrasYEspacios(sender, e, Txt_Nombre);
        }

        private void Txt_Direccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            Desarrollo.Clases.Validaciones Val = new Clases.Validaciones();
            Val.ValirLetrasYEspacios_Direccion(sender, e, Txt_Direccion);
        }

       
    }
}
