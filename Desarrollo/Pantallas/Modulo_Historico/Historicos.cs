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

namespace Desarrollo.Pantallas.Modulo_Historicos
{
    public partial class Historicos : Form
    {
        Conexion Conn = new Conexion();
        Validaciones Valid = new Validaciones();
        C_DatoHistoricos Hist = new C_DatoHistoricos();

        public Historicos()
        {
            InitializeComponent();
        }

        private void Historicos_Load(object sender, EventArgs e)
        {
            var blankContextMenu = new ContextMenuStrip();
            txtBusquedaNombre.ContextMenuStrip = blankContextMenu;

            Radio_Empleado.Checked = true;
            Hist.Fun_CargarDataProductoHistorico(DataGriew_Historicos);

        }

        private void Radio_Empleado_CheckedChanged(object sender, EventArgs e)
        {
            if(Radio_Empleado.Checked)
            {
                Hist.Fun_CargarDataEmpleadoHistorico(DataGriew_Historicos);
            }
        }

        private void Radio_Cliente_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void Radio_Producto_CheckedChanged(object sender, EventArgs e)
        {
            if (Radio_Producto.Checked)
            {
                Hist.Fun_CargarDataProductoHistorico(DataGriew_Historicos);
            }
        }

        private void Radio_Proveedor_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void txtBusquedaNombre_TextChanged(object sender, EventArgs e)
        {
            if (txtBusquedaNombre.Text == string.Empty)
            {
                
                if (Radio_Empleado.Checked)
                {
                    Hist.Fun_CargarDataEmpleadoHistorico(DataGriew_Historicos);
                }
                if (Radio_Producto.Checked)
                {
                    Hist.Fun_CargarDataProductoHistorico(DataGriew_Historicos);
                }
                
            }
            else
            {
                
                if (Radio_Empleado.Checked)
                {
                    Hist.ExtraerNombEmpleadoHistorico(DataGriew_Historicos, txtBusquedaNombre.Text);
                }
                if (Radio_Producto.Checked)
                {
                    Hist.ExtraerNombProductoHistorico(DataGriew_Historicos, txtBusquedaNombre.Text);
                }
               
                
            }
        }

        private void Pest1_Btn_Limpiar_Click(object sender, EventArgs e)
        {
            txtBusquedaNombre.Clear();
        }

        private void txtBusquedaNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            Valid.ValirLetrasYEspacios(sender, e, txtBusquedaNombre);
        }

        private void Bttn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
