using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GenerationN.Features.StaticData
{
    public class AdjEndings
    {
        private static string fromNounToAdj = "Окончания, формирующие прилагательные от существительных";
        private static string fromVerbtoAdj = "Окончания, формирующие прилагательные от глаголов";
        internal static Dictionary<string, string> AdjEndsOne = new Dictionary<string, string>()
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
           // {"qa", $"{fromNounToAdj} " },
        };
        internal static Dictionary<string, string> AdjEndsOnePre = new Dictionary<string, string>()
        {
            {"xush", $"{fromNounToAdj} xushfе'l, xushhavo" },
            {"bad", $"{fromNounToAdj} badbaxt, badnafs" },
            {"ser", $"{fromNounToAdj} sеrhosil olma" },
            {"ba", $"{fromNounToAdj} badavlat, baquvvat" },
            {"be", $"{fromNounToAdj} bеg’ubor, bеxabar" },
            {"bar", $"{fromNounToAdj} barhayot, barvaqt" }
        };


        internal static Dictionary<string, string> AdjEndsTwo = new Dictionary<string, string>()
       {
             {"choq", $"{fromVerbtoAdj} maqtanchoq" },
             {"chack", $"{fromVerbtoAdj} kuyunchak" },
             {"chiq", $"{fromVerbtoAdj} qizg'anchiq" },
             {"gir", $"{fromVerbtoAdj} sezgir" },
             {"g'ir", $"{fromVerbtoAdj} olg'ir" },
             {"kir", $"{fromVerbtoAdj} o'tkir" },
             {"qir", $"{fromVerbtoAdj} topqir" },
             {"qur", $"{fromVerbtoAdj} uchqur" },
             {"ma", $"{fromVerbtoAdj} qaynatma sho'rva" },
             {"ik", $"{fromVerbtoAdj} teshik, chirik" },
             {"uk", $"{fromVerbtoAdj} tuzuk" },
             {"ak", $"{fromVerbtoAdj} g'alvirak" },
             {"uq", $"{fromVerbtoAdj} buzuq" },
             {"iq", $"{fromVerbtoAdj} iliq, siniq" },
             {"oq", $"{fromVerbtoAdj} qoloq, qochoq, qo'rqoq, baqiroq" },
             {"qi", $"{fromVerbtoAdj} sayroqi qush" },
             {"qoq", $"{fromVerbtoAdj} tirishqoq, uyushqoq" },
             {"g'oq", $"{fromVerbtoAdj} toyg'oq" },
             {"ag'on", $"{fromVerbtoAdj} bilag'on, chopag'on" },
             {"mon", $"{fromVerbtoAdj} bilarmon, qirarmon" },
             {"kun", $"{fromVerbtoAdj} tushkun" },
             {"qin", $"{fromVerbtoAdj} jo'shqin" },
             {"g'in", $"{fromVerbtoAdj} ozg'in" },
             {"g'un", $"{fromVerbtoAdj} turg'un" },
             {"qun", $"{fromVerbtoAdj} tutqun" },
             {"arli", $"{fromVerbtoAdj} yetarli, zerikarli" },
             {"ch", $"{fromVerbtoAdj} tinch, jirkanch" },
             {"g'ich", $"{fromVerbtoAdj} yulg'ich" },
             {"ong'ich", $"{fromVerbtoAdj} tepong'ich, suzong'inch" },
             {"ovuch", $"{fromVerbtoAdj} hurkovuch, iskovuch" },
             {"mas", $"{fromVerbtoAdj} o'tmas(pichoq), indamas(odam)" },
             {"indi", $"{fromVerbtoAdj} asrandi (bola)" }
            // Я дошел до 1.1.3
           };
        /* Exception words for AdjEndsTwo
         * Похожие окончания
         *   {"qoq", $"{fromVerbtoAdj} tirishqoq, uyushqoq" },
         *    {"oq", $"{fromVerbtoAdj} qoloq, qochoq, qo'rqoq, baqiroq" },
         *    
         *    Только одна буква!
             {"a", $"{fromVerbtoAdj} ko'tara (savdo)" },
         */
        internal static Dictionary<string, string> AdjEndsThree = new Dictionary<string, string>()
            {
                {"ss","Именительный падеж(кто? что?) не имеет окончания bola, kitob" },
               
            };



}
}
