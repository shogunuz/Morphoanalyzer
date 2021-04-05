using Morphoanalyzer.Features;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Morphoanalyzer.CalcEndingsByStemming
{
    public class CalcEndingsGeneral
    {
        protected Dictionary<string, string> TmpDict { get; set; }

        protected Dictionary<string, Dictionary<string, string>> ExceptionDict { get; set; }

        public static int exceptionWordInt;
        public static string exceptionWordStr;
        protected bool SearchWordFromExSet(string word)
        {
            //We define string array and set a value to it (keys of ExceptionDict)
            string[] listOfKeys = ExceptionDict.Keys.ToArray();

            //we sort listOfKeys, thanks to this, 
            //we can be sure in the way to use binarySearch
            Array.Sort(listOfKeys);

            //I set negative value due to this variable can hold 0,
            //if binarySearch find key in position(0). So, negative value is the best option
            int key = -1;
            key = Array.BinarySearch(listOfKeys, word);

            //If key is more than 0 (including itself), then it means that
            //there is a word in Exception Dict
            if (key >= 0)
            {
                this.TmpDict = ExceptionDict[word];
                return true;
            }
            else {
                ///We launch Levenstein Algrorithm
                for (int i = 0; i < listOfKeys.Length; i++)
                {
                    int t = StringDistance.GetDamerauLevenshteinDistance(listOfKeys[i], word);
                    if (t <= 1)
                    {
                        this.TmpDict = ExceptionDict[listOfKeys[i]];
                        this.TmpDict.Add("Perhaps, you meant: ", listOfKeys[i]);

                        return true;
                    }
                }
            }
            return false;
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
