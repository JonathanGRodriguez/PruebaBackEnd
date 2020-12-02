using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ML
{
    public class Pasajero
    {
        public int IdPasajero { get; set; }

        [Required(ErrorMessage="Ingresa el nombre del pasajero, por favor")]
        public string Nombre { get; set; }

        [Required(ErrorMessage="Ingresa el primer apellido del pasajero, por favor")]
        public string ApellidoPaterno { get; set; }

        [Required(ErrorMessage="Ingresa el segundo apellido del pasajero, por favor")]
        public string ApellidoMaterno { get; set; }

        public List<object> Pasajeros { get; set; }
    }
}
