using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Battles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WinnerId = table.Column<int>(type: "int", nullable: false),
                    LoserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Battles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Hamsters",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    FavFood = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Loves = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImgName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Wins = table.Column<int>(type: "int", nullable: false),
                    Losses = table.Column<int>(type: "int", nullable: false),
                    Games = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hamsters", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Hamsters",
                columns: new[] { "Id", "Age", "FavFood", "Games", "ImgName", "Losses", "Loves", "Name", "Wins" },
                values: new object[,]
                {
                    { 1, 1, "Apples", 0, "/images/hamster-1.jpg", 0, "Climbing", "Belle", 0 },
                    { 2, 2, "Bananas", 0, "/images/hamster-2.jpg", 0, "Snuggleing", "Cleo", 0 },
                    { 3, 3, "Broccoli", 0, "/images/hamster-3.jpg", 0, "Running", "Evie", 0 },
                    { 4, 4, "Carrots", 0, "/images/hamster-4.jpg", 0, "Sleeping", "Lola", 0 },
                    { 5, 1, "Strawberries", 0, "/images/hamster-5.jpg", 0, "Climbing", "Daisy", 0 },
                    { 6, 2, "BlueBerries", 0, "/images/hamster-6.jpg", 0, "Climbing", "Penny", 0 },
                    { 7, 3, "Peanuts", 0, "/images/hamster-7.jpg", 0, "Sleeping", "Ivy", 0 },
                    { 8, 4, "Potato", 0, "/images/hamster-8.jpg", 0, "Climbing", "Roxy", 0 },
                    { 9, 2, "Seeds", 0, "/images/hamster-9.jpg", 0, "Snuggleing", "Zoe", 0 },
                    { 10, 1, "Grapes", 0, "/images/hamster-10.jpg", 0, "Snuggleing", "Duncan", 0 },
                    { 11, 2, "Banana", 0, "/images/hamster-11.jpg", 0, "Climbing", "Frodo", 0 },
                    { 12, 3, "Strawberries", 0, "/images/hamster-12.jpg", 0, "Running", "Jasper", 0 },
                    { 13, 4, "Spinach", 0, "/images/hamster-13.jpg", 0, "Climbing", "Jojo", 0 },
                    { 14, 1, "Hay", 0, "/images/hamster-14.jpg", 0, "Climbing", "Max", 0 },
                    { 15, 2, "Broccoli", 0, "/images/hamster-15.jpg", 0, "Running", "Gomez", 0 },
                    { 16, 3, "Carrot", 0, "/images/hamster-16.jpg", 0, "Climbing", "Felix", 0 },
                    { 17, 4, "Apples", 0, "/images/hamster-17.jpg", 0, "Climbing", "Frodo", 0 },
                    { 18, 5, "Cucumber", 0, "/images/hamster-18.jpg", 0, "Sleeping", "Rocky", 0 },
                    { 19, 2, "Apples", 0, "/images/hamster-19.jpg", 0, "Snuggleing", "Frizy", 0 },
                    { 20, 5, "Cucumber", 0, "/images/hamster-20.jpg", 0, "Sleeping", "Nemo", 0 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Battles");

            migrationBuilder.DropTable(
                name: "Hamsters");
        }
    }
}
