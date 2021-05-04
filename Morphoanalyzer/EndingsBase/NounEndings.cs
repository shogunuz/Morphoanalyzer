using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Morphoanalyzer.EndingsBase
{
    public class NounEndings
    {

        public Dictionary<string, string> Dict;
        public static string personsEndings = "The ending that forms the noun (personality, character)";
        public static string personsEndingsRus = "Окончание, формирующее  существительное - личность";
        public static string objectEndings = "Ending, which forms the noun (object or subject)";
        public static string objectEndingsRus = "Окончание, формирующее существительное - предмет или объект";

        public NounEndings()
        {
            Dict = new Dictionary<string, string>(dict);
        }
        private static readonly Dictionary<string, string> dict = new Dictionary<string, string>()
        {
            {"ham",personsEndings },
            {"dan",personsEndings },
            {"chi", personsEndings },
            {"dosh", personsEndings },
            {"kor", personsEndings },
            {"kar", personsEndings },
            {"gar", personsEndings },
            {"gor", personsEndings },
            {"kash", personsEndings },
            {"dor", personsEndings },
            {"bon", personsEndings },
            {"boz", personsEndings },
            {"paz",personsEndings },
            {"xon", personsEndings },
            {"shunos", personsEndings },
            {"do'z", personsEndings },
            {"soz", personsEndings },
            {"xo'r", personsEndings },
            {"parast", personsEndings },
            {"go'y", personsEndings },
            {"furush", personsEndings },
            {"vachcha", personsEndings },
            {"uvchi", personsEndings },
            {"ovchi", personsEndings },
            {"sil", personsEndings },

            //Narsa-buyum otlari yasovchi qo'shimchalar
            //окончания, формирующие предмет или объект
            {"gich", objectEndings },
            {"kich", objectEndings },
            {"qich", objectEndings },
            {"g'ich", objectEndings },
            {"lar","Plural ending (noun)" },
            {"m","1st person, vowel endings"},
            {"im","1st person, consonant endings"},
            {"miz","1st person, vowel endings" },
            {"imiz","1st person, consonant endings" },
            {"ng","2nd person, vowel endings, singular" },
            {"ing","2nd person, consonant endings, singular " },
            {"ngiz","2nd person, vowel endings, plural" },
            {"ingiz","2nd person, consonant endings, plural" },
            {"si","3rd person, vowel endings, singular" },
            {"ss","Nominative case (who? What?) Has no ending" },
            {"ning","Genitive case (Whose? Whose?)" },
            {"ni","Accusative case (Who? What?)" },
            {"ga","Dative-directional case (To whom? What? Why? Where?)" },
            {"ka","Dative-directional case (To whom? What? Why? Where?)" },
            {"qa","Dative-directional case (To whom? What? Why? Where?)" },
           // {"na","Dative-directional case (To whom? What? Why? Where?)" },
            {"da","Dative-directional case (Who? In what? On what?)" }
        };
    }
}
