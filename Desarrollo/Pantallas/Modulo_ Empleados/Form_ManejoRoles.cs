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

namespace Desarrollo.Pantallas.Modulo__Empleados
{
    public partial class Form_ManejoRoles : Form
    {
        Conexion con = new Conexion();
        C_Roles rol = new C_Roles();
        int existe = 0;

        public Form_ManejoRoles()
        {
            InitializeComponent();
        }

        private void Form_ManejoRoles_Load(object sender, EventArgs e)
        {
            
            Txt_Codigo.Enabled = false;
            Radio_Modificar.Checked = true;

            var blankContextMenu = new ContextMenuStrip();
            Txt_Descripcion.ContextMenuStrip = blankContextMenu;
            Txt_Codigo.ContextMenuStrip = blankContextMenu;
           
            try
            { this.empleadosTableAdapter.Fill(this.ventasAutoPartesDataSet.Empleados);
              this.rolTableAdapter.Fill(this.ventasAutoPartesDataSet.Rol);
            }
            catch(Exception) { }

            rol.Fun_CargarRoles(DataGriew_MuestraDatos);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.rolTableAdapter.FillBy(this.ventasAutoPartesDataSet.Rol);
            }
            catch (System.Exception ex)
            {
               
            }

        }

        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.rolTableAdapter.FillBy1(this.ventasAutoPartesDataSet.Rol);
            }
            catch (System.Exception ex)
            {
            }

        }

        private void Bttn_Guardar_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(Txt_Codigo.Text))
            {
                errorProvider1.SetError(Txt_Codigo, "Por favor, El codigo es un espacio Requerido");
                Txt_Codigo.Focus();
            }
            else { errorProvider1.SetError(Txt_Codigo, ""); }

            if (string.IsNullOrWhiteSpace(Txt_Descripcion.Text))
            {
                errorProvider1.SetError(Txt_Descripcion, "Por favor, el nombre es un campo requerido");
                Txt_Descripcion.Focus();
            }
            else {
                errorProvider1.SetError(Txt_Codigo, "");
                rol.Codigo_Rol = Convert.ToInt16(Txt_Codigo.Text);
                rol.Descripcion = Txt_Descripcion.Text;


                if (Radio_Agregar.Checked == true)
                {

                    existe = rol.Fun_ComprobarDescripcion();

                    if (existe == 1)
                    {
                        Txt_Descripcion.Clear();
                        Txt_Descripcion.Focus();
                    }
                                           
                    Txt_Codigo.Text = Convert.ToString(rol.Fun_Obtener_Ultimo_ID());
                    Txt_Descripcion.Clear();
                }
                else
                if (Radio_Modificar.Checked == true)
                {
                    DataGriew_MuestraDatos.Enabled = true;
                    existe = rol.Fun_ComprobarDescripcionModificar();
                    if (existe == 1)
                    {
                        Txt_Descripcion.Clear();
                        Txt_Descripcion.Focus();
                    }


                    Txt_Codigo.Clear();
                    Txt_Descripcion.Clear();
                }


                rol.Fun_CargarRoles(DataGriew_MuestraDatos);

            }

        }


        private void DataGriew_MuestraDatos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Radio_Modificar.Checked = true;
            string a;
            a = DataGriew_MuestraDatos.CurrentCell.ColumnIndex.ToString();

            if (Convert.ToInt16(a) == 1 || Convert.ToInt16(a) == 0)
            {
                if (Convert.ToInt16(a) == 1)
                {
             
                    Txt_Codigo.Text= DataGriew_MuestraDatos.CurrentRow.Cells[0].Value.ToString();
                    Txt_Descripcion.Text = DataGriew_MuestraDatos.CurrentRow.Cells[1].Value.ToString();
                    
                }
                else
                 if (Convert.ToInt16(a) == 0)
                {

                    Txt_Codigo.Text = DataGriew_MuestraDatos.CurrentCell.Value.ToString();
                    Txt_Descripcion.Text = DataGriew_MuestraDatos.CurrentRow.Cells[1].Value.ToString();
                }

                
            }
        }
        

        private void Radio_Agregar_CheckedChanged(object sender, EventArgs e)
        {
            if (Radio_Agregar.Checked == true)
            {
                Txt_Codigo.Text = Convert.ToString(rol.Fun_Obtener_Ultimo_ID());
                Txt_Descripcion.Text = string.Empty;
            }
            else
            {
                Txt_Codigo.Text = "";
                Txt_Descripcion.Text = string.Empty;

            }
        }

        private void Txt_Descripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones Val = new Validaciones();
            Val.ValirLetrasYEspaciosMayorEspacio(sender, e, Txt_Descripcion);
        }

    }
}
