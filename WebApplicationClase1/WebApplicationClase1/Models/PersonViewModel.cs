using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationClase1.Models
{
    public class PersonViewModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Es requerido")]
        public string Nombre { get; set; }
        public string Apellido { get; set; }
    }
}
