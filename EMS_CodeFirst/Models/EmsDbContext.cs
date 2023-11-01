using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace EMS_CodeFirst.Models; 

// public class EMS_CodeFirstDbContext : DbContext
// {
//     public virtual DbSet<Dept> Depts{get;set;} 
//     public virtual DbSet<Employee> Employees{get;set;} 

//     public EMS_CodeFirstDbContext(){}

//     public EMS_CodeFirstDbContext(DbContextOptions<EMS_CodeFirstDbContext>options) : base(options)
//     {
//     }

//     protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
//     {
//         if(!optionBuilder.IsConfigured)
//         {
//             optionBuilder.UseSqlServer("User ID=sa;password=examlyMssql@123; server=localhost;Database=EmsDb;trusted_connection=false;Persist Security Info=False;Encrypt=False;");
//         }
//     }
// }

public class EMS_CodeFirstDbContext : DBContext
{
    public virtual DbSet<Dept> Depts{get;set;}
    public virtual DbSet<Employee> Employees{get;set;}

    public EMS_CodeFirstDbContext(){}

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if(!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlServer("ConnectionString");
        }
    }
}