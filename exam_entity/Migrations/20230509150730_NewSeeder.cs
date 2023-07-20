using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace exam_entity.Migrations
{
    /// <inheritdoc />
    public partial class NewSeeder : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "BooksInStore",
                columns: new[] { "Id", "Cost", "Discount", "Price", "Quantity" },
                values: new object[,]
                {
                    { 1, 10.99, 45, 19.989999999999998, 10 },
                    { 2, 15.99, 35, 24.989999999999998, 15 },
                    { 3, 8.9900000000000002, 40, 14.99, 20 },
                    { 4, 5.9900000000000002, 40, 9.9900000000000002, 25 },
                    { 5, 18.989999999999998, 35, 29.989999999999998, 12 },
                    { 6, 7.9900000000000002, 38, 12.99, 18 },
                    { 7, 12.99, 40, 21.989999999999998, 14 },
                    { 8, 11.99, 40, 19.989999999999998, 10 },
                    { 9, 9.9900000000000002, 41, 16.989999999999998, 22 },
                    { 10, 13.99, 40, 23.989999999999998, 13 },
                    { 11, 16.989999999999998, 35, 27.989999999999998, 16 },
                    { 12, 14.99, 40, 24.989999999999998, 18 },
                    { 13, 20.989999999999998, 35, 32.990000000000002, 11 },
                    { 14, 6.9900000000000002, 37, 10.99, 24 },
                    { 15, 17.989999999999998, 35, 28.989999999999998, 15 },
                    { 16, 10.99, 38, 17.989999999999998, 21 },
                    { 17, 7.9900000000000002, 38, 12.99, 19 },
                    { 18, 9.9900000000000002, 41, 16.989999999999998, 23 },
                    { 19, 11.99, 40, 19.989999999999998, 12 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BooksInStore",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "BooksInStore",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "BooksInStore",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "BooksInStore",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "BooksInStore",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "BooksInStore",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "BooksInStore",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "BooksInStore",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "BooksInStore",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "BooksInStore",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "BooksInStore",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "BooksInStore",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "BooksInStore",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "BooksInStore",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "BooksInStore",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "BooksInStore",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "BooksInStore",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "BooksInStore",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "BooksInStore",
                keyColumn: "Id",
                keyValue: 19);
        }
    }
}
