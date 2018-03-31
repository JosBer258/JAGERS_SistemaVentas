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
        DateTime Var_Hoy = DateTime.Today;
        public string Var_fecha_actual;

        

        public string NomCliente="xxx", NomEmpleado = "xxx", FechaRealizacion = "xxx", Total, FechaFinal = "xxx";
        public string CodCai, CodigoFactura, Subtotal_R, Porcentaje_R, Impuesto_r;

        private void reportViewer1_Load(object sender, EventArgs e)
        {
          
        }

        public Cotizacion_Impresion_Forma()
        {
            InitializeComponent();
        }
        public List<Cotizaccion_LlenadoDeDataGriew> Datos = new List<Cotizaccion_LlenadoDeDataGriew>();
        private void Cotizacion_Impresion_Forma_Load(object sender, EventArgs e)
        {
            FechaRealizacion = Var_Hoy.ToString("dd-MM-yyyy");

            ReportParameter p = new ReportParameter("NombreCliente", NomCliente);

            reportViewer1.LocalReport.SetParameters(p);

        
            ReportParameter Sub = new ReportParameter("SubTotalRepor", Subtotal_R);
            reportViewer1.LocalReport.SetParameters(Sub);

            ReportParameter Por = new ReportParameter("PorcentajeImpRepor", Porcentaje_R);
            reportViewer1.LocalReport.SetParameters(Por);

            ReportParameter Imp = new ReportParameter("ImpuestoR", Impuesto_r);
            reportViewer1.LocalReport.SetParameters(Imp);




            ReportParameter B = new ReportParameter("Fecha", FechaRealizacion);
            reportViewer1.LocalReport.SetParameters(B);
            
            ReportParameter C = new ReportParameter("Total", Total);
            reportViewer1.LocalReport.SetParameters(C);


            ReportParameter CCai = new ReportParameter("CodigoCai", CodCai);
            reportViewer1.LocalReport.SetParameters(CCai);

            ReportParameter CoFac = new ReportParameter("CodFactura", CodigoFactura);
            reportViewer1.LocalReport.SetParameters(CoFac);

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
