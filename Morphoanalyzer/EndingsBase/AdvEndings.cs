using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Morphoanalyzer.EndingsBase
{
    public class AdvEndings
    {
        private static readonly string fromNounToAdj = "Endings that form adjectives from nouns: ";
        private static readonly string fromVerbToAdj = "Endings that form adjectives from verbs: ";
        private static readonly string fromOthersToAdj = "Окончания, формирующие прилагательное от других частей речи";
        private static readonly string TwoWords = "Прилагательные, формирующиеся путем слияния двух слов";
        private static readonly string fromSumOfNouns = $"{TwoWords}  (существительное + существительное)";
        private static readonly string fromSumOfAdjNoun = $"{TwoWords} (прилагательное + существительное)";
        private static readonly string fromSumOfVerbNounAdv = $"{TwoWords}  (глагол с окончанием -ar + сущ. | наречие )";
        private static readonly string fromEndings = $"{TwoWords} или добавлением окончаний (-aro)";


        public Dictionary<int, Dictionary<string, string>> Dict;

        public AdvEndings()
        {
            Dict = new Dictionary<int, Dictionary<string, string>>
            {
                {1, new Dictionary<string, string>(AdjEndsOne)},
                {2, new Dictionary<string, string>(AdjEndsTwo)},
                {3, new Dictionary<string, string>(AdjEndsThree)},
                {4, new Dictionary<string, string>(AdjEndsFour)},
                {5, new Dictionary<string, string>(AdjEndsFive)},
                {6, new Dictionary<string, string>(AdjEndsSix)},
                {7, new Dictionary<string, string>(AdjEndsSeven)},
                {8, new Dictionary<string, string>(AdjEndsEight)},

            };
        }
        private static readonly Dictionary<string, string> AdjEndsOne = new Dictionary<string, string>()
        {
            {"xush", fromNounToAdj },
            {"bad", fromNounToAdj },
            {"ser", fromNounToAdj },
            {"ba", fromNounToAdj },
            {"be", fromNounToAdj },
            {"bar", fromNounToAdj }
        };

        private static readonly Dictionary<string, string> AdjEndsTwo = new Dictionary<string, string>()
         {
            {"no", fromOthersToAdj }
         };

        private static readonly Dictionary<string, string> AdjEndsThree = new Dictionary<string, string>()
        {
            {"bodom", fromSumOfNouns },
            {"sher", fromSumOfNouns }
        };

        private static readonly Dictionary<string, string> AdjEndsFour = new Dictionary<string, string>()
        {
            {"qimmat", fromSumOfAdjNoun }
        };

        private static readonly Dictionary<string, string> AdjEndsFive = new Dictionary<string, string>()
        {
            {"tez", fromSumOfVerbNounAdv },
            {"erta", fromSumOfVerbNounAdv },
            {"umum", fromSumOfVerbNounAdv },
            {"yarim", fromSumOfVerbNounAdv },
            {"nim", fromSumOfVerbNounAdv }
        };

        private static readonly Dictionary<string, string> AdjEndsSix = new Dictionary<string, string>()
        {
            {"li", fromNounToAdj },
            {"lik", fromNounToAdj },
            {"siz", fromNounToAdj },
            {"iy", fromNounToAdj },
            {"viy", fromNounToAdj },
            {"gi", fromNounToAdj },
            {"ki", fromNounToAdj },
            {"qi", fromNounToAdj},
            {"aki", fromNounToAdj },
            {"oqi", fromNounToAdj },
            {"yi", fromNounToAdj },
            {"chan", fromNounToAdj },
            {"simon", fromNounToAdj },
            {"dor", fromNounToAdj },
            {"kor", fromNounToAdj },
            {"gar", fromNounToAdj },
            {"i", fromNounToAdj },
            {"cha", fromNounToAdj },
            {"namo", fromNounToAdj },
            {"parvar", fromNounToAdj },
            {"on", fromNounToAdj },
            {"shumul", fromNounToAdj },
            {"mand", fromNounToAdj },
            {"don", fromNounToAdj },
            {"kash", fromNounToAdj },
            {"bop", fromNounToAdj },
            {"in", fromNounToAdj },
            {"vor", fromNounToAdj },
            {"parast", fromNounToAdj },
            {"chil", fromNounToAdj },
            {"loq", fromNounToAdj },
            {"chi", fromNounToAdj },
            {"von", fromNounToAdj },
            {"qa", fromNounToAdj },
            {"omuz", fromNounToAdj },
            {"xo’r", fromNounToAdj },
            {"soz", fromNounToAdj },
            {"dek", fromNounToAdj }
        };

        private static readonly Dictionary<string, string> AdjEndsSeven = new Dictionary<string, string>()
        {
             {"choq", fromVerbToAdj },
             {"chack", fromVerbToAdj },
             {"chiq", fromVerbToAdj },
             {"gir", fromVerbToAdj },
             {"g'ir", fromVerbToAdj },
             {"kir", fromVerbToAdj },
             {"qir", fromVerbToAdj },
             {"qur", fromVerbToAdj },
             {"ma", fromVerbToAdj },
             {"ik", fromVerbToAdj },
             {"uk", fromVerbToAdj },
             {"ak", fromVerbToAdj },
             {"uq", fromVerbToAdj },
             {"iq", fromVerbToAdj },
             {"oq", fromVerbToAdj },
             {"qi", fromVerbToAdj },
             {"qoq", fromVerbToAdj },
             {"g'oq", fromVerbToAdj },
             {"ag'on", fromVerbToAdj },
             {"mon", fromVerbToAdj },
             {"kun", fromVerbToAdj },
             {"qin", fromVerbToAdj },
             {"g'in", fromVerbToAdj },
             {"g'un", fromVerbToAdj },
             {"qun", fromVerbToAdj },
             {"arli", fromVerbToAdj },
             {"ch", fromVerbToAdj },
             {"g'ich", fromVerbToAdj },
             {"ong'ich", fromVerbToAdj },
             {"ovuch", fromVerbToAdj },
             {"mas", fromVerbToAdj },
             {"indi", fromVerbToAdj },
             {"lom", fromVerbToAdj },
             {"msiq", fromVerbToAdj },
             {"aro", fromVerbToAdj }
           };
        /* Exception words for AdjEndsTwo
         * Похожие окончания
         *   {"qoq", $"{fromVerbToAdj} tirishqoq, uyushqoq" },
         *    {"oq", $"{fromVerbToAdj} qoloq, qochoq, qo'rqoq, baqiroq" },
         *    
         *    Только одна буква!
             {"a", $"{fromVerbToAdj} ko'tara (savdo)" },
         */

        private static readonly Dictionary<string, string> AdjEndsEight = new Dictionary<string, string>()
        {
            {"aro", fromEndings }
        };
    }
}
