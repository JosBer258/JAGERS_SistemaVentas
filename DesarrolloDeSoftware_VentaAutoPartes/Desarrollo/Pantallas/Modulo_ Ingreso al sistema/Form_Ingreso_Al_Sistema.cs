using Desarrollo.Clases;
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

namespace Desarrollo
{
    public partial class Form_Ingreso_Al_Sistema : Form
    {
        C_Usuarios Users = new C_Usuarios();
        Validaciones Validar = new Validaciones();


        public Form_Ingreso_Al_Sistema()
        {
            InitializeComponent();
        }



        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var blankContextMenu = new ContextMenuStrip();
            txtuser.ContextMenuStrip = blankContextMenu;
            txtpwd.ContextMenuStrip = blankContextMenu;

            txtuser.AutoSize = false;
            txtuser.Size = new Size(220, 30);

            txtpwd.AutoSize = false;
            txtpwd.Size = new Size(220, 30);
        }

        private void pictureBox9_Click_1(object sender, EventArgs e)
        {
            DialogResult opcion;
            opcion = MessageBox.Show("¿Desea salir del sistema?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (opcion == DialogResult.Yes)
                Application.Exit();
        }

        private void txtuser_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click_1(object sender, EventArgs e)
        {

            Conexion con = new Conexion();

            bool Respuesta;

            string login_pass = txtpwd.Text;
            string login_usuario = txtuser.Text;
            
            Respuesta = Users.Fun_PruebaComprobarEstado(login_usuario, login_pass);

            if (Respuesta == true)
            {
                Menu_Principal Men = new Menu_Principal();
                Men.ID_Empleado = txtuser.Text;
                Men.Empleado_Contraseña = txtpwd.Text;
                Men.ShowDialog();


            }
            else if (Respuesta == false)
            {
                DesbloqueDelSistema();
                MessageBox.Show("s");
            }



    
            
        }

        private void pictureBox8_MouseMove_1(object sender, MouseEventArgs e)
        {
            pictureBox8.Size = new Size(80, 73);
        }

        private void pictureBox8_MouseLeave(object sender, EventArgs e)
        {
            pictureBox8.Size = new Size(70, 63);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form_Desbloqueo_De_Usuario DesbloqueoSistema = new Form_Desbloqueo_De_Usuario();
            DesbloqueoSistema.ShowDialog();
        }



        public void DesbloqueDelSistema()
        {

            if (Convert.ToInt16(Users.Var_Codigo_estado) == 3)
            {
                if (Convert.ToInt16(Users.Var_Codigo_Rol) == 1)
                {
                    Application.Exit();
                }
                else
                {
                    Form_Desbloqueo_De_Usuario Desbloqueo = new Form_Desbloqueo_De_Usuario();
                    Desbloqueo.ID_UsuarioADesbloquear = Convert.ToInt16(txtuser.Text);
                    Desbloqueo.ShowDialog();
                }
            }
        }

        private void txtuser_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.ValidarID(sender, e);
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            
        }
    }
}