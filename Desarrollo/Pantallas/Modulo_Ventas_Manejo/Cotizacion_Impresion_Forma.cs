using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desarrollo.Pantallas.Modulo_Ventas_Manejo
{
    public partial class Cotizacion_Impresion_Forma : System.Windows.Forms.Form
    {
        public string NomCliente, NomEmpleado, FechaRealizacion, Total, FechaFinal;

        public Cotizacion_Impresion_Forma()
        {
            InitializeComponent();
        }
        public List<Cotizaccion_LlenadoDeDataGriew> Datos = new List<Cotizaccion_LlenadoDeDataGriew>();
        private void Cotizacion_Impresion_Forma_Load(object sender, EventArgs e)
        {
            ReportParameter p = new ReportParameter("NombreCliente", NomCliente);
            reportViewer1.LocalReport.SetParameters(p);

            ReportParameter A = new ReportParameter("NombreEmpleado", NomEmpleado);
            reportViewer1.LocalReport.SetParameters(A);

            ReportParameter B = new ReportParameter("Fecha", FechaRealizacion);
            reportViewer1.LocalReport.SetParameters(B);
            
            ReportParameter C = new ReportParameter("Total", Total);
            reportViewer1.LocalReport.SetParameters(C);

            ReportParameter E = new ReportParameter("FechaFinal", FechaFinal);
            reportViewer1.LocalReport.SetParameters(E);


            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", Datos));
            this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
