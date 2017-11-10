using Desarrollo.Pantallas.Modulo__Clientes;
using Desarrollo.Pantallas.Modulo__Empleados;
using Desarrollo.Pantallas.Modulo__Ingreso_al_sistema;
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
        public string ID_Empleado, Empleado_Nombre, CodigoRol, Empleado_Contraseña;

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

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Cliente_ManejoCompleto Clientes = new Form_Cliente_ManejoCompleto();
            Clientes.ShowDialog();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form__Ingreso_NuevaContraseña NuevaContraseña = new Form__Ingreso_NuevaContraseña();
            NuevaContraseña.base_Contraseña= Empleado_Contraseña;
            NuevaContraseña.base_ID = ID_Empleado;
            NuevaContraseña.ShowDialog();



        }

        private void logOutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Menu_Principal_Load(object sender, EventArgs e)
        {          
            if (Convert.ToInt16(CodigoRol) == 1)
            {
                
            }else if (Convert.ToInt16(CodigoRol) == 2)
            {
                Menu_Empleado.Visible = false;
            }
            else if (Convert.ToInt16(CodigoRol) == 3)
            {
                Menu_Empleado.Visible = false;
            }
            else if (Convert.ToInt16(CodigoRol) == 4)
            {
                Menu_Empleado.Visible = false;
            }
        }
    }
}
