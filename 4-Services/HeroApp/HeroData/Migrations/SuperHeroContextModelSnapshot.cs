﻿// <auto-generated />
using System;
using HeroData.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace HeroData.Migrations
{
    [DbContext(typeof(SuperHeroContext))]
    partial class SuperHeroContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.5")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("HeroData.Entities.SuperHero", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Alias")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("HideOut")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("RealName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("superhero");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Alias = "Spiderman",
                            HideOut = "His study room",
                            RealName = "Peter Parker"
                        },
                        new
                        {
                            Id = 2,
                            Alias = "Thor",
                            HideOut = "Asgard",
                            RealName = "Thor"
                        });
                });

            modelBuilder.Entity("HeroData.Entities.SuperPower", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<int?>("OwnerId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OwnerId")
                        .IsUnique()
                        .HasFilter("[OwnerId] IS NOT NULL");

                    b.ToTable("SuperPowers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Can climb any building and throw web at the enemy",
                            Name = "spider abilities",
                            OwnerId = 1
                        },
                        new
                        {
                            Id = 2,
                            Description = "It can kill any enemy and open Asgard gates",
                            Name = "Magical hammer",
                            OwnerId = 2
                        });
                });

            modelBuilder.Entity("HeroData.Entities.SuperPower", b =>
                {
                    b.HasOne("HeroData.Entities.SuperHero", "Owner")
                        .WithOne("SuperPower")
                        .HasForeignKey("HeroData.Entities.SuperPower", "OwnerId");

                    b.Navigation("Owner");
                });

            modelBuilder.Entity("HeroData.Entities.SuperHero", b =>
                {
                    b.Navigation("SuperPower");
                });
#pragma warning restore 612, 618
        }
    }
}
