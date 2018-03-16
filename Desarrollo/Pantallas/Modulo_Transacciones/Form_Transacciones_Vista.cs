using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Desarrollo.Clases;
using System.Data.SqlClient;
using Desarrollo.Pantallas.Modulo_Creditos;


namespace Desarrollo.Pantallas.Modulo_Transacciones
{
    public partial class Form_Transacciones_Vista : System.Windows.Forms.Form
    {
        Form_Creditos_CargarMora cargar = new Form_Creditos_CargarMora();
        public string Name;
        private string TipoTransaccion;
        private string Var_OptenerCodigoMora;


        public Form_Transacciones_Vista()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioTipos.Checked == true)
                cmbBxTipos.Enabled = true;
            else cmbBxTipos.Enabled = false;
        }

        private void Form_Transacciones_Vista_Load(object sender, EventArgs e)
        {
            extraerTransacciones(DGV_Transacciones);
            extraerEstados(cmbBxEstados);
            extraerTipoDoc(cmbBxTipoDoc);
            extraerTipoTrans(cmbBxTipos);
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            if (txtCodTrans.Text == string.Empty)
            {
                MessageBox.Show("Error: Seleccione una Transaccion", "Error de aplicacion de mora", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
                if (txtNumDoc.Text == string.Empty)
            {
                MessageBox.Show("Error: Este no es un documento Valido", "Error de aplicacion de mora", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (TipoTransaccion != "Credito")
            {
                MessageBox.Show("Debe selecionar una transaccion del tipo credito", "Error de aplicacion de mora", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            

            cargar.NOMBRE = Name;

            cargar.ShowDialog();



        }

        private void button5_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void cmbBxEstados_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(radioEstados.Checked == true)
                filtrarEstado(DGV_Transacciones,Convert.ToInt16( cmbBxEstados.SelectedValue));

        }

        private void cmbBxTipos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(radioTipos.Checked == true)
                 filtrarTipoTrans(DGV_Transacciones, Convert.ToInt16(cmbBxTipos.SelectedValue));
        }

        private void cmbBxTipoDoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(radioTipoDoc.Checked == true)
                 filtrarTipoDoc(DGV_Transacciones, Convert.ToInt16(cmbBxTipoDoc.SelectedValue));
        }

        private void DGV_Transacciones_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectFila(e);
        }

        private void radioTodas_CheckedChanged(object sender, EventArgs e)
        {
            if (radioTodas.Checked == true)
                extraerTransacciones(DGV_Transacciones);

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            filtarFechaVenc(DGV_Transacciones, dateTimePicker1.Value.Date.ToString());
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
                    on A.Codigo_Mora = E.Codigo_Mora");
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

        public void extraerEstados(ComboBox est)
        {
            Conexion Con = new Conexion();

            Con.cnx.Open();
            Con.sql = string.Format(@"SELECT Codigo_Estado, Descripcion_Estado FROM Estados WHERE Codigo_Tipo_Estado = 8");
            Con.cmd = new SqlCommand(Con.sql, Con.cnx);
            Con.DataAdapter = new SqlDataAdapter(Con.cmd);
            Con.dt = new DataTable();
            Con.DataAdapter.Fill(Con.dt);
            Con.cnx.Close();

            est.ValueMember = "Codigo_Estado";
            est.DisplayMember = "Descripcion_Estado";
            est.DataSource = Con.dt;
            
        }

        public void extraerTipoDoc(ComboBox tipoDoc)
        {
            Conexion Con = new Conexion();

            Con.cnx.Open();
            Con.sql = string.Format(@"SELECT Codigo_TipoDeDocumento, Descripcion FROM Tipos_Documentos");
            Con.cmd = new SqlCommand(Con.sql, Con.cnx);
            Con.DataAdapter = new SqlDataAdapter(Con.cmd);
            Con.dt = new DataTable();
            Con.DataAdapter.Fill(Con.dt);
            Con.cnx.Close();

            tipoDoc.ValueMember = "Codigo_TipoDeDocumento";
            tipoDoc.DisplayMember = "Descripcion";
            tipoDoc.DataSource = Con.dt;

        }

        public void extraerTipoTrans(ComboBox tipoTrans)
        {
            Conexion Con = new Conexion();

            Con.cnx.Open();
            Con.sql = string.Format(@"SELECT Codigo_TipoTransaccion, Descripcion FROM Tipo_Transaccion");
            Con.cmd = new SqlCommand(Con.sql, Con.cnx);
            Con.DataAdapter = new SqlDataAdapter(Con.cmd);
            Con.dt = new DataTable();
            Con.DataAdapter.Fill(Con.dt);
            Con.cnx.Close();

            tipoTrans.ValueMember = "Codigo_TipoTransaccion";
            tipoTrans.DisplayMember = "Descripcion";
            tipoTrans.DataSource = Con.dt;

        }

        public void filtrarEstado(DataGridView dgv, int a)
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
                    
                   WHERE A.Codigo_Estado =" + (a));
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

        public void filtrarTipoTrans(DataGridView dgv, int a)
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
                    
                   WHERE A.Codigo_Tipo_Transaccion =" + (a));
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

        public void filtrarTipoDoc(DataGridView dgv, int a)
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
                    
                   WHERE A.Codigo_Tipo_Documento =" + (a));
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

        private void radioEstados_CheckedChanged(object sender, EventArgs e)
        {
            if (radioEstados.Checked == true)
                cmbBxEstados.Enabled = true;
            else cmbBxEstados.Enabled = false;
        }

        private void radioTipoDoc_CheckedChanged(object sender, EventArgs e)
        {
            if (radioTipoDoc.Checked == true)
                cmbBxTipoDoc.Enabled = true;
            else cmbBxTipoDoc.Enabled = false;
        }

        private void radioFechaVen_CheckedChanged(object sender, EventArgs e)
        {
            if (radioFechaVen.Checked == true)
                dateTimePicker1.Enabled = true;
            else dateTimePicker1.Enabled = false;
        }

        public void selectFila(DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.DGV_Transacciones.Rows[e.RowIndex];
                TipoTransaccion = row.Cells["Tipo de Transacción"].Value.ToString();
                if (TipoTransaccion != "Credito")
                {
                    MessageBox.Show("Debe selecionar una transaccion del tipo credito", "Error de aplicacion de mora", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }              
                txtCodTrans.Text = row.Cells["Código de Transacción"].Value.ToString();
                txtNumDoc.Text = row.Cells["No. de Documento"].Value.ToString();
                txtMonto.Text = row.Cells["Monto Total"].Value.ToString();               
                dateTimePicker3.Value = Convert.ToDateTime(row.Cells["Fecha de Vencimiento"].Value.ToString());



                DataGridViewRow fil = DGV_Transacciones.Rows[e.RowIndex];
                cargar.Txt_CodigoTransaccionMora.Text = Convert.ToString(fil.Cells[0].Value);
                cargar.Txt_NombreClientes.Text = Convert.ToString(fil.Cells[6].Value);
                
            }
        }
                
        private void filtarFechaVenc(DataGridView dgv, string fechaVenc)
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
	               D.Nombre + space(2)+D.Apellido as [Nombre del Cliente],
	               A.Fecha_Vencimiento as [Fecha de Vencimiento],
	             
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
                    
                   WHERE A.Fecha_Vencimiento = '" + fechaVenc + "'");
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


        private void limpiar()
        {
            txtCodTrans.Text = string.Empty;
            txtNumDoc.Text = string.Empty;
            txtNumDoc.Text = string.Empty;
        }

        private void DGV_Transacciones_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.DGV_Transacciones.Rows[e.RowIndex];
            TipoTransaccion = row.Cells["Tipo de Transacción"].Value.ToString();
            if (TipoTransaccion != "Credito")
            {
                MessageBox.Show("Debe selecionar una transaccion del tipo credito", "Error de aplicacion de mora", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            txtCodTrans.Text = row.Cells["Código de Transacción"].Value.ToString();
            txtNumDoc.Text = row.Cells["No. de Documento"].Value.ToString();
            txtMonto.Text = row.Cells["Monto Total"].Value.ToString();     
            dateTimePicker3.Value= Convert.ToDateTime(row.Cells["Fecha de Vencimiento"].Value.ToString());
          
            DataGridViewRow fil = DGV_Transacciones.Rows[e.RowIndex];
            cargar.Txt_CodigoTransaccionMora.Text = Convert.ToString(fil.Cells[0].Value);
            cargar.Txt_NombreClientes.Text = Convert.ToString(fil.Cells[6].Value);
           
        }

        private void txtCodTrans_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            extraerTransacciones(DGV_Transacciones);
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void DGV_Transacciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
