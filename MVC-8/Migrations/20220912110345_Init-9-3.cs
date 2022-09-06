using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVC_8.Migrations
{
    public partial class Init93 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Languages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Languages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CountryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cities_Countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Countries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "People",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CityId = table.Column<int>(type: "int", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_People", x => x.Id);
                    table.ForeignKey(
                        name: "FK_People_Cities_CityId",
                        column: x => x.CityId,
                        principalTable: "Cities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "LanguagePerson",
                columns: table => new
                {
                    LanguagesId = table.Column<int>(type: "int", nullable: false),
                    PeopleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LanguagePerson", x => new { x.LanguagesId, x.PeopleId });
                    table.ForeignKey(
                        name: "FK_LanguagePerson_Languages_LanguagesId",
                        column: x => x.LanguagesId,
                        principalTable: "Languages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_LanguagePerson_People_PeopleId",
                        column: x => x.PeopleId,
                        principalTable: "People",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Skaraborg" },
                    { 2, "USA" }
                });

            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Klingon" },
                    { 2, "Meänkieli" },
                    { 3, "Mixtec" },
                    { 4, "Papiamento" },
                    { 5, "Swahili" },
                    { 6, "Volapük" },
                    { 7, "Väschözzga" }
                });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "CountryId", "Name" },
                values: new object[,]
                {
                    { 1, 1, "Axevalla" },
                    { 2, 1, "Floby" },
                    { 3, 1, "Götene" },
                    { 4, 1, "Hällekis" },
                    { 5, 1, "Källby" },
                    { 6, 1, "Lerdala" },
                    { 7, 1, "Skulltorp" },
                    { 8, 1, "Stenstorp" },
                    { 9, 1, "Tibro" },
                    { 10, 1, "Tidaholm" },
                    { 11, 1, "Töreboda" },
                    { 12, 2, "New York" }
                });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "CityId", "Name", "Phone" },
                values: new object[,]
                {
                    { 1, 9, "Mika Carlsson", "956240" },
                    { 2, 8, "Dave Lindgren", "492567" },
                    { 3, 9, "Adrian Ståhl", "430709" },
                    { 4, 12, "Åsa Fahlgren", "273484" },
                    { 5, 3, "Adrian Fahlgren", "520259" },
                    { 6, 4, "Yngve Dahl", "691427" },
                    { 7, 1, "Osborn Ståhl", "979565" },
                    { 8, 2, "Åsa Zackow", "304225" },
                    { 9, 9, "Åsa Krall", "368293" },
                    { 10, 10, "Kim Ålander", "419846" },
                    { 11, 2, "Alva Dahl", "912178" },
                    { 12, 5, "Lisbet Malmsten", "264855" },
                    { 13, 5, "Olle Lindgren", "793635" },
                    { 14, 12, "Lotta Malmsten", "829277" },
                    { 15, 2, "Lotta Ålander", "770813" },
                    { 16, 5, "Lotta Zackow", "203738" },
                    { 17, 3, "Nisse Fahlgren", "450215" },
                    { 18, 4, "Olle Dahl", "961155" },
                    { 19, 5, "Mika Lindgren", "903220" },
                    { 20, 9, "Mika Krall", "199241" },
                    { 21, 11, "Lisbet Walker", "613163" },
                    { 22, 6, "Dave Erixon", "735203" },
                    { 23, 12, "Ilja Carlsson", "510646" },
                    { 24, 10, "Kim Hjalmarsson", "515553" },
                    { 25, 12, "Ulla Sventon", "937750" }
                });

            migrationBuilder.InsertData(
                table: "LanguagePerson",
                columns: new[] { "LanguagesId", "PeopleId" },
                values: new object[,]
                {
                    { 2, 1 },
                    { 2, 5 },
                    { 2, 15 },
                    { 2, 18 },
                    { 2, 20 },
                    { 2, 21 },
                    { 2, 24 },
                    { 3, 1 },
                    { 3, 7 },
                    { 3, 14 },
                    { 3, 19 },
                    { 3, 23 },
                    { 3, 24 },
                    { 3, 25 },
                    { 4, 3 },
                    { 4, 10 },
                    { 4, 13 },
                    { 4, 19 },
                    { 4, 20 },
                    { 4, 23 },
                    { 4, 24 },
                    { 4, 25 },
                    { 5, 3 },
                    { 5, 5 },
                    { 5, 6 },
                    { 5, 8 },
                    { 5, 13 },
                    { 5, 15 },
                    { 5, 19 },
                    { 5, 20 },
                    { 5, 22 },
                    { 5, 23 },
                    { 6, 3 },
                    { 6, 5 },
                    { 6, 7 },
                    { 6, 11 },
                    { 6, 18 },
                    { 6, 20 },
                    { 6, 24 },
                    { 6, 25 },
                    { 7, 4 },
                    { 7, 7 }
                });

            migrationBuilder.InsertData(
                table: "LanguagePerson",
                columns: new[] { "LanguagesId", "PeopleId" },
                values: new object[,]
                {
                    { 7, 8 },
                    { 7, 10 },
                    { 7, 13 },
                    { 7, 18 },
                    { 7, 21 },
                    { 7, 23 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cities_CountryId",
                table: "Cities",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_LanguagePerson_PeopleId",
                table: "LanguagePerson",
                column: "PeopleId");

            migrationBuilder.CreateIndex(
                name: "IX_People_CityId",
                table: "People",
                column: "CityId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LanguagePerson");

            migrationBuilder.DropTable(
                name: "Languages");

            migrationBuilder.DropTable(
                name: "People");

            migrationBuilder.DropTable(
                name: "Cities");

            migrationBuilder.DropTable(
                name: "Countries");
        }
    }
}
