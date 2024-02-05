using Microsoft.EntityFrameworkCore;
using PizzaPlaceYude.DAL;
using PizzaPlaceYude.Components;
using PizzaPlaceYude.Services;

namespace PizzaPlaceYude
{
	public class Program
	{
		public static void Main(string[] args)
		{
			var builder = WebApplication.CreateBuilder(args);

			// Add services to the container.
			builder.Services.AddRazorComponents()
				.AddInteractiveServerComponents();

			//leer la connection string
			var ConStr = builder.Configuration.GetConnectionString("ConStr");

			builder.Services.AddDbContext<Context>(Options => Options.UseSqlite(ConStr));

			//inyectar services
			builder.Services.AddScoped<MenuService>();
		

			var app = builder.Build();

			// Configure the HTTP request pipeline.
			if (!app.Environment.IsDevelopment())
			{
				app.UseExceptionHandler("/Error");
				// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
				app.UseHsts();
			}

			app.UseHttpsRedirection();

			app.UseStaticFiles();
			app.UseAntiforgery();

			app.MapRazorComponents<App>().AddInteractiveServerRenderMode();

			app.Run();
		}
	}
}
