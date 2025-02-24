﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace api_test.Migrations
{
    [DbContext(typeof(ApisDbC))]
    partial class ApisDbCModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "9.0.1");

            modelBuilder.Entity("Api", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("AsComplete")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreateDat")
                        .HasColumnType("TEXT");

                    b.Property<string>("descrption")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("id");

                    b.ToTable("Apis");
                });
#pragma warning restore 612, 618
        }
    }
}
