using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desarrollo.Pantallas.Estados
{
    public partial class Form_MantenimientoEstados : Form
    {
        public Form_MantenimientoEstados()
        {
            InitializeComponent();
        }

        private void Form_MantenimientoEstados_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'ventasAutoPartesDataSet.Estados' Puede moverla o quitarla según sea necesario.
            this.estadosTableAdapter.Fill(this.ventasAutoPartesDataSet.Estados);

        }

        private void Bttn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Bttn_Aceptar_Click(object sender, EventArgs e)
        {

        }
    }
}
