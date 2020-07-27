using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GenerationN.Features.StaticData
{
    public class NounEndArray
    {
        //Окончания ед и мн числа
        internal static Dictionary<int, Dictionary<string,string>> NounEndingsFirst = 
            new Dictionary<int, Dictionary<string, string>>()
            {
                { 1, NoundEndings.NPOne }
             };

        //Притяжательные окончания 
        internal static Dictionary<int, Dictionary<string, string>> NounEndingsSecond =
            new Dictionary<int, Dictionary<string, string>>()
        {
            {1, NoundEndings.NFVS },
            {2, NoundEndings.NFCS },
            {3, NoundEndings.NFVP },
            {4, NoundEndings.NFCP },
            {5, NoundEndings.NSVS },
            {6, NoundEndings.NSVP },
            {7, NoundEndings.NTVSP },
            {8, NoundEndings.NTCSP }
        };

        //Окончания для 6-ти падежей
        internal static Dictionary<int, Dictionary<string, string>> NounEndingsThird =
            new Dictionary<int, Dictionary<string, string>>()
        {
            {1, NoundEndings.NNC },
            {2, NoundEndings.NGC },
            {3, NoundEndings.NAccC },
            {4, NoundEndings.NDCOne },
            {5, NoundEndings.NDCTwo },
            {6, NoundEndings.NDCThird },
            {7, NoundEndings.NDCFour },
            {8, NoundEndings.NLC },
            {9, NoundEndings.NAbC }
        };

    }
}
