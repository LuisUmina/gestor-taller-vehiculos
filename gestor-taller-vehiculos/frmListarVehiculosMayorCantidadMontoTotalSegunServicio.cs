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
    public partial class frmListarVehiculosMayorCantidadMontoTotalSegunServicio : Form
    {
        CControladora registro = new CControladora();
        public frmListarVehiculosMayorCantidadMontoTotalSegunServicio()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if(cbNombreServicio.Text == "")
            {
                MessageBox.Show("Ingrese todos los campos", "Falta datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }


            //MOSTRAR
            listView1.Items.Clear();
            foreach (CVehiculo vehiculo in registro.ListarVehiculosMayorMontoTotalSegunServicio(cbNombreServicio.Text))
            {
                ListViewItem fila = new ListViewItem(vehiculo.Placa);
                fila.SubItems.Add(vehiculo.NumeroTarjetaPropiedad);
                fila.SubItems.Add(vehiculo.Modelo);
                fila.SubItems.Add(vehiculo.NumeroMotor);
                fila.SubItems.Add(vehiculo.FechaUltimoIngresoTaller);
                listView1.Items.Add(fila);
            }

        }
    }
}
