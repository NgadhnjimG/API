using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace YFE_API.Migrations
{
    public partial class attributesAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Staffs",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Staffs",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Staffs",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Staffs",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "Staffs",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Staffs",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "Staffs",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "PhoneNumber",
                table: "Staffs",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<string>(
                name: "ProfilePicPath",
                table: "Staffs",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "Staffs",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Roles",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Roles",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Roles",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "Name",
                table: "Roles",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "Roles",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Phases",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Phases",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Phases",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Phases",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "Phases",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Messages",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "From",
                table: "Messages",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Messages",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Messages",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "MessageContent",
                table: "Messages",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ReadAt",
                table: "Messages",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "To",
                table: "Messages",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "Messages",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Documents",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Documents",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Documents",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Documents",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "Documents",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Claims",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Claims",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Claims",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Claims",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "Claims",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Applicants",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Applicants",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Applicants",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "Applicants",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ProfilePicPath",
                table: "Applicants",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "Applicants",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Staffs");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Staffs");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Staffs");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Staffs");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "Staffs");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Staffs");

            migrationBuilder.DropColumn(
                name: "Password",
                table: "Staffs");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "Staffs");

            migrationBuilder.DropColumn(
                name: "ProfilePicPath",
                table: "Staffs");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "Staffs");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Roles");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Roles");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Roles");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Roles");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "Roles");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Phases");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Phases");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Phases");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Phases");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "Phases");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Messages");

            migrationBuilder.DropColumn(
                name: "From",
                table: "Messages");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Messages");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Messages");

            migrationBuilder.DropColumn(
                name: "MessageContent",
                table: "Messages");

            migrationBuilder.DropColumn(
                name: "ReadAt",
                table: "Messages");

            migrationBuilder.DropColumn(
                name: "To",
                table: "Messages");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "Messages");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Documents");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Documents");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Documents");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Documents");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "Documents");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Claims");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Claims");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Claims");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Claims");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "Claims");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Applicants");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Applicants");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Applicants");

            migrationBuilder.DropColumn(
                name: "Password",
                table: "Applicants");

            migrationBuilder.DropColumn(
                name: "ProfilePicPath",
                table: "Applicants");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "Applicants");
        }
    }
}
