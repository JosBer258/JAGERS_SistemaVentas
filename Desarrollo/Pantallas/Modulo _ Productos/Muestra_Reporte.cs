using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desarrollo.Pantallas.Modulo___Productos
{
    public partial class Muestra_Reporte : System.Windows.Forms.Form
    {
      
        public Muestra_Reporte()
        {
            InitializeComponent();
        }

        private void Muestra_Reporte_Load(object sender, EventArgs e)
        {
                
            reportViewer1.RefreshReport();
         
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
