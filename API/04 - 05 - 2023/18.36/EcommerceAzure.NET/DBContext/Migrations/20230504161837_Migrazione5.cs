using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DBContext.Migrations
{
    public partial class Migrazione5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "TNEGOZIOId",
                table: "ORDINE",
                type: "bigint",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ORDINE_IdNegozio",
                table: "ORDINE",
                column: "IdNegozio");

            migrationBuilder.CreateIndex(
                name: "IX_ORDINE_TNEGOZIOId",
                table: "ORDINE",
                column: "TNEGOZIOId");

            migrationBuilder.AddForeignKey(
                name: "FK_ORDINE_NEGOZIO_IdNegozio",
                table: "ORDINE",
                column: "IdNegozio",
                principalTable: "NEGOZIO",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ORDINE_NEGOZIO_TNEGOZIOId",
                table: "ORDINE",
                column: "TNEGOZIOId",
                principalTable: "NEGOZIO",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ORDINE_NEGOZIO_IdNegozio",
                table: "ORDINE");

            migrationBuilder.DropForeignKey(
                name: "FK_ORDINE_NEGOZIO_TNEGOZIOId",
                table: "ORDINE");

            migrationBuilder.DropIndex(
                name: "IX_ORDINE_IdNegozio",
                table: "ORDINE");

            migrationBuilder.DropIndex(
                name: "IX_ORDINE_TNEGOZIOId",
                table: "ORDINE");

            migrationBuilder.DropColumn(
                name: "TNEGOZIOId",
                table: "ORDINE");
        }
    }
}
