using PizzaPlaceYude.Components;

namespace PizzaPlaceYude
{
	public class Program
	{
		public static void Main(string[] args)
		{
			var builder = WebApplication.CreateBuilder(args);

			// Add services to the container.
			builder.Services.AddRazorComponents();

			//leer la connection string
			var ConStr = builder.Configuration.GetConnectionString("ConStr");

			//inyectar services
			builder.Services.AddScoped<ClienteServices>();
			builder.Services.AddScoped<PizzaServices>();
			builder.Services.AddScoped<CestaServices>();

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
