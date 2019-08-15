using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace aspFinal.Models
{
    public class FuelType
    {
        public int Id { get; set; }

        [Required, StringLength(200)]
        public string Type { get; set; }

        public ICollection<Car> Cars { get; set; }
    }
}
