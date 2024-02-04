using PizzaPlaceYude.Services;

namespace PizzaPlaceYude.Models
{
	public class Cesta
	{
		public Cliente? ClienteOrden { get; set; } = new Cliente();
		public List<int> Ordenes { get; set; } = new List<int>();
		public bool HasPaid { get; set; }
	}
}
