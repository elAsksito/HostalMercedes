﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Prueba21.Data;

#nullable disable

namespace Prueba21.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20250224043855_OrdeConserjeria21")]
    partial class OrdeConserjeria21
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Prueba21.Models.Cliente", b =>
                {
                    b.Property<int>("ClienteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ClienteId"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Telefono")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ClienteId");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("Prueba21.Models.FormaDePago", b =>
                {
                    b.Property<int>("FormaDePagoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FormaDePagoId"));

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("FormaDePagoId");

                    b.ToTable("FormasDePago");
                });

            modelBuilder.Entity("Prueba21.Models.Habitacion", b =>
                {
                    b.Property<int>("HabitacionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("HabitacionId"));

                    b.Property<int>("Estado")
                        .HasColumnType("int");

                    b.Property<string>("Numero")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<decimal>("Precio")
                        .HasPrecision(18, 2)
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Tipo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("HabitacionId");

                    b.ToTable("Habitaciones");
                });

            modelBuilder.Entity("Prueba21.Models.OrdenConserjeria", b =>
                {
                    b.Property<int>("OrdenConserjeriaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OrdenConserjeriaId"));

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("Estado")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FechaFin")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaInicio")
                        .HasColumnType("datetime2");

                    b.Property<int>("HabitacionId")
                        .HasColumnType("int");

                    b.Property<int>("PersonalId")
                        .HasColumnType("int");

                    b.HasKey("OrdenConserjeriaId");

                    b.HasIndex("HabitacionId");

                    b.HasIndex("PersonalId");

                    b.ToTable("OrdenesConserjeria");
                });

            modelBuilder.Entity("Prueba21.Models.OrdenHospedaje", b =>
                {
                    b.Property<int>("OrdenHospedajeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OrdenHospedajeId"));

                    b.Property<int?>("ClienteId")
                        .HasColumnType("int");

                    b.Property<string>("Estado")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FechaCheckIn")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("FechaCheckOut")
                        .HasColumnType("datetime2");

                    b.Property<int>("FormaDePagoId")
                        .HasColumnType("int");

                    b.Property<int?>("HabitacionId")
                        .HasColumnType("int");

                    b.Property<int?>("OrdenReservaId")
                        .HasColumnType("int");

                    b.HasKey("OrdenHospedajeId");

                    b.HasIndex("ClienteId");

                    b.HasIndex("FormaDePagoId");

                    b.HasIndex("HabitacionId");

                    b.HasIndex("OrdenReservaId");

                    b.ToTable("OrdenesHospedaje", t =>
                        {
                            t.HasCheckConstraint("CHK_OrdenHospedaje_Tipo", "(OrdenReservaId IS NOT NULL) OR (ClienteId IS NOT NULL AND HabitacionId IS NOT NULL)");
                        });
                });

            modelBuilder.Entity("Prueba21.Models.OrdenReserva", b =>
                {
                    b.Property<int>("OrdenReservaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OrdenReservaId"));

                    b.Property<int>("ClienteId")
                        .HasColumnType("int");

                    b.Property<DateTime>("FechaEntrada")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaSalida")
                        .HasColumnType("datetime2");

                    b.Property<int>("FormaDePagoId")
                        .HasColumnType("int");

                    b.Property<int>("HabitacionId")
                        .HasColumnType("int");

                    b.HasKey("OrdenReservaId");

                    b.HasIndex("ClienteId");

                    b.HasIndex("FormaDePagoId");

                    b.HasIndex("HabitacionId");

                    b.ToTable("OrdenesReserva");
                });

            modelBuilder.Entity("Prueba21.Models.Personal", b =>
                {
                    b.Property<int>("PersonalId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PersonalId"));

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("PersonalId");

                    b.ToTable("Personal");
                });

            modelBuilder.Entity("Prueba21.Models.OrdenConserjeria", b =>
                {
                    b.HasOne("Prueba21.Models.Habitacion", "Habitacion")
                        .WithMany("OrdenesConserjeria")
                        .HasForeignKey("HabitacionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Prueba21.Models.Personal", "Personal")
                        .WithMany("OrdenesConserjeria")
                        .HasForeignKey("PersonalId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Habitacion");

                    b.Navigation("Personal");
                });

            modelBuilder.Entity("Prueba21.Models.OrdenHospedaje", b =>
                {
                    b.HasOne("Prueba21.Models.Cliente", "Cliente")
                        .WithMany("OrdenesHospedaje")
                        .HasForeignKey("ClienteId");

                    b.HasOne("Prueba21.Models.FormaDePago", "FormaDePago")
                        .WithMany("OrdenesHospedaje")
                        .HasForeignKey("FormaDePagoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Prueba21.Models.Habitacion", "Habitacion")
                        .WithMany("OrdenesHospedaje")
                        .HasForeignKey("HabitacionId");

                    b.HasOne("Prueba21.Models.OrdenReserva", "OrdenReserva")
                        .WithMany()
                        .HasForeignKey("OrdenReservaId");

                    b.Navigation("Cliente");

                    b.Navigation("FormaDePago");

                    b.Navigation("Habitacion");

                    b.Navigation("OrdenReserva");
                });

            modelBuilder.Entity("Prueba21.Models.OrdenReserva", b =>
                {
                    b.HasOne("Prueba21.Models.Cliente", "Cliente")
                        .WithMany("OrdenReserva")
                        .HasForeignKey("ClienteId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Prueba21.Models.FormaDePago", "FormaDePago")
                        .WithMany("OrdenesReserva")
                        .HasForeignKey("FormaDePagoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Prueba21.Models.Habitacion", "Habitacion")
                        .WithMany("OrdenesReserva")
                        .HasForeignKey("HabitacionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cliente");

                    b.Navigation("FormaDePago");

                    b.Navigation("Habitacion");
                });

            modelBuilder.Entity("Prueba21.Models.Cliente", b =>
                {
                    b.Navigation("OrdenReserva");

                    b.Navigation("OrdenesHospedaje");
                });

            modelBuilder.Entity("Prueba21.Models.FormaDePago", b =>
                {
                    b.Navigation("OrdenesHospedaje");

                    b.Navigation("OrdenesReserva");
                });

            modelBuilder.Entity("Prueba21.Models.Habitacion", b =>
                {
                    b.Navigation("OrdenesConserjeria");

                    b.Navigation("OrdenesHospedaje");

                    b.Navigation("OrdenesReserva");
                });

            modelBuilder.Entity("Prueba21.Models.Personal", b =>
                {
                    b.Navigation("OrdenesConserjeria");
                });
#pragma warning restore 612, 618
        }
    }
}
