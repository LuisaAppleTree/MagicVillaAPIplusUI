﻿// <auto-generated />
using System;
using MagicVilla_API.Datos;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MagicVilla_API.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MagicVilla_API.Modelo.NumeroVilla", b =>
                {
                    b.Property<int>("VillaNo")
                        .HasColumnType("int");

                    b.Property<string>("DetalleEspecial")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FechaActualizacion")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaCreacion")
                        .HasColumnType("datetime2");

                    b.Property<int>("VillaId")
                        .HasColumnType("int");

                    b.HasKey("VillaNo");

                    b.HasIndex("VillaId");

                    b.ToTable("NumeroVillas");
                });

            modelBuilder.Entity("MagicVilla_API.Modelo.Villa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Amenidad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Detalle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FechaActualizacion")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaCreacion")
                        .HasColumnType("datetime2");

                    b.Property<string>("ImagenUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("MetrosCuadrados")
                        .HasColumnType("real");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Ocupantes")
                        .HasColumnType("int");

                    b.Property<float>("Tarifa")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.ToTable("Villas");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Amenidad = "Equitación, cata de vinos",
                            Detalle = "Villa con viñedos en Touluse",
                            FechaActualizacion = new DateTime(2023, 6, 22, 14, 34, 25, 388, DateTimeKind.Local).AddTicks(8011),
                            FechaCreacion = new DateTime(2023, 6, 22, 14, 34, 25, 388, DateTimeKind.Local).AddTicks(7997),
                            ImagenUrl = "",
                            MetrosCuadrados = 70f,
                            Nombre = "Villa Francesa",
                            Ocupantes = 12,
                            Tarifa = 500f
                        },
                        new
                        {
                            Id = 2,
                            Amenidad = "Nado en aguas heladas, bajo el cálido sol de la costa",
                            Detalle = "Villa con vista al cristalino mar",
                            FechaActualizacion = new DateTime(2023, 6, 22, 14, 34, 25, 388, DateTimeKind.Local).AddTicks(8013),
                            FechaCreacion = new DateTime(2023, 6, 22, 14, 34, 25, 388, DateTimeKind.Local).AddTicks(8013),
                            ImagenUrl = "",
                            MetrosCuadrados = 40f,
                            Nombre = "Villa Mediterranea",
                            Ocupantes = 8,
                            Tarifa = 800f
                        });
                });

            modelBuilder.Entity("MagicVilla_API.Modelo.NumeroVilla", b =>
                {
                    b.HasOne("MagicVilla_API.Modelo.Villa", "Villa")
                        .WithMany()
                        .HasForeignKey("VillaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Villa");
                });
#pragma warning restore 612, 618
        }
    }
}
