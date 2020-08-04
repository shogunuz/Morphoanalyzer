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

            // GetNounEndings getNoun = new GetNounEndings();
            string str = "mansabparast";
            GetEndingsGeneral getEnds = new GetEndingsGeneral(
                new GetNounEndings(str));
            GetEndingsGeneral getEndsA = new GetEndingsGeneral(
                new GetAdjectiveEndings(str));
           
            foreach(KeyValuePair<string,string> kvp in getEnds.GettingEndings())
            {
                dict = new Dictionary<string, string>
                {
                    {kvp.Key, kvp.Value }
                }; 
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }
            foreach (KeyValuePair<string, string> kvp in getEndsA.GettingEndings())
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
