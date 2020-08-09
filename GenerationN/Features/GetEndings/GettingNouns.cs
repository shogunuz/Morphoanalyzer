
using System;
using System.Collections.Generic;
using System.Linq;
using GenerationN.Features.StaticData;
using GenerationN.Features.GetEndings;

namespace GenerationN.GetEndings
{
    public class GettingNouns : IGetEndings
    {
        private string strKey { get; set; }
        private string strValue { get; set; }

        private string word;

        private NounEndings nd;

        
        public GettingNouns(string word)
        {
            this.word = word;
            nd = new NounEndings();
            
        }
      

        public Dictionary<string, string> GetEndings()
        {
            Dictionary<string, string> Dict = new Dictionary<string, string>();

            int mode = 1;
            

            //Данный счётчик нужен для того, чтобы определить, было ли добавлено 
            //окончание существительного
            int processed = 0;

            string mainString = string.Empty;

            for (int i = 4; i > 0; i--)
            {
                this.strKey = string.Empty;
                this.strValue = string.Empty;
                string key = string.Empty;
                string value = string.Empty;


                if (i == 1)
                {
                    mode = 0;
                }

                foreach (KeyValuePair<string, string> kvp in nd.Dict[i])
                {
                    KeyValue(kvp.Key, kvp.Value, mode);
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
                    mainString = TypeOfMainWord(i);
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

            if(processed > 0)
            {
                Dict.Add(this.word, mainString);
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


        private string TypeOfMainWord(int i)
        {
            string tmp = string.Empty;
            switch (i)
            {
                case 0:
                    tmp = $"{StaticData.StaticString.MainString} (существительное)";
                    break;
                case 1:
                    tmp = $"{StaticData.StaticString.MainString} (существительное)";
                    break;
                case 2:
                    tmp = $"{StaticData.StaticString.MainString} (существительное)";
                    break;
                case 3:
                    tmp = $"{StaticData.StaticString.MainString} (существительное)";
                    break;
                case 4:
                    tmp = $"{StaticData.StaticString.MainString} (существительное)";
                    break;
                case 5:
                    tmp = $"{StaticData.StaticString.MainString} (существительное)";
                    break;
                default: return $"{StaticData.StaticString.MainString} (разные части речи)";
            }

            return tmp;
        }
    }
}
