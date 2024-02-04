using System.Data.Common;

namespace PizzaPlaceYude.DAL
{
	public class Context : DbContext
	{
		public Contexto(DbContextOption<Contexto>Option) : base(Options) { }
		public DbSet<Cliente>(get;set;)
		public DbSet<Pizza>(get;set;)
		public DbSet<Cesta>(get;set;)
	}
}
