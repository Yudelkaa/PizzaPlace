using Microsoft.EntityFrameworkCore;
using PizzaPlaceYude.Models;

namespace PizzaPlaceYude.DAL
{
	public class Context : DbContext
	{

		public DbSet<Cliente> Cliente { get; set; }
		public DbSet<Pizza> Pizza { get; set; }
		public DbSet<Cesta> Cesta { get; set; }
		public Context(DbContextOptions<Context> Options) : base(Options) { }
	}

}

