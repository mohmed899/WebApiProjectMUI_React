using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApiProjectMUI_React.Migrations
{
    public partial class v1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "payment",
                table: "order");

            migrationBuilder.AlterColumn<string>(
                name: "OrderNumber",
                table: "order",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "OrderNumber",
                table: "order",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "payment",
                table: "order",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
