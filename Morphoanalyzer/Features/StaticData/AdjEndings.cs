using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GenerationN.Features.StaticData
{
    public class AdjEndings
    {
        private static string fromNounToAdj = "Окончания, формирующие прилагательные от существительных";
        private static string fromVerbToAdj = "Окончания, формирующие прилагательные от глаголов";
        private static string fromOthersToAdj = "Окончания, формирующие прилагательное от других частей речи";
        private static string TwoWords = "Прилагательные, формирующиеся путем слияния двух слов";
        private static string fromSumOfNouns = $"{TwoWords}  (существительное + существительное)";
        private static string fromSumOfAdjNoun = $"{TwoWords} (прилагательное + существительное)";
        private static string fromSumOfVerbNounAdv = $"{TwoWords}  (глагол с окончанием -ar + сущ. | наречие )";
        private static string fromEndings = $"{TwoWords} или добавлением окончаний (-aro)";


        public Dictionary<int, Dictionary<string, string>> Dict;

        public AdjEndings()
        {
            Dict = new Dictionary<int, Dictionary<string, string>>
            {
                {1, new Dictionary<string, string>(AdjEndsOne)},
                {2, new Dictionary<string, string>(AdjEndsTwo)},
                {3, new Dictionary<string, string>(AdjEndsThree)},
                {4, new Dictionary<string, string>(AdjEndsFour)},
                {5, new Dictionary<string, string>(AdjEndsFive)},
                {6, new Dictionary<string, string>(AdjEndsSix)},
                {7, new Dictionary<string, string>(AdjEndsSeven)}
            };
        }
        private static readonly Dictionary<string, string> AdjEndsOne = new Dictionary<string, string>()
        {
            {"xush", $"{fromNounToAdj} xushfе'l, xushhavo" },
            {"bad", $"{fromNounToAdj} badbaxt, badnafs" },
            {"ser", $"{fromNounToAdj} sеrhosil olma" },
            {"ba", $"{fromNounToAdj} badavlat, baquvvat" },
            {"be", $"{fromNounToAdj} bеg’ubor, bеxabar" },
            {"bar", $"{fromNounToAdj} barhayot, barvaqt" }
        };

        private static readonly Dictionary<string, string> AdjEndsTwo = new Dictionary<string, string>()
         {
            {"no", $"{fromOthersToAdj} noma'lum, noto'g'ri" }
         };

        private static readonly Dictionary<string, string> AdjEndsThree = new Dictionary<string, string>()
        {
            {"bodom", $"{fromSumOfNouns} bodomqovoh" },
            {"sher", $"{fromSumOfNouns} sheryurak" }
        };

        private static readonly Dictionary<string, string> AdjEndsFour = new Dictionary<string, string>()
        {
            {"qimmat", $"{fromSumOfAdjNoun} qimmatbaho" }
        };

        private static readonly Dictionary<string, string> AdjEndsFive = new Dictionary<string, string>()
        {
            {"tez", $"{fromSumOfVerbNounAdv} tezoqar" },
            {"erta", $"{fromSumOfVerbNounAdv} ertapishar" },
            {"umum", $"{fromSumOfVerbNounAdv} umumkomanda" },
            {"yarim", $"{fromSumOfVerbNounAdv} yarimavtomat" },
            {"nim", $"{fromSumOfVerbNounAdv} nimpushti" }
        };

        private static readonly Dictionary<string, string> AdjEndsSix = new Dictionary<string, string>()
        {
            {"li", $"{fromNounToAdj} rasmli (kitob), kuchli (shamol)" },
            {"lik", $"{fromNounToAdj} toshkеntlik (bola), ko’ylaklik(chit), bolalik(chog’lar) " },
            {"siz", $"{fromNounToAdj} tuzsiz (ovqat)"},
            {"iy", $"{fromNounToAdj} dеvoriy (gazeta)"},
            {"viy", $"{fromNounToAdj} tarbiyaviy (soat)"},
            {"gi", $"{fromNounToAdj} bahorgi (ishlar)"},
            {"ki", $"{fromNounToAdj} qishki (kiyim)"},
            {"qi", $"{fromNounToAdj} qishki (kiyim)"},
            {"aki", $"{fromNounToAdj} jizzaki, jirttaki" },
            {"oqi", $"{fromNounToAdj} pistoqi" },
            {"yi", $"{fromNounToAdj} havoyi" },
            {"chan", $"{fromNounToAdj} ishchan bola" },
            {"simon", $"{fromNounToAdj} odamsimon maymun" },
            {"dor", $"{fromNounToAdj} aybdor, vafodor" },
            {"kor", $"{fromNounToAdj} isyonkor, zulmkor" },
            {"gar", $"{fromNounToAdj} javobgar, ig’vogar" },
            {"i", $"{fromNounToAdj} qishloqi, qozoqi" },
            {"cha", $"{fromNounToAdj} farg’onacha, erkakcha" },
            {"namo", $"{fromNounToAdj} avliyonamo, darvеshnamo" },
            {"parvar", $"{fromNounToAdj} xalqparvar, adolatparvar" },
            {"on", $"{fromNounToAdj} charohon, za'faron " },
            {"shumul", $"{fromNounToAdj} olamshumul, jahonshumul" },
            {"mand", $"{fromNounToAdj} kasalmand, davlatmand" },
            {"don", $"{fromNounToAdj} gapdon, bilimdon" },
            {"kash", $"{fromNounToAdj} dilkash, hazilkash, zahmatkash(odam)" },
            {"bop", $"{fromNounToAdj} palovbop, qishbop" },
            {"in", $"{fromNounToAdj} erkin, otashin" },
            {"vor", $"{fromNounToAdj} dеvonavor, afsonavor" },
            {"parast", $"{fromNounToAdj} mansabparast, maishatparast" },
            {"chil", $"{fromNounToAdj} xalqchil, izchil" },
            {"loq", $"{fromNounToAdj} baqaloq, qo’shaloq (g’o’za) " },
            {"chi", $"{fromNounToAdj} gapchi(odam), vahimachi(ayol)" },
            {"von", $"{fromNounToAdj} zo’ravon(odam)" },
            {"qa", $"{fromNounToAdj} loyqa(suv)" },
            {"omuz", $"{fromNounToAdj} hazilomuz(gap), zaharomuz(hazil)" },
            {"xo’r", $"{fromNounToAdj} g’amxo’r(odam), go’shtxo’r(hayvon)" },
            {"soz", $"{fromNounToAdj} soatsoz(usta)" },
            {"dek", $"{fromNounToAdj} muzdеk(suv), jo’jabirday(jon)" }
        };

        private static readonly Dictionary<string, string> AdjEndsSeven = new Dictionary<string, string>()
        {
             {"choq", $"{fromVerbToAdj} maqtanchoq" },
             {"chack", $"{fromVerbToAdj} kuyunchak" },
             {"chiq", $"{fromVerbToAdj} qizg'anchiq" },
             {"gir", $"{fromVerbToAdj} sezgir" },
             {"g'ir", $"{fromVerbToAdj} olg'ir" },
             {"kir", $"{fromVerbToAdj} o'tkir" },
             {"qir", $"{fromVerbToAdj} topqir" },
             {"qur", $"{fromVerbToAdj} uchqur" },
             {"ma", $"{fromVerbToAdj} qaynatma sho'rva" },
             {"ik", $"{fromVerbToAdj} teshik, chirik" },
             {"uk", $"{fromVerbToAdj} tuzuk" },
             {"ak", $"{fromVerbToAdj} g'alvirak" },
             {"uq", $"{fromVerbToAdj} buzuq" },
             {"iq", $"{fromVerbToAdj} iliq, siniq" },
             {"oq", $"{fromVerbToAdj} qoloq, qochoq, qo'rqoq, baqiroq" },
             {"qi", $"{fromVerbToAdj} sayroqi qush" },
             {"qoq", $"{fromVerbToAdj} tirishqoq, uyushqoq" },
             {"g'oq", $"{fromVerbToAdj} toyg'oq" },
             {"ag'on", $"{fromVerbToAdj} bilag'on, chopag'on" },
             {"mon", $"{fromVerbToAdj} bilarmon, qirarmon" },
             {"kun", $"{fromVerbToAdj} tushkun" },
             {"qin", $"{fromVerbToAdj} jo'shqin" },
             {"g'in", $"{fromVerbToAdj} ozg'in" },
             {"g'un", $"{fromVerbToAdj} turg'un" },
             {"qun", $"{fromVerbToAdj} tutqun" },
             {"arli", $"{fromVerbToAdj} yetarli, zerikarli" },
             {"ch", $"{fromVerbToAdj} tinch, jirkanch" },
             {"g'ich", $"{fromVerbToAdj} yulg'ich" },
             {"ong'ich", $"{fromVerbToAdj} tepong'ich, suzong'inch" },
             {"ovuch", $"{fromVerbToAdj} hurkovuch, iskovuch" },
             {"mas", $"{fromVerbToAdj} o'tmas(pichoq), indamas(odam)" },
             {"indi", $"{fromVerbToAdj} asrandi (bola)" },
             {"lom", $"{fromVerbToAdj} sog'lom" },
             {"msiq", $"{fromVerbToAdj} qarimsiq, achimsiq" },
             {"aro", $"{fromEndings} xalqaro" }
           };
        /* Exception words for AdjEndsTwo
         * Похожие окончания
         *   {"qoq", $"{fromVerbToAdj} tirishqoq, uyushqoq" },
         *    {"oq", $"{fromVerbToAdj} qoloq, qochoq, qo'rqoq, baqiroq" },
         *    
         *    Только одна буква!
             {"a", $"{fromVerbToAdj} ko'tara (savdo)" },
         */

        //1.2.2 + 1.2.3
        private static readonly Dictionary<string, string> AdjEndsEight = new Dictionary<string, string>()
        {
            {"aro", $"{fromEndings} xalqaro" }
        };
    }
}
