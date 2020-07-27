using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace GenerationN.Features
{
    public class AlgoSubString
    {
        public static int Solve(string str)
        {
            if (str == null)
            {
                throw new ArgumentNullException();
            }

            return Regex.Split(str, "[^aeiou]+")
                        .Select(e => e.Length)
                        .Max();
        }
        public static int SolveLinq(string str)
        {
            var vowels = "aeiou".ToCharArray();
            return str.Split(str
                .Where(c => !vowels.Contains(c))
                .ToArray()).
                Max(s => s.Length);
        }

        public static int SolveS(string str) 
            => Regex.Split(str, "[^aeiou]+").Max(e => e.Length);
    }
}
