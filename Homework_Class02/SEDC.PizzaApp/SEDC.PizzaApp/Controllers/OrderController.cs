using Microsoft.AspNetCore.Mvc;
using SEDC.PizzaApp.Models.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SEDC.PizzaApp.Controllers
{

    public class OrderController : Controller
    {
        [Route("Orders")]
        public IActionResult Index()
        {
            List<Order> orders = StaticDb.Orders;
            return View(orders); 
        }
         
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return new EmptyResult();
            }
            Order order = StaticDb.Orders.FirstOrDefault(x => x.Id == id);
            if (order == null)
            {
                return new EmptyResult();
            }
            return View(order);
        }

        public IActionResult JsonData()
        {
            Order order = new Order()
            {
                Id = 3,
                Customer = "Zafir"
            };
            return new JsonResult(order);
        }

        public IActionResult Redirect()
        {
            return RedirectToAction("Index", "Home");
        }


    }
}
