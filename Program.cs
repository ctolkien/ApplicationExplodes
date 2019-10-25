using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace Explode
{
    public static class Program
    {
        public static void Main(string[] args) => CreateWebHostBuilder(args).Build().Run();

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseApplicationInsights()
                .SuppressStatusMessages(false)
                .UseStartup<Startup>();
    }
}
