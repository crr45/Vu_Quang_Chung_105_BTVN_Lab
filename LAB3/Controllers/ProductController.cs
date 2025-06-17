using LAB3.Models;
using Microsoft.AspNetCore.Mvc;

namespace LAB3.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Details()
        {
            var product = new Product
            {
                Id = 1,
                Name = "Laptop Dell XPS 13",
                Price = 29999000m
            };

            return View(product);
        }
    }
}
