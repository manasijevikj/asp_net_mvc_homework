﻿using SEDC.PizzaApp.DataAccess.Interfaces;
using SEDC.PizzaApp.Domain.Models;
using SEDC.PizzaApp.Mappers;
using SEDC.PizzaApp.Services.Interfaces;
using SEDC.PizzaApp.ViewModels.PizzaViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SEDC.PizzaApp.Services.Implementations
{
    public class PizzaService : IPizzaService
    {
        private IRepository<Pizza> _pizzaRepository;

        public PizzaService(IRepository<Pizza> pizzaRepository)
        {
            _pizzaRepository = pizzaRepository;
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
            Pizza pizza = pizzaViewModel.ToPizza();
            _pizzaRepository.Insert(pizza);
        }
    }
}
