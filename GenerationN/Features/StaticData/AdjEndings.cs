using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GenerationN.Features.StaticData
{
    public class AdjEndings
    {
        private static string mainString = "Окончания, формирующие прилагательные из существительных";
        internal static Dictionary<string, string> AdjEndsOne = new Dictionary<string, string>()
        {
            {"li", $"{mainString} rasmli (kitob), kuchli (shamol)" },
            {"lik", $"{mainString} toshkеntlik (bola), ko’ylaklik(chit), bolalik(chog’lar) " },
            {"siz", $"{mainString} tuzsiz (ovqat)"},
            {"iy", $"{mainString} dеvoriy (gazeta)"},
            {"viy", $"{mainString} tarbiyaviy (soat)"},
            {"gi", $"{mainString} bahorgi (ishlar)"},
            {"ki", $"{mainString} qishki (kiyim)"},
            {"qi", $"{mainString} qishki (kiyim)"},
            {"aki", $"{mainString} jizzaki, jirttaki" },
            {"oqi", $"{mainString} pistoqi" },
            {"yi", $"{mainString} havoyi" },
            {"chan", $"{mainString} ishchan bola" },
            {"simon", $"{mainString} odamsimon maymun" },
            {"dor", $"{mainString} aybdor, vafodor" },
            {"kor", $"{mainString} isyonkor, zulmkor" },
            {"gar", $"{mainString} javobgar, ig’vogar" },
            {"i", $"{mainString} qishloqi, qozoqi" },
            {"cha", $"{mainString} farg’onacha, erkakcha" },
            {"namo", $"{mainString} avliyonamo, darvеshnamo" },
            {"parvar", $"{mainString} xalqparvar, adolatparvar" },
            {"on", $"{mainString} charohon, za'faron " },
            {"shumul", $"{mainString} olamshumul, jahonshumul" },
            {"mand", $"{mainString} kasalmand, davlatmand" },
            {"don", $"{mainString} gapdon, bilimdon" },
            {"kash", $"{mainString} dilkash, hazilkash, zahmatkash(odam)" },
            {"bop", $"{mainString} palovbop, qishbop" },
            {"in", $"{mainString} erkin, otashin" },
            {"vor", $"{mainString} dеvonavor, afsonavor" },
            {"parast", $"{mainString} mansabparast, maishatparast" },
            {"chil", $"{mainString} xalqchil, izchil" },
            {"loq", $"{mainString} baqaloq, qo’shaloq (g’o’za) " },
            {"chi", $"{mainString} gapchi(odam), vahimachi(ayol)" },
            {"von", $"{mainString} zo’ravon(odam)" },
            {"qa", $"{mainString} loyqa(suv)" },
            {"omuz", $"{mainString} hazilomuz(gap), zaharomuz(hazil)" },
            {"xo’r", $"{mainString} g’amxo’r(odam), go’shtxo’r(hayvon)" },
            {"soz", $"{mainString} soatsoz(usta)" },
            {"dek", $"{mainString} muzdеk(suv), jo’jabirday(jon)" }
           // {"qa", $"{mainString} " },
        };

        internal static Dictionary<string, string> AdjEndsTwo = new Dictionary<string, string>()
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

        internal static Dictionary<string, string> AdjEndsThree = new Dictionary<string, string>()
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
