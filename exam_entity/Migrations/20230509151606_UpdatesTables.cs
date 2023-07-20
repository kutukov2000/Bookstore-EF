using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace exam_entity.Migrations
{
    /// <inheritdoc />
    public partial class UpdatesTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BookId",
                table: "BooksInStore",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "BookInStoreId",
                table: "Books",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                column: "BookInStoreId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                column: "BookInStoreId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                column: "BookInStoreId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                column: "BookInStoreId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5,
                column: "BookInStoreId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6,
                column: "BookInStoreId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 7,
                column: "BookInStoreId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 8,
                column: "BookInStoreId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 9,
                column: "BookInStoreId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 10,
                column: "BookInStoreId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 11,
                column: "BookInStoreId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 12,
                column: "BookInStoreId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 13,
                column: "BookInStoreId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 14,
                column: "BookInStoreId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 15,
                column: "BookInStoreId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 16,
                column: "BookInStoreId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 17,
                column: "BookInStoreId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 18,
                column: "BookInStoreId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 19,
                column: "BookInStoreId",
                value: null);

            migrationBuilder.UpdateData(
                table: "BooksInStore",
                keyColumn: "Id",
                keyValue: 1,
                column: "BookId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "BooksInStore",
                keyColumn: "Id",
                keyValue: 2,
                column: "BookId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "BooksInStore",
                keyColumn: "Id",
                keyValue: 3,
                column: "BookId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "BooksInStore",
                keyColumn: "Id",
                keyValue: 4,
                column: "BookId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "BooksInStore",
                keyColumn: "Id",
                keyValue: 5,
                column: "BookId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "BooksInStore",
                keyColumn: "Id",
                keyValue: 6,
                column: "BookId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "BooksInStore",
                keyColumn: "Id",
                keyValue: 7,
                column: "BookId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "BooksInStore",
                keyColumn: "Id",
                keyValue: 8,
                column: "BookId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "BooksInStore",
                keyColumn: "Id",
                keyValue: 9,
                column: "BookId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "BooksInStore",
                keyColumn: "Id",
                keyValue: 10,
                column: "BookId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "BooksInStore",
                keyColumn: "Id",
                keyValue: 11,
                column: "BookId",
                value: 11);

            migrationBuilder.UpdateData(
                table: "BooksInStore",
                keyColumn: "Id",
                keyValue: 12,
                column: "BookId",
                value: 12);

            migrationBuilder.UpdateData(
                table: "BooksInStore",
                keyColumn: "Id",
                keyValue: 13,
                column: "BookId",
                value: 13);

            migrationBuilder.UpdateData(
                table: "BooksInStore",
                keyColumn: "Id",
                keyValue: 14,
                column: "BookId",
                value: 14);

            migrationBuilder.UpdateData(
                table: "BooksInStore",
                keyColumn: "Id",
                keyValue: 15,
                column: "BookId",
                value: 15);

            migrationBuilder.UpdateData(
                table: "BooksInStore",
                keyColumn: "Id",
                keyValue: 16,
                column: "BookId",
                value: 16);

            migrationBuilder.UpdateData(
                table: "BooksInStore",
                keyColumn: "Id",
                keyValue: 17,
                column: "BookId",
                value: 17);

            migrationBuilder.UpdateData(
                table: "BooksInStore",
                keyColumn: "Id",
                keyValue: 18,
                column: "BookId",
                value: 18);

            migrationBuilder.UpdateData(
                table: "BooksInStore",
                keyColumn: "Id",
                keyValue: 19,
                column: "BookId",
                value: 19);

            migrationBuilder.CreateIndex(
                name: "IX_BooksInStore_BookId",
                table: "BooksInStore",
                column: "BookId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_BooksInStore_Books_BookId",
                table: "BooksInStore",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BooksInStore_Books_BookId",
                table: "BooksInStore");

            migrationBuilder.DropIndex(
                name: "IX_BooksInStore_BookId",
                table: "BooksInStore");

            migrationBuilder.DropColumn(
                name: "BookId",
                table: "BooksInStore");

            migrationBuilder.DropColumn(
                name: "BookInStoreId",
                table: "Books");
        }
    }
}
