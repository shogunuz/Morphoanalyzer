using GenerationN.GetEndings;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GenerationN.Features
{
  
    public class GetEndingsGeneral
    {
        public Dictionary<string, string> EndingDictionary { get; set; }
        public IParent Parent { get; set; }

        public GetEndingsGeneral(IParent parent)
        {
            this.Parent = parent;
        }

        public Dictionary<string, string> GettingEndings()
        {
            return Parent.GettingEndings();
        }

        public void CalculationEndings(int i)
        {
            Parent.CalculationEndings(i);
        }

        public void KeyValue(string key, string value, int mode) 
        {
            Parent.KeyValue(key, value, mode);
        }

    }
}
