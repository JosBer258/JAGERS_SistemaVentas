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
    public partial class Form_PantallaDeArqueo : System.Windows.Forms.Form
    {
        Desarrollo.Clases.Validaciones Val = new Clases.Validaciones();

        public Form_PantallaDeArqueo()
        {
            InitializeComponent();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form_PantallaDeArqueo_Load(object sender, EventArgs e)
        {
            ExtraerFechaNacimientoPermitida(ComBox_Año);
            extraerTransacciones(dataGridView1);
            Radii_BuscarTransaccionesMesActaul.Checked = true;

            
            Txt_TotalEfectivo.Text = Convert.ToString(MontoActual(2));
            Txt_PorTargetas.Text = Convert.ToString(MontoActual(3));
            Txt_Creditos.Text = Convert.ToString(MontoActual(1));
            Txt_NumTotalVentas.Text = Convert.ToString(SacarNumeroVentasActuales());

        }

        private void Bttn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        public void extraerTransacciones(DataGridView dgv)
        {

            Conexion con = new Conexion();
            con.cnx.Open();
            try
            {
                con.sql = string.Format
                (@"select
A.Codigo_Transaccion as [Código de Transacción],
	               A.Numero_Documento as [No. de Documento],
	               B.Descripcion as [Tipo de Transacción],
	               C.Descripcion as [Tipo de Documentación],
	               A.Fecha as [Fecha de Realización],
	               A.Monto as [Monto Total],
	               D.Nombre +space(2)+ D.Apellido as [Nombre del Cliente],
	               A.Fecha_Vencimiento as [Fecha de Vencimiento],
	               A.ID_Transacion_Padre as [ID de Transacción Padre],
	               E.Porcentaje_Mora as [Porcentaje de Mora],
                   (Select F.Descripcion_Estado from Estados as F where F.Codigo_Estado=A.Codigo_Estado and F.Descripcion_Estado like '%Transac%')
                    FROM [dbo].[Transacciones] as A
                    inner join [dbo].[Tipo_Transaccion] as B
                    on A.Codigo_Tipo_Transaccion = B.Codigo_TipoTransaccion
                    inner join [dbo].[Tipos_Documentos] as C
                    on A.Codigo_Tipo_Documento = C.Codigo_TipoDeDocumento
                    left join [dbo].[Clientes] as D
                    on A.Codigo_Cliente = D.Codigo_Cliente
                    left join [dbo].[Mora] as E
                    on A.Codigo_Mora = E.Codigo_Mora
                    where MONTH(A.Fecha)=MONTH(GETDATE())");
                con.cmd = new SqlCommand(con.sql, con.cnx);
                con.DataAdapter = new SqlDataAdapter(con.cmd);
                con.dt = new DataTable();
                con.DataAdapter.Fill(con.dt);
                dgv.DataSource = con.dt;

                con.cnx.Close();

            }
            catch
            {

            }
        }

        private void Radii_BuscarTransaccionesMesActaul_CheckedChanged(object sender, EventArgs e)
        {
            if (Radii_BuscarTransaccionesMesActaul.Checked == true)
            {
                ComBox_Mess.Enabled=false;
                ComBox_Año.Enabled = false;
            }
            else
            {
                ComBox_Mess.Enabled = true;
                ComBox_Año.Enabled = true;
            }
        }

        public void ExtraerFechaNacimientoPermitida(ComboBox Combo)
        {
            int años = 0;
            años = DateTime.Now.Year;
            for (int i = (años - 60); i <= (años); i++)
            {
                Combo.Items.Add(i);
            }
        }


        private void Bttn_Generar_Click(object sender, EventArgs e)
        {
            if (Radii_BuscarTransaccionesMesActaul.Checked==true) {

                extraerTransacciones(dataGridView1);
                Txt_TotalEfectivo.Text = Convert.ToString(MontoActual(2));
                Txt_PorTargetas.Text = Convert.ToString(MontoActual(3));
                Txt_Creditos.Text = Convert.ToString(MontoActual(1));
                Txt_NumTotalVentas.Text = Convert.ToString(SacarNumeroVentasActuales());

            } else {

                if (ComBox_Mess.SelectedIndex == -1 || ComBox_Año.SelectedIndex==-1)
                {
                    MessageBox.Show("Debe elegir un Mes y un Año","Error de solicitud",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    return;
                }

                int m, a;
                m = Convert.ToInt16(ComBox_Mess.SelectedIndex) +2;
                a = Convert.ToInt16(ComBox_Año.SelectedItem);
                LlenarPorFecha(dataGridView1, m, a);
                Txt_NumTotalVentas.Text = Convert.ToString(SacarNumeroManual(m, a));
                Txt_TotalEfectivo.Text = Convert.ToString(MontoPropuesta(2, m,a));
                Txt_PorTargetas.Text = Convert.ToString(MontoPropuesta(3, m, a));
                Txt_Creditos.Text = Convert.ToString(MontoPropuesta(1, m, a));
            }
        }


        public void LlenarPorFecha(DataGridView dgv, int mes, int año)
        {
            Conexion con = new Conexion();
            con.cnx.Open();
            try
            {
                con.sql = string.Format
                (@"select
A.Codigo_Transaccion as [Código de Transacción],
	               A.Numero_Documento as [No. de Documento],
	               B.Descripcion as [Tipo de Transacción],
	               C.Descripcion as [Tipo de Documentación],
	               A.Fecha as [Fecha de Realización],
	               A.Monto as [Monto Total],
	               D.Nombre +space(2)+ D.Apellido as [Nombre del Cliente],
	               A.Fecha_Vencimiento as [Fecha de Vencimiento],
	               A.ID_Transacion_Padre as [ID de Transacción Padre],
	               E.Porcentaje_Mora as [Porcentaje de Mora],
                   (Select F.Descripcion_Estado from Estados as F where F.Codigo_Estado=A.Codigo_Estado and F.Descripcion_Estado like '%Transac%')
                    FROM [dbo].[Transacciones] as A
                    inner join [dbo].[Tipo_Transaccion] as B
                    on A.Codigo_Tipo_Transaccion = B.Codigo_TipoTransaccion
                    inner join [dbo].[Tipos_Documentos] as C
                    on A.Codigo_Tipo_Documento = C.Codigo_TipoDeDocumento
                    left join [dbo].[Clientes] as D
                    on A.Codigo_Cliente = D.Codigo_Cliente
                    left join [dbo].[Mora] as E
                    on A.Codigo_Mora = E.Codigo_Mora
                   where MONTH(A.Fecha)='{0}' and year(A.Fecha)='{1}'",mes, año );
                con.cmd = new SqlCommand(con.sql, con.cnx);
                con.DataAdapter = new SqlDataAdapter(con.cmd);
                con.dt = new DataTable();
                con.DataAdapter.Fill(con.dt);
                dgv.DataSource = con.dt;

                con.cnx.Close();

            }
            catch
            {

            }
        }



        private double MontoActual(int Tipo)
        {
            Conexion Conex = new Conexion();
            double Var = 0;


            Conex.sql = string.Format(@"select sum(CAST(A.Monto as decimal(12,2))) as A from Transacciones as
                                        A where MONTH(A.Fecha)=MONTH(GETDATE()) and A.Codigo_Tipo_Transaccion='{0}'", Tipo);
            Conex.cmd = new SqlCommand(Conex.sql, Conex.cnx);
            Conex.cnx.Open();

            SqlDataReader Reg = null;
            Reg = Conex.cmd.ExecuteReader();

            if (Reg.Read())
            {

                try
                {
                    Var = Convert.ToDouble((Reg["A"].ToString()));
                }
                catch { }

            }
            Conex.cnx.Close();
            return Var;
        }



        private double MontoPropuesta(int Tipo, int Mes, int Año)
        {
            Conexion Conex = new Conexion();
            double Var = 0;


            Conex.sql = string.Format(@"select sum(CAST(A.Monto as decimal(12,2))) as A from Transacciones as
                                        A where MONTH(A.Fecha)='{0}' and YEAR(A.Fecha)='{1}' and A.Codigo_Tipo_Transaccion='{2}'",Mes,Año,Tipo);
            Conex.cmd = new SqlCommand(Conex.sql, Conex.cnx);
            Conex.cnx.Open();

            SqlDataReader Reg = null;
            Reg = Conex.cmd.ExecuteReader();

            if (Reg.Read())
            {
                try
                {

                    Var = Convert.ToDouble((Reg["A"].ToString()));
                }
                catch
                {

                }
                

            }
            Conex.cnx.Close();
            return Var;
        }

        private int SacarNumeroVentasActuales()
        {
            int Cant = 0;
            Conexion Conex = new Conexion();


            Conex.sql = string.Format(@"select COUNT(A.Cod_Factura) as B from Facturas as A inner join Transacciones as B on A.Cod_Factura=B.Numero_Documento where MONTH( B.Fecha)=MONTH(GETDATE())");
            Conex.cmd = new SqlCommand(Conex.sql, Conex.cnx);
            Conex.cnx.Open();

            SqlDataReader Reg = null;
            Reg = Conex.cmd.ExecuteReader();

            if (Reg.Read())
            {
                try
                {
                    Cant = Convert.ToInt32((Reg["B"].ToString()));
                }
                catch { }

            }
            Conex.cnx.Close();

            return Cant;

        }


        private int SacarNumeroManual(int Mes, int Año)
        {
            int Cant = 0;
            Conexion Conex = new Conexion();


            Conex.sql = string.Format(@"select COUNT(A.Cod_Factura) as B from Facturas as A inner join Transacciones as B
on A.Cod_Factura=B.Numero_Documento where MONTH( B.Fecha)='{0}' and YEAR(B.Fecha)='{1}'", Mes, Año);
            Conex.cmd = new SqlCommand(Conex.sql, Conex.cnx);
            Conex.cnx.Open();

            SqlDataReader Reg = null;
            Reg = Conex.cmd.ExecuteReader();

            if (Reg.Read())
            {
                try
                {

                    Cant = Convert.ToInt32((Reg["B"].ToString()));
                }
                catch { }
            }
            Conex.cnx.Close();

            return Cant;
        }
    }
}
