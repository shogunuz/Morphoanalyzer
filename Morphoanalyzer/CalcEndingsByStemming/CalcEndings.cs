
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
            int last_index = word.Length;
            List<int> numberOfElementsInDict = new List<int>();
            Dictionary<string, string>[] InnerDict =
                new Dictionary<string, string>[last_index];
            int k = 0;
            for(int i = last_index-1; i >= 0; i--)
            {
                InnerDict[k] = new Dictionary<string, string>(GetResultPrivate(word.Remove(last_index - k)));
                numberOfElementsInDict.Add(InnerDict[k].Count);
                k++;
            }
            
            //Возвращаем результат если словарь пуст
            //InnerDict["Message"] = StaticString.NotFoundedEng;

            return CalcBiggestDict(InnerDict,numberOfElementsInDict,word);
        }
        private Dictionary<string, string> CalcBiggestDict(
            Dictionary<string, string>[] resultDictionary,
            List<int> numberOfElementsInDict,
            string word)
        {
            // Получаю индекс словаря, который содержит больше всего окончаний.
            int t = numberOfElementsInDict.IndexOf(numberOfElementsInDict.Max<int>());


            //Проверяю, есть ли вообще хоть что-то в словаре, если словарь пуст,
            //то заполняю просто дефолтным значением
            if (resultDictionary[t].Count == 0)
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
        private Dictionary<string, string> GetResultPrivate(string word)
        {

            const int N = 5;

            Dictionary<string, string>[] resultDictionary = 
                new Dictionary<string, string>[N-1];

            Dictionary<string, string> InnerDict;

            List<int> numberOfElementsInDict = new List<int>();
            GetEndingsParent[] getEnds = new GetEndingsParent[N-1];
            getEnds[0] = new GetEndingsParent(new CalcNounEndings(word));
            getEnds[1] = new GetEndingsParent(new CalcAdjEndings(word));
            getEnds[2] = new GetEndingsParent(new CalcVerbEndings(word));
            getEnds[3] = new GetEndingsParent(new CalcAdvEndings(word));

           
            for (int i = 0; i < getEnds.Length; i++)
            {
                InnerDict = new Dictionary<string, string>();
                foreach (KeyValuePair<string, string> kvp in getEnds[i].GetEndings())
                {
                    InnerDict.Add(kvp.Key, kvp.Value);
                } 
                resultDictionary[i] = new Dictionary<string, string>(InnerDict);
                numberOfElementsInDict.Add(InnerDict.Count);
            }

            return CalcBiggestDict(resultDictionary,numberOfElementsInDict,word);
        }

       
    }
}
