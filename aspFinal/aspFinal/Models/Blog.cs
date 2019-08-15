using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace aspFinal.Models
{
    public class Blog
    {
        public int Id { get; set; }
        public string Image { get; set; }

        [Required(ErrorMessage ="Please input a title."), StringLength(200, ErrorMessage ="Max length must be less than 200 character")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Please input a content.")]
        public string Content { get; set; }

        [Required(ErrorMessage ="Please input a short content"), StringLength(200, ErrorMessage = "Max length must be less than 200 character")]
        public string ShortContent { get; set; }

        [Required]
        public DateTime CreateDate { get; set; }

        
        public DateTime UpdatedDate { get; set; }

        [NotMapped]
        public IFormFile Photo { get; set; }
    }
}
