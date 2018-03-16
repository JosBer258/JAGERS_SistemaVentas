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
    public partial class Form_Desbloqueo_De_Usuario : System.Windows.Forms.Form
    {
        Validaciones Validar = new Validaciones();
        public string Var_id_usuario_desbloquear;

        public Form_Desbloqueo_De_Usuario()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            C_Desbloqueo DesbloquearUser = new C_Desbloqueo();
            bool respuesta;

            if (Txt_UserID.Text == "") {
                MessageBox.Show("El campo de Identidad no puede quedar vacio", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Txt_UserID.Focus();

                return; }
            else if (Txt_Password_Primera.Text == "") {
                MessageBox.Show("El campo de Contraseña no puede quedar vacio", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Txt_Password_Primera.Focus();

                return; }

            if (Txt_UserID.Text.Trim().Length > 50)
            {
                MessageBox.Show("Longitud de Datos incorrecto \n Ingrese un ID de Longitud mayor a 5 Digitos", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; 
            }



            string contra_encriptada = Validar.EncriptarContraseña(Txt_Password_Primera.Text);
            respuesta = DesbloquearUser.Fun_Comprobacion(Txt_UserID.Text, contra_encriptada);

            if (respuesta == true)
            {
                DesbloquearUser.Fun_Restauracion(Convert.ToString( Var_id_usuario_desbloquear));
                DesbloquearUser.Fun_RestablecerIntentos(Convert.ToString(Var_id_usuario_desbloquear));
                this.Close();
            }
            else
            {
                Application.Exit();
            }


        }

        private void Txt_UserID_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.ValidarID(sender, e);
        }

        private void Txt_Password_Primera_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.ValidarPassword(sender, e);
        }

        private void Form_Desbloqueo_De_Usuario_Load(object sender, EventArgs e)
        {
            var blankContextMenu = new ContextMenuStrip();
            Txt_UserID.ContextMenuStrip = blankContextMenu;
            Txt_Password_Primera.ContextMenuStrip = blankContextMenu;
        }
    }
}
