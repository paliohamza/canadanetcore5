using DiDemo.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;

namespace DiDemo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IHostBuilder builder = CreateHostBuilder(args);
            IHost host=builder.Build();
            using (var scope = host.Services.CreateScope())
            {
                var services = scope.ServiceProvider;
                TodoDbSeeder.Seed(services);
            }
            host.Run();
        }
   

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
