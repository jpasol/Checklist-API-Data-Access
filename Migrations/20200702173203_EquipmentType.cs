using Microsoft.EntityFrameworkCore.Migrations;

namespace EquipmentChecklistDataAccess.Migrations
{
    public partial class EquipmentType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Checklist_Items_Condition_ConditionID",
                table: "Checklist_Items");

            migrationBuilder.DropForeignKey(
                name: "FK_Checklist_Items_Equipments_EquipmentID",
                table: "Checklist_Items");

            migrationBuilder.DropForeignKey(
                name: "FK_Questions_Equipments_EquipmentID",
                table: "Questions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Questions",
                table: "Questions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Checklist_Items",
                table: "Checklist_Items");

            migrationBuilder.DropIndex(
                name: "IX_Checklist_Items_EquipmentID",
                table: "Checklist_Items");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Condition",
                table: "Condition");

            migrationBuilder.DropColumn(
                name: "EquipmentID",
                table: "Questions");

            migrationBuilder.DropColumn(
                name: "EquipmentID",
                table: "Checklist_Items");

            migrationBuilder.RenameTable(
                name: "Condition",
                newName: "Conditions");

            migrationBuilder.AddColumn<string>(
                name: "Equipment_TypeID",
                table: "Questions",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Equipment_TypeID",
                table: "Equipments",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Equipment_TypeID",
                table: "Checklist_Items",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Questions",
                table: "Questions",
                columns: new[] { "Equipment_TypeID", "ComponentID" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Checklist_Items",
                table: "Checklist_Items",
                columns: new[] { "ChecklistID", "Equipment_TypeID", "ComponentID", "ConditionID" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Conditions",
                table: "Conditions",
                column: "ID");

            migrationBuilder.CreateTable(
                name: "Equipment_Types",
                columns: table => new
                {
                    ID = table.Column<string>(type: "NVARCHAR(5)", nullable: false),
                    Shortname = table.Column<string>(type: "NVARCHAR(15)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Equipment_Types", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Equipments_Equipment_TypeID",
                table: "Equipments",
                column: "Equipment_TypeID");

            migrationBuilder.CreateIndex(
                name: "IX_Checklist_Items_Equipment_TypeID",
                table: "Checklist_Items",
                column: "Equipment_TypeID");

            migrationBuilder.AddForeignKey(
                name: "FK_Checklist_Items_Conditions_ConditionID",
                table: "Checklist_Items",
                column: "ConditionID",
                principalTable: "Conditions",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Checklist_Items_Equipment_Types_Equipment_TypeID",
                table: "Checklist_Items",
                column: "Equipment_TypeID",
                principalTable: "Equipment_Types",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Equipments_Equipment_Types_Equipment_TypeID",
                table: "Equipments",
                column: "Equipment_TypeID",
                principalTable: "Equipment_Types",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Questions_Equipment_Types_Equipment_TypeID",
                table: "Questions",
                column: "Equipment_TypeID",
                principalTable: "Equipment_Types",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Checklist_Items_Conditions_ConditionID",
                table: "Checklist_Items");

            migrationBuilder.DropForeignKey(
                name: "FK_Checklist_Items_Equipment_Types_Equipment_TypeID",
                table: "Checklist_Items");

            migrationBuilder.DropForeignKey(
                name: "FK_Equipments_Equipment_Types_Equipment_TypeID",
                table: "Equipments");

            migrationBuilder.DropForeignKey(
                name: "FK_Questions_Equipment_Types_Equipment_TypeID",
                table: "Questions");

            migrationBuilder.DropTable(
                name: "Equipment_Types");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Questions",
                table: "Questions");

            migrationBuilder.DropIndex(
                name: "IX_Equipments_Equipment_TypeID",
                table: "Equipments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Checklist_Items",
                table: "Checklist_Items");

            migrationBuilder.DropIndex(
                name: "IX_Checklist_Items_Equipment_TypeID",
                table: "Checklist_Items");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Conditions",
                table: "Conditions");

            migrationBuilder.DropColumn(
                name: "Equipment_TypeID",
                table: "Questions");

            migrationBuilder.DropColumn(
                name: "Equipment_TypeID",
                table: "Equipments");

            migrationBuilder.DropColumn(
                name: "Equipment_TypeID",
                table: "Checklist_Items");

            migrationBuilder.RenameTable(
                name: "Conditions",
                newName: "Condition");

            migrationBuilder.AddColumn<string>(
                name: "EquipmentID",
                table: "Questions",
                type: "NVARCHAR(5)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "EquipmentID",
                table: "Checklist_Items",
                type: "NVARCHAR(5)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Questions",
                table: "Questions",
                columns: new[] { "EquipmentID", "ComponentID" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Checklist_Items",
                table: "Checklist_Items",
                columns: new[] { "ChecklistID", "EquipmentID", "ComponentID", "ConditionID" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Condition",
                table: "Condition",
                column: "ID");

            migrationBuilder.CreateIndex(
                name: "IX_Checklist_Items_EquipmentID",
                table: "Checklist_Items",
                column: "EquipmentID");

            migrationBuilder.AddForeignKey(
                name: "FK_Checklist_Items_Condition_ConditionID",
                table: "Checklist_Items",
                column: "ConditionID",
                principalTable: "Condition",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Checklist_Items_Equipments_EquipmentID",
                table: "Checklist_Items",
                column: "EquipmentID",
                principalTable: "Equipments",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Questions_Equipments_EquipmentID",
                table: "Questions",
                column: "EquipmentID",
                principalTable: "Equipments",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
