using Microsoft.EntityFrameworkCore.Migrations;

namespace TodoApi.DataAccess.Migrations
{
    public partial class eighteenCrete : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "UserPassword",
                table: "Passwords",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "UserMail",
                table: "Passwords",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "NewUserPassword",
                table: "Passwords",
                nullable: true,
                oldClrType: typeof(int));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "UserPassword",
                table: "Passwords",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UserMail",
                table: "Passwords",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "NewUserPassword",
                table: "Passwords",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
