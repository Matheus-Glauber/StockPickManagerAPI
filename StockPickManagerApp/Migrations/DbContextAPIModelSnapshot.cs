﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using StockPickManagerApp;

namespace StockPickManagerApp.Migrations
{
    [DbContext(typeof(DbContextAPI))]
    partial class DbContextAPIModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("StockPickManagerApp.Models.Action", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("code")
                        .HasColumnType("text");

                    b.Property<DateTime>("purchaseDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("qtd")
                        .HasColumnType("integer");

                    b.Property<double>("unitPrice")
                        .HasColumnType("double precision");

                    b.HasKey("ID");

                    b.ToTable("Action");
                });
#pragma warning restore 612, 618
        }
    }
}
