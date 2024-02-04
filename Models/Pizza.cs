namespace PizzaPlaceYude.Models
{
	public class Pizza
	{
		public int IdPizza { get; set; }
		public int Precio { get; set; }
		public int Nombre { get; set; }

		public enum Picante
		{
			Natural,
			Picante,
			ExtraPicante
		};
	}
}
