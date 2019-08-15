using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using aspFinal.DAL;
using aspFinal.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace aspFinal.Areas.Admin.Controllers
{

    [Area("Admin")]
    public class AdvertisementController : Controller
    {
        private readonly AspFinalDbContext _context;
        public AdvertisementController(AspFinalDbContext context)
        {
            _context = context;

        }
        public IActionResult Index()
        {
            if (!User.Identity.IsAuthenticated)
            {
                return Redirect("/account/login");
            }
            if (!User.IsInRole("admin"))
            {
                return Redirect("/account/login");
            }
            IEnumerable<Advertisement> advertisements = _context.Advertisements
                                                                .Include(ad => ad.Car)
                                                                .Include(ad => ad.Car.Make)
                                                                .Include(ad => ad.Car.Make.Brand)
                                                                .Include(ad => ad.Car.Transmission)
                                                                .Include(ad => ad.Car.FuelType)
                                                                .Include(ad => ad.City)
                                                                .Include(ad => ad.City.Country)
                                                                .OrderByDescending(ad => ad.UpdatedDate);
            return View(advertisements);
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
            Advertisement advertisement = await _context.Advertisements.Where(ad => ad.Id == id)
                                                                 .Include(ad => ad.Car)
                                                                 .Include(ad => ad.Car.Make)
                                                                 .Include(ad => ad.Car.Make.Brand)
                                                                 .Include(ad => ad.Car.Transmission)
                                                                 .Include(ad => ad.Car.FuelType)
                                                                 .Include(ad => ad.City)
                                                                 .Include(ad => ad.City.Country).FirstOrDefaultAsync();
            if (advertisement == null)
            {
                return NotFound();
            }
            return View(advertisement);
        }
    }
}