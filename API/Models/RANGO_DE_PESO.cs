using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    public class RANGO_DE_PESO
    {
        [NotMapped]
        public const int ACTIVO = 1;
        [NotMapped]
        public const int INACTIVO = 0;
        
        [Key]
        public int id { get; set; }

        [Required(ErrorMessage = "Campo {0} es requerido")]
        [StringLength(255, ErrorMessage = "El campo {0} tiene maximo de caracteres de {1} y un minimo de {2}", MinimumLength = 5)]
        public string rango_de_peso { get; set; }

        [Required(ErrorMessage = "Campo {0} es requerido")]
        [StringLength(255, ErrorMessage = "El campo {0} tiene maximo de caracteres de {1} y un minimo de {2}", MinimumLength = 5)]
        public string descripcion { get; set; }

        public int estado { get; set; } = ACTIVO;
    }
}