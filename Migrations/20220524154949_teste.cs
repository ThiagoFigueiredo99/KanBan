using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KanBan.Migrations
{
    public partial class teste : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cards_Sprints_IdSprint",
                table: "Cards");

            migrationBuilder.RenameColumn(
                name: "IdSprint",
                table: "Cards",
                newName: "SprintId");

            migrationBuilder.RenameIndex(
                name: "IX_Cards_IdSprint",
                table: "Cards",
                newName: "IX_Cards_SprintId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cards_Sprints_SprintId",
                table: "Cards",
                column: "SprintId",
                principalTable: "Sprints",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cards_Sprints_SprintId",
                table: "Cards");

            migrationBuilder.RenameColumn(
                name: "SprintId",
                table: "Cards",
                newName: "IdSprint");

            migrationBuilder.RenameIndex(
                name: "IX_Cards_SprintId",
                table: "Cards",
                newName: "IX_Cards_IdSprint");

            migrationBuilder.AddForeignKey(
                name: "FK_Cards_Sprints_IdSprint",
                table: "Cards",
                column: "IdSprint",
                principalTable: "Sprints",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
