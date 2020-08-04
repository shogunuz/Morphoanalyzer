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
           /*
            * Нужно оформить все окончания по алфавитно, затем через бинари сёрч 
            * прогнать наше окончание
            */
            string str = "Bolalarimiz";
            GetEndingsGeneral getEnds = new GetEndingsGeneral(
                new GettingNouns(str));
           GetEndingsGeneral getEndsA = new GetEndingsGeneral(
                new GettingAdjectives(str));
           
            foreach(KeyValuePair<string,string> kvp in getEnds.GetEndings())
            {
                dict = new Dictionary<string, string>
                {
                    {kvp.Key, kvp.Value }
                }; 
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }
            foreach (KeyValuePair<string, string> kvp in getEndsA.GetEndings())
            {
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
