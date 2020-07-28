using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GenerationN.GetEndings
{
    public interface IParent
    {

        // string ReverseString(string word);
        Dictionary<string, string> CalculationEndings(int i);
        Dictionary<string, string> GettingEndings();
    }
}
