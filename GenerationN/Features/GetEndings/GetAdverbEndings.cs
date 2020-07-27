using GenerationN.Features;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GenerationN.GetEndings
{
    public class GetAdverbEndings : GetEndingsFromDB
    {

        internal override void AnalyzingWord(string str)
        {
            Console.WriteLine($"Adverb class: {str}");
        }
    }
}
