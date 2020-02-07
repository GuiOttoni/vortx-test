﻿// <auto-generated />
using FaleMais.Infra.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FaleMais.Infra.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.1");

            modelBuilder.Entity("FaleMais.Domain.Models.Tarifa", b =>
                {
                    b.Property<int>("Destino")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Origem")
                        .HasColumnType("INTEGER");

                    b.Property<double>("PrecoMinuto")
                        .HasColumnType("REAL");

                    b.HasKey("Destino", "Origem");

                    b.ToTable("Tarifa");

                    b.HasData(
                        new
                        {
                            Destino = 16,
                            Origem = 11,
                            PrecoMinuto = 1.8999999999999999
                        },
                        new
                        {
                            Destino = 17,
                            Origem = 11,
                            PrecoMinuto = 1.7
                        },
                        new
                        {
                            Destino = 18,
                            Origem = 11,
                            PrecoMinuto = 0.90000000000000002
                        },
                        new
                        {
                            Destino = 11,
                            Origem = 16,
                            PrecoMinuto = 2.8999999999999999
                        },
                        new
                        {
                            Destino = 11,
                            Origem = 17,
                            PrecoMinuto = 2.7000000000000002
                        },
                        new
                        {
                            Destino = 11,
                            Origem = 18,
                            PrecoMinuto = 1.8999999999999999
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
