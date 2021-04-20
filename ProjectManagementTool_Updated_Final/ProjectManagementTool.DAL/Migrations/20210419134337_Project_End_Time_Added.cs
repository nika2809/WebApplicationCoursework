using System;
using Microsoft.EntityFrameworkCore.Migrations;
using ProjectManagementTool.DAL;

namespace ProjectManagementTool.DAL.Migrations
{
    public partial class Project_End_Time_Added : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "EndTime",
                table: "Projects",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EndTime",
                table: "Projects");
        }
    }
}
