using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ML
{
    public class Vuelo
    {
        [Required(ErrorMessage="Ingresa el número de vuelo, por favor"), MaxLength(4)]
        public string NumeroVuelo { get; set; }

        [Required(ErrorMessage="Ingresa el origen, por favor"), MaxLength(2)]
        public string Origen { get; set; }

        [Required(ErrorMessage="Ingresa el destino, por favor"), MaxLength(2)]
        public string Destino { get; set; }

        [Required(ErrorMessage="Se requiere una fecha de salida")]
        [DisplayFormat(DataFormatString="{yyyy/MM/dd hh:mm:ss}")]
        public DateTime FechaSalida { get; set; }

        public List<object> Vuelos { get; set; }
    }
}
