using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace DataAccess.Contexts
{
    public class YagoDizaynGameContext : DbContext
    {
        public YagoDizaynGameContext() : base("YagoDizaynGameContext")
        {

        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer<YagoDizaynGameContext>(new DropCreateDatabaseAlways<YagoDizaynGameContext>());
            modelBuilder.Entity<User>().ToTable("User");
            modelBuilder.Entity<Sales>().ToTable("Sales");
            modelBuilder.Entity<EDevlet>().ToTable("EDevlet");
        }

        public DbSet<User> User { get; set; }
        public DbSet<Sales> Sales { get; set; }
        public DbSet<EDevlet> EDevlet { get; set; }
    }
}
