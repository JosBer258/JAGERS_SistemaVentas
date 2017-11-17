using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desarrollo.Pantallas.Modulo_Creditos
{
    public partial class Form_Mantenimiento_Mora : Form
    {
        public Form_Mantenimiento_Mora()
        {
            InitializeComponent();
        }

        private void Form_Mantenimiento_Mora_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'ventasAutoPartesDataSet.Mora' Puede moverla o quitarla según sea necesario.
            this.moraTableAdapter.Fill(this.ventasAutoPartesDataSet.Mora);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Bttn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
