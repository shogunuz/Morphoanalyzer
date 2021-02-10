using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using System.Text;
using Newtonsoft.Json;
using System.Net;
using Morphoanalyzer.Features;
using Morphoanalyzer.Models;
using Morphoanalyzer.CalcEndingsByStemming;

namespace Morphoanalyzer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EndingsController : ControllerBase
    {
        private CalcEndings endings;
        
        private Dictionary<string, string> defaultDictionary = new Dictionary<string, string>
            {
                {"Первое окончание","Описание окончания" },
                {"Второе окончание","Описание второго окончания" },
                {"Корень слова","Что мы получили в итоге..." }
            }; 
        public EndingsController()
        {
            endings = new CalcEndings();
        }

        // GET: api/getEndings
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
            string word = string.Empty;
            try
            {
                word = modelWord.ResWord;//ResultWord
                word = word.ToLower();
            }
            catch(Exception ex) {
                return CreatedAtAction("GetEndings", defaultDictionary);
            }
            if (string.IsNullOrEmpty(word))
                return CreatedAtAction("GetEndings", defaultDictionary);

            // In case  user sent word(not null) we can start analyzing
            Dictionary<string, string> dictionary = new Dictionary<string, string>();

            await Task.Run(()=> 
            {
                foreach (KeyValuePair<string, string> kvp in endings.GetResult(word))
                {
                    dictionary.Add(kvp.Key, kvp.Value);
                }
            });
            return CreatedAtAction("GetEndings", dictionary);
        }


    }
}
