using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Runtime.Serialization.Json;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace TFL
{
    class Program
    {
       static void Main(string[] args)
        {
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("*************** .Net Core Console Web API Consuming Application.***************");
            Console.WriteLine("*******************************************************************************");
            
            try
            {
                ConsumeAsyncTfl apiConsumeAsyncTfl = new ConsumeAsyncTfl();
                
                while (true)
                {
                   
                    var repositories = apiConsumeAsyncTfl.RoadStatusCheckTask().Result;

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