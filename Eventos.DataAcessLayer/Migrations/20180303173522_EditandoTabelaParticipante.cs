using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Eventos.DataAcessLayer.Migrations
{
    public partial class EditandoTabelaParticipante : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IdEvento",
                table: "Participantes",
                newName: "IdParticipante");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IdParticipante",
                table: "Participantes",
                newName: "IdEvento");
        }
    }
}
