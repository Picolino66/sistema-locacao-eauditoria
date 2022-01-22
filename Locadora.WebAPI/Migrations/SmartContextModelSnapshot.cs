﻿// <auto-generated />
using System;
using Locadora.WebAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Locadora.WebAPI.Migrations
{
    [DbContext(typeof(SmartContext))]
    partial class SmartContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Locadora.WebAPI.Models.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Cpf")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("DataNascimento")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("Locadora.WebAPI.Models.Filme", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("ClassificacaoIndicativa")
                        .HasColumnType("int");

                    b.Property<byte>("Lancamento")
                        .HasColumnType("tinyint unsigned");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Filmes");
                });

            modelBuilder.Entity("Locadora.WebAPI.Models.Locacao", b =>
                {
                    b.Property<int>("ClienteId")
                        .HasColumnType("int");

                    b.Property<int>("FilmeId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DataDevolucao")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("DataLocacao")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.HasKey("ClienteId", "FilmeId");

                    b.HasIndex("FilmeId");

                    b.ToTable("Locacoes");
                });

            modelBuilder.Entity("Locadora.WebAPI.Models.Locacao", b =>
                {
                    b.HasOne("Locadora.WebAPI.Models.Cliente", "Cliente")
                        .WithMany()
                        .HasForeignKey("ClienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Locadora.WebAPI.Models.Filme", "Filme")
                        .WithMany()
                        .HasForeignKey("FilmeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cliente");

                    b.Navigation("Filme");
                });
#pragma warning restore 612, 618
        }
    }
}