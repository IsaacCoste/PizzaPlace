namespace PizzaPlace.Models
{
    public class Estados
    {
        public Menu Menu { get; set; } = new Menu();
        public CestaDeCompras Cesta { get; set; } = new CestaDeCompras();
        public InterfazDeUsuarios InterfazUsuario { get; set; } = new InterfazDeUsuarios();
        public decimal precioTotal => Cesta.Ordenes.Sum(id => Menu.GetPizza(id)!.Precio);
        
    }
}
