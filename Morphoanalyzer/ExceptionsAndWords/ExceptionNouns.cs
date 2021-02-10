using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Morphoanalyzer.Exceptions
{
    public class ExceptionNouns
    {

        public Dictionary<string, Dictionary<string, string>> Dict;
        public static string personsEndings = "The ending that forms the noun (personality, character)"; 
        public static string personsEndingsRus = "Окончание, формирующее  существительное - личность"; 
        public static string objectEndings = "Ending, which forms the noun (object or subject)";
        public static string objectEndingsRus = "Окончание, формирующее существительное - предмет или объект";

        public ExceptionNouns()
        {
            Dict = new Dictionary<string, Dictionary<string, string>>
           {
                {"assalom", new Dictionary<string, string>(assalom)},
                {"dadamlar", new Dictionary<string, string>(dadamlar)},
                {"kelinchak", new Dictionary<string, string>(kelinchak)},
                {"manzara", new Dictionary<string, string>(manzara)}
           };
        }

        private static readonly Dictionary<string, string> dadamlar = new Dictionary<string, string>()
        {
            {"dada"," root word (father)" },
            {"m"," auxiliary particle" },
            {"lar"," this ending is used as an affectionate, " +
                "not as an plural ending" },
            {"dadamlar"," is a noun in affectionate form (daddy)" }
        };

        private static readonly Dictionary<string, string> kelinchak = new Dictionary<string, string>()
        {
            {"kelin"," root word (bride)" },
            {"chak"," this ending is used as an affectionate" },
            {"kelinchak"," is a noun in affectonate form (bride)" },
        }; 
        
        private static readonly Dictionary<string, string> assalom = new Dictionary<string, string>()
        {
            {"assalom"," root word (Greetings)" }
        };

        private static readonly Dictionary<string, string> manzara = new Dictionary<string, string>()
        {
            {"manzara"," root word (view, beautiful view)" }
        };
    }
}
