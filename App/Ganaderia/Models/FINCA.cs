using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ganaderia.Models
{
    public class FINCA
    {
        [NotMapped]
        const int ACTIVO = 1;
        [NotMapped]
        const int INACTIVO = 2;

        [Key]
        public int id { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [StringLength(255, ErrorMessage = "El campo {0} tiene un maximo de {1}, y un maximo de {2}", MinimumLength = 5)]
        public String nombre { get; set; }

        [ForeignKey("DIRECCION")]
        public int id_ubicacion { get; set; }
        public int estado { get; set; } = ACTIVO;
    
        //llave foranea
        public virtual DIRECCION DIRECCION { get; set; }
    }
}