using Microsoft.EntityFrameworkCore.Migrations;

namespace Healz.Data.Migrations
{
    public partial class AddingRolls : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO AspNetRoles (Id,Name) VALUES (1,'Admin')");
            
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM AspNetRoles WHERE Id IN (1)");
        }
    }
}
