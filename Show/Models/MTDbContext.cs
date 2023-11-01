using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace Show.Models;

public class MTDbContext : DbContext
{
    public virtual DbSet<Bike> Bikes{get;set;}
    public virtual DbSet<Showroom>Showrooms{get;set;}

    public MTDbContext(){}

    public MTDbContext(DbContextOptions<MTDbContext>options):base(options)
    {
    }
    protected override OnConfiguring(DbContextOptionsBuilder optionBuilder)
    {
        if(!optionBuilder =IsConfigur)
        {
            optionBuilder.UseSqlServer(""User ID=sa;password=examlyMssql@123; server=localhost;Database=MTDbContext;trusted_connection=false;Persist Security Info=False;Encrypt=False";")
        }
    }

}