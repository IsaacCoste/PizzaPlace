using System.ComponentModel.DataAnnotations;

namespace PizzaPlace.Models
{
    public class Clientes
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Por favor, proporcione su nombre")]
        public string Nombre { get; set; } = default!;
        [Required(ErrorMessage = "Por favor, proporcione la calle con su número de casa")]
        public string Calle { get; set; } = default!;
        [Required(ErrorMessage = "Por favor, proporcione su ciudad")]
        public string Ciudad { get; set; } = default!;
    }
}
