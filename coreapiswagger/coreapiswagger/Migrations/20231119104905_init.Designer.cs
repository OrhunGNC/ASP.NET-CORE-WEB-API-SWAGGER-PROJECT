﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using coreapiswagger.Models;

#nullable disable

namespace coreapiswagger.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20231119104905_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.23")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("coreapiswagger.Models.Developers", b =>
                {
                    b.Property<int>("DevelopersId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DevelopersId"), 1L, 1);

                    b.Property<string>("DeveloperName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("DeveloperValue")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("FoundationDate")
                        .HasColumnType("datetime2");

                    b.HasKey("DevelopersId");

                    b.ToTable("Developerss");
                });

            modelBuilder.Entity("coreapiswagger.Models.Games", b =>
                {
                    b.Property<int>("GamesId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("GamesId"), 1L, 1);

                    b.Property<string>("GameName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ReleaseDate")
                        .HasColumnType("datetime2");

                    b.HasKey("GamesId");

                    b.ToTable("Gamess");
                });

            modelBuilder.Entity("coreapiswagger.Models.Platforms", b =>
                {
                    b.Property<int>("PlatformsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PlatformsId"), 1L, 1);

                    b.Property<string>("PlatformName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PlatformsId");

                    b.ToTable("Platformss");
                });

            modelBuilder.Entity("coreapiswagger.Models.Publishers", b =>
                {
                    b.Property<int>("PublishersId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PublishersId"), 1L, 1);

                    b.Property<DateTime>("FoundationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("PublisherName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("PublisherValue")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("PublishersId");

                    b.ToTable("Publisherss");
                });
#pragma warning restore 612, 618
        }
    }
}