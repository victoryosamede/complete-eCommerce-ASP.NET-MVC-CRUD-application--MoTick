using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MoTick.Migrations
{
    public partial class Change : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Movies",
                newName: "Synopsis");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Synopsis",
                table: "Movies",
                newName: "Description");
        }
    }
}
