using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desarrollo.Pantallas.Modulo_Transacciones
{
    public partial class Form_MantenimientoTransacciones : System.Windows.Forms.Form
    {
        Conexion Con = new Conexion();
        Desarrollo.Clases.Validaciones Val = new Clases.Validaciones();
        Desarrollo.Clases.C_Transacciones T = new Clases.C_Transacciones();

        public Form_MantenimientoTransacciones()
        {
            InitializeComponent();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        public void FuncionesIniciales()
        {
            Txt_CodigoTransacciones.Text = Convert.ToString(T.UnltimoTransaccion());
            Txt_CodigoDocumentacion.Text = Convert.ToString(T.UltimoDocumento());
            this.tipo_TransaccionTableAdapter.Fill(this.ventasAutoPartesDataSet.Tipo_Transaccion);
            T.CargarDocumentos(DaraGriew_Documentacion);
            T.Fun_ExtraerEstados(Txt_EstadoDocumentacion);

        }
        private void Form_MantenimientoTransacciones_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'ventasAutoPartesDataSet.Tipos_Documentos' Puede moverla o quitarla según sea necesario.
            this.tipos_DocumentosTableAdapter.Fill(this.ventasAutoPartesDataSet.Tipos_Documentos);
            // TODO: esta línea de código carga datos en la tabla 'ventasAutoPartesDataSet.Tipo_Transaccion' Puede moverla o quitarla según sea necesario.
            this.tipo_TransaccionTableAdapter.Fill(this.ventasAutoPartesDataSet.Tipo_Transaccion);

            FuncionesIniciales();
            Radio_AgregarTransacciones.Checked = true;
            Radio_AgregarDocumentos.Checked = true;

            Radio_ActualizarTransacciones.Checked = true;


            var blankContextMenu = new ContextMenuStrip();
            Txt_DescripcionDocumentacion.ContextMenuStrip = blankContextMenu;
            Txt_CodigoTransacciones.ContextMenuStrip = blankContextMenu;
            Txt_DescripcionTransacciones.ContextMenuStrip = blankContextMenu;
            Txt_NaturalezaTransacciones.ContextMenuStrip = blankContextMenu;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Grupo_Transacciones_Enter(object sender, EventArgs e)
        {

        }

        private void Radio_AgregarDocumentos_CheckedChanged(object sender, EventArgs e)
        {
            if (Radio_AgregarDocumentos.Checked == true)
            {
                Txt_EstadoDocumentacion.SelectedValue = 1;
                Txt_EstadoDocumentacion.Enabled = false;
                Txt_CodigoDocumentacion.Text = Convert.ToString(T.UltimoDocumento());

            }
            else
            {
                Txt_EstadoDocumentacion.Enabled = true;
                Txt_CodigoDocumentacion.Text = string.Empty;
            }
        }

        private void Bttn_AceptarDocumentacion_Click(object sender, EventArgs e)
        {
            bool Vacios = false;
            if (string.IsNullOrWhiteSpace(Txt_DescripcionDocumentacion.Text))
            {
                errorProvider1.SetError(Txt_DescripcionDocumentacion, "La descripcion es Necesaria");
                Vacios = true;
            }
            else
            {
                errorProvider1.SetError(Txt_DescripcionDocumentacion, "");
            }


            if (string.IsNullOrWhiteSpace(Txt_CodigoDocumentacion.Text))
            {
                errorProvider1.SetError(Txt_CodigoDocumentacion, "El codigo del Documento es Necesario");
                Vacios = true;
            }
            else
            {
                errorProvider1.SetError(Txt_CodigoDocumentacion, "");
            }

            

            if (Vacios==true)
            {
                return;
            }
            

            if (Radio_AgregarDocumentos.Checked == true)
            {
                T.VerificarDocumentos(Convert.ToInt32(Txt_EstadoDocumentacion.SelectedValue), Txt_DescripcionDocumentacion.Text);
                Txt_CodigoDocumentacion.Text = Convert.ToString(T.UltimoDocumento());
                Txt_DescripcionDocumentacion.Text = string.Empty;
            }
            else
            {
                T.VerificarAct_Documento(Convert.ToInt32(Txt_CodigoDocumentacion.Text), 
                Convert.ToInt32(Txt_EstadoDocumentacion.SelectedValue), Txt_DescripcionDocumentacion.Text);
                Txt_CodigoDocumentacion.Text = string.Empty;
                Txt_DescripcionDocumentacion.Text = string.Empty;
            }

            FuncionesIniciales();
        }

        private void Radio_ActDocumentos_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void DaraGriew_Documentacion_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Radio_ActDocumentos.Checked = true;
            Txt_CodigoDocumentacion.Text = DaraGriew_Documentacion.CurrentRow.Cells[0].Value.ToString();
            Txt_DescripcionDocumentacion.Text= DaraGriew_Documentacion.CurrentRow.Cells[1].Value.ToString(); 
            Txt_EstadoDocumentacion.SelectedValue = Convert.ToInt32(DaraGriew_Documentacion.CurrentRow.Cells[2].Value.ToString());

        }

        private void DaraGriew_Documentacion_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Radio_ActDocumentos.Checked = true;
            Txt_CodigoDocumentacion.Text = DaraGriew_Documentacion.CurrentRow.Cells[0].Value.ToString();
            Txt_DescripcionDocumentacion.Text = DaraGriew_Documentacion.CurrentRow.Cells[1].Value.ToString();
            Txt_EstadoDocumentacion.SelectedValue = Convert.ToInt32(DaraGriew_Documentacion.CurrentRow.Cells[2].Value.ToString());
        }

        private void Txt_DescripcionDocumentacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            Val.ValirLetrasYEspacios(sender, e, Txt_DescripcionDocumentacion);
        }

        private void Bttn_LimpiaDocumentacion_Click(object sender, EventArgs e)
        {
            Txt_DescripcionDocumentacion.Text = string.Empty;
            FuncionesIniciales();
            errorProvider1.SetError(Txt_DescripcionDocumentacion, "");
            errorProvider1.SetError(Txt_CodigoDocumentacion, "");
        }

        private void Radio_ActualizarTransacciones_CheckedChanged(object sender, EventArgs e)
        {
            if (Radio_ActualizarTransacciones.Checked == true)
            {
                Txt_CodigoTransacciones.Text = string.Empty;

            }
            else
            {
                Txt_CodigoTransacciones.Text = Convert.ToString(T.UnltimoTransaccion());
                Txt_DescripcionTransacciones.Text = string.Empty;
                Txt_NaturalezaTransacciones.Text  = string.Empty;
            }
        }



        //**********************************************************************
        /////FUNCIONES DE TRANSACCIONES////////////////////////////////////////
        //********************************************************************

        private void DaraGriew_Transacciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Radio_ActualizarTransacciones.Checked = true;
            Txt_CodigoTransacciones.Text= DaraGriew_Transacciones.CurrentRow.Cells[0].Value.ToString();
            Txt_DescripcionTransacciones.Text = DaraGriew_Transacciones.CurrentRow.Cells[1].Value.ToString();
            Txt_NaturalezaTransacciones.Text  = DaraGriew_Transacciones.CurrentRow.Cells[2].Value.ToString();
        }

        private void Bttn_Aceptar_Click(object sender, EventArgs e)
        {
            bool Vacios = false;
            if (string.IsNullOrWhiteSpace(Txt_CodigoTransacciones.Text))
            {
                errorProvider1.SetError(Txt_CodigoTransacciones, "El codigo es necesario Necesaria");
                Vacios = true;
            }
            else
            {
                errorProvider1.SetError(Txt_CodigoTransacciones, "");
            }



            if (string.IsNullOrWhiteSpace(Txt_DescripcionTransacciones.Text))
            {
                errorProvider1.SetError(Txt_DescripcionTransacciones, "La descripcion es Necesaria");
                Vacios = true;
            }
            else
            {
                errorProvider1.SetError(Txt_DescripcionTransacciones, "");
            }


            if (string.IsNullOrWhiteSpace(Txt_NaturalezaTransacciones.Text))
            {
                errorProvider1.SetError(Txt_NaturalezaTransacciones, "La Naturaleza de la transaccion es Necesaria");
                Vacios = true;
            }
            else
            {
                errorProvider1.SetError(Txt_NaturalezaTransacciones, "");
            }



            if (Vacios == true)
            {
                return;
            }

            if (Radio_AgregarTransacciones.Checked == true) {
                T.VerificarTransaccion(Txt_NaturalezaTransacciones.Text, Txt_DescripcionTransacciones.Text);
            }
            else
            {
                T.VerificarModiT(Convert.ToInt32(Txt_CodigoTransacciones.Text), Txt_NaturalezaTransacciones.Text, Txt_DescripcionTransacciones.Text);
                Radio_AgregarTransacciones.Checked = true;
            }

            FuncionesIniciales();
        }

        private void DaraGriew_Transacciones_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Radio_ActualizarTransacciones.Checked = true;
            Txt_CodigoTransacciones.Text = DaraGriew_Transacciones.CurrentRow.Cells[0].Value.ToString();
            Txt_DescripcionTransacciones.Text = DaraGriew_Transacciones.CurrentRow.Cells[1].Value.ToString();
            Txt_NaturalezaTransacciones.Text = DaraGriew_Transacciones.CurrentRow.Cells[2].Value.ToString();
        }

        private void DaraGriew_Transacciones_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Radio_ActualizarTransacciones.Checked = true;
            Txt_CodigoTransacciones.Text = DaraGriew_Transacciones.CurrentRow.Cells[0].Value.ToString();
            Txt_DescripcionTransacciones.Text = DaraGriew_Transacciones.CurrentRow.Cells[1].Value.ToString();
            Txt_NaturalezaTransacciones.Text = DaraGriew_Transacciones.CurrentRow.Cells[2].Value.ToString();
        }

        private void Bttn_Limpiar_Click(object sender, EventArgs e)
        {

            Txt_DescripcionTransacciones.Text = string.Empty;
            Txt_NaturalezaTransacciones.Text = string.Empty;

            errorProvider1.SetError(Txt_CodigoTransacciones, "");
            errorProvider1.SetError(Txt_DescripcionTransacciones, "");
            errorProvider1.SetError(Txt_NaturalezaTransacciones, "");
            FuncionesIniciales();
        }

        private void Txt_DescripcionTransacciones_KeyPress(object sender, KeyPressEventArgs e)
        {
            Val.ValirLetrasYEspacios(sender, e, Txt_DescripcionTransacciones);
        }

        private void Txt_NaturalezaTransacciones_KeyPress(object sender, KeyPressEventArgs e)
        {
            Val.ValirLetrasYEspacios(sender, e, Txt_NaturalezaTransacciones);
        }
    }
}
