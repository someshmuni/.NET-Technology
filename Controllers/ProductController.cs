using Practical_6.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace Practical_6.Controllers
{
    public class ProductController : Controller
    {
        public ActionResult Index()
        {
            List<Product> products = GetProducts();

            return View(products);
        }

        public ActionResult Details(int id)
        {
            List<Product> products = GetProducts();

            Product product = products.FirstOrDefault(p => p.ProductId == id);

            return View(product);
        }

        private List<Product> GetProducts()
        {
            return new List<Product>
            {
                new Product
                {
                    ProductId = 1,
                    ProductName = "Laptop",
                    Description = "Dell Laptop",
                    Price = 55000,
                    Category = "Electronics"
                },

                new Product
                {
                    ProductId = 2,
                    ProductName = "Mobile",
                    Description = "VIVO PHONE",
                    Price = 65000,
                    Category = "Mobile Phone"
                },

                new Product
                {
                    ProductId = 3,
                    ProductName = "Mouse",
                    Description = "Lenovo Mouse",
                    Price = 3000,
                    Category = "Accessories"
                }
            };
        }
    }
}