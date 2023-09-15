using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TodoApi.DataAccess.Migrations
{
    public partial class fourthCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EndDate",
                table: "Todos");

            migrationBuilder.DropColumn(
                name: "StartDate",
                table: "Todos");

            migrationBuilder.AlterColumn<int>(
                name: "TdStatus",
                table: "Todos",
                nullable: false,
                oldClrType: typeof(bool));

            migrationBuilder.AddColumn<bool>(
                name: "TdFavorite",
                table: "Todos",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "TdTitle",
                table: "Todos",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TdFavorite",
                table: "Todos");

            migrationBuilder.DropColumn(
                name: "TdTitle",
                table: "Todos");

            migrationBuilder.AlterColumn<bool>(
                name: "TdStatus",
                table: "Todos",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<DateTime>(
                name: "EndDate",
                table: "Todos",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "StartDate",
                table: "Todos",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
