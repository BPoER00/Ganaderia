using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Ganaderia.Models
{
    public class ANIMAL
    {
        [NotMapped]
        const int ACTIVO = 1;
        [NotMapped]
        const int INACTIVO = 2;

        [Key]
        public int id { get; set; }

        [ForeignKey("RAZA")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public int id_raza { get; set; }

        [ForeignKey("CORRAL")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public int id_corral { get; set; }

        public int estado { get; set; } = ACTIVO;

        //llaves foraneas
        public virtual RAZA RAZA { get; set; }
        public virtual CORRAL CORRAL { get; set; }
    }
}