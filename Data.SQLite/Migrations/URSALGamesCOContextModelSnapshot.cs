﻿// <auto-generated />
using System;
using Data.SQLite.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Data.SQLite.Migrations
{
    [DbContext(typeof(URSALGamesCOContext))]
    partial class URSALGamesCOContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.1-rtm-30846");

            modelBuilder.Entity("Domain.Models.Game", b =>
                {
                    b.Property<long>("GameId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Title");

                    b.HasKey("GameId");

                    b.ToTable("Game");
                });

            modelBuilder.Entity("Domain.Models.GameResult", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<long>("GameId");

                    b.Property<long>("PlayerId");

                    b.Property<DateTime>("Timestamp");

                    b.Property<long>("Win");

                    b.HasKey("Id");

                    b.ToTable("GameResults");
                });
#pragma warning restore 612, 618
        }
    }
}
