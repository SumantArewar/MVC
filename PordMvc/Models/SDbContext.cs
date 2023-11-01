using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace PordMvc.Models;

public class SDbContext : DbContext
{
    public virtual DbSet<Product> Product{get;set;} // It is databse Set
    public SDbContext(){} // It should have an empty constuctor
    public SDbContext(DbContextOptions<SDbContext>options) : base(options){}

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if(!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlServer("User ID=sa;password=examlyMssql@123; server=localhost;Database=SumantDb;trusted_connection=false;Persist Security Info=False;Encrypt=False");
        }
    }
}
