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
using System.IO;
using System.Reflection;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace Desarrollo.Pantallas.Modulo_Ventas_Manejo
{
    public partial class Form_RealizarCotizaciones : System.Windows.Forms.Form
    {
        public string Cot_NombreEmpleado = "";
        double Total;
        Conexion Con = new Conexion();
        Validaciones Val = new Validaciones();
        string NombreProducto;
        string NombreCliente;

        public Form_RealizarCotizaciones()
        {
            InitializeComponent();
        }

        private void Form_RealizarCotizaciones_Load(object sender, EventArgs e)
        {
            Txt_NombreEmpleado.Text = Cot_NombreEmpleado;

            var blankContextMenu = new ContextMenuStrip();
            txt_Nombre1.ContextMenuStrip = blankContextMenu;
            txt_Nombre2.ContextMenuStrip = blankContextMenu;
            Txt_Cantidad.ContextMenuStrip = blankContextMenu;
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        ////LLENADO DE LOS DATOS*********************************************************

        private void FiltroClienteEmpresa(string NombreEmpresa)
        {
            if (NombreEmpresa == string.Empty)
            {
                NombreEmpresa = "a";
            }


            Con.cnx.Open();
            Con.sql = string.Format(@"select Codigo_Empresa, NombreEmpresa from Empresas where NombreEmpresa like '%{0}%' ", NombreEmpresa);
            Con.cmd = new SqlCommand(Con.sql, Con.cnx);
            Con.DataAdapter = new SqlDataAdapter(Con.cmd);
            Con.dt = new DataTable();
            Con.DataAdapter.Fill(Con.dt);
            Con.cnx.Close();


            Combo_NombreCliente.ValueMember = "Codigo_Empresa";
            Combo_NombreCliente.DisplayMember = "NombreEmpresa";
            Combo_NombreCliente.DataSource = Con.dt;
         
        }

        private void FiltroClienteNormal(string NombreCliente)
        {
            if (NombreCliente == string.Empty)
            {
                NombreCliente = "a";
            }
            Con.cnx.Open();


            Con.sql = string.Format(@"select Codigo_Cliente,(Nombre + ' ' + Apellido) as 'Nombre' from Clientes where (Nombre + ' ' + Apellido) like '%{0}%'", NombreCliente);
            Con.cmd = new SqlCommand(Con.sql, Con.cnx);
            Con.DataAdapter = new SqlDataAdapter(Con.cmd);
            Con.dt = new DataTable();
            Con.DataAdapter.Fill(Con.dt);
            Con.cnx.Close();


            Combo_NombreCliente.ValueMember = "Codigo_Cliente";
            Combo_NombreCliente.DisplayMember = "Nombre";
            Combo_NombreCliente.DataSource = Con.dt;
      
        }

        private void txt_Nombre1_TextChanged(object sender, EventArgs e)
        {
            Combo_NombreCliente.DataSource = null;
            Combo_NombreCliente.Items.Clear();

            if (Check_RepresentarEmpresa.Checked == true)
            {
                FiltroClienteEmpresa(txt_Nombre1.Text);
            }
            else
            {
                FiltroClienteNormal(txt_Nombre1.Text);
            }
        }


        private void FiltroProducto(string NombreProducto)
        {
            if (NombreProducto == string.Empty)
            {
                NombreProducto = "a";
            }
            Con.cnx.Open();


            Con.sql = string.Format(@"select Cod_Producto, NombreProducto from Producto where NombreProducto like '%{0}%' and Cod_Estado=1", NombreProducto);
            Con.cmd = new SqlCommand(Con.sql, Con.cnx);
            Con.DataAdapter = new SqlDataAdapter(Con.cmd);
            Con.dt = new DataTable();
            Con.DataAdapter.Fill(Con.dt);
            Con.cnx.Close();


            ComBox_DescripcionProducto.ValueMember = "Cod_Producto";
            ComBox_DescripcionProducto.DisplayMember = "NombreProducto";
            ComBox_DescripcionProducto.DataSource = Con.dt;

        }

        private void txt_Nombre2_TextChanged(object sender, EventArgs e)
        {
            FiltroProducto(txt_Nombre2.Text);
        }

        private void AgregarProductos(int a)
        {

            Con.sql = string.Format(@"
            select A.NombreProducto as Nombre, A.PrecioVenta as Precio, 
            B.Descripcion as Modelo, C.Descripcion as Marca from Producto As A inner Join Modelo as B
            on A.Cod_Modelo=B.Cod_Modelo inner join Marca as C on C.Cod_Marca=B.Cod_Marca
            where A.Cod_Producto='{0}'", a);
            Con.cmd = new SqlCommand(Con.sql, Con.cnx);
            Con.cnx.Open();

            SqlDataReader Reg = null;
            Reg = Con.cmd.ExecuteReader();

            if (Reg.Read())
            {

                NombreProducto = (Reg["Nombre"].ToString());
                Text_Marca.Text = (Reg["Marca"].ToString());
                Text_Modelo.Text = (Reg["Modelo"].ToString());
                Text_Precio.Text = (Reg["Precio"].ToString());
                Con.cnx.Close();
            }
            else
            {
                Con.cnx.Close();
            }


        }

        private void ComBox_DescripcionProducto_SelectedIndexChanged(object sender, EventArgs e)
        {

            AgregarProductos(Convert.ToInt32(ComBox_DescripcionProducto.SelectedValue));

        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            bool Local_Verif = false;
            double Local_TotalPorP = 0;
            string Local_InfoProducto;

            if (ComBox_DescripcionProducto.SelectedIndex == -1)
            {
                errorProvider1.SetError(ComBox_DescripcionProducto, "Debe selecionar un producto");
                return;
            }
            else
            {
                errorProvider1.SetError(ComBox_DescripcionProducto, "");
            }

            if (string.IsNullOrWhiteSpace(Txt_Cantidad.Text) || Convert.ToUInt32(Txt_Cantidad.Text) <= 0)
            {
                errorProvider1.SetError(Txt_Cantidad, "Debe Ingresar una Cantidad mayor de 0");
                return;
            }
            else
            {
                errorProvider1.SetError(Txt_Cantidad, "");
            }




            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (Convert.ToString((string)this.dataGridView1.Rows[i].Cells[0].Value) == NombreProducto)
                {
                    Local_Verif = true;
                }
            }


            if (Local_Verif == true)
            {
                MessageBox.Show("Un producto solo puede ser agregado una sola vez");
                return;
            }

            Total = Total + (Convert.ToDouble(Text_Precio.Text) * Convert.ToUInt32(Txt_Cantidad.Text));
            Local_TotalPorP = Convert.ToDouble(Total);
            Local_InfoProducto ="Nombre:" + NombreProducto + " \nde Marca: " + Text_Marca.Text + " \nY de Modelo: " + Text_Modelo.Text;

            dataGridView1.Rows.Insert(0, Local_InfoProducto, Text_Precio.Text, Txt_Cantidad.Text, Convert.ToString(Local_TotalPorP));
            Label_Total.Text = Convert.ToString(Total);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Var_renglonesSeleccionados = dataGridView1.SelectedRows.Count;
            int Var_cuadrosselecionados = dataGridView1.SelectedCells.Count;

            if (Var_renglonesSeleccionados == 0 && Var_cuadrosselecionados == 0)
            {
                MessageBox.Show("Tienes que seleccionar por lo menos una fila.");
                return;
            }

            double Resta;
            Resta = Convert.ToDouble(dataGridView1.CurrentRow.Cells[5].Value.ToString());
            dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
            Total = Total - Resta;
            Label_Total.Text = Convert.ToString(Total);
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {


            if (dataGridView1.RowCount == 0)
            {
                MessageBox.Show("Debe agregar algun Producto", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (Combo_NombreCliente.SelectedIndex == -1)
            {
                NombreCliente = "Desconocido";
            }
            else
            {
                if (Check_RepresentarEmpresa.Checked == true)
                {
                    ClienteEmpresa(Convert.ToInt32(Combo_NombreCliente.SelectedValue));
                }
                else
                {
                    ClienteNormal(Convert.ToInt32(Combo_NombreCliente.SelectedValue));
                }
            }

            InformeA();
            /*

            Cotizacion_Impresion_Forma Coti = new Cotizacion_Impresion_Forma();
            Coti.NomCliente= NombreCliente;
            Coti.NomEmpleado= Txt_NombreEmpleado.Text;
            Coti.FechaRealizacion= Date_Fecha.Text;
            Coti.Total = label2.Text;
            Coti.FechaFinal = dateTimePicker1.Text;

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                Cotizaccion_LlenadoDeDataGriew Cot = new Cotizaccion_LlenadoDeDataGriew();
                
                Cot.Descripcion = Convert.ToString("Producto: " + (string)this.dataGridView1.Rows[i].Cells[0].Value + 
                                                  "\nDe Marca: " + (string)this.dataGridView1.Rows[i].Cells[1].Value + 
                                                  "\nDe Modelo: " + (string)this.dataGridView1.Rows[i].Cells[2].Value +
                                                  "\nCantidad: " + (string)this.dataGridView1.Rows[i].Cells[4].Value);  

                Cot.Precio = Convert.ToString("L. " + Convert.ToString(this.dataGridView1.Rows[i].Cells[5].Value));
                Coti.Datos.Add(Cot);
            }
             Coti.ShowDialog();*/
        }

        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            Label_Total.Text = "0";
            txt_Nombre2.Text = string.Empty;

        }

        private void btn_DescartarProducto_Click(object sender, EventArgs e)
        {
            int Var_renglonesSeleccionados = dataGridView1.SelectedRows.Count;
            int Var_cuadrosselecionados = dataGridView1.SelectedCells.Count;

            if (Var_renglonesSeleccionados == 0 && Var_cuadrosselecionados == 0)
            {
                MessageBox.Show("Tienes que seleccionar por lo menos una fila.");
                return;
            }

            double Resta;
            Resta = Convert.ToDouble(dataGridView1.CurrentRow.Cells[5].Value.ToString());
            dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
            Total = Total - Resta;
            Label_Total.Text = Convert.ToString(Total);
        }


        public void ClienteNormal(int a)
        {
            Con.sql = string.Format(@" select (Nombre + ' ' + Apellido) 
            as Nombre from Clientes where Codigo_Cliente='{0}'", a);
            Con.cmd = new SqlCommand(Con.sql, Con.cnx);
            Con.cnx.Open();

            SqlDataReader Reg = null;
            Reg = Con.cmd.ExecuteReader();

            if (Reg.Read())
            {

                NombreCliente = (Reg["Nombre"].ToString());
            }
            else
            {


            }
            Con.cnx.Close();
        }

        public void ClienteEmpresa(int a)
        {
            Con.sql = string.Format(@"select NombreEmpresa from Empresas where Codigo_Empresa='{0}'", a);
            Con.cmd = new SqlCommand(Con.sql, Con.cnx);
            Con.cnx.Open();

            SqlDataReader Reg = null;
            Reg = Con.cmd.ExecuteReader();

            if (Reg.Read())
            {

                NombreCliente = (Reg["NombreEmpresa"].ToString());

            }
            else
            {

            }

        }

        private void txt_Nombre1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Val.ValirLetrasYEspacios(sender, e, txt_Nombre1);
        }

        private void txt_Nombre2_KeyPress(object sender, KeyPressEventArgs e)
        {
            Val.ValidarNombres_LetrasYNumeros(sender, e);
        }

        private void Txt_Cantidad_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txt_Cantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            Val.ValidarID(sender, e);
        }



        private void InformeA()
        {
            string Var_NombreCliente;
            DateTime Var_Hoy = DateTime.Today;
            string Var_fecha_actual = Var_Hoy.ToString("dd-MM-yyyy");

            try
            {
                if (Combo_NombreCliente.SelectedIndex == -1)
                {
                    Var_NombreCliente = "Desconocido";
                }else
                {
                  
                    Var_NombreCliente = Combo_NombreCliente.Text;
                }

                string Nombre = "Cotizacion" + Var_fecha_actual + "-" + Var_NombreCliente;
                string Ruta = @"C:\Rogers\Cotizaciones\" + Nombre + ".pdf";               
                ExportDataTableToPdf(dataGridView1, Ruta, "Cotizacion de Inventario");
                System.Diagnostics.Process.Start(Ruta);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message");
            }
        }


        void ExportDataTableToPdf(DataGridView dgvTable, String strPdfPath, string strHeader)
        {
            string Var_NombreCliente;

            if (Combo_NombreCliente.SelectedIndex == -1)
            {
                Var_NombreCliente = "Desconocido";
            }
            else
            {

                Var_NombreCliente = Combo_NombreCliente.Text;
            }
            DateTime Var_Hoy = DateTime.Today;
            string Var_fecha_actual = Var_Hoy.ToString("dd-MM-yyyy");

            System.IO.FileStream fs = new FileStream(strPdfPath, FileMode.Create, FileAccess.Write, FileShare.None);
            Document document = new Document();
            document.SetPageSize(iTextSharp.text.PageSize.A4);
            PdfWriter writer = PdfWriter.GetInstance(document, fs);
            document.Open();


            //Report Header
            BaseFont bfntHead = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
            iTextSharp.text.Font fntHead = new iTextSharp.text.Font(bfntHead, 16, 1, iTextSharp.text.BaseColor.BLACK);
            Paragraph prgHeading = new Paragraph();
            prgHeading.Alignment = Element.ALIGN_CENTER;
            prgHeading.Add(new Chunk(strHeader.ToUpper(), fntHead));
            document.Add(prgHeading);

            //Author
            Paragraph prgAuthor = new Paragraph();
            BaseFont btnAuthor = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
            iTextSharp.text.Font fntAuthor = new iTextSharp.text.Font(btnAuthor, 10, 2, iTextSharp.text.BaseColor.BLACK);
            prgAuthor.Alignment = Element.ALIGN_RIGHT;
            prgAuthor.Add(new Chunk("\nRogers Truck presenta esta cotización en la fecha: " + DateTime.Now.ToShortDateString(), fntAuthor));
            document.Add(prgAuthor);

            iTextSharp.text.Image PNG = iTextSharp.text.Image.GetInstance("Pictures/Logo.png");
            PNG.ScalePercent(30f);
            PNG.SetAbsolutePosition(document.PageSize.Width -40f -530f, document.PageSize.Height -100f);
            document.Add(PNG);
             Paragraph p = new Paragraph("\nRealizada por el Miembro del Equipo de Rogers Truck: "+ Txt_NombreEmpleado.Text +
                "\nlos Nombres y los Precios de los productos que el cliente: " + Var_NombreCliente + 
                "\nha solicitado anteriormente" +
                "\nEste documento tendra valides hasta la fecha del: " + Date_FechaLimite.Value +
                "\n\nLa empresa Rogers Truck Parts no se compromete de ninguna forma con el cliente: " + Var_NombreCliente +
                "\nDe la consistencia de la siguiente información ahora presentada acerca de los productos que ofrece Rogers Truck Parts." +
                "\nEsta cotización es únicamente con fines de informar al cliente:" + Var_NombreCliente +
                "\nacerca de los productos que están presentándose actualmente.");
            document.Add(p);
            document.Add(new Chunk("\n", fntHead));


            PdfPTable tabl = new PdfPTable(dgvTable.Columns.Count);
            BaseFont btnColumnHeader = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
            iTextSharp.text.Font fntColumnHeader = new iTextSharp.text.Font(btnColumnHeader, 14, 0, iTextSharp.text.BaseColor.WHITE);

             for (int i = 0; i < dgvTable.Columns.Count; i++)
             {
                 PdfPCell cell = new PdfPCell();
                 cell.BackgroundColor = iTextSharp.text.BaseColor.DARK_GRAY;
                 cell.AddElement(new Chunk(dgvTable.Columns[i].HeaderText, fntColumnHeader));

                 tabl.AddCell(cell);
             }
         
            for (int i = 0; i < dgvTable.Rows.Count; i++)
            {
                for (int j = 0; j < dgvTable.Columns.Count; j++)
                {
                    tabl.AddCell(Convert.ToString(dgvTable.Rows[i].Cells[j].Value));

                }
            }


            
            document.Add(tabl);
            Paragraph foot = new Paragraph("\nPor un total de: Lps: " + Label_Total.Text +
        "\nAttentamente. \nLa Gerencia.");
            document.Add(foot);
            document.Add(new Chunk("\n", fntHead));
              document.Close();
                writer.Close();
                fs.Close();
           
        }
    }
}
