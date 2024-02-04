using Microsoft.EntityFrameworkCore;
using System.Data.Common;

namespace PizzaPlaceYude.DAL
{
	public class Context : DbContext
	{
		public Context(DbContextOption<Context>Option) : base(Options) { }
		public DbSet<Cliente> Cliente { get; set; }
		public DbSet<Pizza> Pizza { get; set; }
		public DbSet<Cesta> Cesta { get; set; }
	}
}
