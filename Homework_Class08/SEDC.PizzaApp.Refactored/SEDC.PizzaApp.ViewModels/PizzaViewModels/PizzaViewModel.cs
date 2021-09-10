using SEDC.PizzaApp.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SEDC.PizzaApp.ViewModels.PizzaViewModels
{
    public class PizzaViewModel
    {
        public int Id { get; set; }
        [Display(Name = "Pizza's name")]
        public string Name { get; set; }

        [Display(Name = "Pizza Size")]
        public PizzaSizeEnum PizzaSize { get; set; }
        [Display(Name = "Promotion")]
        public bool IsOnPromotion { get; set; }
    }
}
