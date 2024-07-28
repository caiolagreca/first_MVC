using FirstMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace FirstMVC.Controllers
{
    public class HomeController : Controller
    {
        //ActionResult is a return type of a controller method (or Action method)
        public IActionResult Index()
        {
            HomeModel message = new HomeModel();
            return View(message);
        }
    }
}
