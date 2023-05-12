using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DBContext.Migrations
{
    public partial class Migrazione2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "IdAzienda",
                table: "NEGOZIO",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateTable(
                name: "TAZIENDA",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PIva = table.Column<string>(type: "char(11)", maxLength: 11, nullable: false),
                    Logo = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    Descrizione = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    IdUtente = table.Column<long>(type: "bigint", nullable: false),
                    ProgerssivoFattura = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TAZIENDA", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TAZIENDA_AspNetUsers_IdUtente",
                        column: x => x.IdUtente,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TAZIENDA_IdUtente",
                table: "TAZIENDA",
                column: "IdUtente");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TAZIENDA");

            migrationBuilder.DropColumn(
                name: "IdAzienda",
                table: "NEGOZIO");
        }
    }
}
