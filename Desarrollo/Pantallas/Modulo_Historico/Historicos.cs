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
        Conexion Con = new Conexion();
        Validaciones val = new Validaciones();
        C_DatoHistoricos His = new C_DatoHistoricos();

        public Historicos()
        {
            InitializeComponent();
        }

        private void Historicos_Load(object sender, EventArgs e)
        {
            var blankContextMenu = new ContextMenuStrip();
            txtBusquedaNombre.ContextMenuStrip = blankContextMenu;

            His.Fun_CargarDataClienteHistorico(DataGriew_Historicos);
        }

   

        private void Radio_Empleado_CheckedChanged(object sender, EventArgs e)
        {
            if(Radio_Empleado.Checked)
            {
                His.Fun_CargarDataEmpleadoHistorico(DataGriew_Historicos);
            }
        }

        private void Radio_Cliente_CheckedChanged(object sender, EventArgs e)
        {
            if (Radio_Cliente.Checked)
            {
                His.Fun_CargarDataClienteHistorico(DataGriew_Historicos);
            }
        }

        private void Radio_Producto_CheckedChanged(object sender, EventArgs e)
        {
            if (Radio_Producto.Checked)
            {
                His.Fun_CargarDataProductoHistorico(DataGriew_Historicos);
            }
        }

        private void Radio_Proveedor_CheckedChanged(object sender, EventArgs e)
        {
            if (Radio_Proveedor.Checked)
            {
                His.Fun_CargarDataProveedorHistorico(DataGriew_Historicos);
            }
        }

        private void txtBusquedaNombre_TextChanged(object sender, EventArgs e)
        {
            if (txtBusquedaNombre.Text == string.Empty)
            {
                if (Radio_Cliente.Checked)
                {
                    His.Fun_CargarDataClienteHistorico(DataGriew_Historicos);
                }
                if (Radio_Empleado.Checked)
                {
                    His.Fun_CargarDataEmpleadoHistorico(DataGriew_Historicos);
                }
                if (Radio_Producto.Checked)
                {
                    His.Fun_CargarDataProductoHistorico(DataGriew_Historicos);
                }
                if (Radio_Proveedor.Checked)
                {
                    His.Fun_CargarDataProveedorHistorico(DataGriew_Historicos);
                }
            }
            else
            {
                if(Radio_Cliente.Checked)
                {
                    His.ExtraerNombClienteHistorico(DataGriew_Historicos, txtBusquedaNombre.Text);
                }
                if (Radio_Empleado.Checked)
                {
                    His.ExtraerNombEmpleadoHistorico(DataGriew_Historicos, txtBusquedaNombre.Text);
                }
                if (Radio_Producto.Checked)
                {
                    His.ExtraerNombProductoHistorico(DataGriew_Historicos, txtBusquedaNombre.Text);
                }
                if (Radio_Proveedor.Checked)
                {
                    His.ExtraerNombProveedorHistorico(DataGriew_Historicos, txtBusquedaNombre.Text);
                }
                
            }
        }

        private void Pest1_Btn_Limpiar_Click(object sender, EventArgs e)
        {
            txtBusquedaNombre.Clear();
        }

        private void txtBusquedaNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.ValirLetrasYEspacios(sender, e, txtBusquedaNombre);
        }

        private void Bttn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
