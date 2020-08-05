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
        private int mode { get; set; }

        private string word;

        AdjEndings ad;

        public GettingAdjectives(string word)
        {
            this.word = word;
            ad = new AdjEndings();
            Dict = new Dictionary<string, string>();
        }

        
        public Dictionary<string, string> GetEndings()
        {
            //Данный счётчик нужен для того, чтобы определить, было ли добавлено 
            //окончание существительного
            int processed = 0;
            for (int i = 3; i > 0; i--)
            {
                MakeAllVariablesToEmpty();
                foreach (KeyValuePair<string, string> kvp in ad.Dict[i])
                {
                    if (i == 2)
                    {
                        this.mode = 0;
                    }
                    KeyValue(kvp.Key, kvp.Value, mode);
                }
                if (string.IsNullOrEmpty(this.strKey) == false)
                {
                    processed++;
                    Dict.Add(this.strKey, this.strValue);
                    if (this.mode == 0)
                    {
                        this.word = this.word.Remove(0, this.strKey.Length);
                    }
                    else
                    {
                        this.word = this.word.Remove(this.word.Length - this.strKey.Length);
                    }
                }

            }

            if(processed>0)
            {
                Dict.Add(this.word, "Основа слова (прилагательное)");
            }

            return Dict;
        }

        public void KeyValue(string key, string value, int mode)
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

        public void MakeAllVariablesToEmpty()
        {
            this.strKey = "";
            this.strValue = "";
            this.mode = 1;
        }
    }
}
