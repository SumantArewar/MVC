using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace dotnetapp.Models;

public class MyDbContext : DbContext
{
    public virtual DbSet<Animal> Animals{get;set;}
    public virtual DbSet<Zoo> Zoos{get;set;}

    public MyDbContext(){}
    public MyDbContext(DbContextOptions<MyDbContext>options) : base(options)
    {
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
    {
        if(!optionBuilder.IsConfigured)
        {
            optionBuilder.UseSqlServer("User ID=sa;password=examlyMssql@123; server=localhost;Database=MyDb;trusted_connection=false;Persist Security Info=False;Encrypt=False;");
        }
    }
}