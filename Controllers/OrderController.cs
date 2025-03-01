using AmazonSA.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AmazonSA.Controllers
{
    public class OrderController : Controller
    {
        private static List<Order> orders = new List<Order>();

        private static List<Product> products = new List<Product>
        {
            new Product { ProductID = 1, Name = "Laptop", Category = "Electronics", Price = 3500, StockQuantity = 10, ImageUrl = "https://m.media-amazon.com/images/I/71P3MwynNoL._AC_UY436_FMwebp_QL65_.jpg" },
            new Product { ProductID = 2, Name = "Phone", Category = "Electronics", Price = 1500, StockQuantity = 15, ImageUrl = "https://m.media-amazon.com/images/I/71genMPU1QL._AC_UY436_FMwebp_QL65_.jpg" },
            new Product { ProductID = 3, Name = "Headphones", Category = "Accessories", Price = 300, StockQuantity = 20, ImageUrl = "https://m.media-amazon.com/images/I/71F2ccIPPLL._AC_UY436_FMwebp_QL65_.jpg" }
        };

        public IActionResult Create(int productId)
        {
            var product = products.FirstOrDefault(p => p.ProductID == productId);
            if (product == null)
            {
                return NotFound();
            }
            return View(product);
        }

        [HttpPost]
        public IActionResult ConfirmOrder(int productId, int quantity)
        {
            int userId = 1; // Dummy user ID for now

            var product = products.FirstOrDefault(p => p.ProductID == productId);
            if (product == null)
            {
                TempData["ErrorMessage"] = "Product not found.";
                return RedirectToAction("Index", "Product");
            }

            if (quantity > product.StockQuantity)
            {
                TempData["ErrorMessage"] = "Not enough stock available.";
                return RedirectToAction("Create", new { productId });
            }

            // Deduct the ordered quantity from stock
            product.StockQuantity -= quantity;

            var order = new Order
            {
                OrderID = new Random().Next(1000, 9999),
                UserID = userId,
                OrderDate = DateTime.Now,
                Status = "Pending"
            };

            orders.Add(order);

            TempData["SuccessMessage"] = "Order placed successfully!";
            return RedirectToAction("History", new { userId = userId });
        }

        public IActionResult History(int userId)
        {
            var userOrders = orders.Where(o => o.UserID == userId).ToList();
            return View(userOrders);
        }
    }
}
