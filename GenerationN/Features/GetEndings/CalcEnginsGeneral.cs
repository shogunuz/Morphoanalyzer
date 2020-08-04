using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GenerationN.Features.GetEndings
{
    public class CalcEnginsGeneral
    {
        public static bool CheckEnding(string key, string word, int mode)
        {
            bool res = false;
            res = (mode == 1) ?  FromEndToStart(key, word) : FromStartToEnd(key, word);
            
            return res;
        }
        private static bool FromEndToStart(string key, string word)
        {
            int k = 0;
            char[] charArr = key.ToArray();
            Array.Reverse(charArr);
            char[] wordArr = word.ToArray();
            Array.Reverse(wordArr);
            for (int i=0; i<charArr.Length; i++)
            {
                if (wordArr[i] == charArr[i])
                {
                    k++;
                }
            }
            bool res = (k == charArr.Length) ? true : false;

            return res;
        }
        private static bool FromStartToEnd(string key, string word)
        {
            int k = 0;
            char[] charArr = key.ToArray();
            char[] wordArr = word.ToArray();
            for (int i = 0; i < charArr.Length; i++)
            {
                if (wordArr[i] == charArr[i])
                {
                    k++;
                }
            }
            bool res = (k == charArr.Length) ? true : false;

            return res;
        }
    }
}
