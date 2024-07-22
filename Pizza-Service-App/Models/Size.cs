using System.ComponentModel.DataAnnotations;

namespace Pizza_Service_App.Models
{
    public class Size
    {
        [Key]
        public Guid SizeId { get; set; }
        public string PizzaSize { get; set; }
    }
}
