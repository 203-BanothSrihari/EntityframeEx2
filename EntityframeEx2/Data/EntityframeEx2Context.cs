using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EntityframeEx2.Models;

namespace EntityframeEx2.Data
{
    public class EntityframeEx2Context : DbContext
    {
        public EntityframeEx2Context (DbContextOptions<EntityframeEx2Context> options)
            : base(options)
        {
        }

        public DbSet<EntityframeEx2.Models.Product> Product { get; set; }
    }
}
