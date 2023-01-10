using Microsoft.AspNetCore.Mvc;
using Quiz.DAL;

namespace Quiz.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }
        public IActionResult Product_detail()
        {
            return View();
        }
        public IActionResult Product_listing()
        {
            return View();
        }
        public IActionResult Shop_cart()
        {
            return View();
        }
    }
}
