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

/*
 * Author: N. Abdurakhmonova, 
 * Assistant: D.Mengliev
 * Year: 2020
 */

namespace Morphoanalyzer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EndingsNewController : ControllerBase
    {
        private CalcEndings endings;

        
        private Dictionary<string, string> defaultDictionary = new Dictionary<string, string>
            {
                {"Первое окончание","Описание окончания" },
                {"Второе окончание","Описание второго окончания" },
                {"Корень слова","Что мы получили в итоге..." }
            }; 
        public EndingsNewController()
        {
            endings = new CalcEndings();
        }

        // GET: api/endingsNew
        [HttpGet]
        public async Task<ActionResult<string>> GetEndingsNew(Dictionary<string, string> dict)
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

        // GET: api/GetEndingsFormat
        [HttpGet]
        public async Task<ActionResult<string>> GetEndingsFormat()
        {
            string json = string.Empty;
            await Task.Run(() =>
            {
                json = (string.IsNullOrEmpty(StaticData.StaticString.GetResString())) ?
                    JsonConvert.SerializeObject("") :
                    json = JsonConvert.SerializeObject(StaticData.StaticString.GetResString());
            }
            );
            return json;
        }

        // POST api/EndingsNew
        [HttpPost]
        public async Task<ActionResult<ModelWord>> EndingsNew(ModelWord modelWord)
        {
            string word = modelWord.ResWord;
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
            string json = string.Empty;
            await Task.Run(() =>
            {
                json = (dicts.Count == 0) ?
                    JsonConvert.SerializeObject(this.defaultDictionary) :
                    json = JsonConvert.SerializeObject(dicts);
            }
           );
            StaticData.StaticString.SetString(json);
            return CreatedAtAction("GetEndingsNew", dicts);
        }


    }
}
