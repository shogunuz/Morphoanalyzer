using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Morphoanalyzer.Exceptions
{
    public class KhorezmUzbekWords
    {

        public Dictionary<string, Dictionary<string, string>> Dict;
        public static string personsEndings = "The ending that forms the noun (personality, character)"; 
        public static string personsEndingsRus = "Окончание, формирующее  существительное - личность"; 
        public static string objectEndings = "Ending, which forms the noun (object or subject)";
        public static string objectEndingsRus = "Окончание, формирующее существительное - предмет или объект";

        public KhorezmUzbekWords()
        {
            Dict = new Dictionary<string, Dictionary<string, string>>
           {
                {"buzdin", new Dictionary<string, string>(buzdin)},
                {"ava", new Dictionary<string, string>(xa)},
                {"vagi'rdi", new Dictionary<string, string>(vagirdi)},
                {"xo'sh", new Dictionary<string, string>(xair)}
           };
        }

        private static readonly Dictionary<string, string> buzdin = new Dictionary<string, string>()
        {
            {"muz"," root word (ice)" },
            {"day"," ending, which forms adj from noun" }
        };

        private static readonly Dictionary<string, string> vagirdi = new Dictionary<string, string>()
        {
            {"shovqin"," root word (noise)" }
        }; 
        
        private static readonly Dictionary<string, string> xa = new Dictionary<string, string>()
        {
            {"xa"," root word (yes)" }
        };

        private static readonly Dictionary<string, string> xair = new Dictionary<string, string>()
        {
            {"xair"," root word (bye)" }
        };
    }
}
