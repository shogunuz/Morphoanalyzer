
using System;
using System.Collections.Generic;
using System.Linq;
using GenerationN.Features;
using GenerationN.Exceptions;
using Morphoanalyzer.EndingsBase;
using Morphoanalyzer.ExceptionsAndWords;

/*
 * Developers: N. Abdurakhmonova, D.Mengliev
 * Year: 2020
 */
namespace Morphoanalyzer.CalcEndingsByStemming
{
    public class CalcNounEndings : IGetEndings
    {

        private string word;

        private NounEndings nounEndings;
        private CalcEndingsGeneral cGeneral;

        private Dictionary<string, string> tmpDict;

        public CalcNounEndings(string word)
        {
            this.word = word;
            nounEndings = new NounEndings();
            cGeneral = new CalcEndingsGeneral();
            tmpDict = new Dictionary<string, string>();
        }
      
        private int SearchWordFromExSet(string word)
        {
            int res = 0;
            ExceptionNouns exNounEnds = new ExceptionNouns();
            foreach (KeyValuePair<string, Dictionary<string, string>> kvp in exNounEnds.Dict)
            {
                int cnt = StringDistance.GetDamerauLevenshteinDistance(
                    kvp.Key, word);

                /*
                 * Если cnt поставить на ноль, то он будет искать слова со 100%-ым
                 * совпадением, а так, на одну букве делает погрешность,
                 * допустим слово dadanlar он пропустит, так как отличие всего одна
                 * буква n (а должно быть dadamlar)
                 * в ближайшей перспективе сделаем систему РЕКОМЕНДАЦИЙ, 
                 * типа, "возможно, вы имели ввиду это слово"?
                 */

                if(cnt == 0)
                {
                    this.tmpDict = kvp.Value;
                    res = 1;
                    break;
                }
            }

            return res;
        }

        public Dictionary<string, string> GetEndings()
        {
            
            int res = SearchWordFromExSet(this.word);
            if (res == 1)
            {
                return this.tmpDict;
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
                        if(cGeneral.KeyValue(kvp.Key, strKey, mode, this.word))
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
