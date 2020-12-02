using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ML
{
    public class Usuario
    {
        public int IdUsuario { get; set; }

        [Required(ErrorMessage="Ingresa tu nombre, por favor"), MaxLength(50)]
        public string Nombre { get; set; }
        
        [Required(ErrorMessage="Ingresa tu primer apellido, por favor"), MaxLength(50)]
        public string ApellidoPaterno { get; set; }
        
        [Required(ErrorMessage="Ingresa tu segundo apellido, por favor"), MaxLength(50)]
        public string ApellidoMaterno { get; set; }

        [Required(ErrorMessage="Ingresa un nombre de usuario, por favor"), MaxLength(80)]
        public string UserName { get; set; }

        [Required(ErrorMessage="Ingresa una contraseña, por favor"), MaxLength(80)]
        public string Contrasenia { get; set; }

        [Required(ErrorMessage="Confirma tu contraseña, por favor"), MaxLength(80)]
        [Compare("Contrasenia", ErrorMessage="La contraseña no coincide")]
        public string ConfirmaContrasenia { get; set; }

        public List<object> Usuarios { get; set; }
    }
}
