using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KanBan.Migrations
{
    public partial class teste2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cards_Users_IdUser",
                table: "Cards");

            migrationBuilder.RenameColumn(
                name: "IdUser",
                table: "Cards",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Cards_IdUser",
                table: "Cards",
                newName: "IX_Cards_UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cards_Users_UserId",
                table: "Cards",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cards_Users_UserId",
                table: "Cards");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Cards",
                newName: "IdUser");

            migrationBuilder.RenameIndex(
                name: "IX_Cards_UserId",
                table: "Cards",
                newName: "IX_Cards_IdUser");

            migrationBuilder.AddForeignKey(
                name: "FK_Cards_Users_IdUser",
                table: "Cards",
                column: "IdUser",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
