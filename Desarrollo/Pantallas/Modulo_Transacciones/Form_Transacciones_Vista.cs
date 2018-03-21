using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Desarrollo.Clases;
using System.Data.SqlClient;
using Desarrollo.Pantallas.Modulo_Creditos;


namespace Desarrollo.Pantallas.Modulo_Transacciones
{
    public partial class Form_Transacciones_Vista : System.Windows.Forms.Form
    {
        Form_Creditos_CargarMora cargar = new Form_Creditos_CargarMora();
        C_Transacciones Tran = new C_Transacciones();

        public string Name;
        private string TipoTransaccion;
        private string Var_OptenerCodigoMora;


        public Form_Transacciones_Vista()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioTipos.Checked == true)
                cmbBxTipos.Enabled = true;
            else cmbBxTipos.Enabled = false;
        }

        private void Form_Transacciones_Vista_Load(object sender, EventArgs e)
        {
            Tran.Fun_ExtraerTransacciones(DGV_Transacciones);
            Tran.Fun_ExtraerEstados(cmbBxEstados);
            Tran.Fun_ExtraerTipoDoc(cmbBxTipoDoc);
            Tran.Fun_ExtraerTipoTrans(cmbBxTipos);
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            if (txtCodTrans.Text == string.Empty)
            {
                MessageBox.Show("Error: Seleccione una Transaccion", "Error de aplicacion de mora", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
                if (txtNumDoc.Text == string.Empty)
            {
                MessageBox.Show("Error: Este no es un documento Valido", "Error de aplicacion de mora", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (TipoTransaccion != "Credito")
            {
                MessageBox.Show("Debe selecionar una transaccion del tipo credito", "Error de aplicacion de mora", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

          
            cargar.NOMBRE = Name;
            cargar.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void cmbBxEstados_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(radioEstados.Checked == true)
                Tran.Fun_FiltrarEstado(DGV_Transacciones,Convert.ToInt16( cmbBxEstados.SelectedValue));

        }

        private void cmbBxTipos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(radioTipos.Checked == true)
                Tran.Fun_FiltrarTipoTrans(DGV_Transacciones, Convert.ToInt16(cmbBxTipos.SelectedValue));
        }

        private void cmbBxTipoDoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(radioTipoDoc.Checked == true)
                Tran.Fun_FiltrarTipoDoc(DGV_Transacciones, Convert.ToInt16(cmbBxTipoDoc.SelectedValue));
        }

        private void DGV_Transacciones_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectFila(e);
        }

        private void radioTodas_CheckedChanged(object sender, EventArgs e)
        {
            if (radioTodas.Checked == true)
                Tran.Fun_ExtraerTransacciones(DGV_Transacciones);

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            Tran.Fun_FiltarFechaVenc(DGV_Transacciones, DATE_FiltroFecha.Value.Date.ToString());
        }



        private void radioEstados_CheckedChanged(object sender, EventArgs e)
        {
            if (radioEstados.Checked == true)
                cmbBxEstados.Enabled = true;
            else cmbBxEstados.Enabled = false;
        }

        private void radioTipoDoc_CheckedChanged(object sender, EventArgs e)
        {
            if (radioTipoDoc.Checked == true)
                cmbBxTipoDoc.Enabled = true;
            else cmbBxTipoDoc.Enabled = false;
        }

        private void radioFechaVen_CheckedChanged(object sender, EventArgs e)
        {
            if (radioFechaVen.Checked == true)
                DATE_FiltroFecha.Enabled = true;
            else DATE_FiltroFecha.Enabled = false;
        }

        public void selectFila(DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.DGV_Transacciones.Rows[e.RowIndex];
                TipoTransaccion = row.Cells["Tipo de Transacción"].Value.ToString();
                if (TipoTransaccion != "Credito")
                {
                    MessageBox.Show("Debe selecionar una transaccion del tipo credito", "Error de aplicacion de mora", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }              
                txtCodTrans.Text = row.Cells["Código de Transacción"].Value.ToString();
                txtNumDoc.Text = row.Cells["No. de Documento"].Value.ToString();
                txtMonto.Text = row.Cells["Monto Total"].Value.ToString();               
                DATE_FechaTransaccion.Value = Convert.ToDateTime(row.Cells["Fecha de Realización"].Value.ToString());

                cargar.Txt_CodigoTransaccionMora.Text = row.Cells["Código de Transacción"].Value.ToString();
                cargar.Txt_NombreClientes.Text = row.Cells["Nombre del Cliente"].Value.ToString();
                cargar.Txt_MontoOriginal.Text = row.Cells["Monto Total"].Value.ToString();
                cargar.Txt_FechaRealizacionFactura.Text = row.Cells["Fecha de Realización"].Value.ToString();
                cargar.Txt_FechaVencimientoFactura.Text = row.Cells["Fecha de Vencimiento"].Value.ToString();
                cargar.Txt_NumeroFactura.Text = row.Cells["No. de Documento"].Value.ToString();
                cargar.Txt_PorcentajeMora.Text= row.Cells["Porcentaje de Mora"].Value.ToString();
                cargar.Txt_NombreEmpleado.Text = Name;
            }
        }
                
        
        private void limpiar()
        {
            txtCodTrans.Text = string.Empty;
            txtNumDoc.Text = string.Empty;
            txtNumDoc.Text = string.Empty;
        }

        private void DGV_Transacciones_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.DGV_Transacciones.Rows[e.RowIndex];
            TipoTransaccion = row.Cells["Tipo de Transacción"].Value.ToString();
            if (TipoTransaccion != "Credito" )
            {
                MessageBox.Show("Debe selecionar una transaccion del tipo credito", "Error de aplicacion de mora", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            txtCodTrans.Text = row.Cells["Código de Transacción"].Value.ToString();
            txtNumDoc.Text = row.Cells["No. de Documento"].Value.ToString();
            txtMonto.Text = row.Cells["Monto Total"].Value.ToString();     
           DATE_FechaTransaccion.Value= Convert.ToDateTime(row.Cells["Fecha de Realización"].Value.ToString());
          

            cargar.Txt_CodigoTransaccionMora.Text = row.Cells["Código de Transacción"].Value.ToString();
            cargar.Txt_NombreClientes.Text = row.Cells["Nombre del Cliente"].Value.ToString();
            cargar.Txt_MontoOriginal.Text = row.Cells["Monto Total"].Value.ToString();
            cargar.Txt_FechaRealizacionFactura.Text = row.Cells["Fecha de Realización"].Value.ToString();
            cargar.Txt_FechaVencimientoFactura.Text = row.Cells["Fecha de Vencimiento"].Value.ToString();
            cargar.Txt_NumeroFactura.Text = row.Cells["No. de Documento"].Value.ToString();
            cargar.Txt_PorcentajeMora.Text = row.Cells["Porcentaje de Mora"].Value.ToString();
            cargar.Txt_NombreEmpleado.Text = Name;
        }

        private void txtCodTrans_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Tran.Fun_ExtraerTransacciones(DGV_Transacciones);
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void DGV_Transacciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DATE_FechaTransaccion_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
