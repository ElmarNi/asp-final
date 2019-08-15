using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace aspFinal.Models
{
    public class Advertisement
    {
        public int Id { get; set; }

        [Required]
        public int CarId { get; set; }
        public virtual Car Car { get; set; }

        [Required]
        public DateTime CurrentDate { get; set; }

        public DateTime UpdatedDate { get; set; }

        [Required(ErrorMessage = "Please select city")]
        public int? CityId { get; set; }
        public virtual City City { get; set; }

        public string ApplicationUserId { get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; }

    }
}
