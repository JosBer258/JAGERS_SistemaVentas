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
       

        public Form_Ingreso_Al_Sistema()
        {
            InitializeComponent();
        }

        

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
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
            C_Usuarios Users = new C_Usuarios();
            Conexion con = new Conexion();

            
            int cont = Convert.ToInt16(Users.Fun_OptenerNumeroIntentos());

            string login_pass = txtpwd.Text;
            string login_usuario = txtuser.Text;

            Users.Var_Id_empleado = login_usuario;
            Users.Var_Contrasena = login_pass;

            if (login_usuario.Equals("0")== true || login_pass.Equals("12345")== true)
            {
                MessageBox.Show("Por Favor ingrese un usuario y una contraseña", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            

            if (Users.Fun_Buscar() == true)
            {

                if (Convert.ToInt16(Users.Var_Codigo_Rol) == 1)
                {
                    MessageBox.Show("Bienbenido a Venta Rogers Truck", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (Convert.ToInt16(Users.Var_Codigo_Rol) == 2)
                {
                    MessageBox.Show("Bienbenido a Venta Rogers Truck", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (Convert.ToInt16(Users.Var_Codigo_Rol) == 3)
                {
                    MessageBox.Show("Bienbenido a Venta Rogers Truck", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (Convert.ToInt16(Users.Var_Codigo_Rol) == 4)
                {
                    MessageBox.Show("Bienbenido a Venta Rogers Truck", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Usted No tiene Autorizacion para Continuar", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }



            } else 
            if (Users.Fun_Buscar() == false)
            {
                cont--;
                if (cont > 0)
                {
                    MessageBox.Show("Verifique Usuario o Contraseña incorrectos. \nTiene " + cont + " intentos", "¡ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Ingreso Incorrecto de datos. \nLa Aplicacion se cerrara", "¡ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Application.Exit();
                }
            }



            Menu_Principal Menu = new Menu_Principal();
            Menu.ShowDialog();
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
    }
}