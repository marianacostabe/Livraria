﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Livraria.Migrations
{
    public partial class Livraria : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Livraria",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Codigo = table.Column<int>(nullable: false),
                    Nome = table.Column<string>(nullable: true),
                    Autor = table.Column<string>(nullable: true),
                    ISBN = table.Column<string>(nullable: true),
                    AnoLancamento = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Livraria", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Livraria");
        }
    }
}
