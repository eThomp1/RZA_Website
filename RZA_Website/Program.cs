using Microsoft.EntityFrameworkCore;
using RZA_Website.Components;
using RZA_Website.Models;
using RZA_Website.Services;
using RZA_Website.Utilities;
namespace RZA_Website
{
    public class Program
    {
//scaffold-dbcontext name="MySqlConnection" pomelo.entityframeworkcore.mysql -outputdir Models -force

        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddRazorComponents()
                .AddInteractiveServerComponents();
            
            builder.Services.AddDbContext<TlS2303064Rza2Context>(options => options.UseMySql(builder.Configuration.GetConnectionString("MySqlConnection"), new MySqlServerVersion(new Version(8, 0, 29))));
            builder.Services.AddSingleton<UserSession>();
            builder.Services.AddScoped<CustomerService>();
            builder.Services.AddScoped<AttractionService>();
            builder.Services.AddScoped<TicketService>();
            builder.Services.AddScoped<TicketBookingService>();
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

            app.MapRazorComponents<App>()
                .AddInteractiveServerRenderMode();

            app.Run();
        }
    }
}
