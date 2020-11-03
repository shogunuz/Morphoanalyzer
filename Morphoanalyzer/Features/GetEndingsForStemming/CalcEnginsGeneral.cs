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
            char[] keyArr = key.ToArray();
            Array.Reverse(keyArr);
            char[] wordArr = word.ToArray();
            Array.Reverse(wordArr);
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
                
            }
            catch (Exception ex)
            {

            }
            bool res = (k == keyArr.Length) ? true : false;

            return res;
        }
        private static bool FromStartToEnd(string key, string word)
        {
            int k = 0;
            char[] keyArr = key.ToArray();
            char[] wordArr = word.ToArray();
            if(keyArr.Length != wordArr.Length)
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

                }
                catch (Exception ex)
                {

                }
            }
            bool res = (k == keyArr.Length) ? true : false;

            return res;
        }
    }
}
