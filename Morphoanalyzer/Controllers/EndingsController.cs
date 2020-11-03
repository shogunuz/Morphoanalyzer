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

/*
 * Developers: N. Abdurakhmonova, D.Mengliev
 * Year: 2020
 */

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
            string json = string.Empty;

            await Task.Run(() =>
            {
                json = (dict.Count == 0) ?
                    JsonConvert.SerializeObject(this.defaultDictionary) :
                    json = JsonConvert.SerializeObject(dict);
            }
            );
            // await Task.Run(() => DeserializeDictToString());
            return json;
        }

        // POST api/Endings
        [HttpPost]
        public async Task<ActionResult<ModelWord>> Endings(ModelWord modelWord)
        {
            string word = modelWord.word;
            word = word.ToLower(); 
            Dictionary<string, string> dicts = new Dictionary<string, string>();

            if (string.IsNullOrEmpty(word))
                return null;

            await Task.Run(()=> 
            {
                foreach (KeyValuePair<string, string> kvp in endings.GetResult(word))
                {
                    dicts.Add(kvp.Key, kvp.Value);
                }
            });
            //return json;
            return CreatedAtAction("GetEndings", dicts);
        }


    }
}
