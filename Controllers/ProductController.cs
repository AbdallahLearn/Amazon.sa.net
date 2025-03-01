using AmazonSA.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace AmazonSA.Controllers
{
    public class ProductController : Controller
    {
        private static List<Product> products = new List<Product>
        {
            new Product { ProductID = 1, Name = "Laptop", Category = "Electronics", Price = 3500, StockQuantity = 10, ImageUrl = "https://m.media-amazon.com/images/I/71P3MwynNoL._AC_UY436_FMwebp_QL65_.jpg" },
            new Product { ProductID = 2, Name = "Phone", Category = "Electronics", Price = 1500, StockQuantity = 15, ImageUrl = "https://m.media-amazon.com/images/I/71genMPU1QL._AC_UY436_FMwebp_QL65_.jpg" },
            new Product { ProductID = 3, Name = "Headphones", Category = "Accessories", Price = 300, StockQuantity = 20, ImageUrl = "https://m.media-amazon.com/images/I/71F2ccIPPLL._AC_UY436_FMwebp_QL65_.jpg" }
        };

        // Display product list
        public IActionResult Index()
        {
            return View(products);
        }

        // Redirect user to the order page with product details
        public IActionResult Order(int productId)
        {
            var product = products.FirstOrDefault(p => p.ProductID == productId);
            if (product == null)
            {
                return NotFound();
            }
            return View("Order", product);
        }
    }
}
