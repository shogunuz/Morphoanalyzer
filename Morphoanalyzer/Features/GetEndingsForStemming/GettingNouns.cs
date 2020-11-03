
using System;
using System.Collections.Generic;
using System.Linq;
using GenerationN.Features.StaticData;
using GenerationN.Features.GetEndings;
using GenerationN.Features;

/*
 * Developers: N. Abdurakhmonova, D.Mengliev
 * Year: 2020
 */
namespace GenerationN.GetEndings
{
    public class GettingNouns : IGetEndings
    {
        private string strKey { get; set; }
        private string strValue { get; set; }

        private string word;

        private NounEndings nounEndings;

        private Dictionary<string, string> tmpDict;

        public GettingNouns(string word)
        {
            this.word = word;
            nounEndings = new NounEndings();
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

                if(cnt <= 1)
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

                int mode = 1;
                //Данный счётчик нужен для того, чтобы определить, было ли добавлено 
                //окончание существительного
                int processed = 0;

                string mainString = string.Empty;

                for (int i = nounEndings.Dict.Count; i > 0; i--)
                {
                    this.strKey = string.Empty;
                    this.strValue = string.Empty;
                    string key = string.Empty;
                    string value = string.Empty;


                    if (i == 1)
                    {
                        mode = 0;
                    }

                    foreach (KeyValuePair<string, string> kvp in nounEndings.Dict[i])
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

                if (processed > 0)
                {
                    Dict.Add(this.word, mainString);
                }

                return Dict;
            }
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
