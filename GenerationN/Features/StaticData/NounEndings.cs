using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GenerationN.Features.StaticData
{
    public class NounEndings
    {

        public Dictionary<int, Dictionary<string, string>> Dict;
        private static string personsEndings = 
            "Окончания, формирующие существительные - личности";

        public NounEndings()
        {
            Dict = new Dictionary<int, Dictionary<string, string>>
           {
                {1, new Dictionary<string, string>(NounEndsOne)},
                {2, new Dictionary<string, string>(NounEndsTwo)},
                {3, new Dictionary<string, string>(NounEndsThree)}
           };
        }

        private static readonly Dictionary<string, string> NounEndsOne = new Dictionary<string, string>()
        {
            {"lar","Окончание множественного числа (существительное)" },
            {"chi",$"{personsEndings} (suvchi, sportchi)" },
            {"dosh",$"{personsEndings} (sinfdosh, suhbatdosh)" },
            {"kor",$"{personsEndings} (paxtakor)" },
            {"kar",$"{personsEndings} (miskar)" },
            {"gar",$"{personsEndings} (zargar)" },
            {"gor",$"{personsEndings} (talabgor)" },
            {"kash",$"{personsEndings} (aravakash)" },
            {"dor",$"{personsEndings} (amaldor, chorvador)" },
            {"bon",$"{personsEndings}  (darvozabon, saroybon)" },
            {"boz",$"{personsEndings}  (dorboz, askiyaboz)" },
            {"paz",$"{personsEndings} (oshpar, mantipaz)" }
        };

        private static readonly Dictionary<string, string> NounEndsTwo = new Dictionary<string, string>()
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

        private static readonly Dictionary<string, string> NounEndsThree = new Dictionary<string, string>()
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
