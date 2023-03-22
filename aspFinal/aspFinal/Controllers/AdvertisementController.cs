using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using aspFinal.DAL;
using aspFinal.Extensions;
using aspFinal.Models;
using aspFinal.ViewModel;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using static aspFinal.Extensions.IFormFileEx;
namespace aspFinal.Controllers
{
    public class AdvertisementController : Controller
    {
        private readonly AspFinalDbContext _context;
        private readonly IWebHostEnvironment _env;
        public AdvertisementController(AspFinalDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return PartialView("ErrorPage");
            }
            if (!_context.Advertisements.Any(ad => ad.Id == id))
            {
                return PartialView("ErrorPage");
            }
            var selectedAd = await _context.Advertisements.Where(ad => ad.Id == id)
                            .Include(ad => ad.Car)
                            .Include(ad => ad.Car.Make)
                            .Include(ad => ad.Car.Make.Brand)
                            .Include(ad => ad.Car.Transmission)
                            .Include(ad => ad.Car.FuelType)
                            .Include(ad => ad.City)
                            .Include(ad => ad.City.Country)
                            .Include(ad => ad.Car.CarDetailPhotos)
                            .FirstOrDefaultAsync();
            CarDetailsVM viewModel = new CarDetailsVM
            {
                Advertisement = selectedAd,
                RelatedAdvertisements = _context.Advertisements.Where(ad => ad.Car.Make.BrandId == selectedAd.Car.Make.BrandId && ad.Id != selectedAd.Id)
                                                .Include(ad => ad.Car)
                                                .Include(ad => ad.Car.Make)
                                                .Include(ad => ad.Car.Make.Brand)
                                                .Include(ad => ad.Car.Transmission)
                                                .Include(ad => ad.Car.FuelType)
                                                .Include(ad => ad.City)
                                                .Include(ad => ad.City.Country)
                                                .OrderByDescending(ad => ad.UpdatedDate)
                                                .Take(3),
                Blogs = _context.Blogs.OrderByDescending(blog => blog.UpdatedDate).Take(3)
            };
            return View(viewModel);
        }

