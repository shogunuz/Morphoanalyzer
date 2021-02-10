using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

/*
 * Developers: N. Abdurakhmonova, D.Mengliev
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


            {"lar","Plural ending (noun)" } 
        };
        
        private static readonly Dictionary<string, string> NounEndsTwo = new Dictionary<string, string>()
       {
            {"m","1-ое лицо, гласные окончания, ед. число: bola-m"},
            {"im","1st person, consonant endings, singular: bolalar-im, kitob-im"},
            {"miz","1st person, vowel endings, plural: bola-miz, dala-miz" },
            {"imiz","1st person, consonant endings, plural: bolalar-imiz, kitob-imiz" },
            {"ng","2nd person, vowel endings, singular: bola-ng, dala-ng" },
            {"ing","2-ое лицо, согласные окончания, ед. число uy-ing, kitob-ing" },
            {"ngiz","2nd person, vowel endings, pl. number bola-ngiz, dala-ngiz" },
            {"ingiz","2nd person, consonant endings, plural: uy-ingiz, kitob-ingiz" },
            {"si","3-ое лицо, гласные окончания, ед. число bola-si, dala-si" },
            {"i","3-ое лицо, гласные согласные окончания, ед. число uy-i, kitob-i" },
           };

        private static readonly Dictionary<string, string> NounEndsThree = new Dictionary<string, string>()
            {
                {"ss","Nominative case (who? What?) Has no ending bola, kitob" },
                {"ning","Genitive case (Whose? Whose?), bolaning, kitobning" },
                {"ni","Accusative case (Who? What?), bolani, kitobni" },
                {"ga","Dative-directional case (To whom? What? Why? Where?), bolaga, kitobga" },
                {"ka","Dative-directional case (To whom? What? Why? Where?), kokrakka, teshikka" },
                {"qa","Dative-directional case (To whom? What? Why? Where?), toqqa, boqqa" },
                {"na","Dative-directional case (To whom? What? Why? Where?), bolaga, kitobga" },
                {"da","Dative-directional case (Who? In what? On what?), bolada, mahallada" } 
            };

        
    }
}
