using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace Racing.Models
{
    public class RDbContext : DbContext
    {
        public virtual DbSet<Bike>Bikes{get;set;}
        public virtual DbSet<Track>Tracks{get;set;}

        public RDbContext(){}
        public RDbContext(DbContextOptions<RDbContext>options):base(options)
        {}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if(!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("User ID=sa;password=examlyMssql@123; server=localhost;Database=RDb;trusted_connection=false;Persist Security Info=False;Encrypt=False;");
            }
        }
    }
}