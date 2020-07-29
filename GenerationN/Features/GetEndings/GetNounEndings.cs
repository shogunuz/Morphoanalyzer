
using System;
using System.Collections.Generic;
using System.Linq;
using GenerationN.Features.StaticData;
using GenerationN.Features.GetEndings;

namespace GenerationN.GetEndings
{
    public class GetNounEndings : IParent
    {
        private Dictionary<string, string> Dict;
       
        private string word;
        public GetNounEndings()
        {
            Dict = new Dictionary<string, string>();
        }
        public void SetWord(string word)
        {
            this.word = word;
        }
      
        public void CalculationEndings(int i)
        {
            
            string strKey="", strValue="";
            switch (i)
            {
                case 1:
                    foreach (KeyValuePair<string, string> kvp in NoundEndings.NounEndsOne)
                    {
                        if (CalcLevelByLevel.LevelByLevel(kvp.Key, word, 0) == 1)
                        {
                            if (strKey.Length < kvp.Key.Length)
                            {
                                strKey = kvp.Key;
                                strValue = kvp.Value;
                            }
                        }
                    }
                    break;
                case 2:
                    foreach (KeyValuePair<string, string> kvp in NoundEndings.NounEndsTwo)
                    {
                        if (CalcLevelByLevel.LevelByLevel(kvp.Key, word, 0) == 1)
                        {
                            if (strKey.Length < kvp.Key.Length)
                            {
                                strKey = kvp.Key;
                                strValue = kvp.Value;
                            }
                        }

                    }
                    break;
                case 3:
                    foreach (KeyValuePair<string, string> kvp in NoundEndings.NounEndsThree)
                    {
                        if (CalcLevelByLevel.LevelByLevel(kvp.Key,  word, 0) == 1)
                        {
                            if (strKey.Length < kvp.Key.Length)
                            {
                                strKey = kvp.Key;
                                strValue = kvp.Value;
                            }
                        }
                    }
                    break;
                default:
                    break;
            }
            
            if(string.IsNullOrEmpty(strKey)==false)
            {
                Dict.Add(strKey, strValue);
                word = word.Remove(word.Length - strKey.Length);
            }
        }
        public Dictionary<string, string> GettingEndings()
        {
            Console.WriteLine(word);
            for (int i = 3; i > 0; i--)
            {
                CalculationEndings(i);
            }
            Dict.Add(word, "Основа слова");
            

            return Dict;
        }

    }
}
