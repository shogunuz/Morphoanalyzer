using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GenerationN.Features.GetEndings
{
    public class CalcLevelByLevel
    {
        
        public static int LevelByLevel(string key,string word, int k)
        {
            
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
            if (k == charArr.Length)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}
