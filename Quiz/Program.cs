using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Quiz.DAL;
using System;

namespace Quiz
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();

            builder.Services.AddDbContext<AppDbContext>(otp =>
            {
                otp.UseSqlServer(builder.Configuration.GetConnectionString("MSSQL"));
            });
            var app = builder.Build();
            app.UseRouting();
            app.UseStaticFiles();
            app.MapControllerRoute(name: "areas", pattern: "{area:exists}/{controller=Dashboard}/{action=Index}/{id?}");
            app.MapControllerRoute(name: "default", pattern: "{controller=Home}/{action=Index}/{id?}");
            app.MapControllerRoute(name: "Contact", pattern: "Contact", defaults: new { Controller = "Home", Action = "Contact" });
            app.MapControllerRoute(name: "Product_detail", pattern: "Product_detail", defaults: new { Controller = "Home", Action = "Product_detail" });
            app.MapControllerRoute(name: "Product_listing", pattern: "Product_listing", defaults: new { Controller = "Home", Action = "Product_listing" });
            app.MapControllerRoute(name: "shop_cart", pattern: "shop_cart", defaults: new { Controller = "Home", Action = "shop_cart" });
            app.Run();
        }
    }
}