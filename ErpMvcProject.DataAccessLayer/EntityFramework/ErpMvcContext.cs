using ErpMvcProject.DataAccessLayer.EntityFramework;
using ErpMvcProject.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErpMvcProject.DataAccessLayer.Entity
{

    public class ErpMvcContext : DbContext
    {
        public DbSet<Cities> cities { get; set; }
        public DbSet<Current> currents { get; set; }
        public DbSet<CurrentGroups> currentGroups { get; set; }
        public DbSet<Departments> departments { get; set; }
        public DbSet<EmployeeDetails> employeeDetails { get; set; }
        public DbSet<Products> products { get; set; }
        public DbSet<StockEntryTop> stockEntryTops { get; set; }
        public DbSet<StockEntryLower> stockEntryLowers { get; set; }
        public DbSet<StockStatus> stockStatuses { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cities>().MapToStoredProcedures();
            modelBuilder.Entity<Current>().MapToStoredProcedures();
            modelBuilder.Entity<CurrentGroups>().MapToStoredProcedures();
            modelBuilder.Entity<Departments>().MapToStoredProcedures();
            modelBuilder.Entity<EmployeeDetails>().MapToStoredProcedures();
            modelBuilder.Entity<Products>().MapToStoredProcedures();
            modelBuilder.Entity<StockEntryLower>().MapToStoredProcedures();
            modelBuilder.Entity<StockEntryTop>().MapToStoredProcedures();
            modelBuilder.Entity<StockStatus>().MapToStoredProcedures();

        }
        public ErpMvcContext()
        {
            Database.SetInitializer(new MyInitializer());
        }
    }
}
