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

        public DbSet<Rebanho> Rebanho { get; set; }
        public DbSet<Pasto> Pasto { get; set; }
    }
}
