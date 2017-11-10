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
            if (!Char.IsNumber(e.KeyChar) &&
               e.KeyChar != Convert.ToChar(Keys.Back))
            {
                MessageBox.Show("Ingreso de Datos Incorrectos, \n Ingrese un valor de [0-9]", "Error de Ingreso de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
            }
        }

        public void ValidarPassword(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar) &&
               e.KeyChar != Convert.ToChar(Keys.Back) && !Char.IsLetter(e.KeyChar)
               && e.KeyChar != Convert.ToChar('@'))
            {
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
    }

}
