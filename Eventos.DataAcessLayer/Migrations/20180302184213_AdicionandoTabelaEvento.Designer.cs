﻿// <auto-generated />
using Eventos.DataAcessLayer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace Eventos.DataAcessLayer.Migrations
{
    [DbContext(typeof(Database))]
    [Migration("20180302184213_AdicionandoTabelaEvento")]
    partial class AdicionandoTabelaEvento
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125");

            modelBuilder.Entity("Eventos.DataAcessLayer.Models.Evento", b =>
                {
                    b.Property<int>("IdEvento")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Data");

                    b.Property<int>("FaixaEtaria");

                    b.Property<TimeSpan>("HoraFim");

                    b.Property<TimeSpan>("HoraIncio");

                    b.Property<string>("Local")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<bool>("OpenBar");

                    b.Property<int>("QuantidadeDeAmbientes");

                    b.HasKey("IdEvento");

                    b.ToTable("Eventos");
                });
#pragma warning restore 612, 618
        }
    }
}