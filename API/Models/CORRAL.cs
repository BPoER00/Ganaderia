using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    public class CORRAL
    {
        [NotMapped]
        public const int LLENO = 2;
        [NotMapped]
        public const int ACTIVO = 1;
        [NotMapped]
        public const int INACTIVO = 0;
        
        [Key]
        public int id { get; set; }
        
        [ForeignKey("GENERO")]
        [Required(ErrorMessage = "Campo {0} es requerido")]
        public int id_genero { get; set; }

        [ForeignKey("RANGO")]
        [Required(ErrorMessage = "Campo {0} es requerido")]
        public int id_rango_peso { get; set; }

        [ForeignKey("FINCA")]
        [Required(ErrorMessage = "Campo {0} es requerido")]
        public int id_finca { get; set; }

        [Required(ErrorMessage = "Campo {0} es requerido")]
        public int numero_corral { get; set; }

        [Required(ErrorMessage = "Campo {0} es requerido")]
        public int cantidad_corral { get; set; }

        [Required(ErrorMessage = "Campo {0} es requerido")]
        public int cantidad_actual { get; set; }

        public int estado { get; set; } = ACTIVO;

        //llave F
        public virtual GENERO GENERO { get; set; }
        public virtual RANGO_DE_PESO RANGO { get; set; }
        public virtual FINCA FINCA { get; set; }

    }
}