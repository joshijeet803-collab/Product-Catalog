using System.Collections.Generic;
using System.Web.Mvc;
using ProductCatalog.Models;

namespace ProductCatalog.Controllers
{
    public class ProductController : Controller
    {
        public ActionResult Index()
        {
            var products = new List<Product>
            {
                new Product
                {
                    Id = 1,
                    Name = "MacBook Air",
                    Price = 89999,
                    Category = "Laptop",
                    Description = "Powerful and lightweight laptop."
                },
                new Product
                {
                    Id = 2,
                    Name = "iPhone 15",
                    Price = 69999,
                    Category = "Mobile",
                    Description = "Premium smartphone with modern design."
                },
                new Product
                {
                    Id = 3,
                    Name = "AirPods Pro",
                    Price = 24999,
                    Category = "Audio",
                    Description = "Wireless audio with clear sound."
                }
            };

            return View("Index", products);
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }
    }
}