using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Creating_API.Migrations
{
    /// <inheritdoc />
    public partial class ChangedColumnName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "invitation_date",
                table: "EventUser",
                newName: "user_invitation_date");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "user_invitation_date",
                table: "EventUser",
                newName: "invitation_date");
        }
    }
}
