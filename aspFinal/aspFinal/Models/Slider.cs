using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace aspFinal.Models
{
    public class Slider
    {
        public int Id { get; set; }

        [StringLength(200)]
        public string Image { get; set; }
    }
}
