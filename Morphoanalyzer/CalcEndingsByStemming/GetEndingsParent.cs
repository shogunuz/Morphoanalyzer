
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.SignalR;
using Morphoanalyzer.CalcEndingsByStemming;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Morphoanalyzer.CalcEndingsByStemming
{
  
    public class GetEndingsParent
    {
        
        public IGetEndings Parent { get; set; }

        public GetEndingsParent(IGetEndings parent)
        {
            this.Parent = parent;
        }

        public Dictionary<string, string> GetEndings()
        {
            return Parent.GetEndings();
        }

      


    }
}
