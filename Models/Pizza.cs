using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace la_mia_pizzeria_static.Models
{
    public class Pizza
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Il campo è obbligatorio")]
        [StringLength(50, ErrorMessage = "Il titolo non può essere più lungo di 50 caratteri")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Il campo è obbligatorio")]
        [StringLength(200, ErrorMessage = "La descrizione non può essere più lunga di 200 caratteri")]
        [Column(TypeName = "text")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Il campo è obbligatorio")]
        public string Image { get; set; }
        public float Price { get; set; }

        public Pizza(string name, string description, string image, float price)
        {
            Name = name;
            Description = description;
            Image = image;
            Price = price;
        }

        public Pizza()
        {

        }
    }
}
