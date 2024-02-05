using System.ComponentModel.DataAnnotations;
using System.Text.Json;

namespace PizzaPlaceYude.Models
{
	public class Cliente
	{
		[Key]
		[Required(ErrorMessage = "Es requerido")]
		public int IdCliente { get; set; }
		[Required(ErrorMessage = "Es requerido")]
		public string? Nombre { get; set; }
		[Required(ErrorMessage = "Es requerido")]
		public string? Calle { get; set; }
		[Required(ErrorMessage = "Es requerido")]
		public string? Ciudad { get; set; }
	}

	public static class DebuggingExtensions
	{
		private static JsonSerializerOptions options = new
JsonSerializerOptions
		{ WriteIndented = true };
		public static string ToJson(this object obj)
		=> JsonSerializer.Serialize(obj, options);
	}
}
