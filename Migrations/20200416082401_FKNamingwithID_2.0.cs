using Microsoft.EntityFrameworkCore.Migrations;

namespace EquipmentChecklistDataAccess.Migrations
{
    public partial class FKNamingwithID_20 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Remarks_Components_ComponentIDId",
                table: "Remarks");

            migrationBuilder.DropForeignKey(
                name: "FK_Remarks_Issues_IssueIDId",
                table: "Remarks");

            migrationBuilder.DropForeignKey(
                name: "FK_RTGForms_Users_CreatedByUserID",
                table: "RTGForms");

            migrationBuilder.DropForeignKey(
                name: "FK_RTGForms_Users_ModifiedByUserID",
                table: "RTGForms");

            migrationBuilder.DropIndex(
                name: "IX_RTGForms_CreatedByUserID",
                table: "RTGForms");

            migrationBuilder.DropIndex(
                name: "IX_RTGForms_ModifiedByUserID",
                table: "RTGForms");

            migrationBuilder.DropIndex(
                name: "IX_Remarks_ComponentIDId",
                table: "Remarks");

            migrationBuilder.DropIndex(
                name: "IX_Remarks_IssueIDId",
                table: "Remarks");

            migrationBuilder.DropColumn(
                name: "CreatedByUserID",
                table: "RTGForms");

            migrationBuilder.DropColumn(
                name: "ModifiedByUserID",
                table: "RTGForms");

            migrationBuilder.DropColumn(
                name: "ComponentIDId",
                table: "Remarks");

            migrationBuilder.DropColumn(
                name: "IssueIDId",
                table: "Remarks");

            migrationBuilder.RenameColumn(
                name: "UserID",
                table: "Users",
                newName: "Id");

            migrationBuilder.AddColumn<string>(
                name: "CreatedById",
                table: "RTGForms",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ModifiedById",
                table: "RTGForms",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ComponentId",
                table: "Remarks",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IssueId",
                table: "Remarks",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_RTGForms_CreatedById",
                table: "RTGForms",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_RTGForms_ModifiedById",
                table: "RTGForms",
                column: "ModifiedById");

            migrationBuilder.CreateIndex(
                name: "IX_Remarks_ComponentId",
                table: "Remarks",
                column: "ComponentId");

            migrationBuilder.CreateIndex(
                name: "IX_Remarks_IssueId",
                table: "Remarks",
                column: "IssueId");

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
                name: "FK_RTGForms_Users_CreatedById",
                table: "RTGForms",
                column: "CreatedById",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_RTGForms_Users_ModifiedById",
                table: "RTGForms",
                column: "ModifiedById",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Remarks_Components_ComponentId",
                table: "Remarks");

            migrationBuilder.DropForeignKey(
                name: "FK_Remarks_Issues_IssueId",
                table: "Remarks");

            migrationBuilder.DropForeignKey(
                name: "FK_RTGForms_Users_CreatedById",
                table: "RTGForms");

            migrationBuilder.DropForeignKey(
                name: "FK_RTGForms_Users_ModifiedById",
                table: "RTGForms");

            migrationBuilder.DropIndex(
                name: "IX_RTGForms_CreatedById",
                table: "RTGForms");

            migrationBuilder.DropIndex(
                name: "IX_RTGForms_ModifiedById",
                table: "RTGForms");

            migrationBuilder.DropIndex(
                name: "IX_Remarks_ComponentId",
                table: "Remarks");

            migrationBuilder.DropIndex(
                name: "IX_Remarks_IssueId",
                table: "Remarks");

            migrationBuilder.DropColumn(
                name: "CreatedById",
                table: "RTGForms");

            migrationBuilder.DropColumn(
                name: "ModifiedById",
                table: "RTGForms");

            migrationBuilder.DropColumn(
                name: "ComponentId",
                table: "Remarks");

            migrationBuilder.DropColumn(
                name: "IssueId",
                table: "Remarks");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Users",
                newName: "UserID");

            migrationBuilder.AddColumn<string>(
                name: "CreatedByUserID",
                table: "RTGForms",
                type: "NVARCHAR(15)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ModifiedByUserID",
                table: "RTGForms",
                type: "NVARCHAR(15)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ComponentIDId",
                table: "Remarks",
                type: "NVARCHAR(15)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IssueIDId",
                table: "Remarks",
                type: "NVARCHAR(15)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_RTGForms_CreatedByUserID",
                table: "RTGForms",
                column: "CreatedByUserID");

            migrationBuilder.CreateIndex(
                name: "IX_RTGForms_ModifiedByUserID",
                table: "RTGForms",
                column: "ModifiedByUserID");

            migrationBuilder.CreateIndex(
                name: "IX_Remarks_ComponentIDId",
                table: "Remarks",
                column: "ComponentIDId");

            migrationBuilder.CreateIndex(
                name: "IX_Remarks_IssueIDId",
                table: "Remarks",
                column: "IssueIDId");

            migrationBuilder.AddForeignKey(
                name: "FK_Remarks_Components_ComponentIDId",
                table: "Remarks",
                column: "ComponentIDId",
                principalTable: "Components",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Remarks_Issues_IssueIDId",
                table: "Remarks",
                column: "IssueIDId",
                principalTable: "Issues",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_RTGForms_Users_CreatedByUserID",
                table: "RTGForms",
                column: "CreatedByUserID",
                principalTable: "Users",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_RTGForms_Users_ModifiedByUserID",
                table: "RTGForms",
                column: "ModifiedByUserID",
                principalTable: "Users",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
