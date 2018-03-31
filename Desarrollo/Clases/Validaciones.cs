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

        public void ValirLetrasYEspacios(object sender, KeyPressEventArgs e, TextBox Tex)
        {
            int a, b;
            a = Convert.ToInt16(Tex.Text.Count(Char.IsLetter));
            b = Convert.ToInt16(Tex.Text.Count(Char.IsWhiteSpace));
            if (a == 0 && !Char.IsLetter(e.KeyChar))
            { e.Handled = true; }
            if (!Char.IsLetter(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Back) && e.KeyChar != Convert.ToChar(Keys.Space))
            { e.Handled = true; }
            if (e.KeyChar == Convert.ToChar(Keys.Space) && a <= b && !Char.IsLetter(e.KeyChar))
            { e.Handled = true; }
            if (e.KeyChar == Convert.ToChar(Keys.Space) && b == 2 && !Char.IsLetter(e.KeyChar))
            { e.Handled = true; }

        }

        public void ValirLetrasYEspaciosMayorEspacio(object sender, KeyPressEventArgs e, TextBox Tex)
        {
            int a, b;
            a = Convert.ToInt16(Tex.Text.Count(Char.IsLetter));
            b = Convert.ToInt16(Tex.Text.Count(Char.IsWhiteSpace));
            if (a == 0 && !Char.IsLetter(e.KeyChar))
            { e.Handled = true; }
            if (!Char.IsLetter(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Back) && e.KeyChar != Convert.ToChar(Keys.Space))
            { e.Handled = true; }
            if (e.KeyChar == Convert.ToChar(Keys.Space) && a <= b && !Char.IsLetter(e.KeyChar))
            { e.Handled = true; }
            if (e.KeyChar == Convert.ToChar(Keys.Space) && b == 6 && !Char.IsLetter(e.KeyChar))
            { e.Handled = true; }

        }

        public void PrimeroMayuscula(object sender, KeyPressEventArgs e, TextBox Tex)
        {
            if (Tex.Text.Length == 0)
                e.KeyChar = e.KeyChar.ToString().ToUpper().ToCharArray()[0];
            else if (Tex.Text.Length > 0)
                e.KeyChar = e.KeyChar.ToString().ToLower().ToCharArray()[0];
        }


        public void ValirLetrasYEspacios_Direccion(object sender, KeyPressEventArgs e, TextBox Tex)
        {
            int a, b;
            a = Convert.ToInt16(Tex.Text.Count(Char.IsLetterOrDigit));
            b = Convert.ToInt16(Tex.Text.Count(Char.IsWhiteSpace));
            if (a == 0 && !Char.IsLetterOrDigit(e.KeyChar))
            { e.Handled = true; }
            if (!Char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Back) && e.KeyChar != Convert.ToChar(Keys.Space) && (e.KeyChar != '.') && (e.KeyChar != ','))
            { e.Handled = true; }
            if (e.KeyChar == Convert.ToChar(Keys.Space) && a <= b && !Char.IsLetterOrDigit(e.KeyChar))
            { e.Handled = true; }
            if (e.KeyChar == Convert.ToChar(Keys.Space) && b == 15 && !Char.IsLetter(e.KeyChar))
            { e.Handled = true; }
        }


        public Boolean Verificaremail(String email)
        {
            String expresion;
            expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(email, expresion))
            {
                if (Regex.Replace(email, expresion, String.Empty).Length == 0)
                { return true; }
                else
                { return false; }
            }
            else
            { return false; }
        }
        public void NumerosDecimalesImpuesto(object sender, KeyPressEventArgs e, TextBox Text_Prueba)
        {
            Text_Prueba.Text.ToArray();
            var chars = Text_Prueba.Text.ToCharArray();
            bool conf = false;
            int a = 0;
            int b = 0;


            for (int ctr = 0; ctr < chars.Length; ctr++)
            {
                if (Convert.ToString(chars[ctr]).Equals(".") == false)
                {
                    b = b + 1;
                }

                if (Convert.ToString(chars[ctr]).Equals(".") == true)
                {
                    conf = true;
                    b = 0;
                }

                if (conf == true)
                { a = a + 1; }
            }

            if (e.KeyChar == Convert.ToChar(Keys.Back))
            {
                e.Handled = false;
            }
            else
            if (char.IsDigit(e.KeyChar) && b == 2)
            {
                e.Handled = true;
            }
            else
            if (char.IsDigit(e.KeyChar) && a == 3)
            {
                e.Handled = true;
            }
            else
            if (char.IsDigit(e.KeyChar) && a != 3)
            {
                e.Handled = false;
            }
            else
             if ((e.KeyChar == '.') && (!Text_Prueba.Text.Contains(".")))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }



        public void ValidarID(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Back))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }


        public void NumerosDecimales(object sender, KeyPressEventArgs e, TextBox Text_Prueba)
        {
            Text_Prueba.Text.ToArray();
            var chars = Text_Prueba.Text.ToCharArray();
            bool conf = false;
            int a = 0;


            for (int ctr = 0; ctr < chars.Length; ctr++)
            {
                if (Convert.ToString(chars[ctr]).Equals(".") == true)
                {
                    conf = true;
                }

                if (conf == true)
                { a = a + 1; }
            }

            if (e.KeyChar == Convert.ToChar(Keys.Back))
            {
                e.Handled = false;
            }
            else
            if (char.IsDigit(e.KeyChar) && a == 3)
            {
                e.Handled = true;
            }
            else
            if (char.IsDigit(e.KeyChar) && a != 3)
            {
                e.Handled = false;
            }
            else
             if ((e.KeyChar == '.') && (!Text_Prueba.Text.Contains(".")))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        public void ExtraerFechaNacimientoPermitida(ComboBox Combo)
        {
            int años = 0;
            años = DateTime.Now.Year;
            for (int i = (años - 60); i < (años - 18); i++)
            {
                Combo.Items.Add(i);
            }
        }


        public string EncriptarContraseña(string laCadena)
        {
            SHA256CryptoServiceProvider elProveedor = new SHA256CryptoServiceProvider();
            byte[] vectoBytes = System.Text.Encoding.UTF8.GetBytes(laCadena);
            byte[] inArray = elProveedor.ComputeHash(vectoBytes);
            elProveedor.Clear();

            return Convert.ToBase64String(inArray);
        }



        public void ValidarPassword(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar) &&
               e.KeyChar != Convert.ToChar(Keys.Back) && !Char.IsLetter(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Enter)
               && e.KeyChar != Convert.ToChar('@'))
            {
                e.Handled = true;
            }
        }


        public void ValidarCorreoIngreso(object sender, KeyPressEventArgs e, TextBox TextT)
        {
            if (!Char.IsNumber(e.KeyChar) &&
               e.KeyChar != Convert.ToChar(Keys.Back) && !Char.IsLetter(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Enter)
               && e.KeyChar != Convert.ToChar('@') && e.KeyChar != Convert.ToChar('.'))
            {
                e.Handled = true;
            }
            else
            if (e.KeyChar == Convert.ToChar('@') && (TextT.Text.Contains("@")))
            {
                e.Handled = true;
            }

        }


        public void ValidarNombres_SoloLetras(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != Convert.ToChar(Keys.Back) && !Char.IsLetter(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Enter)
             && e.KeyChar != Convert.ToChar(Keys.Space))
            {

                e.Handled = true;
            }
        }


        public void ValidarNombres_LetrasYNumeros(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != Convert.ToChar(Keys.Back) && !Char.IsLetter(e.KeyChar) && !Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Enter))
            {
                e.Handled = true;
            }
        }

        private void ExtraerFechaAño(ComboBox Combo)
        {
            int años = 0;
            años = DateTime.Now.Year;
            for (int i = (años - 60); i < años; i++)
            {
                Combo.Items.Add(i);
            }
        }


        public void NumerosReales_NegativosOPositivos(object sender, KeyPressEventArgs e, TextBox Text_Prueba)
        {
            if (char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back))
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



        public void Fun_LLenarDias(ComboBox Año, ComboBox Mes, ComboBox dia)
        {

            if (Año.SelectedIndex == -1)
            {
                for (int i = 1; i < 32; i++)
                {
                    dia.Items.Add(i);
                }
            }
            else
            {
                int daias = System.DateTime.DaysInMonth(Convert.ToInt16(Año.SelectedItem), (Convert.ToInt16(Mes.SelectedIndex) + 1));

                for (int i = 1; i < (daias + 1); i++)
                {
                    dia.Items.Add(i);
                }
            }
        }



        public bool FechaInicio(DateTimePicker firt, DateTimePicker second)
        {
            if (second.Value.Date == firt.Value.Date)
            {
                return false;
            }
            else if (firt.Value.Date.Year <= (Convert.ToInt16(DateTime.Now.Year) - 50))
            {
                return false;
            }
            else if (second.Value.Date > DateTime.Now.Date)
            {
                return false;
            }
            else
            {
                return true;
            }
        }



        public void NoVacio(System.Windows.Forms.Form form1)
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
