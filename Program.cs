using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using TFL.BAL;

namespace TFL
{
    class Program
    {
       public static void Main(string[] args)
       {                      
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