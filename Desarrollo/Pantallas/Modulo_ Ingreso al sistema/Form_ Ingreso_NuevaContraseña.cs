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
    public partial class Form__Ingreso_NuevaContraseña : System.Windows.Forms.Form
    {
        Validaciones Validar = new Validaciones();   
        C_Desbloqueo Des = new C_Desbloqueo();

        public string Var_base_id, Var_base_contraseña;

        public Form__Ingreso_NuevaContraseña()
        {
            InitializeComponent();
        }

        private void txtuser_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            string contraseña_a_codificar;


            if (Txt_ContraseñaVieja.Text == "")
            {
                MessageBox.Show("Debe Ingresar la Contraseña actual para continuar", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Txt_ContraseñaVieja.Focus();
                Txt_Password_Primera.Text = "";
                Txt_Password_Second.Text = "";
                return;
            }
            else if(Txt_ContraseñaVieja.Text != Var_base_contraseña)
            {
                MessageBox.Show("La Contraseña actual es incorrecta, \n Intente nuevamente", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Txt_ContraseñaVieja.Focus();
                Txt_Password_Primera.Text = "";
                Txt_Password_Second.Text = "";
                return;
            }
            if (Txt_Password_Primera.Text == "") {
                MessageBox.Show("La Contraseña no debe quedar en Vacio", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Txt_Password_Primera.Focus();
                return;

            }else if(Txt_Password_Second.Text == "")
            {
                MessageBox.Show("La Contraseña no debe quedar en Vacio", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Txt_Password_Second.Focus();
                return;

            }
            else if(Txt_Password_Primera.Text != Txt_Password_Second.Text)
            {
                MessageBox.Show("La Contraseña y la confirmacion deben ser iguales", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }else if(Txt_Password_Primera.Text.Trim().Length < 8)
            {
                MessageBox.Show("La Contraseña debe ser almenos de 8 digitos de Longitud", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Txt_Password_Primera.Focus();
                return;
            }else if(Txt_Password_Primera.Text == Var_base_contraseña)
            {
                MessageBox.Show("La contraseña nueva no puede ser la misma que la anterior", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Txt_Password_Primera.Focus();
                Txt_Password_Second.Text = "";
                return;
            }
           


            contraseña_a_codificar = Validar.EncriptarContraseña(Txt_Password_Primera.Text);
            Des.Fun_NuevaContraseña(Var_base_id, contraseña_a_codificar);
            Des.Fun_Restauracion(Var_base_id);

            MessageBox.Show("Contraseña cambiada con exito","Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            this.Close();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Txt_Password_Primera_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.ValidarPassword(sender, e);
        }

        private void Txt_Password_Second_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.ValidarPassword(sender, e);
        }

        private void Txt_ContraseñaVieja_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.ValidarPassword(sender, e);
        }

        private void Form__Ingreso_NuevaContraseña_Load(object sender, EventArgs e)
        {
            Txt_UserID.Text = Var_base_id;

            var blankContextMenu = new ContextMenuStrip();
            Txt_Password_Primera.ContextMenuStrip = blankContextMenu;
            Txt_Password_Second.ContextMenuStrip = blankContextMenu;
            Txt_ContraseñaVieja.ContextMenuStrip = blankContextMenu;
        }
    }
}
