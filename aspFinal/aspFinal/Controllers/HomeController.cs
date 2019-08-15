using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using aspFinal.DAL;
using aspFinal.ViewModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using aspFinal.Models;

namespace aspFinal.Controllers
{
    public class HomeController : Controller
    {
        private readonly AspFinalDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        public HomeController(AspFinalDbContext context, RoleManager<IdentityRole> roleManager, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
            _roleManager = roleManager;
        }
        public async Task<IActionResult> Index()
        {
            //Creating roles
            if (!await _roleManager.RoleExistsAsync("admin"))
            {
                await _roleManager.CreateAsync(new IdentityRole("admin"));
            }
            if (!await _roleManager.RoleExistsAsync("member"))
            {
                await _roleManager.CreateAsync(new IdentityRole("member"));
            }
            if (await _userManager.GetUsersInRoleAsync("admin") == null)
            {
                ApplicationUser adminUser = new ApplicationUser
                {
                    UserName = "elmarib",
                    Firstname = "Elmar",
                    Lastname = "Ibrahimli",
                    Email = "elmarni@code.edu.az",
                    PhoneNumber = "+994553347347",
                    EmailConfirmed = true
                };
                await _userManager.CreateAsync(adminUser, "elmar1999");
                await _userManager.AddToRoleAsync(adminUser, "admin");
            }

            var countOfAdsForTake = 3;
            var countOfVipAds = _context.Advertisements.Where(ad => ad.Car.IsVip == true).Count();
            if (countOfVipAds % 3 != 0)
            {
                countOfAdsForTake = 3 - (countOfVipAds - 3);
            }
            ViewBag.TotalCount = _context.Advertisements.Where(ad => ad.Car.IsVip == false).Count();
            ViewBag.TakenAds = countOfAdsForTake;
            HomeIndexVM viewModel = new HomeIndexVM
            {
                Sliders = _context.Sliders,
                Advertisements = _context.Advertisements.Where(ad => ad.Car.IsVip == false)
                                          .Include(ad => ad.Car)
                                          .Include(ad => ad.Car.Make)
                                          .Include(ad => ad.Car.Make.Brand)
                                          .Include(ad => ad.Car.Transmission)
                                          .Include(ad => ad.Car.FuelType)
                                          .Include(ad => ad.City)
                                          .Include(ad => ad.City.Country)
                                          .OrderByDescending(ad => ad.UpdatedDate).Take(countOfAdsForTake),
                VipAdvertisements = _context.Advertisements
                                            .Where(ad => ad.Car.IsVip == true)
                                            .Include(ad => ad.Car)
                                            .Include(ad => ad.Car.Make)
                                            .Include(ad => ad.Car.Make.Brand)
                                            .Include(ad => ad.Car.Transmission)
                                            .Include(ad => ad.Car.FuelType)
                                            .Include(ad => ad.City)
                                            .Include(ad => ad.City.Country)
                                            .OrderByDescending(ad => ad.UpdatedDate),
                Blogs = _context.Blogs.OrderByDescending(blog => blog.UpdatedDate)
            };
            return View(viewModel);
        }
        public IActionResult LoadCars(int skip)
        {
            var model = _context.Advertisements.Where(ad => ad.Car.IsVip == false)
                                          .Include(ad => ad.Car)
                                          .Include(ad => ad.Car.Make)
                                          .Include(ad => ad.Car.Make.Brand)
                                          .Include(ad => ad.Car.Transmission)
                                          .Include(ad => ad.Car.FuelType)
                                          .Include(ad => ad.City)
                                          .Include(ad => ad.City.Country)
                                          .OrderByDescending(ad => ad.UpdatedDate).Skip(skip).Take(3);
            return PartialView("_CarsPartial", model);
        }
    }
}