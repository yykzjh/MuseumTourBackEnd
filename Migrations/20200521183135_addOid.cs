using Microsoft.EntityFrameworkCore.Migrations;

namespace MPBackends.Migrations
{
    public partial class addOid : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Oid",
                table: "Uploadvideo",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Oid",
                table: "Uploadvideo");
        }
    }
}
