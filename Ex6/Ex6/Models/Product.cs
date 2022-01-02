using System.ComponentModel.DataAnnotations;

namespace Ex6.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please provide Name")]
        [StringLength(25, MinimumLength =3)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please provide Description")]
        [StringLength(100)]
        public string Description { get; set; }

        [Required(ErrorMessage = "Please provide Price")]
        [Range(0.01, 99999.99, ErrorMessage = "Please provide value form range 0,01 - 99999,99")]
        public decimal Price { get; set; }
    }
}
