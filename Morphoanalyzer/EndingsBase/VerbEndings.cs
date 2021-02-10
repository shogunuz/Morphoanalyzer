using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Morphoanalyzer.EndingsBase
{
    public class VerbEndings
    {
        private static readonly string personal_affix_singular =
        "It is personnal affix of singular form, which is added after consonant or vowel";
        private static readonly string personal_affix_plural =
        "It is personnal affix of plural form, which is added after consonant or vowel";

        private static readonly string pc_affix =
        "It is present-continuous affix, which is added after (root) verb";

        private static readonly string pt_affix =
       "It is Past tense affix, which is added after (root) verb";

        public Dictionary<int, Dictionary<string, string>> Dict;

        public VerbEndings()
        {
            Dict = new Dictionary<int, Dictionary<string, string>>
            {
                {1, new Dictionary<string, string>(verb_end_pf)},
                {2, new Dictionary<string, string>(verb_end_pс)},
                {3, new Dictionary<string, string>(verb_end_pt)}
            };
        }

        //Present-Future tense verbs' endings. (both singular and plural)
        private static readonly Dictionary<string, string> verb_end_pf
            = new Dictionary<string, string>()
        {
            {"man", $"{personal_affix_singular} yashay+man, o'rgana+man" },
            {"san", $"{personal_affix_singular} yashay+san, o'rgana+san" },
            {"di", $"{personal_affix_singular} yashay+di, o'rgana+di" },
            {"miz", $"{personal_affix_plural} yashay+miz, o'rgana+miz" },
            {"siz", $"{personal_affix_plural} yashay+siz, o'rgana+siz" },
            {"dilar", $"{personal_affix_plural} yashay+dilar, o'rgana+dilar" }
        };

        //Present-continuous  tense verbs' endings. (both singular and plural)
        private static readonly Dictionary<string, string> verb_end_pс
            = new Dictionary<string, string>()
        {
            {"yap", $"{pc_affix} yasha+yap+man, o'rgan+yap+man" },
            {"moqda", $"{pc_affix} yasha+moqda+man, o'rgan+moqda+san" },
            {"yo'tir", $"{pc_affix} yasha+yo'tir+man, o'rgan+yo'tir+miz" }
        };

        //Past-tense  tense verbs' endings. (both singular and plural)
        private static readonly Dictionary<string, string> verb_end_pt
            = new Dictionary<string, string>()
        {
            {"dim", $"{pt_affix} ishla+di+m" },
            {"ding", $"{pt_affix} ishla+di+ng" },
            {"dik", $"{pt_affix} ishla+dik" },
            {"dingiz", $"{pt_affix} ishla+di+ngiz" },
            {"dilar", $"{pt_affix} ishla+di+lar" }
        };
    }
}
