using SEDC.PizzaApp.Domain.Models;
using SEDC.PizzaApp.ViewModels.PizzaViewModels;

namespace SEDC.PizzaApp.Mappers
{
    public static class PizzaMapper
    {
        public static PizzaDDViewModel ToPizzaDDViewModel(this Pizza pizza)
        {
            return new PizzaDDViewModel
            {
                Id = pizza.Id,
                Name = pizza.Name
            };
        }

        public static PizzaListViewModel PizzaToPizzaListViewModel(this Pizza pizza)
        {
            return new PizzaListViewModel
            {
                Id = pizza.Id,
                Name = pizza.Name,

            };
        }

        public static PizzaDetailsViewModel ToPizzaDetailsViewModel(this Pizza pizza)
        {
            return new PizzaDetailsViewModel
            {
                Id = pizza.Id,
                Name = pizza.Name,
                PizzaSize = pizza.PizzaSize,
                IsOnPromotion = pizza.IsOnPromotion
            };
        }

        public static PizzaViewModel ToPizzaViewModel(this Pizza pizza)
        {
            return new PizzaViewModel
            {
                Id = pizza.Id,
                Name = pizza.Name,
                PizzaSize = pizza.PizzaSize,
                IsOnPromotion = pizza.IsOnPromotion
            };
        }

        public static Pizza ToPizza(this PizzaViewModel pizza)
        {
            return new Pizza
            {
                Id = pizza.Id,
                Name = pizza.Name,
                PizzaSize = pizza.PizzaSize,
                IsOnPromotion = pizza.IsOnPromotion
            };
        }
    }
}
