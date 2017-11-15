using Desarrollo.Pantallas.Estados;///COMPLETO
using Desarrollo.Pantallas.Modulo___Productos;
using Desarrollo.Pantallas.Modulo___Proveedores;
using Desarrollo.Pantallas.Modulo_Ventas_Nuevas;//
using Desarrollo.Pantallas.Modulo__Empleados;///COMPLETO
using Desarrollo.Pantallas.Modulo__Ingreso_al_sistema;
using Desarrollo.Pantallas.Modulo_Creditos;
using Desarrollo.Pantallas.Modulo_Transacciones;



using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Desarrollo.Pantallas.Modulo_Compras;
using Desarrollo.Pantallas.Modulo_Ventas_Manejo;
using Desarrollo.Pantallas.Modulo_Ventas_Manejo.Modulo_ArqueodeCaja;

namespace Desarrollo.Pantallas.Modulo__Ingreso_al_sistema
{
    public partial class Menu_Principal : Form
    {
        public string ID_Empleado, Empleado_Nombre, CodigoRol, Empleado_Contraseña;

        public Menu_Principal()
        {
            InitializeComponent();
        }

        private void manejoDeEmpleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Pantalla del Manejo del Empleado
            Form_Manejo_de_Empleados Empleados = new Form_Manejo_de_Empleados();
            Empleados.ShowDialog();
            //*******************************************************************
        }

        private void manejoDeRolesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Pantallas manejo de Roles 
            Form_ManejoRoles Roles = new Form_ManejoRoles();
            Roles.ShowDialog();
            //************************************************************.
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {   
            //Pantalla de manejo de Clientes
            Form_ManejoClientes Clientes = new Form_ManejoClientes();
            Clientes.ShowDialog();
            //*************************************************************
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Pantalla de manejo de Productos
            Form_Productos_ManejoProductos ManejoProductos = new Form_Productos_ManejoProductos();
            ManejoProductos.ShowDialog();
            //******************************************************************
        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {

            //Apertura de la Pantalla para Manejo de los Proveedores y sus contactos.
            Form_Proveedores_Manejo ManejoProveedores = new Form_Proveedores_Manejo();
            ManejoProveedores.ShowDialog();
            //**********************************************************************.

        }

        private void mantenimientoDeTransaccionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Pantallas de Mantenimiento de Tipos y documentos Transicciones
            Form_MantenimientoTransacciones Transacciones = new Form_MantenimientoTransacciones();
            Transacciones.ShowDialog();
            //************************************************************************************
        }

