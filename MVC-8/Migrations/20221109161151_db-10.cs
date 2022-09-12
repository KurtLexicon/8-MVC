using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVC_8.Migrations
{
    public partial class db10 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "212ea74e-9002-4c1a-b4ad-c5e1207a3f6e");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "5d6ba5de-955b-41eb-b3a1-a844f2570555", "1004f470-054f-447a-97a7-07039562feb6" });

            migrationBuilder.DeleteData(
                table: "LanguagePerson",
                keyColumns: new[] { "LanguagesId", "PeopleId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "LanguagePerson",
                keyColumns: new[] { "LanguagesId", "PeopleId" },
                keyValues: new object[] { 1, 7 });

            migrationBuilder.DeleteData(
                table: "LanguagePerson",
                keyColumns: new[] { "LanguagesId", "PeopleId" },
                keyValues: new object[] { 1, 11 });

            migrationBuilder.DeleteData(
                table: "LanguagePerson",
                keyColumns: new[] { "LanguagesId", "PeopleId" },
                keyValues: new object[] { 1, 17 });

            migrationBuilder.DeleteData(
                table: "LanguagePerson",
                keyColumns: new[] { "LanguagesId", "PeopleId" },
                keyValues: new object[] { 1, 19 });

            migrationBuilder.DeleteData(
                table: "LanguagePerson",
                keyColumns: new[] { "LanguagesId", "PeopleId" },
                keyValues: new object[] { 1, 25 });

            migrationBuilder.DeleteData(
                table: "LanguagePerson",
                keyColumns: new[] { "LanguagesId", "PeopleId" },
                keyValues: new object[] { 2, 11 });

            migrationBuilder.DeleteData(
                table: "LanguagePerson",
                keyColumns: new[] { "LanguagesId", "PeopleId" },
                keyValues: new object[] { 2, 16 });

            migrationBuilder.DeleteData(
                table: "LanguagePerson",
                keyColumns: new[] { "LanguagesId", "PeopleId" },
                keyValues: new object[] { 2, 22 });

            migrationBuilder.DeleteData(
                table: "LanguagePerson",
                keyColumns: new[] { "LanguagesId", "PeopleId" },
                keyValues: new object[] { 2, 23 });

            migrationBuilder.DeleteData(
                table: "LanguagePerson",
                keyColumns: new[] { "LanguagesId", "PeopleId" },
                keyValues: new object[] { 2, 24 });

            migrationBuilder.DeleteData(
                table: "LanguagePerson",
                keyColumns: new[] { "LanguagesId", "PeopleId" },
                keyValues: new object[] { 2, 25 });

            migrationBuilder.DeleteData(
                table: "LanguagePerson",
                keyColumns: new[] { "LanguagesId", "PeopleId" },
                keyValues: new object[] { 3, 1 });

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
                keyValues: new object[] { 3, 23 });

            migrationBuilder.DeleteData(
                table: "LanguagePerson",
                keyColumns: new[] { "LanguagesId", "PeopleId" },
                keyValues: new object[] { 3, 25 });

            migrationBuilder.DeleteData(
                table: "LanguagePerson",
                keyColumns: new[] { "LanguagesId", "PeopleId" },
                keyValues: new object[] { 4, 4 });

            migrationBuilder.DeleteData(
                table: "LanguagePerson",
                keyColumns: new[] { "LanguagesId", "PeopleId" },
                keyValues: new object[] { 4, 7 });

            migrationBuilder.DeleteData(
                table: "LanguagePerson",
                keyColumns: new[] { "LanguagesId", "PeopleId" },
                keyValues: new object[] { 4, 15 });

            migrationBuilder.DeleteData(
                table: "LanguagePerson",
                keyColumns: new[] { "LanguagesId", "PeopleId" },
                keyValues: new object[] { 4, 22 });

            migrationBuilder.DeleteData(
                table: "LanguagePerson",
                keyColumns: new[] { "LanguagesId", "PeopleId" },
                keyValues: new object[] { 5, 1 });

            migrationBuilder.DeleteData(
                table: "LanguagePerson",
                keyColumns: new[] { "LanguagesId", "PeopleId" },
                keyValues: new object[] { 5, 4 });

            migrationBuilder.DeleteData(
                table: "LanguagePerson",
                keyColumns: new[] { "LanguagesId", "PeopleId" },
                keyValues: new object[] { 5, 7 });

            migrationBuilder.DeleteData(
                table: "LanguagePerson",
                keyColumns: new[] { "LanguagesId", "PeopleId" },
                keyValues: new object[] { 5, 9 });

            migrationBuilder.DeleteData(
                table: "LanguagePerson",
                keyColumns: new[] { "LanguagesId", "PeopleId" },
                keyValues: new object[] { 5, 13 });

            migrationBuilder.DeleteData(
                table: "LanguagePerson",
                keyColumns: new[] { "LanguagesId", "PeopleId" },
                keyValues: new object[] { 5, 16 });

            migrationBuilder.DeleteData(
                table: "LanguagePerson",
                keyColumns: new[] { "LanguagesId", "PeopleId" },
                keyValues: new object[] { 5, 18 });

            migrationBuilder.DeleteData(
                table: "LanguagePerson",
                keyColumns: new[] { "LanguagesId", "PeopleId" },
                keyValues: new object[] { 5, 19 });

            migrationBuilder.DeleteData(
                table: "LanguagePerson",
                keyColumns: new[] { "LanguagesId", "PeopleId" },
                keyValues: new object[] { 5, 24 });

            migrationBuilder.DeleteData(
                table: "LanguagePerson",
                keyColumns: new[] { "LanguagesId", "PeopleId" },
                keyValues: new object[] { 5, 25 });

            migrationBuilder.DeleteData(
                table: "LanguagePerson",
                keyColumns: new[] { "LanguagesId", "PeopleId" },
                keyValues: new object[] { 6, 4 });

            migrationBuilder.DeleteData(
                table: "LanguagePerson",
                keyColumns: new[] { "LanguagesId", "PeopleId" },
                keyValues: new object[] { 6, 6 });

            migrationBuilder.DeleteData(
                table: "LanguagePerson",
                keyColumns: new[] { "LanguagesId", "PeopleId" },
                keyValues: new object[] { 6, 19 });

            migrationBuilder.DeleteData(
                table: "LanguagePerson",
                keyColumns: new[] { "LanguagesId", "PeopleId" },
                keyValues: new object[] { 6, 22 });

            migrationBuilder.DeleteData(
                table: "LanguagePerson",
                keyColumns: new[] { "LanguagesId", "PeopleId" },
                keyValues: new object[] { 7, 3 });

            migrationBuilder.DeleteData(
                table: "LanguagePerson",
                keyColumns: new[] { "LanguagesId", "PeopleId" },
                keyValues: new object[] { 7, 7 });

            migrationBuilder.DeleteData(
                table: "LanguagePerson",
                keyColumns: new[] { "LanguagesId", "PeopleId" },
                keyValues: new object[] { 7, 9 });

            migrationBuilder.DeleteData(
                table: "LanguagePerson",
                keyColumns: new[] { "LanguagesId", "PeopleId" },
                keyValues: new object[] { 7, 11 });

            migrationBuilder.DeleteData(
                table: "LanguagePerson",
                keyColumns: new[] { "LanguagesId", "PeopleId" },
                keyValues: new object[] { 7, 23 });

            migrationBuilder.DeleteData(
                table: "LanguagePerson",
                keyColumns: new[] { "LanguagesId", "PeopleId" },
                keyValues: new object[] { 7, 24 });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5d6ba5de-955b-41eb-b3a1-a844f2570555");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1004f470-054f-447a-97a7-07039562feb6");

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
                    { 1, 14 },
                    { 1, 22 },
                    { 2, 3 },
                    { 2, 6 },
                    { 2, 7 },
                    { 2, 10 },
                    { 2, 20 },
                    { 2, 21 },
                    { 3, 12 },
                    { 3, 14 },
                    { 3, 17 },
                    { 3, 20 },
                    { 3, 22 },
                    { 4, 3 },
                    { 4, 10 },
                    { 4, 12 },
                    { 4, 13 },
                    { 4, 16 },
                    { 5, 3 },
                    { 5, 10 },
                    { 5, 12 },
                    { 5, 14 },
                    { 5, 22 },
                    { 6, 13 },
                    { 6, 16 },
                    { 6, 20 },
                    { 6, 21 },
                    { 7, 5 },
                    { 7, 6 },
                    { 7, 12 },
                    { 7, 13 },
                    { 7, 16 },
                    { 7, 20 },
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
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Kim Dahl", "683555" });

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
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Dave Lindgren", "843353" });

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Ilja Hjalmarsson", "477132" });

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CityId", "Name", "Phone" },
                values: new object[] { 5, "Lisbet Sventon", "317017" });

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
                columns: new[] { "CityId", "Name", "Phone" },
                values: new object[] { 4, "Ture Dahl", "991316" });

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
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Beda Bildt", "676625" });

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
                columns: new[] { "CityId", "Name", "Phone" },
                values: new object[] { 7, "Beda Zackow", "649071" });

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                keyValues: new object[] { 1, 14 });

            migrationBuilder.DeleteData(
                table: "LanguagePerson",
                keyColumns: new[] { "LanguagesId", "PeopleId" },
                keyValues: new object[] { 1, 22 });

            migrationBuilder.DeleteData(
                table: "LanguagePerson",
                keyColumns: new[] { "LanguagesId", "PeopleId" },
                keyValues: new object[] { 2, 3 });

            migrationBuilder.DeleteData(
                table: "LanguagePerson",
                keyColumns: new[] { "LanguagesId", "PeopleId" },
                keyValues: new object[] { 2, 6 });

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
                keyValues: new object[] { 3, 12 });

            migrationBuilder.DeleteData(
                table: "LanguagePerson",
                keyColumns: new[] { "LanguagesId", "PeopleId" },
                keyValues: new object[] { 3, 14 });

            migrationBuilder.DeleteData(
                table: "LanguagePerson",
                keyColumns: new[] { "LanguagesId", "PeopleId" },
                keyValues: new object[] { 3, 17 });

            migrationBuilder.DeleteData(
                table: "LanguagePerson",
                keyColumns: new[] { "LanguagesId", "PeopleId" },
                keyValues: new object[] { 3, 20 });

            migrationBuilder.DeleteData(
                table: "LanguagePerson",
                keyColumns: new[] { "LanguagesId", "PeopleId" },
                keyValues: new object[] { 3, 22 });

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
                keyValues: new object[] { 5, 3 });

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
                keyValues: new object[] { 5, 14 });

            migrationBuilder.DeleteData(
                table: "LanguagePerson",
                keyColumns: new[] { "LanguagesId", "PeopleId" },
                keyValues: new object[] { 5, 22 });

            migrationBuilder.DeleteData(
                table: "LanguagePerson",
                keyColumns: new[] { "LanguagesId", "PeopleId" },
                keyValues: new object[] { 6, 13 });

            migrationBuilder.DeleteData(
                table: "LanguagePerson",
                keyColumns: new[] { "LanguagesId", "PeopleId" },
                keyValues: new object[] { 6, 16 });

            migrationBuilder.DeleteData(
                table: "LanguagePerson",
                keyColumns: new[] { "LanguagesId", "PeopleId" },
                keyValues: new object[] { 6, 20 });

            migrationBuilder.DeleteData(
                table: "LanguagePerson",
                keyColumns: new[] { "LanguagesId", "PeopleId" },
                keyValues: new object[] { 6, 21 });

            migrationBuilder.DeleteData(
                table: "LanguagePerson",
                keyColumns: new[] { "LanguagesId", "PeopleId" },
                keyValues: new object[] { 7, 5 });

            migrationBuilder.DeleteData(
                table: "LanguagePerson",
                keyColumns: new[] { "LanguagesId", "PeopleId" },
                keyValues: new object[] { 7, 6 });

            migrationBuilder.DeleteData(
                table: "LanguagePerson",
                keyColumns: new[] { "LanguagesId", "PeopleId" },
                keyValues: new object[] { 7, 12 });

            migrationBuilder.DeleteData(
                table: "LanguagePerson",
                keyColumns: new[] { "LanguagesId", "PeopleId" },
                keyValues: new object[] { 7, 13 });

            migrationBuilder.DeleteData(
                table: "LanguagePerson",
                keyColumns: new[] { "LanguagesId", "PeopleId" },
                keyValues: new object[] { 7, 16 });

            migrationBuilder.DeleteData(
                table: "LanguagePerson",
                keyColumns: new[] { "LanguagesId", "PeopleId" },
                keyValues: new object[] { 7, 20 });

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
                    { "212ea74e-9002-4c1a-b4ad-c5e1207a3f6e", null, "User", null },
                    { "5d6ba5de-955b-41eb-b3a1-a844f2570555", null, "Admin", null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "BirthDate", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "1004f470-054f-447a-97a7-07039562feb6", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "43950fb0-1fe6-43f8-88a8-21928970d4d4", "admin@admin.com", false, "Admin", "Admin", false, null, "ADMIN@ADMIN.COM", "ADMIN", "AQAAAAEAACcQAAAAEBcc23TtN/lS0Mkxu19QVu8aPxWV7YyfQEbOneObszyDeLMZ5WAb3EwXf44RAb040g==", null, false, "be2fb879-8f57-44af-a2b9-0964d3bb79b3", false, "admin" });

            migrationBuilder.InsertData(
                table: "LanguagePerson",
                columns: new[] { "LanguagesId", "PeopleId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 7 },
                    { 1, 11 },
                    { 1, 17 },
                    { 1, 19 },
                    { 1, 25 },
                    { 2, 11 },
                    { 2, 16 },
                    { 2, 22 },
                    { 2, 23 },
                    { 2, 24 },
                    { 2, 25 },
                    { 3, 1 },
                    { 3, 6 },
                    { 3, 11 },
                    { 3, 23 },
                    { 3, 25 },
                    { 4, 4 },
                    { 4, 7 },
                    { 4, 15 },
                    { 4, 22 },
                    { 5, 1 },
                    { 5, 4 },
                    { 5, 7 },
                    { 5, 9 },
                    { 5, 13 },
                    { 5, 16 },
                    { 5, 18 },
                    { 5, 19 },
                    { 5, 24 },
                    { 5, 25 },
                    { 6, 4 },
                    { 6, 6 },
                    { 6, 19 },
                    { 6, 22 },
                    { 7, 3 },
                    { 7, 7 },
                    { 7, 9 },
                    { 7, 11 }
                });

            migrationBuilder.InsertData(
                table: "LanguagePerson",
                columns: new[] { "LanguagesId", "PeopleId" },
                values: new object[,]
                {
                    { 7, 23 },
                    { 7, 24 }
                });

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CityId", "Name", "Phone" },
                values: new object[] { 12, "Beda Dahl", "713480" });

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Lisbet Zackow", "491755" });

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CityId", "Name", "Phone" },
                values: new object[] { 12, "Adrian Ålander", "855214" });

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CityId", "Name", "Phone" },
                values: new object[] { 6, "Olle Hjalmarsson", "930605" });

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CityId", "Name", "Phone" },
                values: new object[] { 2, "Adrian Jonsson", "485295" });

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CityId", "Name", "Phone" },
                values: new object[] { 8, "Adrian Sventon", "327587" });

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CityId", "Name", "Phone" },
                values: new object[] { 7, "Olle Erixon", "560182" });

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Åsa Sventon", "920249" });

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Kim Sventon", "888439" });

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CityId", "Name", "Phone" },
                values: new object[] { 3, "Lisbet Hjalmarsson", "338361" });

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CityId", "Name", "Phone" },
                values: new object[] { 5, "Beda Ståhl", "716302" });

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CityId", "Name", "Phone" },
                values: new object[] { 11, "Kim Ivarsson", "376751" });

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CityId", "Name", "Phone" },
                values: new object[] { 10, "Ylva Malmsten", "929120" });

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CityId", "Name", "Phone" },
                values: new object[] { 6, "Ilja Ivarsson", "973550" });

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Olle Zackow", "179079" });

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CityId", "Name", "Phone" },
                values: new object[] { 6, "Osborn Carlsson", "110108" });

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CityId", "Name", "Phone" },
                values: new object[] { 2, "Kalle Krall", "594745" });

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CityId", "Name", "Phone" },
                values: new object[] { 5, "Alva Malmsten", "520198" });

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CityId", "Name", "Phone" },
                values: new object[] { 11, "Lisbet Ålander", "171623" });

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CityId", "Name", "Phone" },
                values: new object[] { 3, "Ture Dahl", "724403" });

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Name", "Phone" },
                values: new object[] { "Mika Fahlgren", "773261" });

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CityId", "Name", "Phone" },
                values: new object[] { 8, "Ylva Walker", "353269" });

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CityId", "Name", "Phone" },
                values: new object[] { 11, "Ture Ivarsson", "303758" });

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CityId", "Name", "Phone" },
                values: new object[] { 1, "Lisbet Dahl", "105257" });

            migrationBuilder.UpdateData(
                table: "People",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CityId", "Name", "Phone" },
                values: new object[] { 9, "Adrian Bildt", "623020" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "5d6ba5de-955b-41eb-b3a1-a844f2570555", "1004f470-054f-447a-97a7-07039562feb6" });
        }
    }
}
