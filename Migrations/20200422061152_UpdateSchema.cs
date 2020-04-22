using Microsoft.EntityFrameworkCore.Migrations;

namespace EquipmentChecklistDataAccess.Migrations
{
    public partial class UpdateSchema : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Breakdowns_RTGForms_RTGFormId",
                table: "Breakdowns");

            migrationBuilder.DropForeignKey(
                name: "FK_Remarks_Components_ComponentId",
                table: "Remarks");

            migrationBuilder.DropForeignKey(
                name: "FK_Remarks_Issues_IssueId",
                table: "Remarks");

            migrationBuilder.DropForeignKey(
                name: "FK_Remarks_RTGForms_RTGFormId",
                table: "Remarks");

            migrationBuilder.DropForeignKey(
                name: "FK_RTGForms_Users_CreatedById",
                table: "RTGForms");

            migrationBuilder.DropForeignKey(
                name: "FK_RTGForms_Equipments_EquipmentId",
                table: "RTGForms");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Users");

            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "Users",
                type: "NVARCHAR(25)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "NVARCHAR(50)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "Users",
                type: "NVARCHAR(25)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "Users",
                type: "NVARCHAR(20)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "MiddleName",
                table: "Users",
                type: "NVARCHAR(20)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "EquipmentId",
                table: "RTGForms",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "NVARCHAR(15)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedById",
                table: "RTGForms",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "NVARCHAR(15)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "RTGFormId",
                table: "Remarks",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "NVARCHAR(15)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "IssueId",
                table: "Remarks",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "NVARCHAR(15)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ComponentId",
                table: "Remarks",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "NVARCHAR(15)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "RTGFormId",
                table: "Breakdowns",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "NVARCHAR(15)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Breakdowns",
                type: "NVARCHAR(150)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "NVARCHAR(150)",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Breakdowns_RTGForms_RTGFormId",
                table: "Breakdowns",
                column: "RTGFormId",
                principalTable: "RTGForms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Remarks_Components_ComponentId",
                table: "Remarks",
                column: "ComponentId",
                principalTable: "Components",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Remarks_Issues_IssueId",
                table: "Remarks",
                column: "IssueId",
                principalTable: "Issues",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Remarks_RTGForms_RTGFormId",
                table: "Remarks",
                column: "RTGFormId",
                principalTable: "RTGForms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RTGForms_Users_CreatedById",
                table: "RTGForms",
                column: "CreatedById",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RTGForms_Equipments_EquipmentId",
                table: "RTGForms",
                column: "EquipmentId",
                principalTable: "Equipments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Breakdowns_RTGForms_RTGFormId",
                table: "Breakdowns");

            migrationBuilder.DropForeignKey(
                name: "FK_Remarks_Components_ComponentId",
                table: "Remarks");

            migrationBuilder.DropForeignKey(
                name: "FK_Remarks_Issues_IssueId",
                table: "Remarks");

            migrationBuilder.DropForeignKey(
                name: "FK_Remarks_RTGForms_RTGFormId",
                table: "Remarks");

            migrationBuilder.DropForeignKey(
                name: "FK_RTGForms_Users_CreatedById",
                table: "RTGForms");

            migrationBuilder.DropForeignKey(
                name: "FK_RTGForms_Equipments_EquipmentId",
                table: "RTGForms");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "MiddleName",
                table: "Users");

            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "Users",
                type: "NVARCHAR(50)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "NVARCHAR(25)");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Users",
                type: "NVARCHAR(50)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "EquipmentId",
                table: "RTGForms",
                type: "NVARCHAR(15)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "CreatedById",
                table: "RTGForms",
                type: "NVARCHAR(15)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "RTGFormId",
                table: "Remarks",
                type: "NVARCHAR(15)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "IssueId",
                table: "Remarks",
                type: "NVARCHAR(15)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "ComponentId",
                table: "Remarks",
                type: "NVARCHAR(15)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "RTGFormId",
                table: "Breakdowns",
                type: "NVARCHAR(15)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Breakdowns",
                type: "NVARCHAR(150)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "NVARCHAR(150)");

            migrationBuilder.AddForeignKey(
                name: "FK_Breakdowns_RTGForms_RTGFormId",
                table: "Breakdowns",
                column: "RTGFormId",
                principalTable: "RTGForms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Remarks_Components_ComponentId",
                table: "Remarks",
                column: "ComponentId",
                principalTable: "Components",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Remarks_Issues_IssueId",
                table: "Remarks",
                column: "IssueId",
                principalTable: "Issues",
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
                name: "FK_RTGForms_Users_CreatedById",
                table: "RTGForms",
                column: "CreatedById",
                principalTable: "Users",
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
    }
}
