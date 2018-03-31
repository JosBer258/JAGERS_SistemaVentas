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

namespace Desarrollo.Pantallas.Modulo_Ventas_Manejo.Modulo_ArqueodeCaja
{
    public partial class Form_PantallaManejoAperturaCaja : System.Windows.Forms.Form
    {
        Conexion Con = new Conexion();
        C_ManejoAperturaCaja ManejoApertura = new C_ManejoAperturaCaja();

   
        public string Var_Codigo_Local_Apertura;

        public Form_PantallaManejoAperturaCaja()
        {
            InitializeComponent();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Bttn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    
        private void Form_PantallaManejoAperturaCaja_Load(object sender, EventArgs e)
        {
            Pest1_Bttn_ForzarCierre.Visible = false;
            Pest2_CierredeCaja.Visible = false;

            var blankContextMenu = new ContextMenuStrip();
            Pest1_Txt_MontoAAperturaCaja.ContextMenuStrip = blankContextMenu;
            Pest2_Txt_Manejo_Monto.ContextMenuStrip = blankContextMenu;
            Pest2_Txt_Manejo_Monto.ContextMenuStrip = blankContextMenu;
            Pest3_Radii_BuscarTransaccionesMesActaul.Checked = true;

            ManejoApertura.Fun_ShowArquSinFil(Pest3_GridView_Historial);


            if (ManejoApertura.VerificarArqueo(Pest1_FechaApertura) == true)
            {
                MessageBox.Show("Ya se ha realizado una apertura de Caja", "Aviso de Apertura de Caja", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                Pest1_GrupoAgregarEmpleado.Enabled = false; Pest1_DataGriew.Enabled = false; Pest1_Bttn_Guardar.Enabled = false;
                ManejoApertura.FuncionMostrarData(Pest2_DataGriewConfirmacion, Pest1_FechaApertura);
                Pest2_CierredeCaja.Visible = true;
            }
            else
            if (ManejoApertura.Fun_VerExistenciaApertAnteri(Pest1_FechaApertura) ==true)
            {
                Pest2_CierredeCaja.Visible = false;
                MessageBox.Show("Ya se ha realizado una apertura de caja antes sin haber realizado el cierre correspondiente", "Aviso de Apertura de Caja", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                Pest1_GrupoAgregarEmpleado.Enabled = false; Pest1_DataGriew.Enabled = false; Pest1_Bttn_Guardar.Enabled = false;
                Pest2_GrupoManejo.Enabled = false;
                Pest2_CierredeCaja.Enabled = false;
                Pest2_Bttn_Actualizar.Enabled = false;
                Pest1_Bttn_ForzarCierre.Visible = true;
                ManejoApertura.Fun_LlenarDetallesCasoDeApertAntExistente(Pest2_DataGriewConfirmacion);
            }


            Pest1_Txt_NombreEncargado.Text = Name;
            ManejoApertura.Fun_PonerAños(Pest3_ComBox_Año);
            ManejoApertura.Fun_ExtraerEstadosEmpleadosVerificacionApertura(Pest2_Chk_Manejo__ComboBox);
            ManejoApertura.Fun_ExtraerCodigosEmpleadosPorLocalidad(Pest1_ComBox_CodigoEmpleado, Convert.ToDouble(Var_Codigo_Local_Apertura));
        }


        private void Pest1_ComBox_CodigoEmpleado_SelectedIndexChanged(object sender, EventArgs e)
        {
            ManejoApertura.Fun_OptenerNombreEmpleado(Convert.ToInt32(Pest1_ComBox_CodigoEmpleado.SelectedValue), Pest1_Txt_NombreEmpleado);
        }


        private void Bttn_AgregarDataGriew_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(Pest1_Txt_MontoAAperturaCaja.Text) || Pest1_Txt_MontoAAperturaCaja.Text=="")
            {
                errorProvider1.SetError(Pest1_Txt_MontoAAperturaCaja, "Se debe ingresar el monto con el cual el empleado realizara la apertura de la caja.");
                return;
            }
            else
            {
                Pest1_Txt_MontoAAperturaCaja.Text = Convert.ToString(Convert.ToDouble(Pest1_Txt_MontoAAperturaCaja.Text) + 0.0);
                errorProvider1.SetError(Pest1_Txt_MontoAAperturaCaja, "");
                
            }



            if (Convert.ToDouble(Pest1_Txt_MontoAAperturaCaja.Text) == 0)
            {
                errorProvider1.SetError(Pest1_Txt_MontoAAperturaCaja, "Debe Ingresar un Monto con el cual se realizara la Apertura");
                return;
            }
            errorProvider1.SetError(Pest1_Txt_MontoAAperturaCaja, "");


            for (int i = 0; i < Pest1_DataGriew.Rows.Count; i++)
            {
                if (Convert.ToString((string)this.Pest1_DataGriew.Rows[i].Cells[1].Value) == Pest1_Txt_NombreEmpleado.Text)
                {
                    MessageBox.Show("El empleado solo puede ser agregado una sola vez", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            Pest1_DataGriew.Rows.Insert(0,  Convert.ToString(Pest1_ComBox_CodigoEmpleado.SelectedValue),Pest1_Txt_NombreEmpleado.Text, Pest1_Txt_MontoAAperturaCaja.Text, "Eliminar");
        }


        private void Pest1_Bttn_Guardar_Click(object sender, EventArgs e)
        {
            if (Pest1_DataGriew.RowCount == 0)
            {
                MessageBox.Show("Debe agregar algun Empleado", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            ManejoApertura.IngresoDatos(Pest1_FechaApertura,Name);
            foreach (DataGridViewRow Row in Pest1_DataGriew.Rows)
            {                
                String strFila = Row.Index.ToString();
                ManejoApertura.IngresoDetalles((float)Convert.ToDouble(Row.Cells["DG_Monto"].Value), Convert.ToInt32(Row.Cells["DG_Codigo"].Value));
                Pest2_CierredeCaja.Visible = true;
                ManejoApertura.Fun_ShowArquSinFil(Pest3_GridView_Historial);
            }
            if (ManejoApertura.VerificarArqueo(Pest1_FechaApertura) == true)
            {
                MessageBox.Show("Se ha realizado una apertura de Caja", "Aviso de Apertura de Caja", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                Pest1_GrupoAgregarEmpleado.Enabled = false;
                Pest1_DataGriew.Enabled = false;
                Pest1_Bttn_Guardar.Enabled = false;
                ManejoApertura.FuncionMostrarData(Pest2_DataGriewConfirmacion, Pest1_FechaApertura);
            }

        }


        private void Pest1_DataGriew_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
               
        }


        private void Pest1_Txt_MontoAAperturaCaja_KeyPress(object sender, KeyPressEventArgs e)
        {
            Desarrollo.Clases.Validaciones Val = new Clases.Validaciones();
            Val.NumerosDecimales(sender, e, Pest1_Txt_MontoAAperturaCaja);
        }


        private void Pest1_DataGriew_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string ColumnaParaElimina;
            ColumnaParaElimina = Pest1_DataGriew.CurrentCell.ColumnIndex.ToString();
            if (Convert.ToInt16(ColumnaParaElimina) == 3){
                Pest1_DataGriew.Rows.RemoveAt(Pest1_DataGriew.CurrentRow.Index);}
        }
 

        private void Pest2_Bttn_Actualizar_Click(object sender, EventArgs e)
        {
            ManejoApertura.FuncionMostrarData(Pest2_DataGriewConfirmacion, Pest1_FechaApertura);
        }


        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            Desarrollo.Clases.Validaciones Val = new Clases.Validaciones();
            Val.NumerosDecimales(sender, e, Pest2_Txt_Manejo_Monto);
        }


        private void Pest2_DataGriewConfirmacion_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = this.Pest2_DataGriewConfirmacion.Rows[e.RowIndex];

                Pest2_Txt_Manejo_Codigo.Text = Convert.ToString(row.Cells["Codigo"].Value.ToString()); ;
                Pest2_Txt_Manejo_Monto.Text = Convert.ToString(row.Cells["Monto de Apertura de Caja"].Value.ToString()); ;
                Pest2_Txt_Manejo_Nombre.Text = Convert.ToString(row.Cells["Empleado"].Value.ToString()); ;
                Pest2_Chk_Manejo__ComboBox.SelectedValue = Convert.ToString(row.Cells["Codigo del Estado Inicial"].Value.ToString());

                if (Convert.ToInt16(Pest2_Chk_Manejo__ComboBox.SelectedValue) == 1)
                {
                    Pest2_Chk_Manejo__ComboBox.Enabled = false;
                    Pest2_Txt_Manejo_Monto.Enabled = false;
                }
            }
            catch (Exception)
            {

            }
        }   

         
        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Pest2_Txt_Manejo_Codigo.Text))
            {
                errorProvider1.SetError(Pest2_Txt_Manejo_Codigo, "Debe seleccionar a un Empleado");
                return;
            }
            errorProvider1.SetError(Pest2_Txt_Manejo_Codigo, "");

