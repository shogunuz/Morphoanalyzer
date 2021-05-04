using Morphoanalyzer.EndingsBase;
using Morphoanalyzer.Exceptions;
using Morphoanalyzer.Features;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Morphoanalyzer.CalcEndingsByStemming
{
    public class NewCalc
    {
        private Dictionary<string, string> Dict { get; set; }
        private VerbRootBase vb;
        public string foundKey { get; set; }
        public string foundValue { get; set; }
        public NewCalc()
        {
            vb = new VerbRootBase();
        }
        public Dictionary<string, string> CalcRoot(string word){
            Dictionary<string, string> TmpDict;
            TmpDict = new Dictionary<string, string>(vb.Dict);
            Dict = new Dictionary<string, string>();
            string tmpK= "1", tmpV = "1";

            string[] listOfKeys = TmpDict.Keys.ToArray();
            string[] listOfValues = TmpDict.Values.ToArray();

            bool reska = false;
            for (int i=2; i<= word.Length; i++)
            {
                string tmpStr = (i == word.Length) ? word : word.Remove(i);
                int k = Array.BinarySearch(listOfKeys, tmpStr);
                if(k >= 0)
                {
                    if (tmpK.Length < listOfKeys[k].Length)
                    {
                        tmpK = listOfKeys[k];
                        tmpV = listOfValues[k];
                        reska = true;
                    }
                }
            }
            if(!reska)
            {
                tmpK = "Not found word";
                tmpV = "System could not analyze your word";
            }
            this.foundKey = tmpK;
            Dict.Add(tmpK, tmpV);
            return Dict;
        }
       /* public Dictionary<string, string> CalcEndings(string word)
        {
            Dictionary<string, string> TmpDict;
            TmpDict = new Dictionary<string, string>(vbe.Dict);
            Dict = new Dictionary<string, string>();
            this.foundKey = "";
            this.foundValue = "";
            bool res = false;
            int t;
            foreach (KeyValuePair<string, string> kvp in TmpDict)
            {
                t = StringDistance.GetDamerauLevenshteinDistance(kvp.Key, word);
                if (t <= 2)
                {
                    if (kvp.Key.Length > foundKey.Length)
                    {
                        foundKey = kvp.Key;
                        foundValue = kvp.Value;
                    }

                }
            }
            if (foundKey.Length <= 1)
            {
                foundValue = "System could not analyze endings of the word";
                foundKey = "Nf";
            }
           
             Dict.Add(this.foundKey, this.foundValue);
            
            return Dict;
        }*/
    }
}
