using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GenerationN.Features;
using System.IO;
using System.Text;
using GenerationN.Models;

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

        // GET: api/<EndingsController>
        [HttpGet]
        public IDictionary<string, string> Endings()
        {
            Dictionary<string, string> dict = new Dictionary<string, string>
            {
                {"Первое окончание","Описание окончания" },
                {"Второе окончание","Описание второго окончания" },
                {"Корень слова","Что мы получили в итоге..." }
            };

            return dict;
        }

        // POST api/Endings
        [HttpPost]
        public async Task<ActionResult<ModelWord>> Endings([FromBody] string word)
        {
            ModelWord dicts = new ModelWord();
            dicts.Dict = new Dictionary<string, string>();

            if (string.IsNullOrEmpty(word))
                return null;
          
            foreach (KeyValuePair<string, string> kvp in endings.GetResult(word))
            {
                dicts.Dict.Add(kvp.Key, kvp.Value);
            }
            
            return dicts;
        }


    }
}
