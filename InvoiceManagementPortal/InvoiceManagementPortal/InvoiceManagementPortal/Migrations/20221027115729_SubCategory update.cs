using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InvoiceManagementPortal.Migrations
{
    public partial class SubCategoryupdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "SubCategories");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "SubCategories",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
