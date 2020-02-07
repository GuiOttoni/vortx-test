using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FaleMais.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace FaleMais.Infra.Repository
{
    public class Context : DbContext
    {
        public Context()
        {

        }

        public Context(DbContextOptions<Context> options) : base(options)
        { }

        public virtual DbSet<Tarifa> Tarifa { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlite($"Data Source=C:\\Projects\\vortx\\vortx.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Tarifa>().HasKey(k => new { k.Destino, k.Origem });
            modelBuilder.Entity<Tarifa>().HasData(
                new Tarifa() { Origem = 11, Destino = 16, PrecoMinuto = 1.90 },
                new Tarifa() { Origem = 11, Destino = 17, PrecoMinuto = 1.70 },
                new Tarifa() { Origem = 11, Destino = 18, PrecoMinuto = 0.90 },
                new Tarifa() { Origem = 16, Destino = 11, PrecoMinuto = 2.90 },
                new Tarifa() { Origem = 17, Destino = 11, PrecoMinuto = 2.70 },
                new Tarifa() { Origem = 18, Destino = 11, PrecoMinuto = 1.90 }
            );
           
        }
    }


}
