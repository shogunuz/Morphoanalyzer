using GenerationN.GetEndings;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GenerationN.Features
{
  
    public class GetEndingsFromDB
    {
        public Dictionary<string, string> EndingDictionary { get; set; }
        public IParent Parent { get; set; }

        public GetEndingsFromDB(IParent parent)
        {
            this.Parent = parent;
        }

        public string ReverseString(string word)
        {
            return Parent.ReverseString(word);
        }

        public Dictionary<string, string> GettingEndings()
        {
            return Parent.GettingEndings();
        }

        public string CalculationEndings(string reversedWord)
        {
            return Parent.CalculationEndings(reversedWord);
        }

    }
}
