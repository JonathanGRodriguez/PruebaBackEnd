using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ML
{
    public class DetalleReservacion
    {
        public int IdDetalleReservacion { get; set; }
        public Pasajero Pasajero { get; set; }
        public Reservacion Reservacion { get; set; }
        public List<object> DetallesReservacion { get; set; }

    }
}
