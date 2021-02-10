using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Morphoanalyzer.ExceptionsAndWords
{
    public class CalcTypeofRoot
    {
        public static string TypeOfRoot(int i, int c)
        {
            switch (c)
            {
                case 1:
                    return i switch
                    {
                        1 => $"{StaticData.StaticString.RootWord} (noun)",
                        2 => $"{StaticData.StaticString.RootWord} (noun)",
                        3 => $"{StaticData.StaticString.RootWord} (noun)",
                        4 => $"{StaticData.StaticString.RootWord} (noun)",
                        5 => $"{StaticData.StaticString.RootWord} (noun)",
                        _ => $"{StaticData.StaticString.RootWord} (different parts of speech)",
                    };
                case 2:
                    return i switch
                    {
                        1 => $"{StaticData.StaticString.RootWord} (noun)",
                        2 => $"{StaticData.StaticString.RootWord} (different parts of speech)",
                        3 => $"{StaticData.StaticString.RootWord} (sun of nouns)",
                        4 => $"{StaticData.StaticString.RootWord} (sum of noun(s) and adjective(s))",
                        5 => $"{StaticData.StaticString.RootWord} (sum of verb(s), noun(s) and adverb(s))",
                        6 => $"{StaticData.StaticString.RootWord} (noun)",
                        7 => $"{StaticData.StaticString.RootWord} (verb)",
                        _ => $"{StaticData.StaticString.RootWord} (adjective)",
                    };
                default: return $"{StaticData.StaticString.RootWord} unknown";
            }
           
        }
    }
}
