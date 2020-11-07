using Morphoanalyzer.Features;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

/*
 * 
 *This class is responsible for searching endings of words by using EndingsBase. 
 * Each time we send to this class word, key and mode. Mode decides how we will search 
 * endings, from left to right, or vice versa.
 * Then, algorithm converts both key and word string to array forms. Thanks to this,
 * we can compare a letter by letter
 */
namespace Morphoanalyzer.CalcEndingsByStemming
{
    public class CalcEndingsGeneral
    {
        public Dictionary<string, string> TmpDict { get; set; }

        protected Dictionary<string, Dictionary<string, string>> ExceptionDict { get; set; }

        public static int exceptionWordInt;
        public static string exceptionWordStr;
        protected int SearchWordFromExSet(string word)
        {
            int res = 0;

            foreach (KeyValuePair<string, Dictionary<string, string>> kvp in ExceptionDict)
            {
                int cnt = StringDistance.GetDamerauLevenshteinDistance(
                    kvp.Key, word);

                /* Алгоритм Ливенштейна (модицифированный)
                 * Если cnt поставить на ноль, то он будет искать слова со 100%-ым
                 * совпадением. А если на 1, то на одну букву будет делать погрешность,
                 * допустим слово dadanlar он пропустит, так как отличие всего одна
                 * буква n (а должно быть dadamlar)
                 * в ближайшей перспективе сделаем систему РЕКОМЕНДАЦИЙ, 
                 * типа, "возможно, вы имели ввиду это слово"?
                 */

                if (cnt == 0)
                {
                    this.TmpDict = kvp.Value;
                    res = 1;
                    break;
                }
            }

            return res;
        }

        public static bool CheckEnding(string key, string word, int mode)
        {
            int k = 0;
            char[] keyArr = key.ToArray();
            char[] wordArr = word.ToArray();
            if (mode == 1) // FromRightToLeft
            {
                Array.Reverse(keyArr);
                Array.Reverse(wordArr);
            }
            //If mode is 0, then searching will work from Left to Right.

            //if key's length is the same as word's length, then we can 
            //just return false, because our rootWord is the same size as an ending.
            if (keyArr.Length != wordArr.Length)
            {
                try
                {
                    for (int i = 0; i < keyArr.Length; i++)
                    {
                        if (wordArr[i] == keyArr[i])
                        {
                            k++;
                        }
                    }
                }
                catch (IndexOutOfRangeException indexEx)
                {
                    //indexEx exception was generated
                }
                catch (Exception ex)
                {

                }
            }

            return (k == keyArr.Length);
        }
        public bool KeyValue(string key, string strKey, int mode, string word)
        {
            if (CheckEnding(key, word, mode))
            {
                if (strKey.Length < key.Length)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
