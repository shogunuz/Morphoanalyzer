using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Morphoanalyzer.StaticData
{
    public class StaticString
    {
        public static string NotFounded =
            "Не удалось распознать слово, попробуйте проверить правильно написания";
        public static string RootWord = "Root word";

        private static string ResWord = "";

        public static string SetString(string word) => StaticString.ResWord = word;

        public static string GetResString() => StaticString.ResWord;

       


    }
}
