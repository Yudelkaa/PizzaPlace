using PizzaPlaceYude.Services;

namespace PizzaPlaceYude.Models
{
	public class Estado
	{
		public MenuService Menu { get; } = new MenuService();
		public Cesta Cesta { get; } = new Cesta();
		public IU Interfaz { get; set; } = new IU();
		public decimal PrecioTotal => Cesta.Ordenes.Sum(Id => Menu.GetPizza(Id)!.precio);
	}
}
