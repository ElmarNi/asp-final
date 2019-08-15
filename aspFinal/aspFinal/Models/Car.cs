using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace aspFinal.Models
{
    public class Car
    {
        public int Id { get; set; }

        [StringLength(200)]
        public string Image { get; set; }

        [Required(ErrorMessage = "Please input a price")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "Please select make")]
        public int? MakeId { get; set; }

        public virtual Make Make { get; set; }

        [Required(ErrorMessage = "Please input a Year"),]
        public int ManufactureYear { get; set; }

        [Required(ErrorMessage = "Please input a motor")]
        public decimal Motor { get; set; }

        [Required(ErrorMessage = "Please input a millage")]
        public int Millage { get; set; }
        
        [Required(ErrorMessage = "Please input a color"), StringLength(200)]
        public string Color { get; set; }

        [Required(ErrorMessage = "Please select fuel type")]
        public int? FuelTypeId { get; set; }

        public virtual FuelType FuelType { get; set; }

        [Required(ErrorMessage = "Please select transmission")]
        public int? TransmissionId { get; set; }

        public virtual Transmission Transmission { get; set; }
        
        [Required]
        public bool IsVip { get; set; }

        [Required(ErrorMessage = "Please add a description"), StringLength(1000)]
        public string Description { get; set; }

        [NotMapped]
        public IFormFile Photo { get; set; }

        public Advertisement Advertisement { get; set; }

        public ICollection<CarDetailPhotos> CarDetailPhotos { get; set; }

        [NotMapped]
        public ICollection<IFormFile> DetailPhotos { get; set; }

    }
}
