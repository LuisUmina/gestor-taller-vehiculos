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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void vehiculoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVehiculo form = new frmVehiculo();
            form.Show();
        }

        private void ordenDeServicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOrdenServicio form = new frmOrdenServicio();
            form.Show();
        }

        private void listarVehiculosMayorNumeroOrdenesEnDosUltimosAniosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListarVehiculosMayorNumeroOrdenesEnDosUltimosAnios form = new frmListarVehiculosMayorNumeroOrdenesEnDosUltimosAnios();
            form.Show();
        }

        private void listarVehiculosFormaAscendenteSegunPlacaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListarVehiculosFormaAscendenteSegunPlaca form = new frmListarVehiculosFormaAscendenteSegunPlaca();
            form.Show();
        }

        private void listarVehiculosMayorCantidadMontoTotalSegunServicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListarVehiculosMayorCantidadMontoTotalSegunServicio form = new frmListarVehiculosMayorCantidadMontoTotalSegunServicio();
            form.Show();
        }

        private void listarVehiculosMenorNumeroMantenimientosRealizadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListarVehiculosMenorNumeroMantenimientosRealizados form = new frmListarVehiculosMenorNumeroMantenimientosRealizados();
            form.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
