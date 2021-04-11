﻿// <auto-generated />
using System;
using CriadorCaes.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CriadorCaes.Migrations
{
    [DbContext(typeof(CriadorCaesBD))]
    [Migration("20210411162502_windows")]
    partial class windows
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.5")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CriadorCaes.Models.Caes", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DataCompra")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataNasc")
                        .HasColumnType("datetime2");

                    b.Property<string>("LOP")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RacaFK")
                        .HasColumnType("int");

                    b.Property<string>("Sexo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("RacaFK");

                    b.ToTable("Caes");
                });

            modelBuilder.Entity("CriadorCaes.Models.Criadores", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CodPostal")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.Property<string>("Email")
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.Property<string>("Morada")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.Property<string>("NomeComercial")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Telemovel")
                        .HasMaxLength(16)
                        .HasColumnType("nvarchar(16)");

                    b.HasKey("Id");

                    b.ToTable("Criadores");
                });

            modelBuilder.Entity("CriadorCaes.Models.CriadoresCaes", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CaoFK")
                        .HasColumnType("int");

                    b.Property<int>("CriadorFK")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CaoFK");

                    b.HasIndex("CriadorFK");

                    b.ToTable("CriadoresCaes");
                });

            modelBuilder.Entity("CriadorCaes.Models.Fotografias", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CaoFK")
                        .HasColumnType("int");

                    b.Property<DateTime>("Data")
                        .HasColumnType("datetime2");

                    b.Property<string>("Fotografia")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Local")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CaoFK");

                    b.ToTable("Fotografias");
                });

            modelBuilder.Entity("CriadorCaes.Models.Racas", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Designacao")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Racas");
                });

            modelBuilder.Entity("CriadorCaes.Models.Caes", b =>
                {
                    b.HasOne("CriadorCaes.Models.Racas", "Raca")
                        .WithMany("ListaDeCaes")
                        .HasForeignKey("RacaFK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Raca");
                });

            modelBuilder.Entity("CriadorCaes.Models.CriadoresCaes", b =>
                {
                    b.HasOne("CriadorCaes.Models.Caes", "Cao")
                        .WithMany("ListaDeCriadores")
                        .HasForeignKey("CaoFK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CriadorCaes.Models.Criadores", "Criador")
                        .WithMany("ListaDeCaes")
                        .HasForeignKey("CriadorFK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cao");

                    b.Navigation("Criador");
                });

            modelBuilder.Entity("CriadorCaes.Models.Fotografias", b =>
                {
                    b.HasOne("CriadorCaes.Models.Caes", "Cao")
                        .WithMany("ListaDeFotografias")
                        .HasForeignKey("CaoFK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cao");
                });

            modelBuilder.Entity("CriadorCaes.Models.Caes", b =>
                {
                    b.Navigation("ListaDeCriadores");

                    b.Navigation("ListaDeFotografias");
                });

            modelBuilder.Entity("CriadorCaes.Models.Criadores", b =>
                {
                    b.Navigation("ListaDeCaes");
                });

            modelBuilder.Entity("CriadorCaes.Models.Racas", b =>
                {
                    b.Navigation("ListaDeCaes");
                });
#pragma warning restore 612, 618
        }
    }
}
