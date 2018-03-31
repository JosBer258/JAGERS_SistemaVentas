using Desarrollo.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desarrollo.Pantallas.Modulo_Ventas_Manejo
{
    public partial class Form_MantenimientoImpuestos : Form
    {
        
        public Form_MantenimientoImpuestos()
        {
            InitializeComponent();
             
        }
        Validaciones Val = new Validaciones();
        C_Impuesto impuesto = new C_Impuesto();
        private void Form_MantenimientoImpuestos_Load(object sender, EventArgs e)
        {
            RadioB_ModificarImpuesto.Checked = true;
            
                var blankContextMenu = new ContextMenuStrip();
                txt_ValorImpuestoActual.ContextMenuStrip = blankContextMenu;
                txt_Porcentaje.ContextMenuStrip = blankContextMenu;

                impuesto.Fun_ExtraerEstados(comboBoxEstado);
                txt_CodigoNuevoImp.Enabled = false;
                date_FechaIngreso.Enabled = false;
                txt_ValorImpuestoActual.Enabled = false;
                btn_Ingresar.Enabled = false;
                txt_CodigoModificarImp.Enabled = false;
                date_FechaIngresoImp.Enabled = true;
                txt_Porcentaje.Enabled = true;
                comboBoxEstado.Enabled = true;
                btn_Aceptar.Enabled = true;

           
            Fecha_Inicial.MinDate = Convert.ToDateTime( impuesto.ObtenerFechaDisponible());

            date_FechaIngresoImp.MinDate = date_FechaIngresoImp.Value;
            //Fecha_Inicial.MinDate = Fecha_Inicial.Value;

            string Fecha_R = String.Format("{0:yyyy-MM-dd}", date_FechaIngreso.Value);
                impuesto.VerificarImpuestosNuevos(Fecha_R);
                impuesto.Fun_CargarDataGriewEstado3(dataGridView1);
            

            
        }
        private void btn_Ingresar_Click(object sender, EventArgs e)
        {
            

            if (txt_ValorImpuestoActual.Text == String.Empty || Convert.ToDouble(txt_ValorImpuestoActual.Text) <= 0)
                MessageBox.Show("El porcentaje del impuesto no puede ir vacio");
            else
            {
                if (Convert.ToString(date_FechaIngreso.Value) == Convert.ToString(Fecha_Inicial.Value))
                {
                    errorProvider1.SetError(btn_Ingresar, "La fecha de ingreso del impuesto y su fecha de inicio no pueden ser la misma");
                    return;
                }
                else
                {
                    errorProvider1.SetError(btn_Ingresar, "");
                }



                impuesto.Var_Codigo_impuesto = Convert.ToInt16(txt_CodigoNuevoImp.Text);
                impuesto.Var_Porcentaje_Impuesto = (float.Parse(txt_ValorImpuestoActual.Text) / 100);
                impuesto.Var_Codigo_estado = 3;
                impuesto.Var_Fecha_ingreso = String.Format("{0:yyyy-MM-dd}", date_FechaIngreso.Value);
                impuesto.Var_Fecha_inicial = String.Format("{0:yyyy-MM-dd}", Fecha_Inicial.Value);

                impuesto.VerificarFechaInicio();

                

                impuesto.Fun_CargarPrimerDataGriew(dataGridView1);

                txt_ValorImpuestoActual.Clear();
                txt_CodigoNuevoImp.Text=impuesto.Fun_ExtraerCodigoImpuesto();

                Fecha_Inicial.MinDate = Convert.ToDateTime(impuesto.ObtenerFechaDisponible());

            }

        }
      
        private void txt_ValorImpuestoActual_KeyPress(object sender, KeyPressEventArgs e)
        {
            Val.NumerosDecimalesImpuesto(sender, e, txt_ValorImpuestoActual);
        }

        private void RadioB_AgregarImpuesto_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioB_AgregarImpuesto.Checked ==  true)
            {
                txt_CodigoNuevoImp.Text = impuesto.Fun_ExtraerCodigoImpuesto();
                txt_ValorImpuestoActual.Enabled = true;
                btn_Ingresar.Enabled = true;

                txt_CodigoModificarImp.Enabled = false;
                txt_CodigoModificarImp.Clear();
                date_FechaIngresoImp.Enabled = false;
                txt_Porcentaje.Enabled = false;
                txt_Porcentaje.Clear();
                comboBoxEstado.Enabled = false;
                btn_Aceptar.Enabled = false;

                

                txt_ValorImpuestoActual.Focus();
                dataGridView1.Enabled = true;
                Fecha_Inicial.MinDate = Convert.ToDateTime(impuesto.ObtenerFechaDisponible());
                impuesto.Fun_CargarPrimerDataGriew(dataGridView1);
                
            }
        }

        private void RadioB_ModificarImpuesto_CheckedChanged(object sender, EventArgs e)
        {
            if(RadioB_ModificarImpuesto.Checked == true)
            {
                txt_CodigoNuevoImp.Enabled = false;
                txt_CodigoNuevoImp.Clear();
                date_FechaIngreso.Enabled = false;
                txt_ValorImpuestoActual.Enabled = false;
                txt_ValorImpuestoActual.Clear();
                btn_Ingresar.Enabled = false;

                txt_Porcentaje.Enabled = true;
                date_FechaIngresoImp.Enabled = true;
                comboBoxEstado.Enabled = true;
                btn_Aceptar.Enabled = true;
                dataGridView1.Enabled = true;
                Fecha_Inicial.MinDate = Convert.ToDateTime(impuesto.ObtenerFechaDisponible());
                impuesto.Fun_CargarDataGriewEstado3(dataGridView1);

            }
        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
           

            if (txt_CodigoModificarImp.Text==string.Empty) {
                errorProvider1.SetError(txt_CodigoModificarImp, "Debe seleccionar un impuesto");
                errorProvider1.SetError(txt_Porcentaje, "Debe seleccionar un impuesto");
                errorProvider1.SetError(date_FechaIngresoImp, "Debe seleccionar un impuesto");
                errorProvider1.SetError(dateTimePicker1, "Debe seleccionar un impuesto");
                errorProvider1.SetError(comboBoxEstado, "Debe seleccionar un impuesto");
                return;
            } else
            {
                errorProvider1.SetError(txt_CodigoModificarImp, "");
                errorProvider1.SetError(txt_Porcentaje, "");
                errorProvider1.SetError(date_FechaIngresoImp, "");
                errorProvider1.SetError(dateTimePicker1, "");
                errorProvider1.SetError(comboBoxEstado, "");
            }



            if (txt_CodigoModificarImp.Text == string.Empty || Convert.ToDouble(txt_CodigoModificarImp.Text)<=0)
            {         
                errorProvider1.SetError(txt_Porcentaje, "Debe seleccionar un impuesto");
                return;
            }
            else
            {
                errorProvider1.SetError(txt_Porcentaje, "");
            }

            if (Convert.ToString(date_FechaIngresoImp.Value) == Convert.ToString(dateTimePicker1.Value))
            {
                errorProvider1.SetError(btn_Aceptar, "La fecha de ingreso del impuesto y su fecha de inicio no pueden ser la misma");
                return;
            }
            else
            {
                errorProvider1.SetError(btn_Aceptar, "");
            }




            impuesto.Var_Codigo_impuesto = Convert.ToInt16(txt_CodigoModificarImp.Text);
            impuesto.Var_Porcentaje_Impuesto = (float.Parse(txt_Porcentaje.Text) / 100);
            impuesto.Var_Fecha_modificacion = String.Format("{0:yyyy-MM-dd}", dateTimePicker1.Value);
            impuesto.Var_Codigo_estado = Convert.ToInt16(comboBoxEstado.SelectedValue);
            impuesto.Var_Fecha_inicial= String.Format("{0:yyyy-MM-dd}", date_FechaIngresoImp.Value);

            impuesto.VerificarFechaInicioModificaciones();
            txt_CodigoModificarImp.Clear();
            txt_Porcentaje.Clear();
            impuesto.Fun_CargarDataGriewEstado3(dataGridView1);
            Fecha_Inicial.MinDate = Convert.ToDateTime(impuesto.ObtenerFechaDisponible());

        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }


      

        private void txt_Porcentaje_KeyPress(object sender, KeyPressEventArgs e)
        {
            Val.NumerosDecimales(sender, e, txt_Porcentaje);
        }


        private void dataGridView1_CellContentDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if(RadioB_ModificarImpuesto.Checked == true)
            { 
                date_FechaIngresoImp.Value = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[1].Value.ToString()); 
                txt_CodigoModificarImp.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                txt_Porcentaje.Text = Convert.ToString(Convert.ToDouble(dataGridView1.CurrentRow.Cells[3].Value.ToString()) * 100);
                comboBoxEstado.SelectedValue = Convert.ToInt16(dataGridView1.CurrentRow.Cells[5].Value.ToString());
                Fecha_Inicial.MinDate = Convert.ToDateTime(impuesto.ObtenerFechaDisponible());
                MessageBox.Show("Listo");
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
