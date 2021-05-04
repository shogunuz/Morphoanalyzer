
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Morphoanalyzer.EndingsBase;
using Morphoanalyzer.ExceptionsAndWords;
using Morphoanalyzer.Exceptions;


namespace Morphoanalyzer.CalcEndingsByStemming
{
    public class CalcVerbEndings : CalcEndingsGeneral, IGetEndings
    {

        private string word;
        private string Originword;
       
        private readonly VerbEndings verbEndings;
        private ExceptionVerbs exVerbs;
        public CalcVerbEndings(string word)
        {
            this.word = word;
            this.Originword = new string(word);
            verbEndings = new VerbEndings();
            TmpDict = new Dictionary<string, string>();
            exVerbs = new ExceptionVerbs();
            ExceptionDict = new Dictionary<string,Dictionary<string, string>>(exVerbs.Dict);
        }
        private static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
        public Dictionary<string, string> GetEndings()
        {
            bool res = SearchWordFromExSet(this.word);
            if (res)
            {
                CalcEndingsGeneral.exceptionWordInt = 3;//for verb this is 3
                return this.TmpDict;
            }
            else
            {
                NewCalc newCalc = new NewCalc();
                Dictionary<string, string> Dict = new Dictionary<string, string>(newCalc.CalcRoot(this.word));


                //Здем мы получаем размер корня слова
                int rootWordSize = newCalc.foundKey.Length;
                if (rootWordSize < this.word.Length)
                {
                    this.word = Reverse(this.word);
                    this.word = this.word.Remove(this.word.Length - rootWordSize);
                    this.word = Reverse(this.word);

                    string tmpV = "1", tmpK = "1";
                    string[] listOfKeys = verbEndings.Dict.Keys.ToArray();
                    string[] listOfValues = verbEndings.Dict.Values.ToArray();
                    bool reska = false;
                    for (int x = 1; x <= 3; x++)
                    {
                        if (this.word.Length == 0)
                        {
                            break;
                        }
                        if (this.word.Length == 1) 
                        { 
                            Dict.Add(this.word, " additional ending");
                            break;
                        }
                        for (int i = 2; i <= this.word.Length; i++)
                        {
                            string tmpStr = (i == word.Length) ? word : word.Remove(i);
                            int k = Array.BinarySearch(listOfKeys, tmpStr);
                            if (k >= 0)
                            {
                                if (tmpK.Length < listOfKeys[k].Length)
                                {
                                    tmpK = listOfKeys[k];
                                    tmpV = listOfValues[k];
                                    reska = true;
                                }
                            }
                        }
                        if (reska)
                        {
                            Dict.Add(tmpK, tmpV);
                            int ws = tmpK.Length;
                            this.word = Reverse(this.word);
                            this.word = this.word.Remove(this.word.Length - ws);
                            this.word = Reverse(this.word);
                            reska = false;
                            GetEndingsParent.ResultNumber += 1;
                        }
                        else 
                        {
                            tmpK = this.word;
                            tmpV = "System could not analyze endings for this word";
                            Dict.Add(tmpK, tmpV);
                            break;
                        }
                    }
                }

                // Dict.Add(newCalc.foundKey, newCalc.foundValue);
                // int sch = 0;
                /*while (sch < 3)
                {
                    if (this.word.Length > 1)
                    {
                        Dictionary<string, string> InnerDict = new Dictionary<string, string>(newCalc.CalcEndings(this.word));
                        foreach (KeyValuePair<string, string> kvp in InnerDict)
                        {
                            Dict.Add(kvp.Key, kvp.Value);
                            this.word = this.word.Remove(0, newCalc.foundKey.Length);
                        }
                    }
                    else
                    {
                        sch = 100;
                    }
                }*/
                Dict.Add($"Your word - {this.Originword}", " belongs to verb");
                return Dict;
            }
        }
    }
}
