using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DBContext.Migrations
{
    public partial class Migrazione3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "IdUtente",
                table: "ORDINE",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateIndex(
                name: "IX_ORDINE_IdUtente",
                table: "ORDINE",
                column: "IdUtente");

            migrationBuilder.AddForeignKey(
                name: "FK_ORDINE_AspNetUsers_IdUtente",
                table: "ORDINE",
                column: "IdUtente",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ORDINE_AspNetUsers_IdUtente",
                table: "ORDINE");

            migrationBuilder.DropIndex(
                name: "IX_ORDINE_IdUtente",
                table: "ORDINE");

            migrationBuilder.DropColumn(
                name: "IdUtente",
                table: "ORDINE");
        }
    }
}
