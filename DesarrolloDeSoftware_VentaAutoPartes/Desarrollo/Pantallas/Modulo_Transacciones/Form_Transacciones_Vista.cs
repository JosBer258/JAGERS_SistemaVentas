using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desarrollo.Pantallas.Modulo_Transacciones
{
    public partial class Form_Transacciones_Vista : Form
    {
        public Form_Transacciones_Vista()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form_Transacciones_Vista_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'ventasAutoPartesDataSet.Transacciones' Puede moverla o quitarla según sea necesario.
            this.transaccionesTableAdapter.Fill(this.ventasAutoPartesDataSet.Transacciones);

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
