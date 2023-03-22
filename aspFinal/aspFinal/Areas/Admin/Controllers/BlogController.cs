using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using aspFinal.DAL;
using aspFinal.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using static aspFinal.Extensions.IFormFileEx;

namespace aspFinal.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BlogController : Controller
    {
        private readonly AspFinalDbContext _context;
        private readonly IWebHostEnvironment _env;
        public BlogController(AspFinalDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }
        public IActionResult Index()
        {
            IEnumerable<Blog> blogs = _context.Blogs.OrderByDescending(b => b.UpdatedDate);
            if (!User.Identity.IsAuthenticated)
            {
                return Redirect("/account/login");
            }
            if (!User.IsInRole("admin"))
            {
                return Redirect("/account/login");
            }
            return View(blogs);
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (!User.Identity.IsAuthenticated)
            {
                return Redirect("/account/login");
            }
            if (!User.IsInRole("admin"))
            {
                return Redirect("/account/login");
            }
            if (id == null)
            {
                return NotFound();
            }
            Blog blog = await _context.Blogs.FindAsync(id);
            if (blog == null)
            {
                return NotFound();
            }
            return View(blog);
        }

        public IActionResult Create()
        {
            if (!User.Identity.IsAuthenticated)
            {
                return Redirect("/account/login");
            }
            if (!User.IsInRole("admin"))
            {
                return Redirect("/account/login");
            }
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Blog blog)
        {
            if (!User.Identity.IsAuthenticated)
            {
                return Redirect("/account/login");
            }
            if (!User.IsInRole("admin"))
            {
                return Redirect("/account/login");
            }
            if (blog.Content == null)
            {
                ModelState.AddModelError("Content", "Plese input a valid content");
                return View(blog);
            }
            if (blog.ShortContent == null)
            {
                ModelState.AddModelError("Short Content", "Plese input a valid short content");
                return View(blog);
            }
            if (blog.Title == null)
            {
                ModelState.AddModelError("Title", "Plese input a valid title");
                return View(blog);
            }
            if (blog.Photo == null)
            {
                ModelState.AddModelError("Photo", "Photo should be selected");
                return View();
            }
            if (!blog.Photo.ContentType.Contains("image/"))
            {
                ModelState.AddModelError("Photo", "File type should be image");
                return View();
            }

            string filename = await blog.Photo.SavePhotoAsync(_env.WebRootPath, "blogs");
            blog.Image = filename;
            blog.CreateDate = DateTime.Now;
            blog.UpdatedDate = DateTime.Now;

            await _context.Blogs.AddAsync(blog);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (!User.Identity.IsAuthenticated)
            {
                return Redirect("/account/login");
            }
            if (!User.IsInRole("admin"))
            {
                return Redirect("/account/login");
            }
            if (id == null)
            {
                return NotFound();
            }
            Blog blog = await _context.Blogs.FindAsync(id);
            if (blog == null)
            {
                return NotFound();
            }
            return View(blog);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public async Task<IActionResult> DeletePost(int? id)
        {
            if (!User.Identity.IsAuthenticated)
            {
                return Redirect("/account/login");
            }
            if (!User.IsInRole("admin"))
            {
                return Redirect("/account/login");
            }
            if (id == null)
            {
                return NotFound();
            }
            Blog blog = await _context.Blogs.FindAsync(id);
            if (blog == null)
            {
                return NotFound();
            }
            if (!RemovePhoto(_env.WebRootPath, blog.Image))
            {
                ModelState.AddModelError("Photo", "Path not exsists this phooto");
                return View(blog);
            }
            _context.Blogs.Remove(blog);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Update(int? id)
        {
            if (!User.Identity.IsAuthenticated)
            {
                return Redirect("/account/login");
            }
            if (!User.IsInRole("admin"))
            {
                return Redirect("/account/login");
            }
            if (id == null)
            {
                return NotFound();
            }
            Blog blog = await _context.Blogs.FindAsync(id);
            if (blog == null)
            {
                return NotFound();
            }
            return View(blog);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(Blog blog)
        {
            if (!User.Identity.IsAuthenticated)
            {
                return Redirect("/account/login");
            }
            if (!User.IsInRole("admin"))
            {
                return Redirect("/account/login");
            }
            if (!ModelState.IsValid) return NotFound();
            Blog blogFromDb = await _context.Blogs.FindAsync(blog.Id);
            if (blog.Photo != null)
            {
                if (!blog.Photo.ContentType.Contains("image/"))
                {
                    ModelState.AddModelError("Photo", "File type should be image");
                    return View(blogFromDb);
                }
                RemovePhoto(_env.WebRootPath, _context.Blogs.Find(blog.Id).Image);
                blogFromDb.Image = await blog.Photo.SavePhotoAsync(_env.WebRootPath, "blogs");
            }
            blogFromDb.Title = blog.Title;
            blogFromDb.ShortContent = blog.ShortContent;
            blogFromDb.Content = blog.Content;
            blogFromDb.UpdatedDate = DateTime.Now;
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}