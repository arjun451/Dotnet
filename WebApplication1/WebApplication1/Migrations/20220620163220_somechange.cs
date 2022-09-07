using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication1.Migrations
{
    public partial class somechange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "userFollows",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "userFollows",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "UserFollowId",
                table: "AspNetUsers",
                type: "int",
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
    }
}
