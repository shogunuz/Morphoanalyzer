using GenerationN.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace GenerationN.Features.GetEndingsForLeven
{
    public class GetListOfEndsFromDB
    {
        private const string Link = "https://localhost:44339/api/ModelMain";

        public ModelMain GetListOfEnding(string word)
        {
            ModelMain tmp = new ModelMain();
            tmp.coreWord = "NoName";
            ModelMain getList()
            {
                WebRequest request = WebRequest.Create(Link);
                using (WebResponse response = request.GetResponse())
                using (Stream stream = response.GetResponseStream())
                using (StreamReader streamReader = new StreamReader(stream))
                using (JsonTextReader reader = new JsonTextReader(streamReader))
                {

                    reader.SupportMultipleContent = true;
                    var serializer = new JsonSerializer();
                     
                    while (reader.Read())
                    {
                        if (reader.TokenType == JsonToken.StartObject)
                        {
                            ModelMain modelMain = serializer.Deserialize<ModelMain>(reader);

                            int diff = StringDistance.GetDamerauLevenshteinDistance(
                                modelMain.fullWord, word); 
                            if(diff <= 1)
                            {
                                return modelMain;
                            }
                           
                        }
                    }
                }
                return tmp;
            }

            return getList();
        }
    }
}
