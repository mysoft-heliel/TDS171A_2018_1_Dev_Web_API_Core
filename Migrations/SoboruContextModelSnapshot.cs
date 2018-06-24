﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SoboruApi.Models;

namespace SoboruApi.Migrations
{
    [DbContext(typeof(SoboruContext))]
    partial class SoboruContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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

            modelBuilder.Entity("SoboruApi.Models.Receita", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Nome");

                    b.HasKey("Id");

                    b.ToTable("Receitas");
                });

            modelBuilder.Entity("SoboruApi.Models.ReceitaUtensilio", b =>
                {
                    b.Property<long>("ReceitaId");

                    b.Property<long>("UtensilioId");

                    b.HasKey("ReceitaId", "UtensilioId");

                    b.HasIndex("UtensilioId");

                    b.ToTable("ReceitaUtensilio");
                });

            modelBuilder.Entity("SoboruApi.Models.Utensilio", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Nome");

                    b.HasKey("Id");

                    b.ToTable("Utensilios");
                });

            modelBuilder.Entity("SoboruApi.Models.ReceitaUtensilio", b =>
                {
                    b.HasOne("SoboruApi.Models.Receita", "Receita")
                        .WithMany("ReceitasUtensilios")
                        .HasForeignKey("ReceitaId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SoboruApi.Models.Utensilio", "Utensilio")
                        .WithMany("ReceitasUtensilios")
                        .HasForeignKey("UtensilioId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}