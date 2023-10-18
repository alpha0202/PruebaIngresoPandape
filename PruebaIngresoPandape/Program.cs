using Microsoft.EntityFrameworkCore;
using PruebaIngreso.Data;
using PruebaIngreso.Repository;
using PruebaIngreso.Interactor;
using System.Text.Json.Serialization;

namespace PruebaIngresoPandape
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews().AddJsonOptions(opt => opt.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles); 

            //referenciar a dbcontext propio
            var connectionString = builder.Configuration.GetConnectionString("PruebaIngresoContext");
            builder.Services.AddDbContext<MyDbContext>(options => options.UseSqlite(connectionString));



            //inyectar la interfaz
            builder.Services.AddScoped<ICandidatesRepository, CandidatesRepository>();

            //refenciar al dbcontext personalizado en el pry Interactor
            builder.Services.DependencyInteractor();

            //inyectar automapper
            builder.Services.AddAutoMapper(typeof(Program));

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}