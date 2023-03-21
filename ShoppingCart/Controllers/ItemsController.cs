using Microsoft.AspNetCore.Mvc;
using ShoppingCart.Models;

namespace ShoppingCart.Controllers
{
    public class ItemsController : Controller
    {
        private static List<Item> items
            = new List<Item>()
            {
                new Item{Code="1234", Description="Scented Candle", Price=7.35},
                new Item{Code="9995", Description="Cuddly Toy", Price=37.5},
                new Item{Code="12887", Description="Hacksaw", Price=4.99}
            };

        private static Cart cart = new Cart();

        public IActionResult Index()
        {
            ViewBag.TotalPrice = String.Format("{0:0.00}", cart.CalculateTotalPrice());
            return View(items);
        }

        public IActionResult Details(string code)
        {
            Item found = items.FirstOrDefault(p => p.Code.ToLower().Equals(code.ToLower()));
            if (found != null) 
            {
                return View(found);
            }
            else
            {
                return RedirectToAction("Index");
            }
            
        }

        public IActionResult Add(string code)
        {
            if (!string.IsNullOrEmpty(code)) 
            {
                Item found = items.FirstOrDefault(p => p.Code.ToLower().Equals(code.ToLower()));
                if (found != null) 
                {
                    cart.Add(found);
                    return RedirectToAction("Index");
                }
                else
                {
                    return View();
                }
                
            }
            
            return View(items);
        }
    }
}
