using Microsoft.EntityFrameworkCore.Migrations;

namespace EquipmentChecklistDataAccess.Migrations
{
    public partial class ReplaceKeyRTGForm : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Breakdowns_RTGForms_RTGFormId",
                table: "Breakdowns");

            migrationBuilder.DropForeignKey(
                name: "FK_Remarks_RTGForms_RTGFormId",
                table: "Remarks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RTGForms",
                table: "RTGForms");

            migrationBuilder.DropIndex(
                name: "IX_Remarks_RTGFormId",
                table: "Remarks");

            migrationBuilder.DropIndex(
                name: "IX_Breakdowns_RTGFormId",
                table: "Breakdowns");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "RTGForms");

            migrationBuilder.DropColumn(
                name: "RTGFormId",
                table: "Remarks");

            migrationBuilder.DropColumn(
                name: "RTGFormId",
                table: "Breakdowns");

            migrationBuilder.AddColumn<string>(
                name: "TempId",
                table: "RTGForms",
                type: "NVARCHAR(15)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "RTGFormTempId",
                table: "Remarks",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "RTGFormTempId",
                table: "Breakdowns",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RTGForms",
                table: "RTGForms",
                column: "TempId");

            migrationBuilder.CreateIndex(
                name: "IX_Remarks_RTGFormTempId",
                table: "Remarks",
                column: "RTGFormTempId");

            migrationBuilder.CreateIndex(
                name: "IX_Breakdowns_RTGFormTempId",
                table: "Breakdowns",
                column: "RTGFormTempId");

            migrationBuilder.AddForeignKey(
                name: "FK_Breakdowns_RTGForms_RTGFormTempId",
                table: "Breakdowns",
                column: "RTGFormTempId",
                principalTable: "RTGForms",
                principalColumn: "TempId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Remarks_RTGForms_RTGFormTempId",
                table: "Remarks",
                column: "RTGFormTempId",
                principalTable: "RTGForms",
                principalColumn: "TempId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Breakdowns_RTGForms_RTGFormTempId",
                table: "Breakdowns");

            migrationBuilder.DropForeignKey(
                name: "FK_Remarks_RTGForms_RTGFormTempId",
                table: "Remarks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RTGForms",
                table: "RTGForms");

            migrationBuilder.DropIndex(
                name: "IX_Remarks_RTGFormTempId",
                table: "Remarks");

            migrationBuilder.DropIndex(
                name: "IX_Breakdowns_RTGFormTempId",
                table: "Breakdowns");

            migrationBuilder.DropColumn(
                name: "TempId",
                table: "RTGForms");

            migrationBuilder.DropColumn(
                name: "RTGFormTempId",
                table: "Remarks");

            migrationBuilder.DropColumn(
                name: "RTGFormTempId",
                table: "Breakdowns");

            migrationBuilder.AddColumn<string>(
                name: "Id",
                table: "RTGForms",
                type: "NVARCHAR(15)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "RTGFormId",
                table: "Remarks",
                type: "NVARCHAR(15)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "RTGFormId",
                table: "Breakdowns",
                type: "NVARCHAR(15)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RTGForms",
                table: "RTGForms",
                column: "Id");

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
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Remarks_RTGForms_RTGFormId",
                table: "Remarks",
                column: "RTGFormId",
                principalTable: "RTGForms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
