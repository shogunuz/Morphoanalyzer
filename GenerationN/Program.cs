using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GenerationN.Features;
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

        public static void Main(string[] args)
        {
            //Console.WriteLine("sdasd");
            GenerationEndings gt = new GenerationEndings();
            gt.GetData("Vakhala");
            Console.ReadKey();
           // CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
