using Microsoft.EntityFrameworkCore.Migrations;

namespace TodoApi.DataAccess.Migrations
{
    public partial class fifteenthCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "NewUserPassword",
                table: "Usernames",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NewUserPassword",
                table: "Usernames");
        }
    }
}
