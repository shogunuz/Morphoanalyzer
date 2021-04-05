using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;



namespace Morphoanalyzer.Exceptions
{
    public class ExceptionVerbs
    {

        public Dictionary<string, Dictionary<string, string>> Dict;
        public static string personalAffix = " is personal affix"; 
        public static string diAffix = " is exceptional -di affix, which is basically used in past tenses";

        public ExceptionVerbs()
        {
            Dict = new Dictionary<string, Dictionary<string, string>>
           {
                {"ishlamadi", new Dictionary<string, string>(ishlamadi)},
                {"ishlamadim", new Dictionary<string, string>(ishlamadim)},
                {"gapir", new Dictionary<string, string>(gapir)},
                {"gapirmoq", new Dictionary<string, string>(gapirmoq)},
                {"so'zlamoq", new Dictionary<string, string>(sozlamoq)}

           };
        }

        private static readonly Dictionary<string, string> ishlamadi = new Dictionary<string, string>()
        {
            {"ishla"," root word, verb (work), used for pronouns: you, they, we" },
            {"ma"," ending of verb, which is used for negative form of auxiliary verbs" },
            {"di"," ending of verb in past form" },
            {"ishlamadi"," verb in past form ( (he,she) did not work)" }
        };

        private static readonly Dictionary<string, string> ishlamadim = new Dictionary<string, string>()
        {
            {"ishla"," root word, verb (work), used for pronouns: you, they, we" },
            {"ma"," ending of verb, which is used for negative form of auxiliary verbs" },
            {"di"," ending of verb in past form" },
            {"m", $" {personalAffix}, which is used for past verbs of 1st person(I)" },
            {"ishlamadim"," verb in past form ( (I) did not work)" }
        };

        private static readonly Dictionary<string, string> gapir = new Dictionary<string, string>()
        {
            {"gapir"," root word, verb (to speak), used for pronouns: you, they, we" }
        };

        private static readonly Dictionary<string, string> gapirmoq = new Dictionary<string, string>()
        {
            {"gapir"," root word, verb (to speak), used for pronouns: you, they, we" },
            {"moq"," verb ending" }
        };

        private static readonly Dictionary<string, string> sozlamoq = new Dictionary<string, string>()
        {
            {"so'z"," root word, noun (a word)" },
            {"la"," affix, which is used to give order to someone" },
            {"moq"," verb ending" }
        };


    }
}
