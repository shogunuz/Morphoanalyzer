using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GenerationN.Models
{
    public class ModelMainContext :DbContext
    {
        public ModelMainContext(DbContextOptions<ModelMainContext> options) : base(options)
        {

        }

        public DbSet<ModelMain> ModelMains { get;set; }
    }
}
