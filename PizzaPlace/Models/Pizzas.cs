using System.Xml.Linq;

namespace PizzaPlace.Models
{
    public class Pizzas
    {
        public Pizzas(int id, string nombre, decimal precio, Picantes picante)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Precio = precio;
            this.Picante = picante;
        }
        public int Id { get; }
        public string Nombre { get; }
        public decimal Precio { get; }
        public Picantes Picante { get; }
    }
}
