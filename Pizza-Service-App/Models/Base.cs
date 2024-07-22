using System.ComponentModel.DataAnnotations;

namespace Pizza_Service_App.Models
{
    public class Base
    {
        [Key]
        public Guid baseId { get; set; }
        public string BaseName { get; set; }
    }
}
