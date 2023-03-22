using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace aspFinal.Migrations
{
    public partial class updatedCartablemillagedatatypetointfromdecimal : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Millage",
                table: "Cars",
                nullable: false,
                oldClrType: typeof(decimal));

            migrationBuilder.UpdateData(
                table: "Advertisements",
                keyColumn: "Id",
                keyValue: 1,
                column: "CurrentDate",
                value: new DateTime(2019, 8, 10, 4, 2, 48, 597, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Advertisements",
                keyColumn: "Id",
                keyValue: 2,
                column: "CurrentDate",
                value: new DateTime(2019, 8, 10, 4, 2, 48, 598, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Advertisements",
                keyColumn: "Id",
                keyValue: 3,
                column: "CurrentDate",
                value: new DateTime(2019, 8, 10, 4, 2, 48, 598, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Advertisements",
                keyColumn: "Id",
                keyValue: 4,
                column: "CurrentDate",
                value: new DateTime(2019, 8, 10, 4, 2, 48, 598, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Advertisements",
                keyColumn: "Id",
                keyValue: 5,
                column: "CurrentDate",
                value: new DateTime(2019, 8, 10, 4, 2, 48, 598, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Advertisements",
                keyColumn: "Id",
                keyValue: 6,
                column: "CurrentDate",
                value: new DateTime(2019, 8, 10, 4, 2, 48, 598, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Advertisements",
                keyColumn: "Id",
                keyValue: 7,
                column: "CurrentDate",
                value: new DateTime(2019, 8, 10, 4, 2, 48, 598, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Advertisements",
                keyColumn: "Id",
                keyValue: 8,
                column: "CurrentDate",
                value: new DateTime(2019, 8, 10, 4, 2, 48, 598, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 1,
                column: "Millage",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 2,
                column: "Millage",
                value: 146000);

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 3,
                column: "Millage",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 4,
                column: "Millage",
                value: 146000);

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 5,
                column: "Millage",
                value: 250000);

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 6,
                column: "Millage",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 7,
                column: "Millage",
                value: 154456);

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 8,
                column: "Millage",
                value: 146000);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Millage",
                table: "Cars",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.UpdateData(
                table: "Advertisements",
                keyColumn: "Id",
                keyValue: 1,
                column: "CurrentDate",
                value: new DateTime(2019, 8, 10, 3, 41, 15, 642, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Advertisements",
                keyColumn: "Id",
                keyValue: 2,
                column: "CurrentDate",
                value: new DateTime(2019, 8, 10, 3, 41, 15, 643, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Advertisements",
                keyColumn: "Id",
                keyValue: 3,
                column: "CurrentDate",
                value: new DateTime(2019, 8, 10, 3, 41, 15, 643, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Advertisements",
                keyColumn: "Id",
                keyValue: 4,
                column: "CurrentDate",
                value: new DateTime(2019, 8, 10, 3, 41, 15, 643, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Advertisements",
                keyColumn: "Id",
                keyValue: 5,
                column: "CurrentDate",
                value: new DateTime(2019, 8, 10, 3, 41, 15, 643, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Advertisements",
                keyColumn: "Id",
                keyValue: 6,
                column: "CurrentDate",
                value: new DateTime(2019, 8, 10, 3, 41, 15, 643, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Advertisements",
                keyColumn: "Id",
                keyValue: 7,
                column: "CurrentDate",
                value: new DateTime(2019, 8, 10, 3, 41, 15, 643, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Advertisements",
                keyColumn: "Id",
                keyValue: 8,
                column: "CurrentDate",
                value: new DateTime(2019, 8, 10, 3, 41, 15, 643, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 1,
                column: "Millage",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 2,
                column: "Millage",
                value: 146000m);

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 3,
                column: "Millage",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 4,
                column: "Millage",
                value: 146000m);

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 5,
                column: "Millage",
                value: 250000m);

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 6,
                column: "Millage",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 7,
                column: "Millage",
                value: 154456m);

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 8,
                column: "Millage",
                value: 146000m);
        }
    }
}
