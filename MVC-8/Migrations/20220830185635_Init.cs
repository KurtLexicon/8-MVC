using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVC_8.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "People",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_People", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "City", "Name", "Phone" },
                values: new object[,]
                {
                    { 1, "New York", "Åsa Bildt", "313445" },
                    { 2, "Hällekis", "Olle Zackow", "259064" },
                    { 3, "Töreboda", "Beda Carlsson", "709594" },
                    { 4, "New York", "Adrian Fahlgren", "358458" },
                    { 5, "Skulltorp", "Lotta Erixon", "994159" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "People");
        }
    }
}
