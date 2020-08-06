using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GenerationN.Features;
using System.IO;
using System.Text;
using Newtonsoft.Json;
using GenerationN.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GenerationN.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NewendingsController : ControllerBase
    {
        private GettingEndings endings;
        public NewendingsController()
        {
            endings = new GettingEndings();
        }

        // GET: api/newendings
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

        // POST api/Newendings
        [HttpPost]
        public async Task<ActionResult<string>> Newendings([FromBody] string word)
        {
            ModelWord dicts = new ModelWord();
            dicts.Dict = new Dictionary<string, string>();
            string json = string.Empty;
            if (string.IsNullOrEmpty(word))
                return null;

            void fillingDict()
            {
                foreach (KeyValuePair<string, string> kvp in endings.GetResult(word))
                {
                    dicts.Dict.Add(kvp.Key, kvp.Value);
                }
                json = JsonConvert.SerializeObject(dicts.Dict);
            }
           
            await Task.Run(fillingDict);
            //await Task.Run(() => fillingDict());
            return json;
        }


    }
}
