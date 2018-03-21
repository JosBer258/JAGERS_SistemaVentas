using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desarrollo.Pantallas.Manueales
{
    public partial class Form_VistaManualPDF : Form
    {
        public Form_VistaManualPDF()
        {
            InitializeComponent();
        }

        private void Bttn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