            if (Pest2_Txt_Manejo_Monto.Text == "." || string.IsNullOrWhiteSpace(Pest2_Txt_Manejo_Monto.Text))
            {
                errorProvider1.SetError(Pest2_Txt_Manejo_Monto, "Debe Ingresar un Monto con el cual se realizara la Apertura");
                return;
            }

            Pest2_Txt_Manejo_Monto.Text =Convert.ToString( Convert.ToDouble(Pest2_Txt_Manejo_Monto.Text) + 0.0);

            if (Convert.ToDouble(Pest2_Txt_Manejo_Monto.Text)==0)
            {
                errorProvider1.SetError(Pest2_Txt_Manejo_Monto, "Debe Ingresar un Monto con el cual se realizara la Apertura");
                return;
            }
            errorProvider1.SetError(Pest2_Txt_Manejo_Codigo, "");

            if(ManejoApertura.VerificacionDeCajaCerrada(Pest1_FechaApertura) == true)
            {
                errorProvider1.SetError(Pest2_Txt_Manejo_Codigo, "Ya se realizo el cierre previamente");
                return;
            }else
            {
                errorProvider1.SetError(Pest2_Txt_Manejo_Codigo, "");
            }

            ManejoApertura.ActualizarMonto(Convert.ToInt32(Pest2_Txt_Manejo_Codigo.Text), Convert.ToInt32(Pest2_Chk_Manejo__ComboBox.SelectedValue), Convert.ToDouble(Pest2_Txt_Manejo_Monto.Text));
            LimpiarPest2();
            ManejoApertura.FuncionMostrarData(Pest2_DataGriewConfirmacion, Pest1_FechaApertura);

        }


