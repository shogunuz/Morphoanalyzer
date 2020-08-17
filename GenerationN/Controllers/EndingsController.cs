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

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GenerationN.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EndingsController : ControllerBase
    {
        private GettingEndings endings;
        public EndingsController()
        {
            endings = new GettingEndings();
        }

        // GET: api/endings
        [HttpGet]
        public async Task<ActionResult<string>> Newendings()
        {
            Dictionary<string, string> dict = new Dictionary<string, string>
            {
                {"Первое окончание","Описание окончания" },
                {"Второе окончание","Описание второго окончания" },
                {"Корень слова","Что мы получили в итоге..." }
            };

            string json = string.Empty;

            void DeserializeDictToString()
            {
                json = JsonConvert.SerializeObject(dict);
            }

            await Task.Run(DeserializeDictToString);
            // await Task.Run(() => DeserializeDictToString());
            return json;
        }


        // GET: api/endings
        [HttpGet]
        public async Task<ActionResult<string>> GetEndings(Dictionary<string, string> dict)
        {
            Dictionary<string, string> InnerDict = new Dictionary<string, string>
            {
                {"Первое окончание","Описание окончания" },
                {"Второе окончание","Описание второго окончания" },
                {"Корень слова","Что мы получили в итоге..." }
            };
            string json = string.Empty;

            void GetData()
            {
                if(dict.Count == 0)
                {
                    json = JsonConvert.SerializeObject(InnerDict);
                }
                else
                {
                    json = JsonConvert.SerializeObject(dict);
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

            //string json = string.Empty;
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
