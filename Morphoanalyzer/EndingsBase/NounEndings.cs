using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

/*
 * Author: N. Abdurakhmonova, 
 * Assistant: D.Mengliev
 * Year: 2020
 * Description: This class contains Noun endings for stemming
 * Описание: Данный класс содержит окончания существительных для стемминга
 */

namespace Morphoanalyzer.EndingsBase
{
    public class NounEndings
    {

        public Dictionary<int, Dictionary<string, string>> Dict;
        public static string personsEndings = "Окончание, формирующее  существительное - личность"; 
        public static string objectEndings = "Окончание, формирующее существительное - предмет или объект";

        public NounEndings()
        {
            Dict = new Dictionary<int, Dictionary<string, string>>
           {
                {1, new Dictionary<string, string>(NounEndsOnePre)},
                {2, new Dictionary<string, string>(NounEndsOne)},
                {3, new Dictionary<string, string>(NounEndsTwo)},
                {4, new Dictionary<string, string>(NounEndsThree)}
           };
        }

        private static readonly Dictionary<string, string> NounEndsOnePre = new Dictionary<string, string>()
        {
            {"ham",$"{personsEndings} (hamsuhbat, hamyurt)" }
        };

        private static readonly Dictionary<string, string> NounEndsOne = new Dictionary<string, string>()
        {
            //Shaxs oti yasovchi qo'shimbchalar
            //Окончания, формирующие существительные личности
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
            {"paz",$"{personsEndings} (oshpar, mantipaz)" },
            {"xon",$"{personsEndings} (gazetxon, kitobxon)" },
            {"shunos",$"{personsEndings} (tilshunos, zarshunos)" },
            {"do'z",$"{personsEndings} (gilamdo'z, etikdo'z)" },
            {"soz",$"{personsEndings} (soatsoz, aravasoz)" },
            {"xo'r",$"{personsEndings} (choyxo'r, qimizxo'r)" },
            {"parast",$"{personsEndings} (shaxsiyatparast, amalparast)" },
            {"go'y",$"{personsEndings} (duogo'y)" },
            {"furush",$"{personsEndings} (mevafurush, chitfurush)" },
            {"vachcha",$"{personsEndings} (tog'avachcha, amakivachcha)" },
            {"uvchi",$"{personsEndings} (yozuvchi, uchuvchi)" },
            {"ovchi",$"{personsEndings} (tinglovchi)" },
            {"sil",$"{personsEndings} (yo'qsil (arxaiklashgan))" },

            //Narsa-buyum otlari yasovchi qo'shimchalar
            //окончания, формирующие предмет или объект
            {"gich",$"{objectEndings} (purkagich)" },
            {"kich",$"{objectEndings} (ko'rsatkich)" },
            {"qich",$"{objectEndings} (qisqich)" },
            {"g'ich",$"{objectEndings} (chizg'ich)" },


            {"lar","Окончание множественного числа (существительное)" } 
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
