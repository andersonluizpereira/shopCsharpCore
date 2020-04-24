using System.Globalization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace Shop
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Get all available cultures on the current system.
            CultureInfo[] cultures = CultureInfo.GetCultures(CultureTypes.AllCultures);

            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
