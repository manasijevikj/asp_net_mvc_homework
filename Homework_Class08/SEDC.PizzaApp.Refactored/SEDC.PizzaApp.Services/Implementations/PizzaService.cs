﻿using SEDC.PizzaApp.DataAccess.Interfaces;
using SEDC.PizzaApp.Domain.Models;
using SEDC.PizzaApp.Mappers;
using SEDC.PizzaApp.Services.Interfaces;
using SEDC.PizzaApp.ViewModels.PizzaViewModels;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SEDC.PizzaApp.Services.Implementations
{
    public class PizzaService : IPizzaService
    {
        private IPizzaRepository _pizzaRepository;

        public PizzaService(IPizzaRepository pizzaRepository) //Dependency Injection
        {
            _pizzaRepository = pizzaRepository;
        }
        public List<PizzaDDViewModel> GetPizzasForDropdown()
        {
            //get from db
            List<Pizza> pizzasDb = _pizzaRepository.GetAll();
            //map to view models
            return pizzasDb.Select(x => x.ToPizzaDDViewModel()).ToList();
        }

        public string GetPizzaOnPromotion()
        {
            return _pizzaRepository.GetPizzaOnPromotion().Name;
        }

        public List<PizzaListViewModel> GetAllPizzas()
        {
            //get all pizzas from db
            List<Pizza> dbPizzas = _pizzaRepository.GetAll();

            //map all pizzas to view models
            return dbPizzas.Select(x => PizzaMapper.PizzaToPizzaListViewModel(x)).ToList();
        }

        public PizzaDetailsViewModel GetPizzaDetails(int id)
        {
            Pizza pizzaDb = _pizzaRepository.GetById(id);
            if (pizzaDb == null)
            {
                //log
                throw new Exception($"The pizza with id {id} was not found!");
            }
            return pizzaDb.ToPizzaDetailsViewModel();
        }


        public void CreatePizza(PizzaViewModel pizzaViewModel)
        {
            List<Pizza> pizzasDb = _pizzaRepository.GetAll().Where(x => x.IsOnPromotion == true).ToList();
            if (pizzasDb.Count > 1)
            {
                throw new Exception("There can be only one pizza on promotion");
            }
            Pizza pizza = pizzaViewModel.ToPizza();
            _pizzaRepository.Insert(pizza);
        }
    }
}
