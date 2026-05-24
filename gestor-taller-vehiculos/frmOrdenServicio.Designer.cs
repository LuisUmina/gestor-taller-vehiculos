
namespace EP_FSI_Video1_Parte1
{
    partial class frmOrdenServicio
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCodigoOrdenServicio = new System.Windows.Forms.TextBox();
            this.txtAnioServicio = new System.Windows.Forms.TextBox();
            this.txtMesServicio = new System.Windows.Forms.TextBox();
            this.txtDiaServicio = new System.Windows.Forms.TextBox();
            this.txtMontoCanceladoServicio = new System.Windows.Forms.TextBox();
            this.txtNombreClienteServicio = new System.Windows.Forms.TextBox();
            this.cbNombreServicio = new System.Windows.Forms.ComboBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ORDENES DE SERVICIO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "MontoCancelado:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "NombreCliente:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "NombreServicio";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "FechaServicio:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "CodigoOrden:";
            // 
            // txtCodigoOrdenServicio
            // 
            this.txtCodigoOrdenServicio.Location = new System.Drawing.Point(99, 37);
            this.txtCodigoOrdenServicio.Name = "txtCodigoOrdenServicio";
            this.txtCodigoOrdenServicio.Size = new System.Drawing.Size(127, 20);
            this.txtCodigoOrdenServicio.TabIndex = 6;
            // 
            // txtAnioServicio
            // 
            this.txtAnioServicio.Location = new System.Drawing.Point(179, 142);
            this.txtAnioServicio.Name = "txtAnioServicio";
            this.txtAnioServicio.Size = new System.Drawing.Size(34, 20);
            this.txtAnioServicio.TabIndex = 7;
            // 
            // txtMesServicio
            // 
            this.txtMesServicio.Location = new System.Drawing.Point(139, 142);
            this.txtMesServicio.Name = "txtMesServicio";
            this.txtMesServicio.Size = new System.Drawing.Size(34, 20);
            this.txtMesServicio.TabIndex = 8;
            // 
            // txtDiaServicio
            // 
            this.txtDiaServicio.Location = new System.Drawing.Point(99, 142);
            this.txtDiaServicio.Name = "txtDiaServicio";
            this.txtDiaServicio.Size = new System.Drawing.Size(34, 20);
            this.txtDiaServicio.TabIndex = 9;
            // 
            // txtMontoCanceladoServicio
            // 
            this.txtMontoCanceladoServicio.Location = new System.Drawing.Point(99, 116);
            this.txtMontoCanceladoServicio.Name = "txtMontoCanceladoServicio";
            this.txtMontoCanceladoServicio.Size = new System.Drawing.Size(127, 20);
            this.txtMontoCanceladoServicio.TabIndex = 10;
            // 
            // txtNombreClienteServicio
            // 
            this.txtNombreClienteServicio.Location = new System.Drawing.Point(99, 90);
            this.txtNombreClienteServicio.Name = "txtNombreClienteServicio";
            this.txtNombreClienteServicio.Size = new System.Drawing.Size(127, 20);
            this.txtNombreClienteServicio.TabIndex = 11;
            // 
            // cbNombreServicio
            // 
            this.cbNombreServicio.FormattingEnabled = true;
            this.cbNombreServicio.Items.AddRange(new object[] {
            "mantenimiento de frenos",
            "mantenimiento de motor",
            "mantenimiento de direccion",
            "cambio de aceite"});
            this.cbNombreServicio.Location = new System.Drawing.Point(99, 63);
            this.cbNombreServicio.Name = "cbNombreServicio";
            this.cbNombreServicio.Size = new System.Drawing.Size(127, 21);
            this.cbNombreServicio.TabIndex = 12;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(12, 186);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(214, 23);
            this.btnAgregar.TabIndex = 13;
            this.btnAgregar.Text = "AGREGAR";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(259, 9);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(440, 239);
            this.listView1.TabIndex = 15;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Placa";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "NumeroTarjetaPropiedad";
            this.columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Modelo";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "NumeroMotor";
            this.columnHeader4.Width = 90;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "FechaUltimoIngreso";
            this.columnHeader5.Width = 100;
            // 
            // frmOrdenServicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 255);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.cbNombreServicio);
            this.Controls.Add(this.txtNombreClienteServicio);
            this.Controls.Add(this.txtMontoCanceladoServicio);
            this.Controls.Add(this.txtDiaServicio);
            this.Controls.Add(this.txtMesServicio);
            this.Controls.Add(this.txtAnioServicio);
            this.Controls.Add(this.txtCodigoOrdenServicio);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmOrdenServicio";
            this.Text = "frmOrdenServicio";
            this.Load += new System.EventHandler(this.frmOrdenServicio_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCodigoOrdenServicio;
        private System.Windows.Forms.TextBox txtAnioServicio;
        private System.Windows.Forms.TextBox txtMesServicio;
        private System.Windows.Forms.TextBox txtDiaServicio;
        private System.Windows.Forms.TextBox txtMontoCanceladoServicio;
        private System.Windows.Forms.TextBox txtNombreClienteServicio;
        private System.Windows.Forms.ComboBox cbNombreServicio;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
    }
}