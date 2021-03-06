﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProyectoLibreria.Context;

namespace ProyectoLibreria.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20200118234057_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ProyectoLibreria.Entities.Cliente", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ApellidoMaterno");

                    b.Property<string>("ApellidoPaterno");

                    b.Property<int>("DNI");

                    b.Property<int>("Edad");

                    b.Property<string>("Nombre")
                        .IsRequired();

                    b.Property<int>("RUC");

                    b.HasKey("ID");

                    b.ToTable("clientes");
                });

            modelBuilder.Entity("ProyectoLibreria.Entities.Factura", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ID_clienteID");

                    b.Property<int>("ID_sedeID");

                    b.HasKey("ID");

                    b.HasIndex("ID_clienteID");

                    b.HasIndex("ID_sedeID");

                    b.ToTable("facturas");
                });

            modelBuilder.Entity("ProyectoLibreria.Entities.Libro", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Autor");

                    b.Property<int>("Año");

                    b.Property<int>("Cantidad");

                    b.Property<string>("Nombre")
                        .IsRequired();

                    b.Property<int?>("facturaID");

                    b.HasKey("ID");

                    b.HasIndex("facturaID");

                    b.ToTable("libro");
                });

            modelBuilder.Entity("ProyectoLibreria.Entities.Sede", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Direccion");

                    b.Property<string>("Nombre")
                        .IsRequired();

                    b.Property<int>("Telefono");

                    b.HasKey("ID");

                    b.ToTable("sede");
                });

            modelBuilder.Entity("ProyectoLibreria.Entities.Factura", b =>
                {
                    b.HasOne("ProyectoLibreria.Entities.Cliente", "ID_cliente")
                        .WithMany("Facturas")
                        .HasForeignKey("ID_clienteID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ProyectoLibreria.Entities.Sede", "ID_sede")
                        .WithMany("Facturas")
                        .HasForeignKey("ID_sedeID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ProyectoLibreria.Entities.Libro", b =>
                {
                    b.HasOne("ProyectoLibreria.Entities.Factura", "factura")
                        .WithMany("libros")
                        .HasForeignKey("facturaID");
                });
#pragma warning restore 612, 618
        }
    }
}
