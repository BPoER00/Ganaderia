using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
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