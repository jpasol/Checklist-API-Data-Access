using Microsoft.EntityFrameworkCore.Migrations;

namespace EquipmentChecklistDataAccess.Migrations
{
    public partial class addedQuestionEntityToChecklistItems : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Checklist_Items_Equipment_TypeID",
                table: "Checklist_Items");

            migrationBuilder.CreateIndex(
                name: "IX_Checklist_Items_Equipment_TypeID_ComponentID",
                table: "Checklist_Items",
                columns: new[] { "Equipment_TypeID", "ComponentID" });

            migrationBuilder.AddForeignKey(
                name: "FK_Checklist_Items_Questions_Equipment_TypeID_ComponentID",
                table: "Checklist_Items",
                columns: new[] { "Equipment_TypeID", "ComponentID" },
                principalTable: "Questions",
                principalColumns: new[] { "Equipment_TypeID", "ComponentID" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Checklist_Items_Questions_Equipment_TypeID_ComponentID",
                table: "Checklist_Items");

            migrationBuilder.DropIndex(
                name: "IX_Checklist_Items_Equipment_TypeID_ComponentID",
                table: "Checklist_Items");

            migrationBuilder.CreateIndex(
                name: "IX_Checklist_Items_Equipment_TypeID",
                table: "Checklist_Items",
                column: "Equipment_TypeID");
        }
    }
}
