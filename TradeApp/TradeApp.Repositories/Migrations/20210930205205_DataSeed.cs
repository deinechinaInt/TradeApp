using Microsoft.EntityFrameworkCore.Migrations;

namespace TradeApp.Repositories.Migrations
{
    public partial class DataSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "FirstName", "Lastname" },
                values: new object[,]
                {
                    { 1, "user1Email@mail.ru", "User1FirstName", "User1LastName" },
                    { 2, "user2Email@mail.ru", "User2FirstName", "User2LastName" },
                    { 3, "user3Email@mail.ru", "User3FirstName", "User3LastName" },
                    { 4, "user4Email@mail.ru", "User4FirstName", "User4LastName" },
                    { 5, "user5Email@mail.ru", "User5FirstName", "User5LastName" },
                    { 6, "user6Email@mail.ru", "User6FirstName", "User6LastName" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6);
        }
    }
}
