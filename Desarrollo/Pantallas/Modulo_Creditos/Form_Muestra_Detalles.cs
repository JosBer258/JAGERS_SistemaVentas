using Desarrollo.Clases;
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
    public partial class Form_Muestra_Detalles : Form
    {
        C_Credito Cl_Credito = new C_Credito();
        public int LDt_CodTran;

        public Form_Muestra_Detalles()
        {
            InitializeComponent();
        }

        private void Form_Muestra_Detalles_Load(object sender, EventArgs e)
        {
            Cl_Credito.Fun_ExtraerDetallesTran(DGV_Detalles, LDt_CodTran);
            
        }

        private void Bttn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
