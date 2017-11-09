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

namespace Desarrollo.Pantallas.Modulo__Ingreso_al_sistema
{
    public partial class Form_Desbloqueo_De_Usuario : Form
    {
        public int ID_UsuarioADesbloquear;

        public Form_Desbloqueo_De_Usuario()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Desbloqueo DesbloquearUser = new Desbloqueo();


        }
    }
}
