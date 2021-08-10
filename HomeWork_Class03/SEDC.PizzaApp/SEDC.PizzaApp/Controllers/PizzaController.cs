using Microsoft.AspNetCore.Mvc;
using SEDC.PizzaApp.Models.Domain;
using SEDC.PizzaApp.Models.Mappers;
using SEDC.PizzaApp.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SEDC.PizzaApp.Controllers
{
    public class PizzaController : Controller
    {
        public IActionResult Index()
        {
            List<Pizza> pizzas = StaticDb.Pizzas;
            ViewData["Title"] = "Pizza List";
            List<PizzaViewModel> pizzaViewModels = pizzas
                .Select(x => x.PizzaToPizzaViewModelExtensionMethod()).ToList(); //Using Extension Method

            return View(pizzaViewModels); //we send the list to the view

        }

        public IActionResult Details(int? id)
        {
            if(id == null)
            {
                return new EmptyResult();
            }
            Pizza pizza = StaticDb.Pizzas.FirstOrDefault(x => x.Id == id);
            if(pizza == null)
            {
                return new EmptyResult();
            }
            ViewData["Title"] = "Pizza Details";
            PizzaViewModel pizzaTemp = pizza.PizzaToPizzaViewModelExtensionMethod(); //Using Extension Method
            ViewBag.PizzaViewModel = pizzaTemp;
            return View(pizza);
        }

        [Route("SeePizzas")] //localhost:[port]/SeePizzas
        public IActionResult Redirect()
        {
            return RedirectToAction("Index");
        }
    }
}
