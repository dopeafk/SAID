using CodersMVCProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace CodersMVCProject.Controllers
{
    public class ProductsController : Controller
    {
        private readonly static List<Product> products = new List<Product>
    {
        new Product { Id = 1, Name = "Keyboard", Price = 20 },
        new Product { Id = 2, Name = "Mouse", Price = 10 },
        new Product { Id = 3, Name = "Monitor", Price = 100 }
    };

        public IActionResult Index()
        {
            return View(products);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Product product)
        {
            product.Id = products.Count + 1;
            products.Add(product);
            return RedirectToAction("Index");
        }
    }
}
