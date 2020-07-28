using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GenerationN.Features.StaticData
{
    public class NoundEndings
    {
        internal static Dictionary<string, string> NounEndsOne = new Dictionary<string, string>()
        {
        {"lar","Окончание множественного числа (существительное)" }
        };

        internal static Dictionary<string, string> NounEndsTwo = new Dictionary<string, string>()
       {
            {"m","1-ое лицо, гласные окончания, ед. число bola-m"},
            {"im","1 -ое лицо, согласные окончания, ед. число bolalar-im, kitob-im"},
            {"miz","1-ое лицо, гласные окончания, мн. число bola-miz, dala-miz" },
            {"imiz","1-ое лицо, согласные окончания, мн. число bolalar-imiz, kitob-imiz" },
            {"ng","2-ое лицо, гласные окончания, ед. число bola-ng, dala-ng" },
            {"ing","2-ое лицо, согласные окончания, ед. число uy-ing, kitob-ing" },
            {"ngiz","2-ое лицо, гласные окончания, мн. число bola-ngiz, dala-ngiz" },
            {"ingiz","2-ое лицо, согласные окончания, мн. число uy-ingiz, kitob-ingiz" },
            {"si","3-ое лицо, гласные окончания, ед. число bola-si, dala-si" },
            {"i","3-ое лицо, гласные согласные окончания, ед. число uy-i, kitob-i" },
           };

        internal static Dictionary<string, string> NounEndsThree = new Dictionary<string, string>()
            {
             {"ss","Именительный падеж(кто? что?) не имеет окончания bola, kitob" },
            {"ning","Родительный падеж(Чья? Чей?), bolaning, kitobning" },
            {"ni","Винительный падеж(Кого? Чего?), bolani, kitobni" },
            {"ga","Дательно-направительный падеж(Кому? Чему? Почему? Куда?), bolaga, kitobga" },
            {"ka","Дательно-направительный падеж(Кому? Чему? Почему? Куда?), kokrakka, teshikka" },
            {"qa","Дательно-направительный падеж(Кому? Чему? Почему? Куда?), toqqa, boqqa" },
            {"na","Дательно-направительный падеж(Кому? Чему? Почему? Куда?), bolaga, kitobga" },
            {"da","Дательно-направительный падеж(У кого? В чем? На чем?), bolada, mahallada" }
        
            };



}
}
