using Microsoft.EntityFrameworkCore.Migrations;

namespace EquipmentChecklistDataAccess.Migrations
{
    public partial class FKNamingwithID : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Breakdowns_RTGForms_RTGFormIDId",
                table: "Breakdowns");

            migrationBuilder.DropForeignKey(
                name: "FK_Remarks_RTGForms_RTGFormIDId",
                table: "Remarks");

            migrationBuilder.DropForeignKey(
                name: "FK_RTGForms_Equipments_EquipmentIDId",
                table: "RTGForms");

            migrationBuilder.DropIndex(
                name: "IX_RTGForms_EquipmentIDId",
                table: "RTGForms");

            migrationBuilder.DropIndex(
                name: "IX_Remarks_RTGFormIDId",
                table: "Remarks");

            migrationBuilder.DropIndex(
                name: "IX_Breakdowns_RTGFormIDId",
                table: "Breakdowns");

            migrationBuilder.DropColumn(
                name: "EquipmentIDId",
                table: "RTGForms");

            migrationBuilder.DropColumn(
                name: "RTGFormIDId",
                table: "Remarks");

            migrationBuilder.DropColumn(
                name: "RTGFormIDId",
                table: "Breakdowns");

            migrationBuilder.AddColumn<string>(
                name: "EquipmentId",
                table: "RTGForms",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RTGFormId",
                table: "Remarks",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RTGFormId",
                table: "Breakdowns",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_RTGForms_EquipmentId",
                table: "RTGForms",
                column: "EquipmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Remarks_RTGFormId",
                table: "Remarks",
                column: "RTGFormId");

            migrationBuilder.CreateIndex(
                name: "IX_Breakdowns_RTGFormId",
                table: "Breakdowns",
                column: "RTGFormId");

            migrationBuilder.AddForeignKey(
                name: "FK_Breakdowns_RTGForms_RTGFormId",
                table: "Breakdowns",
                column: "RTGFormId",
                principalTable: "RTGForms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Remarks_RTGForms_RTGFormId",
                table: "Remarks",
                column: "RTGFormId",
                principalTable: "RTGForms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_RTGForms_Equipments_EquipmentId",
                table: "RTGForms",
                column: "EquipmentId",
                principalTable: "Equipments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Breakdowns_RTGForms_RTGFormId",
                table: "Breakdowns");

            migrationBuilder.DropForeignKey(
                name: "FK_Remarks_RTGForms_RTGFormId",
                table: "Remarks");

            migrationBuilder.DropForeignKey(
                name: "FK_RTGForms_Equipments_EquipmentId",
                table: "RTGForms");

            migrationBuilder.DropIndex(
                name: "IX_RTGForms_EquipmentId",
                table: "RTGForms");

            migrationBuilder.DropIndex(
                name: "IX_Remarks_RTGFormId",
                table: "Remarks");

            migrationBuilder.DropIndex(
                name: "IX_Breakdowns_RTGFormId",
                table: "Breakdowns");

            migrationBuilder.DropColumn(
                name: "EquipmentId",
                table: "RTGForms");

            migrationBuilder.DropColumn(
                name: "RTGFormId",
                table: "Remarks");

            migrationBuilder.DropColumn(
                name: "RTGFormId",
                table: "Breakdowns");

            migrationBuilder.AddColumn<string>(
                name: "EquipmentIDId",
                table: "RTGForms",
                type: "NVARCHAR(15)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RTGFormIDId",
                table: "Remarks",
                type: "NVARCHAR(15)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RTGFormIDId",
                table: "Breakdowns",
                type: "NVARCHAR(15)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_RTGForms_EquipmentIDId",
                table: "RTGForms",
                column: "EquipmentIDId");

            migrationBuilder.CreateIndex(
                name: "IX_Remarks_RTGFormIDId",
                table: "Remarks",
                column: "RTGFormIDId");

            migrationBuilder.CreateIndex(
                name: "IX_Breakdowns_RTGFormIDId",
                table: "Breakdowns",
                column: "RTGFormIDId");

            migrationBuilder.AddForeignKey(
                name: "FK_Breakdowns_RTGForms_RTGFormIDId",
                table: "Breakdowns",
                column: "RTGFormIDId",
                principalTable: "RTGForms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Remarks_RTGForms_RTGFormIDId",
                table: "Remarks",
                column: "RTGFormIDId",
                principalTable: "RTGForms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_RTGForms_Equipments_EquipmentIDId",
                table: "RTGForms",
                column: "EquipmentIDId",
                principalTable: "Equipments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
