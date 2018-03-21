using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Desarrollo.Clases;
using Desarrollo.Pantallas.Modulo_Transacciones;
using Desarrollo.Pantallas.Modulo__Ingreso_al_sistema;

namespace Desarrollo.Pantallas.Modulo_Creditos
{
    public partial class Form_Creditos_CargarMora : System.Windows.Forms.Form
    {
        public int cod;
        public string NOMBRE;

        private float LMora_PorcentajeMora;
        

        C_Mora mo = new C_Mora();
        Form_Ingreso_Al_Sistema emp = new Form_Ingreso_Al_Sistema();

        public Form_Creditos_CargarMora()
        {
            InitializeComponent();
            
        }

        


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Bttn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form_Creditos_CargarMora_Load(object sender, EventArgs e)
        {
            LMora_PorcentajeMora= mo.Fun_ExtraerSatosUtiles(Txt_MontoActual, Convert.ToInt16(Txt_CodigoTransaccionMora.Text));
            Txt_TotalAProporcional.Text = Convert.ToString( Convert.ToDecimal(Txt_MontoActual.Text) * Convert.ToDecimal(LMora_PorcentajeMora));            
            Txt_MontoNuevo.Text = Convert.ToString( Convert.ToDecimal(Txt_MontoActual.Text)  + Convert.ToDecimal(Txt_TotalAProporcional.Text));


            mo.Var_CodTran = Txt_CodigoTransaccionMora.Text;
            mo.Var_CodDocumt = Txt_NumeroFactura.Text;

            if (mo.Fun_VerExisDetalles() == true)
            {
                mo.Fun_MosNumDetalles(Txt_TotalMorasAplica);
                DATE_FechaUltimaMora.Value= Convert.ToDateTime(mo.Fun_MosFechDetalles());
            }
            else
            {

            }


        }

   

        private void Text_Fecha_Mora_TextChanged(object sender, EventArgs e)
        {
            
            
            
        }

        private void Txt_TotalAAplicar_TextChanged(object sender, EventArgs e)
        {
           
        }


        private void Fun_VerificarFechasMora(DateTime FV_FechaActual, DateTime FV_FechaComp)
        {
            TimeSpan L_TimeActual = FV_FechaActual - FV_FechaComp;
            int L_DiferenciaDia = L_TimeActual.Days;

            if (L_DiferenciaDia >= 30)
            {
                mo.Var_MontoTotal= (float)Convert.ToDouble(Txt_TotalAProporcional.Text);
                mo.Var_ValorRes= (float) Convert.ToDouble(Txt_MontoNuevo.Text);
                mo.Fun_UpdateCreditoCliente();
                mo.Fun_UpdateTran();
                mo.Fun_InsertarDetalles();
                mo.Fun_UpdateTransacciones((int)Convert.ToDouble(Txt_NumeroFactura.Text));
                MessageBox.Show("La operacion se realizo exitosamente", "Mensaje de confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            }
            else
            {
                MessageBox.Show("El limite de tiempo de 30 dias no ha pasado", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Fun_VerificarFechas(DateTime FV_FechaActual, DateTime FV_FechaComp)
        {
            TimeSpan L_TimeActual = FV_FechaActual - FV_FechaComp;
            int L_DiferenciaDia = L_TimeActual.Days;

            if (L_DiferenciaDia >= 0)
            {
                mo.Var_MontoTotal = (float)Convert.ToDouble(Txt_TotalAProporcional.Text);
                mo.Var_ValorRes = (float)Convert.ToDouble(Txt_MontoNuevo.Text);
                mo.Fun_UpdateCreditoCliente();
                mo.Fun_UpdateTran();
                mo.Fun_InsertarDetalles();
                mo.Fun_UpdateTransacciones((int)Convert.ToDouble(Txt_NumeroFactura.Text));
                MessageBox.Show("La operacion se realizo exitosamente", "Mensaje de confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                MessageBox.Show("El limite de tiempo no ha pasado", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void Bttn_Guardar_Click(object sender, EventArgs e)
        {
            if (Txt_TotalMorasAplica.Text == "0")
            {
                Fun_VerificarFechas(DATE_FechaActual.Value, Convert.ToDateTime(Txt_FechaVencimientoFactura.Text));
            }
            else
            {
                Fun_VerificarFechasMora(DATE_FechaActual.Value, DATE_FechaUltimaMora.Value);
            }

            this.Close();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
