using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVC_8.Migrations
{
    public partial class _2211172 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                keyValues: new object[] { 1, 18 });

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
                keyValues: new object[] { 2, 6 });

            migrationBuilder.DeleteData(
                table: "LanguagePerson",
                keyColumns: new[] { "LanguagesId", "PeopleId" },
                keyValues: new object[] { 2, 18 });

            migrationBuilder.DeleteData(
                table: "LanguagePerson",
                keyColumns: new[] { "LanguagesId", "PeopleId" },
                keyValues: new object[] { 2, 24 });

            migrationBuilder.DeleteData(
                table: "LanguagePerson",
                keyColumns: new[] { "LanguagesId", "PeopleId" },
                keyValues: new object[] { 3, 4 });

            migrationBuilder.DeleteData(
                table: "LanguagePerson",
                keyColumns: new[] { "LanguagesId", "PeopleId" },
                keyValues: new object[] { 3, 6 });

            migrationBuilder.DeleteData(
                table: "LanguagePerson",
                keyColumns: new[] { "LanguagesId", "PeopleId" },
                keyValues: new object[] { 3, 12 });

            migrationBuilder.DeleteData(
                table: "LanguagePerson",
                keyColumns: new[] { "LanguagesId", "PeopleId" },
                keyValues: new object[] { 3, 13 });

            migrationBuilder.DeleteData(
                table: "LanguagePerson",
                keyColumns: new[] { "LanguagesId", "PeopleId" },
                keyValues: new object[] { 3, 16 });

            migrationBuilder.DeleteData(
                table: "LanguagePerson",
                keyColumns: new[] { "LanguagesId", "PeopleId" },
                keyValues: new object[] { 3, 17 });

            migrationBuilder.DeleteData(
                table: "LanguagePerson",
                keyColumns: new[] { "LanguagesId", "PeopleId" },
                keyValues: new object[] { 3, 18 });

            migrationBuilder.DeleteData(
                table: "LanguagePerson",
                keyColumns: new[] { "LanguagesId", "PeopleId" },
                keyValues: new object[] { 4, 3 });

            migrationBuilder.DeleteData(
                table: "LanguagePerson",
                keyColumns: new[] { "LanguagesId", "PeopleId" },
                keyValues: new object[] { 4, 10 });

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
                keyValues: new object[] { 5, 4 });

            migrationBuilder.DeleteData(
                table: "LanguagePerson",
                keyColumns: new[] { "LanguagesId", "PeopleId" },
                keyValues: new object[] { 5, 9 });

            migrationBuilder.DeleteData(
                table: "LanguagePerson",
                keyColumns: new[] { "LanguagesId", "PeopleId" },
                keyValues: new object[] { 5, 14 });

            migrationBuilder.DeleteData(
                table: "LanguagePerson",
                keyColumns: new[] { "LanguagesId", "PeopleId" },
                keyValues: new object[] { 5, 17 });

            migrationBuilder.DeleteData(
                table: "LanguagePerson",
                keyColumns: new[] { "LanguagesId", "PeopleId" },
                keyValues: new object[] { 5, 22 });

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
                keyValues: new object[] { 7, 6 });

            migrationBuilder.DeleteData(
                table: "LanguagePerson",
                keyColumns: new[] { "LanguagesId", "PeopleId" },
                keyValues: new object[] { 7, 19 });

            migrationBuilder.DeleteData(
                table: "LanguagePerson",
                keyColumns: new[] { "LanguagesId", "PeopleId" },
                keyValues: new object[] { 7, 20 });

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
                    { "65323db4-0ca7-483b-af60-65a90ec788af", null, "Admin", "ADMIN" },
                    { "f113ba97-e370-4c47-b3e9-3e5a04487809", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "BirthDate", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "1062b699-f2ac-45e3-abbc-3153cec81ac8", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "c73dbe06-684e-4f5e-9a71-fa8aa9a44fe8", "admin@admin.com", false, "Admin", "Admin", false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAEAACcQAAAAEIM4dyyFgSdUT1AelNuU9anV38CL3nCe1fNJ2pD8Db3bbJo4rutWW6jfu5bPWVpQRQ==", null, false, "f182b757-3ccc-4e44-8535-99228f1c591a", false, "admin@admin.com" });

            migrationBuilder.InsertData(
                table: "LanguagePerson",
                columns: new[] { "LanguagesId", "PeopleId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 2 },
                    { 1, 5 },
                    { 1, 11 },
                    { 1, 12 },
                    { 1, 22 },
                    { 2, 5 },
                    { 2, 7 },
                    { 2, 9 },
                    { 2, 11 },
                    { 2, 21 },
                    { 2, 22 },
                    { 2, 25 },
                    { 3, 5 },
                    { 3, 7 },
                    { 3, 25 },
                    { 4, 2 },
                    { 4, 8 },
                    { 4, 9 },
                    { 4, 16 },
                    { 5, 11 },
                    { 5, 16 },
                    { 6, 1 },
                    { 6, 3 },
                    { 6, 4 },
                    { 6, 7 },
                    { 6, 10 },
                    { 6, 13 },
                    { 6, 22 },
                    { 7, 8 },
                    { 7, 14 },
                    { 7, 16 },
                    { 7, 22 }
                });

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CityId", "Name", "Phone" },
                values: new object[] { 5, "Olle Bildt", "669140" });

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CityId", "Name", "Phone" },
                values: new object[] { 2, "Dave Walker", "147139" });

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CityId", "Name", "Phone" },
                values: new object[] { 2, "Kalle Lindgren", "743027" });

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CityId", "Name", "Phone" },
                values: new object[] { 9, "Olle Fahlgren", "280915" });

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CityId", "Name", "Phone" },
                values: new object[] { 1, "Beda Ståhl", "280452" });

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CityId", "Name", "Phone" },
                values: new object[] { 5, "Dave Ålander", "946739" });

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CityId", "Name", "Phone" },
                values: new object[] { 12, "Adrian Sventon", "840031" });

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CityId", "Name", "Phone" },
                values: new object[] { 1, "Åsa Dahl", "426903" });

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CityId", "Name", "Phone" },
                values: new object[] { 5, "Alva Sventon", "457281" });

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CityId", "Name", "Phone" },
                values: new object[] { 1, "Ulla Fahlgren", "368535" });

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CityId", "Name", "Phone" },
                values: new object[] { 7, "Nisse Sventon", "266125" });

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Beda Dahl", "868170" });

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CityId", "Name", "Phone" },
                values: new object[] { 10, "Ture Bildt", "767862" });

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CityId", "Name", "Phone" },
                values: new object[] { 6, "Nisse Ivarsson", "489406" });

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CityId", "Name", "Phone" },
                values: new object[] { 7, "Ture Bildt", "436687" });

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CityId", "Name", "Phone" },
                values: new object[] { 10, "Kalle Malmsten", "504479" });

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CityId", "Name", "Phone" },
                values: new object[] { 5, "Ulla Ålander", "928310" });

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CityId", "Name", "Phone" },
                values: new object[] { 12, "Nisse Ålander", "351721" });

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CityId", "Name", "Phone" },
                values: new object[] { 8, "Lisbet Jonsson", "595372" });

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Lotta Malmsten", "353681" });

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CityId", "Name", "Phone" },
                values: new object[] { 12, "Mika Erixon", "696748" });

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CityId", "Name", "Phone" },
                values: new object[] { 11, "Ilja Malmsten", "608977" });

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CityId", "Name", "Phone" },
                values: new object[] { 2, "Nisse Ståhl", "693290" });

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CityId", "Name", "Phone" },
                values: new object[] { 11, "Ilja Erixon", "481369" });

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CityId", "Name", "Phone" },
                values: new object[] { 6, "Alva Fahlgren", "599424" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "65323db4-0ca7-483b-af60-65a90ec788af", "1062b699-f2ac-45e3-abbc-3153cec81ac8" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f113ba97-e370-4c47-b3e9-3e5a04487809");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "65323db4-0ca7-483b-af60-65a90ec788af", "1062b699-f2ac-45e3-abbc-3153cec81ac8" });

            migrationBuilder.DeleteData(
                table: "LanguagePerson",
                keyColumns: new[] { "LanguagesId", "PeopleId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "LanguagePerson",
                keyColumns: new[] { "LanguagesId", "PeopleId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "LanguagePerson",
                keyColumns: new[] { "LanguagesId", "PeopleId" },
                keyValues: new object[] { 1, 5 });

            migrationBuilder.DeleteData(
                table: "LanguagePerson",
                keyColumns: new[] { "LanguagesId", "PeopleId" },
                keyValues: new object[] { 1, 11 });

            migrationBuilder.DeleteData(
                table: "LanguagePerson",
                keyColumns: new[] { "LanguagesId", "PeopleId" },
                keyValues: new object[] { 1, 12 });

            migrationBuilder.DeleteData(
                table: "LanguagePerson",
                keyColumns: new[] { "LanguagesId", "PeopleId" },
                keyValues: new object[] { 1, 22 });

            migrationBuilder.DeleteData(
                table: "LanguagePerson",
                keyColumns: new[] { "LanguagesId", "PeopleId" },
                keyValues: new object[] { 2, 5 });

            migrationBuilder.DeleteData(
                table: "LanguagePerson",
                keyColumns: new[] { "LanguagesId", "PeopleId" },
                keyValues: new object[] { 2, 7 });

            migrationBuilder.DeleteData(
                table: "LanguagePerson",
                keyColumns: new[] { "LanguagesId", "PeopleId" },
                keyValues: new object[] { 2, 9 });

            migrationBuilder.DeleteData(
                table: "LanguagePerson",
                keyColumns: new[] { "LanguagesId", "PeopleId" },
                keyValues: new object[] { 2, 11 });

            migrationBuilder.DeleteData(
                table: "LanguagePerson",
                keyColumns: new[] { "LanguagesId", "PeopleId" },
                keyValues: new object[] { 2, 21 });

            migrationBuilder.DeleteData(
                table: "LanguagePerson",
                keyColumns: new[] { "LanguagesId", "PeopleId" },
                keyValues: new object[] { 2, 22 });

            migrationBuilder.DeleteData(
                table: "LanguagePerson",
                keyColumns: new[] { "LanguagesId", "PeopleId" },
                keyValues: new object[] { 2, 25 });

            migrationBuilder.DeleteData(
                table: "LanguagePerson",
                keyColumns: new[] { "LanguagesId", "PeopleId" },
                keyValues: new object[] { 3, 5 });

            migrationBuilder.DeleteData(
                table: "LanguagePerson",
                keyColumns: new[] { "LanguagesId", "PeopleId" },
                keyValues: new object[] { 3, 7 });

            migrationBuilder.DeleteData(
                table: "LanguagePerson",
                keyColumns: new[] { "LanguagesId", "PeopleId" },
                keyValues: new object[] { 3, 25 });

            migrationBuilder.DeleteData(
                table: "LanguagePerson",
                keyColumns: new[] { "LanguagesId", "PeopleId" },
                keyValues: new object[] { 4, 2 });

            migrationBuilder.DeleteData(
                table: "LanguagePerson",
                keyColumns: new[] { "LanguagesId", "PeopleId" },
                keyValues: new object[] { 4, 8 });

            migrationBuilder.DeleteData(
                table: "LanguagePerson",
                keyColumns: new[] { "LanguagesId", "PeopleId" },
                keyValues: new object[] { 4, 9 });

            migrationBuilder.DeleteData(
                table: "LanguagePerson",
                keyColumns: new[] { "LanguagesId", "PeopleId" },
                keyValues: new object[] { 4, 16 });

            migrationBuilder.DeleteData(
                table: "LanguagePerson",
                keyColumns: new[] { "LanguagesId", "PeopleId" },
                keyValues: new object[] { 5, 11 });

            migrationBuilder.DeleteData(
                table: "LanguagePerson",
                keyColumns: new[] { "LanguagesId", "PeopleId" },
                keyValues: new object[] { 5, 16 });

            migrationBuilder.DeleteData(
                table: "LanguagePerson",
                keyColumns: new[] { "LanguagesId", "PeopleId" },
                keyValues: new object[] { 6, 1 });

            migrationBuilder.DeleteData(
                table: "LanguagePerson",
                keyColumns: new[] { "LanguagesId", "PeopleId" },
                keyValues: new object[] { 6, 3 });

            migrationBuilder.DeleteData(
                table: "LanguagePerson",
                keyColumns: new[] { "LanguagesId", "PeopleId" },
                keyValues: new object[] { 6, 4 });

            migrationBuilder.DeleteData(
                table: "LanguagePerson",
                keyColumns: new[] { "LanguagesId", "PeopleId" },
                keyValues: new object[] { 6, 7 });

            migrationBuilder.DeleteData(
                table: "LanguagePerson",
                keyColumns: new[] { "LanguagesId", "PeopleId" },
                keyValues: new object[] { 6, 10 });

            migrationBuilder.DeleteData(
                table: "LanguagePerson",
                keyColumns: new[] { "LanguagesId", "PeopleId" },
                keyValues: new object[] { 6, 13 });

            migrationBuilder.DeleteData(
                table: "LanguagePerson",
                keyColumns: new[] { "LanguagesId", "PeopleId" },
                keyValues: new object[] { 6, 22 });

            migrationBuilder.DeleteData(
                table: "LanguagePerson",
                keyColumns: new[] { "LanguagesId", "PeopleId" },
                keyValues: new object[] { 7, 8 });

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
                keyValues: new object[] { 7, 22 });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "65323db4-0ca7-483b-af60-65a90ec788af");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1062b699-f2ac-45e3-abbc-3153cec81ac8");

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
                    { 1, 18 },
                    { 1, 20 },
                    { 1, 21 },
                    { 1, 24 },
                    { 2, 4 },
                    { 2, 6 },
                    { 2, 18 },
                    { 2, 24 },
                    { 3, 4 },
                    { 3, 6 },
                    { 3, 12 },
                    { 3, 13 },
                    { 3, 16 },
                    { 3, 17 },
                    { 3, 18 },
                    { 4, 3 },
                    { 4, 10 },
                    { 4, 14 },
                    { 4, 19 },
                    { 4, 22 },
                    { 4, 24 },
                    { 5, 4 },
                    { 5, 9 },
                    { 5, 14 },
                    { 5, 17 },
                    { 5, 22 },
                    { 6, 6 },
                    { 6, 12 },
                    { 6, 14 },
                    { 6, 19 },
                    { 6, 23 },
                    { 6, 24 },
                    { 6, 25 },
                    { 7, 1 }
                });

            migrationBuilder.InsertData(
                table: "LanguagePerson",
                columns: new[] { "LanguagesId", "PeopleId" },
                values: new object[,]
                {
                    { 7, 6 },
                    { 7, 19 },
                    { 7, 20 }
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
                columns: new[] { "CityId", "Name", "Phone" },
                values: new object[] { 5, "Kalle Hjalmarsson", "870763" });

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
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Kalle Erixon", "644512" });

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
                columns: new[] { "CityId", "Name", "Phone" },
                values: new object[] { 10, "Yngve Walker", "585682" });

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CityId", "Name", "Phone" },
                values: new object[] { 4, "Dave Vretman", "365417" });

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
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Ture Ståhl", "864833" });

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
                columns: new[] { "CityId", "Name", "Phone" },
                values: new object[] { 7, "Alva Fahlgren", "157790" });

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
    }
}
