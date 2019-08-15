using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using aspFinal.DAL;
using aspFinal.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace aspFinal.Controllers
{
    public class AjaxController : Controller
    {
        private readonly AspFinalDbContext _context;
        public AjaxController(AspFinalDbContext context)
        {
            _context = context;
        }
        [HttpPost]
        public IActionResult LoadCitiesByCountryId(int countryId)
        {
            return PartialView("_FilteredCitiesByCountryId", _context.Cities.Where(city => city.CountryId == countryId));
        }

        [HttpPost]
        public IActionResult LoadMakesByBrandId(int brandId)
        {
            return PartialView("_FilteredMakesByBrandId", _context.Makes.Where(make => make.BrandId == brandId));
        }

        [HttpPost]
        public void DeleteImage(int carDetailImageId)
        {
            CarDetailPhotos carDetail = _context.CarDetailPhotos.Where(cd => cd.Id == carDetailImageId).FirstOrDefault();
            Car car = _context.Cars.Where(c => c.Id == carDetail.CarId).Include(c => c.CarDetailPhotos).FirstOrDefault();
            var carId = carDetail.CarId;
            _context.CarDetailPhotos.Remove(carDetail);
            _context.SaveChanges();
        }
    }
}