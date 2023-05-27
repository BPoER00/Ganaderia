using System.ComponentModel.DataAnnotations.Schema;

namespace Ganaderia.Models
{
    public class Reply
    {
        [NotMapped]
        public int code { get; set; }
        [NotMapped]
        public object data { get; set; }
        [NotMapped]
        public string message { get; set; }
    }
}