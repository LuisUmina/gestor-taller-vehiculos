using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EP_FSI_Video1_Parte1
{
    class COrdenServicio
    {
        public String CodigoOrden { get; set; }
        public String NombreServicio { get; set; }
        public String NombreCliente { get; set; }
        public double MontoCancelado { get; set; }
        public String Dia { get; set; }
        public String Mes { get; set; }
        public String Anio { get; set; }

        public COrdenServicio()
        {

        }
    }
}
