using Microsoft.AspNetCore.Mvc;
using System.Globalization;

namespace Otest1.Controllers
{
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
      
        public ActionResult Create(String name, string address, int age)
        {
            ViewBag.name = name;
            ViewBag.age = age;
            ViewBag.address = address;
           
            var t = int.Parse(string.IsNullOrEmpty(address) ? "0" : address);
            t = t + 1;
            
            ViewBag.age = t.ToString();
            // return Redirect(Url());
          
          return RedirectToAction("create", "category", new {area="customer",id=age, name=address});
            //return View();
        }


    }
}
