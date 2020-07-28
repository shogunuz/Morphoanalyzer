
using System;
using System.Collections.Generic;
using System.Linq;
using GenerationN.Features.StaticData;


namespace GenerationN.GetEndings
{
    public class GetNounEndings : IParent
    {
        private Dictionary<string, string> dict { get; set; }
        private string word;
        public GetNounEndings(string word)
        {
            this.word = word;
        }
      
        public Dictionary<string, string> CalculationEndings(int x)
        {
            int k = 0;
            switch (x)
            {
                case 1:
                     foreach (KeyValuePair<string, string> kvp in NoundEndings.NounEndsOne)
                        {
                            char[] charArr = kvp.Key.ToArray();
                            Array.Reverse(charArr);
                            char[] wordArr = word.ToArray();
                            Array.Reverse(wordArr);
                            for(int y=0; y<charArr.Length; y++)
                            {
                                if (wordArr[y] == charArr[y])
                                {
                                    k++;
                                }
                            }
                            if (k==charArr.Length)
                            {
                                dict = new Dictionary<string, string>
                                {
                                    {kvp.Key, kvp.Value }
                                };
                                Console.WriteLine($"{kvp.Key} : {kvp.Value}");
                            }
                        }
                    
                    break;
                case 2:
                        foreach (KeyValuePair<string, string> kvp in NoundEndings.NounEndsTwo)
                        {
                            char[] charArr = kvp.Key.ToArray();
                            Array.Reverse(charArr);
                            char[] wordArr = word.ToArray();
                            Array.Reverse(wordArr);
                            for (int y = 0; y < charArr.Length; y++)
                            {
                                if (wordArr[y] == charArr[y])
                                {
                                    k++;
                                }
                            }
                            if (k == charArr.Length)
                            {
                                dict = new Dictionary<string, string>
                                {
                                    {kvp.Key, kvp.Value }
                                };
                                Console.WriteLine($"{kvp.Key} : {kvp.Value}");
                            }
                        }
                    break;
                case 3:
                        foreach (KeyValuePair<string, string> kvp in NoundEndings.NounEndsThree)
                        {
                            char[] charArr = kvp.Key.ToArray();
                            Array.Reverse(charArr);
                            char[] wordArr = word.ToArray();
                            Array.Reverse(wordArr);
                            for (int y = 0; y < charArr.Length; y++)
                            {
                                if (wordArr[y] == charArr[y])
                                {
                                    k++;
                                }
                            }
                            if (k == charArr.Length)
                            {
                                dict = new Dictionary<string, string>
                                {
                                    {kvp.Key, kvp.Value }
                                };
                                Console.WriteLine($"{kvp.Key} : {kvp.Value}");
                            }
                        }
                    
                    break;
                default:
                    return null;
                    break;
            }

            return dict;
        }
        public Dictionary<string, string> GettingEndings()
        {
            for(int i=3; i>0; i--)
            {
                CalculationEndings(i);
            }

            return dict;
        }

    }
}
