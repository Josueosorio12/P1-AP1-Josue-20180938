// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using P1_ap1_josueosorio_20180938.DAL;

namespace P1_ap1_josueosorio_20180938.Migrations
{
    [DbContext(typeof(Contexto))]
    [Migration("20211006051723_Migracion_inicial")]
    partial class Migracion_inicial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.10");

            modelBuilder.Entity("P1_ap1_josueosorio_20180938.Entidades.AportesEntidades", b =>
                {
                    b.Property<int>("AporteID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Concepto")
                        .HasColumnType("TEXT");

                    b.Property<int>("Conteo")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("FechaIngreso")
                        .HasColumnType("TEXT");

                    b.Property<int>("Monto")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Persona")
                        .HasColumnType("TEXT");

                    b.Property<int>("Total")
                        .HasColumnType("INTEGER");

                    b.HasKey("AporteID");

                    b.ToTable("AportesEntidades");
                });
#pragma warning restore 612, 618
        }
    }
}
