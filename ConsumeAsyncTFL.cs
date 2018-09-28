﻿using System;  
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace TFL
{
    public class ConsumeAsyncTfl : IConsumeAsyncTfl
    {
        private static readonly HttpClient Client = new HttpClient();
        public static IConfiguration Configuration { get; set; }

        public async Task<List<Repository>> RoadStatusCheckTask()
        {
            //Getting secrets from the secrets.json file.
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile(@"C:\Projects\TFL\GUID\secrets.json", optional: true, reloadOnChange: true);

            IConfigurationRoot configuration = builder.Build();
            var appConfig = configuration.GetSection("application").Get<AppConfiguration>();

            var appId = appConfig.AppID;
            var appKey = appConfig.AppKey;


            string apiBaseAddress = "https://api.tfl.gov.uk/Road/";


            var serializer = new DataContractJsonSerializer(typeof(List<Repository>));

            Client.DefaultRequestHeaders.Accept.Clear();
            Client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/vnd.github.v3+json"));

            Console.WriteLine("Please Enter Road Name");
            var roadName = Console.ReadLine();


            Client.DefaultRequestHeaders.Add("TFL-Agent", ".NET Core Accessing TFL API");

            var streamTask =
                Client.GetStreamAsync(apiBaseAddress + roadName + "?app_id=" + appId + "&app_key=" + appKey);


            var repositories = serializer.ReadObject(await streamTask) as List<Repository>;

            return repositories;
        }
    }
}
