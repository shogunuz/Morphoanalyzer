using System;
using System.Collections.Generic;
using System.Linq;

namespace Morphoanalyzer.EndingsBase
{
    public class VerbEndings
    {
        private static readonly string personal_affix_singular =
        " It is personal affix of singular form, which is added after consonant or vowel";
        private static readonly string personal_affix_plural =
        " It is personal affix of plural form, which is added after consonant or vowel";

        private static readonly string pc_affix =
        " It is present-continuous affix, which is added after (root) verb";

        private static readonly string pt_affix =
       " It is Past tense affix, which is added after (root) verb";

        public Dictionary<string, string> Dict;

        public VerbEndings()
        {
            Dict = new Dictionary<string, string>
            {
                {"man", personal_affix_singular },
                {"san", personal_affix_singular },
                {"di", personal_affix_singular },
                {"miz", personal_affix_plural },
                {"siz", personal_affix_plural },
                {"lar", " plural ending of plural" },
                {"moq", " verb ending" },
                {"yap", pc_affix },
                {"moqda", pc_affix },
                {"yo'tir", pc_affix },
                {"dim", pt_affix },
                {"ding", pt_affix },
                {"dik", pt_affix },
                {"dingiz", pt_affix },
                {"dilar", pt_affix },
                {"may", " negative ending of verb in present and future tenses" },
                {"ma", " negative ending of verb in past tense" }
            };
        }
    }
}
