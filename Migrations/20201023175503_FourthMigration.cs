using Microsoft.EntityFrameworkCore.Migrations;

namespace MacroWeb.Migrations
{
    public partial class FourthMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Messages_Messages_CenterId",
                table: "Messages");

            migrationBuilder.AddForeignKey(
                name: "FK_Messages_Messages_CenterId",
                table: "Messages",
                column: "CenterId",
                principalTable: "Messages",
                principalColumn: "MessageId",
                onDelete: ReferentialAction.SetNull);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Messages_Messages_CenterId",
                table: "Messages");

            migrationBuilder.AddForeignKey(
                name: "FK_Messages_Messages_CenterId",
                table: "Messages",
                column: "CenterId",
                principalTable: "Messages",
                principalColumn: "MessageId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
