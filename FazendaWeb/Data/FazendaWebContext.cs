using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace FazendaWeb.Models
{
    public class FazendaWebContext : DbContext
    {
        public FazendaWebContext (DbContextOptions<FazendaWebContext> options)
            : base(options)
        {
        }

        public DbSet<FazendaWeb.Models.Rebanho> Rebanho { get; set; }
    }
}
