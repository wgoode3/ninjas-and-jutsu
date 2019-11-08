﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Naruto.Models;

namespace Naruto.Migrations
{
    [DbContext(typeof(MyContext))]
    [Migration("20191108193218_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Naruto.Models.Jutsu", b =>
                {
                    b.Property<int>("JutsuId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("TechniqueName")
                        .IsRequired();

                    b.HasKey("JutsuId");

                    b.ToTable("Jutsus");
                });

            modelBuilder.Entity("Naruto.Models.Ninja", b =>
                {
                    b.Property<int>("NinjaId")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("Chakra")
                        .IsRequired();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("NinjaId");

                    b.ToTable("Ninjas");
                });

            modelBuilder.Entity("Naruto.Models.Ninjutsu", b =>
                {
                    b.Property<int>("NinjutsuId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("JutsuId");

                    b.Property<int>("NinjaId");

                    b.HasKey("NinjutsuId");

                    b.HasIndex("JutsuId");

                    b.HasIndex("NinjaId");

                    b.ToTable("Ninjitsus");
                });

            modelBuilder.Entity("Naruto.Models.Ninjutsu", b =>
                {
                    b.HasOne("Naruto.Models.Jutsu", "ThatJutsu")
                        .WithMany("JutsuUsers")
                        .HasForeignKey("JutsuId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Naruto.Models.Ninja", "ThatNinja")
                        .WithMany("KnownJutsu")
                        .HasForeignKey("NinjaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}