        private void vistaDeTransaccionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ///Pantalla de Vista de Transacciones
            Form_Transacciones_Vista VistaTransacciones = new Form_Transacciones_Vista();
            VistaTransacciones.ShowDialog();
            //***************************************************************************
        }

        private void mantenimientoDeMoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Pantalla de Mantenimienro de la Mora
            Form_Mantenimiento_Mora MoraMantinimiento = new Form_Mantenimiento_Mora();
            MoraMantinimiento.ShowDialog();
            //************************************************************************

        }

        private void cobrarFacturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Pantalla de Cobro de Credito
            Form_Credito_CobroCredito CobrarCreditos = new Form_Credito_CobroCredito();
            CobrarCreditos.ShowDialog();
            //***********************************************************************

        }

        private void comprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Pantallas de manejo de Compras
            Form_ManejoComprasCompleto Compras = new Form_ManejoComprasCompleto();
            Compras.ShowDialog();
            //***********************************************************************
            
        }

        private void estadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Pantalla de mantenimiento de los estados
            Form_MantenimientoEstados Estados = new Form_MantenimientoEstados();
            Estados.ShowDialog();
            //*************************************************************************+
        }

        private void comprasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
          
        }

        private void mantenimientoDeCaiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Pantalla de Mantenimiento de Cai
            Form_MantenimientoCai Cai = new Form_MantenimientoCai();
            Cai.ShowDialog();
            //*************************************************************

         }

        private void nuevaVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Pantalla de Nueva Venta
            Form_Ventas_Nuevas Venta = new Form_Ventas_Nuevas();
            Venta.ShowDialog();
            //************************************************************
        }

        private void mantenimientoDeImpuestoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void manejoDeImpuestosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_MantenimientoImpuestos Impuestos = new Form_MantenimientoImpuestos();
        }

        private void Menu_Empleado_Click(object sender, EventArgs e)
        {

        }

        private void ventasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pantallaDeSalidaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Pantalla de confirmacion de Cierre
            Form_PantallCierreConfirmacion Cierre = new Form_PantallCierreConfirmacion();
            Cierre.ShowDialog();
            //************************************************************************************
        }

        private void creditosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aplicacionDeMoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Pantalla de Cargar Mora 
            Form_Creditos_CargarMora CargarMora = new Form_Creditos_CargarMora();
            CargarMora.ShowDialog();
            //********************************************************************
        }

        private void realizarCotizacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Pantalla de Realizar Cotizaciones
            Form_RealizarCotizaciones Cotizaciones = new Form_RealizarCotizaciones();
            Cotizaciones.ShowDialog();
            //************************************************************************
        }

        private void busqueDeVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Pantalla de Busqueda de la Facturas
            Form_BusquedaFacturas Buscar = new Form_BusquedaFacturas();
            Buscar.ShowDialog();
            //***************************************************************************
        }

        private void aperturaDeCajaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Pantalla de Apertura de Caja
            Form_PantallaManejoAperturaCaja Apertura = new Form_PantallaManejoAperturaCaja();
            Apertura.ShowDialog();
            //************************************************************************************
        }

        private void historialDeArqueoDeCajaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void arqueoDeCajaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //Pantalla de arqueo de caja a final de cada mes
            Form_PantallaDeArqueo Arqueo = new Form_PantallaDeArqueo();
            Arqueo.ShowDialog();
            //*************************************************************************************
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /////Pantalla de Cambio de Contraseña
            Form__Ingreso_NuevaContraseña NuevaContraseña = new Form__Ingreso_NuevaContraseña();
            NuevaContraseña.base_Contraseña= Empleado_Contraseña;
            NuevaContraseña.base_ID = ID_Empleado;
            NuevaContraseña.ShowDialog();
            //****************************************************************************************
        }




        private void logOutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DialogResult opcion;
            opcion = MessageBox.Show("¿Desea salir del sistema?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (opcion == DialogResult.Yes)
                MessageBox.Show("El Usuario ha salido correctamente", "", MessageBoxButtons.OK);
            Form_Ingreso_Al_Sistema Ingreso = new Form_Ingreso_Al_Sistema();

            this.Close();
            Ingreso.Show();
        }

        private void Menu_Principal_Load(object sender, EventArgs e)
        {
            if (Convert.ToInt16(CodigoRol) == 1)//Gerente --- x
            {
                productosToolStripMenuItem.Visible = true;
                proveedoresToolStripMenuItem.Visible = true;
                logOutToolStripMenuItem.Visible = true;
                logOutToolStripMenuItem1.Visible = true;
                clientesToolStripMenuItem.Visible = true;
                Menu_Empleado.Visible = true;
                ventasToolStripMenuItem.Visible = true;
                transaccionesToolStripMenuItem.Visible = true;
                creditosToolStripMenuItem.Visible = true;
                comprasToolStripMenuItem.Visible = true;
                Menu_Empleado.Visible = true;

                //Extras
                mantenimientoDeCaiToolStripMenuItem.Visible = true;
                nuevaVentaToolStripMenuItem.Visible = true;
                arqueoDeCajaToolStripMenuItem.Visible = true;
                realizarCotizacionesToolStripMenuItem.Visible = true;
                busqueDeVentasToolStripMenuItem.Visible = true;
                manejoDeImpuestosToolStripMenuItem.Visible = true;
                pantallaDeSalidaToolStripMenuItem.Visible = true;

            }
            else if (Convert.ToInt16(CodigoRol) == 2)//Vendedor
            {
                // Estados, proveedores
                Menu_Empleado.Visible = false;
                //Ventas
                mantenimientoDeCaiToolStripMenuItem.Visible = false;
                arqueoDeCajaToolStripMenuItem.Visible = false;
                manejoDeImpuestosToolStripMenuItem.Visible = false;
                //
                transaccionesToolStripMenuItem.Visible = false;
                creditosToolStripMenuItem.Visible = false;
                comprasToolStripMenuItem.Visible = false;
                estadosToolStripMenuItem.Visible = false;
                proveedoresToolStripMenuItem.Visible = false;

            }
            else if (Convert.ToInt16(CodigoRol) == 3)//Agente de Cobros
            {
                Menu_Empleado.Visible = false;
                comprasToolStripMenuItem.Visible = false;
                productosToolStripMenuItem.Visible = false;
                proveedoresToolStripMenuItem.Visible = false;
                ventasToolStripMenuItem.Visible = false;
                estadosToolStripMenuItem.Visible= false;
            }
            else if (Convert.ToInt16(CodigoRol) == 4)//Agente de Bodega----x
            {
                Menu_Empleado.Visible = false;
                creditosToolStripMenuItem.Visible = false;
                estadosToolStripMenuItem.Visible = false;
                transaccionesToolStripMenuItem.Visible = false;
                clientesToolStripMenuItem.Visible = true;
                ventasToolStripMenuItem.Visible = false;
            }
        }
    }
}
