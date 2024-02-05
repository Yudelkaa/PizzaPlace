using PizzaPlaceYude.Services;
using System.ComponentModel.DataAnnotations;

namespace PizzaPlaceYude.Models
{
	public class Cesta
	{
		public Cliente? ClienteOrden { get; set; } = new Cliente();
		public List<int> Ordenes { get; set; } = new List<int>();
		public bool HasPaid { get; set; }
		public void Agregar(int pizzaId) => Ordenes.Add(pizzaId);

		public void Eliminar(int pos) => Ordenes.RemoveAt(pos);
	}
}
