using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desarrollo.Pantallas.Modulo___Productos
{
    public partial class Form_Productos_ManejoProductos : Form
    {
        public Form_Productos_ManejoProductos()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form_Productos_ManejoProductos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'ventasAutoPartesDataSet.Categoria_Producto' Puede moverla o quitarla según sea necesario.
            this.categoria_ProductoTableAdapter.Fill(this.ventasAutoPartesDataSet.Categoria_Producto);
            // TODO: esta línea de código carga datos en la tabla 'ventasAutoPartesDataSet._Productos_Historicos' Puede moverla o quitarla según sea necesario.
            this.productos_HistoricosTableAdapter.Fill(this.ventasAutoPartesDataSet._Productos_Historicos);
            // TODO: esta línea de código carga datos en la tabla 'ventasAutoPartesDataSet.Producto' Puede moverla o quitarla según sea necesario.
            this.productoTableAdapter.Fill(this.ventasAutoPartesDataSet.Producto);
            // TODO: esta línea de código carga datos en la tabla 'ventasAutoPartesDataSet.Modelo' Puede moverla o quitarla según sea necesario.
            this.modeloTableAdapter.Fill(this.ventasAutoPartesDataSet.Modelo);
            // TODO: esta línea de código carga datos en la tabla 'ventasAutoPartesDataSet.Marca' Puede moverla o quitarla según sea necesario.
            this.marcaTableAdapter.Fill(this.ventasAutoPartesDataSet.Marca);

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.productoTableAdapter.FillBy(this.ventasAutoPartesDataSet.Producto);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void tabPage5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button18_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Funcion();//Funcion de Busqueda___Eli Josua
        }



        //CASO NUEVOI PRODUCTO___ELI JOSUA

        public void Funcion()//Funcion de Busqueda___Eli Josua
        {
            MessageBox.Show("Vin Dicel");
        }


        ///CARLOS

    }
}
