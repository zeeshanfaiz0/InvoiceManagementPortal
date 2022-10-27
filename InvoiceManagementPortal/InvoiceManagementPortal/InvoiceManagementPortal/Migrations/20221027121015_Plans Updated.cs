using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InvoiceManagementPortal.Migrations
{
    public partial class PlansUpdated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Type",
                table: "ServicePlans",
                newName: "Plan");

            migrationBuilder.CreateTable(
                name: "PlansType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Plan = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlansType", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ServicePlans_Plan",
                table: "ServicePlans",
                column: "Plan");

            migrationBuilder.AddForeignKey(
                name: "FK_ServicePlans_PlansType_Plan",
                table: "ServicePlans",
                column: "Plan",
                principalTable: "PlansType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ServicePlans_PlansType_Plan",
                table: "ServicePlans");

            migrationBuilder.DropTable(
                name: "PlansType");

            migrationBuilder.DropIndex(
                name: "IX_ServicePlans_Plan",
                table: "ServicePlans");

            migrationBuilder.RenameColumn(
                name: "Plan",
                table: "ServicePlans",
                newName: "Type");
        }
    }
}
