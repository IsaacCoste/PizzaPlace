namespace PizzaPlace.Models
{
    public class CestaDeCompras
    {
        public Clientes Clientes { get; set; } = new Clientes();
        public List<int> Ordenes { get; set; } = new List<int>();
        public bool HaPagado { get; set; }
        public void Añadir(int pizzaId) => Ordenes.Add(pizzaId);
        public void EliminarEn(int posicion) => Ordenes.RemoveAt(posicion);
    }
}
