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
        
        public IGetEndings Parent { get; set; }

        public GetEndingsGeneral(IGetEndings parent)
        {
            this.Parent = parent;
        }

        public Dictionary<string, string> GetEndings()
        {
            return Parent.GetEndings();
        }

        public void KeyValue(string key, string value, int mode) 
        {
            Parent.KeyValue(key, value, mode);
        }


        public void MakeAllVariablesToEmpty()
        {
            Parent.MakeAllVariablesToEmpty();
        }

    }
}
