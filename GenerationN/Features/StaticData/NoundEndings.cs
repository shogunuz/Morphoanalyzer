using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GenerationN.Features.StaticData
{
    public class NoundEndings
    {
        //Nouns plural forms
        internal static Dictionary<string, string> NPOne = new Dictionary<string, string>()
        {
            {"lar","Окончание множественного числа (существительное)" }
        };

        //Nouns 1s face
        //nounFirstfaceVowelSingularform
        internal static Dictionary<string, string> NFVS = new Dictionary<string, string>()
        {
            {"m","1-ое лицо, гласные окончания, ед. число bola-m" }
        };
        //nounFirstfaceConsonantSingularForm
        internal static Dictionary<string, string> NFCS = new Dictionary<string, string>()
        {
            {"im","1 -ое лицо, согласные окончания, ед. число bolalar-im, kitob-im" }
        };
        //nounFirstfaceVowelPluralform
        internal static Dictionary<string, string> NFVP = new Dictionary<string, string>()
        {
            {"miz","1-ое лицо, гласные окончания, мн. число bola-miz, dala-miz" }
        };
        //nounFirstfaceConsonantPluralform
        internal static Dictionary<string, string> NFCP = new Dictionary<string, string>()
        {
            {"imiz","1-ое лицо, согласные окончания, мн. число bolalar-imiz, kitob-imiz" }
        };

        //Nouns 2nd face
        //nounSecondfaceVowelSingularlform
        internal static Dictionary<string, string> NSVS = new Dictionary<string, string>()
        {
            {"ng","2-ое лицо, гласные окончания, ед. число bola-ng, dala-ng" }
        };
        //nounSecondfaceConsonantSingularlform
        internal static Dictionary<string, string> NSCS = new Dictionary<string, string>()
        {
            {"ing","2-ое лицо, согласные окончания, ед. число uy-ing, kitob-ing" }
        };
        //nounSecondfaceVowelPluralform
        internal static Dictionary<string, string> NSVP = new Dictionary<string, string>()
        {
            {"ngiz","2-ое лицо, гласные окончания, мн. число bola-ngiz, dala-ngiz" }
        };
        //nounSecondfaceConsonantPluralform
        internal static Dictionary<string, string> NSCP = new Dictionary<string, string>()
        {
            {"ingiz","2-ое лицо, согласные окончания, мн. число uy-ingiz, kitob-ingiz" }
        };

        //Nouns 3rd face
        //nounThirdfaceVowelSingularPluralform
        internal static Dictionary<string, string> NTVSP = new Dictionary<string, string>()
        {
            {"si","3-ое лицо, гласные окончания, ед. число bola-si, dala-si" }
        };
        //nounThirdfaceConsonantSingularPluralform
        internal static Dictionary<string, string> NTCSP = new Dictionary<string, string>()
        {
            {"i","3-ое лицо, гласные согласные окончания, ед. число uy-i, kitob-i" }
        };


        //Падежные окончания
        //NounNominativeCase
        internal static Dictionary<string, string> NNC = new Dictionary<string, string>()
        {
            {"ss","Именительный падеж(кто? что?) не имеет окончания bola, kitob" }
        };
        //NounGenitiveCase
        internal static Dictionary<string, string> NGC = new Dictionary<string, string>()
        {
            {"ning","Родительный падеж(Чья? Чей?), bolaning, kitobning" }
        };
        //NounАccusativeCase
        internal static Dictionary<string, string> NAccC = new Dictionary<string, string>()
        {
            {"ni","Винительный падеж(Кого? Чего?), bolani, kitobni" }
        };
        /*
        //NounАccusativeCase
        internal static Dictionary<string, string> NAC = new Dictionary<string, string>()
        {
            {"ni","Винительный падеж(Кого? Чего?), bolani, kitobni" }
        };*/
        //NounDativeCase1
        internal static Dictionary<string, string> NDCOne = new Dictionary<string, string>()
        {
            {"ga","Дательно-направительный падеж(Кому? Чему? Почему? Куда?), bolaga, kitobga" }
        }; 
        //NounDativeCase2
        internal static Dictionary<string, string> NDCTwo = new Dictionary<string, string>()
        {
            {"ka","Дательно-направительный падеж(Кому? Чему? Почему? Куда?), kokrakka, teshikka" }
        };
        //NounDativeCase3
        internal static Dictionary<string, string> NDCThird= new Dictionary<string, string>()
        {
            {"qa","Дательно-направительный падеж(Кому? Чему? Почему? Куда?), toqqa, boqqa" }
        };
        //NounDativeCase4
        internal static Dictionary<string, string> NDCFour = new Dictionary<string, string>()
        {
            {"na","Дательно-направительный падеж(Кому? Чему? Почему? Куда?), bolaga, kitobga" }
        };
        /*
        //NounDativeCase5
        internal static Dictionary<string, string> NDCFour = new Dictionary<string, string>()
        {
            {"a","Дательно-направительный падеж(Кому? Чему? Почему? Куда?), bolaga, kitobga" }
        };*/
        //NounLocativeCase
        internal static Dictionary<string, string> NLC = new Dictionary<string, string>()
        {
            {"da","Дательно-направительный падеж(У кого? В чем? На чем?), bolada, mahallada" }
        };
        //NounAblativveCase
        internal static Dictionary<string, string> NAbC = new Dictionary<string, string>()
        {
            {"da","Дательно-направительный падеж(У кого? В чем? На чем?), bolada, mahallada" }
        };
    }
}
