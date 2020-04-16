using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EquipmentChecklistDataAccess.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Components",
                columns: table => new
                {
                    Id = table.Column<string>(type: "NVARCHAR(15)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Components", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Equipments",
                columns: table => new
                {
                    Id = table.Column<string>(type: "NVARCHAR(15)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Equipments", x => x.Id);
                });

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
                name: "Users",
                columns: table => new
                {
                    UserID = table.Column<string>(type: "NVARCHAR(15)", nullable: false),
                    Name = table.Column<string>(type: "NVARCHAR(50)", nullable: true),
                    Password = table.Column<string>(type: "NVARCHAR(50)", nullable: true),
                    isActive = table.Column<bool>(type: "BIT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserID);
                });

            migrationBuilder.CreateTable(
                name: "RTGForms",
                columns: table => new
                {
                    Id = table.Column<string>(type: "NVARCHAR(15)", nullable: false),
                    EquipmentIDId = table.Column<string>(nullable: true),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    DateModified = table.Column<DateTime>(nullable: false),
                    CreatedByUserID = table.Column<string>(nullable: true),
                    ModifiedByUserID = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RTGForms", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RTGForms_Users_CreatedByUserID",
                        column: x => x.CreatedByUserID,
                        principalTable: "Users",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RTGForms_Equipments_EquipmentIDId",
                        column: x => x.EquipmentIDId,
                        principalTable: "Equipments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RTGForms_Users_ModifiedByUserID",
                        column: x => x.ModifiedByUserID,
                        principalTable: "Users",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Breakdowns",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RTGFormIDId = table.Column<string>(nullable: true),
                    TimeStart = table.Column<DateTime>(nullable: false),
                    TimeEnd = table.Column<DateTime>(nullable: false),
                    Description = table.Column<string>(type: "NVARCHAR(150)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Breakdowns", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Breakdowns_RTGForms_RTGFormIDId",
                        column: x => x.RTGFormIDId,
                        principalTable: "RTGForms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Remarks",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RTGFormIDId = table.Column<string>(nullable: true),
                    IssueIDId = table.Column<string>(nullable: true),
                    ComponentIDId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Remarks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Remarks_Components_ComponentIDId",
                        column: x => x.ComponentIDId,
                        principalTable: "Components",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Remarks_Issues_IssueIDId",
                        column: x => x.IssueIDId,
                        principalTable: "Issues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Remarks_RTGForms_RTGFormIDId",
                        column: x => x.RTGFormIDId,
                        principalTable: "RTGForms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Breakdowns_RTGFormIDId",
                table: "Breakdowns",
                column: "RTGFormIDId");

            migrationBuilder.CreateIndex(
                name: "IX_Remarks_ComponentIDId",
                table: "Remarks",
                column: "ComponentIDId");

            migrationBuilder.CreateIndex(
                name: "IX_Remarks_IssueIDId",
                table: "Remarks",
                column: "IssueIDId");

            migrationBuilder.CreateIndex(
                name: "IX_Remarks_RTGFormIDId",
                table: "Remarks",
                column: "RTGFormIDId");

            migrationBuilder.CreateIndex(
                name: "IX_RTGForms_CreatedByUserID",
                table: "RTGForms",
                column: "CreatedByUserID");

            migrationBuilder.CreateIndex(
                name: "IX_RTGForms_EquipmentIDId",
                table: "RTGForms",
                column: "EquipmentIDId");

            migrationBuilder.CreateIndex(
                name: "IX_RTGForms_ModifiedByUserID",
                table: "RTGForms",
                column: "ModifiedByUserID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Breakdowns");

            migrationBuilder.DropTable(
                name: "Remarks");

            migrationBuilder.DropTable(
                name: "Components");

            migrationBuilder.DropTable(
                name: "Issues");

            migrationBuilder.DropTable(
                name: "RTGForms");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Equipments");
        }
    }
}
