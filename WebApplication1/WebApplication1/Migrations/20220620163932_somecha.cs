using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication1.Migrations
{
    public partial class somecha : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserFollowId",
                table: "AspNetUsers",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_UserFollowId",
                table: "AspNetUsers",
                column: "UserFollowId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_userFollows_UserFollowId",
                table: "AspNetUsers",
                column: "UserFollowId",
                principalTable: "userFollows",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_userFollows_UserFollowId",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_UserFollowId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "UserFollowId",
                table: "AspNetUsers");
        }
    }
}
