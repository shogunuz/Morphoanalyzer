using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

/*
 * Author: N. Abdurakhmonova, 
 * Assistant: D.Mengliev
 * Year: 2020
 * Description: This class contains Exception nouns base. System looks for word
 * here before to start stemming. If it finds out it will return the word. If not,
 * the system will start stemming.
 * Описание: Этот класс содержит базу существительных-исключений. Система, прежде
 * всего ищет слово здесь, и если оно находит его, это слово возвращается в качестве результата.
 * Если слово не содержится в этом словаре, то система запускает стемминг и полученный
 * от стемминга результат возвращается стороне, отправившей исходное слово.
 */

namespace Morphoanalyzer.Exceptions
{
    public class ExceptionNouns
    {

        public Dictionary<string, Dictionary<string, string>> Dict;
        public static string personsEndings = "Окончание, формирующее  существительное - личность"; 
        public static string objectEndings = "Окончание, формирующее существительное - предмет или объект";

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
            {"dadamlar"," this word is a noun in affectionate form (daddy)" }
        };

        private static readonly Dictionary<string, string> kelinchak = new Dictionary<string, string>()
        {
            {"kelin"," root word (bride)" },
            {"chak"," this ending is used as an affectionate" },
            {"kelinchak"," this word is a noun in affectonate form (bride)" },
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