        private void button1_Click(object sender, EventArgs e)
        {
            LimpiarPest2();
           
        }


        private void LimpiarPest2()
        {
            Pest2_Txt_Manejo_Codigo.Text = string.Empty;
            Pest2_Txt_Manejo_Monto.Text = "0";
            Pest2_Txt_Manejo_Nombre.Text = string.Empty;
        }
        //Pestaña 3
        private void Pest3_Radii_BuscarTransaccionesMesOtro_CheckedChanged(object sender, EventArgs e)
        {
            if (Pest3_Radii_BuscarTransaccionesMesOtro.Checked == true)
            {
                Pest3_ComBox_Mess.Enabled = true;
                Pest3_ComBox_Año.Enabled = true;
            }else
            {
                Pest3_ComBox_Mess.Enabled = false;
                Pest3_ComBox_Mess.SelectedIndex = -1;
                Pest3_ComBox_Año.Enabled = false;
                Pest3_ComBox_Año.SelectedIndex = -1;
            }
        }

        private void Pest3_Radii_BuscarTransaccionesMesActaul_CheckedChanged(object sender, EventArgs e)
        {
            if (Pest3_Radii_BuscarTransaccionesMesActaul.Checked == true)
            {

                Pest3_ComBox_Mess.Enabled = false;
                Pest3_ComBox_Mess.SelectedIndex = -1;
                Pest3_ComBox_Año.Enabled = false;
                Pest3_ComBox_Año.SelectedIndex = -1;
            }
            else
            {
                Pest3_ComBox_Mess.Enabled = true;
                Pest3_ComBox_Año.Enabled = true;
            }
        }

        private void Pest3_GridView_Historial_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.Pest3_GridView_Historial.Rows[e.RowIndex];
            int Var_CodDeArqBus = Convert.ToInt16(row.Cells["Codigo"].Value.ToString());
            ManejoApertura.Fun_LlenarDetalles(Pest3_DataGriewDetalles, Var_CodDeArqBus);

        }

        private void Pest3_Bttn_Generar_Click(object sender, EventArgs e)
        {
            

            if (Pest3_Radii_BuscarTransaccionesMesActaul.Checked == true)
            {
                ManejoApertura.Fun_ShowArquSinFil(Pest3_GridView_Historial);
            } else
            {
                if (Pest3_ComBox_Año.SelectedIndex == -1 || Pest3_ComBox_Mess.SelectedIndex == -1)
                { errorProvider1.SetError(Pest3_Bttn_Generar, "Debe seleccionar el mes y el año"); return; }
                else
                {
                    errorProvider1.SetError(Pest3_Bttn_Generar, "");
                }

                ManejoApertura.Fun_ShwPorFiltro(Pest3_GridView_Historial, Convert.ToInt32(Pest3_ComBox_Año.SelectedItem), Convert.ToInt32(Pest3_ComBox_Mess.SelectedIndex));
            }
        }


        private void Pest1_Bttn_ForzarCierre_Click(object sender, EventArgs e)
        {
            ManejoApertura.Fun_ForzarCierre(Pest1_FechaApertura);
        }

        private void Pest2_CierredeCaja_Click(object sender, EventArgs e)
        {
            if(ManejoApertura.Fun_VerificarCierrePorDet(Pest1_FechaApertura) == true)
            {
                MessageBox.Show("Existen cajas en estado de abiertas","Aviso de cierre de caja", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }else
            {
                ManejoApertura.Fun_CierreCaja(Pest1_FechaApertura);
            }
        }
    }
}
