using GenerationN.Features;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GenerationN.EndingsBase;
using GenerationN.CalcEndingsByStemming;

namespace GenerationN.GetEndings
{
    public class CalcAdjEndings : IGetEndings
    {
        private Dictionary<string, string> Dict;
        private string strKey { get; set; }
        private string strValue { get; set; }

        private string word;

        AdjEndings ad;

        public CalcAdjEndings(string word)
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
            int mode = 1;
            string mainString = string.Empty;

            for (int i = 7; i > 0; i--)
            {
                this.strKey = string.Empty;
                this.strValue = string.Empty;
                string key = string.Empty;
                string value = string.Empty;

                if (i == 1) { mode = 0; }

                foreach (KeyValuePair<string, string> kvp in ad.Dict[i])
                {
                    KeyValue(kvp.Key, kvp.Value, mode);
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
                    mainString = TypeOfMainWord(i);
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
                Dict.Add(this.word, mainString);
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

        

        private string TypeOfMainWord(int i) 
        {
            string tmp = string.Empty;
            switch(i)
            {
                case 1:
                    tmp =  $"{StaticData.StaticString.MainString} (существительное)";
                    break;
                case 2:
                    tmp = $"{StaticData.StaticString.MainString} (разные части речи)";
                    break;
                case 3:
                    tmp = $"{StaticData.StaticString.MainString} (сумма существительных или существительное)";
                    break;
                case 4:
                    tmp = $"{StaticData.StaticString.MainString} (сумма прилагательного и существительного)";
                    break;
                case 5:
                    tmp = $"{StaticData.StaticString.MainString} (сумма глагола, существительного и наречия)";
                    break;
                case 6:
                    tmp = $"{StaticData.StaticString.MainString} (существительное)";
                    break;
                case 7:
                    tmp = $"{StaticData.StaticString.MainString} (глагол)";
                    break;
                default: return $"{StaticData.StaticString.MainString} (прилагательное)";
            }

            return tmp;
        }
    }
}
