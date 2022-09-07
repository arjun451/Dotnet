using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExitTest.Migrations
{
    public partial class Follow : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "follows",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FollowName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FallowProfileUrl = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_follows", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "follows");
        }
    }
}
