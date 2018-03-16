using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Desarrollo.Clases;
using Desarrollo.Pantallas.Modulo_Transacciones;
using Desarrollo.Pantallas.Modulo__Ingreso_al_sistema;

namespace Desarrollo.Pantallas.Modulo_Creditos
{
    public partial class Form_Creditos_CargarMora : System.Windows.Forms.Form
    {
        public int cod;
        int cliente;
        int padree;
        int mo_por;
        public string NOMBRE;
       

        C_Mora mo = new C_Mora();

        Form_Ingreso_Al_Sistema emp = new Form_Ingreso_Al_Sistema();
        public Form_Creditos_CargarMora()
        {
            InitializeComponent();
            
        }

        public void total()
        {            
           // Txt_TotalAAplicar.Text = Convert.ToString(float.Parse(Txt_PorcentajeDeMora.Text) * float.Parse(Txt_MontoTotalDeFactura.Text));      
        }
       public void hoy()
        {
            DateTime fecha = DateTime.Now;
            Text_Fecha_Mora.Text = fecha.ToShortDateString();
        }
        public int c_clinte()
        {
            int clie = 0;
            Conexion conn = new Conexion();
            conn.cnx.Open();
            conn.sql = string.Format("Select Codigo_Cliente from Transacciones where Codigo_Transaccion = '{0}'",Convert.ToInt16( Txt_CodigoTransaccionMora.Text));
            conn.cmd = new SqlCommand(conn.sql, conn.cnx);
            SqlDataReader Reg = null;
            Reg = conn.cmd.ExecuteReader();
            try
            {
                if (Reg.Read())
                {
                    clie = Convert.ToInt32(Reg["Codigo_Cliente"]);
                }

            }
            catch { }
            conn.cnx.Close();
            return (clie);
        }
        public int i_Padre()
        {
            int padre = 0;
            Conexion conn = new Conexion();
            conn.cnx.Open();
            conn.sql = string.Format("Select ID_Transacion_Padre from Transacciones where Codigo_Transaccion = '{0}'", Convert.ToInt16(Txt_CodigoTransaccionMora.Text));
            conn.cmd = new SqlCommand(conn.sql, conn.cnx);
            SqlDataReader Reg = null;
            Reg = conn.cmd.ExecuteReader();
            try
            {
                if (Reg.Read())
                {
                    padre = Convert.ToInt32(Reg["ID_Transacion_Padre"]);
                }

            }
            catch { }
            conn.cnx.Close();
            return (padre);
        }
        public int c_mora()
        {
            int m_por = 0;
            Conexion conn = new Conexion();
            conn.cnx.Open();
            conn.sql = string.Format("Select Codigo_Mora from Transacciones where Codigo_Transaccion = '{0}'", Convert.ToInt16(Txt_CodigoTransaccionMora.Text));
            conn.cmd = new SqlCommand(conn.sql, conn.cnx);
            SqlDataReader Reg = null;
            Reg = conn.cmd.ExecuteReader();
            try
            {
                if (Reg.Read())
                {
                    m_por = Convert.ToInt32(Reg["Codigo_Mora"]);
                }

            }
            catch { }
            conn.cnx.Close();
            return (m_por);
        }



        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Bttn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form_Creditos_CargarMora_Load(object sender, EventArgs e)
        {
            Text_Nombre_Empleado.Text = NOMBRE;
            total();
            Txt_Codigo_Transaccion.Text = Convert.ToString(mo.Nuevocodigo());
            hoy();
           
        }



        private void Text_Fecha_Mora_TextChanged(object sender, EventArgs e)
        {
            
            
            
        }

        private void Txt_TotalAAplicar_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void Bttn_Guardar_Click(object sender, EventArgs e)
        {
            cliente = c_clinte();
            padree = i_Padre();
            mo_por = c_mora();
            float Pr = (float)Convert.ToDouble(Txt_TotalAAplicar.Text);      
            int transaccion = 1006;
            int documento = 3;
            int estado = 1;

            mo.tabla(estado, transaccion, documento, Pr  , cliente ,
                Convert.ToInt16(Txt_CodigoTransaccionMora.Text) , mo_por);
            MessageBox.Show("Se ha realizado la Operacion con exito","Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();

            



        }
    }
}
