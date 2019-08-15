using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using aspFinal.Models;

namespace aspFinal.ViewModel
{
    public class HomeIndexVM
    {
        public IEnumerable<Slider> Sliders { get; set; }

        public IEnumerable<Advertisement> Advertisements { get; set; }

        public IEnumerable<Advertisement> VipAdvertisements { get; set; }

        public IEnumerable<Blog> Blogs { get; set; }

    }
}
