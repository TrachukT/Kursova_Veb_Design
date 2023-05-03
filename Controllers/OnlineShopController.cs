using Microsoft.AspNetCore.Mvc;
using OnlineShop.Models;

namespace OnlineShop.Controllers
{
    public class OnlineShopController : Controller
    {
        public static List<Login> logins = new List<Login>();
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Registration()
        {
            var login = new Login();
            return View(login);
        }
        public IActionResult AboutUs()
        {
            return View();
        }
        public IActionResult Payment()
        {
            return View();
        }
        public IActionResult Comments()
        {
            return View();
        }
        public IActionResult NewAccount(Login login)
        {
            logins.Add(login);
            return RedirectToAction(nameof(Index));
        }
        public IActionResult SignUp()
        {
            return View();
        }
        public IActionResult Administrator()
        {
            var admin= new Login();
            return View(admin);
        }
    }
}

