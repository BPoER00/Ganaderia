﻿// <auto-generated />
using Ganaderia.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Ganaderia.Migrations
{
    [DbContext(typeof(ConexionContext))]
    [Migration("20230526041237_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Ganaderia.Models.ANIMAL", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<int>("estado")
                        .HasColumnType("int");

                    b.Property<int>("id_corral")
                        .HasColumnType("int");

                    b.Property<int>("id_raza")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("id_corral");

                    b.HasIndex("id_raza");

                    b.ToTable("animal");
                });

            modelBuilder.Entity("Ganaderia.Models.CORRAL", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<int>("cantidad_actual")
                        .HasColumnType("int");

                    b.Property<int>("cantidad_corral")
                        .HasColumnType("int");

                    b.Property<int>("estado")
                        .HasColumnType("int");

                    b.Property<int>("id_finca")
                        .HasColumnType("int");

                    b.Property<int>("id_genero")
                        .HasColumnType("int");

                    b.Property<int>("id_rango_peso")
                        .HasColumnType("int");

                    b.Property<int>("numero_corral")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("id_finca");

                    b.HasIndex("id_genero");

                    b.HasIndex("id_rango_peso");

                    b.ToTable("corral");
                });

            modelBuilder.Entity("Ganaderia.Models.DIRECCION", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<int>("estado")
                        .HasColumnType("int");

                    b.Property<string>("nombre")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("id");

                    b.ToTable("direccion");
                });

            modelBuilder.Entity("Ganaderia.Models.FINCA", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<int>("estado")
                        .HasColumnType("int");

                    b.Property<int>("id_ubicacion")
                        .HasColumnType("int");

                    b.Property<string>("nombre")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("id");

                    b.HasIndex("id_ubicacion");

                    b.ToTable("finca");
                });

            modelBuilder.Entity("Ganaderia.Models.GENERO", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<int>("estado")
                        .HasColumnType("int");

                    b.Property<string>("nombre")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("id");

                    b.ToTable("genero");
                });

            modelBuilder.Entity("Ganaderia.Models.RANGO_DE_PESO", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("descripcion")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<int>("estado")
                        .HasColumnType("int");

                    b.Property<string>("rango_de_peso")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("id");

                    b.ToTable("rango_de_peso");
                });

            modelBuilder.Entity("Ganaderia.Models.RAZA", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<int>("estado")
                        .HasColumnType("int");

                    b.Property<string>("nombre")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("id");

                    b.ToTable("raza");
                });

            modelBuilder.Entity("Ganaderia.Models.ANIMAL", b =>
                {
                    b.HasOne("Ganaderia.Models.CORRAL", "CORRAL")
                        .WithMany()
                        .HasForeignKey("id_corral")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Ganaderia.Models.RAZA", "RAZA")
                        .WithMany()
                        .HasForeignKey("id_raza")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CORRAL");

                    b.Navigation("RAZA");
                });

            modelBuilder.Entity("Ganaderia.Models.CORRAL", b =>
                {
                    b.HasOne("Ganaderia.Models.FINCA", "FINCA")
                        .WithMany()
                        .HasForeignKey("id_finca")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Ganaderia.Models.GENERO", "GENERO")
                        .WithMany()
                        .HasForeignKey("id_genero")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Ganaderia.Models.RANGO_DE_PESO", "RANGO_DE_PESO")
                        .WithMany()
                        .HasForeignKey("id_rango_peso")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("FINCA");

                    b.Navigation("GENERO");

                    b.Navigation("RANGO_DE_PESO");
                });

            modelBuilder.Entity("Ganaderia.Models.FINCA", b =>
                {
                    b.HasOne("Ganaderia.Models.DIRECCION", "DIRECCION")
                        .WithMany()
                        .HasForeignKey("id_ubicacion")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DIRECCION");
                });
#pragma warning restore 612, 618
        }
    }
}
