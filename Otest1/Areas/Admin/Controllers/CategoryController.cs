using Microsoft.AspNetCore.Mvc;
using System.Globalization;

namespace Otest1.Areas.Admin.Controllers
{
    [Area("admin")]
    public class CategoryController : Controller
    {
        public CategoryController()
        {
                
        }
        public IActionResult Index()
        {

            return View();
        }
        
        public ViewResult Create() { return View(); }

        [HttpPost] 
        public ViewResult Create(String name, string address, int age)
        {
            ViewBag.name = name;
            ViewBag.age = age;
            ViewBag.address = address;
           
            var t = int.Parse(string.IsNullOrEmpty(address) ? "0" : address);
            t = t + 1;
            
            ViewBag.age = t.ToString();
               
            return View();
        }


    }
}
