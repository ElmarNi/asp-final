using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using aspFinal.Models;

namespace aspFinal.ViewModel
{
    public class CarDetailsVM
    {
        public Advertisement Advertisement { get; set; }
        public IEnumerable<Advertisement> RelatedAdvertisements { get; set; }
        public IEnumerable<Blog> Blogs { get; set; }
    }
}
