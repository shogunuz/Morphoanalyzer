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
    public class ExceptionAdjectives
    {

        public Dictionary<string, Dictionary<string, string>> Dict;
        public static string personsEndings = "Окончание, формирующее  существительное - личность"; 
        public static string objectEndings = "Окончание, формирующее существительное - предмет или объект";

        public ExceptionAdjectives()
        {
            Dict = new Dictionary<string, Dictionary<string, string>>
           {
                {"bahorgi", new Dictionary<string, string>(bahorgi)}
           };
        }

        private static readonly Dictionary<string, string> bahorgi = new Dictionary<string, string>()
        {
            {"bahor"," корень слова" },
            {"gi","Окончания, формирующие прилагательные от существительных bahorgi (ishlar)" }
        };

    }
}
