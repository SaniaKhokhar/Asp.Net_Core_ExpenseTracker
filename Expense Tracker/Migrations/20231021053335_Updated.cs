using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Expense_Tracker.Migrations
{
    /// <inheritdoc />
    public partial class Updated : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Categories_AspNetUsers_ApplicationUserId",
                table: "Categories");

            migrationBuilder.DropForeignKey(
                name: "FK_Categories_AspNetUsers_userIdId",
                table: "Categories");

            migrationBuilder.DropForeignKey(
                name: "FK_Transactions_AspNetUsers_ApplicationUserId",
                table: "Transactions");

            migrationBuilder.DropForeignKey(
                name: "FK_Transactions_AspNetUsers_userIdId",
                table: "Transactions");

            migrationBuilder.DropIndex(
                name: "IX_Transactions_ApplicationUserId",
                table: "Transactions");

            migrationBuilder.DropIndex(
                name: "IX_Transactions_userIdId",
                table: "Transactions");

            migrationBuilder.DropIndex(
                name: "IX_Categories_ApplicationUserId",
                table: "Categories");

            migrationBuilder.DropIndex(
                name: "IX_Categories_userIdId",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId",
                table: "Transactions");

            migrationBuilder.DropColumn(
                name: "userIdId",
                table: "Transactions");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "userIdId",
                table: "Categories");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserId",
                table: "Transactions",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "userIdId",
                table: "Transactions",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserId",
                table: "Categories",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "userIdId",
                table: "Categories",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Transactions_ApplicationUserId",
                table: "Transactions",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Transactions_userIdId",
                table: "Transactions",
                column: "userIdId");

            migrationBuilder.CreateIndex(
                name: "IX_Categories_ApplicationUserId",
                table: "Categories",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Categories_userIdId",
                table: "Categories",
                column: "userIdId");

            migrationBuilder.AddForeignKey(
                name: "FK_Categories_AspNetUsers_ApplicationUserId",
                table: "Categories",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Categories_AspNetUsers_userIdId",
                table: "Categories",
                column: "userIdId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Transactions_AspNetUsers_ApplicationUserId",
                table: "Transactions",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Transactions_AspNetUsers_userIdId",
                table: "Transactions",
                column: "userIdId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }
    }
}
