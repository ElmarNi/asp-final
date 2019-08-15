using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using aspFinal.DAL;
using aspFinal.Models;
using aspFinal.ViewModel;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace aspFinal.Controllers
{
    public class AccountController : Controller
    {
        private readonly AspFinalDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        public AccountController(AspFinalDbContext context, UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager)
        {
            _context = context;
            _userManager = userManager;
            _signInManager = signInManager;
        }

        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return Redirect("/");
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginVM loginVM)
        {
            if (!ModelState.IsValid) return View(loginVM);
            ApplicationUser logedUser = await _userManager.FindByEmailAsync(loginVM.Email);
            if(logedUser == null)
            {
                ModelState.AddModelError("", "Email or Password is invalid");
                return View(loginVM);
            }
            if (!logedUser.EmailConfirmed)
            {
                ModelState.AddModelError("", "Please confirm your email");
                return View(loginVM);
            }
            Microsoft.AspNetCore.Identity.SignInResult result = await _signInManager.PasswordSignInAsync(logedUser, loginVM.Password, false, true);
            if (!result.Succeeded)
            {
                ModelState.AddModelError("", "Email or Password is invalid");
                return View(loginVM);
            }
            if (await _userManager.IsInRoleAsync(logedUser, "admin"))
            {
                return Redirect("/admin");
            }
            return Redirect("/");
        }

        public async Task<IActionResult> ConfirmEmail(string id)
        {
            ApplicationUser confirmedUser = await _userManager.FindByIdAsync(id);
            confirmedUser.EmailConfirmed = true;
            await _context.SaveChangesAsync();
            return View(confirmedUser);
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterVM registerVM)
        {
            if (!ModelState.IsValid) return View(registerVM);
            ApplicationUser newUser = new ApplicationUser
            {
                Firstname = registerVM.Firstname,
                Lastname = registerVM.Lastname,
                Email = registerVM.Email,
                PhoneNumber = registerVM.Phone,
                UserName = registerVM.UserName
            };
            IdentityResult identityResult = await _userManager.CreateAsync(newUser, registerVM.Password);
            if (!identityResult.Succeeded)
            {
                foreach (var error in identityResult.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
                return View(registerVM);
            }
            await _userManager.AddToRoleAsync(newUser, "member");
            SmtpClient client = new SmtpClient("smtp.gmail.com", 587);

            client.UseDefaultCredentials = false;
            client.EnableSsl = true;

            client.Credentials = new NetworkCredential("elmarib1234@gmail.com", "elmar1999"); 

            MailMessage message = new MailMessage("elmarib1234@gmail.com", registerVM.Email);

            message.IsBodyHtml = true;
            message.Subject = "Confirm Email"; //mesajın başlığı
            message.Body = $"<a href='https://localhost:44316/Account/ConfirmEmail/{newUser.Id}'>Dear {newUser.Firstname} {newUser.Lastname},please confirm your email </a>";

            client.Send(message);
            return RedirectToAction(nameof(Login));
        }
    }
}