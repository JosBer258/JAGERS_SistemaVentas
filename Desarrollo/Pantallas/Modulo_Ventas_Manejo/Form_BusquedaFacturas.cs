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
            Busq.Fun_ExtraerEstados(comboBox1);



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



            if (string.IsNullOrWhiteSpace(textBox6.Text))
            {
                errorProvider1.SetError(textBox6, "Debe llenar este campo");
                Ve = true;
            }
            else
            {
                errorProvider1.SetError(textBox6, "");
            }


            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                errorProvider1.SetError(textBox1, "Debe llenar este campo");
                Ve = true;
            }
            else
            {
                errorProvider1.SetError(textBox1, "");
            }


            if (comboBox1.SelectedIndex==-1)
            {
                errorProvider1.SetError(comboBox1, "Debe llenar este campo");
                Ve = true;
            }
            else
            {
                errorProvider1.SetError(comboBox1, "");
            }

            if (Ve == true)
            {
                return;
            }

            Busq.UpdateFactura(Convert.ToInt32(comboBox1.SelectedValue), Convert.ToInt32(textBox6.Text));

            LimpiarTodo();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox6.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBox1.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            comboBox1.SelectedValue =Convert.ToDouble(dataGridView1.CurrentRow.Cells[8].Value.ToString());


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
            textBox6.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBox1.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            comboBox1.SelectedValue = Convert.ToDouble(dataGridView1.CurrentRow.Cells[8].Value.ToString());


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
            textBox6.Text = string.Empty;
            textBox5.Text = string.Empty;
            textBox4.Text = string.Empty;
            textBox1.Text = string.Empty;
        }
    }
}
