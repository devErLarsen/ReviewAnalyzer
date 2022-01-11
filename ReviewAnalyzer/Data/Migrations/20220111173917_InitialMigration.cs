using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ReviewAnalyzer.Data.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ReviewItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReviewItems", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ReviewItemId = table.Column<int>(type: "INTEGER", nullable: false),
                    Content = table.Column<string>(type: "TEXT", nullable: false),
                    Sentiment = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reviews_ReviewItems_ReviewItemId",
                        column: x => x.ReviewItemId,
                        principalTable: "ReviewItems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "ReviewItems",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "Test" });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "Content", "ReviewItemId", "Sentiment" },
                values: new object[] { 1, "Content is not important right now", 1, "Neutral" });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "Content", "ReviewItemId", "Sentiment" },
                values: new object[] { 2, "Content is not important right now", 1, "Neutral" });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "Content", "ReviewItemId", "Sentiment" },
                values: new object[] { 3, "Content is not important right now", 1, "Mixed" });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "Content", "ReviewItemId", "Sentiment" },
                values: new object[] { 4, "Content is not important right now", 1, "Positive" });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "Content", "ReviewItemId", "Sentiment" },
                values: new object[] { 5, "Content is not important right now", 1, "Neutral" });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "Content", "ReviewItemId", "Sentiment" },
                values: new object[] { 6, "Content is not important right now", 1, "Mixed" });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "Content", "ReviewItemId", "Sentiment" },
                values: new object[] { 7, "Content is not important right now", 1, "Positive" });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "Content", "ReviewItemId", "Sentiment" },
                values: new object[] { 8, "Content is not important right now", 1, "Mixed" });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "Content", "ReviewItemId", "Sentiment" },
                values: new object[] { 9, "Content is not important right now", 1, "Mixed" });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "Content", "ReviewItemId", "Sentiment" },
                values: new object[] { 10, "Content is not important right now", 1, "Mixed" });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "Content", "ReviewItemId", "Sentiment" },
                values: new object[] { 11, "Content is not important right now", 1, "Positive" });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "Content", "ReviewItemId", "Sentiment" },
                values: new object[] { 12, "Content is not important right now", 1, "Negative" });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "Content", "ReviewItemId", "Sentiment" },
                values: new object[] { 13, "Content is not important right now", 1, "Positive" });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "Content", "ReviewItemId", "Sentiment" },
                values: new object[] { 14, "Content is not important right now", 1, "Neutral" });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "Content", "ReviewItemId", "Sentiment" },
                values: new object[] { 15, "Content is not important right now", 1, "Mixed" });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "Content", "ReviewItemId", "Sentiment" },
                values: new object[] { 16, "Content is not important right now", 1, "Neutral" });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "Content", "ReviewItemId", "Sentiment" },
                values: new object[] { 17, "Content is not important right now", 1, "Positive" });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "Content", "ReviewItemId", "Sentiment" },
                values: new object[] { 18, "Content is not important right now", 1, "Neutral" });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "Content", "ReviewItemId", "Sentiment" },
                values: new object[] { 19, "Content is not important right now", 1, "Neutral" });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "Content", "ReviewItemId", "Sentiment" },
                values: new object[] { 20, "Content is not important right now", 1, "Mixed" });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "Content", "ReviewItemId", "Sentiment" },
                values: new object[] { 21, "Content is not important right now", 1, "Mixed" });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "Content", "ReviewItemId", "Sentiment" },
                values: new object[] { 22, "Content is not important right now", 1, "Positive" });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "Content", "ReviewItemId", "Sentiment" },
                values: new object[] { 23, "Content is not important right now", 1, "Positive" });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "Content", "ReviewItemId", "Sentiment" },
                values: new object[] { 24, "Content is not important right now", 1, "Negative" });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "Content", "ReviewItemId", "Sentiment" },
                values: new object[] { 25, "Content is not important right now", 1, "Mixed" });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "Content", "ReviewItemId", "Sentiment" },
                values: new object[] { 26, "Content is not important right now", 1, "Mixed" });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "Content", "ReviewItemId", "Sentiment" },
                values: new object[] { 27, "Content is not important right now", 1, "Neutral" });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "Content", "ReviewItemId", "Sentiment" },
                values: new object[] { 28, "Content is not important right now", 1, "Neutral" });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "Content", "ReviewItemId", "Sentiment" },
                values: new object[] { 29, "Content is not important right now", 1, "Negative" });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "Content", "ReviewItemId", "Sentiment" },
                values: new object[] { 30, "Content is not important right now", 1, "Mixed" });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "Content", "ReviewItemId", "Sentiment" },
                values: new object[] { 31, "Content is not important right now", 1, "Negative" });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "Content", "ReviewItemId", "Sentiment" },
                values: new object[] { 32, "Content is not important right now", 1, "Neutral" });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "Content", "ReviewItemId", "Sentiment" },
                values: new object[] { 33, "Content is not important right now", 1, "Negative" });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "Content", "ReviewItemId", "Sentiment" },
                values: new object[] { 34, "Content is not important right now", 1, "Mixed" });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "Content", "ReviewItemId", "Sentiment" },
                values: new object[] { 35, "Content is not important right now", 1, "Negative" });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "Content", "ReviewItemId", "Sentiment" },
                values: new object[] { 36, "Content is not important right now", 1, "Positive" });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "Content", "ReviewItemId", "Sentiment" },
                values: new object[] { 37, "Content is not important right now", 1, "Positive" });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "Content", "ReviewItemId", "Sentiment" },
                values: new object[] { 38, "Content is not important right now", 1, "Positive" });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "Content", "ReviewItemId", "Sentiment" },
                values: new object[] { 39, "Content is not important right now", 1, "Neutral" });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "Content", "ReviewItemId", "Sentiment" },
                values: new object[] { 40, "Content is not important right now", 1, "Positive" });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "Content", "ReviewItemId", "Sentiment" },
                values: new object[] { 41, "Content is not important right now", 1, "Positive" });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "Content", "ReviewItemId", "Sentiment" },
                values: new object[] { 42, "Content is not important right now", 1, "Negative" });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "Content", "ReviewItemId", "Sentiment" },
                values: new object[] { 43, "Content is not important right now", 1, "Negative" });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "Content", "ReviewItemId", "Sentiment" },
                values: new object[] { 44, "Content is not important right now", 1, "Mixed" });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "Content", "ReviewItemId", "Sentiment" },
                values: new object[] { 45, "Content is not important right now", 1, "Negative" });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "Content", "ReviewItemId", "Sentiment" },
                values: new object[] { 46, "Content is not important right now", 1, "Positive" });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "Content", "ReviewItemId", "Sentiment" },
                values: new object[] { 47, "Content is not important right now", 1, "Positive" });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "Content", "ReviewItemId", "Sentiment" },
                values: new object[] { 48, "Content is not important right now", 1, "Mixed" });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "Content", "ReviewItemId", "Sentiment" },
                values: new object[] { 49, "Content is not important right now", 1, "Negative" });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "Content", "ReviewItemId", "Sentiment" },
                values: new object[] { 50, "Content is not important right now", 1, "Negative" });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "Content", "ReviewItemId", "Sentiment" },
                values: new object[] { 51, "Content is not important right now", 1, "Negative" });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "Content", "ReviewItemId", "Sentiment" },
                values: new object[] { 52, "Content is not important right now", 1, "Positive" });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "Content", "ReviewItemId", "Sentiment" },
                values: new object[] { 53, "Content is not important right now", 1, "Negative" });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "Content", "ReviewItemId", "Sentiment" },
                values: new object[] { 54, "Content is not important right now", 1, "Positive" });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "Content", "ReviewItemId", "Sentiment" },
                values: new object[] { 55, "Content is not important right now", 1, "Positive" });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "Content", "ReviewItemId", "Sentiment" },
                values: new object[] { 56, "Content is not important right now", 1, "Negative" });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "Content", "ReviewItemId", "Sentiment" },
                values: new object[] { 57, "Content is not important right now", 1, "Neutral" });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "Content", "ReviewItemId", "Sentiment" },
                values: new object[] { 58, "Content is not important right now", 1, "Positive" });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "Content", "ReviewItemId", "Sentiment" },
                values: new object[] { 59, "Content is not important right now", 1, "Positive" });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "Content", "ReviewItemId", "Sentiment" },
                values: new object[] { 60, "Content is not important right now", 1, "Positive" });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "Content", "ReviewItemId", "Sentiment" },
                values: new object[] { 61, "Content is not important right now", 1, "Mixed" });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "Content", "ReviewItemId", "Sentiment" },
                values: new object[] { 62, "Content is not important right now", 1, "Mixed" });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "Content", "ReviewItemId", "Sentiment" },
                values: new object[] { 63, "Content is not important right now", 1, "Positive" });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "Content", "ReviewItemId", "Sentiment" },
                values: new object[] { 64, "Content is not important right now", 1, "Mixed" });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "Content", "ReviewItemId", "Sentiment" },
                values: new object[] { 65, "Content is not important right now", 1, "Negative" });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "Content", "ReviewItemId", "Sentiment" },
                values: new object[] { 66, "Content is not important right now", 1, "Negative" });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "Content", "ReviewItemId", "Sentiment" },
                values: new object[] { 67, "Content is not important right now", 1, "Mixed" });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "Content", "ReviewItemId", "Sentiment" },
                values: new object[] { 68, "Content is not important right now", 1, "Positive" });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "Content", "ReviewItemId", "Sentiment" },
                values: new object[] { 69, "Content is not important right now", 1, "Positive" });

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_ReviewItemId",
                table: "Reviews",
                column: "ReviewItemId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Reviews");

            migrationBuilder.DropTable(
                name: "ReviewItems");
        }
    }
}
