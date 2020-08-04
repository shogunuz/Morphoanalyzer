using GenerationN.Features;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GenerationN.Features.StaticData;
using GenerationN.Features.GetEndings;

namespace GenerationN.GetEndings
{
    public class GetAdjectiveEndings : IParent
    {
        private Dictionary<string, string> Dict;
        private string strKey { get; set; }
        private string strValue { get; set; }

        private string word;
        public GetAdjectiveEndings(string word)
        {
            Dict = new Dictionary<string, string>();
            this.word = word;
        }

        public void CalculationEndings(int i)
        {
            this.strKey = "";
            this.strValue = "";
            int mode = 0;
            switch (i)
            {
                case 0:
                    foreach (KeyValuePair<string, string> kvp in AdjEndings.AdjEndsOnePre)
                    {
                        mode = 0;
                        KeyValue(kvp.Key, kvp.Value,mode);
                    }
                    break;
                case 1:
                    foreach (KeyValuePair<string, string> kvp in AdjEndings.AdjEndsOne)
                    {
                        mode = 1;
                        KeyValue(kvp.Key, kvp.Value,mode);
                    }
                    break;
                case 2:
                    foreach (KeyValuePair<string, string> kvp in AdjEndings.AdjEndsTwo)
                    {
                        mode = 1;
                        KeyValue(kvp.Key, kvp.Value,mode);
                    }
                    break;
                case 3:
                    foreach (KeyValuePair<string, string> kvp in AdjEndings.AdjEndsThree)
                    {
                        mode = 1;
                        KeyValue(kvp.Key, kvp.Value,mode);
                    }
                    break;
                default:
                    break;
            }

            if (string.IsNullOrEmpty(this.strKey) == false)
            {
                Dict.Add(this.strKey, this.strValue);
                
                this.word = (mode == 0) ? this.word.Remove(0, this.strKey.Length) : 
                    this.word.Remove(this.word.Length - this.strKey.Length);
            }
        }
        public Dictionary<string, string> GettingEndings()
        {
            Console.WriteLine("Adjective: "+this.word);
            for (int i = 3; i >= 0; i--)
            {
                CalculationEndings(i);
            }
            Dict.Add(this.word, "Основа слова");

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

    }
}