        public IActionResult Index()
        {
            if (!User.Identity.IsAuthenticated)
            {
                return Redirect("/account/login");
            }
            if (!User.IsInRole("member"))
            {
                return Redirect("/account/login");
            }
            IEnumerable<Advertisement> advertisements = _context.Advertisements.Where(ad => ad.ApplicationUser.UserName == User.Identity.Name)
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

        public IActionResult Create()
        {
            if (!User.Identity.IsAuthenticated)
            {
                return Redirect("/account/login");
            }
            if (!User.IsInRole("member"))
            {
                return Redirect("/account/login");
            }

            ViewBag.Countries = _context.Countries;
            ViewBag.Brands = _context.Brands;
            ViewBag.Transmissions = _context.Transmissions;
            ViewBag.Fuels = _context.FuelTypes;
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Car car)
        {
            if (!User.Identity.IsAuthenticated)
            {
                return Redirect("/account/login");
            }
            if (!User.IsInRole("member"))
            {
                return Redirect("/account/login");
            }
            if (car.MakeId == null)
            {
                ModelState.AddModelError("MakeId", "Select a valid make");
                ViewBag.Countries = _context.Countries;
                ViewBag.Brands = _context.Brands;
                ViewBag.Transmissions = _context.Transmissions;
                ViewBag.Fuels = _context.FuelTypes;
                return View(car);
            }
            if (car.ManufactureYear < 1700 || car.ManufactureYear > DateTime.Now.Year)
            {
                ModelState.AddModelError("ManufactureYear", "Input a valid manufacture year");
                ViewBag.Countries = _context.Countries;
                ViewBag.Brands = _context.Brands;
                ViewBag.Transmissions = _context.Transmissions;
                ViewBag.Fuels = _context.FuelTypes;
                return View(car);
            }
            if (car.Motor <= 0)
            {
                ModelState.AddModelError("Motor", "Input a valid Motor");
                ViewBag.Countries = _context.Countries;
                ViewBag.Brands = _context.Brands;
                ViewBag.Transmissions = _context.Transmissions;
                ViewBag.Fuels = _context.FuelTypes;
                return View(car);
            }
            if (car.Millage < 0)
            {
                ModelState.AddModelError("Millage", "Input a valid Millage");
                ViewBag.Countries = _context.Countries;
                ViewBag.Brands = _context.Brands;
                ViewBag.Transmissions = _context.Transmissions;
                ViewBag.Fuels = _context.FuelTypes;
                return View(car);
            }
            if (int.TryParse(car.Color, out _))
            {
                ModelState.AddModelError("Color", "Input a valid Color");
                ViewBag.Countries = _context.Countries;
                ViewBag.Brands = _context.Brands;
                ViewBag.Transmissions = _context.Transmissions;
                ViewBag.Fuels = _context.FuelTypes;
                return View(car);
            }
            if (car.TransmissionId == null)
            {
                ModelState.AddModelError("TransmissionId", "Select a valid Transmission");
                ViewBag.Countries = _context.Countries;
                ViewBag.Brands = _context.Brands;
                ViewBag.Transmissions = _context.Transmissions;
                ViewBag.Fuels = _context.FuelTypes;
                return View(car);
            }
            if (car.FuelTypeId == null)
            {
                ModelState.AddModelError("FuelTypeId", "Select a valid Fuel type");
                ViewBag.Countries = _context.Countries;
                ViewBag.Brands = _context.Brands;
                ViewBag.Transmissions = _context.Transmissions;
                ViewBag.Fuels = _context.FuelTypes;
                return View(car);
            }
            if (car.Description.Length < 200)
            {
                ModelState.AddModelError("Description", "Description is too short");
                ViewBag.Countries = _context.Countries;
                ViewBag.Brands = _context.Brands;
                ViewBag.Transmissions = _context.Transmissions;
                ViewBag.Fuels = _context.FuelTypes;
                return View(car);
            }
            if (car.Price < 0)
            {
                ModelState.AddModelError("Price", "Input a valid Price");
                ViewBag.Countries = _context.Countries;
                ViewBag.Brands = _context.Brands;
                ViewBag.Transmissions = _context.Transmissions;
                ViewBag.Fuels = _context.FuelTypes;
                return View(car);
            }
            if (car.Advertisement.CityId == null)
            {
                ModelState.AddModelError("Advertisement.CityId", "Select a valid City");
                ViewBag.Countries = _context.Countries;
                ViewBag.Brands = _context.Brands;
                ViewBag.Transmissions = _context.Transmissions;
                ViewBag.Fuels = _context.FuelTypes;
                return View(car);
            }
            if (car.Photo == null)
            {
                ModelState.AddModelError("Photo", "Select a Photo");
                ViewBag.Countries = _context.Countries;
                ViewBag.Brands = _context.Brands;
                ViewBag.Transmissions = _context.Transmissions;
                ViewBag.Fuels = _context.FuelTypes;
                return View(car);
            }
            if (!car.Photo.ContentType.Contains("image/"))
            {
                ModelState.AddModelError("Photo", "File type should be image");
                ViewBag.Countries = _context.Countries;
                ViewBag.Brands = _context.Brands;
                ViewBag.Transmissions = _context.Transmissions;
                ViewBag.Fuels = _context.FuelTypes;
                return View(car);
            }

            if (car.DetailPhotos == null)
            {
                ModelState.AddModelError("DetailPhotos", "Select car detail photos");
                ViewBag.Countries = _context.Countries;
                ViewBag.Brands = _context.Brands;
                ViewBag.Transmissions = _context.Transmissions;
                ViewBag.Fuels = _context.FuelTypes;
                return View(car);
            }
            await _context.Cars.AddAsync(car);
            foreach (var photo in car.DetailPhotos)
            {
                if (!photo.ContentType.Contains("image/"))
                {
                    ModelState.AddModelError("DetailPhotos", "File type should be image");
                    ViewBag.Countries = _context.Countries;
                    ViewBag.Brands = _context.Brands;
                    ViewBag.Transmissions = _context.Transmissions;
                    ViewBag.Fuels = _context.FuelTypes;
                    return View(car);
                }
                
                //await _context.SaveChangesAsync();
            }
            foreach (var photo in car.DetailPhotos)
            {
                CarDetailPhotos detailPhoto = new CarDetailPhotos
                {
                    CarId = car.Id,
                    Image = await photo.SavePhotoAsync(_env.WebRootPath, "advertisements")
                };
                await _context.CarDetailPhotos.AddAsync(detailPhoto);
            }
            string filename = await car.Photo.SavePhotoAsync(_env.WebRootPath, "advertisements");
            car.Image = filename;
            car.Advertisement.CurrentDate = DateTime.Now;
            car.Advertisement.UpdatedDate = DateTime.Now;
            car.Advertisement.ApplicationUserId = _context.Users.Where(u => u.UserName == User.Identity.Name).FirstOrDefault().Id;


            await _context.Advertisements.AddAsync(car.Advertisement);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (!User.Identity.IsAuthenticated)
            {
                return Redirect("/account/login");
            }
            if (!User.IsInRole("member"))
            {
                return Redirect("/account/login");
            }
            if (User.Identity.Name != _context.Advertisements.Where(ad => ad.Id == id).Include(ad => ad.ApplicationUser).FirstOrDefault().ApplicationUser.UserName)
            {
                return Redirect("/account/login");
            }
            if (id == null)
            {
                return PartialView("ErrorPage");
            }
            if (!_context.Advertisements.Any(ad => ad.Id == id))
            {
                return PartialView("ErrorPage");
            }

            var selectedAd = await _context.Advertisements.Where(ad => ad.Id == id)
                            .Include(ad => ad.Car)
                            .Include(ad => ad.Car.Make)
                            .Include(ad => ad.Car.Make.Brand)
                            .Include(ad => ad.Car.Transmission)
                            .Include(ad => ad.Car.FuelType)
                            .Include(ad => ad.Car.CarDetailPhotos)
                            .Include(ad => ad.City)
                            .Include(ad => ad.City.Country)
                            .FirstOrDefaultAsync();

            return View(selectedAd);
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
            if (!User.IsInRole("member"))
            {
                return Redirect("/account/login");
            }
            if (id == null)
            {
                return PartialView("ErrorPage");
            }
            if (!_context.Advertisements.Any(ad => ad.Id == id))
            {
                return PartialView("ErrorPage");
            }
            if (User.Identity.Name != _context.Advertisements.Where(ad => ad.Id == id).Include(ad => ad.ApplicationUser).FirstOrDefault().ApplicationUser.UserName)
            {
                return Redirect("/account/login");
            }
            
            Advertisement advertisement = await _context.Advertisements.Where(ad => ad.Id == id)
                            .Include(ad => ad.Car)
                            .Include(ad => ad.Car.Make)
                            .Include(ad => ad.Car.Make.Brand)
                            .Include(ad => ad.Car.Transmission)
                            .Include(ad => ad.Car.FuelType)
                            .Include(ad => ad.City)
                            .Include(ad => ad.City.Country)
                            .Include(ad => ad.Car.CarDetailPhotos)
                            .FirstOrDefaultAsync();
            if (!RemovePhoto(_env.WebRootPath, advertisement.Car.Image))
            {
                ModelState.AddModelError("", "Path not exsists this phooto");
                return View(advertisement);
            }

            foreach (var photo in _context.CarDetailPhotos.Where(cd => cd.CarId == advertisement.CarId))
            {
                if (!RemovePhoto(_env.WebRootPath, photo.Image))
                {
                    ModelState.AddModelError("", "Path not exsists this phooto");
                    return View(advertisement);
                }
            }

            _context.CarDetailPhotos.RemoveRange(advertisement.Car.CarDetailPhotos);
            _context.Cars.Remove(advertisement.Car);
            _context.Advertisements.Remove(advertisement);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Update(int? id)
        {
            if (!User.Identity.IsAuthenticated)
            {
                return Redirect("/account/login");
            }
            if (!User.IsInRole("member"))
            {
                return Redirect("/account/login");
            }
            
            if (id == null)
            {
                return PartialView("ErrorPage");
            }
            if (!_context.Advertisements.Any(ad => ad.Id == id))
            {
                return PartialView("ErrorPage");
            }
            if (User.Identity.Name != _context.Advertisements.Where(ad => ad.Id == id).Include(ad => ad.ApplicationUser).FirstOrDefault().ApplicationUser.UserName)
            {
                return Redirect("/account/login");
            }
            
            
            ViewBag.Countries = _context.Countries;
            ViewBag.Brands = _context.Brands;
            ViewBag.Transmissions = _context.Transmissions;
            ViewBag.Fuels = _context.FuelTypes;
            Advertisement advertisement = await _context.Advertisements.Where(ad => ad.Id == id)
                                                                        .Include(ad => ad.Car)
                                                                        .Include(ad => ad.Car.Make)
                                                                        .Include(ad => ad.Car.Make.Brand)
                                                                        .Include(ad => ad.Car.Transmission)
                                                                        .Include(ad => ad.Car.FuelType)
                                                                        .Include(ad => ad.City)
                                                                        .Include(ad => ad.City.Country)
                                                                        .Include(ad => ad.Car.CarDetailPhotos)
                                                                        .FirstOrDefaultAsync();

            return View(advertisement);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(Advertisement advertisement)
        {
            if (!User.Identity.IsAuthenticated)
            {
                return Redirect("/account/login");
            }
            if (!User.IsInRole("member"))
            {
                return Redirect("/account/login");
            }
            if (advertisement == null)
            {
                return PartialView("ErrorPage");
            }

            if (!ModelState.IsValid)
            {
                ViewBag.Countries = _context.Countries;
                ViewBag.Brands = _context.Brands;
                ViewBag.Transmissions = _context.Transmissions;
                ViewBag.Fuels = _context.FuelTypes;
                return NotFound();
            }

            if (advertisement.Car.MakeId == null)
            {
                ModelState.AddModelError("Car.MakeId", "Select a valid make");
                ViewBag.Countries = _context.Countries;
                ViewBag.Brands = _context.Brands;
                ViewBag.Transmissions = _context.Transmissions;
                ViewBag.Fuels = _context.FuelTypes;
                return View(advertisement);
            }
            if (advertisement.Car.ManufactureYear < 1700 || advertisement.Car.ManufactureYear > DateTime.Now.Year)
            {
                ModelState.AddModelError("Car.ManufactureYear", "Input a valid manufacture year");
                ViewBag.Countries = _context.Countries;
                ViewBag.Brands = _context.Brands;
                ViewBag.Transmissions = _context.Transmissions;
                ViewBag.Fuels = _context.FuelTypes;
                return View(advertisement);
            }
            if (advertisement.Car.Motor <= 0)
            {
                ModelState.AddModelError("Car.Motor", "Input a valid Motor");
                ViewBag.Countries = _context.Countries;
                ViewBag.Brands = _context.Brands;
                ViewBag.Transmissions = _context.Transmissions;
                ViewBag.Fuels = _context.FuelTypes;
                return View(advertisement);
            }
            if (advertisement.Car.Millage < 0)
            {
                ModelState.AddModelError("Car.Millage", "Input a valid Millage");
                ViewBag.Countries = _context.Countries;
                ViewBag.Brands = _context.Brands;
                ViewBag.Transmissions = _context.Transmissions;
                ViewBag.Fuels = _context.FuelTypes;
                return View(advertisement);
            }
            if (int.TryParse(advertisement.Car.Color, out _))
            {
                ModelState.AddModelError("Car.Color", "Input a valid Color");
                ViewBag.Countries = _context.Countries;
                ViewBag.Brands = _context.Brands;
                ViewBag.Transmissions = _context.Transmissions;
                ViewBag.Fuels = _context.FuelTypes;
                return View(advertisement);
            }
            if (advertisement.Car.TransmissionId == null)
            {
                ModelState.AddModelError("Car.TransmissionId", "Select a valid Transmission");
                ViewBag.Countries = _context.Countries;
                ViewBag.Brands = _context.Brands;
                ViewBag.Transmissions = _context.Transmissions;
                ViewBag.Fuels = _context.FuelTypes;
                return View(advertisement);
            }
            if (advertisement.Car.FuelTypeId == null)
            {
                ModelState.AddModelError("Car.FuelTypeId", "Select a valid Fuel type");
                ViewBag.Countries = _context.Countries;
                ViewBag.Brands = _context.Brands;
                ViewBag.Transmissions = _context.Transmissions;
                ViewBag.Fuels = _context.FuelTypes;
                return View(advertisement);
            }
            if (advertisement.Car.Description.Length < 200)
            {
                ModelState.AddModelError("Car.Description", "Description is too short");
                ViewBag.Countries = _context.Countries;
                ViewBag.Brands = _context.Brands;
                ViewBag.Transmissions = _context.Transmissions;
                ViewBag.Fuels = _context.FuelTypes;
                return View(advertisement);
            }
            if (advertisement.Car.Price < 0)
            {
                ModelState.AddModelError("Car.Price", "Input a valid Price");
                ViewBag.Countries = _context.Countries;
                ViewBag.Brands = _context.Brands;
                ViewBag.Transmissions = _context.Transmissions;
                ViewBag.Fuels = _context.FuelTypes;
                return View(advertisement);
            }
            if (advertisement.CityId == null)
            {
                ModelState.AddModelError("CityId", "Select a valid City");
                ViewBag.Countries = _context.Countries;
                ViewBag.Brands = _context.Brands;
                ViewBag.Transmissions = _context.Transmissions;
                ViewBag.Fuels = _context.FuelTypes;
                return View(advertisement);
            }

            Advertisement adFromDb = await _context.Advertisements.Where(ad => ad.Id == advertisement.Id)
                                                                        .Include(ad => ad.Car)
                                                                        .Include(ad => ad.Car.Make)
                                                                        .Include(ad => ad.Car.Make.Brand)
                                                                        .Include(ad => ad.Car.Transmission)
                                                                        .Include(ad => ad.Car.FuelType)
                                                                        .Include(ad => ad.City)
                                                                        .Include(ad => ad.City.Country)
                                                                        .Include(ad => ad.Car.CarDetailPhotos)
                                                                        .FirstOrDefaultAsync();
            if (advertisement.Car.Photo != null)
            {
                if (!advertisement.Car.Photo.ContentType.Contains("image/"))
                {
                    ModelState.AddModelError("Car.Photo", "File type should be image");
                    ViewBag.Countries = _context.Countries;
                    ViewBag.Brands = _context.Brands;
                    ViewBag.Transmissions = _context.Transmissions;
                    ViewBag.Fuels = _context.FuelTypes;
                    return View(adFromDb);
                }
                RemovePhoto(_env.WebRootPath, _context.Advertisements.Where(ad => ad.Id == advertisement.Id).FirstOrDefault().Car.Image);
                adFromDb.Car.Image = await advertisement.Car.Photo.SavePhotoAsync(_env.WebRootPath, "advertisements");
            }
            if (advertisement.Car.DetailPhotos != null)
            {
                foreach (var photo in advertisement.Car.DetailPhotos)
                {
                    if (!photo.ContentType.Contains("image/"))
                    {
                        ModelState.AddModelError("Car.DetailPhotos", "File type should be image");
                        ViewBag.Countries = _context.Countries;
                        ViewBag.Brands = _context.Brands;
                        ViewBag.Transmissions = _context.Transmissions;
                        ViewBag.Fuels = _context.FuelTypes;
                        return View(adFromDb);
                    }
                    
                    //await _context.SaveChangesAsync();
                }
                foreach (var photo in advertisement.Car.DetailPhotos)
                {
                    CarDetailPhotos detailPhoto = new CarDetailPhotos
                    {
                        CarId = adFromDb.CarId,
                        Image = await photo.SavePhotoAsync(_env.WebRootPath, "advertisements")
                    };
                    await _context.CarDetailPhotos.AddAsync(detailPhoto);
                }
            }


            adFromDb.Car.MakeId = advertisement.Car.MakeId;
            adFromDb.Car.Color = advertisement.Car.Color;
            adFromDb.Car.Description = advertisement.Car.Description;
            adFromDb.Car.FuelTypeId = advertisement.Car.FuelTypeId;
            adFromDb.Car.IsVip = advertisement.Car.IsVip;
            adFromDb.Car.ManufactureYear = advertisement.Car.ManufactureYear;
            adFromDb.Car.Millage = advertisement.Car.Millage;
            adFromDb.Car.Motor = advertisement.Car.Motor;
            adFromDb.Car.Price = advertisement.Car.Price;
            adFromDb.Car.TransmissionId = advertisement.Car.TransmissionId;
            adFromDb.CityId = advertisement.CityId;
            adFromDb.UpdatedDate = DateTime.Now;
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}