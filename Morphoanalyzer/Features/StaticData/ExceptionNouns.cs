using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

/*
 * Developers: N. Abdurakhmonova, D.Mengliev
 * Year: 2020
 */

namespace GenerationN.Features.StaticData
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
