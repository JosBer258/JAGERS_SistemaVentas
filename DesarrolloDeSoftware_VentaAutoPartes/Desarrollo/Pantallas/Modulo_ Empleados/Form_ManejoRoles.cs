using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desarrollo.Pantallas.Modulo__Empleados
{
    public partial class Form_ManejoRoles : Form
    {
        public Form_ManejoRoles()
        {
            InitializeComponent();
        }

        private void Form_ManejoRoles_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'ventasAutoPartesDataSet.Empleados' Puede moverla o quitarla según sea necesario.
            this.empleadosTableAdapter.Fill(this.ventasAutoPartesDataSet.Empleados);
            // TODO: esta línea de código carga datos en la tabla 'ventasAutoPartesDataSet.Rol' Puede moverla o quitarla según sea necesario.
            this.rolTableAdapter.Fill(this.ventasAutoPartesDataSet.Rol);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
