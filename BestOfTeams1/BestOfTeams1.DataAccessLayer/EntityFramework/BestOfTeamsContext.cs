using BestOfTeams1.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestOfTeams1.DataAccessLayer.EntityFramework
{
  public  class BestOfTeamsContext:DbContext
    {
        public DbSet<Buses> buses { get; set; }
        public DbSet<Drivers> drivers { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Buses>().MapToStoredProcedures();
            modelBuilder.Entity<Drivers>().MapToStoredProcedures();
        }
        public BestOfTeamsContext()
        {
            Database.SetInitializer(new MyMyInitializer());
        }
    }
    
}
