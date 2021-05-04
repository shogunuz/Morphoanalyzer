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


        public Dictionary<string, string> Dict;

        public AdvEndings()
        {
            Dict = new  Dictionary<string, string>
            {
            {"li", fromNounToAdj }
            };
            /* Exception words for AdjEndsTwo
             * Похожие окончания
             *   {"qoq", $"{fromVerbToAdj} tirishqoq, uyushqoq" },
             *    {"oq", $"{fromVerbToAdj} qoloq, qochoq, qo'rqoq, baqiroq" },
             *    
             *    Только одна буква!
                 {"a", $"{fromVerbToAdj} ko'tara (savdo)" },
             */
        }
    }
}
