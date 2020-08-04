using GenerationN.GetEndings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GenerationN.Features
{
    public class GettingEndings
    {
        public Dictionary<string, string> GetResult(string word)
        {
            Dictionary<string, string>[] dicts = 
                new Dictionary<string, string>[2];

            Dictionary<string, string> Innerdict = new Dictionary<string, string>();

            List<int> numbers = new List<int>();

            GetEndingsGeneral[] getEnds = new GetEndingsGeneral[2];
            getEnds[0] = new GetEndingsGeneral(new GettingNouns(word));
            getEnds[1] = new GetEndingsGeneral(new GettingAdjectives(word));

            int k = 0;

            for (int i = 0; i < getEnds.Length; i++)
            {
                foreach (KeyValuePair<string, string> kvp in getEnds[i].GetEndings())
                {
                    Innerdict.Add(kvp.Key, kvp.Value);
                }
                dicts[i] = new Dictionary<string, string>(Innerdict);
                numbers.Add(Innerdict.Count);
            }
            int t = numbers.Max<int>();
            t = numbers.IndexOf(t);

            return dicts[t];
        }

       
    }
}
