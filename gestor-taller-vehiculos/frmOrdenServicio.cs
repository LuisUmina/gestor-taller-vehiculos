using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EP_FSI_Video1_Parte1
{
    public partial class frmOrdenServicio : Form
    {
        CControladora registro = new CControladora();
        public frmOrdenServicio()
        {
            InitializeComponent();
        }

        private void mostrar(List<CVehiculo> lista)
        {
            listView1.Items.Clear();


            foreach (CVehiculo vehiculo in lista)
            {
                ListViewItem fila = new ListViewItem(vehiculo.Placa);
                fila.SubItems.Add(vehiculo.NumeroTarjetaPropiedad);
                fila.SubItems.Add(vehiculo.Modelo);
                fila.SubItems.Add(vehiculo.NumeroMotor);
                fila.SubItems.Add(vehiculo.FechaUltimoIngresoTaller);
                listView1.Items.Add(fila);
            }

        }


        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if(txtCodigoOrdenServicio.Text == "" || cbNombreServicio.Text == "" || txtNombreClienteServicio.Text == "" || txtMontoCanceladoServicio.Text == "" || txtDiaServicio.Text == "" || txtMesServicio.Text == "" || txtAnioServicio.Text == "")
            {
                MessageBox.Show("Ingrese todos los campos necesarios", "Falta de Informacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }


            if (registro.ExisteOrdenServicio(txtCodigoOrdenServicio.Text))
            {
                MessageBox.Show("Esta orden de servicio ya esta registrada", "Coincidencia de datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            //VERIFICAR QUE SELECCIONO UN VEHICULO
            if(listView1.SelectedItems.Count <= 0)
            {
                MessageBox.Show("Seleccione un vehiculo donde quiera agregar la orden", "Falta datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            //CREAR OBJETO NUEVO
            COrdenServicio nuevo = new COrdenServicio();
            nuevo.CodigoOrden = txtCodigoOrdenServicio.Text;
            nuevo.NombreServicio = cbNombreServicio.Text;
            nuevo.NombreCliente = txtNombreClienteServicio.Text;
            nuevo.MontoCancelado = double.Parse(txtMontoCanceladoServicio.Text);
            nuevo.Dia = txtDiaServicio.Text;
            nuevo.Mes = txtMesServicio.Text;
            nuevo.Anio = txtAnioServicio.Text;

            //AGREGAR
            registro.AgregarOrdenServicioSegunVehiculo(nuevo, listView1.SelectedItems[0].Text);
            MessageBox.Show("Se agrego la orden al vehiculo con placa: " + listView1.SelectedItems[0].Text);


        }

        private void frmOrdenServicio_Load(object sender, EventArgs e)
        {
            mostrar(CControladora.Vehiculos);
        }
    }
}
