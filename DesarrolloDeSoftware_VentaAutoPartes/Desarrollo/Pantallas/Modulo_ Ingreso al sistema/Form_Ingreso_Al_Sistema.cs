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


        int cont = 5;
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

       
        private void pictureBox8_Click_1(object sender, EventArgs e)
        {
            C_Usuarios Users = new C_Usuarios();
            Conexion con = new Conexion();

            

            Validaciones encriptar = new Validaciones();

            string login_pass = encriptar.EncriptarContraseña(txtpwd.Text);
            string login_usuario = txtuser.Text;
            //string login_pass = (txtpwd.Text);

            Users.Var_Id_empleado = login_usuario;
            Users.Var_Contrasena = login_pass;

            if (txtuser.Text == "Usuario" && txtpwd.Text == "12345")
            {
                MessageBox.Show("Por Favor ingrese un usuario y una contraseña", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
            }else
            if (Users.Fun_Buscar_UserAndPass() == true)
            {

                if(Users.Var_Codigo_estado == 1)
                {
                    Users.Fun_RestablecerIntentos();

                          Menu_Principal Menu = new Menu_Principal();
                         Menu.CodigoRol = Convert.ToString(Users.Var_Codigo_rol);
                         Menu.Empleado_Contraseña = Convert.ToString(txtpwd.Text);
                         Menu.ID_Empleado = Convert.ToString(txtuser.Text);
                         Menu.Empleado_Nombre = Convert.ToString(Users.Var_Nombre);
                    this.Hide();
                        Menu.Show();
                 }
                else
                    if (Users.Var_Codigo_estado == 2)
                {
                    MessageBox.Show("Usuario: " + Users.Var_Id_empleado + " Ha sido bloqueado, favor acudir al Gerente", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    Form_Desbloqueo_De_Usuario Desbloque = new Form_Desbloqueo_De_Usuario();
                    Desbloque.ID_UsuarioADesbloquear = txtuser.Text;
                    Desbloque.ShowDialog();
                }
                else if (Users.Var_Codigo_estado == 3)
                {
                    MessageBox.Show("Usuario: " + Users.Var_Id_empleado + " Ha sido bloqueado, favor acudir al Gerente", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    Form_Desbloqueo_De_Usuario Desbloque = new Form_Desbloqueo_De_Usuario();
                    Desbloque.ID_UsuarioADesbloquear = txtuser.Text;
                    Desbloque.ShowDialog();
                }
                else
                {
                    Form__Ingreso_NuevaContraseña NuevaContraseña = new Form__Ingreso_NuevaContraseña();
                    NuevaContraseña.base_ID = txtuser.Text;
                    NuevaContraseña.base_Contraseña = txtpwd.Text;
                    NuevaContraseña.ShowDialog();
                }
            }
            else
                if (Users.Fun_Buscar_User() == true)
            {
                
                txtpwd.Text = "";
                txtpwd.Focus();

                if (Users.Var_Oportunidades_numero > 0)
                {
                    MessageBox.Show("Quedan: " + Users.Var_Oportunidades_numero + " intentos.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    
                  MessageBox.Show("Usuario: " + Users.Var_Id_empleado + " Ha sido bloqueado, favor acudir al Gerente", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

               

                }

          
            }
            else 
            if (Users.Fun_Buscar_UserAndPass() == false)
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
            Pantallas.Modulo__Ingreso_al_sistema.Form__Ingreso_NuevaContraseña NuevaContraseña = new Pantallas.Modulo__Ingreso_al_sistema.Form__Ingreso_NuevaContraseña();
            NuevaContraseña.ShowDialog();
        }

        private void txtpwd_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones pwd = new Validaciones();
            pwd.ValidarPassword(sender, e);

           if (e.KeyChar == 13)
                pictureBox8_Click_1(null, null);
        }

        private void txtpwd_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtuser_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones numeros = new Validaciones(); ;
            numeros.ValidarID(sender, e);
        }
    }
}