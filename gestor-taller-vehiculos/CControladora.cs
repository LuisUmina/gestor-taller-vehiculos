using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EP_FSI_Video1_Parte1
{
    class CControladora
    {
        public static List<CVehiculo> Vehiculos = new List<CVehiculo>();
        public CControladora() { }


        //METODOS
        //-> Agregar vehiculos
        public void AgregarVehiculos(CVehiculo nuevo)
        {
            Vehiculos.Add(nuevo);
        }
        //-> Verificar si el vehiculo existe (placa)
        public bool ExisteVehiculoPlaca(String _placa)
        {
            return Vehiculos.Exists(y => y.Placa.Equals(_placa));
        }
        //-> Agregar Ordenes de Servicio segun vehiculo
        public void AgregarOrdenServicioSegunVehiculo(COrdenServicio nuevo, String _placa)
        {
            CVehiculo buscar = Vehiculos.Find(a => a.Placa.Equals(_placa));

            buscar.OrdenesServicio.Add(nuevo);
        }
        //-> Verificar si la orden existe
        public bool ExisteOrdenServicio(String _codigo)
        {
            foreach(CVehiculo vehiculo in Vehiculos)
            {
                bool buscar = vehiculo.OrdenesServicio.Exists(a => a.CodigoOrden.Equals(_codigo));
                if (buscar == true)
                    return true;
            }
            return false;
        }
        //-> Listar vehiculos de manera ascendente segun placa
        public List<CVehiculo> ListarVehiculosAscendenteSegunPlaca()
        {
            return Vehiculos.OrderBy(a => a.Placa).ToList();
        }

        //-> Listar vehiculo o vehiculos que tienen el mayor monto total cancelado segun servicio
        public List<CVehiculo> ListarVehiculosMayorMontoTotalSegunServicio(String _servicio)
        {
            ////->1
            ////BUSCAR EL MAYOR
            //double mayor = 0.0;
            //foreach(CVehiculo vehi in Vehiculos)
            //{
            //    if(vehi.CalcularMontoTotalSegunServicio(_servicio) > mayor)
            //    {
            //        mayor = vehi.CalcularMontoTotalSegunServicio(_servicio);
            //    }
            //}

            ////BUSCAR AQUELLOS VEHICULOS QUE MT -> MAYOR
            //List<CVehiculo> temp = new List<CVehiculo>();
            //foreach(CVehiculo vehi in Vehiculos)
            //{
            //    if(vehi.CalcularMontoTotalSegunServicio(_servicio) == mayor)
            //    {
            //        temp.Add(vehi);
            //    }
            //}

            //->2
            List<CVehiculo> temp = new List<CVehiculo>();
            double mayor = 0.0;
            foreach (CVehiculo vehi in Vehiculos)
            {
                double calcular = vehi.CalcularMontoTotalSegunServicio(_servicio);
                if(calcular > mayor)
                {
                    mayor = calcular;
                    temp.Clear();
                    temp.Add(vehi);
                } else if(calcular == mayor)
                {
                    temp.Add(vehi);
                }
            }
            return temp;
        }
        //-> Listar el o los vehiculos que tienen el menor numero de mantenimientos realdos
        public List<CVehiculo> ListarVehiculosMenorNumeroMantenimientosRealizados()
        {
            int min = 9999;

            foreach(CVehiculo vehi in Vehiculos)
            {
                if(vehi.OrdenesServicio.Count < min)
                {
                    min = vehi.OrdenesServicio.Count;
                }
            }

            List<CVehiculo> temp = new List<CVehiculo>();

            foreach (CVehiculo vehi in Vehiculos)
            {
                if (vehi.OrdenesServicio.Count == min)
                {
                    temp.Add(vehi);
                }
            }

            return temp;
        }

        //-> Listar vehiculos Mas ordenes de servicios en los dos ultimos Anios
        public List<CVehiculo> ListarVehiculosMasOrdenesServicioEnDosUltimosAnios()
        {
            List<CVehiculo> temp = new List<CVehiculo>();
            int max = 0;

            foreach(CVehiculo vehi in Vehiculos)
            {
                int cantBuscar = vehi.OrdenesServicio.Count(a => (int.Parse(a.Anio) > 2021));
                if(cantBuscar > max)
                {
                    max = cantBuscar;
                    temp.Clear();
                    temp.Add(vehi);
                }else if(cantBuscar == max)
                {
                    temp.Add(vehi);
                }
            }
            return temp;
        }

    }
}
