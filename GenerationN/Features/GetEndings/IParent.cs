using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GenerationN.GetEndings
{
    public interface IParent
    {
      
       // string ReverseString(string word);
        string CalculationEndings();
        Dictionary<string, string> GettingEndings();
    }
}
