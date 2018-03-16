namespace Desarrollo.Pantallas.Modulo___Proveedores
{
    partial class Form_Proveedores_Manejo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.PestañasManejoClientes = new System.Windows.Forms.TabControl();
            this.Pest1 = new System.Windows.Forms.TabPage();
            this.Pest1_Bttn_Limpiar = new System.Windows.Forms.Button();
            this.Pest1_Grupo_ContactosDeProveedor = new System.Windows.Forms.GroupBox();
            this.Pest1_Bttn_LimpiarCont = new System.Windows.Forms.Button();
            this.Pest1_Bttn_AgregarCont = new System.Windows.Forms.Button();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.Pest1_Txt__ContactoNombre = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.Pest1_Txt__ContactoCodigo = new System.Windows.Forms.TextBox();
            this.Pest1_Txt__ContactoTelefono = new System.Windows.Forms.TextBox();
            this.Pest1_Txt__ContactoCorreo = new System.Windows.Forms.TextBox();
            this.Pest1_Txt__ContactoRol = new System.Windows.Forms.TextBox();
            this.Pest1_Txt__ContactoApellido = new System.Windows.Forms.TextBox();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.Codigo_Contacto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre_Contacto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido_Contacto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo_Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo_Proveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pest1_Bttn_Guardar = new System.Windows.Forms.Button();
            this.Pest1_Grupo_DatosDeProveedor = new System.Windows.Forms.GroupBox();
            this.Pest1_ComBox_Estados = new System.Windows.Forms.ComboBox();
            this.Pest1_ComBox_Nacionalidad = new System.Windows.Forms.ComboBox();
            this.Pest1_Txt__CodigoPostal = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.Pest1_Txt__Direccion = new System.Windows.Forms.TextBox();
            this.Pest1_Txt__Correo = new System.Windows.Forms.TextBox();
            this.Pest1_Txt__Nombre = new System.Windows.Forms.TextBox();
            this.Pest1_Txt__CodigoProveedor = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.Pest2 = new System.Windows.Forms.TabPage();
            this.Pest2_Grupo_MuestraDatos = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.proveedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ventasAutoPartesDataSet = new Desarrollo.VentasAutoPartesDataSet();
            this.Pest2_Grupo_Busqueda = new System.Windows.Forms.GroupBox();
            this.Pest2_Bttn_Limpiar = new System.Windows.Forms.Button();
            this.Pest2_Txt_CodigoBusqueda = new System.Windows.Forms.TextBox();
            this.Pest2_Txt_NombreBusqueda = new System.Windows.Forms.TextBox();
            this.Pest2_Radio_CodigoProveedor = new System.Windows.Forms.RadioButton();
            this.Pest2_Radio_NombreProveedor = new System.Windows.Forms.RadioButton();
            this.Pest3 = new System.Windows.Forms.TabPage();
            this.Pest3_Grupo_ContactosProveedor = new System.Windows.Forms.GroupBox();
            this.Pest3_DataG_ContactosProveedor = new System.Windows.Forms.DataGridView();
            this.contactoProveedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Pest3_Grupo_Manejo = new System.Windows.Forms.GroupBox();
            this.Pest3_Txt_Aceptar = new System.Windows.Forms.Button();
            this.Pest3_Bttn_Limpiar = new System.Windows.Forms.Button();
            this.Pest3_ComBx_Estado = new System.Windows.Forms.ComboBox();
            this.Pest3_ComBx_Nacionalidad = new System.Windows.Forms.ComboBox();
            this.Pest3_Txt_CodigoPostal = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.Pest3_Txt_Direccion = new System.Windows.Forms.TextBox();
            this.Pest3_Txt_CorreoElectronico = new System.Windows.Forms.TextBox();
            this.Pest3_Txt_Nombre = new System.Windows.Forms.TextBox();
            this.Pest3_Txt_Codigo = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Pest4 = new System.Windows.Forms.TabPage();
            this.Pest4_Grupo_OpcionesBusqueda = new System.Windows.Forms.GroupBox();
            this.Pest4_Txt_BuscarProvNombre = new System.Windows.Forms.TextBox();
            this.Pest4_Txt_BuscarCodigo = new System.Windows.Forms.TextBox();
            this.Pest4_Txt_BuscarNombre = new System.Windows.Forms.TextBox();
            this.Pest4_Radio_ProveedorBusqueda = new System.Windows.Forms.RadioButton();
            this.Pest4_Radio_CodigoBusqueda = new System.Windows.Forms.RadioButton();
            this.Pest4_Radio_NombreBusqueda = new System.Windows.Forms.RadioButton();
            this.Pest4_Grupo_DatosContacto = new System.Windows.Forms.GroupBox();
            this.Pest4_DataGrid_ManejoContactos = new System.Windows.Forms.DataGridView();
            this.Pest4_Grupo_ManejoDatos = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Pest4_ComBox_TelefonoFijoCodigo = new System.Windows.Forms.ComboBox();
            this.Pest1_Mask_NumeroFijoEmpleado = new System.Windows.Forms.MaskedTextBox();
            this.Pest4_Bttn_Limpiar = new System.Windows.Forms.Button();
            this.Pest4_Bttn_Aceptar = new System.Windows.Forms.Button();
            this.Pest4_CoBx_Estado = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Rol = new System.Windows.Forms.Label();
            this.Pest4_Txt_NombreCont = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Pest4_Txt_CodigoContac = new System.Windows.Forms.TextBox();
            this.Pest4_Txt_ApellidoCont = new System.Windows.Forms.TextBox();
            this.Pest4_Txt_CorreoContact = new System.Windows.Forms.TextBox();
            this.Pest4_Txt_RolContact = new System.Windows.Forms.TextBox();
            this.Pest4_Grupo_OpcionesManejo = new System.Windows.Forms.GroupBox();
            this.Pest4_Radio_Nuevo = new System.Windows.Forms.RadioButton();
            this.Pest4_Radio_BusqYManeji = new System.Windows.Forms.RadioButton();
            this.BTTN_Salir = new System.Windows.Forms.Button();
            this.contacto_ProveedorTableAdapter = new Desarrollo.VentasAutoPartesDataSetTableAdapters.Contacto_ProveedorTableAdapter();
            this.proveedorTableAdapter = new Desarrollo.VentasAutoPartesDataSetTableAdapters.ProveedorTableAdapter();
            this.fKProveedorHistoricoContactoProveedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.proveedor_HistoricoTableAdapter = new Desarrollo.VentasAutoPartesDataSetTableAdapters.Proveedor_HistoricoTableAdapter();
            this.fKProductoProveedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productoTableAdapter = new Desarrollo.VentasAutoPartesDataSetTableAdapters.ProductoTableAdapter();
            this.contactoProveedorBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.PestañasManejoClientes.SuspendLayout();
            this.Pest1.SuspendLayout();
            this.Pest1_Grupo_ContactosDeProveedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.Pest1_Grupo_DatosDeProveedor.SuspendLayout();
            this.Pest2.SuspendLayout();
            this.Pest2_Grupo_MuestraDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventasAutoPartesDataSet)).BeginInit();
            this.Pest2_Grupo_Busqueda.SuspendLayout();
            this.Pest3.SuspendLayout();
            this.Pest3_Grupo_ContactosProveedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pest3_DataG_ContactosProveedor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactoProveedorBindingSource)).BeginInit();
            this.Pest3_Grupo_Manejo.SuspendLayout();
            this.Pest4.SuspendLayout();
            this.Pest4_Grupo_OpcionesBusqueda.SuspendLayout();
            this.Pest4_Grupo_DatosContacto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pest4_DataGrid_ManejoContactos)).BeginInit();
            this.Pest4_Grupo_ManejoDatos.SuspendLayout();
            this.Pest4_Grupo_OpcionesManejo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fKProveedorHistoricoContactoProveedorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKProductoProveedorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactoProveedorBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // PestañasManejoClientes
            // 
            this.PestañasManejoClientes.Controls.Add(this.Pest1);
            this.PestañasManejoClientes.Controls.Add(this.Pest2);
            this.PestañasManejoClientes.Controls.Add(this.Pest3);
            this.PestañasManejoClientes.Controls.Add(this.Pest4);
            this.PestañasManejoClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PestañasManejoClientes.Location = new System.Drawing.Point(18, 13);
            this.PestañasManejoClientes.Margin = new System.Windows.Forms.Padding(4);
            this.PestañasManejoClientes.Name = "PestañasManejoClientes";
            this.PestañasManejoClientes.SelectedIndex = 0;
            this.PestañasManejoClientes.Size = new System.Drawing.Size(1087, 448);
            this.PestañasManejoClientes.TabIndex = 0;
            // 
            // Pest1
            // 
            this.Pest1.Controls.Add(this.Pest1_Bttn_Limpiar);
            this.Pest1.Controls.Add(this.Pest1_Grupo_ContactosDeProveedor);
            this.Pest1.Controls.Add(this.Pest1_Bttn_Guardar);
            this.Pest1.Controls.Add(this.Pest1_Grupo_DatosDeProveedor);
            this.Pest1.Location = new System.Drawing.Point(4, 22);
            this.Pest1.Margin = new System.Windows.Forms.Padding(4);
            this.Pest1.Name = "Pest1";
            this.Pest1.Padding = new System.Windows.Forms.Padding(4);
            this.Pest1.Size = new System.Drawing.Size(1079, 422);
            this.Pest1.TabIndex = 0;
            this.Pest1.Text = "Agregar a Proveedor";
            this.Pest1.UseVisualStyleBackColor = true;
            // 
            // Pest1_Bttn_Limpiar
            // 
            this.Pest1_Bttn_Limpiar.Location = new System.Drawing.Point(835, 99);
            this.Pest1_Bttn_Limpiar.Name = "Pest1_Bttn_Limpiar";
            this.Pest1_Bttn_Limpiar.Size = new System.Drawing.Size(133, 56);
            this.Pest1_Bttn_Limpiar.TabIndex = 17;
            this.Pest1_Bttn_Limpiar.Text = "Limpiar";
            this.Pest1_Bttn_Limpiar.UseVisualStyleBackColor = true;
            this.Pest1_Bttn_Limpiar.Click += new System.EventHandler(this.Pest1_Bttn_Limpiar_Click);
            // 
            // Pest1_Grupo_ContactosDeProveedor
            // 
            this.Pest1_Grupo_ContactosDeProveedor.Controls.Add(this.Pest1_Bttn_LimpiarCont);
            this.Pest1_Grupo_ContactosDeProveedor.Controls.Add(this.Pest1_Bttn_AgregarCont);
            this.Pest1_Grupo_ContactosDeProveedor.Controls.Add(this.label25);
            this.Pest1_Grupo_ContactosDeProveedor.Controls.Add(this.label26);
            this.Pest1_Grupo_ContactosDeProveedor.Controls.Add(this.Pest1_Txt__ContactoNombre);
            this.Pest1_Grupo_ContactosDeProveedor.Controls.Add(this.label28);
            this.Pest1_Grupo_ContactosDeProveedor.Controls.Add(this.label29);
            this.Pest1_Grupo_ContactosDeProveedor.Controls.Add(this.label30);
            this.Pest1_Grupo_ContactosDeProveedor.Controls.Add(this.label31);
            this.Pest1_Grupo_ContactosDeProveedor.Controls.Add(this.Pest1_Txt__ContactoCodigo);
            this.Pest1_Grupo_ContactosDeProveedor.Controls.Add(this.Pest1_Txt__ContactoTelefono);
            this.Pest1_Grupo_ContactosDeProveedor.Controls.Add(this.Pest1_Txt__ContactoCorreo);
            this.Pest1_Grupo_ContactosDeProveedor.Controls.Add(this.Pest1_Txt__ContactoRol);
            this.Pest1_Grupo_ContactosDeProveedor.Controls.Add(this.Pest1_Txt__ContactoApellido);
            this.Pest1_Grupo_ContactosDeProveedor.Controls.Add(this.dataGridView4);
            this.Pest1_Grupo_ContactosDeProveedor.Location = new System.Drawing.Point(7, 177);
            this.Pest1_Grupo_ContactosDeProveedor.Name = "Pest1_Grupo_ContactosDeProveedor";
            this.Pest1_Grupo_ContactosDeProveedor.Size = new System.Drawing.Size(1056, 238);
            this.Pest1_Grupo_ContactosDeProveedor.TabIndex = 2;
            this.Pest1_Grupo_ContactosDeProveedor.TabStop = false;
            this.Pest1_Grupo_ContactosDeProveedor.Text = "Contactos de Proveedor";
            // 
            // Pest1_Bttn_LimpiarCont
            // 
            this.Pest1_Bttn_LimpiarCont.Location = new System.Drawing.Point(944, 30);
            this.Pest1_Bttn_LimpiarCont.Name = "Pest1_Bttn_LimpiarCont";
            this.Pest1_Bttn_LimpiarCont.Size = new System.Drawing.Size(106, 50);
            this.Pest1_Bttn_LimpiarCont.TabIndex = 45;
            this.Pest1_Bttn_LimpiarCont.Text = "Limpiar";
            this.Pest1_Bttn_LimpiarCont.UseVisualStyleBackColor = true;
            this.Pest1_Bttn_LimpiarCont.Click += new System.EventHandler(this.Pest1_Bttn_LimpiarCont_Click);
            // 
            // Pest1_Bttn_AgregarCont
            // 
            this.Pest1_Bttn_AgregarCont.Location = new System.Drawing.Point(809, 27);
            this.Pest1_Bttn_AgregarCont.Name = "Pest1_Bttn_AgregarCont";
            this.Pest1_Bttn_AgregarCont.Size = new System.Drawing.Size(109, 51);
            this.Pest1_Bttn_AgregarCont.TabIndex = 44;
            this.Pest1_Bttn_AgregarCont.Text = "Agregar";
            this.Pest1_Bttn_AgregarCont.UseVisualStyleBackColor = true;
            this.Pest1_Bttn_AgregarCont.Click += new System.EventHandler(this.Pest1_Bttn_AgregarCont_Click);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(231, 50);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(26, 13);
            this.label25.TabIndex = 42;
            this.label25.Text = "Rol";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(451, 53);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(57, 13);
            this.label26.TabIndex = 41;
            this.label26.Text = "Telefono";
            // 
            // Pest1_Txt__ContactoNombre
            // 
            this.Pest1_Txt__ContactoNombre.Location = new System.Drawing.Point(92, 50);
            this.Pest1_Txt__ContactoNombre.MaxLength = 48;
            this.Pest1_Txt__ContactoNombre.Name = "Pest1_Txt__ContactoNombre";
            this.Pest1_Txt__ContactoNombre.Size = new System.Drawing.Size(108, 20);
            this.Pest1_Txt__ContactoNombre.TabIndex = 39;
            this.Pest1_Txt__ContactoNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Pest1_Txt__ContactoNombre_KeyPress);
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(451, 27);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(44, 13);
            this.label28.TabIndex = 38;
            this.label28.Text = "Correo";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(231, 24);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(52, 13);
            this.label29.TabIndex = 37;
            this.label29.Text = "Apellido";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(31, 50);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(50, 13);
            this.label30.TabIndex = 36;
            this.label30.Text = "Nombre";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(31, 24);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(46, 13);
            this.label31.TabIndex = 35;
            this.label31.Text = "Codigo";
            // 
            // Pest1_Txt__ContactoCodigo
            // 
            this.Pest1_Txt__ContactoCodigo.Enabled = false;
            this.Pest1_Txt__ContactoCodigo.Location = new System.Drawing.Point(92, 24);
            this.Pest1_Txt__ContactoCodigo.MaxLength = 5;
            this.Pest1_Txt__ContactoCodigo.Name = "Pest1_Txt__ContactoCodigo";
            this.Pest1_Txt__ContactoCodigo.Size = new System.Drawing.Size(108, 20);
            this.Pest1_Txt__ContactoCodigo.TabIndex = 34;
            this.Pest1_Txt__ContactoCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Pest1_Txt__ContactoCodigo_KeyPress);
            // 
            // Pest1_Txt__ContactoTelefono
            // 
            this.Pest1_Txt__ContactoTelefono.Location = new System.Drawing.Point(509, 50);
            this.Pest1_Txt__ContactoTelefono.MaxLength = 18;
            this.Pest1_Txt__ContactoTelefono.Name = "Pest1_Txt__ContactoTelefono";
            this.Pest1_Txt__ContactoTelefono.Size = new System.Drawing.Size(108, 20);
            this.Pest1_Txt__ContactoTelefono.TabIndex = 33;
            this.Pest1_Txt__ContactoTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Pest1_Txt__ContactoTelefono_KeyPress);
            // 
            // Pest1_Txt__ContactoCorreo
            // 
            this.Pest1_Txt__ContactoCorreo.Location = new System.Drawing.Point(509, 24);
            this.Pest1_Txt__ContactoCorreo.MaxLength = 48;
            this.Pest1_Txt__ContactoCorreo.Name = "Pest1_Txt__ContactoCorreo";
            this.Pest1_Txt__ContactoCorreo.Size = new System.Drawing.Size(107, 20);
            this.Pest1_Txt__ContactoCorreo.TabIndex = 32;
            this.Pest1_Txt__ContactoCorreo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Pest1_Txt__ContactoCorreo_KeyPress);
            // 
            // Pest1_Txt__ContactoRol
            // 
            this.Pest1_Txt__ContactoRol.Location = new System.Drawing.Point(285, 50);
            this.Pest1_Txt__ContactoRol.MaxLength = 23;
            this.Pest1_Txt__ContactoRol.Name = "Pest1_Txt__ContactoRol";
            this.Pest1_Txt__ContactoRol.Size = new System.Drawing.Size(141, 20);
            this.Pest1_Txt__ContactoRol.TabIndex = 31;
            this.Pest1_Txt__ContactoRol.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Pest1_Txt__ContactoRol_KeyPress);
            // 
            // Pest1_Txt__ContactoApellido
            // 
            this.Pest1_Txt__ContactoApellido.Location = new System.Drawing.Point(285, 24);
            this.Pest1_Txt__ContactoApellido.MaxLength = 48;
            this.Pest1_Txt__ContactoApellido.Name = "Pest1_Txt__ContactoApellido";
            this.Pest1_Txt__ContactoApellido.Size = new System.Drawing.Size(142, 20);
            this.Pest1_Txt__ContactoApellido.TabIndex = 30;
            this.Pest1_Txt__ContactoApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Pest1_Txt__ContactoApellido_KeyPress);
            // 
            // dataGridView4
            // 
            this.dataGridView4.AllowUserToAddRows = false;
            this.dataGridView4.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo_Contacto,
            this.Nombre_Contacto,
            this.Apellido_Contacto,
            this.Correo,
            this.Telefono,
            this.Cargo,
            this.Codigo_Estado,
            this.Codigo_Proveedor});
            this.dataGridView4.Location = new System.Drawing.Point(6, 86);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.ReadOnly = true;
            this.dataGridView4.Size = new System.Drawing.Size(1044, 146);
            this.dataGridView4.TabIndex = 0;
            // 
            // Codigo_Contacto
            // 
            this.Codigo_Contacto.HeaderText = "Codigo de Contacto";
            this.Codigo_Contacto.Name = "Codigo_Contacto";
            this.Codigo_Contacto.ReadOnly = true;
            // 
            // Nombre_Contacto
            // 
            this.Nombre_Contacto.HeaderText = "Nombre ";
            this.Nombre_Contacto.Name = "Nombre_Contacto";
            this.Nombre_Contacto.ReadOnly = true;
            // 
            // Apellido_Contacto
            // 
            this.Apellido_Contacto.HeaderText = "Apellido";
            this.Apellido_Contacto.Name = "Apellido_Contacto";
            this.Apellido_Contacto.ReadOnly = true;
            // 
            // Correo
            // 
            this.Correo.HeaderText = "Correo";
            this.Correo.Name = "Correo";
            this.Correo.ReadOnly = true;
            // 
            // Telefono
            // 
            this.Telefono.HeaderText = "Telefono";
            this.Telefono.Name = "Telefono";
            this.Telefono.ReadOnly = true;
            // 
            // Cargo
            // 
            this.Cargo.HeaderText = "Cargo";
            this.Cargo.Name = "Cargo";
            this.Cargo.ReadOnly = true;
            // 
            // Codigo_Estado
            // 
            this.Codigo_Estado.HeaderText = "Codigo de Estado";
            this.Codigo_Estado.Name = "Codigo_Estado";
            this.Codigo_Estado.ReadOnly = true;
            // 
            // Codigo_Proveedor
            // 
            this.Codigo_Proveedor.HeaderText = "Codigo de Proveedor";
            this.Codigo_Proveedor.Name = "Codigo_Proveedor";
            this.Codigo_Proveedor.ReadOnly = true;
            // 
            // Pest1_Bttn_Guardar
            // 
            this.Pest1_Bttn_Guardar.Location = new System.Drawing.Point(835, 26);
            this.Pest1_Bttn_Guardar.Name = "Pest1_Bttn_Guardar";
            this.Pest1_Bttn_Guardar.Size = new System.Drawing.Size(133, 56);
            this.Pest1_Bttn_Guardar.TabIndex = 16;
            this.Pest1_Bttn_Guardar.Text = "Guardar";
            this.Pest1_Bttn_Guardar.UseVisualStyleBackColor = true;
            this.Pest1_Bttn_Guardar.Click += new System.EventHandler(this.Pest1_Bttn_Guardar_Click);
            // 
            // Pest1_Grupo_DatosDeProveedor
            // 
            this.Pest1_Grupo_DatosDeProveedor.Controls.Add(this.Pest1_ComBox_Estados);
            this.Pest1_Grupo_DatosDeProveedor.Controls.Add(this.Pest1_ComBox_Nacionalidad);
            this.Pest1_Grupo_DatosDeProveedor.Controls.Add(this.Pest1_Txt__CodigoPostal);
            this.Pest1_Grupo_DatosDeProveedor.Controls.Add(this.label17);
            this.Pest1_Grupo_DatosDeProveedor.Controls.Add(this.Pest1_Txt__Direccion);
            this.Pest1_Grupo_DatosDeProveedor.Controls.Add(this.Pest1_Txt__Correo);
            this.Pest1_Grupo_DatosDeProveedor.Controls.Add(this.Pest1_Txt__Nombre);
            this.Pest1_Grupo_DatosDeProveedor.Controls.Add(this.Pest1_Txt__CodigoProveedor);
            this.Pest1_Grupo_DatosDeProveedor.Controls.Add(this.label18);
            this.Pest1_Grupo_DatosDeProveedor.Controls.Add(this.label19);
            this.Pest1_Grupo_DatosDeProveedor.Controls.Add(this.label20);
            this.Pest1_Grupo_DatosDeProveedor.Controls.Add(this.label22);
            this.Pest1_Grupo_DatosDeProveedor.Controls.Add(this.label23);
            this.Pest1_Grupo_DatosDeProveedor.Controls.Add(this.label24);
            this.Pest1_Grupo_DatosDeProveedor.Location = new System.Drawing.Point(7, 7);
            this.Pest1_Grupo_DatosDeProveedor.Name = "Pest1_Grupo_DatosDeProveedor";
            this.Pest1_Grupo_DatosDeProveedor.Size = new System.Drawing.Size(639, 164);
            this.Pest1_Grupo_DatosDeProveedor.TabIndex = 1;
            this.Pest1_Grupo_DatosDeProveedor.TabStop = false;
            this.Pest1_Grupo_DatosDeProveedor.Text = "Datos de Proveedor";
            // 
            // Pest1_ComBox_Estados
            // 
            this.Pest1_ComBox_Estados.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Pest1_ComBox_Estados.FormattingEnabled = true;
            this.Pest1_ComBox_Estados.Location = new System.Drawing.Point(454, 29);
            this.Pest1_ComBox_Estados.Name = "Pest1_ComBox_Estados";
            this.Pest1_ComBox_Estados.Size = new System.Drawing.Size(133, 21);
            this.Pest1_ComBox_Estados.TabIndex = 15;
            this.Pest1_ComBox_Estados.SelectedIndexChanged += new System.EventHandler(this.Pest1_ComBox_Estados_SelectedIndexChanged);
            // 
            // Pest1_ComBox_Nacionalidad
            // 
            this.Pest1_ComBox_Nacionalidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Pest1_ComBox_Nacionalidad.FormattingEnabled = true;
            this.Pest1_ComBox_Nacionalidad.Location = new System.Drawing.Point(454, 62);
            this.Pest1_ComBox_Nacionalidad.Name = "Pest1_ComBox_Nacionalidad";
            this.Pest1_ComBox_Nacionalidad.Size = new System.Drawing.Size(133, 21);
            this.Pest1_ComBox_Nacionalidad.TabIndex = 14;
            this.Pest1_ComBox_Nacionalidad.SelectedIndexChanged += new System.EventHandler(this.Pest1_ComBox_Nacionalidad_SelectedIndexChanged);
            // 
            // Pest1_Txt__CodigoPostal
            // 
            this.Pest1_Txt__CodigoPostal.Enabled = false;
            this.Pest1_Txt__CodigoPostal.Location = new System.Drawing.Point(454, 97);
            this.Pest1_Txt__CodigoPostal.MaxLength = 6;
            this.Pest1_Txt__CodigoPostal.Name = "Pest1_Txt__CodigoPostal";
            this.Pest1_Txt__CodigoPostal.Size = new System.Drawing.Size(133, 20);
            this.Pest1_Txt__CodigoPostal.TabIndex = 13;
            this.Pest1_Txt__CodigoPostal.Text = "0";
            this.Pest1_Txt__CodigoPostal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Pest1_Txt__CodigoPostal_KeyPress);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(367, 62);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(81, 13);
            this.label17.TabIndex = 11;
            this.label17.Text = "Nacionalidad";
            // 
            // Pest1_Txt__Direccion
            // 
            this.Pest1_Txt__Direccion.Location = new System.Drawing.Point(180, 123);
            this.Pest1_Txt__Direccion.MaxLength = 98;
            this.Pest1_Txt__Direccion.Name = "Pest1_Txt__Direccion";
            this.Pest1_Txt__Direccion.Size = new System.Drawing.Size(152, 20);
            this.Pest1_Txt__Direccion.TabIndex = 10;
            this.Pest1_Txt__Direccion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Pest1_Txt__Direccion_KeyPress);
            // 
            // Pest1_Txt__Correo
            // 
            this.Pest1_Txt__Correo.Location = new System.Drawing.Point(180, 93);
            this.Pest1_Txt__Correo.MaxLength = 48;
            this.Pest1_Txt__Correo.Name = "Pest1_Txt__Correo";
            this.Pest1_Txt__Correo.Size = new System.Drawing.Size(152, 20);
            this.Pest1_Txt__Correo.TabIndex = 9;
            this.Pest1_Txt__Correo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Pest1_Txt__Correo_KeyPress);
            // 
            // Pest1_Txt__Nombre
            // 
            this.Pest1_Txt__Nombre.Location = new System.Drawing.Point(180, 59);
            this.Pest1_Txt__Nombre.MaxLength = 48;
            this.Pest1_Txt__Nombre.Name = "Pest1_Txt__Nombre";
            this.Pest1_Txt__Nombre.Size = new System.Drawing.Size(152, 20);
            this.Pest1_Txt__Nombre.TabIndex = 8;
            this.Pest1_Txt__Nombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Pest1_Txt__Nombre_KeyPress);
            // 
            // Pest1_Txt__CodigoProveedor
            // 
            this.Pest1_Txt__CodigoProveedor.Enabled = false;
            this.Pest1_Txt__CodigoProveedor.Location = new System.Drawing.Point(180, 30);
            this.Pest1_Txt__CodigoProveedor.MaxLength = 5;
            this.Pest1_Txt__CodigoProveedor.Name = "Pest1_Txt__CodigoProveedor";
            this.Pest1_Txt__CodigoProveedor.Size = new System.Drawing.Size(152, 20);
            this.Pest1_Txt__CodigoProveedor.TabIndex = 7;
            this.Pest1_Txt__CodigoProveedor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Pest1_Txt__CodigoProveedor_KeyPress);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(46, 66);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(50, 13);
            this.label18.TabIndex = 6;
            this.label18.Text = "Nombre\r\n";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(46, 96);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(111, 13);
            this.label19.TabIndex = 5;
            this.label19.Text = "Correo electronico\r\n";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(46, 126);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(61, 13);
            this.label20.TabIndex = 4;
            this.label20.Text = "Direccion";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(367, 32);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(46, 13);
            this.label22.TabIndex = 2;
            this.label22.Text = "Estado";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(363, 97);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(85, 13);
            this.label23.TabIndex = 1;
            this.label23.Text = "Codigo Postal";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(46, 33);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(126, 13);
            this.label24.TabIndex = 0;
            this.label24.Text = "Codigo de Proveedor";
            // 
            // Pest2
            // 
            this.Pest2.Controls.Add(this.Pest2_Grupo_MuestraDatos);
            this.Pest2.Controls.Add(this.Pest2_Grupo_Busqueda);
            this.Pest2.Location = new System.Drawing.Point(4, 22);
            this.Pest2.Margin = new System.Windows.Forms.Padding(4);
            this.Pest2.Name = "Pest2";
            this.Pest2.Padding = new System.Windows.Forms.Padding(4);
            this.Pest2.Size = new System.Drawing.Size(1079, 422);
            this.Pest2.TabIndex = 1;
            this.Pest2.Text = "Busqueda";
            this.Pest2.UseVisualStyleBackColor = true;
            // 
            // Pest2_Grupo_MuestraDatos
            // 
            this.Pest2_Grupo_MuestraDatos.Controls.Add(this.dataGridView2);
            this.Pest2_Grupo_MuestraDatos.Location = new System.Drawing.Point(16, 107);
            this.Pest2_Grupo_MuestraDatos.Name = "Pest2_Grupo_MuestraDatos";
            this.Pest2_Grupo_MuestraDatos.Size = new System.Drawing.Size(1056, 308);
            this.Pest2_Grupo_MuestraDatos.TabIndex = 4;
            this.Pest2_Grupo_MuestraDatos.TabStop = false;
            this.Pest2_Grupo_MuestraDatos.Text = "Resultados de Busqueda de Proveedor";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(6, 35);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(1044, 253);
            this.dataGridView2.TabIndex = 3;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            this.dataGridView2.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentDoubleClick);
            // 
            // proveedorBindingSource
            // 
            this.proveedorBindingSource.DataMember = "Proveedor";
            this.proveedorBindingSource.DataSource = this.ventasAutoPartesDataSet;
            // 
            // ventasAutoPartesDataSet
            // 
            this.ventasAutoPartesDataSet.DataSetName = "VentasAutoPartesDataSet";
            this.ventasAutoPartesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Pest2_Grupo_Busqueda
            // 
            this.Pest2_Grupo_Busqueda.Controls.Add(this.Pest2_Bttn_Limpiar);
            this.Pest2_Grupo_Busqueda.Controls.Add(this.Pest2_Txt_CodigoBusqueda);
            this.Pest2_Grupo_Busqueda.Controls.Add(this.Pest2_Txt_NombreBusqueda);
            this.Pest2_Grupo_Busqueda.Controls.Add(this.Pest2_Radio_CodigoProveedor);
            this.Pest2_Grupo_Busqueda.Controls.Add(this.Pest2_Radio_NombreProveedor);
            this.Pest2_Grupo_Busqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pest2_Grupo_Busqueda.Location = new System.Drawing.Point(16, 20);
            this.Pest2_Grupo_Busqueda.Name = "Pest2_Grupo_Busqueda";
            this.Pest2_Grupo_Busqueda.Size = new System.Drawing.Size(922, 81);
            this.Pest2_Grupo_Busqueda.TabIndex = 2;
            this.Pest2_Grupo_Busqueda.TabStop = false;
            this.Pest2_Grupo_Busqueda.Text = "Opciones de Busqueda";
            // 
            // Pest2_Bttn_Limpiar
            // 
            this.Pest2_Bttn_Limpiar.Location = new System.Drawing.Point(742, 14);
            this.Pest2_Bttn_Limpiar.Name = "Pest2_Bttn_Limpiar";
            this.Pest2_Bttn_Limpiar.Size = new System.Drawing.Size(133, 51);
            this.Pest2_Bttn_Limpiar.TabIndex = 7;
            this.Pest2_Bttn_Limpiar.Text = "Limpiar";
            this.Pest2_Bttn_Limpiar.UseVisualStyleBackColor = true;
            this.Pest2_Bttn_Limpiar.Click += new System.EventHandler(this.Pest2_Bttn_Limpiar_Click);
            // 
            // Pest2_Txt_CodigoBusqueda
            // 
            this.Pest2_Txt_CodigoBusqueda.Location = new System.Drawing.Point(360, 32);
            this.Pest2_Txt_CodigoBusqueda.MaxLength = 6;
            this.Pest2_Txt_CodigoBusqueda.Name = "Pest2_Txt_CodigoBusqueda";
            this.Pest2_Txt_CodigoBusqueda.Size = new System.Drawing.Size(161, 20);
            this.Pest2_Txt_CodigoBusqueda.TabIndex = 6;
            this.Pest2_Txt_CodigoBusqueda.TextChanged += new System.EventHandler(this.Pest2_Txt_CodigoBusqueda_TextChanged);
            this.Pest2_Txt_CodigoBusqueda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Pest2_Txt_CodigoBusqueda_KeyPress);
            // 
            // Pest2_Txt_NombreBusqueda
            // 
            this.Pest2_Txt_NombreBusqueda.Location = new System.Drawing.Point(98, 32);
            this.Pest2_Txt_NombreBusqueda.MaxLength = 30;
            this.Pest2_Txt_NombreBusqueda.Name = "Pest2_Txt_NombreBusqueda";
            this.Pest2_Txt_NombreBusqueda.Size = new System.Drawing.Size(161, 20);
            this.Pest2_Txt_NombreBusqueda.TabIndex = 5;
            this.Pest2_Txt_NombreBusqueda.TextChanged += new System.EventHandler(this.Pest2_Txt_NombreBusqueda_TextChanged);
            this.Pest2_Txt_NombreBusqueda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Pest2_Txt_NombreBusqueda_KeyPress);
            // 
            // Pest2_Radio_CodigoProveedor
            // 
            this.Pest2_Radio_CodigoProveedor.AutoSize = true;
            this.Pest2_Radio_CodigoProveedor.Location = new System.Drawing.Point(279, 31);
            this.Pest2_Radio_CodigoProveedor.Name = "Pest2_Radio_CodigoProveedor";
            this.Pest2_Radio_CodigoProveedor.Size = new System.Drawing.Size(64, 17);
            this.Pest2_Radio_CodigoProveedor.TabIndex = 3;
            this.Pest2_Radio_CodigoProveedor.TabStop = true;
            this.Pest2_Radio_CodigoProveedor.Text = "Codigo";
            this.Pest2_Radio_CodigoProveedor.UseVisualStyleBackColor = true;
            this.Pest2_Radio_CodigoProveedor.CheckedChanged += new System.EventHandler(this.Pest2_Radio_CodigoProveedor_CheckedChanged);
            // 
            // Pest2_Radio_NombreProveedor
            // 
            this.Pest2_Radio_NombreProveedor.AutoSize = true;
            this.Pest2_Radio_NombreProveedor.Location = new System.Drawing.Point(24, 31);
            this.Pest2_Radio_NombreProveedor.Name = "Pest2_Radio_NombreProveedor";
            this.Pest2_Radio_NombreProveedor.Size = new System.Drawing.Size(68, 17);
            this.Pest2_Radio_NombreProveedor.TabIndex = 2;
            this.Pest2_Radio_NombreProveedor.TabStop = true;
            this.Pest2_Radio_NombreProveedor.Text = "Nombre";
            this.Pest2_Radio_NombreProveedor.UseVisualStyleBackColor = true;
            this.Pest2_Radio_NombreProveedor.CheckedChanged += new System.EventHandler(this.Pest2_Radio_NombreProveedor_CheckedChanged);
            // 
            // Pest3
            // 
            this.Pest3.Controls.Add(this.Pest3_Grupo_ContactosProveedor);
            this.Pest3.Controls.Add(this.Pest3_Grupo_Manejo);
            this.Pest3.Location = new System.Drawing.Point(4, 22);
            this.Pest3.Name = "Pest3";
            this.Pest3.Padding = new System.Windows.Forms.Padding(3);
            this.Pest3.Size = new System.Drawing.Size(1079, 422);
            this.Pest3.TabIndex = 2;
            this.Pest3.Text = "Actualizar Datos de Proveedor";
            this.Pest3.UseVisualStyleBackColor = true;
            // 
            // Pest3_Grupo_ContactosProveedor
            // 
            this.Pest3_Grupo_ContactosProveedor.Controls.Add(this.Pest3_DataG_ContactosProveedor);
            this.Pest3_Grupo_ContactosProveedor.Location = new System.Drawing.Point(6, 200);
            this.Pest3_Grupo_ContactosProveedor.Name = "Pest3_Grupo_ContactosProveedor";
            this.Pest3_Grupo_ContactosProveedor.Size = new System.Drawing.Size(1056, 204);
            this.Pest3_Grupo_ContactosProveedor.TabIndex = 1;
            this.Pest3_Grupo_ContactosProveedor.TabStop = false;
            this.Pest3_Grupo_ContactosProveedor.Text = "Contactos de Provedor";
            // 
            // Pest3_DataG_ContactosProveedor
            // 
            this.Pest3_DataG_ContactosProveedor.AllowUserToAddRows = false;
            this.Pest3_DataG_ContactosProveedor.AllowUserToDeleteRows = false;
            this.Pest3_DataG_ContactosProveedor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Pest3_DataG_ContactosProveedor.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.Pest3_DataG_ContactosProveedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Pest3_DataG_ContactosProveedor.Location = new System.Drawing.Point(6, 30);
            this.Pest3_DataG_ContactosProveedor.Name = "Pest3_DataG_ContactosProveedor";
            this.Pest3_DataG_ContactosProveedor.ReadOnly = true;
            this.Pest3_DataG_ContactosProveedor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Pest3_DataG_ContactosProveedor.Size = new System.Drawing.Size(1044, 168);
            this.Pest3_DataG_ContactosProveedor.TabIndex = 0;
            this.Pest3_DataG_ContactosProveedor.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Pest3_DataG_ContactosProveedor_CellContentDoubleClick);
            this.Pest3_DataG_ContactosProveedor.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Pest3_DataG_ContactosProveedor_CellDoubleClick);
            // 
            // contactoProveedorBindingSource
            // 
            this.contactoProveedorBindingSource.DataMember = "Contacto|Proveedor";
            this.contactoProveedorBindingSource.DataSource = this.ventasAutoPartesDataSet;
            // 
            // Pest3_Grupo_Manejo
            // 
            this.Pest3_Grupo_Manejo.Controls.Add(this.Pest3_Txt_Aceptar);
            this.Pest3_Grupo_Manejo.Controls.Add(this.Pest3_Bttn_Limpiar);
            this.Pest3_Grupo_Manejo.Controls.Add(this.Pest3_ComBx_Estado);
            this.Pest3_Grupo_Manejo.Controls.Add(this.Pest3_ComBx_Nacionalidad);
            this.Pest3_Grupo_Manejo.Controls.Add(this.Pest3_Txt_CodigoPostal);
            this.Pest3_Grupo_Manejo.Controls.Add(this.label16);
            this.Pest3_Grupo_Manejo.Controls.Add(this.Pest3_Txt_Direccion);
            this.Pest3_Grupo_Manejo.Controls.Add(this.Pest3_Txt_CorreoElectronico);
            this.Pest3_Grupo_Manejo.Controls.Add(this.Pest3_Txt_Nombre);
            this.Pest3_Grupo_Manejo.Controls.Add(this.Pest3_Txt_Codigo);
            this.Pest3_Grupo_Manejo.Controls.Add(this.label15);
            this.Pest3_Grupo_Manejo.Controls.Add(this.label14);
            this.Pest3_Grupo_Manejo.Controls.Add(this.label13);
            this.Pest3_Grupo_Manejo.Controls.Add(this.label11);
            this.Pest3_Grupo_Manejo.Controls.Add(this.label10);
            this.Pest3_Grupo_Manejo.Controls.Add(this.label9);
            this.Pest3_Grupo_Manejo.Location = new System.Drawing.Point(6, 20);
            this.Pest3_Grupo_Manejo.Name = "Pest3_Grupo_Manejo";
            this.Pest3_Grupo_Manejo.Size = new System.Drawing.Size(802, 164);
            this.Pest3_Grupo_Manejo.TabIndex = 0;
            this.Pest3_Grupo_Manejo.TabStop = false;
            this.Pest3_Grupo_Manejo.Text = "Datos de Proveedor";
            this.Pest3_Grupo_Manejo.Enter += new System.EventHandler(this.Pest3_Grupo_Manejo_Enter);
            // 
            // Pest3_Txt_Aceptar
            // 
            this.Pest3_Txt_Aceptar.Location = new System.Drawing.Point(626, 94);
            this.Pest3_Txt_Aceptar.Name = "Pest3_Txt_Aceptar";
            this.Pest3_Txt_Aceptar.Size = new System.Drawing.Size(132, 49);
            this.Pest3_Txt_Aceptar.TabIndex = 17;
            this.Pest3_Txt_Aceptar.Text = "Aceptar";
            this.Pest3_Txt_Aceptar.UseVisualStyleBackColor = true;
            this.Pest3_Txt_Aceptar.Click += new System.EventHandler(this.Pest3_Txt_Aceptar_Click);
            // 
            // Pest3_Bttn_Limpiar
            // 
            this.Pest3_Bttn_Limpiar.Location = new System.Drawing.Point(626, 26);
            this.Pest3_Bttn_Limpiar.Name = "Pest3_Bttn_Limpiar";
            this.Pest3_Bttn_Limpiar.Size = new System.Drawing.Size(132, 49);
            this.Pest3_Bttn_Limpiar.TabIndex = 16;
            this.Pest3_Bttn_Limpiar.Text = "Limpiar";
            this.Pest3_Bttn_Limpiar.UseVisualStyleBackColor = true;
            this.Pest3_Bttn_Limpiar.Click += new System.EventHandler(this.Pest3_Bttn_Limpiar_Click);
            // 
            // Pest3_ComBx_Estado
            // 
            this.Pest3_ComBx_Estado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Pest3_ComBx_Estado.FormattingEnabled = true;
            this.Pest3_ComBx_Estado.Location = new System.Drawing.Point(420, 29);
            this.Pest3_ComBx_Estado.Name = "Pest3_ComBx_Estado";
            this.Pest3_ComBx_Estado.Size = new System.Drawing.Size(121, 21);
            this.Pest3_ComBx_Estado.TabIndex = 15;
            this.Pest3_ComBx_Estado.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // Pest3_ComBx_Nacionalidad
            // 
            this.Pest3_ComBx_Nacionalidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Pest3_ComBx_Nacionalidad.Enabled = false;
            this.Pest3_ComBx_Nacionalidad.FormattingEnabled = true;
            this.Pest3_ComBx_Nacionalidad.Location = new System.Drawing.Point(420, 62);
            this.Pest3_ComBx_Nacionalidad.Name = "Pest3_ComBx_Nacionalidad";
            this.Pest3_ComBx_Nacionalidad.Size = new System.Drawing.Size(121, 21);
            this.Pest3_ComBx_Nacionalidad.TabIndex = 14;
            // 
            // Pest3_Txt_CodigoPostal
            // 
            this.Pest3_Txt_CodigoPostal.Enabled = false;
            this.Pest3_Txt_CodigoPostal.Location = new System.Drawing.Point(420, 94);
            this.Pest3_Txt_CodigoPostal.MaxLength = 22;
            this.Pest3_Txt_CodigoPostal.Name = "Pest3_Txt_CodigoPostal";
            this.Pest3_Txt_CodigoPostal.Size = new System.Drawing.Size(121, 20);
            this.Pest3_Txt_CodigoPostal.TabIndex = 13;
            this.Pest3_Txt_CodigoPostal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Pest3_Txt_CodigoPostal_KeyPress);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(333, 62);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(81, 13);
            this.label16.TabIndex = 11;
            this.label16.Text = "Nacionalidad";
            // 
            // Pest3_Txt_Direccion
            // 
            this.Pest3_Txt_Direccion.Location = new System.Drawing.Point(153, 119);
            this.Pest3_Txt_Direccion.MaxLength = 99;
            this.Pest3_Txt_Direccion.Name = "Pest3_Txt_Direccion";
            this.Pest3_Txt_Direccion.Size = new System.Drawing.Size(152, 20);
            this.Pest3_Txt_Direccion.TabIndex = 10;
            this.Pest3_Txt_Direccion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Pest3_Txt_Direccion_KeyPress);
            // 
            // Pest3_Txt_CorreoElectronico
            // 
            this.Pest3_Txt_CorreoElectronico.Location = new System.Drawing.Point(153, 89);
            this.Pest3_Txt_CorreoElectronico.MaxLength = 45;
            this.Pest3_Txt_CorreoElectronico.Name = "Pest3_Txt_CorreoElectronico";
            this.Pest3_Txt_CorreoElectronico.Size = new System.Drawing.Size(152, 20);
            this.Pest3_Txt_CorreoElectronico.TabIndex = 9;
            this.Pest3_Txt_CorreoElectronico.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Pest3_Txt_CorreoElectronico_KeyPress);
            // 
            // Pest3_Txt_Nombre
            // 
            this.Pest3_Txt_Nombre.Enabled = false;
            this.Pest3_Txt_Nombre.Location = new System.Drawing.Point(153, 55);
            this.Pest3_Txt_Nombre.Name = "Pest3_Txt_Nombre";
            this.Pest3_Txt_Nombre.Size = new System.Drawing.Size(152, 20);
            this.Pest3_Txt_Nombre.TabIndex = 8;
            this.Pest3_Txt_Nombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Pest3_Txt_Nombre_KeyPress);
            // 
            // Pest3_Txt_Codigo
            // 
            this.Pest3_Txt_Codigo.Enabled = false;
            this.Pest3_Txt_Codigo.Location = new System.Drawing.Point(153, 26);
            this.Pest3_Txt_Codigo.Name = "Pest3_Txt_Codigo";
            this.Pest3_Txt_Codigo.Size = new System.Drawing.Size(152, 20);
            this.Pest3_Txt_Codigo.TabIndex = 7;
            this.Pest3_Txt_Codigo.TextChanged += new System.EventHandler(this.Pest3_Txt_Codigo_TextChanged);
            this.Pest3_Txt_Codigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Pest3_Txt_Codigo_KeyPress);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(19, 62);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(50, 13);
            this.label15.TabIndex = 6;
            this.label15.Text = "Nombre\r\n";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(19, 92);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(111, 13);
            this.label14.TabIndex = 5;
            this.label14.Text = "Correo electronico\r\n";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(19, 122);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(61, 13);
            this.label13.TabIndex = 4;
            this.label13.Text = "Direccion";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(333, 32);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "Estado";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(329, 94);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Codigo Postal";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(126, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Codigo de Proveedor";
            // 
            // Pest4
            // 
            this.Pest4.Controls.Add(this.Pest4_Grupo_OpcionesBusqueda);
            this.Pest4.Controls.Add(this.Pest4_Grupo_DatosContacto);
            this.Pest4.Controls.Add(this.Pest4_Grupo_ManejoDatos);
            this.Pest4.Controls.Add(this.Pest4_Grupo_OpcionesManejo);
            this.Pest4.Location = new System.Drawing.Point(4, 22);
            this.Pest4.Name = "Pest4";
            this.Pest4.Size = new System.Drawing.Size(1079, 422);
            this.Pest4.TabIndex = 3;
            this.Pest4.Text = "Manejo de Contactos";
            this.Pest4.UseVisualStyleBackColor = true;
            // 
            // Pest4_Grupo_OpcionesBusqueda
            // 
            this.Pest4_Grupo_OpcionesBusqueda.Controls.Add(this.Pest4_Txt_BuscarProvNombre);
            this.Pest4_Grupo_OpcionesBusqueda.Controls.Add(this.Pest4_Txt_BuscarCodigo);
            this.Pest4_Grupo_OpcionesBusqueda.Controls.Add(this.Pest4_Txt_BuscarNombre);
            this.Pest4_Grupo_OpcionesBusqueda.Controls.Add(this.Pest4_Radio_ProveedorBusqueda);
            this.Pest4_Grupo_OpcionesBusqueda.Controls.Add(this.Pest4_Radio_CodigoBusqueda);
            this.Pest4_Grupo_OpcionesBusqueda.Controls.Add(this.Pest4_Radio_NombreBusqueda);
            this.Pest4_Grupo_OpcionesBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pest4_Grupo_OpcionesBusqueda.Location = new System.Drawing.Point(16, 83);
            this.Pest4_Grupo_OpcionesBusqueda.Name = "Pest4_Grupo_OpcionesBusqueda";
            this.Pest4_Grupo_OpcionesBusqueda.Size = new System.Drawing.Size(332, 106);
            this.Pest4_Grupo_OpcionesBusqueda.TabIndex = 1;
            this.Pest4_Grupo_OpcionesBusqueda.TabStop = false;
            this.Pest4_Grupo_OpcionesBusqueda.Text = "Opciones de Busqueda";
            // 
            // Pest4_Txt_BuscarProvNombre
            // 
            this.Pest4_Txt_BuscarProvNombre.Location = new System.Drawing.Point(177, 64);
            this.Pest4_Txt_BuscarProvNombre.MaxLength = 5;
            this.Pest4_Txt_BuscarProvNombre.Name = "Pest4_Txt_BuscarProvNombre";
            this.Pest4_Txt_BuscarProvNombre.Size = new System.Drawing.Size(139, 20);
            this.Pest4_Txt_BuscarProvNombre.TabIndex = 7;
            this.Pest4_Txt_BuscarProvNombre.TextChanged += new System.EventHandler(this.Pest4_Txt_BuscarProvNombre_TextChanged);
            this.Pest4_Txt_BuscarProvNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Pest4_Txt_BuscarProvNombre_KeyPress);
            // 
            // Pest4_Txt_BuscarCodigo
            // 
            this.Pest4_Txt_BuscarCodigo.Location = new System.Drawing.Point(177, 41);
            this.Pest4_Txt_BuscarCodigo.Name = "Pest4_Txt_BuscarCodigo";
            this.Pest4_Txt_BuscarCodigo.Size = new System.Drawing.Size(139, 20);
            this.Pest4_Txt_BuscarCodigo.TabIndex = 6;
            this.Pest4_Txt_BuscarCodigo.TextChanged += new System.EventHandler(this.Pest4_Txt_BuscarCodigo_TextChanged);
            this.Pest4_Txt_BuscarCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Pest4_Txt_BuscarCodigo_KeyPress);
            // 
            // Pest4_Txt_BuscarNombre
            // 
            this.Pest4_Txt_BuscarNombre.Location = new System.Drawing.Point(177, 16);
            this.Pest4_Txt_BuscarNombre.Name = "Pest4_Txt_BuscarNombre";
            this.Pest4_Txt_BuscarNombre.Size = new System.Drawing.Size(139, 20);
            this.Pest4_Txt_BuscarNombre.TabIndex = 5;
            this.Pest4_Txt_BuscarNombre.TextChanged += new System.EventHandler(this.Pest4_Txt_BuscarNombre_TextChanged);
            this.Pest4_Txt_BuscarNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Pest4_Txt_BuscarNombre_KeyPress);
            // 
            // Pest4_Radio_ProveedorBusqueda
            // 
            this.Pest4_Radio_ProveedorBusqueda.AutoSize = true;
            this.Pest4_Radio_ProveedorBusqueda.Location = new System.Drawing.Point(24, 65);
            this.Pest4_Radio_ProveedorBusqueda.Name = "Pest4_Radio_ProveedorBusqueda";
            this.Pest4_Radio_ProveedorBusqueda.Size = new System.Drawing.Size(144, 17);
            this.Pest4_Radio_ProveedorBusqueda.TabIndex = 4;
            this.Pest4_Radio_ProveedorBusqueda.TabStop = true;
            this.Pest4_Radio_ProveedorBusqueda.Text = "Codigo de Proveedor";
            this.Pest4_Radio_ProveedorBusqueda.UseVisualStyleBackColor = true;
            this.Pest4_Radio_ProveedorBusqueda.CheckedChanged += new System.EventHandler(this.Pest4_Radio_ProveedorBusqueda_CheckedChanged);
            // 
            // Pest4_Radio_CodigoBusqueda
            // 
            this.Pest4_Radio_CodigoBusqueda.AutoSize = true;
            this.Pest4_Radio_CodigoBusqueda.Location = new System.Drawing.Point(24, 42);
            this.Pest4_Radio_CodigoBusqueda.Name = "Pest4_Radio_CodigoBusqueda";
            this.Pest4_Radio_CodigoBusqueda.Size = new System.Drawing.Size(64, 17);
            this.Pest4_Radio_CodigoBusqueda.TabIndex = 3;
            this.Pest4_Radio_CodigoBusqueda.TabStop = true;
            this.Pest4_Radio_CodigoBusqueda.Text = "Codigo";
            this.Pest4_Radio_CodigoBusqueda.UseVisualStyleBackColor = true;
            this.Pest4_Radio_CodigoBusqueda.CheckedChanged += new System.EventHandler(this.Pest4_Radio_CodigoBusqueda_CheckedChanged);
            // 
            // Pest4_Radio_NombreBusqueda
            // 
            this.Pest4_Radio_NombreBusqueda.AutoSize = true;
            this.Pest4_Radio_NombreBusqueda.Location = new System.Drawing.Point(24, 19);
            this.Pest4_Radio_NombreBusqueda.Name = "Pest4_Radio_NombreBusqueda";
            this.Pest4_Radio_NombreBusqueda.Size = new System.Drawing.Size(68, 17);
            this.Pest4_Radio_NombreBusqueda.TabIndex = 2;
            this.Pest4_Radio_NombreBusqueda.TabStop = true;
            this.Pest4_Radio_NombreBusqueda.Text = "Nombre";
            this.Pest4_Radio_NombreBusqueda.UseVisualStyleBackColor = true;
            this.Pest4_Radio_NombreBusqueda.CheckedChanged += new System.EventHandler(this.Pest4_Radio_NombreBusqueda_CheckedChanged);
            // 
            // Pest4_Grupo_DatosContacto
            // 
            this.Pest4_Grupo_DatosContacto.Controls.Add(this.Pest4_DataGrid_ManejoContactos);
            this.Pest4_Grupo_DatosContacto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pest4_Grupo_DatosContacto.Location = new System.Drawing.Point(16, 208);
            this.Pest4_Grupo_DatosContacto.Name = "Pest4_Grupo_DatosContacto";
            this.Pest4_Grupo_DatosContacto.Size = new System.Drawing.Size(1043, 208);
            this.Pest4_Grupo_DatosContacto.TabIndex = 2;
            this.Pest4_Grupo_DatosContacto.TabStop = false;
            this.Pest4_Grupo_DatosContacto.Text = "Datos del Contacto";
            // 
            // Pest4_DataGrid_ManejoContactos
            // 
            this.Pest4_DataGrid_ManejoContactos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Pest4_DataGrid_ManejoContactos.Location = new System.Drawing.Point(6, 32);
            this.Pest4_DataGrid_ManejoContactos.Name = "Pest4_DataGrid_ManejoContactos";
            this.Pest4_DataGrid_ManejoContactos.ReadOnly = true;
            this.Pest4_DataGrid_ManejoContactos.Size = new System.Drawing.Size(1031, 170);
            this.Pest4_DataGrid_ManejoContactos.TabIndex = 0;
            this.Pest4_DataGrid_ManejoContactos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Pest4_DataGrid_ManejoContactos_CellContentClick);
            // 
            // Pest4_Grupo_ManejoDatos
            // 
            this.Pest4_Grupo_ManejoDatos.Controls.Add(this.comboBox1);
            this.Pest4_Grupo_ManejoDatos.Controls.Add(this.Pest4_ComBox_TelefonoFijoCodigo);
            this.Pest4_Grupo_ManejoDatos.Controls.Add(this.Pest1_Mask_NumeroFijoEmpleado);
            this.Pest4_Grupo_ManejoDatos.Controls.Add(this.Pest4_Bttn_Limpiar);
            this.Pest4_Grupo_ManejoDatos.Controls.Add(this.Pest4_Bttn_Aceptar);
            this.Pest4_Grupo_ManejoDatos.Controls.Add(this.Pest4_CoBx_Estado);
            this.Pest4_Grupo_ManejoDatos.Controls.Add(this.label8);
            this.Pest4_Grupo_ManejoDatos.Controls.Add(this.label7);
            this.Pest4_Grupo_ManejoDatos.Controls.Add(this.label5);
            this.Pest4_Grupo_ManejoDatos.Controls.Add(this.Rol);
            this.Pest4_Grupo_ManejoDatos.Controls.Add(this.Pest4_Txt_NombreCont);
            this.Pest4_Grupo_ManejoDatos.Controls.Add(this.label4);
            this.Pest4_Grupo_ManejoDatos.Controls.Add(this.label3);
            this.Pest4_Grupo_ManejoDatos.Controls.Add(this.label2);
            this.Pest4_Grupo_ManejoDatos.Controls.Add(this.label1);
            this.Pest4_Grupo_ManejoDatos.Controls.Add(this.Pest4_Txt_CodigoContac);
            this.Pest4_Grupo_ManejoDatos.Controls.Add(this.Pest4_Txt_ApellidoCont);
            this.Pest4_Grupo_ManejoDatos.Controls.Add(this.Pest4_Txt_CorreoContact);
            this.Pest4_Grupo_ManejoDatos.Controls.Add(this.Pest4_Txt_RolContact);
            this.Pest4_Grupo_ManejoDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pest4_Grupo_ManejoDatos.Location = new System.Drawing.Point(354, 14);
            this.Pest4_Grupo_ManejoDatos.Name = "Pest4_Grupo_ManejoDatos";
            this.Pest4_Grupo_ManejoDatos.Size = new System.Drawing.Size(705, 175);
            this.Pest4_Grupo_ManejoDatos.TabIndex = 1;
            this.Pest4_Grupo_ManejoDatos.TabStop = false;
            this.Pest4_Grupo_ManejoDatos.Text = "Ingresar Datos";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(369, 21);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 40;
            // 
            // Pest4_ComBox_TelefonoFijoCodigo
            // 
            this.Pest4_ComBox_TelefonoFijoCodigo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Pest4_ComBox_TelefonoFijoCodigo.FormattingEnabled = true;
            this.Pest4_ComBox_TelefonoFijoCodigo.Location = new System.Drawing.Point(94, 138);
            this.Pest4_ComBox_TelefonoFijoCodigo.Name = "Pest4_ComBox_TelefonoFijoCodigo";
            this.Pest4_ComBox_TelefonoFijoCodigo.Size = new System.Drawing.Size(50, 21);
            this.Pest4_ComBox_TelefonoFijoCodigo.TabIndex = 39;
            // 
            // Pest1_Mask_NumeroFijoEmpleado
            // 
            this.Pest1_Mask_NumeroFijoEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pest1_Mask_NumeroFijoEmpleado.Location = new System.Drawing.Point(150, 137);
            this.Pest1_Mask_NumeroFijoEmpleado.Mask = "0000-0000";
            this.Pest1_Mask_NumeroFijoEmpleado.Name = "Pest1_Mask_NumeroFijoEmpleado";
            this.Pest1_Mask_NumeroFijoEmpleado.Size = new System.Drawing.Size(72, 22);
            this.Pest1_Mask_NumeroFijoEmpleado.TabIndex = 36;
            // 
            // Pest4_Bttn_Limpiar
            // 
            this.Pest4_Bttn_Limpiar.Location = new System.Drawing.Point(564, 117);
            this.Pest4_Bttn_Limpiar.Name = "Pest4_Bttn_Limpiar";
            this.Pest4_Bttn_Limpiar.Size = new System.Drawing.Size(132, 51);
            this.Pest4_Bttn_Limpiar.TabIndex = 29;
            this.Pest4_Bttn_Limpiar.Text = "Limpiar";
            this.Pest4_Bttn_Limpiar.UseVisualStyleBackColor = true;
            this.Pest4_Bttn_Limpiar.Click += new System.EventHandler(this.Pest4_Bttn_Limpiar_Click);
            // 
            // Pest4_Bttn_Aceptar
            // 
            this.Pest4_Bttn_Aceptar.Location = new System.Drawing.Point(426, 117);
            this.Pest4_Bttn_Aceptar.Name = "Pest4_Bttn_Aceptar";
            this.Pest4_Bttn_Aceptar.Size = new System.Drawing.Size(132, 51);
            this.Pest4_Bttn_Aceptar.TabIndex = 28;
            this.Pest4_Bttn_Aceptar.Text = "Aceptar";
            this.Pest4_Bttn_Aceptar.UseVisualStyleBackColor = true;
            this.Pest4_Bttn_Aceptar.Click += new System.EventHandler(this.Pest4_Bttn_Aceptar_Click);
            // 
            // Pest4_CoBx_Estado
            // 
            this.Pest4_CoBx_Estado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Pest4_CoBx_Estado.FormattingEnabled = true;
            this.Pest4_CoBx_Estado.Location = new System.Drawing.Point(564, 16);
            this.Pest4_CoBx_Estado.Name = "Pest4_CoBx_Estado";
            this.Pest4_CoBx_Estado.Size = new System.Drawing.Size(132, 21);
            this.Pest4_CoBx_Estado.TabIndex = 27;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(512, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 26;
            this.label8.Text = "Estado";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 140);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "Telefono";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(237, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Codigo de Proveedor";
            // 
            // Rol
            // 
            this.Rol.AutoSize = true;
            this.Rol.Location = new System.Drawing.Point(250, 65);
            this.Rol.Name = "Rol";
            this.Rol.Size = new System.Drawing.Size(113, 13);
            this.Rol.TabIndex = 22;
            this.Rol.Text = "Cargo de Contacto";
            // 
            // Pest4_Txt_NombreCont
            // 
            this.Pest4_Txt_NombreCont.Location = new System.Drawing.Point(94, 50);
            this.Pest4_Txt_NombreCont.Name = "Pest4_Txt_NombreCont";
            this.Pest4_Txt_NombreCont.Size = new System.Drawing.Size(128, 20);
            this.Pest4_Txt_NombreCont.TabIndex = 21;
            this.Pest4_Txt_NombreCont.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Pest4_Txt_NombreCont_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Correo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Apellido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Codigo";
            // 
            // Pest4_Txt_CodigoContac
            // 
            this.Pest4_Txt_CodigoContac.Enabled = false;
            this.Pest4_Txt_CodigoContac.Location = new System.Drawing.Point(94, 17);
            this.Pest4_Txt_CodigoContac.Name = "Pest4_Txt_CodigoContac";
            this.Pest4_Txt_CodigoContac.Size = new System.Drawing.Size(128, 20);
            this.Pest4_Txt_CodigoContac.TabIndex = 16;
            this.Pest4_Txt_CodigoContac.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Pest4_Txt_CodigoContac_KeyPress);
            // 
            // Pest4_Txt_ApellidoCont
            // 
            this.Pest4_Txt_ApellidoCont.Location = new System.Drawing.Point(94, 82);
            this.Pest4_Txt_ApellidoCont.Name = "Pest4_Txt_ApellidoCont";
            this.Pest4_Txt_ApellidoCont.Size = new System.Drawing.Size(128, 20);
            this.Pest4_Txt_ApellidoCont.TabIndex = 15;
            this.Pest4_Txt_ApellidoCont.TextChanged += new System.EventHandler(this.textBox11_TextChanged);
            this.Pest4_Txt_ApellidoCont.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Pest4_Txt_ApellidoCont_KeyPress);
            // 
            // Pest4_Txt_CorreoContact
            // 
            this.Pest4_Txt_CorreoContact.Location = new System.Drawing.Point(94, 111);
            this.Pest4_Txt_CorreoContact.Name = "Pest4_Txt_CorreoContact";
            this.Pest4_Txt_CorreoContact.Size = new System.Drawing.Size(128, 20);
            this.Pest4_Txt_CorreoContact.TabIndex = 14;
            this.Pest4_Txt_CorreoContact.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Pest4_Txt_CorreoContact_KeyPress);
            // 
            // Pest4_Txt_RolContact
            // 
            this.Pest4_Txt_RolContact.Location = new System.Drawing.Point(369, 58);
            this.Pest4_Txt_RolContact.Name = "Pest4_Txt_RolContact";
            this.Pest4_Txt_RolContact.Size = new System.Drawing.Size(121, 20);
            this.Pest4_Txt_RolContact.TabIndex = 13;
            this.Pest4_Txt_RolContact.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Pest4_Txt_RolContact_KeyPress);
            // 
            // Pest4_Grupo_OpcionesManejo
            // 
            this.Pest4_Grupo_OpcionesManejo.Controls.Add(this.Pest4_Radio_Nuevo);
            this.Pest4_Grupo_OpcionesManejo.Controls.Add(this.Pest4_Radio_BusqYManeji);
            this.Pest4_Grupo_OpcionesManejo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pest4_Grupo_OpcionesManejo.Location = new System.Drawing.Point(16, 14);
            this.Pest4_Grupo_OpcionesManejo.Name = "Pest4_Grupo_OpcionesManejo";
            this.Pest4_Grupo_OpcionesManejo.Size = new System.Drawing.Size(332, 63);
            this.Pest4_Grupo_OpcionesManejo.TabIndex = 0;
            this.Pest4_Grupo_OpcionesManejo.TabStop = false;
            this.Pest4_Grupo_OpcionesManejo.Text = "Opciones de Manejo";
            // 
            // Pest4_Radio_Nuevo
            // 
            this.Pest4_Radio_Nuevo.AutoSize = true;
            this.Pest4_Radio_Nuevo.Location = new System.Drawing.Point(172, 29);
            this.Pest4_Radio_Nuevo.Name = "Pest4_Radio_Nuevo";
            this.Pest4_Radio_Nuevo.Size = new System.Drawing.Size(62, 17);
            this.Pest4_Radio_Nuevo.TabIndex = 1;
            this.Pest4_Radio_Nuevo.TabStop = true;
            this.Pest4_Radio_Nuevo.Text = "Nuevo";
            this.Pest4_Radio_Nuevo.UseVisualStyleBackColor = true;
            this.Pest4_Radio_Nuevo.CheckedChanged += new System.EventHandler(this.Pest4_Radio_Nuevo_CheckedChanged);
            // 
            // Pest4_Radio_BusqYManeji
            // 
            this.Pest4_Radio_BusqYManeji.AutoSize = true;
            this.Pest4_Radio_BusqYManeji.Location = new System.Drawing.Point(6, 29);
            this.Pest4_Radio_BusqYManeji.Name = "Pest4_Radio_BusqYManeji";
            this.Pest4_Radio_BusqYManeji.Size = new System.Drawing.Size(136, 17);
            this.Pest4_Radio_BusqYManeji.TabIndex = 0;
            this.Pest4_Radio_BusqYManeji.TabStop = true;
            this.Pest4_Radio_BusqYManeji.Text = "Busqueda y Manejo";
            this.Pest4_Radio_BusqYManeji.UseVisualStyleBackColor = true;
            this.Pest4_Radio_BusqYManeji.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // BTTN_Salir
            // 
            this.BTTN_Salir.Location = new System.Drawing.Point(968, 476);
            this.BTTN_Salir.Name = "BTTN_Salir";
            this.BTTN_Salir.Size = new System.Drawing.Size(133, 51);
            this.BTTN_Salir.TabIndex = 1;
            this.BTTN_Salir.Text = "Salir";
            this.BTTN_Salir.UseVisualStyleBackColor = true;
            this.BTTN_Salir.Click += new System.EventHandler(this.BTTN_Salir_Click);
            // 
            // contacto_ProveedorTableAdapter
            // 
            this.contacto_ProveedorTableAdapter.ClearBeforeFill = true;
            // 
            // proveedorTableAdapter
            // 
            this.proveedorTableAdapter.ClearBeforeFill = true;
            // 
            // fKProveedorHistoricoContactoProveedorBindingSource
            // 
            this.fKProveedorHistoricoContactoProveedorBindingSource.DataMember = "FK_Proveedor|Historico_Contacto|Proveedor";
            this.fKProveedorHistoricoContactoProveedorBindingSource.DataSource = this.contactoProveedorBindingSource;
            // 
            // proveedor_HistoricoTableAdapter
            // 
            this.proveedor_HistoricoTableAdapter.ClearBeforeFill = true;
            // 
            // fKProductoProveedorBindingSource
            // 
            this.fKProductoProveedorBindingSource.DataMember = "FK_Producto_Proveedor";
            this.fKProductoProveedorBindingSource.DataSource = this.proveedorBindingSource;
            // 
            // productoTableAdapter
            // 
            this.productoTableAdapter.ClearBeforeFill = true;
            // 
            // contactoProveedorBindingSource1
            // 
            this.contactoProveedorBindingSource1.DataMember = "Contacto|Proveedor";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form_Proveedores_Manejo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1118, 539);
            this.ControlBox = false;
            this.Controls.Add(this.BTTN_Salir);
            this.Controls.Add(this.PestañasManejoClientes);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form_Proveedores_Manejo";
            this.Text = "Manejo de Proveedores ";
            this.Load += new System.EventHandler(this.Form_Proveedores_Manejo_Load);
            this.PestañasManejoClientes.ResumeLayout(false);
            this.Pest1.ResumeLayout(false);
            this.Pest1_Grupo_ContactosDeProveedor.ResumeLayout(false);
            this.Pest1_Grupo_ContactosDeProveedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.Pest1_Grupo_DatosDeProveedor.ResumeLayout(false);
            this.Pest1_Grupo_DatosDeProveedor.PerformLayout();
            this.Pest2.ResumeLayout(false);
            this.Pest2_Grupo_MuestraDatos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventasAutoPartesDataSet)).EndInit();
            this.Pest2_Grupo_Busqueda.ResumeLayout(false);
            this.Pest2_Grupo_Busqueda.PerformLayout();
            this.Pest3.ResumeLayout(false);
            this.Pest3_Grupo_ContactosProveedor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Pest3_DataG_ContactosProveedor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactoProveedorBindingSource)).EndInit();
            this.Pest3_Grupo_Manejo.ResumeLayout(false);
            this.Pest3_Grupo_Manejo.PerformLayout();
            this.Pest4.ResumeLayout(false);
            this.Pest4_Grupo_OpcionesBusqueda.ResumeLayout(false);
            this.Pest4_Grupo_OpcionesBusqueda.PerformLayout();
            this.Pest4_Grupo_DatosContacto.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Pest4_DataGrid_ManejoContactos)).EndInit();
            this.Pest4_Grupo_ManejoDatos.ResumeLayout(false);
            this.Pest4_Grupo_ManejoDatos.PerformLayout();
            this.Pest4_Grupo_OpcionesManejo.ResumeLayout(false);
            this.Pest4_Grupo_OpcionesManejo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fKProveedorHistoricoContactoProveedorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKProductoProveedorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactoProveedorBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl PestañasManejoClientes;
        private System.Windows.Forms.TabPage Pest1;
        private System.Windows.Forms.TabPage Pest2;
        private System.Windows.Forms.TabPage Pest3;
        private System.Windows.Forms.TabPage Pest4;
        private System.Windows.Forms.GroupBox Pest4_Grupo_OpcionesBusqueda;
        private System.Windows.Forms.GroupBox Pest4_Grupo_DatosContacto;
        private System.Windows.Forms.DataGridView Pest4_DataGrid_ManejoContactos;
        private System.Windows.Forms.GroupBox Pest4_Grupo_ManejoDatos;
        private System.Windows.Forms.GroupBox Pest4_Grupo_OpcionesManejo;
        private System.Windows.Forms.Button BTTN_Salir;
        private VentasAutoPartesDataSet ventasAutoPartesDataSet;
        private System.Windows.Forms.BindingSource contactoProveedorBindingSource;
        private VentasAutoPartesDataSetTableAdapters.Contacto_ProveedorTableAdapter contacto_ProveedorTableAdapter;
        private System.Windows.Forms.RadioButton Pest4_Radio_BusqYManeji;
        private System.Windows.Forms.TextBox Pest4_Txt_BuscarProvNombre;
        private System.Windows.Forms.TextBox Pest4_Txt_BuscarCodigo;
        private System.Windows.Forms.TextBox Pest4_Txt_BuscarNombre;
        private System.Windows.Forms.RadioButton Pest4_Radio_ProveedorBusqueda;
        private System.Windows.Forms.RadioButton Pest4_Radio_CodigoBusqueda;
        private System.Windows.Forms.RadioButton Pest4_Radio_NombreBusqueda;
        private System.Windows.Forms.TextBox Pest4_Txt_NombreCont;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Pest4_Txt_CodigoContac;
        private System.Windows.Forms.TextBox Pest4_Txt_ApellidoCont;
        private System.Windows.Forms.TextBox Pest4_Txt_CorreoContact;
        private System.Windows.Forms.TextBox Pest4_Txt_RolContact;
        private System.Windows.Forms.RadioButton Pest4_Radio_Nuevo;
        private System.Windows.Forms.GroupBox Pest2_Grupo_Busqueda;
        private System.Windows.Forms.TextBox Pest2_Txt_CodigoBusqueda;
        private System.Windows.Forms.TextBox Pest2_Txt_NombreBusqueda;
        private System.Windows.Forms.RadioButton Pest2_Radio_CodigoProveedor;
        private System.Windows.Forms.RadioButton Pest2_Radio_NombreProveedor;
        private System.Windows.Forms.Button Pest4_Bttn_Limpiar;
        private System.Windows.Forms.Button Pest4_Bttn_Aceptar;
        private System.Windows.Forms.ComboBox Pest4_CoBx_Estado;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Rol;
        private System.Windows.Forms.GroupBox Pest2_Grupo_MuestraDatos;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button Pest2_Bttn_Limpiar;
        private System.Windows.Forms.BindingSource proveedorBindingSource;
        private VentasAutoPartesDataSetTableAdapters.ProveedorTableAdapter proveedorTableAdapter;
        private System.Windows.Forms.GroupBox Pest3_Grupo_ContactosProveedor;
        private System.Windows.Forms.DataGridView Pest3_DataG_ContactosProveedor;
        private System.Windows.Forms.GroupBox Pest3_Grupo_Manejo;
        private System.Windows.Forms.ComboBox Pest3_ComBx_Estado;
        private System.Windows.Forms.ComboBox Pest3_ComBx_Nacionalidad;
        private System.Windows.Forms.TextBox Pest3_Txt_CodigoPostal;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox Pest3_Txt_Direccion;
        private System.Windows.Forms.TextBox Pest3_Txt_CorreoElectronico;
        private System.Windows.Forms.TextBox Pest3_Txt_Nombre;
        private System.Windows.Forms.TextBox Pest3_Txt_Codigo;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox Pest1_Grupo_ContactosDeProveedor;
        private System.Windows.Forms.Button Pest1_Bttn_LimpiarCont;
        private System.Windows.Forms.Button Pest1_Bttn_AgregarCont;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox Pest1_Txt__ContactoNombre;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.TextBox Pest1_Txt__ContactoCodigo;
        private System.Windows.Forms.TextBox Pest1_Txt__ContactoTelefono;
        private System.Windows.Forms.TextBox Pest1_Txt__ContactoCorreo;
        private System.Windows.Forms.TextBox Pest1_Txt__ContactoRol;
        private System.Windows.Forms.TextBox Pest1_Txt__ContactoApellido;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.GroupBox Pest1_Grupo_DatosDeProveedor;
        private System.Windows.Forms.Button Pest1_Bttn_Limpiar;
        private System.Windows.Forms.Button Pest1_Bttn_Guardar;
        private System.Windows.Forms.ComboBox Pest1_ComBox_Estados;
        private System.Windows.Forms.ComboBox Pest1_ComBox_Nacionalidad;
        private System.Windows.Forms.TextBox Pest1_Txt__CodigoPostal;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox Pest1_Txt__Direccion;
        private System.Windows.Forms.TextBox Pest1_Txt__Correo;
        private System.Windows.Forms.TextBox Pest1_Txt__Nombre;
        private System.Windows.Forms.TextBox Pest1_Txt__CodigoProveedor;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Button Pest3_Txt_Aceptar;
        private System.Windows.Forms.Button Pest3_Bttn_Limpiar;
        private System.Windows.Forms.MaskedTextBox Pest1_Mask_NumeroFijoEmpleado;
        private System.Windows.Forms.ComboBox Pest4_ComBox_TelefonoFijoCodigo;
        private System.Windows.Forms.BindingSource fKProveedorHistoricoContactoProveedorBindingSource;
        private VentasAutoPartesDataSetTableAdapters.Proveedor_HistoricoTableAdapter proveedor_HistoricoTableAdapter;
        private System.Windows.Forms.BindingSource fKProductoProveedorBindingSource;
        private VentasAutoPartesDataSetTableAdapters.ProductoTableAdapter productoTableAdapter;
       
        private System.Windows.Forms.BindingSource contactoProveedorBindingSource1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo_Contacto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_Contacto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido_Contacto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Correo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cargo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo_Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo_Proveedor;
    }
}