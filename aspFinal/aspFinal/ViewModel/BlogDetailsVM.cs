using aspFinal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aspFinal.ViewModel
{
    public class BlogDetailsVM
    {
        public Blog Blog { get; set; }

        public IEnumerable<Blog> Blogs { get; set; }
    }
}
