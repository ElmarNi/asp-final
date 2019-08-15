using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using aspFinal.DAL;
using aspFinal.ViewModel;
using aspFinal.Models;

namespace aspFinal.Controllers
{
    public class BlogController : Controller
    {
        private readonly AspFinalDbContext _context;
        public BlogController(AspFinalDbContext context)
        {
            _context = context;
        }
        public IActionResult Details(int id)
        {
            if (!_context.Blogs.Any(blog => blog.Id == id))
            {
                return PartialView("ErrorPage");
            }
            BlogDetailsVM viewModel = new BlogDetailsVM
            {
                Blog = _context.Blogs.Where(b => b.Id == id).FirstOrDefault(),
                Blogs = _context.Blogs.OrderByDescending(b => b.UpdatedDate).Take(5)
            };
            return View(viewModel);
        }
    }
}