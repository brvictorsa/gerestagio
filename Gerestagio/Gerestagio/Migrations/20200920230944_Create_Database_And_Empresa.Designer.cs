﻿// <auto-generated />
using System;
using Gerestagio.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Gerestagio.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20200920230944_Create_Database_And_Empresa")]
    partial class Create_Database_And_Empresa
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("public")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("Gerestagio.Domain.Entidades.Empresa", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("AtualizadoEm")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Cnpj")
                        .HasColumnType("text");

                    b.Property<string>("Contato")
                        .HasColumnType("text");

                    b.Property<DateTime>("CriadoEm")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Nome")
                        .HasColumnType("text");

                    b.Property<string>("Telefone")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Empresas");
                });
#pragma warning restore 612, 618
        }
    }
}
