using Microsoft.EntityFrameworkCore.Migrations;

namespace YFE_API.Migrations
{
    public partial class relationsAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Username",
                table: "Staffs",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "To",
                table: "Messages",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "From",
                table: "Messages",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "ApplicantUploadId",
                table: "Documents",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "StaffUploadId",
                table: "Documents",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PhaseId",
                table: "Applicants",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Username",
                table: "Applicants",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "StaffClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StaffId = table.Column<int>(nullable: true),
                    ClaimId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StaffClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StaffClaims_Claims_ClaimId",
                        column: x => x.ClaimId,
                        principalTable: "Claims",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StaffClaims_Staffs_StaffId",
                        column: x => x.StaffId,
                        principalTable: "Staffs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "StaffRoles",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StaffId = table.Column<int>(nullable: true),
                    RoleId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StaffRoles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StaffRoles_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StaffRoles_Staffs_StaffId",
                        column: x => x.StaffId,
                        principalTable: "Staffs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Documents_ApplicantUploadId",
                table: "Documents",
                column: "ApplicantUploadId");

            migrationBuilder.CreateIndex(
                name: "IX_Documents_StaffUploadId",
                table: "Documents",
                column: "StaffUploadId");

            migrationBuilder.CreateIndex(
                name: "IX_Applicants_PhaseId",
                table: "Applicants",
                column: "PhaseId");

            migrationBuilder.CreateIndex(
                name: "IX_StaffClaims_ClaimId",
                table: "StaffClaims",
                column: "ClaimId");

            migrationBuilder.CreateIndex(
                name: "IX_StaffClaims_StaffId",
                table: "StaffClaims",
                column: "StaffId");

            migrationBuilder.CreateIndex(
                name: "IX_StaffRoles_RoleId",
                table: "StaffRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_StaffRoles_StaffId",
                table: "StaffRoles",
                column: "StaffId");

            migrationBuilder.AddForeignKey(
                name: "FK_Applicants_Phases_PhaseId",
                table: "Applicants",
                column: "PhaseId",
                principalTable: "Phases",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Documents_Applicants_ApplicantUploadId",
                table: "Documents",
                column: "ApplicantUploadId",
                principalTable: "Applicants",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Documents_Staffs_StaffUploadId",
                table: "Documents",
                column: "StaffUploadId",
                principalTable: "Staffs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Applicants_Phases_PhaseId",
                table: "Applicants");

            migrationBuilder.DropForeignKey(
                name: "FK_Documents_Applicants_ApplicantUploadId",
                table: "Documents");

            migrationBuilder.DropForeignKey(
                name: "FK_Documents_Staffs_StaffUploadId",
                table: "Documents");

            migrationBuilder.DropTable(
                name: "StaffClaims");

            migrationBuilder.DropTable(
                name: "StaffRoles");

            migrationBuilder.DropIndex(
                name: "IX_Documents_ApplicantUploadId",
                table: "Documents");

            migrationBuilder.DropIndex(
                name: "IX_Documents_StaffUploadId",
                table: "Documents");

            migrationBuilder.DropIndex(
                name: "IX_Applicants_PhaseId",
                table: "Applicants");

            migrationBuilder.DropColumn(
                name: "Username",
                table: "Staffs");

            migrationBuilder.DropColumn(
                name: "ApplicantUploadId",
                table: "Documents");

            migrationBuilder.DropColumn(
                name: "StaffUploadId",
                table: "Documents");

            migrationBuilder.DropColumn(
                name: "PhaseId",
                table: "Applicants");

            migrationBuilder.DropColumn(
                name: "Username",
                table: "Applicants");

            migrationBuilder.AlterColumn<int>(
                name: "To",
                table: "Messages",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "From",
                table: "Messages",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);
        }
    }
}
