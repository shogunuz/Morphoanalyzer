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

            string mainString = string.Empty;

            for (int i = 7; i > 0; i--)
            {
                MakeAllVariablesToEmpty();

                foreach (KeyValuePair<string, string> kvp in ad.Dict[i])
                {
                    if(i == 1) { this.mode = 0; }
                    KeyValue(kvp.Key, kvp.Value, mode);
                }

                if (string.IsNullOrEmpty(this.strKey) == false)
                {
                    processed++;
                    Dict.Add(this.strKey, this.strValue);
                    mainString = TypeOfMainWord(i);
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

            if(processed > 0)
            {
                Dict.Add(this.word, mainString);
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
