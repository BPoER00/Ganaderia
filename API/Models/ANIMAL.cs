using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    public class ANIMAL
    {
        [NotMapped]
        public const int ACTIVO = 1;
        [NotMapped]
        public const int INACTIVO = 0;

        [Key]
        public int id { get; set; }

        [ForeignKey("RAZA")]
        [Required(ErrorMessage = "Campo {0} es requerido")]
        public int id_raza { get; set; }

        [ForeignKey("CORRAL")]
        [Required(ErrorMessage = "Campo {0} es requerido")]
        public int id_corral { get; set; }

        public int estado { get; set; } = ACTIVO;

        //llave F
        public virtual RAZA RAZA { get; set; }
        public virtual CORRAL CORRAL { get; set; }
    }
}