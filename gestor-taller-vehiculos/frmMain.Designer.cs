
namespace EP_FSI_Video1_Parte1
{
    partial class frmMain
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.rEGISTROToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rEPORTESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vehiculoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordenDeServicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarVehiculosMayorNumeroOrdenesEnDosUltimosAniosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarVehiculosFormaAscendenteSegunPlacaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarVehiculosMayorCantidadMontoTotalSegunServicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarVehiculosMenorNumeroMantenimientosRealizadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSalir = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rEGISTROToolStripMenuItem,
            this.rEPORTESToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(210, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // rEGISTROToolStripMenuItem
            // 
            this.rEGISTROToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vehiculoToolStripMenuItem,
            this.ordenDeServicioToolStripMenuItem});
            this.rEGISTROToolStripMenuItem.Name = "rEGISTROToolStripMenuItem";
            this.rEGISTROToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.rEGISTROToolStripMenuItem.Text = "REGISTRO";
            // 
            // rEPORTESToolStripMenuItem
            // 
            this.rEPORTESToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listarVehiculosMayorNumeroOrdenesEnDosUltimosAniosToolStripMenuItem,
            this.listarVehiculosFormaAscendenteSegunPlacaToolStripMenuItem,
            this.listarVehiculosMayorCantidadMontoTotalSegunServicioToolStripMenuItem,
            this.listarVehiculosMenorNumeroMantenimientosRealizadosToolStripMenuItem});
            this.rEPORTESToolStripMenuItem.Name = "rEPORTESToolStripMenuItem";
            this.rEPORTESToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.rEPORTESToolStripMenuItem.Text = "REPORTES";
            // 
            // vehiculoToolStripMenuItem
            // 
            this.vehiculoToolStripMenuItem.Name = "vehiculoToolStripMenuItem";
            this.vehiculoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.vehiculoToolStripMenuItem.Text = "Vehiculo";
            this.vehiculoToolStripMenuItem.Click += new System.EventHandler(this.vehiculoToolStripMenuItem_Click);
            // 
            // ordenDeServicioToolStripMenuItem
            // 
            this.ordenDeServicioToolStripMenuItem.Name = "ordenDeServicioToolStripMenuItem";
            this.ordenDeServicioToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ordenDeServicioToolStripMenuItem.Text = "OrdenDeServicio";
            this.ordenDeServicioToolStripMenuItem.Click += new System.EventHandler(this.ordenDeServicioToolStripMenuItem_Click);
            // 
            // listarVehiculosMayorNumeroOrdenesEnDosUltimosAniosToolStripMenuItem
            // 
            this.listarVehiculosMayorNumeroOrdenesEnDosUltimosAniosToolStripMenuItem.Name = "listarVehiculosMayorNumeroOrdenesEnDosUltimosAniosToolStripMenuItem";
            this.listarVehiculosMayorNumeroOrdenesEnDosUltimosAniosToolStripMenuItem.Size = new System.Drawing.Size(378, 22);
            this.listarVehiculosMayorNumeroOrdenesEnDosUltimosAniosToolStripMenuItem.Text = "ListarVehiculosMayorNumeroOrdenesEnDosUltimosAnios";
            this.listarVehiculosMayorNumeroOrdenesEnDosUltimosAniosToolStripMenuItem.Click += new System.EventHandler(this.listarVehiculosMayorNumeroOrdenesEnDosUltimosAniosToolStripMenuItem_Click);
            // 
            // listarVehiculosFormaAscendenteSegunPlacaToolStripMenuItem
            // 
            this.listarVehiculosFormaAscendenteSegunPlacaToolStripMenuItem.Name = "listarVehiculosFormaAscendenteSegunPlacaToolStripMenuItem";
            this.listarVehiculosFormaAscendenteSegunPlacaToolStripMenuItem.Size = new System.Drawing.Size(378, 22);
            this.listarVehiculosFormaAscendenteSegunPlacaToolStripMenuItem.Text = "ListarVehiculosFormaAscendenteSegunPlaca";
            this.listarVehiculosFormaAscendenteSegunPlacaToolStripMenuItem.Click += new System.EventHandler(this.listarVehiculosFormaAscendenteSegunPlacaToolStripMenuItem_Click);
            // 
            // listarVehiculosMayorCantidadMontoTotalSegunServicioToolStripMenuItem
            // 
            this.listarVehiculosMayorCantidadMontoTotalSegunServicioToolStripMenuItem.Name = "listarVehiculosMayorCantidadMontoTotalSegunServicioToolStripMenuItem";
            this.listarVehiculosMayorCantidadMontoTotalSegunServicioToolStripMenuItem.Size = new System.Drawing.Size(378, 22);
            this.listarVehiculosMayorCantidadMontoTotalSegunServicioToolStripMenuItem.Text = "ListarVehiculosMayorCantidadMontoTotalSegunServicio";
            this.listarVehiculosMayorCantidadMontoTotalSegunServicioToolStripMenuItem.Click += new System.EventHandler(this.listarVehiculosMayorCantidadMontoTotalSegunServicioToolStripMenuItem_Click);
            // 
            // listarVehiculosMenorNumeroMantenimientosRealizadosToolStripMenuItem
            // 
            this.listarVehiculosMenorNumeroMantenimientosRealizadosToolStripMenuItem.Name = "listarVehiculosMenorNumeroMantenimientosRealizadosToolStripMenuItem";
            this.listarVehiculosMenorNumeroMantenimientosRealizadosToolStripMenuItem.Size = new System.Drawing.Size(378, 22);
            this.listarVehiculosMenorNumeroMantenimientosRealizadosToolStripMenuItem.Text = "ListarVehiculosMenorNumeroMantenimientosRealizados";
            this.listarVehiculosMenorNumeroMantenimientosRealizadosToolStripMenuItem.Click += new System.EventHandler(this.listarVehiculosMenorNumeroMantenimientosRealizadosToolStripMenuItem_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(67, 62);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(210, 148);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem rEGISTROToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vehiculoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordenDeServicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rEPORTESToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarVehiculosMayorNumeroOrdenesEnDosUltimosAniosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarVehiculosFormaAscendenteSegunPlacaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarVehiculosMayorCantidadMontoTotalSegunServicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarVehiculosMenorNumeroMantenimientosRealizadosToolStripMenuItem;
        private System.Windows.Forms.Button btnSalir;
    }
}

