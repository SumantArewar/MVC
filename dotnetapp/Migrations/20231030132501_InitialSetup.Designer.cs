﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using dotnetapp.Models;

#nullable disable

namespace dotnetapp.Migrations
{
    [DbContext(typeof(MyDbContext))]
    [Migration("20231030132501_InitialSetup")]
    partial class InitialSetup
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("dotnetapp.Models.Animal", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ZooId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ZooId");

                    b.ToTable("Animals");
                });

            modelBuilder.Entity("dotnetapp.Models.Zoo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ZId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Zoos");
                });

            modelBuilder.Entity("dotnetapp.Models.Animal", b =>
                {
                    b.HasOne("dotnetapp.Models.Zoo", "Zoo")
                        .WithMany("Animals")
                        .HasForeignKey("ZooId");

                    b.Navigation("Zoo");
                });

            modelBuilder.Entity("dotnetapp.Models.Zoo", b =>
                {
                    b.Navigation("Animals");
                });
#pragma warning restore 612, 618
        }
    }
}
