using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Ganaderia.Models
{
    public class CORRAL
    {
        [NotMapped]
        const int ACTIVO = 1;
        [NotMapped]
        const int INACTIVO = 2;

        [Key]
        public int id { get; set; }

        [ForeignKey("GENERO")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public int id_genero { get; set; }

        [ForeignKey("RANGO_DE_PESO")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public int id_rango_peso { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [ForeignKey("FINCA")]
        public int id_finca { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public int numero_corral { get; set; }
        
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public int cantidad_corral { get; set; }
        
        public int cantidad_actual { get; set; }

        public int estado { get; set; } = ACTIVO;

        //llaves foraneas
        public virtual GENERO GENERO { get; set; }
        public virtual RANGO_DE_PESO RANGO_DE_PESO { get; set; }
        public virtual FINCA FINCA { get; set; }
    }
}