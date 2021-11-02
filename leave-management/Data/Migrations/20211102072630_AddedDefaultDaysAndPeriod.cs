using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace leave_management.Data.Migrations
{
    public partial class AddedDefaultDaysAndPeriod : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LeaveAllocationS_AspNetUsers_EmployeeId",
                table: "LeaveAllocationS");

            migrationBuilder.DropForeignKey(
                name: "FK_LeaveAllocationS_LeaveTypes_LeaveTypeId",
                table: "LeaveAllocationS");

            migrationBuilder.DropPrimaryKey(
                name: "PK_LeaveAllocationS",
                table: "LeaveAllocationS");

            migrationBuilder.RenameTable(
                name: "LeaveAllocationS",
                newName: "LeaveAllocations");

            migrationBuilder.RenameIndex(
                name: "IX_LeaveAllocationS_LeaveTypeId",
                table: "LeaveAllocations",
                newName: "IX_LeaveAllocations_LeaveTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_LeaveAllocationS_EmployeeId",
                table: "LeaveAllocations",
                newName: "IX_LeaveAllocations_EmployeeId");

            migrationBuilder.AddColumn<int>(
                name: "DefaultDays",
                table: "LeaveTypes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Period",
                table: "LeaveAllocations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_LeaveAllocations",
                table: "LeaveAllocations",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "DetailsLeaveTypeVM",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetailsLeaveTypeVM", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_LeaveAllocations_AspNetUsers_EmployeeId",
                table: "LeaveAllocations",
                column: "EmployeeId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_LeaveAllocations_LeaveTypes_LeaveTypeId",
                table: "LeaveAllocations",
                column: "LeaveTypeId",
                principalTable: "LeaveTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LeaveAllocations_AspNetUsers_EmployeeId",
                table: "LeaveAllocations");

            migrationBuilder.DropForeignKey(
                name: "FK_LeaveAllocations_LeaveTypes_LeaveTypeId",
                table: "LeaveAllocations");

            migrationBuilder.DropTable(
                name: "DetailsLeaveTypeVM");

            migrationBuilder.DropPrimaryKey(
                name: "PK_LeaveAllocations",
                table: "LeaveAllocations");

            migrationBuilder.DropColumn(
                name: "DefaultDays",
                table: "LeaveTypes");

            migrationBuilder.DropColumn(
                name: "Period",
                table: "LeaveAllocations");

            migrationBuilder.RenameTable(
                name: "LeaveAllocations",
                newName: "LeaveAllocationS");

            migrationBuilder.RenameIndex(
                name: "IX_LeaveAllocations_LeaveTypeId",
                table: "LeaveAllocationS",
                newName: "IX_LeaveAllocationS_LeaveTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_LeaveAllocations_EmployeeId",
                table: "LeaveAllocationS",
                newName: "IX_LeaveAllocationS_EmployeeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_LeaveAllocationS",
                table: "LeaveAllocationS",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_LeaveAllocationS_AspNetUsers_EmployeeId",
                table: "LeaveAllocationS",
                column: "EmployeeId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_LeaveAllocationS_LeaveTypes_LeaveTypeId",
                table: "LeaveAllocationS",
                column: "LeaveTypeId",
                principalTable: "LeaveTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
