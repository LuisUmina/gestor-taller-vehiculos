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
    public partial class frmVehiculo : Form
    {
        CControladora registro = new CControladora();
        public frmVehiculo()
        {
            InitializeComponent();
        }

        private void mostrar(List<CVehiculo> lista)
        {
            listView1.Items.Clear();


            foreach(CVehiculo vehiculo in lista)
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
            //VERIFICAR QUE LOS CAMPOS ESTEN LLENOS
            if(txtPlacaVehiculos.Text == "" || txtNumTarjetaPropiedadVehiculo.Text == "" || txtModeloVehiculo.Text == "" || txtColorVehiculo.Text == "" || txtNumMotorVehiculo.Text == "" || txtFechaUltimoIngresoVehiculo.Text == "")
            {
                MessageBox.Show("Ingrese todos los campos necesarios", "Falta de Informacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;    
            }

            //VERIFICAR SI ESE VEHICULO EXISTE
            if (registro.ExisteVehiculoPlaca(txtPlacaVehiculos.Text))
            {
                MessageBox.Show("Este vehiculo ya esta registrado", "Coincidencia de Datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            //CREAR NUEVO
            CVehiculo nuevo = new CVehiculo();
            nuevo.Placa = txtPlacaVehiculos.Text;
            nuevo.NumeroTarjetaPropiedad = txtNumTarjetaPropiedadVehiculo.Text;
            nuevo.Modelo = txtModeloVehiculo.Text;
            nuevo.Color = txtColorVehiculo.Text;
            nuevo.NumeroMotor = txtNumMotorVehiculo.Text;
            nuevo.FechaUltimoIngresoTaller = txtFechaUltimoIngresoVehiculo.Text;

            //AGREGAR NUEVO OBJETO
            registro.AgregarVehiculos(nuevo);

            //MOSTRAR EN LIST VIEW
            mostrar(CControladora.Vehiculos);
        }

        private void frmVehiculo_Load(object sender, EventArgs e)
        {
            //MOSTRAR EN LIST VIEW
            mostrar(CControladora.Vehiculos);
        }
    }
}
