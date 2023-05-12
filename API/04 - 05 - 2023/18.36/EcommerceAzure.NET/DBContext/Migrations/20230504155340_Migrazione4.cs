using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DBContext.Migrations
{
    public partial class Migrazione4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "TAZIENDAId",
                table: "NEGOZIO",
                type: "bigint",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_NEGOZIO_IdAzienda",
                table: "NEGOZIO",
                column: "IdAzienda");

            migrationBuilder.CreateIndex(
                name: "IX_NEGOZIO_TAZIENDAId",
                table: "NEGOZIO",
                column: "TAZIENDAId");

            migrationBuilder.AddForeignKey(
                name: "FK_NEGOZIO_AZIENDA_IdAzienda",
                table: "NEGOZIO",
                column: "IdAzienda",
                principalTable: "AZIENDA",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_NEGOZIO_AZIENDA_TAZIENDAId",
                table: "NEGOZIO",
                column: "TAZIENDAId",
                principalTable: "AZIENDA",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_NEGOZIO_AZIENDA_IdAzienda",
                table: "NEGOZIO");

            migrationBuilder.DropForeignKey(
                name: "FK_NEGOZIO_AZIENDA_TAZIENDAId",
                table: "NEGOZIO");

            migrationBuilder.DropIndex(
                name: "IX_NEGOZIO_IdAzienda",
                table: "NEGOZIO");

            migrationBuilder.DropIndex(
                name: "IX_NEGOZIO_TAZIENDAId",
                table: "NEGOZIO");

            migrationBuilder.DropColumn(
                name: "TAZIENDAId",
                table: "NEGOZIO");
        }
    }
}
