using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desarrollo.Pantallas.Modulo_Ventas_Manejo.Modulo_ArqueodeCaja
{
    public partial class Form_PantallCierreConfirmacion : Form
    {
        public Form_PantallCierreConfirmacion()
        {
            InitializeComponent();
        }

        private void Form_PantallCierreConfirmacion_Load(object sender, EventArgs e)
        {

        }

        private void Bttn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
