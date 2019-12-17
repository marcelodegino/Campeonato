﻿// <auto-generated />
using System;
using Campeonato.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Campeonato.Migrations
{
    [DbContext(typeof(CampeonatoContext))]
    [Migration("20191216205505_campeonato")]
    partial class campeonato
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Campeonato.Models.Jogador", b =>
                {
                    b.Property<int>("JogadorId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Idade");

                    b.Property<string>("Nacionalidade")
                        .IsRequired();

                    b.Property<string>("Nome")
                        .IsRequired();

                    b.HasKey("JogadorId");

                    b.ToTable("Jogador");
                });

            modelBuilder.Entity("Campeonato.Models.Placar", b =>
                {
                    b.Property<int>("PlacarId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("HorarioId");

                    b.Property<int>("JogadorId");

                    b.Property<int>("TotalPontos");

                    b.HasKey("PlacarId");

                    b.HasIndex("JogadorId");

                    b.ToTable("Placar");
                });

            modelBuilder.Entity("Campeonato.Models.Placar", b =>
                {
                    b.HasOne("Campeonato.Models.Jogador", "Jogador")
                        .WithMany("Placares")
                        .HasForeignKey("JogadorId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
