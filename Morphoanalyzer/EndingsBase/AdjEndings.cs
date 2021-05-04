using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Morphoanalyzer.EndingsBase
{
    public class AdjEndings
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

        public AdjEndings()
        {
            Dict = new Dictionary<string, string>
            {
            {"xush", fromNounToAdj },
            {"bad", fromNounToAdj },
            {"ser", fromNounToAdj },
            {"ba", fromNounToAdj },
            {"be", fromNounToAdj },
            {"bar", fromNounToAdj },
            {"no", fromOthersToAdj },
            {"bodom", fromSumOfNouns },
            {"sher", fromSumOfNouns },
            {"qimmat", fromSumOfAdjNoun },
            {"tez", fromSumOfVerbNounAdv },
            {"erta", fromSumOfVerbNounAdv },
            {"umum", fromSumOfVerbNounAdv },
            {"yarim", fromSumOfVerbNounAdv },
            {"nim", fromSumOfVerbNounAdv },
            {"lik", fromNounToAdj },
            {"siz", fromNounToAdj },
            {"iy", fromNounToAdj },
            {"viy", fromNounToAdj },
            {"gi", fromNounToAdj },
            {"ki", fromNounToAdj },
            {"aki", fromNounToAdj },
            {"oqi", fromNounToAdj },
            {"yi", fromNounToAdj },
            {"chan", fromNounToAdj },
            {"simon", fromNounToAdj },
            {"dor", fromNounToAdj },
            {"kor", fromNounToAdj },
            {"gar", fromNounToAdj },
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
            {"dek", fromNounToAdj },
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
        }

    }
}
