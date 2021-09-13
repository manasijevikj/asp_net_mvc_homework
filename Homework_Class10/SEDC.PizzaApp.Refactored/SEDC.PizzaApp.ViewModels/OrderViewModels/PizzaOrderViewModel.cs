using SEDC.PizzaApp.Domain.Enums;
using System.ComponentModel.DataAnnotations;

namespace SEDC.PizzaApp.ViewModels.OrderViewModels
{
    public class PizzaOrderViewModel
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        [Display(Name ="Pizza")]
        public int PizzaId { get; set; }
        [Display(Name = "Pizza Size")]
        public PizzaSizeEnum PizzaSize { get; set; }
        public int Quantity { get; set; }
    }
}
