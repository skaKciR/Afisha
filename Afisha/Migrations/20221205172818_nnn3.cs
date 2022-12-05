using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Afisha.Migrations
{
    public partial class nnn3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "PCard",
                table: "Events",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "44546e06-8719-4ad8-b88a-f271ae9d6eab",
                column: "ConcurrencyStamp",
                value: "da5caebd-85b5-4aa2-beb1-f98bcad6fa34");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b62472e-4f66-49fa-a20f-e7685b9565d8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "1ce41c83-d4da-4762-9cad-60c7f9aa343e", "AQAAAAEAACcQAAAAEKBMd5NAEUMbbIBHv/OxN+t+Y0TbXK/NT79s5RPiWSiRrarYqXbwyjja0yVM1u8RRg==" });

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("2863fe2b-ddb9-4a7a-a74d-5fb64be349de"),
                column: "DateAdded",
                value: new DateTime(2022, 12, 5, 17, 28, 17, 564, DateTimeKind.Utc).AddTicks(6705));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("4aa76a4c-c59d-409a-84c1-06e6487a137a"),
                column: "DateAdded",
                value: new DateTime(2022, 12, 5, 17, 28, 17, 564, DateTimeKind.Utc).AddTicks(6693));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("63dc8fa6-07ae-4391-8916-e057f71239ce"),
                column: "DateAdded",
                value: new DateTime(2022, 12, 5, 17, 28, 17, 564, DateTimeKind.Utc).AddTicks(6652));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("70bf165a-700a-4156-91c0-e83fce0a277f"),
                column: "DateAdded",
                value: new DateTime(2022, 12, 5, 17, 28, 17, 564, DateTimeKind.Utc).AddTicks(6681));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "PCard",
                table: "Events",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "44546e06-8719-4ad8-b88a-f271ae9d6eab",
                column: "ConcurrencyStamp",
                value: "a77b0b85-dce5-4740-8765-4dc961db2c57");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b62472e-4f66-49fa-a20f-e7685b9565d8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "7eaa7bb8-d2e7-4df5-b021-1b80c6855005", "AQAAAAEAACcQAAAAEKSAHsm55ZkLtE3mTSyXlazhL8AHD2mCEQhhHwYwP6sXKJWDLurP78ROrhgzfRB+cg==" });

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("2863fe2b-ddb9-4a7a-a74d-5fb64be349de"),
                column: "DateAdded",
                value: new DateTime(2022, 12, 4, 17, 19, 49, 169, DateTimeKind.Utc).AddTicks(1680));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("4aa76a4c-c59d-409a-84c1-06e6487a137a"),
                column: "DateAdded",
                value: new DateTime(2022, 12, 4, 17, 19, 49, 169, DateTimeKind.Utc).AddTicks(1673));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("63dc8fa6-07ae-4391-8916-e057f71239ce"),
                column: "DateAdded",
                value: new DateTime(2022, 12, 4, 17, 19, 49, 169, DateTimeKind.Utc).AddTicks(1644));

            migrationBuilder.UpdateData(
                table: "TextFields",
                keyColumn: "Id",
                keyValue: new Guid("70bf165a-700a-4156-91c0-e83fce0a277f"),
                column: "DateAdded",
                value: new DateTime(2022, 12, 4, 17, 19, 49, 169, DateTimeKind.Utc).AddTicks(1664));
        }
    }
}
