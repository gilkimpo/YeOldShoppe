using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using YeOldeShoppe.Models;

namespace YeOldeShoppe.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private ShopDBContext db;
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        [Authorize]
        public IActionResult Shop()
        {
            db = new ShopDBContext();   
            return View(db);
        }
        public IActionResult Purchase(decimal itemPrice, int quantity, string name)
        {
            db = new ShopDBContext();
            List<AspNetUsers> userList = db.AspNetUsers.ToList();
            List<Items> itemList = db.Items.ToList();

            foreach(Items item in itemList)
            {
                if (item.Name==name)
                {
                    item.Quantity = quantity;
                    db.SaveChanges();
                }

            }
            foreach(AspNetUsers user in userList)
            {
                if (user.Email==User.Identity.Name)
                {
                    user.Funds -= itemPrice;
                    db.AspNetUsers.Update(user);
                    db.SaveChanges();
                    return View("Shop", db);
                }
            }
            return View("Shop", db);
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
