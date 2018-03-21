using Desarrollo.Clases;
using Desarrollo.Pantallas.Manueales;
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

namespace Desarrollo.Pantallas.Modulo_Creditos
{
    public partial class Form_Credito_CobroCredito : System.Windows.Forms.Form
    {
        C_Credito Cl_Credito = new C_Credito();
        Validaciones CL_Valid = new Validaciones();
        Form_Creditos_CargarMora CL_Mora = new Form_Creditos_CargarMora();
        private string LCr_TipoTransaccion;
        private string LCr_EstadoTransacion;

        public Form_Credito_CobroCredito()
        {
            InitializeComponent();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form_VistaManualPDF Manual = new Form_VistaManualPDF();
            Manual.PDF_Local.src = (Application.StartupPath + @"\ManualesHTML\Manual del Gerente.pdf");
            Manual.ShowDialog();
        }

        private void Form_Credito_CobroCredito_Load(object sender, EventArgs e)
        {
            Cl_Credito.Fun_MostrarTiposPago(Pest1_ComBox_MetodoPago);
            Pest2_Radio_Todos.Checked = true;

            var blankContextMenu = new ContextMenuStrip();
            Pest1_Txt_Filtro.ContextMenuStrip = blankContextMenu;
            Pest1_Txt_MontAPagar.ContextMenuStrip = blankContextMenu;
            Pest2_Txt_FiltroNombre.ContextMenuStrip = blankContextMenu;
        }

        private void Bttn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Fun_Limpiar()
        {
            errorProvider1.SetError(Pest1_Txt_NTransacion, "");
            errorProvider1.SetError(Pest1_Txt_NFactura, "");
            errorProvider1.SetError(Pest1_Txt_MontoOriginal, "");
            errorProvider1.SetError(Pest1_Txt_MontoResidual, "");
            errorProvider1.SetError(Pest1_Txt_MontAPagar, "");
            Pest1_Txt_MontAPagar.Text = string.Empty;
            Pest1_Txt_NTransacion.Text = string.Empty;
            Pest1_Txt_NFactura.Text = string.Empty;
            Pest1_Txt_MontoOriginal.Text = string.Empty;
            Pest1_Txt_MontoResidual.Text = string.Empty;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Fun_Limpiar();
        }

        private void Pest1_Txt_Filtro_KeyPress(object sender, KeyPressEventArgs e)
        {
            CL_Valid.ValidarNombres_LetrasYNumeros(sender, e);
        }

