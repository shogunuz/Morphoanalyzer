using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GenerationN.Features.GetEndingsForLeven
{
    /* Данный класс принимает на вход словарь, который получается от
      базы данных (ModelMainCOntroller GET запрос).
     Словарь, который принимает этот класс прогоняется по методам, каждый из которых
     обращаются к статичным окончаниям (из StaticData) дабы сравнить эти окончания, 
     с окончаниями словаря.
    В отличии от стемминг версии, в этой версии поиска окончаний, наши окончания уже 
    усечены, и нам просто нужно прогнать эти окончания по уже существющим.
    В зависимости от того, какой метод вернет нам больше выявленных окончаний, 
    будет подготовлен новый словарь с парами окончаний+инфой по ним.

     */
    public class GetEndingsForLeven
    {
        private Dictionary<string, string> dictionary { get; set; }

        public GetEndingsForLeven(Dictionary<string,string> dict)
        {
            this.dictionary = dict;
        }

        public Dictionary<string, string> GetEndings()
        {

            return this.dictionary;
        }
        //private 
    }
}
