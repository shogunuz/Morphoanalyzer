
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
        private string strKey { get; set; }
        private string strValue { get; set; }

        private string word;
        public GetNounEndings(string word)
        {
            Dict = new Dictionary<string, string>();
            this.word = word;
        }
      
        public void CalculationEndings(int i)
        {
            this.strKey = "";
            this.strValue="";

            switch (i)
            {
                case 1:
                    foreach (KeyValuePair<string, string> kvp in NounEndings.NounEndsOne)
                    {
                        KeyValue(kvp.Key,  kvp.Value, 1);
                    }
                    break;
                case 2:
                    foreach (KeyValuePair<string, string> kvp in NounEndings.NounEndsTwo)
                    {
                        KeyValue(kvp.Key, kvp.Value, 1);
                    }
                    break;
                case 3:
                    foreach (KeyValuePair<string, string> kvp in NounEndings.NounEndsThree)
                    {
                        KeyValue(kvp.Key, kvp.Value, 1);
                    }
                    break;
                default:
                    break;
            }
            
            if(string.IsNullOrEmpty(this.strKey)==false)
            {
                Dict.Add(this.strKey, this.strValue);
                this.word = this.word.Remove(this.word.Length - this.strKey.Length);
            }
        }
        public Dictionary<string, string> GettingEndings()
        {
            Console.WriteLine("Noun: " + this.word);
            for (int i = 3; i > 0; i--)
            {
                CalculationEndings(i);
            }
            Dict.Add(this.word, "Основа слова");

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

    }
}
