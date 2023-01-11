using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Afisha.Migrations
{
    public partial class picture2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "Picture",
                table: "Tickets",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "Picture",
                table: "Events",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "44546e06-8719-4ad8-b88a-f271ae9d6eab",
                column: "ConcurrencyStamp",
                value: "41d0cd6c-af05-469c-b459-a1527226bb63");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b62472e-4f66-49fa-a20f-e7685b9565d8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c31a15f1-bd1b-4a26-a860-de9c7f954c5b", "AQAAAAEAACcQAAAAEEbLYw2tvGJpZgu7hEGOrcdgt1ZGVEdsdlOxbQl+XK9JjKb3nhpjU/E52G4VwxH3jQ==" });

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("2863fe2b-ddb9-4a7a-a74d-5fb64be349de"),
                column: "DateAdded",
                value: new DateTime(2023, 1, 11, 7, 47, 59, 323, DateTimeKind.Utc).AddTicks(3415));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("4aa76a4c-c59d-409a-84c1-06e6487a137a"),
                column: "DateAdded",
                value: new DateTime(2023, 1, 11, 7, 47, 59, 323, DateTimeKind.Utc).AddTicks(3404));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("63dc8fa6-07ae-4391-8916-e057f71239ce"),
                column: "DateAdded",
                value: new DateTime(2023, 1, 11, 7, 47, 59, 323, DateTimeKind.Utc).AddTicks(3360));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("70bf165a-700a-4156-91c0-e83fce0a277f"),
                column: "DateAdded",
                value: new DateTime(2023, 1, 11, 7, 47, 59, 323, DateTimeKind.Utc).AddTicks(3391));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Picture",
                table: "Tickets");

            migrationBuilder.DropColumn(
                name: "Picture",
                table: "Events");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "44546e06-8719-4ad8-b88a-f271ae9d6eab",
                column: "ConcurrencyStamp",
                value: "9302151f-8b95-465b-b91e-fe56b32b6881");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b62472e-4f66-49fa-a20f-e7685b9565d8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "94702a13-2a62-44de-b1c1-9532b036c160", "AQAAAAEAACcQAAAAEJU3WvGnGOvEnNa3gWozazE3M2T4faTIVClc3HrH49V4SVCua7hqSNU/1qzm8+Z9Uw==" });

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("2863fe2b-ddb9-4a7a-a74d-5fb64be349de"),
                column: "DateAdded",
                value: new DateTime(2023, 1, 11, 7, 22, 31, 66, DateTimeKind.Utc).AddTicks(2925));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("4aa76a4c-c59d-409a-84c1-06e6487a137a"),
                column: "DateAdded",
                value: new DateTime(2023, 1, 11, 7, 22, 31, 66, DateTimeKind.Utc).AddTicks(2913));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("63dc8fa6-07ae-4391-8916-e057f71239ce"),
                column: "DateAdded",
                value: new DateTime(2023, 1, 11, 7, 22, 31, 66, DateTimeKind.Utc).AddTicks(2876));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("70bf165a-700a-4156-91c0-e83fce0a277f"),
                column: "DateAdded",
                value: new DateTime(2023, 1, 11, 7, 22, 31, 66, DateTimeKind.Utc).AddTicks(2901));
        }
    }
}
