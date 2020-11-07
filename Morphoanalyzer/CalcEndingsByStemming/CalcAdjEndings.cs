using GenerationN.Features;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Morphoanalyzer.EndingsBase;
using Morphoanalyzer.ExceptionsAndWords;

namespace Morphoanalyzer.CalcEndingsByStemming
{
    public class CalcAdjEndings : IGetEndings
    {
        private string strKey { get; set; }
        private string strValue { get; set; }

        private string word;

        AdjEndings ad;

        public CalcAdjEndings(string word)
        {
            this.word = word;
            ad = new AdjEndings();
            
        }

        
        public Dictionary<string, string> GetEndings()
        {
            Dictionary<string, string> Dict = new Dictionary<string, string>();

            //Данный счётчик нужен для того, чтобы определить, было ли добавлено 
            //окончание прилагательного
            int processed = 0;

            //if mode is 1, it means that algorithm will stem from right to left
            //if mode is 0, the stemming algorithm will stem from left to right
            int mode = 1;

            //This string is used for storing root of the word
            string rootOfWord = string.Empty;

            for (int i = 7; i > 0; i--)
            {
                this.strKey = string.Empty; 
                this.strValue = string.Empty;
                string key = string.Empty;
                string value = string.Empty;

                if (i == 1) { mode = 0; }

                foreach (KeyValuePair<string, string> kvp in ad.Dict[i])
                {
                    this.KeyValue(kvp.Key, kvp.Value, mode);
                    if(strKey.Length > key.Length)
                    {
                        key = new string(strKey);
                        value = new string(strValue);
                    }
                }

                if (string.IsNullOrEmpty(key) == false)
                {
                    processed++;
                    Dict.Add(key, value);

                    //We try to determine the root of the word
                    //1-noun, 2-adj, 3-verb, 4-adverbs
                    rootOfWord = CalcTypeofRoot.TypeOfRoot(i,2);
                    if (mode == 0)
                    {
                        this.word = this.word.Remove(0, key.Length);
                    }
                    else
                    {
                        this.word = this.word.Remove(this.word.Length - key.Length);
                    }
                }

            }

            if(processed > 0)
            {
                Dict.Add(this.word, rootOfWord);
            }

            return Dict;
        }

        public void KeyValue(string key, string value, int mode)
        {
            if (CalcEndingsGeneral.CheckEnding(key, this.word, mode))
            {
                if (this.strKey.Length < key.Length)
                {
                    this.strKey = key;
                    this.strValue = value;
                }
            }
        }

    }
}
