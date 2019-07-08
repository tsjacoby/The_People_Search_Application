using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using The_People_Search_Application.Contexts;
using Microsoft.Extensions.DependencyInjection;

namespace The_People_Search_Application
{
    /// <summary>
    /// The main program class used to initialize the application.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// <param name="args">The args passed to main, if any.</param>
        public static void Main(string[] args)
        {
            var webHost = WebHost.CreateDefaultBuilder(args).UseStartup<Startup>().Build();
            using (var scope = webHost.Services.CreateScope())
            {
                var services = scope.ServiceProvider;
                try
                {
                    var context = services.GetRequiredService<PeopleContext>();
                    PeopleInitializer.Initialize(context);
                }
                catch (Exception ex)
                {
                    var logger = services.GetRequiredService<ILogger<Program>>();
                    logger.LogError(ex, "An error occurred while seeding the database.");
                }
            }

            webHost.Run();
        }
    }
}
