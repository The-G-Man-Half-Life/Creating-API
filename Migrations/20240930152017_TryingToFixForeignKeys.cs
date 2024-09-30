using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Creating_API.Migrations
{
    /// <inheritdoc />
    public partial class TryingToFixForeignKeys : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "gues_id",
                table: "Chair",
                newName: "guest_id");

            migrationBuilder.CreateIndex(
                name: "IX_UserAllergy_allergy_id",
                table: "UserAllergy",
                column: "allergy_id");

            migrationBuilder.CreateIndex(
                name: "IX_UserAllergy_user_id",
                table: "UserAllergy",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "IX_Table_event_id",
                table: "Table",
                column: "event_id");

            migrationBuilder.CreateIndex(
                name: "IX_Guest_event_id",
                table: "Guest",
                column: "event_id");

            migrationBuilder.CreateIndex(
                name: "IX_Guest_user_id",
                table: "Guest",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "IX_EventUser_event_id",
                table: "EventUser",
                column: "event_id");

            migrationBuilder.CreateIndex(
                name: "IX_EventUser_user_id",
                table: "EventUser",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "IX_Chair_guest_id",
                table: "Chair",
                column: "guest_id");

            migrationBuilder.CreateIndex(
                name: "IX_Chair_person_id",
                table: "Chair",
                column: "person_id");

            migrationBuilder.CreateIndex(
                name: "IX_Chair_table_id",
                table: "Chair",
                column: "table_id");

            migrationBuilder.AddForeignKey(
                name: "FK_Chair_Guest_guest_id",
                table: "Chair",
                column: "guest_id",
                principalTable: "Guest",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Chair_Table_table_id",
                table: "Chair",
                column: "table_id",
                principalTable: "Table",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Chair_User_person_id",
                table: "Chair",
                column: "person_id",
                principalTable: "User",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EventUser_Event_event_id",
                table: "EventUser",
                column: "event_id",
                principalTable: "Event",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EventUser_User_user_id",
                table: "EventUser",
                column: "user_id",
                principalTable: "User",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Guest_Event_event_id",
                table: "Guest",
                column: "event_id",
                principalTable: "Event",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Guest_User_user_id",
                table: "Guest",
                column: "user_id",
                principalTable: "User",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Table_Event_event_id",
                table: "Table",
                column: "event_id",
                principalTable: "Event",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserAllergy_Allergy_allergy_id",
                table: "UserAllergy",
                column: "allergy_id",
                principalTable: "Allergy",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserAllergy_User_user_id",
                table: "UserAllergy",
                column: "user_id",
                principalTable: "User",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Chair_Guest_guest_id",
                table: "Chair");

            migrationBuilder.DropForeignKey(
                name: "FK_Chair_Table_table_id",
                table: "Chair");

            migrationBuilder.DropForeignKey(
                name: "FK_Chair_User_person_id",
                table: "Chair");

            migrationBuilder.DropForeignKey(
                name: "FK_EventUser_Event_event_id",
                table: "EventUser");

            migrationBuilder.DropForeignKey(
                name: "FK_EventUser_User_user_id",
                table: "EventUser");

            migrationBuilder.DropForeignKey(
                name: "FK_Guest_Event_event_id",
                table: "Guest");

            migrationBuilder.DropForeignKey(
                name: "FK_Guest_User_user_id",
                table: "Guest");

            migrationBuilder.DropForeignKey(
                name: "FK_Table_Event_event_id",
                table: "Table");

            migrationBuilder.DropForeignKey(
                name: "FK_UserAllergy_Allergy_allergy_id",
                table: "UserAllergy");

            migrationBuilder.DropForeignKey(
                name: "FK_UserAllergy_User_user_id",
                table: "UserAllergy");

            migrationBuilder.DropIndex(
                name: "IX_UserAllergy_allergy_id",
                table: "UserAllergy");

            migrationBuilder.DropIndex(
                name: "IX_UserAllergy_user_id",
                table: "UserAllergy");

            migrationBuilder.DropIndex(
                name: "IX_Table_event_id",
                table: "Table");

            migrationBuilder.DropIndex(
                name: "IX_Guest_event_id",
                table: "Guest");

            migrationBuilder.DropIndex(
                name: "IX_Guest_user_id",
                table: "Guest");

            migrationBuilder.DropIndex(
                name: "IX_EventUser_event_id",
                table: "EventUser");

            migrationBuilder.DropIndex(
                name: "IX_EventUser_user_id",
                table: "EventUser");

            migrationBuilder.DropIndex(
                name: "IX_Chair_guest_id",
                table: "Chair");

            migrationBuilder.DropIndex(
                name: "IX_Chair_person_id",
                table: "Chair");

            migrationBuilder.DropIndex(
                name: "IX_Chair_table_id",
                table: "Chair");

            migrationBuilder.RenameColumn(
                name: "guest_id",
                table: "Chair",
                newName: "gues_id");
        }
    }
}
