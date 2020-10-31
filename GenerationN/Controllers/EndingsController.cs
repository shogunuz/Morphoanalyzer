using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GenerationN.Features;
using System.IO;
using System.Text;
using GenerationN.Models;
using Newtonsoft.Json;
using System.Net;
using GenerationN.Features.GetEndingsForLeven;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GenerationN.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EndingsController : ControllerBase
    {
        private GettingEndings endings;

        
        private Dictionary<string, string> defaultDictionary = new Dictionary<string, string>
            {
                {"Первое окончание","Описание окончания" },
                {"Второе окончание","Описание второго окончания" },
                {"Корень слова","Что мы получили в итоге..." }
            };
        public EndingsController()
        {
            endings = new GettingEndings();
        }

        // GET: api/endings
        [HttpGet]
        public async Task<ActionResult<string>> GetEndings(Dictionary<string, string> dict)
        {
            /* Я создам строку, в которую помещу последний элемент словаря
               так как последний элемент словаря это корень слова.
               Корень слова мне нужен для того, чтобы прогнать его по Exception
                датасету. 
             */
            string lastword;
           

            string json = string.Empty;

            void GetData()
            {
                if(dict.Count == 0)
                {
                    json = JsonConvert.SerializeObject(this.defaultDictionary);
                }
                else
                {
                    GetListOfEndsFromDB glfromDB = new GetListOfEndsFromDB();
                    ModelMain mm = glfromDB.GetListOfEnding(dict.Keys.Last());
                    if(mm.coreWord == "NoName")
                    {
                        json = JsonConvert.SerializeObject(dict);
                    }
                    else
                    {
                        json = JsonConvert.SerializeObject(mm);
                    }
                }
            }

            await Task.Run(GetData);
            // await Task.Run(() => DeserializeDictToString());
            return json;
        }

        // POST api/Endings
        [HttpPost]
        public async Task<ActionResult<ModelWord>> Endings(ModelWord modelWord)
        {
            string word = modelWord.word;
            Dictionary<string, string> dicts = new Dictionary<string, string>();

            if (string.IsNullOrEmpty(word))
                return null;

            void fillingDict()
            {
                foreach (KeyValuePair<string, string> kvp in endings.GetResult(word))
                {
                    dicts.Add(kvp.Key, kvp.Value);
                }
               // json = JsonConvert.SerializeObject(dicts);
            }

            await Task.Run(fillingDict);
            //await Task.Run(() => fillingDict());
            //return json;
            return CreatedAtAction("GetEndings", dicts);
        }


    }
}
