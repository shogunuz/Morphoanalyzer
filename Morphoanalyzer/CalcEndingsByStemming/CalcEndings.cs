
using System;
using System.Collections.Generic;
using System.Linq;
using Morphoanalyzer.StaticData;


namespace Morphoanalyzer.CalcEndingsByStemming
{
    public class CalcEndings
    {
        public Dictionary<string, string> GetResult(string word)
        {
            Dictionary<string, string>[] resultDictionary = new Dictionary<string, string>[2];

            Dictionary<string, string> InnerDict;

            List<int> numbers = new List<int>();

            GetEndingsGeneral[] getEnds = new GetEndingsGeneral[4];
            getEnds[0] = new GetEndingsGeneral(new CalcNounEndings(word));
            getEnds[1] = new GetEndingsGeneral(new CalcAdjEndings(word));
            getEnds[2] = new GetEndingsGeneral(new CalcVerbEndings(word));
            getEnds[3] = new GetEndingsGeneral(new CalcAdvEndings(word));

           
            for (int i = 0; i < getEnds.Length; i++)
            {
                InnerDict = new Dictionary<string, string>();
                foreach (KeyValuePair<string, string> kvp in getEnds[i].GetEndings())
                {
                    InnerDict.Add(kvp.Key, kvp.Value);
                } 
                resultDictionary[i] = new Dictionary<string, string>(InnerDict);
                numbers.Add(InnerDict.Count);
            }

            // Получаю индекс словаря, который содержит больше всего окончаний.
            int t = numbers.IndexOf(numbers.Max<int>());


            //Проверяю, есть ли вообще хоть что-то в словаре, если словарь пуст,
            //то заполняю просто дефолтным значением
            if(resultDictionary[t].Count == 0)
            {
                resultDictionary[t] = new Dictionary<string, string>
                {
                    {$"{word}", StaticString.RootWord}
                };
            }

            //I am checking if the system find out exception word or not
            //if it found, then, it will return found word
            return CalcEndingsGeneral.exceptionWordInt switch
            {
                1 => resultDictionary[0], //1 is Noun
                2 => resultDictionary[1], //2 is Adjective
                3 => resultDictionary[2], //3 is Verbs
                4 => resultDictionary[3], //4 is Adverbs
                _ => resultDictionary[t], // OR it's noun\adj
            };
        }

       
    }
}
