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
