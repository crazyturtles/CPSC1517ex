using FSISSystem.ENTITIES;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSISSystem.DAL
{
    internal class FSISContext : DbContext
    {
        public FSISContext() : base("NWDB")
        {

        }
        public DbSet<Guardian> Guardians { get; set; }
        public DbSet<Player> Players { get; set; }
        public DbSet<Team> Teams { get; set; }

    }
}
