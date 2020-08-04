using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GenerationN.GetEndings
{
    public interface IParent
    {

       
        void CalculationEndings(int i);
        Dictionary<string, string> GettingEndings();
        void KeyValue(string key, string value, int mode);
    }
}
