﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NZWalks.API.Data;

#nullable disable

namespace NZWalks.API.Migrations
{
    [DbContext(typeof(NZWalksDbContext))]
    [Migration("20230522164424_Seeding Data For Difficulties and Regions")]
    partial class SeedingDataForDifficultiesandRegions
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0-preview.4.23259.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("NZWalks.API.Models.Domain.Difficulty", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Difficulties");

                    b.HasData(
                        new
                        {
                            Id = new Guid("062ba027-d986-45c9-b530-d8cf3ef9e3bb"),
                            Name = "Easy"
                        },
                        new
                        {
                            Id = new Guid("4bf45d76-7d26-4561-ac69-126a8b0db4ed"),
                            Name = "Medium"
                        },
                        new
                        {
                            Id = new Guid("40c3e47a-62b9-4dac-bc9e-1280c3a1c705"),
                            Name = "Hard"
                        });
                });

            modelBuilder.Entity("NZWalks.API.Models.Domain.Region", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RegionImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Regions");

                    b.HasData(
                        new
                        {
                            Id = new Guid("f72fd8d6-7bbf-4912-a331-3db5406ed059"),
                            Code = "AKL",
                            Name = "Auckland"
                        },
                        new
                        {
                            Id = new Guid("4d590d3c-1a2c-404d-81d4-ddd965600ad5"),
                            Code = "NTL",
                            Name = "North Land",
                            RegionImageUrl = "https://i.imgur.com/BweUjJK.jpeg"
                        },
                        new
                        {
                            Id = new Guid("be195175-e8ca-4da7-95b9-89377a378715"),
                            Code = "BOP",
                            Name = "Blay of Plenty"
                        },
                        new
                        {
                            Id = new Guid("f72fd8d6-7bbf-4912-a331-3db5406ed056"),
                            Code = "WGN",
                            Name = "Wellington"
                        },
                        new
                        {
                            Id = new Guid("a113c477-3389-4500-9176-bc4b8de0a6fa"),
                            Code = "NSN",
                            Name = "Nelson",
                            RegionImageUrl = "https://i.imgur.com/uNZ2GwE.jpeg"
                        },
                        new
                        {
                            Id = new Guid("fca2fe0f-0967-4e7f-b379-a16871b887ca"),
                            Code = "STL",
                            Name = "Southland"
                        });
                });

            modelBuilder.Entity("NZWalks.API.Models.Domain.Walk", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("DifficultyId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("LengthInKm")
                        .HasColumnType("float");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("RegionId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("WalkImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("DifficultyId");

                    b.HasIndex("RegionId");

                    b.ToTable("Walks");
                });

            modelBuilder.Entity("NZWalks.API.Models.Domain.Walk", b =>
                {
                    b.HasOne("NZWalks.API.Models.Domain.Difficulty", "Difficulty")
                        .WithMany()
                        .HasForeignKey("DifficultyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("NZWalks.API.Models.Domain.Region", "Region")
                        .WithMany()
                        .HasForeignKey("RegionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Difficulty");

                    b.Navigation("Region");
                });
#pragma warning restore 612, 618
        }
    }
}
