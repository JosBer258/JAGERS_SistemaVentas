using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desarrollo.Pantallas.Modulo___Proveedores
{
    public partial class Form_Proveedores_Manejo : Form
    {
        public Form_Proveedores_Manejo()
        {
            InitializeComponent();
        }

        private void Form_Proveedores_Manejo_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'ventasAutoPartesDataSet.Proveedor' Puede moverla o quitarla según sea necesario.
            this.proveedorTableAdapter.Fill(this.ventasAutoPartesDataSet.Proveedor);
            // TODO: esta línea de código carga datos en la tabla 'ventasAutoPartesDataSet._Contacto_Proveedor' Puede moverla o quitarla según sea necesario.
            this.contacto_ProveedorTableAdapter.Fill(this.ventasAutoPartesDataSet._Contacto_Proveedor);

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BTTN_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Pest4_Bttn_Aceptar_Click(object sender, EventArgs e)
        {

        }
    }
}
