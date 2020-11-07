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

namespace GenerationN.Exceptions
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
                {"dadamlar", new Dictionary<string, string>(dadamlar)},
                {"kelinchak", new Dictionary<string, string>(kelinchak)}
           };
        }

        private static readonly Dictionary<string, string> dadamlar = new Dictionary<string, string>()
        {
            {"dada"," корень слова" },
            {"lar"," данное окончание используется как ласкательное, а не как" +
                " окончание предмета или лица множественного числа" }
        };

        private static readonly Dictionary<string, string> kelinchak = new Dictionary<string, string>()
        {
            {"kelin"," корень слова" },
            {"chack"," данное окончание используется как ласкательное" }
        };

    }
}
