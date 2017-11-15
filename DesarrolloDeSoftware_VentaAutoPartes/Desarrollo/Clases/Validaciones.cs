using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace Desarrollo.Clases
{
    class Validaciones
    {

        private Boolean Verificaremail(String email)
        {
            String expresion;
            expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(email, expresion))
            {  if (Regex.Replace(email, expresion, String.Empty).Length == 0)
                {  return true; }
                else
                { return false; }
            }
            else
            {return false;}
        }


        private void ValidacionTelefono(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar) &&
               e.KeyChar != Convert.ToChar(Keys.Back))
            {
                e.Handled = true;
            }
        }


        public void ValidarID(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Back))
            {
              MessageBox.Show("Ingreso de Datos Incorrectos, \n Ingrese un valor de [0-9]", "Error de Ingreso de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
            } else {
                e.Handled = false;
            }
        }

        public void ValidarPassword(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar) &&
               e.KeyChar != Convert.ToChar(Keys.Back) && !Char.IsLetter(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Enter)
               && e.KeyChar != Convert.ToChar('@'))
            {
                MessageBox.Show("Ingreso de Datos Incorrectos, \n Ingrese un valor de [0-9][A-Z] o Un @", "Error de Ingreso de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);

                e.Handled = true;
            }
        }


        public  string EncriptarContraseña(string laCadena)
        {
            SHA256CryptoServiceProvider elProveedor = new SHA256CryptoServiceProvider();
            byte[] vectoBytes = System.Text.Encoding.UTF8.GetBytes(laCadena);
            byte[] inArray = elProveedor.ComputeHash(vectoBytes);
            elProveedor.Clear();

            return Convert.ToBase64String(inArray);
        }

        public void Solonumero(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }


        public void SoloDecimales(char ch, string txt, KeyPressEventArgs e)
        {

            bool esDec = false;

            for (int i = 0; i < txt.Length; i++)
            {
                if (txt[i] == '.')
                    esDec = true;
            }

            if (Char.IsDigit(ch))
                e.Handled = false;

            else if (ch == 46 || ch == 8)
                e.Handled = (esDec) ? true : false;
            else e.Handled = true;

            if (ch == 8)
            {
                e.Handled = false;
            }
        }


        public void NumerosDecimales_202(object sender, KeyPressEventArgs e, TextBox Text_Prueba)
        {
            if (char.IsLetter(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back))
            {
                e.Handled = false;
            }
            else if((e.KeyChar == '.') && (!Text_Prueba.Text.Contains(".")))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        public void NumerosReales(object sender, KeyPressEventArgs e, TextBox Text_Prueba)
        {
            if (char.IsLetter(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back))
            {
                e.Handled = false;
            }
            else if ((e.KeyChar == '-') && (!Text_Prueba.Text.Contains("-")))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }




        public void SoloLetras(KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }


        public void SoloNumeros(KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }


        public void NoVacio(Form form1)
        {
            bool txtCompletado = true;
            string MensajeError = "Uno o más textbox estan vacíos";
            foreach (Control c in form1.Controls)
            {
                if (c is TextBox && ((TextBox)c).Enabled == true)//Si es un textbox y esta vacío
                {
                    if (String.IsNullOrEmpty(c.Text))
                    {
                        txtCompletado = false;
                        c.Focus();
                        MessageBox.Show(MensajeError, "Error");
                        break;
                    }
                }
            }
        }
    }

}
