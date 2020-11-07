using GenerationN.GetEndings;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.SignalR;
using Morphoanalyzer.CalcEndingsByStemming;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

/*
 * Author: N. Abdurakhmonova, 
 * Assistant: D.Mengliev
 * Year: 2020
 * Description: This class is used as General(Parent) class for other classes,
 * which are in charge of stemming words (nouns, verbs, adjs and e.g.)
 * Описание: Этот класс используется как родительский для других классов,
 * которые ответственны за стемминг слов. (существительные, глаголы и др.)
 */

namespace Morphoanalyzer.Features
{
  
    public class GetEndingsGeneral
    {
        
        public IGetEndings Parent { get; set; }

        public GetEndingsGeneral(IGetEndings parent)
        {
            this.Parent = parent;
        }

        public Dictionary<string, string> GetEndings()
        {
            return Parent.GetEndings();
        }

      


    }
}
