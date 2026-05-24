using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EP_FSI_Video1_Parte1
{
    class CVehiculo
    {
        public String Placa { get; set; }
        public String NumeroTarjetaPropiedad { get; set; }
        public String Modelo { get; set; }
        public String Color { get; set; }
        public String NumeroMotor { get; set; }
        public String FechaUltimoIngresoTaller { get; set; }
        public  List<COrdenServicio> OrdenesServicio{ get; set; }

        public CVehiculo()
        {
            if (OrdenesServicio == null)
                OrdenesServicio = new List<COrdenServicio>();
        }

        public double CalcularMontoTotalSegunServicio(String _servicio)
        {
            double MontoTotalServicios = 0.0;

            foreach(COrdenServicio orden in OrdenesServicio)
            {
                if(orden.NombreServicio == _servicio)
                {
                    MontoTotalServicios += orden.MontoCancelado;
                }
            }
            return MontoTotalServicios;
        }
    }
}
