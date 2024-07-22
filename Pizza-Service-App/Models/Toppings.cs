using System.ComponentModel.DataAnnotations;

namespace Pizza_Service_App.Models
{
    public class Toppings
    {
        [Key]
        public Guid ToppingId { get; set; }
        public string ToppingName { get; set; }
    }
}
