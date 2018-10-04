using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Runtime.Serialization.Json;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using TFL.BAL;
using Unity;
using Unity.Lifetime;

namespace TFL
{
    class Program
    {
       public static void Main(string[] args)
       {

            //App app = new App();
            //app.Run();



            /*

            //setup our DI
            var serviceProvider = new ServiceCollection()
                .AddLogging()
                .AddSingleton<IConsumeAsyncTfl, ConsumeAsyncTfl>()
                .BuildServiceProvider();

            var logger = serviceProvider.GetService<ILoggerFactory>()
                .CreateLogger<Program>();
            logger.LogDebug("Starting application");

            //do the actual work here
            var app = serviceProvider.GetService<App>();
            app.Run();

            logger.LogDebug("All done!");
            */




            
            // create service collection
            var serviceCollection = new ServiceCollection();
            ConfigureServices(serviceCollection);

            // create service provider
            var serviceProvider = serviceCollection.BuildServiceProvider();

            // entry to run app
            serviceProvider.GetService<App>().RoadStatusCheckTask();
        }

        private static void ConfigureServices(IServiceCollection serviceCollection)
        {
            // add logging
            serviceCollection.AddSingleton(new LoggerFactory()
                .AddConsole()
                .AddDebug());
            serviceCollection.AddLogging();

            // add services
            serviceCollection.AddTransient<IConsumeAsyncTfl, ConsumeAsyncTfl>();

            // add app
            serviceCollection.AddTransient<App>();
        }


    }
}