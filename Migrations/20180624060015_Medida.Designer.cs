﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SoboruApi.Models;

namespace SoboruApi.Migrations
{
    [DbContext(typeof(SoboruContext))]
    [Migration("20180624060015_Medida")]
    partial class Medida
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.1-rtm-30846");

            modelBuilder.Entity("SoboruApi.Models.Medida", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Abreviacao");

                    b.Property<string>("Nome");

                    b.HasKey("Id");

                    b.ToTable("Medidas");
                });
#pragma warning restore 612, 618
        }
    }
}
