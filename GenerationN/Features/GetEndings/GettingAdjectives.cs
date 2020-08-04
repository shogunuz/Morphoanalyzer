using GenerationN.Features;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GenerationN.Features.StaticData;
using GenerationN.Features.GetEndings;

namespace GenerationN.GetEndings
{
    public class GettingAdjectives : IGetEndings
    {
        private Dictionary<string, string> Dict;
        private string strKey { get; set; }
        private string strValue { get; set; }

        private string word;

        AdjEndings ad;
        public GettingAdjectives(string word)
        {
            Dict = new Dictionary<string, string>();
            this.word = word;
            ad = new AdjEndings();
        }

        
        public Dictionary<string, string> GetEndings()
        {
            //Console.WriteLine("Adjective: "+this.word);
            int mode = 0;
            for (int i = 3; i > 0; i--)
            {
                mode = 1;
                foreach (KeyValuePair<string, string> kvp in ad.Dict[i])
                {
                    if (i == 2)
                    {
                        mode = 0;
                    }
                    KeyValue(kvp.Key, kvp.Value, mode);
                }
                if (string.IsNullOrEmpty(this.strKey) == false)
                {
                    Dict.Add(this.strKey, this.strValue);
                    this.word = this.word.Remove(this.word.Length - this.strKey.Length);
                }

                this.strKey = "";
                this.strValue = "";
            }

            Dict.Add(this.word, "Основа слова");

            return Dict;
        }

        public void KeyValue(string key, string value, int mode)
        {
            void keyValue()
            {
                if (CalcEnginsGeneral.CheckEnding(key, this.word, mode))
                {
                    if (this.strKey.Length < key.Length)
                    {
                        this.strKey = key;
                        this.strValue = value;
                    }
                }
            }
            keyValue();
        }

    }
}
