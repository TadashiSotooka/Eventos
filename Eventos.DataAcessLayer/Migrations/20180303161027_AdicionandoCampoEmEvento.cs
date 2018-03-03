using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Eventos.DataAcessLayer.Migrations
{
    public partial class AdicionandoCampoEmEvento : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IngressosVendidos",
                table: "Eventos",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MaximoIngressos",
                table: "Eventos",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IngressosVendidos",
                table: "Eventos");

            migrationBuilder.DropColumn(
                name: "MaximoIngressos",
                table: "Eventos");
        }
    }
}
