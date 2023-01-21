using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Afisha.Migrations
{
    public partial class picture : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "44546e06-8719-4ad8-b88a-f271ae9d6eab",
                column: "ConcurrencyStamp",
                value: "63fa62c5-be84-4e48-aaea-343709a44eae");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b62472e-4f66-49fa-a20f-e7685b9565d8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f2b5dba6-82c0-492e-95a2-0144d2a04499", "AQAAAAEAACcQAAAAELCUOqb7LwvdJbByYDOA4BqLhqSXJPHGqAThLNzVi1HcFUFs4+C4acyNzOn7bQbtNw==" });

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("2863fe2b-ddb9-4a7a-a74d-5fb64be349de"),
                column: "DateAdded",
                value: new DateTime(2023, 1, 11, 7, 19, 56, 116, DateTimeKind.Utc).AddTicks(5579));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("4aa76a4c-c59d-409a-84c1-06e6487a137a"),
                column: "DateAdded",
                value: new DateTime(2023, 1, 11, 7, 19, 56, 116, DateTimeKind.Utc).AddTicks(5567));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("63dc8fa6-07ae-4391-8916-e057f71239ce"),
                column: "DateAdded",
                value: new DateTime(2023, 1, 11, 7, 19, 56, 116, DateTimeKind.Utc).AddTicks(5528));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("70bf165a-700a-4156-91c0-e83fce0a277f"),
                column: "DateAdded",
                value: new DateTime(2023, 1, 11, 7, 19, 56, 116, DateTimeKind.Utc).AddTicks(5555));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "44546e06-8719-4ad8-b88a-f271ae9d6eab",
                column: "ConcurrencyStamp",
                value: "c2837eda-df3f-436e-9743-24e2226269a1");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b62472e-4f66-49fa-a20f-e7685b9565d8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "53c259db-7bc0-4e4f-a7a8-5b467ad01933", "AQAAAAEAACcQAAAAEHyqqC4poh3fZLz0DzCsh7fsMiHzDa66eyRAwndoIxLWvLqn1hF4Jf5JSnA8AW5Zmg==" });

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("2863fe2b-ddb9-4a7a-a74d-5fb64be349de"),
                column: "DateAdded",
                value: new DateTime(2022, 12, 25, 18, 0, 15, 336, DateTimeKind.Utc).AddTicks(209));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("4aa76a4c-c59d-409a-84c1-06e6487a137a"),
                column: "DateAdded",
                value: new DateTime(2022, 12, 25, 18, 0, 15, 336, DateTimeKind.Utc).AddTicks(196));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("63dc8fa6-07ae-4391-8916-e057f71239ce"),
                column: "DateAdded",
                value: new DateTime(2022, 12, 25, 18, 0, 15, 336, DateTimeKind.Utc).AddTicks(146));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("70bf165a-700a-4156-91c0-e83fce0a277f"),
                column: "DateAdded",
                value: new DateTime(2022, 12, 25, 18, 0, 15, 336, DateTimeKind.Utc).AddTicks(182));
        }
    }
}
