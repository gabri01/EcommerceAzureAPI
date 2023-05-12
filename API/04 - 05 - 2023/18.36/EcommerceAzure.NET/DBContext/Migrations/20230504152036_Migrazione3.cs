using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DBContext.Migrations
{
    public partial class Migrazione3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TAZIENDA_AspNetUsers_IdUtente",
                table: "TAZIENDA");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TAZIENDA",
                table: "TAZIENDA");

            migrationBuilder.RenameTable(
                name: "TAZIENDA",
                newName: "AZIENDA");

            migrationBuilder.RenameIndex(
                name: "IX_TAZIENDA_IdUtente",
                table: "AZIENDA",
                newName: "IX_AZIENDA_IdUtente");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AZIENDA",
                table: "AZIENDA",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AZIENDA_AspNetUsers_IdUtente",
                table: "AZIENDA",
                column: "IdUtente",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AZIENDA_AspNetUsers_IdUtente",
                table: "AZIENDA");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AZIENDA",
                table: "AZIENDA");

            migrationBuilder.RenameTable(
                name: "AZIENDA",
                newName: "TAZIENDA");

            migrationBuilder.RenameIndex(
                name: "IX_AZIENDA_IdUtente",
                table: "TAZIENDA",
                newName: "IX_TAZIENDA_IdUtente");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TAZIENDA",
                table: "TAZIENDA",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TAZIENDA_AspNetUsers_IdUtente",
                table: "TAZIENDA",
                column: "IdUtente",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
