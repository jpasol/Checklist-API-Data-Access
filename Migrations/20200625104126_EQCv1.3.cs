using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EquipmentChecklistDataAccess.Migrations
{
    public partial class EQCv13 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Breakdowns");

            migrationBuilder.DropTable(
                name: "Remarks");

            migrationBuilder.DropTable(
                name: "Issues");

            migrationBuilder.DropTable(
                name: "RTGForms");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Users",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Equipments",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Components",
                newName: "ID");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Equipments",
                table: "Equipments"
                );

            migrationBuilder.AlterColumn<string>(
                name: "ID",
                table: "Equipments",
                type: "NVARCHAR(5)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "NVARCHAR(15)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Equipments",
                table: "Equipments",
                column: "ID"
                );

            migrationBuilder.AddColumn<string>(
                name: "Shortname",
                table: "Equipments",
                type: "NVARCHAR(15)",
                nullable: true);


            migrationBuilder.DropPrimaryKey(
                name: "PK_Components",
                table: "Components"
                );

            migrationBuilder.AlterColumn<string>(
                name: "ID",
                table: "Components",
                type: "NVARCHAR(5)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "NVARCHAR(15)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Components",
                table: "Components",
                column: "ID"
                );

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Components",
                type: "NVARCHAR(150)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Shortname",
                table: "Components",
                type: "NVARCHAR(15)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Checklists",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EquipmentID = table.Column<string>(nullable: true),
                    Date_Created = table.Column<DateTime>(nullable: false),
                    UserID = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Checklists", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Checklists_Equipments_EquipmentID",
                        column: x => x.EquipmentID,
                        principalTable: "Equipments",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Checklists_Users_UserID",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Condition",
                columns: table => new
                {
                    ID = table.Column<string>(type: "NVARCHAR(5)", nullable: false),
                    Shortname = table.Column<string>(type: "NVARCHAR(15)", nullable: true),
                    Description = table.Column<string>(type: "NVARCHAR(150)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Condition", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Questions",
                columns: table => new
                {
                    EquipmentID = table.Column<string>(nullable: false),
                    ComponentID = table.Column<string>(nullable: false),
                    Question_Text = table.Column<string>(type: "NVARCHAR(150)", nullable: true),
                    Rank = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Questions", x => new { x.EquipmentID, x.ComponentID });
                    table.ForeignKey(
                        name: "FK_Questions_Components_ComponentID",
                        column: x => x.ComponentID,
                        principalTable: "Components",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Questions_Equipments_EquipmentID",
                        column: x => x.EquipmentID,
                        principalTable: "Equipments",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Checklist_Items",
                columns: table => new
                {
                    ChecklistID = table.Column<int>(nullable: false),
                    EquipmentID = table.Column<string>(nullable: false),
                    ComponentID = table.Column<string>(nullable: false),
                    ConditionID = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Checklist_Items", x => new { x.ChecklistID, x.EquipmentID, x.ComponentID, x.ConditionID });
                    table.ForeignKey(
                        name: "FK_Checklist_Items_Checklists_ChecklistID",
                        column: x => x.ChecklistID,
                        principalTable: "Checklists",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Checklist_Items_Components_ComponentID",
                        column: x => x.ComponentID,
                        principalTable: "Components",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Checklist_Items_Condition_ConditionID",
                        column: x => x.ConditionID,
                        principalTable: "Condition",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Checklist_Items_Equipments_EquipmentID",
                        column: x => x.EquipmentID,
                        principalTable: "Equipments",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Checklist_Items_ComponentID",
                table: "Checklist_Items",
                column: "ComponentID");

            migrationBuilder.CreateIndex(
                name: "IX_Checklist_Items_ConditionID",
                table: "Checklist_Items",
                column: "ConditionID");

            migrationBuilder.CreateIndex(
                name: "IX_Checklist_Items_EquipmentID",
                table: "Checklist_Items",
                column: "EquipmentID");

            migrationBuilder.CreateIndex(
                name: "IX_Checklists_EquipmentID",
                table: "Checklists",
                column: "EquipmentID");

            migrationBuilder.CreateIndex(
                name: "IX_Checklists_UserID",
                table: "Checklists",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_Questions_ComponentID",
                table: "Questions",
                column: "ComponentID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Checklist_Items");

            migrationBuilder.DropTable(
                name: "Questions");

            migrationBuilder.DropTable(
                name: "Checklists");

            migrationBuilder.DropTable(
                name: "Condition");

            migrationBuilder.DropColumn(
                name: "Shortname",
                table: "Equipments");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Components");

            migrationBuilder.DropColumn(
                name: "Shortname",
                table: "Components");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Users",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Equipments",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Components",
                newName: "Id");

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Equipments",
                type: "NVARCHAR(15)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "NVARCHAR(5)");

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Components",
                type: "NVARCHAR(15)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "NVARCHAR(5)");

            migrationBuilder.CreateTable(
                name: "Issues",
                columns: table => new
                {
                    Id = table.Column<string>(type: "NVARCHAR(15)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Issues", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RTGForms",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedById = table.Column<string>(type: "NVARCHAR(15)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EquipmentId = table.Column<string>(type: "NVARCHAR(15)", nullable: false),
                    ModifiedById = table.Column<string>(type: "NVARCHAR(15)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RTGForms", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RTGForms_Users_CreatedById",
                        column: x => x.CreatedById,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RTGForms_Equipments_EquipmentId",
                        column: x => x.EquipmentId,
                        principalTable: "Equipments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RTGForms_Users_ModifiedById",
                        column: x => x.ModifiedById,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Breakdowns",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "NVARCHAR(150)", nullable: false),
                    RTGFormId = table.Column<int>(type: "int", nullable: false),
                    TimeEnd = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TimeStart = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Breakdowns", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Breakdowns_RTGForms_RTGFormId",
                        column: x => x.RTGFormId,
                        principalTable: "RTGForms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Remarks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ComponentId = table.Column<string>(type: "NVARCHAR(15)", nullable: false),
                    IssueId = table.Column<string>(type: "NVARCHAR(15)", nullable: false),
                    RTGFormId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Remarks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Remarks_Components_ComponentId",
                        column: x => x.ComponentId,
                        principalTable: "Components",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Remarks_Issues_IssueId",
                        column: x => x.IssueId,
                        principalTable: "Issues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Remarks_RTGForms_RTGFormId",
                        column: x => x.RTGFormId,
                        principalTable: "RTGForms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Breakdowns_RTGFormId",
                table: "Breakdowns",
                column: "RTGFormId");

            migrationBuilder.CreateIndex(
                name: "IX_Remarks_ComponentId",
                table: "Remarks",
                column: "ComponentId");

            migrationBuilder.CreateIndex(
                name: "IX_Remarks_IssueId",
                table: "Remarks",
                column: "IssueId");

            migrationBuilder.CreateIndex(
                name: "IX_Remarks_RTGFormId",
                table: "Remarks",
                column: "RTGFormId");

            migrationBuilder.CreateIndex(
                name: "IX_RTGForms_CreatedById",
                table: "RTGForms",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_RTGForms_EquipmentId",
                table: "RTGForms",
                column: "EquipmentId");

            migrationBuilder.CreateIndex(
                name: "IX_RTGForms_ModifiedById",
                table: "RTGForms",
                column: "ModifiedById");
        }
    }
}