        private void Pest1_Txt_Filtro_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Pest1_Txt_Filtro.Text)==true)
            {

                return;
            }           
            Cl_Credito.Var_filtrocliente = Pest1_Txt_Filtro.Text;
            Cl_Credito.Fun_MostrarCliente(Pest1_ComBox_MuestDatos);

            if (Pest1_ComBox_MuestDatos.SelectedIndex == -1)
            {
                Pest1_DGV_DatosFactura.DataSource = null;
                Pest1_DGV_DatosFactura.Refresh();
            }
            Fun_Limpiar();
        }

        private void Pest1_ComBox_MuestDatos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Pest1_ComBox_MuestDatos.SelectedIndex == -1)
            {
                Pest1_DGV_DatosFactura.DataSource = null;
                Pest1_DGV_DatosFactura.Refresh();

                return;
            }
            Cl_Credito.Var_filtro_cod_client = (int) Convert.ToDouble(Pest1_ComBox_MuestDatos.SelectedValue);
            Cl_Credito.Fun_MostrarCreditos(Pest1_DGV_DatosFactura);
            Fun_Limpiar();

        }

        private void Pest1_Txt_MontAPagar_KeyPress(object sender, KeyPressEventArgs e)
        {
            CL_Valid.NumerosDecimales(sender, e, Pest1_Txt_MontAPagar);
        }

        private void Pest1_Bttn_RealizarPag_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Pest1_Txt_NTransacion.Text) )
            {
                errorProvider1.SetError(Pest1_Txt_NTransacion, "Debe selecionar una factura");
                errorProvider1.SetError(Pest1_Txt_NFactura, "Debe selecionar una factura");
                errorProvider1.SetError(Pest1_Txt_MontoOriginal, "Debe selecionar una factura");
                errorProvider1.SetError(Pest1_Txt_MontoResidual, "Debe selecionar una factura");
                return;
            }
            else
            {
                errorProvider1.SetError(Pest1_Txt_NTransacion, "");
                errorProvider1.SetError(Pest1_Txt_NFactura, "");
                errorProvider1.SetError(Pest1_Txt_MontoOriginal, "");
                errorProvider1.SetError(Pest1_Txt_MontoResidual, "");
            }

            if (string.IsNullOrEmpty(Pest1_Txt_MontAPagar.Text))
            {
                errorProvider1.SetError(Pest1_Txt_MontAPagar, "Debe ingresar el monto a pagar");
                return;
            }
            else
            {
                errorProvider1.SetError(Pest1_Txt_MontAPagar, "");
            }

            

            Cl_Credito.Var_aumento_saldo_credit = (float)Convert.ToDecimal(Pest1_Txt_MontAPagar.Text);
            Cl_Credito.Var_resid_actual= (float)Convert.ToDecimal(Pest1_Txt_MontoResidual.Text) - (float)Convert.ToDecimal(Pest1_Txt_MontAPagar.Text);
            Cl_Credito.Var_numero_documento = (int) Convert.ToDouble(Pest1_Txt_NFactura.Text);
            Cl_Credito.Var_cod_transaccion = Convert.ToInt32(Pest1_Txt_NTransacion.Text);
            Cl_Credito.Var_cod_accion = Convert.ToInt32(Pest1_ComBox_MetodoPago.SelectedValue);
            

            if (Cl_Credito.Var_resid_actual < 0)
            {
                errorProvider1.SetError(Pest1_Bttn_RealizarPag, "El monto a pagar no puede ser mayor al monto de la factura");
                return;
            } else
            {
                errorProvider1.SetError(Pest1_Bttn_RealizarPag, "");
            }


            if (Cl_Credito.Var_resid_actual==0)
            {
                Cl_Credito.Fun_UpdateEstadoTransaccion();
            }

            Cl_Credito.Fun_UpdateTransaccionValRes();
            Cl_Credito.Fun_UpdateSaldoCredit();
            Cl_Credito.Fun_InsertarDetalles();
            Cl_Credito.Var_filtro_cod_client = (int)Convert.ToDouble(Pest1_ComBox_MuestDatos.SelectedValue);
            Cl_Credito.Fun_MostrarCreditos(Pest1_DGV_DatosFactura);

            Fun_Limpiar();
            MessageBox.Show("Se realizo el pago exitosamente", "Mensaje de confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void Pest1_DGV_DatosFactura_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = this.Pest1_DGV_DatosFactura.Rows[e.RowIndex];
                Pest1_Txt_NTransacion.Text = row.Cells["Codigo"].Value.ToString();
                Pest1_Txt_NFactura.Text = row.Cells["No. de Factura"].Value.ToString();
                Pest1_Txt_MontoOriginal.Text = row.Cells["Monto Original"].Value.ToString();
                Pest1_Txt_MontoResidual.Text = row.Cells["Monto Actual"].Value.ToString();
            }
            catch (Exception) { }
        }

        private void Pest1_DGV_DatosFactura_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = this.Pest1_DGV_DatosFactura.Rows[e.RowIndex];
                Pest1_Txt_NTransacion.Text = row.Cells["Codigo"].Value.ToString();
                Pest1_Txt_NFactura.Text = row.Cells["No. de Factura"].Value.ToString();
                Pest1_Txt_MontoOriginal.Text = row.Cells["Monto Original"].Value.ToString();
                Pest1_Txt_MontoResidual.Text = row.Cells["Monto Actual"].Value.ToString();
            }
            catch (Exception) { }
        }

        private void DVG_MuesCredito_Click(object sender, EventArgs e)
        {
           
        }

        private void Pest2_Radio_FilPorClie_CheckedChanged(object sender, EventArgs e)
        {
            if (Pest2_Radio_FilPorClie.Checked==true) {
                Pest2_Grupo_Cliente.Enabled = true; }
        }

        private void Pest2_Radio_Todos_CheckedChanged(object sender, EventArgs e)
        {
            if (Pest2_Radio_Todos.Checked == true)
            {
                Pest2_Grupo_Cliente.Enabled = false;
                Cl_Credito.Fun_ExtraerTransacciones(Pest2_DGV_MuestraDatos);
            }
        }

        private void Bttn_LimpiarTodo_Click(object sender, EventArgs e)
        {
            Fun_Limpiar();
            Pest1_Txt_Filtro.Clear();
            Pest1_ComBox_MuestDatos.SelectedIndex = -1;
        }

        private void Bttn_MuestraClientes_Click(object sender, EventArgs e)
        {
            Form_ManejoClientes Cli = new Form_ManejoClientes();
            Cli.ShowDialog();
        }

        private void Pest2_Grupo_Cliente_Enter(object sender, EventArgs e)
        {

        }

        private void Pest2_Txt_FiltroNombre_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Pest2_Txt_FiltroNombre.Text) == true)
            {
                Pest2_ComBo_Muestra.SelectedIndex = -1;
                return;
            }

            Cl_Credito.Var_filtrocliente = Pest2_Txt_FiltroNombre.Text;
            Cl_Credito.Fun_MostrarCliente(Pest2_ComBo_Muestra);

            if (Pest2_ComBo_Muestra.SelectedIndex == -1)
            {
                Pest2_DGV_MuestraDatos.DataSource = null;
                Pest2_DGV_MuestraDatos.Refresh();
            }
            
        }

        private void Pest2_ComBo_Muestra_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cl_Credito.Var_clien_trans_gener = Pest2_Txt_FiltroNombre.Text;

            if (Pest2_ComBo_Muestra.SelectedIndex == -1)
            {
                Pest2_DGV_MuestraDatos.DataSource = null;
                Pest2_DGV_MuestraDatos.Refresh();
                return;
            }
            Cl_Credito.Fun_ExtraerTransaccionesClientes(Pest2_DGV_MuestraDatos);
        }

        private void Pest2_Grupo_Muestra_Enter(object sender, EventArgs e)
        {

        }

        private void Pest2_DGV_MuestraDatos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try{

                DataGridViewRow row = this.Pest2_DGV_MuestraDatos.Rows[e.RowIndex];
                LCr_TipoTransaccion = row.Cells["Tipo de Transacción"].Value.ToString();
                LCr_EstadoTransacion = row.Cells["Estados"].Value.ToString();

                if (LCr_EstadoTransacion == "Transaccion Pagada")
                {
                    Pest2_Bttn_AplicarMora.Enabled = false;
                } else
                {
                    Pest2_Bttn_AplicarMora.Enabled = true;
                }
                Pest2_Cod_Trans.Text = row.Cells["Código de Transacción"].Value.ToString();

                CL_Mora.Txt_CodigoTransaccionMora.Text = row.Cells["Código de Transacción"].Value.ToString();
                CL_Mora.Txt_NombreClientes.Text = row.Cells["Nombre del Cliente"].Value.ToString();
                CL_Mora.Txt_MontoOriginal.Text = row.Cells["Monto Total"].Value.ToString();
                CL_Mora.Txt_FechaRealizacionFactura.Text = row.Cells["Fecha de Realización"].Value.ToString();
                CL_Mora.Txt_FechaVencimientoFactura.Text = row.Cells["Fecha de Vencimiento"].Value.ToString();
                CL_Mora.Txt_NumeroFactura.Text = row.Cells["No. de Documento"].Value.ToString();
                CL_Mora.Txt_PorcentajeMora.Text = row.Cells["Porcentaje de Mora"].Value.ToString();
                CL_Mora.Txt_NombreEmpleado.Text = Pest1_Txt_NombreEmpleado.Text;
                CL_Mora.Txt_TotalMorasAplica.Text = "0";
            }
            catch { }
        }

        private void Pest2_DGV_MuestraDatos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try { 

            DataGridViewRow row = this.Pest2_DGV_MuestraDatos.Rows[e.RowIndex];
            LCr_TipoTransaccion = row.Cells["Tipo de Transacción"].Value.ToString();
            LCr_EstadoTransacion = row.Cells["Estados"].Value.ToString();

            if (LCr_EstadoTransacion == "Transaccion Pagada")
            {
                Pest2_Bttn_AplicarMora.Enabled = false;
            }
            else
            {
                Pest2_Bttn_AplicarMora.Enabled = true;
            }
            Pest2_Cod_Trans.Text = row.Cells["Código de Transacción"].Value.ToString();

            CL_Mora.Txt_CodigoTransaccionMora.Text = row.Cells["Código de Transacción"].Value.ToString();
            CL_Mora.Txt_NombreClientes.Text = row.Cells["Nombre del Cliente"].Value.ToString();
            CL_Mora.Txt_MontoOriginal.Text = row.Cells["Monto Total"].Value.ToString();
            CL_Mora.Txt_FechaRealizacionFactura.Text = row.Cells["Fecha de Realización"].Value.ToString();
            CL_Mora.Txt_FechaVencimientoFactura.Text = row.Cells["Fecha de Vencimiento"].Value.ToString();
            CL_Mora.Txt_NumeroFactura.Text = row.Cells["No. de Documento"].Value.ToString();
            CL_Mora.Txt_PorcentajeMora.Text = row.Cells["Porcentaje de Mora"].Value.ToString();
            CL_Mora.Txt_NombreEmpleado.Text = Pest1_Txt_NombreEmpleado.Text;
                CL_Mora.Txt_TotalMorasAplica.Text = "0";
            }
            catch { }
        }

        private void Pest2_Bttn_AplicarMora_Click(object sender, EventArgs e)
        {
            CL_Mora.ShowDialog();
            if (Pest2_Radio_FilPorClie.Checked == true)
            {
                Cl_Credito.Fun_ExtraerTransaccionesClientes(Pest2_DGV_MuestraDatos);
            }else
            {
                Cl_Credito.Fun_ExtraerTransacciones(Pest2_DGV_MuestraDatos);
            }

        }

        private void Pest2_Txt_FiltroNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            CL_Valid.ValidarNombres_LetrasYNumeros(sender, e);
        }

        private void Pest2_Bttn_VerDetalle_Click(object sender, EventArgs e)
        {
            Form_Muestra_Detalles Detalles = new Form_Muestra_Detalles();
            Detalles.LDt_CodTran = Convert.ToInt32(Pest2_Cod_Trans.Text);
            Detalles.ShowDialog();
        }
    }
}
