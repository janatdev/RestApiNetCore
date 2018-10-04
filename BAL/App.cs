using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.Logging;

namespace TFL.BAL
{
    public class App
    {
        private readonly IConsumeAsyncTfl _consumeAsyncTfl;

        private readonly ILogger<App> _logger;

        public App(IConsumeAsyncTfl consumeAsyncTfl, ILogger<App> logger)
        {
            _consumeAsyncTfl = consumeAsyncTfl;
            _logger = logger;
        }

        public void RoadStatusCheckTask()
        {
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("*************** .Net Core Console Web API Consuming Application.***************");
            Console.WriteLine("*******************************************************************************");

            try
            {
                while (true)
                {
                    _logger.LogInformation($"Logger Information : This is a console application for TFL Rest API. ");

                    var repositories = _consumeAsyncTfl.RoadStatusCheckTask().Result;

                    foreach (var repo in repositories)
                    {
                        Console.WriteLine($"The Status of the " + repo.Name + " is as follows: ");
                        Console.WriteLine(repo.Name + " Status is " + repo.Status);
                        Console.WriteLine("Road Status Description is " + repo.StatusDescription);
                    }

                    //Exit the App or Restart checking the Raod Status.
                    Console.WriteLine(
                        $"\nWrite 'Exit'/'exit' to close the application.\n\nOtherwise Press Enter to check the Road Status again. ");
                    var restart = Console.ReadLine();

                    if (restart == "Exit" || restart == "exit")
                    {
                        break;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Not a valid Road");
                Console.ReadLine();
            }
        }
    }
}

