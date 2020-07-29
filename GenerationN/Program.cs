using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GenerationN.Features;
using GenerationN.Features.StaticData;
using GenerationN.GetEndings;
using GenerationN.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace GenerationN
{
    public class Program
    {
        //globally unique identifier[GUID] is a statistically unique 128-bit number
        //PointID = Guid.NewGuid();
        private static Dictionary<string, string> dict;
        public static void Main(string[] args)
        {
            // CreateHostBuilder(args).Build().Run();
           // dict = new Dictionary<string, string>();
            GetNounEndings getNoun = new GetNounEndings();
            getNoun.SetWord("Bolalarimiz");
           
            foreach(KeyValuePair<string,string> kvp in getNoun.GettingEndings())
            {
                dict = new Dictionary<string, string>
                {
                    {kvp.Key, kvp.Value }
                }; 
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }
            Console.ReadKey();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
