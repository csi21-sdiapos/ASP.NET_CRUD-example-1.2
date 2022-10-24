﻿// <auto-generated />
using EntityFramework_CodeFirst_example1.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace EntityFramework_CodeFirst_example1.Migrations
{
    [DbContext(typeof(PostgreSQLContext))]
    [Migration("20221024170147_Creacion-Inicial")]
    partial class CreacionInicial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("EntityFramework_CodeFirst_example1.Models.DTOs.AlumnoDTO", b =>
                {
                    b.Property<int>("alumno_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("alumno_id"));

                    b.Property<string>("alumno_apellidos")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("alumno_email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("alumno_nombre")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("asignatura_id")
                        .HasColumnType("integer");

                    b.HasKey("alumno_id");

                    b.HasIndex("asignatura_id");

                    b.ToTable("alumnos");
                });

            modelBuilder.Entity("EntityFramework_CodeFirst_example1.Models.DTOs.AsignaturaDTO", b =>
                {
                    b.Property<int>("asignatura_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("asignatura_id"));

                    b.Property<int>("alumno_id")
                        .HasColumnType("integer");

                    b.Property<string>("asignatura_nombre")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("asignatura_id");

                    b.HasIndex("alumno_id");

                    b.ToTable("asignaturas");
                });

            modelBuilder.Entity("EntityFramework_CodeFirst_example1.Models.DTOs.AlumnoDTO", b =>
                {
                    b.HasOne("EntityFramework_CodeFirst_example1.Models.DTOs.AsignaturaDTO", "asignatura")
                        .WithMany()
                        .HasForeignKey("asignatura_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("asignatura");
                });

            modelBuilder.Entity("EntityFramework_CodeFirst_example1.Models.DTOs.AsignaturaDTO", b =>
                {
                    b.HasOne("EntityFramework_CodeFirst_example1.Models.DTOs.AlumnoDTO", "alumno")
                        .WithMany()
                        .HasForeignKey("alumno_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("alumno");
                });
#pragma warning restore 612, 618
        }
    }
}
