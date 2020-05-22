using Microsoft.EntityFrameworkCore.Migrations;

namespace MPBackends.Migrations
{
    public partial class modifyStatus : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Status",
                table: "Uploadvideo",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Status",
                table: "Uploadvideo",
                type: "text",
                nullable: true,
                oldClrType: typeof(int));
        }
    }
}
