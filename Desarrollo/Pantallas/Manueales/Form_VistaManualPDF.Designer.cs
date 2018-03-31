namespace Desarrollo.Pantallas.Manueales
{
    partial class Form_VistaManualPDF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_VistaManualPDF));
            this.PDF_Local = new AxAcroPDFLib.AxAcroPDF();
            this.Bttn_Salir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PDF_Local)).BeginInit();
            this.SuspendLayout();
            // 
            // PDF_Local
            // 
            this.PDF_Local.Enabled = true;
            this.PDF_Local.Location = new System.Drawing.Point(12, 12);
            this.PDF_Local.Name = "PDF_Local";
            this.PDF_Local.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("PDF_Local.OcxState")));
            this.PDF_Local.Size = new System.Drawing.Size(924, 523);
            this.PDF_Local.TabIndex = 0;
            // 
            // Bttn_Salir
            // 
            this.Bttn_Salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bttn_Salir.Location = new System.Drawing.Point(741, 553);
            this.Bttn_Salir.Name = "Bttn_Salir";
            this.Bttn_Salir.Size = new System.Drawing.Size(195, 65);
            this.Bttn_Salir.TabIndex = 1;
            this.Bttn_Salir.Text = "Salir";
            this.Bttn_Salir.UseVisualStyleBackColor = true;
            this.Bttn_Salir.Click += new System.EventHandler(this.Bttn_Salir_Click);
            // 
            // Form_VistaManualPDF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(948, 630);
            this.ControlBox = false;
            this.Controls.Add(this.Bttn_Salir);
            this.Controls.Add(this.PDF_Local);
            this.Name = "Form_VistaManualPDF";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vista de manual del sistema";
            ((System.ComponentModel.ISupportInitialize)(this.PDF_Local)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Bttn_Salir;
        public AxAcroPDFLib.AxAcroPDF PDF_Local;
    }
}