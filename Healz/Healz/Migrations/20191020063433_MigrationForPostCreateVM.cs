using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Healz.Migrations
{
    public partial class MigrationForPostCreateVM : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "postImgUrl",
                table: "BlogPost",
                nullable: true,
                oldClrType: typeof(byte[]),
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<byte[]>(
                name: "postImgUrl",
                table: "BlogPost",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
