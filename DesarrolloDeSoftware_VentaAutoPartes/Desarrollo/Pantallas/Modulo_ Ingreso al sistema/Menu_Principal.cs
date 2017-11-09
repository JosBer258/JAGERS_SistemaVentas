using Desarrollo.Pantallas.Modulo__Empleados;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desarrollo.Pantallas.Modulo__Ingreso_al_sistema
{
    public partial class Menu_Principal : Form
    {
        public Menu_Principal()
        {
            InitializeComponent();
        }

        private void manejoDeEmpleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Manejo_de_Empleados Empleados = new Form_Manejo_de_Empleados();
            Empleados.ShowDialog();
        }

        private void manejoDeRolesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_ManejoRoles Roles = new Form_ManejoRoles();
            Roles.ShowDialog();
        }
    }
}
