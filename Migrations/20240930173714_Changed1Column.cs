using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Creating_API.Migrations
{
    /// <inheritdoc />
    public partial class Changed1Column : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "invitation_date",
                table: "User");

            migrationBuilder.AddColumn<DateOnly>(
                name: "invitation_date",
                table: "EventUser",
                type: "date",
                nullable: false,
                defaultValue: new DateOnly(1, 1, 1));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "invitation_date",
                table: "EventUser");

            migrationBuilder.AddColumn<DateOnly>(
                name: "invitation_date",
                table: "User",
                type: "date",
                nullable: false,
                defaultValue: new DateOnly(1, 1, 1));
        }
    }
}
