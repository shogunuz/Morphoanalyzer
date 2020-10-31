using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GenerationN.Models;
using Microsoft.EntityFrameworkCore;

namespace GenerationN.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ModelMainController : ControllerBase
    {
        private readonly ModelMainContext _context;

        public ModelMainController(ModelMainContext context)
        {
            _context = context;
        }

        // GET: api/ModelMain
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ModelMain>>> GetModelMain()
        {
            return await _context.ModelMains.ToListAsync();
        }


        // GET: api/ModelMain/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ModelMain>> GetModelMain(int id)
        {
            var modelMain = await _context.ModelMains.FindAsync(id);

            if (modelMain == null)
            {
                return NotFound();
            }
            return modelMain;
        }

        /*
        [HttpPost]
        public async Task<ActionResult<ModelMain>> PostModelMain(ModelMain modelMain)
        {
           
             _context.ModelMains.Add(modelMain);
             await _context.SaveChangesAsync();
            return CreatedAtAction("GetModelMain", new { id = modelMain.Id }, modelMain);
        }
        */
    }
}
