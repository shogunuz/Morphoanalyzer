
using System;
using System.Collections.Generic;
using System.Linq;

namespace GenerationN.GetEndings
{
    public class GetNounEndings : IParent
    {
        private Dictionary<string, string> dict { get; set; }
        private string word;
        public GetNounEndings(string word)
        {
            this.word = word;
        }
      
        public string CalculationEndings()
        {
            dict = GettingEndings();
            foreach

            return "";
        }
        public Dictionary<string, string> GettingEndings()
        {
            throw new NotImplementedException();
        }

    }
}
