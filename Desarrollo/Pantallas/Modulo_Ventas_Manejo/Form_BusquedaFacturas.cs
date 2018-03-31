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

    public partial class Form_BusquedaFacturas : System.Windows.Forms.Form
    {
        Conexion con = new Conexion();
        C_Factura Busq = new C_Factura();

        public Form_BusquedaFacturas()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form_BusquedaFacturas_Load(object sender, EventArgs e)
        {
            Busq.Fun_InsertarDatagriew(dataGridView1);
            Busq.Fun_ExtraerEstados(CMB_Estado);



            var blankContextMenu = new ContextMenuStrip();
            textBox9.ContextMenuStrip = blankContextMenu;
        }



        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            if (textBox9.Text == string.Empty)
            {
                Busq.Fun_InsertarDatagriew(dataGridView1);
            }
            else
            {
                Busq.Fun_InsertarDatagriewC(dataGridView1, Convert.ToDouble(textBox9.Text));
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    

        private void button3_Click(object sender, EventArgs e)
        {
            bool Ve=false;



            if (string.IsNullOrWhiteSpace(Txt_Codigo.Text))
            {
                errorProvider1.SetError(Txt_Codigo, "Debe llenar este campo");
                Ve = true;
            }
            else
            {
                errorProvider1.SetError(Txt_Codigo, "");
            }


            if (string.IsNullOrWhiteSpace(Txt_MontoTotal.Text))
            {
                errorProvider1.SetError(Txt_MontoTotal, "Debe llenar este campo");
                Ve = true;
            }
            else
            {
                errorProvider1.SetError(Txt_MontoTotal, "");
            }


            if (CMB_Estado.SelectedIndex==-1)
            {
                errorProvider1.SetError(CMB_Estado, "Debe llenar este campo");
                Ve = true;
            }
            else
            {
                errorProvider1.SetError(CMB_Estado, "");
            }

            if (Ve == true)
            {
                return;
            }

            Busq.UpdateFactura(Convert.ToInt32(CMB_Estado.SelectedValue), (int)Convert.ToDouble(Txt_Codigo.Text));

            if (Convert.ToInt32(CMB_Estado.SelectedValue)==2)
            {
                Busq.Fun_UpdateTransacciones((int)Convert.ToDouble(Txt_Codigo.Text));
            }
            LimpiarTodo();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Txt_Codigo.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            Txt_Nombre.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            Txt_Fecha.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            Txt_MontoTotal.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            CMB_Estado.SelectedValue =Convert.ToDouble(dataGridView1.CurrentRow.Cells[8].Value.ToString());


            Busq.LlenarDetalles(dataGridView2, Convert.ToDouble(dataGridView1.CurrentRow.Cells[0].Value.ToString()));
        }

        

        private void textBox9_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones Val = new Validaciones();
            Val.ValidarID(sender, e);
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }



        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Txt_Codigo.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            Txt_Nombre.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            Txt_Fecha.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            Txt_MontoTotal.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            CMB_Estado.SelectedValue = Convert.ToDouble(dataGridView1.CurrentRow.Cells[8].Value.ToString());


            Busq.LlenarDetalles(dataGridView2, Convert.ToDouble(dataGridView1.CurrentRow.Cells[0].Value.ToString()));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            LimpiarTodo();
        }


        private void LimpiarTodo()
        {
            dataGridView2.DataSource = null;
            dataGridView2.RowCount = 0;
            dataGridView2.Rows.Clear();
            dataGridView2.Refresh();
            Busq.Fun_InsertarDatagriew(dataGridView1);
            Txt_Codigo.Text = string.Empty;
            Txt_Nombre.Text = string.Empty;
            Txt_Fecha.Text = string.Empty;
            Txt_MontoTotal.Text = string.Empty;
        }
    }
}
