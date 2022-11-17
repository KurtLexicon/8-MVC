using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVC_8.Migrations
{
    public partial class _2211171 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "41ed0178-5107-4742-aaf1-efaeb1868788");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "34140290-2abe-488e-8340-3fd21e72d159", "2fe164a1-5ac0-4f32-a924-c3ff64d3ceee" });

            migrationBuilder.DeleteData(
                table: "LanguagePerson",
                keyColumns: new[] { "LanguagesId", "PeopleId" },
                keyValues: new object[] { 1, 8 });

            migrationBuilder.DeleteData(
                table: "LanguagePerson",
                keyColumns: new[] { "LanguagesId", "PeopleId" },
                keyValues: new object[] { 1, 15 });

            migrationBuilder.DeleteData(
                table: "LanguagePerson",
                keyColumns: new[] { "LanguagesId", "PeopleId" },
                keyValues: new object[] { 1, 22 });

            migrationBuilder.DeleteData(
                table: "LanguagePerson",
                keyColumns: new[] { "LanguagesId", "PeopleId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "LanguagePerson",
                keyColumns: new[] { "LanguagesId", "PeopleId" },
                keyValues: new object[] { 2, 7 });

            migrationBuilder.DeleteData(
                table: "LanguagePerson",
                keyColumns: new[] { "LanguagesId", "PeopleId" },
                keyValues: new object[] { 2, 10 });

            migrationBuilder.DeleteData(
                table: "LanguagePerson",
                keyColumns: new[] { "LanguagesId", "PeopleId" },
                keyValues: new object[] { 2, 20 });

            migrationBuilder.DeleteData(
                table: "LanguagePerson",
                keyColumns: new[] { "LanguagesId", "PeopleId" },
                keyValues: new object[] { 2, 21 });

            migrationBuilder.DeleteData(
                table: "LanguagePerson",
                keyColumns: new[] { "LanguagesId", "PeopleId" },
                keyValues: new object[] { 3, 14 });

            migrationBuilder.DeleteData(
                table: "LanguagePerson",
                keyColumns: new[] { "LanguagesId", "PeopleId" },
                keyValues: new object[] { 3, 15 });

            migrationBuilder.DeleteData(
                table: "LanguagePerson",
                keyColumns: new[] { "LanguagesId", "PeopleId" },
                keyValues: new object[] { 3, 22 });

            migrationBuilder.DeleteData(
                table: "LanguagePerson",
                keyColumns: new[] { "LanguagesId", "PeopleId" },
                keyValues: new object[] { 4, 5 });

            migrationBuilder.DeleteData(
                table: "LanguagePerson",
                keyColumns: new[] { "LanguagesId", "PeopleId" },
                keyValues: new object[] { 4, 6 });

            migrationBuilder.DeleteData(
                table: "LanguagePerson",
                keyColumns: new[] { "LanguagesId", "PeopleId" },
                keyValues: new object[] { 4, 12 });

            migrationBuilder.DeleteData(
                table: "LanguagePerson",
                keyColumns: new[] { "LanguagesId", "PeopleId" },
                keyValues: new object[] { 4, 13 });

            migrationBuilder.DeleteData(
                table: "LanguagePerson",
                keyColumns: new[] { "LanguagesId", "PeopleId" },
                keyValues: new object[] { 4, 16 });

            migrationBuilder.DeleteData(
                table: "LanguagePerson",
                keyColumns: new[] { "LanguagesId", "PeopleId" },
                keyValues: new object[] { 4, 23 });

            migrationBuilder.DeleteData(
                table: "LanguagePerson",
                keyColumns: new[] { "LanguagesId", "PeopleId" },
                keyValues: new object[] { 5, 3 });

            migrationBuilder.DeleteData(
                table: "LanguagePerson",
                keyColumns: new[] { "LanguagesId", "PeopleId" },
                keyValues: new object[] { 5, 5 });

            migrationBuilder.DeleteData(
                table: "LanguagePerson",
                keyColumns: new[] { "LanguagesId", "PeopleId" },
                keyValues: new object[] { 5, 6 });

            migrationBuilder.DeleteData(
                table: "LanguagePerson",
                keyColumns: new[] { "LanguagesId", "PeopleId" },
                keyValues: new object[] { 5, 10 });

            migrationBuilder.DeleteData(
                table: "LanguagePerson",
                keyColumns: new[] { "LanguagesId", "PeopleId" },
                keyValues: new object[] { 5, 12 });

            migrationBuilder.DeleteData(
                table: "LanguagePerson",
                keyColumns: new[] { "LanguagesId", "PeopleId" },
                keyValues: new object[] { 5, 15 });

            migrationBuilder.DeleteData(
                table: "LanguagePerson",
                keyColumns: new[] { "LanguagesId", "PeopleId" },
                keyValues: new object[] { 6, 13 });

            migrationBuilder.DeleteData(
                table: "LanguagePerson",
                keyColumns: new[] { "LanguagesId", "PeopleId" },
                keyValues: new object[] { 6, 17 });

            migrationBuilder.DeleteData(
                table: "LanguagePerson",
                keyColumns: new[] { "LanguagesId", "PeopleId" },
                keyValues: new object[] { 6, 21 });

            migrationBuilder.DeleteData(
                table: "LanguagePerson",
                keyColumns: new[] { "LanguagesId", "PeopleId" },
                keyValues: new object[] { 7, 2 });

            migrationBuilder.DeleteData(
                table: "LanguagePerson",
                keyColumns: new[] { "LanguagesId", "PeopleId" },
                keyValues: new object[] { 7, 5 });

            migrationBuilder.DeleteData(
                table: "LanguagePerson",
                keyColumns: new[] { "LanguagesId", "PeopleId" },
                keyValues: new object[] { 7, 13 });

            migrationBuilder.DeleteData(
                table: "LanguagePerson",
                keyColumns: new[] { "LanguagesId", "PeopleId" },
                keyValues: new object[] { 7, 14 });

            migrationBuilder.DeleteData(
                table: "LanguagePerson",
                keyColumns: new[] { "LanguagesId", "PeopleId" },
                keyValues: new object[] { 7, 16 });

            migrationBuilder.DeleteData(
                table: "LanguagePerson",
                keyColumns: new[] { "LanguagesId", "PeopleId" },
                keyValues: new object[] { 7, 18 });

            migrationBuilder.DeleteData(
                table: "LanguagePerson",
                keyColumns: new[] { "LanguagesId", "PeopleId" },
                keyValues: new object[] { 7, 22 });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "34140290-2abe-488e-8340-3fd21e72d159");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2fe164a1-5ac0-4f32-a924-c3ff64d3ceee");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "cda6f899-bad1-4569-bbd6-9f5d739b779d", null, "Admin", "ADMIN" },
                    { "e3ea8a48-a5fa-4023-8fc3-7ac081f9ed22", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "BirthDate", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "d4b00c3f-2043-4f5b-bea1-6fe36d82d7ed", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "3cdf66bb-0bed-4962-944d-d3397c0ca8b1", "admin@admin.com", false, "Admin", "Admin", false, null, "ADMIN@ADMIN.COM", "ADMIN", "AQAAAAEAACcQAAAAEDY1UTVOO2hetY/xbqTMxSHFNLkMLHJMTaEumBn5Xxncj3lnZmyOJ+BbPvr6O1XdyA==", null, false, "406fa485-1414-45af-8c08-165b6fd525cd", false, "admin" });

            migrationBuilder.InsertData(
                table: "LanguagePerson",
                columns: new[] { "LanguagesId", "PeopleId" },
                values: new object[,]
                {
                    { 1, 4 },
                    { 1, 9 },
                    { 1, 10 },
                    { 1, 13 },
                    { 1, 16 },
                    { 1, 20 },
                    { 1, 21 },
                    { 1, 24 },
                    { 2, 4 },
                    { 2, 12 },
                    { 2, 24 },
                    { 3, 6 },
                    { 3, 11 },
                    { 3, 13 },
                    { 3, 18 },
                    { 3, 21 },
                    { 3, 23 },
                    { 4, 14 },
                    { 4, 19 },
                    { 4, 22 },
                    { 4, 24 },
                    { 4, 25 },
                    { 5, 4 },
                    { 5, 9 },
                    { 5, 21 },
                    { 5, 25 },
                    { 6, 5 },
                    { 6, 6 },
                    { 6, 12 },
                    { 6, 14 },
                    { 6, 19 },
                    { 6, 23 },
                    { 6, 24 },
                    { 6, 25 },
                    { 7, 1 },
                    { 7, 7 },
                    { 7, 19 }
                });

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CityId", "Name", "Phone" },
                values: new object[] { 6, "Mika Hjalmarsson", "391732" });

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CityId", "Name", "Phone" },
                values: new object[] { 5, "Adrian Carlsson", "595416" });

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CityId", "Name", "Phone" },
                values: new object[] { 6, "Kim Vretman", "151225" });

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CityId", "Name", "Phone" },
                values: new object[] { 7, "Ilja Ålander", "703783" });

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CityId", "Name", "Phone" },
                values: new object[] { 4, "Ture Hjalmarsson", "646665" });

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CityId", "Name", "Phone" },
                values: new object[] { 11, "Olle Carlsson", "583858" });

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CityId", "Name", "Phone" },
                values: new object[] { 5, "Olle Ivarsson", "923612" });

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CityId", "Name", "Phone" },
                values: new object[] { 6, "Yngve Walker", "279100" });

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CityId", "Name", "Phone" },
                values: new object[] { 3, "Nisse Carlsson", "409782" });

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Kalle Hjalmarsson", "870763" });

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CityId", "Name", "Phone" },
                values: new object[] { 5, "Nisse Erixon", "122053" });

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CityId", "Name", "Phone" },
                values: new object[] { 6, "Kalle Erixon", "644512" });

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CityId", "Name", "Phone" },
                values: new object[] { 8, "Kalle Walker", "857793" });

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CityId", "Name", "Phone" },
                values: new object[] { 2, "Lisbet Zackow", "161824" });

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Yngve Walker", "585682" });

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Dave Vretman", "365417" });

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CityId", "Name", "Phone" },
                values: new object[] { 10, "Osborn Malmsten", "939992" });

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CityId", "Name", "Phone" },
                values: new object[] { 5, "Mika Krall", "717346" });

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CityId", "Name", "Phone" },
                values: new object[] { 7, "Åsa Jonsson", "135612" });

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CityId", "Name", "Phone" },
                values: new object[] { 11, "Ture Ståhl", "864833" });

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CityId", "Name", "Phone" },
                values: new object[] { 10, "Alva Zackow", "749506" });

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CityId", "Name", "Phone" },
                values: new object[] { 5, "Ture Ståhl", "745752" });

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CityId", "Name", "Phone" },
                values: new object[] { 5, "Ylva Vretman", "116747" });

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Alva Fahlgren", "157790" });

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CityId", "Name", "Phone" },
                values: new object[] { 5, "Yngve Erixon", "493850" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "cda6f899-bad1-4569-bbd6-9f5d739b779d", "d4b00c3f-2043-4f5b-bea1-6fe36d82d7ed" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e3ea8a48-a5fa-4023-8fc3-7ac081f9ed22");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "cda6f899-bad1-4569-bbd6-9f5d739b779d", "d4b00c3f-2043-4f5b-bea1-6fe36d82d7ed" });

            migrationBuilder.DeleteData(
                table: "LanguagePerson",
                keyColumns: new[] { "LanguagesId", "PeopleId" },
                keyValues: new object[] { 1, 4 });

            migrationBuilder.DeleteData(
                table: "LanguagePerson",
                keyColumns: new[] { "LanguagesId", "PeopleId" },
                keyValues: new object[] { 1, 9 });

            migrationBuilder.DeleteData(
                table: "LanguagePerson",
                keyColumns: new[] { "LanguagesId", "PeopleId" },
                keyValues: new object[] { 1, 10 });

            migrationBuilder.DeleteData(
                table: "LanguagePerson",
                keyColumns: new[] { "LanguagesId", "PeopleId" },
                keyValues: new object[] { 1, 13 });

            migrationBuilder.DeleteData(
                table: "LanguagePerson",
                keyColumns: new[] { "LanguagesId", "PeopleId" },
                keyValues: new object[] { 1, 16 });

            migrationBuilder.DeleteData(
                table: "LanguagePerson",
                keyColumns: new[] { "LanguagesId", "PeopleId" },
                keyValues: new object[] { 1, 20 });

            migrationBuilder.DeleteData(
                table: "LanguagePerson",
                keyColumns: new[] { "LanguagesId", "PeopleId" },
                keyValues: new object[] { 1, 21 });

            migrationBuilder.DeleteData(
                table: "LanguagePerson",
                keyColumns: new[] { "LanguagesId", "PeopleId" },
                keyValues: new object[] { 1, 24 });

            migrationBuilder.DeleteData(
                table: "LanguagePerson",
                keyColumns: new[] { "LanguagesId", "PeopleId" },
                keyValues: new object[] { 2, 4 });

            migrationBuilder.DeleteData(
                table: "LanguagePerson",
                keyColumns: new[] { "LanguagesId", "PeopleId" },
                keyValues: new object[] { 2, 12 });

            migrationBuilder.DeleteData(
                table: "LanguagePerson",
                keyColumns: new[] { "LanguagesId", "PeopleId" },
                keyValues: new object[] { 2, 24 });

            migrationBuilder.DeleteData(
                table: "LanguagePerson",
                keyColumns: new[] { "LanguagesId", "PeopleId" },
                keyValues: new object[] { 3, 6 });

            migrationBuilder.DeleteData(
                table: "LanguagePerson",
                keyColumns: new[] { "LanguagesId", "PeopleId" },
                keyValues: new object[] { 3, 11 });

            migrationBuilder.DeleteData(
                table: "LanguagePerson",
                keyColumns: new[] { "LanguagesId", "PeopleId" },
                keyValues: new object[] { 3, 13 });

            migrationBuilder.DeleteData(
                table: "LanguagePerson",
                keyColumns: new[] { "LanguagesId", "PeopleId" },
                keyValues: new object[] { 3, 18 });

            migrationBuilder.DeleteData(
                table: "LanguagePerson",
                keyColumns: new[] { "LanguagesId", "PeopleId" },
                keyValues: new object[] { 3, 21 });

            migrationBuilder.DeleteData(
                table: "LanguagePerson",
                keyColumns: new[] { "LanguagesId", "PeopleId" },
                keyValues: new object[] { 3, 23 });

            migrationBuilder.DeleteData(
                table: "LanguagePerson",
                keyColumns: new[] { "LanguagesId", "PeopleId" },
                keyValues: new object[] { 4, 14 });

            migrationBuilder.DeleteData(
                table: "LanguagePerson",
                keyColumns: new[] { "LanguagesId", "PeopleId" },
                keyValues: new object[] { 4, 19 });

            migrationBuilder.DeleteData(
                table: "LanguagePerson",
                keyColumns: new[] { "LanguagesId", "PeopleId" },
                keyValues: new object[] { 4, 22 });

            migrationBuilder.DeleteData(
                table: "LanguagePerson",
                keyColumns: new[] { "LanguagesId", "PeopleId" },
                keyValues: new object[] { 4, 24 });

            migrationBuilder.DeleteData(
                table: "LanguagePerson",
                keyColumns: new[] { "LanguagesId", "PeopleId" },
                keyValues: new object[] { 4, 25 });

            migrationBuilder.DeleteData(
                table: "LanguagePerson",
                keyColumns: new[] { "LanguagesId", "PeopleId" },
                keyValues: new object[] { 5, 4 });

            migrationBuilder.DeleteData(
                table: "LanguagePerson",
                keyColumns: new[] { "LanguagesId", "PeopleId" },
                keyValues: new object[] { 5, 9 });

            migrationBuilder.DeleteData(
                table: "LanguagePerson",
                keyColumns: new[] { "LanguagesId", "PeopleId" },
                keyValues: new object[] { 5, 21 });

            migrationBuilder.DeleteData(
                table: "LanguagePerson",
                keyColumns: new[] { "LanguagesId", "PeopleId" },
                keyValues: new object[] { 5, 25 });

            migrationBuilder.DeleteData(
                table: "LanguagePerson",
                keyColumns: new[] { "LanguagesId", "PeopleId" },
                keyValues: new object[] { 6, 5 });

            migrationBuilder.DeleteData(
                table: "LanguagePerson",
                keyColumns: new[] { "LanguagesId", "PeopleId" },
                keyValues: new object[] { 6, 6 });

            migrationBuilder.DeleteData(
                table: "LanguagePerson",
                keyColumns: new[] { "LanguagesId", "PeopleId" },
                keyValues: new object[] { 6, 12 });

            migrationBuilder.DeleteData(
                table: "LanguagePerson",
                keyColumns: new[] { "LanguagesId", "PeopleId" },
                keyValues: new object[] { 6, 14 });

            migrationBuilder.DeleteData(
                table: "LanguagePerson",
                keyColumns: new[] { "LanguagesId", "PeopleId" },
                keyValues: new object[] { 6, 19 });

            migrationBuilder.DeleteData(
                table: "LanguagePerson",
                keyColumns: new[] { "LanguagesId", "PeopleId" },
                keyValues: new object[] { 6, 23 });

            migrationBuilder.DeleteData(
                table: "LanguagePerson",
                keyColumns: new[] { "LanguagesId", "PeopleId" },
                keyValues: new object[] { 6, 24 });

            migrationBuilder.DeleteData(
                table: "LanguagePerson",
                keyColumns: new[] { "LanguagesId", "PeopleId" },
                keyValues: new object[] { 6, 25 });

            migrationBuilder.DeleteData(
                table: "LanguagePerson",
                keyColumns: new[] { "LanguagesId", "PeopleId" },
                keyValues: new object[] { 7, 1 });

            migrationBuilder.DeleteData(
                table: "LanguagePerson",
                keyColumns: new[] { "LanguagesId", "PeopleId" },
                keyValues: new object[] { 7, 7 });

            migrationBuilder.DeleteData(
                table: "LanguagePerson",
                keyColumns: new[] { "LanguagesId", "PeopleId" },
                keyValues: new object[] { 7, 19 });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cda6f899-bad1-4569-bbd6-9f5d739b779d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d4b00c3f-2043-4f5b-bea1-6fe36d82d7ed");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "34140290-2abe-488e-8340-3fd21e72d159", null, "Admin", null },
                    { "41ed0178-5107-4742-aaf1-efaeb1868788", null, "User", null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "BirthDate", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "2fe164a1-5ac0-4f32-a924-c3ff64d3ceee", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "00024d25-f772-42cb-9de0-1e41cb23f03b", "admin@admin.com", false, "Admin", "Admin", false, null, "ADMIN@ADMIN.COM", "ADMIN", "AQAAAAEAACcQAAAAEH8luAwVo7gJJSHcCwXPe1m4GRyBQ9BzHmXjkNfLrd+IHDy2Tfr9M+HGQy8B0NFYJg==", null, false, "4af2ed49-53a3-4b09-8249-38dbbdb0821f", false, "admin" });

            migrationBuilder.InsertData(
                table: "LanguagePerson",
                columns: new[] { "LanguagesId", "PeopleId" },
                values: new object[,]
                {
                    { 1, 8 },
                    { 1, 15 },
                    { 1, 22 },
                    { 2, 1 },
                    { 2, 7 },
                    { 2, 10 },
                    { 2, 20 },
                    { 2, 21 },
                    { 3, 14 },
                    { 3, 15 },
                    { 3, 22 },
                    { 4, 5 },
                    { 4, 6 },
                    { 4, 12 },
                    { 4, 13 },
                    { 4, 16 },
                    { 4, 23 },
                    { 5, 3 },
                    { 5, 5 },
                    { 5, 6 },
                    { 5, 10 },
                    { 5, 12 },
                    { 5, 15 },
                    { 6, 13 },
                    { 6, 17 },
                    { 6, 21 },
                    { 7, 2 },
                    { 7, 5 },
                    { 7, 13 },
                    { 7, 14 },
                    { 7, 16 },
                    { 7, 18 },
                    { 7, 22 }
                });

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CityId", "Name", "Phone" },
                values: new object[] { 9, "Adrian Walker", "873105" });

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CityId", "Name", "Phone" },
                values: new object[] { 10, "Kim Dahl", "683555" });

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CityId", "Name", "Phone" },
                values: new object[] { 4, "Ilja Dahl", "170913" });

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CityId", "Name", "Phone" },
                values: new object[] { 11, "Kalle Fahlgren", "961453" });

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CityId", "Name", "Phone" },
                values: new object[] { 9, "Lotta Zackow", "201380" });

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CityId", "Name", "Phone" },
                values: new object[] { 4, "Lotta Dahl", "344441" });

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CityId", "Name", "Phone" },
                values: new object[] { 12, "Klas Hjalmarsson", "191472" });

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CityId", "Name", "Phone" },
                values: new object[] { 11, "Dave Lindgren", "843353" });

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CityId", "Name", "Phone" },
                values: new object[] { 9, "Ilja Hjalmarsson", "477132" });

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Lisbet Sventon", "317017" });

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CityId", "Name", "Phone" },
                values: new object[] { 11, "Kim Vretman", "470380" });

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CityId", "Name", "Phone" },
                values: new object[] { 7, "Osborn Lindgren", "766548" });

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CityId", "Name", "Phone" },
                values: new object[] { 9, "Nisse Erixon", "783601" });

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CityId", "Name", "Phone" },
                values: new object[] { 11, "Alva Ivarsson", "745135" });

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Ture Erixon", "997749" });

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Ture Dahl", "991316" });

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CityId", "Name", "Phone" },
                values: new object[] { 12, "Alva Lindgren", "645981" });

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CityId", "Name", "Phone" },
                values: new object[] { 4, "Beda Ålander", "475535" });

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CityId", "Name", "Phone" },
                values: new object[] { 9, "Adrian Fahlgren", "561129" });

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CityId", "Name", "Phone" },
                values: new object[] { 7, "Alva Fahlgren", "428767" });

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CityId", "Name", "Phone" },
                values: new object[] { 1, "Beda Bildt", "676625" });

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CityId", "Name", "Phone" },
                values: new object[] { 12, "Beda Carlsson", "754983" });

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CityId", "Name", "Phone" },
                values: new object[] { 7, "Ture Hjalmarsson", "365754" });

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Beda Zackow", "649071" });

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CityId", "Name", "Phone" },
                values: new object[] { 10, "Lotta Hjalmarsson", "316138" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "34140290-2abe-488e-8340-3fd21e72d159", "2fe164a1-5ac0-4f32-a924-c3ff64d3ceee" });
        }
    }
}
