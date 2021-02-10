
using System;
using System.Collections.Generic;
using System.Linq;
using Morphoanalyzer.EndingsBase;
using Morphoanalyzer.ExceptionsAndWords;
using Morphoanalyzer.Exceptions;
using Morphoanalyzer.Features;
using DotLiquid.Tags;


namespace Morphoanalyzer.CalcEndingsByStemming
{
    public class CalcNounEndings: CalcEndingsGeneral, IGetEndings
    {
        private string word;

        private readonly NounEndings nounEndings;
        public CalcNounEndings(string word)
        {
            this.word = word;
            nounEndings = new NounEndings();
            TmpDict = new Dictionary<string, string>();
            ExceptionDict = new Dictionary<string, 
                Dictionary<string, string>>(new ExceptionNouns().Dict);
        }
      
        public Dictionary<string, string> GetEndings()
        {
            bool res = SearchWordFromExSet(this.word);
            if (res)
            {
                CalcEndingsGeneral.exceptionWordInt = 1;//for noun this is 1
                return this.TmpDict;
            }
            else
            {
                Dictionary<string, string> Dict = new Dictionary<string, string>();
                
                //if mode is 1, it means that algorithm will stem from right to left
                //if mode is 0, the stemming algorithm will stem from left to right
                int mode = 1;

                //Данный счётчик нужен для того, чтобы определить, было ли добавлено 
                //окончание существительного
                int processed = 0;

                //This string is used for storing root of the word
                //1-noun, 2-adj, 3-verb, 4-adverbs
                string rootOfWord = string.Empty;

                for (int i = nounEndings.Dict.Count; i > 0; i--)
                {
                    string strKey = string.Empty;
                    string strValue = string.Empty;
                    string key = string.Empty;
                    string value = string.Empty;


                    if (i == 1)
                    {
                        mode = 0;
                    }

                    foreach (KeyValuePair<string, string> kvp in nounEndings.Dict[i])
                    {
                        if(KeyValue(kvp.Key, strKey, mode, this.word))
                        {
                            strKey = kvp.Key;
                            strValue = kvp.Value;
                        }
                        if (strKey.Length > key.Length)
                        {
                            key = new string(strKey);
                            value = new string(strValue);
                        }
                    }

                    if (string.IsNullOrEmpty(key) == false)
                    {
                        processed++;
                        Dict.Add(key, value);
                        rootOfWord = CalcTypeofRoot.TypeOfRoot(i,1);
                        if (mode == 0)
                        {
                            //это нулевой dict, где мы удаляем не окончание, а приставку
                            this.word = this.word.Remove(0, key.Length);
                        }
                        else
                        {
                            this.word = this.word.Remove(this.word.Length - key.Length);
                        }
                    }

                }

                if (processed > 0)
                {
                    Dict.Add(this.word, rootOfWord);
                }

                return Dict;
            }
        }

        
    }
}
