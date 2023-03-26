using Microsoft.AspNetCore.Mvc;

namespace zadanie.Controllers
{
    public class FormController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(string field1, string field2, string field3)
        {
            ViewBag.Field1 = field1;
            ViewBag.Field2 = field2;
            ViewBag.Field3 = field3;
            return View("Confirmation");
        }
    }
}