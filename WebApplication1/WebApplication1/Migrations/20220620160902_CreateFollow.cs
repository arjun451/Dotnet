using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication1.Migrations
{
    public partial class CreateFollow : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "followersCount");

            migrationBuilder.AddColumn<int>(
                name: "Follow",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Followers",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UserFollowId",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "userFollows",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FollowUserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FallowUserProfileUrl = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_userFollows", x => x.Id);
                });

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

            migrationBuilder.DropTable(
                name: "userFollows");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_UserFollowId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Follow",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Followers",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "UserFollowId",
                table: "AspNetUsers");

            migrationBuilder.CreateTable(
                name: "followersCount",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FollowCount = table.Column<int>(type: "int", nullable: false),
                    FollowersCount = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_followersCount", x => x.Id);
                });
        }
    }
}
