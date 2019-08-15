using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace aspFinal.Areas.Admin.Controllers
{

    public class DashboardController : Controller
    {
        [Area("Admin")]
        public IActionResult Index()
        {
            if (User.Identity.IsAuthenticated && User.IsInRole("admin"))
            {
                return View();
            }
            return Redirect("/account/login");
        }
    }
}