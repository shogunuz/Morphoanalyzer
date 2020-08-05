using GenerationN.GetEndings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GenerationN.StaticData;

namespace GenerationN.Features
{
    public class GettingEndings
    {
        public Dictionary<string, string> GetResult(string word)
        {
            Dictionary<string, string>[] resultDictionary = new Dictionary<string, string>[2];

            Dictionary<string, string> InnerDict;

            List<int> numbers = new List<int>();

            GetEndingsGeneral[] getEnds = new GetEndingsGeneral[2];
            getEnds[0] = new GetEndingsGeneral(new GettingNouns(word));
            getEnds[1] = new GetEndingsGeneral(new GettingAdjectives(word));

            for (int i = 0; i < getEnds.Length; i++)
            {
                InnerDict = new Dictionary<string, string>();
                foreach (KeyValuePair<string, string> kvp in getEnds[i].GetEndings())
                {
                    InnerDict.Add(kvp.Key, kvp.Value);
                }
                //oyinchiq / kelinchak
                resultDictionary[i] = new Dictionary<string, string>(InnerDict);
                numbers.Add(InnerDict.Count);
            }

            // Получаю индекс словаря, который содержит больше всего окончаний.
            int t = numbers.IndexOf(numbers.Max<int>());

            if(resultDictionary[t].Count == 0)
            {
                resultDictionary[t] = new Dictionary<string, string>
                {
                    {$"{word}", StaticString.CheckCorrectnessWord}
                };
            }

            return resultDictionary[t];
        }

       
    }
}
