using Eventos.DataAcessLayer.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Eventos.DataAcessLayer
{
    public class Database : DbContext
    {
        public DbSet<Evento> Eventos { get; set; }
        public DbSet<Participante> Participantes { get; set; }

        //public BancoDeDados(DbContextOptions<BancoDeDados> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseMySql("server = localhost; " +
            "userid=root;" +
            "password=0000;database=eventos;");
        }

    }
}
