using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace exam_entity.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Genres",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genres", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Authors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    CountryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Authors_Countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Countries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Pages = table.Column<int>(type: "int", nullable: false),
                    PublicationYear = table.Column<int>(type: "int", nullable: false),
                    Cost = table.Column<double>(type: "float", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    AuthorId = table.Column<int>(type: "int", nullable: false),
                    GenreId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Books_Authors_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "Authors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Books_Genres_GenreId",
                        column: x => x.GenreId,
                        principalTable: "Genres",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Ukraine" },
                    { 2, "Poland" },
                    { 3, "Germany" },
                    { 4, "France" },
                    { 5, "Spain" },
                    { 6, "Italy" },
                    { 7, "South Korea" },
                    { 8, "Sweden" },
                    { 9, "Norway" },
                    { 10, "Finland" },
                    { 11, "United Kingdom" },
                    { 12, "United States" },
                    { 13, "Canada" },
                    { 14, "Mexico" },
                    { 15, "Brazil" },
                    { 16, "Argentina" },
                    { 17, "Australia" },
                    { 18, "New Zealand" },
                    { 19, "China" },
                    { 20, "Japan" }
                });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Action" },
                    { 2, "Adventure" },
                    { 3, "Comedy" },
                    { 4, "Drama" },
                    { 5, "Horror" },
                    { 6, "Mystery" },
                    { 7, "Romance" },
                    { 8, "Science Fiction" },
                    { 9, "Thriller" },
                    { 10, "Western" },
                    { 11, "Biography" },
                    { 12, "Crime" },
                    { 13, "Fantasy" },
                    { 14, "Historical" },
                    { 15, "Music" },
                    { 16, "Psychological" },
                    { 17, "Sports" },
                    { 18, "War" },
                    { 19, "Political" },
                    { 20, "Documentary" }
                });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "CountryId", "Name" },
                values: new object[,]
                {
                    { 1, 12, "Ernest Hemingway" },
                    { 2, 12, "F. Scott Fitzgerald" },
                    { 3, 11, "Virginia Woolf" },
                    { 4, 11, "George Orwell" },
                    { 5, 11, "J.R.R. Tolkien" },
                    { 6, 1, "Ivan Franko" },
                    { 7, 1, "Lesya Ukrainka" },
                    { 8, 1, "Nikolai Gogol" },
                    { 9, 1, "Taras Shevchenko" },
                    { 10, 3, "Franz Kafka" },
                    { 11, 3, "Thomas Mann" },
                    { 12, 3, "Hermann Hesse" },
                    { 13, 3, "Johann Wolfgang von Goethe" },
                    { 14, 15, "Gabriel Garcia Marquez" },
                    { 15, 19, "Mario Vargas Llosa" },
                    { 16, 19, "Isabel Allende" },
                    { 17, 20, "Haruki Murakami" },
                    { 18, 20, "Yukio Mishima" },
                    { 19, 12, "Jhumpa Lahiri" },
                    { 20, 12, "Toni Morrison" }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Comment", "Cost", "GenreId", "Pages", "Price", "PublicationYear", "Title" },
                values: new object[,]
                {
                    { 1, 1, null, 0.0, 1, 0, 10.99, 1952, "The Old Man and the Sea" },
                    { 2, 2, null, 0.0, 1, 0, 12.99, 1925, "The Great Gatsby" },
                    { 3, 3, null, 0.0, 1, 0, 8.9900000000000002, 1927, "To the Lighthouse" },
                    { 4, 4, null, 0.0, 2, 0, 9.9900000000000002, 1949, "1984" },
                    { 5, 5, null, 0.0, 3, 0, 20.989999999999998, 1954, "The Lord of the Rings" },
                    { 6, 6, null, 0.0, 4, 0, 5.9900000000000002, 1882, "Zahar Berkut" },
                    { 7, 7, null, 0.0, 4, 0, 7.9900000000000002, 1911, "Forest Song" },
                    { 8, 8, null, 0.0, 4, 0, 9.9900000000000002, 1842, "Dead Souls" },
                    { 9, 9, null, 0.0, 4, 0, 6.9900000000000002, 1840, "Kobzar" },
                    { 10, 10, null, 0.0, 5, 0, 11.99, 1925, "The Trial" },
                    { 11, 11, null, 0.0, 5, 0, 14.99, 1924, "The Magic Mountain" },
                    { 12, 12, null, 0.0, 5, 0, 8.9900000000000002, 1922, "Siddhartha" },
                    { 13, 13, null, 0.0, 6, 0, 9.9900000000000002, 1808, "Faust" },
                    { 14, 14, null, 0.0, 1, 0, 9.9900000000000002, 1932, "Brave New World" },
                    { 15, 15, null, 0.0, 2, 0, 10.99, 1866, "Crime and Punishment" },
                    { 16, 16, null, 0.0, 3, 0, 7.9900000000000002, 1813, "Pride and Prejudice" },
                    { 17, 17, null, 0.0, 4, 0, 12.99, 1862, "Les Misérables" },
                    { 18, 18, null, 0.0, 2, 0, 11.99, 1880, "The Brothers Karamazov" },
                    { 19, 19, null, 0.0, 4, 0, 14.99, 1869, "War and Peace" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Authors_CountryId",
                table: "Authors",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_Books_AuthorId",
                table: "Books",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_Books_GenreId",
                table: "Books",
                column: "GenreId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "Authors");

            migrationBuilder.DropTable(
                name: "Genres");

            migrationBuilder.DropTable(
                name: "Countries");
        }
    }
}
