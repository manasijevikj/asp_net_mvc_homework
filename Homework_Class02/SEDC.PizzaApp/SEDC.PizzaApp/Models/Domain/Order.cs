using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SEDC.PizzaApp.Models.Domain
{
    public class Order
    {
        public int Id { get; set; }
        public TimeSpan Date { get; set; }
        public List<Pizza> Pizzas { get; set; }
        public string Customer { get; set; }

    }
}
 