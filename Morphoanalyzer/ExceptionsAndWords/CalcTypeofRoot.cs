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
                        1 => $"{StaticData.StaticString.MainString} (существительное)",
                        2 => $"{StaticData.StaticString.MainString} (существительное)",
                        3 => $"{StaticData.StaticString.MainString} (существительное)",
                        4 => $"{StaticData.StaticString.MainString} (существительное)",
                        5 => $"{StaticData.StaticString.MainString} (существительное)",
                        _ => $"{StaticData.StaticString.MainString} (разные части речи)",
                    };
                case 2:
                    return i switch
                    {
                        1 => $"{StaticData.StaticString.MainString} (существительное)",
                        2 => $"{StaticData.StaticString.MainString} (разные части речи)",
                        3 => $"{StaticData.StaticString.MainString} (сумма существительных или существительное)",
                        4 => $"{StaticData.StaticString.MainString} (сумма прилагательного и существительного)",
                        5 => $"{StaticData.StaticString.MainString} (сумма глагола, существительного и наречия)",
                        6 => $"{StaticData.StaticString.MainString} (существительное)",
                        7 => $"{StaticData.StaticString.MainString} (глагол)",
                        _ => $"{StaticData.StaticString.MainString} (прилагательное)",
                    };
                default: return $"{StaticData.StaticString.MainString} не известна";
            }
           
        }
    }
}
