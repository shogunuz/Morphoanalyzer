using GenerationN.GetEndings;
using GenerationN.StaticData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GenerationN.Features
{
    public class GenerationEndings
    {
        /* Здесь и происходит усечение окончаний
         * 
         * 
         */
        private GetEndingsFromDB[] getEndings; 
        public GenerationEndings()
        {
            getEndings = new GetEndingsFromDB[Staticdatas.KindsOfEndings];
         //   getEndings[0] = new GetNounEndings();
           // getEndings[1] = new GetVerbEndings();
          //  getEndings[2] = new GetAdjectiveEndings();
           // getEndings[3] = new GetAdverbEndings();
        }

        public void GetData(string str)
        {
            /*Данный метод получает стринг
             * который перенаправляет другому методу
             * который и проходит по всем объектам чтобы найти окончания
             */
            
           //  foreach (GetEndingsFromDB item in getEndings)
              //  item.AnalyzingWord(str);
            
            //Можно также реализовать внутренний метод, он будет приватным
        }

    }
}
