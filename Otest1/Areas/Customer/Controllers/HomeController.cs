using Microsoft.AspNetCore.Mvc;
using Otest1.Models;
using System.Diagnostics;

namespace Otest1.Areas.AdCustomermin.Controllers
{
    [Area("Customer")]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public string Index()
        {
            return ($"Welcome <h1> Index </h1>");
        }

        public IActionResult List(string cat, int page) {
            return Content("Action is list with cat"+cat +"page "+page);
        }

        public ContentResult GetTime()
        {

            return Content("<h1>"+ DateTime.Today.ToShortDateString() +"</h1>","text/html");
        }
        public string Privacy(string name, int id)
        {
            return $"Privacy action {name} is {id} ";
        }

        public IActionResult generateList()
        {
            return View("Views/Home/index1.cshtml");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}