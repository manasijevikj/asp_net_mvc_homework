using Microsoft.AspNetCore.Mvc;
using SEDC.PizzaApp.Domain.Models;
using SEDC.PizzaApp.Services.Interfaces;
using SEDC.PizzaApp.ViewModels.OrderViewModels;
using SEDC.PizzaApp.ViewModels.PizzaViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SEDC.PizzaApp.Refactored.Controllers
{
    public class PizzaController : Controller
    {
        private IPizzaService _pizzaService;
        private IOrderService _orderService;

        public PizzaController(IPizzaService pizzaService, IOrderService orderService)
        {
            _pizzaService = pizzaService;
            _orderService = orderService;
        }

        public IActionResult Index()
        {
            List<PizzaListViewModel> pizzaListViewModels = _pizzaService.GetAllPizzas();
            return View(pizzaListViewModels);
        }

        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return View("BadRequest");
            }
            try
            {
                PizzaDetailsViewModel pizzaDetailsViewModel = _pizzaService.GetPizzaDetails(id.Value);
                List<OrderListViewModel> connectedOrders = _pizzaService.GetConnectedListViewOrders((int)id);
                ViewBag.ConnectedOrders = connectedOrders;
                return View(pizzaDetailsViewModel);
            }
            catch (Exception e)
            {
                //log
                return View("ExceptionPage");

            }
        }

        public IActionResult Create()
        {
            PizzaViewModel pizzaViewModel = new PizzaViewModel();
            return View(pizzaViewModel);
        }

        [HttpPost]
        public IActionResult Create(PizzaViewModel pizzaViewModel)
        {
            try
            {
                _pizzaService.CreatePizza(pizzaViewModel);
                return RedirectToAction("Index");
            }
            catch (Exception e)
            {
                return View("ExceptionPage");
            }
        }


    }
}
