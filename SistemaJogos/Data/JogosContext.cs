using Microsoft.EntityFrameworkCore;
using SistemaJogos.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaJogos
{
    public class JogosContext : DbContext
    {
        // Classe de contexto e banco de dados

        public JogosContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Jogos>().HasKey(t => t.Id);
        }


        public DbSet<Jogos> Jogos { get; set; }
    }
}
