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

namespace Desarrollo.Pantallas.Modulo_Ventas_Manejo.Modulo_ArqueodeCaja
{
    public partial class Form_PantallCierreConfirmacion : System.Windows.Forms.Form
    {
        Validaciones Val = new Validaciones();
        N_Ventas Ven = new N_Ventas();

        public string Var_TotTrg, Var_TotCaj, Var_TotCrd, Var_ConVenDia, Cod_Usuario;

        private void Text_TotalEfectivoCaja_KeyPress(object sender, KeyPressEventArgs e)
        {
            Val.NumerosDecimales(sender, e, Text_TotalEfectivoCaja);
        }

        private void Bttn_Aceptar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Text_TotalEfectivoCaja.Text))
            {
                errorProvider1.SetError(Text_TotalEfectivoCaja, "Debe ingresar el total de efectivo en caja");
                return;
            }else
            {
                errorProvider1.SetError(Text_TotalEfectivoCaja, "");
            }


            if (string.IsNullOrEmpty(Txt_COntraseñaCOnfirmacion.Text))
            {
                errorProvider1.SetError(Txt_COntraseñaCOnfirmacion, "Debe ingresar su contraseña");
                return;
            }else
            {
                errorProvider1.SetError(Txt_COntraseñaCOnfirmacion, "");
            }


            if(Ven.Fun_ComprobarUsuarioYContraseña(Cod_Usuario, Val.EncriptarContraseña(Txt_COntraseñaCOnfirmacion.Text))== true){
                    if (string.IsNullOrEmpty(Txt_TotalCredito.Text))
                    {
                            Txt_TotalCredito.Text = "0";
                    }

                if (string.IsNullOrEmpty(Text_TotalEfectivoVenta.Text)) { Text_TotalEfectivoVenta.Text = "0"; }

                if (string.IsNullOrEmpty(Txt_TotalTarjeta.Text)) { Txt_TotalTarjeta.Text = "0"; }

                    Ven.Fun_ActuaizacionYCierreCaja(
                    (float)Convert.ToDouble(Txt_TotalCredito.Text), (float)Convert.ToDouble(Text_TotalEfectivoVenta.Text),
                    (float)Convert.ToDouble(Txt_TotalTarjeta.Text), (float)Convert.ToDouble(Text_TotalEfectivoCaja.Text), Convert.ToInt16(Cod_Usuario));

                     MessageBox.Show("Se ha cerrado la caja correctamente", "Cierre de Caja", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                     Application.Exit();
            }
            else
            {
                     MessageBox.Show("Contraseña incorrectar", "Error de Autenticación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                     
            }


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Txt_COntraseñaCOnfirmacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            Val.ValidarPassword(sender, e);
        }

        public Form_PantallCierreConfirmacion()
        {
            InitializeComponent();
        }

        private void Form_PantallCierreConfirmacion_Load(object sender, EventArgs e)
        {
            var blankContextMenu = new ContextMenuStrip();
            Txt_COntraseñaCOnfirmacion.ContextMenuStrip = blankContextMenu;
            Text_TotalEfectivoCaja.ContextMenuStrip = blankContextMenu;


            Text_TotalEfectivoVenta.Text = Var_TotCaj;
            Txt_TotalTarjeta.Text = Var_TotTrg;
            Txt_TotalCredito.Text = Var_TotCrd;
        }

        private void Bttn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
