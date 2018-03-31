using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
    public partial class Form_ConfirmImprCredito : Form
    {
        public Form_ConfirmImprCredito()
        {
            InitializeComponent();
        }

        private void Bttn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form_ConfirmImprCredito_Load(object sender, EventArgs e)
        {

        }

        public void limpiar()
        {
            DGV_Datos.Rows.Clear();
            Var_Cliente.Text = "Cliente";
        }

        private void Bttn_Generar_Click(object sender, EventArgs e)
        {

            if (DGV_Datos.RowCount == 0)
            {
                MessageBox.Show("No se a realizado ningun pago", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            InformeA();


        }



        private void InformeA()
        {
            string Var_NombreCliente = Var_Cliente.Text;
            DateTime Var_Hoy = DateTime.Today;
            string Var_fecha_actual = Var_Hoy.ToString("dd-MM-yyyy");
            try
            {
                
                string Nombre = "Cotizacion" + Var_fecha_actual + "-" + Var_NombreCliente;
                string Ruta = @"C:\Rogers\Informes de Pago de Creditos\" + Nombre + ".pdf";

                ExportDataTableToPdf(DGV_Datos, Ruta, "Cotizacion de Inventario");
                System.Diagnostics.Process.Start(Ruta);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message");
            }
        }


        void ExportDataTableToPdf(DataGridView dgvTable, String strPdfPath, string strHeader)
        {
            
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

            Paragraph prgAuthor = new Paragraph();
            BaseFont btnAuthor = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
            iTextSharp.text.Font fntAuthor = new iTextSharp.text.Font(btnAuthor, 10, 2, iTextSharp.text.BaseColor.BLACK);
            prgAuthor.Alignment = Element.ALIGN_RIGHT;
            prgAuthor.Add(new Chunk("\nRogers Truck presenta informe de pago de facturas al credito el dia: " + DateTime.Now.ToShortDateString(), fntAuthor));
            document.Add(prgAuthor);

            iTextSharp.text.Image PNG = iTextSharp.text.Image.GetInstance("Pictures/Logo.png");
            PNG.ScalePercent(30f);
            PNG.SetAbsolutePosition(document.PageSize.Width - 40f - 530f, document.PageSize.Height - 100f);
            document.Add(PNG);
            Paragraph p = new Paragraph("\nPor el cliente: " + Var_Cliente.Text);
            document.Add(p);
            document.Add(new Chunk("\n", fntHead));
            string Var_Descripcion;
           
            for (int i = 0; i < DGV_Datos.Rows.Count; i++)
            {
                Cotizaccion_LlenadoDeDataGriew Cot = new Cotizaccion_LlenadoDeDataGriew();
                Var_Descripcion = Convert.ToString("\nNumero de Factura " + (string)this.DGV_Datos.Rows[i].Cells[0].Value + "\nPago actual de la factura: " + (string)this.DGV_Datos.Rows[i].Cells[1].Value + "\nMonto restante de la factura: " + Convert.ToString(this.DGV_Datos.Rows[i].Cells[2].Value));
                Paragraph Var_Cont = new Paragraph(Var_Descripcion);
                document.Add(Var_Cont);
            }


            Paragraph foot = new Paragraph("\nAttentamente. \nLa Gerencia.");
            document.Add(foot);
            document.Add(new Chunk("\n", fntHead));
            document.Close();
            writer.Close();
            fs.Close();

        }

    }
}
