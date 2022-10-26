using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Afisha.Migrations
{
    public partial class _initial3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "44546e06-8719-4ad8-b88a-f271ae9d6eab",
                column: "ConcurrencyStamp",
                value: "395fbc33-31f2-4d6f-8b3b-674d1a110cd5");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b62472e-4f66-49fa-a20f-e7685b9565d8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a7121dce-4410-47df-809b-9d062ddf3eca", "AQAAAAEAACcQAAAAEHdhKw6u1n9xqB5DPosaDNvRYKyApeAoFAFjvNgyb9JEl5hOVQ/6b/gT4HpWzEBM+w==" });

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("2863fe2b-ddb9-4a7a-a74d-5fb64be349de"),
                column: "DateAdded",
                value: new DateTime(2022, 10, 25, 18, 2, 43, 144, DateTimeKind.Utc).AddTicks(6287));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("4aa76a4c-c59d-409a-84c1-06e6487a137a"),
                column: "DateAdded",
                value: new DateTime(2022, 10, 25, 18, 2, 43, 144, DateTimeKind.Utc).AddTicks(6279));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("63dc8fa6-07ae-4391-8916-e057f71239ce"),
                column: "DateAdded",
                value: new DateTime(2022, 10, 25, 18, 2, 43, 144, DateTimeKind.Utc).AddTicks(6247));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("70bf165a-700a-4156-91c0-e83fce0a277f"),
                column: "DateAdded",
                value: new DateTime(2022, 10, 25, 18, 2, 43, 144, DateTimeKind.Utc).AddTicks(6271));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "44546e06-8719-4ad8-b88a-f271ae9d6eab",
                column: "ConcurrencyStamp",
                value: "7bb821e4-3da5-4fcb-8871-2bce63720e1a");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b62472e-4f66-49fa-a20f-e7685b9565d8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "9094c1c3-77ec-490b-875a-bf0b40f902d6", "AQAAAAEAACcQAAAAEI6MbDUjLaHebFOBqDQboEbAXoOYLioPB+/qlf2DV7V4pR817N0TowwcSTela8+2hQ==" });

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("2863fe2b-ddb9-4a7a-a74d-5fb64be349de"),
                column: "DateAdded",
                value: new DateTime(2022, 10, 25, 12, 10, 39, 970, DateTimeKind.Utc).AddTicks(1560));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("4aa76a4c-c59d-409a-84c1-06e6487a137a"),
                column: "DateAdded",
                value: new DateTime(2022, 10, 25, 12, 10, 39, 970, DateTimeKind.Utc).AddTicks(1546));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("63dc8fa6-07ae-4391-8916-e057f71239ce"),
                column: "DateAdded",
                value: new DateTime(2022, 10, 25, 12, 10, 39, 970, DateTimeKind.Utc).AddTicks(1494));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("70bf165a-700a-4156-91c0-e83fce0a277f"),
                column: "DateAdded",
                value: new DateTime(2022, 10, 25, 12, 10, 39, 970, DateTimeKind.Utc).AddTicks(1531));
        }
    }
}
