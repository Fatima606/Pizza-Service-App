using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Pizza_Service_App.Models
{
    public class PizzaTopping
    {
        public Guid PizzaId { get; set; }
        public Pizza Pizza { get; set; }

        public Guid ToppingId { get; set; }
        public Toppings Topping { get; set; }
    }
}
