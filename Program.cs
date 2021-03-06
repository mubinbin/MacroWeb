using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace MacroWeb
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();

        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder
                        .UseStartup<Startup>()
                        // this is needed when dockerize the app 
                        // let the app runs at port 5000
                        .UseUrls("http://*:5000/");
                });
    }
}
