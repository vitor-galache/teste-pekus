﻿// <auto-generated />
using System;
using CalculadoraPekus.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CalculadoraPekus.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20241017194917_v1")]
    partial class v1
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CalculadoraPekus.Models.Calculo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DataCalculo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("DATETIME2")
                        .HasDefaultValue(new DateTime(2024, 10, 17, 16, 49, 17, 118, DateTimeKind.Local).AddTicks(9559))
                        .HasColumnName("DataCalculo");

                    b.Property<decimal>("Resultado")
                        .HasColumnType("DECIMAL")
                        .HasColumnName("Resultado");

                    b.Property<string>("TipoCalculo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Operação");

                    b.Property<decimal>("ValorA")
                        .HasColumnType("DECIMAL")
                        .HasColumnName("ValorA");

                    b.Property<decimal>("ValorB")
                        .HasColumnType("DECIMAL")
                        .HasColumnName("ValorB");

                    b.HasKey("Id");

                    b.ToTable("Calculos");
                });
#pragma warning restore 612, 618
        }
    }
}
