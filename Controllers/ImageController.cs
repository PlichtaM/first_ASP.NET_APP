using System.IO;
using Microsoft.AspNetCore.Mvc;

namespace zadanie.Controllers
{
    public class ImageController : Controller
    {
        public IActionResult Index(string name)
        {
            var imagePath = Path.Combine("wwwroot", "images", name);
            if (System.IO.File.Exists(imagePath))
            {
                var image = System.IO.File.ReadAllBytes(imagePath);
                return File(image, "image/jpeg");
            }
            else
            {
                return NotFound();
            }
        }
    }
}