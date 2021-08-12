﻿using SEDC.PizzaApp.Models.Domain;
using SEDC.PizzaApp.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SEDC.PizzaApp.Models.Mappers
{
    public static class PizzaMapper
    {
        public static PizzaViewModel PizzaToPizzaViewModel(Pizza pizza)
        {
            return new PizzaViewModel
            {
                Id = pizza.Id,
                Name = pizza.Name,
                Price = pizza.HasExtras ? (pizza.Price)+(10) : pizza.Price,
                PizzaSize = pizza.PizzaSize,
                IsOnPromotion = pizza.IsOnPromotion

            };
        }

        public static PizzaViewModel PizzaToPizzaViewModelExtensionMethod(this Pizza pizza)
        {
            return new PizzaViewModel
            {
                Id = pizza.Id,
                Name = pizza.Name,
                Price = pizza.HasExtras ? (pizza.Price) + (10) : pizza.Price,
                PizzaSize = pizza.PizzaSize,
                IsOnPromotion = pizza.IsOnPromotion

            };
        }
    }
}
