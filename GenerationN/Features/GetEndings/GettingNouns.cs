
using System;
using System.Collections.Generic;
using System.Linq;
using GenerationN.Features.StaticData;
using GenerationN.Features.GetEndings;

namespace GenerationN.GetEndings
{
    public class GettingNouns : IGetEndings
    {
        private Dictionary<string, string> Dict;
        private string strKey { get; set; }
        private string strValue { get; set; }

        private string word;

        NounEndings nd;
        public GettingNouns(string word)
        {
            Dict = new Dictionary<string, string>();
            this.word = word;
            nd = new NounEndings();
        }
      

        public Dictionary<string, string> GetEndings()
        {
            //Данный счётчик нужен для того, чтобы определить, было ли добавлено 
            //окончание существительного
            int processed = 0;
            for (int i = 3; i > 0; i--)
            {
                MakeAllVariablesToEmpty();

                foreach (KeyValuePair<string, string> kvp in nd.Dict[i])
                {
                    KeyValue(kvp.Key, kvp.Value, 1);
                }

                if (string.IsNullOrEmpty(this.strKey) == false)
                {
                    Dict.Add(this.strKey, this.strValue);
                    this.word = this.word.Remove(this.word.Length - this.strKey.Length);
                    processed++;
                }

                
            }

            if(processed > 0)
            {
                Dict.Add(this.word, "Основа слова (существительное)");
            }

            return Dict;
        }

        public void KeyValue(string key,  string value, int mode)
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
        }

    }
}
