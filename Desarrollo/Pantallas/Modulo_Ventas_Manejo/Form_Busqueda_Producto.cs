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
using Desarrollo.Clases;
using Desarrollo.Pantallas.Modulo_Ventas_Nuevas;

namespace Desarrollo.Pantallas.Modulo_Ventas_Manejo
{
    public partial class Form_Busqueda_Producto : System.Windows.Forms.Form
    {
        public string Localidad;

        public Form_Busqueda_Producto()
        {
            InitializeComponent();
        }

        private void Form_Busqueda_Producto_Load(object sender, EventArgs e)
        {
            ExtrearProducto(dataGridView1);

            var blankContextMenu = new ContextMenuStrip();
            textBox1.ContextMenuStrip = blankContextMenu;

        }

        public void ExtrearProducto(DataGridView dgv)
        {
            Conexion con = new Conexion();
            con.cnx.Open();
            try
            {

                con.sql = string.Format
                //(@"select * from Producto");
                (@"select A.Cod_Producto as 'Codigo del Producto', A.NombreProducto as 'Producto', A.Descripcion as 'Descripcion', D.Cantidad as 'Cantidad Existente',
                L.Cod_Localidad as 'Codigo de Localidad',L.Nombre as 'Localidad',
                CAST(A.PrecioVenta as decimal(10,2)) as 'Precio' from Producto A inner join [Producto|Localidad] as D on D.Cod_Producto=A.Cod_Producto inner join Localidad as L on D.Cod_Localidad=L.Cod_Localidad
                where  A.Cod_Estado= '1'");
                con.cmd = new SqlCommand(con.sql, con.cnx);
                con.DataAdapter = new SqlDataAdapter(con.cmd);
                con.dt = new DataTable();
                con.DataAdapter.Fill(con.dt);
                dgv.DataSource = con.dt;

            }
            catch
            {

            }
        }

        public void ExtraerPorNombreProducto(DataGridView dgv, string Nom)
        {
            Conexion con = new Conexion();
            con.cnx.Open();
            try
            {
                con.sql = string.Format
                //(@"select * from Producto where NombreProducto like '%{0}%'", Nom);
                (@"select A.Cod_Producto as 'Codigo del Producto',A.NombreProducto as 'Producto',A.Descripcion as 'Descripcion',D.Cantidad 
                as 'Cantidad Existente', L.Cod_Localidad as 'Codigo de Localidad',L.Nombre as 'Localidad',
                CAST(A.PrecioVenta as decimal(10,2)) as 'Precio' from Producto A inner join [Producto|Localidad] as D on D.Cod_Producto=A.Cod_Producto inner join Localidad as L on D.Cod_Localidad=L.Cod_Localidad
                where  A.NombreProducto like '%{0}%' and A.Cod_Estado= '1'", Nom); 
                con.cmd = new SqlCommand(con.sql, con.cnx);
                con.DataAdapter = new SqlDataAdapter(con.cmd);
                con.dt = new DataTable();
                con.DataAdapter.Fill(con.dt);
                dgv.DataSource = con.dt;

            }
            catch
            {

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == string.Empty)
            {
                ExtrearProducto(dataGridView1);
            }
            else
            {
                ExtraerPorNombreProducto(dataGridView1, textBox1.Text);
            }
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];

                Form_Ventas_Nuevas Marcos = Owner as Form_Ventas_Nuevas;

                if(this.Localidad== row.Cells["Codigo de Localidad"].Value.ToString())
                {
                    Marcos.txtcodigo.Text = row.Cells["Codigo del Producto"].Value.ToString();
                    Marcos.txtnombre.Text = row.Cells["Producto"].Value.ToString();
                    Marcos.txtcanExistente.Text = row.Cells["Cantidad Existente"].Value.ToString();
                    Marcos.txtprecioVenta.Text = row.Cells["Precio"].Value.ToString();
                    Marcos.txtcanExistente.Text = row.Cells["Cantidad Existente"].Value.ToString();

                    if (Localidad == "1")
                    {
                        Marcos.TotalBodega=OptenerBodega(Convert.ToInt32(Marcos.txtcodigo.Text));
                        Marcos.TotalTienda= Convert.ToInt32(row.Cells["Cantidad Existente"].Value.ToString());
                    }
                    this.Close();
                }
            }
            catch { }
    }
        public int OptenerBodega(int C_P)
        {
            int C=0;
            Conexion conn = new Conexion();

            conn.sql = string.Format(@"select Cantidad from [Producto|Localidad] where Cod_Localidad='2' and Cod_Producto='{0}'", C_P);
            conn.cmd = new SqlCommand(conn.sql, conn.cnx);
            conn.cnx.Open();
            SqlDataReader Reg = null;
            Reg = conn.cmd.ExecuteReader();

            if (Reg.Read())
            {

                C= Convert.ToInt16((Reg["Cantidad"].ToString()));
            }
            else
            {
                
            }
            conn.cnx.Close();
            return C;

        }


        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones Val = new Validaciones();

            Val.ValirLetrasYEspacios(sender, e, textBox1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
