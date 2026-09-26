using ClinicaOdontologica.Consumer;
using static System.Net.WebRequestMethods;
using ClinicaOdontologica;

namespace ClinicaOdontologica.MVC

{
    public class Program
    {
        public static void Main(string[] args)
        {
            CRUD<Cita>.Endpoint = "http://localhost:5006/api/Citas";
            CRUD<Consultorio>.Endpoint = "http://localhost:5006/api/Consultorios";
            CRUD<DetalleCita>.Endpoint = "http://localhost:5006/api/DetalleCitas";            
            CRUD<Especialidad>.Endpoint = "http://localhost:5006/api/Especialidades";
            CRUD<Factura>.Endpoint = "http://localhost:5006/api/Facturas";


            var builder = WebApplication.CreateBuilder(args);
            

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseRouting();

            app.UseAuthorization();

            app.MapStaticAssets();
            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}")
                .WithStaticAssets();

            app.Run();
        }
    }
}
