using Desarrollo.Clases;
using Desarrollo.Pantallas.Modulo_Ventas_Nuevas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desarrollo.Pantallas.Modulo_Ventas_Manejo
{
    public partial class Form_DefinirMetodoDePago : System.Windows.Forms.Form
    {
        N_Ventas V = new N_Ventas();
        Validaciones Va = new Validaciones();

        public int CodigoCliente;
        public double Monto_Credito;
        public double Total;
        string Monto;

        public Form_DefinirMetodoDePago()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Monto = "";

            if (Pest1_DadoCliente.Text==string.Empty) { Pest1_DadoCliente.Text = "0"; }
            if (textBox5.Text == string.Empty) { textBox5.Text = "0"; }
            if (textBox8.Text == string.Empty) { textBox8.Text = "0"; }

            string Total_Efectivo, Total_Credito, Total_Tarjeta;
            Total_Efectivo =Convert.ToString( Convert.ToDouble(Pest1_DadoCliente.Text) - Convert.ToDouble(Pest1_Cambio.Text));
            Total_Tarjeta = Convert.ToString(Convert.ToDouble(textBox5.Text));
            Total_Credito = Convert.ToString(Convert.ToDouble(textBox8.Text));

            if(Convert.ToDouble(textBox6.Text)< Convert.ToDouble(textBox8.Text)){
                MessageBox.Show("El cliente no cuenta con suficiente credito","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            if (Convert.ToDouble(Total) < (Convert.ToDouble(Total_Efectivo) + Convert.ToDouble(Total_Credito) + Convert.ToDouble(Total_Tarjeta))  || 
                Convert.ToDouble(Total) > (Convert.ToDouble(Total_Efectivo) + Convert.ToDouble(Total_Credito) + Convert.ToDouble(Total_Tarjeta)))
            {
                float LoclVar_Total = (float)(Convert.ToDouble(Total) - (Convert.ToDouble(Total_Efectivo) + Convert.ToDouble(Total_Credito) + Convert.ToDouble(Total_Tarjeta)));
                if (LoclVar_Total >= 1)
                {
                    MessageBox.Show("El Total a Pagar por el cliente es muy poco o excede lo Permitido", "Error de Registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                
                
            }


            Form_Ventas_Nuevas Marcos = Owner as Form_Ventas_Nuevas;
            Marcos.Var_ConfirmarMetodoDePago = true;
            Marcos.Var_TotalAPagarCredito= Convert.ToDouble(textBox8.Text);
            Marcos.Var_TotalAPagarEfectivo = Convert.ToDouble(Pest1_DadoCliente.Text);
            Marcos.Var_TotalAPagarEfectivoCambio = Convert.ToDouble(Pest1_Cambio.Text);
            Marcos.Var_TotalAPagarTarjeta = Convert.ToDouble(textBox5.Text);
            this.Close();


        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void Form_DefinirMetodoDePago_Load(object sender, EventArgs e)
        {
            var blankContextMenu = new ContextMenuStrip();
            Pest1_DadoCliente.ContextMenuStrip = blankContextMenu;
            textBox5.ContextMenuStrip = blankContextMenu;
            textBox8.ContextMenuStrip = blankContextMenu;


            Monto_Credito = V.Var_OptenerCredito(CodigoCliente);

            
            if (Monto_Credito == 0)
            {
                textBox8.Enabled = false;
            }
            else
            {
                textBox8.Enabled = true;
                textBox6.Text = Convert.ToString(Monto_Credito);
            }


            Pest1_TotalAPagar.Text = Convert.ToString(Total); 
            textBox4.Text = Convert.ToString(Total); 
            Pest3_Txt_MontoTotal.Text = Convert.ToString(Total);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string Cambio;
            if (Pest1_DadoCliente.Text==string.Empty)
            {
                Cambio = "0";
                return;
            }

            Cambio = Convert.ToString((float)Convert.ToDouble(Pest1_DadoCliente.Text) - (float)Convert.ToDouble(Pest1_TotalAPagar.Text));

            

            if ((float)Convert.ToDouble(Cambio) < 0)
            {
                Cambio = "0";
            }

            Pest1_Cambio.Text = Convert.ToString(Cambio);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Va.NumerosDecimales(sender,e, Pest1_DadoCliente);
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            Va.NumerosDecimales(sender, e, textBox5);
        }

        private void textBox8_KeyPress(object sender, KeyPressEventArgs e)
        {
            Va.NumerosDecimales(sender, e, textBox8);
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        
        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            Fun_Sumatoria();
        }

        private void Fun_Sumatoria()
        {
            if (textBox8.Text==string.Empty) { textBox8.Text = "0"; }

            if (textBox5.Text==string.Empty) { textBox5.Text = "0"; }

            Monto =Convert.ToString( Convert.ToDouble(Total) - (Convert.ToDouble(textBox8.Text) + Convert.ToDouble(textBox5.Text)));
            Pest1_TotalAPagar.Text = Convert.ToString(Monto);
            textBox4.Text = Convert.ToString(Monto);
            Pest3_Txt_MontoTotal.Text = Convert.ToString(Monto);


        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            Fun_Sumatoria();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
