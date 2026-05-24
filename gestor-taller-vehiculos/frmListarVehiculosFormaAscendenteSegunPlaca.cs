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
    public partial class frmListarVehiculosFormaAscendenteSegunPlaca : Form
    {
        CControladora registro = new CControladora();
        public frmListarVehiculosFormaAscendenteSegunPlaca()
        {
            InitializeComponent();
        }

        private void frmListarVehiculosFormaAscendenteSegunPlaca_Load(object sender, EventArgs e)
        {
            listView1.Items.Clear();


            foreach (CVehiculo vehiculo in registro.ListarVehiculosAscendenteSegunPlaca())
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
