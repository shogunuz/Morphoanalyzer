using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GenerationN.GetEndings
{
    public interface IGetEndings
    {
        Dictionary<string, string> GetEndings();
        void KeyValue(string key, string value, int mode);

        
    }
}
