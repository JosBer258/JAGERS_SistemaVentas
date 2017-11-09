namespace Desarrollo.Pantallas.Modulo__Ingreso_al_sistema
{
    partial class Menu_Principal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.empleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manejoDeEmpleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manejoDeRolesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.menuStrip1.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.empleadosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1362, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // empleadosToolStripMenuItem
            // 
            this.empleadosToolStripMenuItem.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.empleadosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manejoDeEmpleadosToolStripMenuItem,
            this.manejoDeRolesToolStripMenuItem});
            this.empleadosToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.empleadosToolStripMenuItem.Name = "empleadosToolStripMenuItem";
            this.empleadosToolStripMenuItem.Size = new System.Drawing.Size(96, 23);
            this.empleadosToolStripMenuItem.Text = "Empleados";
            // 
            // manejoDeEmpleadosToolStripMenuItem
            // 
            this.manejoDeEmpleadosToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.manejoDeEmpleadosToolStripMenuItem.Image = global::Desarrollo.Properties.Resources.corbata;
            this.manejoDeEmpleadosToolStripMenuItem.Name = "manejoDeEmpleadosToolStripMenuItem";
            this.manejoDeEmpleadosToolStripMenuItem.Size = new System.Drawing.Size(230, 24);
            this.manejoDeEmpleadosToolStripMenuItem.Text = "Manejo de Empleados";
            this.manejoDeEmpleadosToolStripMenuItem.Click += new System.EventHandler(this.manejoDeEmpleadosToolStripMenuItem_Click);
            // 
            // manejoDeRolesToolStripMenuItem
            // 
            this.manejoDeRolesToolStripMenuItem.BackColor = System.Drawing.SystemColors.HighlightText;
            this.manejoDeRolesToolStripMenuItem.Name = "manejoDeRolesToolStripMenuItem";
            this.manejoDeRolesToolStripMenuItem.Size = new System.Drawing.Size(230, 24);
            this.manejoDeRolesToolStripMenuItem.Text = "Manejo de Roles";
            this.manejoDeRolesToolStripMenuItem.Click += new System.EventHandler(this.manejoDeRolesToolStripMenuItem_Click);
            // 
            // Menu_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::Desarrollo.Properties.Resources.rayos_azules_51b330b6e7aaa;
            this.ClientSize = new System.Drawing.Size(1362, 741);
            this.ControlBox = false;
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.Highlight;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Menu_Principal";
            this.Text = "Menu_Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem empleadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manejoDeEmpleadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manejoDeRolesToolStripMenuItem;
    }
}