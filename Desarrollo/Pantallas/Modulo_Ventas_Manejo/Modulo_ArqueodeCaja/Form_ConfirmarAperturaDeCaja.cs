using Desarrollo.Pantallas.Modulo_Ventas_Nuevas;
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
    public partial class Form_ConfirmarAperturaDeCaja : System.Windows.Forms.Form
    {
        Conexion Con = new Conexion();
        Desarrollo.Clases.Validaciones Val = new Clases.Validaciones();

        public string Codigo_Empleado;
        public string NombreEmpleado;
        public int Cod_ArqueoActual;
        public string Monto="";
        public bool Entrada;



        public Form_ConfirmarAperturaDeCaja()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Bttn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form_ConfirmarAperturaDeCaja_Load(object sender, EventArgs e)
        { // DATE_TIMEPICKET_BACKUP.Text;   EL QUE CAPTURA LA FECHA DE HOY

            var blankContextMenu = new ContextMenuStrip();
            Txt_COntraseñaCOnfirmacion.ContextMenuStrip = blankContextMenu;

            int DatosApertura= ExtraerDatosApertura();

            if (DatosApertura == 0 || DatosApertura == 4)
            {
                MessageBox.Show("No existe ninguna apertura programada \nContacte con su supervisor para mas información", "Error de Apertura", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
                
            }

            int RespuestaCierre = ExtraerCierreCaja(Convert.ToInt32(Codigo_Empleado));
            if (RespuestaCierre == 1)
            {
                MessageBox.Show("Ya se ha realizado el cierre de caja \nContacte con su supervisor para mas información", "Error de Apertura", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            if (ExtraerDatosApertura() == 1)
            {         
                    Form_Ventas_Nuevas Venta = new Form_Ventas_Nuevas();
                    Venta.NombreEmp = NombreEmpleado;
                    Venta.Cod_Empleado = Codigo_Empleado;
                    this.Close();
                    Venta.ShowDialog();            }
            
            Label_DineroRecibido.Text = Monto;
        }

        public int ExtraerCierreCaja(int C_Empleado)
        {
            int Respuesta=0;

            Con.sql = string.Format(@"select EstadoFinal from Arqueo_Detalles
                                      where Cod_Arqueo=(select top 1 Codigo_Arqueo from Arqueo 
                                       order by Codigo_Arqueo desc) and Cod_Empleado='{0}'", C_Empleado);

            Con.cmd = new SqlCommand(Con.sql, Con.cnx);
            Con.cnx.Open();

            SqlDataReader Reg = null;
            Reg = Con.cmd.ExecuteReader();

            if (Reg.Read())
            {
                Respuesta = (int)Convert.ToDouble((Reg["EstadoFinal"].ToString()));
            }
            else
            {

            }

            Con.cnx.Close();


            return Respuesta;
        }


        public int ExtraerDatosApertura()
        {
            string Fecha_R = String.Format("{0:yyyy-MM-dd}", DATE_TIMEPICKET_BACKUP.Value);
            int Cod_E =Convert.ToInt16(Codigo_Empleado);

            int Codigo = 0;
            
            Con.sql = string.Format(@"select * from Arqueo_Detalles as B inner join Arqueo as C on B.Cod_Arqueo=c.Codigo_Arqueo
            where Cod_Arqueo=(select Top 1 Codigo_Arqueo from Arqueo order by Codigo_Arqueo desc) 
            and Cod_Empleado='{0}' and C.Fecha_Realizacion='{1}'", Cod_E, Fecha_R);

            Con.cmd = new SqlCommand(Con.sql, Con.cnx);
            Con.cnx.Open();

            SqlDataReader Reg = null;
            Reg = Con.cmd.ExecuteReader();

            if (Reg.Read())
            {
                Codigo = Convert.ToInt16((Reg["EstadoInicial"].ToString()));
                Monto= Convert.ToString((Reg["MontoInicial"].ToString()));
                Cod_ArqueoActual = Convert.ToInt16((Reg["Codigo_Arqueo"].ToString()));
               

            }
            else
            {

            }

            Con.cnx.Close();
            return (Codigo);
        }

        private void ValidarContraseña(int C_Empleado, int C_Estado, string C_Con_Empleado, int C_Arqueo, int EstadoFinal)
        {
            string Contraseña = Val.EncriptarContraseña(C_Con_Empleado);

            Con.sql = string.Format(@"select * from Empleados where Codigo_Empleado='{0}' and Contraseña='{1}'", C_Empleado, Contraseña);

            Con.cmd = new SqlCommand(Con.sql, Con.cnx);
            Con.cnx.Open();

            SqlDataReader Reg = null;
            Reg = Con.cmd.ExecuteReader();

            if (Reg.Read())
            {
                Con.cnx.Close();
                Entrada = true;
                ActualizarDatos(C_Empleado, C_Estado, C_Arqueo, EstadoFinal);
            }
            else
            {
                MessageBox.Show("Credenciales Incorrectas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Con.cnx.Close();

            }

        }

        private void ActualizarDatos(int C_Empleado1, int C_Estado1, int C_Arqueo, int Estad_Final)
        {
            Con.sql = string.Format(@"update Arqueo_Detalles set EstadoInicial='{0}', EstadoFinal='{1}' where Cod_Empleado='{2}' and Cod_Arqueo='{3}' ", C_Estado1, Estad_Final, C_Empleado1, C_Arqueo );

            Con.cmd = new SqlCommand(Con.sql, Con.cnx);
            Con.cnx.Open();
            SqlDataReader Reg = null;
            Reg = Con.cmd.ExecuteReader();
            Con.cnx.Close();
        }

        //ACEPTACION DE APERTURA
        private void Bttn_Aceptar_Click(object sender, EventArgs e)
        {
            if (Txt_COntraseñaCOnfirmacion.Text == string.Empty)
            {
                MessageBox.Show("Ingrese la Contraseña","Error de Ingreso",MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ValidarContraseña(Convert.ToInt16(Codigo_Empleado),1, Txt_COntraseñaCOnfirmacion.Text, Cod_ArqueoActual, 2);

            if (Entrada == false)
            {
                return;
            }
            else
            {
                Form_Ventas_Nuevas Venta = new Form_Ventas_Nuevas();
                Venta.NombreEmp = NombreEmpleado;
                Venta.Cod_Empleado = this.Codigo_Empleado;
                this.Close();
                Venta.ShowDialog();
            }

        }

        //REHCAZO DE APERTURA
        private void Bttn_Rechazar_Click(object sender, EventArgs e)
        {

            DialogResult opcion;
            opcion = MessageBox.Show("¿Desea rechazar la confirmacion de la apertura?", "Aviso de Apertura", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (opcion == DialogResult.Yes)
            {
                ValidarContraseña(Convert.ToInt16(Codigo_Empleado), 3, Txt_COntraseñaCOnfirmacion.Text, Cod_ArqueoActual, 3);
            }
            else
            {
                return;
            }
                
            if (Entrada == true)
            {
                this.Close();
            }
            else
            {
                this.Close();
            }
        }


        private void Txt_COntraseñaCOnfirmacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            Val.ValidarPassword(sender, e);
        }
    }
}
