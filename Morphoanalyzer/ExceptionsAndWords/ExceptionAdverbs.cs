using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Morphoanalyzer.Exceptions
{
    public class ExceptionAdverbs
    {

        public Dictionary<string, Dictionary<string, string>> Dict;
        public static string personsEndings = "The ending that forms the noun (person)"; 
        public static string objectEndings = "The ending that forms the noun (object)";

        public ExceptionAdverbs()
        {
            Dict = new Dictionary<string, Dictionary<string, string>>
           {
                {"bahorgi", new Dictionary<string, string>(bahorgi)},
                {"guzal", new Dictionary<string, string>(guzal)}

           };
        }

        private static readonly Dictionary<string, string> bahorgi = new Dictionary<string, string>()
        {
            {"bahor","Root word (n. Spring)" },
            {"gi","Endings that form adjectives from nouns: bahorgi (adj. spring)" },
            {"bahorgi", " is an adjective" }
        };

        private static readonly Dictionary<string, string> guzal = new Dictionary<string, string>()
        {
            {"guzal","Root word (beautiful)" }
        };

        

    }
}
